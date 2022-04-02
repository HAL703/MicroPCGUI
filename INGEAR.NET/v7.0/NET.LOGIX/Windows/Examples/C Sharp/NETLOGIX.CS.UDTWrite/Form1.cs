using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logix;

namespace NETLOGIX.cs.UDTWrite
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

         //////////////////////////////////////////
        /// <summary>
        /// STRUCT_B User Defined Data Type
        /// </summary>
        /// <remarks>
        /// This structure represents 
        /// user-defined type STRUCT_B in the PLC
        /// 
        /// STRUCT_B.pilot_on           (BOOL)
        /// STRUCT_B.hourlyCount        (DINT[12] array)
        /// STRUCT_B.rate               (REAL)
        /// 
        /// Because STRUCT_B contains a fixed array, it unmanaged and must be
        /// declared as "unsafe" and we need to compile with "Allow Unsafe Code"
        /// compiler option
        /// 
        /// In the PLC, define the STRUCT_B user defined data type, then
        /// create a Controller Scope tag called "struct_b"
        /// 
        /// </remarks>
        public struct STRUCT_B
        {
            public int boolVals;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public Int16[] hourlyCount;
            public Single rate;
        }
        /// <summary>
        /// STRUCT_B variable
        /// </summary>
       // STRUCT_B struct_b;

        /// <summary>
        /// Instance of the Logix.Controller
        /// </summary>
        Controller myPLC = new Controller();

        /// <summary>
        /// Instance of Logix.Tag class for "struct_a"
        /// </summary>
        Tag tagStructA = new Tag("struct_a", Logix.Tag.ATOMIC.OBJECT);

        /// <summary>
        /// Instance of Logix.Tag class for "struct_b"
        /// </summary>
        Tag tagStructB = new Tag("struct_b", Logix.Tag.ATOMIC.OBJECT);

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
        }

        /// <summary>
        /// Connects to the PLC and enables reading/writing of tags
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.IPAddress = ipAddress.Text;
                myPLC.Path = cipPath.Text;
                myPLC.Timeout = 3000;
                if (myPLC.Connect() != Logix.ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(myPLC.ErrorString, this.Text);
                    return;
                }
                // enable reading/writing of tag
                structA_Grp.Enabled = true;
                structB_Grp.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Disconnects from PLC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            myPLC.Disconnect();
            structA_Grp.Enabled = false;
            structB_Grp.Enabled = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        /// <summary>
        /// Reads UDT STRUCT_A and decodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStructA_Read_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                // read the tag
                if (myPLC.ReadTag(tagStructA) != Logix.ResultCode.E_SUCCESS)
                {
                    if (myPLC.ErrorCode == 0x10312)
                        MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + myPLC.ErrorString, this.Text);
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

        /// <summary>
        /// Writes UDT STRUCT_A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuctA_Write_Click(object sender, EventArgs e)
        {
            // get data for STRUCT_A
            EncodeStructA();
            // write it to PLC
            if (myPLC.WriteTag(tagStructA) != Logix.ResultCode.E_SUCCESS)
                MessageBox.Show(tagStructA.ErrorString);

        }
        /// <summary>
        /// Read and decode UDT tag "struct_b"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStructB_Read_Click(object sender, EventArgs e)
        {
            try
            {
                // read UDT tag "struct_b"
                if (myPLC.ReadTag(tagStructB) != Logix.ResultCode.E_SUCCESS)
                {
                    if (myPLC.ErrorCode == 0x10312)
                        MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + myPLC.ErrorString, this.Text);
                    return;
                }
                // decode to STUCT_B data type
                DecodeStructB();
                btnStructB_Write.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Decodes to STRUCT_B data type
        /// </summary>
        /// <remarks>
        /// Because STRUCT_B has 'fixed array' we need to declare this function with
        /// "unsafe" keyword
        /// </remarks>
        private void DecodeStructB()
        {
            try
            {
                //
                // decode tag struct_B to STRUCT_B User Data Type
                //
                STRUCT_B struct_b = (STRUCT_B)udtEnc.ToType(tagStructB, typeof(STRUCT_B));

                // 
                // value for struct_b.pilot_on
                //
                bits = udtEnc.ToBoolArray(struct_b.boolVals);
                structB_pilot_on.Checked = bits[0];

                //
                // value for struct_b.hourlyCount[12]
                //
                 structB_hourlyCount_0.Text = struct_b.hourlyCount[0].ToString();
                 structB_hourlyCount_1.Text = struct_b.hourlyCount[1].ToString();
                 structB_hourlyCount_2.Text = struct_b.hourlyCount[2].ToString();
                 structB_hourlyCount_3.Text = struct_b.hourlyCount[3].ToString();
                 structB_hourlyCount_4.Text = struct_b.hourlyCount[4].ToString();
                 structB_hourlyCount_5.Text = struct_b.hourlyCount[5].ToString();
                 structB_hourlyCount_6.Text = struct_b.hourlyCount[6].ToString();
                 structB_hourlyCount_7.Text = struct_b.hourlyCount[7].ToString();
                 structB_hourlyCount_8.Text = struct_b.hourlyCount[8].ToString();
                 structB_hourlyCount_9.Text = struct_b.hourlyCount[9].ToString();
                 structB_hourlyCount_10.Text = struct_b.hourlyCount[10].ToString();
                 structB_hourlyCount_11.Text = struct_b.hourlyCount[11].ToString();

                structB_rate.Text = struct_b.rate.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Encode values for STRUCT_B UDT writing
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 
        /// </remarks>
        private void EncodeStructB()
        {
            //
            // 
            STRUCT_B struct_b = new STRUCT_B();
            struct_b.hourlyCount = new Int16[12];
            try
            {
                //
                // get bool value
                if (structB_pilot_on.Checked)
                    struct_b.boolVals = 1;
                
                // remaining STRUCT_B members
                struct_b.hourlyCount[0] = Convert.ToInt16(structB_hourlyCount_0.Text);
                struct_b.hourlyCount[1] = Convert.ToInt16(structB_hourlyCount_1.Text);
                struct_b.hourlyCount[2] = Convert.ToInt16(structB_hourlyCount_2.Text);
                struct_b.hourlyCount[3] = Convert.ToInt16(structB_hourlyCount_3.Text);
                struct_b.hourlyCount[4] = Convert.ToInt16(structB_hourlyCount_4.Text);
                struct_b.hourlyCount[5] = Convert.ToInt16(structB_hourlyCount_5.Text);
                struct_b.hourlyCount[6] = Convert.ToInt16(structB_hourlyCount_6.Text);
                struct_b.hourlyCount[7] = Convert.ToInt16(structB_hourlyCount_7.Text);
                struct_b.hourlyCount[8] = Convert.ToInt16(structB_hourlyCount_8.Text);
                struct_b.hourlyCount[9] = Convert.ToInt16(structB_hourlyCount_9.Text);
                struct_b.hourlyCount[10] = Convert.ToInt16(structB_hourlyCount_10.Text);
                struct_b.hourlyCount[11] = Convert.ToInt16(structB_hourlyCount_11.Text);

                struct_b.rate = Convert.ToSingle(structB_rate.Text);

                tagStructB.Value = udtEnc.FromType(struct_b);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Writes UDT tag "struct_b"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStructB_Write_Click(object sender, EventArgs e)
        {
            EncodeStructB();
            if (myPLC.WriteTag(tagStructB) != Logix.ResultCode.E_SUCCESS)
                MessageBox.Show(tagStructB.ErrorString);

        }
    }
}