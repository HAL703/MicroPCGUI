using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Logix;


namespace cs.UnsolicitedMsg
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Instance of Logix.PeerMessage class
        /// </summary>
        PeerMessage peerMsg = new PeerMessage();

        public Form1()
        {
            InitializeComponent();

            peerMsg.Received += new EventHandler(peerMsg_Received);
            listView.View = View.Details;
            listView.Columns.Add("Sender IP", 75, HorizontalAlignment.Left);
            listView.Columns.Add("Timestamp", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Items", 75, HorizontalAlignment.Left);
            listView.Columns.Add("Name/Address", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Type", 75, HorizontalAlignment.Left);
            listView.Columns.Add("Values", 140, HorizontalAlignment.Left);

            //
            // provide a list of ip addresses on this 
            // machine
            EnumLocalIPAddresses();
            ipList.SelectedIndex = 0;
            msgType.SelectedIndex = 0;

        }

        /// <summary>
        /// Delegate for the UI update for the 
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void MsgReceivedDelegate(MessageEventArgs e);

        /// <summary>
        /// Update listView with unsolicited messages
        /// </summary>
        private void MsgReceived(MessageEventArgs e)
        {

            ListViewItem msgItem = listView.Items.Add(new ListViewItem(peerMsg.IPSender));

            msgItem.SubItems.Add(peerMsg.Timestamp.ToString());

            msgItem.SubItems.Add(peerMsg.Length.ToString());

            msgItem.SubItems.Add(peerMsg.ItemName);

            msgItem.SubItems.Add(peerMsg.NetType.ToString());

            msgItem.SubItems.Add(ItemValues());


        }

        /// <summary>
        /// Builds a string comma separated values if there's
        /// more than one value
        /// </summary>
        /// <returns></returns>
        private string ItemValues()
        {
            string rtnVal = "";

            if (1 == peerMsg.Length)
                return peerMsg.Value.ToString();

            Array dataArray = (Array)peerMsg.Value;

            for (int i = 0; i < dataArray.Length; i++)
                rtnVal += dataArray.GetValue(i).ToString() + ",";

            return rtnVal;
        }
 
        void peerMsg_Received(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////
                // since tag_changed is being called from the plcUpdate
                // thread, we need to ceated a delegate to handle the UI
                if (InvokeRequired)
                    Invoke(new MsgReceivedDelegate(MsgReceived), new object[] { (MessageEventArgs)e });
                else
                    MsgReceived((MessageEventArgs)e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
            throw new Exception("The method or operation is not implemented.");
        }

 
        /// <summary>
        /// Populates list box with addresses from this machine.
        /// </summary>
        private void EnumLocalIPAddresses()
        {
            try
            {

                //
                // Find host by name
                //
                IPHostEntry iphostentry = Dns.GetHostEntry(Dns.GetHostName());

                //
                // populate ipList box with addresses
                foreach (IPAddress ipaddress in iphostentry.AddressList)
                    ipList.Items.Add(ipaddress.ToString());

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            try
            {

                //////////////////////////////////////////////
                // shut down
                peerMsg.ShutDown();

                //
                // enable buttons
                btnListen.Enabled = true;
                btnShutdown.Enabled = false;
                ipList.Enabled = true;


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                ////////////////////////////////////////////////
                // if we want to listen on any NIC on our machine, 
                // set PeerMessage.IPAddressNIC = ""
                //
                //
                // if we want to listen for messages on a 
                // specific NIC then set PeerMessage.IPAddressNIC to the 
                // IP Address assigned to the NIC
                //
                if ("Any" == ipList.Text)
                    peerMsg.IPAddressNIC = "";
                else
                    peerMsg.IPAddressNIC = ipList.Text;

                ///////////////////////////////////////////////
                // there are 2 types of ethernet protocol messages
                // CIP (Control and Information Protocol) for newer CPU's
                // CSP (Client Server Protocol) for legacy PLC-5 & SLC 5/05
                // 
                if (msgType.SelectedIndex == 0)
                    peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP;
                else
                    peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CSP;

                //////////////////////////////////////////////
                // just call Listen
                peerMsg.Listen();

                //
                // disable some of the buttons
                //
                btnListen.Enabled = false;
                ipList.Enabled = false;
                msgType.Enabled = false;
                btnShutdown.Enabled = true;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}