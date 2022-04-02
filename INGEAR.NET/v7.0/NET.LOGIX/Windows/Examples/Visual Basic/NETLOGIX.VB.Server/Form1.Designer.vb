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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.ipList = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.listView = New System.Windows.Forms.ListView()
        Me.lblMsgCount = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ipPort = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(402, 170)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(133, 27)
        Me.btnClearList.TabIndex = 13
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(402, 205)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Received Messages"
        '
        'btnShutdown
        '
        Me.btnShutdown.Enabled = False
        Me.btnShutdown.Location = New System.Drawing.Point(402, 141)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(133, 27)
        Me.btnShutdown.TabIndex = 11
        Me.btnShutdown.Text = "Shut Down"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(402, 112)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(133, 27)
        Me.btnListen.TabIndex = 10
        Me.btnListen.Text = "Listen"
        Me.btnListen.UseVisualStyleBackColor = True
        '
        'ipList
        '
        Me.ipList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ipList.FormattingEnabled = True
        Me.ipList.Items.AddRange(New Object() {"Any"})
        Me.ipList.Location = New System.Drawing.Point(398, 41)
        Me.ipList.Name = "ipList"
        Me.ipList.Size = New System.Drawing.Size(137, 21)
        Me.ipList.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(394, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(164, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Recv on NIC with this IP Address"
        '
        'listView
        '
        Me.listView.Location = New System.Drawing.Point(11, 336)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(556, 213)
        Me.listView.TabIndex = 7
        Me.listView.UseCompatibleStateImageBehavior = False
        '
        'lblMsgCount
        '
        Me.lblMsgCount.BackColor = System.Drawing.Color.White
        Me.lblMsgCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsgCount.Location = New System.Drawing.Point(466, 223)
        Me.lblMsgCount.Name = "lblMsgCount"
        Me.lblMsgCount.Size = New System.Drawing.Size(78, 17)
        Me.lblMsgCount.TabIndex = 20
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(402, 224)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Msg Count"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "44818 is default"
        '
        'ipPort
        '
        Me.ipPort.BackColor = System.Drawing.Color.White
        Me.ipPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipPort.Location = New System.Drawing.Point(457, 73)
        Me.ipPort.Name = "ipPort"
        Me.ipPort.Size = New System.Drawing.Size(78, 17)
        Me.ipPort.TabIndex = 59
        Me.ipPort.Text = "44818"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(405, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "IP Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "NET.LOGIX Server Example"
        '
        'dataGrid
        '
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Value})
        Me.dataGrid.Location = New System.Drawing.Point(11, 40)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersWidth = 150
        Me.dataGrid.Size = New System.Drawing.Size(362, 290)
        Me.dataGrid.TabIndex = 61
        '
        'Value
        '
        Me.Value.FillWeight = 200.0!
        Me.Value.HeaderText = "Value"
        Me.Value.MinimumWidth = 200
        Me.Value.Name = "Value"
        Me.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Value.Width = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 555)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ipPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMsgCount)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.btnListen)
        Me.Controls.Add(Me.ipList)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NETLOGIX Server (VB.NET Example)"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnClearList As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnShutdown As System.Windows.Forms.Button
    Private WithEvents btnListen As System.Windows.Forms.Button
    Private WithEvents ipList As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents listView As System.Windows.Forms.ListView
    Private WithEvents lblMsgCount As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents ipPort As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dataGrid As System.Windows.Forms.DataGridView
    Private WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
