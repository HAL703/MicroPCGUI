namespace NETLOGIX.CS.ReadArray
{
    partial class frmArrayWrite
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
            this.dataList = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(12, 12);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(164, 212);
            this.dataList.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(183, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Value...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(182, 52);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(78, 31);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Fill Array...";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(183, 156);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(78, 31);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write Array";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // frmArrayWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 236);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArrayWrite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Write";
            this.Load += new System.EventHandler(this.ArrayWrite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnWrite;
    }
}