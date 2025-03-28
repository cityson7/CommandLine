using System;


namespace CommandLine
{

    /// <summary>
    /// Defines RAM Type 
    /// </summary>
    public enum RamType
    {
        UNKNOWN = 0,
        SDR = 4,
        DDR = 7,
        DDR2 = 8,
        DDR3 = 11,
        DDR4 = 12,
        DDR5 = 18, //0x12
    }

    /// <summary>
    /// Defines SPD sizes
    /// </summary>
    public enum SpdSize
    {
        /// <summary>
        /// SD RAM SPD Total Size
        /// </summary>
        SDR_SPD_SIZE = 128,
        /// <summary>
        /// DDR RAM SPD Total Size
        /// </summary>
        DDR_SPD_SIZE = 256,
        /// <summary>
        /// DDR2 RAM SPD Total Size
        /// </summary>
        DDR2_SPD_SIZE = 256,
        /// <summary>
        /// DDR3 RAM SPD Total Size
        /// </summary>
        DDR3_SPD_SIZE = 256,
        /// <summary>
        /// DDR4 RAM SPD Total Size
        /// </summary>
        DDR4_SPD_SIZE = 512,
        /// <summary>
        /// DDR5 RAM SPD Total Size
        /// </summary>
        DDR5_SPD_SIZE = 1024,
    }


    public enum DramManufacturer
    {
        //0x2C00—Micron Technology, Inc.
        //0x5105—Qimonda AG i. In.
        //0x802C—Micron Technology, Inc.
        //0x80AD—Hynix Semiconductor Inc.
        //0x80CE—Samsung Electronics, Inc.
        //0x8551—Qimonda AG i. In.
        //0xAD00—Hynix Semiconductor Inc.
        //0xCE00—Samsung Electronics, Inc.
        HLDS = 0x8F5E,
    }


    /// <summary>
    /// Defines EEPROM class, properties, and methods to handle EEPROM operations
    /// </summary>
    public class Eeprom
    {
        /// <summary>
        /// Gets RAM type from SPD data
        /// </summary>
        /// <param name="spd">SPD dump</param>
        /// <returns>RAM Type</returns>
        public static RamType GetRamType(byte[] spd)
        {
            // Byte at offset 0x02 in SPD indicates RAM type
            if (spd != null)
            {
                byte _ramType = spd[0x02];  //Module Type [0x02]

                switch (_ramType)
                {
                    case 0: return RamType.SDR;
                    case 7: return RamType.DDR;
                    case 8: return RamType.DDR2;
                    case 11: return RamType.DDR3;
                    case 12: return RamType.DDR4;
                    case 18: return RamType.DDR5;
                    default: return RamType.UNKNOWN;
                }
            }
            else
            {
                return RamType.UNKNOWN;
            }
            //if (Enum.IsDefined(typeof(RamType), (RamType)_ramType))
            //{
            //    return (RamType)_ramType;
            //}
            //return RamType.UNKNOWN;
        }

        /// <summary>
        /// Gets total EEPROM size
        /// </summary>
        /// <param name="device">Device instance</param>
        /// <returns>SPD size</returns>
        public static SpdSize GetSpdSize(RamType device)
        {

            switch (device)
            {
                case RamType.SDR: return SpdSize.SDR_SPD_SIZE;
                case RamType.DDR: return SpdSize.DDR_SPD_SIZE;
                case RamType.DDR2: return SpdSize.DDR2_SPD_SIZE;
                case RamType.DDR3: return SpdSize.DDR3_SPD_SIZE;
                case RamType.DDR4: return SpdSize.DDR4_SPD_SIZE;
                case RamType.DDR5: return SpdSize.DDR5_SPD_SIZE;
                default: return (SpdSize)1024;
            }
        }

        /// <summary>
        /// Gets model name from SPD contents
        /// </summary>
        /// <param name="spd">SPD contents</param>
        /// <returns>Model name</returns>
        public static string GetModuleModelName(byte[] spd)
        {

            // Part number location for SDR-DDR2 SPDs
            int modelNameStart;
            int modelNameEnd;
            string name;

            switch (GetRamType(spd))
            {
                case RamType.DDR5:  // Part number location for DDR5 SPDs
                    modelNameStart = 0x209;
                    modelNameEnd = 0x226;
                    break;
                case RamType.DDR4:  // Part number location for DDR4 SPDs
                    modelNameStart = 0x149;
                    modelNameEnd = 0x15C;
                    break;
                case RamType.DDR3:  // Part number location for DDR3 SPDs
                    modelNameStart = 0x80;
                    modelNameEnd = 0x91;
                    break;
                default:
                    modelNameStart = 0x49;
                    modelNameEnd = 0x5A;
                    break;
            }

            char[] _chars = new char[modelNameEnd - modelNameStart + 1];
            for (int i = 0; i < _chars.Length; i++)
            {
                _chars[i] = (char)spd[modelNameStart + i];
            }

            name = new string(_chars).Replace("\0", " ");

            return name.Trim();
        }

        /// <summary>
        /// Calculates CRC16/XMODEM checksum
        /// </summary>
        /// <param name="input">A byte array to be checked</param>
        /// <returns>A calculated checksum</returns>
        public static ushort Crc16(byte[] input)
        {
            int crc = 0;

            for (int i = 0; i < input.Length; i++)
            {
                crc ^= input[i] << 8;
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x8000) == 0x8000)
                    {
                        crc = (crc << 1) ^ 0x1021;
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
            }

            return (ushort)(crc & 0xFFFF);

            //ushort[] table = new ushort[256];
            //ushort crc = 0;

            //for (int i = 0; i < table.Length; ++i)
            //{

            //    ushort temp = 0;
            //    ushort a = (ushort)(i << 8);

            //    for (int j = 0; j < 8; ++j)
            //    {
            //        temp = (((temp ^ a) & 0x8000) != 0) ? (ushort)((temp << 1) ^ 0x1021) : (temp <<= 1);
            //        a <<= 1;
            //    }

            //    table[i] = temp;
            //}

            //for (int i = 0; i < input.Length; ++i)
            //{
            //    crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & input[i]))]);
            //}

            //return crc;
        }

        /// <summary>
        /// Calculates CRC8 checksum
        /// </summary>
        /// <param name="input">A byte array to be checked</param>
        /// <returns>A calculated checksum</returns>
        public static ushort Crc(byte[] input)
        {
            ushort crc = 0;

            for (int i = 0; i < input.Length; i++)
            {
                crc += input[i];
            }

            return crc;
        }
    }
}
