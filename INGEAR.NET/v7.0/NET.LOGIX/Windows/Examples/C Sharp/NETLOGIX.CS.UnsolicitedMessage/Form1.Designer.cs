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
            this.msgType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMsgCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(2, 114);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(537, 213);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receive messages on NIC with this IP Address";
            // 
            // ipList
            // 
            this.ipList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ipList.FormattingEnabled = true;
            this.ipList.Items.AddRange(new object[] {
            "Any"});
            this.ipList.Location = new System.Drawing.Point(16, 29);
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(137, 21);
            this.ipList.TabIndex = 2;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(199, 26);
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
            this.btnShutdown.Location = new System.Drawing.Point(199, 55);
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
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Received Messages";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(199, 84);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(133, 27);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // msgType
            // 
            this.msgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.msgType.FormattingEnabled = true;
            this.msgType.Items.AddRange(new object[] {
            "Ethernet CIP",
            "Legacy CSP"});
            this.msgType.Location = new System.Drawing.Point(15, 75);
            this.msgType.Name = "msgType";
            this.msgType.Size = new System.Drawing.Size(137, 21);
            this.msgType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message Type";
            // 
            // lblMsgCount
            // 
            this.lblMsgCount.BackColor = System.Drawing.Color.White;
            this.lblMsgCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMsgCount.Location = new System.Drawing.Point(416, 85);
            this.lblMsgCount.Name = "lblMsgCount";
            this.lblMsgCount.Size = new System.Drawing.Size(78, 17);
            this.lblMsgCount.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Msg Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 334);
            this.Controls.Add(this.lblMsgCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgType);
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
            this.Text = "NET.LOGIX Unsolicited Message(C# Example)";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox msgType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMsgCount;
        private System.Windows.Forms.Label label4;
    }
}

