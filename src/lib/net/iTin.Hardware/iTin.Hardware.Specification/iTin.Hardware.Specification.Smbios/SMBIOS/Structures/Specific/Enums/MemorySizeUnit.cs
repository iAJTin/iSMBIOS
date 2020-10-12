
namespace iTin.Hardware.Specification.Smbios
{
    /// <summary>
    /// Defines the unit of measurement of the memory.
    /// </summary>
    public enum MemorySizeUnit
    {
        /// <summary>
        /// Memory expressed in kilobytes
        /// </summary>
        KB = -1,

        /// <summary>
        /// Memory expressed in megabytes
        /// </summary>
        MB,

        /// <summary>
        /// Memory expressed in gigabytes
        /// </summary>
        GB,

        /// <summary>
        /// Undefined
        /// </summary>
        Reserved
    }
}
