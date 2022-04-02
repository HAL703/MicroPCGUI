using System;
using System.Runtime.InteropServices;
namespace MicroPCGUI
{
    //nested structs for PLC
    public class Structures
    {
        public struct GUI_GENERAL_STRUCT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public GUI_GENERAL[] guiGeneral;
        };
        public struct GUI_PBS_STRUCT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public GUI_PBS[] guiPBSArray;
        };
        public struct HAMMER_STRUCT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public HAMMER[] hammerModeSet;
        };
        public struct ACTIVE_UPDATE_STRUCT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ACTIVE_UPDATE[] Active_Update;
        };
        //general structs that are arrays of size 6 and have regular members
        public struct GUI_GENERAL
        {
            public int boolVals;
            public Int32 Cycle_Setpoint;
            public Int32 Hammer_Retract;
            public Single Hammer_Setpoint;
            public DATA_DISPLAY data_display;
        };
        public struct GUI_PBS
        {
            public int boolPBVals;
            public Int32 resetVis;
        };
        public struct HAMMER
        {
            public Int32 Hammer_Mode;
        };
        public struct ACTIVE_UPDATE
        {
            public Single Hammer_Feed;
            public Int32 Cycle_Active_Counter;
        };
        //this is for the string datatype in the PLC, it is a special case as it is technically its own struct
        public struct DATA_DISPLAY
        {
            public Int32 LEN;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 82)]
            public string DATA;
        };
    }
}
