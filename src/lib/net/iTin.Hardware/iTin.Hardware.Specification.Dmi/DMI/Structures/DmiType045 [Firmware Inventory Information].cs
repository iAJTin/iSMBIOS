﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Firmware Inventory Information (Type 45) structure.<br/>
/// For more information, please see <see cref="SmbiosType045"/>.
/// </summary>
internal sealed class DmiType045: DmiBaseType<SmbiosType045>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType045"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType045(SmbiosType045 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        #region version 3.5
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareComponentName, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareComponentName));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareVersion));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareVersionFormat, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareVersionFormat));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareId, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareId));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareIdFormat, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareIdFormat));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareReleaseDate, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareReleaseDate));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareManufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareManufacturer));
        properties.Add(DmiProperty.FirmwareInventoryInformation.LowestSupportedFirmwareVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.LowestSupportedFirmwareVersion));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareImageSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareImageSize));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareCharacteristics, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareCharacteristics));
        properties.Add(DmiProperty.FirmwareInventoryInformation.FirmwareState, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.FirmwareState));

        var numberOfAssociatedComponents = (byte)SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.NumberOfAssociatedComponents);
        properties.Add(DmiProperty.FirmwareInventoryInformation.NumberOfAssociatedComponents, numberOfAssociatedComponents);
        if (numberOfAssociatedComponents != 0)
        {
            properties.Add(DmiProperty.FirmwareInventoryInformation.AssociatedComponentHandles, SmbiosStructure.GetPropertyValue(SmbiosProperty.FirmwareInventoryInformation.AssociatedComponentHandles));

        }
        #endregion
    }
}
