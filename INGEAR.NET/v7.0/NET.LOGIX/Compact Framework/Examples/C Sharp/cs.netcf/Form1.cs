using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace csnetcf
{
    public partial class Form1 : Form
    {
        Controller MyPLC = new Controller();
        Tag MyTag = new Tag();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////
            // some initialization settings
            MyPLC.Timeout = 3000;
            ////////////////////////////////////
            // set default data type
            MyTag.DataType = Logix.Tag.ATOMIC.INT;
            MyTag.Length = 1;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                /////////////////////////////////////
                // set ip address and path
                MyPLC.IPAddress = ipAddress.Text;
                MyPLC.Path = path.Text;

                if (MyPLC.Connect() != ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(MyPLC.ErrorString, this.Text);
                    return;
                }
                tagProps.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            MyPLC.Disconnect();
            tagProps.Enabled = true;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
     
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            try
            {
                btnWrite.Enabled = false;

                /////////////////////////////////
                // set the tag name;
                MyTag.Name = tagName.Text;

                ///////////////////////////////
                // invoke a read command
                if (MyPLC.ReadTag (MyTag) != ResultCode.E_SUCCESS)
                {
                   results.Text = MyPLC.ErrorString;
                   return;
                }
               
                /////////////////////////////////
                // make sure tag quality is good
                if (ResultCode.QUAL_GOOD == MyTag.QualityCode)
                {
                    dataValue.Text = MyTag.Value.ToString();
                    results.Text = MyTag.TimeStamp.ToString();
                    btnWrite.Enabled = true;
                }
                else
                {
                    dataValue.Text = "????"; 
                    results.Text = MyTag.ErrorString;
                    btnWrite.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show (ex.Message, this.Text);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                ///////////////////////////////
                // set data value
                MyTag.Value = dataValue.Text;

                ////////////////////////////////
                // invoke write
                if (MyPLC.WriteTag(MyTag) != ResultCode.E_SUCCESS)
                {
                    results.Text = MyPLC.ErrorString;
                    return;
                }
                if (ResultCode.QUAL_GOOD == MyTag.QualityCode)
                    results.Text = MyTag.TimeStamp.ToString();
                else
                {
                    dataValue.Text = "????";
                    results.Text = MyTag.ErrorString;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

           }

        private void btnBoolArray_CheckedChanged(object sender, EventArgs e)
        {
            ///////////////////////////////////////////
            // need to be ATOMIC.BOOL if tag is BOOL array
            // BOOL[]
            MyTag.DataType = Logix.Tag.ATOMIC.BOOL;
        }

        private void btnString_CheckedChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////
            // needs to be ATOMIC.STRING if tag is
            // STRING 
            MyTag.DataType = Logix.Tag.ATOMIC.STRING;
        }

        private void btnAtomic_CheckedChanged(object sender, EventArgs e)
        {
            //////////////////////////////////////
            // for all other ATOMIC types, it really
            // doesn't matter.  In this case we'll
            // use ATOMIC.INT as default
            MyTag.DataType = Logix.Tag.ATOMIC.INT;
        }

 
        }

    }
