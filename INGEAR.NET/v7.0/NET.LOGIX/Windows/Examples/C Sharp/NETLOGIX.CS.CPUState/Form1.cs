using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logix;

namespace NETLOGIX.CS.CPUState
{
    public partial class Form1 : Form
    {
        
        // instance of the Logix.Controller class
        Controller theCPU = new Controller();

        // instance of the Logix.Tag class
        Tag cpuState = new Tag();
        Tag cpuInfo = new Tag();
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // set the IP Addres and CIP path
                theCPU.IPAddress = _ipAddress.Text;
                theCPU.Path = _cipPath.Text;
                if (btnMicroCPU.Checked)
                    theCPU.CPUType = Controller.CPU.MICRO;
                else
                    theCPU.CPUType = Controller.CPU.LOGIX;

                // connection timeout period (in ms)
                theCPU.Timeout = 3000;

                if (theCPU.Connect() != Logix.ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(theCPU.ErrorString, this.Text);
                    return;
                }
                _btnConnect.Enabled = false;
                _btnDisconnect.Enabled = true;
                _btnReadState.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnDisconnect_Click(object sender, EventArgs e)
        {
            theCPU.Disconnect();
            _btnConnect.Enabled = true;
            _btnDisconnect.Enabled = false;
            _btnReadState.Enabled = false;

        }

        private void _btnReadState_Click(object sender, EventArgs e)
        {
            try
            {
             
                cpuInfo.Name = "@cpu_info";
                if (theCPU.ReadTag(cpuInfo) != Logix.ResultCode.E_SUCCESS)
                {
                    if (theCPU.ErrorCode == 0x10312)
                    {
                        if (theCPU.ErrorCode == 0x10312)
                            MessageBox.Show(theCPU.ErrorString + Environment.NewLine + "If this is a 5069 CompactLogix 5380 or 5480, Disconnect, clear CIP Path and reconnect", "Error Reading Tag");
                        else
                            MessageBox.Show("Error : " + theCPU.ErrorString, this.Text);
                        return;
                    }
                }
                string[] plcProps = (string[])cpuInfo.Value;

                _progName.Text = plcProps[0]; // program name
                _model.Text = plcProps[1]; // plc model
                _firmware.Text = plcProps[2]; // firmware revision
                _prodType.Text = plcProps[3]; // product type 
                _prodCode.Text = plcProps[4]; // product code
                _serialNum.Text = plcProps[5]; // serial #
                _edsFile.Text = plcProps[6];// EDS file number

                // Micro850 & CompactLogix 5380/5480 does not support CPU state
                if (btnMicroCPU.Checked || _cipPath.Text.Length == 0)
                {
                    _LEDState.Text = "Unavailable";
                    _faultState.Text = "Unavailable";
                    _keyState.Text = "Unavailable";
                    return;

                }

 
                // NET.Logix command name to get state of the 
                // ControlLogix/CompactLogix Cpu
                cpuState.Name = "@cpu_state";

                if (theCPU.ReadTag(cpuState) != Logix.ResultCode.E_SUCCESS)
                {
                    MessageBox.Show(theCPU.ErrorString, this.Text);
                    return;
                }

                // returns a 3-element System.Int32[]
                Int32[] stateValue = (Int32[])cpuState.Value;

                // Value 0 - OK LED State
                switch (stateValue[0])
                {
                    case 0:
                        _LEDState.Text = "Solid Red (Power Up)"; break;
                    case 1:
                        _LEDState.Text = "Flashing Red (Firmware Update)"; break;
                    case 2:
                        _LEDState.Text = "Flashing Red (Communications Fault)"; break;
                    case 3:
                        _LEDState.Text = "Flashing Green (Awaiting Connection)"; break;
                    case 4:
                        _LEDState.Text = "Flashing Red (Configuration Bad)"; break;
                    case 5:
                        _LEDState.Text = "Flashing/Solid Red (Major Fault)"; break;
                    case 6:
                        _LEDState.Text = "Solid Green (Connected)"; break;
                    case 7:
                        _LEDState.Text = "Flashing Green (Program Mode)"; break;
                }

                // Value 1 - Major/Minor Fault
                switch (stateValue[1])
                {
                    case 0:
                        _faultState.Text = "No Fault"; break;
                    case 1:
                        _faultState.Text = "Minor Recoverable Fault"; break;
                    case 2:
                        _faultState.Text = "Minor Unrecoverable Fault"; break;
                    case 3:
                        _faultState.Text = "Major Recoverable Fault"; break;
                    case 4:
                        _faultState.Text = "Major Unrecoverable Fault"; break;
                }

                // Value 2 - Key Switch Position
                switch (stateValue[2])
                {
                    case 1:
                        _keyState.Text = "Run Mode (RUN)"; break;
                    case 2:
                        _keyState.Text = "Program (PROG)"; break;
                    case 3:
                        _keyState.Text = "Remote (REM)"; break;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}