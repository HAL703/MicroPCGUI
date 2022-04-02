<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class vbnetcf
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vbnetcf))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ipAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.path = New System.Windows.Forms.TextBox
        Me.btnConnect = New System.Windows.Forms.Button
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.tagProps = New System.Windows.Forms.Panel
        Me.results = New System.Windows.Forms.ListBox
        Me.dataValue = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnWrite = New System.Windows.Forms.Button
        Me.btnRead = New System.Windows.Forms.Button
        Me.btnString = New System.Windows.Forms.RadioButton
        Me.btnBoolArray = New System.Windows.Forms.RadioButton
        Me.btnAtomic = New System.Windows.Forms.RadioButton
        Me.tagName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tagProps.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.Text = "IP Address:"
        '
        'ipAddress
        '
        Me.ipAddress.Location = New System.Drawing.Point(76, 6)
        Me.ipAddress.Name = "ipAddress"
        Me.ipAddress.Size = New System.Drawing.Size(154, 21)
        Me.ipAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 12)
        Me.Label2.Text = "Path"
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(76, 33)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(154, 21)
        Me.path.TabIndex = 3
        Me.path.Text = "0"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(14, 60)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(100, 30)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(127, 60)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(100, 30)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Disconnect"
        '
        'tagProps
        '
        Me.tagProps.Controls.Add(Me.results)
        Me.tagProps.Controls.Add(Me.dataValue)
        Me.tagProps.Controls.Add(Me.Label4)
        Me.tagProps.Controls.Add(Me.btnWrite)
        Me.tagProps.Controls.Add(Me.btnRead)
        Me.tagProps.Controls.Add(Me.btnString)
        Me.tagProps.Controls.Add(Me.btnBoolArray)
        Me.tagProps.Controls.Add(Me.btnAtomic)
        Me.tagProps.Controls.Add(Me.tagName)
        Me.tagProps.Controls.Add(Me.Label3)
        Me.tagProps.Enabled = False
        Me.tagProps.Location = New System.Drawing.Point(0, 98)
        Me.tagProps.Name = "tagProps"
        Me.tagProps.Size = New System.Drawing.Size(239, 193)
        '
        'results
        '
        Me.results.Location = New System.Drawing.Point(5, 127)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(226, 58)
        Me.results.TabIndex = 9
        '
        'dataValue
        '
        Me.dataValue.Location = New System.Drawing.Point(82, 100)
        Me.dataValue.Name = "dataValue"
        Me.dataValue.Size = New System.Drawing.Size(147, 21)
        Me.dataValue.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.Text = "Value"
        '
        'btnWrite
        '
        Me.btnWrite.Enabled = False
        Me.btnWrite.Location = New System.Drawing.Point(127, 59)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(100, 30)
        Me.btnWrite.TabIndex = 6
        Me.btnWrite.Text = "Write"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(14, 59)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(100, 30)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read"
        '
        'btnString
        '
        Me.btnString.Location = New System.Drawing.Point(177, 34)
        Me.btnString.Name = "btnString"
        Me.btnString.Size = New System.Drawing.Size(59, 20)
        Me.btnString.TabIndex = 4
        Me.btnString.TabStop = False
        Me.btnString.Text = "String"
        '
        'btnBoolArray
        '
        Me.btnBoolArray.Location = New System.Drawing.Point(86, 34)
        Me.btnBoolArray.Name = "btnBoolArray"
        Me.btnBoolArray.Size = New System.Drawing.Size(85, 20)
        Me.btnBoolArray.TabIndex = 3
        Me.btnBoolArray.TabStop = False
        Me.btnBoolArray.Text = "Bool Array"
        '
        'btnAtomic
        '
        Me.btnAtomic.Checked = True
        Me.btnAtomic.Location = New System.Drawing.Point(9, 34)
        Me.btnAtomic.Name = "btnAtomic"
        Me.btnAtomic.Size = New System.Drawing.Size(65, 20)
        Me.btnAtomic.TabIndex = 2
        Me.btnAtomic.Text = "Atomic"
        '
        'tagName
        '
        Me.tagName.Location = New System.Drawing.Point(79, 7)
        Me.tagName.Name = "tagName"
        Me.tagName.Size = New System.Drawing.Size(151, 21)
        Me.tagName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.Text = "TagName"
        '
        'vbnetcf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.tagProps)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ipAddress)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "vbnetcf"
        Me.Text = "NETLOGIX (Compact Framework)"
        Me.tagProps.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ipAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents path As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents tagProps As System.Windows.Forms.Panel
    Friend WithEvents btnBoolArray As System.Windows.Forms.RadioButton
    Friend WithEvents btnAtomic As System.Windows.Forms.RadioButton
    Friend WithEvents tagName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dataValue As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnString As System.Windows.Forms.RadioButton
    Friend WithEvents results As System.Windows.Forms.ListBox

End Class
