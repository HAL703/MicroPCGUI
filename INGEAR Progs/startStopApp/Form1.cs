using System;
using System.Windows.Forms;
using Logix;
using System.Timers;


namespace startStopApp
{
    public partial class Form1 : Form
    {
        //Initialization of PLC/tags
        private Controller myPLC = new Controller(Controller.CPU.LOGIX, "169.169.1.10");
        private Tag myTag = new Tag("startScan");
        private Tag cpuInfo = new Tag();
        private Tag cpuState = new Tag();
        private Tag WriteTag = new Tag("startScan");
        private CPUState myPLCState;

        private System.Timers.Timer tagSampleTimer;
        private const double tagSampleTime = 250;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Connects to given controller (PLC)
        private void connectBtn_Click(object sender, EventArgs e)
        {
            myPLC.Connect();
            if (myPLC.IsConnected)
            {
                connectBtn.Enabled = false;
                disconnectBtn.Enabled = true;

                lblConnection.Text = "Connected";
                
                readCpuProperties();

                tagSampleTimer = new System.Timers.Timer(tagSampleTime);
                tagSampleTimer.Enabled = true;
                tagSampleTimer.AutoReset = true;
                tagSampleTimer.Elapsed += new System.Timers.ElapsedEventHandler(triggerTagUpdate);

            }
            else
            {
                lblConnection.Text = "Couldn't Connect";
            }
        }
        // Reads the CPU Properties
        private void readCpuProperties()
        {
            try
            {
                cpuInfo.Name = "$CPU_INFO";
                if(myPLC.ReadTag(cpuInfo) == ResultCode.E_SUCCESS)
                {
                    string[] plcProperties = (string[])cpuInfo.Value;

                    txtProgName.Text = plcProperties[0];
                    txtModel.Text = plcProperties[1];
                    txtFirmware.Text = plcProperties[2];
                    txtProdType.Text = plcProperties[3];
                    txtProdCode.Text = plcProperties[4];
                    txtSerial.Text = plcProperties[5];
                    txtEDS.Text = plcProperties[6];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //A new thread is created here by the timer in the connect function
        private void triggerTagUpdate(object sender, ElapsedEventArgs e)
        {
            try
            {
                // Read Analog tag for the main tagValueWindow
                if (myPLC.ReadTag(myTag) == ResultCode.E_SUCCESS)
                {
                    tagValueWindow.Text = myTag.Value.ToString();
                    lblTimestamp.Text = myTag.TimeStamp.ToString();
                }
                else
                {
                    tagValueWindow.Text = "???";
                }
                //Read the state properties from CPU
                cpuState.Name = "$CPU_STATE";
                if(myPLC.ReadTag(cpuState) == ResultCode.E_SUCCESS)
                {
                    myPLCState = new CPUState((Int32[])cpuState.Value);
                    //Get the state of the CPU as strings from CPUState class
                    txtOK.Text = myPLCState.GetCPUOkState();
                    txtFaults.Text = myPLCState.GetCPUFaultState();
                    txtKey.Text = myPLCState.GetCPUKeySwitch();
                }
                else
                {
                    MessageBox.Show(cpuState.ErrorString, this.Text);
                    txtOK.Text = "N/A";
                    txtFaults.Text = "N/A";
                    txtKey.Text = "N/A";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //This disconnects us from the given controller (PLC)
        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if(myPLC.IsConnected)
            {
                myPLC.Disconnect();
                tagSampleTimer.Stop();
            }

            lblConnection.Text = "Disconnected";
            connectBtn.Enabled = true;
            disconnectBtn.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
        //These are maintained start/stop buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                WriteTag.DataType = Logix.Tag.ATOMIC.BOOL;
                WriteTag.Value = 1;
                myPLC.WriteTag(WriteTag);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (myPLC.IsConnected)
            {
                WriteTag.DataType = Logix.Tag.ATOMIC.BOOL;
                WriteTag.Value = 0;
                myPLC.WriteTag(WriteTag);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
