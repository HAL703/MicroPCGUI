using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logix;

namespace NETLOGIX.cs.UserDefinedType
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
        /// 
        /// In the PLC, define the STRUCT_B user defined data type, then
        /// create a Controller Scope tag called "struct_b"
        /// 
        /// </remarks>
       public struct STRUCT_B
       {
           // boolean values are packed into 32-bit ints
            public Int32 boolVals;
          // declare unmanaged array
          [MarshalAs (UnmanagedType.ByValArray, SizeConst = 12)] 
          public  Int16[] hourlyCount;
          public  Single  rate;
        }

        //////////////////////////////////////////
        /// <summary>
        /// STRUCT_C User Defined Data Type
        /// </summary>
        /// <remarks>
        /// This struture represents
        /// user-defined type STRUCT_C in the PLC
        /// NOTE: This is a nested UDT.
        /// 
        /// STRUCT_C.hour_full      (BOOL)
        /// STRUCT_C.today          (UDT STRUCT_B)
        /// STRUCT_C.sampleTime     (DINT)
        /// 
        /// In the PLC, define the STRUCT_C user defined data type, then
        /// create a Controller Scope tag called "struct_c"
        /// 
        /// </remarks>
        public struct STRUCT_C
        {
            public int boolVals;
            public STRUCT_B today;
            public int sampleTime;
            public int shipped;
        };
 

        //////////////////////////////////////////
        /// <summary>
        /// STRUCT_D User Defined Type
        /// </summary>
        /// <remarks>
        /// This structure represents
        /// user-defined type STRUCT_D in the PLC
        /// NOTE: This is a nested UDT
        /// 
        /// STRUCT_D.myint          (INT)
        /// STRUCT_D.myfloat        (REAL)
        /// STRUCT_D.myarray        (STRUCT_C[8])
        /// STRUCT_D.mypid          (REAL)
        /// 
        /// In the PLC, define the STRUCT_D user defined data type, then
        /// create a Controller Scope tag called "struct_d"
        /// 
        /// </remarks>   
        public struct STRUCT_D
        {
            public Int16 myint;
            public Single myfloat;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public STRUCT_C[] myarray;           
            public Single mypid;
        };

        /// <summary>
        /// Encoded_Type (aka Abbreviated Data Type) a series 
        /// of bytes from the PLC that is used to reference 
        /// Data Types.  You'll need this value to write Structured Types
        /// </summary>
        /// 
        public byte[] Encoded_TypeCode = null;
        UInt16 UDT_TypeCode = 0;

        /// <summary>
        /// The Tag.Value class returns Structure Data Types as a 
        /// byte[].  We'll call this rawUDT to pass to DTEncoding class
        /// </summary>
        public byte[] rawUDT = null;

        /// <summary>
        /// Boolean (bit) values in structured types are either packed in 8-bit or 32-bit values.
        /// The DTEncoding.ToBoolArray unpacks bits
        /// </summary>
        public bool[] bit;

        //////////////////////////////////////////
        /// <summary>
        /// Instance of the NET.LOGIX Controller class
        /// </summary>
        Controller myPLC = new Controller();

        //////////////////////////////////////////
        /// <summary>
        /// Instance of the NET.LOGIX Tag class
        /// </summary>
        /// <remarks>
        /// were using the default tag name of "struct_a"
        /// </remarks>
        Tag myUDT = new Tag("struct_a", Logix.Tag.ATOMIC.OBJECT);

        //////////////////////////////////////////
        /// <summary>
        /// Instance of the NET.LOGIX DTEncoding class
        /// </summary>
        DTEncoding udtEnc = new DTEncoding();

        public Form1()
        {
            InitializeComponent();
            LoadHelp();
            myPLC.Timeout = 3000;
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPLC.Connect() != ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(myPLC.ErrorString, this.Text);
                    return;
                }
                if (myPLC.ReadTag(myUDT) != Logix.ResultCode.E_SUCCESS)
                {
                    if (myPLC.ErrorCode == 0x10312)
                        MessageBox.Show(myPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + myPLC.ErrorString, this.Text);
                    return;
                }

               if (true == btnSTRUCT_A.Checked)
                    DisplayStructA();
                else if (true == btnSTRUCT_B.Checked)
                    DisplayStructB();
                else if (true == btnSTRUCT_C.Checked)
                    DisplayStructC();
                else
                    DisplayStructD();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Displays STRUCT_A in Tree View
        /// </summary>
        private void DisplayStructA()
        {
            try
            {
                //
                // use NET.LOGIX DTEncoding to convert the Tag.Value property to
                // STRUCT_A type
                STRUCT_A struct_a = (STRUCT_A)udtEnc.ToType(myUDT, typeof(STRUCT_A));

                // bits are packed into 32-bit values, use the .ToBoolArray to get
                // the individual bit elements
                bit = udtEnc.ToBoolArray(struct_a.boolVals);

                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();

                // add a root node the tree view
                treeView1.Nodes.Add("STRUCT_A");

                // add the branch and value for STRUCT_A.limit4
                treeView1.Nodes[0].Nodes.Add("limit4 = " + bit[0].ToString());

                // add the branch and value for STRUCT_A.limit4
                treeView1.Nodes[0].Nodes.Add("limit7 = " + bit[1].ToString());

                // add the branch and value for STRUCT_A.travel
                treeView1.Nodes[0].Nodes.Add("travel = " + struct_a.travel.ToString());

                // add the branch and value for STRUCT_A.errors
                treeView1.Nodes[0].Nodes.Add("errors = " + struct_a.errors.ToString());

                // add the branch and value for STRUCT_A.wears
                treeView1.Nodes[0].Nodes.Add("wear = " + struct_a.wear.ToString());

                treeView1.EndUpdate();

                //
                // get the "Abbreviated Type Code" for the STRUCT_A UDT
                //
                Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT);
                UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0);

                lblTypeCode.Text = "STRUCT_A Type Code = " + UDT_TypeCode.ToString();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Displays STRUCT_B in Treeview
        /// </summary>
        /// <remarks>
        /// This function uses the  key word because of the access to fixed array hourlyCount[] members
        /// </remarks>
        private void DisplayStructB()
        {

            try
            {
                //
                // use NET.LOGIX DTEncoding to convert the Tag.Value property to
                // STRUCT_B type
                STRUCT_B struct_b = (STRUCT_B)udtEnc.ToType(myUDT, typeof(STRUCT_B));

                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();

                // add root node
                treeView1.Nodes.Add("STRUCT_B");

                // add the branch and value for STRUCT_B.limit4
                // convert the struct_b.boolVals a bool[]
                bit = udtEnc.ToBoolArray(struct_b.boolVals);
                treeView1.Nodes[0].Nodes.Add("pilot_on = " + bit[0].ToString());

                // add the branchs and values for STRUCT_B.hourlyCount
                treeView1.Nodes[0].Nodes.Add("hourlyCount");
                for (int x = 0; x<12; x++)
                    treeView1.Nodes[0].Nodes[1].Nodes.Add("["+x.ToString()+ "]= " + struct_b.hourlyCount[x].ToString());
                
                // add the branch and value for STRUCT_B.rate
                treeView1.Nodes[0].Nodes.Add("rate = " + struct_b.rate.ToString());
                treeView1.EndUpdate();

                //
                // get the "Abbreviated Type Code" for the STRUCT_B UDT
                //
                Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT);
                UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0);

                lblTypeCode.Text = "STRUCT_B Type Code = " + UDT_TypeCode.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Displays STRUCT_C in Tree View
        /// </summary>
        /// <remarks>
        /// </remarks>
        private void DisplayStructC()
        {

            //
            // use NET.LOGIX DTEncoding to convert the Tag.Value property to
            // STRUCT_C type
            STRUCT_C struct_c = (STRUCT_C)udtEnc.ToType(myUDT, typeof(STRUCT_C));

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            // add STRUCT_C root node
            treeView1.Nodes.Add("STRUCT_C");
            
            // add branch and value for STRUCT_C.hour_full
            bit = udtEnc.ToBoolArray(struct_c.boolVals);
            treeView1.Nodes[0].Nodes.Add("hour_full = " + bit[0].ToString());

            // add branch for STRUCT_B
            treeView1.Nodes[0].Nodes.Add("today");

            // add branch and value for STRUCT_C.today.pilot_on
            bit = udtEnc.ToBoolArray(struct_c.today.boolVals);
            treeView1.Nodes[0].Nodes[1].Nodes.Add("pilot_on = " + bit[0].ToString());

            // add branch and values for STRUCT_C.today.hourlyCount[]
            treeView1.Nodes[0].Nodes[1].Nodes.Add("hourlyCount");
            for (int x = 0; x<12; x++)
                treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Add("["+x.ToString()+"] = " + struct_c.today.hourlyCount[x].ToString());

            // add branch and value for STRUCT_C.today.rate
            treeView1.Nodes[0].Nodes[1].Nodes.Add("rate =  " + struct_c.today.rate.ToString());

            // add branch and value for STRUCT_C.sampleTime
            treeView1.Nodes[0].Nodes.Add("sampleTime = " + struct_c.sampleTime.ToString());

            // add branch and value for STRUCT_C.shipped
            treeView1.Nodes[0].Nodes.Add("shipped = " + struct_c.shipped.ToString());
            treeView1.EndUpdate();

            //
            // get the "Abbreviated Type Code" for the STRUCT_B UDT
            //
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT);
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0);

            lblTypeCode.Text = "STRUCT_C Type Code = " + UDT_TypeCode.ToString();



        }

        private void DisplayStructD()
        {

            int x = 0;

            // use NET.LOGIX DTEncoding to convert the Tag.Value property to
            // STRUCT_D type
            STRUCT_D struct_d = (STRUCT_D)udtEnc.ToType(myUDT, typeof(STRUCT_D));

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            // add root for STRUCT_D
            treeView1.Nodes.Add("STRUCT_D");

            // add the branch and value for STRUCT_D.myint
            treeView1.Nodes[0].Nodes.Add("myint = " + struct_d.myint.ToString());

            // add the branch and value for STRUCT_D.myfloat
            treeView1.Nodes[0].Nodes.Add("myfloat = " + struct_d.myfloat.ToString());

            for (int i = 0; i < 8; i++)
            {
                //////////////////////////////////////
                // add the branches and value for STRUCT_D.myarray[] 
                //////////////////////////////////////
                treeView1.Nodes[0].Nodes.Add("myarray[" + i.ToString() + "]");
                bit = udtEnc.ToBoolArray(struct_d.myarray[i].boolVals);

                treeView1.Nodes[0].Nodes[i+2].Nodes.Add("hour_full = " + bit[0].ToString());
                treeView1.Nodes[0].Nodes[i+2].Nodes.Add("today");

                bit = udtEnc.ToBoolArray(struct_d.myarray[i].today.boolVals);

                treeView1.Nodes[0].Nodes[i+2].Nodes[1].Nodes.Add("pilot_on = " + bit[0].ToString());
                treeView1.Nodes[0].Nodes[i+2].Nodes[1].Nodes.Add("hourlyCount");
                for (x = 0; x < 12; x++)
                {
                    Console.WriteLine("i = " + i.ToString() + " :  x - " +  x.ToString());
                    treeView1.Nodes[0].Nodes[i + 2].Nodes[1].Nodes[1].Nodes.Add("[" + x.ToString() + "] = " + struct_d.myarray[i].today.hourlyCount[x].ToString());
                }
               treeView1.Nodes[0].Nodes[i + 2].Nodes[1].Nodes.Add("rate = " + struct_d.myarray[i].today.rate.ToString());
               treeView1.Nodes[0].Nodes[i + 2].Nodes.Add("sampleTime = " + struct_d.myarray[i].sampleTime.ToString());
               treeView1.Nodes[0].Nodes[i + 2].Nodes.Add("shipped = " + struct_d.myarray[i].shipped.ToString());
               
            }
            
            /////////////////////////////////
            // add the branch and value for STRUCT_D.mypic
            /////////////////////////////////
            treeView1.Nodes[0].Nodes.Add("mypid = " + struct_d.mypid.ToString());
            treeView1.EndUpdate();

            //
            // get the "Abbreviated Type Code" for the STRUCT_D UDT
            //
            Encoded_TypeCode = udtEnc.GetDataTypeCode(myUDT);
            UDT_TypeCode = BitConverter.ToUInt16(Encoded_TypeCode, 0);

            lblTypeCode.Text = "STRUCT_D Type Code = " + UDT_TypeCode.ToString();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.IPAddress = _ipAddress.Text;
                myPLC.Path = _cipPath.Text;
                if (Logix.ResultCode.E_SUCCESS != myPLC.Connect())
                {
                    MessageBox.Show(myPLC.ErrorString);
                    return;
                }
                structTypes.Enabled = true;
                btnRead.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSTRUCT_A_CheckedChanged(object sender, EventArgs e)
        {
            myUDT.Name = "struct_a";

        }

        private void btnSTRUCT_B_CheckedChanged(object sender, EventArgs e)
        {
            myUDT.Name = "struct_b";

        }

        private void btnSTRUCT_C_CheckedChanged(object sender, EventArgs e)
        {
            myUDT.Name = "struct_c";

        }

        private void btnSTRUCT_D_CheckedChanged(object sender, EventArgs e)
        {
            myUDT.Name = "struct_d";

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void LoadHelp()
        {
            txtHelp.Text = "NOTES:" + System.Environment.NewLine 
            + "This example requires the following User Data Types (UDT's) to be defined in the PLC" + System.Environment.NewLine + System.Environment.NewLine

            + "Create a tag called 'struct_a' from this UDT" + System.Environment.NewLine 

            + "STRUCT_A" + System.Environment.NewLine 
            + "  limit4       (BOOL)" + System.Environment.NewLine 
            + "  limit7       (BOOL)" + System.Environment.NewLine 
            + "  travel       (DINT)" + System.Environment.NewLine 
            + "  errors       (DINT)" + System.Environment.NewLine 
            + "  wear         (REAL)" + System.Environment.NewLine 
            + "END STRUCT_A" + System.Environment.NewLine + System.Environment.NewLine

            + "Create a tag called 'struct_b' from this UDT" + System.Environment.NewLine 

            + "STRUCT_B" + System.Environment.NewLine 
            + "  pilot_on     (BOOL)" + System.Environment.NewLine 
            + "  hourlyCount[](INT[12])" + System.Environment.NewLine 
            + "  rate         (REAL)" + System.Environment.NewLine 
            + "END STRUCT_B" + System.Environment.NewLine + System.Environment.NewLine

            + "Create a tag called 'struct_c' from this UDT" + System.Environment.NewLine 

            + "STRUCT_C" + System.Environment.NewLine 
            + "  hour_full    (BOOL)" + System.Environment.NewLine 
            + "  today        (STRUCT_B)" + System.Environment.NewLine 
            + "  sampleTime   (DINT)" + System.Environment.NewLine 
            + "  shipped      (DINT)" + System.Environment.NewLine 
            + "END STRUCT_C" + System.Environment.NewLine + System.Environment.NewLine

            + "Create a tag called 'struct_d' from this UDT" + System.Environment.NewLine 

            + "STRUCT_D" + System.Environment.NewLine 
            + "  myint        (INT)" + System.Environment.NewLine 
            + "  myfloat      (REAL)" + System.Environment.NewLine 
            + "  myarray[]    (STRUCT_C[8])" + System.Environment.NewLine 
            + "  mypid        (REAL)" + System.Environment.NewLine 
            + "END STRUCT_D" + System.Environment.NewLine;

        }
    }
}