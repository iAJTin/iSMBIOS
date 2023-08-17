
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Cooling Device (Type 27) structure.<br/>
/// For more information, please see <see cref="SmbiosType027"/>.
/// </summary>
internal sealed class DmiType027: DmiBaseType<SmbiosType027>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType027"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType027(SmbiosType027 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion > DmiStructureVersion.v22)
        {
            ushort temperatureProbeHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.CoolingDevice.TemperatureProbeHandle);
            if (temperatureProbeHandle != 0x8000)
            {
                properties.Add(DmiProperty.CoolingDevice.TemperatureProbeHandle, temperatureProbeHandle);
            }

            properties.Add(DmiProperty.CoolingDevice.DeviceTypeAndStatus.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.Status));
            properties.Add(DmiProperty.CoolingDevice.DeviceTypeAndStatus.DeviceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.DeviceType));

            byte coolingUnitGroup = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.CoolingDevice.CoolingUnitGroup);
            if (coolingUnitGroup != 0x00)
            {
                properties.Add(DmiProperty.CoolingDevice.CoolingUnitGroup, coolingUnitGroup);
            }

            properties.Add(DmiProperty.CoolingDevice.OemDefined, SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.OemDefined));

            object nominalSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.NominalSpeed);
            if (nominalSpeedProperty != null)
            {
                ushort nominalSpeed = (ushort)nominalSpeedProperty;
                if (nominalSpeed != 0x8000)
                {
                    properties.Add(DmiProperty.CoolingDevice.NominalSpeed, nominalSpeed);
                }
            }
        }

        if (ImplementedVersion > DmiStructureVersion.v27)
        {
            properties.Add(DmiProperty.CoolingDevice.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.Description));
        }
    }
}
