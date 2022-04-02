namespace cs.UnsolicitedMsg
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
            this.label3 = new System.Windows.Forms.Label();
            this.msgType = new System.Windows.Forms.ComboBox();
            this.ipList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnListen = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.Text = "Message Type";
            // 
            // msgType
            // 
            this.msgType.Items.Add("Ethernet CIP");
            this.msgType.Items.Add("Legacy CSP");
            this.msgType.Location = new System.Drawing.Point(9, 65);
            this.msgType.Name = "msgType";
            this.msgType.Size = new System.Drawing.Size(137, 22);
            this.msgType.TabIndex = 11;
            // 
            // ipList
            // 
            this.ipList.Items.Add("Any");
            this.ipList.Location = new System.Drawing.Point(10, 25);
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(137, 22);
            this.ipList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.Text = "Use NIC with IP";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(153, 76);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(81, 27);
            this.btnClearList.TabIndex = 15;
            this.btnClearList.Text = "Clear Msgs";
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.Enabled = false;
            this.btnShutdown.Location = new System.Drawing.Point(153, 43);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(81, 27);
            this.btnShutdown.TabIndex = 14;
            this.btnShutdown.Text = "Shut Down";
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(153, 10);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(81, 27);
            this.btnListen.TabIndex = 13;
            this.btnListen.Text = "Listen";
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(3, 109);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(231, 147);
            this.listView.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgType);
            this.Controls.Add(this.ipList);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Unsolicited Msg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox msgType;
        private System.Windows.Forms.ComboBox ipList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView listView;
    }
}

