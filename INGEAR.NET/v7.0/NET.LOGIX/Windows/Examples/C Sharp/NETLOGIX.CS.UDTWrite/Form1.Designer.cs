namespace NETLOGIX.cs.UDTWrite
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
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.cipPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.structA_Grp = new System.Windows.Forms.GroupBox();
            this.btnStuctA_Write = new System.Windows.Forms.Button();
            this.btnStructA_Read = new System.Windows.Forms.Button();
            this.structA_wear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.structA_errors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.structA_travel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.structA_limit7 = new System.Windows.Forms.CheckBox();
            this.structA_limit4 = new System.Windows.Forms.CheckBox();
            this.structB_Grp = new System.Windows.Forms.GroupBox();
            this.btnStructB_Write = new System.Windows.Forms.Button();
            this.btnStructB_Read = new System.Windows.Forms.Button();
            this.structB_rate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.structB_hourlyCount_0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.structB_pilot_on = new System.Windows.Forms.CheckBox();
            this.structA_Grp.SuspendLayout();
            this.structB_Grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(78, 9);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(113, 20);
            this.ipAddress.TabIndex = 1;
            // 
            // cipPath
            // 
            this.cipPath.Location = new System.Drawing.Point(78, 35);
            this.cipPath.Name = "cipPath";
            this.cipPath.Size = new System.Drawing.Size(113, 20);
            this.cipPath.TabIndex = 3;
            this.cipPath.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CIP Path";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(217, 7);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(217, 37);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(98, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // structA_Grp
            // 
            this.structA_Grp.Controls.Add(this.btnStuctA_Write);
            this.structA_Grp.Controls.Add(this.btnStructA_Read);
            this.structA_Grp.Controls.Add(this.structA_wear);
            this.structA_Grp.Controls.Add(this.label5);
            this.structA_Grp.Controls.Add(this.structA_errors);
            this.structA_Grp.Controls.Add(this.label4);
            this.structA_Grp.Controls.Add(this.structA_travel);
            this.structA_Grp.Controls.Add(this.label3);
            this.structA_Grp.Controls.Add(this.structA_limit7);
            this.structA_Grp.Controls.Add(this.structA_limit4);
            this.structA_Grp.Enabled = false;
            this.structA_Grp.Location = new System.Drawing.Point(14, 68);
            this.structA_Grp.Name = "structA_Grp";
            this.structA_Grp.Size = new System.Drawing.Size(320, 131);
            this.structA_Grp.TabIndex = 6;
            this.structA_Grp.TabStop = false;
            this.structA_Grp.Text = "STRUCT_A";
            // 
            // btnStuctA_Write
            // 
            this.btnStuctA_Write.Enabled = false;
            this.btnStuctA_Write.Location = new System.Drawing.Point(203, 42);
            this.btnStuctA_Write.Name = "btnStuctA_Write";
            this.btnStuctA_Write.Size = new System.Drawing.Size(98, 23);
            this.btnStuctA_Write.TabIndex = 10;
            this.btnStuctA_Write.Text = "Write";
            this.btnStuctA_Write.UseVisualStyleBackColor = true;
            this.btnStuctA_Write.Click += new System.EventHandler(this.btnStuctA_Write_Click);
            // 
            // btnStructA_Read
            // 
            this.btnStructA_Read.Location = new System.Drawing.Point(203, 13);
            this.btnStructA_Read.Name = "btnStructA_Read";
            this.btnStructA_Read.Size = new System.Drawing.Size(98, 23);
            this.btnStructA_Read.TabIndex = 9;
            this.btnStructA_Read.Text = "Read";
            this.btnStructA_Read.UseVisualStyleBackColor = true;
            this.btnStructA_Read.Click += new System.EventHandler(this.btnStructA_Read_Click);
            // 
            // structA_wear
            // 
            this.structA_wear.Location = new System.Drawing.Point(70, 99);
            this.structA_wear.Name = "structA_wear";
            this.structA_wear.Size = new System.Drawing.Size(90, 20);
            this.structA_wear.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "wear";
            // 
            // structA_errors
            // 
            this.structA_errors.Location = new System.Drawing.Point(70, 76);
            this.structA_errors.Name = "structA_errors";
            this.structA_errors.Size = new System.Drawing.Size(90, 20);
            this.structA_errors.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "errors";
            // 
            // structA_travel
            // 
            this.structA_travel.Location = new System.Drawing.Point(70, 54);
            this.structA_travel.Name = "structA_travel";
            this.structA_travel.Size = new System.Drawing.Size(90, 20);
            this.structA_travel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "travel";
            // 
            // structA_limit7
            // 
            this.structA_limit7.AutoSize = true;
            this.structA_limit7.Location = new System.Drawing.Point(15, 35);
            this.structA_limit7.Name = "structA_limit7";
            this.structA_limit7.Size = new System.Drawing.Size(49, 17);
            this.structA_limit7.TabIndex = 2;
            this.structA_limit7.Text = "limit7";
            this.structA_limit7.UseVisualStyleBackColor = true;
            // 
            // structA_limit4
            // 
            this.structA_limit4.AutoSize = true;
            this.structA_limit4.Location = new System.Drawing.Point(15, 17);
            this.structA_limit4.Name = "structA_limit4";
            this.structA_limit4.Size = new System.Drawing.Size(49, 17);
            this.structA_limit4.TabIndex = 1;
            this.structA_limit4.Text = "limit4";
            this.structA_limit4.UseVisualStyleBackColor = true;
            // 
            // structB_Grp
            // 
            this.structB_Grp.Controls.Add(this.btnStructB_Write);
            this.structB_Grp.Controls.Add(this.btnStructB_Read);
            this.structB_Grp.Controls.Add(this.structB_rate);
            this.structB_Grp.Controls.Add(this.label18);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_11);
            this.structB_Grp.Controls.Add(this.label17);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_10);
            this.structB_Grp.Controls.Add(this.label16);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_9);
            this.structB_Grp.Controls.Add(this.label15);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_8);
            this.structB_Grp.Controls.Add(this.label14);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_7);
            this.structB_Grp.Controls.Add(this.label13);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_6);
            this.structB_Grp.Controls.Add(this.label12);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_5);
            this.structB_Grp.Controls.Add(this.label11);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_4);
            this.structB_Grp.Controls.Add(this.label10);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_3);
            this.structB_Grp.Controls.Add(this.label9);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_2);
            this.structB_Grp.Controls.Add(this.label8);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_1);
            this.structB_Grp.Controls.Add(this.label7);
            this.structB_Grp.Controls.Add(this.structB_hourlyCount_0);
            this.structB_Grp.Controls.Add(this.label6);
            this.structB_Grp.Controls.Add(this.structB_pilot_on);
            this.structB_Grp.Enabled = false;
            this.structB_Grp.Location = new System.Drawing.Point(14, 204);
            this.structB_Grp.Name = "structB_Grp";
            this.structB_Grp.Size = new System.Drawing.Size(320, 234);
            this.structB_Grp.TabIndex = 7;
            this.structB_Grp.TabStop = false;
            this.structB_Grp.Text = "STRUCT_B";
            // 
            // btnStructB_Write
            // 
            this.btnStructB_Write.Enabled = false;
            this.btnStructB_Write.Location = new System.Drawing.Point(203, 42);
            this.btnStructB_Write.Name = "btnStructB_Write";
            this.btnStructB_Write.Size = new System.Drawing.Size(98, 23);
            this.btnStructB_Write.TabIndex = 28;
            this.btnStructB_Write.Text = "Write";
            this.btnStructB_Write.UseVisualStyleBackColor = true;
            this.btnStructB_Write.Click += new System.EventHandler(this.btnStructB_Write_Click);
            // 
            // btnStructB_Read
            // 
            this.btnStructB_Read.Location = new System.Drawing.Point(203, 13);
            this.btnStructB_Read.Name = "btnStructB_Read";
            this.btnStructB_Read.Size = new System.Drawing.Size(98, 23);
            this.btnStructB_Read.TabIndex = 27;
            this.btnStructB_Read.Text = "Read";
            this.btnStructB_Read.UseVisualStyleBackColor = true;
            this.btnStructB_Read.Click += new System.EventHandler(this.btnStructB_Read_Click);
            // 
            // structB_rate
            // 
            this.structB_rate.Location = new System.Drawing.Point(97, 200);
            this.structB_rate.Name = "structB_rate";
            this.structB_rate.Size = new System.Drawing.Size(62, 20);
            this.structB_rate.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "rate";
            // 
            // structB_hourlyCount_11
            // 
            this.structB_hourlyCount_11.Location = new System.Drawing.Point(250, 176);
            this.structB_hourlyCount_11.Name = "structB_hourlyCount_11";
            this.structB_hourlyCount_11.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_11.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "hourlyCount[11]";
            // 
            // structB_hourlyCount_10
            // 
            this.structB_hourlyCount_10.Location = new System.Drawing.Point(250, 156);
            this.structB_hourlyCount_10.Name = "structB_hourlyCount_10";
            this.structB_hourlyCount_10.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_10.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(168, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "hourlyCount[10]";
            // 
            // structB_hourlyCount_9
            // 
            this.structB_hourlyCount_9.Location = new System.Drawing.Point(250, 136);
            this.structB_hourlyCount_9.Name = "structB_hourlyCount_9";
            this.structB_hourlyCount_9.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_9.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "hourlyCount[9]";
            // 
            // structB_hourlyCount_8
            // 
            this.structB_hourlyCount_8.Location = new System.Drawing.Point(250, 116);
            this.structB_hourlyCount_8.Name = "structB_hourlyCount_8";
            this.structB_hourlyCount_8.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_8.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "hourlyCount[8]";
            // 
            // structB_hourlyCount_7
            // 
            this.structB_hourlyCount_7.Location = new System.Drawing.Point(250, 96);
            this.structB_hourlyCount_7.Name = "structB_hourlyCount_7";
            this.structB_hourlyCount_7.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_7.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "hourlyCount[7]";
            // 
            // structB_hourlyCount_6
            // 
            this.structB_hourlyCount_6.Location = new System.Drawing.Point(250, 76);
            this.structB_hourlyCount_6.Name = "structB_hourlyCount_6";
            this.structB_hourlyCount_6.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_6.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "hourlyCount[6]";
            // 
            // structB_hourlyCount_5
            // 
            this.structB_hourlyCount_5.Location = new System.Drawing.Point(97, 176);
            this.structB_hourlyCount_5.Name = "structB_hourlyCount_5";
            this.structB_hourlyCount_5.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_5.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "hourlyCount[5]";
            // 
            // structB_hourlyCount_4
            // 
            this.structB_hourlyCount_4.Location = new System.Drawing.Point(97, 156);
            this.structB_hourlyCount_4.Name = "structB_hourlyCount_4";
            this.structB_hourlyCount_4.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_4.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "hourlyCount[4]";
            // 
            // structB_hourlyCount_3
            // 
            this.structB_hourlyCount_3.Location = new System.Drawing.Point(97, 136);
            this.structB_hourlyCount_3.Name = "structB_hourlyCount_3";
            this.structB_hourlyCount_3.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "hourlyCount[3]";
            // 
            // structB_hourlyCount_2
            // 
            this.structB_hourlyCount_2.Location = new System.Drawing.Point(97, 116);
            this.structB_hourlyCount_2.Name = "structB_hourlyCount_2";
            this.structB_hourlyCount_2.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "hourlyCount[2]";
            // 
            // structB_hourlyCount_1
            // 
            this.structB_hourlyCount_1.Location = new System.Drawing.Point(97, 96);
            this.structB_hourlyCount_1.Name = "structB_hourlyCount_1";
            this.structB_hourlyCount_1.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "hourlyCount[1]";
            // 
            // structB_hourlyCount_0
            // 
            this.structB_hourlyCount_0.Location = new System.Drawing.Point(97, 76);
            this.structB_hourlyCount_0.Name = "structB_hourlyCount_0";
            this.structB_hourlyCount_0.Size = new System.Drawing.Size(62, 20);
            this.structB_hourlyCount_0.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "hourlyCount[0]";
            // 
            // structB_pilot_on
            // 
            this.structB_pilot_on.AutoSize = true;
            this.structB_pilot_on.Location = new System.Drawing.Point(15, 56);
            this.structB_pilot_on.Name = "structB_pilot_on";
            this.structB_pilot_on.Size = new System.Drawing.Size(63, 17);
            this.structB_pilot_on.TabIndex = 0;
            this.structB_pilot_on.Text = "pilot_on";
            this.structB_pilot_on.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 447);
            this.Controls.Add(this.structB_Grp);
            this.Controls.Add(this.structA_Grp);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cipPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX UDT Write (C# Example)";
            this.structA_Grp.ResumeLayout(false);
            this.structA_Grp.PerformLayout();
            this.structB_Grp.ResumeLayout(false);
            this.structB_Grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.TextBox cipPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox structA_Grp;
        private System.Windows.Forms.CheckBox structA_limit4;
        private System.Windows.Forms.CheckBox structA_limit7;
        private System.Windows.Forms.TextBox structA_wear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox structA_errors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox structA_travel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStructA_Read;
        private System.Windows.Forms.Button btnStuctA_Write;
        private System.Windows.Forms.GroupBox structB_Grp;
        private System.Windows.Forms.CheckBox structB_pilot_on;
        private System.Windows.Forms.TextBox structB_hourlyCount_5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox structB_hourlyCount_4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox structB_hourlyCount_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox structB_hourlyCount_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox structB_hourlyCount_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox structB_hourlyCount_0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox structB_hourlyCount_11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox structB_hourlyCount_10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox structB_hourlyCount_9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox structB_hourlyCount_8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox structB_hourlyCount_7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox structB_hourlyCount_6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStructB_Write;
        private System.Windows.Forms.Button btnStructB_Read;
        private System.Windows.Forms.TextBox structB_rate;
        private System.Windows.Forms.Label label18;
    }
}

