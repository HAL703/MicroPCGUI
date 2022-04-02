Imports Logix
Public Class vbNETform
    Inherits System.Windows.Forms.Form
    Public MyPLC As Controller
    Private WithEvents tagProps As System.Windows.Forms.GroupBox
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents btnString As System.Windows.Forms.RadioButton
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents btnBoolArray As System.Windows.Forms.RadioButton
    Private WithEvents txtValue As System.Windows.Forms.TextBox
    Private WithEvents btnAtomic As System.Windows.Forms.RadioButton
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents btnWrite As System.Windows.Forms.Button
    Private WithEvents lblQualString As System.Windows.Forms.Label
    Private WithEvents btnRead As System.Windows.Forms.Button
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents lblTimestamp As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents btnM850 As System.Windows.Forms.RadioButton
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnLOGIX As System.Windows.Forms.RadioButton
    Private WithEvents txtPath As System.Windows.Forms.TextBox
    Private WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Public MyTag As Tag

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vbNETform))
        Me.tagProps = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnString = New System.Windows.Forms.RadioButton()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnBoolArray = New System.Windows.Forms.RadioButton()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnAtomic = New System.Windows.Forms.RadioButton()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.lblQualString = New System.Windows.Forms.Label()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblTimestamp = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnM850 = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnLOGIX = New System.Windows.Forms.RadioButton()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tagProps.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tagProps
        '
        Me.tagProps.Controls.Add(Me.txtName)
        Me.tagProps.Controls.Add(Me.label4)
        Me.tagProps.Controls.Add(Me.btnString)
        Me.tagProps.Controls.Add(Me.label5)
        Me.tagProps.Controls.Add(Me.btnBoolArray)
        Me.tagProps.Controls.Add(Me.txtValue)
        Me.tagProps.Controls.Add(Me.btnAtomic)
        Me.tagProps.Controls.Add(Me.label6)
        Me.tagProps.Controls.Add(Me.btnWrite)
        Me.tagProps.Controls.Add(Me.lblQualString)
        Me.tagProps.Controls.Add(Me.btnRead)
        Me.tagProps.Controls.Add(Me.label8)
        Me.tagProps.Controls.Add(Me.lblTimestamp)
        Me.tagProps.Enabled = False
        Me.tagProps.Location = New System.Drawing.Point(5, 138)
        Me.tagProps.Name = "tagProps"
        Me.tagProps.Size = New System.Drawing.Size(358, 197)
        Me.tagProps.TabIndex = 30
        Me.tagProps.TabStop = False
        Me.tagProps.Text = "Tag Properties"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(81, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 20)
        Me.txtName.TabIndex = 6
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(12, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(74, 19)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Tag Name"
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(276, 44)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(56, 19)
        Me.btnString.TabIndex = 22
        Me.btnString.Text = "String"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(20, 70)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(48, 16)
        Me.label5.TabIndex = 7
        Me.label5.Text = "Value"
        '
        'btnBoolArray
        '
        Me.btnBoolArray.Location = New System.Drawing.Point(180, 44)
        Me.btnBoolArray.Name = "btnBoolArray"
        Me.btnBoolArray.Size = New System.Drawing.Size(80, 19)
        Me.btnBoolArray.TabIndex = 21
        Me.btnBoolArray.Text = "Bool Array"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(81, 70)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(248, 20)
        Me.txtValue.TabIndex = 8
        '
        'btnAtomic
        '
        Me.btnAtomic.Checked = True
        Me.btnAtomic.Location = New System.Drawing.Point(81, 44)
        Me.btnAtomic.Name = "btnAtomic"
        Me.btnAtomic.Size = New System.Drawing.Size(64, 19)
        Me.btnAtomic.TabIndex = 20
        Me.btnAtomic.TabStop = True
        Me.btnAtomic.Text = "Atomic"
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(4, 145)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(104, 16)
        Me.label6.TabIndex = 9
        Me.label6.Text = "Tag Quality"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(210, 97)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(95, 25)
        Me.btnWrite.TabIndex = 19
        Me.btnWrite.Text = "Write"
        '
        'lblQualString
        '
        Me.lblQualString.Location = New System.Drawing.Point(124, 145)
        Me.lblQualString.Name = "lblQualString"
        Me.lblQualString.Size = New System.Drawing.Size(168, 16)
        Me.lblQualString.TabIndex = 10
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(81, 97)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(95, 25)
        Me.btnRead.TabIndex = 18
        Me.btnRead.Text = "Read"
        '
        'label8
        '
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.label8.Location = New System.Drawing.Point(4, 169)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(104, 16)
        Me.label8.TabIndex = 14
        Me.label8.Text = "Time Stamp"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTimestamp
        '
        Me.lblTimestamp.Location = New System.Drawing.Point(124, 169)
        Me.lblTimestamp.Name = "lblTimestamp"
        Me.lblTimestamp.Size = New System.Drawing.Size(232, 16)
        Me.lblTimestamp.TabIndex = 15
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnDisconnect)
        Me.groupBox1.Controls.Add(Me.btnConnect)
        Me.groupBox1.Controls.Add(Me.btnM850)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btnLOGIX)
        Me.groupBox1.Controls.Add(Me.txtPath)
        Me.groupBox1.Controls.Add(Me.txtIPAddress)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(3, 5)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(360, 130)
        Me.groupBox1.TabIndex = 29
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "PLC Properties"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(210, 97)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(95, 25)
        Me.btnDisconnect.TabIndex = 35
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(81, 97)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(95, 25)
        Me.btnConnect.TabIndex = 34
        Me.btnConnect.Text = "Connect"
        '
        'btnM850
        '
        Me.btnM850.AutoSize = True
        Me.btnM850.Location = New System.Drawing.Point(149, 20)
        Me.btnM850.Name = "btnM850"
        Me.btnM850.Size = New System.Drawing.Size(51, 17)
        Me.btnM850.TabIndex = 33
        Me.btnM850.Text = "Micro"
        Me.btnM850.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(11, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(64, 15)
        Me.label1.TabIndex = 32
        Me.label1.Text = "CPU Type"
        '
        'btnLOGIX
        '
        Me.btnLOGIX.AutoSize = True
        Me.btnLOGIX.Checked = True
        Me.btnLOGIX.Location = New System.Drawing.Point(81, 20)
        Me.btnLOGIX.Name = "btnLOGIX"
        Me.btnLOGIX.Size = New System.Drawing.Size(50, 17)
        Me.btnLOGIX.TabIndex = 31
        Me.btnLOGIX.TabStop = True
        Me.btnLOGIX.Text = "Logix"
        Me.btnLOGIX.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(81, 70)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(240, 20)
        Me.txtPath.TabIndex = 30
        Me.txtPath.Text = "0"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(81, 41)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(139, 20)
        Me.txtIPAddress.TabIndex = 28
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(11, 65)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 26)
        Me.label3.TabIndex = 29
        Me.label3.Text = "CPU Slot / CIP Path"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(11, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 16)
        Me.label2.TabIndex = 27
        Me.label2.Text = "IP Address"
        '
        'vbNETform
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(367, 341)
        Me.Controls.Add(Me.tagProps)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "vbNETform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX  VB SIMPLE Example"
        Me.tagProps.ResumeLayout(False)
        Me.tagProps.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub vbNETSimpleform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' * create instances of the Controller class and Tag class
        MyPLC = New Controller
        MyTag = New Tag

        ' * display initial quality information for tag
        lblQualString.Text = MyTag.QualityString

    End Sub

    Private Function bitVal(ByVal Value As Object, ByVal bitNum As Int32) As Boolean

        Try
            If Convert.ToInt32(1 << bitNum) And Convert.ToInt32(Value) = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Function

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            ' * set the ipaddress and path of the controller
            MyPLC.IPAddress = txtIPAddress.Text
            MyPLC.Path = txtPath.Text
            MyPLC.Timeout = 3000
            If btnM850.Checked = True Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If

            If MyPLC.Connect() = ResultCode.E_SUCCESS Then
                tagProps.Enabled = True
            Else
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click

        MyPLC.Disconnect()
        tagProps.Enabled = True

    End Sub

  
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try

            ' * set the tag name for the Tag class
            MyTag.Name = txtName.Text
            MyTag.Length = 1

            ' ********************************
            ' * set the data type
            If btnBoolArray.Checked = True Then
                MyTag.DataType = Logix.Tag.ATOMIC.BOOL
            ElseIf btnString.Checked = True Then
                MyTag.DataType = Logix.Tag.ATOMIC.STRING
            Else
                MyTag.DataType = Logix.Tag.ATOMIC.INT
            End If

            ' * calling Controller.Connect() is optional
            ' * if the Controller is not connected when Controller.ReadTag()
            ' * is called, Controller will automatically connect
            If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString, Me.Text)
                End If
                Return
            End If

            If Logix.ResultCode.QUAL_GOOD = MyTag.QualityCode Then
                ' * display tag information
                txtValue.Text = Convert.ToString(MyTag.Value)
                lblTimestamp.Text = MyTag.TimeStamp.ToString
                btnWrite.Enabled = True
            Else
                MessageBox.Show(MyTag.ErrorString, Me.Text)
                btnWrite.Enabled = False
            End If

            lblQualString.Text = MyTag.QualityString

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try
            ' * set the tag name for the Tag class
            MyTag.Name = txtName.Text

            ' * set the value
            MyTag.Value = txtValue.Text

            ' * calling Controller.Connect() is optional
            ' * if the Controller is not connected when Controller.ReadTag()
            ' * is called, Controller will automatically connect
            If MyPLC.WriteTag(MyTag) <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
                Return
            End If


            ' ********************************
            ' * check results
            If Logix.ResultCode.QUAL_GOOD = MyTag.QualityCode Then
                lblTimestamp.Text = MyTag.TimeStamp.ToString
            Else
                MessageBox.Show(MyTag.ErrorString, Me.Text)

            End If
            ' * display tag information
            lblQualString.Text = MyTag.QualityString

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub
End Class
