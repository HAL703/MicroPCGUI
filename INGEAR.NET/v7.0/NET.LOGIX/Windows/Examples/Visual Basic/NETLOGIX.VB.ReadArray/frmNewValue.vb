Public Class frmNewValue

    Public value As String

    Private Sub frmNewValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editValue.Text = value
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        value = editValue.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class