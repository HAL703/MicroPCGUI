' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.UI.Popups
Imports Logix

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>

Public NotInheritable Class MainPage
    Inherits Page
    Dim MyPLC As New Controller
    Dim MyTag As Tag

    Private Async Sub BtnConnect_Click(sender As Object, e As RoutedEventArgs) Handles BtnConnect.Click
        If BtnMicro.IsChecked Then
            MyPLC.CPUType = Controller.CPU.MICRO
        Else
            MyPLC.CPUType = Controller.CPU.LOGIX
        End If

        MyPLC.IPAddress = TxtIPAddr.Text
        MyPLC.Path = TxtCIPPath.Text

        If MyPLC.Connect() <> ResultCode.E_SUCCESS Then
            BtnWrite.IsEnabled = False
            BtnRead.IsEnabled = False
            Dim msg As New MessageDialog(MyPLC.ErrorString, "NET.LOGIX.UWP Error")
            Await msg.ShowAsync()
            Return
        End If
        BtnRead.IsEnabled = True

    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As RoutedEventArgs) Handles BtnDisconnect.Click

        MyPLC.Disconnect()
        BtnRead.IsEnabled = False
        BtnWrite.IsEnabled = False

    End Sub

    Private Async Sub BtnRead_Click(sender As Object, e As RoutedEventArgs) Handles BtnRead.Click

        BtnWrite.IsEnabled = False

        MyTag = New Tag(TxtTagName.Text)

        If BtnBoolArray.IsChecked Then
            MyTag.NetType = GetType(System.Boolean)
        ElseIf BtnString.IsChecked Then
            MyTag.NetType = GetType(System.String)
        End If

        If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
            LblQual.Text = MyTag.QualityString
            Dim msg As New MessageDialog(MyPLC.ErrorString, "NET.LOGIX.UWP Error")
            Await msg.ShowAsync()
            Return
        End If
        BtnWrite.IsEnabled = True
        TxtValue.Text = MyTag.Value.ToString()
        LblQual.Text = MyTag.QualityString
        LblTimestamp.Text = MyTag.TimeStamp.ToString()

    End Sub

    Private Async Sub BtnWrite_Click(sender As Object, e As RoutedEventArgs) Handles BtnWrite.Click
        MyTag.Value = TxtValue.Text
        If MyPLC.WriteTag(MyTag) <> ResultCode.E_SUCCESS Then
            LblQual.Text = MyTag.QualityString
            Dim msg As New MessageDialog(MyPLC.ErrorString, "NET.LOGIX.UWP Error")
            Await msg.ShowAsync()
            Return
        End If
        LblQual.Text = MyTag.QualityString
        LblTimestamp.Text = MyTag.TimeStamp.ToString()
    End Sub
End Class
