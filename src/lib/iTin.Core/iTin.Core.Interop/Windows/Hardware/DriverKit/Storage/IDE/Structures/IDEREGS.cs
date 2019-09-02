
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide
{
    using System.Runtime.InteropServices;

    using BYTE = System.Byte;

    /// <summary>
    /// The <strong>IDEREGS</strong> structure is used to report the contents of the IDE controller registers.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntdddisk/ns-ntdddisk-_ideregs.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct IDEREGS
    {
        /// <summary>
        /// Used for specifying SMART "commands".
        /// </summary>
        public BYTE bFeaturesReg;

        /// <summary>
        /// IDE sector count register
        /// </summary>
        public BYTE bSectorCountReg;

        /// <summary>
        /// IDE sector number register
        /// </summary>
        public BYTE bSectorNumberReg;

        /// <summary>
        /// IDE low order cylinder value
        /// </summary>
        public BYTE bCylLowReg;

        /// <summary>
        /// IDE high order cylinder value
        /// </summary>
        public BYTE bCylHighReg;

        /// <summary>
        ///  IDE drive/head register
        /// </summary>
        public BYTE bDriveHeadReg;

        /// <summary>
        /// Actual IDE command.
        /// </summary>
        public BYTE bCommandReg;

        /// <summary>
        /// Reserved for future use.  Must be zero.
        /// </summary>
        public BYTE bReserved;
    }
}
