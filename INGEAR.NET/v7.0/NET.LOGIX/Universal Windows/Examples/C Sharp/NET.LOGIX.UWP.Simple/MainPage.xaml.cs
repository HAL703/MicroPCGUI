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
using Logix;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NET.LOGIX.UWP.Simple
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Controller myPLC = new Controller();
        Tag myTag = null;

        public MainPage()
        {
            this.InitializeComponent();
            btnLogix.IsChecked = true;
            btnAtomic.IsChecked = true;
            btnWrite.IsEnabled = false;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private async void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            myPLC.IPAddress = ipAddr.Text;
            myPLC.Path = path.Text;
            if (btnLogix.IsChecked == true)
                myPLC.CPUType = Controller.CPU.LOGIX;
            else
                myPLC.CPUType = Controller.CPU.MICRO;

            if (myPLC.Connect() != ResultCode.E_SUCCESS)
            {
                var msg = new MessageDialog(myPLC.ErrorString);
                await msg.ShowAsync();
                return;

            }
        }

        private void btnDisconnect_Click(object sender, RoutedEventArgs e)
        {
            myPLC.Disconnect();
        }

        private async void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if (myPLC.IsConnected == false)
            {
                var msg = new MessageDialog("Not Connected to PLC");
                await msg.ShowAsync();
                return;
            }
            myTag = new Logix.Tag(tagName.Text);
            if (btnString.IsChecked == true)
                myTag.DataType = Logix.Tag.ATOMIC.STRING;
            else if (btnBoolArray.IsChecked == true)
                myTag.DataType = Logix.Tag.ATOMIC.BOOL;

            if (myPLC.ReadTag(myTag) !=ResultCode.E_SUCCESS)
            {
                var msg = new MessageDialog(myPLC.ErrorString);
                await msg.ShowAsync();
                return;
            }

            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                tagValue.Text = myTag.Value.ToString();
                btnWrite.IsEnabled = true;
                tagQual.Text = myTag.QualityString;
                timeStamp.Text = myTag.TimeStamp.ToString();
            });
        }

        private async void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            if (myTag != null)
            {
                myTag.Value = tagValue.Text;

                if (myPLC.ReadTag(myTag) != ResultCode.E_SUCCESS)
                {
                    var msg = new MessageDialog(myPLC.ErrorString);
                    await msg.ShowAsync();
                    return;
                }
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    tagQual.Text = myTag.QualityString;
                    timeStamp.Text = myTag.TimeStamp.ToString();
                });

            }
        }
    }
}
