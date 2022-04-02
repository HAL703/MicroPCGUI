using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Logix;

namespace NETLOGIX.CS.Buttons
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class csNETButtons : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurValue;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        ///////////////////////////////////////////
        /// add instance of Controller Class and Tag class
        /// 
        Controller MyPLC = new Controller();

        Tag ButtonTag = new Tag();

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label _tagType;
        private RadioButton btnLogix;
        private RadioButton btnMicro;
        private Label label12;
        private GroupBox tagProps;
        private TextBox txtStopVal;
        private Label label10;
        private Button btnStop;
        private TextBox txtStartVal;
        private Label label9;
        private Button btnStart;
        private TextBox txtJogUp;
        private Label label8;
        private TextBox txtJogDn;
        private Label label7;
        private Button btnJog;
        private Button btnGet;
        private TextBox txtName;
        private Label label4;
        object newValue = null;

        public csNETButtons()
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
        protected override void Dispose(bool disposing)
        {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csNETButtons));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCurValue = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this._tagType = new System.Windows.Forms.Label();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnMicro = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tagProps = new System.Windows.Forms.GroupBox();
            this.txtStopVal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtStartVal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtJogUp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJogDn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnJog = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "This example shows how to use NET.LOGIX for common pushbutton tasks such as START" +
    ", STOP and JOG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(106, 66);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(192, 22);
            this.txtIPAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU Slot / CIP Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(106, 93);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(192, 22);
            this.txtPath.TabIndex = 4;
            this.txtPath.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(103, 122);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 28);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Value";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurValue
            // 
            this.lblCurValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurValue.Location = new System.Drawing.Point(114, 72);
            this.lblCurValue.Name = "lblCurValue";
            this.lblCurValue.Size = new System.Drawing.Size(266, 36);
            this.lblCurValue.TabIndex = 9;
            this.lblCurValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(202, 122);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 28);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(110, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Data Type:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _tagType
            // 
            this._tagType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tagType.Location = new System.Drawing.Point(190, 45);
            this._tagType.Name = "_tagType";
            this._tagType.Size = new System.Drawing.Size(189, 18);
            this._tagType.TabIndex = 25;
            this._tagType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(106, 44);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(62, 21);
            this.btnLogix.TabIndex = 26;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "Logix";
            this.btnLogix.UseVisualStyleBackColor = true;
            // 
            // btnMicro
            // 
            this.btnMicro.AutoSize = true;
            this.btnMicro.Location = new System.Drawing.Point(229, 44);
            this.btnMicro.Name = "btnMicro";
            this.btnMicro.Size = new System.Drawing.Size(63, 21);
            this.btnMicro.TabIndex = 27;
            this.btnMicro.Text = "Micro";
            this.btnMicro.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(11, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "CPU Type";
            // 
            // tagProps
            // 
            this.tagProps.Controls.Add(this.txtStopVal);
            this.tagProps.Controls.Add(this.label10);
            this.tagProps.Controls.Add(this.btnStop);
            this.tagProps.Controls.Add(this.txtStartVal);
            this.tagProps.Controls.Add(this.label9);
            this.tagProps.Controls.Add(this.btnStart);
            this.tagProps.Controls.Add(this.txtJogUp);
            this.tagProps.Controls.Add(this.label8);
            this.tagProps.Controls.Add(this.txtJogDn);
            this.tagProps.Controls.Add(this.label7);
            this.tagProps.Controls.Add(this.btnJog);
            this.tagProps.Controls.Add(this.btnGet);
            this.tagProps.Controls.Add(this.txtName);
            this.tagProps.Controls.Add(this.label4);
            this.tagProps.Controls.Add(this.label11);
            this.tagProps.Controls.Add(this._tagType);
            this.tagProps.Controls.Add(this.label5);
            this.tagProps.Controls.Add(this.lblCurValue);
            this.tagProps.Enabled = false;
            this.tagProps.Location = new System.Drawing.Point(6, 152);
            this.tagProps.Name = "tagProps";
            this.tagProps.Size = new System.Drawing.Size(388, 336);
            this.tagProps.TabIndex = 29;
            this.tagProps.TabStop = false;
            this.tagProps.Text = "Tag Properties";
            // 
            // txtStopVal
            // 
            this.txtStopVal.Location = new System.Drawing.Point(200, 275);
            this.txtStopVal.Name = "txtStopVal";
            this.txtStopVal.Size = new System.Drawing.Size(116, 22);
            this.txtStopVal.TabIndex = 36;
            this.txtStopVal.Text = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(114, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "Stop Value";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(8, 256);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 56);
            this.btnStop.TabIndex = 34;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtStartVal
            // 
            this.txtStartVal.Location = new System.Drawing.Point(200, 210);
            this.txtStartVal.Name = "txtStartVal";
            this.txtStartVal.Size = new System.Drawing.Size(116, 22);
            this.txtStartVal.TabIndex = 33;
            this.txtStartVal.Text = "1";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(114, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Start Value";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 55);
            this.btnStart.TabIndex = 31;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtJogUp
            // 
            this.txtJogUp.Location = new System.Drawing.Point(200, 145);
            this.txtJogUp.Name = "txtJogUp";
            this.txtJogUp.Size = new System.Drawing.Size(116, 22);
            this.txtJogUp.TabIndex = 30;
            this.txtJogUp.Text = "0";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(114, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Value Up";
            // 
            // txtJogDn
            // 
            this.txtJogDn.Location = new System.Drawing.Point(200, 118);
            this.txtJogDn.Name = "txtJogDn";
            this.txtJogDn.Size = new System.Drawing.Size(116, 22);
            this.txtJogDn.TabIndex = 28;
            this.txtJogDn.Text = "1";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(114, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Value Down";
            // 
            // btnJog
            // 
            this.btnJog.Location = new System.Drawing.Point(8, 118);
            this.btnJog.Name = "btnJog";
            this.btnJog.Size = new System.Drawing.Size(96, 55);
            this.btnJog.TabIndex = 26;
            this.btnJog.Text = "Jog";
            this.btnJog.Click += new System.EventHandler(this.btnJog_Click);
            this.btnJog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bntJog_MouseDown);
            this.btnJog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJog_MouseUp);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(11, 39);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(95, 29);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 22);
            this.txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tag Name";
            // 
            // csNETButtons
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(572, 603);
            this.Controls.Add(this.tagProps);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnMicro);
            this.Controls.Add(this.btnLogix);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "csNETButtons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX  C# Buttons Example";
            this.Load += new System.EventHandler(this.csNETButtons_Load);
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
            Application.Run(new csNETButtons());
        }

        private void csNETButtons_Load(object sender, System.EventArgs e)
        {
            try
            {
                ////////////////////////////////////////
                /// Link Tag class to controller class
                /// 
                ButtonTag.Controller = MyPLC;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (btnMicro.Checked)
                    MyPLC.CPUType = Controller.CPU.MICRO;
                else
                    MyPLC.CPUType = Controller.CPU.LOGIX;
                ///////////////////////////////////////
                /// set the IP Address and Path of Controller class
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
                btnMicro.Enabled = false;
                btnLogix.Enabled = false;
                ButtonTag.Controller = MyPLC;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }


        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            MyPLC.Disconnect();
            tagProps.Enabled = false;
            btnMicro.Enabled = true;
            btnLogix.Enabled = true;
        }

  
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonTag.Name = txtName.Text;

                if (MyPLC.ReadTag(ButtonTag) != ResultCode.E_SUCCESS)
                {
                    if (MyPLC.ErrorCode == 0x10312)
                        MessageBox.Show(MyPLC.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                    else
                        MessageBox.Show("Error : " + ButtonTag.ErrorString, this.Text);
                    return;
                }
                lblCurValue.Text = ButtonTag.Value.ToString();
                _tagType.Text = ButtonTag.NetType.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        void ImmediateWrite(object writeValue)
        {

            object newValue = null;

            try
            {              
                /////////////////////////////////
                /// convert txt value to appropriate
                /// data type for tag
                switch (Type.GetTypeCode(ButtonTag.NetType))
                {
                    case System.TypeCode.Boolean:
                        newValue = Convert.ToBoolean(writeValue);
                        break;

                    case System.TypeCode.SByte:
                        newValue = Convert.ToSByte(writeValue);
                        break;

                    case System.TypeCode.Byte:
                        newValue = Convert.ToByte(writeValue);
                        break;

                    case System.TypeCode.Int16:
                        newValue = Convert.ToInt16(writeValue);
                        break;

                    case System.TypeCode.UInt16:
                        newValue = Convert.ToUInt16(writeValue);
                        break;

                    case System.TypeCode.Int32:
                        newValue = Convert.ToInt32(writeValue);
                        break;

                    case System.TypeCode.UInt32:
                        newValue = Convert.ToUInt32(writeValue);
                        break;

                    case System.TypeCode.Int64:
                        newValue = Convert.ToInt64(writeValue);
                        break;

                    case System.TypeCode.UInt64:
                        newValue = Convert.ToUInt64(writeValue);
                        break;

                    case System.TypeCode.Single:
                        newValue = Convert.ToSingle(writeValue);
                        break;

                    case System.TypeCode.Double:
                        newValue = Convert.ToSingle(writeValue);
                        break;

                    case System.TypeCode.String:
                        newValue = writeValue.ToString();
                        break;
                }

                // immediately write value to PLC
                ButtonTag.Now = newValue;

                // immediately read value back from PLC
                lblCurValue.Text = ButtonTag.Now.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }

        }

        private void bntJog_MouseDown(object sender, MouseEventArgs e)
        {
            ImmediateWrite(txtJogDn.Text);

        }

        private void btnJog_MouseUp(object sender, MouseEventArgs e)
        {
            ImmediateWrite(txtJogUp.Text);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            ImmediateWrite(txtStartVal.Text);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ImmediateWrite(txtStopVal.Text);
        }

        private void btnJog_Click(object sender, EventArgs e)
        {

        }
    }
}
