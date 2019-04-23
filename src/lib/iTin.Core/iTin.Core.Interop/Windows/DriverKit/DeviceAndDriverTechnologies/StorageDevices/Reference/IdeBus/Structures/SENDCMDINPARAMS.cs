using System.Runtime.InteropServices;
using BYTE = System.Byte;
using DWORD = System.UInt32;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// La estructura <strongs>SENDCMDINPARAMS</strongs> contiene los parámetros de entrada para una petición de tipo <see cref="IoctlDiskIoControlCode.SMART_SEND_DRIVE_COMMAND"/>.
    /// </summary>
    /// <remarks>
    /// La estructura <strongs>SENDCMDINPARAMS</strongs> también se utiliza con la petición <see cref="IoctlDiskIoControlCode.SMART_RCV_DRIVE_DATA"/>.
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff565401%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct SENDCMDINPARAMS
    {
        #region Atributos
        /// <summary>
        /// Tamaño del búfer en bytes.
        /// </summary>
        public DWORD cBufferSize; 

        /// <summary>
        /// Estructura <see cref="IDEREGS"/> que contiene el registro de la controladora IDE.
        /// </summary>
        public IDEREGS irDriveRegs; 

        /// <summary>
        /// Número de unidad física a la que se envia el comando (0, 1, 2, 3).
        /// </summary>
        /// <remarks>
        /// Este miembro ws opaco. No utilizar, el sistema operativo hace caso omiso de este miembro, 
        /// debido a que la unidad física que recibe la solicitud depende del handle que identifica a la unidad.
        /// </remarks>
        public BYTE bDriveNumber;

        /// <summary>
        /// Reservado para futuras extensiones.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public BYTE[] bReserved;

        /// <summary>
        /// Reservado para futuras extensiones.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public DWORD[] dwReserved;

        /// <summary>
        /// Puntero al búfer de entrada.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public BYTE[] bBuffer;
        #endregion
    }
}