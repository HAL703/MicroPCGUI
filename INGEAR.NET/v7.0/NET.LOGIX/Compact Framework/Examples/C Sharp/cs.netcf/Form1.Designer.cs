namespace csnetcf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.results = new System.Windows.Forms.ListBox();
            this.dataValue = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.RadioButton();
            this.btnBoolArray = new System.Windows.Forms.RadioButton();
            this.btnAtomic = new System.Windows.Forms.RadioButton();
            this.tagName = new System.Windows.Forms.TextBox();
            this.tagProps = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.tagProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(6, 127);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(226, 58);
            this.results.TabIndex = 9;
            // 
            // dataValue
            // 
            this.dataValue.Location = new System.Drawing.Point(82, 100);
            this.dataValue.Name = "dataValue";
            this.dataValue.Size = new System.Drawing.Size(147, 21);
            this.dataValue.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 101);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 15);
            this.Label4.Text = "Value";
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(127, 59);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 30);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(2, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 15);
            this.Label1.Text = "IP Address:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(14, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 30);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(177, 34);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(59, 20);
            this.btnString.TabIndex = 4;
            this.btnString.TabStop = false;
            this.btnString.Text = "String";
            this.btnString.CheckedChanged += new System.EventHandler(this.btnString_CheckedChanged);
            // 
            // btnBoolArray
            // 
            this.btnBoolArray.Location = new System.Drawing.Point(86, 34);
            this.btnBoolArray.Name = "btnBoolArray";
            this.btnBoolArray.Size = new System.Drawing.Size(85, 20);
            this.btnBoolArray.TabIndex = 3;
            this.btnBoolArray.TabStop = false;
            this.btnBoolArray.Text = "Bool Array";
            this.btnBoolArray.CheckedChanged += new System.EventHandler(this.btnBoolArray_CheckedChanged);
            // 
            // btnAtomic
            // 
            this.btnAtomic.Checked = true;
            this.btnAtomic.Location = new System.Drawing.Point(9, 34);
            this.btnAtomic.Name = "btnAtomic";
            this.btnAtomic.Size = new System.Drawing.Size(65, 20);
            this.btnAtomic.TabIndex = 2;
            this.btnAtomic.Text = "Atomic";
            this.btnAtomic.CheckedChanged += new System.EventHandler(this.btnAtomic_CheckedChanged);
            // 
            // tagName
            // 
            this.tagName.Location = new System.Drawing.Point(79, 7);
            this.tagName.Name = "tagName";
            this.tagName.Size = new System.Drawing.Size(151, 21);
            this.tagName.TabIndex = 1;
            // 
            // tagProps
            // 
            this.tagProps.Controls.Add(this.results);
            this.tagProps.Controls.Add(this.dataValue);
            this.tagProps.Controls.Add(this.Label4);
            this.tagProps.Controls.Add(this.btnWrite);
            this.tagProps.Controls.Add(this.btnRead);
            this.tagProps.Controls.Add(this.btnString);
            this.tagProps.Controls.Add(this.btnBoolArray);
            this.tagProps.Controls.Add(this.btnAtomic);
            this.tagProps.Controls.Add(this.tagName);
            this.tagProps.Controls.Add(this.Label3);
            this.tagProps.Enabled = false;
            this.tagProps.Location = new System.Drawing.Point(-1, 99);
            this.tagProps.Name = "tagProps";
            this.tagProps.Size = new System.Drawing.Size(239, 193);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 17);
            this.Label3.Text = "TagName";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(126, 63);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 30);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(75, 36);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(154, 21);
            this.path.TabIndex = 10;
            this.path.Text = "0";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(4, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 12);
            this.Label2.Text = "Path";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(75, 9);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(154, 21);
            this.ipAddress.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tagProps);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.path);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ipAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NETLOGIXCF C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tagProps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox results;
        internal System.Windows.Forms.TextBox dataValue;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnWrite;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnRead;
        internal System.Windows.Forms.RadioButton btnString;
        internal System.Windows.Forms.RadioButton btnBoolArray;
        internal System.Windows.Forms.RadioButton btnAtomic;
        internal System.Windows.Forms.TextBox tagName;
        internal System.Windows.Forms.Panel tagProps;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.TextBox path;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox ipAddress;
    }
}

