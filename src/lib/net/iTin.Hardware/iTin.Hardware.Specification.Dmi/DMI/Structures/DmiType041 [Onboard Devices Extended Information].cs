
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Onboard Devices Extended Information (Type 41) structure.<br/>
/// For more information, please see <see cref="DmiType041"/>.
/// </summary>
internal sealed class DmiType041: DmiBaseType<SmbiosType041>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType041"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType041(SmbiosType041 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.OnBoardDevicesExtended.ReferenceDesignation, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.ReferenceDesignation));
        properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceStatus));
        properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceType));
    }
}
