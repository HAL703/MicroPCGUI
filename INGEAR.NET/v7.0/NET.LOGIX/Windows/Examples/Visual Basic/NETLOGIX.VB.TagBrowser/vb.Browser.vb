
Imports System.Threading
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

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
    Friend WithEvents _ipaddress As System.Windows.Forms.TextBox
    Private WithEvents chkProgramTags As System.Windows.Forms.CheckBox
    Private WithEvents chkGlobalTags As System.Windows.Forms.CheckBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents filterType As System.Windows.Forms.TextBox
    Private WithEvents filtrName As System.Windows.Forms.TextBox
    Private WithEvents btnRefresh As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnMicro8xx As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me._ipaddress = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.chkProgramTags = New System.Windows.Forms.CheckBox()
        Me.chkGlobalTags = New System.Windows.Forms.CheckBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.filterType = New System.Windows.Forms.TextBox()
        Me.filtrName = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMicro8xx = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me._groupProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(139, 72)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 24)
        Me.btnDisconnect.TabIndex = 38
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(67, 72)
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
        Me._groupProperties.Location = New System.Drawing.Point(218, 3)
        Me._groupProperties.Name = "_groupProperties"
        Me._groupProperties.Size = New System.Drawing.Size(238, 72)
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
        Me._btnChangeRate.Location = New System.Drawing.Point(157, 16)
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
        Me._path.Location = New System.Drawing.Point(67, 48)
        Me._path.Name = "_path"
        Me._path.Size = New System.Drawing.Size(144, 20)
        Me._path.TabIndex = 35
        Me._path.Text = "0"
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(0, 48)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(64, 16)
        Me.label15.TabIndex = 34
        Me.label15.Text = "Path"
        '
        '_tagView
        '
        Me._tagView.AllowDrop = True
        Me._tagView.Enabled = False
        Me._tagView.GridLines = True
        Me._tagView.Location = New System.Drawing.Point(7, 358)
        Me._tagView.Name = "_tagView"
        Me._tagView.Size = New System.Drawing.Size(758, 212)
        Me._tagView.TabIndex = 32
        Me._tagView.UseCompatibleStateImageBehavior = False
        '
        '_ipaddress
        '
        Me._ipaddress.Location = New System.Drawing.Point(67, 25)
        Me._ipaddress.Name = "_ipaddress"
        Me._ipaddress.Size = New System.Drawing.Size(144, 20)
        Me._ipaddress.TabIndex = 30
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(1, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 29
        Me.label1.Text = "IP Address"
        '
        'chkProgramTags
        '
        Me.chkProgramTags.AutoSize = True
        Me.chkProgramTags.Checked = True
        Me.chkProgramTags.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProgramTags.Location = New System.Drawing.Point(465, 98)
        Me.chkProgramTags.Name = "chkProgramTags"
        Me.chkProgramTags.Size = New System.Drawing.Size(130, 17)
        Me.chkProgramTags.TabIndex = 50
        Me.chkProgramTags.Text = "Include Program Tags"
        Me.chkProgramTags.UseVisualStyleBackColor = True
        '
        'chkGlobalTags
        '
        Me.chkGlobalTags.AutoSize = True
        Me.chkGlobalTags.Checked = True
        Me.chkGlobalTags.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGlobalTags.Location = New System.Drawing.Point(465, 78)
        Me.chkGlobalTags.Name = "chkGlobalTags"
        Me.chkGlobalTags.Size = New System.Drawing.Size(121, 17)
        Me.chkGlobalTags.TabIndex = 49
        Me.chkGlobalTags.Text = "Include Global Tags"
        Me.chkGlobalTags.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(374, 76)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(61, 16)
        Me.label6.TabIndex = 48
        Me.label6.Text = "By Type"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(259, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "By Name"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(157, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Search Filters"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'filterType
        '
        Me.filterType.Location = New System.Drawing.Point(361, 95)
        Me.filterType.Name = "filterType"
        Me.filterType.Size = New System.Drawing.Size(100, 20)
        Me.filterType.TabIndex = 45
        '
        'filtrName
        '
        Me.filtrName.Location = New System.Drawing.Point(248, 95)
        Me.filtrName.Name = "filtrName"
        Me.filtrName.Size = New System.Drawing.Size(100, 20)
        Me.filtrName.TabIndex = 44
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Location = New System.Drawing.Point(601, 76)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 36)
        Me.btnRefresh.TabIndex = 43
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(463, -1)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(307, 75)
        Me.textBox1.TabIndex = 42
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'treeView1
        '
        Me.treeView1.AllowDrop = True
        Me.treeView1.Location = New System.Drawing.Point(7, 121)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.ShowNodeToolTips = True
        Me.treeView1.Size = New System.Drawing.Size(760, 231)
        Me.treeView1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "CPU Type"
        '
        'btnMicro8xx
        '
        Me.btnMicro8xx.AutoSize = True
        Me.btnMicro8xx.Location = New System.Drawing.Point(145, 4)
        Me.btnMicro8xx.Name = "btnMicro8xx"
        Me.btnMicro8xx.Size = New System.Drawing.Size(51, 17)
        Me.btnMicro8xx.TabIndex = 52
        Me.btnMicro8xx.Text = "Micro"
        Me.btnMicro8xx.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(78, 4)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(50, 17)
        Me.btnLogix.TabIndex = 51
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "Logix"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(775, 574)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMicro8xx)
        Me.Controls.Add(Me.btnLogix)
        Me.Controls.Add(Me.chkProgramTags)
        Me.Controls.Add(Me.chkGlobalTags)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.filterType)
        Me.Controls.Add(Me.filtrName)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.treeView1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me._groupProperties)
        Me.Controls.Add(Me._path)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me._tagView)
        Me.Controls.Add(Me._ipaddress)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NET.LOGIX Browse, Drag-Drop and Monitor"
        Me._groupProperties.ResumeLayout(False)
        Me._groupProperties.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' *****************************
    ' * Initialize Controller class
    Public MyPLC As New Controller

    ' ******************************
    ' * Initialize TagGroup class
    Public MyGroup As New TagGroup

    ' ******************************
    ' * un-initialized Tag class
    Dim WithEvents newTag As Tag

    ' tag class for CPU info
    Dim cpuInfo As New Tag("@CPU_INFO")
    Dim cpuState As New Tag("@CPU_STATE")

    Dim progName As String = ""
    Dim rootName As String = ""

    Dim rootNode As New TreeNode()

    ' cpu program collection
    Dim programList As ReadOnlyCollection(Of Program)

    ' tag template collection list
    Dim tagList As ReadOnlyCollection(Of TagTemplate)



    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            ' * stop scan thread
            MyGroup.ScanStop()
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

        _tagView.Columns.Add("Tag Name", 300, HorizontalAlignment.Left)
        _tagView.Columns.Add("Value", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Data Type", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Quality", 100, HorizontalAlignment.Left)
        _tagView.Columns.Add("Time Stamp", 140, HorizontalAlignment.Left)

        ' set scangroup properties
        MyGroup.Controller = MyPLC
        MyGroup.ScanningMode = TagGroup.SCANMODE.ReadWrite
        MyGroup.Interval = 1000

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        Dim msg As String

        ' connect to the PLC
        Try

            ' set the IP Addres, Path
            ' properties.  We'll also set
            ' the timeout property to 3000ms
            MyPLC.IPAddress = _ipaddress.Text
            MyPLC.Path = _path.Text
            MyPLC.Timeout = 3000

            Me.Cursor = Cursors.WaitCursor

            ' let's connect 
            If ResultCode.E_SUCCESS = MyPLC.Connect() Then

                _groupProperties.Enabled = True
                btnDisconnect.Enabled = True
                btnConnect.Enabled = False
                _tagView.Enabled = True
                Me.Cursor = Cursors.Default

                ' read CPU state & upload tags
                GetPLCInfoAndState()

                UploadTags()
                btnRefresh.Enabled = True

                ' Step 1: assign parent Controller class and start scanning
                MyGroup.Controller = MyPLC
                MyGroup.Interval = Convert.ToInt32(_updateRate.Text)
                MyGroup.ScanStart()
            Else
                msg = "ERROR:" + MyPLC.ErrorCode.ToString() + " - " + MyPLC.ErrorString
                MessageBox.Show(msg, Me.Text)
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click

        Try

            ' stop scanning
            MyGroup.ScanStop()

            ' disconnect the PLC
            MyPLC.Disconnect()

            _groupProperties.Enabled = False
            btnDisconnect.Enabled = False
            btnConnect.Enabled = True
            _tagView.Enabled = False

            ' clean up the treeview, listview
            ' and remove items from Group
            MyGroup.Clear()
            _tagView.Items.Clear()
            treeView1.Nodes.Clear()
            rootNode.Nodes.Clear()
            _itemCount.Text = MyGroup.Count.ToString()
            _tagView.Enabled = False
            btnRefresh.Enabled = False

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub GetPLCInfoAndState()

        Me.Cursor = Cursors.WaitCursor

        ' read CPU info
        If MyPLC.ReadTag(cpuInfo) <> ResultCode.E_SUCCESS Then

            If MyPLC.ErrorCode = &H10312 Then
                MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
            Else
                MessageBox.Show(MyPLC.ErrorString)
            End If
            Return
        End If


        Dim plcInfo() As String = cpuInfo.Value
        rootNode.Text = "Controller " + plcInfo(0)
        rootNode.ToolTipText = plcInfo(1) + Environment.NewLine
        rootNode.ToolTipText += "Firmware: " + plcInfo(2) + Environment.NewLine

        ' CPU State supported by LOGIX CPU only
        If MyPLC.CPUType = Controller.CPU.LOGIX And _path.Text.Length > 0 Then

            ' read CPU State
            If MyPLC.ReadTag(cpuState) = ResultCode.E_SUCCESS Then

                ' returns a 3-element System.Int32()
                Dim stateValue() As Integer = cpuState.Value

                ' Value 0 - OK LED State
                Select Case stateValue(0)
                    Case 0
                        rootNode.ToolTipText += "CPU: Power Up"
                    Case 1
                        rootNode.ToolTipText += "CPU: FRN Update"
                    Case 2
                        rootNode.ToolTipText += "CPU: Comms Fault"
                    Case 3
                        rootNode.ToolTipText += "CPU: Awaiting Connection"
                    Case 4
                        rootNode.ToolTipText += "CPU: Bad Config"
                    Case 5
                        rootNode.ToolTipText += "CPU: Major Flt"
                    Case 6
                        rootNode.ToolTipText += "CPU: Connected"
                    Case 7
                        rootNode.ToolTipText += "CPU: Program Mode"
                End Select

                rootNode.ToolTipText += Environment.NewLine

                ' Value{1) power up state
                Select Case (stateValue(1))

                    Case 0
                        rootNode.ToolTipText += "CPU: No Fault"
                    Case 1
                        rootNode.ToolTipText += "CPU: Minor Recoverable Fault"
                    Case 2
                        rootNode.ToolTipText += "CPU: Minor Unrecoverable Fault"
                    Case 3
                        rootNode.ToolTipText += "CPU: Major Recoverable Fault"
                    Case 4
                        rootNode.ToolTipText += "CPU: Major Unrecoverable Fault"
                End Select

                rootNode.ToolTipText += Environment.NewLine

                ' Value 2 - Key Switch Position
                Select Case (stateValue(2))
                    Case 1
                        rootNode.ToolTipText += "KeySelect Case: RUN"
                    Case 2
                        rootNode.ToolTipText += "KeySelect Case: PROG"
                    Case 3
                        rootNode.ToolTipText += "KeySelect Case: REM"
                End Select

            End If
        End If

        treeView1.Nodes.Add(rootNode)
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub UploadTags()

        ' upload tags from PLC
        Me.Cursor = Cursors.WaitCursor
        If MyPLC.UploadTags(True) <> ResultCode.E_SUCCESS Then
            MessageBox.Show(MyPLC.ErrorString)
            Return
        End If

        Me.Cursor = Cursors.Default
        CreateTagTree()

    End Sub


    Private Sub CreateTagTree()

        Me.Cursor = Cursors.WaitCursor
        ' list of program names
        programList = MyPLC.ProgramList

        For Each cpuProgram As Program In programList
            ' if program is Name empty
            ' then these are Global tags
            If cpuProgram.Name = "" Then
                progName = "Global"
                If (False = chkGlobalTags.Checked) Then
                    Continue For
                End If
            Else
                progName = cpuProgram.Name
                If False = chkProgramTags.Checked Then
                    Continue For
                End If
            End If

            ' create TreeView nodes for Program Names
            Dim prgNode As New TreeNode(progName)

            rootNode.Nodes.Add(prgNode)

            ' get collection of TagItems in 
            ' filters "*" returns all tag names & atomic types
            tagList = cpuProgram.TagItems(filtrName.Text, filterType.Text, False)

            ' create a node for each tagTemplate
            For Each template As TagTemplate In tagList

                Dim tagNode As New TreeNode(template.Name)
                tagNode.Tag = template
                AddNode(prgNode, template)
            Next
        Next
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub AddNode(parent As TreeNode, template As TagTemplate)

        Dim parentName As String = parent.Text
        Dim itemName As String = ""

        If parentName.IndexOf(progName) = 0 Then
            parentName = parentName.Substring(progName.Length)
        End If

        If parentName.Length = 0 Then
            itemName = template.Name
        Else
            itemName = parentName + "." + template.Name
            If itemName(0) = "." Then
                itemName = itemName.Substring(1)
            End If
        End If

        Dim node As New TreeNode(itemName)
        parent.Nodes.Add(node)

        ' attache template to node
        node.Tag = template
        node.ToolTipText = ToolTipInfo(template)

        Dim memberList As ReadOnlyCollection(Of TagTemplate) = template.Members

        ' * if this is an array
        If template.IsArray Then
            Dim dim1 As Integer = template.ArraySize(0)
            Dim dim2 As Integer = template.ArraySize(1)
            Dim dim3 As Integer = template.ArraySize(2)

            Dim subItem As String = ""
            Dim x As Integer
            Dim y As Integer
            Dim z As Integer

            If template.ArrayDims = 1 Then
                For x = 0 To dim1 - 1

                    subItem = String.Format("{0}.{1}[{2:d}]", parentName, template.Name, x)

                    ' * remove leading '.' if it exists
                    If subItem(0) = "." Then
                        subItem = subItem.Substring(1)
                    End If

                    '*  add the node to the treeview
                    Dim subNode As New TreeNode(subItem)
                    node.Nodes.Add(subNode)
                    subNode.Tag = template

                    For Each member As TagTemplate In memberList
                        AddNode(subNode, member)
                    Next
                Next

            ElseIf template.ArrayDims = 2 Then

                For x = 0 To dim1 - 1
                    For y = 0 To dim2 - 1

                        subItem = String.Format("{0}.{1}[{2:d},{3:d}]", parentName, template.Name, x, y)

                        ' * remove leading '.' if it exists
                        If subItem(0) = "." Then
                            subItem = subItem.Substring(1)
                        End If

                        '*  add the node to the treeview
                        Dim subNode As New TreeNode(subItem)
                        node.Nodes.Add(subNode)
                        subNode.Tag = template

                        For Each member As TagTemplate In memberList
                            AddNode(subNode, member)
                        Next
                    Next
                Next

            ElseIf template.ArrayDims = 2 Then

                For x = 0 To dim1 - 1
                    For y = 0 To dim2 - 1
                        For z = 0 To dim3 - 1
                            subItem = String.Format("{0}.{1}[{2:d},{3:d},{4:d}]", parentName, template.Name, x, y, z)

                            ' * remove leading '.' if it exists
                            If subItem(0) = "." Then
                                subItem = subItem.Substring(1)
                            End If

                            '*  add the node to the treeview
                            Dim subNode As New TreeNode(subItem)
                            node.Nodes.Add(subNode)
                            subNode.Tag = template

                            For Each member As TagTemplate In memberList
                                AddNode(subNode, member)
                            Next
                        Next
                    Next
                Next
            End If

        Else

            ' if template has members
            For Each member As TagTemplate In memberList
                AddNode(node, member)
            Next
        End If

    End Sub

    Function ToolTipInfo(template As TagTemplate) As String

        Dim tipInfo As String = "DATA TYPE = " + template.TypeName + Environment.NewLine
        If (template.IsAtomic) Then
            tipInfo += "ATOMIC" + Environment.NewLine
        ElseIf template.IsString Then
            tipInfo += "STRING" + Environment.NewLine
            tipInfo += template.StringSize.ToString() + " Chars"
        End If

        If template.IsArray Then

            If (template.ArrayDims = 1) Then
                tipInfo += "DIMS[" + template.ArraySize(0).ToString() + "]" + Environment.NewLine
            ElseIf (template.ArrayDims = 2) Then
                tipInfo += "DIMS[" + template.ArraySize(0).ToString() + "," + template.ArraySize(1).ToString() + "]" + Environment.NewLine
            ElseIf (template.ArrayDims = 3) Then
                tipInfo += "DIMS[" + template.ArraySize(0).ToString() + "," + template.ArraySize(0).ToString() + "," + template.ArraySize(0).ToString() + "]" + Environment.NewLine

            End If
        End If

        Return tipInfo

    End Function

    Private Sub MakeNewTag(ByVal theNewTag As Tag, ByVal node As TreeNode)
        Try

            ' the TreeNode.Tag is null
            ' this TreeNode does not contain
            ' a TagTemplate
            If node.Tag Is Nothing Then
                Return
            End If

            ' * make sure this is the last node in the tree
            If node.Nodes.Count <> 0 Then
                Return
            End If

            ' get the TagTemplate
            Dim tagTmp As TagTemplate = node.Tag

            theNewTag = New Tag(node.Text)

            ' * if the tag is an array, use the treenode text
            '
            If tagTmp.IsString Then
                theNewTag.DataType = Logix.Tag.ATOMIC.STRING
                If (tagTmp.StringSize <> 82) Then
                    theNewTag.Name = node.Text + "#" + tagTmp.StringSize.ToString()
                End If

            ElseIf tagTmp.TypeName = "BOOL" Then
                theNewTag.DataType = Logix.Tag.ATOMIC.BOOL
            End If

            ' if the quality is good add the tag
            ' to the tag list
            If (ResultCode.E_SUCCESS = MyPLC.ReadTag(theNewTag)) Then

                ' add event handler
                ' this event handler will be common
                ' for all tags

                AddHandler theNewTag.Changed, AddressOf newTag_Changed


                ' * add the Tag Name to the 
                ' * ListView
                Dim tagListItem As ListViewItem = _tagView.Items.Add(theNewTag.Name)

                ' * use Tag.MyObject to remember
                ' * its reference in the ListView (_tagView)
                ' *
                ' * we'll use this for updating
                ' * the ListView when we get a DataChange
                ' * event
                theNewTag.MyObject = tagListItem

                ' * also, we'll reference newTag
                ' * in the tagListItem
                ' *
                ' * we'll use this for referencing
                ' * the tag when we click on the ListView
                tagListItem.Tag = theNewTag

                ' * display something for the value
                ' * to create the listview item
                tagListItem.SubItems.Add(theNewTag.Value.ToString())

                ' * display data type in the listview
                tagListItem.SubItems.Add(theNewTag.NetType.ToString())

                ' * and the quality string
                tagListItem.SubItems.Add(theNewTag.QualityString)

                ' * and the timestamp
                tagListItem.SubItems.Add(theNewTag.TimeStamp.ToString())

                ' * add the tag to the tag group
                MyGroup.AddTag(theNewTag)

                ' display number of tags
                ' in group
                _itemCount.Text = MyGroup.Count.ToString()
            Else
                MessageBox.Show(newTag.ErrorString, Me.Text)
            End If

        Catch ex As System.Exception

            MessageBox.Show(ex.Message, Me.Text)

        End Try
    End Sub
    Private Sub AddTag(node As TreeNode)
        MakeNewTag(newTag, node)
    End Sub


    Public Delegate Sub changedDelegate(ByVal e As System.EventArgs)


    Private Sub tagChanged(ByVal e As System.EventArgs)

        Try

            Dim tagViewItem As ListViewItem
            ' * data change event args associated with the tag
            Dim args As Logix.DataChangeEventArgs

            args = e

            ' * retrieve the ListViewItem associated
            ' * with the Tag class
            tagViewItem = args.MyObject

            ' * we' ll check the QUALITY of the 
            ' * tag.  If we' ve got a good quality
            ' * we'll update the list view items.
            If Logix.ResultCode.QUAL_GOOD = args.QualityCode Then
                tagViewItem.SubItems(1).Text = Convert.ToString(args.Value)
                tagViewItem.SubItems(4).Text = args.TimeStamp.ToString()
            Else
                tagViewItem.SubItems(1).Text = "????"
            End If

            ' * we'll always display
            ' * the quality string
            tagViewItem.SubItems(3).Text = args.QualityString

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
        ' * change the scan time update rate
        MyGroup.Interval = Convert.ToInt32(_updateRate.Text)
    End Sub

    Private Sub _tagView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _tagView.MouseDown

        Dim theTag As Tag

        Dim theItem As ListView
        Dim tagWriteDlg As New frmTagWrite

        ' * if there's nothing in the
        ' * _tagView or clicks are < 2
        ' * the exit
        If 0 = _tagView.Items.Count Or e.Clicks <> 2 Then
            Exit Sub
        End If

        ' ***********************
        ' * process for exceptions
        ' *
        Try
            ' * get the selected item
            ' * and the reference to Tag
            ' * that we associated with the item
            ' *
            theItem = sender
            theTag = theItem.FocusedItem.Tag

            ' * LEFT Mouse is Write Tag
            If MouseButtons.Left = e.Button Then

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
                MyGroup.RemoveTag(theTag)

                ' *****************************
                ' * remove the tag list item
                ' *
                _tagView.Items.Remove(theItem.FocusedItem)

                _itemCount.Text = MyGroup.Count.ToString()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        rootNode.Nodes.Clear()
        CreateTagTree()

    End Sub

    Private Sub _tagView_DragDrop(sender As Object, e As DragEventArgs) Handles _tagView.DragDrop
        If e.Data.GetDataPresent(GetType(TreeNode)) Then
            Dim node As TreeNode = e.Data.GetData(GetType(TreeNode))
            AddTag(node)
        End If
    End Sub

    Private Sub _tagView_DragEnter(sender As Object, e As DragEventArgs) Handles _tagView.DragEnter

        If e.Data.GetDataPresent(GetType(TreeNode)) Then
            e.Effect = DragDropEffects.Move
        End If

    End Sub

    Private Sub treeView1_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles treeView1.ItemDrag
        treeView1.DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub btnLogix_CheckedChanged(sender As Object, e As EventArgs) Handles btnLogix.CheckedChanged
        MyPLC.CPUType = Controller.CPU.LOGIX
    End Sub

    Private Sub btnMicro8xx_CheckedChanged(sender As Object, e As EventArgs) Handles btnMicro8xx.CheckedChanged
        MyPLC.CPUType = Controller.CPU.MICRO
    End Sub
End Class
