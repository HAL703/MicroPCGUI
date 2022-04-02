using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Logix;
using System.Threading;

namespace NETLOGIX.CS.GroupRead
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label _itemCount;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListView _tagView;
		private System.Windows.Forms.Button _btnChangeRate;
		private System.Windows.Forms.TextBox _updateRate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox _tagProperties;
		private System.Windows.Forms.Button _btnAddTag;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _ipaddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox _path;
		private System.Windows.Forms.GroupBox _groupProperties;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// INGEAR.NET.Logix Controller class
		/// </summary>
		Controller MyPLC = new Controller();

        /// <summary>
        /// INGEAR.NET.Logix TagGroup class
        /// </summary>
        TagGroup MyGroup = new Logix.TagGroup();

        private System.Windows.Forms.Label _status;

		private System.Windows.Forms.RadioButton btnDefaultType;
		private System.Windows.Forms.RadioButton btnBoolArray;
		private System.Windows.Forms.RadioButton btnStringTag;
        private Label label16;
        private RadioButton btnLogix;
        private RadioButton btnMicro;
        private Label label17;
		private System.Windows.Forms.TextBox _tagName;


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			/////////////////////////////////
			/// mouse event handler
			/// for the tag view list
			/// 
			_tagView.MouseDown+=new MouseEventHandler(_tagView_MouseDown);

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{

            MyGroup.ScanStop();
            MyPLC.Disconnect();

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
            this._itemCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tagView = new System.Windows.Forms.ListView();
            this._btnChangeRate = new System.Windows.Forms.Button();
            this._updateRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tagProperties = new System.Windows.Forms.GroupBox();
            this.btnStringTag = new System.Windows.Forms.RadioButton();
            this.btnBoolArray = new System.Windows.Forms.RadioButton();
            this.btnDefaultType = new System.Windows.Forms.RadioButton();
            this._btnAddTag = new System.Windows.Forms.Button();
            this._tagName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._ipaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this._path = new System.Windows.Forms.TextBox();
            this._groupProperties = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._status = new System.Windows.Forms.Label();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnMicro = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this._tagProperties.SuspendLayout();
            this._groupProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // _itemCount
            // 
            this._itemCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._itemCount.Location = new System.Drawing.Point(96, 48);
            this._itemCount.Name = "_itemCount";
            this._itemCount.Size = new System.Drawing.Size(96, 16);
            this._itemCount.TabIndex = 21;
            this._itemCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 233);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Using Group Scanning";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(8, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(256, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "1). Select CPU Type";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(104, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Right double-click Tag Name";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(104, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Left double-click Tag Name";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Remove Tag:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Write Tag:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "6). Repeat steps 2-4 to add more tags";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "5). Click the \"Add Tag\" button";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "4). Select data type ( Atomic / Bool Array / String )";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "3). Enter a CPU Tag Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "2). Enter the IP Address and Path of the PLC";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Group Items:";
            // 
            // _tagView
            // 
            this._tagView.Enabled = false;
            this._tagView.GridLines = true;
            this._tagView.Location = new System.Drawing.Point(0, 300);
            this._tagView.Name = "_tagView";
            this._tagView.Size = new System.Drawing.Size(544, 224);
            this._tagView.TabIndex = 17;
            this._tagView.UseCompatibleStateImageBehavior = false;
            // 
            // _btnChangeRate
            // 
            this._btnChangeRate.Location = new System.Drawing.Point(168, 16);
            this._btnChangeRate.Name = "_btnChangeRate";
            this._btnChangeRate.Size = new System.Drawing.Size(64, 23);
            this._btnChangeRate.TabIndex = 16;
            this._btnChangeRate.Text = "< Change";
            this._btnChangeRate.Click += new System.EventHandler(this._btnChangeRate_Click);
            // 
            // _updateRate
            // 
            this._updateRate.Location = new System.Drawing.Point(104, 18);
            this._updateRate.Name = "_updateRate";
            this._updateRate.Size = new System.Drawing.Size(48, 20);
            this._updateRate.TabIndex = 15;
            this._updateRate.Text = "1000";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Update Rate (ms)";
            // 
            // _tagProperties
            // 
            this._tagProperties.Controls.Add(this.btnStringTag);
            this._tagProperties.Controls.Add(this.btnBoolArray);
            this._tagProperties.Controls.Add(this.btnDefaultType);
            this._tagProperties.Controls.Add(this._btnAddTag);
            this._tagProperties.Controls.Add(this._tagName);
            this._tagProperties.Controls.Add(this.label2);
            this._tagProperties.Enabled = false;
            this._tagProperties.Location = new System.Drawing.Point(9, 120);
            this._tagProperties.Name = "_tagProperties";
            this._tagProperties.Size = new System.Drawing.Size(248, 104);
            this._tagProperties.TabIndex = 13;
            this._tagProperties.TabStop = false;
            this._tagProperties.Text = "Tag Properties";
            // 
            // btnStringTag
            // 
            this.btnStringTag.Location = new System.Drawing.Point(183, 53);
            this.btnStringTag.Name = "btnStringTag";
            this.btnStringTag.Size = new System.Drawing.Size(52, 21);
            this.btnStringTag.TabIndex = 7;
            this.btnStringTag.Text = "String";
            // 
            // btnBoolArray
            // 
            this.btnBoolArray.Location = new System.Drawing.Point(88, 56);
            this.btnBoolArray.Name = "btnBoolArray";
            this.btnBoolArray.Size = new System.Drawing.Size(75, 16);
            this.btnBoolArray.TabIndex = 6;
            this.btnBoolArray.Text = "Bool Array";
            // 
            // btnDefaultType
            // 
            this.btnDefaultType.Checked = true;
            this.btnDefaultType.Location = new System.Drawing.Point(8, 56);
            this.btnDefaultType.Name = "btnDefaultType";
            this.btnDefaultType.Size = new System.Drawing.Size(64, 16);
            this.btnDefaultType.TabIndex = 5;
            this.btnDefaultType.TabStop = true;
            this.btnDefaultType.Text = "Atomic";
            // 
            // _btnAddTag
            // 
            this._btnAddTag.Location = new System.Drawing.Point(48, 78);
            this._btnAddTag.Name = "_btnAddTag";
            this._btnAddTag.Size = new System.Drawing.Size(144, 22);
            this._btnAddTag.TabIndex = 4;
            this._btnAddTag.Text = "Add Tag";
            this._btnAddTag.Click += new System.EventHandler(this._btnAddTag_Click);
            // 
            // _tagName
            // 
            this._tagName.Location = new System.Drawing.Point(8, 32);
            this._tagName.Name = "_tagName";
            this._tagName.Size = new System.Drawing.Size(232, 20);
            this._tagName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // _ipaddress
            // 
            this._ipaddress.Location = new System.Drawing.Point(96, 41);
            this._ipaddress.Name = "_ipaddress";
            this._ipaddress.Size = new System.Drawing.Size(144, 20);
            this._ipaddress.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(16, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Path";
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(96, 64);
            this._path.Name = "_path";
            this._path.Size = new System.Drawing.Size(144, 20);
            this._path.TabIndex = 23;
            this._path.Text = "0";
            // 
            // _groupProperties
            // 
            this._groupProperties.Controls.Add(this.label4);
            this._groupProperties.Controls.Add(this._updateRate);
            this._groupProperties.Controls.Add(this._btnChangeRate);
            this._groupProperties.Controls.Add(this.label5);
            this._groupProperties.Controls.Add(this._itemCount);
            this._groupProperties.Enabled = false;
            this._groupProperties.Location = new System.Drawing.Point(8, 224);
            this._groupProperties.Name = "_groupProperties";
            this._groupProperties.Size = new System.Drawing.Size(248, 72);
            this._groupProperties.TabIndex = 24;
            this._groupProperties.TabStop = false;
            this._groupProperties.Text = "Group Properties";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(96, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 24);
            this.btnConnect.TabIndex = 25;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(168, 88);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 24);
            this.btnDisconnect.TabIndex = 26;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(264, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Status:";
            // 
            // _status
            // 
            this._status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._status.Location = new System.Drawing.Point(312, 268);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(224, 16);
            this._status.TabIndex = 28;
            this._status.Text = "DISCONNECT";
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(96, 18);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(50, 17);
            this.btnLogix.TabIndex = 29;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "Logix";
            this.btnLogix.UseVisualStyleBackColor = true;
            this.btnLogix.CheckedChanged += new System.EventHandler(this.btnLogix_CheckedChanged);
            // 
            // btnMicro
            // 
            this.btnMicro.AutoSize = true;
            this.btnMicro.Location = new System.Drawing.Point(168, 18);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(51, 17);
            this.btnMicro.TabIndex = 30;
            this.btnMicro.Text = "Micro";
            this.btnMicro.UseVisualStyleBackColor = true;
            this.btnMicro.CheckedChanged += new System.EventHandler(this.btnMicro_CheckedChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(18, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 31;
            this.label17.Text = "CPU Type";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(547, 531);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnMicro);
            this.Controls.Add(this.btnLogix);
            this.Controls.Add(this._status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this._groupProperties);
            this.Controls.Add(this._path);
            this.Controls.Add(this._ipaddress);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._tagView);
            this.Controls.Add(this._tagProperties);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX - C# Group Scanning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this._tagProperties.ResumeLayout(false);
            this._tagProperties.PerformLayout();
            this._groupProperties.ResumeLayout(false);
            this._groupProperties.PerformLayout();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// **********************************
			// * add colums to list view
			// *
			_tagView.View = View.Details;
			_tagView.Columns.Add("Tag Name", 100, HorizontalAlignment.Left);
			_tagView.Columns.Add("Value", 100, HorizontalAlignment.Left);
			_tagView.Columns.Add("Data Type", 100, HorizontalAlignment.Left);
			_tagView.Columns.Add("Quality", 100, HorizontalAlignment.Left);
			_tagView.Columns.Add("Time Stamp", 140, HorizontalAlignment.Left);

		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			////////////////////////////////////
			/// connect to the PLC
			try
			{
                
				///////////////////////////////
				/// set the IP Addres, Path
				/// properties.  We'll also set
				/// the timeout property to 3000ms
				MyPLC.IPAddress = _ipaddress.Text;
				MyPLC.Path = _path.Text;
				MyPLC.Timeout = 3000;

                if (btnMicro.Checked)
                    MyPLC.CPUType = Controller.CPU.MICRO;
                else
                    MyPLC.CPUType = Controller.CPU.LOGIX;
				////////////////////////////////
				/// let's connect and check
				/// results
				if (ResultCode.E_SUCCESS == MyPLC.Connect())
				{
					_status.Text = "CONNECTED";
					_tagProperties.Enabled = true;
					_groupProperties.Enabled = true;
					btnDisconnect.Enabled = true;
					btnConnect.Enabled = false;
					_tagView.Enabled = true;

                    ///////////////////////////
                    // set scanning parameters

                    // Step 1: assign parent Controller class
                    MyGroup.Controller = MyPLC;
                    // Step 2: start scanning
                    MyGroup.ScanStart();
				}
				else
				{
					string msg = "ERROR:"+MyPLC.ErrorCode.ToString()+" - " + MyPLC.ErrorString;
					MessageBox.Show(msg, this.Text);
				}

			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}	
		}

		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
			try
			{
                ///////////////////////////////
                // stop scanning
                MyGroup.ScanStop();

				///////////////////////////////
				/// disconnect the PLC
				/// 
				MyPLC.Disconnect();
				_status.Text = "DISCONNECTED";
				_tagName.Text = "";
				_tagProperties.Enabled = false;
				_groupProperties.Enabled = false;
				btnDisconnect.Enabled = false;
				btnConnect.Enabled = true;
				_tagView.Enabled = false;

				/////////////////////////////
				// clean up the tag view list
				// and remove items from Group
				MyGroup.Clear();
				_tagView.Items.Clear();

				_itemCount.Text = MyGroup.Count.ToString();
				_tagView.Enabled = false;


			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}
		}


 		/// <summary>
		/// Tag.Changed event handler
		/// </summary>
		/// <param name="sender">
		/// Instance of Tag class that invoked the change</param>
		/// <param name="e">DataChangedEventArgs</param>
		private void newTag_Changed(object sender, EventArgs e)
		{
		  //////////////////////////////////////////////////
          // since tag_changed is being called from the plcUpdate
          // thread, we need to ceated a delegate to handle the UI
          if (InvokeRequired)
               Invoke(new changedDelegate(tagChanged), new object[] {e});
           else
               tagChanged(e);
    	}

        /// <summary>
        /// Delegate for the UI update
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void changedDelegate(EventArgs e);

        /// <summary>
        /// tagChanged data handler
        /// </summary>
        /// <param name="e">
        /// DataChangeEventArgs
        /// </param>
        private void tagChanged(EventArgs e)
        {
            try
            {

                ///////////////////////////
                /// data change event args associated with the tag
                DataChangeEventArgs args = (DataChangeEventArgs)e;

                //  ********************************
                //  * retrieve the ListViewItem associated
                //  * with the Tag class
                ListViewItem tagViewItem = (ListViewItem)args.MyObject;

                //  ********************************
                //  * we' ll check the QUALITY of the 
                //  * tag.  If we' ve got a good quality
                //  * we'll update the list view items.
                if (ResultCode.QUAL_GOOD == args.QualityCode)
                {
                    tagViewItem.SubItems[1].Text = Convert.ToString(args.Value);
                    tagViewItem.SubItems[4].Text = args.TimeStamp.ToString();
                }
                else
                    tagViewItem.SubItems[1].Text = "????";

                /////////////////////////
                /// we'll always display
                /// the quality string
                /// 
                tagViewItem.SubItems[3].Text = args.QualityString;

                if (MyPLC.IsConnected == false)
                    _status.Text = "DISCONNECTED";
                else
                    _status.Text = "CONNECTED";


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

 
		private void _btnAddTag_Click(object sender, System.EventArgs e)
		{

                try
                {
                    Tag newTag = new Tag(_tagName.Text);
                    ////////////////////////////////
                    /// if this is a BOOL ARRAY, we need to 
                    /// specify in the contructor
                    if (true == btnBoolArray.Checked)
                        newTag.DataType = Logix.Tag.ATOMIC.BOOL;
                    ////////////////////////////////
                    /// if this is a STRING tag, we need to 
                    /// specify in the contructor
                    else if (true == btnStringTag.Checked)
                        newTag.DataType = Logix.Tag.ATOMIC.STRING;

                    // read the tag to make sure it exists
                    if (MyPLC.ReadTag(newTag) != ResultCode.E_SUCCESS)
                    {
                        if (MyPLC.ErrorCode == 0x10312)
                            MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                        else
                            MessageBox.Show("Error : " + MyPLC.ErrorString, this.Text);
                        return;
                    }

                    ////////////////////////////////////
                    /// if the quality is good add the tag
                    /// to the tag list
                    if (ResultCode.QUAL_GOOD == newTag.QualityCode)
                    {
                        //////////////////////////////////
                        /// add event handler
                        /// this event handler will be common
                        /// for all tags
                        /// 
                        newTag.Changed += new System.EventHandler(newTag_Changed);

                        // *************************
                        // * add the Tag Name to the 
                        // * ListView
                        ListViewItem tagListItem = _tagView.Items.Add(newTag.Name);

                        // ***************************
                        // * use Tag.MyObject to remember
                        // * its reference in the ListView (_tagView)
                        // *
                        // * we'll use this for updating
                        // * the ListView when we get a DataChange
                        // * event
                        newTag.MyObject = tagListItem;

                        // ****************************
                        // * also, we'll reference newTag
                        // * in the tagListItem
                        // *
                        // * we'll use this for referencing
                        // * the tag when we click on the ListView
                        tagListItem.Tag = newTag;

                        // ****************************
                        // * display something for the value
                        // * to create the listview item
                        tagListItem.SubItems.Add(newTag.Value.ToString());

                        // ***********************
                        // * display data type in the listview
                        // *
                        tagListItem.SubItems.Add(newTag.NetType.ToString());

                        // ************************
                        // * and the quality string
                        // 
                        tagListItem.SubItems.Add(newTag.QualityString);

                        // ************************
                        // * and the timestamp
                        // *
                        tagListItem.SubItems.Add(newTag.TimeStamp.ToString());

                        // ************************
                        // * add the tag to the tag group
                        // *
                        MyGroup.AddTag(newTag);

                        ////////////////////////////
                        /// display number of tags
                        /// in group
                        /// 
                        _itemCount.Text = MyGroup.Count.ToString();
                    }
                    else
                        MessageBox.Show(newTag.ErrorString, this.Text);

                }
                // ****************************
                // * any exceptions will be shown
                // * in a message box
                // *
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text);
                }
		}

		private void _tagView_MouseDown(object sender, MouseEventArgs e)
		{
			//////////////////////////////
			/// If there are no more items
			/// or it's not a double click
			/// we'll just exit
			///  
			if (0== _tagView.Items.Count || 2!= e.Clicks)
				return;

			///////////////////////////////
			/// get the listview item in focus
			/// 
			ListViewItem theItem = ((ListView)sender).FocusedItem;
			
			///////////////////////////////
			/// reference the GELink.Tag associated
			/// with the item
			/// 
			Tag theTag = (Tag)theItem.Tag;

			////////////////////////////////
			/// catch exceptions
			try
			{
				//////////////////////////////
				/// LEFT double-click (Write Tag)
				/// 
				if (MouseButtons.Left == e.Button)
				{
					///////////////////////////
					/// Tag Write dialog box
					/// 
					frmTagWrite tagWriteDlg = new frmTagWrite();

					//  ****************************
					//  * add a description along with a
					//  * the current value in the 
					//  * tagWriteDlg
					tagWriteDlg._description.Text = "Write value to " + theTag.Name;
					tagWriteDlg._newValue.Text = Convert.ToString(theTag.Value);

                    // just set .Value property
                    // scanning automatically write to PLC
                    if(DialogResult.OK == tagWriteDlg.ShowDialog())
						theTag.Value = tagWriteDlg._newValue.Text;
					
				}
					/////////////////////////////
					/// RIGHT double-click (Remove Tag)
					/// 
				else if (MouseButtons.Right == e.Button)
				{
					///////////////////////////////////
					/// remove the tag from the group
					/// 
					MyGroup.RemoveTag(theTag);

					//////////////////////////////////
					/// refesh item display count
					/// 
					_itemCount.Text = MyGroup.Count.ToString();

					//////////////////////////////////
					/// remove from listview
					/// 
					_tagView.Items.Remove(theItem);

				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text);
			}

		}

 
        private void _btnChangeRate_Click(object sender, System.EventArgs e)
		{
			 MyGroup.Interval= Convert.ToInt32(_updateRate.Text);
		}

        private void btnLogix_CheckedChanged(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.LOGIX;
        }

        private void btnMicro_CheckedChanged(object sender, EventArgs e)
        {
            MyPLC.CPUType = Controller.CPU.MICRO;
        }

  
  
	}
}
