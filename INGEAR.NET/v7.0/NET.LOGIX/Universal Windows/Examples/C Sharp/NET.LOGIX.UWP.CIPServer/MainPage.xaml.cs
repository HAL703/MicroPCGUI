using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.UI.Core;
using System.Threading.Tasks;
using Logix;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NET.LOGIX.UWP.CIPServer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {
        int messageCount = 0;
        PeerMessage CIPMsg = new PeerMessage();
        Windows.UI.Xaml.DispatcherTimer UITimer = new DispatcherTimer();

        String valSINT = "0";
        String valINT = "0";
        String valDINT = "0";
        String valREAL = "0.0";

  
        public MainPage()
        {
            this.InitializeComponent();
            CIPMsg.Received += CIPMsg_Received;
            CIPMsg.Request += CIPMsg_Request;
            UITimer.Tick += UITimer_Tick;

       }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UITimer_Tick(object sender, object e)
        {
            // scan the UI for values
            valSINT = tagSINT.Text;
            valINT = tagINT.Text;
            valDINT = tagDINT.Text;
            valREAL = tagREAL.Text;
        }

        /// <summary>
        /// Starts CIP Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnListen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CIPMsg.Listen(Convert.ToInt32(ipPort.Text));
                UITimer.Interval = TimeSpan.FromMilliseconds(100);
                UITimer.Start();
            }
            catch (System.Exception ex)
            {
                var msg = new MessageDialog(ex.Message);
                await msg.ShowAsync();
            }
        }
        /// <summary>
        /// shuts down CIP server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShutdown_Click(object sender, RoutedEventArgs e)
        {
            CIPMsg.ShutDown();
            UITimer.Stop();
        }

        /// <summary>
        /// this event gets fire when CIP Read Command (Service 0x4c) is requested
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CIPMsg_Request(object sender, EventArgs e)
        {
            PeerMessage theSender = (PeerMessage)sender;
            MessageEventArgs ea = (MessageEventArgs)e;
            messageCount++;

            // send reply
            switch (ea.ItemName.ToUpper())
            {
                case "TAGSINT":
                    theSender.MessageReply(Convert.ToSByte(valSINT));
                    break;
                case "TAGINT":
                    theSender.MessageReply(Convert.ToInt16(valINT));
                    break;
                case "TAGDINT":
                    theSender.MessageReply(Convert.ToInt32(valDINT));
                    break;
                case "TAGREAL":
                    theSender.MessageReply(Convert.ToSingle(valREAL));
                    break;
                default:
                    theSender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
                    break;
            }

            // update the UI
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            { 
                senderIP.Text = ea.IPSender;
                cipCommand.Text = "CIP Read Command (Service 0x4c)";
                symbolicName.Text = ea.ItemName;
                timeStamp.Text = ea.Timestamp.ToString();
                msgCount.Text = messageCount.ToString();
            });
        }

        /// <summary>
        /// this event gets fired when CIP Write Command (Service 0x4d) is received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CIPMsg_Received(object sender, EventArgs e)
        {
            bool success = false;
            messageCount++;
            PeerMessage theSender = (PeerMessage)sender;
            MessageEventArgs ea = (MessageEventArgs)e;

            // verify tagname exists and data types match
            switch (ea.ItemName.ToUpper())
            {
                case "TAGSINT":
                  if (ea.NetType == TypeCode.Byte)
                     success = true;
                  break;
                case "TAGINT":
                  if (ea.NetType == TypeCode.Int16)
                     success = true;
                  break;
                case "TAGDINT":
                  if (ea.NetType == TypeCode.Int32)
                      success = true;
                   break;
                 case "TAGREAL":
                  if (ea.NetType == TypeCode.Single)
                      success = true;
                  break;
             }
             if (success == true)
                 theSender.MessageReply(PeerMessage.MSG_ER.SUCCESS);
             else
                 theSender.MessageReply(PeerMessage.MSG_ER.TAG_DOES_NOT_EXIST);
       
             // update the UI
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                senderIP.Text = ea.IPSender;
                cipCommand.Text = "CIP Write Command (Service 0x4d)";
                symbolicName.Text = ea.ItemName;
                timeStamp.Text = ea.Timestamp.ToString();
                msgCount.Text = messageCount.ToString();
                if (success == true)
                {
                    switch (ea.ItemName.ToUpper())
                    {
                        case "TAGSINT":
                            tagSINT.Text = ea.Value.ToString();
                            break;
                        case "TAGINT":
                            tagINT.Text = ea.Value.ToString();
                            break;
                        case "TAGDINT":
                            tagDINT.Text = ea.Value.ToString();
                            break;
                        case "TAGREAL":
                            tagREAL.Text = ea.Value.ToString();
                            break;

                    }
                }

            });
        }

    }
}
