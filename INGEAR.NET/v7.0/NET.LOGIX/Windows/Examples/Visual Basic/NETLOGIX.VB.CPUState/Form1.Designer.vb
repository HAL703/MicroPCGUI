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
        Me.Label1 = New System.Windows.Forms.Label()
        Me._ipAddress = New System.Windows.Forms.TextBox()
        Me._cipPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._btnReadState = New System.Windows.Forms.Button()
        Me._btnConnect = New System.Windows.Forms.Button()
        Me._btnDisconnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me._keySwState = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me._faultState = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me._LEDState = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me._edsFile = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me._serialNum = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me._prodCode = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me._prodType = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me._firmware = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me._model = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me._progName = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnMicroCPU = New System.Windows.Forms.RadioButton()
        Me.btnLogixCPU = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address"
        '
        '_ipAddress
        '
        Me._ipAddress.Location = New System.Drawing.Point(99, 23)
        Me._ipAddress.Name = "_ipAddress"
        Me._ipAddress.Size = New System.Drawing.Size(161, 20)
        Me._ipAddress.TabIndex = 1
        '
        '_cipPath
        '
        Me._cipPath.Location = New System.Drawing.Point(99, 49)
        Me._cipPath.Name = "_cipPath"
        Me._cipPath.Size = New System.Drawing.Size(161, 20)
        Me._cipPath.TabIndex = 3
        Me._cipPath.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CIP Path"
        '
        '_btnReadState
        '
        Me._btnReadState.Enabled = False
        Me._btnReadState.Location = New System.Drawing.Point(101, 74)
        Me._btnReadState.Name = "_btnReadState"
        Me._btnReadState.Size = New System.Drawing.Size(86, 32)
        Me._btnReadState.TabIndex = 4
        Me._btnReadState.Text = "CPU Info"
        Me._btnReadState.UseVisualStyleBackColor = True
        '
        '_btnConnect
        '
        Me._btnConnect.Location = New System.Drawing.Point(11, 74)
        Me._btnConnect.Name = "_btnConnect"
        Me._btnConnect.Size = New System.Drawing.Size(80, 32)
        Me._btnConnect.TabIndex = 5
        Me._btnConnect.Text = "Connect"
        Me._btnConnect.UseVisualStyleBackColor = True
        '
        '_btnDisconnect
        '
        Me._btnDisconnect.Enabled = False
        Me._btnDisconnect.Location = New System.Drawing.Point(197, 74)
        Me._btnDisconnect.Name = "_btnDisconnect"
        Me._btnDisconnect.Size = New System.Drawing.Size(80, 32)
        Me._btnDisconnect.TabIndex = 6
        Me._btnDisconnect.Text = "Disconnect"
        Me._btnDisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._keySwState)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me._faultState)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me._LEDState)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 131)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU State"
        '
        '_keySwState
        '
        Me._keySwState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._keySwState.Location = New System.Drawing.Point(12, 102)
        Me._keySwState.Name = "_keySwState"
        Me._keySwState.Size = New System.Drawing.Size(273, 17)
        Me._keySwState.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Key Switch Position"
        '
        '_faultState
        '
        Me._faultState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._faultState.Location = New System.Drawing.Point(12, 66)
        Me._faultState.Name = "_faultState"
        Me._faultState.Size = New System.Drawing.Size(273, 17)
        Me._faultState.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Major/Minor Faults"
        '
        '_LEDState
        '
        Me._LEDState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._LEDState.Location = New System.Drawing.Point(12, 34)
        Me._LEDState.Name = "_LEDState"
        Me._LEDState.Size = New System.Drawing.Size(273, 17)
        Me._LEDState.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "OK LED State"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label19)
        Me.groupBox2.Controls.Add(Me._edsFile)
        Me.groupBox2.Controls.Add(Me.label17)
        Me.groupBox2.Controls.Add(Me._serialNum)
        Me.groupBox2.Controls.Add(Me.label15)
        Me.groupBox2.Controls.Add(Me._prodCode)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me._prodType)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me._firmware)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me._model)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me._progName)
        Me.groupBox2.Location = New System.Drawing.Point(8, 118)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(285, 182)
        Me.groupBox2.TabIndex = 12
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "CPU Properties"
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(10, 159)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(74, 13)
        Me.label19.TabIndex = 18
        Me.label19.Text = "EDS Filename"
        '
        '_edsFile
        '
        Me._edsFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._edsFile.Location = New System.Drawing.Point(105, 160)
        Me._edsFile.Name = "_edsFile"
        Me._edsFile.Size = New System.Drawing.Size(164, 16)
        Me._edsFile.TabIndex = 17
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(10, 137)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(43, 13)
        Me.label17.TabIndex = 16
        Me.label17.Text = "Serial #"
        '
        '_serialNum
        '
        Me._serialNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._serialNum.Location = New System.Drawing.Point(105, 138)
        Me._serialNum.Name = "_serialNum"
        Me._serialNum.Size = New System.Drawing.Size(164, 16)
        Me._serialNum.TabIndex = 15
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(10, 114)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(72, 13)
        Me.label15.TabIndex = 14
        Me.label15.Text = "Product Code"
        '
        '_prodCode
        '
        Me._prodCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._prodCode.Location = New System.Drawing.Point(105, 115)
        Me._prodCode.Name = "_prodCode"
        Me._prodCode.Size = New System.Drawing.Size(164, 16)
        Me._prodCode.TabIndex = 13
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(10, 91)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(71, 13)
        Me.label13.TabIndex = 12
        Me.label13.Text = "Product Type"
        '
        '_prodType
        '
        Me._prodType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._prodType.Location = New System.Drawing.Point(105, 92)
        Me._prodType.Name = "_prodType"
        Me._prodType.Size = New System.Drawing.Size(164, 16)
        Me._prodType.TabIndex = 11
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(10, 68)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(87, 13)
        Me.label10.TabIndex = 10
        Me.label10.Text = "Firmware Version"
        '
        '_firmware
        '
        Me._firmware.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._firmware.Location = New System.Drawing.Point(105, 69)
        Me._firmware.Name = "_firmware"
        Me._firmware.Size = New System.Drawing.Size(164, 16)
        Me._firmware.TabIndex = 9
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(10, 46)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(36, 13)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Model"
        '
        '_model
        '
        Me._model.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._model.Location = New System.Drawing.Point(105, 47)
        Me._model.Name = "_model"
        Me._model.Size = New System.Drawing.Size(164, 16)
        Me._model.TabIndex = 7
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(10, 22)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(77, 13)
        Me.label7.TabIndex = 6
        Me.label7.Text = "Program Name"
        '
        '_progName
        '
        Me._progName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._progName.Location = New System.Drawing.Point(105, 23)
        Me._progName.Name = "_progName"
        Me._progName.Size = New System.Drawing.Size(164, 16)
        Me._progName.TabIndex = 1
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 5)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(56, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "CPU Type"
        '
        'btnMicroCPU
        '
        Me.btnMicroCPU.AutoSize = True
        Me.btnMicroCPU.Location = New System.Drawing.Point(159, 3)
        Me.btnMicroCPU.Name = "btnMicroCPU"
        Me.btnMicroCPU.Size = New System.Drawing.Size(51, 17)
        Me.btnMicroCPU.TabIndex = 14
        Me.btnMicroCPU.TabStop = True
        Me.btnMicroCPU.Text = "Micro"
        Me.btnMicroCPU.UseVisualStyleBackColor = True
        '
        'btnLogixCPU
        '
        Me.btnLogixCPU.AutoSize = True
        Me.btnLogixCPU.Checked = True
        Me.btnLogixCPU.Location = New System.Drawing.Point(96, 3)
        Me.btnLogixCPU.Name = "btnLogixCPU"
        Me.btnLogixCPU.Size = New System.Drawing.Size(50, 17)
        Me.btnLogixCPU.TabIndex = 13
        Me.btnLogixCPU.TabStop = True
        Me.btnLogixCPU.Text = "Logix"
        Me.btnLogixCPU.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 443)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btnMicroCPU)
        Me.Controls.Add(Me.btnLogixCPU)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me._btnDisconnect)
        Me.Controls.Add(Me._btnConnect)
        Me.Controls.Add(Me._btnReadState)
        Me.Controls.Add(Me._cipPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._ipAddress)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX CPU State"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _ipAddress As System.Windows.Forms.TextBox
    Friend WithEvents _cipPath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _btnReadState As System.Windows.Forms.Button
    Friend WithEvents _btnConnect As System.Windows.Forms.Button
    Friend WithEvents _btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _keySwState As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents _faultState As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _LEDState As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents _edsFile As System.Windows.Forms.Label
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents _serialNum As System.Windows.Forms.Label
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents _prodCode As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents _prodType As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents _firmware As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents _model As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents _progName As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents btnMicroCPU As System.Windows.Forms.RadioButton
    Private WithEvents btnLogixCPU As System.Windows.Forms.RadioButton

End Class
