﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the IPMI Device Information (Type 38) structure.<br/>
/// For more information, please see <see cref="SmbiosType038"/>.
/// </summary>
internal sealed class DmiType038 : DmiBaseType<SmbiosType038>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType038"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType038(SmbiosType038 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.IpmiDevice.InterfaceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.InterfaceType));
        properties.Add(DmiProperty.IpmiDevice.SpecificationRevision, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.SpecificationRevision));
        properties.Add(DmiProperty.IpmiDevice.I2CSlaveAddress, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.I2CSlaveAddress));
        properties.Add(DmiProperty.IpmiDevice.BaseAddress, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAddress));

        byte nvStorageDeviceAddress = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.IpmiDevice.NVStorageDeviceAddress);
        if (nvStorageDeviceAddress != 0xff)
        {
            properties.Add(DmiProperty.IpmiDevice.NVStorageDeviceAddress, nvStorageDeviceAddress);
        }

        if (SmbiosStructure.StructureInfo.Length >= 0x11)
        {
            properties.Add(DmiProperty.IpmiDevice.BaseAdressModifier.LsBit, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAdressModifier.LsBit));
            properties.Add(DmiProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing));
            properties.Add(DmiProperty.IpmiDevice.Interrupt.SpecifiedInfo, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.SpecifiedInfo));
            properties.Add(DmiProperty.IpmiDevice.Interrupt.Polarity, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.Polarity));
            properties.Add(DmiProperty.IpmiDevice.Interrupt.TriggerMode, SmbiosStructure.GetPropertyValue(SmbiosProperty.IpmiDevice.Interrupt.TriggerMode));
        }

        if (SmbiosStructure.StructureInfo.Length >= 0x12)
        {
            byte interruptNumber = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.IpmiDevice.InterruptNumber);
            if (interruptNumber != 0x00)
            {
                properties.Add(DmiProperty.IpmiDevice.InterruptNumber, interruptNumber);
            }
        }
    }
}
