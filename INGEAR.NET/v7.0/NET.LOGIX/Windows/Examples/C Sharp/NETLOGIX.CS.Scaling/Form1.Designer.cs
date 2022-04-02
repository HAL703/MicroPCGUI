namespace NETLOGIX.CS.Scaling
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
            this.tagName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rawMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rawMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.scaledMax = new System.Windows.Forms.TextBox();
            this.scaledMin = new System.Windows.Forms.TextBox();
            this.scaledValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLinear = new System.Windows.Forms.RadioButton();
            this.btnSquareRoot = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMicro850 = new System.Windows.Forms.RadioButton();
            this.btnLogix = new System.Windows.Forms.RadioButton();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagName
            // 
            this.tagName.Location = new System.Drawing.Point(69, 115);
            this.tagName.Name = "tagName";
            this.tagName.Size = new System.Drawing.Size(206, 20);
            this.tagName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag Name";
            // 
            // rawMin
            // 
            this.rawMin.Location = new System.Drawing.Point(69, 167);
            this.rawMin.Name = "rawMin";
            this.rawMin.Size = new System.Drawing.Size(100, 20);
            this.rawMin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raw Value";
            // 
            // rawMax
            // 
            this.rawMax.Location = new System.Drawing.Point(175, 167);
            this.rawMax.Name = "rawMax";
            this.rawMax.Size = new System.Drawing.Size(100, 20);
            this.rawMax.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minimum";
            // 
            // scaledMax
            // 
            this.scaledMax.Location = new System.Drawing.Point(175, 192);
            this.scaledMax.Name = "scaledMax";
            this.scaledMax.Size = new System.Drawing.Size(100, 20);
            this.scaledMax.TabIndex = 11;
            // 
            // scaledMin
            // 
            this.scaledMin.Location = new System.Drawing.Point(69, 192);
            this.scaledMin.Name = "scaledMin";
            this.scaledMin.Size = new System.Drawing.Size(100, 20);
            this.scaledMin.TabIndex = 10;
            // 
            // scaledValue
            // 
            this.scaledValue.Location = new System.Drawing.Point(69, 264);
            this.scaledValue.Name = "scaledValue";
            this.scaledValue.Size = new System.Drawing.Size(100, 20);
            this.scaledValue.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maximum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Scales To";
            // 
            // btnLinear
            // 
            this.btnLinear.AutoSize = true;
            this.btnLinear.Checked = true;
            this.btnLinear.Location = new System.Drawing.Point(69, 228);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(54, 17);
            this.btnLinear.TabIndex = 16;
            this.btnLinear.TabStop = true;
            this.btnLinear.Text = "Linear";
            this.btnLinear.UseVisualStyleBackColor = true;
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.AutoSize = true;
            this.btnSquareRoot.Location = new System.Drawing.Point(190, 228);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(85, 17);
            this.btnSquareRoot.TabIndex = 17;
            this.btnSquareRoot.Text = "Square Root";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Scaling";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(178, 264);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(97, 23);
            this.btnRead.TabIndex = 21;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(178, 293);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(97, 23);
            this.btnWrite.TabIndex = 22;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnMicro850);
            this.groupBox1.Controls.Add(this.btnLogix);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 103);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "CPU Type";
            // 
            // btnMicro850
            // 
            this.btnMicro850.AutoSize = true;
            this.btnMicro850.Location = new System.Drawing.Point(177, 19);
            this.btnMicro850.Name = "btnMicro850";
            this.btnMicro850.Size = new System.Drawing.Size(54, 17);
            this.btnMicro850.TabIndex = 33;
            this.btnMicro850.Text = "Micro ";
            this.btnMicro850.UseVisualStyleBackColor = true;
            // 
            // btnLogix
            // 
            this.btnLogix.AutoSize = true;
            this.btnLogix.Checked = true;
            this.btnLogix.Location = new System.Drawing.Point(106, 19);
            this.btnLogix.Name = "btnLogix";
            this.btnLogix.Size = new System.Drawing.Size(50, 17);
            this.btnLogix.TabIndex = 32;
            this.btnLogix.TabStop = true;
            this.btnLogix.Text = "Logix";
            this.btnLogix.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(175, 66);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(97, 23);
            this.btnDisconnect.TabIndex = 31;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(175, 40);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(97, 23);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(66, 67);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 29;
            this.path.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Path";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(66, 41);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(100, 20);
            this.ipAddress.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "IPAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnLinear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scaledValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scaledMax);
            this.Controls.Add(this.scaledMin);
            this.Controls.Add(this.rawMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rawMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX Scaling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tagName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rawMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rawMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox scaledMax;
        private System.Windows.Forms.TextBox scaledMin;
        private System.Windows.Forms.TextBox scaledValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton btnLinear;
        private System.Windows.Forms.RadioButton btnSquareRoot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton btnMicro850;
        private System.Windows.Forms.RadioButton btnLogix;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label label1;
    }
}

