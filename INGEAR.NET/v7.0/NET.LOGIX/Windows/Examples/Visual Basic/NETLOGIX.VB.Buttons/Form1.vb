Imports Logix

Public Class frmVBButtons
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents _tagType As System.Windows.Forms.Label
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents txtStopVal As System.Windows.Forms.TextBox
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents txtStartVal As System.Windows.Forms.TextBox
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtJogUp As System.Windows.Forms.TextBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents txtJogDn As System.Windows.Forms.TextBox
    Friend WithEvents label7 As System.Windows.Forms.Label
    Friend WithEvents btnJog As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblCurValue As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents btnMicro As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVBButtons))
        Me._tagType = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.txtStopVal = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txtStartVal = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtJogUp = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtJogDn = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.btnJog = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblCurValue = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.btnMicro = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        '_tagType
        '
        Me._tagType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tagType.Location = New System.Drawing.Point(160, 184)
        Me._tagType.Name = "_tagType"
        Me._tagType.Size = New System.Drawing.Size(173, 16)
        Me._tagType.TabIndex = 51
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(96, 184)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(56, 16)
        Me.label11.TabIndex = 50
        Me.label11.Text = "Tag Type:"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(16, 176)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(80, 24)
        Me.btnDisconnect.TabIndex = 49
        Me.btnDisconnect.Text = "Disconnect"
        '
        'txtStopVal
        '
        Me.txtStopVal.Location = New System.Drawing.Point(176, 384)
        Me.txtStopVal.Name = "txtStopVal"
        Me.txtStopVal.Size = New System.Drawing.Size(96, 20)
        Me.txtStopVal.TabIndex = 48
        Me.txtStopVal.Text = "0"
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(104, 384)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(64, 16)
        Me.label10.TabIndex = 47
        Me.label10.Text = "Stop Value"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(16, 368)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(80, 48)
        Me.btnStop.TabIndex = 46
        Me.btnStop.Text = "Stop"
        '
        'txtStartVal
        '
        Me.txtStartVal.Location = New System.Drawing.Point(176, 328)
        Me.txtStartVal.Name = "txtStartVal"
        Me.txtStartVal.Size = New System.Drawing.Size(96, 20)
        Me.txtStartVal.TabIndex = 45
        Me.txtStartVal.Text = "1"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(104, 328)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(64, 16)
        Me.label9.TabIndex = 44
        Me.label9.Text = "Start Value"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(16, 312)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(80, 48)
        Me.btnStart.TabIndex = 43
        Me.btnStart.Text = "Start"
        '
        'txtJogUp
        '
        Me.txtJogUp.Location = New System.Drawing.Point(176, 272)
        Me.txtJogUp.Name = "txtJogUp"
        Me.txtJogUp.Size = New System.Drawing.Size(96, 20)
        Me.txtJogUp.TabIndex = 42
        Me.txtJogUp.Text = "0"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(104, 272)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(64, 16)
        Me.label8.TabIndex = 41
        Me.label8.Text = "Value Up"
        '
        'txtJogDn
        '
        Me.txtJogDn.Location = New System.Drawing.Point(176, 248)
        Me.txtJogDn.Name = "txtJogDn"
        Me.txtJogDn.Size = New System.Drawing.Size(96, 20)
        Me.txtJogDn.TabIndex = 40
        Me.txtJogDn.Text = "1"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(104, 248)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(72, 16)
        Me.label7.TabIndex = 39
        Me.label7.Text = "Value Down"
        '
        'btnJog
        '
        Me.btnJog.Location = New System.Drawing.Point(16, 248)
        Me.btnJog.Name = "btnJog"
        Me.btnJog.Size = New System.Drawing.Size(80, 48)
        Me.btnJog.TabIndex = 38
        Me.btnJog.Text = "Jog"
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(160, 152)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(148, 24)
        Me.lblError.TabIndex = 37
        Me.lblError.Text = "DISCONNECTED"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(112, 152)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(40, 16)
        Me.label6.TabIndex = 36
        Me.label6.Text = "Status"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurValue
        '
        Me.lblCurValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurValue.Location = New System.Drawing.Point(104, 208)
        Me.lblCurValue.Name = "lblCurValue"
        Me.lblCurValue.Size = New System.Drawing.Size(168, 32)
        Me.lblCurValue.TabIndex = 35
        Me.lblCurValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(8, 216)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(80, 16)
        Me.label5.TabIndex = 34
        Me.label5.Text = "Current Value"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(16, 152)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(80, 24)
        Me.btnConnect.TabIndex = 33
        Me.btnConnect.Text = "Get Tag"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(88, 120)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 20)
        Me.txtName.TabIndex = 32
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(8, 128)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 16)
        Me.label4.TabIndex = 31
        Me.label4.Text = "Tag Name"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(88, 96)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(160, 20)
        Me.txtPath.TabIndex = 30
        Me.txtPath.Text = "0"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(8, 96)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 24)
        Me.label3.TabIndex = 29
        Me.label3.Text = "CPU Slot / CIP Path"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(88, 72)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(160, 20)
        Me.txtIPAddress.TabIndex = 28
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(8, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 27
        Me.label2.Text = "IP Address"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.label1.Location = New System.Drawing.Point(8, 2)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(325, 32)
        Me.label1.TabIndex = 26
        Me.label1.Text = "This example shows how to use NET.LOGIX for common pushbutton tasks such as START" & _
    ", STOP and JOG"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(10, 49)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(72, 16)
        Me.label12.TabIndex = 54
        Me.label12.Text = "CPU Type"
        '
        'btnMicro
        '
        Me.btnMicro.AutoSize = True
        Me.btnMicro.Location = New System.Drawing.Point(192, 49)
        Me.btnMicro.Name = "btnMicro"
        Me.btnMicro.Size = New System.Drawing.Size(51, 17)
        Me.btnMicro.TabIndex = 53
        Me.btnMicro.Text = "Micro"
        Me.btnMicro.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(89, 49)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(50, 17)
        Me.btnLogix.TabIndex = 52
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "Logix"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'frmVBButtons
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(339, 446)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.btnMicro)
        Me.Controls.Add(Me.btnLogix)
        Me.Controls.Add(Me._tagType)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.txtStopVal)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.txtStartVal)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtJogUp)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtJogDn)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.btnJog)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.lblCurValue)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVBButtons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX  VB Buttons Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' **************************************
    ' * initialize controller class
    Dim MyPLC As New Controller

    ' **************************************
    ' * initialize tag class
    Dim MyTag As New Tag


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        ' ***************************
        ' * here's where will connect and get the tag value
        Try
            ' ***********************
            ' * set the IP Address and Path
            MyPLC.IPAddress = txtIPAddress.Text
            MyPLC.Path = txtPath.Text
            MyPLC.Timeout = 3000
            If btnMicro.Checked = True Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If
            If MyPLC.Connect() <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
                Return
            End If

            ' ************************
            ' * set the Tag.Name property
            MyTag.Name = txtName.Text

            ' ************************
            ' * set the parent controller property
            MyTag.Controller = MyPLC

            ' *************************
            ' * read the value
            If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString)
                End If
                Return
            End If

            If MyTag.QualityCode = ResultCode.QUAL_GOOD Then
                ' *************************
                ' * show the tag type
                _tagType.Text = MyTag.NetType.ToString()

                ' *************************
                ' * display controller status
                lblError.Text = MyTag.ErrorString

            Else

                lblCurValue.Text = "???"

                ' *************************
                ' * display controller status
                lblError.Text = MyTag.ErrorString

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try


    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        Try
            ' ***************************
            ' * disconnect if we're connected
            If MyPLC.IsConnected = True Then
                MyPLC.Disconnect()
            End If

            ' *************************
            ' * reset displays
            lblCurValue.Text = ""
            _tagType.Text = ""
            lblError.Text = "DISCONNECTED"

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnJog_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnJog.MouseDown

        Try
            ' ****************************
            ' * set the value based on tag data type
            Select Case MyTag.DataType

                Case Tag.ATOMIC.BOOL
                    MyTag.Now = Convert.ToInt16(txtJogDn.Text)

                Case Logix.Tag.ATOMIC.SINT
                    MyTag.Now = Convert.ToSByte(txtJogDn.Text)

                Case Logix.Tag.ATOMIC.INT
                    MyTag.Now = Convert.ToInt16(txtJogDn.Text)

                Case Logix.Tag.ATOMIC.DINT
                    MyTag.Now = Convert.ToInt32(txtJogDn.Text)

                Case Logix.Tag.ATOMIC.REAL
                    MyTag.Now = Convert.ToSingle(txtJogDn.Text)

                Case Logix.Tag.ATOMIC.STRING
                    MyTag.Now = txtJogDn.Text

            End Select

            ' *************************
            ' * .Now to immediately read back the value
            lblCurValue.Text = MyTag.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnJog_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnJog.MouseUp
        Try
            ' ****************************
            ' * set the value based on tag data type
            Select Case MyTag.DataType

                Case Logix.Tag.ATOMIC.BOOL
                    MyTag.Now = Convert.ToInt16(txtJogUp.Text)

                Case Logix.Tag.ATOMIC.SINT
                    MyTag.Now = Convert.ToSByte(txtJogUp.Text)

                Case Logix.Tag.ATOMIC.INT
                    MyTag.Now = Convert.ToInt16(txtJogUp.Text)

                Case Logix.Tag.ATOMIC.DINT
                    MyTag.Now = Convert.ToInt32(txtJogUp.Text)

                Case Logix.Tag.ATOMIC.REAL
                    MyTag.Now = Convert.ToSingle(txtJogUp.Text)

                Case Logix.Tag.ATOMIC.STRING
                    MyTag.Now = txtJogUp.Text

            End Select

            ' *************************
            ' * .Now to immediately read back the value
            lblCurValue.Text = MyTag.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            ' ****************************
            ' * set the value based on tag data type
            Select Case MyTag.DataType

                Case Logix.Tag.ATOMIC.BOOL
                    MyTag.Now = Convert.ToInt16(txtStartVal.Text)

                Case Logix.Tag.ATOMIC.SINT
                    MyTag.Now = Convert.ToSByte(txtStartVal.Text)

                Case Logix.Tag.ATOMIC.INT
                    MyTag.Now = Convert.ToInt16(txtStartVal.Text)

                Case Logix.Tag.ATOMIC.DINT
                    MyTag.Now = Convert.ToInt32(txtStartVal.Text)

                Case Logix.Tag.ATOMIC.REAL
                    MyTag.Now = Convert.ToSingle(txtStartVal.Text)

                Case Logix.Tag.ATOMIC.STRING
                    MyTag.Now = txtStartVal.Text

            End Select

            ' *************************
            ' * .Now to immediately read back the value
            lblCurValue.Text = MyTag.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Try
            ' ****************************
            ' * set the value based on tag data type
            Select Case MyTag.DataType

                Case Logix.Tag.ATOMIC.BOOL
                    MyTag.Now = Convert.ToInt16(txtStopVal.Text)

                Case Logix.Tag.ATOMIC.SINT
                    MyTag.Now = Convert.ToSByte(txtStopVal.Text)

                Case Logix.Tag.ATOMIC.INT
                    MyTag.Now = Convert.ToInt16(txtStopVal.Text)

                Case Logix.Tag.ATOMIC.DINT
                    MyTag.Now = Convert.ToInt32(txtStopVal.Text)

                Case Logix.Tag.ATOMIC.REAL
                    MyTag.Now = Convert.ToSingle(txtStopVal.Text)

                Case Logix.Tag.ATOMIC.STRING
                    MyTag.Now = txtStopVal.Text

            End Select

            ' *************************
            ' * .Now to immediately read back the value
            lblCurValue.Text = MyTag.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub
End Class
