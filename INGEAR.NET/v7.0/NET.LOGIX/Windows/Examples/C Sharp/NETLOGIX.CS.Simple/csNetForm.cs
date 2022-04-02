using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Logix;

namespace NETLOGIX.CS.Simple
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class csNetForm : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQualString;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTimestamp;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnWrite;


		/// <summary>
		/// ///////////////////////
		/// </summary>
		Controller MyPLC = new Controller();
		Tag MyTag = null;

		private System.Windows.Forms.RadioButton btnString;
		private System.Windows.Forms.RadioButton btnAtomic;
        private System.Windows.Forms.RadioButton btnBoolArray;
        private GroupBox groupBox1;
        private Button btnDisconnect;
        private Button btnConnect;
        private RadioButton btnM850;
        private Label label1;
        private RadioButton btnLOGIX;
        private TextBox txtPath;
        private TextBox txtIPAddress;
        private Label label3;
        private Label label2;
        private GroupBox tagProps;
        private Timer timer1;
        private IContainer components;

		public csNetForm()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csNetForm));
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQualString = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnAtomic = new System.Windows.Forms.RadioButton();
            this.btnBoolArray = new System.Windows.Forms.RadioButton();
            this.btnString = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnM850 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLOGIX = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagProps = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tagProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tag Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 22);
            this.txtName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(97, 81);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(298, 22);
            this.txtValue.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tag Quality";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQualString
            // 
            this.lblQualString.Location = new System.Drawing.Point(149, 167);
            this.lblQualString.Name = "lblQualString";
            this.lblQualString.Size = new System.Drawing.Size(201, 19);
            this.lblQualString.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(5, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Time Stamp";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(149, 195);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(278, 18);
            this.lblTimestamp.TabIndex = 15;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(97, 112);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(114, 29);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(252, 112);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(114, 29);
            this.btnWrite.TabIndex = 19;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnAtomic
            // 
            this.btnAtomic.Checked = true;
            this.btnAtomic.Location = new System.Drawing.Point(97, 51);
            this.btnAtomic.Name = "btnAtomic";
            this.btnAtomic.Size = new System.Drawing.Size(77, 22);
            this.btnAtomic.TabIndex = 20;
            this.btnAtomic.TabStop = true;
            this.btnAtomic.Text = "Atomic";
            // 
            // btnBoolArray
            // 
            this.btnBoolArray.Location = new System.Drawing.Point(216, 51);
            this.btnBoolArray.Name = "btnBoolArray";
            this.btnBoolArray.Size = new System.Drawing.Size(96, 22);
            this.btnBoolArray.TabIndex = 21;
            this.btnBoolArray.Text = "Bool Array";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(331, 51);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(67, 22);
            this.btnString.TabIndex = 22;
            this.btnString.Text = "String";
            this.btnString.CheckedChanged += new System.EventHandler(this.btnString_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnM850);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLOGIX);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 150);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC Properties";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(252, 112);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 29);
            this.btnDisconnect.TabIndex = 35;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(97, 112);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 29);
            this.btnConnect.TabIndex = 34;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btnM850
            // 
            this.btnM850.AutoSize = true;
            this.btnM850.Location = new System.Drawing.Point(193, 23);
            this.btnM850.Name = "btnM850";
            this.btnM850.Size = new System.Drawing.Size(63, 21);
            this.btnM850.TabIndex = 33;
            this.btnM850.Text = "Micro";
            this.btnM850.UseVisualStyleBackColor = true;
            this.btnM850.CheckedChanged += new System.EventHandler(this.btnM850_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "CPU Type";
            // 
            // btnLOGIX
            // 
            this.btnLOGIX.AutoSize = true;
            this.btnLOGIX.Checked = true;
            this.btnLOGIX.Location = new System.Drawing.Point(97, 23);
            this.btnLOGIX.Name = "btnLOGIX";
            this.btnLOGIX.Size = new System.Drawing.Size(62, 21);
            this.btnLOGIX.TabIndex = 31;
            this.btnLOGIX.TabStop = true;
            this.btnLOGIX.Text = "Logix";
            this.btnLOGIX.UseVisualStyleBackColor = true;
            this.btnLOGIX.CheckedChanged += new System.EventHandler(this.btnLOGIX_CheckedChanged_1);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(97, 81);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(288, 22);
            this.txtPath.TabIndex = 30;
            this.txtPath.Text = "0";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(97, 47);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(167, 22);
            this.txtIPAddress.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "CPU Slot / CIP Path";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "IP Address";
            // 
            // tagProps
            // 
            this.tagProps.Controls.Add(this.txtName);
            this.tagProps.Controls.Add(this.label4);
            this.tagProps.Controls.Add(this.btnString);
            this.tagProps.Controls.Add(this.label5);
            this.tagProps.Controls.Add(this.btnBoolArray);
            this.tagProps.Controls.Add(this.txtValue);
            this.tagProps.Controls.Add(this.btnAtomic);
            this.tagProps.Controls.Add(this.label6);
            this.tagProps.Controls.Add(this.btnWrite);
            this.tagProps.Controls.Add(this.lblQualString);
            this.tagProps.Controls.Add(this.btnRead);
            this.tagProps.Controls.Add(this.label8);
            this.tagProps.Controls.Add(this.lblTimestamp);
            this.tagProps.Enabled = false;
            this.tagProps.Location = new System.Drawing.Point(8, 157);
            this.tagProps.Name = "tagProps";
            this.tagProps.Size = new System.Drawing.Size(430, 227);
            this.tagProps.TabIndex = 28;
            this.tagProps.TabStop = false;
            this.tagProps.Text = "Tag Properties";
            // 
            // csNetForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(527, 514);
            this.Controls.Add(this.tagProps);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "csNetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX  C# Simple";
            this.Load += new System.EventHandler(this.csNetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tagProps.ResumeLayout(false);
            this.tagProps.PerformLayout();
            this.ResumeLayout(false);

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
            Application.Run(new csNetForm());
		}

		private void csNetForm_Load(object sender, System.EventArgs e)
		{
           
		}

		private void btnRead_Click(object sender, System.EventArgs e)
		{

 			try
			{

                MyTag = new Tag(txtName.Text);
				////////////////////////////////////
				/// if the tag is a bool array
				if (btnBoolArray.Checked)
					MyTag.DataType = Logix.Tag.ATOMIC.BOOL;
				///////////////////////////////////
				/// if tag is a String
				else if (btnString.Checked)
			    	MyTag.DataType = Logix.Tag.ATOMIC.STRING;	

				////////////////////////////////////
				///provide information to Tag class
				///
				MyTag.Length = 1;
		
				//////////////////////////////////////////////
				/// there's no need to explicitly call Controller.Connect()
				/// Any call to ReadTag()/Write(), GroupRead() or GroupWrite()
				/// will automatically establish the connection
				/// 
                if (MyPLC.ReadTag(MyTag) != ResultCode.E_SUCCESS)
                {
                    if (MyPLC.ErrorCode == 0x10312)
                        MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + MyPLC.ErrorString, this.Text);
                    return;
                }

				//////////////////////////////////////////////
				/// check results
				/// 
				if (ResultCode.QUAL_GOOD == MyTag.QualityCode)
				{
					txtValue.Text = MyTag.Value.ToString();
                    lblTimestamp.Text = MyTag.TimeStamp.ToString();
					btnWrite.Enabled = true;
				}
				else
				{
					txtValue.Text = "????";
					MessageBox.Show("Error: " + MyTag.ErrorString, this.Text);
					btnWrite.Enabled = false;

				}
				lblQualString.Text = MyTag.QualityString;

			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}
		}

		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			try
			{

				/////////////////////////////////////
				/// update the .Value property
				/// 
                MyTag.Value = txtValue.Text;

                MyTag.Length = 1;

				if (MyPLC.WriteTag(MyTag) !=ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(MyPLC.ErrorString, this.Text);
                    return;
                }

				///////////////////////////////////////////
				/// display the tag results
				/// 
				if(Logix.ResultCode.QUAL_GOOD == MyTag.QualityCode)
					lblTimestamp.Text = MyTag.TimeStamp.ToString();
				else
                    MessageBox.Show(MyTag.ErrorString, this.Text);

				lblQualString.Text = MyTag.QualityString;

			}
           
		catch(System.Exception ex)
		{
			MessageBox.Show(ex.Message, this.Text);
		}
           
		}

 
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            MyPLC.Disconnect();
            tagProps.Enabled = false;
        }

        private void btnLOGIX_CheckedChanged_1(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.LOGIX;
            btnBoolArray.Enabled = true;
            btnString.Enabled = true;
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            ////////////////////////////////////
            ///provide connection information to 
            ///instance of Controller class
            ///
            MyPLC.IPAddress = txtIPAddress.Text;
            MyPLC.Path = txtPath.Text;
            MyPLC.Timeout = 3000;

            if (MyPLC.Connect() != ResultCode.E_SUCCESS)
            {
                MessageBox.Show(MyPLC.ErrorString, this.Text);
                return;
            }
            tagProps.Enabled = true;
        }

        private void btnM850_CheckedChanged_1(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.MICRO;
            btnBoolArray.Enabled = false;
            btnString.Enabled = false;
        }

        private void btnString_CheckedChanged(object sender, EventArgs e)
        {
            
        }

 



        
	}
}
