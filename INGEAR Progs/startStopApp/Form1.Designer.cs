namespace startStopApp
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
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.tagValueWindow = new System.Windows.Forms.RichTextBox();
            this.cnnStat = new System.Windows.Forms.Label();
            this.tStmp = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFaults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEDS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirmware = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtProgName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(264, 210);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(207, 50);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(511, 210);
            this.disconnectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(207, 50);
            this.disconnectBtn.TabIndex = 0;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // tagValueWindow
            // 
            this.tagValueWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagValueWindow.Location = new System.Drawing.Point(264, 33);
            this.tagValueWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tagValueWindow.Name = "tagValueWindow";
            this.tagValueWindow.ReadOnly = true;
            this.tagValueWindow.Size = new System.Drawing.Size(455, 166);
            this.tagValueWindow.TabIndex = 1;
            this.tagValueWindow.Text = "";
            // 
            // cnnStat
            // 
            this.cnnStat.AutoSize = true;
            this.cnnStat.Location = new System.Drawing.Point(261, 274);
            this.cnnStat.Name = "cnnStat";
            this.cnnStat.Size = new System.Drawing.Size(117, 16);
            this.cnnStat.TabIndex = 2;
            this.cnnStat.Text = "Connection Status:";
            // 
            // tStmp
            // 
            this.tStmp.AutoSize = true;
            this.tStmp.Location = new System.Drawing.Point(508, 274);
            this.tStmp.Name = "tStmp";
            this.tStmp.Size = new System.Drawing.Size(78, 16);
            this.tStmp.TabIndex = 3;
            this.tStmp.Text = "Timestamp:";
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.AutoSize = true;
            this.lblTimestamp.Location = new System.Drawing.Point(595, 274);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(30, 16);
            this.lblTimestamp.TabIndex = 4;
            this.lblTimestamp.Text = "N/A";
            this.lblTimestamp.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(395, 274);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(30, 16);
            this.lblConnection.TabIndex = 5;
            this.lblConnection.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFaults);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(237, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU State";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(101, 85);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(121, 22);
            this.txtKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key Position";
            // 
            // txtFaults
            // 
            this.txtFaults.Location = new System.Drawing.Point(101, 52);
            this.txtFaults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFaults.Name = "txtFaults";
            this.txtFaults.ReadOnly = true;
            this.txtFaults.Size = new System.Drawing.Size(121, 22);
            this.txtFaults.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Major/Minor";
            // 
            // txtOK
            // 
            this.txtOK.Location = new System.Drawing.Point(101, 25);
            this.txtOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOK.Name = "txtOK";
            this.txtOK.ReadOnly = true;
            this.txtOK.Size = new System.Drawing.Size(121, 22);
            this.txtOK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OK Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEDS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtProdCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProdType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFirmware);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtProgName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(17, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(237, 279);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Properties";
            // 
            // txtEDS
            // 
            this.txtEDS.Location = new System.Drawing.Point(109, 198);
            this.txtEDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEDS.Name = "txtEDS";
            this.txtEDS.ReadOnly = true;
            this.txtEDS.Size = new System.Drawing.Size(113, 22);
            this.txtEDS.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "EDS Filename";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(109, 170);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(113, 22);
            this.txtSerial.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Serial #";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(109, 142);
            this.txtProdCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.ReadOnly = true;
            this.txtProdCode.Size = new System.Drawing.Size(113, 22);
            this.txtProdCode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product Code";
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(109, 114);
            this.txtProdType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.ReadOnly = true;
            this.txtProdType.Size = new System.Drawing.Size(113, 22);
            this.txtProdType.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Product Type";
            // 
            // txtFirmware
            // 
            this.txtFirmware.Location = new System.Drawing.Point(109, 79);
            this.txtFirmware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirmware.Name = "txtFirmware";
            this.txtFirmware.ReadOnly = true;
            this.txtFirmware.Size = new System.Drawing.Size(113, 22);
            this.txtFirmware.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Firmware";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Program Name";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(109, 49);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(113, 22);
            this.txtModel.TabIndex = 9;
            // 
            // txtProgName
            // 
            this.txtProgName.Location = new System.Drawing.Point(109, 18);
            this.txtProgName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProgName.Name = "txtProgName";
            this.txtProgName.ReadOnly = true;
            this.txtProgName.Size = new System.Drawing.Size(113, 22);
            this.txtProgName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 62);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(265, 314);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(204, 22);
            this.txtValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.lblTimestamp);
            this.Controls.Add(this.tStmp);
            this.Controls.Add(this.cnnStat);
            this.Controls.Add(this.tagValueWindow);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.connectBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.RichTextBox tagValueWindow;
        private System.Windows.Forms.Label cnnStat;
        private System.Windows.Forms.Label tStmp;
        private System.Windows.Forms.Label lblTimestamp;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFaults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEDS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirmware;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtProgName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValue;
    }
}

