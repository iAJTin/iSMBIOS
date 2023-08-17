
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Physical Memory Array (Type 16) structure.<br/>
/// For more information, please see <see cref="SmbiosType016"/>.
/// </summary>
internal sealed class DmiType016 : DmiBaseType<SmbiosType016>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType016"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType016(SmbiosType016 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.v21)
        {
            return;
        }

        properties.Add(DmiProperty.PhysicalMemoryArray.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.Location));
        properties.Add(DmiProperty.PhysicalMemoryArray.Use, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.Use));
        properties.Add(DmiProperty.PhysicalMemoryArray.MemoryErrorCorrection, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.MemoryErrorCorrection));
        properties.Add(DmiProperty.PhysicalMemoryArray.MemoryErrorInformationHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.MemoryErrorInformationHandle));
        properties.Add(DmiProperty.PhysicalMemoryArray.NumberOfMemoryDevices, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.NumberOfMemoryDevices));

        uint maximumCapacity = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.PhysicalMemoryArray.MaximumCapacity);
        if (maximumCapacity != 0x08000000)
        {
            properties.Add(DmiProperty.PhysicalMemoryArray.MaximumCapacity, maximumCapacity);
        }
        else
        {
            if (ImplementedVersion >= DmiStructureVersion.v27)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.MaximumCapacity, SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.ExtendedMaximumCapacity));
            }
        }
    }
}
