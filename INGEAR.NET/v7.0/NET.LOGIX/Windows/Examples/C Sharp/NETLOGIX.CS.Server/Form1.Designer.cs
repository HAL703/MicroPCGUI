namespace NETLOGIX.cs.UnsolicitedMessage
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
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ipList = new System.Windows.Forms.ComboBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lblMsgCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipPort = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(10, 335);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(557, 213);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recv on NIC with this IP Address";
            // 
            // ipList
            // 
            this.ipList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ipList.FormattingEnabled = true;
            this.ipList.Items.AddRange(new object[] {
            "Any"});
            this.ipList.Location = new System.Drawing.Point(389, 43);
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(137, 21);
            this.ipList.TabIndex = 2;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(389, 139);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(133, 27);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Enabled = false;
            this.btnShutdown.Location = new System.Drawing.Point(389, 168);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(133, 27);
            this.btnShutdown.TabIndex = 4;
            this.btnShutdown.Text = "Shut Down";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Received Messages";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(389, 197);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(133, 27);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // lblMsgCount
            // 
            this.lblMsgCount.BackColor = System.Drawing.Color.White;
            this.lblMsgCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgCount.Location = new System.Drawing.Point(444, 257);
            this.lblMsgCount.Name = "lblMsgCount";
            this.lblMsgCount.Size = new System.Drawing.Size(78, 17);
            this.lblMsgCount.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Msg Count";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.dataGrid.Location = new System.Drawing.Point(10, 33);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 150;
            this.dataGrid.Size = new System.Drawing.Size(362, 290);
            this.dataGrid.TabIndex = 54;
            // 
            // Value
            // 
            this.Value.FillWeight = 200F;
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 200;
            this.Value.Name = "Value";
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 200;
            // 
            // ipPort
            // 
            this.ipPort.BackColor = System.Drawing.Color.White;
            this.ipPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipPort.Location = new System.Drawing.Point(448, 76);
            this.ipPort.Name = "ipPort";
            this.ipPort.Size = new System.Drawing.Size(78, 17);
            this.ipPort.TabIndex = 56;
            this.ipPort.Text = "44818";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "IP Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "44818 is default";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "NET.LOGIX Server Example";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblMsgCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.ipList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NET.LOGIX Server (C# Example)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ipList;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label lblMsgCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label ipPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

