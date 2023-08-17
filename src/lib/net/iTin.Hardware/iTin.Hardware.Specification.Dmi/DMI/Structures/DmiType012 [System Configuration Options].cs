
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Configuration Options (Type 12) structure.<br/>
/// For more information, please see <see cref="SmbiosType012"/>.
/// </summary>
internal sealed class DmiType012 : DmiBaseType<SmbiosType012>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType012"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType012(SmbiosType012 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.SystemConfigurationOptions.Values, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemConfigurationOptions.Values));
    }
}
