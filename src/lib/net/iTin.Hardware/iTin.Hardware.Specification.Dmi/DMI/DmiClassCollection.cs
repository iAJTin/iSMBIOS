
using System.Collections.Generic;
using System.Collections.ObjectModel;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Representa una colección de objetos <see cref="DmiClass"/>.
/// </summary>
public sealed class DmiClassCollection : ReadOnlyCollection<DmiClass> 
{
    /// <summary>
    /// Initialize a new instance of the <see cref = "DmiClassCollection"/> class.
    /// </summary>
    /// <param name="parent">Estructura.</param>
    internal DmiClassCollection(DmiStructure parent) : base(new List<DmiClass>())
    {
        var structures = parent.Context.Get((SmbiosStructure)(int)parent.Class);
        foreach (var structure in structures)
        {
            Items.Add(new DmiClass(DmiStructureFactory.Create(structure, parent.Context.Version)));
        }
    }
}
