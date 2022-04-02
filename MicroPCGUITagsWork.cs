using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using Logix;
using System.Text.RegularExpressions;
namespace MicroPCGUI
{
    public partial class MicroPCUI : MetroForm
    {
        //important values for each impact frame
        public int xyz;
        public Int32 hammerModeSetValue;
        public bool[] pbVals = new bool[4];
        //controller tags, dictionary for data binding, and other variables used in the program
        private Controller myPLC = new Controller();
        Dictionary<int, string> impactFrame = new Dictionary<int, string>();
        bool comboReady = false;

        Tag activeUpdater = new Tag("active_update", Logix.Tag.ATOMIC.OBJECT);
        Tag hammerTag = new Tag("hammer_struct", Logix.Tag.ATOMIC.OBJECT);
        Tag gui_pbs = new Tag("gui_pbs_struct", Logix.Tag.ATOMIC.OBJECT);
        Tag gui_general_struct = new Tag("gui_general_struct", Logix.Tag.ATOMIC.OBJECT);

        DTEncoding udtEnc = new DTEncoding();
        bool[] bits;

        string nonNumericCatcher = "Please enter ONLY numeric characters.";
        string nonNumericDecimalCatcher = "Please enter ONLY numeric characters and/or decimals.";
        
        //This is the metroform itself loading its buttons and panels, and any general setup
        public MicroPCUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            myImpactFrameArray();
            setup();
            //!!change PLC IP Address here if different PLC, or create another controller instance and do the commands below for that
            myPLC.IPAddress = "169.169.1.10";
            myPLC.CPUType = Controller.CPU.LOGIX;
            myPLC.Path = "0";
            myPLC.Timeout = 5000;
            if (myPLC.Connect() != ResultCode.E_SUCCESS)
            {
                MessageBox.Show(myPLC.ErrorString, this.Text);
                return;
            }
        }
        //setup before an impact frame is selected, buttons will all be hidden except dropdown
        private void setup()
        {
            GeneralWindow.Hide();
            //if you add buttons outside the GeneralWindow panel, need to set them invisible here besides the GeneralInformation label
        }
        //sets all necessary buttons visible and does some reading before program is available to user
        private void setVisible()
        {
            //if you add buttons outside the GeneralWindow panel, need to set them visible here
            GeneralWindow.Show();
            GeneralInformation.Visible = false;
            myPLC.ReadTag(gui_pbs);
            Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
            pbVals = udtEnc.ToBoolArray(guiPBSGen.guiPBSArray[xyz].boolPBVals);
            pbVals[1] = true;
            guiPBSGen.guiPBSArray[xyz].boolPBVals = udtEnc.FromBoolArray(pbVals);
            gui_pbs.Value = udtEnc.FromType(guiPBSGen);
            myPLC.WriteTag(gui_pbs);
            //------------------------------------
            myPLC.ReadTag(gui_general_struct);
            DecodeGeneralStruct();
            myPLC.ReadTag(activeUpdater);
            Structures.ACTIVE_UPDATE_STRUCT cycleCounterUpdate = (Structures.ACTIVE_UPDATE_STRUCT)udtEnc.ToType(activeUpdater, typeof(Structures.ACTIVE_UPDATE_STRUCT));
            cycleCounter.Text = cycleCounterUpdate.Active_Update[xyz].Cycle_Active_Counter.ToString();
            impactFrameArrayDrop.Location = new Point(59, 175);
            myPLC.ReadTag(hammerTag);
            Structures.HAMMER_STRUCT hammerInst = (Structures.HAMMER_STRUCT)udtEnc.ToType(hammerTag, typeof(Structures.HAMMER_STRUCT));
            //------------------------------------
            if(hammerInst.hammerModeSet[xyz].Hammer_Mode == 1)
            { handModeRadio.Checked = true; }
            else if(hammerInst.hammerModeSet[xyz].Hammer_Mode == 2)
            { automaticMode.Checked = true; }
            else if(hammerInst.hammerModeSet[xyz].Hammer_Mode == 5)
            { keyenceMode.Checked = true; }
        }
        //This function is the impact frame dropdown menu setup
        //DO NOT EDIT, very likely to break the whole program
        private void myImpactFrameArray()
        {
            MetroComboBox impactFrameArray = new MetroComboBox(); //this declaration may not be required 
            impactFrame[1] = "SELECT BELOW";
            impactFrame[2] = "RED";
            impactFrame[3] = "GREEN";
            impactFrame[4] = "ORANGE";
            impactFrame[5] = "BLUE";
            impactFrame[6] = "YELLOW";
            impactFrame[7] = "VIOLET";
            BindingSource bindingSource = new BindingSource(impactFrame, null);
            impactFrameArrayDrop.DataSource = bindingSource;
            impactFrameArrayDrop.DisplayMember = "Value";
            impactFrameArrayDrop.ValueMember = "Value";
            comboReady = true;
        }
        //This function tells what happens when the user selects an impact frame on the dropdown menu
        //DO NOT EDIT
        private void impactFrameArrayDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReady)
            {
                int placeholder = impactFrameArrayDrop.SelectedIndex;
                switch(placeholder)
                {
                    case 1:
                        xyz = 0;
                        setVisible();
                        break;
                    case 2:
                        xyz = 1;
                        setVisible();
                        break;
                    case 3:
                        xyz = 2;
                        setVisible();
                        break;
                    case 4:
                        xyz = 3;
                        setVisible();
                        break;
                    case 5:
                        xyz = 4;
                        setVisible();
                        break;
                    case 6:
                        xyz = 5;
                        setVisible();
                        break;
                    default:
                        break;
                }
            }
        }
        private void PBStructReaderWriter(bool one, bool two)
        {
            myPLC.ReadTag(gui_pbs);
            Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
            pbVals = udtEnc.ToBoolArray(guiPBSGen.guiPBSArray[xyz].boolPBVals);
            pbVals[0] = one;
            guiPBSGen.guiPBSArray[xyz].boolPBVals = udtEnc.FromBoolArray(pbVals);
            gui_pbs.Value = udtEnc.FromType(guiPBSGen);
            myPLC.WriteTag(gui_pbs);
            pbVals[0] = two;
            //starts a timer and when completed, calls a plcRegister_Tick function that makes the buttons momentary
            plcRegister.Start();
        }
        //These next 4 functions all perform a read/write to PLC whenever the button is clicked, buttons are momentary, not toggled
        private void startCycle_Click(object sender, EventArgs e)
        {
            try
            {
                PBStructReaderWriter(true,false);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void stopCycle_Click(object sender, EventArgs e)
        {
            try
            {
                //this is inverted from the start button
                PBStructReaderWriter(false,true);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void resetCount_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.ReadTag(gui_pbs);
                Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
                pbVals = udtEnc.ToBoolArray(guiPBSGen.guiPBSArray[xyz].boolPBVals);
                pbVals[2] = true;
                guiPBSGen.guiPBSArray[xyz].boolPBVals = udtEnc.FromBoolArray(pbVals);
                gui_pbs.Value = udtEnc.FromType(guiPBSGen);
                myPLC.WriteTag(gui_pbs);
                pbVals[2] = false;
                //starts a timer and when completed, calls a plcRegister_Tick function that makes the buttons momentary
                plcRegister.Start();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void eStop_Click(object sender, EventArgs e)
        {
            try
            {
                myPLC.ReadTag(gui_pbs);
                Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
                pbVals = udtEnc.ToBoolArray(guiPBSGen.guiPBSArray[xyz].boolPBVals);
                pbVals[3] = true;
                guiPBSGen.guiPBSArray[xyz].boolPBVals = udtEnc.FromBoolArray(pbVals);
                gui_pbs.Value = udtEnc.FromType(guiPBSGen);
                myPLC.WriteTag(gui_pbs);
                pbVals[3] = false;
                //starts a timer and when completed, calls a plcRegister_Tick function that makes the buttons momentary
                plcRegister.Start();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //main function for the 3 hammer mode radio buttons, reads/writes values to PLC
        private void hammerModeFunc()
        {
            try
            {
                myPLC.ReadTag(hammerTag);
                Structures.HAMMER_STRUCT hammerInst = (Structures.HAMMER_STRUCT)udtEnc.ToType(hammerTag, typeof(Structures.HAMMER_STRUCT));
                hammerInst.hammerModeSet[xyz].Hammer_Mode = Convert.ToInt32(hammerModeSetValue);
                hammerTag.Value = udtEnc.FromType(hammerInst);
                myPLC.WriteTag(hammerTag);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Various functions checking if the radio buttons are clicked, gets sent to hammerModeFunc()
        private void handModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            hammerModeSetValue = 1;
            hammerModeFunc();
        }
        private void automaticMode_CheckedChanged(object sender, EventArgs e)
        {
            hammerModeSetValue = 2;
            hammerModeFunc();
        }
        private void keyenceMode_CheckedChanged(object sender, EventArgs e)
        {
            hammerModeSetValue = 5;
            hammerModeFunc();
        }
        //Writes user input in the cycleSetPoint textbox to the PLC, if and only if, enter is pressed
        private void cycleSetPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cycleSetPoint.Text.All(char.IsDigit))
                    {
                        myPLC.ReadTag(gui_general_struct);
                        Structures.GUI_GENERAL_STRUCT cycleSet = (Structures.GUI_GENERAL_STRUCT)udtEnc.ToType(gui_general_struct, typeof(Structures.GUI_GENERAL_STRUCT));
                        cycleSet.guiGeneral[xyz].Cycle_Setpoint = Convert.ToInt32(cycleSetPoint.Text);
                        gui_general_struct.Value = udtEnc.FromType(cycleSet);
                        myPLC.WriteTag(gui_general_struct);
                    }
                    else
                    {
                        //Throws an exception if the user enters anything other than numbers
                        throw new FormatException();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(nonNumericCatcher);
            }
        }
        //Writes user input in the hammerRetract textbox to the PLC, if and only if, enter is pressed
        private void hammerRetract_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (hammerRetract.Text.All(char.IsDigit))
                    {
                        myPLC.ReadTag(gui_general_struct);
                        Structures.GUI_GENERAL_STRUCT hammerRet = (Structures.GUI_GENERAL_STRUCT)udtEnc.ToType(gui_general_struct, typeof(Structures.GUI_GENERAL_STRUCT));
                        hammerRet.guiGeneral[xyz].Hammer_Retract = Convert.ToInt32(hammerRetract.Text);
                        gui_general_struct.Value = udtEnc.FromType(hammerRet);
                        myPLC.WriteTag(gui_general_struct);
                    }
                    else
                    {
                        //Throws an exception if the user enters anything other than numbers
                        throw new FormatException();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(nonNumericCatcher);
            }
        }
        //Writes user input in the hammerSP textbox to the PLC, if and only if, enter is pressed, do not edit
        private void hammerSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (hammerSP.Text.All(char.IsDigit) || Regex.IsMatch(hammerSP.Text, "^[0-9]*\\.?[0-9]*$"))
                    {
                        Structures.GUI_GENERAL_STRUCT hammerSet = (Structures.GUI_GENERAL_STRUCT)udtEnc.ToType(gui_general_struct, typeof(Structures.GUI_GENERAL_STRUCT));
                        myPLC.ReadTag(gui_general_struct);
                        hammerSet.guiGeneral[xyz].Hammer_Setpoint = Convert.ToSingle(hammerSP.Text);
                        gui_general_struct.Value = udtEnc.FromType(hammerSet);
                        myPLC.WriteTag(gui_general_struct);
                    }
                    else
                    {
                        //throws exception if the user enters anything other than numbers and one decimal point
                        throw new FormatException();
                    }
                }
                else
                {
                    return;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show(nonNumericDecimalCatcher);
            }
        }
        //Writes user input in the cycleCounter textbox to the PLC, if and only if, enter is pressed
        private void cycleCounter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cycleCounter.Text.All(char.IsDigit))
                    {
                        Structures.ACTIVE_UPDATE_STRUCT cycActive = (Structures.ACTIVE_UPDATE_STRUCT)udtEnc.ToType(activeUpdater, typeof(Structures.ACTIVE_UPDATE_STRUCT));
                        cycActive.Active_Update[xyz].Cycle_Active_Counter = Convert.ToInt32(cycleCounter.Text);
                        activeUpdater.Value = udtEnc.FromType(cycActive);
                        myPLC.WriteTag(activeUpdater);
                    }
                    else
                    {
                        //Throws an exception if the user enters anything other than numbers
                        throw new FormatException();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(nonNumericCatcher);
            }
        }
        //main checkbox function for read/write booleans
        private void checkboxClick()
        {
            bool[] limits = new bool[2];
            Structures.GUI_GENERAL_STRUCT chkBox = (Structures.GUI_GENERAL_STRUCT)udtEnc.ToType(gui_general_struct, typeof(Structures.GUI_GENERAL_STRUCT));
            limits[0] = strokeVerifyChk.Checked;
            limits[1] = partDetectChk.Checked;
            chkBox.guiGeneral[xyz].boolVals = udtEnc.FromBoolArray(limits);

            gui_general_struct.Value = udtEnc.FromType(chkBox);
            myPLC.WriteTag(gui_general_struct);
        }
        //on-click functions for the 2 checkboxes 
        private void strokeVerifyChk_Click(object sender, EventArgs e)
        {
            checkboxClick();
        }
        private void partDetectChk_Click(object sender, EventArgs e)
        {
            checkboxClick();
        }
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            //This occurs every 500 milliseconds
            myPLC.ReadTag(activeUpdater);
            Structures.ACTIVE_UPDATE_STRUCT activeUp = (Structures.ACTIVE_UPDATE_STRUCT)udtEnc.ToType(activeUpdater, typeof(Structures.ACTIVE_UPDATE_STRUCT));
            cycleCounterRead.Text = activeUp.Active_Update[xyz].Cycle_Active_Counter.ToString();
            hammerFeedback.Text = activeUp.Active_Update[xyz].Hammer_Feed.ToString();
            //------------------------------------
            myPLC.ReadTag(gui_pbs);
            Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
            if (guiPBSGen.guiPBSArray[xyz].resetVis == 1)
            {
                eStop.Visible = true;
            }
            else
            {
                eStop.Visible = false;
            }
            //guiPBSGen.guiPBSArray[xyz].resetVis = Convert.ToInt32(0);
            //gui_pbs.Value = udtEnc.FromType(guiPBSGen);
            //myPLC.WriteTag(gui_pbs);

        }
        private void generalTimer_Tick(object sender, EventArgs e)
        {
            //This occurs every 5 seconds
            myPLC.ReadTag(gui_general_struct);
            DecodeGeneralStruct();
        }
        private void plcRegister_Tick(object sender, EventArgs e)
        {
            Structures.GUI_PBS_STRUCT guiPBSGen = (Structures.GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(Structures.GUI_PBS_STRUCT));
            guiPBSGen.guiPBSArray[xyz].boolPBVals = udtEnc.FromBoolArray(pbVals);
            gui_pbs.Value = udtEnc.FromType(guiPBSGen);
            myPLC.WriteTag(gui_pbs);
            eStop.Visible = false;
            plcRegister.Enabled = false;
        }
        //this MAY NOT BE NEEDED, THIS COULD POSSIBLY BREAK E-STOP FUNCTIONALITY
        /*private void eStopTimer_Tick(object sender, EventArgs e)
        {
            myPLC.ReadTag(gui_pbs); //this may not be needed
            GUI_PBS_STRUCT guiPBSGen = (GUI_PBS_STRUCT)udtEnc.ToType(gui_pbs, typeof(GUI_PBS_STRUCT));
            if (guiPBSGen.guiPBSArray[xyz].resetVis == 1)
            {

            }
            eStopTimer.Enabled = false;
        }*/
        //Decodes the general struct from the PLC to be able to read the correct values in this application
        private void DecodeGeneralStruct()
        {
            try
            {
                 Structures.GUI_GENERAL_STRUCT guiGen = (Structures.GUI_GENERAL_STRUCT)udtEnc.ToType(gui_general_struct, typeof(Structures.GUI_GENERAL_STRUCT));

                 bits = udtEnc.ToBoolArray(guiGen.guiGeneral[xyz].boolVals);

                 strokeVerifyChk.Checked = bits[0];
                 partDetectChk.Checked = bits[1];
                 cycleSetPoint.Text = guiGen.guiGeneral[xyz].Cycle_Setpoint.ToString();
                 hammerSP.Text = guiGen.guiGeneral[xyz].Hammer_Setpoint.ToString();
                 hammerRetract.Text = guiGen.guiGeneral[xyz].Hammer_Retract.ToString();
                 dataDisplayLbl.Text = guiGen.guiGeneral[xyz].data_display.DATA.ToString();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
