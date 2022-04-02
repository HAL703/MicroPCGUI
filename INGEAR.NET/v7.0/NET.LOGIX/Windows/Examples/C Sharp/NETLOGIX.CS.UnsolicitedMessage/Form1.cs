using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Net;
using Logix;
using System.Windows.Forms;

namespace NETLOGIX.cs.UnsolicitedMessage
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Instance of Logix.PeerMessage class
        /// </summary>
        PeerMessage peerMsg = new PeerMessage();

        int msgCount = 0;

        public Form1()
        {
            InitializeComponent();

            peerMsg.Received += new EventHandler(peerMsg_Received);
            peerMsg.Request += new EventHandler(peerMsg_Request);

            // **********************************
            // * add colums to list view
            // *
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


        }

        void peerMsg_Received(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////
                // since peerMsg_Received is being called from a different
                // thread, we need to ceated a delegate to handle the UI
                if (InvokeRequired)
                    Invoke(new MsgReceivedDelegate(MsgReceived), new object[] {(PeerMessage)sender, (MessageEventArgs)e });
                else
                    MsgReceived((PeerMessage)sender, (MessageEventArgs)e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        // this event is fired when a READ MSG is received
        void peerMsg_Request(object sender, EventArgs e)
        {
            try
            {
                //////////////////////////////////////////////////
                // since peerMsg_Request is being called from a different
                // thread, we need to ceated a delegate to handle the UI
                if (InvokeRequired)
                    Invoke(new MsgRequestDelegate(MsgRequest), new object[] { (PeerMessage)sender, (MessageEventArgs)e });
                else
                    MsgRequest((PeerMessage)sender, (MessageEventArgs)e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        
    
        /// <summary>
        /// Delegate for the UI update for the 
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void MsgReceivedDelegate( PeerMessage sender, MessageEventArgs e);

        /// <summary>
        /// Update listView with unsolicited messages
        /// </summary>
        private void MsgReceived(PeerMessage sender, MessageEventArgs e)
        {

            // to reject this message pass one of the errors
            // sender.MessageReply(PeerMessage.MSG_ER.TAG_ACCESS_DENIED);
            // sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
            // sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR);
            // return;

            msgCount++;

             if (listView.Items.Count > 50)
                listView.Items.Clear();

            ListViewItem msgItem = listView.Items.Add(e.IPSender);

            msgItem.SubItems.Add(e.Timestamp.ToString("hh:mm:ss.fff"));

            msgItem.SubItems.Add(e.Length.ToString());

            msgItem.SubItems.Add(e.ItemName);

            msgItem.SubItems.Add(e.NetType.ToString());

            msgItem.SubItems.Add(ItemValues(e));

            lblMsgCount.Text = msgCount.ToString();

            

        }


        /// <summary>
        /// Delegate for the UI update for the 
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void MsgRequestDelegate(PeerMessage sender, MessageEventArgs e);

        /// <summary>
        /// 
        /// </summary>
        private void MsgRequest(PeerMessage sender, MessageEventArgs e)
        {
            // to reject this message pass one of the errors
            // sender.MessageReply(PeerMessage.MSG_ER.TAG_ACCESS_DENIED);
            // sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
            // sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR);
            // return;

            // to return a SINT value
            // sbyte value = 123;
            // sender.MessageReply(value);

            // to return a INT value
            // Int16 value = 4567;
            // sender.MessageReply(value);

            // to return a DINT value
            // Int32 value = 12345657;
            // sender.MessageReply(value);

            // to return a REAL value
            // Single value = 123.4567;
            // sender.MessageReply(value);

            // to return a STRING value
            // String value = "Hello World";
            // sender.MessageReply(value);


        }

        /// <summary>
        /// Builds a string comma separated values if there's
        /// more than one value
        /// </summary>
        /// <returns></returns>
        private string ItemValues(MessageEventArgs e)
        {
            string rtnVal = "";

            if (1== e.Length)
                return e.Value.ToString();

            Array dataArray = (Array)e.Value;

            for (int i = 0; i < dataArray.Length; i++)
                rtnVal += dataArray.GetValue(i).ToString() + ",";

            return rtnVal;
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
                string ipaddr = "";
                //
                // populate ipList box with addresses
                foreach (IPAddress ipaddress in iphostentry.AddressList)
                {
                    ipaddr = ipaddress.ToString();
                    if (false == ipaddr.Contains(":"))
                        ipList.Items.Add(ipaddr);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Starts listening for messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Shuts down listening for messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clears the listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearList_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipList.SelectedIndex = 0;
            msgType.SelectedIndex = 0;


        }

 


    }
}