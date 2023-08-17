﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Device Mapped Address (Type 20) structure.<br/>
/// For more information, please see <see cref="SmbiosType020"/>.
/// </summary>
internal sealed class DmiType020 : DmiBaseType<SmbiosType020>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType020"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType020(SmbiosType020 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.v21)
        {
            return;
        }

        properties.Add(DmiProperty.MemoryDeviceMappedAddress.MemoryDeviceHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.MemoryDeviceHandle));
        properties.Add(DmiProperty.MemoryDeviceMappedAddress.MemoryArrayMappedAddressHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.MemoryArrayMappedAddressHandle));
        properties.Add(DmiProperty.MemoryDeviceMappedAddress.PartitionRowPosition, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.PartitionRowPosition));
        properties.Add(DmiProperty.MemoryDeviceMappedAddress.InterleavePosition, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.InterleavePosition));
        properties.Add(DmiProperty.MemoryDeviceMappedAddress.InterleavedDataDepth, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.InterleavedDataDepth));

        uint startingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryDeviceMappedAddress.StartingAddress);
        if (startingAddress == 0xffffffff)
        {
            if (ImplementedVersion >= DmiStructureVersion.v27)
            {
                object extendedStartingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedStartingAddress);
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.StartingAddress, extendedStartingAddress);
            }
        }
        else
        {
            properties.Add(DmiProperty.MemoryDeviceMappedAddress.StartingAddress, (ulong)startingAddress * (ulong)1024);
        }

        uint endingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryDeviceMappedAddress.EndingAddress);
        if (endingAddress == 0xffffffff)
        {
            if (ImplementedVersion >= DmiStructureVersion.v27)
            {
                object extendedEndingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedEndingAddress);
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.EndingAddress, extendedEndingAddress);
            }
        }
        else
        {
            properties.Add(DmiProperty.MemoryDeviceMappedAddress.EndingAddress, (ulong)endingAddress * (ulong)1024);
        }
    }
}
