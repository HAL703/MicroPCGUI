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
        Me.lblTypeCode = New System.Windows.Forms.Label()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.structTypes = New System.Windows.Forms.GroupBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnSTRUCT_D = New System.Windows.Forms.RadioButton()
        Me.btnSTRUCT_C = New System.Windows.Forms.RadioButton()
        Me.btnSTRUCT_B = New System.Windows.Forms.RadioButton()
        Me.btnSTRUCT_A = New System.Windows.Forms.RadioButton()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me._cipPath = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._ipAddress = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.structTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTypeCode
        '
        Me.lblTypeCode.Location = New System.Drawing.Point(294, 313)
        Me.lblTypeCode.Name = "lblTypeCode"
        Me.lblTypeCode.Size = New System.Drawing.Size(247, 19)
        Me.lblTypeCode.TabIndex = 17
        Me.lblTypeCode.Text = "Type Code = "
        '
        'treeView1
        '
        Me.treeView1.Location = New System.Drawing.Point(291, 15)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Size = New System.Drawing.Size(250, 295)
        Me.treeView1.TabIndex = 16
        '
        'structTypes
        '
        Me.structTypes.Controls.Add(Me.btnRead)
        Me.structTypes.Controls.Add(Me.btnSTRUCT_D)
        Me.structTypes.Controls.Add(Me.btnSTRUCT_C)
        Me.structTypes.Controls.Add(Me.btnSTRUCT_B)
        Me.structTypes.Controls.Add(Me.btnSTRUCT_A)
        Me.structTypes.Enabled = False
        Me.structTypes.Location = New System.Drawing.Point(1, 84)
        Me.structTypes.Name = "structTypes"
        Me.structTypes.Size = New System.Drawing.Size(284, 116)
        Me.structTypes.TabIndex = 15
        Me.structTypes.TabStop = False
        Me.structTypes.Text = "Select User Defined Type"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(74, 80)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(128, 31)
        Me.btnRead.TabIndex = 8
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnSTRUCT_D
        '
        Me.btnSTRUCT_D.AutoSize = True
        Me.btnSTRUCT_D.Location = New System.Drawing.Point(176, 44)
        Me.btnSTRUCT_D.Name = "btnSTRUCT_D"
        Me.btnSTRUCT_D.Size = New System.Drawing.Size(83, 17)
        Me.btnSTRUCT_D.TabIndex = 3
        Me.btnSTRUCT_D.TabStop = True
        Me.btnSTRUCT_D.Text = "STRUCT_D"
        Me.btnSTRUCT_D.UseVisualStyleBackColor = True
        '
        'btnSTRUCT_C
        '
        Me.btnSTRUCT_C.AutoSize = True
        Me.btnSTRUCT_C.Location = New System.Drawing.Point(176, 19)
        Me.btnSTRUCT_C.Name = "btnSTRUCT_C"
        Me.btnSTRUCT_C.Size = New System.Drawing.Size(82, 17)
        Me.btnSTRUCT_C.TabIndex = 2
        Me.btnSTRUCT_C.TabStop = True
        Me.btnSTRUCT_C.Text = "STRUCT_C"
        Me.btnSTRUCT_C.UseVisualStyleBackColor = True
        '
        'btnSTRUCT_B
        '
        Me.btnSTRUCT_B.AutoSize = True
        Me.btnSTRUCT_B.Location = New System.Drawing.Point(15, 42)
        Me.btnSTRUCT_B.Name = "btnSTRUCT_B"
        Me.btnSTRUCT_B.Size = New System.Drawing.Size(82, 17)
        Me.btnSTRUCT_B.TabIndex = 1
        Me.btnSTRUCT_B.TabStop = True
        Me.btnSTRUCT_B.Text = "STRUCT_B"
        Me.btnSTRUCT_B.UseVisualStyleBackColor = True
        '
        'btnSTRUCT_A
        '
        Me.btnSTRUCT_A.AutoSize = True
        Me.btnSTRUCT_A.Location = New System.Drawing.Point(15, 19)
        Me.btnSTRUCT_A.Name = "btnSTRUCT_A"
        Me.btnSTRUCT_A.Size = New System.Drawing.Size(82, 17)
        Me.btnSTRUCT_A.TabIndex = 0
        Me.btnSTRUCT_A.TabStop = True
        Me.btnSTRUCT_A.Text = "STRUCT_A"
        Me.btnSTRUCT_A.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(191, 42)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(94, 27)
        Me.btnDisconnect.TabIndex = 14
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(191, 12)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(94, 27)
        Me.btnConnect.TabIndex = 13
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        '_cipPath
        '
        Me._cipPath.Location = New System.Drawing.Point(65, 42)
        Me._cipPath.Name = "_cipPath"
        Me._cipPath.Size = New System.Drawing.Size(106, 20)
        Me._cipPath.TabIndex = 12
        Me._cipPath.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 45)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "CIP Path"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_ipAddress
        '
        Me._ipAddress.Location = New System.Drawing.Point(65, 14)
        Me._ipAddress.Name = "_ipAddress"
        Me._ipAddress.Size = New System.Drawing.Size(106, 20)
        Me._ipAddress.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(-1, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "IP Address"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtHelp
        '
        Me.txtHelp.BackColor = System.Drawing.Color.White
        Me.txtHelp.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelp.Location = New System.Drawing.Point(6, 210)
        Me.txtHelp.Multiline = True
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.ReadOnly = True
        Me.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHelp.Size = New System.Drawing.Size(278, 103)
        Me.txtHelp.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 336)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.lblTypeCode)
        Me.Controls.Add(Me.treeView1)
        Me.Controls.Add(Me.structTypes)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me._cipPath)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._ipAddress)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NETLOGIX User Defined Data Type Read (VB.NET Example)"
        Me.structTypes.ResumeLayout(False)
        Me.structTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTypeCode As System.Windows.Forms.Label
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private WithEvents structTypes As System.Windows.Forms.GroupBox
    Private WithEvents btnRead As System.Windows.Forms.Button
    Private WithEvents btnSTRUCT_D As System.Windows.Forms.RadioButton
    Private WithEvents btnSTRUCT_C As System.Windows.Forms.RadioButton
    Private WithEvents btnSTRUCT_B As System.Windows.Forms.RadioButton
    Private WithEvents btnSTRUCT_A As System.Windows.Forms.RadioButton
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents _cipPath As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _ipAddress As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents txtHelp As System.Windows.Forms.TextBox

End Class
