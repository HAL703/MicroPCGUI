using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace NETLOGIX.CS.Scaling
{
    public partial class Form1 : Form
    {

        // instance of the Controller class
        Controller myPLC = new Controller();

        Tag myTag = new Tag();

        // instance of the Tag class
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // set the ip address
                myPLC.IPAddress = ipAddress.Text;

                // set the path property
                myPLC.Path = path.Text;
                if (btnLogix.Checked)
                    myPLC.CPUType = Controller.CPU.LOGIX;
                else
                    myPLC.CPUType = Controller.CPU.MICRO;
                // connect to the PLC
                if (myPLC.Connect() != ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(myPLC.ErrorString, this.Text);
                    return;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            // disconnect from the PLC
            myPLC.Disconnect();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            try
            {
                SetScalingParameters();
                
                // read the tag
                if (myPLC.ReadTag(myTag) != ResultCode.E_SUCCESS)
                {
                    if (myPLC.ErrorCode == 0x10312)
                        MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + myPLC.ErrorString, this.Text);
                    return;
                }


                scaledValue.Text = myTag.Value.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
                
        }

        private void SetScalingParameters()
        {

            // set tag name
            myTag.Name = tagName.Text;

            // set scaling parameters
            double minRaw = Convert.ToDouble(rawMin.Text);
            double maxRaw = Convert.ToDouble(rawMax.Text);
            double minScaled = Convert.ToDouble(scaledMin.Text);
            double maxScaled = Convert.ToDouble(scaledMax.Text);

            // set scaling type
            Logix.Tag.CONVERSION conversionType = Logix.Tag.CONVERSION.Linear;
            if (btnSquareRoot.Checked)
                conversionType = Logix.Tag.CONVERSION.SquareRoot;

            // appy scaling to the tag
            myTag.ScaleValue(conversionType, minRaw, maxRaw, minScaled, maxScaled);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                myTag.Value = scaledValue.Text;

                if (myPLC.WriteTag(myTag) != ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(myPLC.ErrorString, this.Text);
                    return;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            
        }


 
    }
}