
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode OEM Strings (Type 11) structure.<br/>
/// For more information, please see <see cref="SmbiosType011"/>.
/// </summary>
internal sealed class DmiType011 : DmiBaseType<SmbiosType011>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType011"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType011(SmbiosType011 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.OemStrings.Values, SmbiosStructure.GetPropertyValue(SmbiosProperty.OemStrings.Values));
    }
}
