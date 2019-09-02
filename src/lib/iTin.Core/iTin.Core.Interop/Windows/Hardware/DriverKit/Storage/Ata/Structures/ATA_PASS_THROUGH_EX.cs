
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System.Runtime.InteropServices;

    using UCHAR = System.Byte;
    using ULONG = System.UInt32;
    using ULONG_PTR = System.IntPtr;
    using USHORT = System.UInt16;

    /// <summary>
    /// The <strongs>ATA_PASS_THROUGH_EX</strongs> structure is used in conjunction with an IOCTL_ATA_PASS_THROUGH request to instruct the port driver to send an embedded ATA command to the target device.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/es-es/windows-hardware/drivers/ddi/content/ntddscsi/ns-ntddscsi-_ata_pass_through_ex.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ATA_PASS_THROUGH_EX
    {
        /// <summary>
        /// Specify the length in bytes of the structure.
        /// </summary>
        public USHORT Length;

        /// <summary>
        /// Indicates the address of the data transfer and specifies the type of operation to be performed.
        /// </summary>
        public AtaFlags AtaFlags;

        /// <summary>
        /// Contains an integer that indicates the IDE port or the request bus.
        /// This value is set by the port controller.
        /// </summary>
        public UCHAR PathId;

        /// <summary>
        /// Contains an integer that indicates the target device on the bus.
        /// This value is set by the port controller.
        /// </summary>
        public UCHAR TargetId;

        /// <summary>
        /// Indicates the logical unit number of the device.
        /// This value is set by the port controller.
        /// </summary>
        public UCHAR Lun;

        /// <summary>
        /// Reservad.
        /// </summary>
        public UCHAR ReservedAsUchar;

        /// <summary>
        /// Indicates the size, in bytes, of the data buffer.
        /// If there is insufficient data, the miniport driver must update this member in the number of bytes that are actually transferred.
        /// </summary>
        public ULONG DataTransferLength;

        /// <summary>
        /// Indicates the number of seconds allowed for the execution request before the operating system specific port driver determines that the request has expired.
        /// </summary>
        public ULONG TimeOutValue;

        /// <summary>
        /// Reservad.
        /// </summary>
        public ULONG ReservedAsUlong;

        /// <summary>
        /// Specifies the offset, in bytes, from the beginning of this structure to the data buffer. 
        /// </summary>
        public ULONG_PTR DataBufferOffset;

        /// <summary>
        /// Specifies the contents of the task file input registers prior to the current pass-through command.
        /// This member is not used when the ATA_FLAGS_48BIT_COMMAND flag is not set. 
        /// </summary>
        public ATA_TASK_FILE PreviousTaskFile;

        /// <summary>
        /// Specifies the content of the task file register on both input and output.
        /// On input, the array values in CurrentTaskFile map to the task file input registers in the following manner.
        /// </summary>
        public ATA_TASK_FILE CurrentTaskFile;
    }
}
