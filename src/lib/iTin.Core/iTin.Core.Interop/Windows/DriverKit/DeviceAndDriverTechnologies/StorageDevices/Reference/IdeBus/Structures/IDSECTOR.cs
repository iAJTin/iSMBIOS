using System.Runtime.InteropServices;
using UCHAR = System.Byte;
using ULONG = System.UInt32;
using USHORT = System.UInt16;
using BYTE = System.Byte;
using CHAR = System.Char;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff554977%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct IDSECTOR
    {
        #region Atributos
        /// <summary>
        /// 
        /// </summary>
        public USHORT wGenConfig;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wNumCyls;
        
        /// <summary>
        /// 
        /// </summary>
        public USHORT wReserved;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wNumHeads;
       
        /// <summary>
        /// 
        /// </summary>
        public ushort wBytesPerTrack;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wBytesPerSector;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wSectorsPerTrack;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public USHORT[] wVendorUnique;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 19)]
        public CHAR[] sSerialNumber;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wBufferType;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wBufferSize;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wECCSize;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public CHAR[] sFirmwareRev;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 39)]
        public CHAR[] sModelNumber;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wMoreVendorUnique;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wDoubleWordIO;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wCapabilities;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wReserved1;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wPIOTiming;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wDMATiming;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wBS;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wNumCurrentCyls;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wNumCurrentHeads;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wNumCurrentSectorsPerTrack;

        /// <summary>
        /// 
        /// </summary>
        public ULONG  ulCurrentSectorCapacity;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wMultSectorStuff;

        /// <summary>
        /// 
        /// </summary>
        public ULONG  ulTotalAddressableSectors;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wSingleWordDMA;

        /// <summary>
        /// 
        /// </summary>
        public USHORT wMultiWordDMA;

        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 127)]
        public BYTE[] bReserved;
        #endregion
    }
}