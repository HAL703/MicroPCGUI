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
        Me.msgType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsgCount = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(232, 82)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(133, 27)
        Me.btnClearList.TabIndex = 13
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 97)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(104, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Received Messages"
        '
        'btnShutdown
        '
        Me.btnShutdown.Enabled = False
        Me.btnShutdown.Location = New System.Drawing.Point(232, 53)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(133, 27)
        Me.btnShutdown.TabIndex = 11
        Me.btnShutdown.Text = "Shut Down"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(232, 24)
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
        Me.ipList.Location = New System.Drawing.Point(17, 27)
        Me.ipList.Name = "ipList"
        Me.ipList.Size = New System.Drawing.Size(137, 21)
        Me.ipList.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(228, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Receive messages on NIC with this IP Address"
        '
        'listView
        '
        Me.listView.Location = New System.Drawing.Point(2, 114)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(537, 213)
        Me.listView.TabIndex = 7
        Me.listView.UseCompatibleStateImageBehavior = False
        '
        'msgType
        '
        Me.msgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.msgType.FormattingEnabled = True
        Me.msgType.Items.AddRange(New Object() {"Ethernet CIP", "Legacy CSP"})
        Me.msgType.Location = New System.Drawing.Point(18, 73)
        Me.msgType.Name = "msgType"
        Me.msgType.Size = New System.Drawing.Size(137, 21)
        Me.msgType.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Message Type"
        '
        'lblMsgCount
        '
        Me.lblMsgCount.BackColor = System.Drawing.Color.White
        Me.lblMsgCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsgCount.Location = New System.Drawing.Point(439, 34)
        Me.lblMsgCount.Name = "lblMsgCount"
        Me.lblMsgCount.Size = New System.Drawing.Size(78, 17)
        Me.lblMsgCount.TabIndex = 20
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(375, 35)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Msg Count"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 334)
        Me.Controls.Add(Me.lblMsgCount)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.msgType)
        Me.Controls.Add(Me.Label3)
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
        Me.Text = "NETLOGIX Unsolicited Message (VB.NET Example)"
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
    Private WithEvents msgType As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents lblMsgCount As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label

End Class
