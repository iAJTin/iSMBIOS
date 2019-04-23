using System.Runtime.InteropServices;
using BYTE = System.Byte;
using DWORD = System.UInt32;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// La estructura <strongs>SENDCMDOUTPARAMS</strongs> se utiliza junto con la petición <see cref="IoctlDiskIoControlCode.SMART_SEND_DRIVE_COMMAND"/> para recuperar los datos devueltos por un comando (SMART).
    /// </summary>
    /// <remarks>
    /// La estructura <strongs>SENDCMDOUTPARAMS</strongs> también se utiliza con la petición <see cref="IoctlDiskIoControlCode.SMART_RCV_DRIVE_DATA"/>.
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff565405%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    struct SENDCMDOUTPARAMS
    {
        #region Atributos
        /// <summary>
        /// Tamaño del buffer en bytes.
        /// </summary>
        public DWORD cBufferSize; 

        /// <summary>
        /// Estructura <see cref="DRIVERSTATUS"/> que indica el estado del driver.
        /// </summary>
        public DRIVERSTATUS DriverStatus; 

        /// <summary>
        /// Puntero a un búfer que almacena los datos leídos desde el disco.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public BYTE[] bBuffer;
        #endregion
    }
}