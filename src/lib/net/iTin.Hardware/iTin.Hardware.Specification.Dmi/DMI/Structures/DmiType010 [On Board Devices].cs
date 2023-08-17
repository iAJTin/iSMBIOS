
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the On Board Devices (Type 10, Obsolete) structure.<br/>
/// For more information, please see <see cref="SmbiosType010"/>.
/// </summary>
internal sealed class DmiType010 : DmiBaseType<SmbiosType010>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType010"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType010(SmbiosType010 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.OnBoardDevices.Enabled, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Enabled));
        properties.Add(DmiProperty.OnBoardDevices.DeviceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.DeviceType));
        properties.Add(DmiProperty.OnBoardDevices.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Description));
    }
}
