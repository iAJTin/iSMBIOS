
namespace iTin.Hardware.Specification.Dmi
{
    /// <summary>
    /// Defines the membership of a memory device to a set with the same size and type.
    /// </summary>
    internal enum MemoryDeviceBelongsToSet
    {
        /// <summary>
        /// Not belong to a set
        /// </summary>
        No,

        /// <summary>
        /// Not known if it belongs to a set
        /// </summary>
        Unknown,

        /// <summary>
        /// Belongs to a set 
        /// </summary>
        Yes
    }
}
