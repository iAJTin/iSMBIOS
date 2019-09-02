
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide
{
    using System.Runtime.InteropServices;

    using BYTE = System.Byte;
    using DWORD = System.UInt32;

    /// <summary>
    /// The <strongs>SENDCMDOUTPARAMS</strongs> structure is used in conjunction with the <see cref="DiskIoControlCode.SMART_SEND_DRIVE_COMMAND"/> request to retrieve data returned by a Self-Monitoring Analysis and Reporting Technology (SMART) command.
    /// </summary>
    /// <remarks>
    /// The <strongs>SENDCMDOUTPARAMS</strongs> structure is also used with the request <see cref="DiskIoControlCode.SMART_RCV_DRIVE_DATA"/>.
    /// For more information, see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntdddisk/ns-ntdddisk-_sendcmdoutparams.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct SENDCMDOUTPARAMS
    {
        /// <summary>
        /// Buffer size in bytes.
        /// </summary>
        public DWORD cBufferSize;

        /// <summary>
        /// Structure <see cref="DRIVERSTATUS"/> that indicates the status of the driver.
        /// </summary>
        public DRIVERSTATUS DriverStatus;

        /// <summary>
        /// Pointer to a buffer that stores the data read from the disk.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public BYTE[] bBuffer;
    }
}
