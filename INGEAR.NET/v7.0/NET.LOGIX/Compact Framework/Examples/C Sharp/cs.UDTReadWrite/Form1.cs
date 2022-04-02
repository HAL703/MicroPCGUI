using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace cs.UDTReadWrite
{
    public partial class Form1 : Form
    {
        //////////////////////////////////////////
        /// <summary>
        /// STRUCT_A User Defined Data TYpe
        /// </summary>
        /// <remarks>        
        /// This structure is represents
        /// user-defined type STRUCT_A in the PLC
        /// 
        /// STRUCT_A.limit4  (BOOL)
        /// STRUCT_A.limit7  (BOOL)
        /// STRUCT_A.travel  (DINT)
        /// STRUCT_A.errors  (DINT)
        /// STRUCT_A.wear    (REAL)
        /// 
        /// In the PLC, define the STRUCT_A user defined data type, then
        /// create a Controller Scope tag called "struct_a"
        /// 
        ///</remarks>
        public struct STRUCT_A
        {
            // boolean values are packed into 32-bit ints
            public int boolVals;
            public int travel;
            public int errors;
            public Single wear;
        };

        /// <summary>
        /// Instance of the Logix.Controller
        /// </summary>
        Controller myPLC = new Controller();

        /// <summary>
        /// Instance of Logix.Tag class for "struct_a"
        /// </summary>
        Tag tagStructA = new Tag("struct_a");

        /// <summary>
        /// Instance of Logix.Tag class for "struct_b"
        /// </summary>
        Tag tagStructB = new Tag("struct_b");

        /// <summary>
        /// Instance of Logix.DTEncoding for Logix Data Type conversion
        /// </summary>
        DTEncoding udtEnc = new DTEncoding();

        /// <summary>
        /// array for bit values
        /// </summary>
        bool[] bits;


        public Form1()
        {
            InitializeComponent();
            myPLC.Timeout = 3000;
            tagStructA.DataType = Logix.Tag.ATOMIC.OBJECT;
            tagStructB.DataType = Logix.Tag.ATOMIC.OBJECT;
        }

         private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.IPAddress = ipAddress.Text;
                myPLC.Path = cipPath.Text;
                myPLC.Timeout = 3000;
                if (myPLC.Connect() != Logix.ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(myPLC.ErrorString);
                    return;
                }
                // enable reading/writing of tag
                btnConnect.Enabled = false;
                Disconnect.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            myPLC.Disconnect();
            btnConnect.Enabled = true;
            Disconnect.Enabled = false;
 
        }

        private void btnStructA_Read_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 
                // read the tag
                if (myPLC.ReadTag(tagStructA) != Logix.ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(tagStructA.ErrorString);
                    return;
                }
                // decode
                DecodeStructA();
                btnStuctA_Write.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStuctA_Write_Click_1(object sender, EventArgs e)
        {
            // get data for STRUCT_A
            EncodeStructA();
            // write it to PLC
            if (myPLC.WriteTag(tagStructA) != Logix.ResultCode.E_SUCCESS)
                MessageBox.Show(tagStructA.ErrorString);

        }
        /// <summary>
        /// Decodes UDT tag "struct_a" to STRUCT_A 
        /// </summary>
        private void DecodeStructA()
        {
            try
            {
                //
                // decode tag struct_a to STRUCT_A User Data Type
                //
                STRUCT_A struct_a = (STRUCT_A)udtEnc.ToType(tagStructA, typeof(STRUCT_A));

                // 
                // convert the boolVals member to bits
                //
                bits = udtEnc.ToBoolArray(struct_a.boolVals);

                //
                // update fields
                //
                structA_limit4.Checked = bits[0];
                structA_limit7.Checked = bits[1];
                structA_travel.Text = struct_a.travel.ToString();
                structA_errors.Text = struct_a.errors.ToString();
                structA_wear.Text = struct_a.wear.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Encodes values from STRUCT_A to UDT for writing to the PLC.
        /// </summary>
        /// <returns></returns>
        private void EncodeStructA()
        {

            STRUCT_A struct_a = new STRUCT_A();
            bool[] limits = new bool[2];

            // populate STRUCT_A members
            try
            {
                // get the bit values from check box
                limits[0] = structA_limit4.Checked;
                limits[1] = structA_limit7.Checked;
                // convert bool[] to Int32
                struct_a.boolVals = udtEnc.FromBoolArray(limits);

                // get values for remaining members
                struct_a.errors = Convert.ToInt32(structA_errors.Text);
                struct_a.travel = Convert.ToInt32(structA_travel.Text);
                struct_a.wear = Convert.ToSingle(structA_wear.Text);

                // encode STRUCT_A for writing
                tagStructA.Value = udtEnc.FromType(struct_a);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}