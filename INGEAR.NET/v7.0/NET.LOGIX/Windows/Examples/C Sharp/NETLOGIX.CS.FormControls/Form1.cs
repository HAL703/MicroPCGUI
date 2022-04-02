using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace NETLOGIX.CS.FormControls
{
    public partial class Form1 : Form
    {
        // create instance of Controller class
        Controller MyPLC = new Controller();

        // create instance of tag glass
        // for scanning
        TagGroup scanGroup = new TagGroup();

        // create some simulated
        Tag simTagINT = new Tag();
        Tag simTagBOOL = new Tag();


        public Form1()
        {
            InitializeComponent();

            // set tag properties
            SetTagProperties();

            // link to tags to form controls
            LinkTagsToFormControls();
  
        }

        private void SetTagProperties()
        {
            // set simulated tag properties and add to 
            // scan group

            simTagINT.Name = "intTag";
            simTagINT.DataType = Logix.Tag.ATOMIC.INT;
            simTagINT.SimType = Logix.Tag.SIMULATION.UserMode;
            scanGroup.AddTag(simTagINT);


            simTagBOOL.Name = "boolTag";
            simTagBOOL.DataType = Logix.Tag.ATOMIC.BOOL;
            simTagBOOL.SimType = Logix.Tag.SIMULATION.UserMode;
            scanGroup.AddTag(simTagBOOL);

/***
            simDintTag.Name = "dintTag";
            simDintTag.DataType = Logix.Tag.ATOMIC.DINT;
            simDintTag.SimType = Logix.Tag.SIMULATION.Ramp;
            scanGroup.AddTag(simDintTag);

            simRealTag.Name = "realTag";
            simRealTag.DataType = Logix.Tag.ATOMIC.REAL;
            simRealTag.SimType = Logix.Tag.SIMULATION.Sine;
            scanGroup.AddTag(simRealTag);
***/
        }

        private void LinkTagsToFormControls()
        {
            // this demonstrates how to link Tag.Values to FormControls 
            // with Tag.UIItemAdd() method

            // the value for simTagINT is provide by trackBar1 control
            // use .UIItemAdd method to link simTagINT to progressBar1.Value
            simTagINT.UIItemAdd(new UIItem(progressBar1,"Value"));

            // use .UIItemAdd method to link simTagINT to label2.Text with formatting
            simTagINT.UIItemAdd(new UIItem(label2,"Text","{0:0000}"));

            // use .UIItemAdd method to link simTagINT to label2.Backcolor that 
            // transistions from black to blue
            simTagINT.UIItemAdd(new UIItem(label2, "Backcolor",0, Color.Black, 100, Color.Blue));

            // the value for simTagBOOL is toggled by the button1_Click event

            // for the button1 change the 
            simTagBOOL.UIItemAdd(new UIItem(button1, "Text", "RUN|STOP"));
            simTagBOOL.UIItemAdd(new UIItem(button1, "ForeColor", 0, Color.White, 1, Color.Black));
            simTagBOOL.UIItemAdd(new UIItem(button1, "BackColor", 0, Color.Green, 1, Color.Red));
            simTagBOOL.UIItemAdd(new UIItem(label5, "Text", "Stopped|Running"));
            simTagBOOL.UIItemAdd(new UIItem(label5, "ImageIndex"));



        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            // when Controller.Simulated = true
            // the Controller.IPAddress, .Path & .Timeout
            // properties are ignored for .Connect
            MyPLC.IPAddress = "192.168.1.40";
            MyPLC.Path = "0";

            // simulate
            MyPLC.Simulate = true;

            // connect as though communicating to a 
            // physical device.
            MyPLC.Connect();

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            scanGroup.ScanStop();
            MyPLC.Disconnect();
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            // assign instance of Controller class to TagGroup
            scanGroup.Controller = MyPLC;

            // set scanning mode - ReadWrite is default
            scanGroup.ScanningMode = Logix.TagGroup.SCANMODE.ReadWrite;

            // set scanGroup update interval in millisecs
            scanGroup.Interval = 500;

            // start scanning
            scanGroup.ScanStart();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // update this tag 
            // scanGroup will automatically execute write
            simTagINT.Value = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simTagBOOL.Value = !Convert.ToBoolean(simTagBOOL.Value);
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            scanGroup.ScanStop();
        }


    }
}