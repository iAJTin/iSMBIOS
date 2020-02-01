
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Smbios;

    /// <inheritdoc/>
    /// <summary>
    /// Representa una colección de objetos <see cref="DmiClass"/>.
    /// </summary>
    public sealed class DmiClassCollection : ReadOnlyCollection<DmiClass> 
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the <see cref = "DmiClassCollection"/> class.
        /// </summary>
        /// <param name="parent">Estructura.</param>
        internal DmiClassCollection(DmiStructure parent) : base(new List<DmiClass>())
        {
            SMBIOS smbios = DmiHelper.Smbios;
            int smbiosVersion = smbios.Version;
            SmbiosStructureCollection structures = smbios.Get((SmbiosStructure)(int)parent.Class);
            foreach (var structure in structures)
            {
                Items.Add(new DmiClass(DmiStructureFactory.Create(structure, smbiosVersion)));
            }
        }
    }
}
