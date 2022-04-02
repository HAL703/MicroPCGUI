using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Logix;

namespace NETLOGIX.CS.ReadArray
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _ipAddress;
        private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Logix.Controller class
		/// </summary>
		Controller MyPLC = new Controller();

        /// <summary>
        // Logix Tag class
        /// </summary>
        Tag MyTag = new Tag();

        private RadioButton btnLogix;
        private RadioButton btnMicro;
        private Label label6;
        private Button btnConnect;
        private Button btnDisconnect;
        private GroupBox tagProps;
        private ComboBox dataType;
        private Label label5;
        private Button btnRead;
        private ListBox _values;
        private TextBox _arrayItems;
        private Label label4;
        private TextBox _tagName;
        private Label label3;

        private System.Windows.Forms.TextBox _path;
        private Button btnWrite;

        string errMsg = "";

        NETLOGIX.CS.ReadArray.frmArrayWrite frmWrite = new NETLOGIX.CS.ReadArray.frmArrayWrite();

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this._ipAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._path = new System.Windows.Forms.TextBox();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnMicro = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tagProps = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.dataType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this._values = new System.Windows.Forms.ListBox();
            this._arrayItems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tagProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _ipAddress
            // 
            this._ipAddress.Location = new System.Drawing.Point(86, 34);
            this._ipAddress.Name = "_ipAddress";
            this._ipAddress.Size = new System.Drawing.Size(144, 20);
            this._ipAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CIP Path:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(86, 59);
            this._path.Name = "_path";
            this._path.Size = new System.Drawing.Size(144, 20);
            this._path.TabIndex = 3;
            this._path.Text = "0";
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(86, 12);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(57, 17);
            this.btnLogix.TabIndex = 14;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "LOGIX";
            this.btnLogix.UseVisualStyleBackColor = true;
            this.btnLogix.CheckedChanged += new System.EventHandler(this.btnLogix_CheckedChanged);
            // 
            // btnMicro
            // 
            this.btnMicro.AutoSize = true;
            this.btnMicro.Location = new System.Drawing.Point(173, 12);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(60, 17);
            this.btnMicro.TabIndex = 15;
            this.btnMicro.Text = "MICRO";
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.CheckedChanged += new System.EventHandler(this.btnMicro_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "CPU Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(77, 85);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(154, 85);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tagProps
            // 
            this.tagProps.Controls.Add(this.btnWrite);
            this.tagProps.Controls.Add(this.dataType);
            this.tagProps.Controls.Add(this.label5);
            this.tagProps.Controls.Add(this.btnRead);
            this.tagProps.Controls.Add(this._values);
            this.tagProps.Controls.Add(this._arrayItems);
            this.tagProps.Controls.Add(this.label4);
            this.tagProps.Controls.Add(this._tagName);
            this.tagProps.Controls.Add(this.label3);
            this.tagProps.Location = new System.Drawing.Point(9, 112);
            this.tagProps.Name = "tagProps";
            this.tagProps.Size = new System.Drawing.Size(298, 335);
            this.tagProps.TabIndex = 19;
            this.tagProps.TabStop = false;
            this.tagProps.Text = "Tag Properties";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(93, 303);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 22;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // dataType
            // 
            this.dataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataType.FormattingEnabled = true;
            this.dataType.Items.AddRange(new object[] {
            "BOOL[] -  (System.Boolean[])",
            "SINT[] - (System.SByte[])",
            "BYTE[] - (System.Byte[])",
            "INT[] -  (System.Int16[])",
            "WORD[] -  (System.UInt16[])",
            "DINT[] -  (System.Int32[])",
            "DWORD[] - (System.UInt32[])",
            "LINT[] - (System.Int64[])",
            "LWORD[] - (System.UInt64[])",
            "REAL[] -  (System.Single[])",
            "LREAL[] -  (System.Double[])",
            "STRING[] - (System.Sting[])"});
            this.dataType.Location = new System.Drawing.Point(76, 49);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(162, 21);
            this.dataType.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Data Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 303);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 19;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click_1);
            // 
            // _values
            // 
            this._values.HorizontalScrollbar = true;
            this._values.Location = new System.Drawing.Point(12, 110);
            this._values.Name = "_values";
            this._values.ScrollAlwaysVisible = true;
            this._values.Size = new System.Drawing.Size(272, 186);
            this._values.TabIndex = 18;
            // 
            // _arrayItems
            // 
            this._arrayItems.Location = new System.Drawing.Point(76, 82);
            this._arrayItems.Name = "_arrayItems";
            this._arrayItems.Size = new System.Drawing.Size(72, 20);
            this._arrayItems.TabIndex = 17;
            this._arrayItems.Text = "2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Items:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _tagName
            // 
            this._tagName.Location = new System.Drawing.Point(76, 22);
            this._tagName.Name = "_tagName";
            this._tagName.Size = new System.Drawing.Size(162, 20);
            this._tagName.TabIndex = 15;
            this._tagName.Text = "Array[0]";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Array Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(306, 449);
            this.Controls.Add(this.tagProps);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMicro);
            this.Controls.Add(this.btnLogix);
            this.Controls.Add(this._path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._ipAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX  C# Read Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tagProps.ResumeLayout(false);
            this.tagProps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
		}



        private void Form1_Load(object sender, EventArgs e)
        {
            dataType.SelectedItem = 0;
        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            try
			{
				
  			    //////////////////////////////////
				/// set tag properties
				MyTag.Name = _tagName.Text;
				MyTag.Length = Convert.ToInt32(_arrayItems.Text);

                if (MyTag.Length < 2)
                {
                    MessageBox.Show("Array must be a minimum of 2 items", this.Text);
                    return;
                }

                switch (dataType.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("Please select Data Type");
                        return;
                    case 0:  // BOOL 
                        if (MyPLC.CPUType == Controller.CPU.LOGIX)
                              MyTag.NetType = typeof(System.Boolean);
                       else
                        {
                            MessageBox.Show("BOOL array (System.Boolean[]) not accessible from Micro850", this.Text);
                            return;
                        }
                        break;
                    case 1:  // SINT
                        if (MyPLC.CPUType == Controller.CPU.MICRO && MyTag.Length > 480)
                        {
                            MessageBox.Show("SINT array (System.SByte[]) max size = 480 items per block", this.Text);
                            return;
                        }
                        MyTag.NetType = typeof(System.SByte);
                        break;

                    case 2:  // BYTE
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {
                            if (MyTag.Length > 480)
                            {
                                MessageBox.Show("BYTE array (System.Byte[]) max size = 480 items per block", this.Text);
                                return;
                            }
                            MyTag.NetType = typeof(System.Byte);
                        }
                        else
                        {
                            MessageBox.Show("BYTE array (System.Byte[]) unsupported data type by Logix CPU", this.Text);
                            return;
                        }
                        break;

                    case 3:  // INT
                        if (MyPLC.CPUType == Controller.CPU.MICRO && MyTag.Length > 240)
                        {
                            MessageBox.Show("INT array (System.Int16[]) max size = 240 items per block", this.Text);
                            return;
                        }
                        MyTag.NetType = typeof(System.Int16);
                        break;


                    case 4:  // WORD
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {
                            if (MyTag.Length > 240)
                            {
                                MessageBox.Show("WORD array (System.UInt16[]) max size = 240 items per block", this.Text);
                                return;
                            }
                            MyTag.NetType = typeof(System.UInt16);
                        }
                        else
                        {
                            MessageBox.Show("WORD array (System.UInt16[]) unsupported data type by Logix CPU", this.Text);
                            return;
                        }
                        break;

                    case 5:  //DINT
                        if (MyPLC.CPUType == Controller.CPU.MICRO && MyTag.Length > 120)
                        {
                            MessageBox.Show("DINT array (System.Int32[]) max size = 120 items per block", this.Text);
                            return;
                        }
                        MyTag.NetType = typeof(System.Int32);
                        break;

                    case 6:  // DWORD
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {
                            if (MyTag.Length > 120)
                            {
                                MessageBox.Show("DWORD array (System.UInt32[]) max size = 120 items per block", this.Text);
                                return;
                            }
                            MyTag.NetType = typeof(System.UInt32);
                        }
                        else
                        {
                            MessageBox.Show("DWORD array (System.UInt32[]) unsupported data type by Logix CPU", this.Text);
                            return;
                        }
                        break;

                    case 7:  //LINT
                        if (MyPLC.CPUType == Controller.CPU.MICRO && MyTag.Length > 60)
                        {
                            MessageBox.Show("LINT array (System.Int64[]) max size = 60 items per block", this.Text);
                            return;
                        }
                        MyTag.NetType = typeof(System.Int64);
                        break;

                    case 8:  // LWORD
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {
                            if (MyTag.Length > 60)
                            {
                                MessageBox.Show("LWORD array (System.UInt64[]) max size = 60 items per block", this.Text);
                                return;
                            }
                            MyTag.NetType = typeof(System.UInt64);
                        }
                        else
                        {
                            MessageBox.Show("LWORD array (System.UInt64[]) unsupported data type by Logix CPU", this.Text);
                            return;
                        }
                        break;

                    case 9:  //REAL
                        if (MyPLC.CPUType == Controller.CPU.MICRO && MyTag.Length > 120)
                        {
                            MessageBox.Show("LINT array (System.Single[]) max size = 120 items per block", this.Text);
                            return;
                        }
                        MyTag.NetType = typeof(System.Single);
                        break;

                    case 10:  // LREAL
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {
                            if (MyTag.Length > 60)
                            {
                                MessageBox.Show("LREAL array (System.Double[]) max size = 60 items per block", this.Text);
                                return;
                            }
                            MyTag.NetType = typeof(System.Double);
                        }
                        else
                        {
                            MessageBox.Show("LREAL array (System.Double[]) unsupported data type by Logix CPU", this.Text);
                            return;
                        }
                        break;

                    case 11:  // STRING
                        if (MyPLC.CPUType == Controller.CPU.MICRO)
                        {                          
                                MessageBox.Show("STRING array (System.String[]) unsupported by Micro 800 CPU", this.Text);
                                return;
                        }
                        MyTag.NetType = typeof(System.String);
                       
                        break;
                }

                if (MyPLC.ReadTag(MyTag) != ResultCode.E_SUCCESS)
                {
                    if (MyPLC.ErrorCode == 0x10312)
                        MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + MyPLC.ErrorString, this.Text);
                    return;
                }
                updateValues();

			}

			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}
		}

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {
                ///////////////////////////////////
				/// set controller properties
                MyPLC.IPAddress = _ipAddress.Text;
				MyPLC.Path = _path.Text;
                MyPLC.Timeout = 3000;
                MyPLC.CPUType = Controller.CPU.LOGIX;
                
                if (MyPLC.Connect() != ResultCode.E_SUCCESS)
                {
                    errMsg = "Error:" + MyPLC.ErrorCode.ToString() + " - " + MyPLC.ErrorString;
                    MessageBox.Show (errMsg, this.Text);
                    return;
                }
                else
                    tagProps.Enabled = true;

            }
            catch (SystemException ex)
            {
                MessageBox.Show (ex.Message, this.Text);
            }
       
        }

        private void btnLogix_CheckedChanged(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.LOGIX;
        }

        private void btnMicro_CheckedChanged(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.MICRO;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            MyPLC.Disconnect();
            tagProps.Enabled = false;
            _values.Items.Clear();

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                frmWrite.dataArray = (System.Array)MyTag.Value;
                frmWrite.dataType = Type.GetTypeCode(MyTag.NetType);

                if (DialogResult.Cancel == frmWrite.ShowDialog())
                    return;
               
                MyTag.Value = frmWrite.dataArray;

                MyPLC.WriteTag(MyTag);

                updateValues();
                
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }

        void updateValues()
        {
            _values.Items.Clear();

            if (MyPLC.ErrorCode == ResultCode.E_SUCCESS)
            {
                Array theData = (Array)MyTag.Value;
                for (int i = 0; i < theData.Length; i++)
                   _values.Items.Add("Item: " + i.ToString() + " = " + Convert.ToString(theData.GetValue(i)));
            }
            else
                 _values.Items.Add("Error: " + MyTag.ErrorString);

        }
	}
}
