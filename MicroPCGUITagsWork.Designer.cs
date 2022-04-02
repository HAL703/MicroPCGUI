using System.Drawing;
using MetroFramework;
namespace MicroPCGUI
{
    partial class MicroPCUI
    {
        public sealed class BorderColor
        {
            public static Color Form(MetroThemeStyle theme)
            {
                if (theme == MetroThemeStyle.Dark)
                    return Color.FromArgb(153, 153, 153);

                return Color.FromArgb(153, 153, 153);
            }
        }
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroPCUI));
            this.impactFrameArrayDrop = new MetroFramework.Controls.MetroComboBox();
            this.startCycle = new MetroFramework.Controls.MetroButton();
            this.stopCycle = new MetroFramework.Controls.MetroButton();
            this.eStop = new MetroFramework.Controls.MetroButton();
            this.resetCount = new MetroFramework.Controls.MetroButton();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.hammerFeedback = new MetroFramework.Controls.MetroLabel();
            this.hammerSetPointLbl = new MetroFramework.Controls.MetroLabel();
            this.cycleSetPoint = new MetroFramework.Controls.MetroTextBox();
            this.hammerRetract = new MetroFramework.Controls.MetroTextBox();
            this.hammerRetractLbl = new MetroFramework.Controls.MetroLabel();
            this.handModeRadio = new MetroFramework.Controls.MetroRadioButton();
            this.automaticMode = new MetroFramework.Controls.MetroRadioButton();
            this.keyenceMode = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.hammerSP = new MetroFramework.Controls.MetroTextBox();
            this.dataDisplayLbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.strokeVerifyChk = new MetroFramework.Controls.MetroCheckBox();
            this.partDetectChk = new MetroFramework.Controls.MetroCheckBox();
            this.cycleCounter = new MetroFramework.Controls.MetroTextBox();
            this.GeneralInformation = new MetroFramework.Controls.MetroLabel();
            this.Logo = new MetroFramework.Controls.MetroPanel();
            this.GeneralWindow = new MetroFramework.Controls.MetroPanel();
            this.cycleCounterRead = new MetroFramework.Controls.MetroLabel();
            this.generalTimer = new System.Windows.Forms.Timer(this.components);
            this.plcRegister = new System.Windows.Forms.Timer(this.components);
            this.eStopTimer = new System.Windows.Forms.Timer(this.components);
            this.GeneralWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // impactFrameArrayDrop
            // 
            this.impactFrameArrayDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.impactFrameArrayDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.impactFrameArrayDrop.DropDownHeight = 300;
            this.impactFrameArrayDrop.DropDownWidth = 150;
            this.impactFrameArrayDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.impactFrameArrayDrop.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.impactFrameArrayDrop.ForeColor = System.Drawing.Color.OrangeRed;
            this.impactFrameArrayDrop.FormattingEnabled = true;
            this.impactFrameArrayDrop.IntegralHeight = false;
            this.impactFrameArrayDrop.ItemHeight = 23;
            this.impactFrameArrayDrop.Location = new System.Drawing.Point(452, 308);
            this.impactFrameArrayDrop.Margin = new System.Windows.Forms.Padding(2);
            this.impactFrameArrayDrop.Name = "impactFrameArrayDrop";
            this.impactFrameArrayDrop.PromptText = "IMPACT FRAMES";
            this.impactFrameArrayDrop.Size = new System.Drawing.Size(127, 29);
            this.impactFrameArrayDrop.Style = MetroFramework.MetroColorStyle.Orange;
            this.impactFrameArrayDrop.TabIndex = 0;
            this.impactFrameArrayDrop.Tag = "";
            this.impactFrameArrayDrop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.impactFrameArrayDrop.UseCustomBackColor = true;
            this.impactFrameArrayDrop.UseCustomForeColor = true;
            this.impactFrameArrayDrop.UseSelectable = true;
            this.impactFrameArrayDrop.UseStyleColors = true;
            this.impactFrameArrayDrop.SelectedIndexChanged += new System.EventHandler(this.impactFrameArrayDrop_SelectedIndexChanged);
            // 
            // startCycle
            // 
            this.startCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startCycle.ForeColor = System.Drawing.SystemColors.Control;
            this.startCycle.Location = new System.Drawing.Point(276, 9);
            this.startCycle.Margin = new System.Windows.Forms.Padding(2);
            this.startCycle.Name = "startCycle";
            this.startCycle.Size = new System.Drawing.Size(164, 60);
            this.startCycle.TabIndex = 2;
            this.startCycle.Tag = "but1";
            this.startCycle.Text = "START CYCLE";
            this.startCycle.UseCustomBackColor = true;
            this.startCycle.UseCustomForeColor = true;
            this.startCycle.UseSelectable = true;
            this.startCycle.Click += new System.EventHandler(this.startCycle_Click);
            // 
            // stopCycle
            // 
            this.stopCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopCycle.ForeColor = System.Drawing.SystemColors.Control;
            this.stopCycle.Location = new System.Drawing.Point(276, 73);
            this.stopCycle.Margin = new System.Windows.Forms.Padding(2);
            this.stopCycle.Name = "stopCycle";
            this.stopCycle.Size = new System.Drawing.Size(164, 60);
            this.stopCycle.TabIndex = 3;
            this.stopCycle.Tag = "but2";
            this.stopCycle.Text = "STOP CYCLE";
            this.stopCycle.UseCustomBackColor = true;
            this.stopCycle.UseCustomForeColor = true;
            this.stopCycle.UseSelectable = true;
            this.stopCycle.Click += new System.EventHandler(this.stopCycle_Click);
            // 
            // eStop
            // 
            this.eStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eStop.ForeColor = System.Drawing.SystemColors.Control;
            this.eStop.Location = new System.Drawing.Point(276, 201);
            this.eStop.Margin = new System.Windows.Forms.Padding(2);
            this.eStop.Name = "eStop";
            this.eStop.Size = new System.Drawing.Size(164, 60);
            this.eStop.TabIndex = 4;
            this.eStop.Tag = "but4";
            this.eStop.Text = "E-STOP";
            this.eStop.UseCustomBackColor = true;
            this.eStop.UseCustomForeColor = true;
            this.eStop.UseSelectable = true;
            this.eStop.Click += new System.EventHandler(this.eStop_Click);
            // 
            // resetCount
            // 
            this.resetCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetCount.Location = new System.Drawing.Point(276, 137);
            this.resetCount.Margin = new System.Windows.Forms.Padding(2);
            this.resetCount.Name = "resetCount";
            this.resetCount.Size = new System.Drawing.Size(164, 60);
            this.resetCount.TabIndex = 5;
            this.resetCount.Tag = "but3";
            this.resetCount.Text = "RESET COUNT";
            this.resetCount.UseCustomBackColor = true;
            this.resetCount.UseCustomForeColor = true;
            this.resetCount.UseSelectable = true;
            this.resetCount.Click += new System.EventHandler(this.resetCount_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // hammerFeedback
            // 
            this.hammerFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hammerFeedback.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.hammerFeedback.Location = new System.Drawing.Point(665, 151);
            this.hammerFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hammerFeedback.Name = "hammerFeedback";
            this.hammerFeedback.Size = new System.Drawing.Size(76, 22);
            this.hammerFeedback.TabIndex = 13;
            this.hammerFeedback.Text = "0";
            this.hammerFeedback.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hammerSetPointLbl
            // 
            this.hammerSetPointLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hammerSetPointLbl.AutoSize = true;
            this.hammerSetPointLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.hammerSetPointLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.hammerSetPointLbl.Location = new System.Drawing.Point(660, 56);
            this.hammerSetPointLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hammerSetPointLbl.Name = "hammerSetPointLbl";
            this.hammerSetPointLbl.Size = new System.Drawing.Size(121, 25);
            this.hammerSetPointLbl.TabIndex = 14;
            this.hammerSetPointLbl.Text = "HAMMER SP";
            this.hammerSetPointLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cycleSetPoint
            // 
            this.cycleSetPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.cycleSetPoint.CustomButton.AutoSize = true;
            this.cycleSetPoint.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cycleSetPoint.CustomButton.Image = null;
            this.cycleSetPoint.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.cycleSetPoint.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.cycleSetPoint.CustomButton.Name = "";
            this.cycleSetPoint.CustomButton.Size = new System.Drawing.Size(6, 6);
            this.cycleSetPoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cycleSetPoint.CustomButton.TabIndex = 1;
            this.cycleSetPoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cycleSetPoint.CustomButton.UseSelectable = true;
            this.cycleSetPoint.CustomButton.Visible = false;
            this.cycleSetPoint.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cycleSetPoint.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.cycleSetPoint.Lines = new string[] {
        "0"};
            this.cycleSetPoint.Location = new System.Drawing.Point(492, 35);
            this.cycleSetPoint.Margin = new System.Windows.Forms.Padding(2);
            this.cycleSetPoint.MaxLength = 32767;
            this.cycleSetPoint.Name = "cycleSetPoint";
            this.cycleSetPoint.PasswordChar = '\0';
            this.cycleSetPoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cycleSetPoint.SelectedText = "";
            this.cycleSetPoint.SelectionLength = 0;
            this.cycleSetPoint.SelectionStart = 0;
            this.cycleSetPoint.ShortcutsEnabled = true;
            this.cycleSetPoint.Size = new System.Drawing.Size(76, 19);
            this.cycleSetPoint.TabIndex = 15;
            this.cycleSetPoint.Text = "0";
            this.cycleSetPoint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cycleSetPoint.UseSelectable = true;
            this.cycleSetPoint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cycleSetPoint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cycleSetPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cycleSetPoint_KeyPress);
            // 
            // hammerRetract
            // 
            this.hammerRetract.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.hammerRetract.CustomButton.AutoSize = true;
            this.hammerRetract.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hammerRetract.CustomButton.Image = null;
            this.hammerRetract.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.hammerRetract.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.hammerRetract.CustomButton.Name = "";
            this.hammerRetract.CustomButton.Size = new System.Drawing.Size(6, 6);
            this.hammerRetract.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hammerRetract.CustomButton.TabIndex = 1;
            this.hammerRetract.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hammerRetract.CustomButton.UseSelectable = true;
            this.hammerRetract.CustomButton.Visible = false;
            this.hammerRetract.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hammerRetract.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.hammerRetract.Lines = new string[] {
        "HammerRetract"};
            this.hammerRetract.Location = new System.Drawing.Point(665, 35);
            this.hammerRetract.Margin = new System.Windows.Forms.Padding(2);
            this.hammerRetract.MaxLength = 32767;
            this.hammerRetract.Name = "hammerRetract";
            this.hammerRetract.PasswordChar = '\0';
            this.hammerRetract.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hammerRetract.SelectedText = "";
            this.hammerRetract.SelectionLength = 0;
            this.hammerRetract.SelectionStart = 0;
            this.hammerRetract.ShortcutsEnabled = true;
            this.hammerRetract.Size = new System.Drawing.Size(76, 19);
            this.hammerRetract.TabIndex = 19;
            this.hammerRetract.Text = "HammerRetract";
            this.hammerRetract.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hammerRetract.UseSelectable = true;
            this.hammerRetract.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hammerRetract.WaterMarkFont = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.hammerRetract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hammerRetract_KeyPress);
            // 
            // hammerRetractLbl
            // 
            this.hammerRetractLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hammerRetractLbl.AutoSize = true;
            this.hammerRetractLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.hammerRetractLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.hammerRetractLbl.Location = new System.Drawing.Point(614, 9);
            this.hammerRetractLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hammerRetractLbl.Name = "hammerRetractLbl";
            this.hammerRetractLbl.Size = new System.Drawing.Size(229, 25);
            this.hammerRetractLbl.TabIndex = 23;
            this.hammerRetractLbl.Text = "HAMMER RETRACT TIME";
            this.hammerRetractLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // handModeRadio
            // 
            this.handModeRadio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.handModeRadio.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.handModeRadio.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.handModeRadio.Location = new System.Drawing.Point(460, 162);
            this.handModeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.handModeRadio.Name = "handModeRadio";
            this.handModeRadio.Size = new System.Drawing.Size(145, 35);
            this.handModeRadio.TabIndex = 24;
            this.handModeRadio.Text = "HAND MODE";
            this.handModeRadio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.handModeRadio.UseSelectable = true;
            this.handModeRadio.CheckedChanged += new System.EventHandler(this.handModeRadio_CheckedChanged);
            // 
            // automaticMode
            // 
            this.automaticMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.automaticMode.AutoSize = true;
            this.automaticMode.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.automaticMode.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.automaticMode.Location = new System.Drawing.Point(460, 213);
            this.automaticMode.Margin = new System.Windows.Forms.Padding(2);
            this.automaticMode.Name = "automaticMode";
            this.automaticMode.Size = new System.Drawing.Size(194, 25);
            this.automaticMode.TabIndex = 25;
            this.automaticMode.Text = "AUTOMATIC MODE";
            this.automaticMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.automaticMode.UseSelectable = true;
            this.automaticMode.CheckedChanged += new System.EventHandler(this.automaticMode_CheckedChanged);
            // 
            // keyenceMode
            // 
            this.keyenceMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyenceMode.AutoSize = true;
            this.keyenceMode.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.keyenceMode.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.keyenceMode.Location = new System.Drawing.Point(460, 250);
            this.keyenceMode.Margin = new System.Windows.Forms.Padding(2);
            this.keyenceMode.Name = "keyenceMode";
            this.keyenceMode.Size = new System.Drawing.Size(165, 25);
            this.keyenceMode.TabIndex = 26;
            this.keyenceMode.Text = "KEYENCE MODE";
            this.keyenceMode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.keyenceMode.UseSelectable = true;
            this.keyenceMode.CheckedChanged += new System.EventHandler(this.keyenceMode_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(644, 114);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(190, 25);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "HAMMER FEEDBACK";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // hammerSP
            // 
            this.hammerSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.hammerSP.CustomButton.AutoSize = true;
            this.hammerSP.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hammerSP.CustomButton.FlatAppearance.BorderSize = 0;
            this.hammerSP.CustomButton.Image = null;
            this.hammerSP.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.hammerSP.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.hammerSP.CustomButton.Name = "";
            this.hammerSP.CustomButton.Size = new System.Drawing.Size(6, 6);
            this.hammerSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hammerSP.CustomButton.TabIndex = 1;
            this.hammerSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hammerSP.CustomButton.UseSelectable = true;
            this.hammerSP.CustomButton.Visible = false;
            this.hammerSP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hammerSP.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.hammerSP.Lines = new string[] {
        "0.00"};
            this.hammerSP.Location = new System.Drawing.Point(665, 83);
            this.hammerSP.Margin = new System.Windows.Forms.Padding(2);
            this.hammerSP.MaxLength = 32767;
            this.hammerSP.Name = "hammerSP";
            this.hammerSP.PasswordChar = '\0';
            this.hammerSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hammerSP.SelectedText = "";
            this.hammerSP.SelectionLength = 0;
            this.hammerSP.SelectionStart = 0;
            this.hammerSP.ShortcutsEnabled = true;
            this.hammerSP.Size = new System.Drawing.Size(76, 19);
            this.hammerSP.TabIndex = 28;
            this.hammerSP.Text = "0.00";
            this.hammerSP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hammerSP.UseSelectable = true;
            this.hammerSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hammerSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.hammerSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hammerSP_KeyPress);
            // 
            // dataDisplayLbl
            // 
            this.dataDisplayLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataDisplayLbl.AutoSize = true;
            this.dataDisplayLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dataDisplayLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.dataDisplayLbl.Location = new System.Drawing.Point(276, 292);
            this.dataDisplayLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataDisplayLbl.Name = "dataDisplayLbl";
            this.dataDisplayLbl.Size = new System.Drawing.Size(112, 25);
            this.dataDisplayLbl.TabIndex = 29;
            this.dataDisplayLbl.Text = "dataDisplay";
            this.dataDisplayLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(452, 9);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(156, 25);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "CYCLE SETPOINT";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(452, 56);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(200, 25);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "CYCLE ACTIVE COUNT";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // strokeVerifyChk
            // 
            this.strokeVerifyChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.strokeVerifyChk.AutoSize = true;
            this.strokeVerifyChk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.strokeVerifyChk.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.strokeVerifyChk.Location = new System.Drawing.Point(665, 201);
            this.strokeVerifyChk.Margin = new System.Windows.Forms.Padding(2);
            this.strokeVerifyChk.Name = "strokeVerifyChk";
            this.strokeVerifyChk.Size = new System.Drawing.Size(126, 19);
            this.strokeVerifyChk.TabIndex = 33;
            this.strokeVerifyChk.Text = "STROKE VERIFY";
            this.strokeVerifyChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.strokeVerifyChk.UseSelectable = true;
            this.strokeVerifyChk.Click += new System.EventHandler(this.strokeVerifyChk_Click);
            // 
            // partDetectChk
            // 
            this.partDetectChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partDetectChk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.partDetectChk.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.partDetectChk.Location = new System.Drawing.Point(665, 239);
            this.partDetectChk.Margin = new System.Windows.Forms.Padding(2);
            this.partDetectChk.Name = "partDetectChk";
            this.partDetectChk.Size = new System.Drawing.Size(126, 19);
            this.partDetectChk.TabIndex = 34;
            this.partDetectChk.Text = "PART DETECT";
            this.partDetectChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.partDetectChk.UseSelectable = true;
            this.partDetectChk.Click += new System.EventHandler(this.partDetectChk_Click);
            // 
            // cycleCounter
            // 
            this.cycleCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.cycleCounter.CustomButton.AutoSize = true;
            this.cycleCounter.CustomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cycleCounter.CustomButton.Image = null;
            this.cycleCounter.CustomButton.Location = new System.Drawing.Point(46, 1);
            this.cycleCounter.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.cycleCounter.CustomButton.Name = "";
            this.cycleCounter.CustomButton.Size = new System.Drawing.Size(6, 6);
            this.cycleCounter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cycleCounter.CustomButton.TabIndex = 1;
            this.cycleCounter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cycleCounter.CustomButton.UseSelectable = true;
            this.cycleCounter.CustomButton.Visible = false;
            this.cycleCounter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cycleCounter.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.cycleCounter.Lines = new string[] {
        "CYCLE ACTIVE COUNT"};
            this.cycleCounter.Location = new System.Drawing.Point(492, 91);
            this.cycleCounter.Margin = new System.Windows.Forms.Padding(2);
            this.cycleCounter.MaxLength = 32767;
            this.cycleCounter.Name = "cycleCounter";
            this.cycleCounter.PasswordChar = '\0';
            this.cycleCounter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cycleCounter.SelectedText = "";
            this.cycleCounter.SelectionLength = 0;
            this.cycleCounter.SelectionStart = 0;
            this.cycleCounter.ShortcutsEnabled = true;
            this.cycleCounter.Size = new System.Drawing.Size(76, 19);
            this.cycleCounter.TabIndex = 39;
            this.cycleCounter.Text = "CYCLE ACTIVE COUNT";
            this.cycleCounter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cycleCounter.UseSelectable = true;
            this.cycleCounter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cycleCounter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cycleCounter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cycleCounter_KeyPress);
            // 
            // GeneralInformation
            // 
            this.GeneralInformation.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.GeneralInformation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.GeneralInformation.Location = new System.Drawing.Point(380, 259);
            this.GeneralInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GeneralInformation.Name = "GeneralInformation";
            this.GeneralInformation.Size = new System.Drawing.Size(280, 32);
            this.GeneralInformation.TabIndex = 40;
            this.GeneralInformation.Text = "SELECT IMPACT FRAME BELOW";
            this.GeneralInformation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.HorizontalScrollbarBarColor = true;
            this.Logo.HorizontalScrollbarHighlightOnWheel = false;
            this.Logo.HorizontalScrollbarSize = 8;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(339, 154);
            this.Logo.TabIndex = 43;
            this.Logo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Logo.VerticalScrollbarBarColor = true;
            this.Logo.VerticalScrollbarHighlightOnWheel = false;
            this.Logo.VerticalScrollbarSize = 8;
            // 
            // GeneralWindow
            // 
            this.GeneralWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralWindow.AutoSize = true;
            this.GeneralWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralWindow.Controls.Add(this.cycleCounterRead);
            this.GeneralWindow.Controls.Add(this.startCycle);
            this.GeneralWindow.Controls.Add(this.dataDisplayLbl);
            this.GeneralWindow.Controls.Add(this.stopCycle);
            this.GeneralWindow.Controls.Add(this.resetCount);
            this.GeneralWindow.Controls.Add(this.cycleCounter);
            this.GeneralWindow.Controls.Add(this.eStop);
            this.GeneralWindow.Controls.Add(this.automaticMode);
            this.GeneralWindow.Controls.Add(this.metroLabel3);
            this.GeneralWindow.Controls.Add(this.metroLabel2);
            this.GeneralWindow.Controls.Add(this.cycleSetPoint);
            this.GeneralWindow.Controls.Add(this.partDetectChk);
            this.GeneralWindow.Controls.Add(this.hammerSP);
            this.GeneralWindow.Controls.Add(this.strokeVerifyChk);
            this.GeneralWindow.Controls.Add(this.keyenceMode);
            this.GeneralWindow.Controls.Add(this.handModeRadio);
            this.GeneralWindow.Controls.Add(this.hammerSetPointLbl);
            this.GeneralWindow.Controls.Add(this.hammerRetractLbl);
            this.GeneralWindow.Controls.Add(this.hammerRetract);
            this.GeneralWindow.Controls.Add(this.metroLabel1);
            this.GeneralWindow.Controls.Add(this.hammerFeedback);
            this.GeneralWindow.HorizontalScrollbarBarColor = true;
            this.GeneralWindow.HorizontalScrollbarHighlightOnWheel = false;
            this.GeneralWindow.HorizontalScrollbarSize = 10;
            this.GeneralWindow.Location = new System.Drawing.Point(42, 159);
            this.GeneralWindow.Name = "GeneralWindow";
            this.GeneralWindow.Size = new System.Drawing.Size(1110, 461);
            this.GeneralWindow.TabIndex = 44;
            this.GeneralWindow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GeneralWindow.VerticalScrollbarBarColor = true;
            this.GeneralWindow.VerticalScrollbarHighlightOnWheel = false;
            this.GeneralWindow.VerticalScrollbarSize = 10;
            // 
            // cycleCounterRead
            // 
            this.cycleCounterRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cycleCounterRead.AutoSize = true;
            this.cycleCounterRead.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.cycleCounterRead.Location = new System.Drawing.Point(492, 119);
            this.cycleCounterRead.Name = "cycleCounterRead";
            this.cycleCounterRead.Size = new System.Drawing.Size(130, 19);
            this.cycleCounterRead.TabIndex = 40;
            this.cycleCounterRead.Text = "cycleCounterRead";
            this.cycleCounterRead.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // generalTimer
            // 
            this.generalTimer.Enabled = true;
            this.generalTimer.Interval = 5000;
            this.generalTimer.Tick += new System.EventHandler(this.generalTimer_Tick);
            // 
            // plcRegister
            // 
            this.plcRegister.Interval = 1000;
            this.plcRegister.Tick += new System.EventHandler(this.plcRegister_Tick);
            // 
            // eStopTimer
            // 
            this.eStopTimer.Interval = 3000;
            // 
            // MicroPCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1245, 707);
            this.Controls.Add(this.impactFrameArrayDrop);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.GeneralInformation);
            this.Controls.Add(this.GeneralWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MicroPCUI";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "MicroPCUI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.GeneralWindow.ResumeLayout(false);
            this.GeneralWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox impactFrameArrayDrop;
        private MetroFramework.Controls.MetroButton startCycle;
        private MetroFramework.Controls.MetroButton stopCycle;
        private MetroFramework.Controls.MetroButton eStop;
        private MetroFramework.Controls.MetroButton resetCount;
        private System.Windows.Forms.Timer updateTimer;
        private MetroFramework.Controls.MetroLabel hammerFeedback;
        private MetroFramework.Controls.MetroLabel hammerSetPointLbl;
        private MetroFramework.Controls.MetroTextBox cycleSetPoint;
        private MetroFramework.Controls.MetroTextBox hammerRetract;
        private MetroFramework.Controls.MetroLabel hammerRetractLbl;
        private MetroFramework.Controls.MetroRadioButton handModeRadio;
        private MetroFramework.Controls.MetroRadioButton automaticMode;
        private MetroFramework.Controls.MetroRadioButton keyenceMode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox hammerSP;
        private MetroFramework.Controls.MetroLabel dataDisplayLbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox strokeVerifyChk;
        private MetroFramework.Controls.MetroCheckBox partDetectChk;
        private MetroFramework.Controls.MetroTextBox cycleCounter;
        private MetroFramework.Controls.MetroLabel GeneralInformation;
        private MetroFramework.Controls.MetroPanel Logo;
        private MetroFramework.Controls.MetroPanel GeneralWindow;
        private System.Windows.Forms.Timer generalTimer;
        private MetroFramework.Controls.MetroLabel cycleCounterRead;
        private System.Windows.Forms.Timer plcRegister;
        private System.Windows.Forms.Timer eStopTimer;
    }
}

