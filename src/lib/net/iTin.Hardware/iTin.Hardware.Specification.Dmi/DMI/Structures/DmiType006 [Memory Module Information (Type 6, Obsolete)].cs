﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Module Information (Type 6, Obsolete) structure.<br/>
/// For more information, please see <see cref="SmbiosType006"/>.
/// </summary>
internal sealed class DmiType006 : DmiBaseType<SmbiosType006>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType006"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType006(SmbiosType006 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.MemoryModule.SocketDesignation, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.SocketDesignation));
        properties.Add(DmiProperty.MemoryModule.BankConnections, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.BankConnections));

        object currentSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.CurrentSpeed);
        if (currentSpeedProperty != null)
        {
            byte currentSpeed = (byte)currentSpeedProperty;
            if (currentSpeed != 0x00)
            {
                properties.Add(DmiProperty.MemoryModule.CurrentSpeed, currentSpeed);
            }
        }

        properties.Add(DmiProperty.MemoryModule.CurrentMemoryType, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.CurrentMemoryType));
        properties.Add(DmiProperty.MemoryModule.InstalledSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.InstalledSize));
        properties.Add(DmiProperty.MemoryModule.EnabledSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.EnabledSize));
        properties.Add(DmiProperty.MemoryModule.ErrorStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.ErrorStatus));
    }
}
