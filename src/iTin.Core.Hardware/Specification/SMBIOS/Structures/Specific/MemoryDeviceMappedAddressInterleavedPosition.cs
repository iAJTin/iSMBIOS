
namespace iTin.Core.Hardware.Specification.Smbios
{
    /// <summary>
    /// Indica el tipo de interpolación de un dispositivo.
    /// </summary>
    enum MemoryDeviceMappedAddressInterleavedPosition
    {
        /// <summary>
        /// No interpolado.
        /// </summary>
        NonInterleaved = 0x00,

        /// <summary>
        /// Primera posición interpolada.
        /// </summary>
        FirstInterleavePosition = 0x01,

        /// <summary>
        /// Segunda posición interpolada.
        /// </summary>
        SecondInterleavePosition = 0x02,

        /// <summary>
        /// Desconocido.
        /// </summary>
        Unknown = 0xff,
    }
}
