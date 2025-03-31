using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using DDR5XMPEditor.DDR5SPD;
using Stylet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection;
using DDR5XMPEditor;
using System.Xml.Linq;
using System.Runtime.Remoting.Contexts;

namespace CommandLine
{
    public partial class FormMain : Form
    {
        public DDR5_SPD Ddr5Spd = new DDR5_SPD();

        public FormMain()
        {
            InitializeComponent();

            this.KeyPreview = true; // 폼에서 키 입력을 먼저 감지하도록 설정
            this.KeyDown += FormMain_KeyDown;
        }

        /**************************************************************************/
        /*                              변수                                      */
        /**************************************************************************/
        public enum SpdSize
        {
            SDR_SPD_SIZE = 128,
            DDR_SPD_SIZE = 256,
            DDR2_SPD_SIZE = 256,
            DDR3_SPD_SIZE = 256,
            DDR4_SPD_SIZE = 512,
            DDR5_SPD_SIZE = 1024,
        }
        public string currentFileName = ""; // Loaded file
                                            
        public byte[] HexData = new byte[0];  // Spd Data  (SpdContents)

        //COM Port 와 EEPROM address를 저장하는 변수
        private string foundDevices;  // (MySpdReader)
        private string foundEeproms;

        // CRC status
        private bool crcValidChecksum;


        /* Main Form 이벤트 */
        private void FormMain_Load(object sender, EventArgs e)
        {
            Logging("Program started");

            SetStyle(ControlStyles.DoubleBuffer, true);

            // Fill top offset line
            byte[] _offsetTable = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                _offsetTable[i] = (byte)i;
            }
        }

        /**************************************************************************/
        /*                              함수                                      */
        /**************************************************************************/
        private string RunCommand(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                using (Process process = new Process { StartInfo = psi })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    return !string.IsNullOrEmpty(output) ? output : error;
                }
            }
            catch (Exception ex)
            {
                return "오류 발생:" + ex.Message;
            }
        }

        private void Logging(string message)  //Log Page에 출력하기 
        {
            if (message != null)
            {
                String timeStamp = (DateTime.Now).ToLocalTime().ToString();
                listBoxLog.Items.Add($"{timeStamp}:   {message}");
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            }
        }

        private void LoggingCVS(DDR5_SPD spd)  //CVS File 출력위해 ListBox에 추가하기 
        {
            if (spd != null)
            {
                String timeStamp = (DateTime.Now).ToLocalTime().ToString();

                if (listBoxCvs.Items.Count == 0)
                {
                    /* syr CVS파일에 아이템 추가하기 */
                    listBoxCvs.Items.Add($"MID , CL , ");
                    listBoxCvs.SelectedIndex = listBoxCvs.Items.Count - 1;
                }

                listBoxCvs.Items.Add($"{spd.ManufacturerId} , {SupportCL(spd)} ,");
                listBoxCvs.SelectedIndex = listBoxCvs.Items.Count - 1;
            }
        }

        private string SupportCL(DDR5_SPD spd)
        {
            string _cl = null;

            if (spd.CL20) _cl += "CL20/"; if (spd.CL22) _cl += "CL22/"; if (spd.CL24) _cl += "CL24/"; if (spd.CL26) _cl += "CL26/";
            if (spd.CL28) _cl += "CL28/"; if (spd.CL30) _cl += "CL30/"; if (spd.CL32) _cl += "CL32/"; if (spd.CL34) _cl += "CL34/";
            if (spd.CL36) _cl += "CL36/"; if (spd.CL38) _cl += "CL38/"; if (spd.CL40) _cl += "CL40/"; if (spd.CL42) _cl += "CL42/";
            if (spd.CL44) _cl += "CL44/"; if (spd.CL46) _cl += "CL46/"; if (spd.CL48) _cl += "CL48/"; if (spd.CL50) _cl += "CL50/";
            if (spd.CL52) _cl += "CL52/"; if (spd.CL54) _cl += "CL54/"; if (spd.CL56) _cl += "CL56/"; 
            if (spd.CL58) _cl += "CL58/"; if (spd.CL60) _cl += "CL60/"; if (spd.CL62) _cl += "CL62/";
            if (spd.CL64) _cl += "CL64/"; if (spd.CL66) _cl += "CL66/"; if (spd.CL68) _cl += "CL68/";
            if (spd.CL70) _cl += "CL70/"; if (spd.CL72) _cl += "CL72/"; if (spd.CL74) _cl += "CL74/";
            if (spd.CL76) _cl += "CL76/"; if (spd.CL78) _cl += "CL78/"; if (spd.CL80) _cl += "CL80/";
            if (spd.CL82) _cl += "CL82/"; if (spd.CL84) _cl += "CL84/"; if (spd.CL86) _cl += "CL86/";
            if (spd.CL88) _cl += "CL88/"; if (spd.CL90) _cl += "CL90/"; if (spd.CL92) _cl += "CL92/";
            if (spd.CL94) _cl += "CL94/"; if (spd.CL96) _cl += "CL96/"; if (spd.CL98) _cl += "CL98/";

            return _cl;
        }

        private void DisplayDataView(byte[] _hexData)    //SPD Hex값을 Data View에 Display해줌 (displayContents)
        {
            int bytesPerRow = 16;
            int vOffsetCount = _hexData.Length / bytesPerRow;  //수직 offset


            tboxHexData.Clear(); // 기존 내용 지우기

            // Hex 데이터를 줄 단위로 변환
            string[] hexLines = DataToHex(_hexData, bytesPerRow).Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            // TextBox에서 사용하는 폰트 가져오기
            Font textBoxFont = new System.Drawing.Font("Consolas", 9.7F);  // TextBox의 폰트 사용 

            // 각 라인에 배경색 다르게 설정
            for (int i = 0; i < hexLines.Length; i++)
            {
                string line = hexLines[i];

                // XMP, EXPO Font 배경색 설정 
                if (i >= 0x28 && i < 0x2C )
                {
                    tboxHexData.SelectionBackColor = Color.LightGray; // XMP Header 라인 배경색
                }
                else if (i >= 0x2C && i < 0x30)
                {
                    tboxHexData.SelectionBackColor = Color.LightGreen; // XMP2 라인 배경색
                }
                else if (i >= 0x30 && i < 0x34)
                {
                    tboxHexData.SelectionBackColor = Color.LightBlue; // XMP2 라인 배경색
                }
                else if (i >= 0x34 && i < 0x3C)
                {
                    tboxHexData.SelectionBackColor = Color.LightSalmon; // EXPO 라인 배경색
                }
                else
                {
                    tboxHexData.SelectionBackColor = Color.White;       // 기본 배경색으로 복귀
                }

                    // TextBox에서 사용되는 폰트를 RichTextBox에 적용
                    tboxHexData.SelectionFont = textBoxFont;

                // 해당 라인 추가
                tboxHexData.AppendText(line + "\n");
            }

            // 텍스트 추가 후 배경색 초기화
            tboxHexData.SelectionBackColor = Color.White; // 기본 배경색으로 복귀
     
            if( tabControlMain.SelectedTab != tabPageMain && !tabPageMain.Text.StartsWith("* "))  //텝이 선택되지 않은경우, 텝 하일라이트*함
            {
                tabPageMain.ForeColor = Color.Blue;
                tabPageMain.Text = $"* {tabPageMain.Text}";
            }

            ParsingToDdr5Spd(_hexData);  //SPD data에서  DDR5_SPD 로 파싱함 
        }

        private void ParsingToDdr5Spd(byte[] _hexData)  //SPD data에서  DDR5_SPD 로 파싱함 
        {
            /* SPD Data Parse */
            var spd = DDR5_SPD.Parse(_hexData);
            if (spd == null)
            {
                Logging("DDR5 SPD Parsing 실패");
            }
            else
            {
                Ddr5Spd = spd;
                Logging("DDR5 SPD Parsing 성공");
            }
        }

        private void DisplaySpdView(DDR5_SPD vm)  //SPD값을 파싱해서 SPD 탭에 Display함
        {
            tabPageSPD_SPD.Enabled = true;

            /* Display Tab */
            SPDMain_Tab(vm, false);
            SPD_Tab(vm, false); 
            XMP1_Tab(vm, false);  
            XMP2_Tab(vm, false); 
            EXPO1_Tab(vm, false); 
            EXPO2_Tab(vm, false);
            Header_Tab(vm, false);

            statusBarRamType.Text = tboxMIDparsing.Text;
            Logging($" {tboxMID.Text} , {tboxSNum.Text} , {tboxPNum.Text} , {tboxDMID.Text}, {tboxMSD.Text}  ");
        }

        private string DataToHex(byte[] data, int bytesPerRow = 16, int bytesGroup = 4)  //15개 바이트씩 끊어서 Hex값을 출력함 (BinToHex)
        {
            string output = "";
            string asciitext = "";

            for (int i = 0; i < data.Length; i++)
            {
                if( i == 0 )
                {
                    output += $"{i:X3} : ";
                }
                else if (i % bytesPerRow == 0 && i > 0)  //새로운줄에서 갱신함, 단 처음은 제외
                {
                    output += " : " + asciitext;
                    asciitext = "";
                    output += Environment.NewLine;
                    output += $"{i:X3} : ";
                }

                //ASCII값을 asciitext에 16byte단위로 저장후 Newline전에 output에 추가시킴. 
                asciitext += (data[i] >= 0x20 && data[i] <= 0x7E) || (data[i] >= 0xA0 && data[i] <= 0xFF)
                        // Display an ASCII character
                        ? ((char)data[i]).ToString()
                        // Display a middle dot for all other characters
                        : "·";

                //output += data[i].ToString("X2");
                output += $"{data[i]:X2}";

                if ( i % bytesPerRow != bytesPerRow - 1)  //마지막 바이트가 아닌경우, 공백을 추가함
                {
                    output += " ";
                }

                if(((i + 1 & 0x0F) % bytesGroup == 0) && (i % bytesPerRow != bytesPerRow -1))  //15개 바이트마다 공백을 추가함
                {
                    output += " ";
                }

                //마지막 Line의 ASCII변환값을 추가함. 
                if ( i == data.Length -1 )
                {
                    output += " : " + asciitext;
                }
            }
            return output;
        }

        private string DataToText(byte[] input)
        {

            int charsPerRow = 16;
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {

                // Add a new line, except before the first row
                if (i % charsPerRow == 0 && i > 0)
                {
                    output += Environment.NewLine;
                }

                output += (input[i] >= 0x20 && input[i] <= 0x7E) || (input[i] >= 0xA0 && input[i] <= 0xFF)
                    // Display an ASCII character
                    ? ((char)input[i]).ToString()
                    // Display a middle dot for all other characters
                    : "·";
            }

            return output;
        }

        private bool ValidateCrc(byte[] data)  //CRC를 검증함
        {
            if (data.Length < (int)SpdSize.SDR_SPD_SIZE)
            {
                return false;
            }

            if (Ddr5Spd.GetVerifyCrc() == false)
            {
                Logging($"SPD CRC가 불일치 ");
                return false;
            }
            else if (Ddr5Spd.xmpFound == true && Ddr5Spd.GetVerifyXMPCrc() == false)
            {
                Logging($"XMP CRC가 불일치 ");
                return false;
            }
            else if (Ddr5Spd.expoFound == true && Ddr5Spd.GetVerifyEXPOCrc() == false)
            {
                Logging($"EXPO CRC가 불일치 ");
                return false;
            }
            else
            {
                Logging($"CRC가 일치합니다. ");
                return true;
            }
        }
        private void SPDMain_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Data Update
            {                

                vm.ManufacturerId = tboxMID.Text;   //MID 변환함 
                tboxMIDparsing.Text = vm.ManufactureName(Ddr5Spd.ManufacturerId);
                vm.ManufacturingYear = ushort.Parse(tboxMDyear.Text);
                vm.ManufacturingWeek = ushort.Parse(tboxMDweek.Text);
                vm.SerialNumber = tboxSNum.Text;
                vm.PartNumber = tboxPNum.Text;
                vm.DramManufacturerId = tboxDMID.Text;
                tboxDMIDparsing.Text = vm.ManufactureName(Ddr5Spd.DramManufacturerId);
                vm.SpecificData = tboxMSD.Text;
            
            }
            else //Display
            {
                // Display SPD values
                tboxMID.Text = vm.ManufacturerId; ;
                tboxMIDparsing.Text = vm.ManufactureName(Ddr5Spd.ManufacturerId);
                tboxMDyear.Text = vm.ManufacturingYear.ToString();
                tboxMDweek.Text = vm.ManufacturingWeek.ToString();
                tboxSNum.Text = vm.SerialNumber;
                tboxPNum.Text = vm.PartNumber;
                tboxDMID.Text = vm.DramManufacturerId;
                tboxDMIDparsing.Text = vm.ManufactureName(Ddr5Spd.DramManufacturerId);
                tboxMSD.Text = vm.SpecificData;
            }

        }

        private void SPD_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Data Update
            {
                /* Frequency */
                vm.MinCycleTime = (ushort)updnMinCycleTime.Value;
                tboxSpdFrequency.Text = vm.Frequency + " Mhz";
                tboxSpdMegaTransfers.Text = vm.MegaTransfers + " MT/s";

                /* Supported CAS Latencies */
                vm.CL20 = cboxCL20.Checked; vm.CL22 = cboxCL22.Checked; vm.CL24 = cboxCL24.Checked; 
                vm.CL26 = cboxCL26.Checked;
                vm.CL28 = cboxCL28.Checked; vm.CL30 = cboxCL30.Checked; vm.CL32 = cboxCL32.Checked;
                vm.CL34 = cboxCL34.Checked; vm.CL36 = cboxCL36.Checked; vm.CL38 = cboxCL38.Checked;
                vm.CL40 = cboxCL40.Checked; vm.CL42 = cboxCL42.Checked; vm.CL44 = cboxCL44.Checked;
                vm.CL46 = cboxCL46.Checked; vm.CL48 = cboxCL48.Checked; vm.CL50 = cboxCL50.Checked;
                vm.CL52 = cboxCL52.Checked; vm.CL54 = cboxCL54.Checked; vm.CL56 = cboxCL56.Checked;
                vm.CL58 = cboxCL58.Checked; vm.CL60 = cboxCL60.Checked; vm.CL62 = cboxCL62.Checked;
                vm.CL64 = cboxCL64.Checked; vm.CL66 = cboxCL66.Checked; vm.CL68 = cboxCL68.Checked;
                vm.CL70 = cboxCL70.Checked; vm.CL72 = cboxCL72.Checked; vm.CL74 = cboxCL74.Checked;
                vm.CL76 = cboxCL76.Checked; vm.CL78 = cboxCL78.Checked; vm.CL80 = cboxCL80.Checked;
                vm.CL82 = cboxCL82.Checked; vm.CL84 = cboxCL84.Checked; vm.CL86 = cboxCL86.Checked;
                vm.CL88 = cboxCL88.Checked; vm.CL90 = cboxCL90.Checked; vm.CL92 = cboxCL92.Checked;
                vm.CL94 = cboxCL94.Checked; vm.CL96 = cboxCL96.Checked; vm.CL98 = cboxCL98.Checked;

                /* Timings */
                vm.tAA = ushort.Parse(tboxTiming_tAA.Text); 
                vm.tRCD = ushort.Parse(tboxTiming_tRCD.Text);
                vm.tRP = ushort.Parse(tboxTiming_tRP.Text);
                vm.tRAS = ushort.Parse(tboxTiming_tRAS.Text);
                vm.tRC = ushort.Parse(tboxTiming_tRC.Text);
                vm.tWR = ushort.Parse(tboxTiming_tWR.Text);
                vm.tRFC1_slr = ushort.Parse(tboxTiming_tRFC1.Text);
                vm.tRFC2_slr = ushort.Parse(tboxTiming_tRFC2.Text); 
                vm.tRFCsb_slr = ushort.Parse(tboxTiming_tRFCsb.Text);

                vm.tRRD_L = ushort.Parse(tboxTiming_tRRD_L.Text);
                vm.tCCD_L = ushort.Parse(tboxTiming_tCCD_L.Text);
                vm.tCCD_L_WR = ushort.Parse(tboxTiming_tCCD_L_WR.Text);
                vm.tCCD_L_WR2 = ushort.Parse(tboxTiming_tCCD_L_WR2.Text);
                vm.tFAW = ushort.Parse(tboxTiming_tFAW.Text);
                vm.tCCD_L_WTR = ushort.Parse(tboxTiming_tCCD_L_WTR.Text);
                vm.tCCD_S_WTR = ushort.Parse(tboxTiming_tCCD_S_WTR.Text);
                vm.tRTP = ushort.Parse(tboxTiming_tRTP.Text);

                vm.tRRD_L_lowerLimit = ushort.Parse(tboxTimingLmt_tRRD_L.Text);
                vm.tCCD_L_lowerLimit = ushort.Parse(tboxTimingLmt_tCCD_L.Text);
                vm.tCCD_L_WR_lowerLimit = ushort.Parse(tboxTimingLmt_tCCD_L_WR.Text);
                vm.tCCD_L_WR2_lowerLimit = ushort.Parse(tboxTimingLmt_tCCD_L_WR2.Text);
                vm.tFAW_lowerLimit = ushort.Parse(tboxTimingLmt_tFAW.Text);
                vm.tCCD_L_WTR_lowerLimit = ushort.Parse(tboxTimingLmt_tCCD_L_WTR.Text);
                vm.tCCD_S_WTR_lowerLimit = ushort.Parse(tboxTimingLmt_tCCD_S_WTR.Text);
                vm.tRTP_lowerLimit = ushort.Parse(tboxTimingLmt_tRTP.Text);
            }
            else //Display
            {
                /* Frequency */
                updnMinCycleTime.Text = vm.MinCycleTime.ToString();
                tboxSpdFrequency.Text = vm.Frequency + " Mhz";
                tboxSpdMegaTransfers.Text = vm.MegaTransfers + " MT/s";

                /* Supported CAS Latencies */
                cboxCL20.Checked = vm.CL20; cboxCL22.Checked = vm.CL22; cboxCL24.Checked = vm.CL24; 
                cboxCL26.Checked = vm.CL26;
                cboxCL28.Checked = vm.CL28; cboxCL30.Checked = vm.CL30; cboxCL32.Checked = vm.CL32;
                cboxCL34.Checked = vm.CL34; cboxCL36.Checked = vm.CL36; cboxCL38.Checked = vm.CL38;
                cboxCL40.Checked = vm.CL40; cboxCL42.Checked = vm.CL42; cboxCL44.Checked = vm.CL44;
                cboxCL46.Checked = vm.CL46; cboxCL48.Checked = vm.CL48; cboxCL50.Checked = vm.CL50;
                cboxCL52.Checked = vm.CL52; cboxCL54.Checked = vm.CL54; cboxCL56.Checked = vm.CL56;
                cboxCL58.Checked = vm.CL58; cboxCL60.Checked = vm.CL60; cboxCL62.Checked = vm.CL62;
                cboxCL64.Checked = vm.CL64; cboxCL66.Checked = vm.CL66; cboxCL68.Checked = vm.CL68;
                cboxCL70.Checked = vm.CL70; cboxCL72.Checked = vm.CL72; cboxCL74.Checked = vm.CL74;
                cboxCL76.Checked = vm.CL76; cboxCL78.Checked = vm.CL78; cboxCL80.Checked = vm.CL80;
                cboxCL82.Checked = vm.CL82; cboxCL84.Checked = vm.CL84; cboxCL86.Checked = vm.CL86;
                cboxCL88.Checked = vm.CL88; cboxCL90.Checked = vm.CL90; cboxCL92.Checked = vm.CL92;
                cboxCL94.Checked = vm.CL94; cboxCL96.Checked = vm.CL96; cboxCL98.Checked = vm.CL98;

                /* Timings */
                tboxTiming_tAA.Text = vm.tAA.ToString();
                tboxTiming_tRCD.Text = vm.tRCD.ToString();
                tboxTiming_tRP.Text = vm.tRP.ToString();
                tboxTiming_tRAS.Text = vm.tRAS.ToString();
                tboxTiming_tRC.Text = vm.tRC.ToString();
                tboxTiming_tWR.Text = vm.tWR.ToString();
                tboxTiming_tRFC1.Text = vm.tRFC1_slr.ToString();
                tboxTiming_tRFC2.Text = vm.tRFC2_slr.ToString();
                tboxTiming_tRFCsb.Text = vm.tRFCsb_slr.ToString();

                tboxTiming_tRRD_L.Text = vm.tRRD_L.ToString();
                tboxTiming_tCCD_L.Text = vm.tCCD_L.ToString();
                tboxTiming_tCCD_L_WR.Text = vm.tCCD_L_WR.ToString();
                tboxTiming_tCCD_L_WR2.Text = vm.tCCD_L_WR2.ToString();
                tboxTiming_tFAW.Text = vm.tFAW.ToString();
                tboxTiming_tCCD_L_WTR.Text = vm.tCCD_L_WTR.ToString();
                tboxTiming_tCCD_S_WTR.Text = vm.tCCD_S_WTR.ToString();
                tboxTiming_tRTP.Text = vm.tRTP.ToString();

                tboxTimingLmt_tRRD_L.Text = vm.tRRD_L_lowerLimit.ToString();
                tboxTimingLmt_tCCD_L.Text = vm.tCCD_L_lowerLimit.ToString();
                tboxTimingLmt_tCCD_L_WR.Text = vm.tCCD_L_WR_lowerLimit.ToString();
                tboxTimingLmt_tCCD_L_WR2.Text = vm.tCCD_L_WR2_lowerLimit.ToString();
                tboxTimingLmt_tFAW.Text = vm.tFAW_lowerLimit.ToString();
                tboxTimingLmt_tCCD_L_WTR.Text = vm.tCCD_L_WTR_lowerLimit.ToString();
                tboxTimingLmt_tCCD_S_WTR.Text = vm.tCCD_S_WTR_lowerLimit.ToString();
                tboxTimingLmt_tRTP.Text = vm.tRTP_lowerLimit.ToString();

                lblTiming_tAA.Text = vm.tAATicks.ToString();
                lblTiming_tRCD.Text = vm.tRCDTicks.ToString();
                lblTiming_tRP.Text = vm.tRPTicks.ToString();
                lblTiming_tRAS.Text = vm.tRASTicks.ToString();
                lblTiming_tRC.Text = vm.tRCTicks.ToString();
                lblTiming_tWR.Text = vm.tWRTicks.ToString();
                lblTiming_tRFC1.Text = vm.tRFC1_slrTicks.ToString();
                lblTiming_tRFC2.Text = vm.tRFC2_slrTicks.ToString();
                lblTiming_tRFCsb.Text = vm.tRFCsb_slrTicks.ToString();

                lblTiming_tRRD_L.Text = vm.tRRD_LTicks.ToString();
                lblTiming_tCCD_L.Text = vm.tCCD_LTicks.ToString();
                lblTiming_tCCD_L_WR.Text = vm.tCCD_L_WRTicks.ToString();
                lblTiming_tCCD_L_WR2.Text = vm.tCCD_L_WR2Ticks.ToString();
                lblTiming_tFAW.Text = vm.tFAWTicks.ToString();
                lblTiming_tCCD_L_WTR.Text = vm.tCCD_L_WTRTicks.ToString();
                lblTiming_tCCD_S_WTR.Text = vm.tCCD_S_WTRTicks.ToString();
                lblTiming_tRTP.Text = vm.tRTPTicks.ToString();
            }
        }

        private void XMP1_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Update
            {
                /* XMP Organization */
                vm.XMP1Enabled = cbox_EnableXMP1.Checked;

                /* Profile */
                vm.XMPProfile1Name = tboxXMP1_ProfileName.Text;

                /* Frequency */
                vm.XMP1.MinCycleTime = (ushort)updnXMP1_MinCycleTime.Value;
                tboxXMP1_Frequency.Text = vm.XMP1.Frequency  + " MMz";
                tboxXMP1_MegaTransfers.Text = vm.XMP1.MegaTransfers + " MT/s";
                vm.XMP1.CommandRate = (XMP_3_0.CommandRatesEnum?)comboxXMP1_CommandRate.SelectedIndex;
                vm.XMP1.IntelDynamicMemoryBoost = cboxXMP1_IntelDynamicMemoryBoost.Checked;
                vm.XMP1.RealTimeMemoryFrequencyOC = cboxXMP1_RealTimeMemoryFrequencyOC.Checked;

                /* Voltages */
                vm.XMP1.VDD = ushort.Parse(tboxXMP1_VDD.Text);
                vm.XMP1.VDDQ = ushort.Parse(tboxXMP1_VDDQ.Text);
                vm.XMP1.VPP = ushort.Parse(tboxXMP1_VPP.Text);
                vm.XMP1.VMEMCTRL = ushort.Parse(tboxXMP1_VMEM.Text);

                /* Supported CAS Latencies */
                vm.XMP1.CL20 = cboxXMP1_CL20.Checked; vm.XMP1.CL22 = cboxXMP1_CL22.Checked; vm.XMP1.CL24 = cboxXMP1_CL24.Checked; 
                vm.XMP1.CL26 = cboxXMP1_CL26.Checked; vm.XMP1.CL28 = cboxXMP1_CL28.Checked; vm.XMP1.CL30 = cboxXMP1_CL30.Checked; 
                vm.XMP1.CL32 = cboxXMP1_CL32.Checked; vm.XMP1.CL34 = cboxXMP1_CL34.Checked; vm.XMP1.CL36 = cboxXMP1_CL36.Checked; 
                vm.XMP1.CL38 = cboxXMP1_CL38.Checked; vm.XMP1.CL40 = cboxXMP1_CL40.Checked; vm.XMP1.CL42 = cboxXMP1_CL42.Checked; 
                vm.XMP1.CL44 = cboxXMP1_CL44.Checked; vm.XMP1.CL46 = cboxXMP1_CL46.Checked; vm.XMP1.CL48 = cboxXMP1_CL48.Checked; 
                vm.XMP1.CL50 = cboxXMP1_CL50.Checked; vm.XMP1.CL52 = cboxXMP1_CL52.Checked; vm.XMP1.CL54 = cboxXMP1_CL54.Checked; 
                vm.XMP1.CL56 = cboxXMP1_CL56.Checked; vm.XMP1.CL58 = cboxXMP1_CL58.Checked; vm.XMP1.CL60 = cboxXMP1_CL60.Checked; 
                vm.XMP1.CL62 = cboxXMP1_CL62.Checked; vm.XMP1.CL64 = cboxXMP1_CL64.Checked; vm.XMP1.CL66 = cboxXMP1_CL66.Checked; 
                vm.XMP1.CL68 = cboxXMP1_CL68.Checked; vm.XMP1.CL70 = cboxXMP1_CL70.Checked; vm.XMP1.CL72 = cboxXMP1_CL72.Checked; 
                vm.XMP1.CL74 = cboxXMP1_CL74.Checked; vm.XMP1.CL76 = cboxXMP1_CL76.Checked; vm.XMP1.CL78 = cboxXMP1_CL78.Checked; 
                vm.XMP1.CL80 = cboxXMP1_CL80.Checked; vm.XMP1.CL82 = cboxXMP1_CL82.Checked; vm.XMP1.CL84 = cboxXMP1_CL84.Checked; 
                vm.XMP1.CL86 = cboxXMP1_CL86.Checked; vm.XMP1.CL88 = cboxXMP1_CL88.Checked; vm.XMP1.CL90 = cboxXMP1_CL90.Checked;
                vm.XMP1.CL92 = cboxXMP1_CL92.Checked; vm.XMP1.CL94 = cboxXMP1_CL94.Checked; vm.XMP1.CL96 = cboxXMP1_CL96.Checked; 
                vm.XMP1.CL98 = cboxXMP1_CL98.Checked;

                /* Timing */
                vm.XMP1.tAA = ushort.Parse(tboxXMP1_tAA.Text);
                vm.XMP1.tRCD = ushort.Parse(tboxXMP1_tRCD.Text);
                vm.XMP1.tRP = ushort.Parse(tboxXMP1_tRP.Text);
                vm.XMP1.tRAS = ushort.Parse(tboxXMP1_tRAS.Text);
                vm.XMP1.tRC = ushort.Parse(tboxXMP1_tRC.Text);
                vm.XMP1.tWR = ushort.Parse(tboxXMP1_tWR.Text);
                vm.XMP1.tRFC1 = ushort.Parse(tboxXMP1_tRFC1.Text);
                vm.XMP1.tRFC2 = ushort.Parse(tboxXMP1_tRFC2.Text);
                vm.XMP1.tRFC = ushort.Parse(tboxXMP1_tRFCsb.Text);

                vm.XMP1.tRRD_L = ushort.Parse(tboxXMP1_tRRD_L.Text);
                vm.XMP1.tCCD_L = ushort.Parse(tboxXMP1_tCCD_L.Text);
                vm.XMP1.tCCD_L_WR = ushort.Parse(tboxXMP1_tCCD_L_WR.Text);
                vm.XMP1.tCCD_L_WR2 = ushort.Parse(tboxXMP1_tCCD_L_WR2.Text);
                vm.XMP1.tFAW = ushort.Parse(tboxXMP1_tFAW.Text);
                vm.XMP1.tCCD_L_WTR = ushort.Parse(tboxXMP1_tCCD_L_WTR.Text);
                vm.XMP1.tCCD_S_WTR = ushort.Parse(tboxXMP1_tCCD_S_WTR.Text);
                vm.XMP1.tRTP = ushort.Parse(tboxXMP1_tRTP.Text);

                vm.XMP1.tRRD_L_lowerLimit = ushort.Parse(tboxXMP1Lmt_tRRD_L.Text);
                vm.XMP1.tCCD_L_lowerLimit = ushort.Parse(tboxXMP1Lmt_tCCD_L.Text);
                vm.XMP1.tCCD_L_WR_lowerLimit = ushort.Parse(tboxXMP1Lmt_tCCD_L_WR.Text);
                vm.XMP1.tCCD_L_WR2_lowerLimit = ushort.Parse(tboxXMP1Lmt_tCCD_L_WR2.Text);
                vm.XMP1.tFAW_lowerLimit = ushort.Parse(tboxXMP1Lmt_tFAW.Text);
                vm.XMP1.tCCD_L_WTR_lowerLimit = ushort.Parse(tboxXMP1Lmt_tCCD_L_WTR.Text);
                vm.XMP1.tCCD_S_WTR_lowerLimit = ushort.Parse(tboxXMP1Lmt_tCCD_S_WTR.Text);
                vm.XMP1.tRTP_lowerLimit = ushort.Parse(tboxXMP1Lmt_tRTP.Text);

                lblXMP1_tAA.Text = vm.XMP1.tAATicks.ToString();
                lblXMP1_tRCD.Text = vm.XMP1.tRCDTicks.ToString();
                lblXMP1_tRP.Text = vm.XMP1.tRPTicks.ToString();
                lblXMP1_tRAS.Text = vm.XMP1.tRASTicks.ToString();
                lblXMP1_tRC.Text = vm.XMP1.tRCTicks.ToString();
                lblXMP1_tWR.Text = vm.XMP1.tWRTicks.ToString();
                lblXMP1_tRFC1.Text = vm.XMP1.tRFC1Ticks.ToString();
                lblXMP1_tRFC2.Text = vm.XMP1.tRFC2Ticks.ToString();
                lblXMP1_tRFCsb.Text = vm.XMP1.tRFCTicks.ToString();

                lblXMP1_tRRD_L.Text = vm.XMP1.tRRD_LTicks.ToString();
                lblXMP1_tCCD_L.Text = vm.XMP1.tCCD_LTicks.ToString();
                lblXMP1_tCCD_L_WR.Text = vm.XMP1.tCCD_L_WRTicks.ToString();
                lblXMP1_tCCD_L_WR2.Text = vm.XMP1.tCCD_L_WR2Ticks.ToString();
                lblXMP1_tFAW.Text = vm.XMP1.tFAWTicks.ToString();
                lblXMP1_tCCD_L_WTR.Text = vm.XMP1.tCCD_L_WTRTicks.ToString();
                lblXMP1_tCCD_S_WTR.Text = vm.XMP1.tCCD_S_WTRTicks.ToString();
                lblXMP1_tRTP.Text = vm.XMP1.tRTPTicks.ToString();

            }
            else //Display
            {
                cbox_EnableXMP1.Checked = vm.XMP1Enabled;
                tabPageSPD_XMP1.Enabled = cbox_EnableXMP1.Checked;

                /* Profile */
                tboxXMP1_ProfileName.Text = vm.XMPProfile1Name;

                /* Frequency */
                updnXMP1_MinCycleTime.Text = vm.XMP1.MinCycleTime.ToString();
                tboxXMP1_Frequency.Text = vm.XMP1.Frequency + " Mhz";
                tboxXMP1_MegaTransfers.Text = vm.XMP1.MegaTransfers + " MT/s";
                comboxXMP1_CommandRate.Text = vm.XMP1.CommandRate.ToString();
                cboxXMP1_IntelDynamicMemoryBoost.Checked = vm.XMP1.IntelDynamicMemoryBoost;
                cboxXMP1_RealTimeMemoryFrequencyOC.Checked = vm.XMP1.RealTimeMemoryFrequencyOC;

                /* Voltages */
                tboxXMP1_VDD.Text = vm.XMP1.VDD.ToString();
                tboxXMP1_VDDQ.Text = vm.XMP1.VDDQ.ToString();
                tboxXMP1_VPP.Text = vm.XMP1.VPP.ToString();
                tboxXMP1_VMEM.Text = vm.XMP1.VMEMCTRL.ToString();

                /* Supported CAS Latencies */
                cboxXMP1_CL20.Checked = vm.XMP1.CL20; cboxXMP1_CL22.Checked = vm.XMP1.CL22; cboxXMP1_CL24.Checked = vm.XMP1.CL24;
                cboxXMP1_CL26.Checked = vm.XMP1.CL26; cboxXMP1_CL28.Checked = vm.XMP1.CL28; cboxXMP1_CL30.Checked = vm.XMP1.CL30;
                cboxXMP1_CL32.Checked = vm.XMP1.CL32; cboxXMP1_CL34.Checked = vm.XMP1.CL34; cboxXMP1_CL36.Checked = vm.XMP1.CL36;
                cboxXMP1_CL38.Checked = vm.XMP1.CL38; cboxXMP1_CL40.Checked = vm.XMP1.CL40; cboxXMP1_CL42.Checked = vm.XMP1.CL42;
                cboxXMP1_CL44.Checked = vm.XMP1.CL44; cboxXMP1_CL46.Checked = vm.XMP1.CL46; cboxXMP1_CL48.Checked = vm.XMP1.CL48;
                cboxXMP1_CL50.Checked = vm.XMP1.CL50; cboxXMP1_CL52.Checked = vm.XMP1.CL52; cboxXMP1_CL54.Checked = vm.XMP1.CL54;
                cboxXMP1_CL56.Checked = vm.XMP1.CL56; cboxXMP1_CL58.Checked = vm.XMP1.CL58; cboxXMP1_CL60.Checked = vm.XMP1.CL60;
                cboxXMP1_CL62.Checked = vm.XMP1.CL62; cboxXMP1_CL64.Checked = vm.XMP1.CL64; cboxXMP1_CL66.Checked = vm.XMP1.CL66;
                cboxXMP1_CL68.Checked = vm.XMP1.CL68; cboxXMP1_CL70.Checked = vm.XMP1.CL70; cboxXMP1_CL72.Checked = vm.XMP1.CL72;
                cboxXMP1_CL74.Checked = vm.XMP1.CL74; cboxXMP1_CL76.Checked = vm.XMP1.CL76; cboxXMP1_CL78.Checked = vm.XMP1.CL78;
                cboxXMP1_CL80.Checked = vm.XMP1.CL80; cboxXMP1_CL82.Checked = vm.XMP1.CL82; cboxXMP1_CL84.Checked = vm.XMP1.CL84;
                cboxXMP1_CL86.Checked = vm.XMP1.CL86; cboxXMP1_CL88.Checked = vm.XMP1.CL88; cboxXMP1_CL90.Checked = vm.XMP1.CL90;
                cboxXMP1_CL92.Checked = vm.XMP1.CL92; cboxXMP1_CL94.Checked = vm.XMP1.CL94; cboxXMP1_CL96.Checked = vm.XMP1.CL96;
                cboxXMP1_CL98.Checked = vm.XMP1.CL98;

                /* Timing */
                tboxXMP1_tAA.Text = vm.XMP1.tAA.ToString();
                tboxXMP1_tRCD.Text = vm.XMP1.tRCD.ToString();
                tboxXMP1_tRP.Text = vm.XMP1.tRP.ToString();
                tboxXMP1_tRAS.Text = vm.XMP1.tRAS.ToString();
                tboxXMP1_tRC.Text = vm.XMP1.tRC.ToString();
                tboxXMP1_tWR.Text = vm.XMP1.tWR.ToString();
                tboxXMP1_tRFC1.Text = vm.XMP1.tRFC1.ToString();
                tboxXMP1_tRFC2.Text = vm.XMP1.tRFC2.ToString();
                tboxXMP1_tRFCsb.Text = vm.XMP1.tRFC.ToString();

                tboxXMP1_tRRD_L.Text = vm.XMP1.tRRD_L.ToString();
                tboxXMP1_tCCD_L.Text = vm.XMP1.tCCD_L.ToString();
                tboxXMP1_tCCD_L_WR.Text = vm.XMP1.tCCD_L_WR.ToString();
                tboxXMP1_tCCD_L_WR2.Text = vm.XMP1.tCCD_L_WR2.ToString();
                tboxXMP1_tFAW.Text = vm.XMP1.tFAW.ToString();
                tboxXMP1_tCCD_L_WTR.Text = vm.XMP1.tCCD_L_WTR.ToString();
                tboxXMP1_tCCD_S_WTR.Text = vm.XMP1.tCCD_S_WTR.ToString();
                tboxXMP1_tRTP.Text = vm.XMP1.tRTP.ToString();

                tboxXMP1Lmt_tRRD_L.Text = vm.XMP1.tRRD_L_lowerLimit.ToString();
                tboxXMP1Lmt_tCCD_L.Text = vm.XMP1.tCCD_L_lowerLimit.ToString();
                tboxXMP1Lmt_tCCD_L_WR.Text = vm.XMP1.tCCD_L_WR_lowerLimit.ToString();
                tboxXMP1Lmt_tCCD_L_WR2.Text = vm.XMP1.tCCD_L_WR2_lowerLimit.ToString();
                tboxXMP1Lmt_tFAW.Text = vm.XMP1.tFAW_lowerLimit.ToString();
                tboxXMP1Lmt_tCCD_L_WTR.Text = vm.XMP1.tCCD_L_WTR_lowerLimit.ToString();
                tboxXMP1Lmt_tCCD_S_WTR.Text = vm.XMP1.tCCD_S_WTR_lowerLimit.ToString();
                tboxXMP1Lmt_tRTP.Text = vm.XMP1.tRTP_lowerLimit.ToString();

                lblXMP1_tAA.Text = vm.XMP1.tAATicks.ToString();
                lblXMP1_tRCD.Text = vm.XMP1.tRCDTicks.ToString();
                lblXMP1_tRP.Text = vm.XMP1.tRPTicks.ToString();
                lblXMP1_tRAS.Text = vm.XMP1.tRASTicks.ToString();
                lblXMP1_tRC.Text = vm.XMP1.tRCTicks.ToString();
                lblXMP1_tWR.Text = vm.XMP1.tWRTicks.ToString();
                lblXMP1_tRFC1.Text = vm.XMP1.tRFC1Ticks.ToString();
                lblXMP1_tRFC2.Text = vm.XMP1.tRFC2Ticks.ToString();
                lblXMP1_tRFCsb.Text = vm.XMP1.tRFCTicks.ToString();

                lblXMP1_tRRD_L.Text = vm.XMP1.tRRD_LTicks.ToString();
                lblXMP1_tCCD_L.Text = vm.XMP1.tCCD_LTicks.ToString();
                lblXMP1_tCCD_L_WR.Text = vm.XMP1.tCCD_L_WRTicks.ToString();
                lblXMP1_tCCD_L_WR2.Text = vm.XMP1.tCCD_L_WR2Ticks.ToString();
                lblXMP1_tFAW.Text = vm.XMP1.tFAWTicks.ToString();
                lblXMP1_tCCD_L_WTR.Text = vm.XMP1.tCCD_L_WTRTicks.ToString();
                lblXMP1_tCCD_S_WTR.Text = vm.XMP1.tCCD_S_WTRTicks.ToString();
                lblXMP1_tRTP.Text = vm.XMP1.tRTPTicks.ToString();
            }
        }

        private void XMP2_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Update
            {
                /* XMP Organization */
                vm.XMP2Enabled = cbox_EnableXMP2.Checked;

                /* Profile */
                vm.XMPProfile2Name = tboxXMP2_ProfileName.Text;

                /* Frequency */
                vm.XMP2.MinCycleTime = (ushort)updnXMP2_MinCycleTime.Value;
                tboxXMP2_Frequency.Text = vm.XMP2.Frequency + " Mhz";
                tboxXMP2_MegaTransfers.Text = vm.XMP2.MegaTransfers + " MT/s";
                vm.XMP2.CommandRate = (XMP_3_0.CommandRatesEnum?)comboxXMP2_CommandRate.SelectedIndex;                
                vm.XMP2.IntelDynamicMemoryBoost = cboxXMP2_IntelDynamicMemoryBoost.Checked;
                vm.XMP2.RealTimeMemoryFrequencyOC = cboxXMP2_RealTimeMemoryFrequencyOC.Checked;

                /* Voltages */
                vm.XMP2.VDD = ushort.Parse(tboxXMP2_VDD.Text);
                vm.XMP2.VDDQ = ushort.Parse(tboxXMP2_VDDQ.Text);
                vm.XMP2.VPP = ushort.Parse(tboxXMP2_VPP.Text);
                vm.XMP2.VMEMCTRL = ushort.Parse(tboxXMP2_VMEM.Text);

                /* Supported CAS Latencies */
                vm.XMP2.CL20 = cboxXMP2_CL20.Checked; vm.XMP2.CL22 = cboxXMP2_CL22.Checked; vm.XMP2.CL24 = cboxXMP2_CL24.Checked;
                vm.XMP2.CL26 = cboxXMP2_CL26.Checked; vm.XMP2.CL28 = cboxXMP2_CL28.Checked; vm.XMP2.CL30 = cboxXMP2_CL30.Checked;
                vm.XMP2.CL32 = cboxXMP2_CL32.Checked; vm.XMP2.CL34 = cboxXMP2_CL34.Checked; vm.XMP2.CL36 = cboxXMP2_CL36.Checked;
                vm.XMP2.CL38 = cboxXMP2_CL38.Checked; vm.XMP2.CL40 = cboxXMP2_CL40.Checked; vm.XMP2.CL42 = cboxXMP2_CL42.Checked;
                vm.XMP2.CL44 = cboxXMP2_CL44.Checked; vm.XMP2.CL46 = cboxXMP2_CL46.Checked; vm.XMP2.CL48 = cboxXMP2_CL48.Checked;
                vm.XMP2.CL50 = cboxXMP2_CL50.Checked; vm.XMP2.CL52 = cboxXMP2_CL52.Checked; vm.XMP2.CL54 = cboxXMP2_CL54.Checked;
                vm.XMP2.CL56 = cboxXMP2_CL56.Checked; vm.XMP2.CL58 = cboxXMP2_CL58.Checked; vm.XMP2.CL60 = cboxXMP2_CL60.Checked;
                vm.XMP2.CL62 = cboxXMP2_CL62.Checked; vm.XMP2.CL64 = cboxXMP2_CL64.Checked; vm.XMP2.CL66 = cboxXMP2_CL66.Checked;
                vm.XMP2.CL68 = cboxXMP2_CL68.Checked; vm.XMP2.CL70 = cboxXMP2_CL70.Checked; vm.XMP2.CL72 = cboxXMP2_CL72.Checked;
                vm.XMP2.CL74 = cboxXMP2_CL74.Checked; vm.XMP2.CL76 = cboxXMP2_CL76.Checked; vm.XMP2.CL78 = cboxXMP2_CL78.Checked;
                vm.XMP2.CL80 = cboxXMP2_CL80.Checked; vm.XMP2.CL82 = cboxXMP2_CL82.Checked; vm.XMP2.CL84 = cboxXMP2_CL84.Checked;
                vm.XMP2.CL86 = cboxXMP2_CL86.Checked; vm.XMP2.CL88 = cboxXMP2_CL88.Checked; vm.XMP2.CL90 = cboxXMP2_CL90.Checked;
                vm.XMP2.CL92 = cboxXMP2_CL92.Checked; vm.XMP2.CL94 = cboxXMP2_CL94.Checked; vm.XMP2.CL96 = cboxXMP2_CL96.Checked;
                vm.XMP2.CL98 = cboxXMP2_CL98.Checked;

                /* Timing */
                vm.XMP2.tAA = ushort.Parse(tboxXMP2_tAA.Text);
                vm.XMP2.tRCD = ushort.Parse(tboxXMP2_tRCD.Text);
                vm.XMP2.tRP = ushort.Parse(tboxXMP2_tRP.Text);
                vm.XMP2.tRAS = ushort.Parse(tboxXMP2_tRAS.Text);
                vm.XMP2.tRC = ushort.Parse(tboxXMP2_tRC.Text);
                vm.XMP2.tWR = ushort.Parse(tboxXMP2_tWR.Text);
                vm.XMP2.tRFC1 = ushort.Parse(tboxXMP2_tRFC1.Text);
                vm.XMP2.tRFC2 = ushort.Parse(tboxXMP2_tRFC2.Text);
                vm.XMP2.tRFC = ushort.Parse(tboxXMP2_tRFCsb.Text);

                vm.XMP2.tRRD_L = ushort.Parse(tboxXMP2_tRRD_L.Text);
                vm.XMP2.tCCD_L = ushort.Parse(tboxXMP2_tCCD_L.Text);
                vm.XMP2.tCCD_L_WR = ushort.Parse(tboxXMP2_tCCD_L_WR.Text);
                vm.XMP2.tCCD_L_WR2 = ushort.Parse(tboxXMP2_tCCD_L_WR2.Text);
                vm.XMP2.tFAW = ushort.Parse(tboxXMP2_tFAW.Text);
                vm.XMP2.tCCD_L_WTR = ushort.Parse(tboxXMP2_tCCD_L_WTR.Text);
                vm.XMP2.tCCD_S_WTR = ushort.Parse(tboxXMP2_tCCD_S_WTR.Text);
                vm.XMP2.tRTP = ushort.Parse(tboxXMP2_tRTP.Text);

                vm.XMP2.tRRD_L_lowerLimit = ushort.Parse(tboxXMP2Lmt_tRRD_L.Text);
                vm.XMP2.tCCD_L_lowerLimit = ushort.Parse(tboxXMP2Lmt_tCCD_L.Text);
                vm.XMP2.tCCD_L_WR_lowerLimit = ushort.Parse(tboxXMP2Lmt_tCCD_L_WR.Text);
                vm.XMP2.tCCD_L_WR2_lowerLimit = ushort.Parse(tboxXMP2Lmt_tCCD_L_WR2.Text);
                vm.XMP2.tFAW_lowerLimit = ushort.Parse(tboxXMP2Lmt_tFAW.Text);
                vm.XMP2.tCCD_L_WTR_lowerLimit = ushort.Parse(tboxXMP2Lmt_tCCD_L_WTR.Text);
                vm.XMP2.tCCD_S_WTR_lowerLimit = ushort.Parse(tboxXMP2Lmt_tCCD_S_WTR.Text);
                vm.XMP2.tRTP_lowerLimit = ushort.Parse(tboxXMP2Lmt_tRTP.Text);

                lblXMP2_tAA.Text = vm.XMP2.tAATicks.ToString();
                lblXMP2_tRCD.Text = vm.XMP2.tRCDTicks.ToString();
                lblXMP2_tRP.Text = vm.XMP2.tRPTicks.ToString();
                lblXMP2_tRAS.Text = vm.XMP2.tRASTicks.ToString();
                lblXMP2_tRC.Text = vm.XMP2.tRCTicks.ToString();
                lblXMP2_tWR.Text = vm.XMP2.tWRTicks.ToString();
                lblXMP2_tRFC1.Text = vm.XMP2.tRFC1Ticks.ToString();
                lblXMP2_tRFC2.Text = vm.XMP2.tRFC2Ticks.ToString();
                lblXMP2_tRFCsb.Text = vm.XMP2.tRFCTicks.ToString();

                lblXMP2_tRRD_L.Text = vm.XMP2.tRRD_LTicks.ToString();
                lblXMP2_tCCD_L.Text = vm.XMP2.tCCD_LTicks.ToString();
                lblXMP2_tCCD_L_WR.Text = vm.XMP2.tCCD_L_WRTicks.ToString();
                lblXMP2_tCCD_L_WR2.Text = vm.XMP2.tCCD_L_WR2Ticks.ToString();
                lblXMP2_tFAW.Text = vm.XMP2.tFAWTicks.ToString();
                lblXMP2_tCCD_L_WTR.Text = vm.XMP2.tCCD_L_WTRTicks.ToString();
                lblXMP2_tCCD_S_WTR.Text = vm.XMP2.tCCD_S_WTRTicks.ToString();
                lblXMP2_tRTP.Text = vm.XMP2.tRTPTicks.ToString();

            }
            else //Display
            {
                cbox_EnableXMP2.Checked = vm.XMP2Enabled;
                tabPageSPD_XMP2.Enabled = cbox_EnableXMP2.Checked;

                /* Profile */
                tboxXMP2_ProfileName.Text = vm.XMPProfile2Name;

                /* Frequency */
                updnXMP2_MinCycleTime.Text = vm.XMP2.MinCycleTime.ToString();
                tboxXMP2_Frequency.Text = vm.XMP2.Frequency + " Mhz";
                tboxXMP2_MegaTransfers.Text = vm.XMP2.MegaTransfers + " MT/s";
                comboxXMP2_CommandRate.Text = vm.XMP2.CommandRate.ToString();
                cboxXMP2_IntelDynamicMemoryBoost.Checked = vm.XMP2.IntelDynamicMemoryBoost;
                cboxXMP2_RealTimeMemoryFrequencyOC.Checked = vm.XMP2.RealTimeMemoryFrequencyOC;

                /* Voltages */
                tboxXMP2_VDD.Text = vm.XMP2.VDD.ToString();
                tboxXMP2_VDDQ.Text = vm.XMP2.VDDQ.ToString();
                tboxXMP2_VPP.Text = vm.XMP2.VPP.ToString();
                tboxXMP2_VMEM.Text = vm.XMP2.VMEMCTRL.ToString();

                /* Supported CAS Latencies */
                cboxXMP2_CL20.Checked = vm.XMP2.CL20; cboxXMP2_CL22.Checked = vm.XMP2.CL22; cboxXMP2_CL24.Checked = vm.XMP2.CL24;
                cboxXMP2_CL26.Checked = vm.XMP2.CL26; cboxXMP2_CL28.Checked = vm.XMP2.CL28; cboxXMP2_CL30.Checked = vm.XMP2.CL30;
                cboxXMP2_CL32.Checked = vm.XMP2.CL32; cboxXMP2_CL34.Checked = vm.XMP2.CL34; cboxXMP2_CL36.Checked = vm.XMP2.CL36;
                cboxXMP2_CL38.Checked = vm.XMP2.CL38; cboxXMP2_CL40.Checked = vm.XMP2.CL40; cboxXMP2_CL42.Checked = vm.XMP2.CL42;
                cboxXMP2_CL44.Checked = vm.XMP2.CL44; cboxXMP2_CL46.Checked = vm.XMP2.CL46; cboxXMP2_CL48.Checked = vm.XMP2.CL48;
                cboxXMP2_CL50.Checked = vm.XMP2.CL50; cboxXMP2_CL52.Checked = vm.XMP2.CL52; cboxXMP2_CL54.Checked = vm.XMP2.CL54;
                cboxXMP2_CL56.Checked = vm.XMP2.CL56; cboxXMP2_CL58.Checked = vm.XMP2.CL58; cboxXMP2_CL60.Checked = vm.XMP2.CL60;
                cboxXMP2_CL62.Checked = vm.XMP2.CL62; cboxXMP2_CL64.Checked = vm.XMP2.CL64; cboxXMP2_CL66.Checked = vm.XMP2.CL66;
                cboxXMP2_CL68.Checked = vm.XMP2.CL68; cboxXMP2_CL70.Checked = vm.XMP2.CL70; cboxXMP2_CL72.Checked = vm.XMP2.CL72;
                cboxXMP2_CL74.Checked = vm.XMP2.CL74; cboxXMP2_CL76.Checked = vm.XMP2.CL76; cboxXMP2_CL78.Checked = vm.XMP2.CL78;
                cboxXMP2_CL80.Checked = vm.XMP2.CL80; cboxXMP2_CL82.Checked = vm.XMP2.CL82; cboxXMP2_CL84.Checked = vm.XMP2.CL84;
                cboxXMP2_CL86.Checked = vm.XMP2.CL86; cboxXMP2_CL88.Checked = vm.XMP2.CL88; cboxXMP2_CL90.Checked = vm.XMP2.CL90;
                cboxXMP2_CL92.Checked = vm.XMP2.CL92; cboxXMP2_CL94.Checked = vm.XMP2.CL94; cboxXMP2_CL96.Checked = vm.XMP2.CL96;
                cboxXMP2_CL98.Checked = vm.XMP2.CL98;

                /* Timing */
                tboxXMP2_tAA.Text = vm.XMP2.tAA.ToString();
                tboxXMP2_tRCD.Text = vm.XMP2.tRCD.ToString();
                tboxXMP2_tRP.Text = vm.XMP2.tRP.ToString();
                tboxXMP2_tRAS.Text = vm.XMP2.tRAS.ToString();
                tboxXMP2_tRC.Text = vm.XMP2.tRC.ToString();
                tboxXMP2_tWR.Text = vm.XMP2.tWR.ToString();
                tboxXMP2_tRFC1.Text = vm.XMP2.tRFC1.ToString();
                tboxXMP2_tRFC2.Text = vm.XMP2.tRFC2.ToString();
                tboxXMP2_tRFCsb.Text = vm.XMP2.tRFC.ToString();

                tboxXMP2_tRRD_L.Text = vm.XMP2.tRRD_L.ToString();
                tboxXMP2_tCCD_L.Text = vm.XMP2.tCCD_L.ToString();
                tboxXMP2_tCCD_L_WR.Text = vm.XMP2.tCCD_L_WR.ToString();
                tboxXMP2_tCCD_L_WR2.Text = vm.XMP2.tCCD_L_WR2.ToString();
                tboxXMP2_tFAW.Text = vm.XMP2.tFAW.ToString();
                tboxXMP2_tCCD_L_WTR.Text = vm.XMP2.tCCD_L_WTR.ToString();
                tboxXMP2_tCCD_S_WTR.Text = vm.XMP2.tCCD_S_WTR.ToString();
                tboxXMP2_tRTP.Text = vm.XMP2.tRTP.ToString();

                tboxXMP2Lmt_tRRD_L.Text = vm.XMP2.tRRD_L_lowerLimit.ToString();
                tboxXMP2Lmt_tCCD_L.Text = vm.XMP2.tCCD_L_lowerLimit.ToString();
                tboxXMP2Lmt_tCCD_L_WR.Text = vm.XMP2.tCCD_L_WR_lowerLimit.ToString();
                tboxXMP2Lmt_tCCD_L_WR2.Text = vm.XMP2.tCCD_L_WR2_lowerLimit.ToString();
                tboxXMP2Lmt_tFAW.Text = vm.XMP2.tFAW_lowerLimit.ToString();
                tboxXMP2Lmt_tCCD_L_WTR.Text = vm.XMP2.tCCD_L_WTR_lowerLimit.ToString();
                tboxXMP2Lmt_tCCD_S_WTR.Text = vm.XMP2.tCCD_S_WTR_lowerLimit.ToString();
                tboxXMP2Lmt_tRTP.Text = vm.XMP2.tRTP_lowerLimit.ToString();

                lblXMP2_tAA.Text = vm.XMP2.tAATicks.ToString();
                lblXMP2_tRCD.Text = vm.XMP2.tRCDTicks.ToString();
                lblXMP2_tRP.Text = vm.XMP2.tRPTicks.ToString();
                lblXMP2_tRAS.Text = vm.XMP2.tRASTicks.ToString();
                lblXMP2_tRC.Text = vm.XMP2.tRCTicks.ToString();
                lblXMP2_tWR.Text = vm.XMP2.tWRTicks.ToString();
                lblXMP2_tRFC1.Text = vm.XMP2.tRFC1Ticks.ToString();
                lblXMP2_tRFC2.Text = vm.XMP2.tRFC2Ticks.ToString();
                lblXMP2_tRFCsb.Text = vm.XMP2.tRFCTicks.ToString();

                lblXMP2_tRRD_L.Text = vm.XMP2.tRRD_LTicks.ToString();
                lblXMP2_tCCD_L.Text = vm.XMP2.tCCD_LTicks.ToString();
                lblXMP2_tCCD_L_WR.Text = vm.XMP2.tCCD_L_WRTicks.ToString();
                lblXMP2_tCCD_L_WR2.Text = vm.XMP2.tCCD_L_WR2Ticks.ToString();
                lblXMP2_tFAW.Text = vm.XMP2.tFAWTicks.ToString();
                lblXMP2_tCCD_L_WTR.Text = vm.XMP2.tCCD_L_WTRTicks.ToString();
                lblXMP2_tCCD_S_WTR.Text = vm.XMP2.tCCD_S_WTRTicks.ToString();
                lblXMP2_tRTP.Text = vm.XMP2.tRTPTicks.ToString();
            }
        }


        private void EXPO1_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Update
            {
                /* EXPO Organization */
                vm.EXPO1Enabled = cbox_EnableEXPO1.Checked;

                /* Frequency */
                vm.EXPO1.MinCycleTime = (ushort)updnEXPO1_MinCycleTime.Value;
                tboxEXPO1_Frequency.Text = vm.EXPO1.Frequency + " Mhz";
                tboxEXPO1_MegaTransfers.Text = vm.EXPO1.MegaTransfers + " MT/s";

                /* Voltages */
                vm.EXPO1.VDD = ushort.Parse(tboxEXPO1_VDD.Text);
                vm.EXPO1.VDDQ = ushort.Parse(tboxEXPO1_VDDQ.Text);
                vm.EXPO1.VPP = ushort.Parse(tboxEXPO1_VPP.Text);

                /* Timing */
                vm.EXPO1.tAA = ushort.Parse(tboxEXPO1_tAA.Text);
                vm.EXPO1.tRCD = ushort.Parse(tboxEXPO1_tRCD.Text);
                vm.EXPO1.tRP = ushort.Parse(tboxEXPO1_tRP.Text);
                vm.EXPO1.tRAS = ushort.Parse(tboxEXPO1_tRAS.Text);
                vm.EXPO1.tRC = ushort.Parse(tboxEXPO1_tRC.Text);
                vm.EXPO1.tWR = ushort.Parse(tboxEXPO1_tWR.Text);
                vm.EXPO1.tRFC1 = ushort.Parse(tboxEXPO1_tRFC1.Text);
                vm.EXPO1.tRFC2 = ushort.Parse(tboxEXPO1_tRFC2.Text);
                vm.EXPO1.tRFC = ushort.Parse(tboxEXPO1_tRFCsb.Text);

                vm.EXPO1.tRRD_L = ushort.Parse(tboxEXPO1_tRRD_L.Text);
                vm.EXPO1.tCCD_L = ushort.Parse(tboxEXPO1_tCCD_L.Text);
                vm.EXPO1.tCCD_L_WR = ushort.Parse(tboxEXPO1_tCCD_L_WR.Text);
                vm.EXPO1.tCCD_L_WR2 = ushort.Parse(tboxEXPO1_tCCD_L_WR2.Text);
                vm.EXPO1.tFAW = ushort.Parse(tboxEXPO1_tFAW.Text);
                vm.EXPO1.tCCD_L_WTR = ushort.Parse(tboxEXPO1_tCCD_L_WTR.Text);
                vm.EXPO1.tCCD_S_WTR = ushort.Parse(tboxEXPO1_tCCD_S_WTR.Text);
                vm.EXPO1.tRTP = ushort.Parse(tboxEXPO1_tRTP.Text);

                lblEXPO1_tAA.Text = vm.EXPO1.tAATicks.ToString();
                lblEXPO1_tRCD.Text = vm.EXPO1.tRCDTicks.ToString();
                lblEXPO1_tRP.Text = vm.EXPO1.tRPTicks.ToString();
                lblEXPO1_tRAS.Text = vm.EXPO1.tRASTicks.ToString();
                lblEXPO1_tRC.Text = vm.EXPO1.tRCTicks.ToString();
                lblEXPO1_tWR.Text = vm.EXPO1.tWRTicks.ToString();
                lblEXPO1_tRFC1.Text = vm.EXPO1.tRFC1Ticks.ToString();
                lblEXPO1_tRFC2.Text = vm.EXPO1.tRFC2Ticks.ToString();
                lblEXPO1_tRFC.Text = vm.EXPO1.tRFCTicks.ToString();

                lblEXPO1_tRRD_L.Text = vm.EXPO1.tRRD_LTicks.ToString();
                lblEXPO1_tCCD_L.Text = vm.EXPO1.tCCD_LTicks.ToString();
                lblEXPO1_tCCD_L_WR.Text = vm.EXPO1.tCCD_L_WRTicks.ToString();
                lblEXPO1_tCCD_L_WR2.Text = vm.EXPO1.tCCD_L_WR2Ticks.ToString();
                lblEXPO1_tFAW.Text = vm.EXPO1.tFAWTicks.ToString();
                lblEXPO1_tCCD_L_WTR.Text = vm.EXPO1.tCCD_L_WTRTicks.ToString();
                lblEXPO1_tCCD_S_WTR.Text = vm.EXPO1.tCCD_S_WTRTicks.ToString();
                lblEXPO1_tRTP.Text = vm.EXPO1.tRTPTicks.ToString();

            }
            else //Display
            {

                cbox_EnableEXPO1.Checked = vm.EXPO1Enabled;
                tabPageSPD_EXPO1.Enabled = cbox_EnableEXPO1.Checked;

                /* Frequency */
                updnEXPO1_MinCycleTime.Text = vm.EXPO1.MinCycleTime.ToString();
                tboxEXPO1_Frequency.Text = vm.EXPO1.Frequency + " Mhz";
                tboxEXPO1_MegaTransfers.Text = vm.EXPO1.MegaTransfers + " MT/s";

                /* Voltages */
                tboxEXPO1_VDD.Text = vm.EXPO1.VDD.ToString();
                tboxEXPO1_VDDQ.Text = vm.EXPO1.VDDQ.ToString();
                tboxEXPO1_VPP.Text = vm.EXPO1.VPP.ToString();

                /* Timing */
                tboxEXPO1_tAA.Text = vm.EXPO1.tAA.ToString();
                tboxEXPO1_tRCD.Text = vm.EXPO1.tRCD.ToString();
                tboxEXPO1_tRP.Text = vm.EXPO1.tRP.ToString();
                tboxEXPO1_tRAS.Text = vm.EXPO1.tRAS.ToString();
                tboxEXPO1_tRC.Text = vm.EXPO1.tRC.ToString();
                tboxEXPO1_tWR.Text = vm.EXPO1.tWR.ToString();
                tboxEXPO1_tRFC1.Text = vm.EXPO1.tRFC1.ToString();
                tboxEXPO1_tRFC2.Text = vm.EXPO1.tRFC2.ToString();
                tboxEXPO1_tRFCsb.Text = vm.EXPO1.tRFC.ToString();

                tboxEXPO1_tRRD_L.Text = vm.EXPO1.tRRD_L.ToString();
                tboxEXPO1_tCCD_L.Text = vm.EXPO1.tCCD_L.ToString();
                tboxEXPO1_tCCD_L_WR.Text = vm.EXPO1.tCCD_L_WR.ToString();
                tboxEXPO1_tCCD_L_WR2.Text = vm.EXPO1.tCCD_L_WR2.ToString();
                tboxEXPO1_tFAW.Text = vm.EXPO1.tFAW.ToString();
                tboxEXPO1_tCCD_L_WTR.Text = vm.EXPO1.tCCD_L_WTR.ToString();
                tboxEXPO1_tCCD_S_WTR.Text = vm.EXPO1.tCCD_S_WTR.ToString();
                tboxEXPO1_tRTP.Text = vm.EXPO1.tRTP.ToString();

                lblEXPO1_tAA.Text = vm.EXPO1.tAATicks.ToString();
                lblEXPO1_tRCD.Text = vm.EXPO1.tRCDTicks.ToString();
                lblEXPO1_tRP.Text = vm.EXPO1.tRPTicks.ToString();
                lblEXPO1_tRAS.Text = vm.EXPO1.tRASTicks.ToString();
                lblEXPO1_tRC.Text = vm.EXPO1.tRCTicks.ToString();
                lblEXPO1_tWR.Text = vm.EXPO1.tWRTicks.ToString();
                lblEXPO1_tRFC1.Text = vm.EXPO1.tRFC1Ticks.ToString();
                lblEXPO1_tRFC2.Text = vm.EXPO1.tRFC2Ticks.ToString();
                lblEXPO1_tRFC.Text = vm.EXPO1.tRFCTicks.ToString();

                lblEXPO1_tRRD_L.Text = vm.EXPO1.tRRD_LTicks.ToString();
                lblEXPO1_tCCD_L.Text = vm.EXPO1.tCCD_LTicks.ToString();
                lblEXPO1_tCCD_L_WR.Text = vm.EXPO1.tCCD_L_WRTicks.ToString();
                lblEXPO1_tCCD_L_WR2.Text = vm.EXPO1.tCCD_L_WR2Ticks.ToString();
                lblEXPO1_tFAW.Text = vm.EXPO1.tFAWTicks.ToString();
                lblEXPO1_tCCD_L_WTR.Text = vm.EXPO1.tCCD_L_WTRTicks.ToString();
                lblEXPO1_tCCD_S_WTR.Text = vm.EXPO1.tCCD_S_WTRTicks.ToString();
                lblEXPO1_tRTP.Text = vm.EXPO1.tRTPTicks.ToString();
            }
        }

        private void EXPO2_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Update
            {
                /* EXPO Organization */
                vm.EXPO2Enabled = cbox_EnableEXPO2.Checked;

                /* Frequency */
                vm.EXPO2.MinCycleTime = (ushort)updnEXPO2_MinCycleTime.Value;
                tboxEXPO2_Frequency.Text = vm.EXPO2.Frequency + " Mhz";
                tboxEXPO2_MegaTransfers.Text = vm.EXPO2.MegaTransfers + " MT/s";

                /* Voltages */
                vm.EXPO2.VDD = ushort.Parse(tboxEXPO2_VDD.Text);
                vm.EXPO2.VDDQ = ushort.Parse(tboxEXPO2_VDDQ.Text);
                vm.EXPO2.VPP = ushort.Parse(tboxEXPO2_VPP.Text);

                /* Timing */
                vm.EXPO2.tAA = ushort.Parse(tboxEXPO2_tAA.Text);
                vm.EXPO2.tRCD = ushort.Parse(tboxEXPO2_tRCD.Text);
                vm.EXPO2.tRP = ushort.Parse(tboxEXPO2_tRP.Text);
                vm.EXPO2.tRAS = ushort.Parse(tboxEXPO2_tRAS.Text);
                vm.EXPO2.tRC = ushort.Parse(tboxEXPO2_tRC.Text);
                vm.EXPO2.tWR = ushort.Parse(tboxEXPO2_tWR.Text);
                vm.EXPO2.tRFC1 = ushort.Parse(tboxEXPO2_tRFC1.Text);
                vm.EXPO2.tRFC2 = ushort.Parse(tboxEXPO2_tRFC2.Text);
                vm.EXPO2.tRFC = ushort.Parse(tboxEXPO2_tRFCsb.Text);

                vm.EXPO2.tRRD_L = ushort.Parse(tboxEXPO2_tRRD_L.Text);
                vm.EXPO2.tCCD_L = ushort.Parse(tboxEXPO2_tCCD_L.Text);
                vm.EXPO2.tCCD_L_WR = ushort.Parse(tboxEXPO2_tCCD_L_WR.Text);
                vm.EXPO2.tCCD_L_WR2 = ushort.Parse(tboxEXPO2_tCCD_L_WR2.Text);
                vm.EXPO2.tFAW = ushort.Parse(tboxEXPO2_tFAW.Text);
                vm.EXPO2.tCCD_L_WTR = ushort.Parse(tboxEXPO2_tCCD_L_WTR.Text);
                vm.EXPO2.tCCD_S_WTR = ushort.Parse(tboxEXPO2_tCCD_S_WTR.Text);
                vm.EXPO2.tRTP = ushort.Parse(tboxEXPO2_tRTP.Text);

                lblEXPO2_tAA.Text = vm.EXPO2.tAATicks.ToString();
                lblEXPO2_tRCD.Text = vm.EXPO2.tRCDTicks.ToString();
                lblEXPO2_tRP.Text = vm.EXPO2.tRPTicks.ToString();
                lblEXPO2_tRAS.Text = vm.EXPO2.tRASTicks.ToString();
                lblEXPO2_tRC.Text = vm.EXPO2.tRCTicks.ToString();
                lblEXPO2_tWR.Text = vm.EXPO2.tWRTicks.ToString();
                lblEXPO2_tRFC1.Text = vm.EXPO2.tRFC1Ticks.ToString();
                lblEXPO2_tRFC2.Text = vm.EXPO2.tRFC2Ticks.ToString();
                lblEXPO2_tRFC.Text = vm.EXPO2.tRFCTicks.ToString();

                lblEXPO2_tRRD_L.Text = vm.EXPO2.tRRD_LTicks.ToString();
                lblEXPO2_tCCD_L.Text = vm.EXPO2.tCCD_LTicks.ToString();
                lblEXPO2_tCCD_L_WR.Text = vm.EXPO2.tCCD_L_WRTicks.ToString();
                lblEXPO2_tCCD_L_WR2.Text = vm.EXPO2.tCCD_L_WR2Ticks.ToString();
                lblEXPO2_tFAW.Text = vm.EXPO2.tFAWTicks.ToString();
                lblEXPO2_tCCD_L_WTR.Text = vm.EXPO2.tCCD_L_WTRTicks.ToString();
                lblEXPO2_tCCD_S_WTR.Text = vm.EXPO2.tCCD_S_WTRTicks.ToString();
                lblEXPO2_tRTP.Text = vm.EXPO2.tRTPTicks.ToString();

            }
            else //Display
            {
                cbox_EnableEXPO2.Checked = vm.EXPO2Enabled;
                tabPageSPD_EXPO2.Enabled = cbox_EnableEXPO2.Checked;

                /* Frequency */
                updnEXPO2_MinCycleTime.Text = vm.EXPO2.MinCycleTime.ToString();
                tboxEXPO2_Frequency.Text = vm.EXPO2.Frequency + " Mhz";
                tboxEXPO2_MegaTransfers.Text = vm.EXPO2.MegaTransfers + " MT/s";

                /* Voltages */
                tboxEXPO2_VDD.Text = vm.EXPO2.VDD.ToString();
                tboxEXPO2_VDDQ.Text = vm.EXPO2.VDDQ.ToString();
                tboxEXPO2_VPP.Text = vm.EXPO2.VPP.ToString();

                /* Timing */
                tboxEXPO2_tAA.Text = vm.EXPO2.tAA.ToString();
                tboxEXPO2_tRCD.Text = vm.EXPO2.tRCD.ToString();
                tboxEXPO2_tRP.Text = vm.EXPO2.tRP.ToString();
                tboxEXPO2_tRAS.Text = vm.EXPO2.tRAS.ToString();
                tboxEXPO2_tRC.Text = vm.EXPO2.tRC.ToString();
                tboxEXPO2_tWR.Text = vm.EXPO2.tWR.ToString();
                tboxEXPO2_tRFC1.Text = vm.EXPO2.tRFC1.ToString();
                tboxEXPO2_tRFC2.Text = vm.EXPO2.tRFC2.ToString();
                tboxEXPO2_tRFCsb.Text = vm.EXPO2.tRFC.ToString();

                tboxEXPO2_tRRD_L.Text = vm.EXPO2.tRRD_L.ToString();
                tboxEXPO2_tCCD_L.Text = vm.EXPO2.tCCD_L.ToString();
                tboxEXPO2_tCCD_L_WR.Text = vm.EXPO2.tCCD_L_WR.ToString();
                tboxEXPO2_tCCD_L_WR2.Text = vm.EXPO2.tCCD_L_WR2.ToString();
                tboxEXPO2_tFAW.Text = vm.EXPO2.tFAW.ToString();
                tboxEXPO2_tCCD_L_WTR.Text = vm.EXPO2.tCCD_L_WTR.ToString();
                tboxEXPO2_tCCD_S_WTR.Text = vm.EXPO2.tCCD_S_WTR.ToString();
                tboxEXPO2_tRTP.Text = vm.EXPO2.tRTP.ToString();

                lblEXPO2_tAA.Text = vm.EXPO2.tAATicks.ToString();
                lblEXPO2_tRCD.Text = vm.EXPO2.tRCDTicks.ToString();
                lblEXPO2_tRP.Text = vm.EXPO2.tRPTicks.ToString();
                lblEXPO2_tRAS.Text = vm.EXPO2.tRASTicks.ToString();
                lblEXPO2_tRC.Text = vm.EXPO2.tRCTicks.ToString();
                lblEXPO2_tWR.Text = vm.EXPO2.tWRTicks.ToString();
                lblEXPO2_tRFC1.Text = vm.EXPO2.tRFC1Ticks.ToString();
                lblEXPO2_tRFC2.Text = vm.EXPO2.tRFC2Ticks.ToString();
                lblEXPO2_tRFC.Text = vm.EXPO2.tRFCTicks.ToString();

                lblEXPO2_tRRD_L.Text = vm.EXPO2.tRRD_LTicks.ToString();
                lblEXPO2_tCCD_L.Text = vm.EXPO2.tCCD_LTicks.ToString();
                lblEXPO2_tCCD_L_WR.Text = vm.EXPO2.tCCD_L_WRTicks.ToString();
                lblEXPO2_tCCD_L_WR2.Text = vm.EXPO2.tCCD_L_WR2Ticks.ToString();
                lblEXPO2_tFAW.Text = vm.EXPO2.tFAWTicks.ToString();
                lblEXPO2_tCCD_L_WTR.Text = vm.EXPO2.tCCD_L_WTRTicks.ToString();
                lblEXPO2_tCCD_S_WTR.Text = vm.EXPO2.tCCD_S_WTRTicks.ToString();
                lblEXPO2_tRTP.Text = vm.EXPO2.tRTPTicks.ToString();
            }
        }

        private void Header_Tab(DDR5_SPD vm, bool update)
        {
            if (update) //Update
            {                
                vm.XMPIdString = tboxXMPheader_IdString.Text;   //Intel Extreme Memory Profile Identification String
                vm.XMPversion = tboxXMPheader_Version.Text;
                vm.XMPconfiguration = tboxXMPheader_Configuration.Text;

                vm.XMPPMICvenderID = tboxXMPheader_PMICvend.Text;
                vm.XMPPMICnumber = tboxXMPheader_PMICnum.Text;
                vm.XMPPMICcapabilities = tboxXMPheader_PMICcap.Text;


                vm.ExpoIdString = tboxEXPOheader_IdString.Text;
                vm.ExpoVersion = tboxEXPOheader_Version.Text;
                vm.ExpoConfiguration = tboxEXPOheader_Configuration.Text;

            }
            else //Display
            {                
                tboxXMPheader_IdString.Text = vm.XMPIdString;  //Intel Extreme Memory Profile Identification String
                tboxXMPheader_Version.Text = vm.XMPversion.ToString();
                tboxXMPheader_Configuration.Text = vm.XMPconfiguration.ToString();

                tboxXMPheader_PMICvend.Text = vm.XMPPMICvenderID;
                tboxXMPheader_PMICnum.Text = vm.XMPPMICnumber;
                tboxXMPheader_PMICcap.Text = vm.XMPPMICcapabilities;

                tboxEXPOheader_IdString.Text = vm.ExpoIdString;
                tboxEXPOheader_Version.Text= vm.ExpoVersion.ToString();
                tboxEXPOheader_Configuration.Text= vm.ExpoConfiguration.ToString();
            }
        }

        /**************************************************************************/
        /*                           콤포넌트                                     */
        /**************************************************************************/
        /**************************************************************************/
        /*************************************/
        /****             보턴            ****/
        /*************************************/
        private void btnSPDupdate_Click(object sender, EventArgs e)
        {
            /* DDR5_SPD 를 update(갱신)해줌 */
            SPDMain_Tab(Ddr5Spd, true);  //SPD Main Tab update 
            SPD_Tab(Ddr5Spd, true);  //SPD Tab update
            XMP1_Tab(Ddr5Spd, true);  //XMP1 Tab update
            XMP2_Tab(Ddr5Spd, true);  //XMP2 Tab update
            EXPO1_Tab(Ddr5Spd, true);  //EXPO1 Tab update
            EXPO2_Tab(Ddr5Spd, true);  //EXPO2 Tab update
            Header_Tab(Ddr5Spd, true);  //XMP Header Tab update 

            Ddr5Spd.UpdateCrc();    //CRC update

            /* SPD HexData Update*/
            HexData = Ddr5Spd.GetBytes();

            //Data Viewer 탭 update하기 
            DisplayDataView(HexData);
            DisplaySpdView(Ddr5Spd);

            LoggingCVS(Ddr5Spd);
            Logging($"SPD Data Updated");
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            while (listBoxLog.Items.Count > 0)
            {
                listBoxLog.Items.RemoveAt(0);
            }
        }

        private void btnLogSave_Click(object sender, EventArgs e)
        {
            if (listBoxLog.Items.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|Log files (*.log)|*.log|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}_{(DateTime.Now).Hour}{(DateTime.Now).Minute}{(DateTime.Now).Second}{(DateTime.Now).Millisecond}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    string[] log = new string[listBoxLog.Items.Count];

                    for (int i = 0; i < log.Length; i++)
                    {
                        log[i] = listBoxLog.Items[i].ToString();
                    }

                    File.WriteAllLines(saveFileDialog.FileName, log);
                    Logging($"Log saved to file '{saveFileDialog.FileName}'");
                }
            }
        }

        private void btnCvsClear_Click(object sender, EventArgs e)
        {
            while (listBoxCvs.Items.Count > 0)
            {
                listBoxCvs.Items.RemoveAt(0);
            }
        }

        private void btnCvsSave_Click(object sender, EventArgs e)
        {
            if (listBoxCvs.Items.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|Log files (*.log)|*.log|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}_{(DateTime.Now).Hour}{(DateTime.Now).Minute}{(DateTime.Now).Second}{(DateTime.Now).Millisecond}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    string[] log = new string[listBoxCvs.Items.Count];

                    for (int i = 0; i < log.Length; i++)
                    {
                        log[i] = listBoxCvs.Items[i].ToString();
                    }

                    File.WriteAllLines(saveFileDialog.FileName, log);
                    Logging($"CVS saved to file '{saveFileDialog.FileName}'");
                }
            }
        }
        /*************************************/
        /****             툴바            ****/
        /*************************************/
        /**************************************************************************/
        private void toolOpenFile_Click(object sender, EventArgs e) //툴바: 파일 열기
        {
            string path = "";

            // 바이너리가 위치한 동일한 디렉토리에 파일 "열림"을 방지하기 위한 수정 사항
            if (sender.GetType() == typeof(String))
            {
                path = sender.ToString();
            }

            // file open dialog를 통해 파일을 선택함
            if (!File.Exists(path))
            {
                var inputFilePath = new OpenFileDialog();

                //cjin inputFilePath.Filter = "Binary File(*.bin)|*.bin|SPD Dumps (*.spd)|*.spd|All files (*.*)|*.*";
                inputFilePath.Filter = "SPD files (*.spd, *.bin)|*.spd;*.bin|All files (*.*)|*.*";
                inputFilePath.FilterIndex = 0;
                inputFilePath.RestoreDirectory = true;

                if (inputFilePath.ShowDialog() == DialogResult.OK && inputFilePath.FileName != "")
                {
                    path = inputFilePath.FileName;
                }
                else
                {
                    return;
                }
            }

            // 파일을 읽어서 HexData 배열에 저장함
            byte[] _hexData = File.ReadAllBytes(path);

            //cjin 파일 확장자 추출
            string fileExtension = Path.GetExtension(path).ToLower();
            string outputFilePath = "output.txt";

            if (_hexData.Length > 1024)   // 1024byte 이상은 Error 표시
            {
                //cjin *.spd or *.txt로 되어 있는 ASCII형식의 File로 되어 있을 경우 
                if ((fileExtension == ".txt") || (fileExtension == ".spd"))
                {
                    try
                    {
                        // Read all lines from the file
                        string[] lines = File.ReadAllLines(path);

                        // Open a StreamWriter to write to the output file
                        using (StreamWriter writer = new StreamWriter(outputFilePath))
                        {
                            // Start from the second line (index 1) to skip the first line (DIMM)
                            for (int i = 4; i < lines.Length; i++)
                            {
                                // Clean the SPD data from each line
                                string cleanedLine = CleanSPDDataLine(lines[i]);

                                // Write the cleaned data to the output file, if it's not empty
                                if (!string.IsNullOrWhiteSpace(cleanedLine))
                                {
                                    writer.WriteLine(cleanedLine);
                                }
                            }
                        }
                        Console.WriteLine("SPD data has been processed and saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine($"An error occurred: {ex.Message}");
                        string _errorMessage = "File Size is not match. : " + ex;
                        Logging(String.Format(_errorMessage, path));
                        MessageBox.Show(String.Format(_errorMessage, Path.GetFileName(path)), path, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    string _errorMessage = "너무 커서 File \"{0}\" 을 open못함";
                    Logging(String.Format(_errorMessage, path));
                    MessageBox.Show(String.Format(_errorMessage, Path.GetFileName(path)), path, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 파일명을 display함
            currentFileName = path;

            if (currentFileName != "" && tabPageMain.Text != Path.GetFileName(currentFileName))  
            {
                tboxHexData.Text = Path.GetFileName(currentFileName);
            }

            // HexData를 전역변수에 저장하고, Data View에 Display함
            if ((fileExtension == ".txt") || (fileExtension == ".spd"))
            {
                // ASCII 문자열로 변환합니다.
                string asciiString = Encoding.ASCII.GetString(_hexData);

                // 공백을 제거합니다.
                string cleanString = asciiString.Replace(" ", "");
                //string result = cleanString.Replace("\r\n", "");
                string result = cleanString.Replace(" ", "").Replace(",", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");


                // 바이트 배열의 길이는 문자열 길이의 절반 (2자리씩 하나의 byte로 변환되기 때문)
                HexData = new byte[result.Length / 2];

                // 2자리씩 잘라서 16진수로 변환하여 byte 배열에 저장
                for (int i = 0; i < result.Length; i += 2)
                {
                    // 2자리씩 잘라서 16진수로 변환
                    string hexValue = result.Substring(i, 2);
                    HexData[i / 2] = Convert.ToByte(hexValue, 16);
                }
            }
            else
            {
                // HexData를 전역변수에 저장하고, Data View에 Display함
                HexData = _hexData;
            }

            DisplayDataView(HexData);
            DisplaySpdView(Ddr5Spd);
            statusBarProgress.Value = statusBarProgress.Maximum;
            crcValidChecksum = ValidateCrc(HexData);  //CRC를 검증함
            Logging($"File \"{Path.GetFileName(currentFileName)}\" opened 성공.");
        }

        //cjin CleanSPD Data Line
        static string CleanSPDDataLine(string line)
        {
            // Check if the line is long enough to avoid exceptions
            if (line.Length <= 4)
            {
                return string.Empty; // Return an empty string if the line is too short
            }

            // Remove the first 6 characters
            string cleaned = line.Substring(4);

            // Optionally, you can remove any spaces, commas, or line breaks from the cleaned line
            cleaned = cleaned.Replace(" ", "").Replace(",", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");

            return cleaned;
        }

        /* Save Hex Data */
        private void toolMenu_SaveHexData_Click(object sender, EventArgs e)
        {
            if (HexData.Length == 0)
            {
                Logging("저장할 SPD Date가 없습니다.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary File(*.bin)|*.bin|SPD Dumps (*.spd)|*.spd|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = Eeprom.GetModuleModelName(HexData);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveFileDialog.FileName;
                File.WriteAllBytes(saveFileDialog.FileName, HexData);
                Logging($"File \"{Path.GetFileName(saveFileDialog.FileName)}\" 저장 성공.");
            }
        }

        /* Save CSV Data */
        private void toolMenu_SaveCSVFile_Click(object sender, EventArgs e)
        {
            btnCvsSave_Click(sender, e);
        }

        /* Save Log Data */
        private void toolMenu_SaveLogFile_Click(object sender, EventArgs e)
        {
            btnLogSave_Click(sender, e);
        }

        private void toolDevice_Click(object sender, EventArgs e)
        {
            foundDevices = null;
            foundEeproms = null;

            // COM Port 찾기 
            string _command = "spdrwcli.exe /find";
            string _data = RunCommand(_command); // Cmd실행
            Match match = Regex.Match(_data, @"COM(\d+)"); //"COMxx" 만 추출 
            string _deviceID = "COM" + match.Groups[1].Value;  //COM포트를 찾음   

            if (match.Success)
            {
                foundDevices = _deviceID;
                Logging("COM 포트 찾음: " + _deviceID);
            }
            else
            {
                Logging("COM 포트를 찾을수 없습니다. ");
                return;
            }

            // Address 찾기
            _command = "spdrwcli.exe /scan " + _deviceID;
            _data = RunCommand(_command); // Cmd실행
            match = Regex.Match(_data, @"address:\s*(\d+)"); //"COMxx" 만 추출 
            string _eepromID = match.Groups[1].Value;

            if (match.Success)
            {
                foundEeproms = _eepromID;
                Logging("EEPROM 찾음: " + _eepromID);
            }
            else
            {
                Logging("EEPROM 를 찾을수 없습니다. ");
                return;
            }

            // 예전 Device를 삭제하고, 새로운 Device를 추가함 
            ToolStripItem[] _existingDeviceItem = toolDevice.DropDownItems.Find("FoundDevicePortAddress", false);

            if (_existingDeviceItem.Length > 0)
            {
                for (int i = 0; i < _existingDeviceItem.Length; i++)
                {
                    if (!((ToolStripMenuItem)_existingDeviceItem[i]).Checked)
                    {
                        toolDevice.DropDownItems.Remove(_existingDeviceItem[i]);
                    }
                }
            }

            // 찾은 Device를 추가함
            if (foundDevices != null)
            {
                string _label = foundDevices;
                ToolStripMenuItem _deviceItem = new ToolStripMenuItem(_label, null /*, ConnectToDevice */);
                _deviceItem.Name = "FoundDevicePortAddress";
                toolDevice.DropDownItems.Add(_deviceItem);
            }
        }

        private void toolClear_Click(object sender, EventArgs e)
        {
            byte[] _Data = new byte[0];  // Spd Data  (SpdContents)
            HexData = _Data;

            /* SPD Data Parse */
            var spd = DDR5_SPD.Parse(HexData);
            Ddr5Spd = spd;

            cbox_EnableXMP1.Checked = false;
            cbox_EnableXMP2.Checked = false;
            cbox_EnableEXPO1.Checked = false;
            cbox_EnableEXPO2.Checked = false;

            tabPageSPD_SPD.Enabled = false;
            tabPageSPD_XMP1.Enabled = cbox_EnableXMP1.Checked;
            tabPageSPD_XMP2.Enabled = cbox_EnableXMP2.Checked;
            tabPageSPD_EXPO1.Enabled = cbox_EnableEXPO1.Checked;
            tabPageSPD_EXPO2.Enabled = cbox_EnableEXPO2.Checked;

            DisplayDataView(HexData);
            //DisplaySpdView(Ddr5Spd);
        }

        private void toolReadEeprom_Click(object sender, EventArgs e)
        {
            int start = Environment.TickCount;
            string command = "spdrwcli.exe /read " + foundDevices + " 80";
            
            // 파일을 읽어서 HexData 배열에 저장함
            string _data = RunCommand(command);

            // 정규식을 이용하여 "주소: " 부분 제거 (예: "0000: " 제거)
            string cleanedData = Regex.Replace(_data, @"^\s*\d{4}:\s*", "", RegexOptions.Multiline);

            // 정규식을 사용하여 숫자(16진수)만 추출
            var hexValues = Regex.Matches(cleanedData, @"\b[0-9A-Fa-f]{2}\b")
                                 .Cast<Match>()
                                 .Select(m => m.Value)
                                 .ToArray();

            // 공백을 기준으로 문자열 분리 후 16진수 바이트 배열 변환
            byte[] _Data = hexValues
                .Select(hex => Convert.ToByte(hex, 16))
                .ToArray();

            // 앞의 16개 요소를 삭제한 새로운 배열 생성
            if (_Data.Length >= 16)
            {
                byte[] _hexData = new byte[_Data.Length - 16];
                Array.Copy(_Data, 16, _hexData, 0, _hexData.Length);
                // HexData를 전역변수에 저장하고, Data View에 Display함
                HexData = _hexData;
            }
            else
            {
                // Handle the error appropriately, e.g., log an error message or throw an exception
                MessageBox.Show("DDR5가 없습니다.");
                Logging("DDR5가 없습니다.");
            }

            int stop = Environment.TickCount;

            if (HexData.Length > 0) 
            {
                currentFileName = "";  //파일명을 초기화함
                DisplayDataView(HexData);
                DisplaySpdView(Ddr5Spd);
                crcValidChecksum = ValidateCrc(HexData);

                statusBarProgress.Value = statusBarProgress.Maximum;
                //tabPageMain.Text = $"{MySpdReader.PortName}:{MySpdReader.EepromAddress}";
                if (tabControlMain.SelectedTab != tabPageMain && !tabPageMain.Text.StartsWith("* "))
                {
                    tabPageMain.Text = $"* {tabPageMain.Text}";
                }
                Logging($"Read SPD ({HexData.Length} bytes) from {foundDevices} in {stop - start} ms");
            }
        }


        private void toolWriteEeprom_Click(object sender, EventArgs e)
        {
            int start = Environment.TickCount;

            /* 먼저 Temp File에 저장을 하고, 그 파일을 이용하여 Write함 */
            if (HexData.Length == 0)
            {
                Logging("SPD Data 없어, Write 못함");
                return;
            }
            else
            {
                string _tempFileName = "spdTemp.bin";
                File.WriteAllBytes(_tempFileName, HexData);
                Logging($"임시파일\"{_tempFileName}\" 저장");

                // SPD Write Cmd실행
                string command = "spdrwcli.exe /write " + foundDevices + " 80 " + _tempFileName;
                RunCommand(command);

                //statusBarProgress.Value = 0;
                int stop = Environment.TickCount;
                Logging($"Write SPD ({HexData.Length} bytes) from {foundDevices} in {stop - start} ms");
            }   
        }

        /*************************************/
        /****     background 콤포넌트     ****/
        /*************************************/
        /**************************************************************************/
        private void timerInterfaceUpdater_Tick(object sender, EventArgs e)
        {
            
            bool _deviceLoaded = foundDevices != null;  // Device 로드되었는지 확인           
            bool _spdLoaded = HexData.Length != 0;  // SPD Data가 로드되었는지 확인            
            bool _progressBarActive = (statusBarProgress.Value == statusBarProgress.Minimum)  // Tool 바 상태를 Enable or disable 
                                       || (statusBarProgress.Value == statusBarProgress.Maximum);

            toolSave.Enabled = _spdLoaded;
            toolReadEeprom.Enabled = _deviceLoaded;
            toolWriteEeprom.Enabled = _deviceLoaded;

            // CRC status
            if (_spdLoaded && (Eeprom.GetRamType(HexData) != RamType.UNKNOWN))
            {
                statusBarCrcStatus.Visible = statusBarProgress.Value == statusBarProgress.Maximum;
                statusBarCrcStatus.Text = (crcValidChecksum) ? "CRC OK" : "CRC Error";
                statusBarCrcStatus.ForeColor = (crcValidChecksum) ? Color.FromArgb(128, 255, 128) : Color.White;
                statusBarCrcStatus.BackColor = (crcValidChecksum) ? Color.FromArgb(255, 0, 64, 0) : Color.FromArgb(192, 255, 0, 0);                
            }
            else
            {
                // Hide CRC status for non DDR4 RAM
                statusBarCrcStatus.Visible = false;
            }

            // 상태바 (0 or maximum 값일때 숨김)
            statusBarProgress.Visible = !_progressBarActive;

            // Connection Status
            statusBarConnectionStatus.Enabled = _deviceLoaded;
            statusBarConnectionStatus.ForeColor = (_deviceLoaded) ? Color.Navy : SystemColors.Control;
            statusBarConnectionStatus.Text = (_deviceLoaded) ? $" {foundDevices}" : "Not connected";
            toolDevice.Text = (_deviceLoaded) ? $"{foundDevices}" : "Device";

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) // Ctrl + S 단축키
            {
                toolSave.ShowDropDown(); // 드롭다운 메뉴 열기
                e.SuppressKeyPress = true; // 원래 동작 방지
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageMain && tabPageMain.Text.StartsWith("* "))
            {
                tabPageMain.Text = tabPageMain.Text.Replace("* ", "");
            }
        }

        private void updnMinCycleTime_ValueChanged(object sender, EventArgs e)
        {
            Ddr5Spd.MinCycleTime = (ushort)updnMinCycleTime.Value;
            tboxSpdFrequency.Text = Ddr5Spd.Frequency + " Mhz";
            tboxSpdMegaTransfers.Text = Ddr5Spd.MegaTransfers + " MT/s";
        }

        private void updnXMP1_MinCycleTime_ValueChanged(object sender, EventArgs e)
        {
            Ddr5Spd.XMP1.MinCycleTime = (ushort)updnXMP1_MinCycleTime.Value;
            tboxXMP1_Frequency.Text = Ddr5Spd.XMP1.Frequency + " Mhz";
            tboxXMP1_MegaTransfers.Text = Ddr5Spd.XMP1.MegaTransfers + " MT/s";
        }

        private void updnXMP2_MinCycleTime_ValueChanged(object sender, EventArgs e)
        {
            Ddr5Spd.XMP2.MinCycleTime = (ushort)updnXMP2_MinCycleTime.Value;
            tboxXMP2_Frequency.Text = Ddr5Spd.XMP2.Frequency + " Mhz";
            tboxXMP2_MegaTransfers.Text = Ddr5Spd.XMP2.MegaTransfers + " MT/s";
        }

        private void updnEXPO1_MinCycleTime_ValueChanged(object sender, EventArgs e)
        {
            Ddr5Spd.EXPO1.MinCycleTime = (ushort)updnEXPO1_MinCycleTime.Value;
            tboxEXPO1_Frequency.Text = Ddr5Spd.EXPO1.Frequency + " Mhz";
            tboxEXPO1_MegaTransfers.Text = Ddr5Spd.EXPO1.MegaTransfers + " MT/s";
        }

        private void updnEXPO2_MinCycleTime_ValueChanged(object sender, EventArgs e)
        {
            Ddr5Spd.EXPO2.MinCycleTime = (ushort)updnEXPO2_MinCycleTime.Value;
            tboxEXPO2_Frequency.Text = Ddr5Spd.EXPO2.Frequency + " Mhz";
            tboxEXPO2_MegaTransfers.Text = Ddr5Spd.EXPO2.MegaTransfers + " MT/s";
        }

        private void cbox_EnableXMP1_CheckedChanged(object sender, EventArgs e)
        {
            tabPageSPD_XMP1.Enabled = cbox_EnableXMP1.Checked;
        }

        private void cbox_EnableXMP2_CheckedChanged(object sender, EventArgs e)
        {
            tabPageSPD_XMP2.Enabled = cbox_EnableXMP2.Checked;
        }

        private void cbox_EnableEXPO1_CheckedChanged(object sender, EventArgs e)
        {
            tabPageSPD_EXPO1.Enabled = cbox_EnableEXPO1.Checked;
        }

        private void cbox_EnableEXPO2_CheckedChanged(object sender, EventArgs e)
        {
            tabPageSPD_EXPO2.Enabled = cbox_EnableEXPO2.Checked;
        }


    }
}
