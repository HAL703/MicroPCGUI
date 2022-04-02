using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace NETLOGIX.CS.ChassisBrowser
{
    public partial class Form1 : Form
    {
        Controller myPLC = new Controller();

        Tag myTag = new Tag();

        TreeNode rootNode = new TreeNode("Backplane");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            myPLC.IPAddress = ipAddr.Text;
            myPLC.Path = path.Text;

            if (myPLC.Connect() != ResultCode.E_SUCCESS)
                MessageBox.Show("Connect Error : " + myPLC.ErrorString);
            // step 1 - 
            // try to get the number of slots in back plane.  Some old devices do not support
            myTag.Name = "@backplane";
            if (myPLC.ReadTag(myTag) != ResultCode.E_SUCCESS)
            {
                bpSlots.Focus();
                MessageBox.Show("Unable to read number of backplane slots, manually enter number of slots");
            }
            else
                bpSlots.Text = myTag.Value.ToString();

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            myPLC.Disconnect();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int slots = 0;

            string[] moduleInfo = null;
            try
            {
                rootNode.Nodes.Clear();

                slots = Convert.ToInt32(bpSlots.Text);
                for (int i = 0; i < slots; i++)
                {
                    myTag.Name = "@slot." + i.ToString();
                    if (myPLC.ReadTag(myTag) == ResultCode.E_SUCCESS)
                    {
                        moduleInfo = (string[])myTag.Value;
                        TreeNode module = new TreeNode(String.Format("{0:d2}, {1}", i, moduleInfo[0]));
                        module.ToolTipText = ToolTipInfo(moduleInfo);
                        rootNode.Nodes.Add(module);

                    }
                    else
                        rootNode.Nodes.Add(String.Format("{0:d2} ,<Empty>", i));
                }

            }
            catch(SystemException ex)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(rootNode);
        }

        private string ToolTipInfo(string[] info)
        {
            return String.Format("Version: {0}{5}Product Type: {1}{5}Product Code: {2}{5}Serial Number: {3}{5}EDS Filename: {4}{5}", info[1], info[2], info[3], info[4], info[5], Environment.NewLine);
            
        }
    }
}
