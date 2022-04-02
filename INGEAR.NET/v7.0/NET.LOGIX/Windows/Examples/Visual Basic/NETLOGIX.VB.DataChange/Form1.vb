Imports Logix
Public Class Form1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCurValue As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents lblPrevVal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTimeStamp As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblChangeCount As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUpdateRate As System.Windows.Forms.TextBox
    Friend WithEvents btnActive As System.Windows.Forms.CheckBox
    Friend WithEvents btnAtomic As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents _writeValue As System.Windows.Forms.TextBox
    Friend WithEvents btnWriteTag As System.Windows.Forms.Button
    Friend WithEvents btnBoolArray As System.Windows.Forms.RadioButton
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents btnMicro As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Friend WithEvents btnString As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCurValue = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblPrevVal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblChangeCount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUpdateRate = New System.Windows.Forms.TextBox()
        Me.btnActive = New System.Windows.Forms.CheckBox()
        Me.btnAtomic = New System.Windows.Forms.RadioButton()
        Me.btnBoolArray = New System.Windows.Forms.RadioButton()
        Me.btnString = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me._writeValue = New System.Windows.Forms.TextBox()
        Me.btnWriteTag = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnMicro = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Demonstrates DataChange event handling.  "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IP Address"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(80, 51)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(144, 20)
        Me.txtIPAddress.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPU Slot / CIP Path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(80, 75)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(256, 20)
        Me.txtPath.TabIndex = 5
        Me.txtPath.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tag Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 99)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 20)
        Me.txtName.TabIndex = 7
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 1000
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(248, 201)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(72, 24)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start Scan"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(248, 225)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(72, 24)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop Scan"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Current"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurValue
        '
        Me.lblCurValue.Location = New System.Drawing.Point(88, 169)
        Me.lblCurValue.Name = "lblCurValue"
        Me.lblCurValue.Size = New System.Drawing.Size(128, 16)
        Me.lblCurValue.TabIndex = 12
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(16, 193)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 16)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Previous"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrevVal
        '
        Me.lblPrevVal.Location = New System.Drawing.Point(88, 193)
        Me.lblPrevVal.Name = "lblPrevVal"
        Me.lblPrevVal.Size = New System.Drawing.Size(128, 16)
        Me.lblPrevVal.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TimeStamp"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.Location = New System.Drawing.Point(88, 217)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(128, 16)
        Me.lblTimeStamp.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Quality"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuality
        '
        Me.lblQuality.Location = New System.Drawing.Point(88, 241)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(128, 16)
        Me.lblQuality.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Values"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(248, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Scan Count"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUpdate
        '
        Me.lblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdate.Location = New System.Drawing.Point(256, 337)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(64, 16)
        Me.lblUpdate.TabIndex = 21
        Me.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(240, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Changed Count"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChangeCount
        '
        Me.lblChangeCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChangeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeCount.Location = New System.Drawing.Point(256, 289)
        Me.lblChangeCount.Name = "lblChangeCount"
        Me.lblChangeCount.Size = New System.Drawing.Size(64, 32)
        Me.lblChangeCount.TabIndex = 23
        Me.lblChangeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(248, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Scan Rate (ms)"
        '
        'txtUpdateRate
        '
        Me.txtUpdateRate.Location = New System.Drawing.Point(248, 177)
        Me.txtUpdateRate.Name = "txtUpdateRate"
        Me.txtUpdateRate.Size = New System.Drawing.Size(72, 20)
        Me.txtUpdateRate.TabIndex = 25
        Me.txtUpdateRate.Text = "1000"
        '
        'btnActive
        '
        Me.btnActive.Checked = True
        Me.btnActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.btnActive.Location = New System.Drawing.Point(248, 249)
        Me.btnActive.Name = "btnActive"
        Me.btnActive.Size = New System.Drawing.Size(88, 16)
        Me.btnActive.TabIndex = 26
        Me.btnActive.Text = "Tag is Active"
        '
        'btnAtomic
        '
        Me.btnAtomic.Checked = True
        Me.btnAtomic.Location = New System.Drawing.Point(80, 123)
        Me.btnAtomic.Name = "btnAtomic"
        Me.btnAtomic.Size = New System.Drawing.Size(64, 16)
        Me.btnAtomic.TabIndex = 27
        Me.btnAtomic.TabStop = True
        Me.btnAtomic.Text = "Atomic"
        '
        'btnBoolArray
        '
        Me.btnBoolArray.Location = New System.Drawing.Point(168, 123)
        Me.btnBoolArray.Name = "btnBoolArray"
        Me.btnBoolArray.Size = New System.Drawing.Size(80, 16)
        Me.btnBoolArray.TabIndex = 28
        Me.btnBoolArray.Text = "Bool Array"
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(272, 122)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(56, 19)
        Me.btnString.TabIndex = 29
        Me.btnString.Text = "String"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Write Value"
        '
        '_writeValue
        '
        Me._writeValue.Location = New System.Drawing.Point(16, 289)
        Me._writeValue.Name = "_writeValue"
        Me._writeValue.Size = New System.Drawing.Size(224, 20)
        Me._writeValue.TabIndex = 31
        '
        'btnWriteTag
        '
        Me.btnWriteTag.Location = New System.Drawing.Point(72, 321)
        Me.btnWriteTag.Name = "btnWriteTag"
        Me.btnWriteTag.Size = New System.Drawing.Size(120, 24)
        Me.btnWriteTag.TabIndex = 32
        Me.btnWriteTag.Text = "Write Tag"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "CPU Type"
        '
        'btnMicro
        '
        Me.btnMicro.AutoSize = True
        Me.btnMicro.Location = New System.Drawing.Point(149, 25)
        Me.btnMicro.Name = "btnMicro"
        Me.btnMicro.Size = New System.Drawing.Size(51, 17)
        Me.btnMicro.TabIndex = 37
        Me.btnMicro.Text = "Micro"
        Me.btnMicro.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(82, 25)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(50, 17)
        Me.btnLogix.TabIndex = 36
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "Logix"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 382)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnMicro)
        Me.Controls.Add(Me.btnLogix)
        Me.Controls.Add(Me.btnWriteTag)
        Me.Controls.Add(Me._writeValue)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnString)
        Me.Controls.Add(Me.btnBoolArray)
        Me.Controls.Add(Me.btnAtomic)
        Me.Controls.Add(Me.btnActive)
        Me.Controls.Add(Me.txtUpdateRate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblChangeCount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblQuality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTimeStamp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPrevVal)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.lblCurValue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIPAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX  VB DataChange Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' ***********************************
    ' * declare instances of Controller, TagGroup and Tag classes
    ' *
    Dim MyPLC As New Controller
   
    ' ***********************************
    ' * declare more tags here for to be
    ' * added to ScanGroup
    Dim WithEvents MyTag As New Tag

    ' **********************************
    ' * just some counters we'll increment
    Dim UpdateCount As Int32
    Dim DataChanges As Int32

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyTag_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyTag.Changed

        Try
            Dim theTag As Tag
            Dim args As DataChangeEventArgs

            theTag = sender
            args = e

            ' *********************************
            ' * display changed value
            lblCurValue.Text = args.Value

            ' *********************************
            ' * display previous value
            lblPrevVal.Text = args.PreValue

            ' *********************************
            ' * display time stamp when change occured
            lblTimeStamp.Text = args.TimeStamp.ToString()

            ' **********************************
            ' * display tag quality
            lblQuality.Text = args.QualityString

            ' *********************************
            ' * increment and display DataChanged counter
            DataChanges = DataChanges + 1
            lblChangeCount.Text = DataChanges.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try


    End Sub

    Private Sub UpdateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateTimer.Tick

        ' **********************************
        ' * increment and display the number of
        ' * times we scanned the tag
        UpdateCount = UpdateCount + 1
        lblUpdate.Text = UpdateCount

        ' ***********************************
        ' * read all tags in the ScanGroup
        If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
            If MessageBox.Show(MyPLC.ErrorString, Me.Text, MessageBoxButtons.RetryCancel) = Windows.Forms.DialogResult.Retry Then
                UpdateTimer.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Try
            ' ****************************
            ' Reset the incrementing counters
            UpdateCount = 0
            DataChanges = 0

            ' ******************************
            ' set IP Address and Path for Controller class
            MyPLC.IPAddress = txtIPAddress.Text
            MyPLC.Path = txtPath.Text
            MyPLC.Timeout = 3000

            If btnMicro.Checked = True Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If

            ' ******************************
            ' * set the Tag class .Name to the controllogix tag
            ' * we want to scan
            MyTag.Name = txtName.Text
            ' *******************************
            ' * set the .Active state of the Tag class
            MyTag.Active = btnActive.Checked

            ' ********************************
            ' * set the data type property
            If btnBoolArray.Checked Then
                MyTag.DataType = Logix.Tag.ATOMIC.BOOL
            ElseIf btnString.Checked Then
                MyTag.DataType = Logix.Tag.ATOMIC.STRING
            End If
            ' *****************************************
            ' * set the properties of any additional tags
            ' * you might have created

            ' ***************************
            ' * update and display Scan counter
            UpdateCount = UpdateCount + 1
            lblUpdate.Text = UpdateCount

            ' ****************************
            ' * an initial scan of the controllogix tag
            If MyPLC.ReadTag(MyTag) <> ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString, Me.Text)
                End If
                Return
            End If

                ' ****************************
                ' * use a timer to provide scan updates
                UpdateTimer.Interval = txtUpdateRate.Text
                UpdateTimer.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try


    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        ' **************************
        ' * stop the timer, clear the 
        ' * scan group and disconnect
        ' * from the controlLogix
        UpdateTimer.Enabled = False
        MyPLC.Disconnect()
    End Sub

    Private Sub btnActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActive.CheckedChanged

        ' *************************************
        ' * change the Active state of the Tag class
        MyTag.Active = btnActive.Checked
    End Sub

    Private Sub btnWriteTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteTag.Click
        Try

         
            ' *****************************
            ' * set the tag value
            MyTag.Value = _writeValue.Text

            ' ******************************
            ' * write the tag and check for errors
            If MyPLC.WriteTag(MyTag) <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
            End If

 
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub
End Class
