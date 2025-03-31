namespace CommandLine
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolMenu_SaveHexData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu_SaveCSVFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenu_SaveLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDevice = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolReadEeprom = new System.Windows.Forms.ToolStripButton();
            this.toolWriteEeprom = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tboxHexData = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageSPD = new System.Windows.Forms.TabPage();
            this.tabControlSPD = new System.Windows.Forms.TabControl();
            this.tabPageSPD_SPD = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tboxTimingLmt_tRTP = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tFAW = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxTimingLmt_tRRD_L = new System.Windows.Forms.TextBox();
            this.lblTiming_tRTP = new System.Windows.Forms.Label();
            this.lblTiming_tCCD_S_WTR = new System.Windows.Forms.Label();
            this.lblTiming_tCCD_L_WTR = new System.Windows.Forms.Label();
            this.lblTiming_tFAW = new System.Windows.Forms.Label();
            this.lblTiming_tCCD_L_WR2 = new System.Windows.Forms.Label();
            this.lblTiming_tCCD_L_WR = new System.Windows.Forms.Label();
            this.lblTiming_tCCD_L = new System.Windows.Forms.Label();
            this.lblTiming_tRRD_L = new System.Windows.Forms.Label();
            this.tboxTiming_tRTP = new System.Windows.Forms.TextBox();
            this.tboxTiming_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxTiming_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxTiming_tFAW = new System.Windows.Forms.TextBox();
            this.tboxTiming_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxTiming_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxTiming_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRRD_L = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblTiming_tRFCsb = new System.Windows.Forms.Label();
            this.lblTiming_tRFC2 = new System.Windows.Forms.Label();
            this.lblTiming_tRFC1 = new System.Windows.Forms.Label();
            this.lblTiming_tWR = new System.Windows.Forms.Label();
            this.lblTiming_tRC = new System.Windows.Forms.Label();
            this.lblTiming_tRAS = new System.Windows.Forms.Label();
            this.lblTiming_tRP = new System.Windows.Forms.Label();
            this.lblTiming_tRCD = new System.Windows.Forms.Label();
            this.lblTiming_tAA = new System.Windows.Forms.Label();
            this.tboxTiming_tRFCsb = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRFC2 = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRFC1 = new System.Windows.Forms.TextBox();
            this.tboxTiming_tWR = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRC = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRAS = new System.Windows.Forms.TextBox();
            this.tboxTiming_tRP = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tboxTiming_tRCD = new System.Windows.Forms.TextBox();
            this.tboxTiming_tAA = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxCL90 = new System.Windows.Forms.CheckBox();
            this.cboxCL78 = new System.Windows.Forms.CheckBox();
            this.cboxCL66 = new System.Windows.Forms.CheckBox();
            this.cboxCL54 = new System.Windows.Forms.CheckBox();
            this.cboxCL42 = new System.Windows.Forms.CheckBox();
            this.cboxCL30 = new System.Windows.Forms.CheckBox();
            this.cboxCL88 = new System.Windows.Forms.CheckBox();
            this.cboxCL76 = new System.Windows.Forms.CheckBox();
            this.cboxCL64 = new System.Windows.Forms.CheckBox();
            this.cboxCL52 = new System.Windows.Forms.CheckBox();
            this.cboxCL40 = new System.Windows.Forms.CheckBox();
            this.cboxCL28 = new System.Windows.Forms.CheckBox();
            this.cboxCL98 = new System.Windows.Forms.CheckBox();
            this.cboxCL86 = new System.Windows.Forms.CheckBox();
            this.cboxCL74 = new System.Windows.Forms.CheckBox();
            this.cboxCL62 = new System.Windows.Forms.CheckBox();
            this.cboxCL50 = new System.Windows.Forms.CheckBox();
            this.cboxCL38 = new System.Windows.Forms.CheckBox();
            this.cboxCL26 = new System.Windows.Forms.CheckBox();
            this.cboxCL96 = new System.Windows.Forms.CheckBox();
            this.cboxCL84 = new System.Windows.Forms.CheckBox();
            this.cboxCL72 = new System.Windows.Forms.CheckBox();
            this.cboxCL60 = new System.Windows.Forms.CheckBox();
            this.cboxCL48 = new System.Windows.Forms.CheckBox();
            this.cboxCL36 = new System.Windows.Forms.CheckBox();
            this.cboxCL24 = new System.Windows.Forms.CheckBox();
            this.cboxCL94 = new System.Windows.Forms.CheckBox();
            this.cboxCL82 = new System.Windows.Forms.CheckBox();
            this.cboxCL70 = new System.Windows.Forms.CheckBox();
            this.cboxCL58 = new System.Windows.Forms.CheckBox();
            this.cboxCL46 = new System.Windows.Forms.CheckBox();
            this.cboxCL34 = new System.Windows.Forms.CheckBox();
            this.cboxCL22 = new System.Windows.Forms.CheckBox();
            this.cboxCL92 = new System.Windows.Forms.CheckBox();
            this.cboxCL80 = new System.Windows.Forms.CheckBox();
            this.cboxCL68 = new System.Windows.Forms.CheckBox();
            this.cboxCL56 = new System.Windows.Forms.CheckBox();
            this.cboxCL44 = new System.Windows.Forms.CheckBox();
            this.cboxCL32 = new System.Windows.Forms.CheckBox();
            this.cboxCL20 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxSpdMegaTransfers = new System.Windows.Forms.TextBox();
            this.tboxSpdFrequency = new System.Windows.Forms.TextBox();
            this.updnMinCycleTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageSPD_XMP1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tboxXMP1Lmt_tRTP = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tFAW = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxXMP1Lmt_tRRD_L = new System.Windows.Forms.TextBox();
            this.lblXMP1_tRTP = new System.Windows.Forms.Label();
            this.lblXMP1_tCCD_S_WTR = new System.Windows.Forms.Label();
            this.lblXMP1_tCCD_L_WTR = new System.Windows.Forms.Label();
            this.lblXMP1_tFAW = new System.Windows.Forms.Label();
            this.lblXMP1_tCCD_L_WR2 = new System.Windows.Forms.Label();
            this.lblXMP1_tCCD_L_WR = new System.Windows.Forms.Label();
            this.lblXMP1_tCCD_L = new System.Windows.Forms.Label();
            this.lblXMP1_tRRD_L = new System.Windows.Forms.Label();
            this.tboxXMP1_tRTP = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tFAW = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRRD_L = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lblXMP1_tRFCsb = new System.Windows.Forms.Label();
            this.lblXMP1_tRFC2 = new System.Windows.Forms.Label();
            this.lblXMP1_tRFC1 = new System.Windows.Forms.Label();
            this.lblXMP1_tWR = new System.Windows.Forms.Label();
            this.lblXMP1_tRC = new System.Windows.Forms.Label();
            this.lblXMP1_tRAS = new System.Windows.Forms.Label();
            this.lblXMP1_tRP = new System.Windows.Forms.Label();
            this.lblXMP1_tRCD = new System.Windows.Forms.Label();
            this.lblXMP1_tAA = new System.Windows.Forms.Label();
            this.tboxXMP1_tRFCsb = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRFC2 = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRFC1 = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tWR = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRC = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRAS = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tRP = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.tboxXMP1_tRCD = new System.Windows.Forms.TextBox();
            this.tboxXMP1_tAA = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tboxXMP1_VMEM = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tboxXMP1_VPP = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tboxXMP1_VDDQ = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tboxXMP1_VDD = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboxXMP1_CL90 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL78 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL66 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL54 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL42 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL30 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL88 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL76 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL64 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL52 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL40 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL28 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL98 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL86 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL74 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL62 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL50 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL38 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL26 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL96 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL84 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL72 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL60 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL48 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL36 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL24 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL94 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL82 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL70 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL58 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL46 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL34 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL22 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL92 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL80 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL68 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL56 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL44 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL32 = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_CL20 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboxXMP1_RealTimeMemoryFrequencyOC = new System.Windows.Forms.CheckBox();
            this.cboxXMP1_IntelDynamicMemoryBoost = new System.Windows.Forms.CheckBox();
            this.comboxXMP1_CommandRate = new System.Windows.Forms.ComboBox();
            this.tboxXMP1_MegaTransfers = new System.Windows.Forms.TextBox();
            this.tboxXMP1_Frequency = new System.Windows.Forms.TextBox();
            this.updnXMP1_MinCycleTime = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPageSPD_XMP2 = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tboxXMP2Lmt_tRTP = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tFAW = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxXMP2Lmt_tRRD_L = new System.Windows.Forms.TextBox();
            this.lblXMP2_tRTP = new System.Windows.Forms.Label();
            this.lblXMP2_tCCD_S_WTR = new System.Windows.Forms.Label();
            this.lblXMP2_tCCD_L_WTR = new System.Windows.Forms.Label();
            this.lblXMP2_tFAW = new System.Windows.Forms.Label();
            this.lblXMP2_tCCD_L_WR2 = new System.Windows.Forms.Label();
            this.lblXMP2_tCCD_L_WR = new System.Windows.Forms.Label();
            this.lblXMP2_tCCD_L = new System.Windows.Forms.Label();
            this.lblXMP2_tRRD_L = new System.Windows.Forms.Label();
            this.tboxXMP2_tRTP = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tFAW = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRRD_L = new System.Windows.Forms.TextBox();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.lblXMP2_tRFCsb = new System.Windows.Forms.Label();
            this.lblXMP2_tRFC2 = new System.Windows.Forms.Label();
            this.lblXMP2_tRFC1 = new System.Windows.Forms.Label();
            this.lblXMP2_tWR = new System.Windows.Forms.Label();
            this.lblXMP2_tRC = new System.Windows.Forms.Label();
            this.lblXMP2_tRAS = new System.Windows.Forms.Label();
            this.lblXMP2_tRP = new System.Windows.Forms.Label();
            this.lblXMP2_tRCD = new System.Windows.Forms.Label();
            this.lblXMP2_tAA = new System.Windows.Forms.Label();
            this.tboxXMP2_tRFCsb = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRFC2 = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRFC1 = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tWR = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRC = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRAS = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tRP = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.tboxXMP2_tRCD = new System.Windows.Forms.TextBox();
            this.tboxXMP2_tAA = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cboxXMP2_CL90 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL78 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL66 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL54 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL42 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL30 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL88 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL76 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL64 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL52 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL40 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL28 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL98 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL86 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL74 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL62 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL50 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL38 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL26 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL96 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL84 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL72 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL60 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL48 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL36 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL24 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL94 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL82 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL70 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL58 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL46 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL34 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL22 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL92 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL80 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL68 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL56 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL44 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL32 = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_CL20 = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tboxXMP2_VMEM = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.tboxXMP2_VPP = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.tboxXMP2_VDDQ = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.tboxXMP2_VDD = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cboxXMP2_RealTimeMemoryFrequencyOC = new System.Windows.Forms.CheckBox();
            this.cboxXMP2_IntelDynamicMemoryBoost = new System.Windows.Forms.CheckBox();
            this.comboxXMP2_CommandRate = new System.Windows.Forms.ComboBox();
            this.tboxXMP2_MegaTransfers = new System.Windows.Forms.TextBox();
            this.tboxXMP2_Frequency = new System.Windows.Forms.TextBox();
            this.updnXMP2_MinCycleTime = new System.Windows.Forms.NumericUpDown();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.tabPageSPD_EXPO1 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblEXPO1_tRTP = new System.Windows.Forms.Label();
            this.lblEXPO1_tCCD_S_WTR = new System.Windows.Forms.Label();
            this.lblEXPO1_tCCD_L_WTR = new System.Windows.Forms.Label();
            this.lblEXPO1_tFAW = new System.Windows.Forms.Label();
            this.lblEXPO1_tCCD_L_WR2 = new System.Windows.Forms.Label();
            this.lblEXPO1_tCCD_L_WR = new System.Windows.Forms.Label();
            this.lblEXPO1_tCCD_L = new System.Windows.Forms.Label();
            this.lblEXPO1_tRRD_L = new System.Windows.Forms.Label();
            this.tboxEXPO1_tRTP = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tFAW = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRRD_L = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.lblEXPO1_tRFC = new System.Windows.Forms.Label();
            this.lblEXPO1_tRFC2 = new System.Windows.Forms.Label();
            this.lblEXPO1_tRFC1 = new System.Windows.Forms.Label();
            this.lblEXPO1_tWR = new System.Windows.Forms.Label();
            this.lblEXPO1_tRC = new System.Windows.Forms.Label();
            this.lblEXPO1_tRAS = new System.Windows.Forms.Label();
            this.lblEXPO1_tRP = new System.Windows.Forms.Label();
            this.lblEXPO1_tRCD = new System.Windows.Forms.Label();
            this.lblEXPO1_tAA = new System.Windows.Forms.Label();
            this.tboxEXPO1_tRFCsb = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRFC2 = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRFC1 = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tWR = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRC = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRAS = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tRP = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.tboxEXPO1_tRCD = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_tAA = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tboxEXPO1_VPP = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.tboxEXPO1_VDDQ = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.tboxEXPO1_VDD = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.tboxEXPO1_MegaTransfers = new System.Windows.Forms.TextBox();
            this.tboxEXPO1_Frequency = new System.Windows.Forms.TextBox();
            this.updnEXPO1_MinCycleTime = new System.Windows.Forms.NumericUpDown();
            this.label112 = new System.Windows.Forms.Label();
            this.tabPageSPD_EXPO2 = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.lblEXPO2_tRTP = new System.Windows.Forms.Label();
            this.lblEXPO2_tCCD_S_WTR = new System.Windows.Forms.Label();
            this.lblEXPO2_tCCD_L_WTR = new System.Windows.Forms.Label();
            this.lblEXPO2_tFAW = new System.Windows.Forms.Label();
            this.lblEXPO2_tCCD_L_WR2 = new System.Windows.Forms.Label();
            this.lblEXPO2_tCCD_L_WR = new System.Windows.Forms.Label();
            this.lblEXPO2_tCCD_L = new System.Windows.Forms.Label();
            this.lblEXPO2_tRRD_L = new System.Windows.Forms.Label();
            this.tboxEXPO2_tRTP = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tCCD_S_WTR = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tCCD_L_WTR = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tFAW = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tCCD_L_WR2 = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tCCD_L_WR = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tCCD_L = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRRD_L = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.lblEXPO2_tRFC = new System.Windows.Forms.Label();
            this.lblEXPO2_tRFC2 = new System.Windows.Forms.Label();
            this.lblEXPO2_tRFC1 = new System.Windows.Forms.Label();
            this.lblEXPO2_tWR = new System.Windows.Forms.Label();
            this.lblEXPO2_tRC = new System.Windows.Forms.Label();
            this.lblEXPO2_tRAS = new System.Windows.Forms.Label();
            this.lblEXPO2_tRP = new System.Windows.Forms.Label();
            this.lblEXPO2_tRCD = new System.Windows.Forms.Label();
            this.lblEXPO2_tAA = new System.Windows.Forms.Label();
            this.tboxEXPO2_tRFCsb = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRFC2 = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRFC1 = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tWR = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRC = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRAS = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tRP = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.tboxEXPO2_tRCD = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_tAA = new System.Windows.Forms.TextBox();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tboxEXPO2_VPP = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tboxEXPO2_VDDQ = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tboxEXPO2_VDD = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tboxEXPO2_MegaTransfers = new System.Windows.Forms.TextBox();
            this.tboxEXPO2_Frequency = new System.Windows.Forms.TextBox();
            this.updnEXPO2_MinCycleTime = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPageSPD_Header = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.tboxEXPOheader_Configuration = new System.Windows.Forms.TextBox();
            this.tboxEXPOheader_Version = new System.Windows.Forms.TextBox();
            this.tboxEXPOheader_IdString = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.tboxXMP2_ProfileName = new System.Windows.Forms.TextBox();
            this.tboxXMP1_ProfileName = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.tboxXMPheader_PMICcap = new System.Windows.Forms.TextBox();
            this.tboxXMPheader_PMICnum = new System.Windows.Forms.TextBox();
            this.tboxXMPheader_PMICvend = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.tboxXMPheader_Configuration = new System.Windows.Forms.TextBox();
            this.tboxXMPheader_Version = new System.Windows.Forms.TextBox();
            this.tboxXMPheader_IdString = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.cbox_EnableEXPO2 = new System.Windows.Forms.CheckBox();
            this.cbox_EnableEXPO1 = new System.Windows.Forms.CheckBox();
            this.cbox_EnableXMP2 = new System.Windows.Forms.CheckBox();
            this.cbox_EnableXMP1 = new System.Windows.Forms.CheckBox();
            this.btnSPDupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxMSD = new System.Windows.Forms.TextBox();
            this.tboxPNum = new System.Windows.Forms.TextBox();
            this.tboxSNum = new System.Windows.Forms.TextBox();
            this.tboxDMIDparsing = new System.Windows.Forms.TextBox();
            this.tboxDMID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxMDweek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxMDyear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxMIDparsing = new System.Windows.Forms.TextBox();
            this.tboxMID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.btnCvsSave = new System.Windows.Forms.Button();
            this.btnLogSave = new System.Windows.Forms.Button();
            this.btnCvsClear = new System.Windows.Forms.Button();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.listBoxCvs = new System.Windows.Forms.ListBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.timerInterfaceUpdater = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBarConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarCrcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusBarRamType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageSPD.SuspendLayout();
            this.tabControlSPD.SuspendLayout();
            this.tabPageSPD_SPD.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinCycleTime)).BeginInit();
            this.tabPageSPD_XMP1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnXMP1_MinCycleTime)).BeginInit();
            this.tabPageSPD_XMP2.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnXMP2_MinCycleTime)).BeginInit();
            this.tabPageSPD_EXPO1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEXPO1_MinCycleTime)).BeginInit();
            this.tabPageSPD_EXPO2.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEXPO2_MinCycleTime)).BeginInit();
            this.tabPageSPD_Header.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpenFile,
            this.toolSave,
            this.toolClear,
            this.toolStripSeparator1,
            this.toolDevice,
            this.toolStripSeparator2,
            this.toolReadEeprom,
            this.toolWriteEeprom,
            this.toolStripSeparator3});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(662, 44);
            this.toolStripMain.TabIndex = 9;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolOpenFile
            // 
            this.toolOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolOpenFile.Image")));
            this.toolOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpenFile.Name = "toolOpenFile";
            this.toolOpenFile.Size = new System.Drawing.Size(44, 41);
            this.toolOpenFile.Text = "toolStripButton_Open";
            this.toolOpenFile.ToolTipText = "Open File";
            this.toolOpenFile.Click += new System.EventHandler(this.toolOpenFile_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_SaveHexData,
            this.toolMenu_SaveCSVFile,
            this.toolMenu_SaveLogFile});
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(54, 41);
            this.toolSave.Text = "Save";
            // 
            // toolMenu_SaveHexData
            // 
            this.toolMenu_SaveHexData.Name = "toolMenu_SaveHexData";
            this.toolMenu_SaveHexData.Size = new System.Drawing.Size(191, 26);
            this.toolMenu_SaveHexData.Text = "Save &Hex Data";
            this.toolMenu_SaveHexData.Click += new System.EventHandler(this.toolMenu_SaveHexData_Click);
            // 
            // toolMenu_SaveCSVFile
            // 
            this.toolMenu_SaveCSVFile.Name = "toolMenu_SaveCSVFile";
            this.toolMenu_SaveCSVFile.Size = new System.Drawing.Size(191, 26);
            this.toolMenu_SaveCSVFile.Text = "Save &CSV File";
            this.toolMenu_SaveCSVFile.Click += new System.EventHandler(this.toolMenu_SaveCSVFile_Click);
            // 
            // toolMenu_SaveLogFile
            // 
            this.toolMenu_SaveLogFile.Name = "toolMenu_SaveLogFile";
            this.toolMenu_SaveLogFile.Size = new System.Drawing.Size(191, 26);
            this.toolMenu_SaveLogFile.Text = "Save &Log File";
            this.toolMenu_SaveLogFile.Click += new System.EventHandler(this.toolMenu_SaveLogFile_Click);
            // 
            // toolClear
            // 
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClear.Image = ((System.Drawing.Image)(resources.GetObject("toolClear.Image")));
            this.toolClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Size = new System.Drawing.Size(43, 41);
            this.toolClear.Text = "Clear";
            this.toolClear.Click += new System.EventHandler(this.toolClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolDevice
            // 
            this.toolDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDevice.Image = ((System.Drawing.Image)(resources.GetObject("toolDevice.Image")));
            this.toolDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDevice.Name = "toolDevice";
            this.toolDevice.Size = new System.Drawing.Size(59, 41);
            this.toolDevice.Text = "ToolStripDrop_Device";
            this.toolDevice.ToolTipText = "COM Search";
            this.toolDevice.Click += new System.EventHandler(this.toolDevice_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolReadEeprom
            // 
            this.toolReadEeprom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReadEeprom.Image = ((System.Drawing.Image)(resources.GetObject("toolReadEeprom.Image")));
            this.toolReadEeprom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolReadEeprom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReadEeprom.Name = "toolReadEeprom";
            this.toolReadEeprom.Size = new System.Drawing.Size(49, 41);
            this.toolReadEeprom.Text = "toolStripButton_ReadEeprom";
            this.toolReadEeprom.ToolTipText = "Save File";
            this.toolReadEeprom.Click += new System.EventHandler(this.toolReadEeprom_Click);
            // 
            // toolWriteEeprom
            // 
            this.toolWriteEeprom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWriteEeprom.Image = ((System.Drawing.Image)(resources.GetObject("toolWriteEeprom.Image")));
            this.toolWriteEeprom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolWriteEeprom.Name = "toolWriteEeprom";
            this.toolWriteEeprom.Size = new System.Drawing.Size(49, 41);
            this.toolWriteEeprom.Text = "Write Tool";
            this.toolWriteEeprom.Click += new System.EventHandler(this.toolWriteEeprom_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageSPD);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Location = new System.Drawing.Point(2, 59);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(657, 664);
            this.tabControlMain.TabIndex = 10;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.Transparent;
            this.tabPageMain.Controls.Add(this.tboxHexData);
            this.tabPageMain.Controls.Add(this.label26);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMain.Size = new System.Drawing.Size(649, 635);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Data View";
            // 
            // tboxHexData
            // 
            this.tboxHexData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxHexData.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHexData.Location = new System.Drawing.Point(3, 24);
            this.tboxHexData.Name = "tboxHexData";
            this.tboxHexData.Size = new System.Drawing.Size(643, 607);
            this.tboxHexData.TabIndex = 6;
            this.tboxHexData.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Top;
            this.label26.Font = new System.Drawing.Font("Consolas", 9.7F);
            this.label26.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label26.Location = new System.Drawing.Point(3, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(630, 20);
            this.label26.TabIndex = 5;
            this.label26.Text = "Add : 00 01 02 03  04 05 06 07  08 09 0A 0B  0C 0D 0E 0F :      ASCII";
            // 
            // tabPageSPD
            // 
            this.tabPageSPD.BackColor = System.Drawing.Color.Transparent;
            this.tabPageSPD.Controls.Add(this.tabControlSPD);
            this.tabPageSPD.Controls.Add(this.cbox_EnableEXPO2);
            this.tabPageSPD.Controls.Add(this.cbox_EnableEXPO1);
            this.tabPageSPD.Controls.Add(this.cbox_EnableXMP2);
            this.tabPageSPD.Controls.Add(this.cbox_EnableXMP1);
            this.tabPageSPD.Controls.Add(this.btnSPDupdate);
            this.tabPageSPD.Controls.Add(this.label6);
            this.tabPageSPD.Controls.Add(this.label5);
            this.tabPageSPD.Controls.Add(this.label8);
            this.tabPageSPD.Controls.Add(this.label7);
            this.tabPageSPD.Controls.Add(this.tboxMSD);
            this.tabPageSPD.Controls.Add(this.tboxPNum);
            this.tabPageSPD.Controls.Add(this.tboxSNum);
            this.tabPageSPD.Controls.Add(this.tboxDMIDparsing);
            this.tabPageSPD.Controls.Add(this.tboxDMID);
            this.tabPageSPD.Controls.Add(this.label4);
            this.tabPageSPD.Controls.Add(this.tboxMDweek);
            this.tabPageSPD.Controls.Add(this.label3);
            this.tabPageSPD.Controls.Add(this.tboxMDyear);
            this.tabPageSPD.Controls.Add(this.label2);
            this.tabPageSPD.Controls.Add(this.tboxMIDparsing);
            this.tabPageSPD.Controls.Add(this.tboxMID);
            this.tabPageSPD.Controls.Add(this.label1);
            this.tabPageSPD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageSPD.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD.Name = "tabPageSPD";
            this.tabPageSPD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD.Size = new System.Drawing.Size(651, 783);
            this.tabPageSPD.TabIndex = 1;
            this.tabPageSPD.Text = "SPD";
            // 
            // tabControlSPD
            // 
            this.tabControlSPD.Controls.Add(this.tabPageSPD_SPD);
            this.tabControlSPD.Controls.Add(this.tabPageSPD_XMP1);
            this.tabControlSPD.Controls.Add(this.tabPageSPD_XMP2);
            this.tabControlSPD.Controls.Add(this.tabPageSPD_EXPO1);
            this.tabControlSPD.Controls.Add(this.tabPageSPD_EXPO2);
            this.tabControlSPD.Controls.Add(this.tabPageSPD_Header);
            this.tabControlSPD.Location = new System.Drawing.Point(7, 139);
            this.tabControlSPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlSPD.Name = "tabControlSPD";
            this.tabControlSPD.SelectedIndex = 0;
            this.tabControlSPD.Size = new System.Drawing.Size(623, 641);
            this.tabControlSPD.TabIndex = 20;
            // 
            // tabPageSPD_SPD
            // 
            this.tabPageSPD_SPD.Controls.Add(this.groupBox3);
            this.tabPageSPD_SPD.Controls.Add(this.groupBox2);
            this.tabPageSPD_SPD.Controls.Add(this.groupBox1);
            this.tabPageSPD_SPD.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_SPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_SPD.Name = "tabPageSPD_SPD";
            this.tabPageSPD_SPD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_SPD.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_SPD.TabIndex = 0;
            this.tabPageSPD_SPD.Text = "SPD";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tRTP);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tCCD_S_WTR);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tCCD_L_WTR);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tFAW);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tCCD_L_WR2);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tCCD_L_WR);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tCCD_L);
            this.groupBox3.Controls.Add(this.tboxTimingLmt_tRRD_L);
            this.groupBox3.Controls.Add(this.lblTiming_tRTP);
            this.groupBox3.Controls.Add(this.lblTiming_tCCD_S_WTR);
            this.groupBox3.Controls.Add(this.lblTiming_tCCD_L_WTR);
            this.groupBox3.Controls.Add(this.lblTiming_tFAW);
            this.groupBox3.Controls.Add(this.lblTiming_tCCD_L_WR2);
            this.groupBox3.Controls.Add(this.lblTiming_tCCD_L_WR);
            this.groupBox3.Controls.Add(this.lblTiming_tCCD_L);
            this.groupBox3.Controls.Add(this.lblTiming_tRRD_L);
            this.groupBox3.Controls.Add(this.tboxTiming_tRTP);
            this.groupBox3.Controls.Add(this.tboxTiming_tCCD_S_WTR);
            this.groupBox3.Controls.Add(this.tboxTiming_tCCD_L_WTR);
            this.groupBox3.Controls.Add(this.tboxTiming_tFAW);
            this.groupBox3.Controls.Add(this.tboxTiming_tCCD_L_WR2);
            this.groupBox3.Controls.Add(this.tboxTiming_tCCD_L_WR);
            this.groupBox3.Controls.Add(this.tboxTiming_tCCD_L);
            this.groupBox3.Controls.Add(this.tboxTiming_tRRD_L);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.lblTiming_tRFCsb);
            this.groupBox3.Controls.Add(this.lblTiming_tRFC2);
            this.groupBox3.Controls.Add(this.lblTiming_tRFC1);
            this.groupBox3.Controls.Add(this.lblTiming_tWR);
            this.groupBox3.Controls.Add(this.lblTiming_tRC);
            this.groupBox3.Controls.Add(this.lblTiming_tRAS);
            this.groupBox3.Controls.Add(this.lblTiming_tRP);
            this.groupBox3.Controls.Add(this.lblTiming_tRCD);
            this.groupBox3.Controls.Add(this.lblTiming_tAA);
            this.groupBox3.Controls.Add(this.tboxTiming_tRFCsb);
            this.groupBox3.Controls.Add(this.tboxTiming_tRFC2);
            this.groupBox3.Controls.Add(this.tboxTiming_tRFC1);
            this.groupBox3.Controls.Add(this.tboxTiming_tWR);
            this.groupBox3.Controls.Add(this.tboxTiming_tRC);
            this.groupBox3.Controls.Add(this.tboxTiming_tRAS);
            this.groupBox3.Controls.Add(this.tboxTiming_tRP);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.tboxTiming_tRCD);
            this.groupBox3.Controls.Add(this.tboxTiming_tAA);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(7, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(600, 296);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timings";
            // 
            // tboxTimingLmt_tRTP
            // 
            this.tboxTimingLmt_tRTP.Location = new System.Drawing.Point(427, 231);
            this.tboxTimingLmt_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tRTP.Name = "tboxTimingLmt_tRTP";
            this.tboxTimingLmt_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tRTP.TabIndex = 25;
            // 
            // tboxTimingLmt_tCCD_S_WTR
            // 
            this.tboxTimingLmt_tCCD_S_WTR.Location = new System.Drawing.Point(427, 204);
            this.tboxTimingLmt_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tCCD_S_WTR.Name = "tboxTimingLmt_tCCD_S_WTR";
            this.tboxTimingLmt_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tCCD_S_WTR.TabIndex = 24;
            // 
            // tboxTimingLmt_tCCD_L_WTR
            // 
            this.tboxTimingLmt_tCCD_L_WTR.Location = new System.Drawing.Point(427, 176);
            this.tboxTimingLmt_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tCCD_L_WTR.Name = "tboxTimingLmt_tCCD_L_WTR";
            this.tboxTimingLmt_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tCCD_L_WTR.TabIndex = 23;
            // 
            // tboxTimingLmt_tFAW
            // 
            this.tboxTimingLmt_tFAW.Location = new System.Drawing.Point(427, 149);
            this.tboxTimingLmt_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tFAW.Name = "tboxTimingLmt_tFAW";
            this.tboxTimingLmt_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tFAW.TabIndex = 22;
            // 
            // tboxTimingLmt_tCCD_L_WR2
            // 
            this.tboxTimingLmt_tCCD_L_WR2.Location = new System.Drawing.Point(427, 121);
            this.tboxTimingLmt_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tCCD_L_WR2.Name = "tboxTimingLmt_tCCD_L_WR2";
            this.tboxTimingLmt_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tCCD_L_WR2.TabIndex = 21;
            // 
            // tboxTimingLmt_tCCD_L_WR
            // 
            this.tboxTimingLmt_tCCD_L_WR.Location = new System.Drawing.Point(427, 94);
            this.tboxTimingLmt_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tCCD_L_WR.Name = "tboxTimingLmt_tCCD_L_WR";
            this.tboxTimingLmt_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tCCD_L_WR.TabIndex = 20;
            // 
            // tboxTimingLmt_tCCD_L
            // 
            this.tboxTimingLmt_tCCD_L.Location = new System.Drawing.Point(427, 66);
            this.tboxTimingLmt_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tCCD_L.Name = "tboxTimingLmt_tCCD_L";
            this.tboxTimingLmt_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tCCD_L.TabIndex = 19;
            // 
            // tboxTimingLmt_tRRD_L
            // 
            this.tboxTimingLmt_tRRD_L.Location = new System.Drawing.Point(427, 39);
            this.tboxTimingLmt_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTimingLmt_tRRD_L.Name = "tboxTimingLmt_tRRD_L";
            this.tboxTimingLmt_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxTimingLmt_tRRD_L.TabIndex = 18;
            // 
            // lblTiming_tRTP
            // 
            this.lblTiming_tRTP.AutoSize = true;
            this.lblTiming_tRTP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRTP.Location = new System.Drawing.Point(502, 235);
            this.lblTiming_tRTP.Name = "lblTiming_tRTP";
            this.lblTiming_tRTP.Size = new System.Drawing.Size(39, 20);
            this.lblTiming_tRTP.TabIndex = 50;
            this.lblTiming_tRTP.Text = "tRTP";
            // 
            // lblTiming_tCCD_S_WTR
            // 
            this.lblTiming_tCCD_S_WTR.AutoSize = true;
            this.lblTiming_tCCD_S_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tCCD_S_WTR.Location = new System.Drawing.Point(502, 212);
            this.lblTiming_tCCD_S_WTR.Name = "lblTiming_tCCD_S_WTR";
            this.lblTiming_tCCD_S_WTR.Size = new System.Drawing.Size(94, 20);
            this.lblTiming_tCCD_S_WTR.TabIndex = 51;
            this.lblTiming_tCCD_S_WTR.Text = "tCCD_S_WTR";
            // 
            // lblTiming_tCCD_L_WTR
            // 
            this.lblTiming_tCCD_L_WTR.AutoSize = true;
            this.lblTiming_tCCD_L_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tCCD_L_WTR.Location = new System.Drawing.Point(502, 185);
            this.lblTiming_tCCD_L_WTR.Name = "lblTiming_tCCD_L_WTR";
            this.lblTiming_tCCD_L_WTR.Size = new System.Drawing.Size(93, 20);
            this.lblTiming_tCCD_L_WTR.TabIndex = 47;
            this.lblTiming_tCCD_L_WTR.Text = "tCCD_L_WTR";
            // 
            // lblTiming_tFAW
            // 
            this.lblTiming_tFAW.AutoSize = true;
            this.lblTiming_tFAW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tFAW.Location = new System.Drawing.Point(502, 158);
            this.lblTiming_tFAW.Name = "lblTiming_tFAW";
            this.lblTiming_tFAW.Size = new System.Drawing.Size(43, 20);
            this.lblTiming_tFAW.TabIndex = 48;
            this.lblTiming_tFAW.Text = "tFAW";
            // 
            // lblTiming_tCCD_L_WR2
            // 
            this.lblTiming_tCCD_L_WR2.AutoSize = true;
            this.lblTiming_tCCD_L_WR2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tCCD_L_WR2.Location = new System.Drawing.Point(502, 129);
            this.lblTiming_tCCD_L_WR2.Name = "lblTiming_tCCD_L_WR2";
            this.lblTiming_tCCD_L_WR2.Size = new System.Drawing.Size(93, 20);
            this.lblTiming_tCCD_L_WR2.TabIndex = 49;
            this.lblTiming_tCCD_L_WR2.Text = "tCCD_L_WR2";
            // 
            // lblTiming_tCCD_L_WR
            // 
            this.lblTiming_tCCD_L_WR.AutoSize = true;
            this.lblTiming_tCCD_L_WR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tCCD_L_WR.Location = new System.Drawing.Point(502, 101);
            this.lblTiming_tCCD_L_WR.Name = "lblTiming_tCCD_L_WR";
            this.lblTiming_tCCD_L_WR.Size = new System.Drawing.Size(85, 20);
            this.lblTiming_tCCD_L_WR.TabIndex = 44;
            this.lblTiming_tCCD_L_WR.Text = "tCCD_L_WR";
            // 
            // lblTiming_tCCD_L
            // 
            this.lblTiming_tCCD_L.AutoSize = true;
            this.lblTiming_tCCD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tCCD_L.Location = new System.Drawing.Point(502, 74);
            this.lblTiming_tCCD_L.Name = "lblTiming_tCCD_L";
            this.lblTiming_tCCD_L.Size = new System.Drawing.Size(56, 20);
            this.lblTiming_tCCD_L.TabIndex = 45;
            this.lblTiming_tCCD_L.Text = "tCCD_L";
            // 
            // lblTiming_tRRD_L
            // 
            this.lblTiming_tRRD_L.AutoSize = true;
            this.lblTiming_tRRD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRRD_L.Location = new System.Drawing.Point(502, 46);
            this.lblTiming_tRRD_L.Name = "lblTiming_tRRD_L";
            this.lblTiming_tRRD_L.Size = new System.Drawing.Size(56, 20);
            this.lblTiming_tRRD_L.TabIndex = 46;
            this.lblTiming_tRRD_L.Text = "tRRD_L";
            // 
            // tboxTiming_tRTP
            // 
            this.tboxTiming_tRTP.Location = new System.Drawing.Point(350, 232);
            this.tboxTiming_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRTP.Name = "tboxTiming_tRTP";
            this.tboxTiming_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRTP.TabIndex = 17;
            // 
            // tboxTiming_tCCD_S_WTR
            // 
            this.tboxTiming_tCCD_S_WTR.Location = new System.Drawing.Point(350, 205);
            this.tboxTiming_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tCCD_S_WTR.Name = "tboxTiming_tCCD_S_WTR";
            this.tboxTiming_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tCCD_S_WTR.TabIndex = 16;
            // 
            // tboxTiming_tCCD_L_WTR
            // 
            this.tboxTiming_tCCD_L_WTR.Location = new System.Drawing.Point(350, 178);
            this.tboxTiming_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tCCD_L_WTR.Name = "tboxTiming_tCCD_L_WTR";
            this.tboxTiming_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tCCD_L_WTR.TabIndex = 15;
            // 
            // tboxTiming_tFAW
            // 
            this.tboxTiming_tFAW.Location = new System.Drawing.Point(350, 150);
            this.tboxTiming_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tFAW.Name = "tboxTiming_tFAW";
            this.tboxTiming_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tFAW.TabIndex = 14;
            // 
            // tboxTiming_tCCD_L_WR2
            // 
            this.tboxTiming_tCCD_L_WR2.Location = new System.Drawing.Point(350, 122);
            this.tboxTiming_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tCCD_L_WR2.Name = "tboxTiming_tCCD_L_WR2";
            this.tboxTiming_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tCCD_L_WR2.TabIndex = 13;
            // 
            // tboxTiming_tCCD_L_WR
            // 
            this.tboxTiming_tCCD_L_WR.Location = new System.Drawing.Point(350, 95);
            this.tboxTiming_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tCCD_L_WR.Name = "tboxTiming_tCCD_L_WR";
            this.tboxTiming_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tCCD_L_WR.TabIndex = 12;
            // 
            // tboxTiming_tCCD_L
            // 
            this.tboxTiming_tCCD_L.Location = new System.Drawing.Point(350, 68);
            this.tboxTiming_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tCCD_L.Name = "tboxTiming_tCCD_L";
            this.tboxTiming_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tCCD_L.TabIndex = 11;
            // 
            // tboxTiming_tRRD_L
            // 
            this.tboxTiming_tRRD_L.Location = new System.Drawing.Point(350, 40);
            this.tboxTiming_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRRD_L.Name = "tboxTiming_tRRD_L";
            this.tboxTiming_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRRD_L.TabIndex = 10;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(305, 236);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(46, 20);
            this.label34.TabIndex = 36;
            this.label34.Text = "tRTP :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(257, 209);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(101, 20);
            this.label35.TabIndex = 37;
            this.label35.Text = "tCCD_S_WTR :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(257, 181);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 20);
            this.label36.TabIndex = 33;
            this.label36.Text = "tCCD_L_WTR :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(298, 154);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(50, 20);
            this.label37.TabIndex = 34;
            this.label37.Text = "tFAW :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(256, 125);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 20);
            this.label38.TabIndex = 35;
            this.label38.Text = "tCCD_L_WR2 :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(263, 99);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(92, 20);
            this.label39.TabIndex = 29;
            this.label39.Text = "tCCD_L_WR :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(289, 71);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(63, 20);
            this.label40.TabIndex = 32;
            this.label40.Text = "tCCD_L :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(289, 44);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(63, 20);
            this.label41.TabIndex = 28;
            this.label41.Text = "tRRD_L :";
            // 
            // lblTiming_tRFCsb
            // 
            this.lblTiming_tRFCsb.AutoSize = true;
            this.lblTiming_tRFCsb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRFCsb.Location = new System.Drawing.Point(159, 268);
            this.lblTiming_tRFCsb.Name = "lblTiming_tRFCsb";
            this.lblTiming_tRFCsb.Size = new System.Drawing.Size(54, 20);
            this.lblTiming_tRFCsb.TabIndex = 25;
            this.lblTiming_tRFCsb.Text = "tRFCsb";
            // 
            // lblTiming_tRFC2
            // 
            this.lblTiming_tRFC2.AutoSize = true;
            this.lblTiming_tRFC2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRFC2.Location = new System.Drawing.Point(159, 240);
            this.lblTiming_tRFC2.Name = "lblTiming_tRFC2";
            this.lblTiming_tRFC2.Size = new System.Drawing.Size(47, 20);
            this.lblTiming_tRFC2.TabIndex = 26;
            this.lblTiming_tRFC2.Text = "tRFC2";
            // 
            // lblTiming_tRFC1
            // 
            this.lblTiming_tRFC1.AutoSize = true;
            this.lblTiming_tRFC1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRFC1.Location = new System.Drawing.Point(159, 212);
            this.lblTiming_tRFC1.Name = "lblTiming_tRFC1";
            this.lblTiming_tRFC1.Size = new System.Drawing.Size(47, 20);
            this.lblTiming_tRFC1.TabIndex = 27;
            this.lblTiming_tRFC1.Text = "tRFC1";
            // 
            // lblTiming_tWR
            // 
            this.lblTiming_tWR.AutoSize = true;
            this.lblTiming_tWR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tWR.Location = new System.Drawing.Point(159, 185);
            this.lblTiming_tWR.Name = "lblTiming_tWR";
            this.lblTiming_tWR.Size = new System.Drawing.Size(37, 20);
            this.lblTiming_tWR.TabIndex = 22;
            this.lblTiming_tWR.Text = "tWR";
            // 
            // lblTiming_tRC
            // 
            this.lblTiming_tRC.AutoSize = true;
            this.lblTiming_tRC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRC.Location = new System.Drawing.Point(159, 158);
            this.lblTiming_tRC.Name = "lblTiming_tRC";
            this.lblTiming_tRC.Size = new System.Drawing.Size(32, 20);
            this.lblTiming_tRC.TabIndex = 23;
            this.lblTiming_tRC.Text = "tRC";
            // 
            // lblTiming_tRAS
            // 
            this.lblTiming_tRAS.AutoSize = true;
            this.lblTiming_tRAS.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRAS.Location = new System.Drawing.Point(159, 129);
            this.lblTiming_tRAS.Name = "lblTiming_tRAS";
            this.lblTiming_tRAS.Size = new System.Drawing.Size(41, 20);
            this.lblTiming_tRAS.TabIndex = 24;
            this.lblTiming_tRAS.Text = "tRAS";
            // 
            // lblTiming_tRP
            // 
            this.lblTiming_tRP.AutoSize = true;
            this.lblTiming_tRP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRP.Location = new System.Drawing.Point(159, 101);
            this.lblTiming_tRP.Name = "lblTiming_tRP";
            this.lblTiming_tRP.Size = new System.Drawing.Size(31, 20);
            this.lblTiming_tRP.TabIndex = 19;
            this.lblTiming_tRP.Text = "tRP";
            // 
            // lblTiming_tRCD
            // 
            this.lblTiming_tRCD.AutoSize = true;
            this.lblTiming_tRCD.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tRCD.Location = new System.Drawing.Point(159, 74);
            this.lblTiming_tRCD.Name = "lblTiming_tRCD";
            this.lblTiming_tRCD.Size = new System.Drawing.Size(43, 20);
            this.lblTiming_tRCD.TabIndex = 20;
            this.lblTiming_tRCD.Text = "tRCD";
            // 
            // lblTiming_tAA
            // 
            this.lblTiming_tAA.AutoSize = true;
            this.lblTiming_tAA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming_tAA.Location = new System.Drawing.Point(159, 46);
            this.lblTiming_tAA.Name = "lblTiming_tAA";
            this.lblTiming_tAA.Size = new System.Drawing.Size(34, 20);
            this.lblTiming_tAA.TabIndex = 21;
            this.lblTiming_tAA.Text = "tAA";
            // 
            // tboxTiming_tRFCsb
            // 
            this.tboxTiming_tRFCsb.Location = new System.Drawing.Point(83, 262);
            this.tboxTiming_tRFCsb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRFCsb.Name = "tboxTiming_tRFCsb";
            this.tboxTiming_tRFCsb.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRFCsb.TabIndex = 9;
            // 
            // tboxTiming_tRFC2
            // 
            this.tboxTiming_tRFC2.Location = new System.Drawing.Point(83, 235);
            this.tboxTiming_tRFC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRFC2.Name = "tboxTiming_tRFC2";
            this.tboxTiming_tRFC2.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRFC2.TabIndex = 8;
            // 
            // tboxTiming_tRFC1
            // 
            this.tboxTiming_tRFC1.Location = new System.Drawing.Point(83, 208);
            this.tboxTiming_tRFC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRFC1.Name = "tboxTiming_tRFC1";
            this.tboxTiming_tRFC1.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRFC1.TabIndex = 7;
            // 
            // tboxTiming_tWR
            // 
            this.tboxTiming_tWR.Location = new System.Drawing.Point(83, 180);
            this.tboxTiming_tWR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tWR.Name = "tboxTiming_tWR";
            this.tboxTiming_tWR.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tWR.TabIndex = 6;
            // 
            // tboxTiming_tRC
            // 
            this.tboxTiming_tRC.Location = new System.Drawing.Point(83, 152);
            this.tboxTiming_tRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRC.Name = "tboxTiming_tRC";
            this.tboxTiming_tRC.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRC.TabIndex = 5;
            // 
            // tboxTiming_tRAS
            // 
            this.tboxTiming_tRAS.Location = new System.Drawing.Point(83, 125);
            this.tboxTiming_tRAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRAS.Name = "tboxTiming_tRAS";
            this.tboxTiming_tRAS.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRAS.TabIndex = 4;
            // 
            // tboxTiming_tRP
            // 
            this.tboxTiming_tRP.Location = new System.Drawing.Point(83, 98);
            this.tboxTiming_tRP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRP.Name = "tboxTiming_tRP";
            this.tboxTiming_tRP.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRP.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 266);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 20);
            this.label23.TabIndex = 9;
            this.label23.Text = "tRFCsb :";
            // 
            // tboxTiming_tRCD
            // 
            this.tboxTiming_tRCD.Location = new System.Drawing.Point(83, 70);
            this.tboxTiming_tRCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tRCD.Name = "tboxTiming_tRCD";
            this.tboxTiming_tRCD.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tRCD.TabIndex = 2;
            // 
            // tboxTiming_tAA
            // 
            this.tboxTiming_tAA.Location = new System.Drawing.Point(83, 42);
            this.tboxTiming_tAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTiming_tAA.Name = "tboxTiming_tAA";
            this.tboxTiming_tAA.Size = new System.Drawing.Size(59, 25);
            this.tboxTiming_tAA.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 239);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 20);
            this.label24.TabIndex = 10;
            this.label24.Text = "tRFC2 :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(13, 211);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 20);
            this.label25.TabIndex = 11;
            this.label25.Text = "tRFC1 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "tWR :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "tRC :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 20);
            this.label22.TabIndex = 8;
            this.label22.Text = "tRAS :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(502, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ticks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(416, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "LowCLK Limit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(343, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Value (ps)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(282, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(153, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ticks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Value (ps)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "tRP :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "tRCD :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "tAA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxCL90);
            this.groupBox2.Controls.Add(this.cboxCL78);
            this.groupBox2.Controls.Add(this.cboxCL66);
            this.groupBox2.Controls.Add(this.cboxCL54);
            this.groupBox2.Controls.Add(this.cboxCL42);
            this.groupBox2.Controls.Add(this.cboxCL30);
            this.groupBox2.Controls.Add(this.cboxCL88);
            this.groupBox2.Controls.Add(this.cboxCL76);
            this.groupBox2.Controls.Add(this.cboxCL64);
            this.groupBox2.Controls.Add(this.cboxCL52);
            this.groupBox2.Controls.Add(this.cboxCL40);
            this.groupBox2.Controls.Add(this.cboxCL28);
            this.groupBox2.Controls.Add(this.cboxCL98);
            this.groupBox2.Controls.Add(this.cboxCL86);
            this.groupBox2.Controls.Add(this.cboxCL74);
            this.groupBox2.Controls.Add(this.cboxCL62);
            this.groupBox2.Controls.Add(this.cboxCL50);
            this.groupBox2.Controls.Add(this.cboxCL38);
            this.groupBox2.Controls.Add(this.cboxCL26);
            this.groupBox2.Controls.Add(this.cboxCL96);
            this.groupBox2.Controls.Add(this.cboxCL84);
            this.groupBox2.Controls.Add(this.cboxCL72);
            this.groupBox2.Controls.Add(this.cboxCL60);
            this.groupBox2.Controls.Add(this.cboxCL48);
            this.groupBox2.Controls.Add(this.cboxCL36);
            this.groupBox2.Controls.Add(this.cboxCL24);
            this.groupBox2.Controls.Add(this.cboxCL94);
            this.groupBox2.Controls.Add(this.cboxCL82);
            this.groupBox2.Controls.Add(this.cboxCL70);
            this.groupBox2.Controls.Add(this.cboxCL58);
            this.groupBox2.Controls.Add(this.cboxCL46);
            this.groupBox2.Controls.Add(this.cboxCL34);
            this.groupBox2.Controls.Add(this.cboxCL22);
            this.groupBox2.Controls.Add(this.cboxCL92);
            this.groupBox2.Controls.Add(this.cboxCL80);
            this.groupBox2.Controls.Add(this.cboxCL68);
            this.groupBox2.Controls.Add(this.cboxCL56);
            this.groupBox2.Controls.Add(this.cboxCL44);
            this.groupBox2.Controls.Add(this.cboxCL32);
            this.groupBox2.Controls.Add(this.cboxCL20);
            this.groupBox2.Location = new System.Drawing.Point(7, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supported CAS Latencies";
            // 
            // cboxCL90
            // 
            this.cboxCL90.AutoSize = true;
            this.cboxCL90.Location = new System.Drawing.Point(331, 21);
            this.cboxCL90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL90.Name = "cboxCL90";
            this.cboxCL90.Size = new System.Drawing.Size(45, 19);
            this.cboxCL90.TabIndex = 1;
            this.cboxCL90.Text = "90";
            this.cboxCL90.UseVisualStyleBackColor = true;
            // 
            // cboxCL78
            // 
            this.cboxCL78.AutoSize = true;
            this.cboxCL78.Location = new System.Drawing.Point(240, 106);
            this.cboxCL78.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL78.Name = "cboxCL78";
            this.cboxCL78.Size = new System.Drawing.Size(45, 19);
            this.cboxCL78.TabIndex = 1;
            this.cboxCL78.Text = "78";
            this.cboxCL78.UseVisualStyleBackColor = true;
            // 
            // cboxCL66
            // 
            this.cboxCL66.AutoSize = true;
            this.cboxCL66.Location = new System.Drawing.Point(194, 85);
            this.cboxCL66.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL66.Name = "cboxCL66";
            this.cboxCL66.Size = new System.Drawing.Size(45, 19);
            this.cboxCL66.TabIndex = 1;
            this.cboxCL66.Text = "66";
            this.cboxCL66.UseVisualStyleBackColor = true;
            // 
            // cboxCL54
            // 
            this.cboxCL54.AutoSize = true;
            this.cboxCL54.Location = new System.Drawing.Point(149, 64);
            this.cboxCL54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL54.Name = "cboxCL54";
            this.cboxCL54.Size = new System.Drawing.Size(45, 19);
            this.cboxCL54.TabIndex = 1;
            this.cboxCL54.Text = "54";
            this.cboxCL54.UseVisualStyleBackColor = true;
            // 
            // cboxCL42
            // 
            this.cboxCL42.AutoSize = true;
            this.cboxCL42.Location = new System.Drawing.Point(103, 42);
            this.cboxCL42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL42.Name = "cboxCL42";
            this.cboxCL42.Size = new System.Drawing.Size(45, 19);
            this.cboxCL42.TabIndex = 1;
            this.cboxCL42.Text = "42";
            this.cboxCL42.UseVisualStyleBackColor = true;
            // 
            // cboxCL30
            // 
            this.cboxCL30.AutoSize = true;
            this.cboxCL30.Location = new System.Drawing.Point(57, 21);
            this.cboxCL30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL30.Name = "cboxCL30";
            this.cboxCL30.Size = new System.Drawing.Size(45, 19);
            this.cboxCL30.TabIndex = 1;
            this.cboxCL30.Text = "30";
            this.cboxCL30.UseVisualStyleBackColor = true;
            // 
            // cboxCL88
            // 
            this.cboxCL88.AutoSize = true;
            this.cboxCL88.Location = new System.Drawing.Point(286, 106);
            this.cboxCL88.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL88.Name = "cboxCL88";
            this.cboxCL88.Size = new System.Drawing.Size(45, 19);
            this.cboxCL88.TabIndex = 1;
            this.cboxCL88.Text = "88";
            this.cboxCL88.UseVisualStyleBackColor = true;
            // 
            // cboxCL76
            // 
            this.cboxCL76.AutoSize = true;
            this.cboxCL76.Location = new System.Drawing.Point(240, 85);
            this.cboxCL76.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL76.Name = "cboxCL76";
            this.cboxCL76.Size = new System.Drawing.Size(45, 19);
            this.cboxCL76.TabIndex = 1;
            this.cboxCL76.Text = "76";
            this.cboxCL76.UseVisualStyleBackColor = true;
            // 
            // cboxCL64
            // 
            this.cboxCL64.AutoSize = true;
            this.cboxCL64.Location = new System.Drawing.Point(194, 64);
            this.cboxCL64.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL64.Name = "cboxCL64";
            this.cboxCL64.Size = new System.Drawing.Size(45, 19);
            this.cboxCL64.TabIndex = 1;
            this.cboxCL64.Text = "64";
            this.cboxCL64.UseVisualStyleBackColor = true;
            // 
            // cboxCL52
            // 
            this.cboxCL52.AutoSize = true;
            this.cboxCL52.Location = new System.Drawing.Point(149, 42);
            this.cboxCL52.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL52.Name = "cboxCL52";
            this.cboxCL52.Size = new System.Drawing.Size(45, 19);
            this.cboxCL52.TabIndex = 1;
            this.cboxCL52.Text = "52";
            this.cboxCL52.UseVisualStyleBackColor = true;
            // 
            // cboxCL40
            // 
            this.cboxCL40.AutoSize = true;
            this.cboxCL40.Location = new System.Drawing.Point(103, 21);
            this.cboxCL40.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL40.Name = "cboxCL40";
            this.cboxCL40.Size = new System.Drawing.Size(45, 19);
            this.cboxCL40.TabIndex = 1;
            this.cboxCL40.Text = "40";
            this.cboxCL40.UseVisualStyleBackColor = true;
            // 
            // cboxCL28
            // 
            this.cboxCL28.AutoSize = true;
            this.cboxCL28.Location = new System.Drawing.Point(11, 106);
            this.cboxCL28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL28.Name = "cboxCL28";
            this.cboxCL28.Size = new System.Drawing.Size(45, 19);
            this.cboxCL28.TabIndex = 1;
            this.cboxCL28.Text = "28";
            this.cboxCL28.UseVisualStyleBackColor = true;
            // 
            // cboxCL98
            // 
            this.cboxCL98.AutoSize = true;
            this.cboxCL98.Location = new System.Drawing.Point(331, 106);
            this.cboxCL98.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL98.Name = "cboxCL98";
            this.cboxCL98.Size = new System.Drawing.Size(45, 19);
            this.cboxCL98.TabIndex = 1;
            this.cboxCL98.Text = "98";
            this.cboxCL98.UseVisualStyleBackColor = true;
            // 
            // cboxCL86
            // 
            this.cboxCL86.AutoSize = true;
            this.cboxCL86.Location = new System.Drawing.Point(286, 85);
            this.cboxCL86.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL86.Name = "cboxCL86";
            this.cboxCL86.Size = new System.Drawing.Size(45, 19);
            this.cboxCL86.TabIndex = 1;
            this.cboxCL86.Text = "86";
            this.cboxCL86.UseVisualStyleBackColor = true;
            // 
            // cboxCL74
            // 
            this.cboxCL74.AutoSize = true;
            this.cboxCL74.Location = new System.Drawing.Point(240, 64);
            this.cboxCL74.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL74.Name = "cboxCL74";
            this.cboxCL74.Size = new System.Drawing.Size(45, 19);
            this.cboxCL74.TabIndex = 1;
            this.cboxCL74.Text = "74";
            this.cboxCL74.UseVisualStyleBackColor = true;
            // 
            // cboxCL62
            // 
            this.cboxCL62.AutoSize = true;
            this.cboxCL62.Location = new System.Drawing.Point(194, 42);
            this.cboxCL62.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL62.Name = "cboxCL62";
            this.cboxCL62.Size = new System.Drawing.Size(45, 19);
            this.cboxCL62.TabIndex = 1;
            this.cboxCL62.Text = "62";
            this.cboxCL62.UseVisualStyleBackColor = true;
            // 
            // cboxCL50
            // 
            this.cboxCL50.AutoSize = true;
            this.cboxCL50.Location = new System.Drawing.Point(149, 21);
            this.cboxCL50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL50.Name = "cboxCL50";
            this.cboxCL50.Size = new System.Drawing.Size(45, 19);
            this.cboxCL50.TabIndex = 1;
            this.cboxCL50.Text = "50";
            this.cboxCL50.UseVisualStyleBackColor = true;
            // 
            // cboxCL38
            // 
            this.cboxCL38.AutoSize = true;
            this.cboxCL38.Location = new System.Drawing.Point(57, 106);
            this.cboxCL38.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL38.Name = "cboxCL38";
            this.cboxCL38.Size = new System.Drawing.Size(45, 19);
            this.cboxCL38.TabIndex = 1;
            this.cboxCL38.Text = "38";
            this.cboxCL38.UseVisualStyleBackColor = true;
            // 
            // cboxCL26
            // 
            this.cboxCL26.AutoSize = true;
            this.cboxCL26.Location = new System.Drawing.Point(11, 85);
            this.cboxCL26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL26.Name = "cboxCL26";
            this.cboxCL26.Size = new System.Drawing.Size(45, 19);
            this.cboxCL26.TabIndex = 1;
            this.cboxCL26.Text = "26";
            this.cboxCL26.UseVisualStyleBackColor = true;
            // 
            // cboxCL96
            // 
            this.cboxCL96.AutoSize = true;
            this.cboxCL96.Location = new System.Drawing.Point(331, 85);
            this.cboxCL96.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL96.Name = "cboxCL96";
            this.cboxCL96.Size = new System.Drawing.Size(45, 19);
            this.cboxCL96.TabIndex = 1;
            this.cboxCL96.Text = "96";
            this.cboxCL96.UseVisualStyleBackColor = true;
            // 
            // cboxCL84
            // 
            this.cboxCL84.AutoSize = true;
            this.cboxCL84.Location = new System.Drawing.Point(286, 64);
            this.cboxCL84.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL84.Name = "cboxCL84";
            this.cboxCL84.Size = new System.Drawing.Size(45, 19);
            this.cboxCL84.TabIndex = 1;
            this.cboxCL84.Text = "84";
            this.cboxCL84.UseVisualStyleBackColor = true;
            // 
            // cboxCL72
            // 
            this.cboxCL72.AutoSize = true;
            this.cboxCL72.Location = new System.Drawing.Point(240, 42);
            this.cboxCL72.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL72.Name = "cboxCL72";
            this.cboxCL72.Size = new System.Drawing.Size(45, 19);
            this.cboxCL72.TabIndex = 1;
            this.cboxCL72.Text = "72";
            this.cboxCL72.UseVisualStyleBackColor = true;
            // 
            // cboxCL60
            // 
            this.cboxCL60.AutoSize = true;
            this.cboxCL60.Location = new System.Drawing.Point(194, 21);
            this.cboxCL60.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL60.Name = "cboxCL60";
            this.cboxCL60.Size = new System.Drawing.Size(45, 19);
            this.cboxCL60.TabIndex = 1;
            this.cboxCL60.Text = "60";
            this.cboxCL60.UseVisualStyleBackColor = true;
            // 
            // cboxCL48
            // 
            this.cboxCL48.AutoSize = true;
            this.cboxCL48.Location = new System.Drawing.Point(103, 106);
            this.cboxCL48.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL48.Name = "cboxCL48";
            this.cboxCL48.Size = new System.Drawing.Size(45, 19);
            this.cboxCL48.TabIndex = 1;
            this.cboxCL48.Text = "48";
            this.cboxCL48.UseVisualStyleBackColor = true;
            // 
            // cboxCL36
            // 
            this.cboxCL36.AutoSize = true;
            this.cboxCL36.Location = new System.Drawing.Point(57, 85);
            this.cboxCL36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL36.Name = "cboxCL36";
            this.cboxCL36.Size = new System.Drawing.Size(45, 19);
            this.cboxCL36.TabIndex = 1;
            this.cboxCL36.Text = "36";
            this.cboxCL36.UseVisualStyleBackColor = true;
            // 
            // cboxCL24
            // 
            this.cboxCL24.AutoSize = true;
            this.cboxCL24.Location = new System.Drawing.Point(11, 64);
            this.cboxCL24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL24.Name = "cboxCL24";
            this.cboxCL24.Size = new System.Drawing.Size(45, 19);
            this.cboxCL24.TabIndex = 1;
            this.cboxCL24.Text = "24";
            this.cboxCL24.UseVisualStyleBackColor = true;
            // 
            // cboxCL94
            // 
            this.cboxCL94.AutoSize = true;
            this.cboxCL94.Location = new System.Drawing.Point(331, 64);
            this.cboxCL94.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL94.Name = "cboxCL94";
            this.cboxCL94.Size = new System.Drawing.Size(45, 19);
            this.cboxCL94.TabIndex = 1;
            this.cboxCL94.Text = "94";
            this.cboxCL94.UseVisualStyleBackColor = true;
            // 
            // cboxCL82
            // 
            this.cboxCL82.AutoSize = true;
            this.cboxCL82.Location = new System.Drawing.Point(286, 42);
            this.cboxCL82.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL82.Name = "cboxCL82";
            this.cboxCL82.Size = new System.Drawing.Size(45, 19);
            this.cboxCL82.TabIndex = 1;
            this.cboxCL82.Text = "82";
            this.cboxCL82.UseVisualStyleBackColor = true;
            // 
            // cboxCL70
            // 
            this.cboxCL70.AutoSize = true;
            this.cboxCL70.Location = new System.Drawing.Point(240, 21);
            this.cboxCL70.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL70.Name = "cboxCL70";
            this.cboxCL70.Size = new System.Drawing.Size(45, 19);
            this.cboxCL70.TabIndex = 1;
            this.cboxCL70.Text = "70";
            this.cboxCL70.UseVisualStyleBackColor = true;
            // 
            // cboxCL58
            // 
            this.cboxCL58.AutoSize = true;
            this.cboxCL58.Location = new System.Drawing.Point(149, 106);
            this.cboxCL58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL58.Name = "cboxCL58";
            this.cboxCL58.Size = new System.Drawing.Size(45, 19);
            this.cboxCL58.TabIndex = 1;
            this.cboxCL58.Text = "58";
            this.cboxCL58.UseVisualStyleBackColor = true;
            // 
            // cboxCL46
            // 
            this.cboxCL46.AutoSize = true;
            this.cboxCL46.Location = new System.Drawing.Point(103, 85);
            this.cboxCL46.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL46.Name = "cboxCL46";
            this.cboxCL46.Size = new System.Drawing.Size(45, 19);
            this.cboxCL46.TabIndex = 1;
            this.cboxCL46.Text = "46";
            this.cboxCL46.UseVisualStyleBackColor = true;
            // 
            // cboxCL34
            // 
            this.cboxCL34.AutoSize = true;
            this.cboxCL34.Location = new System.Drawing.Point(57, 64);
            this.cboxCL34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL34.Name = "cboxCL34";
            this.cboxCL34.Size = new System.Drawing.Size(45, 19);
            this.cboxCL34.TabIndex = 1;
            this.cboxCL34.Text = "34";
            this.cboxCL34.UseVisualStyleBackColor = true;
            // 
            // cboxCL22
            // 
            this.cboxCL22.AutoSize = true;
            this.cboxCL22.Location = new System.Drawing.Point(11, 42);
            this.cboxCL22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL22.Name = "cboxCL22";
            this.cboxCL22.Size = new System.Drawing.Size(45, 19);
            this.cboxCL22.TabIndex = 1;
            this.cboxCL22.Text = "22";
            this.cboxCL22.UseVisualStyleBackColor = true;
            // 
            // cboxCL92
            // 
            this.cboxCL92.AutoSize = true;
            this.cboxCL92.Location = new System.Drawing.Point(331, 42);
            this.cboxCL92.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL92.Name = "cboxCL92";
            this.cboxCL92.Size = new System.Drawing.Size(45, 19);
            this.cboxCL92.TabIndex = 0;
            this.cboxCL92.Text = "92";
            this.cboxCL92.UseVisualStyleBackColor = true;
            // 
            // cboxCL80
            // 
            this.cboxCL80.AutoSize = true;
            this.cboxCL80.Location = new System.Drawing.Point(286, 21);
            this.cboxCL80.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL80.Name = "cboxCL80";
            this.cboxCL80.Size = new System.Drawing.Size(45, 19);
            this.cboxCL80.TabIndex = 0;
            this.cboxCL80.Text = "80";
            this.cboxCL80.UseVisualStyleBackColor = true;
            // 
            // cboxCL68
            // 
            this.cboxCL68.AutoSize = true;
            this.cboxCL68.Location = new System.Drawing.Point(194, 106);
            this.cboxCL68.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL68.Name = "cboxCL68";
            this.cboxCL68.Size = new System.Drawing.Size(45, 19);
            this.cboxCL68.TabIndex = 0;
            this.cboxCL68.Text = "68";
            this.cboxCL68.UseVisualStyleBackColor = true;
            // 
            // cboxCL56
            // 
            this.cboxCL56.AutoSize = true;
            this.cboxCL56.Location = new System.Drawing.Point(149, 85);
            this.cboxCL56.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL56.Name = "cboxCL56";
            this.cboxCL56.Size = new System.Drawing.Size(45, 19);
            this.cboxCL56.TabIndex = 0;
            this.cboxCL56.Text = "56";
            this.cboxCL56.UseVisualStyleBackColor = true;
            // 
            // cboxCL44
            // 
            this.cboxCL44.AutoSize = true;
            this.cboxCL44.Location = new System.Drawing.Point(103, 64);
            this.cboxCL44.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL44.Name = "cboxCL44";
            this.cboxCL44.Size = new System.Drawing.Size(45, 19);
            this.cboxCL44.TabIndex = 0;
            this.cboxCL44.Text = "44";
            this.cboxCL44.UseVisualStyleBackColor = true;
            // 
            // cboxCL32
            // 
            this.cboxCL32.AutoSize = true;
            this.cboxCL32.Location = new System.Drawing.Point(57, 42);
            this.cboxCL32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL32.Name = "cboxCL32";
            this.cboxCL32.Size = new System.Drawing.Size(45, 19);
            this.cboxCL32.TabIndex = 0;
            this.cboxCL32.Text = "32";
            this.cboxCL32.UseVisualStyleBackColor = true;
            // 
            // cboxCL20
            // 
            this.cboxCL20.AutoSize = true;
            this.cboxCL20.Location = new System.Drawing.Point(11, 21);
            this.cboxCL20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxCL20.Name = "cboxCL20";
            this.cboxCL20.Size = new System.Drawing.Size(45, 19);
            this.cboxCL20.TabIndex = 0;
            this.cboxCL20.Text = "20";
            this.cboxCL20.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxSpdMegaTransfers);
            this.groupBox1.Controls.Add(this.tboxSpdFrequency);
            this.groupBox1.Controls.Add(this.updnMinCycleTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(600, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // tboxSpdMegaTransfers
            // 
            this.tboxSpdMegaTransfers.Enabled = false;
            this.tboxSpdMegaTransfers.Location = new System.Drawing.Point(338, 14);
            this.tboxSpdMegaTransfers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxSpdMegaTransfers.Name = "tboxSpdMegaTransfers";
            this.tboxSpdMegaTransfers.Size = new System.Drawing.Size(114, 25);
            this.tboxSpdMegaTransfers.TabIndex = 2;
            // 
            // tboxSpdFrequency
            // 
            this.tboxSpdFrequency.Enabled = false;
            this.tboxSpdFrequency.Location = new System.Drawing.Point(217, 14);
            this.tboxSpdFrequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxSpdFrequency.Name = "tboxSpdFrequency";
            this.tboxSpdFrequency.Size = new System.Drawing.Size(114, 25);
            this.tboxSpdFrequency.TabIndex = 2;
            // 
            // updnMinCycleTime
            // 
            this.updnMinCycleTime.Location = new System.Drawing.Point(128, 15);
            this.updnMinCycleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updnMinCycleTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.updnMinCycleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnMinCycleTime.Name = "updnMinCycleTime";
            this.updnMinCycleTime.Size = new System.Drawing.Size(82, 25);
            this.updnMinCycleTime.TabIndex = 1;
            this.updnMinCycleTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnMinCycleTime.ValueChanged += new System.EventHandler(this.updnMinCycleTime_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Min Cycle Time:";
            // 
            // tabPageSPD_XMP1
            // 
            this.tabPageSPD_XMP1.Controls.Add(this.groupBox8);
            this.tabPageSPD_XMP1.Controls.Add(this.groupBox7);
            this.tabPageSPD_XMP1.Controls.Add(this.groupBox6);
            this.tabPageSPD_XMP1.Controls.Add(this.groupBox5);
            this.tabPageSPD_XMP1.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_XMP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_XMP1.Name = "tabPageSPD_XMP1";
            this.tabPageSPD_XMP1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_XMP1.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_XMP1.TabIndex = 1;
            this.tabPageSPD_XMP1.Text = "XMP1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tRTP);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tCCD_S_WTR);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tCCD_L_WTR);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tFAW);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tCCD_L_WR2);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tCCD_L_WR);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tCCD_L);
            this.groupBox8.Controls.Add(this.tboxXMP1Lmt_tRRD_L);
            this.groupBox8.Controls.Add(this.lblXMP1_tRTP);
            this.groupBox8.Controls.Add(this.lblXMP1_tCCD_S_WTR);
            this.groupBox8.Controls.Add(this.lblXMP1_tCCD_L_WTR);
            this.groupBox8.Controls.Add(this.lblXMP1_tFAW);
            this.groupBox8.Controls.Add(this.lblXMP1_tCCD_L_WR2);
            this.groupBox8.Controls.Add(this.lblXMP1_tCCD_L_WR);
            this.groupBox8.Controls.Add(this.lblXMP1_tCCD_L);
            this.groupBox8.Controls.Add(this.lblXMP1_tRRD_L);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRTP);
            this.groupBox8.Controls.Add(this.tboxXMP1_tCCD_S_WTR);
            this.groupBox8.Controls.Add(this.tboxXMP1_tCCD_L_WTR);
            this.groupBox8.Controls.Add(this.tboxXMP1_tFAW);
            this.groupBox8.Controls.Add(this.tboxXMP1_tCCD_L_WR2);
            this.groupBox8.Controls.Add(this.tboxXMP1_tCCD_L_WR);
            this.groupBox8.Controls.Add(this.tboxXMP1_tCCD_L);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRRD_L);
            this.groupBox8.Controls.Add(this.label49);
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.label51);
            this.groupBox8.Controls.Add(this.label52);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Controls.Add(this.label54);
            this.groupBox8.Controls.Add(this.label55);
            this.groupBox8.Controls.Add(this.label56);
            this.groupBox8.Controls.Add(this.lblXMP1_tRFCsb);
            this.groupBox8.Controls.Add(this.lblXMP1_tRFC2);
            this.groupBox8.Controls.Add(this.lblXMP1_tRFC1);
            this.groupBox8.Controls.Add(this.lblXMP1_tWR);
            this.groupBox8.Controls.Add(this.lblXMP1_tRC);
            this.groupBox8.Controls.Add(this.lblXMP1_tRAS);
            this.groupBox8.Controls.Add(this.lblXMP1_tRP);
            this.groupBox8.Controls.Add(this.lblXMP1_tRCD);
            this.groupBox8.Controls.Add(this.lblXMP1_tAA);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRFCsb);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRFC2);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRFC1);
            this.groupBox8.Controls.Add(this.tboxXMP1_tWR);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRC);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRAS);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRP);
            this.groupBox8.Controls.Add(this.label66);
            this.groupBox8.Controls.Add(this.tboxXMP1_tRCD);
            this.groupBox8.Controls.Add(this.tboxXMP1_tAA);
            this.groupBox8.Controls.Add(this.label67);
            this.groupBox8.Controls.Add(this.label68);
            this.groupBox8.Controls.Add(this.label69);
            this.groupBox8.Controls.Add(this.label70);
            this.groupBox8.Controls.Add(this.label71);
            this.groupBox8.Controls.Add(this.label72);
            this.groupBox8.Controls.Add(this.label73);
            this.groupBox8.Controls.Add(this.label74);
            this.groupBox8.Controls.Add(this.label75);
            this.groupBox8.Controls.Add(this.label76);
            this.groupBox8.Controls.Add(this.label77);
            this.groupBox8.Controls.Add(this.label78);
            this.groupBox8.Controls.Add(this.label79);
            this.groupBox8.Controls.Add(this.label80);
            this.groupBox8.Controls.Add(this.label81);
            this.groupBox8.Location = new System.Drawing.Point(7, 260);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(600, 296);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Timings";
            // 
            // tboxXMP1Lmt_tRTP
            // 
            this.tboxXMP1Lmt_tRTP.Location = new System.Drawing.Point(427, 231);
            this.tboxXMP1Lmt_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tRTP.Name = "tboxXMP1Lmt_tRTP";
            this.tboxXMP1Lmt_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tRTP.TabIndex = 58;
            // 
            // tboxXMP1Lmt_tCCD_S_WTR
            // 
            this.tboxXMP1Lmt_tCCD_S_WTR.Location = new System.Drawing.Point(427, 204);
            this.tboxXMP1Lmt_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tCCD_S_WTR.Name = "tboxXMP1Lmt_tCCD_S_WTR";
            this.tboxXMP1Lmt_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tCCD_S_WTR.TabIndex = 59;
            // 
            // tboxXMP1Lmt_tCCD_L_WTR
            // 
            this.tboxXMP1Lmt_tCCD_L_WTR.Location = new System.Drawing.Point(427, 176);
            this.tboxXMP1Lmt_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tCCD_L_WTR.Name = "tboxXMP1Lmt_tCCD_L_WTR";
            this.tboxXMP1Lmt_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tCCD_L_WTR.TabIndex = 56;
            // 
            // tboxXMP1Lmt_tFAW
            // 
            this.tboxXMP1Lmt_tFAW.Location = new System.Drawing.Point(427, 149);
            this.tboxXMP1Lmt_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tFAW.Name = "tboxXMP1Lmt_tFAW";
            this.tboxXMP1Lmt_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tFAW.TabIndex = 57;
            // 
            // tboxXMP1Lmt_tCCD_L_WR2
            // 
            this.tboxXMP1Lmt_tCCD_L_WR2.Location = new System.Drawing.Point(427, 121);
            this.tboxXMP1Lmt_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tCCD_L_WR2.Name = "tboxXMP1Lmt_tCCD_L_WR2";
            this.tboxXMP1Lmt_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tCCD_L_WR2.TabIndex = 54;
            // 
            // tboxXMP1Lmt_tCCD_L_WR
            // 
            this.tboxXMP1Lmt_tCCD_L_WR.Location = new System.Drawing.Point(427, 94);
            this.tboxXMP1Lmt_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tCCD_L_WR.Name = "tboxXMP1Lmt_tCCD_L_WR";
            this.tboxXMP1Lmt_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tCCD_L_WR.TabIndex = 55;
            // 
            // tboxXMP1Lmt_tCCD_L
            // 
            this.tboxXMP1Lmt_tCCD_L.Location = new System.Drawing.Point(427, 66);
            this.tboxXMP1Lmt_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tCCD_L.Name = "tboxXMP1Lmt_tCCD_L";
            this.tboxXMP1Lmt_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tCCD_L.TabIndex = 53;
            // 
            // tboxXMP1Lmt_tRRD_L
            // 
            this.tboxXMP1Lmt_tRRD_L.Location = new System.Drawing.Point(427, 39);
            this.tboxXMP1Lmt_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1Lmt_tRRD_L.Name = "tboxXMP1Lmt_tRRD_L";
            this.tboxXMP1Lmt_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1Lmt_tRRD_L.TabIndex = 52;
            // 
            // lblXMP1_tRTP
            // 
            this.lblXMP1_tRTP.AutoSize = true;
            this.lblXMP1_tRTP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRTP.Location = new System.Drawing.Point(502, 235);
            this.lblXMP1_tRTP.Name = "lblXMP1_tRTP";
            this.lblXMP1_tRTP.Size = new System.Drawing.Size(39, 20);
            this.lblXMP1_tRTP.TabIndex = 50;
            this.lblXMP1_tRTP.Text = "tRTP";
            // 
            // lblXMP1_tCCD_S_WTR
            // 
            this.lblXMP1_tCCD_S_WTR.AutoSize = true;
            this.lblXMP1_tCCD_S_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tCCD_S_WTR.Location = new System.Drawing.Point(502, 212);
            this.lblXMP1_tCCD_S_WTR.Name = "lblXMP1_tCCD_S_WTR";
            this.lblXMP1_tCCD_S_WTR.Size = new System.Drawing.Size(94, 20);
            this.lblXMP1_tCCD_S_WTR.TabIndex = 51;
            this.lblXMP1_tCCD_S_WTR.Text = "tCCD_S_WTR";
            // 
            // lblXMP1_tCCD_L_WTR
            // 
            this.lblXMP1_tCCD_L_WTR.AutoSize = true;
            this.lblXMP1_tCCD_L_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tCCD_L_WTR.Location = new System.Drawing.Point(502, 185);
            this.lblXMP1_tCCD_L_WTR.Name = "lblXMP1_tCCD_L_WTR";
            this.lblXMP1_tCCD_L_WTR.Size = new System.Drawing.Size(93, 20);
            this.lblXMP1_tCCD_L_WTR.TabIndex = 47;
            this.lblXMP1_tCCD_L_WTR.Text = "tCCD_L_WTR";
            // 
            // lblXMP1_tFAW
            // 
            this.lblXMP1_tFAW.AutoSize = true;
            this.lblXMP1_tFAW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tFAW.Location = new System.Drawing.Point(502, 158);
            this.lblXMP1_tFAW.Name = "lblXMP1_tFAW";
            this.lblXMP1_tFAW.Size = new System.Drawing.Size(43, 20);
            this.lblXMP1_tFAW.TabIndex = 48;
            this.lblXMP1_tFAW.Text = "tFAW";
            // 
            // lblXMP1_tCCD_L_WR2
            // 
            this.lblXMP1_tCCD_L_WR2.AutoSize = true;
            this.lblXMP1_tCCD_L_WR2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tCCD_L_WR2.Location = new System.Drawing.Point(502, 129);
            this.lblXMP1_tCCD_L_WR2.Name = "lblXMP1_tCCD_L_WR2";
            this.lblXMP1_tCCD_L_WR2.Size = new System.Drawing.Size(93, 20);
            this.lblXMP1_tCCD_L_WR2.TabIndex = 49;
            this.lblXMP1_tCCD_L_WR2.Text = "tCCD_L_WR2";
            // 
            // lblXMP1_tCCD_L_WR
            // 
            this.lblXMP1_tCCD_L_WR.AutoSize = true;
            this.lblXMP1_tCCD_L_WR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tCCD_L_WR.Location = new System.Drawing.Point(502, 101);
            this.lblXMP1_tCCD_L_WR.Name = "lblXMP1_tCCD_L_WR";
            this.lblXMP1_tCCD_L_WR.Size = new System.Drawing.Size(85, 20);
            this.lblXMP1_tCCD_L_WR.TabIndex = 44;
            this.lblXMP1_tCCD_L_WR.Text = "tCCD_L_WR";
            // 
            // lblXMP1_tCCD_L
            // 
            this.lblXMP1_tCCD_L.AutoSize = true;
            this.lblXMP1_tCCD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tCCD_L.Location = new System.Drawing.Point(502, 74);
            this.lblXMP1_tCCD_L.Name = "lblXMP1_tCCD_L";
            this.lblXMP1_tCCD_L.Size = new System.Drawing.Size(56, 20);
            this.lblXMP1_tCCD_L.TabIndex = 45;
            this.lblXMP1_tCCD_L.Text = "tCCD_L";
            // 
            // lblXMP1_tRRD_L
            // 
            this.lblXMP1_tRRD_L.AutoSize = true;
            this.lblXMP1_tRRD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRRD_L.Location = new System.Drawing.Point(502, 46);
            this.lblXMP1_tRRD_L.Name = "lblXMP1_tRRD_L";
            this.lblXMP1_tRRD_L.Size = new System.Drawing.Size(56, 20);
            this.lblXMP1_tRRD_L.TabIndex = 46;
            this.lblXMP1_tRRD_L.Text = "tRRD_L";
            // 
            // tboxXMP1_tRTP
            // 
            this.tboxXMP1_tRTP.Location = new System.Drawing.Point(350, 232);
            this.tboxXMP1_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRTP.Name = "tboxXMP1_tRTP";
            this.tboxXMP1_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRTP.TabIndex = 42;
            // 
            // tboxXMP1_tCCD_S_WTR
            // 
            this.tboxXMP1_tCCD_S_WTR.Location = new System.Drawing.Point(350, 205);
            this.tboxXMP1_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tCCD_S_WTR.Name = "tboxXMP1_tCCD_S_WTR";
            this.tboxXMP1_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tCCD_S_WTR.TabIndex = 43;
            // 
            // tboxXMP1_tCCD_L_WTR
            // 
            this.tboxXMP1_tCCD_L_WTR.Location = new System.Drawing.Point(350, 178);
            this.tboxXMP1_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tCCD_L_WTR.Name = "tboxXMP1_tCCD_L_WTR";
            this.tboxXMP1_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tCCD_L_WTR.TabIndex = 40;
            // 
            // tboxXMP1_tFAW
            // 
            this.tboxXMP1_tFAW.Location = new System.Drawing.Point(350, 150);
            this.tboxXMP1_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tFAW.Name = "tboxXMP1_tFAW";
            this.tboxXMP1_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tFAW.TabIndex = 41;
            // 
            // tboxXMP1_tCCD_L_WR2
            // 
            this.tboxXMP1_tCCD_L_WR2.Location = new System.Drawing.Point(350, 122);
            this.tboxXMP1_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tCCD_L_WR2.Name = "tboxXMP1_tCCD_L_WR2";
            this.tboxXMP1_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tCCD_L_WR2.TabIndex = 38;
            // 
            // tboxXMP1_tCCD_L_WR
            // 
            this.tboxXMP1_tCCD_L_WR.Location = new System.Drawing.Point(350, 95);
            this.tboxXMP1_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tCCD_L_WR.Name = "tboxXMP1_tCCD_L_WR";
            this.tboxXMP1_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tCCD_L_WR.TabIndex = 39;
            // 
            // tboxXMP1_tCCD_L
            // 
            this.tboxXMP1_tCCD_L.Location = new System.Drawing.Point(350, 68);
            this.tboxXMP1_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tCCD_L.Name = "tboxXMP1_tCCD_L";
            this.tboxXMP1_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tCCD_L.TabIndex = 31;
            // 
            // tboxXMP1_tRRD_L
            // 
            this.tboxXMP1_tRRD_L.Location = new System.Drawing.Point(350, 40);
            this.tboxXMP1_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRRD_L.Name = "tboxXMP1_tRRD_L";
            this.tboxXMP1_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRRD_L.TabIndex = 30;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(305, 236);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(46, 20);
            this.label49.TabIndex = 36;
            this.label49.Text = "tRTP :";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(257, 209);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(101, 20);
            this.label50.TabIndex = 37;
            this.label50.Text = "tCCD_S_WTR :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(257, 181);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(100, 20);
            this.label51.TabIndex = 33;
            this.label51.Text = "tCCD_L_WTR :";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(298, 154);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(50, 20);
            this.label52.TabIndex = 34;
            this.label52.Text = "tFAW :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(256, 125);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 20);
            this.label53.TabIndex = 35;
            this.label53.Text = "tCCD_L_WR2 :";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(263, 99);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(92, 20);
            this.label54.TabIndex = 29;
            this.label54.Text = "tCCD_L_WR :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(289, 71);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(63, 20);
            this.label55.TabIndex = 32;
            this.label55.Text = "tCCD_L :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(289, 44);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(63, 20);
            this.label56.TabIndex = 28;
            this.label56.Text = "tRRD_L :";
            // 
            // lblXMP1_tRFCsb
            // 
            this.lblXMP1_tRFCsb.AutoSize = true;
            this.lblXMP1_tRFCsb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRFCsb.Location = new System.Drawing.Point(159, 268);
            this.lblXMP1_tRFCsb.Name = "lblXMP1_tRFCsb";
            this.lblXMP1_tRFCsb.Size = new System.Drawing.Size(54, 20);
            this.lblXMP1_tRFCsb.TabIndex = 25;
            this.lblXMP1_tRFCsb.Text = "tRFCsb";
            // 
            // lblXMP1_tRFC2
            // 
            this.lblXMP1_tRFC2.AutoSize = true;
            this.lblXMP1_tRFC2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRFC2.Location = new System.Drawing.Point(159, 240);
            this.lblXMP1_tRFC2.Name = "lblXMP1_tRFC2";
            this.lblXMP1_tRFC2.Size = new System.Drawing.Size(47, 20);
            this.lblXMP1_tRFC2.TabIndex = 26;
            this.lblXMP1_tRFC2.Text = "tRFC2";
            // 
            // lblXMP1_tRFC1
            // 
            this.lblXMP1_tRFC1.AutoSize = true;
            this.lblXMP1_tRFC1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRFC1.Location = new System.Drawing.Point(159, 212);
            this.lblXMP1_tRFC1.Name = "lblXMP1_tRFC1";
            this.lblXMP1_tRFC1.Size = new System.Drawing.Size(47, 20);
            this.lblXMP1_tRFC1.TabIndex = 27;
            this.lblXMP1_tRFC1.Text = "tRFC1";
            // 
            // lblXMP1_tWR
            // 
            this.lblXMP1_tWR.AutoSize = true;
            this.lblXMP1_tWR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tWR.Location = new System.Drawing.Point(159, 185);
            this.lblXMP1_tWR.Name = "lblXMP1_tWR";
            this.lblXMP1_tWR.Size = new System.Drawing.Size(37, 20);
            this.lblXMP1_tWR.TabIndex = 22;
            this.lblXMP1_tWR.Text = "tWR";
            // 
            // lblXMP1_tRC
            // 
            this.lblXMP1_tRC.AutoSize = true;
            this.lblXMP1_tRC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRC.Location = new System.Drawing.Point(159, 158);
            this.lblXMP1_tRC.Name = "lblXMP1_tRC";
            this.lblXMP1_tRC.Size = new System.Drawing.Size(32, 20);
            this.lblXMP1_tRC.TabIndex = 23;
            this.lblXMP1_tRC.Text = "tRC";
            // 
            // lblXMP1_tRAS
            // 
            this.lblXMP1_tRAS.AutoSize = true;
            this.lblXMP1_tRAS.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRAS.Location = new System.Drawing.Point(159, 129);
            this.lblXMP1_tRAS.Name = "lblXMP1_tRAS";
            this.lblXMP1_tRAS.Size = new System.Drawing.Size(41, 20);
            this.lblXMP1_tRAS.TabIndex = 24;
            this.lblXMP1_tRAS.Text = "tRAS";
            // 
            // lblXMP1_tRP
            // 
            this.lblXMP1_tRP.AutoSize = true;
            this.lblXMP1_tRP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRP.Location = new System.Drawing.Point(159, 101);
            this.lblXMP1_tRP.Name = "lblXMP1_tRP";
            this.lblXMP1_tRP.Size = new System.Drawing.Size(31, 20);
            this.lblXMP1_tRP.TabIndex = 19;
            this.lblXMP1_tRP.Text = "tRP";
            // 
            // lblXMP1_tRCD
            // 
            this.lblXMP1_tRCD.AutoSize = true;
            this.lblXMP1_tRCD.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tRCD.Location = new System.Drawing.Point(159, 74);
            this.lblXMP1_tRCD.Name = "lblXMP1_tRCD";
            this.lblXMP1_tRCD.Size = new System.Drawing.Size(43, 20);
            this.lblXMP1_tRCD.TabIndex = 20;
            this.lblXMP1_tRCD.Text = "tRCD";
            // 
            // lblXMP1_tAA
            // 
            this.lblXMP1_tAA.AutoSize = true;
            this.lblXMP1_tAA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP1_tAA.Location = new System.Drawing.Point(159, 46);
            this.lblXMP1_tAA.Name = "lblXMP1_tAA";
            this.lblXMP1_tAA.Size = new System.Drawing.Size(34, 20);
            this.lblXMP1_tAA.TabIndex = 21;
            this.lblXMP1_tAA.Text = "tAA";
            // 
            // tboxXMP1_tRFCsb
            // 
            this.tboxXMP1_tRFCsb.Location = new System.Drawing.Point(83, 262);
            this.tboxXMP1_tRFCsb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRFCsb.Name = "tboxXMP1_tRFCsb";
            this.tboxXMP1_tRFCsb.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRFCsb.TabIndex = 18;
            // 
            // tboxXMP1_tRFC2
            // 
            this.tboxXMP1_tRFC2.Location = new System.Drawing.Point(83, 235);
            this.tboxXMP1_tRFC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRFC2.Name = "tboxXMP1_tRFC2";
            this.tboxXMP1_tRFC2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRFC2.TabIndex = 16;
            // 
            // tboxXMP1_tRFC1
            // 
            this.tboxXMP1_tRFC1.Location = new System.Drawing.Point(83, 208);
            this.tboxXMP1_tRFC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRFC1.Name = "tboxXMP1_tRFC1";
            this.tboxXMP1_tRFC1.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRFC1.TabIndex = 17;
            // 
            // tboxXMP1_tWR
            // 
            this.tboxXMP1_tWR.Location = new System.Drawing.Point(83, 180);
            this.tboxXMP1_tWR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tWR.Name = "tboxXMP1_tWR";
            this.tboxXMP1_tWR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tWR.TabIndex = 14;
            // 
            // tboxXMP1_tRC
            // 
            this.tboxXMP1_tRC.Location = new System.Drawing.Point(83, 152);
            this.tboxXMP1_tRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRC.Name = "tboxXMP1_tRC";
            this.tboxXMP1_tRC.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRC.TabIndex = 15;
            // 
            // tboxXMP1_tRAS
            // 
            this.tboxXMP1_tRAS.Location = new System.Drawing.Point(83, 125);
            this.tboxXMP1_tRAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRAS.Name = "tboxXMP1_tRAS";
            this.tboxXMP1_tRAS.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRAS.TabIndex = 12;
            // 
            // tboxXMP1_tRP
            // 
            this.tboxXMP1_tRP.Location = new System.Drawing.Point(83, 98);
            this.tboxXMP1_tRP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRP.Name = "tboxXMP1_tRP";
            this.tboxXMP1_tRP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRP.TabIndex = 13;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(7, 266);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(61, 20);
            this.label66.TabIndex = 9;
            this.label66.Text = "tRFCsb :";
            // 
            // tboxXMP1_tRCD
            // 
            this.tboxXMP1_tRCD.Location = new System.Drawing.Point(83, 70);
            this.tboxXMP1_tRCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tRCD.Name = "tboxXMP1_tRCD";
            this.tboxXMP1_tRCD.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tRCD.TabIndex = 2;
            // 
            // tboxXMP1_tAA
            // 
            this.tboxXMP1_tAA.Location = new System.Drawing.Point(83, 42);
            this.tboxXMP1_tAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_tAA.Name = "tboxXMP1_tAA";
            this.tboxXMP1_tAA.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP1_tAA.TabIndex = 2;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(13, 239);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(54, 20);
            this.label67.TabIndex = 10;
            this.label67.Text = "tRFC2 :";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(13, 211);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(54, 20);
            this.label68.TabIndex = 11;
            this.label68.Text = "tRFC1 :";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(22, 184);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(44, 20);
            this.label69.TabIndex = 6;
            this.label69.Text = "tWR :";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(22, 156);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(39, 20);
            this.label70.TabIndex = 7;
            this.label70.Text = "tRC :";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(22, 128);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(48, 20);
            this.label71.TabIndex = 8;
            this.label71.Text = "tRAS :";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label72.Location = new System.Drawing.Point(502, 21);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(48, 19);
            this.label72.TabIndex = 3;
            this.label72.Text = "Ticks";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(416, 24);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(88, 16);
            this.label73.TabIndex = 4;
            this.label73.Text = "LowCLK Limit";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label74.Location = new System.Drawing.Point(343, 21);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(82, 19);
            this.label74.TabIndex = 4;
            this.label74.Text = "Value (ps)";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label75.Location = new System.Drawing.Point(282, 21);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(53, 19);
            this.label75.TabIndex = 5;
            this.label75.Text = "Name";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label76.Location = new System.Drawing.Point(153, 21);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(48, 19);
            this.label76.TabIndex = 2;
            this.label76.Text = "Ticks";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(80, 21);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(82, 19);
            this.label77.TabIndex = 2;
            this.label77.Text = "Value (ps)";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(22, 101);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(38, 20);
            this.label78.TabIndex = 2;
            this.label78.Text = "tRP :";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(22, 74);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(50, 20);
            this.label79.TabIndex = 2;
            this.label79.Text = "tRCD :";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(22, 46);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(41, 20);
            this.label80.TabIndex = 2;
            this.label80.Text = "tAA :";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(19, 21);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(53, 19);
            this.label81.TabIndex = 2;
            this.label81.Text = "Name";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tboxXMP1_VMEM);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.tboxXMP1_VPP);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.tboxXMP1_VDDQ);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.tboxXMP1_VDD);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Location = new System.Drawing.Point(7, 81);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(600, 48);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Voltages";
            // 
            // tboxXMP1_VMEM
            // 
            this.tboxXMP1_VMEM.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP1_VMEM.Location = new System.Drawing.Point(514, 15);
            this.tboxXMP1_VMEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_VMEM.Name = "tboxXMP1_VMEM";
            this.tboxXMP1_VMEM.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP1_VMEM.TabIndex = 20;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(422, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 15);
            this.label32.TabIndex = 19;
            this.label32.Text = "VMEMCTRL:";
            // 
            // tboxXMP1_VPP
            // 
            this.tboxXMP1_VPP.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP1_VPP.Location = new System.Drawing.Point(331, 15);
            this.tboxXMP1_VPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_VPP.Name = "tboxXMP1_VPP";
            this.tboxXMP1_VPP.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP1_VPP.TabIndex = 18;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(281, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 15);
            this.label31.TabIndex = 17;
            this.label31.Text = "VPP:";
            // 
            // tboxXMP1_VDDQ
            // 
            this.tboxXMP1_VDDQ.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP1_VDDQ.Location = new System.Drawing.Point(189, 15);
            this.tboxXMP1_VDDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_VDDQ.Name = "tboxXMP1_VDDQ";
            this.tboxXMP1_VDDQ.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP1_VDDQ.TabIndex = 16;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(138, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(52, 15);
            this.label30.TabIndex = 15;
            this.label30.Text = "VDDQ:";
            // 
            // tboxXMP1_VDD
            // 
            this.tboxXMP1_VDD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP1_VDD.Location = new System.Drawing.Point(56, 15);
            this.tboxXMP1_VDD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_VDD.Name = "tboxXMP1_VDD";
            this.tboxXMP1_VDD.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP1_VDD.TabIndex = 14;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 15);
            this.label29.TabIndex = 0;
            this.label29.Text = "VDD:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboxXMP1_CL90);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL78);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL66);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL54);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL42);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL30);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL88);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL76);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL64);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL52);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL40);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL28);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL98);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL86);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL74);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL62);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL50);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL38);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL26);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL96);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL84);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL72);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL60);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL48);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL36);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL24);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL94);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL82);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL70);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL58);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL46);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL34);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL22);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL92);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL80);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL68);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL56);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL44);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL32);
            this.groupBox6.Controls.Add(this.cboxXMP1_CL20);
            this.groupBox6.Location = new System.Drawing.Point(7, 130);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(600, 130);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Supported CAS Latencies";
            // 
            // cboxXMP1_CL90
            // 
            this.cboxXMP1_CL90.AutoSize = true;
            this.cboxXMP1_CL90.Location = new System.Drawing.Point(331, 21);
            this.cboxXMP1_CL90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL90.Name = "cboxXMP1_CL90";
            this.cboxXMP1_CL90.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL90.TabIndex = 1;
            this.cboxXMP1_CL90.Text = "90";
            this.cboxXMP1_CL90.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL78
            // 
            this.cboxXMP1_CL78.AutoSize = true;
            this.cboxXMP1_CL78.Location = new System.Drawing.Point(240, 106);
            this.cboxXMP1_CL78.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL78.Name = "cboxXMP1_CL78";
            this.cboxXMP1_CL78.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL78.TabIndex = 1;
            this.cboxXMP1_CL78.Text = "78";
            this.cboxXMP1_CL78.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL66
            // 
            this.cboxXMP1_CL66.AutoSize = true;
            this.cboxXMP1_CL66.Location = new System.Drawing.Point(194, 85);
            this.cboxXMP1_CL66.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL66.Name = "cboxXMP1_CL66";
            this.cboxXMP1_CL66.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL66.TabIndex = 1;
            this.cboxXMP1_CL66.Text = "66";
            this.cboxXMP1_CL66.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL54
            // 
            this.cboxXMP1_CL54.AutoSize = true;
            this.cboxXMP1_CL54.Location = new System.Drawing.Point(149, 64);
            this.cboxXMP1_CL54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL54.Name = "cboxXMP1_CL54";
            this.cboxXMP1_CL54.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL54.TabIndex = 1;
            this.cboxXMP1_CL54.Text = "54";
            this.cboxXMP1_CL54.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL42
            // 
            this.cboxXMP1_CL42.AutoSize = true;
            this.cboxXMP1_CL42.Location = new System.Drawing.Point(103, 42);
            this.cboxXMP1_CL42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL42.Name = "cboxXMP1_CL42";
            this.cboxXMP1_CL42.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL42.TabIndex = 1;
            this.cboxXMP1_CL42.Text = "42";
            this.cboxXMP1_CL42.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL30
            // 
            this.cboxXMP1_CL30.AutoSize = true;
            this.cboxXMP1_CL30.Location = new System.Drawing.Point(57, 21);
            this.cboxXMP1_CL30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL30.Name = "cboxXMP1_CL30";
            this.cboxXMP1_CL30.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL30.TabIndex = 1;
            this.cboxXMP1_CL30.Text = "30";
            this.cboxXMP1_CL30.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL88
            // 
            this.cboxXMP1_CL88.AutoSize = true;
            this.cboxXMP1_CL88.Location = new System.Drawing.Point(286, 106);
            this.cboxXMP1_CL88.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL88.Name = "cboxXMP1_CL88";
            this.cboxXMP1_CL88.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL88.TabIndex = 1;
            this.cboxXMP1_CL88.Text = "88";
            this.cboxXMP1_CL88.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL76
            // 
            this.cboxXMP1_CL76.AutoSize = true;
            this.cboxXMP1_CL76.Location = new System.Drawing.Point(240, 85);
            this.cboxXMP1_CL76.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL76.Name = "cboxXMP1_CL76";
            this.cboxXMP1_CL76.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL76.TabIndex = 1;
            this.cboxXMP1_CL76.Text = "76";
            this.cboxXMP1_CL76.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL64
            // 
            this.cboxXMP1_CL64.AutoSize = true;
            this.cboxXMP1_CL64.Location = new System.Drawing.Point(194, 64);
            this.cboxXMP1_CL64.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL64.Name = "cboxXMP1_CL64";
            this.cboxXMP1_CL64.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL64.TabIndex = 1;
            this.cboxXMP1_CL64.Text = "64";
            this.cboxXMP1_CL64.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL52
            // 
            this.cboxXMP1_CL52.AutoSize = true;
            this.cboxXMP1_CL52.Location = new System.Drawing.Point(149, 42);
            this.cboxXMP1_CL52.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL52.Name = "cboxXMP1_CL52";
            this.cboxXMP1_CL52.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL52.TabIndex = 1;
            this.cboxXMP1_CL52.Text = "52";
            this.cboxXMP1_CL52.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL40
            // 
            this.cboxXMP1_CL40.AutoSize = true;
            this.cboxXMP1_CL40.Location = new System.Drawing.Point(103, 21);
            this.cboxXMP1_CL40.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL40.Name = "cboxXMP1_CL40";
            this.cboxXMP1_CL40.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL40.TabIndex = 1;
            this.cboxXMP1_CL40.Text = "40";
            this.cboxXMP1_CL40.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL28
            // 
            this.cboxXMP1_CL28.AutoSize = true;
            this.cboxXMP1_CL28.Location = new System.Drawing.Point(11, 106);
            this.cboxXMP1_CL28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL28.Name = "cboxXMP1_CL28";
            this.cboxXMP1_CL28.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL28.TabIndex = 1;
            this.cboxXMP1_CL28.Text = "28";
            this.cboxXMP1_CL28.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL98
            // 
            this.cboxXMP1_CL98.AutoSize = true;
            this.cboxXMP1_CL98.Location = new System.Drawing.Point(331, 106);
            this.cboxXMP1_CL98.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL98.Name = "cboxXMP1_CL98";
            this.cboxXMP1_CL98.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL98.TabIndex = 1;
            this.cboxXMP1_CL98.Text = "98";
            this.cboxXMP1_CL98.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL86
            // 
            this.cboxXMP1_CL86.AutoSize = true;
            this.cboxXMP1_CL86.Location = new System.Drawing.Point(286, 85);
            this.cboxXMP1_CL86.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL86.Name = "cboxXMP1_CL86";
            this.cboxXMP1_CL86.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL86.TabIndex = 1;
            this.cboxXMP1_CL86.Text = "86";
            this.cboxXMP1_CL86.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL74
            // 
            this.cboxXMP1_CL74.AutoSize = true;
            this.cboxXMP1_CL74.Location = new System.Drawing.Point(240, 64);
            this.cboxXMP1_CL74.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL74.Name = "cboxXMP1_CL74";
            this.cboxXMP1_CL74.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL74.TabIndex = 1;
            this.cboxXMP1_CL74.Text = "74";
            this.cboxXMP1_CL74.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL62
            // 
            this.cboxXMP1_CL62.AutoSize = true;
            this.cboxXMP1_CL62.Location = new System.Drawing.Point(194, 42);
            this.cboxXMP1_CL62.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL62.Name = "cboxXMP1_CL62";
            this.cboxXMP1_CL62.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL62.TabIndex = 1;
            this.cboxXMP1_CL62.Text = "62";
            this.cboxXMP1_CL62.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL50
            // 
            this.cboxXMP1_CL50.AutoSize = true;
            this.cboxXMP1_CL50.Location = new System.Drawing.Point(149, 21);
            this.cboxXMP1_CL50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL50.Name = "cboxXMP1_CL50";
            this.cboxXMP1_CL50.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL50.TabIndex = 1;
            this.cboxXMP1_CL50.Text = "50";
            this.cboxXMP1_CL50.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL38
            // 
            this.cboxXMP1_CL38.AutoSize = true;
            this.cboxXMP1_CL38.Location = new System.Drawing.Point(57, 106);
            this.cboxXMP1_CL38.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL38.Name = "cboxXMP1_CL38";
            this.cboxXMP1_CL38.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL38.TabIndex = 1;
            this.cboxXMP1_CL38.Text = "38";
            this.cboxXMP1_CL38.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL26
            // 
            this.cboxXMP1_CL26.AutoSize = true;
            this.cboxXMP1_CL26.Location = new System.Drawing.Point(11, 85);
            this.cboxXMP1_CL26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL26.Name = "cboxXMP1_CL26";
            this.cboxXMP1_CL26.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL26.TabIndex = 1;
            this.cboxXMP1_CL26.Text = "26";
            this.cboxXMP1_CL26.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL96
            // 
            this.cboxXMP1_CL96.AutoSize = true;
            this.cboxXMP1_CL96.Location = new System.Drawing.Point(331, 85);
            this.cboxXMP1_CL96.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL96.Name = "cboxXMP1_CL96";
            this.cboxXMP1_CL96.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL96.TabIndex = 1;
            this.cboxXMP1_CL96.Text = "96";
            this.cboxXMP1_CL96.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL84
            // 
            this.cboxXMP1_CL84.AutoSize = true;
            this.cboxXMP1_CL84.Location = new System.Drawing.Point(286, 64);
            this.cboxXMP1_CL84.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL84.Name = "cboxXMP1_CL84";
            this.cboxXMP1_CL84.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL84.TabIndex = 1;
            this.cboxXMP1_CL84.Text = "84";
            this.cboxXMP1_CL84.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL72
            // 
            this.cboxXMP1_CL72.AutoSize = true;
            this.cboxXMP1_CL72.Location = new System.Drawing.Point(240, 42);
            this.cboxXMP1_CL72.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL72.Name = "cboxXMP1_CL72";
            this.cboxXMP1_CL72.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL72.TabIndex = 1;
            this.cboxXMP1_CL72.Text = "72";
            this.cboxXMP1_CL72.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL60
            // 
            this.cboxXMP1_CL60.AutoSize = true;
            this.cboxXMP1_CL60.Location = new System.Drawing.Point(194, 21);
            this.cboxXMP1_CL60.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL60.Name = "cboxXMP1_CL60";
            this.cboxXMP1_CL60.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL60.TabIndex = 1;
            this.cboxXMP1_CL60.Text = "60";
            this.cboxXMP1_CL60.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL48
            // 
            this.cboxXMP1_CL48.AutoSize = true;
            this.cboxXMP1_CL48.Location = new System.Drawing.Point(103, 106);
            this.cboxXMP1_CL48.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL48.Name = "cboxXMP1_CL48";
            this.cboxXMP1_CL48.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL48.TabIndex = 1;
            this.cboxXMP1_CL48.Text = "48";
            this.cboxXMP1_CL48.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL36
            // 
            this.cboxXMP1_CL36.AutoSize = true;
            this.cboxXMP1_CL36.Location = new System.Drawing.Point(57, 85);
            this.cboxXMP1_CL36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL36.Name = "cboxXMP1_CL36";
            this.cboxXMP1_CL36.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL36.TabIndex = 1;
            this.cboxXMP1_CL36.Text = "36";
            this.cboxXMP1_CL36.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL24
            // 
            this.cboxXMP1_CL24.AutoSize = true;
            this.cboxXMP1_CL24.Location = new System.Drawing.Point(11, 64);
            this.cboxXMP1_CL24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL24.Name = "cboxXMP1_CL24";
            this.cboxXMP1_CL24.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL24.TabIndex = 1;
            this.cboxXMP1_CL24.Text = "24";
            this.cboxXMP1_CL24.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL94
            // 
            this.cboxXMP1_CL94.AutoSize = true;
            this.cboxXMP1_CL94.Location = new System.Drawing.Point(331, 64);
            this.cboxXMP1_CL94.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL94.Name = "cboxXMP1_CL94";
            this.cboxXMP1_CL94.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL94.TabIndex = 1;
            this.cboxXMP1_CL94.Text = "94";
            this.cboxXMP1_CL94.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL82
            // 
            this.cboxXMP1_CL82.AutoSize = true;
            this.cboxXMP1_CL82.Location = new System.Drawing.Point(286, 42);
            this.cboxXMP1_CL82.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL82.Name = "cboxXMP1_CL82";
            this.cboxXMP1_CL82.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL82.TabIndex = 1;
            this.cboxXMP1_CL82.Text = "82";
            this.cboxXMP1_CL82.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL70
            // 
            this.cboxXMP1_CL70.AutoSize = true;
            this.cboxXMP1_CL70.Location = new System.Drawing.Point(240, 21);
            this.cboxXMP1_CL70.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL70.Name = "cboxXMP1_CL70";
            this.cboxXMP1_CL70.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL70.TabIndex = 1;
            this.cboxXMP1_CL70.Text = "70";
            this.cboxXMP1_CL70.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL58
            // 
            this.cboxXMP1_CL58.AutoSize = true;
            this.cboxXMP1_CL58.Location = new System.Drawing.Point(149, 106);
            this.cboxXMP1_CL58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL58.Name = "cboxXMP1_CL58";
            this.cboxXMP1_CL58.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL58.TabIndex = 1;
            this.cboxXMP1_CL58.Text = "58";
            this.cboxXMP1_CL58.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL46
            // 
            this.cboxXMP1_CL46.AutoSize = true;
            this.cboxXMP1_CL46.Location = new System.Drawing.Point(103, 85);
            this.cboxXMP1_CL46.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL46.Name = "cboxXMP1_CL46";
            this.cboxXMP1_CL46.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL46.TabIndex = 1;
            this.cboxXMP1_CL46.Text = "46";
            this.cboxXMP1_CL46.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL34
            // 
            this.cboxXMP1_CL34.AutoSize = true;
            this.cboxXMP1_CL34.Location = new System.Drawing.Point(57, 64);
            this.cboxXMP1_CL34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL34.Name = "cboxXMP1_CL34";
            this.cboxXMP1_CL34.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL34.TabIndex = 1;
            this.cboxXMP1_CL34.Text = "34";
            this.cboxXMP1_CL34.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL22
            // 
            this.cboxXMP1_CL22.AutoSize = true;
            this.cboxXMP1_CL22.Location = new System.Drawing.Point(11, 42);
            this.cboxXMP1_CL22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL22.Name = "cboxXMP1_CL22";
            this.cboxXMP1_CL22.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL22.TabIndex = 1;
            this.cboxXMP1_CL22.Text = "22";
            this.cboxXMP1_CL22.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL92
            // 
            this.cboxXMP1_CL92.AutoSize = true;
            this.cboxXMP1_CL92.Location = new System.Drawing.Point(331, 42);
            this.cboxXMP1_CL92.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL92.Name = "cboxXMP1_CL92";
            this.cboxXMP1_CL92.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL92.TabIndex = 0;
            this.cboxXMP1_CL92.Text = "92";
            this.cboxXMP1_CL92.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL80
            // 
            this.cboxXMP1_CL80.AutoSize = true;
            this.cboxXMP1_CL80.Location = new System.Drawing.Point(286, 21);
            this.cboxXMP1_CL80.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL80.Name = "cboxXMP1_CL80";
            this.cboxXMP1_CL80.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL80.TabIndex = 0;
            this.cboxXMP1_CL80.Text = "80";
            this.cboxXMP1_CL80.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL68
            // 
            this.cboxXMP1_CL68.AutoSize = true;
            this.cboxXMP1_CL68.Location = new System.Drawing.Point(194, 106);
            this.cboxXMP1_CL68.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL68.Name = "cboxXMP1_CL68";
            this.cboxXMP1_CL68.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL68.TabIndex = 0;
            this.cboxXMP1_CL68.Text = "68";
            this.cboxXMP1_CL68.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL56
            // 
            this.cboxXMP1_CL56.AutoSize = true;
            this.cboxXMP1_CL56.Location = new System.Drawing.Point(149, 85);
            this.cboxXMP1_CL56.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL56.Name = "cboxXMP1_CL56";
            this.cboxXMP1_CL56.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL56.TabIndex = 0;
            this.cboxXMP1_CL56.Text = "56";
            this.cboxXMP1_CL56.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL44
            // 
            this.cboxXMP1_CL44.AutoSize = true;
            this.cboxXMP1_CL44.Location = new System.Drawing.Point(103, 64);
            this.cboxXMP1_CL44.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL44.Name = "cboxXMP1_CL44";
            this.cboxXMP1_CL44.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL44.TabIndex = 0;
            this.cboxXMP1_CL44.Text = "44";
            this.cboxXMP1_CL44.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL32
            // 
            this.cboxXMP1_CL32.AutoSize = true;
            this.cboxXMP1_CL32.Location = new System.Drawing.Point(57, 42);
            this.cboxXMP1_CL32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL32.Name = "cboxXMP1_CL32";
            this.cboxXMP1_CL32.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL32.TabIndex = 0;
            this.cboxXMP1_CL32.Text = "32";
            this.cboxXMP1_CL32.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_CL20
            // 
            this.cboxXMP1_CL20.AutoSize = true;
            this.cboxXMP1_CL20.Location = new System.Drawing.Point(11, 21);
            this.cboxXMP1_CL20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_CL20.Name = "cboxXMP1_CL20";
            this.cboxXMP1_CL20.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP1_CL20.TabIndex = 0;
            this.cboxXMP1_CL20.Text = "20";
            this.cboxXMP1_CL20.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboxXMP1_RealTimeMemoryFrequencyOC);
            this.groupBox5.Controls.Add(this.cboxXMP1_IntelDynamicMemoryBoost);
            this.groupBox5.Controls.Add(this.comboxXMP1_CommandRate);
            this.groupBox5.Controls.Add(this.tboxXMP1_MegaTransfers);
            this.groupBox5.Controls.Add(this.tboxXMP1_Frequency);
            this.groupBox5.Controls.Add(this.updnXMP1_MinCycleTime);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Location = new System.Drawing.Point(7, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(600, 72);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Frequency";
            // 
            // cboxXMP1_RealTimeMemoryFrequencyOC
            // 
            this.cboxXMP1_RealTimeMemoryFrequencyOC.AutoSize = true;
            this.cboxXMP1_RealTimeMemoryFrequencyOC.Location = new System.Drawing.Point(353, 46);
            this.cboxXMP1_RealTimeMemoryFrequencyOC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_RealTimeMemoryFrequencyOC.Name = "cboxXMP1_RealTimeMemoryFrequencyOC";
            this.cboxXMP1_RealTimeMemoryFrequencyOC.Size = new System.Drawing.Size(241, 19);
            this.cboxXMP1_RealTimeMemoryFrequencyOC.TabIndex = 4;
            this.cboxXMP1_RealTimeMemoryFrequencyOC.Text = "Realtime Memory Frequency OC";
            this.cboxXMP1_RealTimeMemoryFrequencyOC.UseVisualStyleBackColor = true;
            // 
            // cboxXMP1_IntelDynamicMemoryBoost
            // 
            this.cboxXMP1_IntelDynamicMemoryBoost.AutoSize = true;
            this.cboxXMP1_IntelDynamicMemoryBoost.Location = new System.Drawing.Point(378, 18);
            this.cboxXMP1_IntelDynamicMemoryBoost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP1_IntelDynamicMemoryBoost.Name = "cboxXMP1_IntelDynamicMemoryBoost";
            this.cboxXMP1_IntelDynamicMemoryBoost.Size = new System.Drawing.Size(218, 19);
            this.cboxXMP1_IntelDynamicMemoryBoost.TabIndex = 4;
            this.cboxXMP1_IntelDynamicMemoryBoost.Text = "Intel Dynamic Memory Boost";
            this.cboxXMP1_IntelDynamicMemoryBoost.UseVisualStyleBackColor = true;
            // 
            // comboxXMP1_CommandRate
            // 
            this.comboxXMP1_CommandRate.FormattingEnabled = true;
            this.comboxXMP1_CommandRate.Items.AddRange(new object[] {
            "_Undefined",
            "_1N",
            "_2N",
            "_3N"});
            this.comboxXMP1_CommandRate.Location = new System.Drawing.Point(128, 45);
            this.comboxXMP1_CommandRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboxXMP1_CommandRate.Name = "comboxXMP1_CommandRate";
            this.comboxXMP1_CommandRate.Size = new System.Drawing.Size(105, 23);
            this.comboxXMP1_CommandRate.TabIndex = 3;
            // 
            // tboxXMP1_MegaTransfers
            // 
            this.tboxXMP1_MegaTransfers.Enabled = false;
            this.tboxXMP1_MegaTransfers.Location = new System.Drawing.Point(285, 15);
            this.tboxXMP1_MegaTransfers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_MegaTransfers.Name = "tboxXMP1_MegaTransfers";
            this.tboxXMP1_MegaTransfers.Size = new System.Drawing.Size(79, 25);
            this.tboxXMP1_MegaTransfers.TabIndex = 2;
            // 
            // tboxXMP1_Frequency
            // 
            this.tboxXMP1_Frequency.Enabled = false;
            this.tboxXMP1_Frequency.Location = new System.Drawing.Point(208, 15);
            this.tboxXMP1_Frequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_Frequency.Name = "tboxXMP1_Frequency";
            this.tboxXMP1_Frequency.Size = new System.Drawing.Size(69, 25);
            this.tboxXMP1_Frequency.TabIndex = 2;
            // 
            // updnXMP1_MinCycleTime
            // 
            this.updnXMP1_MinCycleTime.Location = new System.Drawing.Point(128, 15);
            this.updnXMP1_MinCycleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updnXMP1_MinCycleTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.updnXMP1_MinCycleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnXMP1_MinCycleTime.Name = "updnXMP1_MinCycleTime";
            this.updnXMP1_MinCycleTime.Size = new System.Drawing.Size(73, 25);
            this.updnXMP1_MinCycleTime.TabIndex = 1;
            this.updnXMP1_MinCycleTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnXMP1_MinCycleTime.ValueChanged += new System.EventHandler(this.updnXMP1_MinCycleTime_ValueChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(7, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 15);
            this.label28.TabIndex = 0;
            this.label28.Text = "Command Rate:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 15);
            this.label27.TabIndex = 0;
            this.label27.Text = "Min Cycle Time:";
            // 
            // tabPageSPD_XMP2
            // 
            this.tabPageSPD_XMP2.Controls.Add(this.groupBox18);
            this.tabPageSPD_XMP2.Controls.Add(this.groupBox17);
            this.tabPageSPD_XMP2.Controls.Add(this.groupBox16);
            this.tabPageSPD_XMP2.Controls.Add(this.groupBox15);
            this.tabPageSPD_XMP2.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_XMP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_XMP2.Name = "tabPageSPD_XMP2";
            this.tabPageSPD_XMP2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_XMP2.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_XMP2.TabIndex = 2;
            this.tabPageSPD_XMP2.Text = "XMP2";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tRTP);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tCCD_S_WTR);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tCCD_L_WTR);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tFAW);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tCCD_L_WR2);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tCCD_L_WR);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tCCD_L);
            this.groupBox18.Controls.Add(this.tboxXMP2Lmt_tRRD_L);
            this.groupBox18.Controls.Add(this.lblXMP2_tRTP);
            this.groupBox18.Controls.Add(this.lblXMP2_tCCD_S_WTR);
            this.groupBox18.Controls.Add(this.lblXMP2_tCCD_L_WTR);
            this.groupBox18.Controls.Add(this.lblXMP2_tFAW);
            this.groupBox18.Controls.Add(this.lblXMP2_tCCD_L_WR2);
            this.groupBox18.Controls.Add(this.lblXMP2_tCCD_L_WR);
            this.groupBox18.Controls.Add(this.lblXMP2_tCCD_L);
            this.groupBox18.Controls.Add(this.lblXMP2_tRRD_L);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRTP);
            this.groupBox18.Controls.Add(this.tboxXMP2_tCCD_S_WTR);
            this.groupBox18.Controls.Add(this.tboxXMP2_tCCD_L_WTR);
            this.groupBox18.Controls.Add(this.tboxXMP2_tFAW);
            this.groupBox18.Controls.Add(this.tboxXMP2_tCCD_L_WR2);
            this.groupBox18.Controls.Add(this.tboxXMP2_tCCD_L_WR);
            this.groupBox18.Controls.Add(this.tboxXMP2_tCCD_L);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRRD_L);
            this.groupBox18.Controls.Add(this.label128);
            this.groupBox18.Controls.Add(this.label129);
            this.groupBox18.Controls.Add(this.label130);
            this.groupBox18.Controls.Add(this.label131);
            this.groupBox18.Controls.Add(this.label132);
            this.groupBox18.Controls.Add(this.label133);
            this.groupBox18.Controls.Add(this.label134);
            this.groupBox18.Controls.Add(this.label135);
            this.groupBox18.Controls.Add(this.lblXMP2_tRFCsb);
            this.groupBox18.Controls.Add(this.lblXMP2_tRFC2);
            this.groupBox18.Controls.Add(this.lblXMP2_tRFC1);
            this.groupBox18.Controls.Add(this.lblXMP2_tWR);
            this.groupBox18.Controls.Add(this.lblXMP2_tRC);
            this.groupBox18.Controls.Add(this.lblXMP2_tRAS);
            this.groupBox18.Controls.Add(this.lblXMP2_tRP);
            this.groupBox18.Controls.Add(this.lblXMP2_tRCD);
            this.groupBox18.Controls.Add(this.lblXMP2_tAA);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRFCsb);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRFC2);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRFC1);
            this.groupBox18.Controls.Add(this.tboxXMP2_tWR);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRC);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRAS);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRP);
            this.groupBox18.Controls.Add(this.label145);
            this.groupBox18.Controls.Add(this.tboxXMP2_tRCD);
            this.groupBox18.Controls.Add(this.tboxXMP2_tAA);
            this.groupBox18.Controls.Add(this.label146);
            this.groupBox18.Controls.Add(this.label147);
            this.groupBox18.Controls.Add(this.label148);
            this.groupBox18.Controls.Add(this.label149);
            this.groupBox18.Controls.Add(this.label150);
            this.groupBox18.Controls.Add(this.label151);
            this.groupBox18.Controls.Add(this.label152);
            this.groupBox18.Controls.Add(this.label153);
            this.groupBox18.Controls.Add(this.label154);
            this.groupBox18.Controls.Add(this.label155);
            this.groupBox18.Controls.Add(this.label156);
            this.groupBox18.Controls.Add(this.label157);
            this.groupBox18.Controls.Add(this.label158);
            this.groupBox18.Controls.Add(this.label159);
            this.groupBox18.Controls.Add(this.label160);
            this.groupBox18.Location = new System.Drawing.Point(7, 260);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox18.Size = new System.Drawing.Size(600, 296);
            this.groupBox18.TabIndex = 6;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Timings";
            // 
            // tboxXMP2Lmt_tRTP
            // 
            this.tboxXMP2Lmt_tRTP.Location = new System.Drawing.Point(427, 231);
            this.tboxXMP2Lmt_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tRTP.Name = "tboxXMP2Lmt_tRTP";
            this.tboxXMP2Lmt_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tRTP.TabIndex = 58;
            // 
            // tboxXMP2Lmt_tCCD_S_WTR
            // 
            this.tboxXMP2Lmt_tCCD_S_WTR.Location = new System.Drawing.Point(427, 204);
            this.tboxXMP2Lmt_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tCCD_S_WTR.Name = "tboxXMP2Lmt_tCCD_S_WTR";
            this.tboxXMP2Lmt_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tCCD_S_WTR.TabIndex = 59;
            // 
            // tboxXMP2Lmt_tCCD_L_WTR
            // 
            this.tboxXMP2Lmt_tCCD_L_WTR.Location = new System.Drawing.Point(427, 176);
            this.tboxXMP2Lmt_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tCCD_L_WTR.Name = "tboxXMP2Lmt_tCCD_L_WTR";
            this.tboxXMP2Lmt_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tCCD_L_WTR.TabIndex = 56;
            // 
            // tboxXMP2Lmt_tFAW
            // 
            this.tboxXMP2Lmt_tFAW.Location = new System.Drawing.Point(427, 149);
            this.tboxXMP2Lmt_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tFAW.Name = "tboxXMP2Lmt_tFAW";
            this.tboxXMP2Lmt_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tFAW.TabIndex = 57;
            // 
            // tboxXMP2Lmt_tCCD_L_WR2
            // 
            this.tboxXMP2Lmt_tCCD_L_WR2.Location = new System.Drawing.Point(427, 121);
            this.tboxXMP2Lmt_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tCCD_L_WR2.Name = "tboxXMP2Lmt_tCCD_L_WR2";
            this.tboxXMP2Lmt_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tCCD_L_WR2.TabIndex = 54;
            // 
            // tboxXMP2Lmt_tCCD_L_WR
            // 
            this.tboxXMP2Lmt_tCCD_L_WR.Location = new System.Drawing.Point(427, 94);
            this.tboxXMP2Lmt_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tCCD_L_WR.Name = "tboxXMP2Lmt_tCCD_L_WR";
            this.tboxXMP2Lmt_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tCCD_L_WR.TabIndex = 55;
            // 
            // tboxXMP2Lmt_tCCD_L
            // 
            this.tboxXMP2Lmt_tCCD_L.Location = new System.Drawing.Point(427, 66);
            this.tboxXMP2Lmt_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tCCD_L.Name = "tboxXMP2Lmt_tCCD_L";
            this.tboxXMP2Lmt_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tCCD_L.TabIndex = 53;
            // 
            // tboxXMP2Lmt_tRRD_L
            // 
            this.tboxXMP2Lmt_tRRD_L.Location = new System.Drawing.Point(427, 39);
            this.tboxXMP2Lmt_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2Lmt_tRRD_L.Name = "tboxXMP2Lmt_tRRD_L";
            this.tboxXMP2Lmt_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2Lmt_tRRD_L.TabIndex = 52;
            // 
            // lblXMP2_tRTP
            // 
            this.lblXMP2_tRTP.AutoSize = true;
            this.lblXMP2_tRTP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRTP.Location = new System.Drawing.Point(502, 235);
            this.lblXMP2_tRTP.Name = "lblXMP2_tRTP";
            this.lblXMP2_tRTP.Size = new System.Drawing.Size(39, 20);
            this.lblXMP2_tRTP.TabIndex = 50;
            this.lblXMP2_tRTP.Text = "tRTP";
            // 
            // lblXMP2_tCCD_S_WTR
            // 
            this.lblXMP2_tCCD_S_WTR.AutoSize = true;
            this.lblXMP2_tCCD_S_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tCCD_S_WTR.Location = new System.Drawing.Point(502, 212);
            this.lblXMP2_tCCD_S_WTR.Name = "lblXMP2_tCCD_S_WTR";
            this.lblXMP2_tCCD_S_WTR.Size = new System.Drawing.Size(94, 20);
            this.lblXMP2_tCCD_S_WTR.TabIndex = 51;
            this.lblXMP2_tCCD_S_WTR.Text = "tCCD_S_WTR";
            // 
            // lblXMP2_tCCD_L_WTR
            // 
            this.lblXMP2_tCCD_L_WTR.AutoSize = true;
            this.lblXMP2_tCCD_L_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tCCD_L_WTR.Location = new System.Drawing.Point(502, 185);
            this.lblXMP2_tCCD_L_WTR.Name = "lblXMP2_tCCD_L_WTR";
            this.lblXMP2_tCCD_L_WTR.Size = new System.Drawing.Size(93, 20);
            this.lblXMP2_tCCD_L_WTR.TabIndex = 47;
            this.lblXMP2_tCCD_L_WTR.Text = "tCCD_L_WTR";
            // 
            // lblXMP2_tFAW
            // 
            this.lblXMP2_tFAW.AutoSize = true;
            this.lblXMP2_tFAW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tFAW.Location = new System.Drawing.Point(502, 158);
            this.lblXMP2_tFAW.Name = "lblXMP2_tFAW";
            this.lblXMP2_tFAW.Size = new System.Drawing.Size(43, 20);
            this.lblXMP2_tFAW.TabIndex = 48;
            this.lblXMP2_tFAW.Text = "tFAW";
            // 
            // lblXMP2_tCCD_L_WR2
            // 
            this.lblXMP2_tCCD_L_WR2.AutoSize = true;
            this.lblXMP2_tCCD_L_WR2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tCCD_L_WR2.Location = new System.Drawing.Point(502, 129);
            this.lblXMP2_tCCD_L_WR2.Name = "lblXMP2_tCCD_L_WR2";
            this.lblXMP2_tCCD_L_WR2.Size = new System.Drawing.Size(93, 20);
            this.lblXMP2_tCCD_L_WR2.TabIndex = 49;
            this.lblXMP2_tCCD_L_WR2.Text = "tCCD_L_WR2";
            // 
            // lblXMP2_tCCD_L_WR
            // 
            this.lblXMP2_tCCD_L_WR.AutoSize = true;
            this.lblXMP2_tCCD_L_WR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tCCD_L_WR.Location = new System.Drawing.Point(502, 101);
            this.lblXMP2_tCCD_L_WR.Name = "lblXMP2_tCCD_L_WR";
            this.lblXMP2_tCCD_L_WR.Size = new System.Drawing.Size(85, 20);
            this.lblXMP2_tCCD_L_WR.TabIndex = 44;
            this.lblXMP2_tCCD_L_WR.Text = "tCCD_L_WR";
            // 
            // lblXMP2_tCCD_L
            // 
            this.lblXMP2_tCCD_L.AutoSize = true;
            this.lblXMP2_tCCD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tCCD_L.Location = new System.Drawing.Point(502, 74);
            this.lblXMP2_tCCD_L.Name = "lblXMP2_tCCD_L";
            this.lblXMP2_tCCD_L.Size = new System.Drawing.Size(56, 20);
            this.lblXMP2_tCCD_L.TabIndex = 45;
            this.lblXMP2_tCCD_L.Text = "tCCD_L";
            // 
            // lblXMP2_tRRD_L
            // 
            this.lblXMP2_tRRD_L.AutoSize = true;
            this.lblXMP2_tRRD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRRD_L.Location = new System.Drawing.Point(502, 46);
            this.lblXMP2_tRRD_L.Name = "lblXMP2_tRRD_L";
            this.lblXMP2_tRRD_L.Size = new System.Drawing.Size(56, 20);
            this.lblXMP2_tRRD_L.TabIndex = 46;
            this.lblXMP2_tRRD_L.Text = "tRRD_L";
            // 
            // tboxXMP2_tRTP
            // 
            this.tboxXMP2_tRTP.Location = new System.Drawing.Point(350, 232);
            this.tboxXMP2_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRTP.Name = "tboxXMP2_tRTP";
            this.tboxXMP2_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRTP.TabIndex = 42;
            // 
            // tboxXMP2_tCCD_S_WTR
            // 
            this.tboxXMP2_tCCD_S_WTR.Location = new System.Drawing.Point(350, 205);
            this.tboxXMP2_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tCCD_S_WTR.Name = "tboxXMP2_tCCD_S_WTR";
            this.tboxXMP2_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tCCD_S_WTR.TabIndex = 43;
            // 
            // tboxXMP2_tCCD_L_WTR
            // 
            this.tboxXMP2_tCCD_L_WTR.Location = new System.Drawing.Point(350, 178);
            this.tboxXMP2_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tCCD_L_WTR.Name = "tboxXMP2_tCCD_L_WTR";
            this.tboxXMP2_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tCCD_L_WTR.TabIndex = 40;
            // 
            // tboxXMP2_tFAW
            // 
            this.tboxXMP2_tFAW.Location = new System.Drawing.Point(350, 150);
            this.tboxXMP2_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tFAW.Name = "tboxXMP2_tFAW";
            this.tboxXMP2_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tFAW.TabIndex = 41;
            // 
            // tboxXMP2_tCCD_L_WR2
            // 
            this.tboxXMP2_tCCD_L_WR2.Location = new System.Drawing.Point(350, 122);
            this.tboxXMP2_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tCCD_L_WR2.Name = "tboxXMP2_tCCD_L_WR2";
            this.tboxXMP2_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tCCD_L_WR2.TabIndex = 38;
            // 
            // tboxXMP2_tCCD_L_WR
            // 
            this.tboxXMP2_tCCD_L_WR.Location = new System.Drawing.Point(350, 95);
            this.tboxXMP2_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tCCD_L_WR.Name = "tboxXMP2_tCCD_L_WR";
            this.tboxXMP2_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tCCD_L_WR.TabIndex = 39;
            // 
            // tboxXMP2_tCCD_L
            // 
            this.tboxXMP2_tCCD_L.Location = new System.Drawing.Point(350, 68);
            this.tboxXMP2_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tCCD_L.Name = "tboxXMP2_tCCD_L";
            this.tboxXMP2_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tCCD_L.TabIndex = 31;
            // 
            // tboxXMP2_tRRD_L
            // 
            this.tboxXMP2_tRRD_L.Location = new System.Drawing.Point(350, 40);
            this.tboxXMP2_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRRD_L.Name = "tboxXMP2_tRRD_L";
            this.tboxXMP2_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRRD_L.TabIndex = 30;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.Location = new System.Drawing.Point(305, 236);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(46, 20);
            this.label128.TabIndex = 36;
            this.label128.Text = "tRTP :";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.Location = new System.Drawing.Point(257, 209);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(101, 20);
            this.label129.TabIndex = 37;
            this.label129.Text = "tCCD_S_WTR :";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(257, 181);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(100, 20);
            this.label130.TabIndex = 33;
            this.label130.Text = "tCCD_L_WTR :";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(298, 154);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(50, 20);
            this.label131.TabIndex = 34;
            this.label131.Text = "tFAW :";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(256, 125);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(100, 20);
            this.label132.TabIndex = 35;
            this.label132.Text = "tCCD_L_WR2 :";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(263, 99);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(92, 20);
            this.label133.TabIndex = 29;
            this.label133.Text = "tCCD_L_WR :";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(289, 71);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(63, 20);
            this.label134.TabIndex = 32;
            this.label134.Text = "tCCD_L :";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(289, 44);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(63, 20);
            this.label135.TabIndex = 28;
            this.label135.Text = "tRRD_L :";
            // 
            // lblXMP2_tRFCsb
            // 
            this.lblXMP2_tRFCsb.AutoSize = true;
            this.lblXMP2_tRFCsb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRFCsb.Location = new System.Drawing.Point(159, 268);
            this.lblXMP2_tRFCsb.Name = "lblXMP2_tRFCsb";
            this.lblXMP2_tRFCsb.Size = new System.Drawing.Size(54, 20);
            this.lblXMP2_tRFCsb.TabIndex = 25;
            this.lblXMP2_tRFCsb.Text = "tRFCsb";
            // 
            // lblXMP2_tRFC2
            // 
            this.lblXMP2_tRFC2.AutoSize = true;
            this.lblXMP2_tRFC2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRFC2.Location = new System.Drawing.Point(159, 240);
            this.lblXMP2_tRFC2.Name = "lblXMP2_tRFC2";
            this.lblXMP2_tRFC2.Size = new System.Drawing.Size(47, 20);
            this.lblXMP2_tRFC2.TabIndex = 26;
            this.lblXMP2_tRFC2.Text = "tRFC2";
            // 
            // lblXMP2_tRFC1
            // 
            this.lblXMP2_tRFC1.AutoSize = true;
            this.lblXMP2_tRFC1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRFC1.Location = new System.Drawing.Point(159, 212);
            this.lblXMP2_tRFC1.Name = "lblXMP2_tRFC1";
            this.lblXMP2_tRFC1.Size = new System.Drawing.Size(47, 20);
            this.lblXMP2_tRFC1.TabIndex = 27;
            this.lblXMP2_tRFC1.Text = "tRFC1";
            // 
            // lblXMP2_tWR
            // 
            this.lblXMP2_tWR.AutoSize = true;
            this.lblXMP2_tWR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tWR.Location = new System.Drawing.Point(159, 185);
            this.lblXMP2_tWR.Name = "lblXMP2_tWR";
            this.lblXMP2_tWR.Size = new System.Drawing.Size(37, 20);
            this.lblXMP2_tWR.TabIndex = 22;
            this.lblXMP2_tWR.Text = "tWR";
            // 
            // lblXMP2_tRC
            // 
            this.lblXMP2_tRC.AutoSize = true;
            this.lblXMP2_tRC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRC.Location = new System.Drawing.Point(159, 158);
            this.lblXMP2_tRC.Name = "lblXMP2_tRC";
            this.lblXMP2_tRC.Size = new System.Drawing.Size(32, 20);
            this.lblXMP2_tRC.TabIndex = 23;
            this.lblXMP2_tRC.Text = "tRC";
            // 
            // lblXMP2_tRAS
            // 
            this.lblXMP2_tRAS.AutoSize = true;
            this.lblXMP2_tRAS.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRAS.Location = new System.Drawing.Point(159, 129);
            this.lblXMP2_tRAS.Name = "lblXMP2_tRAS";
            this.lblXMP2_tRAS.Size = new System.Drawing.Size(41, 20);
            this.lblXMP2_tRAS.TabIndex = 24;
            this.lblXMP2_tRAS.Text = "tRAS";
            // 
            // lblXMP2_tRP
            // 
            this.lblXMP2_tRP.AutoSize = true;
            this.lblXMP2_tRP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRP.Location = new System.Drawing.Point(159, 101);
            this.lblXMP2_tRP.Name = "lblXMP2_tRP";
            this.lblXMP2_tRP.Size = new System.Drawing.Size(31, 20);
            this.lblXMP2_tRP.TabIndex = 19;
            this.lblXMP2_tRP.Text = "tRP";
            // 
            // lblXMP2_tRCD
            // 
            this.lblXMP2_tRCD.AutoSize = true;
            this.lblXMP2_tRCD.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tRCD.Location = new System.Drawing.Point(159, 74);
            this.lblXMP2_tRCD.Name = "lblXMP2_tRCD";
            this.lblXMP2_tRCD.Size = new System.Drawing.Size(43, 20);
            this.lblXMP2_tRCD.TabIndex = 20;
            this.lblXMP2_tRCD.Text = "tRCD";
            // 
            // lblXMP2_tAA
            // 
            this.lblXMP2_tAA.AutoSize = true;
            this.lblXMP2_tAA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMP2_tAA.Location = new System.Drawing.Point(159, 46);
            this.lblXMP2_tAA.Name = "lblXMP2_tAA";
            this.lblXMP2_tAA.Size = new System.Drawing.Size(34, 20);
            this.lblXMP2_tAA.TabIndex = 21;
            this.lblXMP2_tAA.Text = "tAA";
            // 
            // tboxXMP2_tRFCsb
            // 
            this.tboxXMP2_tRFCsb.Location = new System.Drawing.Point(83, 262);
            this.tboxXMP2_tRFCsb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRFCsb.Name = "tboxXMP2_tRFCsb";
            this.tboxXMP2_tRFCsb.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRFCsb.TabIndex = 18;
            // 
            // tboxXMP2_tRFC2
            // 
            this.tboxXMP2_tRFC2.Location = new System.Drawing.Point(83, 235);
            this.tboxXMP2_tRFC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRFC2.Name = "tboxXMP2_tRFC2";
            this.tboxXMP2_tRFC2.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRFC2.TabIndex = 16;
            // 
            // tboxXMP2_tRFC1
            // 
            this.tboxXMP2_tRFC1.Location = new System.Drawing.Point(83, 208);
            this.tboxXMP2_tRFC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRFC1.Name = "tboxXMP2_tRFC1";
            this.tboxXMP2_tRFC1.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRFC1.TabIndex = 17;
            // 
            // tboxXMP2_tWR
            // 
            this.tboxXMP2_tWR.Location = new System.Drawing.Point(83, 180);
            this.tboxXMP2_tWR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tWR.Name = "tboxXMP2_tWR";
            this.tboxXMP2_tWR.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tWR.TabIndex = 14;
            // 
            // tboxXMP2_tRC
            // 
            this.tboxXMP2_tRC.Location = new System.Drawing.Point(83, 152);
            this.tboxXMP2_tRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRC.Name = "tboxXMP2_tRC";
            this.tboxXMP2_tRC.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRC.TabIndex = 15;
            // 
            // tboxXMP2_tRAS
            // 
            this.tboxXMP2_tRAS.Location = new System.Drawing.Point(83, 125);
            this.tboxXMP2_tRAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRAS.Name = "tboxXMP2_tRAS";
            this.tboxXMP2_tRAS.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRAS.TabIndex = 12;
            // 
            // tboxXMP2_tRP
            // 
            this.tboxXMP2_tRP.Location = new System.Drawing.Point(83, 98);
            this.tboxXMP2_tRP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRP.Name = "tboxXMP2_tRP";
            this.tboxXMP2_tRP.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRP.TabIndex = 13;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.Location = new System.Drawing.Point(7, 266);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(61, 20);
            this.label145.TabIndex = 9;
            this.label145.Text = "tRFCsb :";
            // 
            // tboxXMP2_tRCD
            // 
            this.tboxXMP2_tRCD.Location = new System.Drawing.Point(83, 70);
            this.tboxXMP2_tRCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tRCD.Name = "tboxXMP2_tRCD";
            this.tboxXMP2_tRCD.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tRCD.TabIndex = 2;
            // 
            // tboxXMP2_tAA
            // 
            this.tboxXMP2_tAA.Location = new System.Drawing.Point(83, 42);
            this.tboxXMP2_tAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_tAA.Name = "tboxXMP2_tAA";
            this.tboxXMP2_tAA.Size = new System.Drawing.Size(59, 25);
            this.tboxXMP2_tAA.TabIndex = 2;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(13, 239);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(54, 20);
            this.label146.TabIndex = 10;
            this.label146.Text = "tRFC2 :";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(13, 211);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(54, 20);
            this.label147.TabIndex = 11;
            this.label147.Text = "tRFC1 :";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(22, 184);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(44, 20);
            this.label148.TabIndex = 6;
            this.label148.Text = "tWR :";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(22, 156);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(39, 20);
            this.label149.TabIndex = 7;
            this.label149.Text = "tRC :";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(22, 128);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(48, 20);
            this.label150.TabIndex = 8;
            this.label150.Text = "tRAS :";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label151.Location = new System.Drawing.Point(502, 21);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(48, 19);
            this.label151.TabIndex = 3;
            this.label151.Text = "Ticks";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(416, 24);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(88, 16);
            this.label152.TabIndex = 4;
            this.label152.Text = "LowCLK Limit";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label153.Location = new System.Drawing.Point(343, 21);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(82, 19);
            this.label153.TabIndex = 4;
            this.label153.Text = "Value (ps)";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label154.Location = new System.Drawing.Point(282, 21);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(53, 19);
            this.label154.TabIndex = 5;
            this.label154.Text = "Name";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label155.Location = new System.Drawing.Point(153, 21);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(48, 19);
            this.label155.TabIndex = 2;
            this.label155.Text = "Ticks";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(80, 21);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(82, 19);
            this.label156.TabIndex = 2;
            this.label156.Text = "Value (ps)";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.Location = new System.Drawing.Point(22, 101);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(38, 20);
            this.label157.TabIndex = 2;
            this.label157.Text = "tRP :";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(22, 74);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(50, 20);
            this.label158.TabIndex = 2;
            this.label158.Text = "tRCD :";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.Location = new System.Drawing.Point(22, 46);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(41, 20);
            this.label159.TabIndex = 2;
            this.label159.Text = "tAA :";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(19, 21);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(53, 19);
            this.label160.TabIndex = 2;
            this.label160.Text = "Name";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cboxXMP2_CL90);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL78);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL66);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL54);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL42);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL30);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL88);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL76);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL64);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL52);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL40);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL28);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL98);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL86);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL74);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL62);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL50);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL38);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL26);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL96);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL84);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL72);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL60);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL48);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL36);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL24);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL94);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL82);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL70);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL58);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL46);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL34);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL22);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL92);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL80);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL68);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL56);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL44);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL32);
            this.groupBox17.Controls.Add(this.cboxXMP2_CL20);
            this.groupBox17.Location = new System.Drawing.Point(7, 130);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox17.Size = new System.Drawing.Size(600, 130);
            this.groupBox17.TabIndex = 5;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Supported CAS Latencies";
            // 
            // cboxXMP2_CL90
            // 
            this.cboxXMP2_CL90.AutoSize = true;
            this.cboxXMP2_CL90.Location = new System.Drawing.Point(331, 21);
            this.cboxXMP2_CL90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL90.Name = "cboxXMP2_CL90";
            this.cboxXMP2_CL90.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL90.TabIndex = 1;
            this.cboxXMP2_CL90.Text = "90";
            this.cboxXMP2_CL90.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL78
            // 
            this.cboxXMP2_CL78.AutoSize = true;
            this.cboxXMP2_CL78.Location = new System.Drawing.Point(240, 106);
            this.cboxXMP2_CL78.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL78.Name = "cboxXMP2_CL78";
            this.cboxXMP2_CL78.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL78.TabIndex = 1;
            this.cboxXMP2_CL78.Text = "78";
            this.cboxXMP2_CL78.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL66
            // 
            this.cboxXMP2_CL66.AutoSize = true;
            this.cboxXMP2_CL66.Location = new System.Drawing.Point(194, 85);
            this.cboxXMP2_CL66.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL66.Name = "cboxXMP2_CL66";
            this.cboxXMP2_CL66.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL66.TabIndex = 1;
            this.cboxXMP2_CL66.Text = "66";
            this.cboxXMP2_CL66.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL54
            // 
            this.cboxXMP2_CL54.AutoSize = true;
            this.cboxXMP2_CL54.Location = new System.Drawing.Point(149, 64);
            this.cboxXMP2_CL54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL54.Name = "cboxXMP2_CL54";
            this.cboxXMP2_CL54.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL54.TabIndex = 1;
            this.cboxXMP2_CL54.Text = "54";
            this.cboxXMP2_CL54.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL42
            // 
            this.cboxXMP2_CL42.AutoSize = true;
            this.cboxXMP2_CL42.Location = new System.Drawing.Point(103, 42);
            this.cboxXMP2_CL42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL42.Name = "cboxXMP2_CL42";
            this.cboxXMP2_CL42.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL42.TabIndex = 1;
            this.cboxXMP2_CL42.Text = "42";
            this.cboxXMP2_CL42.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL30
            // 
            this.cboxXMP2_CL30.AutoSize = true;
            this.cboxXMP2_CL30.Location = new System.Drawing.Point(57, 21);
            this.cboxXMP2_CL30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL30.Name = "cboxXMP2_CL30";
            this.cboxXMP2_CL30.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL30.TabIndex = 1;
            this.cboxXMP2_CL30.Text = "30";
            this.cboxXMP2_CL30.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL88
            // 
            this.cboxXMP2_CL88.AutoSize = true;
            this.cboxXMP2_CL88.Location = new System.Drawing.Point(286, 106);
            this.cboxXMP2_CL88.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL88.Name = "cboxXMP2_CL88";
            this.cboxXMP2_CL88.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL88.TabIndex = 1;
            this.cboxXMP2_CL88.Text = "88";
            this.cboxXMP2_CL88.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL76
            // 
            this.cboxXMP2_CL76.AutoSize = true;
            this.cboxXMP2_CL76.Location = new System.Drawing.Point(240, 85);
            this.cboxXMP2_CL76.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL76.Name = "cboxXMP2_CL76";
            this.cboxXMP2_CL76.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL76.TabIndex = 1;
            this.cboxXMP2_CL76.Text = "76";
            this.cboxXMP2_CL76.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL64
            // 
            this.cboxXMP2_CL64.AutoSize = true;
            this.cboxXMP2_CL64.Location = new System.Drawing.Point(194, 64);
            this.cboxXMP2_CL64.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL64.Name = "cboxXMP2_CL64";
            this.cboxXMP2_CL64.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL64.TabIndex = 1;
            this.cboxXMP2_CL64.Text = "64";
            this.cboxXMP2_CL64.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL52
            // 
            this.cboxXMP2_CL52.AutoSize = true;
            this.cboxXMP2_CL52.Location = new System.Drawing.Point(149, 42);
            this.cboxXMP2_CL52.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL52.Name = "cboxXMP2_CL52";
            this.cboxXMP2_CL52.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL52.TabIndex = 1;
            this.cboxXMP2_CL52.Text = "52";
            this.cboxXMP2_CL52.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL40
            // 
            this.cboxXMP2_CL40.AutoSize = true;
            this.cboxXMP2_CL40.Location = new System.Drawing.Point(103, 21);
            this.cboxXMP2_CL40.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL40.Name = "cboxXMP2_CL40";
            this.cboxXMP2_CL40.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL40.TabIndex = 1;
            this.cboxXMP2_CL40.Text = "40";
            this.cboxXMP2_CL40.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL28
            // 
            this.cboxXMP2_CL28.AutoSize = true;
            this.cboxXMP2_CL28.Location = new System.Drawing.Point(11, 106);
            this.cboxXMP2_CL28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL28.Name = "cboxXMP2_CL28";
            this.cboxXMP2_CL28.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL28.TabIndex = 1;
            this.cboxXMP2_CL28.Text = "28";
            this.cboxXMP2_CL28.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL98
            // 
            this.cboxXMP2_CL98.AutoSize = true;
            this.cboxXMP2_CL98.Location = new System.Drawing.Point(331, 106);
            this.cboxXMP2_CL98.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL98.Name = "cboxXMP2_CL98";
            this.cboxXMP2_CL98.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL98.TabIndex = 1;
            this.cboxXMP2_CL98.Text = "98";
            this.cboxXMP2_CL98.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL86
            // 
            this.cboxXMP2_CL86.AutoSize = true;
            this.cboxXMP2_CL86.Location = new System.Drawing.Point(286, 85);
            this.cboxXMP2_CL86.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL86.Name = "cboxXMP2_CL86";
            this.cboxXMP2_CL86.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL86.TabIndex = 1;
            this.cboxXMP2_CL86.Text = "86";
            this.cboxXMP2_CL86.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL74
            // 
            this.cboxXMP2_CL74.AutoSize = true;
            this.cboxXMP2_CL74.Location = new System.Drawing.Point(240, 64);
            this.cboxXMP2_CL74.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL74.Name = "cboxXMP2_CL74";
            this.cboxXMP2_CL74.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL74.TabIndex = 1;
            this.cboxXMP2_CL74.Text = "74";
            this.cboxXMP2_CL74.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL62
            // 
            this.cboxXMP2_CL62.AutoSize = true;
            this.cboxXMP2_CL62.Location = new System.Drawing.Point(194, 42);
            this.cboxXMP2_CL62.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL62.Name = "cboxXMP2_CL62";
            this.cboxXMP2_CL62.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL62.TabIndex = 1;
            this.cboxXMP2_CL62.Text = "62";
            this.cboxXMP2_CL62.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL50
            // 
            this.cboxXMP2_CL50.AutoSize = true;
            this.cboxXMP2_CL50.Location = new System.Drawing.Point(149, 21);
            this.cboxXMP2_CL50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL50.Name = "cboxXMP2_CL50";
            this.cboxXMP2_CL50.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL50.TabIndex = 1;
            this.cboxXMP2_CL50.Text = "50";
            this.cboxXMP2_CL50.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL38
            // 
            this.cboxXMP2_CL38.AutoSize = true;
            this.cboxXMP2_CL38.Location = new System.Drawing.Point(57, 106);
            this.cboxXMP2_CL38.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL38.Name = "cboxXMP2_CL38";
            this.cboxXMP2_CL38.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL38.TabIndex = 1;
            this.cboxXMP2_CL38.Text = "38";
            this.cboxXMP2_CL38.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL26
            // 
            this.cboxXMP2_CL26.AutoSize = true;
            this.cboxXMP2_CL26.Location = new System.Drawing.Point(11, 85);
            this.cboxXMP2_CL26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL26.Name = "cboxXMP2_CL26";
            this.cboxXMP2_CL26.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL26.TabIndex = 1;
            this.cboxXMP2_CL26.Text = "26";
            this.cboxXMP2_CL26.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL96
            // 
            this.cboxXMP2_CL96.AutoSize = true;
            this.cboxXMP2_CL96.Location = new System.Drawing.Point(331, 85);
            this.cboxXMP2_CL96.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL96.Name = "cboxXMP2_CL96";
            this.cboxXMP2_CL96.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL96.TabIndex = 1;
            this.cboxXMP2_CL96.Text = "96";
            this.cboxXMP2_CL96.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL84
            // 
            this.cboxXMP2_CL84.AutoSize = true;
            this.cboxXMP2_CL84.Location = new System.Drawing.Point(286, 64);
            this.cboxXMP2_CL84.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL84.Name = "cboxXMP2_CL84";
            this.cboxXMP2_CL84.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL84.TabIndex = 1;
            this.cboxXMP2_CL84.Text = "84";
            this.cboxXMP2_CL84.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL72
            // 
            this.cboxXMP2_CL72.AutoSize = true;
            this.cboxXMP2_CL72.Location = new System.Drawing.Point(240, 42);
            this.cboxXMP2_CL72.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL72.Name = "cboxXMP2_CL72";
            this.cboxXMP2_CL72.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL72.TabIndex = 1;
            this.cboxXMP2_CL72.Text = "72";
            this.cboxXMP2_CL72.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL60
            // 
            this.cboxXMP2_CL60.AutoSize = true;
            this.cboxXMP2_CL60.Location = new System.Drawing.Point(194, 21);
            this.cboxXMP2_CL60.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL60.Name = "cboxXMP2_CL60";
            this.cboxXMP2_CL60.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL60.TabIndex = 1;
            this.cboxXMP2_CL60.Text = "60";
            this.cboxXMP2_CL60.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL48
            // 
            this.cboxXMP2_CL48.AutoSize = true;
            this.cboxXMP2_CL48.Location = new System.Drawing.Point(103, 106);
            this.cboxXMP2_CL48.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL48.Name = "cboxXMP2_CL48";
            this.cboxXMP2_CL48.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL48.TabIndex = 1;
            this.cboxXMP2_CL48.Text = "48";
            this.cboxXMP2_CL48.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL36
            // 
            this.cboxXMP2_CL36.AutoSize = true;
            this.cboxXMP2_CL36.Location = new System.Drawing.Point(57, 85);
            this.cboxXMP2_CL36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL36.Name = "cboxXMP2_CL36";
            this.cboxXMP2_CL36.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL36.TabIndex = 1;
            this.cboxXMP2_CL36.Text = "36";
            this.cboxXMP2_CL36.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL24
            // 
            this.cboxXMP2_CL24.AutoSize = true;
            this.cboxXMP2_CL24.Location = new System.Drawing.Point(11, 64);
            this.cboxXMP2_CL24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL24.Name = "cboxXMP2_CL24";
            this.cboxXMP2_CL24.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL24.TabIndex = 1;
            this.cboxXMP2_CL24.Text = "24";
            this.cboxXMP2_CL24.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL94
            // 
            this.cboxXMP2_CL94.AutoSize = true;
            this.cboxXMP2_CL94.Location = new System.Drawing.Point(331, 64);
            this.cboxXMP2_CL94.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL94.Name = "cboxXMP2_CL94";
            this.cboxXMP2_CL94.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL94.TabIndex = 1;
            this.cboxXMP2_CL94.Text = "94";
            this.cboxXMP2_CL94.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL82
            // 
            this.cboxXMP2_CL82.AutoSize = true;
            this.cboxXMP2_CL82.Location = new System.Drawing.Point(286, 42);
            this.cboxXMP2_CL82.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL82.Name = "cboxXMP2_CL82";
            this.cboxXMP2_CL82.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL82.TabIndex = 1;
            this.cboxXMP2_CL82.Text = "82";
            this.cboxXMP2_CL82.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL70
            // 
            this.cboxXMP2_CL70.AutoSize = true;
            this.cboxXMP2_CL70.Location = new System.Drawing.Point(240, 21);
            this.cboxXMP2_CL70.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL70.Name = "cboxXMP2_CL70";
            this.cboxXMP2_CL70.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL70.TabIndex = 1;
            this.cboxXMP2_CL70.Text = "70";
            this.cboxXMP2_CL70.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL58
            // 
            this.cboxXMP2_CL58.AutoSize = true;
            this.cboxXMP2_CL58.Location = new System.Drawing.Point(149, 106);
            this.cboxXMP2_CL58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL58.Name = "cboxXMP2_CL58";
            this.cboxXMP2_CL58.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL58.TabIndex = 1;
            this.cboxXMP2_CL58.Text = "58";
            this.cboxXMP2_CL58.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL46
            // 
            this.cboxXMP2_CL46.AutoSize = true;
            this.cboxXMP2_CL46.Location = new System.Drawing.Point(103, 85);
            this.cboxXMP2_CL46.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL46.Name = "cboxXMP2_CL46";
            this.cboxXMP2_CL46.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL46.TabIndex = 1;
            this.cboxXMP2_CL46.Text = "46";
            this.cboxXMP2_CL46.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL34
            // 
            this.cboxXMP2_CL34.AutoSize = true;
            this.cboxXMP2_CL34.Location = new System.Drawing.Point(57, 64);
            this.cboxXMP2_CL34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL34.Name = "cboxXMP2_CL34";
            this.cboxXMP2_CL34.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL34.TabIndex = 1;
            this.cboxXMP2_CL34.Text = "34";
            this.cboxXMP2_CL34.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL22
            // 
            this.cboxXMP2_CL22.AutoSize = true;
            this.cboxXMP2_CL22.Location = new System.Drawing.Point(11, 42);
            this.cboxXMP2_CL22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL22.Name = "cboxXMP2_CL22";
            this.cboxXMP2_CL22.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL22.TabIndex = 1;
            this.cboxXMP2_CL22.Text = "22";
            this.cboxXMP2_CL22.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL92
            // 
            this.cboxXMP2_CL92.AutoSize = true;
            this.cboxXMP2_CL92.Location = new System.Drawing.Point(331, 42);
            this.cboxXMP2_CL92.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL92.Name = "cboxXMP2_CL92";
            this.cboxXMP2_CL92.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL92.TabIndex = 0;
            this.cboxXMP2_CL92.Text = "92";
            this.cboxXMP2_CL92.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL80
            // 
            this.cboxXMP2_CL80.AutoSize = true;
            this.cboxXMP2_CL80.Location = new System.Drawing.Point(286, 21);
            this.cboxXMP2_CL80.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL80.Name = "cboxXMP2_CL80";
            this.cboxXMP2_CL80.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL80.TabIndex = 0;
            this.cboxXMP2_CL80.Text = "80";
            this.cboxXMP2_CL80.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL68
            // 
            this.cboxXMP2_CL68.AutoSize = true;
            this.cboxXMP2_CL68.Location = new System.Drawing.Point(194, 106);
            this.cboxXMP2_CL68.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL68.Name = "cboxXMP2_CL68";
            this.cboxXMP2_CL68.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL68.TabIndex = 0;
            this.cboxXMP2_CL68.Text = "68";
            this.cboxXMP2_CL68.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL56
            // 
            this.cboxXMP2_CL56.AutoSize = true;
            this.cboxXMP2_CL56.Location = new System.Drawing.Point(149, 85);
            this.cboxXMP2_CL56.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL56.Name = "cboxXMP2_CL56";
            this.cboxXMP2_CL56.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL56.TabIndex = 0;
            this.cboxXMP2_CL56.Text = "56";
            this.cboxXMP2_CL56.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL44
            // 
            this.cboxXMP2_CL44.AutoSize = true;
            this.cboxXMP2_CL44.Location = new System.Drawing.Point(103, 64);
            this.cboxXMP2_CL44.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL44.Name = "cboxXMP2_CL44";
            this.cboxXMP2_CL44.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL44.TabIndex = 0;
            this.cboxXMP2_CL44.Text = "44";
            this.cboxXMP2_CL44.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL32
            // 
            this.cboxXMP2_CL32.AutoSize = true;
            this.cboxXMP2_CL32.Location = new System.Drawing.Point(57, 42);
            this.cboxXMP2_CL32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL32.Name = "cboxXMP2_CL32";
            this.cboxXMP2_CL32.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL32.TabIndex = 0;
            this.cboxXMP2_CL32.Text = "32";
            this.cboxXMP2_CL32.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_CL20
            // 
            this.cboxXMP2_CL20.AutoSize = true;
            this.cboxXMP2_CL20.Location = new System.Drawing.Point(11, 21);
            this.cboxXMP2_CL20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_CL20.Name = "cboxXMP2_CL20";
            this.cboxXMP2_CL20.Size = new System.Drawing.Size(45, 19);
            this.cboxXMP2_CL20.TabIndex = 0;
            this.cboxXMP2_CL20.Text = "20";
            this.cboxXMP2_CL20.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.tboxXMP2_VMEM);
            this.groupBox16.Controls.Add(this.label116);
            this.groupBox16.Controls.Add(this.tboxXMP2_VPP);
            this.groupBox16.Controls.Add(this.label117);
            this.groupBox16.Controls.Add(this.tboxXMP2_VDDQ);
            this.groupBox16.Controls.Add(this.label118);
            this.groupBox16.Controls.Add(this.tboxXMP2_VDD);
            this.groupBox16.Controls.Add(this.label119);
            this.groupBox16.Location = new System.Drawing.Point(7, 81);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox16.Size = new System.Drawing.Size(600, 48);
            this.groupBox16.TabIndex = 4;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Voltages";
            // 
            // tboxXMP2_VMEM
            // 
            this.tboxXMP2_VMEM.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP2_VMEM.Location = new System.Drawing.Point(514, 15);
            this.tboxXMP2_VMEM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_VMEM.Name = "tboxXMP2_VMEM";
            this.tboxXMP2_VMEM.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP2_VMEM.TabIndex = 20;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(422, 20);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(89, 15);
            this.label116.TabIndex = 19;
            this.label116.Text = "VMEMCTRL:";
            // 
            // tboxXMP2_VPP
            // 
            this.tboxXMP2_VPP.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP2_VPP.Location = new System.Drawing.Point(331, 15);
            this.tboxXMP2_VPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_VPP.Name = "tboxXMP2_VPP";
            this.tboxXMP2_VPP.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP2_VPP.TabIndex = 18;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(281, 20);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(40, 15);
            this.label117.TabIndex = 17;
            this.label117.Text = "VPP:";
            // 
            // tboxXMP2_VDDQ
            // 
            this.tboxXMP2_VDDQ.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP2_VDDQ.Location = new System.Drawing.Point(189, 15);
            this.tboxXMP2_VDDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_VDDQ.Name = "tboxXMP2_VDDQ";
            this.tboxXMP2_VDDQ.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP2_VDDQ.TabIndex = 16;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(138, 20);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(52, 15);
            this.label118.TabIndex = 15;
            this.label118.Text = "VDDQ:";
            // 
            // tboxXMP2_VDD
            // 
            this.tboxXMP2_VDD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP2_VDD.Location = new System.Drawing.Point(56, 15);
            this.tboxXMP2_VDD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_VDD.Name = "tboxXMP2_VDD";
            this.tboxXMP2_VDD.Size = new System.Drawing.Size(54, 25);
            this.tboxXMP2_VDD.TabIndex = 14;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(13, 20);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(40, 15);
            this.label119.TabIndex = 0;
            this.label119.Text = "VDD:";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.cboxXMP2_RealTimeMemoryFrequencyOC);
            this.groupBox15.Controls.Add(this.cboxXMP2_IntelDynamicMemoryBoost);
            this.groupBox15.Controls.Add(this.comboxXMP2_CommandRate);
            this.groupBox15.Controls.Add(this.tboxXMP2_MegaTransfers);
            this.groupBox15.Controls.Add(this.tboxXMP2_Frequency);
            this.groupBox15.Controls.Add(this.updnXMP2_MinCycleTime);
            this.groupBox15.Controls.Add(this.label114);
            this.groupBox15.Controls.Add(this.label115);
            this.groupBox15.Location = new System.Drawing.Point(7, 4);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox15.Size = new System.Drawing.Size(600, 76);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Frequency";
            // 
            // cboxXMP2_RealTimeMemoryFrequencyOC
            // 
            this.cboxXMP2_RealTimeMemoryFrequencyOC.AutoSize = true;
            this.cboxXMP2_RealTimeMemoryFrequencyOC.Location = new System.Drawing.Point(353, 46);
            this.cboxXMP2_RealTimeMemoryFrequencyOC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_RealTimeMemoryFrequencyOC.Name = "cboxXMP2_RealTimeMemoryFrequencyOC";
            this.cboxXMP2_RealTimeMemoryFrequencyOC.Size = new System.Drawing.Size(241, 19);
            this.cboxXMP2_RealTimeMemoryFrequencyOC.TabIndex = 4;
            this.cboxXMP2_RealTimeMemoryFrequencyOC.Text = "Realtime Memory Frequency OC";
            this.cboxXMP2_RealTimeMemoryFrequencyOC.UseVisualStyleBackColor = true;
            // 
            // cboxXMP2_IntelDynamicMemoryBoost
            // 
            this.cboxXMP2_IntelDynamicMemoryBoost.AutoSize = true;
            this.cboxXMP2_IntelDynamicMemoryBoost.Location = new System.Drawing.Point(378, 18);
            this.cboxXMP2_IntelDynamicMemoryBoost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxXMP2_IntelDynamicMemoryBoost.Name = "cboxXMP2_IntelDynamicMemoryBoost";
            this.cboxXMP2_IntelDynamicMemoryBoost.Size = new System.Drawing.Size(218, 19);
            this.cboxXMP2_IntelDynamicMemoryBoost.TabIndex = 4;
            this.cboxXMP2_IntelDynamicMemoryBoost.Text = "Intel Dynamic Memory Boost";
            this.cboxXMP2_IntelDynamicMemoryBoost.UseVisualStyleBackColor = true;
            // 
            // comboxXMP2_CommandRate
            // 
            this.comboxXMP2_CommandRate.FormattingEnabled = true;
            this.comboxXMP2_CommandRate.Items.AddRange(new object[] {
            "_Undefined",
            "_1N",
            "_2N",
            "_3N"});
            this.comboxXMP2_CommandRate.Location = new System.Drawing.Point(128, 45);
            this.comboxXMP2_CommandRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboxXMP2_CommandRate.Name = "comboxXMP2_CommandRate";
            this.comboxXMP2_CommandRate.Size = new System.Drawing.Size(105, 23);
            this.comboxXMP2_CommandRate.TabIndex = 3;
            // 
            // tboxXMP2_MegaTransfers
            // 
            this.tboxXMP2_MegaTransfers.Enabled = false;
            this.tboxXMP2_MegaTransfers.Location = new System.Drawing.Point(285, 15);
            this.tboxXMP2_MegaTransfers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_MegaTransfers.Name = "tboxXMP2_MegaTransfers";
            this.tboxXMP2_MegaTransfers.Size = new System.Drawing.Size(79, 25);
            this.tboxXMP2_MegaTransfers.TabIndex = 2;
            // 
            // tboxXMP2_Frequency
            // 
            this.tboxXMP2_Frequency.Enabled = false;
            this.tboxXMP2_Frequency.Location = new System.Drawing.Point(208, 15);
            this.tboxXMP2_Frequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_Frequency.Name = "tboxXMP2_Frequency";
            this.tboxXMP2_Frequency.Size = new System.Drawing.Size(69, 25);
            this.tboxXMP2_Frequency.TabIndex = 2;
            // 
            // updnXMP2_MinCycleTime
            // 
            this.updnXMP2_MinCycleTime.Location = new System.Drawing.Point(128, 15);
            this.updnXMP2_MinCycleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updnXMP2_MinCycleTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.updnXMP2_MinCycleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnXMP2_MinCycleTime.Name = "updnXMP2_MinCycleTime";
            this.updnXMP2_MinCycleTime.Size = new System.Drawing.Size(73, 25);
            this.updnXMP2_MinCycleTime.TabIndex = 1;
            this.updnXMP2_MinCycleTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnXMP2_MinCycleTime.ValueChanged += new System.EventHandler(this.updnXMP2_MinCycleTime_ValueChanged);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(7, 49);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(112, 15);
            this.label114.TabIndex = 0;
            this.label114.Text = "Command Rate:";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(7, 21);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(112, 15);
            this.label115.TabIndex = 0;
            this.label115.Text = "Min Cycle Time:";
            // 
            // tabPageSPD_EXPO1
            // 
            this.tabPageSPD_EXPO1.Controls.Add(this.groupBox10);
            this.tabPageSPD_EXPO1.Controls.Add(this.groupBox11);
            this.tabPageSPD_EXPO1.Controls.Add(this.groupBox13);
            this.tabPageSPD_EXPO1.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_EXPO1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_EXPO1.Name = "tabPageSPD_EXPO1";
            this.tabPageSPD_EXPO1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_EXPO1.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_EXPO1.TabIndex = 5;
            this.tabPageSPD_EXPO1.Text = "EXPO1";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblEXPO1_tRTP);
            this.groupBox10.Controls.Add(this.lblEXPO1_tCCD_S_WTR);
            this.groupBox10.Controls.Add(this.lblEXPO1_tCCD_L_WTR);
            this.groupBox10.Controls.Add(this.lblEXPO1_tFAW);
            this.groupBox10.Controls.Add(this.lblEXPO1_tCCD_L_WR2);
            this.groupBox10.Controls.Add(this.lblEXPO1_tCCD_L_WR);
            this.groupBox10.Controls.Add(this.lblEXPO1_tCCD_L);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRRD_L);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRTP);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tCCD_S_WTR);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tCCD_L_WTR);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tFAW);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tCCD_L_WR2);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tCCD_L_WR);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tCCD_L);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRRD_L);
            this.groupBox10.Controls.Add(this.label58);
            this.groupBox10.Controls.Add(this.label59);
            this.groupBox10.Controls.Add(this.label60);
            this.groupBox10.Controls.Add(this.label61);
            this.groupBox10.Controls.Add(this.label62);
            this.groupBox10.Controls.Add(this.label63);
            this.groupBox10.Controls.Add(this.label64);
            this.groupBox10.Controls.Add(this.label65);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRFC);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRFC2);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRFC1);
            this.groupBox10.Controls.Add(this.lblEXPO1_tWR);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRC);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRAS);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRP);
            this.groupBox10.Controls.Add(this.lblEXPO1_tRCD);
            this.groupBox10.Controls.Add(this.lblEXPO1_tAA);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRFCsb);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRFC2);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRFC1);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tWR);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRC);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRAS);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRP);
            this.groupBox10.Controls.Add(this.label91);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tRCD);
            this.groupBox10.Controls.Add(this.tboxEXPO1_tAA);
            this.groupBox10.Controls.Add(this.label92);
            this.groupBox10.Controls.Add(this.label93);
            this.groupBox10.Controls.Add(this.label94);
            this.groupBox10.Controls.Add(this.label95);
            this.groupBox10.Controls.Add(this.label96);
            this.groupBox10.Controls.Add(this.label97);
            this.groupBox10.Controls.Add(this.label99);
            this.groupBox10.Controls.Add(this.label100);
            this.groupBox10.Controls.Add(this.label101);
            this.groupBox10.Controls.Add(this.label102);
            this.groupBox10.Controls.Add(this.label103);
            this.groupBox10.Controls.Add(this.label104);
            this.groupBox10.Controls.Add(this.label105);
            this.groupBox10.Controls.Add(this.label106);
            this.groupBox10.Location = new System.Drawing.Point(7, 105);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(600, 296);
            this.groupBox10.TabIndex = 4;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Timings";
            // 
            // lblEXPO1_tRTP
            // 
            this.lblEXPO1_tRTP.AutoSize = true;
            this.lblEXPO1_tRTP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRTP.Location = new System.Drawing.Point(425, 235);
            this.lblEXPO1_tRTP.Name = "lblEXPO1_tRTP";
            this.lblEXPO1_tRTP.Size = new System.Drawing.Size(39, 20);
            this.lblEXPO1_tRTP.TabIndex = 50;
            this.lblEXPO1_tRTP.Text = "tRTP";
            // 
            // lblEXPO1_tCCD_S_WTR
            // 
            this.lblEXPO1_tCCD_S_WTR.AutoSize = true;
            this.lblEXPO1_tCCD_S_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tCCD_S_WTR.Location = new System.Drawing.Point(425, 212);
            this.lblEXPO1_tCCD_S_WTR.Name = "lblEXPO1_tCCD_S_WTR";
            this.lblEXPO1_tCCD_S_WTR.Size = new System.Drawing.Size(94, 20);
            this.lblEXPO1_tCCD_S_WTR.TabIndex = 51;
            this.lblEXPO1_tCCD_S_WTR.Text = "tCCD_S_WTR";
            // 
            // lblEXPO1_tCCD_L_WTR
            // 
            this.lblEXPO1_tCCD_L_WTR.AutoSize = true;
            this.lblEXPO1_tCCD_L_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tCCD_L_WTR.Location = new System.Drawing.Point(425, 185);
            this.lblEXPO1_tCCD_L_WTR.Name = "lblEXPO1_tCCD_L_WTR";
            this.lblEXPO1_tCCD_L_WTR.Size = new System.Drawing.Size(93, 20);
            this.lblEXPO1_tCCD_L_WTR.TabIndex = 47;
            this.lblEXPO1_tCCD_L_WTR.Text = "tCCD_L_WTR";
            // 
            // lblEXPO1_tFAW
            // 
            this.lblEXPO1_tFAW.AutoSize = true;
            this.lblEXPO1_tFAW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tFAW.Location = new System.Drawing.Point(425, 158);
            this.lblEXPO1_tFAW.Name = "lblEXPO1_tFAW";
            this.lblEXPO1_tFAW.Size = new System.Drawing.Size(43, 20);
            this.lblEXPO1_tFAW.TabIndex = 48;
            this.lblEXPO1_tFAW.Text = "tFAW";
            // 
            // lblEXPO1_tCCD_L_WR2
            // 
            this.lblEXPO1_tCCD_L_WR2.AutoSize = true;
            this.lblEXPO1_tCCD_L_WR2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tCCD_L_WR2.Location = new System.Drawing.Point(425, 129);
            this.lblEXPO1_tCCD_L_WR2.Name = "lblEXPO1_tCCD_L_WR2";
            this.lblEXPO1_tCCD_L_WR2.Size = new System.Drawing.Size(93, 20);
            this.lblEXPO1_tCCD_L_WR2.TabIndex = 49;
            this.lblEXPO1_tCCD_L_WR2.Text = "tCCD_L_WR2";
            // 
            // lblEXPO1_tCCD_L_WR
            // 
            this.lblEXPO1_tCCD_L_WR.AutoSize = true;
            this.lblEXPO1_tCCD_L_WR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tCCD_L_WR.Location = new System.Drawing.Point(425, 101);
            this.lblEXPO1_tCCD_L_WR.Name = "lblEXPO1_tCCD_L_WR";
            this.lblEXPO1_tCCD_L_WR.Size = new System.Drawing.Size(85, 20);
            this.lblEXPO1_tCCD_L_WR.TabIndex = 44;
            this.lblEXPO1_tCCD_L_WR.Text = "tCCD_L_WR";
            // 
            // lblEXPO1_tCCD_L
            // 
            this.lblEXPO1_tCCD_L.AutoSize = true;
            this.lblEXPO1_tCCD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tCCD_L.Location = new System.Drawing.Point(425, 74);
            this.lblEXPO1_tCCD_L.Name = "lblEXPO1_tCCD_L";
            this.lblEXPO1_tCCD_L.Size = new System.Drawing.Size(56, 20);
            this.lblEXPO1_tCCD_L.TabIndex = 45;
            this.lblEXPO1_tCCD_L.Text = "tCCD_L";
            // 
            // lblEXPO1_tRRD_L
            // 
            this.lblEXPO1_tRRD_L.AutoSize = true;
            this.lblEXPO1_tRRD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRRD_L.Location = new System.Drawing.Point(425, 46);
            this.lblEXPO1_tRRD_L.Name = "lblEXPO1_tRRD_L";
            this.lblEXPO1_tRRD_L.Size = new System.Drawing.Size(56, 20);
            this.lblEXPO1_tRRD_L.TabIndex = 46;
            this.lblEXPO1_tRRD_L.Text = "tRRD_L";
            // 
            // tboxEXPO1_tRTP
            // 
            this.tboxEXPO1_tRTP.Location = new System.Drawing.Point(350, 232);
            this.tboxEXPO1_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRTP.Name = "tboxEXPO1_tRTP";
            this.tboxEXPO1_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRTP.TabIndex = 42;
            // 
            // tboxEXPO1_tCCD_S_WTR
            // 
            this.tboxEXPO1_tCCD_S_WTR.Location = new System.Drawing.Point(350, 205);
            this.tboxEXPO1_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tCCD_S_WTR.Name = "tboxEXPO1_tCCD_S_WTR";
            this.tboxEXPO1_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tCCD_S_WTR.TabIndex = 43;
            // 
            // tboxEXPO1_tCCD_L_WTR
            // 
            this.tboxEXPO1_tCCD_L_WTR.Location = new System.Drawing.Point(350, 178);
            this.tboxEXPO1_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tCCD_L_WTR.Name = "tboxEXPO1_tCCD_L_WTR";
            this.tboxEXPO1_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tCCD_L_WTR.TabIndex = 40;
            // 
            // tboxEXPO1_tFAW
            // 
            this.tboxEXPO1_tFAW.Location = new System.Drawing.Point(350, 150);
            this.tboxEXPO1_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tFAW.Name = "tboxEXPO1_tFAW";
            this.tboxEXPO1_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tFAW.TabIndex = 41;
            // 
            // tboxEXPO1_tCCD_L_WR2
            // 
            this.tboxEXPO1_tCCD_L_WR2.Location = new System.Drawing.Point(350, 122);
            this.tboxEXPO1_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tCCD_L_WR2.Name = "tboxEXPO1_tCCD_L_WR2";
            this.tboxEXPO1_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tCCD_L_WR2.TabIndex = 38;
            // 
            // tboxEXPO1_tCCD_L_WR
            // 
            this.tboxEXPO1_tCCD_L_WR.Location = new System.Drawing.Point(350, 95);
            this.tboxEXPO1_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tCCD_L_WR.Name = "tboxEXPO1_tCCD_L_WR";
            this.tboxEXPO1_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tCCD_L_WR.TabIndex = 39;
            // 
            // tboxEXPO1_tCCD_L
            // 
            this.tboxEXPO1_tCCD_L.Location = new System.Drawing.Point(350, 68);
            this.tboxEXPO1_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tCCD_L.Name = "tboxEXPO1_tCCD_L";
            this.tboxEXPO1_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tCCD_L.TabIndex = 31;
            // 
            // tboxEXPO1_tRRD_L
            // 
            this.tboxEXPO1_tRRD_L.Location = new System.Drawing.Point(350, 40);
            this.tboxEXPO1_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRRD_L.Name = "tboxEXPO1_tRRD_L";
            this.tboxEXPO1_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRRD_L.TabIndex = 30;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(305, 236);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(46, 20);
            this.label58.TabIndex = 36;
            this.label58.Text = "tRTP :";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(257, 209);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(101, 20);
            this.label59.TabIndex = 37;
            this.label59.Text = "tCCD_S_WTR :";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(257, 181);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(100, 20);
            this.label60.TabIndex = 33;
            this.label60.Text = "tCCD_L_WTR :";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(298, 154);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(50, 20);
            this.label61.TabIndex = 34;
            this.label61.Text = "tFAW :";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(256, 125);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(100, 20);
            this.label62.TabIndex = 35;
            this.label62.Text = "tCCD_L_WR2 :";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(263, 99);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(92, 20);
            this.label63.TabIndex = 29;
            this.label63.Text = "tCCD_L_WR :";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(289, 71);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(63, 20);
            this.label64.TabIndex = 32;
            this.label64.Text = "tCCD_L :";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(289, 44);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(63, 20);
            this.label65.TabIndex = 28;
            this.label65.Text = "tRRD_L :";
            // 
            // lblEXPO1_tRFC
            // 
            this.lblEXPO1_tRFC.AutoSize = true;
            this.lblEXPO1_tRFC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRFC.Location = new System.Drawing.Point(159, 268);
            this.lblEXPO1_tRFC.Name = "lblEXPO1_tRFC";
            this.lblEXPO1_tRFC.Size = new System.Drawing.Size(39, 20);
            this.lblEXPO1_tRFC.TabIndex = 25;
            this.lblEXPO1_tRFC.Text = "tRFC";
            // 
            // lblEXPO1_tRFC2
            // 
            this.lblEXPO1_tRFC2.AutoSize = true;
            this.lblEXPO1_tRFC2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRFC2.Location = new System.Drawing.Point(159, 240);
            this.lblEXPO1_tRFC2.Name = "lblEXPO1_tRFC2";
            this.lblEXPO1_tRFC2.Size = new System.Drawing.Size(47, 20);
            this.lblEXPO1_tRFC2.TabIndex = 26;
            this.lblEXPO1_tRFC2.Text = "tRFC2";
            // 
            // lblEXPO1_tRFC1
            // 
            this.lblEXPO1_tRFC1.AutoSize = true;
            this.lblEXPO1_tRFC1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRFC1.Location = new System.Drawing.Point(159, 212);
            this.lblEXPO1_tRFC1.Name = "lblEXPO1_tRFC1";
            this.lblEXPO1_tRFC1.Size = new System.Drawing.Size(47, 20);
            this.lblEXPO1_tRFC1.TabIndex = 27;
            this.lblEXPO1_tRFC1.Text = "tRFC1";
            // 
            // lblEXPO1_tWR
            // 
            this.lblEXPO1_tWR.AutoSize = true;
            this.lblEXPO1_tWR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tWR.Location = new System.Drawing.Point(159, 185);
            this.lblEXPO1_tWR.Name = "lblEXPO1_tWR";
            this.lblEXPO1_tWR.Size = new System.Drawing.Size(37, 20);
            this.lblEXPO1_tWR.TabIndex = 22;
            this.lblEXPO1_tWR.Text = "tWR";
            // 
            // lblEXPO1_tRC
            // 
            this.lblEXPO1_tRC.AutoSize = true;
            this.lblEXPO1_tRC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRC.Location = new System.Drawing.Point(159, 158);
            this.lblEXPO1_tRC.Name = "lblEXPO1_tRC";
            this.lblEXPO1_tRC.Size = new System.Drawing.Size(32, 20);
            this.lblEXPO1_tRC.TabIndex = 23;
            this.lblEXPO1_tRC.Text = "tRC";
            // 
            // lblEXPO1_tRAS
            // 
            this.lblEXPO1_tRAS.AutoSize = true;
            this.lblEXPO1_tRAS.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRAS.Location = new System.Drawing.Point(159, 129);
            this.lblEXPO1_tRAS.Name = "lblEXPO1_tRAS";
            this.lblEXPO1_tRAS.Size = new System.Drawing.Size(41, 20);
            this.lblEXPO1_tRAS.TabIndex = 24;
            this.lblEXPO1_tRAS.Text = "tRAS";
            // 
            // lblEXPO1_tRP
            // 
            this.lblEXPO1_tRP.AutoSize = true;
            this.lblEXPO1_tRP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRP.Location = new System.Drawing.Point(159, 101);
            this.lblEXPO1_tRP.Name = "lblEXPO1_tRP";
            this.lblEXPO1_tRP.Size = new System.Drawing.Size(31, 20);
            this.lblEXPO1_tRP.TabIndex = 19;
            this.lblEXPO1_tRP.Text = "tRP";
            // 
            // lblEXPO1_tRCD
            // 
            this.lblEXPO1_tRCD.AutoSize = true;
            this.lblEXPO1_tRCD.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tRCD.Location = new System.Drawing.Point(159, 74);
            this.lblEXPO1_tRCD.Name = "lblEXPO1_tRCD";
            this.lblEXPO1_tRCD.Size = new System.Drawing.Size(43, 20);
            this.lblEXPO1_tRCD.TabIndex = 20;
            this.lblEXPO1_tRCD.Text = "tRCD";
            // 
            // lblEXPO1_tAA
            // 
            this.lblEXPO1_tAA.AutoSize = true;
            this.lblEXPO1_tAA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO1_tAA.Location = new System.Drawing.Point(159, 46);
            this.lblEXPO1_tAA.Name = "lblEXPO1_tAA";
            this.lblEXPO1_tAA.Size = new System.Drawing.Size(34, 20);
            this.lblEXPO1_tAA.TabIndex = 21;
            this.lblEXPO1_tAA.Text = "tAA";
            // 
            // tboxEXPO1_tRFCsb
            // 
            this.tboxEXPO1_tRFCsb.Location = new System.Drawing.Point(83, 262);
            this.tboxEXPO1_tRFCsb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRFCsb.Name = "tboxEXPO1_tRFCsb";
            this.tboxEXPO1_tRFCsb.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRFCsb.TabIndex = 18;
            // 
            // tboxEXPO1_tRFC2
            // 
            this.tboxEXPO1_tRFC2.Location = new System.Drawing.Point(83, 235);
            this.tboxEXPO1_tRFC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRFC2.Name = "tboxEXPO1_tRFC2";
            this.tboxEXPO1_tRFC2.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRFC2.TabIndex = 16;
            // 
            // tboxEXPO1_tRFC1
            // 
            this.tboxEXPO1_tRFC1.Location = new System.Drawing.Point(83, 208);
            this.tboxEXPO1_tRFC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRFC1.Name = "tboxEXPO1_tRFC1";
            this.tboxEXPO1_tRFC1.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRFC1.TabIndex = 17;
            // 
            // tboxEXPO1_tWR
            // 
            this.tboxEXPO1_tWR.Location = new System.Drawing.Point(83, 180);
            this.tboxEXPO1_tWR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tWR.Name = "tboxEXPO1_tWR";
            this.tboxEXPO1_tWR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tWR.TabIndex = 14;
            // 
            // tboxEXPO1_tRC
            // 
            this.tboxEXPO1_tRC.Location = new System.Drawing.Point(83, 152);
            this.tboxEXPO1_tRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRC.Name = "tboxEXPO1_tRC";
            this.tboxEXPO1_tRC.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRC.TabIndex = 15;
            // 
            // tboxEXPO1_tRAS
            // 
            this.tboxEXPO1_tRAS.Location = new System.Drawing.Point(83, 125);
            this.tboxEXPO1_tRAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRAS.Name = "tboxEXPO1_tRAS";
            this.tboxEXPO1_tRAS.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRAS.TabIndex = 12;
            // 
            // tboxEXPO1_tRP
            // 
            this.tboxEXPO1_tRP.Location = new System.Drawing.Point(83, 98);
            this.tboxEXPO1_tRP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRP.Name = "tboxEXPO1_tRP";
            this.tboxEXPO1_tRP.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRP.TabIndex = 13;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(7, 266);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(46, 20);
            this.label91.TabIndex = 9;
            this.label91.Text = "tRFC :";
            // 
            // tboxEXPO1_tRCD
            // 
            this.tboxEXPO1_tRCD.Location = new System.Drawing.Point(83, 70);
            this.tboxEXPO1_tRCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tRCD.Name = "tboxEXPO1_tRCD";
            this.tboxEXPO1_tRCD.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tRCD.TabIndex = 2;
            // 
            // tboxEXPO1_tAA
            // 
            this.tboxEXPO1_tAA.Location = new System.Drawing.Point(83, 42);
            this.tboxEXPO1_tAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_tAA.Name = "tboxEXPO1_tAA";
            this.tboxEXPO1_tAA.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO1_tAA.TabIndex = 2;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(13, 239);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(54, 20);
            this.label92.TabIndex = 10;
            this.label92.Text = "tRFC2 :";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(13, 211);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(54, 20);
            this.label93.TabIndex = 11;
            this.label93.Text = "tRFC1 :";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(22, 184);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(44, 20);
            this.label94.TabIndex = 6;
            this.label94.Text = "tWR :";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(22, 156);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(39, 20);
            this.label95.TabIndex = 7;
            this.label95.Text = "tRC :";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(22, 128);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(48, 20);
            this.label96.TabIndex = 8;
            this.label96.Text = "tRAS :";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label97.Location = new System.Drawing.Point(425, 21);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(48, 19);
            this.label97.TabIndex = 3;
            this.label97.Text = "Ticks";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label99.Location = new System.Drawing.Point(343, 21);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(82, 19);
            this.label99.TabIndex = 4;
            this.label99.Text = "Value (ps)";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label100.Location = new System.Drawing.Point(282, 21);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(53, 19);
            this.label100.TabIndex = 5;
            this.label100.Text = "Name";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label101.Location = new System.Drawing.Point(153, 21);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(48, 19);
            this.label101.TabIndex = 2;
            this.label101.Text = "Ticks";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(80, 21);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(82, 19);
            this.label102.TabIndex = 2;
            this.label102.Text = "Value (ps)";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(22, 101);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(38, 20);
            this.label103.TabIndex = 2;
            this.label103.Text = "tRP :";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(22, 74);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(50, 20);
            this.label104.TabIndex = 2;
            this.label104.Text = "tRCD :";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(22, 46);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(41, 20);
            this.label105.TabIndex = 2;
            this.label105.Text = "tAA :";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(19, 21);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(53, 19);
            this.label106.TabIndex = 2;
            this.label106.Text = "Name";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tboxEXPO1_VPP);
            this.groupBox11.Controls.Add(this.label108);
            this.groupBox11.Controls.Add(this.tboxEXPO1_VDDQ);
            this.groupBox11.Controls.Add(this.label109);
            this.groupBox11.Controls.Add(this.tboxEXPO1_VDD);
            this.groupBox11.Controls.Add(this.label110);
            this.groupBox11.Location = new System.Drawing.Point(7, 55);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox11.Size = new System.Drawing.Size(600, 48);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Voltages";
            // 
            // tboxEXPO1_VPP
            // 
            this.tboxEXPO1_VPP.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO1_VPP.Location = new System.Drawing.Point(331, 15);
            this.tboxEXPO1_VPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_VPP.Name = "tboxEXPO1_VPP";
            this.tboxEXPO1_VPP.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO1_VPP.TabIndex = 18;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(281, 20);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(40, 15);
            this.label108.TabIndex = 17;
            this.label108.Text = "VPP:";
            // 
            // tboxEXPO1_VDDQ
            // 
            this.tboxEXPO1_VDDQ.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO1_VDDQ.Location = new System.Drawing.Point(189, 15);
            this.tboxEXPO1_VDDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_VDDQ.Name = "tboxEXPO1_VDDQ";
            this.tboxEXPO1_VDDQ.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO1_VDDQ.TabIndex = 16;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(138, 20);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(52, 15);
            this.label109.TabIndex = 15;
            this.label109.Text = "VDDQ:";
            // 
            // tboxEXPO1_VDD
            // 
            this.tboxEXPO1_VDD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO1_VDD.Location = new System.Drawing.Point(56, 15);
            this.tboxEXPO1_VDD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_VDD.Name = "tboxEXPO1_VDD";
            this.tboxEXPO1_VDD.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO1_VDD.TabIndex = 14;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(13, 20);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(40, 15);
            this.label110.TabIndex = 0;
            this.label110.Text = "VDD:";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.tboxEXPO1_MegaTransfers);
            this.groupBox13.Controls.Add(this.tboxEXPO1_Frequency);
            this.groupBox13.Controls.Add(this.updnEXPO1_MinCycleTime);
            this.groupBox13.Controls.Add(this.label112);
            this.groupBox13.Location = new System.Drawing.Point(7, 8);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox13.Size = new System.Drawing.Size(600, 46);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Frequency";
            // 
            // tboxEXPO1_MegaTransfers
            // 
            this.tboxEXPO1_MegaTransfers.Enabled = false;
            this.tboxEXPO1_MegaTransfers.Location = new System.Drawing.Point(285, 14);
            this.tboxEXPO1_MegaTransfers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_MegaTransfers.Name = "tboxEXPO1_MegaTransfers";
            this.tboxEXPO1_MegaTransfers.Size = new System.Drawing.Size(79, 25);
            this.tboxEXPO1_MegaTransfers.TabIndex = 2;
            // 
            // tboxEXPO1_Frequency
            // 
            this.tboxEXPO1_Frequency.Enabled = false;
            this.tboxEXPO1_Frequency.Location = new System.Drawing.Point(208, 14);
            this.tboxEXPO1_Frequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO1_Frequency.Name = "tboxEXPO1_Frequency";
            this.tboxEXPO1_Frequency.Size = new System.Drawing.Size(69, 25);
            this.tboxEXPO1_Frequency.TabIndex = 2;
            // 
            // updnEXPO1_MinCycleTime
            // 
            this.updnEXPO1_MinCycleTime.Location = new System.Drawing.Point(128, 15);
            this.updnEXPO1_MinCycleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updnEXPO1_MinCycleTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.updnEXPO1_MinCycleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnEXPO1_MinCycleTime.Name = "updnEXPO1_MinCycleTime";
            this.updnEXPO1_MinCycleTime.Size = new System.Drawing.Size(73, 25);
            this.updnEXPO1_MinCycleTime.TabIndex = 1;
            this.updnEXPO1_MinCycleTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnEXPO1_MinCycleTime.ValueChanged += new System.EventHandler(this.updnEXPO1_MinCycleTime_ValueChanged);
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(7, 21);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(112, 15);
            this.label112.TabIndex = 0;
            this.label112.Text = "Min Cycle Time:";
            // 
            // tabPageSPD_EXPO2
            // 
            this.tabPageSPD_EXPO2.Controls.Add(this.groupBox19);
            this.tabPageSPD_EXPO2.Controls.Add(this.groupBox14);
            this.tabPageSPD_EXPO2.Controls.Add(this.groupBox12);
            this.tabPageSPD_EXPO2.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_EXPO2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_EXPO2.Name = "tabPageSPD_EXPO2";
            this.tabPageSPD_EXPO2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_EXPO2.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_EXPO2.TabIndex = 4;
            this.tabPageSPD_EXPO2.Text = "EXPO2";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.lblEXPO2_tRTP);
            this.groupBox19.Controls.Add(this.lblEXPO2_tCCD_S_WTR);
            this.groupBox19.Controls.Add(this.lblEXPO2_tCCD_L_WTR);
            this.groupBox19.Controls.Add(this.lblEXPO2_tFAW);
            this.groupBox19.Controls.Add(this.lblEXPO2_tCCD_L_WR2);
            this.groupBox19.Controls.Add(this.lblEXPO2_tCCD_L_WR);
            this.groupBox19.Controls.Add(this.lblEXPO2_tCCD_L);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRRD_L);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRTP);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tCCD_S_WTR);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tCCD_L_WTR);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tFAW);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tCCD_L_WR2);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tCCD_L_WR);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tCCD_L);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRRD_L);
            this.groupBox19.Controls.Add(this.label86);
            this.groupBox19.Controls.Add(this.label87);
            this.groupBox19.Controls.Add(this.label88);
            this.groupBox19.Controls.Add(this.label89);
            this.groupBox19.Controls.Add(this.label90);
            this.groupBox19.Controls.Add(this.label98);
            this.groupBox19.Controls.Add(this.label107);
            this.groupBox19.Controls.Add(this.label111);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRFC);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRFC2);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRFC1);
            this.groupBox19.Controls.Add(this.lblEXPO2_tWR);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRC);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRAS);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRP);
            this.groupBox19.Controls.Add(this.lblEXPO2_tRCD);
            this.groupBox19.Controls.Add(this.lblEXPO2_tAA);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRFCsb);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRFC2);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRFC1);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tWR);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRC);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRAS);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRP);
            this.groupBox19.Controls.Add(this.label136);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tRCD);
            this.groupBox19.Controls.Add(this.tboxEXPO2_tAA);
            this.groupBox19.Controls.Add(this.label137);
            this.groupBox19.Controls.Add(this.label138);
            this.groupBox19.Controls.Add(this.label139);
            this.groupBox19.Controls.Add(this.label140);
            this.groupBox19.Controls.Add(this.label141);
            this.groupBox19.Controls.Add(this.label142);
            this.groupBox19.Controls.Add(this.label143);
            this.groupBox19.Controls.Add(this.label144);
            this.groupBox19.Controls.Add(this.label161);
            this.groupBox19.Controls.Add(this.label162);
            this.groupBox19.Controls.Add(this.label163);
            this.groupBox19.Controls.Add(this.label164);
            this.groupBox19.Controls.Add(this.label165);
            this.groupBox19.Controls.Add(this.label166);
            this.groupBox19.Location = new System.Drawing.Point(7, 105);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox19.Size = new System.Drawing.Size(600, 296);
            this.groupBox19.TabIndex = 5;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Timings";
            // 
            // lblEXPO2_tRTP
            // 
            this.lblEXPO2_tRTP.AutoSize = true;
            this.lblEXPO2_tRTP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRTP.Location = new System.Drawing.Point(425, 235);
            this.lblEXPO2_tRTP.Name = "lblEXPO2_tRTP";
            this.lblEXPO2_tRTP.Size = new System.Drawing.Size(39, 20);
            this.lblEXPO2_tRTP.TabIndex = 50;
            this.lblEXPO2_tRTP.Text = "tRTP";
            // 
            // lblEXPO2_tCCD_S_WTR
            // 
            this.lblEXPO2_tCCD_S_WTR.AutoSize = true;
            this.lblEXPO2_tCCD_S_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tCCD_S_WTR.Location = new System.Drawing.Point(425, 212);
            this.lblEXPO2_tCCD_S_WTR.Name = "lblEXPO2_tCCD_S_WTR";
            this.lblEXPO2_tCCD_S_WTR.Size = new System.Drawing.Size(94, 20);
            this.lblEXPO2_tCCD_S_WTR.TabIndex = 51;
            this.lblEXPO2_tCCD_S_WTR.Text = "tCCD_S_WTR";
            // 
            // lblEXPO2_tCCD_L_WTR
            // 
            this.lblEXPO2_tCCD_L_WTR.AutoSize = true;
            this.lblEXPO2_tCCD_L_WTR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tCCD_L_WTR.Location = new System.Drawing.Point(425, 185);
            this.lblEXPO2_tCCD_L_WTR.Name = "lblEXPO2_tCCD_L_WTR";
            this.lblEXPO2_tCCD_L_WTR.Size = new System.Drawing.Size(93, 20);
            this.lblEXPO2_tCCD_L_WTR.TabIndex = 47;
            this.lblEXPO2_tCCD_L_WTR.Text = "tCCD_L_WTR";
            // 
            // lblEXPO2_tFAW
            // 
            this.lblEXPO2_tFAW.AutoSize = true;
            this.lblEXPO2_tFAW.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tFAW.Location = new System.Drawing.Point(425, 158);
            this.lblEXPO2_tFAW.Name = "lblEXPO2_tFAW";
            this.lblEXPO2_tFAW.Size = new System.Drawing.Size(43, 20);
            this.lblEXPO2_tFAW.TabIndex = 48;
            this.lblEXPO2_tFAW.Text = "tFAW";
            // 
            // lblEXPO2_tCCD_L_WR2
            // 
            this.lblEXPO2_tCCD_L_WR2.AutoSize = true;
            this.lblEXPO2_tCCD_L_WR2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tCCD_L_WR2.Location = new System.Drawing.Point(425, 129);
            this.lblEXPO2_tCCD_L_WR2.Name = "lblEXPO2_tCCD_L_WR2";
            this.lblEXPO2_tCCD_L_WR2.Size = new System.Drawing.Size(93, 20);
            this.lblEXPO2_tCCD_L_WR2.TabIndex = 49;
            this.lblEXPO2_tCCD_L_WR2.Text = "tCCD_L_WR2";
            // 
            // lblEXPO2_tCCD_L_WR
            // 
            this.lblEXPO2_tCCD_L_WR.AutoSize = true;
            this.lblEXPO2_tCCD_L_WR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tCCD_L_WR.Location = new System.Drawing.Point(425, 101);
            this.lblEXPO2_tCCD_L_WR.Name = "lblEXPO2_tCCD_L_WR";
            this.lblEXPO2_tCCD_L_WR.Size = new System.Drawing.Size(85, 20);
            this.lblEXPO2_tCCD_L_WR.TabIndex = 44;
            this.lblEXPO2_tCCD_L_WR.Text = "tCCD_L_WR";
            // 
            // lblEXPO2_tCCD_L
            // 
            this.lblEXPO2_tCCD_L.AutoSize = true;
            this.lblEXPO2_tCCD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tCCD_L.Location = new System.Drawing.Point(425, 74);
            this.lblEXPO2_tCCD_L.Name = "lblEXPO2_tCCD_L";
            this.lblEXPO2_tCCD_L.Size = new System.Drawing.Size(56, 20);
            this.lblEXPO2_tCCD_L.TabIndex = 45;
            this.lblEXPO2_tCCD_L.Text = "tCCD_L";
            // 
            // lblEXPO2_tRRD_L
            // 
            this.lblEXPO2_tRRD_L.AutoSize = true;
            this.lblEXPO2_tRRD_L.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRRD_L.Location = new System.Drawing.Point(425, 46);
            this.lblEXPO2_tRRD_L.Name = "lblEXPO2_tRRD_L";
            this.lblEXPO2_tRRD_L.Size = new System.Drawing.Size(56, 20);
            this.lblEXPO2_tRRD_L.TabIndex = 46;
            this.lblEXPO2_tRRD_L.Text = "tRRD_L";
            // 
            // tboxEXPO2_tRTP
            // 
            this.tboxEXPO2_tRTP.Location = new System.Drawing.Point(350, 232);
            this.tboxEXPO2_tRTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRTP.Name = "tboxEXPO2_tRTP";
            this.tboxEXPO2_tRTP.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRTP.TabIndex = 42;
            // 
            // tboxEXPO2_tCCD_S_WTR
            // 
            this.tboxEXPO2_tCCD_S_WTR.Location = new System.Drawing.Point(350, 205);
            this.tboxEXPO2_tCCD_S_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tCCD_S_WTR.Name = "tboxEXPO2_tCCD_S_WTR";
            this.tboxEXPO2_tCCD_S_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tCCD_S_WTR.TabIndex = 43;
            // 
            // tboxEXPO2_tCCD_L_WTR
            // 
            this.tboxEXPO2_tCCD_L_WTR.Location = new System.Drawing.Point(350, 178);
            this.tboxEXPO2_tCCD_L_WTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tCCD_L_WTR.Name = "tboxEXPO2_tCCD_L_WTR";
            this.tboxEXPO2_tCCD_L_WTR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tCCD_L_WTR.TabIndex = 40;
            // 
            // tboxEXPO2_tFAW
            // 
            this.tboxEXPO2_tFAW.Location = new System.Drawing.Point(350, 150);
            this.tboxEXPO2_tFAW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tFAW.Name = "tboxEXPO2_tFAW";
            this.tboxEXPO2_tFAW.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tFAW.TabIndex = 41;
            // 
            // tboxEXPO2_tCCD_L_WR2
            // 
            this.tboxEXPO2_tCCD_L_WR2.Location = new System.Drawing.Point(350, 122);
            this.tboxEXPO2_tCCD_L_WR2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tCCD_L_WR2.Name = "tboxEXPO2_tCCD_L_WR2";
            this.tboxEXPO2_tCCD_L_WR2.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tCCD_L_WR2.TabIndex = 38;
            // 
            // tboxEXPO2_tCCD_L_WR
            // 
            this.tboxEXPO2_tCCD_L_WR.Location = new System.Drawing.Point(350, 95);
            this.tboxEXPO2_tCCD_L_WR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tCCD_L_WR.Name = "tboxEXPO2_tCCD_L_WR";
            this.tboxEXPO2_tCCD_L_WR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tCCD_L_WR.TabIndex = 39;
            // 
            // tboxEXPO2_tCCD_L
            // 
            this.tboxEXPO2_tCCD_L.Location = new System.Drawing.Point(350, 68);
            this.tboxEXPO2_tCCD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tCCD_L.Name = "tboxEXPO2_tCCD_L";
            this.tboxEXPO2_tCCD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tCCD_L.TabIndex = 31;
            // 
            // tboxEXPO2_tRRD_L
            // 
            this.tboxEXPO2_tRRD_L.Location = new System.Drawing.Point(350, 40);
            this.tboxEXPO2_tRRD_L.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRRD_L.Name = "tboxEXPO2_tRRD_L";
            this.tboxEXPO2_tRRD_L.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRRD_L.TabIndex = 30;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(305, 236);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(46, 20);
            this.label86.TabIndex = 36;
            this.label86.Text = "tRTP :";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(257, 209);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(101, 20);
            this.label87.TabIndex = 37;
            this.label87.Text = "tCCD_S_WTR :";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(257, 181);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(100, 20);
            this.label88.TabIndex = 33;
            this.label88.Text = "tCCD_L_WTR :";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(298, 154);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(50, 20);
            this.label89.TabIndex = 34;
            this.label89.Text = "tFAW :";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(256, 125);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(100, 20);
            this.label90.TabIndex = 35;
            this.label90.Text = "tCCD_L_WR2 :";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(263, 99);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(92, 20);
            this.label98.TabIndex = 29;
            this.label98.Text = "tCCD_L_WR :";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(289, 71);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(63, 20);
            this.label107.TabIndex = 32;
            this.label107.Text = "tCCD_L :";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(289, 44);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(63, 20);
            this.label111.TabIndex = 28;
            this.label111.Text = "tRRD_L :";
            // 
            // lblEXPO2_tRFC
            // 
            this.lblEXPO2_tRFC.AutoSize = true;
            this.lblEXPO2_tRFC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRFC.Location = new System.Drawing.Point(159, 268);
            this.lblEXPO2_tRFC.Name = "lblEXPO2_tRFC";
            this.lblEXPO2_tRFC.Size = new System.Drawing.Size(39, 20);
            this.lblEXPO2_tRFC.TabIndex = 25;
            this.lblEXPO2_tRFC.Text = "tRFC";
            // 
            // lblEXPO2_tRFC2
            // 
            this.lblEXPO2_tRFC2.AutoSize = true;
            this.lblEXPO2_tRFC2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRFC2.Location = new System.Drawing.Point(159, 240);
            this.lblEXPO2_tRFC2.Name = "lblEXPO2_tRFC2";
            this.lblEXPO2_tRFC2.Size = new System.Drawing.Size(47, 20);
            this.lblEXPO2_tRFC2.TabIndex = 26;
            this.lblEXPO2_tRFC2.Text = "tRFC2";
            // 
            // lblEXPO2_tRFC1
            // 
            this.lblEXPO2_tRFC1.AutoSize = true;
            this.lblEXPO2_tRFC1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRFC1.Location = new System.Drawing.Point(159, 212);
            this.lblEXPO2_tRFC1.Name = "lblEXPO2_tRFC1";
            this.lblEXPO2_tRFC1.Size = new System.Drawing.Size(47, 20);
            this.lblEXPO2_tRFC1.TabIndex = 27;
            this.lblEXPO2_tRFC1.Text = "tRFC1";
            // 
            // lblEXPO2_tWR
            // 
            this.lblEXPO2_tWR.AutoSize = true;
            this.lblEXPO2_tWR.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tWR.Location = new System.Drawing.Point(159, 185);
            this.lblEXPO2_tWR.Name = "lblEXPO2_tWR";
            this.lblEXPO2_tWR.Size = new System.Drawing.Size(37, 20);
            this.lblEXPO2_tWR.TabIndex = 22;
            this.lblEXPO2_tWR.Text = "tWR";
            // 
            // lblEXPO2_tRC
            // 
            this.lblEXPO2_tRC.AutoSize = true;
            this.lblEXPO2_tRC.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRC.Location = new System.Drawing.Point(159, 158);
            this.lblEXPO2_tRC.Name = "lblEXPO2_tRC";
            this.lblEXPO2_tRC.Size = new System.Drawing.Size(32, 20);
            this.lblEXPO2_tRC.TabIndex = 23;
            this.lblEXPO2_tRC.Text = "tRC";
            // 
            // lblEXPO2_tRAS
            // 
            this.lblEXPO2_tRAS.AutoSize = true;
            this.lblEXPO2_tRAS.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRAS.Location = new System.Drawing.Point(159, 129);
            this.lblEXPO2_tRAS.Name = "lblEXPO2_tRAS";
            this.lblEXPO2_tRAS.Size = new System.Drawing.Size(41, 20);
            this.lblEXPO2_tRAS.TabIndex = 24;
            this.lblEXPO2_tRAS.Text = "tRAS";
            // 
            // lblEXPO2_tRP
            // 
            this.lblEXPO2_tRP.AutoSize = true;
            this.lblEXPO2_tRP.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRP.Location = new System.Drawing.Point(159, 101);
            this.lblEXPO2_tRP.Name = "lblEXPO2_tRP";
            this.lblEXPO2_tRP.Size = new System.Drawing.Size(31, 20);
            this.lblEXPO2_tRP.TabIndex = 19;
            this.lblEXPO2_tRP.Text = "tRP";
            // 
            // lblEXPO2_tRCD
            // 
            this.lblEXPO2_tRCD.AutoSize = true;
            this.lblEXPO2_tRCD.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tRCD.Location = new System.Drawing.Point(159, 74);
            this.lblEXPO2_tRCD.Name = "lblEXPO2_tRCD";
            this.lblEXPO2_tRCD.Size = new System.Drawing.Size(43, 20);
            this.lblEXPO2_tRCD.TabIndex = 20;
            this.lblEXPO2_tRCD.Text = "tRCD";
            // 
            // lblEXPO2_tAA
            // 
            this.lblEXPO2_tAA.AutoSize = true;
            this.lblEXPO2_tAA.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEXPO2_tAA.Location = new System.Drawing.Point(159, 46);
            this.lblEXPO2_tAA.Name = "lblEXPO2_tAA";
            this.lblEXPO2_tAA.Size = new System.Drawing.Size(34, 20);
            this.lblEXPO2_tAA.TabIndex = 21;
            this.lblEXPO2_tAA.Text = "tAA";
            // 
            // tboxEXPO2_tRFCsb
            // 
            this.tboxEXPO2_tRFCsb.Location = new System.Drawing.Point(83, 262);
            this.tboxEXPO2_tRFCsb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRFCsb.Name = "tboxEXPO2_tRFCsb";
            this.tboxEXPO2_tRFCsb.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRFCsb.TabIndex = 18;
            // 
            // tboxEXPO2_tRFC2
            // 
            this.tboxEXPO2_tRFC2.Location = new System.Drawing.Point(83, 235);
            this.tboxEXPO2_tRFC2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRFC2.Name = "tboxEXPO2_tRFC2";
            this.tboxEXPO2_tRFC2.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRFC2.TabIndex = 16;
            // 
            // tboxEXPO2_tRFC1
            // 
            this.tboxEXPO2_tRFC1.Location = new System.Drawing.Point(83, 208);
            this.tboxEXPO2_tRFC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRFC1.Name = "tboxEXPO2_tRFC1";
            this.tboxEXPO2_tRFC1.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRFC1.TabIndex = 17;
            // 
            // tboxEXPO2_tWR
            // 
            this.tboxEXPO2_tWR.Location = new System.Drawing.Point(83, 180);
            this.tboxEXPO2_tWR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tWR.Name = "tboxEXPO2_tWR";
            this.tboxEXPO2_tWR.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tWR.TabIndex = 14;
            // 
            // tboxEXPO2_tRC
            // 
            this.tboxEXPO2_tRC.Location = new System.Drawing.Point(83, 152);
            this.tboxEXPO2_tRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRC.Name = "tboxEXPO2_tRC";
            this.tboxEXPO2_tRC.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRC.TabIndex = 15;
            // 
            // tboxEXPO2_tRAS
            // 
            this.tboxEXPO2_tRAS.Location = new System.Drawing.Point(83, 125);
            this.tboxEXPO2_tRAS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRAS.Name = "tboxEXPO2_tRAS";
            this.tboxEXPO2_tRAS.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRAS.TabIndex = 12;
            // 
            // tboxEXPO2_tRP
            // 
            this.tboxEXPO2_tRP.Location = new System.Drawing.Point(83, 98);
            this.tboxEXPO2_tRP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRP.Name = "tboxEXPO2_tRP";
            this.tboxEXPO2_tRP.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRP.TabIndex = 13;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(7, 266);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(46, 20);
            this.label136.TabIndex = 9;
            this.label136.Text = "tRFC :";
            // 
            // tboxEXPO2_tRCD
            // 
            this.tboxEXPO2_tRCD.Location = new System.Drawing.Point(83, 70);
            this.tboxEXPO2_tRCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tRCD.Name = "tboxEXPO2_tRCD";
            this.tboxEXPO2_tRCD.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tRCD.TabIndex = 2;
            // 
            // tboxEXPO2_tAA
            // 
            this.tboxEXPO2_tAA.Location = new System.Drawing.Point(83, 42);
            this.tboxEXPO2_tAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_tAA.Name = "tboxEXPO2_tAA";
            this.tboxEXPO2_tAA.Size = new System.Drawing.Size(59, 25);
            this.tboxEXPO2_tAA.TabIndex = 2;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(13, 239);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(54, 20);
            this.label137.TabIndex = 10;
            this.label137.Text = "tRFC2 :";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.Location = new System.Drawing.Point(13, 211);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(54, 20);
            this.label138.TabIndex = 11;
            this.label138.Text = "tRFC1 :";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.Location = new System.Drawing.Point(22, 184);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(44, 20);
            this.label139.TabIndex = 6;
            this.label139.Text = "tWR :";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.Location = new System.Drawing.Point(22, 156);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(39, 20);
            this.label140.TabIndex = 7;
            this.label140.Text = "tRC :";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(22, 128);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(48, 20);
            this.label141.TabIndex = 8;
            this.label141.Text = "tRAS :";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label142.Location = new System.Drawing.Point(425, 21);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(48, 19);
            this.label142.TabIndex = 3;
            this.label142.Text = "Ticks";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label143.Location = new System.Drawing.Point(343, 21);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(82, 19);
            this.label143.TabIndex = 4;
            this.label143.Text = "Value (ps)";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label144.Location = new System.Drawing.Point(282, 21);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(53, 19);
            this.label144.TabIndex = 5;
            this.label144.Text = "Name";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label161.Location = new System.Drawing.Point(153, 21);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(48, 19);
            this.label161.TabIndex = 2;
            this.label161.Text = "Ticks";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(80, 21);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(82, 19);
            this.label162.TabIndex = 2;
            this.label162.Text = "Value (ps)";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(22, 101);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(38, 20);
            this.label163.TabIndex = 2;
            this.label163.Text = "tRP :";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(22, 74);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(50, 20);
            this.label164.TabIndex = 2;
            this.label164.Text = "tRCD :";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(22, 46);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(41, 20);
            this.label165.TabIndex = 2;
            this.label165.Text = "tAA :";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.Location = new System.Drawing.Point(19, 21);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(53, 19);
            this.label166.TabIndex = 2;
            this.label166.Text = "Name";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tboxEXPO2_VPP);
            this.groupBox14.Controls.Add(this.label43);
            this.groupBox14.Controls.Add(this.tboxEXPO2_VDDQ);
            this.groupBox14.Controls.Add(this.label44);
            this.groupBox14.Controls.Add(this.tboxEXPO2_VDD);
            this.groupBox14.Controls.Add(this.label45);
            this.groupBox14.Location = new System.Drawing.Point(7, 55);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox14.Size = new System.Drawing.Size(600, 48);
            this.groupBox14.TabIndex = 4;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Voltages";
            // 
            // tboxEXPO2_VPP
            // 
            this.tboxEXPO2_VPP.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO2_VPP.Location = new System.Drawing.Point(331, 15);
            this.tboxEXPO2_VPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_VPP.Name = "tboxEXPO2_VPP";
            this.tboxEXPO2_VPP.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO2_VPP.TabIndex = 18;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(281, 20);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(40, 15);
            this.label43.TabIndex = 17;
            this.label43.Text = "VPP:";
            // 
            // tboxEXPO2_VDDQ
            // 
            this.tboxEXPO2_VDDQ.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO2_VDDQ.Location = new System.Drawing.Point(189, 15);
            this.tboxEXPO2_VDDQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_VDDQ.Name = "tboxEXPO2_VDDQ";
            this.tboxEXPO2_VDDQ.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO2_VDDQ.TabIndex = 16;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(138, 20);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(52, 15);
            this.label44.TabIndex = 15;
            this.label44.Text = "VDDQ:";
            // 
            // tboxEXPO2_VDD
            // 
            this.tboxEXPO2_VDD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxEXPO2_VDD.Location = new System.Drawing.Point(56, 15);
            this.tboxEXPO2_VDD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_VDD.Name = "tboxEXPO2_VDD";
            this.tboxEXPO2_VDD.Size = new System.Drawing.Size(54, 25);
            this.tboxEXPO2_VDD.TabIndex = 14;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(13, 20);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 15);
            this.label45.TabIndex = 0;
            this.label45.Text = "VDD:";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tboxEXPO2_MegaTransfers);
            this.groupBox12.Controls.Add(this.tboxEXPO2_Frequency);
            this.groupBox12.Controls.Add(this.updnEXPO2_MinCycleTime);
            this.groupBox12.Controls.Add(this.label42);
            this.groupBox12.Location = new System.Drawing.Point(7, 8);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox12.Size = new System.Drawing.Size(600, 46);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Frequency";
            // 
            // tboxEXPO2_MegaTransfers
            // 
            this.tboxEXPO2_MegaTransfers.Enabled = false;
            this.tboxEXPO2_MegaTransfers.Location = new System.Drawing.Point(285, 14);
            this.tboxEXPO2_MegaTransfers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_MegaTransfers.Name = "tboxEXPO2_MegaTransfers";
            this.tboxEXPO2_MegaTransfers.Size = new System.Drawing.Size(79, 25);
            this.tboxEXPO2_MegaTransfers.TabIndex = 2;
            // 
            // tboxEXPO2_Frequency
            // 
            this.tboxEXPO2_Frequency.Enabled = false;
            this.tboxEXPO2_Frequency.Location = new System.Drawing.Point(208, 14);
            this.tboxEXPO2_Frequency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPO2_Frequency.Name = "tboxEXPO2_Frequency";
            this.tboxEXPO2_Frequency.Size = new System.Drawing.Size(69, 25);
            this.tboxEXPO2_Frequency.TabIndex = 2;
            // 
            // updnEXPO2_MinCycleTime
            // 
            this.updnEXPO2_MinCycleTime.Location = new System.Drawing.Point(128, 15);
            this.updnEXPO2_MinCycleTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updnEXPO2_MinCycleTime.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.updnEXPO2_MinCycleTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnEXPO2_MinCycleTime.Name = "updnEXPO2_MinCycleTime";
            this.updnEXPO2_MinCycleTime.Size = new System.Drawing.Size(73, 25);
            this.updnEXPO2_MinCycleTime.TabIndex = 1;
            this.updnEXPO2_MinCycleTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updnEXPO2_MinCycleTime.ValueChanged += new System.EventHandler(this.updnEXPO2_MinCycleTime_ValueChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(7, 21);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(112, 15);
            this.label42.TabIndex = 0;
            this.label42.Text = "Min Cycle Time:";
            // 
            // tabPageSPD_Header
            // 
            this.tabPageSPD_Header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageSPD_Header.Controls.Add(this.groupBox9);
            this.tabPageSPD_Header.Controls.Add(this.groupBox4);
            this.tabPageSPD_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageSPD_Header.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPD_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_Header.Name = "tabPageSPD_Header";
            this.tabPageSPD_Header.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSPD_Header.Size = new System.Drawing.Size(615, 612);
            this.tabPageSPD_Header.TabIndex = 6;
            this.tabPageSPD_Header.Text = "Header";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox25);
            this.groupBox9.Location = new System.Drawing.Point(8, 290);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(603, 106);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "EXPO Header";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.tboxEXPOheader_Configuration);
            this.groupBox25.Controls.Add(this.tboxEXPOheader_Version);
            this.groupBox25.Controls.Add(this.tboxEXPOheader_IdString);
            this.groupBox25.Controls.Add(this.label124);
            this.groupBox25.Controls.Add(this.label125);
            this.groupBox25.Controls.Add(this.label126);
            this.groupBox25.Location = new System.Drawing.Point(5, 25);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox25.Size = new System.Drawing.Size(594, 50);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Profile";
            // 
            // tboxEXPOheader_Configuration
            // 
            this.tboxEXPOheader_Configuration.Location = new System.Drawing.Point(545, 16);
            this.tboxEXPOheader_Configuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPOheader_Configuration.Name = "tboxEXPOheader_Configuration";
            this.tboxEXPOheader_Configuration.Size = new System.Drawing.Size(33, 25);
            this.tboxEXPOheader_Configuration.TabIndex = 1;
            // 
            // tboxEXPOheader_Version
            // 
            this.tboxEXPOheader_Version.Location = new System.Drawing.Point(351, 16);
            this.tboxEXPOheader_Version.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPOheader_Version.Name = "tboxEXPOheader_Version";
            this.tboxEXPOheader_Version.Size = new System.Drawing.Size(38, 25);
            this.tboxEXPOheader_Version.TabIndex = 1;
            // 
            // tboxEXPOheader_IdString
            // 
            this.tboxEXPOheader_IdString.Location = new System.Drawing.Point(179, 16);
            this.tboxEXPOheader_IdString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEXPOheader_IdString.Name = "tboxEXPOheader_IdString";
            this.tboxEXPOheader_IdString.Size = new System.Drawing.Size(62, 25);
            this.tboxEXPOheader_IdString.TabIndex = 1;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(409, 21);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(148, 15);
            this.label124.TabIndex = 0;
            this.label124.Text = "EXPO Configuration: ";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(249, 21);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(110, 15);
            this.label125.TabIndex = 0;
            this.label125.Text = "EXPO Version: ";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(6, 21);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(180, 15);
            this.label126.TabIndex = 0;
            this.label126.Text = "EXPO Identification String:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox22);
            this.groupBox4.Controls.Add(this.groupBox21);
            this.groupBox4.Controls.Add(this.groupBox20);
            this.groupBox4.Location = new System.Drawing.Point(7, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(603, 255);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "XMP Header";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.tboxXMP2_ProfileName);
            this.groupBox22.Controls.Add(this.tboxXMP1_ProfileName);
            this.groupBox22.Controls.Add(this.label120);
            this.groupBox22.Controls.Add(this.label121);
            this.groupBox22.Location = new System.Drawing.Point(5, 138);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox22.Size = new System.Drawing.Size(594, 50);
            this.groupBox22.TabIndex = 2;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Profile name ";
            // 
            // tboxXMP2_ProfileName
            // 
            this.tboxXMP2_ProfileName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP2_ProfileName.Location = new System.Drawing.Point(275, 16);
            this.tboxXMP2_ProfileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP2_ProfileName.Name = "tboxXMP2_ProfileName";
            this.tboxXMP2_ProfileName.Size = new System.Drawing.Size(156, 25);
            this.tboxXMP2_ProfileName.TabIndex = 15;
            // 
            // tboxXMP1_ProfileName
            // 
            this.tboxXMP1_ProfileName.BackColor = System.Drawing.SystemColors.Window;
            this.tboxXMP1_ProfileName.Location = new System.Drawing.Point(54, 16);
            this.tboxXMP1_ProfileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMP1_ProfileName.Name = "tboxXMP1_ProfileName";
            this.tboxXMP1_ProfileName.Size = new System.Drawing.Size(156, 25);
            this.tboxXMP1_ProfileName.TabIndex = 15;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(221, 22);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(51, 15);
            this.label120.TabIndex = 0;
            this.label120.Text = "XMP2:";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(6, 21);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(56, 15);
            this.label121.TabIndex = 0;
            this.label121.Text = "XMP1: ";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.tboxXMPheader_PMICcap);
            this.groupBox21.Controls.Add(this.tboxXMPheader_PMICnum);
            this.groupBox21.Controls.Add(this.tboxXMPheader_PMICvend);
            this.groupBox21.Controls.Add(this.label83);
            this.groupBox21.Controls.Add(this.label84);
            this.groupBox21.Controls.Add(this.label85);
            this.groupBox21.Location = new System.Drawing.Point(5, 80);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox21.Size = new System.Drawing.Size(594, 50);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "PMIC";
            // 
            // tboxXMPheader_PMICcap
            // 
            this.tboxXMPheader_PMICcap.Location = new System.Drawing.Point(421, 16);
            this.tboxXMPheader_PMICcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_PMICcap.Name = "tboxXMPheader_PMICcap";
            this.tboxXMPheader_PMICcap.Size = new System.Drawing.Size(33, 25);
            this.tboxXMPheader_PMICcap.TabIndex = 1;
            // 
            // tboxXMPheader_PMICnum
            // 
            this.tboxXMPheader_PMICnum.Location = new System.Drawing.Point(237, 16);
            this.tboxXMPheader_PMICnum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_PMICnum.Name = "tboxXMPheader_PMICnum";
            this.tboxXMPheader_PMICnum.Size = new System.Drawing.Size(38, 25);
            this.tboxXMPheader_PMICnum.TabIndex = 1;
            // 
            // tboxXMPheader_PMICvend
            // 
            this.tboxXMPheader_PMICvend.Location = new System.Drawing.Point(90, 16);
            this.tboxXMPheader_PMICvend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_PMICvend.Name = "tboxXMPheader_PMICvend";
            this.tboxXMPheader_PMICvend.Size = new System.Drawing.Size(42, 25);
            this.tboxXMPheader_PMICvend.TabIndex = 1;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(328, 21);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(86, 15);
            this.label83.TabIndex = 0;
            this.label83.Text = "Capabilities:";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(168, 21);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(60, 15);
            this.label84.TabIndex = 0;
            this.label84.Text = "Number:";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(6, 21);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(80, 15);
            this.label85.TabIndex = 0;
            this.label85.Text = "Vendor ID: ";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.tboxXMPheader_Configuration);
            this.groupBox20.Controls.Add(this.tboxXMPheader_Version);
            this.groupBox20.Controls.Add(this.tboxXMPheader_IdString);
            this.groupBox20.Controls.Add(this.label82);
            this.groupBox20.Controls.Add(this.label57);
            this.groupBox20.Controls.Add(this.label48);
            this.groupBox20.Location = new System.Drawing.Point(5, 22);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox20.Size = new System.Drawing.Size(594, 50);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Profile";
            // 
            // tboxXMPheader_Configuration
            // 
            this.tboxXMPheader_Configuration.Location = new System.Drawing.Point(545, 16);
            this.tboxXMPheader_Configuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_Configuration.Name = "tboxXMPheader_Configuration";
            this.tboxXMPheader_Configuration.Size = new System.Drawing.Size(33, 25);
            this.tboxXMPheader_Configuration.TabIndex = 1;
            // 
            // tboxXMPheader_Version
            // 
            this.tboxXMPheader_Version.Location = new System.Drawing.Point(347, 16);
            this.tboxXMPheader_Version.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_Version.Name = "tboxXMPheader_Version";
            this.tboxXMPheader_Version.Size = new System.Drawing.Size(38, 25);
            this.tboxXMPheader_Version.TabIndex = 1;
            // 
            // tboxXMPheader_IdString
            // 
            this.tboxXMPheader_IdString.Location = new System.Drawing.Point(177, 16);
            this.tboxXMPheader_IdString.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxXMPheader_IdString.Name = "tboxXMPheader_IdString";
            this.tboxXMPheader_IdString.Size = new System.Drawing.Size(42, 25);
            this.tboxXMPheader_IdString.TabIndex = 1;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(414, 21);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(139, 15);
            this.label82.TabIndex = 0;
            this.label82.Text = "XMP Configuration: ";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(249, 21);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(101, 15);
            this.label57.TabIndex = 0;
            this.label57.Text = "XMP Version: ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 21);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(171, 15);
            this.label48.TabIndex = 0;
            this.label48.Text = "XMP Identification String:";
            // 
            // cbox_EnableEXPO2
            // 
            this.cbox_EnableEXPO2.AutoSize = true;
            this.cbox_EnableEXPO2.Location = new System.Drawing.Point(264, 116);
            this.cbox_EnableEXPO2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_EnableEXPO2.Name = "cbox_EnableEXPO2";
            this.cbox_EnableEXPO2.Size = new System.Drawing.Size(77, 19);
            this.cbox_EnableEXPO2.TabIndex = 21;
            this.cbox_EnableEXPO2.Text = "EXPO1";
            this.cbox_EnableEXPO2.UseVisualStyleBackColor = true;
            this.cbox_EnableEXPO2.CheckedChanged += new System.EventHandler(this.cbox_EnableEXPO2_CheckedChanged);
            // 
            // cbox_EnableEXPO1
            // 
            this.cbox_EnableEXPO1.AutoSize = true;
            this.cbox_EnableEXPO1.Location = new System.Drawing.Point(189, 116);
            this.cbox_EnableEXPO1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_EnableEXPO1.Name = "cbox_EnableEXPO1";
            this.cbox_EnableEXPO1.Size = new System.Drawing.Size(77, 19);
            this.cbox_EnableEXPO1.TabIndex = 21;
            this.cbox_EnableEXPO1.Text = "EXPO1";
            this.cbox_EnableEXPO1.UseVisualStyleBackColor = true;
            this.cbox_EnableEXPO1.CheckedChanged += new System.EventHandler(this.cbox_EnableEXPO1_CheckedChanged);
            // 
            // cbox_EnableXMP2
            // 
            this.cbox_EnableXMP2.AutoSize = true;
            this.cbox_EnableXMP2.Location = new System.Drawing.Point(120, 116);
            this.cbox_EnableXMP2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_EnableXMP2.Name = "cbox_EnableXMP2";
            this.cbox_EnableXMP2.Size = new System.Drawing.Size(68, 19);
            this.cbox_EnableXMP2.TabIndex = 21;
            this.cbox_EnableXMP2.Text = "XMP2";
            this.cbox_EnableXMP2.UseVisualStyleBackColor = true;
            this.cbox_EnableXMP2.CheckedChanged += new System.EventHandler(this.cbox_EnableXMP2_CheckedChanged);
            // 
            // cbox_EnableXMP1
            // 
            this.cbox_EnableXMP1.AutoSize = true;
            this.cbox_EnableXMP1.Location = new System.Drawing.Point(51, 116);
            this.cbox_EnableXMP1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_EnableXMP1.Name = "cbox_EnableXMP1";
            this.cbox_EnableXMP1.Size = new System.Drawing.Size(68, 19);
            this.cbox_EnableXMP1.TabIndex = 21;
            this.cbox_EnableXMP1.Text = "XMP1";
            this.cbox_EnableXMP1.UseVisualStyleBackColor = true;
            this.cbox_EnableXMP1.CheckedChanged += new System.EventHandler(this.cbox_EnableXMP1_CheckedChanged);
            // 
            // btnSPDupdate
            // 
            this.btnSPDupdate.Location = new System.Drawing.Point(477, 4);
            this.btnSPDupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSPDupdate.Name = "btnSPDupdate";
            this.btnSPDupdate.Size = new System.Drawing.Size(153, 52);
            this.btnSPDupdate.TabIndex = 19;
            this.btnSPDupdate.Text = "SPD 반영";
            this.btnSPDupdate.UseVisualStyleBackColor = true;
            this.btnSPDupdate.Click += new System.EventHandler(this.btnSPDupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Module Part Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Module Serial Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Manufa. Specific Data :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dram Manufacturer’s ID :";
            // 
            // tboxMSD
            // 
            this.tboxMSD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMSD.Location = new System.Drawing.Point(365, 85);
            this.tboxMSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMSD.Name = "tboxMSD";
            this.tboxMSD.Size = new System.Drawing.Size(268, 25);
            this.tboxMSD.TabIndex = 10;
            // 
            // tboxPNum
            // 
            this.tboxPNum.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPNum.Location = new System.Drawing.Point(128, 85);
            this.tboxPNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxPNum.Name = "tboxPNum";
            this.tboxPNum.Size = new System.Drawing.Size(93, 25);
            this.tboxPNum.TabIndex = 11;
            // 
            // tboxSNum
            // 
            this.tboxSNum.BackColor = System.Drawing.SystemColors.Window;
            this.tboxSNum.Location = new System.Drawing.Point(136, 58);
            this.tboxSNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxSNum.Name = "tboxSNum";
            this.tboxSNum.Size = new System.Drawing.Size(92, 25);
            this.tboxSNum.TabIndex = 12;
            // 
            // tboxDMIDparsing
            // 
            this.tboxDMIDparsing.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDMIDparsing.Enabled = false;
            this.tboxDMIDparsing.Location = new System.Drawing.Point(435, 58);
            this.tboxDMIDparsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxDMIDparsing.Name = "tboxDMIDparsing";
            this.tboxDMIDparsing.Size = new System.Drawing.Size(117, 25);
            this.tboxDMIDparsing.TabIndex = 13;
            // 
            // tboxDMID
            // 
            this.tboxDMID.BackColor = System.Drawing.SystemColors.Window;
            this.tboxDMID.Location = new System.Drawing.Point(387, 58);
            this.tboxDMID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxDMID.Name = "tboxDMID";
            this.tboxDMID.Size = new System.Drawing.Size(44, 25);
            this.tboxDMID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "week";
            // 
            // tboxMDweek
            // 
            this.tboxMDweek.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMDweek.Location = new System.Drawing.Point(240, 30);
            this.tboxMDweek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMDweek.Name = "tboxMDweek";
            this.tboxMDweek.Size = new System.Drawing.Size(26, 25);
            this.tboxMDweek.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "year";
            // 
            // tboxMDyear
            // 
            this.tboxMDyear.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMDyear.Location = new System.Drawing.Point(173, 30);
            this.tboxMDyear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMDyear.Name = "tboxMDyear";
            this.tboxMDyear.Size = new System.Drawing.Size(30, 25);
            this.tboxMDyear.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Module Manufacturing Date :";
            // 
            // tboxMIDparsing
            // 
            this.tboxMIDparsing.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMIDparsing.Enabled = false;
            this.tboxMIDparsing.Location = new System.Drawing.Point(226, 2);
            this.tboxMIDparsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMIDparsing.Name = "tboxMIDparsing";
            this.tboxMIDparsing.Size = new System.Drawing.Size(171, 25);
            this.tboxMIDparsing.TabIndex = 4;
            // 
            // tboxMID
            // 
            this.tboxMID.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMID.Location = new System.Drawing.Point(171, 2);
            this.tboxMID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMID.Name = "tboxMID";
            this.tboxMID.Size = new System.Drawing.Size(47, 25);
            this.tboxMID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Module Manufacturer’s ID :";
            // 
            // tabPageLog
            // 
            this.tabPageLog.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLog.Controls.Add(this.label47);
            this.tabPageLog.Controls.Add(this.label46);
            this.tabPageLog.Controls.Add(this.btnCvsSave);
            this.tabPageLog.Controls.Add(this.btnLogSave);
            this.tabPageLog.Controls.Add(this.btnCvsClear);
            this.tabPageLog.Controls.Add(this.btnLogClear);
            this.tabPageLog.Controls.Add(this.listBoxCvs);
            this.tabPageLog.Controls.Add(this.listBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(651, 783);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Log";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label47.Location = new System.Drawing.Point(7, 372);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(42, 17);
            this.label47.TabIndex = 2;
            this.label47.Text = "CVS";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.Location = new System.Drawing.Point(7, 15);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 17);
            this.label46.TabIndex = 2;
            this.label46.Text = "Log ";
            // 
            // btnCvsSave
            // 
            this.btnCvsSave.Location = new System.Drawing.Point(162, 368);
            this.btnCvsSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCvsSave.Name = "btnCvsSave";
            this.btnCvsSave.Size = new System.Drawing.Size(86, 29);
            this.btnCvsSave.TabIndex = 1;
            this.btnCvsSave.Text = "CVS Save";
            this.btnCvsSave.UseVisualStyleBackColor = true;
            this.btnCvsSave.Click += new System.EventHandler(this.btnCvsSave_Click);
            // 
            // btnLogSave
            // 
            this.btnLogSave.Location = new System.Drawing.Point(162, 9);
            this.btnLogSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogSave.Name = "btnLogSave";
            this.btnLogSave.Size = new System.Drawing.Size(86, 29);
            this.btnLogSave.TabIndex = 1;
            this.btnLogSave.Text = "Log Save";
            this.btnLogSave.UseVisualStyleBackColor = true;
            this.btnLogSave.Click += new System.EventHandler(this.btnLogSave_Click);
            // 
            // btnCvsClear
            // 
            this.btnCvsClear.Location = new System.Drawing.Point(70, 368);
            this.btnCvsClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCvsClear.Name = "btnCvsClear";
            this.btnCvsClear.Size = new System.Drawing.Size(86, 29);
            this.btnCvsClear.TabIndex = 1;
            this.btnCvsClear.Text = "CVS Clear";
            this.btnCvsClear.UseVisualStyleBackColor = true;
            this.btnCvsClear.Click += new System.EventHandler(this.btnCvsClear_Click);
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(70, 9);
            this.btnLogClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(86, 29);
            this.btnLogClear.TabIndex = 1;
            this.btnLogClear.Text = "Log Clear";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // listBoxCvs
            // 
            this.listBoxCvs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCvs.ItemHeight = 15;
            this.listBoxCvs.Location = new System.Drawing.Point(3, 404);
            this.listBoxCvs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCvs.Name = "listBoxCvs";
            this.listBoxCvs.ScrollAlwaysVisible = true;
            this.listBoxCvs.Size = new System.Drawing.Size(643, 360);
            this.listBoxCvs.TabIndex = 0;
            // 
            // listBoxLog
            // 
            this.listBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLog.ItemHeight = 15;
            this.listBoxLog.Location = new System.Drawing.Point(1, 41);
            this.listBoxLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(646, 315);
            this.listBoxLog.TabIndex = 0;
            // 
            // timerInterfaceUpdater
            // 
            this.timerInterfaceUpdater.Enabled = true;
            this.timerInterfaceUpdater.Tick += new System.EventHandler(this.timerInterfaceUpdater_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarConnectionStatus,
            this.statusBarCrcStatus,
            this.statusBarProgress,
            this.statusBarRamType});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(662, 26);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBarConnectionStatus
            // 
            this.statusBarConnectionStatus.AutoSize = false;
            this.statusBarConnectionStatus.Name = "statusBarConnectionStatus";
            this.statusBarConnectionStatus.Size = new System.Drawing.Size(160, 20);
            this.statusBarConnectionStatus.Text = "Not connected";
            // 
            // statusBarCrcStatus
            // 
            this.statusBarCrcStatus.AutoSize = false;
            this.statusBarCrcStatus.Name = "statusBarCrcStatus";
            this.statusBarCrcStatus.Size = new System.Drawing.Size(75, 20);
            this.statusBarCrcStatus.Text = "CRC Status";
            // 
            // statusBarProgress
            // 
            this.statusBarProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusBarProgress.AutoSize = false;
            this.statusBarProgress.Name = "statusBarProgress";
            this.statusBarProgress.Size = new System.Drawing.Size(86, 18);
            this.statusBarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // statusBarRamType
            // 
            this.statusBarRamType.Name = "statusBarRamType";
            this.statusBarRamType.Size = new System.Drawing.Size(96, 20);
            this.statusBarRamType.Text = "Manufacture";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 753);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(680, 1420);
            this.MinimumSize = new System.Drawing.Size(680, 800);
            this.Name = "FormMain";
            this.Text = "DDR5-SPD-Writer by HLDS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageSPD.ResumeLayout(false);
            this.tabPageSPD.PerformLayout();
            this.tabControlSPD.ResumeLayout(false);
            this.tabPageSPD_SPD.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnMinCycleTime)).EndInit();
            this.tabPageSPD_XMP1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnXMP1_MinCycleTime)).EndInit();
            this.tabPageSPD_XMP2.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnXMP2_MinCycleTime)).EndInit();
            this.tabPageSPD_EXPO1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEXPO1_MinCycleTime)).EndInit();
            this.tabPageSPD_EXPO2.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnEXPO2_MinCycleTime)).EndInit();
            this.tabPageSPD_Header.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolOpenFile;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSPD;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolReadEeprom;
        private System.Windows.Forms.Timer timerInterfaceUpdater;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBarConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusBarCrcStatus;
        private System.Windows.Forms.ToolStripProgressBar statusBarProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusBarRamType;
        private System.Windows.Forms.ToolStripButton toolWriteEeprom;
        private System.Windows.Forms.TextBox tboxMIDparsing;
        private System.Windows.Forms.TextBox tboxMID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxMSD;
        private System.Windows.Forms.TextBox tboxPNum;
        private System.Windows.Forms.TextBox tboxSNum;
        private System.Windows.Forms.TextBox tboxDMIDparsing;
        private System.Windows.Forms.TextBox tboxDMID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxMDweek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxMDyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSPDupdate;
        private System.Windows.Forms.TabControl tabControlSPD;
        private System.Windows.Forms.TabPage tabPageSPD_SPD;
        private System.Windows.Forms.TabPage tabPageSPD_XMP1;
        private System.Windows.Forms.TabPage tabPageSPD_XMP2;
        private System.Windows.Forms.TabPage tabPageSPD_EXPO2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxSpdMegaTransfers;
        private System.Windows.Forms.TextBox tboxSpdFrequency;
        private System.Windows.Forms.NumericUpDown updnMinCycleTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxCL24;
        private System.Windows.Forms.CheckBox cboxCL22;
        private System.Windows.Forms.CheckBox cboxCL20;
        private System.Windows.Forms.CheckBox cboxCL30;
        private System.Windows.Forms.CheckBox cboxCL28;
        private System.Windows.Forms.CheckBox cboxCL26;
        private System.Windows.Forms.CheckBox cboxCL90;
        private System.Windows.Forms.CheckBox cboxCL78;
        private System.Windows.Forms.CheckBox cboxCL66;
        private System.Windows.Forms.CheckBox cboxCL54;
        private System.Windows.Forms.CheckBox cboxCL42;
        private System.Windows.Forms.CheckBox cboxCL88;
        private System.Windows.Forms.CheckBox cboxCL76;
        private System.Windows.Forms.CheckBox cboxCL64;
        private System.Windows.Forms.CheckBox cboxCL52;
        private System.Windows.Forms.CheckBox cboxCL40;
        private System.Windows.Forms.CheckBox cboxCL98;
        private System.Windows.Forms.CheckBox cboxCL86;
        private System.Windows.Forms.CheckBox cboxCL74;
        private System.Windows.Forms.CheckBox cboxCL62;
        private System.Windows.Forms.CheckBox cboxCL50;
        private System.Windows.Forms.CheckBox cboxCL38;
        private System.Windows.Forms.CheckBox cboxCL96;
        private System.Windows.Forms.CheckBox cboxCL84;
        private System.Windows.Forms.CheckBox cboxCL72;
        private System.Windows.Forms.CheckBox cboxCL60;
        private System.Windows.Forms.CheckBox cboxCL48;
        private System.Windows.Forms.CheckBox cboxCL36;
        private System.Windows.Forms.CheckBox cboxCL94;
        private System.Windows.Forms.CheckBox cboxCL82;
        private System.Windows.Forms.CheckBox cboxCL70;
        private System.Windows.Forms.CheckBox cboxCL58;
        private System.Windows.Forms.CheckBox cboxCL46;
        private System.Windows.Forms.CheckBox cboxCL34;
        private System.Windows.Forms.CheckBox cboxCL92;
        private System.Windows.Forms.CheckBox cboxCL80;
        private System.Windows.Forms.CheckBox cboxCL68;
        private System.Windows.Forms.CheckBox cboxCL56;
        private System.Windows.Forms.CheckBox cboxCL44;
        private System.Windows.Forms.CheckBox cboxCL32;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tboxTiming_tAA;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tboxTiming_tRFCsb;
        private System.Windows.Forms.TextBox tboxTiming_tRFC2;
        private System.Windows.Forms.TextBox tboxTiming_tRFC1;
        private System.Windows.Forms.TextBox tboxTiming_tWR;
        private System.Windows.Forms.TextBox tboxTiming_tRC;
        private System.Windows.Forms.TextBox tboxTiming_tRAS;
        private System.Windows.Forms.TextBox tboxTiming_tRP;
        private System.Windows.Forms.TextBox tboxTiming_tRCD;
        private System.Windows.Forms.Label lblTiming_tRFCsb;
        private System.Windows.Forms.Label lblTiming_tRFC2;
        private System.Windows.Forms.Label lblTiming_tRFC1;
        private System.Windows.Forms.Label lblTiming_tWR;
        private System.Windows.Forms.Label lblTiming_tRC;
        private System.Windows.Forms.Label lblTiming_tRAS;
        private System.Windows.Forms.Label lblTiming_tRP;
        private System.Windows.Forms.Label lblTiming_tRCD;
        private System.Windows.Forms.Label lblTiming_tAA;
        private System.Windows.Forms.Label lblTiming_tRTP;
        private System.Windows.Forms.Label lblTiming_tCCD_S_WTR;
        private System.Windows.Forms.Label lblTiming_tCCD_L_WTR;
        private System.Windows.Forms.Label lblTiming_tFAW;
        private System.Windows.Forms.Label lblTiming_tCCD_L_WR2;
        private System.Windows.Forms.Label lblTiming_tCCD_L_WR;
        private System.Windows.Forms.Label lblTiming_tCCD_L;
        private System.Windows.Forms.Label lblTiming_tRRD_L;
        private System.Windows.Forms.TextBox tboxTiming_tRTP;
        private System.Windows.Forms.TextBox tboxTiming_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxTiming_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxTiming_tFAW;
        private System.Windows.Forms.TextBox tboxTiming_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxTiming_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxTiming_tCCD_L;
        private System.Windows.Forms.TextBox tboxTiming_tRRD_L;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tboxTimingLmt_tRTP;
        private System.Windows.Forms.TextBox tboxTimingLmt_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxTimingLmt_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxTimingLmt_tFAW;
        private System.Windows.Forms.TextBox tboxTimingLmt_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxTimingLmt_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxTimingLmt_tCCD_L;
        private System.Windows.Forms.TextBox tboxTimingLmt_tRRD_L;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tboxXMP1_MegaTransfers;
        private System.Windows.Forms.TextBox tboxXMP1_Frequency;
        private System.Windows.Forms.NumericUpDown updnXMP1_MinCycleTime;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboxXMP1_CommandRate;
        private System.Windows.Forms.CheckBox cboxXMP1_IntelDynamicMemoryBoost;
        private System.Windows.Forms.CheckBox cboxXMP1_RealTimeMemoryFrequencyOC;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cboxXMP1_CL90;
        private System.Windows.Forms.CheckBox cboxXMP1_CL78;
        private System.Windows.Forms.CheckBox cboxXMP1_CL66;
        private System.Windows.Forms.CheckBox cboxXMP1_CL54;
        private System.Windows.Forms.CheckBox cboxXMP1_CL42;
        private System.Windows.Forms.CheckBox cboxXMP1_CL30;
        private System.Windows.Forms.CheckBox cboxXMP1_CL88;
        private System.Windows.Forms.CheckBox cboxXMP1_CL76;
        private System.Windows.Forms.CheckBox cboxXMP1_CL64;
        private System.Windows.Forms.CheckBox cboxXMP1_CL52;
        private System.Windows.Forms.CheckBox cboxXMP1_CL40;
        private System.Windows.Forms.CheckBox cboxXMP1_CL28;
        private System.Windows.Forms.CheckBox cboxXMP1_CL98;
        private System.Windows.Forms.CheckBox cboxXMP1_CL86;
        private System.Windows.Forms.CheckBox cboxXMP1_CL74;
        private System.Windows.Forms.CheckBox cboxXMP1_CL62;
        private System.Windows.Forms.CheckBox cboxXMP1_CL50;
        private System.Windows.Forms.CheckBox cboxXMP1_CL38;
        private System.Windows.Forms.CheckBox cboxXMP1_CL26;
        private System.Windows.Forms.CheckBox cboxXMP1_CL96;
        private System.Windows.Forms.CheckBox cboxXMP1_CL84;
        private System.Windows.Forms.CheckBox cboxXMP1_CL72;
        private System.Windows.Forms.CheckBox cboxXMP1_CL60;
        private System.Windows.Forms.CheckBox cboxXMP1_CL48;
        private System.Windows.Forms.CheckBox cboxXMP1_CL36;
        private System.Windows.Forms.CheckBox cboxXMP1_CL24;
        private System.Windows.Forms.CheckBox cboxXMP1_CL94;
        private System.Windows.Forms.CheckBox cboxXMP1_CL82;
        private System.Windows.Forms.CheckBox cboxXMP1_CL70;
        private System.Windows.Forms.CheckBox cboxXMP1_CL58;
        private System.Windows.Forms.CheckBox cboxXMP1_CL46;
        private System.Windows.Forms.CheckBox cboxXMP1_CL34;
        private System.Windows.Forms.CheckBox cboxXMP1_CL22;
        private System.Windows.Forms.CheckBox cboxXMP1_CL92;
        private System.Windows.Forms.CheckBox cboxXMP1_CL80;
        private System.Windows.Forms.CheckBox cboxXMP1_CL68;
        private System.Windows.Forms.CheckBox cboxXMP1_CL56;
        private System.Windows.Forms.CheckBox cboxXMP1_CL44;
        private System.Windows.Forms.CheckBox cboxXMP1_CL32;
        private System.Windows.Forms.CheckBox cboxXMP1_CL20;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tboxXMP1_VDD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tboxXMP1_VPP;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tboxXMP1_VDDQ;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tboxXMP1_VMEM;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tRTP;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tFAW;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tCCD_L;
        private System.Windows.Forms.TextBox tboxXMP1Lmt_tRRD_L;
        private System.Windows.Forms.Label lblXMP1_tRTP;
        private System.Windows.Forms.Label lblXMP1_tCCD_S_WTR;
        private System.Windows.Forms.Label lblXMP1_tCCD_L_WTR;
        private System.Windows.Forms.Label lblXMP1_tFAW;
        private System.Windows.Forms.Label lblXMP1_tCCD_L_WR2;
        private System.Windows.Forms.Label lblXMP1_tCCD_L_WR;
        private System.Windows.Forms.Label lblXMP1_tCCD_L;
        private System.Windows.Forms.Label lblXMP1_tRRD_L;
        private System.Windows.Forms.TextBox tboxXMP1_tRTP;
        private System.Windows.Forms.TextBox tboxXMP1_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxXMP1_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxXMP1_tFAW;
        private System.Windows.Forms.TextBox tboxXMP1_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxXMP1_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxXMP1_tCCD_L;
        private System.Windows.Forms.TextBox tboxXMP1_tRRD_L;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label lblXMP1_tRFCsb;
        private System.Windows.Forms.Label lblXMP1_tRFC2;
        private System.Windows.Forms.Label lblXMP1_tRFC1;
        private System.Windows.Forms.Label lblXMP1_tWR;
        private System.Windows.Forms.Label lblXMP1_tRC;
        private System.Windows.Forms.Label lblXMP1_tRAS;
        private System.Windows.Forms.Label lblXMP1_tRP;
        private System.Windows.Forms.Label lblXMP1_tRCD;
        private System.Windows.Forms.Label lblXMP1_tAA;
        private System.Windows.Forms.TextBox tboxXMP1_tRFCsb;
        private System.Windows.Forms.TextBox tboxXMP1_tRFC2;
        private System.Windows.Forms.TextBox tboxXMP1_tRFC1;
        private System.Windows.Forms.TextBox tboxXMP1_tWR;
        private System.Windows.Forms.TextBox tboxXMP1_tRC;
        private System.Windows.Forms.TextBox tboxXMP1_tRAS;
        private System.Windows.Forms.TextBox tboxXMP1_tRP;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox tboxXMP1_tRCD;
        private System.Windows.Forms.TextBox tboxXMP1_tAA;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox cboxXMP2_CL90;
        private System.Windows.Forms.CheckBox cboxXMP2_CL78;
        private System.Windows.Forms.CheckBox cboxXMP2_CL66;
        private System.Windows.Forms.CheckBox cboxXMP2_CL54;
        private System.Windows.Forms.CheckBox cboxXMP2_CL42;
        private System.Windows.Forms.CheckBox cboxXMP2_CL30;
        private System.Windows.Forms.CheckBox cboxXMP2_CL88;
        private System.Windows.Forms.CheckBox cboxXMP2_CL76;
        private System.Windows.Forms.CheckBox cboxXMP2_CL64;
        private System.Windows.Forms.CheckBox cboxXMP2_CL52;
        private System.Windows.Forms.CheckBox cboxXMP2_CL40;
        private System.Windows.Forms.CheckBox cboxXMP2_CL28;
        private System.Windows.Forms.CheckBox cboxXMP2_CL98;
        private System.Windows.Forms.CheckBox cboxXMP2_CL86;
        private System.Windows.Forms.CheckBox cboxXMP2_CL74;
        private System.Windows.Forms.CheckBox cboxXMP2_CL62;
        private System.Windows.Forms.CheckBox cboxXMP2_CL50;
        private System.Windows.Forms.CheckBox cboxXMP2_CL38;
        private System.Windows.Forms.CheckBox cboxXMP2_CL26;
        private System.Windows.Forms.CheckBox cboxXMP2_CL96;
        private System.Windows.Forms.CheckBox cboxXMP2_CL84;
        private System.Windows.Forms.CheckBox cboxXMP2_CL72;
        private System.Windows.Forms.CheckBox cboxXMP2_CL60;
        private System.Windows.Forms.CheckBox cboxXMP2_CL48;
        private System.Windows.Forms.CheckBox cboxXMP2_CL36;
        private System.Windows.Forms.CheckBox cboxXMP2_CL24;
        private System.Windows.Forms.CheckBox cboxXMP2_CL94;
        private System.Windows.Forms.CheckBox cboxXMP2_CL82;
        private System.Windows.Forms.CheckBox cboxXMP2_CL70;
        private System.Windows.Forms.CheckBox cboxXMP2_CL58;
        private System.Windows.Forms.CheckBox cboxXMP2_CL46;
        private System.Windows.Forms.CheckBox cboxXMP2_CL34;
        private System.Windows.Forms.CheckBox cboxXMP2_CL22;
        private System.Windows.Forms.CheckBox cboxXMP2_CL92;
        private System.Windows.Forms.CheckBox cboxXMP2_CL80;
        private System.Windows.Forms.CheckBox cboxXMP2_CL68;
        private System.Windows.Forms.CheckBox cboxXMP2_CL56;
        private System.Windows.Forms.CheckBox cboxXMP2_CL44;
        private System.Windows.Forms.CheckBox cboxXMP2_CL32;
        private System.Windows.Forms.CheckBox cboxXMP2_CL20;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.TextBox tboxXMP2_VMEM;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TextBox tboxXMP2_VPP;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox tboxXMP2_VDDQ;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox tboxXMP2_VDD;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox cboxXMP2_RealTimeMemoryFrequencyOC;
        private System.Windows.Forms.CheckBox cboxXMP2_IntelDynamicMemoryBoost;
        private System.Windows.Forms.ComboBox comboxXMP2_CommandRate;
        private System.Windows.Forms.TextBox tboxXMP2_MegaTransfers;
        private System.Windows.Forms.TextBox tboxXMP2_Frequency;
        private System.Windows.Forms.NumericUpDown updnXMP2_MinCycleTime;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TabPage tabPageSPD_EXPO1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblEXPO1_tRTP;
        private System.Windows.Forms.Label lblEXPO1_tCCD_S_WTR;
        private System.Windows.Forms.Label lblEXPO1_tCCD_L_WTR;
        private System.Windows.Forms.Label lblEXPO1_tFAW;
        private System.Windows.Forms.Label lblEXPO1_tCCD_L_WR2;
        private System.Windows.Forms.Label lblEXPO1_tCCD_L_WR;
        private System.Windows.Forms.Label lblEXPO1_tCCD_L;
        private System.Windows.Forms.Label lblEXPO1_tRRD_L;
        private System.Windows.Forms.TextBox tboxEXPO1_tRTP;
        private System.Windows.Forms.TextBox tboxEXPO1_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxEXPO1_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxEXPO1_tFAW;
        private System.Windows.Forms.TextBox tboxEXPO1_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxEXPO1_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxEXPO1_tCCD_L;
        private System.Windows.Forms.TextBox tboxEXPO1_tRRD_L;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label lblEXPO1_tRFC;
        private System.Windows.Forms.Label lblEXPO1_tRFC2;
        private System.Windows.Forms.Label lblEXPO1_tRFC1;
        private System.Windows.Forms.Label lblEXPO1_tWR;
        private System.Windows.Forms.Label lblEXPO1_tRC;
        private System.Windows.Forms.Label lblEXPO1_tRAS;
        private System.Windows.Forms.Label lblEXPO1_tRP;
        private System.Windows.Forms.Label lblEXPO1_tRCD;
        private System.Windows.Forms.Label lblEXPO1_tAA;
        private System.Windows.Forms.TextBox tboxEXPO1_tRFCsb;
        private System.Windows.Forms.TextBox tboxEXPO1_tRFC2;
        private System.Windows.Forms.TextBox tboxEXPO1_tRFC1;
        private System.Windows.Forms.TextBox tboxEXPO1_tWR;
        private System.Windows.Forms.TextBox tboxEXPO1_tRC;
        private System.Windows.Forms.TextBox tboxEXPO1_tRAS;
        private System.Windows.Forms.TextBox tboxEXPO1_tRP;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox tboxEXPO1_tRCD;
        private System.Windows.Forms.TextBox tboxEXPO1_tAA;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox tboxEXPO1_VPP;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox tboxEXPO1_VDDQ;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TextBox tboxEXPO1_VDD;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox tboxEXPO1_MegaTransfers;
        private System.Windows.Forms.TextBox tboxEXPO1_Frequency;
        private System.Windows.Forms.NumericUpDown updnEXPO1_MinCycleTime;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tRTP;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tFAW;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tCCD_L;
        private System.Windows.Forms.TextBox tboxXMP2Lmt_tRRD_L;
        private System.Windows.Forms.Label lblXMP2_tRTP;
        private System.Windows.Forms.Label lblXMP2_tCCD_S_WTR;
        private System.Windows.Forms.Label lblXMP2_tCCD_L_WTR;
        private System.Windows.Forms.Label lblXMP2_tFAW;
        private System.Windows.Forms.Label lblXMP2_tCCD_L_WR2;
        private System.Windows.Forms.Label lblXMP2_tCCD_L_WR;
        private System.Windows.Forms.Label lblXMP2_tCCD_L;
        private System.Windows.Forms.Label lblXMP2_tRRD_L;
        private System.Windows.Forms.TextBox tboxXMP2_tRTP;
        private System.Windows.Forms.TextBox tboxXMP2_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxXMP2_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxXMP2_tFAW;
        private System.Windows.Forms.TextBox tboxXMP2_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxXMP2_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxXMP2_tCCD_L;
        private System.Windows.Forms.TextBox tboxXMP2_tRRD_L;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label lblXMP2_tRFCsb;
        private System.Windows.Forms.Label lblXMP2_tRFC2;
        private System.Windows.Forms.Label lblXMP2_tRFC1;
        private System.Windows.Forms.Label lblXMP2_tWR;
        private System.Windows.Forms.Label lblXMP2_tRC;
        private System.Windows.Forms.Label lblXMP2_tRAS;
        private System.Windows.Forms.Label lblXMP2_tRP;
        private System.Windows.Forms.Label lblXMP2_tRCD;
        private System.Windows.Forms.Label lblXMP2_tAA;
        private System.Windows.Forms.TextBox tboxXMP2_tRFCsb;
        private System.Windows.Forms.TextBox tboxXMP2_tRFC2;
        private System.Windows.Forms.TextBox tboxXMP2_tRFC1;
        private System.Windows.Forms.TextBox tboxXMP2_tWR;
        private System.Windows.Forms.TextBox tboxXMP2_tRC;
        private System.Windows.Forms.TextBox tboxXMP2_tRAS;
        private System.Windows.Forms.TextBox tboxXMP2_tRP;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.TextBox tboxXMP2_tRCD;
        private System.Windows.Forms.TextBox tboxXMP2_tAA;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox tboxEXPO2_VPP;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox tboxEXPO2_VDDQ;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tboxEXPO2_VDD;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tboxEXPO2_MegaTransfers;
        private System.Windows.Forms.TextBox tboxEXPO2_Frequency;
        private System.Windows.Forms.NumericUpDown updnEXPO2_MinCycleTime;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label lblEXPO2_tRTP;
        private System.Windows.Forms.Label lblEXPO2_tCCD_S_WTR;
        private System.Windows.Forms.Label lblEXPO2_tCCD_L_WTR;
        private System.Windows.Forms.Label lblEXPO2_tFAW;
        private System.Windows.Forms.Label lblEXPO2_tCCD_L_WR2;
        private System.Windows.Forms.Label lblEXPO2_tCCD_L_WR;
        private System.Windows.Forms.Label lblEXPO2_tCCD_L;
        private System.Windows.Forms.Label lblEXPO2_tRRD_L;
        private System.Windows.Forms.TextBox tboxEXPO2_tRTP;
        private System.Windows.Forms.TextBox tboxEXPO2_tCCD_S_WTR;
        private System.Windows.Forms.TextBox tboxEXPO2_tCCD_L_WTR;
        private System.Windows.Forms.TextBox tboxEXPO2_tFAW;
        private System.Windows.Forms.TextBox tboxEXPO2_tCCD_L_WR2;
        private System.Windows.Forms.TextBox tboxEXPO2_tCCD_L_WR;
        private System.Windows.Forms.TextBox tboxEXPO2_tCCD_L;
        private System.Windows.Forms.TextBox tboxEXPO2_tRRD_L;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label lblEXPO2_tRFC;
        private System.Windows.Forms.Label lblEXPO2_tRFC2;
        private System.Windows.Forms.Label lblEXPO2_tRFC1;
        private System.Windows.Forms.Label lblEXPO2_tWR;
        private System.Windows.Forms.Label lblEXPO2_tRC;
        private System.Windows.Forms.Label lblEXPO2_tRAS;
        private System.Windows.Forms.Label lblEXPO2_tRP;
        private System.Windows.Forms.Label lblEXPO2_tRCD;
        private System.Windows.Forms.Label lblEXPO2_tAA;
        private System.Windows.Forms.TextBox tboxEXPO2_tRFCsb;
        private System.Windows.Forms.TextBox tboxEXPO2_tRFC2;
        private System.Windows.Forms.TextBox tboxEXPO2_tRFC1;
        private System.Windows.Forms.TextBox tboxEXPO2_tWR;
        private System.Windows.Forms.TextBox tboxEXPO2_tRC;
        private System.Windows.Forms.TextBox tboxEXPO2_tRAS;
        private System.Windows.Forms.TextBox tboxEXPO2_tRP;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox tboxEXPO2_tRCD;
        private System.Windows.Forms.TextBox tboxEXPO2_tAA;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.Button btnLogSave;
        private System.Windows.Forms.ToolStripDropDownButton toolSave;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_SaveHexData;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_SaveCSVFile;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_SaveLogFile;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button btnCvsSave;
        private System.Windows.Forms.Button btnCvsClear;
        private System.Windows.Forms.ListBox listBoxCvs;
        private System.Windows.Forms.CheckBox cbox_EnableXMP1;
        private System.Windows.Forms.CheckBox cbox_EnableXMP2;
        private System.Windows.Forms.CheckBox cbox_EnableEXPO1;
        private System.Windows.Forms.CheckBox cbox_EnableEXPO2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolClear;
        private System.Windows.Forms.TabPage tabPageSPD_Header;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.TextBox tboxXMPheader_IdString;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tboxXMPheader_Version;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tboxXMPheader_Configuration;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.TextBox tboxXMPheader_PMICcap;
        private System.Windows.Forms.TextBox tboxXMPheader_PMICnum;
        private System.Windows.Forms.TextBox tboxXMPheader_PMICvend;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox tboxXMP2_ProfileName;
        private System.Windows.Forms.TextBox tboxXMP1_ProfileName;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.TextBox tboxEXPOheader_Configuration;
        private System.Windows.Forms.TextBox tboxEXPOheader_Version;
        private System.Windows.Forms.TextBox tboxEXPOheader_IdString;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox tboxHexData;
    }
}
