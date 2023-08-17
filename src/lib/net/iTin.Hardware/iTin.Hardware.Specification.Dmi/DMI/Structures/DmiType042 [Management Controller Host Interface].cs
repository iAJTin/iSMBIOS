
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Management Controller Host Interface (Type 42) structure.<br/>
/// For more information, please see <see cref="DmiType042"/>.
/// </summary>
internal sealed class DmiType042: DmiBaseType<SmbiosType042>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType042"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType042(SmbiosType042 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.ManagementControllerHostInterface.InterfaceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.InterfaceType));

        object interfaceTypeSpecificData = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.InterfaceTypeSpecificData);
        if (interfaceTypeSpecificData != null)
        {
            properties.Add(DmiProperty.ManagementControllerHostInterface.InterfaceTypeSpecificData, interfaceTypeSpecificData);
        }

        object protocols = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.Protocols);
        if (protocols != null)
        {
            properties.Add(DmiProperty.ManagementControllerHostInterface.Protocols, new DmiManagementControllerHostInterfaceProtocolRecordsCollection((ManagementControllerHostInterfaceProtocolRecordsCollection)protocols));
        }
    }
}
