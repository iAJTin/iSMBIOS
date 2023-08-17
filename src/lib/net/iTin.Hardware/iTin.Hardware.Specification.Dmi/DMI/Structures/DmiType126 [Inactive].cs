
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Inactive (Type 126) structure.<br/>
/// For more information, please see <see cref="SmbiosType126"/>.
/// </summary>
internal sealed class DmiType126 : DmiBaseType<SmbiosType126>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType126"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType126(SmbiosType126 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    { 
        properties.Add(DmiProperty.Inactive.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.Inactive.Description));
    }
}
