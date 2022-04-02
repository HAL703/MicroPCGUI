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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.btnStartScan = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(51, 262)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(299, 19)
        Me.label8.TabIndex = 29
        Me.label8.Text = "Discrete Values"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label7
        '
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(51, 131)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(299, 19)
        Me.label7.TabIndex = 28
        Me.label7.Text = "Analog Values"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(42, 346)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(361, 50)
        Me.label6.TabIndex = 27
        Me.label6.Text = "Click Button1 to write a Boolean value.  The Button.Text, ForeGround and BackGrou" & _
    "nd colors will change.  Label5.Text and .Image will change with value."
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.label5.ImageList = Me.ImageList1
        Me.label5.Location = New System.Drawing.Point(158, 284)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(152, 50)
        Me.label5.TabIndex = 26
        Me.label5.Text = "label5"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "red.ico")
        Me.ImageList1.Images.SetKeyName(1, "green.ico")
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(42, 284)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(110, 50)
        Me.button1.TabIndex = 25
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(189, 150)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(193, 92)
        Me.label4.TabIndex = 24
        Me.label4.Text = resources.GetString("label4.Text")
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Underline)
        Me.label3.Location = New System.Drawing.Point(51, 55)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(299, 22)
        Me.label3.TabIndex = 23
        Me.label3.Text = "To begin, click Connect then Start Scanning"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStopScan
        '
        Me.btnStopScan.Location = New System.Drawing.Point(230, 80)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(80, 40)
        Me.btnStopScan.TabIndex = 22
        Me.btnStopScan.Text = "Stop Scanning"
        Me.btnStopScan.UseVisualStyleBackColor = True
        '
        'btnStartScan
        '
        Me.btnStartScan.Location = New System.Drawing.Point(108, 80)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.Size = New System.Drawing.Size(80, 40)
        Me.btnStartScan.TabIndex = 21
        Me.btnStartScan.Text = "Start Scanning"
        Me.btnStartScan.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(315, 80)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(80, 40)
        Me.btnDisconnect.TabIndex = 20
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(24, 80)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(80, 40)
        Me.btnConnect.TabIndex = 19
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Black
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(45, 155)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 31)
        Me.label2.TabIndex = 18
        Me.label2.Text = "0000"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(24, 192)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(149, 25)
        Me.progressBar1.TabIndex = 17
        '
        'trackBar1
        '
        Me.trackBar1.Location = New System.Drawing.Point(14, 222)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(169, 45)
        Me.trackBar1.TabIndex = 16
        Me.trackBar1.TickFrequency = 5
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(5, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(419, 30)
        Me.label1.TabIndex = 15
        Me.label1.Text = "This example demonstrates linking Windows Form Controls to NET.LOGIX Tag classes," & _
    " TagGroup scanning and Tag data simulation. "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 406)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnStopScan)
        Me.Controls.Add(Me.btnStartScan)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.trackBar1)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET LOGIX  Form Controls VB.NET"
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnStopScan As System.Windows.Forms.Button
    Private WithEvents btnStartScan As System.Windows.Forms.Button
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
