
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Device (Type 17) structure.
    /// For more information, please see <see cref="SmbiosType017"/>.
    /// </summary>
    internal sealed class DmiType017 : DmiBaseType<SmbiosType017>
    {
        #region constructor/s

        #region [public] DmiType017(SmbiosType017, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType017"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType017(SmbiosType017 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(DmiClassPropertiesTable properties)
        {
            #region 2.1+
            object physicalMemoryArrayHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.PhysicalMemoryArrayHandle);
            if (physicalMemoryArrayHandle != null)
            {
                properties.Add(DmiProperty.MemoryDevice.PhysicalMemoryArrayHandle, physicalMemoryArrayHandle);
            }

            object memoryErrorInformationHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryErrorInformationHandle);
            if (memoryErrorInformationHandle != null)
            {
                properties.Add(DmiProperty.MemoryDevice.MemoryErrorInformationHandle, memoryErrorInformationHandle);
            }

            object totalWidthProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.TotalWidth);
            if (totalWidthProperty != null)
            {
                int totalWidth = (int)totalWidthProperty;
                if (totalWidth != 0xffff)
                {
                    properties.Add(DmiProperty.MemoryDevice.TotalWidth, totalWidth);
                }
            }

            object dataWidthProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.DataWidth);
            if (dataWidthProperty != null)
            {
                int dataWidth = (int)dataWidthProperty;
                if (dataWidth != 0xffff)
                {
                    properties.Add(DmiProperty.MemoryDevice.DataWidth, dataWidth);
                }
            }

            object size = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.Size);
            if (size != null)
            {
                properties.Add(DmiProperty.MemoryDevice.Size, size);
            }

            object formFactor = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.FormFactor);
            if (formFactor != null)
            {
                properties.Add(DmiProperty.MemoryDevice.FormFactor, formFactor);
            }

            object deviceSet = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.DeviceSet);
            if (deviceSet != null)
            {
                properties.Add(DmiProperty.MemoryDevice.DeviceSet, deviceSet);
            }

            object deviceLocator = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.DeviceLocator);
            if (deviceLocator != null)
            {
                properties.Add(DmiProperty.MemoryDevice.DeviceLocator, deviceLocator);
            }

            object bankLabel = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.BankLabel);
            if (bankLabel != null)
            {
                properties.Add(DmiProperty.MemoryDevice.BankLabel, bankLabel);
            }

            object memoryType = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryType);
            if (memoryType != null)
            {
                properties.Add(DmiProperty.MemoryDevice.MemoryType, memoryType);
            }

            object typeDetail = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.TypeDetail);
            if (typeDetail != null)
            {
                properties.Add(DmiProperty.MemoryDevice.TypeDetail, typeDetail);
            }
            #endregion

            #region 2.3+
            if (SmbiosStructure.StructureInfo.Length >= 0x16)
            {
                object maximunSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MaximunSpeed);
                if (maximunSpeedProperty != null)
                {
                    int maximunSpeed = (int)maximunSpeedProperty;
                    if (maximunSpeed != 0x00)
                    {
                        properties.Add(DmiProperty.MemoryDevice.MaximunSpeed, maximunSpeed);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x18)
            {
                object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.Manufacturer);
                if (manufacturer != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.Manufacturer, manufacturer);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x19)
            {
                object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.SerialNumber);
                if (serialNumber != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.SerialNumber, serialNumber);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x1a)
            {
                object assetTag = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.AssetTag);
                if (assetTag != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.AssetTag, assetTag);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x1b)
            {
                object partNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.PartNumber);
                if (partNumber != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.PartNumber, partNumber);
                }
            }
            #endregion

            #region 2.6+
            if (SmbiosStructure.StructureInfo.Length >= 0x1c)
            {
                object rankProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.Rank);
                if (rankProperty != null)
                {
                    byte rank = (byte)rankProperty;
                    if (rank != 0x00)
                    {
                        properties.Add(DmiProperty.MemoryDevice.Rank, rank);
                    }
                }
            }
            #endregion

            #region 2.7+
            if (SmbiosStructure.StructureInfo.Length >= 0x21)
            {
                object currentSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ConfiguredMemoryClockSpeed);
                if (currentSpeedProperty != null)
                {
                    int currentSpeed = (int)currentSpeedProperty;
                    if (currentSpeed != 0x0000)
                    {
                        properties.Add(DmiProperty.MemoryDevice.ConfiguredMemoryClockSpeed, currentSpeed);
                    }
                }
            }
            #endregion

            #region 2.8+
            if (SmbiosStructure.StructureInfo.Length >= 0x23)
            {
                object minimunVoltageProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MinimunVoltage);
                if (minimunVoltageProperty != null)
                {
                    int minimunVoltage = (int)minimunVoltageProperty;
                    if (minimunVoltage != 0x0000)
                    {
                        properties.Add(DmiProperty.MemoryDevice.MinimunVoltage, minimunVoltage);
                    }
                }

                object maximumVoltageProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MaximumVoltage);
                if (maximumVoltageProperty != null)
                {
                    int maximumVoltage = (int)maximumVoltageProperty;
                    if (maximumVoltage != 0x0000)
                    {
                        properties.Add(DmiProperty.MemoryDevice.MaximumVoltage, maximumVoltage);
                    }
                }

                object configuredVoltageProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ConfiguredVoltage);
                if (configuredVoltageProperty != null)
                {
                    int configuredVoltage = (int)configuredVoltageProperty;
                    if (configuredVoltage != 0x0000)
                    {
                        properties.Add(DmiProperty.MemoryDevice.ConfiguredVoltage, configuredVoltage);
                    }
                }
            }
            #endregion

            #region 3.2+
            if (SmbiosStructure.StructureInfo.Length >= 0x29)
            {
                object memoryTechnology = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryTechnology);
                if (memoryTechnology != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.MemoryTechnology, memoryTechnology);
                }

                object memoryOperatingModeCapability = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryOperatingModeCapability);
                if (memoryOperatingModeCapability != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.MemoryOperatingModeCapability, memoryOperatingModeCapability);
                }

                object firmwareVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.FirmwareVersion);
                if (firmwareVersion != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.FirmwareVersion, firmwareVersion);
                }

                object moduleManufacturerId = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ModuleManufacturerId);
                if (moduleManufacturerId != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.ModuleManufacturerId, moduleManufacturerId);
                }

                object moduleProductId = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ModuleProductId);
                if (moduleProductId != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.ModuleProductId, moduleProductId);
                }

                object memorySubsystemControllerManufacturerId = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemorySubsystemControllerManufacturerId);
                if (memorySubsystemControllerManufacturerId != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.MemorySubsystemControllerManufacturerId, memorySubsystemControllerManufacturerId);
                }

                object memorySubsystemControllerProductId = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemorySubsystemControllerProductId);
                if (memorySubsystemControllerProductId != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.MemorySubsystemControllerProductId, memorySubsystemControllerProductId);
                }

                object nonVolatileSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.NonVolatileSize);
                if (nonVolatileSize != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.NonVolatileSize, nonVolatileSize);
                }

                object volatileSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.VolatileSize);
                if (volatileSize != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.VolatileSize, volatileSize);
                }

                object cacheSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.CacheSize);
                if (cacheSize != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.CacheSize, cacheSize);
                }

                object logicalSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.LogicalSize);
                if (logicalSize != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.LogicalSize, logicalSize);
                }
            }
            #endregion

            #region 3.3+
            if (SmbiosStructure.StructureInfo.Length >= 0x55)
            {
                object extendedSpeed = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ExtendedSpeed);
                if (extendedSpeed != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.ExtendedSpeed, extendedSpeed);
                }

                object extendedConfiguredMemorySpeed = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ExtendedConfiguredMemorySpeed);
                if (extendedConfiguredMemorySpeed != null)
                {
                    properties.Add(DmiProperty.MemoryDevice.ExtendedConfiguredMemorySpeed, extendedConfiguredMemorySpeed);
                }
            }
            #endregion
        }
        #endregion
    
        #endregion
    }
}
