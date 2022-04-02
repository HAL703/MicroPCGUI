' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
Imports Logix
Imports Windows.UI.Popups

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Dim WithEvents CIPMsg As New PeerMessage
    Dim messagCount As Integer
    Dim WithEvents UITimer As New Windows.UI.Xaml.DispatcherTimer

    Dim valSINT As String = "0"
    Dim valINT As String = "0"
    Dim valDINT As String = "0"
    Dim valREAL As String = "0.0"

    ''' <summary>
    ''' This starts the CIP Server
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnListen_Click(sender As Object, e As RoutedEventArgs) Handles BtnListen.Click

        Try
            CIPMsg.Listen(Convert.ToInt32(TxtIPPort.Text))
            UITimer.Interval = TimeSpan.FromMilliseconds(100)
            UITimer.Start()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' This shuts down CIP Server
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnShutown_Click(sender As Object, e As RoutedEventArgs) Handles BtnShutdown.Click
        CIPMsg.ShutDown()
        UITimer.Stop()
    End Sub

    ''' <summary>
    ''' This scans the UI current values
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UITimer_Tick(sender As Object, e As Object) Handles UITimer.Tick
        valSINT = TxtSINT.Text
        valINT = TxtINT.Text
        valDINT = TxtDINT.Text
        valREAL = TxtREAL.Text
    End Sub
    ''' <summary>
    ''' This event fires when a CIP Write Command (Service 0x4d) is received
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub CIP_Received(sender As PeerMessage, e As MessageEventArgs) Handles CIPMsg.Received
        messagCount += 1
        Dim success As Boolean = False

        '' process the message
        Select Case e.ItemName.ToUpper()
            Case "TAGSINT"
                If e.NetType = TypeCode.Byte Then
                    success = True
                End If
            Case "TAGINT"
                If e.NetType = TypeCode.Int16 Then
                    success = True
                End If

            Case "TAGDINT"
                If e.NetType = TypeCode.Int32 Then
                    success = True
                End If
            Case "TAGREAL"
                If e.NetType = TypeCode.Single Then
                    success = True
                End If
        End Select
        If success = True Then
            sender.MessageReply(PeerMessage.MSG_ER.SUCCESS)
        Else
            sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST)
        End If

        '' update the UI
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High,
             Sub()
                 TxtCipCommand.Text = "CIP Write Command (Service 0x4d)"
                 TxtSenderIP.Text = e.IPSender
                 TxtSymbolicName.Text = e.ItemName
                 TxtTimestamp.Text = e.Timestamp.ToString()
                 TxtMsgCount.Text = messagCount.ToString()
                 If success = True Then
                     Select Case e.ItemName.ToUpper()
                         Case "TAGSINT"
                             TxtSINT.Text = sender.Value.ToString()
                         Case "TAGINT"
                             TxtINT.Text = sender.Value.ToString()
                         Case "TAGDINT"
                             TxtDINT.Text = sender.Value.ToString()
                         Case "TAGREAL"
                             TxtREAL.Text = sender.Value.ToString()
                     End Select
                 End If

             End Sub)

    End Sub

    ''' <summary>
    ''' this event is fired when CIP Read Command (Service 0x4c) is received
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub CIP_Request(sender As PeerMessage, e As MessageEventArgs) Handles CIPMsg.Request
        messagCount += 1
        '' process the message
        Select Case e.ItemName.ToUpper()
            Case "TAGSINT"
                sender.MessageReply(Convert.ToSByte(valSINT))
            Case "TAGINT"
                sender.MessageReply(Convert.ToInt16(valINT))
            Case "TAGDINT"
                sender.MessageReply(Convert.ToInt32(valDINT))
            Case "TAGREAL"
                sender.MessageReply(Convert.ToSingle(valREAL))
            Case Else
                sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST)
        End Select

        '' update the UI
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High,
                 Sub()
                     TxtCipCommand.Text = "CIP Read Command (Service 0x4c)"
                     TxtSenderIP.Text = e.IPSender
                     TxtSymbolicName.Text = e.ItemName
                     TxtTimestamp.Text = e.Timestamp.ToString()
                     TxtMsgCount.Text = messagCount.ToString()
                 End Sub)
    End Sub


End Class
