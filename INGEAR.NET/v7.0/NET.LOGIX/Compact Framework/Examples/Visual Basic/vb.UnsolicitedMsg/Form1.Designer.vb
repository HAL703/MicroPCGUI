<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.listView = New System.Windows.Forms.ListView
        Me.MainMenu2 = New System.Windows.Forms.MainMenu
        Me.btnClearList = New System.Windows.Forms.Button
        Me.btnShutdown = New System.Windows.Forms.Button
        Me.btnListen = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.msgType = New System.Windows.Forms.ComboBox
        Me.ipList = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'listView
        '
        Me.listView.Location = New System.Drawing.Point(5, 113)
        Me.listView.Name = "listView"
        Me.listView.Size = New System.Drawing.Size(231, 147)
        Me.listView.TabIndex = 24
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(155, 80)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(81, 27)
        Me.btnClearList.TabIndex = 23
        Me.btnClearList.Text = "Clear Msgs"
        '
        'btnShutdown
        '
        Me.btnShutdown.Enabled = False
        Me.btnShutdown.Location = New System.Drawing.Point(155, 47)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(81, 27)
        Me.btnShutdown.TabIndex = 22
        Me.btnShutdown.Text = "Shut Down"
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(155, 14)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(81, 27)
        Me.btnListen.TabIndex = 21
        Me.btnListen.Text = "Listen"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(12, 53)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(123, 13)
        Me.label3.Text = "Message Type"
        '
        'msgType
        '
        Me.msgType.Items.Add("Ethernet CIP")
        Me.msgType.Items.Add("Legacy CSP")
        Me.msgType.Location = New System.Drawing.Point(11, 69)
        Me.msgType.Name = "msgType"
        Me.msgType.Size = New System.Drawing.Size(137, 22)
        Me.msgType.TabIndex = 20
        '
        'ipList
        '
        Me.ipList.Items.Add("Any")
        Me.ipList.Location = New System.Drawing.Point(12, 29)
        Me.ipList.Name = "ipList"
        Me.ipList.Size = New System.Drawing.Size(137, 22)
        Me.ipList.TabIndex = 19
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(228, 13)
        Me.label1.Text = "Use NIC with IP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.listView)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.btnListen)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.msgType)
        Me.Controls.Add(Me.ipList)
        Me.Controls.Add(Me.label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "VB Unsolicited Msg"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listView As System.Windows.Forms.ListView
    Private WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Private WithEvents btnClearList As System.Windows.Forms.Button
    Private WithEvents btnShutdown As System.Windows.Forms.Button
    Private WithEvents btnListen As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents msgType As System.Windows.Forms.ComboBox
    Private WithEvents ipList As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
