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

        int index = 0;
        int offset = 0;
        TypeCode tagType = TypeCode.Empty;

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
            listView.Columns.Add("Symbolic Name", 120, HorizontalAlignment.Left);
            listView.Columns.Add("Command", 120, HorizontalAlignment.Left);

            CreateServerTags();

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

            UpdateListView(e, "CIP Data Table Write");

            if (true == ValidateTagName(e) && tagType == e.NetType)
            {

                if (e.Length == 1)
                    dataGrid.Rows[index].Cells[0].Value = e.Value.ToString();
                else
                {
                    Array data = (Array)e.Value;
                    for (int i = 0; i < e.Length; i++)
                        dataGrid.Rows[index + i].Cells[0].Value = data.GetValue(i).ToString();

                }
            }
            else
                sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);

         
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

            UpdateListView(e, "CIP Data Table Read");

            if (true == ValidateTagName(e))
            {
                try 
                {
                    if (e.Length == 1)
                    {
                       if (tagType == TypeCode.Byte)
                           sender.MessageReply(Convert.ToSByte(dataGrid.Rows[index].Cells[0].Value));
                       else if (tagType == TypeCode.Int16)
                           sender.MessageReply(Convert.ToInt16(dataGrid.Rows[index].Cells[0].Value));
                       else if (tagType == TypeCode.Int32)
                           sender.MessageReply(Convert.ToInt32(dataGrid.Rows[index].Cells[0].Value));
                       else 
                           sender.MessageReply(Convert.ToSingle(dataGrid.Rows[index].Cells[0].Value));
                    }
                    else
                    {
                        Int32[] data = new Int32[e.Length];
                        for (int i = 0; i < data.Length; i++)
                            data[i] = Convert.ToInt32(dataGrid.Rows[index + 1].Cells[0].Value);
                         sender.MessageReply(data);
                    }      
                }
                catch(System.Exception ex)
                {
                    sender.MessageReply(PeerMessage.MSG_ER.GENERAL_ERROR);
                    MessageBox.Show(ex.Message);
                }
            }
            else
                sender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);


        }

        private void UpdateListView(MessageEventArgs e, String MsgType)
        {
            msgCount++;

            if (listView.Items.Count > 50)
                listView.Items.Clear();

            ListViewItem msgItem = listView.Items.Add(e.IPSender);

            msgItem.SubItems.Add(e.Timestamp.ToString("hh:mm:ss.fff"));

            msgItem.SubItems.Add(e.Length.ToString());

            msgItem.SubItems.Add(e.ItemName);

            msgItem.SubItems.Add(MsgType);

            lblMsgCount.Text = msgCount.ToString();

        }


        private bool ValidateTagName(MessageEventArgs e)
        {

            bool NameIsGood = true;
            string tagName = e.ItemName.ToUpper();
            switch (tagName)
            {
                case "TAGSINT":
                    index = 0;
                    tagType = TypeCode.SByte;
                    break;

                case "TAGINT":
                    index = 1;
                    tagType = TypeCode.Int16;
                   break;

                case "TAGDINT":
                   tagType = TypeCode.Int32;
                   index = 2;
                   break;

                case "TAGREAL":
                   tagType = TypeCode.Single;
                    index = 3;
                    break;

                case "DINTARRAY":
                    tagType = TypeCode.Int32;

                    index = 4;
                   break;

                default:
                    if (tagName.Substring(0, 10) == "DINTARRAY[")
                    {
                        tagType = TypeCode.Int32;
                        offset = Convert.ToInt32(tagName.Substring(10).Replace("]",""));
                        index = offset + 4;
                        if ((offset > 32) || (e.Length + offset > 32))
                            NameIsGood = false;
                    }
                    else
                        NameIsGood = false;
                    break;

            }
            return NameIsGood;



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
                int ipport = 0;
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

                peerMsg.Protocol = PeerMessage.MSGPROTOCOL.CIP;

                //////////////////////////////////////////////
                // just call Listen
                peerMsg.Listen(Convert.ToInt32(ipPort.Text));
                
                //
                // disable some of the buttons
                //
                btnListen.Enabled = false;
                ipList.Enabled = false;
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


        }


        private void CreateServerTags()
        {

            dataGrid.Rows.Add("0");
            dataGrid.Rows[0].HeaderCell.Value = "tagSINT";

            dataGrid.Rows.Add("0");
            dataGrid.Rows[1].HeaderCell.Value = "tagINT";

            dataGrid.Rows.Add("0");
            dataGrid.Rows[2].HeaderCell.Value = "tagDINT";

            dataGrid.Rows.Add("0");
            dataGrid.Rows[3].HeaderCell.Value = "tagREAL";

            for (int i = 0; i < 32; i++)
            {
                dataGrid.Rows.Add("0");
                dataGrid.Rows[i + 4].HeaderCell.Value = string.Format("dintArray[{0}]", i);
            }
 


        }

    }
}