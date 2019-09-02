
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System;

    /// <summary>
    /// Indicates the address of the data transfer and specifies the type of operation to be performed.
    /// </summary>
    [Flags]
    public enum AtaFlags : ushort
    {
        /// <summary>
        /// None.
        /// </summary>
	    None = 0,

        /// <summary>
        /// Wait for the device to be ready before sending the command.
        /// </summary>
        DriveReadyRequired = 1,

        /// <summary>
        /// Read device data.
        /// </summary>
        ReceiveData = 1 << 1,

        /// <summary>
        /// Send data to the device.
        /// </summary>
        SendData = 1 << 2,

        /// <summary>
        /// The ATA command to be sent uses the 48-bit logical block address (LBA) feature set.
        /// When this flag is set, the contents of the PreviousTaskFile member in the <strong>ATA_PASS_THROUGH_EX</strong> structure should be valid.
        /// </summary>
        Command48Bit = 1 << 3,

        /// <summary>
        /// Set transfer mode to DMA.
        /// </summary>
        UseDma = 1 << 4,

        /// <summary>
        /// Read a single sector and only on the device.
        /// </summary>
        NoMultiple = 1 << 5
    }
}