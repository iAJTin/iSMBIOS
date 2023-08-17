﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Portable Battery (Type 22) structure.<br/>
/// For more information, please see <see cref="SmbiosType022"/>.
/// </summary>
internal sealed class DmiType022 : DmiBaseType<SmbiosType022>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType022"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType022(SmbiosType022 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion >= DmiStructureVersion.v21)
        {
            properties.Add(DmiProperty.PortableBattery.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.Location));
            properties.Add(DmiProperty.PortableBattery.Manufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.Manufacturer));
            properties.Add(DmiProperty.PortableBattery.DeviceName, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DeviceName));
  
            ushort designVoltage = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.PortableBattery.DesignVoltage);
            if (designVoltage != 0x0000)
            {
                properties.Add(DmiProperty.PortableBattery.DesignVoltage, designVoltage);
            }

            properties.Add(DmiProperty.PortableBattery.SBDSVersionNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.SBDSVersionNumber));

            byte maximumErrorInBatteryData = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.PortableBattery.MaximunErrorInBatteryData);
            if (maximumErrorInBatteryData != 0xff)
            {
                properties.Add(DmiProperty.PortableBattery.MaximunErrorInBatteryData, maximumErrorInBatteryData);
            }

            properties.Add(DmiProperty.PortableBattery.ManufactureDate, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.ManufactureDate));
            properties.Add(DmiProperty.PortableBattery.SerialNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.SerialNumber));
            properties.Add(DmiProperty.PortableBattery.DeviceChemistry, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DeviceChemistry));
            properties.Add(DmiProperty.PortableBattery.DesignCapacity, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DesignCapacity));
            properties.Add(DmiProperty.PortableBattery.DesignCapacityMultiplier, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DesignCapacityMultiplier));
        }

        if (SmbiosStructure.StructureInfo.Length >= 0x17)
        {
            properties.Add(DmiProperty.PortableBattery.OemSpecific, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.OemSpecific));
        }
    }
}
