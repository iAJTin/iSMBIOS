
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the  Management Device Component (Type 35) structure.<br/>
/// For more information, please see <see cref="SmbiosType035"/>.
/// </summary>
internal sealed class DmiType035 : DmiBaseType<SmbiosType035>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType035"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType035(SmbiosType035 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.ManagementDeviceComponent.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.Description));
        properties.Add(DmiProperty.ManagementDeviceComponent.ComponentHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ComponentHandle));
           
        ushort thresholdHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceComponent.ThresholdHandle);
        if (thresholdHandle != 0xffff)
        {
            properties.Add(DmiProperty.ManagementDeviceComponent.ThresholdHandle, thresholdHandle);
        }

        properties.Add(DmiProperty.ManagementDeviceComponent.ManagementDeviceHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ManagementDeviceHandle));
    }
}
