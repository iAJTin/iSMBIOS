﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the 64-Bit Memory Error Information (Type 33) structure.<br/>
/// For more information, please see <see cref="SmbiosType033"/>.
/// </summary>
internal sealed class DmiType033 : DmiBaseType<SmbiosType033>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType033"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType033(SmbiosType033 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.BitMemoryError64.ErrorType, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError64.ErrorType));
        properties.Add(DmiProperty.BitMemoryError64.ErrorGranularity, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError64.ErrorGranularity));
        properties.Add(DmiProperty.BitMemoryError64.ErrorOperation, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError64.ErrorOperation));

        uint vendorSyndrome = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError64.VendorSyndrome);
        if (vendorSyndrome != 0x00000000)
        {
            properties.Add(DmiProperty.BitMemoryError64.VendorSyndrome, vendorSyndrome);
        }

        ulong busErrorAddress = SmbiosStructure.GetPropertyValue<ulong>(SmbiosProperty.BitMemoryError64.MemoryArrayErrorAddress);
        if (busErrorAddress != 0x8000000000000000)
        {
            properties.Add(DmiProperty.BitMemoryError64.MemoryArrayErrorAddress, busErrorAddress);
        }

        ulong deviceErrorAddress = SmbiosStructure.GetPropertyValue<ulong>(SmbiosProperty.BitMemoryError64.DeviceErrorAddress);
        if (deviceErrorAddress != 0x8000000000000000)
        {
            properties.Add(DmiProperty.BitMemoryError64.DeviceErrorAddress, deviceErrorAddress);
        }

        uint errorResolution = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError64.ErrorResolution);
        if (errorResolution != 0x80000000)
        {
            properties.Add(DmiProperty.BitMemoryError64.ErrorResolution, errorResolution);
        }
    }
}
