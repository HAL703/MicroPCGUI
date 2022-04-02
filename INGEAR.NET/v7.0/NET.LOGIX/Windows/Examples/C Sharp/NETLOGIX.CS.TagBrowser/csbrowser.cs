using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Logix;

namespace NETLOGIX.CS.Browser
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label _itemCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView _tagView;
        private System.Windows.Forms.Button _btnChangeRate;
        private System.Windows.Forms.TextBox _updateRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _ipaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox _path;
        private System.Windows.Forms.GroupBox _groupProperties;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// INGEAR.NET.Logix Controller class
        /// </summary>
        Controller MyPLC = new Controller();
        private TreeView treeView1;

        /// <summary>
        /// INGEAR.NET.Logix TagGroup class
        /// </summary>
        TagGroup MyGroup = new Logix.TagGroup();

        Tag cpuInfo = new Tag("@CPU_INFO");

        Tag cpuState = new Tag("@CPU_STATE");
        private TextBox textBox1;

        string progName = "";
        string rootName = "";

        TreeNode rootNode = new TreeNode();

        ReadOnlyCollection<TagTemplate> tagList = null;
        private Button btnRefresh;
        private TextBox filtrName;
        private TextBox filterType;
        private Label label2;
        private Label label3;
        private Label label6;
        private CheckBox chkGlobalTags;
        private CheckBox chkProgramTags;
        private RadioButton btnLogix;
        private RadioButton btnMicro8xx;
        private Label label7;
        ReadOnlyCollection<Logix.Program> programList = null;

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
            _tagView.MouseDown += new MouseEventHandler(_tagView_MouseDown);
                       
        }

       

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {

            MyGroup.ScanStop();
            MyPLC.Disconnect();
            
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.label5 = new System.Windows.Forms.Label();
            this._tagView = new System.Windows.Forms.ListView();
            this._btnChangeRate = new System.Windows.Forms.Button();
            this._updateRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._ipaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this._path = new System.Windows.Forms.TextBox();
            this._groupProperties = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.filtrName = new System.Windows.Forms.TextBox();
            this.filterType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkGlobalTags = new System.Windows.Forms.CheckBox();
            this.chkProgramTags = new System.Windows.Forms.CheckBox();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnMicro8xx = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this._groupProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // _itemCount
            // 
            this._itemCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._itemCount.Location = new System.Drawing.Point(124, 55);
            this._itemCount.Name = "_itemCount";
            this._itemCount.Size = new System.Drawing.Size(55, 19);
            this._itemCount.TabIndex = 21;
            this._itemCount.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tags on Scan";
            // 
            // _tagView
            // 
            this._tagView.AllowDrop = true;
            this._tagView.Enabled = false;
            this._tagView.GridLines = true;
            this._tagView.HideSelection = false;
            this._tagView.Location = new System.Drawing.Point(10, 426);
            this._tagView.Name = "_tagView";
            this._tagView.Size = new System.Drawing.Size(912, 229);
            this._tagView.TabIndex = 17;
            this._tagView.UseCompatibleStateImageBehavior = false;
            this._tagView.DragDrop += new System.Windows.Forms.DragEventHandler(this._tagView_DragDrop);
            this._tagView.DragEnter += new System.Windows.Forms.DragEventHandler(this._tagView_DragEnter);
            // 
            // _btnChangeRate
            // 
            this._btnChangeRate.Location = new System.Drawing.Point(185, 18);
            this._btnChangeRate.Name = "_btnChangeRate";
            this._btnChangeRate.Size = new System.Drawing.Size(77, 27);
            this._btnChangeRate.TabIndex = 16;
            this._btnChangeRate.Text = "Change";
            this._btnChangeRate.Click += new System.EventHandler(this._btnChangeRate_Click);
            // 
            // _updateRate
            // 
            this._updateRate.Location = new System.Drawing.Point(121, 21);
            this._updateRate.Name = "_updateRate";
            this._updateRate.Size = new System.Drawing.Size(58, 22);
            this._updateRate.TabIndex = 15;
            this._updateRate.Text = "1000";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Update Rate (ms)";
            // 
            // _ipaddress
            // 
            this._ipaddress.Location = new System.Drawing.Point(84, 31);
            this._ipaddress.Name = "_ipaddress";
            this._ipaddress.Size = new System.Drawing.Size(166, 22);
            this._ipaddress.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Address";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(4, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "CIP Path";
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(85, 60);
            this._path.Name = "_path";
            this._path.Size = new System.Drawing.Size(166, 22);
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
            this._groupProperties.Location = new System.Drawing.Point(268, 3);
            this._groupProperties.Name = "_groupProperties";
            this._groupProperties.Size = new System.Drawing.Size(274, 88);
            this._groupProperties.TabIndex = 24;
            this._groupProperties.TabStop = false;
            this._groupProperties.Text = "Scanning";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(90, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 29);
            this.btnConnect.TabIndex = 25;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(178, 88);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 29);
            this.btnDisconnect.TabIndex = 26;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(10, 148);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(912, 266);
            this.treeView1.TabIndex = 27;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(369, 86);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(714, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 41);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // filtrName
            // 
            this.filtrName.Location = new System.Drawing.Point(290, 118);
            this.filtrName.Name = "filtrName";
            this.filtrName.Size = new System.Drawing.Size(120, 22);
            this.filtrName.TabIndex = 30;
            // 
            // filterType
            // 
            this.filterType.Location = new System.Drawing.Point(426, 118);
            this.filterType.Name = "filterType";
            this.filterType.Size = new System.Drawing.Size(120, 22);
            this.filterType.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(181, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search Filters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(304, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "By Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(442, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "By Type";
            // 
            // chkGlobalTags
            // 
            this.chkGlobalTags.AutoSize = true;
            this.chkGlobalTags.Checked = true;
            this.chkGlobalTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGlobalTags.Location = new System.Drawing.Point(551, 95);
            this.chkGlobalTags.Name = "chkGlobalTags";
            this.chkGlobalTags.Size = new System.Drawing.Size(156, 21);
            this.chkGlobalTags.TabIndex = 35;
            this.chkGlobalTags.Text = "Include Global Tags";
            this.chkGlobalTags.UseVisualStyleBackColor = true;
            // 
            // chkProgramTags
            // 
            this.chkProgramTags.AutoSize = true;
            this.chkProgramTags.Checked = true;
            this.chkProgramTags.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProgramTags.Location = new System.Drawing.Point(551, 121);
            this.chkProgramTags.Name = "chkProgramTags";
            this.chkProgramTags.Size = new System.Drawing.Size(169, 21);
            this.chkProgramTags.TabIndex = 36;
            this.chkProgramTags.Text = "Include Program Tags";
            this.chkProgramTags.UseVisualStyleBackColor = true;
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(82, 6);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(62, 21);
            this.btnLogix.TabIndex = 37;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "Logix";
            this.btnLogix.UseVisualStyleBackColor = true;
            this.btnLogix.CheckedChanged += new System.EventHandler(this.btnLogix_CheckedChanged);
            // 
            // btnMicro8xx
            // 
            this.btnMicro8xx.AutoSize = true;
            this.btnMicro8xx.Location = new System.Drawing.Point(145, 6);
            this.btnMicro8xx.Name = "btnMicro8xx";
            this.btnMicro8xx.Size = new System.Drawing.Size(63, 21);
            this.btnMicro8xx.TabIndex = 38;
            this.btnMicro8xx.Text = "Micro";
            this.btnMicro8xx.UseVisualStyleBackColor = true;
            this.btnMicro8xx.CheckedChanged += new System.EventHandler(this.btnMicro8xx_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "CPU Type";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(775, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMicro8xx);
            this.Controls.Add(this.btnLogix);
            this.Controls.Add(this.chkProgramTags);
            this.Controls.Add(this.chkGlobalTags);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterType);
            this.Controls.Add(this.filtrName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this._groupProperties);
            this.Controls.Add(this._path);
            this.Controls.Add(this._ipaddress);
            this.Controls.Add(this.label15);
            this.Controls.Add(this._tagView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX  Browse, Drag/Drop, Scan ";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            _tagView.Columns.Add("Tag Name", 300, HorizontalAlignment.Left);
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

                this.Cursor = Cursors.WaitCursor;
                ////////////////////////////////
                /// let's connect and check
                /// results
                if (ResultCode.E_SUCCESS == MyPLC.Connect())
                {
                    _groupProperties.Enabled = true;
                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                    _tagView.Enabled = true;
                     this.Cursor = Cursors.Default;

                    // read CPU state & upload tags
                    GetPLCInfoAndState();

                    UploadTags();
                    btnRefresh.Enabled = true;

                    // Step 1: assign parent Controller class and start scanning
                    MyGroup.Controller = MyPLC;
                    MyGroup.Interval = Convert.ToInt32(_updateRate.Text);
                    MyGroup.ScanStart();
                   
               }
                else
                {
                   
                    string msg = "ERROR:" + MyPLC.ErrorCode.ToString() + " - " + MyPLC.ErrorString;
                    MessageBox.Show(msg, this.Text);
                }

            }
            catch (System.Exception ex)
           {
                MessageBox.Show(ex.Message, this.Text);
           }
            this.Cursor = Cursors.Default;
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

                _groupProperties.Enabled = false;
                btnDisconnect.Enabled = false;
                btnConnect.Enabled = true;
                _tagView.Enabled = false;

                /////////////////////////////
                // clean up the treeview, listview
                // and remove items from Group
                MyGroup.Clear();
                _tagView.Items.Clear();
                treeView1.Nodes.Clear();
                rootNode.Nodes.Clear();
                _itemCount.Text = MyGroup.Count.ToString();
                _tagView.Enabled = false;
                btnRefresh.Enabled = false;


            }
            catch (System.Exception ex)
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
                Invoke(new changedDelegate(tagChanged), new object[] { e });
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

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void _tagView_MouseDown(object sender, MouseEventArgs e)
        {
            //////////////////////////////
            /// If there are no more items
            /// or it's not a double click
            /// we'll just exit
            ///  
            if (0 == _tagView.Items.Count || 2 != e.Clicks)
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
                    if (DialogResult.OK == tagWriteDlg.ShowDialog())
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
            // change the update interval
            MyGroup.Interval = Convert.ToInt32(_updateRate.Text);
        }


        private void GetPLCInfoAndState()
        {
            this.Cursor = Cursors.WaitCursor;
            // read CPU info
            if (MyPLC.ReadTag(cpuInfo) == ResultCode.E_SUCCESS)
            {
                string[] plcInfo = (string[])cpuInfo.Value;
                rootName = rootNode.Text = "Controller " + plcInfo[0];
                rootNode.ToolTipText = plcInfo[1] + Environment.NewLine;
                rootNode.ToolTipText += "Firmware: " + plcInfo[2] + Environment.NewLine;                          
            }
            if (MyPLC.CPUType == Controller.CPU.LOGIX && _path.Text.Length > 0)
            {
            // read CPU State
                if (MyPLC.ReadTag(cpuState) == ResultCode.E_SUCCESS)
                {
                    // returns a 3-element System.Int32[]
                    Int32[] stateValue = (Int32[])cpuState.Value;

                    // Value 0 - OK LED State
                    switch (stateValue[0])
                    {
                        case 0:
                            rootNode.ToolTipText += "CPU: Power Up"; break;
                        case 1:
                            rootNode.ToolTipText += "CPU: FRN Update"; break;
                        case 2:
                            rootNode.ToolTipText += "CPU: Comms Fault"; break;
                        case 3:
                            rootNode.ToolTipText += "CPU: Awaiting Connection"; break;
                        case 4:
                            rootNode.ToolTipText += "CPU: Bad Config"; break;
                        case 5:
                            rootNode.ToolTipText += "CPU: Major Flt"; break;
                        case 6:
                            rootNode.ToolTipText += "CPU: Connected"; break;
                        case 7:
                            rootNode.ToolTipText += "CPU: Program Mode"; break;
                    }
                    rootNode.ToolTipText += Environment.NewLine;
                    // Value 1 - Major/Minor Fault
                    switch (stateValue[1])
                    {
                        case 0:
                            rootNode.ToolTipText += "CPU: No Fault"; break;
                        case 1:
                            rootNode.ToolTipText += "CPU: Minor Recoverable Fault"; break;
                        case 2:
                            rootNode.ToolTipText += "CPU: Minor Unrecoverable Fault"; break;
                        case 3:
                            rootNode.ToolTipText += "CPU: Major Recoverable Fault"; break;
                        case 4:
                            rootNode.ToolTipText += "CPU: Major Unrecoverable Fault"; break;
                    }
                    rootNode.ToolTipText += Environment.NewLine;
                    // Value 2 - Key Switch Position
                    switch (stateValue[2])
                    {
                        case 1:
                            rootNode.ToolTipText += "Keyswitch: RUN"; break;
                        case 2:
                            rootNode.ToolTipText += "Keyswitch: PROG"; break;
                        case 3:
                            rootNode.ToolTipText += "Keyswitch: REM"; break;
                    }

                }
            }
            treeView1.Nodes.Add(rootNode);
            this.Cursor = Cursors.Default;
        }


        private void UploadTags()
        {
            // upload tags from PLC
            this.Cursor = Cursors.WaitCursor;
            if (MyPLC.UploadTags() != ResultCode.E_SUCCESS)
            {
                if (MyPLC.ErrorCode == 0x10312)
                    MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                else
                    MessageBox.Show("Error : " + MyPLC.ErrorString, this.Text);
                return;
            }

            this.Cursor = Cursors.Default;
            CreateTagTree();
        }

        private void CreateTagTree()
        {
            this.Cursor = Cursors.WaitCursor;

            // list of program names
            programList = MyPLC.ProgramList;
          
            foreach (Logix.Program program in programList)
            {
                // if program is Name empty
                // then these are Global tags
                if (program.Name == "")
                {
                    progName = "Global";
                    // skip if Global Tags check box unchecked
                    if (false == chkGlobalTags.Checked)
                        continue;
                }
               else
                {   
                    progName = program.Name;

                    // skip if Program Tags check box unchecked
                    if (false == chkProgramTags.Checked)
                        continue;
                }

                // create TreeView nodes for Program Names
                TreeNode prgNode = new TreeNode(progName);

                rootNode.Nodes.Add(prgNode);

                // get collection of TagItems in 
                // filters "*" returns all tag names & atomic types
                tagList = program.TagItems(filtrName.Text, filterType.Text, false);

                // create a node for each tagTemplate
                foreach (TagTemplate tagTemplate in tagList)
                {
                    TreeNode tagNode = new TreeNode(tagTemplate.Name);
                    tagNode.Tag = tagTemplate;
                    AddNode(prgNode, tagTemplate);
                }
            }
            this.Cursor = Cursors.Default;
        }

        //
        // this is a recursive function that build symbolic tag name nodes
        //
        private void AddNode(TreeNode parent, Logix.TagTemplate template)
        {
            string parentName = parent.Text;
            string itemName = "";

            // strip out leading program name (e.g "Global")
            // or if there's a leading '.' remove it.
            if (parentName.IndexOf(progName) == 0)
                parentName = parentName.Substring(progName.Length);
            if (parentName.Length == 0)
                itemName = template.Name;
            else
            {
               itemName = parentName + "." + template.Name;
               if (itemName[0] == '.')
                   itemName = itemName.Substring(1);
            }
            
            // add the item to the treeview
            TreeNode node = new TreeNode(itemName);
            parent.Nodes.Add(node);

            // attache template to treeview node for later retrieval
            node.Tag = template;

            // set tool tip for item
            node.ToolTipText = ToolTipInfo(template);

            // get the list of members for the tag template
            ReadOnlyCollection<TagTemplate> memberList = template.Members;

            // is is an array
            if (template.IsArray)
            {
                // this tells us the size of each array dimension
                int dim1 = template.ArraySize[0];
                int dim2 = template.ArraySize[1];
                int dim3 = template.ArraySize[2];

                string subItem = "";
                
                if (1 == template.ArrayDims)
                {
                    for (int i = 0; i < dim1; i++)
                    {
                        // build the subitem name
                        subItem = string.Format("{0}.{1}[{2:d}]", parentName, template.Name, i);
                        
                        // remove leading '.' if it exists
                        if (subItem[0] == '.')
                            subItem = subItem.Substring(1);
                        
                        // add the node to the treeview
                        TreeNode sub = new TreeNode(subItem);
                        node.Nodes.Add(sub);
                        sub.Tag = template;

                        // recurse for any children members
                        foreach (Logix.TagTemplate member in memberList)
                            AddNode(sub, member);
                    }
               }
               else if  (2 == template.ArrayDims)
               {
                   for (int x = 0; x < dim1; x++)
                   {
                       for (int y = 0; y< dim2; y++)
                       {
                           subItem = string.Format("{0}.{1}[{2:d},{3:d}]", parentName, template.Name, x, y);

                           if (subItem[0] == '.')
                               subItem = subItem.Substring(1);
                           TreeNode sub = new TreeNode(subItem);
          
                            node.Nodes.Add(sub);
                            sub.Tag = template;
                            foreach (Logix.TagTemplate member in memberList)
                                AddNode(sub, member);
                       }
                    }

               }
              else if  (3 == template.ArrayDims)
               {
                   for (int x = 0; x < dim1; x++)
                   {
                       for (int y = 0; y < dim2; y++)
                       {
                           for (int z = 0; z < dim3; z++)
                           {
                               subItem = string.Format("{0}.{1}[{2:d},{3:d},{4:d}]", parentName, template.Name, x, y, z);
                               if (subItem[0] == '.')
                                   subItem = subItem.Substring(1);
                               TreeNode sub = new TreeNode(subItem);
                               node.Nodes.Add(sub);
                               sub.Tag = template;
                               foreach (Logix.TagTemplate member in memberList)
                                   AddNode(sub, member);
                           }
                       }

                }
            }
         }
         else
         {
            foreach (Logix.TagTemplate member in memberList)
                AddNode(node, member);
         }
                  
        }

        string ToolTipInfo(TagTemplate template)
        {
            string tipInfo = "DATA TYPE = " + template.TypeName + Environment.NewLine;
            if (template.IsAtomic)
                tipInfo += "ATOMIC" + Environment.NewLine;
            else if (template.IsString)
            {
                tipInfo += "STRING" + Environment.NewLine;
                tipInfo += template.StringSize.ToString() + " Chars";
            }

            if (template.IsArray)
            {
                int[] subscr = template.ArraySize;
                if (template.ArrayDims == 1)
                    tipInfo += "DIMS[" + subscr[0].ToString() + "]" + Environment.NewLine;
                else if (template.ArrayDims == 2)
                    tipInfo += "DIMS[" + subscr[0].ToString() + "," + subscr[1].ToString() + "]" + Environment.NewLine;
                else if (template.ArrayDims == 3)
                    tipInfo += "DIMS[" + subscr[0].ToString() + "," + subscr[1].ToString() + "," + subscr[2].ToString() + "]" + Environment.NewLine;

            }
   
            return tipInfo;
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {          
            treeView1.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void _tagView_DragEnter(object sender, DragEventArgs e)
        {
          
            if (e.Data.GetDataPresent(typeof(TreeNode)))
                e.Effect = DragDropEffects.Move; //All or Copy (try)
        }

        private void _tagView_DragDrop(object sender, DragEventArgs e)
        {
           
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode node = (TreeNode)e.Data.GetData
                    (typeof(TreeNode));
                AddTag(node);             
            }
        }

            
       private void AddTag(TreeNode node)
       {
          try
          {
               // the TreeNode.Tag is null
               // this TreeNode does not contain
               // a TagTemplate
               if (null == node.Tag)
                   return;

               // make sure this is the last node in the tree
               if (node.Nodes.Count != 0)
                    return;

               // grab the TagTemplate
               TagTemplate tagTmp = (TagTemplate)node.Tag;    
       
               Tag newTag = new Tag();

               // 
               // 
               if (tagTmp.IsString)
               {
                   newTag.DataType = Logix.Tag.ATOMIC.STRING;
                   if (tagTmp.StringSize == 82)
                       newTag.Name = node.Text;
                   else
                       newTag.Name = node.Text + "#" + tagTmp.StringSize.ToString();
               }
               else
               {
                   newTag = new Tag(node.Text);
                   if (tagTmp.TypeName == "BOOL")
                       newTag.DataType = Logix.Tag.ATOMIC.BOOL;
               }

                ////////////////////////////////////
               /// if the quality is good add the tag
               /// to the tag list
               if (ResultCode.E_SUCCESS == MyPLC.ReadTag(newTag))
               {
                   //////////////////////////////////
                   /// add event handler
                   /// this event handler will be common
                   /// for all tags
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
          catch (System.Exception ex)
           {
               MessageBox.Show(ex.Message, this.Text);
           }
        }

       private void btnRefresh_Click(object sender, EventArgs e)
       {
           rootNode.Nodes.Clear();
           CreateTagTree();
       }

       private void btnLogix_CheckedChanged(object sender, EventArgs e)
       {
           MyPLC.CPUType = Controller.CPU.LOGIX;
       }

       private void btnMicro8xx_CheckedChanged(object sender, EventArgs e)
       {
           MyPLC.CPUType = Controller.CPU.MICRO;
       }
  

    }
        
	
}
