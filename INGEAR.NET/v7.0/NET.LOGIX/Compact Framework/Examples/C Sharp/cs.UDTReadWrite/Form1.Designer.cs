namespace cs.UDTReadWrite
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.structA_limit4 = new System.Windows.Forms.CheckBox();
            this.structA_limit7 = new System.Windows.Forms.CheckBox();
            this.structA_wear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.structA_errors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.structA_travel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStuctA_Write = new System.Windows.Forms.Button();
            this.btnStructA_Read = new System.Windows.Forms.Button();
            this.cipPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.Text = "IP Address";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(70, 3);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(136, 21);
            this.ipAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.Text = "CIP PAth";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 20);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(122, 57);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(100, 20);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.Text = "STRUCT_A";
            // 
            // structA_limit4
            // 
            this.structA_limit4.Location = new System.Drawing.Point(3, 103);
            this.structA_limit4.Name = "structA_limit4";
            this.structA_limit4.Size = new System.Drawing.Size(71, 20);
            this.structA_limit4.TabIndex = 9;
            this.structA_limit4.Text = "limit4";
            // 
            // structA_limit7
            // 
            this.structA_limit7.Location = new System.Drawing.Point(3, 129);
            this.structA_limit7.Name = "structA_limit7";
            this.structA_limit7.Size = new System.Drawing.Size(71, 20);
            this.structA_limit7.TabIndex = 10;
            this.structA_limit7.Text = "limit7";
            // 
            // structA_wear
            // 
            this.structA_wear.Location = new System.Drawing.Point(59, 200);
            this.structA_wear.Name = "structA_wear";
            this.structA_wear.Size = new System.Drawing.Size(90, 21);
            this.structA_wear.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.Text = "wear";
            // 
            // structA_errors
            // 
            this.structA_errors.Location = new System.Drawing.Point(59, 177);
            this.structA_errors.Name = "structA_errors";
            this.structA_errors.Size = new System.Drawing.Size(90, 21);
            this.structA_errors.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.Text = "errors";
            // 
            // structA_travel
            // 
            this.structA_travel.Location = new System.Drawing.Point(59, 155);
            this.structA_travel.Name = "structA_travel";
            this.structA_travel.Size = new System.Drawing.Size(90, 21);
            this.structA_travel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.Text = "travel";
            // 
            // btnStuctA_Write
            // 
            this.btnStuctA_Write.Enabled = false;
            this.btnStuctA_Write.Location = new System.Drawing.Point(122, 129);
            this.btnStuctA_Write.Name = "btnStuctA_Write";
            this.btnStuctA_Write.Size = new System.Drawing.Size(98, 23);
            this.btnStuctA_Write.TabIndex = 21;
            this.btnStuctA_Write.Text = "Write";
            this.btnStuctA_Write.Click += new System.EventHandler(this.btnStuctA_Write_Click_1);
            // 
            // btnStructA_Read
            // 
            this.btnStructA_Read.Location = new System.Drawing.Point(122, 100);
            this.btnStructA_Read.Name = "btnStructA_Read";
            this.btnStructA_Read.Size = new System.Drawing.Size(98, 23);
            this.btnStructA_Read.TabIndex = 20;
            this.btnStructA_Read.Text = "Read";
            this.btnStructA_Read.Click += new System.EventHandler(this.btnStructA_Read_Click_1);
            // 
            // cipPath
            // 
            this.cipPath.Location = new System.Drawing.Point(70, 30);
            this.cipPath.Name = "cipPath";
            this.cipPath.Size = new System.Drawing.Size(136, 21);
            this.cipPath.TabIndex = 3;
            this.cipPath.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnStuctA_Write);
            this.Controls.Add(this.btnStructA_Read);
            this.Controls.Add(this.structA_wear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.structA_errors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.structA_travel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.structA_limit7);
            this.Controls.Add(this.structA_limit4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cipPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "UDT Read/Write";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox structA_limit4;
        private System.Windows.Forms.CheckBox structA_limit7;
        private System.Windows.Forms.TextBox structA_wear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox structA_errors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox structA_travel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStuctA_Write;
        private System.Windows.Forms.Button btnStructA_Read;
        private System.Windows.Forms.TextBox cipPath;
    }
}

