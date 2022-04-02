Public Class frmArrayWrite

    Public dataArray As System.Array
    Public dataType As System.TypeCode
    Dim i As Integer

    Dim newValue As New frmNewValue

    Private Sub frmArrayWrite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load the list box with with values
        Try
            dataList.Items.Clear()
            For i = 0 To dataArray.Length - 1
                dataList.Items.Add(dataArray.GetValue(i).ToString())
            Next
            dataList.SelectedIndex = 0
        Catch ex As System.Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub setValue(writeValue As String, index As Integer)

        Dim dataValue As Object = Nothing

        Try

            ' ////////////////////////////////
            '// convert txt value to appropriate
            '// data type for tag
            Select Case (dataType)

                Case System.TypeCode.Boolean
                    If writeValue.ToUpper() = "FALSE" Or writeValue.ToUpper() = "OFF" Or writeValue = "0" Then
                        dataValue = False
                    Else
                        dataValue = True
                    End If


                Case System.TypeCode.SByte
                    dataValue = Convert.ToSByte(writeValue)

                Case System.TypeCode.Byte
                    dataValue = Convert.ToByte(writeValue)

                Case System.TypeCode.Int16
                    dataValue = Convert.ToInt16(writeValue)

                Case System.TypeCode.UInt16
                    dataValue = Convert.ToUInt16(writeValue)

                Case System.TypeCode.Int32
                    dataValue = Convert.ToInt32(writeValue)

                Case System.TypeCode.UInt32
                    dataValue = Convert.ToUInt32(writeValue)

                Case System.TypeCode.Int64
                    dataValue = Convert.ToInt64(writeValue)

                Case System.TypeCode.UInt64
                    dataValue = Convert.ToUInt64(writeValue)

                Case System.TypeCode.Single
                    dataValue = Convert.ToSingle(writeValue)

                Case System.TypeCode.Double
                    dataValue = Convert.ToSingle(writeValue)

                Case System.TypeCode.String
                    dataValue = writeValue.ToString()
            End Select

            dataList.Items(index) = dataValue
            dataArray.SetValue(dataValue, index)

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        newValue.value = dataArray.GetValue(dataList.SelectedIndex).ToString()
        If DialogResult.Cancel = newValue.ShowDialog() Then
            Return
        End If
        setValue(newValue.value, dataList.SelectedIndex)
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click

        If DialogResult.Cancel = newValue.ShowDialog() Then
            Return
        End If

        For i = 0 To dataArray.Length - 1
            setValue(newValue.value, i)
        Next

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class