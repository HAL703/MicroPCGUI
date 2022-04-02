namespace NETLOGIX.CS.CPUState
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
            this.label1 = new System.Windows.Forms.Label();
            this._ipAddress = new System.Windows.Forms.TextBox();
            this._cipPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnConnect = new System.Windows.Forms.Button();
            this._btnDisconnect = new System.Windows.Forms.Button();
            this._btnReadState = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._keyState = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._faultState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._LEDState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogixCPU = new System.Windows.Forms.RadioButton();
            this.btnMicroCPU = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this._edsFile = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this._serialNum = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this._prodCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._prodType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._firmware = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._model = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._progName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // _ipAddress
            // 
            this._ipAddress.Location = new System.Drawing.Point(102, 25);
            this._ipAddress.Name = "_ipAddress";
            this._ipAddress.Size = new System.Drawing.Size(182, 20);
            this._ipAddress.TabIndex = 1;
            // 
            // _cipPath
            // 
            this._cipPath.Location = new System.Drawing.Point(103, 49);
            this._cipPath.Name = "_cipPath";
            this._cipPath.Size = new System.Drawing.Size(182, 20);
            this._cipPath.TabIndex = 3;
            this._cipPath.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            // 
            // _btnConnect
            // 
            this._btnConnect.Location = new System.Drawing.Point(20, 75);
            this._btnConnect.Name = "_btnConnect";
            this._btnConnect.Size = new System.Drawing.Size(82, 28);
            this._btnConnect.TabIndex = 4;
            this._btnConnect.Text = "Connect";
            this._btnConnect.UseVisualStyleBackColor = true;
            this._btnConnect.Click += new System.EventHandler(this._btnConnect_Click);
            // 
            // _btnDisconnect
            // 
            this._btnDisconnect.Enabled = false;
            this._btnDisconnect.Location = new System.Drawing.Point(210, 75);
            this._btnDisconnect.Name = "_btnDisconnect";
            this._btnDisconnect.Size = new System.Drawing.Size(81, 28);
            this._btnDisconnect.TabIndex = 5;
            this._btnDisconnect.Text = "Disconnect";
            this._btnDisconnect.UseVisualStyleBackColor = true;
            this._btnDisconnect.Click += new System.EventHandler(this._btnDisconnect_Click);
            // 
            // _btnReadState
            // 
            this._btnReadState.Enabled = false;
            this._btnReadState.Location = new System.Drawing.Point(112, 74);
            this._btnReadState.Name = "_btnReadState";
            this._btnReadState.Size = new System.Drawing.Size(91, 30);
            this._btnReadState.TabIndex = 6;
            this._btnReadState.Text = "Read CPU Info";
            this._btnReadState.UseVisualStyleBackColor = true;
            this._btnReadState.Click += new System.EventHandler(this._btnReadState_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._keyState);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._faultState);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._LEDState);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU State";
            // 
            // _keyState
            // 
            this._keyState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._keyState.Location = new System.Drawing.Point(104, 64);
            this._keyState.Name = "_keyState";
            this._keyState.Size = new System.Drawing.Size(165, 16);
            this._keyState.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Key Position";
            // 
            // _faultState
            // 
            this._faultState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._faultState.Location = new System.Drawing.Point(105, 41);
            this._faultState.Name = "_faultState";
            this._faultState.Size = new System.Drawing.Size(164, 16);
            this._faultState.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Major/Minor Faults";
            // 
            // _LEDState
            // 
            this._LEDState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._LEDState.Location = new System.Drawing.Point(104, 16);
            this._LEDState.Name = "_LEDState";
            this._LEDState.Size = new System.Drawing.Size(165, 16);
            this._LEDState.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "OK LED";
            // 
            // btnLogixCPU
            // 
            this.btnLogixCPU.AutoSize = true;
            this.btnLogixCPU.Checked = true;
            this.btnLogixCPU.Location = new System.Drawing.Point(106, 5);
            this.btnLogixCPU.Name = "btnLogixCPU";
            this.btnLogixCPU.Size = new System.Drawing.Size(50, 17);
            this.btnLogixCPU.TabIndex = 8;
            this.btnLogixCPU.TabStop = true;
            this.btnLogixCPU.Text = "Logix";
            this.btnLogixCPU.UseVisualStyleBackColor = true;
            // 
            // btnMicroCPU
            // 
            this.btnMicroCPU.AutoSize = true;
            this.btnMicroCPU.Location = new System.Drawing.Point(169, 5);
            this.btnMicroCPU.Name = "btnMicroCPU";
            this.btnMicroCPU.Size = new System.Drawing.Size(51, 17);
            this.btnMicroCPU.TabIndex = 9;
            this.btnMicroCPU.TabStop = true;
            this.btnMicroCPU.Text = "Micro";
            this.btnMicroCPU.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CPU Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this._edsFile);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this._serialNum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this._prodCode);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this._prodType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this._firmware);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._model);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._progName);
            this.groupBox2.Location = new System.Drawing.Point(8, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 182);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU Properties";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "EDS Filename";
            // 
            // _edsFile
            // 
            this._edsFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._edsFile.Location = new System.Drawing.Point(105, 160);
            this._edsFile.Name = "_edsFile";
            this._edsFile.Size = new System.Drawing.Size(164, 16);
            this._edsFile.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Serial #";
            // 
            // _serialNum
            // 
            this._serialNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._serialNum.Location = new System.Drawing.Point(105, 138);
            this._serialNum.Name = "_serialNum";
            this._serialNum.Size = new System.Drawing.Size(164, 16);
            this._serialNum.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Product Code";
            // 
            // _prodCode
            // 
            this._prodCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._prodCode.Location = new System.Drawing.Point(105, 115);
            this._prodCode.Name = "_prodCode";
            this._prodCode.Size = new System.Drawing.Size(164, 16);
            this._prodCode.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Product Type";
            // 
            // _prodType
            // 
            this._prodType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._prodType.Location = new System.Drawing.Point(105, 92);
            this._prodType.Name = "_prodType";
            this._prodType.Size = new System.Drawing.Size(164, 16);
            this._prodType.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Firmware Version";
            // 
            // _firmware
            // 
            this._firmware.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._firmware.Location = new System.Drawing.Point(105, 69);
            this._firmware.Name = "_firmware";
            this._firmware.Size = new System.Drawing.Size(164, 16);
            this._firmware.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model";
            // 
            // _model
            // 
            this._model.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._model.Location = new System.Drawing.Point(105, 47);
            this._model.Name = "_model";
            this._model.Size = new System.Drawing.Size(164, 16);
            this._model.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Program Name";
            // 
            // _progName
            // 
            this._progName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._progName.Location = new System.Drawing.Point(105, 23);
            this._progName.Name = "_progName";
            this._progName.Size = new System.Drawing.Size(164, 16);
            this._progName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMicroCPU);
            this.Controls.Add(this.btnLogixCPU);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnReadState);
            this.Controls.Add(this._btnDisconnect);
            this.Controls.Add(this._btnConnect);
            this.Controls.Add(this._cipPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._ipAddress);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX CPU Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _ipAddress;
        private System.Windows.Forms.TextBox _cipPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnConnect;
        private System.Windows.Forms.Button _btnDisconnect;
        private System.Windows.Forms.Button _btnReadState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _keyState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label _faultState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _LEDState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btnLogixCPU;
        private System.Windows.Forms.RadioButton btnMicroCPU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label _edsFile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label _serialNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label _prodCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label _prodType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label _firmware;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _progName;
    }
}

