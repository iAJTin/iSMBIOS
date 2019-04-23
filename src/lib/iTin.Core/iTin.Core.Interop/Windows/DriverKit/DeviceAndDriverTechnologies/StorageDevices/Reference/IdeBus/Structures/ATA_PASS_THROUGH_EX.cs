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
    struct ATA_PASS_THROUGH_EX
    {
        #region Atributos
        /// <summary>
        /// Especifica la longitud en bytes de la estructura.
        /// </summary>
        public USHORT Length;

        /// <summary>
        /// Indica la dirección de la transferencia de datos y especifica el tipo de operación a realizar.
        /// </summary>
        public AtaFlags AtaFlags;

        /// <summary>
        /// Contiene un entero que indica el puerto IDE o el bus de la solicitud.
        /// Este valor se establece por el controlador de puerto.
        /// </summary>
        public UCHAR PathId;

        /// <summary>
        /// Contains an integer that indicates the target device on the bus.
        /// Este valor se establece por el controlador de puerto.
        /// </summary>
        public UCHAR TargetId;

        /// <summary>
        /// Indicates the logical unit number of the device.
        /// Este valor se establece por el controlador de puerto.
        /// </summary>
        public UCHAR Lun;

        /// <summary>
        /// Reservado.
        /// </summary>
        public UCHAR ReservedAsUchar;

        /// <summary>
        /// Indica el tamaño en bytes, del búfer de datos.
        /// Si se produce una insuficiencia de datos, el controlador de minipuerto debe actualizar este miembro en el 
        /// número de bytes que se transfieren en realidad.
        /// </summary>
        public ULONG DataTransferLength;

        /// <summary>
        /// Indica el número de segundos que se permite para la solicitud de ejecución antes de que el sistema operativo 
        /// específico de controlador de puerto determina que la solicitud ha caducado.
        /// </summary>
        public ULONG TimeOutValue;

        /// <summary>
        /// Reservado.
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
        public AtaTaskFile PreviousTaskFile;

        /// <summary>
        /// Specifies the content of the task file register on both input and output.
        /// On input, the array values in CurrentTaskFile map to the task file input registers in the following manner.
        /// </summary>
        public AtaTaskFile CurrentTaskFile;
        #endregion
    }
}