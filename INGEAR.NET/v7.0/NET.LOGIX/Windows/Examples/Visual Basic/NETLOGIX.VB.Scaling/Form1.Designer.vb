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
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnSquareRoot = New System.Windows.Forms.RadioButton()
        Me.btnLinear = New System.Windows.Forms.RadioButton()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.scaledValue = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.scaledMax = New System.Windows.Forms.TextBox()
        Me.scaledMin = New System.Windows.Forms.TextBox()
        Me.rawMax = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.rawMin = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tagName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.btnMicro850 = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.ipAddress = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(181, 292)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(97, 23)
        Me.btnWrite.TabIndex = 16
        Me.btnWrite.Text = "Write"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(181, 263)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(97, 23)
        Me.btnRead.TabIndex = 15
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(11, 230)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(42, 13)
        Me.label9.TabIndex = 41
        Me.label9.Text = "Scaling"
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.AutoSize = True
        Me.btnSquareRoot.Location = New System.Drawing.Point(193, 227)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(85, 17)
        Me.btnSquareRoot.TabIndex = 13
        Me.btnSquareRoot.Text = "Square Root"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnLinear
        '
        Me.btnLinear.AutoSize = True
        Me.btnLinear.Checked = True
        Me.btnLinear.Location = New System.Drawing.Point(72, 227)
        Me.btnLinear.Name = "btnLinear"
        Me.btnLinear.Size = New System.Drawing.Size(54, 17)
        Me.btnLinear.TabIndex = 12
        Me.btnLinear.TabStop = True
        Me.btnLinear.Text = "Linear"
        Me.btnLinear.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(11, 195)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(55, 13)
        Me.label8.TabIndex = 38
        Me.label8.Text = "Scales To"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(178, 150)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(51, 13)
        Me.label7.TabIndex = 37
        Me.label7.Text = "Maximum"
        '
        'scaledValue
        '
        Me.scaledValue.Location = New System.Drawing.Point(72, 263)
        Me.scaledValue.Name = "scaledValue"
        Me.scaledValue.Size = New System.Drawing.Size(100, 20)
        Me.scaledValue.TabIndex = 14
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(11, 267)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(34, 13)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Value"
        '
        'scaledMax
        '
        Me.scaledMax.Location = New System.Drawing.Point(178, 191)
        Me.scaledMax.Name = "scaledMax"
        Me.scaledMax.Size = New System.Drawing.Size(100, 20)
        Me.scaledMax.TabIndex = 11
        '
        'scaledMin
        '
        Me.scaledMin.Location = New System.Drawing.Point(72, 191)
        Me.scaledMin.Name = "scaledMin"
        Me.scaledMin.Size = New System.Drawing.Size(100, 20)
        Me.scaledMin.TabIndex = 10
        '
        'rawMax
        '
        Me.rawMax.Location = New System.Drawing.Point(178, 166)
        Me.rawMax.Name = "rawMax"
        Me.rawMax.Size = New System.Drawing.Size(100, 20)
        Me.rawMax.TabIndex = 9
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(69, 150)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 13)
        Me.label5.TabIndex = 31
        Me.label5.Text = "Minimum"
        '
        'rawMin
        '
        Me.rawMin.Location = New System.Drawing.Point(72, 166)
        Me.rawMin.Name = "rawMin"
        Me.rawMin.Size = New System.Drawing.Size(100, 20)
        Me.rawMin.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(11, 170)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(59, 13)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Raw Value"
        '
        'tagName
        '
        Me.tagName.Location = New System.Drawing.Point(72, 114)
        Me.tagName.Name = "tagName"
        Me.tagName.Size = New System.Drawing.Size(206, 20)
        Me.tagName.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(11, 118)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(57, 13)
        Me.label3.TabIndex = 27
        Me.label3.Text = "Tag Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label10)
        Me.GroupBox1.Controls.Add(Me.btnMicro850)
        Me.GroupBox1.Controls.Add(Me.btnLogix)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.path)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.ipAddress)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 103)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(8, 22)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(56, 13)
        Me.label10.TabIndex = 0
        Me.label10.Text = "CPU Type"
        '
        'btnMicro850
        '
        Me.btnMicro850.AutoSize = True
        Me.btnMicro850.Location = New System.Drawing.Point(156, 20)
        Me.btnMicro850.Name = "btnMicro850"
        Me.btnMicro850.Size = New System.Drawing.Size(51, 17)
        Me.btnMicro850.TabIndex = 1
        Me.btnMicro850.Text = "Micro"
        Me.btnMicro850.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(79, 20)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(50, 17)
        Me.btnLogix.TabIndex = 0
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "Logix"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(184, 70)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(97, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(184, 44)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(97, 23)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(79, 71)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(100, 20)
        Me.path.TabIndex = 3
        Me.path.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 75)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 46
        Me.label2.Text = "Path"
        '
        'ipAddress
        '
        Me.ipAddress.Location = New System.Drawing.Point(79, 45)
        Me.ipAddress.Name = "ipAddress"
        Me.ipAddress.Size = New System.Drawing.Size(100, 20)
        Me.ipAddress.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 13)
        Me.label1.TabIndex = 44
        Me.label1.Text = "IPAddress"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 328)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnLinear)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.scaledValue)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.scaledMax)
        Me.Controls.Add(Me.scaledMin)
        Me.Controls.Add(Me.rawMax)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.rawMin)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tagName)
        Me.Controls.Add(Me.label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX Scaling"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnWrite As System.Windows.Forms.Button
    Private WithEvents btnRead As System.Windows.Forms.Button
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents btnSquareRoot As System.Windows.Forms.RadioButton
    Private WithEvents btnLinear As System.Windows.Forms.RadioButton
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents scaledValue As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents scaledMax As System.Windows.Forms.TextBox
    Private WithEvents scaledMin As System.Windows.Forms.TextBox
    Private WithEvents rawMax As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents rawMin As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents tagName As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents btnMicro850 As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents path As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents ipAddress As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
