
namespace iTin.Core.Hardware.Specification.Smbios
{
    /// <summary>
    /// Indica la pertenencia de un dispositivo de memoria a un conjunto con el mismo tamaño y tipo.
    /// </summary>
    enum MemoryDeviceBelongsToSet
    {
        /// <summary>
        /// No pertence a un conjunto
        /// </summary>
        No,

        /// <summary>
        /// Se desconoce si pertence a un conjunto
        /// </summary>
        Unknown,

        /// <summary>
        /// Si pertence a un conjunto 
        /// </summary>
        Yes
    }
}
