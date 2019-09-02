
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide
{
    using System.Runtime.InteropServices;

    using BYTE = System.Byte;
    using DWORD = System.UInt32;

    /// <summary>
    /// The <strongs>SENDCMDINPARAMS</strongs> structure contains the input parameters for the <see cref="DiskIoControlCode.SMART_SEND_DRIVE_COMMAND"/> request.
    /// </summary>
    /// <remarks>
    /// The <strongs>SENDCMDINPARAMS</strongs> structure is also used with the request <see cref="DiskIoControlCode.SMART_RCV_DRIVE_DATA" />.
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntdddisk/ns-ntdddisk-_sendcmdinparams.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct SENDCMDINPARAMS
    {
        /// <summary>
        /// Buffer size in bytes.
        /// </summary>
        public DWORD cBufferSize;

        /// <summary>
        /// Structure <see cref="IDEREGS"/> that contains the IDE controller register.
        /// </summary>
        public IDEREGS irDriveRegs;

        /// <summary>
        /// Physical unit number to which the command is sent (0, 1, 2, 3).
        /// </summary>
        /// <remarks>
        /// This opaque ws member. Do not use, the operating system ignores this member, because the physical unit that receives the request depends on the handle that identifies the unit.
        /// </remarks>
        public BYTE bDriveNumber;

        /// <summary>
        /// Reserved for future extensions.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public BYTE[] bReserved;

        /// <summary>
        /// Reserved for future extensions.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public DWORD[] dwReserved;

        /// <summary>
        /// Pointer to the input buffer.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public BYTE[] bBuffer;
    }
}
