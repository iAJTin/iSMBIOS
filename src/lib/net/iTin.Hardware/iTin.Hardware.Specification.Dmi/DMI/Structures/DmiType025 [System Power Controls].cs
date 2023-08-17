﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Power Controls (Type 25) structure.<br/>
/// For more information, please see <see cref="SmbiosType025"/>.
/// </summary>
internal sealed class DmiType025 : DmiBaseType<SmbiosType025>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType025"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType025(SmbiosType025 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.SystemPowerControls.Month, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Month));
        properties.Add(DmiProperty.SystemPowerControls.Day, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Day));
        properties.Add(DmiProperty.SystemPowerControls.Hour, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Hour));
        properties.Add(DmiProperty.SystemPowerControls.Minute, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Minute));
        properties.Add(DmiProperty.SystemPowerControls.Second, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Second));
    }
}
