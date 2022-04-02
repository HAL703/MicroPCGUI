Imports Logix
Public Class Form1
    Inherits System.Windows.Forms.Form

    ' ****************************
    ' * Initialize Controller class
    Dim MyPLC As New Controller
    Dim MyTag As New Tag
    Dim i As Integer
    Dim frmWrite As New frmArrayWrite()
    Dim theData As Array
    Dim errMsg As String
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
    Friend WithEvents _path As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents _ipAddress As System.Windows.Forms.TextBox
    Friend WithEvents tagProps As System.Windows.Forms.GroupBox
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dataType As System.Windows.Forms.ComboBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents _values As System.Windows.Forms.ListBox
    Friend WithEvents _arrayItems As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents _tagName As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents btnDisconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents btnMicro As System.Windows.Forms.RadioButton
    Private WithEvents btnLogix As System.Windows.Forms.RadioButton
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._path = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._ipAddress = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tagProps = New System.Windows.Forms.GroupBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dataType = New System.Windows.Forms.ComboBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me._values = New System.Windows.Forms.ListBox()
        Me._arrayItems = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me._tagName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.btnMicro = New System.Windows.Forms.RadioButton()
        Me.btnLogix = New System.Windows.Forms.RadioButton()
        Me.tagProps.SuspendLayout()
        Me.SuspendLayout()
        '
        '_path
        '
        Me._path.Location = New System.Drawing.Point(88, 52)
        Me._path.Name = "_path"
        Me._path.Size = New System.Drawing.Size(155, 20)
        Me._path.TabIndex = 15
        Me._path.Text = "0"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(8, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 14
        Me.label2.Text = "CIP Path:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_ipAddress
        '
        Me._ipAddress.Location = New System.Drawing.Point(88, 28)
        Me._ipAddress.Name = "_ipAddress"
        Me._ipAddress.Size = New System.Drawing.Size(155, 20)
        Me._ipAddress.TabIndex = 13
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 16)
        Me.label1.TabIndex = 12
        Me.label1.Text = "IP Address:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tagProps
        '
        Me.tagProps.Controls.Add(Me.btnWrite)
        Me.tagProps.Controls.Add(Me.Label5)
        Me.tagProps.Controls.Add(Me.dataType)
        Me.tagProps.Controls.Add(Me.btnRead)
        Me.tagProps.Controls.Add(Me._values)
        Me.tagProps.Controls.Add(Me._arrayItems)
        Me.tagProps.Controls.Add(Me.label4)
        Me.tagProps.Controls.Add(Me._tagName)
        Me.tagProps.Controls.Add(Me.label3)
        Me.tagProps.Enabled = False
        Me.tagProps.Location = New System.Drawing.Point(5, 104)
        Me.tagProps.Name = "tagProps"
        Me.tagProps.Size = New System.Drawing.Size(295, 342)
        Me.tagProps.TabIndex = 26
        Me.tagProps.TabStop = False
        Me.tagProps.Text = "Tag Properties"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(103, 308)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(75, 23)
        Me.btnWrite.TabIndex = 34
        Me.btnWrite.Text = "Write"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Data Type"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dataType
        '
        Me.dataType.FormattingEnabled = True
        Me.dataType.Items.AddRange(New Object() {"BOOL[] -  (System.Boolean[])", "SINT[] - (System.SByte[])", "BYTE[] - (System.Byte[])", "INT[] -  (System.Int16[])", "WORD[] -  (System.UInt16[])", "DINT[] -  (System.Int32[])", "DWORD[] - (System.UInt32[])", "LINT[] - (System.Int64[])", "LWORD[] - (System.UInt64[])", "REAL[] -  (System.Single[])", "LREAL[] -  (System.Double[])", "STRING[] - (System.Sting[])"})
        Me.dataType.Location = New System.Drawing.Point(80, 45)
        Me.dataType.Name = "dataType"
        Me.dataType.Size = New System.Drawing.Size(157, 21)
        Me.dataType.TabIndex = 32
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(10, 308)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 31
        Me.btnRead.Text = "Read"
        '
        '_values
        '
        Me._values.HorizontalScrollbar = True
        Me._values.Location = New System.Drawing.Point(10, 103)
        Me._values.Name = "_values"
        Me._values.ScrollAlwaysVisible = True
        Me._values.Size = New System.Drawing.Size(272, 199)
        Me._values.TabIndex = 30
        '
        '_arrayItems
        '
        Me._arrayItems.Location = New System.Drawing.Point(82, 73)
        Me._arrayItems.Name = "_arrayItems"
        Me._arrayItems.Size = New System.Drawing.Size(72, 20)
        Me._arrayItems.TabIndex = 29
        Me._arrayItems.Text = "2"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(2, 75)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 16)
        Me.label4.TabIndex = 28
        Me.label4.Text = "Items:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tagName
        '
        Me._tagName.Location = New System.Drawing.Point(82, 20)
        Me._tagName.Name = "_tagName"
        Me._tagName.Size = New System.Drawing.Size(155, 20)
        Me._tagName.TabIndex = 27
        Me._tagName.Text = "Array[0]"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(2, 20)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 16)
        Me.label3.TabIndex = 26
        Me.label3.Text = "CPU Array:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(168, 78)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 31
        Me.btnDisconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(91, 78)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 30
        Me.btnConnect.Text = "Connect"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 5)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(72, 16)
        Me.label6.TabIndex = 29
        Me.label6.Text = "CPU Type:"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnMicro
        '
        Me.btnMicro.AutoSize = True
        Me.btnMicro.Location = New System.Drawing.Point(183, 5)
        Me.btnMicro.Name = "btnMicro"
        Me.btnMicro.Size = New System.Drawing.Size(60, 17)
        Me.btnMicro.TabIndex = 28
        Me.btnMicro.Text = "MICRO"
        Me.btnMicro.UseVisualStyleBackColor = True
        '
        'btnLogix
        '
        Me.btnLogix.AutoSize = True
        Me.btnLogix.Checked = True
        Me.btnLogix.Location = New System.Drawing.Point(96, 5)
        Me.btnLogix.Name = "btnLogix"
        Me.btnLogix.Size = New System.Drawing.Size(57, 17)
        Me.btnLogix.TabIndex = 27
        Me.btnLogix.TabStop = True
        Me.btnLogix.Text = "LOGIX"
        Me.btnLogix.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(306, 449)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btnMicro)
        Me.Controls.Add(Me.btnLogix)
        Me.Controls.Add(Me.tagProps)
        Me.Controls.Add(Me._path)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._ipAddress)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NETLOGIX - VB Read Array"
        Me.tagProps.ResumeLayout(False)
        Me.tagProps.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataType.SelectedIndex = 0
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Try

            frmWrite.dataArray = MyTag.Value
            frmWrite.dataType = Type.GetTypeCode(MyTag.NetType)

            If DialogResult.Cancel = frmWrite.ShowDialog() Then
                Return
            End If

            MyTag.Value = frmWrite.dataArray

            If MyPLC.WriteTag(MyTag) <> ResultCode.E_SUCCESS Then
                MessageBox.Show(MyPLC.ErrorString, Me.Text)
                Return
            End If

            updateValues()

        Catch ex As System.Exception

            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub updateValues()

        theData = MyTag.Value
        _values.Items.Clear()

        If MyPLC.ErrorCode = ResultCode.E_SUCCESS Then
            For i = 0 To theData.Length - 1
                _values.Items.Add("Item: " + i.ToString() + " = " + Convert.ToString(theData.GetValue(i)))
            Next
        Else
            _values.Items.Add("Error: " + MyTag.ErrorString)
        End If

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Try

            ''''''''''''''''''
            '' set controller properties
            MyPLC.IPAddress = _ipAddress.Text
            MyPLC.Path = _path.Text
            MyPLC.Timeout = 3000

            If (btnMicro.Checked) Then
                MyPLC.CPUType = Controller.CPU.MICRO
            Else
                MyPLC.CPUType = Controller.CPU.LOGIX
            End If

            If MyPLC.Connect() <> ResultCode.E_SUCCESS Then
                errMsg = "Error:" + MyPLC.ErrorCode.ToString() + " - " + MyPLC.ErrorString
                MessageBox.Show(errMsg, Me.Text)
                Return

            Else
                tagProps.Enabled = True

            End If

        Catch ex As SystemException
            MessageBox.Show(ex.Message, Me.Text)
        End Try


    End Sub

   
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try

            _values.Items.Clear()

            ' set controller properties
            MyPLC.IPAddress = _ipAddress.Text
            MyPLC.Path = _path.Text
            MyPLC.Timeout = 3000

            ' set tag properties
            MyTag.Name = _tagName.Text
            MyTag.Length = Convert.ToInt32(_arrayItems.Text)

            If MyTag.Length < 2 Then
                MessageBox.Show("Minimum array size is 2", Me.Text)
                Return
            End If


            Select Case (dataType.SelectedIndex)

                Case 0 ' BOOL 
                    If MyPLC.CPUType = Controller.CPU.LOGIX Then
                        MyTag.NetType = GetType(System.Boolean)
                    Else
                        MessageBox.Show("BOOL array (System.Boolean[]) not accessible from Micro850", Me.Text)
                        Return
                    End If

                Case 1 ' SINT
                    If MyPLC.CPUType = Controller.CPU.MICRO And MyTag.Length > 480 Then
                        MessageBox.Show("SINT array (System.SByte[]) max size = 480 items per block", Me.Text)
                        Return
                    Else
                        MyTag.NetType = GetType(System.SByte)
                    End If

                Case 2 ' BYTE
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        If (MyTag.Length > 480) Then
                            MessageBox.Show("BYTE array (System.Byte[]) max size = 480 items per block", Me.Text)
                            Return
                        Else
                            MyTag.NetType = GetType(System.Byte)
                        End If
                    Else
                        MessageBox.Show("BYTE array (System.Byte[]) unsupported data type by Logix CPU", Me.Text)
                        Return
                    End If

                Case 3 ' INT
                    If MyPLC.CPUType = Controller.CPU.MICRO And MyTag.Length > 240 Then
                        MessageBox.Show("INT array (System.Int16[]) max size = 240 items per block", Me.Text)
                        Return
                    Else
                        MyTag.NetType = GetType(System.Int16)
                    End If

                Case 4 ' WORD
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        If MyTag.Length > 240 Then
                            MessageBox.Show("WORD array (System.UInt16[]) max size = 240 items per block", Me.Text)
                            Return
                        Else
                            MyTag.NetType = GetType(System.UInt16)
                        End If
                    Else
                        MessageBox.Show("WORD array (System.UInt16[]) unsupported data type by Logix CPU", Me.Text)
                        Return
                    End If

                Case 5 'DINT
                    If MyPLC.CPUType = Controller.CPU.MICRO And MyTag.Length > 120 Then
                        MessageBox.Show("DINT array (System.Int32[]) max size = 120 items per block", Me.Text)
                        Return
                    Else
                        MyTag.NetType = GetType(System.Int32)
                    End If

                Case 6 ' DWORD
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        If (MyTag.Length > 120) Then
                            MessageBox.Show("DWORD array (System.UInt32[]) max size = 120 items per block", Me.Text)
                            Return
                        Else
                            MyTag.NetType = GetType(System.UInt32)
                        End If
                    Else
                        MessageBox.Show("DWORD array (System.UInt32[]) unsupported data type by Logix CPU", Me.Text)
                        Return
                    End If

                Case 7 'LINT
                    If MyPLC.CPUType = Controller.CPU.MICRO And MyTag.Length > 60 Then
                        MessageBox.Show("LINT array (System.Int64[]) max size = 60 items per block", Me.Text)
                        Return
                    Else
                        MyTag.NetType = GetType(System.Int64)
                    End If

                Case 8 ' LWORD
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        If (MyTag.Length > 60) Then
                            MessageBox.Show("LWORD array (System.UInt64[]) max size = 60 items per block", Me.Text)
                            Return
                        Else
                            MyTag.NetType = GetType(System.UInt64)
                        End If

                    Else
                        MessageBox.Show("LWORD array (System.UInt64[]) unsupported data type by Logix CPU", Me.Text)
                        Return
                    End If

                Case 9 'REAL
                    If (MyPLC.CPUType = Controller.CPU.MICRO And MyTag.Length > 120) Then
                        MessageBox.Show("LINT array (System.Single[]) max size = 120 items per block", Me.Text)
                        Return
                    End If
                    MyTag.NetType = GetType(System.Single)


                Case 10 ' LREAL
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        If (MyTag.Length > 60) Then
                            MessageBox.Show("LREAL array (System.Double[]) max size = 60 items per block", Me.Text)
                            Return
                        Else
                            MyTag.NetType = GetType(System.Double)
                        End If
                    Else
                        MessageBox.Show("LREAL array (System.Double[]) unsupported data type by Logix CPU", Me.Text)
                        Return
                    End If

                Case 11 ' STRING
                    If MyPLC.CPUType = Controller.CPU.MICRO Then
                        MessageBox.Show("STRING array (System.String[]) unsupported by Micro 800 CPU", Me.Text)
                        Return
                    End If

                    MyTag.NetType = GetType(System.String)
            End Select

            ' *'''''''''''''''''/
            ' *' read the item
            If MyPLC.ReadTag(MyTag) <> Logix.ResultCode.E_SUCCESS Then
                If MyPLC.ErrorCode = &H10312 Then
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag")
                Else
                    MessageBox.Show("Error: " + MyTag.ErrorString, Me.Text)
                End If
                Return
            End If

            theData = MyTag.Value

            For i = 0 To theData.Length - 1
                _values.Items.Add("Item: " + i.ToString() + " = " + Convert.ToString(theData(i)))
            Next

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub
End Class
