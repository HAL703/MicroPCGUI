Imports Logix
Public Class Form1

    '* create instance of Controller class
    Dim MyPLC As New Controller()

    ' * create instance of tag glass
    ' * for scanning
    Dim scanGroup As New TagGroup()

    ' * create some simulated tags
    Dim simTagINT As New Tag()
    Dim simTagBOOL As New Tag()

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        ' * stop scanning and disconnect
        scanGroup.ScanStop()
        MyPLC.Disconnect()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' * set the tag properties
        SetTagProperties()

        ' * link tags to form controls
        LinkTagsToControls()
    End Sub

    Private Sub SetTagProperties()

        ' * set simulated tag properties and add to 
        ' * scan group
        simTagINT.Name = "intTag"
        simTagINT.DataType = Logix.Tag.ATOMIC.INT
        simTagINT.SimType = Logix.Tag.SIMULATION.UserMode
        scanGroup.AddTag(simTagINT)

        simTagBOOL.Name = "boolTag"
        simTagBOOL.DataType = Logix.Tag.ATOMIC.BOOL
        simTagBOOL.SimType = Logix.Tag.SIMULATION.UserMode
        scanGroup.AddTag(simTagBOOL)

    End Sub

    Private Sub LinkTagsToControls()

        '*  this demonstrates how to link Tag.Values to FormControls 
        '*  with Tag.UIItemAdd() method

        '*  the value for simTagINT is provide by trackBar1 control
        '*  use .UIItemAdd method to link simTagINT to progressBar1.Value
        simTagINT.UIItemAdd(New UIItem(progressBar1, "Value"))

        '*  use .UIItemAdd method to link simTagINT to label2.Text with formatting
        simTagINT.UIItemAdd(New UIItem(label2, "Text", "{0:0000}"))

        '*  use .UIItemAdd method to link simTagINT to label2.Backcolor that 
        '*  transistions from black to blue
        simTagINT.UIItemAdd(New UIItem(label2, "Backcolor", 0, Color.Black, 100, Color.Blue))

        '*  the value for simTagBOOL is toggled by the button1_Click event

        '*  for the button1 change the 
        simTagBOOL.UIItemAdd(New UIItem(button1, "Text", "RUN|STOP"))
        simTagBOOL.UIItemAdd(New UIItem(button1, "ForeColor", 0, Color.White, 1, Color.Black))
        simTagBOOL.UIItemAdd(New UIItem(button1, "BackColor", 0, Color.Green, 1, Color.Red))
        simTagBOOL.UIItemAdd(New UIItem(label5, "Text", "Stopped|Running"))
        simTagBOOL.UIItemAdd(New UIItem(label5, "ImageIndex"))


    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        '*  when Controller.Simulated = true
        '*  the Controller.IPAddress, .Path & .Timeout
        '*  properties are ignored for .Connect
        MyPLC.IPAddress = "192.168.1.40"
        MyPLC.Path = "0"

        '*  When .Simulate = true, no communication occurs
        '*  with physical PLC.
        MyPLC.Simulate = True

        '*  connect as though communicating to a 
        '*  physical device.
        MyPLC.Connect()

    End Sub

    Private Sub btnStartScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartScan.Click
        '*  assign instance of Controller class to TagGroup
        scanGroup.Controller = MyPLC

        '*  set scanning mode - ReadWrite is default
        scanGroup.ScanningMode = Logix.TagGroup.SCANMODE.ReadWrite

        '*  set scanGroup update interval in millisecs
        scanGroup.Interval = 500

        '*  start scanning
        scanGroup.ScanStart()

    End Sub

    Private Sub btnStopScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopScan.Click

        scanGroup.ScanStop()

    End Sub

    Private Sub trackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar1.Scroll

        ' * write simulated value from trackBar
        ' * scanGroup will automatically udpate
        simTagINT.Value = trackBar1.Value
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click


        If simTagBOOL.Value = False Then
            simTagBOOL.Value = True
        Else
            simTagBOOL.Value = False
        End If
    End Sub
End Class
