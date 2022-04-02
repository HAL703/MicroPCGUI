Imports System.Net
Imports Logix

Public Class Form1

    ' *********************************
    ' * instance of NETLOGIX.PeerMessageClass with
    ' * event handler
    Dim WithEvents peerMsg As New PeerMessage()
    Dim msgCount As Int32

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '* **********************************
        '* * add colums to list view
        '* *
        listView.View = View.Details
        listView.Columns.Add("Sender IP", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Timestamp", 100, HorizontalAlignment.Left)
        listView.Columns.Add("Items", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Name/Address", 100, HorizontalAlignment.Left)
        listView.Columns.Add("Type", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Values", 140, HorizontalAlignment.Left)

        '*
        '* provide a list of ip addresses on this 
        '* machine
        EnumLocalIPAddresses()
        ipList.SelectedIndex = 0
        msgType.SelectedIndex = 0

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

        Dim msgItem As ListViewItem

        ' to reject this message pass one of the errors
        ' sender.MessageReply(PeerMessage.MSG_ER.TAG_ACCESS_DENIED);
        ' sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
        ' sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR);
        ' return;

        ' e.IPAddressNIC - IP address of network interface to that received message
        ' e.IPSender - IP address of device that sent message
        ' e.ItemName - symbolic item name or data table address
        ' e.Length - number of items 
        ' e.NetType - data type of value
        ' e.Timestamp - Date & Time message was received
        ' e.Value - data delivered in message

        msgCount = msgCount + 1

        If (listView.Items.Count > 50) Then
            listView.Items.Clear()
        End If

        msgItem = listView.Items.Add(e.IPSender)

        msgItem.SubItems.Add(e.Timestamp.ToString("hh:mm:ss.fff"))

        msgItem.SubItems.Add(e.Length.ToString())

        msgItem.SubItems.Add(e.ItemName)

        msgItem.SubItems.Add(e.NetType.ToString())

        msgItem.SubItems.Add(ItemValues(e))

        lblMsgCount.Text = msgCount.ToString()

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

        ' e.IPAddressNIC - IP address of network interface to that received message
        ' e.IPSender - IP address of device that sent message
        ' e.ItemName - symbolic item name or data table address
        ' e.Length - number of items requested
        ' e.NetType - N/A
        ' e.Timestamp - Date & Time message was received
        ' e.Value - null/empty, user code will supply value in MessageReply (see below)

        ' to reject this message pass one of the errors
        ' sender.MessageReply(PeerMessage.MSG_ER.TAG_ACCESS_DENIED);
        ' sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
        ' sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR);
        ' return;


        ' to return a SINT value
        ' sbyte value = 123;
        ' sender.MessageReply(value);

        ' to return a INT value
        ' Int16 value = 4567;
        ' sender.MessageReply(value);

        ' to return a DINT value
        ' Int32 value = 12345657;
        ' sender.MessageReply(value);

        ' to return a REAL value
        ' Single value = 123.4567;
        ' sender.MessageReply(value);


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

            ' * set the message type to listen for
            If msgType.SelectedIndex = 0 Then
                peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP
            Else
                peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CSP
            End If

            peerMsg.Listen()
            btnListen.Enabled = False
            btnShutdown.Enabled = True
            ipList.Enabled = False
            msgType.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click

        peerMsg.ShutDown()
        btnListen.Enabled = True
        btnShutdown.Enabled = False
        ipList.Enabled = True
        msgType.Enabled = True

    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click

        listView.Items.Clear()

    End Sub

   
End Class
