using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startStopApp
{
    public class CPUState
    {
        private Int32[] stateValue;

        //Default Constructor
        public CPUState(Int32[] CPUStateValue)
        {
            stateValue = CPUStateValue;
        }
        //Returns CPUOK
        public string GetCPUOkState()
        {
            string cpuOkState = "????";
            //Value 0 OK LED State
            switch (stateValue[0])
            {
                case 0:
                    cpuOkState = "Solid Red (Power Up)"; break;
                case 1:
                    cpuOkState = "Flashing Red(Firmware Update)"; break;
                case 2:
                    cpuOkState = "Flashing Red (Communications Error)"; break;
                case 3:
                    cpuOkState = "Flashing Green (Awaiting Connection)"; break;
                case 4:
                    cpuOkState = "Flashing Red (Configuration Fault)"; break;
                case 5:
                    cpuOkState = "Flashing/Solid Red (Major Fault)"; break;
                case 6:
                    cpuOkState = "Solid Green (Connected)"; break;
                case 7:
                    cpuOkState = "Flashing Green (Program Mode)"; break;
            }
            return cpuOkState;
        }
        //Returns any Faults
        public string GetCPUFaultState()
        {
            string cpuFaultState = "????";
            //Value 1 Fault LED State
            switch (stateValue[1])
            {
                case 0:
                    cpuFaultState = "No Faults"; break;
                case 1:
                    cpuFaultState = "Minor Recoverable Fault"; break;
                case 2:
                    cpuFaultState = "Minor Unrecoverable Fault"; break;
                case 3:
                    cpuFaultState = "Major Recoverable Fault"; break;
                case 4:
                    cpuFaultState = "Major Unrecoverable Fault"; break;

            }
            return cpuFaultState;
        }
        //Returns KEY switch position
        public string GetCPUKeySwitch()
        {
            string cpuKeySwitch = "????";
            //Value 2 - Keyswitch Position
            switch (stateValue[2])
            {
                case 1:
                    cpuKeySwitch = "Run Mode (RUN)"; break;
                case 2:
                    cpuKeySwitch = "Program Mode (PROG)"; break;
                case 3:
                    cpuKeySwitch = "Remote (REM)"; break;

            }
            return cpuKeySwitch;
        }
    }
}
