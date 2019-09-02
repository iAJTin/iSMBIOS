
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide
{
    using System.Runtime.InteropServices;

    using BYTE = System.Byte;
    using DWORD = System.UInt32;

    /// <summary>
    /// The <strong>DRIVERSTATUS</strong> structure is used in conjunction with the <c>SENDCMDOUTPARAMS</c> structure and the <see cref="DiskIoControlCode.SMART_SEND_DRIVE_COMMAND"/> request to retrieve data returned by a Self-Monitoring Analysis and Reporting Technology (SMART) command.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntdddisk/ns-ntdddisk-_driverstatus.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DRIVERSTATUS
    {
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
    }
}
