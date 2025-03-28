using Stylet;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Forms;
using static DDR5XMPEditor.DDR5SPD.EXPO;
using static DDR5XMPEditor.DDR5SPD.XMP_3_0;

namespace DDR5XMPEditor.DDR5SPD
{
    public class DDR5_SPD : PropertyChangedBase
    {
        public enum FormFactorEnum
        {
            Reserved,
            RDIMM,
            UDIMM,
            SODIMM,
            LRDIMM,
            CUDIMM,
            CSODIMM,
            MRDIMM,
            CAMM2,
            Reserved_9,
            DDIMM,
            Solder_down,
            Reserved_12,
            Reserved_13,
            Reserved_14,
            Reserved_15,
            Count
        }

        public enum DensitiesEnum
        {
            _0Gb,
            _4Gb,
            _8Gb,
            _12Gb,
            _16Gb,
            _24Gb,
            _32Gb,
            _48Gb,
            _64Gb,
            Count
        }

        public enum OperatingTemperatureRangeEnum : ushort
        {
            A1T = 0, // (-40 to +125 °C)
            A2T = 1, // (-40 to +105 °C)
            A3T = 2, //(-40 to +85 °C)
            IT = 3,  //(-40 to +95 °C)
            ST = 4,  //(-25 to +85 °C)
            ET = 5,  //(-25 to +105 °C)
            RT = 6,  //(0 to +45 °C)
            NT = 7,  //(0 to +85 °C)
            XT = 8,  //(0 to +95 °C)
            Count = 9
        }

        public const ushort partNumberSize = 30;
        public const ushort specificDataSize = 64;
        public const ushort heatSpreaderBit = 2;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private unsafe struct RawSPD
        {
            // Start General configuration (0-127, 0x00-0x7F, Block 0,1)
            // Byte 0 to 3 Header/Type
            public byte bytesUsed;
            public byte revision_BaseConfig;
            public byte memoryType; // 12 = DDR5
            public byte moduleType; // 0x02 = Unbuffered DIMM, 0x03 = SO-DIMM, 0x04=LRDIMM (only bits 3-0 are used)
            // Byte 4-7 First Density/Package
            public byte firstDensityPackage;
            public byte firstAddressing;
            public byte firstIOWitdth;
            public byte firstBankGroups;
            // Byte 8-11 Second Density/Package
            public byte secondDensityPackage;
            public byte secondAddressing;
            public byte secondIOWitdth;
            public byte secondBankGroups;
            // Byte 12
            public byte sdramBL32;
            public byte sdramDutyCycle;
            public byte sdramFaultHandling;
            public byte reserved_15;
            // Byte 16-18 (Voltages, 1.1v)
            public byte voltageVDD;  // 0x00 -> 1.1v
            public byte voltageVDDQ; // 0x00 -> 1.1v
            public byte voltageVPP;  // 0x00 -> 1.1v
            // Byte 19
            public byte sdramTimming; // Should be 0x00 for JEDEC standard timmings
            // Byte 20-21
            public fixed byte minCycleTime[2];
            // Byte 22-23
            public fixed byte maxCycleTime[2];
            // Byte 24-28 Cas Latencies supported
            public fixed byte clSupported[5];
            public byte reserved_29;
            // Byte 30-31 tAA
            public fixed byte tAA[2];
            // Byte 32-33 tRCD
            public fixed byte tRCD[2];
            // Byte 34-35 tRP
            public fixed byte tRP[2];
            // Byte 36-37 tRAS
            public fixed byte tRAS[2];
            // Byte 38-39 tRC
            public fixed byte tRC[2];
            // Byte 40-41 tWR
            public fixed byte tWR[2];

            // Same logical bank
            // Byte 42-43 tRFC1 (Normal Refresh Recovery Time)
            public fixed byte tRFC1_slr[2];
            // Byte 44-45 tRFC2 (Fine Granularity Refresh Recovery Time)
            public fixed byte tRFC2_slr[2];
            // Byte 46-47 tRFCsb (Same Bank Refresh Recovery Time)
            public fixed byte tRFCsb_slr[2];

            // Different logical bank
            // Byte 48-49 tRFC1 (Normal Refresh Recovery Time)
            public fixed byte tRFC1_dlr[2];
            // Byte 50-51 tRFC2 (Fine Granularity Refresh Recovery Time)
            public fixed byte tRFC2_dlr[2];
            // Byte 52-53 tRFCsb (Same Bank Refresh Recovery Time)
            public fixed byte tRFCsb_dlr[2];

            // Byte 54-57 SDRAM Refresh Management
            public fixed byte refreshManagementFirst[2];
            public fixed byte refreshManagementSecond[2];

            // Byte 58-61 Adaptive Refresh Management Level A
            public fixed byte adaptiveRefreshManagementAFirst[2];
            public fixed byte adaptiveRefreshManagementASecond[2];

            // Byte 62-65 Adaptive Refresh Management Level B
            public fixed byte adaptiveRefreshManagementBFirst[2];
            public fixed byte adaptiveRefreshManagementBSecond[2];

            // Byte 66-69 Adaptive Refresh Management Level C
            public fixed byte adaptiveRefreshManagementCFirst[2];
            public fixed byte adaptiveRefreshManagementCSecond[2];

            // Byte 70-72 Activate to Activate Command Delay for Same Bank Group
            public fixed byte tRRD_L[2];
            public byte tRRD_L_lowerLimit;

            // Byte 73-75 Read to Read Command Delay for Same Bank Group
            public fixed byte tCCD_L[2];
            public byte tCCD_L_lowerLimit;

            // Byte 76-78 Write to Write Command Delay for Same Bank Group
            public fixed byte tCCD_L_WR[2];
            public byte tCCD_L_WR_lowerLimit;

            // Byte 79-81 Write to Write Command Delay for Same Bank Group, Second Write not RMW
            public fixed byte tCCD_L_WR2[2];
            public byte tCCD_L_WR2_lowerLimit;

            // Byte 82-84 Four Activate Window
            public fixed byte tFAW[2];
            public byte tFAW_lowerLimit;

            // Byte 85-87 Write to Read Command Delay for Same Bank Group
            public fixed byte tCCD_L_WTR[2];
            public byte tCCD_L_WTR_lowerLimit;

            // Byte 88-90 Write to Read Command Delay for Different Bank Group
            public fixed byte tCCD_S_WTR[2];
            public byte tCCD_S_WTR_lowerLimit;

            // Byte 91-93 Read to Precharge Command Delay
            public fixed byte tRTP[2];
            public byte tRTP_lowerLimit;

            // Byte 94-96 Read to Read Command Delay for Different Bank in Same Bank
            public fixed byte tCCD_M[2];
            public byte tCCD_M_lowerLimit;

            // Byte 97-99 Write to Write Command Delay for Different Bank in Same Bank Group
            public fixed byte tCCD_M_WR[2];
            public byte tCCD_M_WR_lowerLimit;

            // Byte 100-102 Write to Read Command Delay for Same Bank Group
            public fixed byte tCCD_M_WTR[2];
            public byte tCCD_M_WTR_lowerLimit;

            // Byte 103-127 Reserved
            public fixed byte reserved_103_127[25];

            // End General configuration


            // Block 2 - Reserved for future use
            // Reserved (128-191, 0x80-0xBF)
            public fixed byte reserved_128_191[64];


            // Block 3 - Common Module Parameters/Standard Module Parameters
            // Byte 192 SPD Revision for SPD bytes 192~447
            public byte revision_CommonBytes;
            // Byte 193
            public byte hashingSequence;

            // Byte 194-197 SPD
            public fixed byte spdManufacturer[2];
            public byte spdDeviceType;
            public byte spdRevision;

            // Byte 198-201 PMIC 0
            public fixed byte pmic0Manufacturer[2];
            public byte pmic0DeviceType;
            public byte pmic0Revision;

            // Byte 202-205 PMIC 1
            public fixed byte pmic1Manufacturer[2];
            public byte pmic1DeviceType;
            public byte pmic1Revision;

            // Byte 206-209 PMIC 2
            public fixed byte pmic2Manufacturer[2];
            public byte pmic2DeviceType;
            public byte pmic2Revision;

            // Byte 210-213 Thermal Sensor
            public fixed byte thermalSensorManufacturer[2];
            public byte thermalSensorDeviceType;
            public byte thermalSensorRevision;

            // Byte 214-229 Reserved
            public fixed byte reserved_214_229[16];

            // Byte 230
            public byte moduleHeight;
            // Byte 231
            public byte moduleMaxThickness;
            // Byte 232
            public byte refRawCard;
            // Byte 233
            public byte dimmAttributes;
            // Byte 234
            public byte moduleOrganization;
            // Byte 235
            public byte memoryChannelBusWidth;

            // Byte 236-239 Reserved
            public fixed byte reserved_236_239[4];

            // Ending of block 3 + block 4/5/6

            // Byte 240-447 - Not used for regular DDR5
            public fixed byte reserved_240_447[208];

            // ------------------------ Block 7 ------------------------
            // Reserved (448-509, 0x1C0-0x1FD)
            public fixed byte reserved_448_509[62];

            // Byte 510-511 Checksum (for bytes 0-509)
            public fixed byte checksum[2];
            // ---------------------- End block 7 ----------------------

            // Block 8 - Manufacturing information
            // Byte 512
            public fixed byte moduleManufacturer[2];
            // Byte 514
            public byte manufactureLocation;
            // Byte 515-516
            public fixed byte manufactureDate[2];
            // Bytes 517-520
            public fixed byte serialNumber[4];
            // Bytes 521-550
            public fixed byte modulePartnumber[partNumberSize];
            // Byte 551
            public byte moduleRevision;
            // Byte 552-553 DRAM Manufacturer ID Code
            public fixed byte dramManufacturer[2];
            // Byte 554 DRAM stepping
            public byte dramStepping;

            // Block 9 - Manufacturing information

            // Bytes 555~575 (0x22B~23F): Manufacturer’s Specific Data =  21 Bytes
            public fixed byte reserved_555_575[575 - 555 + 1];

            // Bytes 576~639 (0x240~27F): Manufacturer’s Specific Data ( ESSENCORE Part Number ) = 64 Bytes
            public fixed byte moduleSpecificData[639 - 576 + 1];

            // Bytes 640~1023 End User bits (XMP/EXPO)
            public fixed byte endUser[1023 - 640 + 1];
        }

        // Non user XMP profiles
        public const ushort maxXmpProfileName = 16;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private unsafe struct XMPHeader_3_0
        {
            public fixed byte profileIdString[2];        // Bytes 640-641 Intel Extreme Memory Profile ID String           
            public byte version;       // Bytes 642  Intel Extreme Memory Profile Version
            public byte profileEnabled;        // Bytes 643  // bit 0: profile 1 enabled, bit 1: profile 2 enabled, bit 2: profile 3 enabled
            public byte configuration;         // Bytes 644
            public fixed byte PMICvendorID[2];        // Bytes 645-646 
            public byte PMICnumber;       // Bytes 647
            public byte PMICcapabilities;       // Bytes 648
            public fixed byte unknown[5];       // Bytes 649-653
            public fixed byte profileName1[maxXmpProfileName];        // Bytes 654-669    Profile 1 String Name
            public fixed byte profileName2[maxXmpProfileName];        // Bytes 670-685    Profile 2 String Name
            public fixed byte profileName3[maxXmpProfileName];        // Bytes 686-701    Profile 3 String Name
            public fixed byte checksum[2];        // Bytes 702-703 
        };

        // Total SPD size
        public const int TotalSize = 1024;
        public const int SPDTotalSize = 3136;
        private RawSPD rawSPD;

        // XMP
        public static readonly byte[] XMPHeaderMagic = { 0x0C, 0x4A };
        public static readonly byte XMPVersion = 0x30;
        public static readonly ushort XMPOffset = 0x280;
        public static readonly ushort[] XMPProfilesOffset = { 0x2C0, 0x300, 0x340, 0x380, 0x3C0 };

        private XMPHeader_3_0 xmpHeader;
        public const int TotalXMPHeaderSize = 0x40;
        public bool xmpFound = false;
        public const int TotalXMPProfiles = 5;
        private readonly XMP_3_0[] xmp = new XMP_3_0[TotalXMPProfiles];
        public const int TotalXMPSize = 0x40;

        // EXPO
        public bool expoFound = false;
        public const int TotalEXPOProfiles = 2; //TOD:O Support more than 1 profile
        private readonly EXPO[] expo = new EXPO[TotalEXPOProfiles];
        private RawEXPO rawExpo;
        public static readonly ushort[] EXPOProfilesOffset = { 0x34A, 0x372 };
        private static readonly FormFactorEnum[] formFactorMap = new FormFactorEnum[(int)FormFactorEnum.Count]
        {
            FormFactorEnum.Reserved,
            FormFactorEnum.RDIMM,
            FormFactorEnum.UDIMM,
            FormFactorEnum.SODIMM,
            FormFactorEnum.LRDIMM,
            FormFactorEnum.CUDIMM,
            FormFactorEnum.CSODIMM,
            FormFactorEnum.MRDIMM,
            FormFactorEnum.CAMM2,
            FormFactorEnum.Reserved_9,
            FormFactorEnum.DDIMM,
            FormFactorEnum.Solder_down,
            FormFactorEnum.Reserved_12,
            FormFactorEnum.Reserved_13,
            FormFactorEnum.Reserved_14,
            FormFactorEnum.Reserved_15
        };

        private static readonly DensitiesEnum[] densityMap = new DensitiesEnum[(int)DensitiesEnum.Count]
        {
            DensitiesEnum._0Gb,
            DensitiesEnum._4Gb,
            DensitiesEnum._8Gb,
            DensitiesEnum._12Gb,
            DensitiesEnum._16Gb,
            DensitiesEnum._24Gb,
            DensitiesEnum._32Gb,
            DensitiesEnum._48Gb,
            DensitiesEnum._64Gb
        };

        private static readonly int[] bankGroupsBitsMap = new int[4] { 1, 2, 4, 8 };
        private static readonly int[] banksPerBankGroupBitsMap = new int[3] { 1, 2, 4 };

        private static readonly int[] columnAddressBitsMap = new int[2] { 10, 11 };
        private static readonly int[] rowAddressBitsMap = new int[3] { 16, 17, 18 };

        private static readonly int[] deviceWidthMap = new int[4] { 4, 8, 16, 32 };

        public unsafe ushort MinCycleTime
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.minCycleTime[0], rawSPD.minCycleTime[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.minCycleTime[0], ref rawSPD.minCycleTime[1], value);
            }
        }

        public unsafe double? Frequency
        {
            get
            {
                ushort frq = Utilities.ConvertBytes(rawSPD.minCycleTime[0], rawSPD.minCycleTime[1]);

                return Math.Round(1.0 / ((double)frq / 1000000));
            }
        }

        public double? MegaTransfers
        {
            get
            {
                if (Frequency == null)
                {
                    return null;
                }

                return Frequency * 2;
            }
        }

        public unsafe ushort MaxCycleTime
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.maxCycleTime[0], rawSPD.maxCycleTime[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.maxCycleTime[0], ref rawSPD.maxCycleTime[1], value);
            }
        }
        public unsafe bool IsCLSupported(int cl)
        {
            int[] mask = { 1, 2, 4, 8, 16, 32, 64, 128 };

            // All valid CAS latencies are even numbers between 20 and 98
            if (cl < 20 || cl > 98 || (cl % 2 != 0))
            {
                return false;
            }

            const int offset = 20;
            int bit = (cl - offset) / 2;

            if (cl >= 20 && cl <= 34)
            {
                int index = bit;
                return (rawSPD.clSupported[0] & mask[index]) == mask[index];
            }
            else if (cl >= 36 && cl <= 50)
            {
                int index = bit - 8;
                return (rawSPD.clSupported[1] & mask[index]) == mask[index];
            }
            else if (cl >= 52 && cl <= 66)
            {
                int index = bit - 16;
                return (rawSPD.clSupported[2] & mask[index]) == mask[index];
            }
            else if (cl >= 68 && cl <= 82)
            {
                int index = bit - 24;
                return (rawSPD.clSupported[3] & mask[index]) == mask[index];
            }
            else if (cl >= 84 && cl <= 98)
            {
                int index = bit - 32;
                return (rawSPD.clSupported[4] & mask[index]) == mask[index];
            }

            // Should never reach this point
            return false;
        }
        public unsafe void SetCLSupported(int cl, bool supported)
        {
            // All valid CAS latencies are even numbers between 20 and 98
            if (cl < 20 || cl > 98 || (cl % 2 != 0))
            {
                return;
            }

            int[] mask = { 1, 2, 4, 8, 16, 32, 64, 128 };

            const int offset = 20;
            int bit = (cl - offset) / 2;

            if (cl >= 20 && cl <= 34)
            {
                int index = bit;
                if (supported)
                {
                    rawSPD.clSupported[0] |= (byte)mask[index];
                }
                else
                {
                    rawSPD.clSupported[0] &= (byte)~mask[index];
                }
            }
            else if (cl >= 36 && cl <= 50)
            {
                int index = bit - 8;
                if (supported)
                {
                    rawSPD.clSupported[1] |= (byte)mask[index];
                }
                else
                {
                    rawSPD.clSupported[1] &= (byte)~mask[index];
                }
            }
            else if (cl >= 52 && cl <= 66)
            {
                int index = bit - 16;
                if (supported)
                {
                    rawSPD.clSupported[2] |= (byte)mask[index];
                }
                else
                {
                    rawSPD.clSupported[2] &= (byte)~mask[index];
                }
            }
            else if (cl >= 68 && cl <= 82)
            {
                int index = bit - 24;
                if (supported)
                {
                    rawSPD.clSupported[3] |= (byte)mask[index];
                }
                else
                {
                    rawSPD.clSupported[3] &= (byte)~mask[index];
                }
            }
            else if (cl >= 84 && cl <= 98)
            {
                int index = bit - 32;
                if (supported)
                {
                    rawSPD.clSupported[4] |= (byte)mask[index];
                }
                else
                {
                    rawSPD.clSupported[4] &= (byte)~mask[index];
                }
            }
        }
        public unsafe bool CL20
        {
            get
            {
                return IsCLSupported(20);
            }
            set
            {
                SetCLSupported(20, value);
            }
        }
        public unsafe bool CL22
        {
            get
            {
                return IsCLSupported(22);
            }
            set
            {
                SetCLSupported(22, value);
            }
        }

        public unsafe bool CL24
        {
            get
            {
                return IsCLSupported(24);
            }
            set
            {
                SetCLSupported(24, value);
            }
        }

        public unsafe bool CL26
        {
            get
            {
                return IsCLSupported(26);
            }
            set
            {
                SetCLSupported(26, value);
            }
        }

        public unsafe bool CL28
        {
            get
            {
                return IsCLSupported(28);
            }
            set
            {
                SetCLSupported(28, value);
            }
        }

        public unsafe bool CL30
        {
            get
            {
                return IsCLSupported(30);
            }
            set
            {
                SetCLSupported(30, value);
            }
        }
        public unsafe bool CL32
        {
            get
            {
                return IsCLSupported(32);
            }
            set
            {
                SetCLSupported(32, value);
            }
        }

        public unsafe bool CL34
        {
            get
            {
                return IsCLSupported(34);
            }
            set
            {
                SetCLSupported(34, value);
            }
        }

        public unsafe bool CL36
        {
            get
            {
                return IsCLSupported(36);
            }
            set
            {
                SetCLSupported(36, value);
            }
        }

        public unsafe bool CL38
        {
            get
            {
                return IsCLSupported(38);
            }
            set
            {
                SetCLSupported(38, value);
            }
        }

        public unsafe bool CL40
        {
            get
            {
                return IsCLSupported(40);
            }
            set
            {
                SetCLSupported(40, value);
            }
        }
        public unsafe bool CL42
        {
            get
            {
                return IsCLSupported(42);
            }
            set
            {
                SetCLSupported(42, value);
            }
        }

        public unsafe bool CL44
        {
            get
            {
                return IsCLSupported(44);
            }
            set
            {
                SetCLSupported(44, value);
            }
        }

        public unsafe bool CL46
        {
            get
            {
                return IsCLSupported(46);
            }
            set
            {
                SetCLSupported(46, value);
            }
        }

        public unsafe bool CL48
        {
            get
            {
                return IsCLSupported(48);
            }
            set
            {
                SetCLSupported(48, value);
            }
        }
        public unsafe bool CL50
        {
            get
            {
                return IsCLSupported(50);
            }
            set
            {
                SetCLSupported(50, value);
            }
        }
        public unsafe bool CL52
        {
            get
            {
                return IsCLSupported(52);
            }
            set
            {
                SetCLSupported(52, value);
            }
        }

        public unsafe bool CL54
        {
            get
            {
                return IsCLSupported(54);
            }
            set
            {
                SetCLSupported(54, value);
            }
        }

        public unsafe bool CL56
        {
            get
            {
                return IsCLSupported(56);
            }
            set
            {
                SetCLSupported(56, value);
            }
        }

        public unsafe bool CL58
        {
            get
            {
                return IsCLSupported(58);
            }
            set
            {
                SetCLSupported(58, value);
            }
        }
        public unsafe bool CL60
        {
            get
            {
                return IsCLSupported(60);
            }
            set
            {
                SetCLSupported(60, value);
            }
        }
        public unsafe bool CL62
        {
            get
            {
                return IsCLSupported(62);
            }
            set
            {
                SetCLSupported(62, value);
            }
        }

        public unsafe bool CL64
        {
            get
            {
                return IsCLSupported(64);
            }
            set
            {
                SetCLSupported(64, value);
            }
        }

        public unsafe bool CL66
        {
            get
            {
                return IsCLSupported(66);
            }
            set
            {
                SetCLSupported(66, value);
            }
        }

        public unsafe bool CL68
        {
            get
            {
                return IsCLSupported(68);
            }
            set
            {
                SetCLSupported(68, value);
            }
        }
        public unsafe bool CL70
        {
            get
            {
                return IsCLSupported(70);
            }
            set
            {
                SetCLSupported(70, value);
            }
        }
        public unsafe bool CL72
        {
            get
            {
                return IsCLSupported(72);
            }
            set
            {
                SetCLSupported(72, value);
            }
        }

        public unsafe bool CL74
        {
            get
            {
                return IsCLSupported(74);
            }
            set
            {
                SetCLSupported(74, value);
            }
        }

        public unsafe bool CL76
        {
            get
            {
                return IsCLSupported(76);
            }
            set
            {
                SetCLSupported(76, value);
            }
        }

        public unsafe bool CL78
        {
            get
            {
                return IsCLSupported(78);
            }
            set
            {
                SetCLSupported(78, value);
            }
        }
        public unsafe bool CL80
        {
            get
            {
                return IsCLSupported(80);
            }
            set
            {
                SetCLSupported(80, value);
            }
        }
        public unsafe bool CL82
        {
            get
            {
                return IsCLSupported(82);
            }
            set
            {
                SetCLSupported(82, value);
            }
        }

        public unsafe bool CL84
        {
            get
            {
                return IsCLSupported(84);
            }
            set
            {
                SetCLSupported(84, value);
            }
        }

        public unsafe bool CL86
        {
            get
            {
                return IsCLSupported(86);
            }
            set
            {
                SetCLSupported(86, value);
            }
        }

        public unsafe bool CL88
        {
            get
            {
                return IsCLSupported(88);
            }
            set
            {
                SetCLSupported(88, value);
            }
        }
        public unsafe bool CL90
        {
            get
            {
                return IsCLSupported(90);
            }
            set
            {
                SetCLSupported(90, value);
            }
        }
        public unsafe bool CL92
        {
            get
            {
                return IsCLSupported(92);
            }
            set
            {
                SetCLSupported(92, value);
            }
        }

        public unsafe bool CL94
        {
            get
            {
                return IsCLSupported(94);
            }
            set
            {
                SetCLSupported(94, value);
            }
        }

        public unsafe bool CL96
        {
            get
            {
                return IsCLSupported(96);
            }
            set
            {
                SetCLSupported(96, value);
            }
        }

        public unsafe bool CL98
        {
            get
            {
                return IsCLSupported(98);
            }
            set
            {
                SetCLSupported(98, value);
            }
        }

        public unsafe ushort tAA
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tAA[0], rawSPD.tAA[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tAA[0], ref rawSPD.tAA[1], value);
            }
        }
        public unsafe uint tAATicks
        {
            get
            {
                return Utilities.TimeToTicksDDR5(tAA, MinCycleTime);
            }
        }

        public unsafe ushort tRCD
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRCD[0], rawSPD.tRCD[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRCD[0], ref rawSPD.tRCD[1], value);
            }
        }

        public unsafe ushort tRCDTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRCD, MinCycleTime);
            }
        }

        public unsafe ushort tRP
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRP[0], rawSPD.tRP[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRP[0], ref rawSPD.tRP[1], value);
            }
        }

        public unsafe ushort tRPTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRP, MinCycleTime);
            }
        }

        public unsafe ushort tRAS
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRAS[0], rawSPD.tRAS[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRAS[0], ref rawSPD.tRAS[1], value);
            }
        }
        public unsafe ushort tRASTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRAS, MinCycleTime);
            }
        }
        public unsafe ushort tRC
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRC[0], rawSPD.tRC[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRC[0], ref rawSPD.tRC[1], value);
            }
        }
        public unsafe ushort tRCTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRC, MinCycleTime);
            }
        }
        public unsafe ushort tWR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tWR[0], rawSPD.tWR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tWR[0], ref rawSPD.tWR[1], value);
            }
        }
        public unsafe ushort tWRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tWR, MinCycleTime);
            }
        }

        public unsafe ushort tRFC1_slr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFC1_slr[0], rawSPD.tRFC1_slr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFC1_slr[0], ref rawSPD.tRFC1_slr[1], value);
            }
        }
        public unsafe ushort tRFC1_slrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFC1_slr * 1000), MinCycleTime);
            }

            set
            {
            }
        }
        public unsafe ushort tRFC2_slr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFC2_slr[0], rawSPD.tRFC2_slr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFC2_slr[0], ref rawSPD.tRFC2_slr[1], value);
            }
        }
        public unsafe ushort tRFC2_slrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFC2_slr * 1000), MinCycleTime);
            }
        }
        public unsafe ushort tRFCsb_slr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFCsb_slr[0], rawSPD.tRFCsb_slr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFCsb_slr[0], ref rawSPD.tRFCsb_slr[1], value);
            }
        }
        public unsafe ushort tRFCsb_slrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFCsb_slr * 1000), MinCycleTime);
            }
        }
        public unsafe ushort tRFC1_dlr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFC1_dlr[0], rawSPD.tRFC1_dlr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFC1_dlr[0], ref rawSPD.tRFC1_dlr[1], value);
            }
        }
        public unsafe ushort tRFC1_dlrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFC1_dlr * 1000), MinCycleTime);
            }
        }
        public unsafe ushort tRFC2_dlr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFC2_dlr[0], rawSPD.tRFC2_dlr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFC2_dlr[0], ref rawSPD.tRFC2_dlr[1], value);
            }
        }
        public unsafe ushort tRFC2_dlrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFC2_dlr * 1000), MinCycleTime);
            }
        }
        public unsafe ushort tRFCsb_dlr
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRFCsb_dlr[0], rawSPD.tRFCsb_dlr[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRFCsb_dlr[0], ref rawSPD.tRFCsb_dlr[1], value);
            }
        }
        public unsafe ushort tRFCsb_dlrTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5((uint)(tRFCsb_dlr * 1000), MinCycleTime);
            }
        }
        public unsafe ushort tRRD_L
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRRD_L[0], rawSPD.tRRD_L[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRRD_L[0], ref rawSPD.tRRD_L[1], value);
            }
        }
        public unsafe ushort tRRD_LTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRRD_L, MinCycleTime);
            }
        }
        public unsafe ushort tRRD_L_lowerLimit
        {
            get => rawSPD.tRRD_L_lowerLimit;
            set
            {
                rawSPD.tRRD_L_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort tCCD_L
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_L[0], rawSPD.tCCD_L[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_L[0], ref rawSPD.tCCD_L[1], value);
            }
        }
        public unsafe ushort tCCD_LTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_L, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_L_lowerLimit
        {
            get => rawSPD.tCCD_L_lowerLimit;
            set
            {
                rawSPD.tCCD_L_lowerLimit = (byte)value;
            }
        }
        public unsafe ushort tCCD_L_WR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_L_WR[0], rawSPD.tCCD_L_WR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_L_WR[0], ref rawSPD.tCCD_L_WR[1], value);
            }
        }
        public unsafe ushort tCCD_L_WRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_L_WR, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_L_WR_lowerLimit
        {
            get => rawSPD.tCCD_L_WR_lowerLimit;
            set
            {
                rawSPD.tCCD_L_WR_lowerLimit = (byte)value;
            }
        }
        public unsafe ushort tCCD_L_WR2
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_L_WR2[0], rawSPD.tCCD_L_WR2[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_L_WR2[0], ref rawSPD.tCCD_L_WR2[1], value);
            }
        }
        public unsafe ushort tCCD_L_WR2Ticks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_L_WR2, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_L_WR2_lowerLimit
        {
            get => rawSPD.tCCD_L_WR2_lowerLimit;
            set
            {
                rawSPD.tCCD_L_WR2_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort tFAW
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tFAW[0], rawSPD.tFAW[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tFAW[0], ref rawSPD.tFAW[1], value);
            }
        }
        public unsafe ushort tFAWTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tFAW, MinCycleTime);
            }
        }
        public unsafe ushort tFAW_lowerLimit
        {
            get => rawSPD.tFAW_lowerLimit;
            set
            {
                rawSPD.tFAW_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort tCCD_L_WTR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_L_WTR[0], rawSPD.tCCD_L_WTR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_L_WTR[0], ref rawSPD.tCCD_L_WTR[1], value);
            }
        }
        public unsafe ushort tCCD_L_WTRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_L_WTR, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_L_WTR_lowerLimit
        {
            get => rawSPD.tCCD_L_WTR_lowerLimit;
            set
            {
                rawSPD.tCCD_L_WTR_lowerLimit = (byte)value;
            }
        }
        public unsafe ushort tCCD_S_WTR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_S_WTR[0], rawSPD.tCCD_S_WTR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_S_WTR[0], ref rawSPD.tCCD_S_WTR[1], value);
            }
        }
        public unsafe ushort tCCD_S_WTRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_S_WTR, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_S_WTR_lowerLimit
        {
            get => rawSPD.tCCD_S_WTR_lowerLimit;
            set
            {
                rawSPD.tCCD_S_WTR_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort tRTP
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tRTP[0], rawSPD.tRTP[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tRTP[0], ref rawSPD.tRTP[1], value);
            }
        }
        public unsafe ushort tRTPTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tRTP, MinCycleTime);
            }
        }
        public unsafe ushort tRTP_lowerLimit
        {
            get => rawSPD.tRTP_lowerLimit;
            set
            {
                rawSPD.tRTP_lowerLimit = (byte)value;
            }
        }
        public unsafe ushort tCCD_M
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_M[0], rawSPD.tCCD_M[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_M[0], ref rawSPD.tCCD_M[1], value);
            }
        }
        public unsafe ushort tCCD_MTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_M, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_M_lowerLimit
        {
            get => rawSPD.tCCD_M_lowerLimit;
            set
            {
                rawSPD.tCCD_M_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort tCCD_M_WR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_M_WR[0], rawSPD.tCCD_M_WR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_M_WR[0], ref rawSPD.tCCD_M_WR[1], value);
            }
        }
        public unsafe ushort tCCD_M_WRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_M_WR, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_M_WR_lowerLimit
        {
            get => rawSPD.tCCD_M_WR_lowerLimit;
            set
            {
                rawSPD.tCCD_M_WR_lowerLimit = (byte)value;
            }
        }
        public unsafe ushort tCCD_M_WTR
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.tCCD_M_WTR[0], rawSPD.tCCD_M_WTR[1]);
            }

            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.tCCD_M_WTR[0], ref rawSPD.tCCD_M_WTR[1], value);
            }
        }
        public unsafe ushort tCCD_M_WTRTicks
        {
            get
            {
                return (ushort)Utilities.TimeToTicksDDR5(tCCD_M_WTR, MinCycleTime);
            }
        }
        public unsafe ushort tCCD_M_WTR_lowerLimit
        {
            get => rawSPD.tCCD_M_WTR_lowerLimit;
            set
            {
                rawSPD.tCCD_M_WTR_lowerLimit = (byte)value;
            }
        }

        public unsafe ushort BanksPerBankGroup
        {
            get => (ushort)banksPerBankGroupBitsMap[rawSPD.firstBankGroups & 0x7];
            set
            {
                int index = Array.IndexOf(banksPerBankGroupBitsMap, value);
                if (index >= 0 && value <= 2)
                {
                    rawSPD.firstBankGroups = (byte)((rawSPD.firstBankGroups & 0xF8) | (index));
                }
            }
        }

        public unsafe ushort BankGroups
        {
            get => (ushort)bankGroupsBitsMap[(rawSPD.firstBankGroups >> 5)];
            set
            {
                int index = Array.IndexOf(bankGroupsBitsMap, value);

                if (index >= 0 && value <= 3)
                {
                    rawSPD.firstBankGroups = (byte)((rawSPD.firstBankGroups & 0x1F) | (index << 5));
                }
            }
        }

        public unsafe ushort ColumnAddresses
        {
            get => (ushort)columnAddressBitsMap[(rawSPD.firstAddressing >> 5)];
            set
            {
                int index = Array.IndexOf(columnAddressBitsMap, value);

                if (index >= 0 && value <= 1)
                {
                    rawSPD.firstAddressing = (byte)((rawSPD.firstAddressing & 0x1F) | (index << 5));
                }
            }
        }

        public unsafe ushort RowAddresses
        {
            get => (ushort)rowAddressBitsMap[(rawSPD.firstAddressing & 0x1F)];
            set
            {
                int index = Array.IndexOf(rowAddressBitsMap, value);

                if (index >= 0 && value <= 3)
                {
                    rawSPD.firstAddressing = (byte)((rawSPD.firstAddressing & 0xE0) | (index));
                }
            }
        }

        public unsafe ushort DeviceWidth
        {
            get => (ushort)deviceWidthMap[(rawSPD.firstIOWitdth >> 5)];
            set
            {
                int index = Array.IndexOf(deviceWidthMap, value);

                if (index >= 0 && value <= 3)
                {
                    rawSPD.firstIOWitdth = (byte)((rawSPD.firstIOWitdth & 0x1F) | (index << 5));
                }
            }
        }
        public DensitiesEnum? Density
        {
            get
            {
                ushort index = (ushort)(rawSPD.firstDensityPackage & 0xF);
                if (index >= (ushort)DensitiesEnum.Count)
                {
                    return null;
                }
                return densityMap[index];
            }
            set
            {
                if (value.HasValue)
                {
                    int index = Array.FindIndex(densityMap, d => d == value.Value);
                    rawSPD.firstDensityPackage = (byte)((rawSPD.firstDensityPackage & 0xF0) | (index & 0xF));
                }
            }
        }
        public unsafe ushort ManufacturingYear
        {
            get => ushort.Parse(rawSPD.manufactureDate[0].ToString("X"));   // Year is represented in hex e.g. 0x22 = 2022
            set
            {
                if (value > 99)
                {
                    value = 99;
                }

                rawSPD.manufactureDate[0] = byte.Parse(value.ToString(), System.Globalization.NumberStyles.HexNumber);
            }
        }

        public unsafe ushort ManufacturingWeek
        {
            get => ushort.Parse(rawSPD.manufactureDate[1].ToString("X"));   // Week is represented in hex e.g. 0x10 = Week 10
            set
            {
                // 52 weeks in a year
                if (value > 52)
                {
                    value = 52;
                }

                rawSPD.manufactureDate[1] = byte.Parse(value.ToString(), System.Globalization.NumberStyles.HexNumber);
            }
        }

        public unsafe string SerialNumber
        {
            get
            {
                // 바이트 배열을 uint로 변환하여 HEX 문자열로 반환
                uint value = BitConverter.ToUInt32(GetSerialNumberArray(), 0);
                return value.ToString("X8"); // 8자리 HEX 문자열
            }
            set
            {
                // 문자열을 uint로 변환하여 바이트 배열에 저장
                if (uint.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out uint result))
                {
                    fixed (byte* p = rawSPD.serialNumber)
                    {
                        p[0] = (byte)(result >> 24); // 상위 바이트 저장
                        p[1] = (byte)((result >> 16) & 0xFF); // 다음 바이트 저장
                        p[2] = (byte)((result >> 8) & 0xFF); // 다음 바이트 저장
                        p[3] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("SerialNumber 문자열이 올바르지 않습니다. 유효한 HEX 문자열을 입력하세요.");
                }
            }
        }

        private unsafe byte[] GetSerialNumberArray()
        {
            byte[] bytes = new byte[4];
            fixed (byte* p = rawSPD.serialNumber)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[i] = p[i];
                }
            }
            Array.Reverse(bytes);  //리틀 엔디언 <-> 빅 엔디언 변환 

            return bytes;
        }

        public unsafe string PartNumber
        {
            get
            {
                fixed (byte* p = rawSPD.modulePartnumber)
                {
                    return Marshal.PtrToStringAnsi((IntPtr)p);
                }
            }
            set
            {
                const int maxSize = partNumberSize;
                var str = value.Substring(0, Math.Min(maxSize, value.Length));
                fixed (byte* p = rawSPD.modulePartnumber)
                {
                    for (int i = 0; i < str.Length; ++i)
                    {
                        p[i] = (byte)str[i];
                    }
                    for (int i = str.Length; i < maxSize; ++i)
                    {
                        p[i] = 0;
                    }
                }
            }
        }

        public unsafe string SpecificData
        {
            get
            {
                fixed (byte* p = rawSPD.moduleSpecificData)
                {
                    return Marshal.PtrToStringAnsi((IntPtr)p);
                }
            }
            set
            {
                const int maxSize = specificDataSize;
                var str = value.Substring(0, Math.Min(maxSize, value.Length));
                fixed (byte* p = rawSPD.moduleSpecificData)
                {
                    for (int i = 0; i < str.Length; ++i)
                    {
                        p[i] = (byte)str[i];
                    }
                    for (int i = str.Length; i < maxSize; ++i)
                    {
                        p[i] = 0;
                    }
                }
            }
        }


        public unsafe bool HeatSpreader
        {
            get
            {
                return Utilities.GetBit(rawSPD.dimmAttributes, heatSpreaderBit);
            }
            set
            {
                rawSPD.dimmAttributes = Utilities.SetBit(rawSPD.dimmAttributes, heatSpreaderBit, value);
            }
        }
        public unsafe OperatingTemperatureRangeEnum OperatingTemperatureRange
        {
            get
            {
                return (OperatingTemperatureRangeEnum)(rawSPD.dimmAttributes >> 4);
            }
            set
            {
                // TODO
            }
        }

        public unsafe string ManufacturerId
        {
            get
            {
                // 바이트 배열을 ushort로 변환하여 HEX 문자열로 반환
                ushort value = Utilities.ConvertBytes(rawSPD.moduleManufacturer[1], rawSPD.moduleManufacturer[0]);
                return value.ToString("X4"); // 4자리 HEX 문자열
            }
            set
            {

                // 문자열을 ushort로 변환하여 바이트 배열에 저장
                if (ushort.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out ushort result))
                {
                    fixed (byte* p = rawSPD.moduleManufacturer)
                    {
                        p[0] = (byte)(result >> 8); // 상위 바이트 저장
                        p[1] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("ManufacturerId 문자열이 올바르지 않습니다. 유효한 HEX 문자열을 입력하세요.");
                }

            }
        }

        public unsafe string DramManufacturerId
        {
            get
            {
                // 바이트 배열을 ushort로 변환하여 HEX 문자열로 반환
                ushort value = Utilities.ConvertBytes(rawSPD.dramManufacturer[1], rawSPD.dramManufacturer[0]);
                return value.ToString("X4"); // 4자리 HEX 문자열
            }
            set
            {

                // 문자열을 ushort로 변환하여 바이트 배열에 저장
                if (ushort.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out ushort result))
                {
                    fixed (byte* p = rawSPD.dramManufacturer)
                    {
                        p[0] = (byte)(result >> 8); // 상위 바이트 저장
                        p[1] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("DramManufacturerId 문자열이 올바르지 않습니다. 유효한 HEX 문자열을 입력하세요.");
                }

            }
        }

        public unsafe string ManufactureName(string mid)
        {
                switch (mid)
                {
                /*  ex) Bank1 이면,  -1 하고 Parity bit 붙어,  0x80**  */
                case "802C":    return "Micron Technology";
                case "8097":    return "Texas Instruments";
                case "80AD":    return "SK Hynix";
                case "80CE":    return "Samsung";
                case "029E":    return "Corsair";
                case "8313":    return "Golden Empire";
                case "04CD":    return "G Skill Intl";
                case "04EF":    return "MultiLink Technology";
                case "859B":    return "Crucial Technology";                    
                case "1898":    return "Essencore Limited";
                case "2C00":    return "Micron Technology";        
                case "8F5E":    return "Hitach-LG Data Storage";
                default:        return "Unknown";
                }
        }

        public unsafe ushort CRC
        {
            get
            {
                return Utilities.ConvertBytes(rawSPD.checksum[0], rawSPD.checksum[1]);
            }
            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawSPD.checksum[0], ref rawSPD.checksum[1], value);
            }
        }

        public unsafe ushort XMPHeaderCRC
        {
            get
            {
                return Utilities.ConvertBytes(xmpHeader.checksum[0], xmpHeader.checksum[1]);
            }
            set
            {
                Utilities.Convert16bitUnsignedInteger(ref xmpHeader.checksum[0], ref xmpHeader.checksum[1], value);
            }
        }
        public unsafe ushort XMP1CRC
        {
            get
            {
                return xmp[0].CRC;
            }
            set
            {
                xmp[0].CRC = value;
            }
        }
        public unsafe ushort XMP2CRC
        {
            get
            {
                return xmp[1].CRC;
            }
            set
            {
                xmp[1].CRC = value;
            }
        }
        public unsafe ushort XMP3CRC
        {
            get
            {
                return xmp[2].CRC;
            }
            set
            {
                xmp[2].CRC = value;
            }
        }
        public unsafe ushort ExpoCRC
        {
            get
            {
                return Utilities.ConvertBytes(rawExpo.checksum[0], rawExpo.checksum[1]);
            }
            set
            {
                Utilities.Convert16bitUnsignedInteger(ref rawExpo.checksum[0], ref rawExpo.checksum[1], value);
            }
        }
        public FormFactorEnum? FormFactor
        {
            get
            {
                ushort index = (ushort)(rawSPD.moduleType & 0xF);
                if (index >= (ushort)FormFactorEnum.Count)
                {
                    return null;
                }
                return formFactorMap[index];
            }
            set
            {
                if (value.HasValue)
                {
                    int index = Array.FindIndex(formFactorMap, d => d == value.Value);
                    rawSPD.moduleType = (byte)((rawSPD.moduleType & 0xF0) | (index & 0xF));
                }
            }
        }

        public bool EXPO1Enabled
        {
            get => (rawExpo.header.profileEnabled & 0x1) == 0x1;
            set
            {
                if (value)
                {
                    rawExpo.header.profileEnabled |= 0x1;
                }
                else
                {
                    rawExpo.header.profileEnabled &= 0xFE;
                }
            }
        }

        public bool EXPO2Enabled
        {
            get => (rawExpo.header.profileEnabled & 0x10) == 0x10;
            set
            {
                if (value)
                {
                    rawExpo.header.profileEnabled |= 0x10;
                }
                else
                {
                    rawExpo.header.profileEnabled &= 0xEF;
                }
            }
        }

        public bool XMP1Enabled
        {
            get => (xmpHeader.profileEnabled & 0x1) == 0x1;
            set
            {
                if (value)
                {
                    xmpHeader.profileEnabled |= 0x1;
                }
                else
                {
                    xmpHeader.profileEnabled &= 0xFE;
                }
            }
        }

        public bool XMP2Enabled
        {
            get => (xmpHeader.profileEnabled & 0x2) == 0x2;
            set
            {
                if (value)
                {
                    xmpHeader.profileEnabled |= 0x2;
                }
                else
                {
                    xmpHeader.profileEnabled &= 0xFD;
                }
            }
        }

        public bool XMP3Enabled
        {
            get => (xmpHeader.profileEnabled & 0x4) == 0x4;
            set
            {
                if (!expoFound)
                {
                    if (value)
                    {
                        xmpHeader.profileEnabled |= 0x4;
                    }
                    else
                    {
                        xmpHeader.profileEnabled &= 0xFB;
                    }
                }
            }
        }

        public bool XMPUser1Exists
        {
            get
            {
                if (XMPUser1 == null || expoFound)
                {
                    return false;
                }
                else
                {
                    return XMPUser1.CheckCRCValidity() && !XMPUser1.IsEmpty();
                }
            }
        }
        public bool XMPUser1Enabled
        {
            get
            {
                if (XMPUser1 == null || expoFound)
                {
                    return false;
                }
                else
                {
                    return XMPUser1Exists;
                }
            }
            set
            {
                if (!expoFound)
                {
                    if (value)
                    {
                        // User has enabled profile
                        if (!XMPUser1Exists)
                        {
                            XMPUser1.LoadSample();
                        }
                    }
                    else
                    {
                        XMPUser1.Wipe();
                    }
                }
            }
        }
        public bool XMPUser2Exists
        {
            get
            {
                if (XMPUser2 == null)
                {
                    return false;
                }
                else
                {
                    return XMPUser2.CheckCRCValidity() && !XMPUser2.IsEmpty();
                }
            }
        }
        public bool XMPUser2Enabled
        {
            get
            {
                if (XMPUser2 == null)
                {
                    return false;
                }
                else
                {
                    return XMPUser2Exists;
                }
            }
            set
            {
                if (value)
                {
                    // User has enabled profile
                    if (!XMPUser2Exists)
                    {
                        XMPUser2.LoadSample();
                    }
                }
                else
                {
                    XMPUser2.Wipe();
                }
            }
        }
        public unsafe string XMPProfile1Name
        {
            get
            {
                fixed (byte* p = xmpHeader.profileName1)
                {
                    const int maxSize = maxXmpProfileName;
                    return Marshal.PtrToStringAnsi((IntPtr)p, maxSize);
                }
            }
            set
            {
                const int maxSize = maxXmpProfileName;
                var str = value.Substring(0, Math.Min(maxSize, value.Length));
                fixed (byte* p = xmpHeader.profileName1)
                {
                    for (int i = 0; i < maxSize; ++i)
                    {
                        if (str.Length > i)
                        {
                            p[i] = (byte)str[i];
                        }
                        else
                        {
                            p[i] = 0;
                        }
                    }
                }
            }
        }

        public unsafe string XMPProfile2Name
        {
            get
            {
                const int maxSize = maxXmpProfileName;
                fixed (byte* p = xmpHeader.profileName2)
                {
                    return Marshal.PtrToStringAnsi((IntPtr)p, maxSize);
                }
            }
            set
            {
                const int maxSize = maxXmpProfileName;
                var str = value.Substring(0, Math.Min(maxSize, value.Length));
                fixed (byte* p = xmpHeader.profileName2)
                {
                    for (int i = 0; i < maxSize; ++i)
                    {
                        if (str.Length > i)
                        {
                            p[i] = (byte)str[i];
                        }
                        else
                        {
                            p[i] = 0;
                        }
                    }
                }
            }
        }

        public unsafe string XMPProfile3Name
        {
            get
            {
                const int maxSize = maxXmpProfileName;
                fixed (byte* p = xmpHeader.profileName3)
                {
                    return Marshal.PtrToStringAnsi((IntPtr)p, maxSize);
                }
            }
            set
            {
                const int maxSize = maxXmpProfileName;
                var str = value.Substring(0, Math.Min(maxSize, value.Length));
                fixed (byte* p = xmpHeader.profileName3)
                {
                    for (int i = 0; i < maxSize; ++i)
                    {
                        if (str.Length > i)
                        {
                            p[i] = (byte)str[i];
                        }
                        else
                        {
                            p[i] = 0;
                        }
                    }
                }
            }
        }

        public unsafe string XMPIdString
        {
            get
            {
                // 바이트 배열을 ushort로 변환하여 HEX 문자열로 반환
                ushort value = Utilities.ConvertBytes(xmpHeader.profileIdString[1], xmpHeader.profileIdString[0]);
                return value.ToString("X4"); // 4자리 HEX 문자열
            }
            set
            {

                // 문자열을 ushort로 변환하여 바이트 배열에 저장
                if (ushort.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out ushort result))
                {
                    fixed (byte* p = xmpHeader.profileIdString)
                    {
                        p[0] = (byte)(result >> 8); // 상위 바이트 저장
                        p[1] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("Profile Id String 문자열이 올바르지 않습니다.");
                }

            }
        }

        public unsafe string XMPversion
        {
            get => xmpHeader.version.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    xmpHeader.version = result;
                }
            }
        }

        public unsafe string XMPconfiguration
        {
            get => xmpHeader.configuration.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    xmpHeader.configuration = result;
                }
            }
        }

        public unsafe string XMPPMICvenderID
        {
            get
            {
                // 바이트 배열을 ushort로 변환하여 HEX 문자열로 반환
                ushort value = Utilities.ConvertBytes(xmpHeader.PMICvendorID[1], xmpHeader.PMICvendorID[0]);
                return value.ToString("X4"); // 4자리 HEX 문자열
            }
            set
            {

                // 문자열을 ushort로 변환하여 바이트 배열에 저장
                if (ushort.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out ushort result))
                {
                    fixed (byte* p = xmpHeader.PMICvendorID)
                    {
                        p[0] = (byte)(result >> 8); // 상위 바이트 저장
                        p[1] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("PMICvendorID 문자열이 올바르지 않습니다.");
                }

            }
        }

        public unsafe string XMPPMICnumber
        {
            get => xmpHeader.PMICnumber.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    xmpHeader.PMICnumber = result;
                }
            }
        }

        public unsafe string XMPPMICcapabilities
        {
            get => xmpHeader.PMICcapabilities.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    xmpHeader.PMICcapabilities = result;
                }
            }
        }

        public unsafe string ExpoIdString
        {
            get
            {
                // 바이트 배열을 ushort로 변환하여 HEX 문자열로 반환
                ushort value0 = Utilities.ConvertBytes(rawExpo.header.magic[1], rawExpo.header.magic[0]);
                ushort value1 = Utilities.ConvertBytes(rawExpo.header.magic[3], rawExpo.header.magic[2]);
                UInt32 value = (UInt32)value0 << 16 | (UInt32)value1;
                return value.ToString("X8"); // 4자리 HEX 문자열
            }
            set
            {

                // 문자열을 ushort로 변환하여 바이트 배열에 저장
                if (UInt32.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out UInt32 result))
                {
                    fixed (byte* p = rawExpo.header.magic)
                    {
                        p[0] = (byte)(result >> 24); // 상위 바이트 저장
                        p[1] = (byte)((result >> 16) & 0xFF);
                        p[2] = (byte)((result >> 8) & 0xFF);
                        p[3] = (byte)(result & 0xFF); // 하위 바이트 저장
                    }
                }
                else
                {
                    throw new FormatException("EXPO Profile Id String 문자열 틀림");
                }

            }
        }

        public unsafe string ExpoVersion
        {
            get => rawExpo.header.version.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    rawExpo.header.version = result;
                }
            }
        }

        public unsafe string ExpoConfiguration
        {
            get => rawExpo.header.config.ToString("X2");
            set
            {
                if (byte.TryParse(value, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out byte result))
                {
                    rawExpo.header.config = result;
                }
            }
        }

        public byte[] GetXMPHeaderBytes()
        {
            byte[] bytes = new byte[TotalXMPHeaderSize];

            // Convert raw SPD to byte array.
            IntPtr ptr = IntPtr.Zero;
            try
            {
                int xmpHeaderSize = Marshal.SizeOf<XMPHeader_3_0>();
                ptr = Marshal.AllocHGlobal(xmpHeaderSize);
                Marshal.StructureToPtr(xmpHeader, ptr, true);
                Marshal.Copy(ptr, bytes, 0, xmpHeaderSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return bytes;
        }

        public byte[] GetXMPBytes()
        {
            byte[] bytes = new byte[TotalXMPSize];

            // Convert raw SPD to byte array.
            IntPtr ptr = IntPtr.Zero;
            try
            {
                int xmpSize = Marshal.SizeOf<RawXMPProfile>();
                ptr = Marshal.AllocHGlobal(xmpSize);
                Marshal.StructureToPtr(xmp, ptr, true);
                Marshal.Copy(ptr, bytes, 0, xmpSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return bytes;
        }

        public byte[] GetEXPOBytes()
        {
            byte[] bytes = new byte[EXPOSize];

            // Convert raw SPD to byte array.
            IntPtr ptr = IntPtr.Zero;
            try
            {
                int expoSize = Marshal.SizeOf<RawEXPO>();
                ptr = Marshal.AllocHGlobal(expoSize);
                Marshal.StructureToPtr(rawExpo, ptr, true);
                Marshal.Copy(ptr, bytes, 0, expoSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
            
            byte[] expo1Bytes = EXPO1.GetBytes();
            Array.Copy(expo1Bytes, 0, bytes, EXPOProfilesOffset[0] - EXPOOffset, expo1Bytes.Length);
            byte[] expo2Bytes = EXPO2.GetBytes();
            Array.Copy(expo2Bytes, 0, bytes, EXPOProfilesOffset[1] - EXPOOffset, expo2Bytes.Length);

            return bytes;
        }

        public bool GetVerifyCrc()
        {
            //Check JEDEC block checksum
            var rawSpdBytes = GetBytes();
            ushort _crc = Utilities.Crc16(rawSpdBytes.Take(0x1FD + 1).ToArray());

            if(CRC == _crc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVerifyXMPCrc()
        {
            //Check JEDEC block checksum
            var rawXmpHeaderBytes = GetXMPHeaderBytes();
            ushort _crc = Utilities.Crc16(rawXmpHeaderBytes.Take(0x3D + 1).ToArray());

            if (XMPHeaderCRC == _crc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVerifyEXPOCrc()
        {
            //Check JEDEC block checksum
            var expoBytes = GetEXPOBytes();
            ushort _crc = Utilities.Crc16(expoBytes.Take(0x7D + 1).ToArray());

            if (ExpoCRC == _crc)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateXMPHeaderCRC()
        {
            // Update XMP Header CRC
            var rawXmpHeaderBytes = GetXMPHeaderBytes();
            XMPHeaderCRC = Utilities.Crc16(rawXmpHeaderBytes.Take(0x3D + 1).ToArray());
        }

        public void UpdateXMP1CRC()
        {
            // Update XMP Header CRC
            var rawXmpBytes = GetXMPBytes();
            XMP1CRC = Utilities.Crc16(rawXmpBytes.Take(0x3D + 1).ToArray());
        }

        public void UpdateXMP2CRC()
        {
            // Update XMP Header CRC
            var rawXmpBytes = GetXMPBytes();
            XMP2CRC = Utilities.Crc16(rawXmpBytes.Take(0x3D + 1).ToArray());
        }

        public void UpdateXMP3CRC()
        {
            // Update XMP Header CRC
            var rawXmpBytes = GetXMPBytes();
            XMP3CRC = Utilities.Crc16(rawXmpBytes.Take(0x3D + 1).ToArray());
        }

        public void UpdateEXPOCRC() {
            // Update EXPO CRC
            var expoBytes = GetEXPOBytes();
            ExpoCRC = Utilities.Crc16(expoBytes.Take(0x7D + 1).ToArray());
        }

        public void UpdateCrc()
        {
            // Update JEDEC block checksum
            var rawSpdBytes = GetBytes();
            CRC = Utilities.Crc16(rawSpdBytes.Take(0x1FD + 1).ToArray());

            if (xmpFound)
            {
                UpdateXMPHeaderCRC();

                // Update XMP Profiles CRCs too (only for enabled profiles)
                if (XMP1Enabled)
                {
                    xmp[0].UpdateCrc();
                }
                if (XMP2Enabled)
                {
                    xmp[1].UpdateCrc();
                }
                if (XMP3Enabled && !expoFound)
                {
                    xmp[2].UpdateCrc();
                }
                if (XMPUser1Enabled && !expoFound)
                {
                    xmp[3].UpdateCrc();
                }
                if (XMPUser1Enabled)
                {
                    xmp[4].UpdateCrc();
                }
            }

            if (expoFound)
            {
                UpdateEXPOCRC();
            }
        }

        public byte[] GetBytes()
        {
            byte[] bytes = new byte[TotalSize];

            // Convert raw SPD to byte array.
            IntPtr ptr = IntPtr.Zero;
            try
            {
                int rawSpdSize = Marshal.SizeOf<RawSPD>();
                ptr = Marshal.AllocHGlobal(rawSpdSize);
                Marshal.StructureToPtr(rawSPD, ptr, true);
                Marshal.Copy(ptr, bytes, 0, rawSpdSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            // Convert header to byte array.
            ptr = IntPtr.Zero;
            try
            {
                int headerSize = Marshal.SizeOf<XMPHeader_3_0>();
                ptr = Marshal.AllocHGlobal(headerSize);
                Marshal.StructureToPtr(xmpHeader, ptr, true);
                Marshal.Copy(ptr, bytes, XMPOffset, headerSize);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            // Copy XMP Profiles
            byte[] xmp1Bytes = XMP1.GetBytes();
            Array.Copy(xmp1Bytes, 0, bytes, XMPProfilesOffset[0], xmp1Bytes.Length);
            byte[] xmp2Bytes = XMP2.GetBytes();
            Array.Copy(xmp2Bytes, 0, bytes, XMPProfilesOffset[1], xmp2Bytes.Length);

            // EXPO takes XMP profile 3 and user profile 1
            if (expoFound || EXPO1Enabled || EXPO2Enabled)
            {
                byte[] expoBytes = GetEXPOBytes();
                Array.Copy(expoBytes, 0, bytes, EXPOOffset, expoBytes.Length);
            }
            else
            {
                byte[] xmp3Bytes = XMP3.GetBytes();
                Array.Copy(xmp3Bytes, 0, bytes, XMPProfilesOffset[2], xmp3Bytes.Length);
                byte[] xmp4Bytes = XMPUser1.GetBytes();
                Array.Copy(xmp4Bytes, 0, bytes, XMPProfilesOffset[3], xmp4Bytes.Length);
            }

            byte[] xmp5Bytes = XMPUser2.GetBytes();
            Array.Copy(xmp5Bytes, 0, bytes, XMPProfilesOffset[4], xmp5Bytes.Length);

            return bytes;
        }

        public static DDR5_SPD Parse(byte[] bytes)
        {
            try
            {
                if (bytes.Length != TotalSize)
                {
                    //MessageBox.Show($"SPD must be {TotalSize} bytes", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }

                var rawSpdBytes = bytes.Take(TotalSize).ToArray();
                DDR5_SPD spd = new DDR5_SPD();

                // Read into RawSpd struct.
                var handle = GCHandle.Alloc(rawSpdBytes, GCHandleType.Pinned);
                spd.rawSPD = Marshal.PtrToStructure<RawSPD>(handle.AddrOfPinnedObject());
                handle.Free();

                // Check what memory type we got
                if (spd.rawSPD.memoryType != 0x12)
                {
                    throw new ApplicationException("SPD is for non DDR5, this is not supported.");
                }

                if (!((spd.rawSPD.moduleType == 0x02) || (spd.rawSPD.moduleType == 0x03)))
                {
                    throw new ApplicationException("SPD is for non UDIMM/SODIMM memory, this is not supported.");
                }

                var xmpBytes = bytes.Skip(XMPOffset).ToArray();
                var xmpHeaderMagic = xmpBytes.Take(XMPHeaderMagic.Length);

                var expoBytes = bytes.Skip(EXPO.EXPOOffset).Take(EXPO.EXPOSize).ToArray();
                var expoHeaderMagic = expoBytes.Take(EXPO.EXPOHeaderMagic.Length);

                // Check if EXPO is present
                spd.expoFound = expoHeaderMagic.SequenceEqual(EXPO.EXPOHeaderMagic);

                // Read the EXPO block
                handle = GCHandle.Alloc(expoBytes, GCHandleType.Pinned);
                spd.rawExpo = Marshal.PtrToStructure<EXPO.RawEXPO>(handle.AddrOfPinnedObject());
                handle.Free();

                // Parse EXPO Profiles (if any)
                spd.ParseEXPO(expoBytes);
                // Read the EXPO block
                handle = GCHandle.Alloc(expoBytes, GCHandleType.Pinned);
                spd.rawExpo = Marshal.PtrToStructure<EXPO.RawEXPO>(handle.AddrOfPinnedObject());
                handle.Free();

                // Parse EXPO Profiles (if any)
                spd.ParseEXPO(expoBytes);                // Check if XMP 3.0 is present
                spd.xmpFound = (xmpHeaderMagic.SequenceEqual(XMPHeaderMagic) && xmpBytes[2] == XMPVersion);

                // Read the XMP header
                handle = GCHandle.Alloc(xmpBytes, GCHandleType.Pinned);
                spd.xmpHeader = Marshal.PtrToStructure<XMPHeader_3_0>(handle.AddrOfPinnedObject());
                handle.Free();

                // Parse the XMP profiles (if any)
                spd.ParseXMP(xmpBytes.Skip(Marshal.SizeOf<XMPHeader_3_0>()).ToArray());


                return spd;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }

            return null;
        }
        public XMP_3_0 XMP1
        {
            get => xmp[0];
            set => xmp[0] = value;
        }
        public XMP_3_0 XMP2
        {
            get => xmp[1];
            set => xmp[1] = value;
        }
        public XMP_3_0 XMP3
        {
            get => xmp[2];
            set => xmp[2] = value;
        }
        public XMP_3_0 XMPUser1
        {
            get => xmp[3];
            set => xmp[3] = value;
        }
        public XMP_3_0 XMPUser2
        {
            get => xmp[4];
            set => xmp[4] = value;
        }
        public EXPO EXPO1
        {
            get => expo[0];
            set => expo[0] = value;
        }
        public EXPO EXPO2
        {
            get => expo[1];
            set => expo[1] = value;
        }

        public bool copyXmpProfile(ushort sourceProfile, ushort targetProfile)
        {
            if (sourceProfile == targetProfile)
            {
                return false;
            }

            XMP_3_0 source;
            string profileName;

            switch (sourceProfile)
            {
                case 1:
                    source = XMP1;
                    profileName = XMPProfile1Name;
                    break;
                case 2:
                    source = XMP2;
                    profileName = XMPProfile2Name;
                    break;
                case 3:
                    source = XMP3;
                    profileName = XMPProfile3Name;
                    break;
                case 4:
                    source = XMPUser1;
                    profileName = "User 1";
                    break;
                case 5:
                    source = XMPUser2;
                    profileName = "User 2";
                    break;
                default:
                    return false;
            }

            switch (targetProfile)
            {
                case 1:
                    XMP1 = source;
                    XMP1Enabled = true;
                    XMPProfile1Name = profileName;
                    UpdateCrc();
                    break;

                case 2:
                    XMP2 = source;
                    XMP2Enabled = true;
                    XMPProfile2Name = profileName;
                    UpdateCrc();
                    break;
                case 3:
                    XMP3 = source;
                    XMP3Enabled = true;
                    XMPProfile3Name = profileName;
                    UpdateCrc();
                    break;
                case 4:
                    XMPUser1 = source;
                    XMPUser1.UpdateCrc();
                    break;
                case 5:
                    XMPUser2 = source;
                    XMPUser2.UpdateCrc();
                    break;
                default:
                    return false;
            }

            return true;
        }
        private void ParseXMP(byte[] bytes)
        {
            XMP1 = XMP_3_0.Parse(1, bytes.Take(XMP_3_0.Size).ToArray());
            XMP2 = XMP_3_0.Parse(2, bytes.Skip(XMP_3_0.Size).Take(XMP_3_0.Size).ToArray());

            // Don't parse profile 3, and User profile 1 if expo is present
            if (expoFound)
            {
                XMP3 = new XMP_3_0();

                // User profiles
                XMPUser1 = new XMP_3_0();
            }
            else
            {
                XMP3 = XMP_3_0.Parse(3, bytes.Skip(XMP_3_0.Size * 2).Take(XMP_3_0.Size).ToArray());

                // User profiles
                XMPUser1 = XMP_3_0.Parse(4, bytes.Skip(XMP_3_0.Size * 3).Take(XMP_3_0.Size).ToArray());
            }

            XMPUser2 = XMP_3_0.Parse(5, bytes.Skip(XMP_3_0.Size * 4).Take(XMP_3_0.Size).ToArray());
        }
        private void ParseEXPO(byte[] bytes)
        {
            EXPO1 = EXPO.Parse(1, bytes.Skip(EXPO.EXPOHeaderSize).Take(EXPO.EXPOProfileSize).ToArray());
            EXPO2 = EXPO.Parse(1, bytes.Skip(EXPO.EXPOHeaderSize + EXPO.EXPOProfileSize).Take(EXPO.EXPOProfileSize).ToArray());
        }
    }
}
