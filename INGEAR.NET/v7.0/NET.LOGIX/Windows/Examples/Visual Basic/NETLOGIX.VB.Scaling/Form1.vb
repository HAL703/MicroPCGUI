Imports Logix
Public Class Form1

    ' * instance of Controller class
    Dim MyPLC As New Controller

    ' * instance of Tag class
    Dim MyTag As New Tag

    Private Sub SetScalingParameters()

        Dim minRaw As Double
        Dim maxRaw As Double
        Dim minScaled As Double
        Dim maxScaled As Double
        Dim conversionType As Logix.Tag.CONVERSION

        '* set tag name
        MyTag.Name = tagName.Text

        '* set scaling parameters
        minRaw = Convert.ToDouble(rawMin.Text)
        maxRaw = Convert.ToDouble(rawMax.Text)
        minScaled = Convert.ToDouble(scaledMin.Text)
        maxScaled = Convert.ToDouble(scaledMax.Text)

        '* set scaling type
        conversionType = Logix.Tag.CONVERSION.Linear

        If btnSquareRoot.Checked = True Then
            conversionType = Logix.Tag.CONVERSION.SquareRoot
        End If

        '* apply scaling to the tag
        MyTag.ScaleValue(conversionType, minRaw, maxRaw, minScaled, maxScaled)

    End Sub


    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        Try
            SetScalingParameters()

            If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString)
                End If
                Return
            End If

            scaledValue.Text = MyTag.Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click

        Try
            MyTag.Value = scaledValue.Text

            If MyPLC.WriteTag(MyTag) <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        '* connect to PLC
        Try
            MyPLC.IPAddress = ipAddress.Text
            MyPLC.Path = path.Text
            If btnMicro850.Checked = True Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If
            If MyPLC.Connect() <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        MyPLC.Disconnect()
    End Sub
End Class
