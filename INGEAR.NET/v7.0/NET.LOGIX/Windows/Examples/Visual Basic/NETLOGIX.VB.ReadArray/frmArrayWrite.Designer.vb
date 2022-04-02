<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayWrite
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dataList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(183, 156)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(78, 31)
        Me.btnWrite.TabIndex = 10
        Me.btnWrite.Text = "Write Array"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(183, 193)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 31)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFill
        '
        Me.btnFill.Location = New System.Drawing.Point(182, 52)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(78, 31)
        Me.btnFill.TabIndex = 8
        Me.btnFill.Text = "Fill Array..."
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(183, 15)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 31)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit Value..."
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dataList
        '
        Me.dataList.FormattingEnabled = True
        Me.dataList.Location = New System.Drawing.Point(12, 12)
        Me.dataList.Name = "dataList"
        Me.dataList.Size = New System.Drawing.Size(164, 212)
        Me.dataList.TabIndex = 6
        '
        'frmArrayWrite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dataList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArrayWrite"
        Me.Text = "Array Write"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnWrite As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnFill As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents dataList As System.Windows.Forms.ListBox
End Class
