
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the  Management Device (Type 34) structure.<br/>
/// For more information, please see <see cref="SmbiosType034"/>.
/// </summary>
internal sealed class DmiType034 : DmiBaseType<SmbiosType034>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType034"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType034(SmbiosType034 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.ManagementDevice.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Description));
        properties.Add(DmiProperty.ManagementDevice.Type, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Type));
        properties.Add(DmiProperty.ManagementDevice.Address, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Address));
        properties.Add(DmiProperty.ManagementDevice.AddressType, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.AddressType));
    }
}
