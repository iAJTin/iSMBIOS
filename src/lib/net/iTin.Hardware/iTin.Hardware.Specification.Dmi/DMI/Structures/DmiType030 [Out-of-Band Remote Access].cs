﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Out-of-Band Remote Access (Type 30) structure.<br/>
/// For more information, please see <see cref="SmbiosType030"/>.
/// </summary>
internal sealed class DmiType030 : DmiBaseType<SmbiosType030>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType030"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType030(SmbiosType030 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.OutOfBandRemote.Manufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Manufacturer));
        properties.Add(DmiProperty.OutOfBandRemote.Connections.OutBoundConnection, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Connections.OutBoundConnection));
        properties.Add(DmiProperty.OutOfBandRemote.Connections.InBoundConnection, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Connections.InBoundConnection));
    }
}
