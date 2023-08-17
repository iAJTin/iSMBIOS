
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Channel (Type 37) structure.<br/>
/// For more information, please see <see cref="SmbiosType037"/>.
/// </summary>
sealed class DmiType037 : DmiBaseType<SmbiosType037>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType037"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType037(SmbiosType037 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.MemoryChannel.ChannelType, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.ChannelType));
        properties.Add(DmiProperty.MemoryChannel.MaximunChannelLoad, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.MaximumChannelLoad));

        object devices = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.Devices);
        if (devices != null)
        {
            properties.Add(DmiProperty.MemoryChannel.Devices, new DmiMemoryChannelElementCollection((MemoryChannelElementCollection) devices));
        }
    }
}
