
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// The <strongs>ATA_PASS_THROUGH_EX</strongs> structure is used in conjunction with an <see cref="IOCTL_ATA_PASS_THROUGH"/> request to instruct the port driver to send an embedded ATA command to the target device.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntddscsi/ns-ntddscsi-_ata_pass_through_ex.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct ATA_PASS_THROUGH_EX_WITH_BUFFER
    {
        /// <summary>
        /// Especifica la longitud en bytes de la estructura.
        /// </summary>
        public ATA_PASS_THROUGH_EX Apt;

        /// <summary>
        /// Indica la dirección de la transferencia de datos y especifica el tipo de operación a realizar.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)] 
        public byte[] Data;
    }
}