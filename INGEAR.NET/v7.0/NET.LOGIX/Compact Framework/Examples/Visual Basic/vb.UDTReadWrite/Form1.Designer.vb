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
        Me.btnStuctA_Write = New System.Windows.Forms.Button
        Me.btnStructA_Read = New System.Windows.Forms.Button
        Me.structA_wear = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.structA_errors = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.structA_travel = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.structA_limit7 = New System.Windows.Forms.CheckBox
        Me.structA_limit4 = New System.Windows.Forms.CheckBox
        Me.MainMenu2 = New System.Windows.Forms.MainMenu
        Me.label3 = New System.Windows.Forms.Label
        Me.Disconnect = New System.Windows.Forms.Button
        Me.btnConnect = New System.Windows.Forms.Button
        Me.cipPath = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.ipAddress = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnStuctA_Write
        '
        Me.btnStuctA_Write.Enabled = False
        Me.btnStuctA_Write.Location = New System.Drawing.Point(130, 151)
        Me.btnStuctA_Write.Name = "btnStuctA_Write"
        Me.btnStuctA_Write.Size = New System.Drawing.Size(98, 23)
        Me.btnStuctA_Write.TabIndex = 38
        Me.btnStuctA_Write.Text = "Write"
        '
        'btnStructA_Read
        '
        Me.btnStructA_Read.Location = New System.Drawing.Point(130, 122)
        Me.btnStructA_Read.Name = "btnStructA_Read"
        Me.btnStructA_Read.Size = New System.Drawing.Size(98, 23)
        Me.btnStructA_Read.TabIndex = 37
        Me.btnStructA_Read.Text = "Read"
        '
        'structA_wear
        '
        Me.structA_wear.Location = New System.Drawing.Point(67, 222)
        Me.structA_wear.Name = "structA_wear"
        Me.structA_wear.Size = New System.Drawing.Size(90, 21)
        Me.structA_wear.TabIndex = 36
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(12, 226)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 17)
        Me.label5.Text = "wear"
        '
        'structA_errors
        '
        Me.structA_errors.Location = New System.Drawing.Point(67, 199)
        Me.structA_errors.Name = "structA_errors"
        Me.structA_errors.Size = New System.Drawing.Size(90, 21)
        Me.structA_errors.TabIndex = 35
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(12, 203)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(40, 17)
        Me.label4.Text = "errors"
        '
        'structA_travel
        '
        Me.structA_travel.Location = New System.Drawing.Point(67, 177)
        Me.structA_travel.Name = "structA_travel"
        Me.structA_travel.Size = New System.Drawing.Size(90, 21)
        Me.structA_travel.TabIndex = 34
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(12, 181)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(49, 13)
        Me.label6.Text = "travel"
        '
        'structA_limit7
        '
        Me.structA_limit7.Location = New System.Drawing.Point(11, 151)
        Me.structA_limit7.Name = "structA_limit7"
        Me.structA_limit7.Size = New System.Drawing.Size(71, 20)
        Me.structA_limit7.TabIndex = 33
        Me.structA_limit7.Text = "limit7"
        '
        'structA_limit4
        '
        Me.structA_limit4.Location = New System.Drawing.Point(11, 125)
        Me.structA_limit4.Name = "structA_limit4"
        Me.structA_limit4.Size = New System.Drawing.Size(71, 20)
        Me.structA_limit4.TabIndex = 32
        Me.structA_limit4.Text = "limit4"
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label3.Location = New System.Drawing.Point(11, 106)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 16)
        Me.label3.Text = "STRUCT_A"
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(130, 79)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(100, 20)
        Me.Disconnect.TabIndex = 31
        Me.Disconnect.Text = "Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(11, 79)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(100, 20)
        Me.btnConnect.TabIndex = 30
        Me.btnConnect.Text = "Connect"
        '
        'cipPath
        '
        Me.cipPath.Location = New System.Drawing.Point(78, 52)
        Me.cipPath.Name = "cipPath"
        Me.cipPath.Size = New System.Drawing.Size(136, 21)
        Me.cipPath.TabIndex = 29
        Me.cipPath.Text = "0"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(11, 54)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 16)
        Me.label2.Text = "CIP PAth"
        '
        'ipAddress
        '
        Me.ipAddress.Location = New System.Drawing.Point(78, 25)
        Me.ipAddress.Name = "ipAddress"
        Me.ipAddress.Size = New System.Drawing.Size(136, 21)
        Me.ipAddress.TabIndex = 28
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(11, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 16)
        Me.label1.Text = "IP Address"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnStuctA_Write)
        Me.Controls.Add(Me.btnStructA_Read)
        Me.Controls.Add(Me.structA_wear)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.structA_errors)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.structA_travel)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.structA_limit7)
        Me.Controls.Add(Me.structA_limit4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.cipPath)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.ipAddress)
        Me.Controls.Add(Me.label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "UDT Read/Write"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnStuctA_Write As System.Windows.Forms.Button
    Private WithEvents btnStructA_Read As System.Windows.Forms.Button
    Private WithEvents structA_wear As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents structA_errors As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents structA_travel As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents structA_limit7 As System.Windows.Forms.CheckBox
    Private WithEvents structA_limit4 As System.Windows.Forms.CheckBox
    Private WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents Disconnect As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents cipPath As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents ipAddress As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
