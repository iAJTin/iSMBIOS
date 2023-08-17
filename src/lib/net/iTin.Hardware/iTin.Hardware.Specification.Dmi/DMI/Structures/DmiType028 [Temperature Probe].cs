﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Temperature Probe (Type 28) structure.<br/>
/// For more information, please see <see cref="SmbiosType028"/>.
/// </summary>
internal sealed class DmiType028 : DmiBaseType<SmbiosType028>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType028"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType028(SmbiosType028 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion >= DmiStructureVersion.Latest)
        {
            properties.Add(DmiProperty.TemperatureProbe.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.Description));
            properties.Add(DmiProperty.TemperatureProbe.LocationAndStatus.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.LocationAndStatus.Status));
            properties.Add(DmiProperty.TemperatureProbe.LocationAndStatus.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.LocationAndStatus.Location));

            ushort maximumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.MaximumValue);
            if (maximumValue != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.MaximumValue, maximumValue);
            }

            ushort minimumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.MinimumValue);
            if (minimumValue != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.MinimumValue, minimumValue);
            }

            ushort resolution = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.Resolution);
            if (resolution != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Resolution, resolution);
            }

            ushort tolerance = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.Tolerance);
            if (tolerance != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Tolerance, tolerance);
            }

            ushort accuracy = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.Accuracy);
            if (accuracy != 0x8000)
            {
                properties.Add(DmiProperty.TemperatureProbe.Accuracy, accuracy);
            }

            properties.Add(DmiProperty.TemperatureProbe.OemDefined, SmbiosStructure.GetPropertyValue(SmbiosProperty.TemperatureProbe.OemDefined));
        }

        if (SmbiosStructure.StructureInfo.Length < 0x15)
        {
            return;
        }

        ushort nominalValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.TemperatureProbe.NominalValue);
        if (nominalValue != 0x8000)
        {
            properties.Add(DmiProperty.TemperatureProbe.NominalValue, nominalValue);
        }
    }
}
