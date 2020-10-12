
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a read-only collection of objects <see cref="SmbiosBaseType"/>.
    /// </summary>
    public sealed class SmbiosStructureCollection : ReadOnlyCollection<SmbiosBaseType>
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosStructureCollection"/> class.
        /// </summary>
        /// <param name="selectedStructure">The selected structure.</param>
        internal SmbiosStructureCollection(IEnumerable<SmbiosBaseType> selectedStructure) : base(selectedStructure.ToList())
        {
        }
    }
}
