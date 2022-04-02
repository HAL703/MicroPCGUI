Imports System.Net
Imports Logix

Public Class Form1

    ' *********************************
    ' * instance of NETLOGIX.PeerMessageClass with
    ' * event handler
    Dim WithEvents peerMsg As New PeerMessage()
    Dim msgCount As Int32

    Dim cellIndex As Integer = 0
    Dim offset As Integer = 0

    Dim tagType As TypeCode = TypeCode.Empty

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '* **********************************
        '* * add colums to list view
        '* *
        listView.View = View.Details
        listView.Columns.Add("Sender IP", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Timestamp", 100, HorizontalAlignment.Left)
        listView.Columns.Add("Items", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Symbolic Name", 120, HorizontalAlignment.Left)
        listView.Columns.Add("Command", 120, HorizontalAlignment.Left)


        CreateServerTags()

        '*
        '* provide a list of ip addresses on this 
        '* machine
        EnumLocalIPAddresses()
        ipList.SelectedIndex = 0

    End Sub


    Private Sub EnumLocalIPAddresses()
        Dim ip_hostEntry As IPHostEntry
        Dim ip_Address As IPAddress
        Dim ipaddr As String
        Try
            '*
            '* Find host by name
            '*
            ip_hostEntry = Dns.GetHostEntry(Dns.GetHostName())

            '*
            '* populate ipList box with addresses
            For Each ip_Address In ip_hostEntry.AddressList
                ipaddr = ip_Address.ToString()
                If False = ipaddr.Contains(":") Then
                    ipList.Items.Add(ipaddr)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Public Delegate Sub MsgReceivedDelegate(ByVal sender As PeerMessage, e As MessageEventArgs)

    Private Sub peerMsg_Received(ByVal sender As PeerMessage, ByVal e As System.EventArgs) Handles peerMsg.Received

        ' ******************************************
        ' * since Received event is generated in a different thread
        ' * than the UI we'll need a delegate
        If InvokeRequired = True Then
            Dim newDelegate As New MsgReceivedDelegate(AddressOf MsgReceived)
            Invoke(newDelegate, sender, e)
        Else
            MsgReceived(sender, e)
        End If

    End Sub

    Private Sub MsgReceived(ByVal sender As PeerMessage, e As MessageEventArgs)

        Dim i As Integer

        msgCount += 1

        If (listView.Items.Count > 50) Then
            listView.Items.Clear()
        End If

        ' received data table write command
        UpdateListView(e, "CIP Data Table Write")

        ' verify tag name and data type exists
        If True = ValidateTagName(e) And tagType = e.NetType Then

            ' * single item being written
            If (e.Length = 1) Then
                dataGrid.Rows(cellIndex).Cells(0).Value = e.Value.ToString()
            Else
                ' array of items being written
                Dim data As Array = e.Value
                For i = 0 To e.Length - 1
                    dataGrid.Rows(cellIndex + i).Cells(0).Value = data.GetValue(i).ToString()
                Next
            End If
        Else
            ' * tag name did not exist in server
            sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST)
        End If


    End Sub

    Public Delegate Sub MsgRequestDelegate(ByVal sender As PeerMessage, e As MessageEventArgs)

    Private Sub peerMsg_Request(sender As PeerMessage, e As EventArgs) Handles peerMsg.Request
        ' ******************************************
        ' * since Received event is generated in a different thread
        ' * than the UI we'll need a delegate
        If InvokeRequired = True Then
            Dim newDelegate As New MsgRequestDelegate(AddressOf MsgRequest)
            Invoke(newDelegate, sender, e)
        Else
            MsgRequest(sender, e)
        End If
    End Sub


    Private Sub MsgRequest(ByVal sender As PeerMessage, e As MessageEventArgs)

        ' * read command
        UpdateListView(e, "CIP Data Table Read")

        ' * mak sure tag name exists
        If True = ValidateTagName(e) Then
            Try
                If (e.Length = 1) Then

                    ' * make sure tag type from client is same as tag type in server
                    If (tagType = TypeCode.Byte) Then
                        sender.MessageReply(Convert.ToSByte(dataGrid.Rows(cellIndex).Cells(0).Value))

                    ElseIf (tagType = TypeCode.Int16) Then
                        sender.MessageReply(Convert.ToInt16(dataGrid.Rows(cellIndex).Cells(0).Value))

                    ElseIf (tagType = TypeCode.Int32) Then
                        sender.MessageReply(Convert.ToInt32(dataGrid.Rows(cellIndex).Cells(0).Value))

                    Else
                        sender.MessageReply(Convert.ToSingle(dataGrid.Rows(cellIndex).Cells(0).Value))
                    End If
                Else

                    If (tagType = TypeCode.Int32) Then
                        Dim data(e.Length) As Integer
                        Dim i As Integer
                        For i = 0 To data.Length - 1
                            data(i) = Convert.ToInt32(dataGrid.Rows(cellIndex + 1).Cells(0).Value)
                            sender.MessageReply(data)
                        Next
                    End If

                End If

            Catch ex As System.Exception
                sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR)
                MessageBox.Show(ex.Message)
            End Try
        Else

            sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST)

        End If


    End Sub

    Private Sub UpdateListView(e As MessageEventArgs, MsgType As String)

        msgCount += 1

        If listView.Items.Count > 50 Then
            listView.Items.Clear()
        End If

        Dim msgItem As ListViewItem = listView.Items.Add(e.IPSender)
        msgItem.SubItems.Add(e.Timestamp.ToString("hh:mm:ss.fff"))

        msgItem.SubItems.Add(e.Length.ToString())

        msgItem.SubItems.Add(e.ItemName)

        msgItem.SubItems.Add(MsgType)

        lblMsgCount.Text = msgCount.ToString()

    End Sub
    Private Function ItemValues(ByVal e As MessageEventArgs) As String

        Dim rtnVal As String
        Dim dataArray As Array
        Dim I As Integer

        rtnVal = ""

        If e.Length = 1 Then
            rtnVal = e.Value.ToString()
        Else
            dataArray = e.Value
            For I = 0 To dataArray.Length - 1
                rtnVal = rtnVal + dataArray(I).ToString() + ","
            Next
        End If

        ItemValues = rtnVal

    End Function

    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click
        Try
            ' * Set th NIC selection
            If ipList.Text = "Any" Then
                peerMsg.IPAddressNIC = ""
            Else
                peerMsg.IPAddressNIC = ipList.Text
            End If

            peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP

            peerMsg.Listen(Convert.ToInt32(ipPort.Text))

            btnListen.Enabled = False
            btnShutdown.Enabled = True
            ipList.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click

        peerMsg.ShutDown()
        btnListen.Enabled = True
        btnShutdown.Enabled = False
        ipList.Enabled = True

    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click

        listView.Items.Clear()

    End Sub


    Private Sub CreateServerTags()

        dataGrid.Rows.Add("0")
        dataGrid.Rows(0).HeaderCell.Value = "tagSINT"

        dataGrid.Rows.Add("0")
        dataGrid.Rows(1).HeaderCell.Value = "tagINT"

        dataGrid.Rows.Add("0")
        dataGrid.Rows(2).HeaderCell.Value = "tagDINT"

        dataGrid.Rows.Add("0")
        dataGrid.Rows(3).HeaderCell.Value = "tagREAL"

        Dim i As Integer
        For i = 0 To 31
            dataGrid.Rows.Add("0")
            dataGrid.Rows(i + 4).HeaderCell.Value = String.Format("dintArray[{0}]", i)
        Next
    End Sub

    Private Function ValidateTagName(e As MessageEventArgs)

        Dim NameIsGood As Boolean = True
        Dim tagName As String = e.ItemName.ToUpper()

        Select tagName

            Case "TAGSINT"
                cellIndex = 0
                tagType = TypeCode.SByte

            Case "TAGINT"
                cellIndex = 1
                tagType = TypeCode.Int16

            Case "TAGDINT"
                cellIndex = 2
                tagType = TypeCode.Int32

            Case "TAGREAL"
                cellIndex = 3
                tagType = TypeCode.Single

            Case "DINTARRAY"
                cellIndex = 4
                tagType = TypeCode.Int32

            Case Else
                If tagName.Substring(0, 10) = "DINTARRAY[" Then
                    tagType = TypeCode.Int32
                    offset = Convert.ToInt32(tagName.Substring(10).Replace("]", ""))
                    cellIndex = offset + 4
                    If (offset > 32) Or (e.Length + offset > 32) Then
                        NameIsGood = False
                    End If
                Else
                    NameIsGood = False
                End If

        End Select

        Return NameIsGood

    End Function
End Class
