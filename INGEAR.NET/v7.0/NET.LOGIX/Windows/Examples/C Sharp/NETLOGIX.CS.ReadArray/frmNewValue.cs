using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NETLOGIX.CS.ReadArray
{
    public partial class frmNewValue : Form
    {
        public string value = "";
        public frmNewValue()
        {
            InitializeComponent();
        }

        private void frmNewValue_Load(object sender, EventArgs e)
        {
            editValue.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            value = editValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}