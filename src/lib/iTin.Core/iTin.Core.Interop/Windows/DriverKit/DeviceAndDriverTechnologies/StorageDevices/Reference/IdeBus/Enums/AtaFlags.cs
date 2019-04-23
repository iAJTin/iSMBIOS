using System;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// Indica la dirección de la transferencia de datos y especifica el tipo de operación a realizar.
    /// </summary>
    [Flags]
    public enum AtaFlags : ushort
    {
        /// <summary>
        /// Ninguno.
        /// </summary>
	    None = 0,

        /// <summary>
        /// Espere a que el dispositivo este preparado antes de enviar el comando.
        /// </summary>
        DriveReadyRequired = (1 << 0),

        /// <summary>
        /// Leer datos del dispositivo.
        /// </summary>
        ReceiveData = (1 << 1),

        /// <summary>
        /// Enviar datos al dispositivo.
        /// </summary>
        SendData = (1 << 2),

        /// <summary>
        /// The ATA command to be sent uses the 48-bit logical block address (LBA) feature set.
        /// When this flag is set, the contents of the PreviousTaskFile member in the <strong>ATA_PASS_THROUGH_EX</strong> structure should be valid.
        /// </summary>
        Command48Bit = (1 << 3),

        /// <summary>
        /// Establecer modo de transferencia a DMA.
        /// </summary>
        UseDma = (1 << 4),

        /// <summary>
        /// Leer un solo sector y sólo en el dispositivo.
        /// </summary>
        NoMultiple = (1 << 5)
    }
}