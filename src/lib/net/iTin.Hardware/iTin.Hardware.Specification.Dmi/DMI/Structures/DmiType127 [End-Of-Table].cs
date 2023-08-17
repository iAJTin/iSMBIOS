
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the End Of Table (Type 127) structure.<br/>
/// For more information, please see <see cref="SmbiosType127"/>.
/// </summary>
internal sealed class DmiType127 : DmiBaseType<SmbiosType127>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType127"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType127(SmbiosType127 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.EndOfTable.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.EndOfTable.Status));
    }
}
