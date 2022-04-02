using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NETLOGIX.CS.ReadArray
{
    public partial class frmArrayWrite : Form
    {
        public System.Array dataArray = null;

        public System.TypeCode dataType;

        NETLOGIX.CS.ReadArray.frmNewValue newValue = new NETLOGIX.CS.ReadArray.frmNewValue();

        public frmArrayWrite()
        {
            InitializeComponent();
        }

        private void ArrayWrite_Load(object sender, EventArgs e)
        {
            try
            {
                dataList.Items.Clear();
                for (int i = 0; i < dataArray.Length; i++)
                    dataList.Items.Add(dataArray.GetValue(i).ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataList.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

                newValue.value = dataArray.GetValue(dataList.SelectedIndex).ToString();
                if (DialogResult.Cancel == newValue.ShowDialog())
                    return;
                setValue(newValue.value, dataList.SelectedIndex);


        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();


        }

        private void btnFill_Click(object sender, EventArgs e)
        {

            if (DialogResult.Cancel == newValue.ShowDialog())
                return;

            for (int i = 0; i< dataArray.Length; i++)
                setValue(newValue.value, i);

        }

        private void setValue(string writeValue, int index)
        {
             object dataValue = null;

            try
            {              
                /////////////////////////////////
                /// convert txt value to appropriate
                /// data type for tag
                switch (dataType)
                {
                    case System.TypeCode.Boolean:
                        if (writeValue.ToUpper() == "FALSE" || writeValue == "0" || writeValue.ToUpper() == "ON")
                            dataValue = false;
                        else
                            dataValue = true;
                        break;

                    case System.TypeCode.SByte:
                        dataValue = Convert.ToSByte(writeValue);
                        break;

                    case System.TypeCode.Byte:
                        dataValue = Convert.ToByte(writeValue);
                        break;

                    case System.TypeCode.Int16:
                        dataValue = Convert.ToInt16(writeValue);
                        break;

                    case System.TypeCode.UInt16:
                        dataValue = Convert.ToUInt16(writeValue);
                        break;

                    case System.TypeCode.Int32:
                        dataValue = Convert.ToInt32(writeValue);
                        break;

                    case System.TypeCode.UInt32:
                        dataValue = Convert.ToUInt32(writeValue);
                        break;

                    case System.TypeCode.Int64:
                        dataValue = Convert.ToInt64(writeValue);
                        break;

                    case System.TypeCode.UInt64:
                        dataValue = Convert.ToUInt64(writeValue);
                        break;

                    case System.TypeCode.Single:
                        dataValue = Convert.ToSingle(writeValue);
                        break;

                    case System.TypeCode.Double:
                        dataValue = Convert.ToSingle(writeValue);
                        break;

                    case System.TypeCode.String:
                        dataValue = writeValue.ToString();
                        break;
                }
                dataList.Items[index] = dataValue;
                dataArray.SetValue(dataValue, index);
   
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

 
        }
 

    }
}