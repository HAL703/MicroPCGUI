using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NETLOGIX.CS.Browser
{
	/// <summary>
	/// Summary description for frmTagWrite.
	/// </summary>
	public class frmTagWrite : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		public System.Windows.Forms.TextBox _newValue;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label _description;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTagWrite()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTagWrite));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this._newValue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._description = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(160, 83);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 32);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(72, 83);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 32);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// _newValue
			// 
			this._newValue.Location = new System.Drawing.Point(72, 51);
			this._newValue.Name = "_newValue";
			this._newValue.Size = new System.Drawing.Size(184, 20);
			this._newValue.TabIndex = 7;
			this._newValue.Text = "";
			this._newValue.TextChanged += new System.EventHandler(this._newValue_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Value";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// _description
			// 
			this._description.Location = new System.Drawing.Point(24, 11);
			this._description.Name = "_description";
			this._description.Size = new System.Drawing.Size(192, 16);
			this._description.TabIndex = 5;
			this._description.Click += new System.EventHandler(this._description_Click);
			// 
			// frmTagWrite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 126);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this._newValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._description);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTagWrite";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Write Tag Value";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();

		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void _description_Click(object sender, System.EventArgs e)
		{
		
		}

		private void _newValue_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
