Imports Logix
Imports System.Threading
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
    Friend WithEvents _status As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents _groupProperties As System.Windows.Forms.GroupBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents _updateRate As System.Windows.Forms.TextBox
    Friend WithEvents _btnChangeRate As System.Windows.Forms.Button
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents _itemCount As System.Windows.Forms.Label
    Friend WithEvents _path As System.Windows.Forms.TextBox
    Friend WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents _tagView As System.Windows.Forms.ListView
    Friend WithEvents _tagProperties As System.Windows.Forms.GroupBox
    Friend WithEvents btnStringTag As System.Windows.Forms.RadioButton
    Friend WithEvents btnBoolArray As System.Windows.Forms.RadioButton
    Friend WithEvents btnDefaultType As System.Windows.Forms.RadioButton
    Friend WithEvents _btnAddTag As System.Windows.Forms.Button
    Friend WithEvents _tagName As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents _ipaddress As System.Windows.Forms.TextBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents btnMicro As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._status = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me._groupProperties = New System.Windows.Forms.GroupBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me._updateRate = New System.Windows.Forms.TextBox()
        Me._btnChangeRate = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me._itemCount = New System.Windows.Forms.Label()
        Me._path = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me._tagView = New System.Windows.Forms.ListView()
        Me._tagProperties = New System.Windows.Forms.GroupBox()
        Me.btnStringTag = New System.Windows.Forms.RadioButton()
        Me.btnBoolArray = New System.Windows.Forms.RadioButton()
        Me.btnDefaultType = New System.Windows.Forms.RadioButton()
        Me._btnAddTag = New System.Windows.Forms.Button()
        Me._tagName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._ipaddress = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnMicro = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me._groupProperties.SuspendLayout()
        Me._tagProperties.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_status
        '
        Me._status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._status.Location = New System.Drawing.Point(313, 259)
        Me._status.Name = "_status"
        Me._status.Size = New System.Drawing.Size(224, 16)
        Me._status.TabIndex = 40
        Me._status.Text = "DISCONNECT"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(265, 259)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 16)
        Me.label3.TabIndex = 39
        Me.label3.Text = "Status:"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(169, 90)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 24)
        Me.btnDisconnect.TabIndex = 38
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(97, 90)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(72, 24)
        Me.btnConnect.TabIndex = 37
        Me.btnConnect.Text = "Connect"
        '
        '_groupProperties
        '
        Me._groupProperties.Controls.Add(Me.label4)
        Me._groupProperties.Controls.Add(Me._updateRate)
        Me._groupProperties.Controls.Add(Me._btnChangeRate)
        Me._groupProperties.Controls.Add(Me.label5)
        Me._groupProperties.Controls.Add(Me._itemCount)
        Me._groupProperties.Enabled = False
        Me._groupProperties.Location = New System.Drawing.Point(9, 226)
        Me._groupProperties.Name = "_groupProperties"
        Me._groupProperties.Size = New System.Drawing.Size(248, 72)
        Me._groupProperties.TabIndex = 36
        Me._groupProperties.TabStop = False
        Me._groupProperties.Text = "Group Properties"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(8, 20)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(96, 16)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Update Rate (ms)"
        '
        '_updateRate
        '
        Me._updateRate.Location = New System.Drawing.Point(104, 18)
        Me._updateRate.Name = "_updateRate"
        Me._updateRate.Size = New System.Drawing.Size(48, 20)
        Me._updateRate.TabIndex = 15
        Me._updateRate.Text = "1000"
        '
        '_btnChangeRate
        '
        Me._btnChangeRate.Location = New System.Drawing.Point(168, 16)
        Me._btnChangeRate.Name = "_btnChangeRate"
        Me._btnChangeRate.Size = New System.Drawing.Size(64, 20)
        Me._btnChangeRate.TabIndex = 16
        Me._btnChangeRate.Text = "< Change"
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(8, 48)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(72, 16)
        Me.label5.TabIndex = 18
        Me.label5.Text = "Group Items:"
        '
        '_itemCount
        '
        Me._itemCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._itemCount.Location = New System.Drawing.Point(96, 48)
        Me._itemCount.Name = "_itemCount"
        Me._itemCount.Size = New System.Drawing.Size(96, 16)
        Me._itemCount.TabIndex = 21
        Me._itemCount.Text = "0"
        '
        '_path
        '
        Me._path.Location = New System.Drawing.Point(97, 66)
        Me._path.Name = "_path"
        Me._path.Size = New System.Drawing.Size(144, 20)
        Me._path.TabIndex = 35
        Me._path.Text = "0"
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(17, 66)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 16)
        Me.label15.TabIndex = 34
        Me.label15.Text = "Path"
        '
        '_tagView
        '
        Me._tagView.Enabled = False
        Me._tagView.GridLines = True
        Me._tagView.Location = New System.Drawing.Point(1, 298)
        Me._tagView.Name = "_tagView"
        Me._tagView.Size = New System.Drawing.Size(544, 224)
        Me._tagView.TabIndex = 32
        Me._tagView.UseCompatibleStateImageBehavior = False
        '
        '_tagProperties
        '
        Me._tagProperties.Controls.Add(Me.btnStringTag)
        Me._tagProperties.Controls.Add(Me.btnBoolArray)
        Me._tagProperties.Controls.Add(Me.btnDefaultType)
        Me._tagProperties.Controls.Add(Me._btnAddTag)
        Me._tagProperties.Controls.Add(Me._tagName)
        Me._tagProperties.Controls.Add(Me.label2)
        Me._tagProperties.Enabled = False
        Me._tagProperties.Location = New System.Drawing.Point(10, 122)
        Me._tagProperties.Name = "_tagProperties"
        Me._tagProperties.Size = New System.Drawing.Size(248, 104)
        Me._tagProperties.TabIndex = 31
        Me._tagProperties.TabStop = False
        Me._tagProperties.Text = "Tag Properties"
        '
        'btnStringTag
        '
        Me.btnStringTag.Location = New System.Drawing.Point(183, 56)
        Me.btnStringTag.Name = "btnStringTag"
        Me.btnStringTag.Size = New System.Drawing.Size(52, 18)
        Me.btnStringTag.TabIndex = 7
        Me.btnStringTag.Text = "String"
        '
        'btnBoolArray
        '
        Me.btnBoolArray.Location = New System.Drawing.Point(88, 56)
        Me.btnBoolArray.Name = "btnBoolArray"
        Me.btnBoolArray.Size = New System.Drawing.Size(75, 16)
        Me.btnBoolArray.TabIndex = 6
        Me.btnBoolArray.Text = "Bool Array"
        '
        'btnDefaultType
        '
        Me.btnDefaultType.Checked = True
        Me.btnDefaultType.Location = New System.Drawing.Point(8, 56)
        Me.btnDefaultType.Name = "btnDefaultType"
        Me.btnDefaultType.Size = New System.Drawing.Size(64, 16)
        Me.btnDefaultType.TabIndex = 5
        Me.btnDefaultType.TabStop = True
        Me.btnDefaultType.Text = "Atomic"
        '
        '_btnAddTag
        '
        Me._btnAddTag.Location = New System.Drawing.Point(48, 77)
        Me._btnAddTag.Name = "_btnAddTag"
        Me._btnAddTag.Size = New System.Drawing.Size(144, 21)
        Me._btnAddTag.TabIndex = 4
        Me._btnAddTag.Text = "Add Tag"
        '
        '_tagName
        '
        Me._tagName.Location = New System.Drawing.Point(8, 32)
        Me._tagName.Name = "_tagName"
        Me._tagName.Size = New System.Drawing.Size(232, 20)
        Me._tagName.TabIndex = 1
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(8, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Name"
        '
        '_ipaddress
        '
        Me._ipaddress.Location = New System.Drawing.Point(97, 43)
        Me._ipaddress.Name = "_ipaddress"
        Me._ipaddress.Size = New System.Drawing.Size(144, 20)
        Me._ipaddress.TabIndex = 30
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(18, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 29
        Me.label1.Text = "IP Address"
        '
        'label17
        '
        Me.label17.Location = New System.Drawing.Point(19, 13)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(72, 16)
        Me.label17.TabIndex = 43
        Me.label17.Text = "CPU Type"
        '
        'btnMicro
        '
        Me.btnMicro.AutoSize = True
        Me.btnMicro.Location = New System.Drawing.Point(169, 12)
        Me.btnMicro.Name = "btnMicro"
        Me.btnMicro.Size = New System.Drawing.Size(51, 17)
        Me.btnMicro.TabIndex = 42
        Me.btnMicro.Text = "Micro"
        Me.btnMicro.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(97, 12)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(50, 17)
        Me.btnLogix.TabIndex = 41
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "Logix"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.label14)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label9)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Location = New System.Drawing.Point(269, 13)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(272, 233)
        Me.groupBox2.TabIndex = 44
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Using Group Scanning"
        '
        'label16
        '
        Me.label16.Location = New System.Drawing.Point(8, 29)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(256, 16)
        Me.label16.TabIndex = 9
        Me.label16.Text = "1). Select CPU Type"
        '
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(104, 191)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(152, 16)
        Me.label14.TabIndex = 8
        Me.label14.Text = "Right double-click Tag Name"
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(104, 175)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(152, 16)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Left double-click Tag Name"
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(8, 191)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(88, 16)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Remove Tag:"
        '
        'label11
        '
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(8, 175)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(72, 16)
        Me.label11.TabIndex = 5
        Me.label11.Text = "Write Tag:"
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(8, 151)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(256, 16)
        Me.label10.TabIndex = 4
        Me.label10.Text = "6). Repeat steps 2-4 to add more tags"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(8, 127)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(256, 16)
        Me.label9.TabIndex = 3
        Me.label9.Text = "5). Click the ""Add Tag"" button"
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(8, 103)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(256, 16)
        Me.label8.TabIndex = 2
        Me.label8.Text = "4). Select data type ( Atomic / Bool Array / String )"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(8, 79)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(256, 16)
        Me.label7.TabIndex = 1
        Me.label7.Text = "3). Enter a CPU Tag Name"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(8, 55)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(256, 16)
        Me.label6.TabIndex = 0
        Me.label6.Text = "2). Enter the IP Address and Path of the PLC"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(547, 531)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.btnMicro)
        Me.Controls.Add(Me.btnLogix)
        Me.Controls.Add(Me._status)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me._groupProperties)
        Me.Controls.Add(Me._path)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me._tagView)
        Me.Controls.Add(Me._tagProperties)
        Me.Controls.Add(Me._ipaddress)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX VB.NET ScanGroup"
        Me._groupProperties.ResumeLayout(False)
        Me._groupProperties.PerformLayout()
        Me._tagProperties.ResumeLayout(False)
        Me._tagProperties.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' *****************************
    ' * Initialize Controller class
    Public MyPLC As New Controller

    ' ******************************
    ' * Initialize TagGroup class
    Public scanGroup As New TagGroup

    ' ******************************
    ' * un-initialized Tag class
    Dim WithEvents newTag As Tag

 

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            ' *******************************
            ' * stop scan thread
            ' *
            scanGroup.ScanStop()
            
            ' ****************************
            ' * disconnect from PLC
            MyPLC.Disconnect()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' * **********************************
        ' * * add colums to list view
        ' * *
        _tagView.View = View.Details

        _tagView.Columns.Add("Tag Name", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Value", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Data Type", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Quality", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Time Stamp", 140, HorizontalAlignment.Left)

        ' set scangroup properties
        scanGroup.Controller = MyPLC
        scanGroup.ScanningMode = TagGroup.SCANMODE.ReadWrite
        scanGroup.Interval = 1000

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Dim msg As String
        Try
            ' *********************************
            ' * set the IP Addres, Path
            ' * properties.  We'll also set
            ' * the timeout property to 3000ms
            MyPLC.IPAddress = _ipaddress.Text
            MyPLC.Path = _path.Text
            MyPLC.Timeout = 3000

            If btnMicro.Checked = True Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If

            ' *********************************
            ' * let's connect and check
            ' * results
            If MyPLC.Connect() = ResultCode.E_SUCCESS Then
                _status.Text = "CONNECTED"
                _tagProperties.Enabled = True
                _groupProperties.Enabled = True
                btnDisconnect.Enabled = True
                btnConnect.Enabled = False
                _tagView.Enabled = True

                ' assign instance of controller
                ' class to scan group then start
                ' scanning
                scanGroup.Controller = MyPLC
                scanGroup.ScanStart()
            Else
                msg = "ERROR:" + MyPLC.ErrorCode.ToString() + " - " + MyPLC.ErrorString
                MessageBox.Show(msg, Me.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        Try

            ' *******************************
            ' * stop scan thread
            ' *
            scanGroup.ScanStop()

            ' ****************************
            ' * disconnect from PLC
            MyPLC.Disconnect()
            _status.Text = "DISCONNECTED"
            _tagName.Text = ""
            _tagProperties.Enabled = False
            _groupProperties.Enabled = False
            btnDisconnect.Enabled = False
            btnConnect.Enabled = True
            _tagView.Enabled = False

            ' ************************* 				
            ' * clean up the tag view list
            ' * and remove items from Group
            scanGroup.Clear()
            _tagView.Items.Clear()

            _itemCount.Text = scanGroup.Count.ToString()
            _tagView.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub AddTag(ByVal theNewTag As Tag)
        Try
            ' *************************
            ' * new items
            Dim tagListItem As ListViewItem

            ' *************************************
            ' * if this is a BOOL ARRAY, we need to 
            ' * specify in the contructor
            If True = btnBoolArray.Checked Then
                theNewTag = New Tag(_tagName.Text, GetType(System.Boolean))

                ' ********************************
                ' * if this is a STRING tag we'll need to 
                ' * use the STRING constructor
            ElseIf True = btnStringTag.Checked Then
                theNewTag = New Tag(_tagName.Text, GetType(System.String))
            Else
                ' *******************************
                ' * use this constructor for
                ' * BOOL, SINT, DINT, and REAL type
                theNewTag = New Tag(_tagName.Text)
            End If

            If MyPLC.ReadTag(theNewTag) <> ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show(MyPLC.ErrorString)
                End If
                Return
            End If
            If theNewTag.QualityCode = ResultCode.QUAL_GOOD Then

                ' *************************
                ' * add event handler
                ' * this event handler will be common
                ' * for all tags

                AddHandler theNewTag.Changed, AddressOf newTag_Changed

                ' **************************
                ' * add the Tag Name to the 
                ' * ListView
                tagListItem = _tagView.Items.Add(theNewTag.Name)

                ' ***************************
                ' * use Tag.MyObject to remember
                ' * its reference in the ListView (_tagView)
                ' *
                ' * we'll use this for updating
                ' * the ListView when we get a DataChange
                ' * event
                theNewTag.MyObject = tagListItem

                ' ****************************
                ' * also, we'll reference newTag
                ' * in the tagListItem
                ' *
                ' * we'll use this for referencing
                ' * the tag when we click on the ListView
                tagListItem.Tag = theNewTag

                ' ****************************
                ' * display something for the value
                ' * to create the listview item
                tagListItem.SubItems.Add(theNewTag.Value.ToString())

                ' ***********************
                ' * display data type in the listview
                ' *
                tagListItem.SubItems.Add(theNewTag.NetType.ToString())

                ' ************************
                ' * and the quality string
                ' *
                tagListItem.SubItems.Add(theNewTag.QualityString)

                '  ************************
                '  * and the timestamp
                '  *
                tagListItem.SubItems.Add(theNewTag.TimeStamp.ToString())

                '  ************************
                '  * add the tag to the tag group
                '  *
                scanGroup.AddTag(theNewTag)

                ' *****************************
                ' * display number of tags
                ' * in group
                ' * 
                _itemCount.Text = scanGroup.Count.ToString()

            Else
                MessageBox.Show(newTag.ErrorString, Me.Text)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub
    Private Sub _btnAddTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnAddTag.Click

        AddTag(newTag)

    End Sub

    Public Delegate Sub changedDelegate(ByVal e As System.EventArgs)


    Private Sub tagChanged(ByVal e As System.EventArgs)

        Try

            ' ******************************
            ' * 
            Dim tagViewItem As ListViewItem

            ' *************************
            ' * data change event args associated with the tag
            Dim args As Logix.DataChangeEventArgs

            args = e

            ' ********************************
            ' * retrieve the ListViewItem associated
            ' * with the Tag class
            tagViewItem = args.MyObject

            ' ********************************
            ' * we' ll check the QUALITY of the 
            ' * tag.  If we' ve got a good quality
            ' * we'll update the list view items.
            If Logix.ResultCode.QUAL_GOOD = args.QualityCode Then
                tagViewItem.SubItems(1).Text = Convert.ToString(args.Value)
                tagViewItem.SubItems(4).Text = args.TimeStamp.ToString()
            Else
                tagViewItem.SubItems(1).Text = "????"
            End If
            ' *******************************
            ' * we'll always display
            ' * the quality string
            ' * 
            tagViewItem.SubItems(3).Text = args.QualityString

            If MyPLC.IsConnected = False Then
                _status.Text = "DISCONNECTED"
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub
    Private Sub newTag_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles newTag.Changed

        If InvokeRequired = True Then
            Dim newDelegate As New changedDelegate(AddressOf tagChanged)
            Invoke(newDelegate, e)
        Else
            tagChanged(e)
        End If

    End Sub

    Private Sub _btnChangeRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnChangeRate.Click
        ' **********************
        ' * change the update timer
        ' * rate
        scanGroup.Interval = Convert.ToInt32(_updateRate.Text)
    End Sub

    Private Sub _tagView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _tagView.MouseDown

        Dim theTag As Tag

        Dim theItem As ListView
        Dim tagWriteDlg As New frmTagWrite

        ' ***********************
        ' * if there's nothing in the
        ' * _tagView or clicks are < 2
        ' * the exit
        ' *
        If 0 = _tagView.Items.Count Or e.Clicks <> 2 Then
            Exit Sub
        End If

        ' ***********************
        ' * process for exceptions
        ' *
        Try

            ' *******************************
            ' * get the selected item
            ' * and the reference to GELink.Tag
            ' * that we associated with the item
            ' *
            theItem = sender
            theTag = theItem.FocusedItem.Tag

            ' ********************************
            ' * LEFT Mouse is Write Tag
            If MouseButtons.Left = e.Button Then

                ' ****************************
                ' * initialize the tagWriteDlg
                ' *
                tagWriteDlg.description.Text = "Write Tag " + theTag.Name
                tagWriteDlg.newValue.Text = Convert.ToString(theTag.Value)

                ' ***************************
                ' * write the value if OK was
                ' * clicked
                If DialogResult.OK = tagWriteDlg.ShowDialog Then

                    theTag.Value = tagWriteDlg.newValue.Text

                End If

                ' *************************
                ' * RIGHT mouse is Remove Tag
            ElseIf MouseButtons.Right = e.Button Then

                ' ****************************
                ' * remove the tag from the group
                ' *
                scanGroup.RemoveTag(theTag)

                ' *****************************
                ' * remove the tag list item
                ' *
                _tagView.Items.Remove(theItem.FocusedItem)

                _itemCount.Text = scanGroup.Count.ToString()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub


End Class
