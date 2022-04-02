<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bpSlots = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ipAddr = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'bpSlots
        '
        Me.bpSlots.Location = New System.Drawing.Point(100, 66)
        Me.bpSlots.Name = "bpSlots"
        Me.bpSlots.Size = New System.Drawing.Size(34, 20)
        Me.bpSlots.TabIndex = 19
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 69)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(84, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Backplane Slots"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(215, 68)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 17
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(215, 37)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 16
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(215, 8)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 15
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(77, 36)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(100, 20)
        Me.path.TabIndex = 14
        Me.path.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(11, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Path"
        '
        'ipAddr
        '
        Me.ipAddr.Location = New System.Drawing.Point(77, 10)
        Me.ipAddr.Name = "ipAddr"
        Me.ipAddr.Size = New System.Drawing.Size(100, 20)
        Me.ipAddr.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "IP Address"
        '
        'treeView1
        '
        Me.treeView1.Location = New System.Drawing.Point(11, 101)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.ShowNodeToolTips = True
        Me.treeView1.Size = New System.Drawing.Size(276, 235)
        Me.treeView1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 344)
        Me.Controls.Add(Me.bpSlots)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ipAddr)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.treeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NETLOGIX Chassis Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bpSlots As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents path As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents ipAddr As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents treeView1 As System.Windows.Forms.TreeView

End Class
