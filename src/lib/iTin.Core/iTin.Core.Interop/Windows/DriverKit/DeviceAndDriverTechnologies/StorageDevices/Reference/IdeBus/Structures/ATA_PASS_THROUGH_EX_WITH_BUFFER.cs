using System.Runtime.InteropServices;
using UCHAR = System.Byte;
using ULONG = System.UInt32;
using ULONG_PTR = System.IntPtr;
using USHORT = System.UInt16;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// La estructura <strongs>ATA_PASS_THROUGH_EX</strongs> contiene los parámetros de entrada para una petición de tipo <see cref="IOCTL_ATA_PASS_THROUGH"/>.
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff551323%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    struct ATA_PASS_THROUGH_EX_WITH_BUFFER
    {
        #region Atributos
        /// <summary>
        /// Especifica la longitud en bytes de la estructura.
        /// </summary>
        public ATA_PASS_THROUGH_EX Apt;

        /// <summary>
        /// Indica la dirección de la transferencia de datos y especifica el tipo de operación a realizar.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)] 
        public byte[] Data;
        #endregion
    }
}