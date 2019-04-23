using System.Runtime.InteropServices;
using BYTE = System.Byte;
using DWORD = System.UInt32;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff554977%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct DRIVERSTATUS
    {
        #region Atributos
        /// <summary>
        /// Error code from driver, or 0 if no error.
        /// </summary>
        public  BYTE  bDriverError;

        /// <summary>
        /// Contents of IDE Error register. Only valid when bDriverError is SMART_IDE_ERROR.
        /// </summary>
        public BYTE  bIDEStatus;

        /// <summary>
        /// Reserved for future expansion.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public BYTE[]  bReserved;

        /// <summary>
        /// Reserved for future expansion.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public DWORD[]  dwReserved;
        #endregion
    }
}