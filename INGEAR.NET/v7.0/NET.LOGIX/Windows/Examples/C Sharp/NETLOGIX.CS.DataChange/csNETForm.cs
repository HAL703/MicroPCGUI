using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using Logix;

namespace NETLOGIX.CS.DataChange
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class csNETForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIPAddress;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Timer ScanTimer;
		private System.ComponentModel.IContainer components;

        Stopwatch sw = new Stopwatch();

		/// <summary>
		/// declare an instance of the Controller Class
		/// </summary>
		Controller MyPLC = new Controller();

		
		// declare an instance of the Tag class
		// additional Tag class instances can be 
		// created if needed.
		Tag MyTag = new Tag();

        int scancount = 0;
        private GroupBox tagProps;
        private Button btnWrite;
        private TextBox _writeValue;
        private Label label10;
        private RadioButton btnString;
        private RadioButton btnBoolArray;
        private RadioButton _btnAtomic;
        private Label lblScanCount;
        private Label label14;
        private Label lblChangeCount;
        private Label label12;
        private Label lblQuality;
        private Label label11;
        private Label lblPrevVal;
        private Label label9;
        private Label lblCurValue;
        private Label label8;
        private Label lblTimeStamp;
        private Label label7;
        private Label label6;
        private Button btnStopScan;
        private TextBox txtScanRate;
        private Label label5;
        private Button btnStartScan;
        private CheckBox btnActive;
        private TextBox txtName;
        private Label label4;
        private RadioButton btnLogix;
        private RadioButton btnMicro;
        private Label label13;
        private Button btnConnect;
        private Button btnDisconnect;
        private Label tagType;
        private Label label15;
		int changecount = 0;


		public csNETForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// set the Tag.DataChange event handler
			// if you've declared additional tags for your scan group
			// be sure to add the event handlers if needed.
			//
			this.MyTag.Changed +=new EventHandler(MyTag_Changed);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csNETForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            this.tagProps = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tagType = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this._writeValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.RadioButton();
            this.btnBoolArray = new System.Windows.Forms.RadioButton();
            this._btnAtomic = new System.Windows.Forms.RadioButton();
            this.lblScanCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblChangeCount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrevVal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.txtScanRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnMicro = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tagProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demonstrates DataChange event handling.  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(106, 55);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(192, 22);
            this.txtIPAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU Slot / CIP Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(106, 83);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(307, 22);
            this.txtPath.TabIndex = 4;
            this.txtPath.Text = "0";
            // 
            // ScanTimer
            // 
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // tagProps
            // 
            this.tagProps.Controls.Add(this.label15);
            this.tagProps.Controls.Add(this.tagType);
            this.tagProps.Controls.Add(this.btnWrite);
            this.tagProps.Controls.Add(this._writeValue);
            this.tagProps.Controls.Add(this.label10);
            this.tagProps.Controls.Add(this.btnString);
            this.tagProps.Controls.Add(this.btnBoolArray);
            this.tagProps.Controls.Add(this._btnAtomic);
            this.tagProps.Controls.Add(this.lblScanCount);
            this.tagProps.Controls.Add(this.label14);
            this.tagProps.Controls.Add(this.lblChangeCount);
            this.tagProps.Controls.Add(this.label12);
            this.tagProps.Controls.Add(this.lblQuality);
            this.tagProps.Controls.Add(this.label11);
            this.tagProps.Controls.Add(this.lblPrevVal);
            this.tagProps.Controls.Add(this.label9);
            this.tagProps.Controls.Add(this.lblCurValue);
            this.tagProps.Controls.Add(this.label8);
            this.tagProps.Controls.Add(this.lblTimeStamp);
            this.tagProps.Controls.Add(this.label7);
            this.tagProps.Controls.Add(this.label6);
            this.tagProps.Controls.Add(this.btnStopScan);
            this.tagProps.Controls.Add(this.txtScanRate);
            this.tagProps.Controls.Add(this.label5);
            this.tagProps.Controls.Add(this.btnStartScan);
            this.tagProps.Controls.Add(this.btnActive);
            this.tagProps.Controls.Add(this.txtName);
            this.tagProps.Controls.Add(this.label4);
            this.tagProps.Enabled = false;
            this.tagProps.Location = new System.Drawing.Point(10, 142);
            this.tagProps.Name = "tagProps";
            this.tagProps.Size = new System.Drawing.Size(416, 316);
            this.tagProps.TabIndex = 32;
            this.tagProps.TabStop = false;
            this.tagProps.Text = "Tag Properties";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 59;
            this.label15.Text = "VALUES";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tagType
            // 
            this.tagType.Location = new System.Drawing.Point(109, 68);
            this.tagType.Name = "tagType";
            this.tagType.Size = new System.Drawing.Size(154, 19);
            this.tagType.TabIndex = 58;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(13, 279);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(144, 28);
            this.btnWrite.TabIndex = 57;
            this.btnWrite.Text = "Write Value";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // _writeValue
            // 
            this._writeValue.Location = new System.Drawing.Point(11, 238);
            this._writeValue.Name = "_writeValue";
            this._writeValue.Size = new System.Drawing.Size(259, 22);
            this._writeValue.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(1, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "Write Value";
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(337, 44);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(67, 21);
            this.btnString.TabIndex = 54;
            this.btnString.Text = "String";
            // 
            // btnBoolArray
            // 
            this.btnBoolArray.Location = new System.Drawing.Point(208, 44);
            this.btnBoolArray.Name = "btnBoolArray";
            this.btnBoolArray.Size = new System.Drawing.Size(96, 18);
            this.btnBoolArray.TabIndex = 53;
            this.btnBoolArray.Text = "Bool Array";
            // 
            // _btnAtomic
            // 
            this._btnAtomic.Checked = true;
            this._btnAtomic.Location = new System.Drawing.Point(97, 44);
            this._btnAtomic.Name = "_btnAtomic";
            this._btnAtomic.Size = new System.Drawing.Size(77, 18);
            this._btnAtomic.TabIndex = 52;
            this._btnAtomic.TabStop = true;
            this._btnAtomic.Text = "Atomic";
            // 
            // lblScanCount
            // 
            this.lblScanCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScanCount.Location = new System.Drawing.Point(308, 288);
            this.lblScanCount.Name = "lblScanCount";
            this.lblScanCount.Size = new System.Drawing.Size(68, 19);
            this.lblScanCount.TabIndex = 51;
            this.lblScanCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(284, 270);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 50;
            this.label14.Text = "Scan Updates";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChangeCount
            // 
            this.lblChangeCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChangeCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChangeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeCount.Location = new System.Drawing.Point(299, 219);
            this.lblChangeCount.Name = "lblChangeCount";
            this.lblChangeCount.Size = new System.Drawing.Size(87, 46);
            this.lblChangeCount.TabIndex = 49;
            this.lblChangeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(280, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 18);
            this.label12.TabIndex = 48;
            this.label12.Text = "Data Changes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuality
            // 
            this.lblQuality.Location = new System.Drawing.Point(107, 190);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(153, 19);
            this.lblQuality.TabIndex = 47;
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 46;
            this.label11.Text = "Quality";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevVal
            // 
            this.lblPrevVal.Location = new System.Drawing.Point(107, 137);
            this.lblPrevVal.Name = "lblPrevVal";
            this.lblPrevVal.Size = new System.Drawing.Size(153, 19);
            this.lblPrevVal.TabIndex = 45;
            this.lblPrevVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Previous";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurValue
            // 
            this.lblCurValue.Location = new System.Drawing.Point(107, 111);
            this.lblCurValue.Name = "lblCurValue";
            this.lblCurValue.Size = new System.Drawing.Size(153, 18);
            this.lblCurValue.TabIndex = 43;
            this.lblCurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Current";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.Location = new System.Drawing.Point(107, 166);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(153, 19);
            this.lblTimeStamp.TabIndex = 41;
            this.lblTimeStamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Time Stamp";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data Type";
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(299, 145);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(105, 28);
            this.btnStopScan.TabIndex = 38;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // txtScanRate
            // 
            this.txtScanRate.Location = new System.Drawing.Point(299, 90);
            this.txtScanRate.Name = "txtScanRate";
            this.txtScanRate.Size = new System.Drawing.Size(96, 22);
            this.txtScanRate.TabIndex = 37;
            this.txtScanRate.Text = "1000";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(289, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Scan Rate (ms)";
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(299, 118);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(105, 27);
            this.btnStartScan.TabIndex = 35;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // btnActive
            // 
            this.btnActive.Checked = true;
            this.btnActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnActive.Location = new System.Drawing.Point(299, 173);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(108, 21);
            this.btnActive.TabIndex = 34;
            this.btnActive.Text = "Tag Is Active";
            this.btnActive.Click += new System.EventHandler(this.btnActive_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 22);
            this.txtName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tag Name";
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(108, 28);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(62, 21);
            this.btnLogix.TabIndex = 33;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "Logix";
            this.btnLogix.UseVisualStyleBackColor = true;
            this.btnLogix.CheckedChanged += new System.EventHandler(this.btnLogix_CheckedChanged);
            // 
            // btnMicro
            // 
            this.btnMicro.AutoSize = true;
            this.btnMicro.Location = new System.Drawing.Point(188, 28);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(63, 21);
            this.btnMicro.TabIndex = 34;
            this.btnMicro.Text = "Micro";
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.CheckedChanged += new System.EventHandler(this.btnMicro_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(19, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "CPU Type";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(106, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 25);
            this.btnConnect.TabIndex = 36;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(230, 113);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(107, 25);
            this.btnDisconnect.TabIndex = 37;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // csNETForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(806, 621);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnMicro);
            this.Controls.Add(this.btnLogix);
            this.Controls.Add(this.tagProps);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "csNETForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX C# DataChange Example";
            this.Load += new System.EventHandler(this.csNETForm_Load);
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
            Application.Run(new csNETForm());
		}

		private void MyTag_Changed(object sender, System.EventArgs e)
		{
			Tag theTag = (Tag)sender;
			DataChangeEventArgs args = (DataChangeEventArgs)e;

			/////////////////////////////////////
			/// increment the change count and 
			/// display
			changecount++;
			lblChangeCount.Text = changecount.ToString();

			/////////////////////////////////////////
			/// event args tell about the data change
			/// 

			///////////////////////////////////////
			/// time stamp
			lblTimeStamp.Text = args.TimeStamp.ToString();

			////////////////////////////////////////
			/// current value
			lblCurValue.Text = args.Value.ToString();

			///////////////////////////////////////
			/// previous value
            /// 
			if (args.PreValue != null)
                lblPrevVal.Text = args.PreValue.ToString();

			//////////////////////////////////////
			/// quality code
			lblQuality.Text = args.QualityString;
		}

		private void csNETForm_Load(object sender, System.EventArgs e)
		{
			
		}

		private void ScanTimer_Tick(object sender, System.EventArgs e)
		{
			////////////////////////////////////////
			/// update the scan count and display
			scancount++;
			lblScanCount.Text = scancount.ToString();

			//////////////////////////////////////
			///update the group
            if (MyPLC.ReadTag(MyTag) != ResultCode.E_SUCCESS)
            {
                ScanTimer.Enabled = false;
                MessageBox.Show(MyPLC.ErrorString);
            }

		}

		private void btnStartScan_Click(object sender, System.EventArgs e)
		{
			try
			{
				//////////////////////////////////////////
				/// reset incrementing counters
				scancount = 0;
				lblScanCount.Text = scancount.ToString();
				changecount = 0;
				lblChangeCount.Text = changecount.ToString();


				/////////////////////////////////////////
				// set Tag properties
				MyTag.Name = txtName.Text;
				MyTag.Active = btnActive.Checked;

				/////////////////////////////////////////
				/// set the data type property
				/// 
				if (btnBoolArray.Checked)
					MyTag.NetType = typeof(System.Boolean);
				else if (btnString.Checked)
					MyTag.NetType = typeof(System.String);

				
				/////////////////////////////////////////
				// perform initial update
				if (MyPLC.ReadTag(MyTag)!=ResultCode.E_SUCCESS)
                {
                     if (MyPLC.ErrorCode == 0x10312)
                         MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                     else
                         MessageBox.Show("Error : " + MyPLC.ErrorString, this.Text);
                     return;
                }
                
                tagType.Text = MyTag.NetType.ToString();

				/////////////////////////////////////////
				// update scan count
				scancount++;
				lblScanCount.Text = scancount.ToString();

				////////////////////////////////////////
				/// set the timer properties to begin
				/// scanning
				ScanTimer.Interval = Convert.ToInt32(txtScanRate.Text);
				ScanTimer.Enabled = true;
			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}

		}

		private void btnStopScan_Click(object sender, System.EventArgs e)
		{
			//////////////////////////////////////
			// do some clean up

			//////////////////////////////////////
			// stop the scan timer
			ScanTimer.Enabled = false;
			
	
		}

		private void btnActive_CheckedChanged(object sender, System.EventArgs e)
		{
			//////////////////////////////////////
			// include/exclude tag from being
			// updated in TagGroup class
			MyTag.Active = btnActive.Checked;
		}

		private void btnWrite_Click(object sender, System.EventArgs e)
		{
            ScanTimer.Enabled = false;
			try
			{
				////////////////////////////////
				/// create a tag for writing
			//	Tag writeTag = new Tag();
			//	writeTag.Name = MyTag.Name;
			//	writeTag.NetType = MyTag.NetType;
			    MyTag.Value = _writeValue.Text;
			
				///////////////////////////////
				/// write tag and check for results
				/// 
				if(MyPLC.WriteTag(MyTag)!=ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(MyPLC.ErrorString, this.Text);
                    return;
                }

				if (ResultCode.QUAL_GOOD != MyTag.QualityCode)
				{
					string msg = "Write Failed: " + MyTag.ErrorString;
					MessageBox.Show(msg, this.Text);
				}

			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}
            ScanTimer.Enabled = true;
		}

         private void btnLogix_CheckedChanged(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.LOGIX;
        }

         private void btnMicro_CheckedChanged(object sender, EventArgs e)
         {
             MyPLC.CPUType = Controller.CPU.MICRO;
         }

         private void btnConnect_Click(object sender, EventArgs e)
         {
             try
             {
                 //////////////////////////////////////////
                 /// set Controller class properties
                 MyPLC.IPAddress = txtIPAddress.Text;
                 MyPLC.Path = txtPath.Text;
                 MyPLC.Timeout = 3000;

                 if (MyPLC.Connect() != ResultCode.E_SUCCESS)
                 {
                     MessageBox.Show(MyPLC.ErrorString, this.Text);
                     return;
                 }
                 tagProps.Enabled = true;
                 btnLogix.Enabled = false;
                 btnMicro.Enabled = false;
             }
             catch (System.Exception ex)
             {
                 MessageBox.Show(ex.Message, this.Text);

             }

         }

         private void btnDisconnect_Click(object sender, EventArgs e)
         {
             MyPLC.Disconnect();
             tagProps.Enabled = false;
             btnLogix.Enabled = true;
             btnMicro.Enabled = true;
         }
	}
}
