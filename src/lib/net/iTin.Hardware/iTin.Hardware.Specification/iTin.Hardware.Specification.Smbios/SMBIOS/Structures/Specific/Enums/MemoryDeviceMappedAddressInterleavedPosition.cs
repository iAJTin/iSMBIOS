
namespace iTin.Hardware.Specification.Smbios
{
    /// <summary>
    /// Defines the type of interpolation of a device.
    /// </summary>
    internal enum MemoryDeviceMappedAddressInterleavedPosition
    {
        /// <summary>
        /// Not interpolated
        /// </summary>
        NonInterleaved = 0x00,

        /// <summary>
        /// First interpolated position
        /// </summary>
        FirstInterleavePosition = 0x01,

        /// <summary>
        /// Second interpolated position.
        /// </summary>
        SecondInterleavePosition = 0x02,

        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0xff,
    }
}
