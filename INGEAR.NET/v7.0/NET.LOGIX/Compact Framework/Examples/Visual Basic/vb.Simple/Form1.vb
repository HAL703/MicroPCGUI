Imports Logix
Public Class vbnetcf

    Dim LogixPLC As New Controller
    Dim LogixTag As New Tag

    Private Sub vbnetcf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' *******************************
        ' * set default timeout
        LogixPLC.Timeout = 3000

        ' ********************************
        ' * set default data type
        LogixTag.DataType = Logix.Tag.ATOMIC.INT


    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Try
            ' ******************************
            ' * set PLC communication properties
            LogixPLC.IPAddress = ipAddress.Text
            LogixPLC.Path = path.Text

            ' ******************************
            ' * try to connect
            If LogixPLC.Connect() = ResultCode.E_SUCCESS Then
                btnDisconnect.Enabled = True
                btnConnect.Enabled = False
                tagProps.Enabled = True
            Else
                MessageBox.Show(LogixPLC.ErrorString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        Try
            LogixPLC.Disconnect()
            btnDisconnect.Enabled = False
            btnConnect.Enabled = True
            tagProps.Enabled = False
            results.Items.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAtomic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtomic.CheckedChanged
        LogixTag.DataType = Logix.Tag.ATOMIC.INT
    End Sub

    Private Sub btnBoolArray_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoolArray.CheckedChanged
        LogixTag.DataType = Logix.Tag.ATOMIC.BOOL
    End Sub

    Private Sub btnString_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnString.CheckedChanged
        LogixTag.DataType = Logix.Tag.ATOMIC.STRING
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        Try

            LogixTag.Name = tagName.Text
            LogixTag.Length = 1

            If LogixPLC.ReadTag(LogixTag) <> ResultCode.E_SUCCESS Then
                MessageBox.Show(LogixPLC.ErrorString)
                Exit Sub
            End If

            If LogixTag.QualityCode = ResultCode.QUAL_GOOD Then
                dataValue.Text = LogixTag.Value.ToString()
                results.Items.Add(LogixTag.TimeStamp)
                btnWrite.Enabled = True
            Else
                results.Items.Clear()
                dataValue.Text = "???"
                btnWrite.Enabled = False
                MessageBox.Show(LogixTag.ErrorString)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class
