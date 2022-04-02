Imports System.Net
Imports Logix

Public Class Form1

    ' create instance of Peer Message class
    Dim WithEvents peerMsg As New PeerMessage

    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click

        Try
            ' *******************************
            ' * if we want to listen on any NIC on our machine, 
            ' * set PeerMessage.IPAddressNIC = ""
            ' *
            ' *
            ' * if we want to listen for messages on a 
            ' * specific NIC then set PeerMessage.IPAddressNIC to the 
            ' * IP Address assigned to the NIC
            ' *
            If "Any" = ipList.Text Then
                peerMsg.IPAddressNIC = ""
            Else
                peerMsg.IPAddressNIC = ipList.Text
            End If


            ' **************************************
            ' * there are 2 types of ethernet protocol messages
            ' * CIP (Control and Information Protocol) for newer CPU's
            ' * CSP (Client Server Protocol) for legacy PLC-5 & SLC 5/05
            ' * 
            If 0 = msgType.SelectedIndex Then
                peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP
            Else
                peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CSP
            End If

            ' *****************************************
            ' * just call Listen
            peerMsg.Listen()

            ' *
            ' * disable some of the buttons
            ' *
            btnListen.Enabled = False
            ipList.Enabled = False
            msgType.Enabled = False
            btnShutdown.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Delegate Sub MsgReceivedDelegate()

    Private Sub peerMsg_Received(ByVal sender As Object, ByVal e As System.EventArgs) Handles peerMsg.Received

        ' ******************************************
        ' * since Received event is generated in a different thread
        ' * than the UI we'll need a delegate
        If InvokeRequired = True Then
            Dim newDelegate As New MsgReceivedDelegate(AddressOf MsgReceived)
            Invoke(newDelegate)
        Else
            MsgReceived()
        End If

    End Sub

    Private Sub MsgReceived()

        Dim msgItem As ListViewItem

        msgItem = listView.Items.Add(New ListViewItem(peerMsg.IPSender))

        msgItem.SubItems.Add(peerMsg.Timestamp.ToString())

        msgItem.SubItems.Add(peerMsg.Length.ToString())

        msgItem.SubItems.Add(peerMsg.ItemName)

        msgItem.SubItems.Add(peerMsg.NetType.ToString())

        msgItem.SubItems.Add(ItemValues())

    End Sub

    Private Function ItemValues() As String

        Dim rtnVal As String
        Dim dataArray As Array
        Dim I As Integer

        rtnVal = ""

        If peerMsg.Length = 1 Then
            rtnVal = peerMsg.Value.ToString()
        Else
            dataArray = peerMsg.Value
            For I = 0 To dataArray.Length - 1
                rtnVal = rtnVal + dataArray.GetValue(I).ToString() + ","
            Next
        End If

        ItemValues = rtnVal

    End Function

  
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listView.View = View.Details
        listView.Columns.Add("Sender IP", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Timestamp", 100, HorizontalAlignment.Left)
        listView.Columns.Add("Items", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Name/Address", 100, HorizontalAlignment.Left)
        listView.Columns.Add("Type", 75, HorizontalAlignment.Left)
        listView.Columns.Add("Values", 140, HorizontalAlignment.Left)

        ' *
        ' * provide a list of ip addresses on this 
        ' * machine
        EnumLocalIPAddresses()
        ipList.SelectedIndex = 0
        msgType.SelectedIndex = 0

    End Sub

    Private Sub EnumLocalIPAddresses()
        Dim ip_hostEntry As IPHostEntry
        Dim ip_Address As IPAddress

        Try
            '*
            '* Find host by name
            '*
            ip_hostEntry = Dns.GetHostEntry(Dns.GetHostName())

            '*
            '* populate ipList box with addresses
            For Each ip_Address In ip_hostEntry.AddressList
                ipList.Items.Add(ip_Address.ToString())
            Next

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
