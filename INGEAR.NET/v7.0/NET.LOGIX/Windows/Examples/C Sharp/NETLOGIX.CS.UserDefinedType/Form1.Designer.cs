namespace NETLOGIX.cs.UserDefinedType
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
            this.label1 = new System.Windows.Forms.Label();
            this._ipAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cipPath = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.structTypes = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSTRUCT_D = new System.Windows.Forms.RadioButton();
            this.btnSTRUCT_C = new System.Windows.Forms.RadioButton();
            this.btnSTRUCT_B = new System.Windows.Forms.RadioButton();
            this.btnSTRUCT_A = new System.Windows.Forms.RadioButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.structTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // _ipAddress
            // 
            this._ipAddress.Location = new System.Drawing.Point(75, 6);
            this._ipAddress.Name = "_ipAddress";
            this._ipAddress.Size = new System.Drawing.Size(106, 20);
            this._ipAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CIP Path";
            // 
            // _cipPath
            // 
            this._cipPath.Location = new System.Drawing.Point(75, 34);
            this._cipPath.Name = "_cipPath";
            this._cipPath.Size = new System.Drawing.Size(106, 20);
            this._cipPath.TabIndex = 3;
            this._cipPath.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(201, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 27);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(201, 34);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 27);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // structTypes
            // 
            this.structTypes.Controls.Add(this.btnRead);
            this.structTypes.Controls.Add(this.btnSTRUCT_D);
            this.structTypes.Controls.Add(this.btnSTRUCT_C);
            this.structTypes.Controls.Add(this.btnSTRUCT_B);
            this.structTypes.Controls.Add(this.btnSTRUCT_A);
            this.structTypes.Enabled = false;
            this.structTypes.Location = new System.Drawing.Point(11, 76);
            this.structTypes.Name = "structTypes";
            this.structTypes.Size = new System.Drawing.Size(284, 116);
            this.structTypes.TabIndex = 6;
            this.structTypes.TabStop = false;
            this.structTypes.Text = "Select User Defined Type";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(74, 80);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(128, 31);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSTRUCT_D
            // 
            this.btnSTRUCT_D.AutoSize = true;
            this.btnSTRUCT_D.Location = new System.Drawing.Point(176, 44);
            this.btnSTRUCT_D.Name = "btnSTRUCT_D";
            this.btnSTRUCT_D.Size = new System.Drawing.Size(83, 17);
            this.btnSTRUCT_D.TabIndex = 3;
            this.btnSTRUCT_D.TabStop = true;
            this.btnSTRUCT_D.Text = "STRUCT_D";
            this.btnSTRUCT_D.UseVisualStyleBackColor = true;
            this.btnSTRUCT_D.CheckedChanged += new System.EventHandler(this.btnSTRUCT_D_CheckedChanged);
            // 
            // btnSTRUCT_C
            // 
            this.btnSTRUCT_C.AutoSize = true;
            this.btnSTRUCT_C.Location = new System.Drawing.Point(176, 19);
            this.btnSTRUCT_C.Name = "btnSTRUCT_C";
            this.btnSTRUCT_C.Size = new System.Drawing.Size(82, 17);
            this.btnSTRUCT_C.TabIndex = 2;
            this.btnSTRUCT_C.TabStop = true;
            this.btnSTRUCT_C.Text = "STRUCT_C";
            this.btnSTRUCT_C.UseVisualStyleBackColor = true;
            this.btnSTRUCT_C.CheckedChanged += new System.EventHandler(this.btnSTRUCT_C_CheckedChanged);
            // 
            // btnSTRUCT_B
            // 
            this.btnSTRUCT_B.AutoSize = true;
            this.btnSTRUCT_B.Location = new System.Drawing.Point(15, 42);
            this.btnSTRUCT_B.Name = "btnSTRUCT_B";
            this.btnSTRUCT_B.Size = new System.Drawing.Size(82, 17);
            this.btnSTRUCT_B.TabIndex = 1;
            this.btnSTRUCT_B.TabStop = true;
            this.btnSTRUCT_B.Text = "STRUCT_B";
            this.btnSTRUCT_B.UseVisualStyleBackColor = true;
            this.btnSTRUCT_B.CheckedChanged += new System.EventHandler(this.btnSTRUCT_B_CheckedChanged);
            // 
            // btnSTRUCT_A
            // 
            this.btnSTRUCT_A.AutoSize = true;
            this.btnSTRUCT_A.Location = new System.Drawing.Point(15, 19);
            this.btnSTRUCT_A.Name = "btnSTRUCT_A";
            this.btnSTRUCT_A.Size = new System.Drawing.Size(82, 17);
            this.btnSTRUCT_A.TabIndex = 0;
            this.btnSTRUCT_A.TabStop = true;
            this.btnSTRUCT_A.Text = "STRUCT_A";
            this.btnSTRUCT_A.UseVisualStyleBackColor = true;
            this.btnSTRUCT_A.CheckedChanged += new System.EventHandler(this.btnSTRUCT_A_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(301, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 296);
            this.treeView1.TabIndex = 7;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.Location = new System.Drawing.Point(304, 305);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(247, 19);
            this.lblTypeCode.TabIndex = 8;
            this.lblTypeCode.Text = "Type Code = ";
            // 
            // txtHelp
            // 
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.Location = new System.Drawing.Point(15, 198);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(278, 103);
            this.txtHelp.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 336);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.lblTypeCode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.structTypes);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this._cipPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._ipAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX User-Defined Type Read (C# Example)";
            this.structTypes.ResumeLayout(false);
            this.structTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _ipAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _cipPath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox structTypes;
        private System.Windows.Forms.RadioButton btnSTRUCT_D;
        private System.Windows.Forms.RadioButton btnSTRUCT_C;
        private System.Windows.Forms.RadioButton btnSTRUCT_B;
        private System.Windows.Forms.RadioButton btnSTRUCT_A;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblTypeCode;
        internal System.Windows.Forms.TextBox txtHelp;
    }
}

