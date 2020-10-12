
namespace iTin.Hardware.Specification.Dmi
{
    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

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
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                properties.Add(DmiProperty.MemoryDevice.PhysicalMemoryArrayHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.PhysicalMemoryArrayHandle));

                ushort memoryErrorInformationHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.MemoryErrorInformationHandle);
                switch (memoryErrorInformationHandle)
                {
                    case 0xffff:
                        properties.Add(DmiProperty.MemoryDevice.MemoryErrorInformationHandle, -1);
                        break;

                    case 0xfffe:
                        properties.Add(DmiProperty.MemoryDevice.MemoryErrorInformationHandle, -2);
                        break;

                    default:
                        properties.Add(DmiProperty.MemoryDevice.MemoryErrorInformationHandle, memoryErrorInformationHandle);
                        break;
                }

                ushort totalWidth = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.TotalWidth);
                if (totalWidth != 0xffff)
                {
                    properties.Add(DmiProperty.MemoryDevice.TotalWidth, totalWidth);
                }

                ushort dataWidth = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.DataWidth);
                if (dataWidth != 0xffff)
                {
                    properties.Add(DmiProperty.MemoryDevice.DataWidth, dataWidth);
                }

                ushort size = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.Size);
                if (size == 0x0000)
                {
                    // No memory device installed
                }
                else if (size == 0xffff)
                {
                    // size is unknown.
                }
                else if (size != 0x7fff)
                {
                    bool sizeIsMeasuredInKb = IsMeasuredInKb(size);
                    if (!sizeIsMeasuredInKb)
                    {
                        size <<= 0x0a;
                    }

                    properties.Add(DmiProperty.MemoryDevice.Size, size);
                }
                else
                {
                    if (ImplementedVersion >= DmiStructureVersion.v27)
                    {
                        uint extendedSize = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryDevice.ExtendedSize);
                        properties.Add(DmiProperty.MemoryDevice.Size, extendedSize << 0x0a);
                    }
                }

                properties.Add(DmiProperty.MemoryDevice.FormFactor, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.FormFactor));
                properties.Add(DmiProperty.MemoryDevice.DeviceSet, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.DeviceSet));
                properties.Add(DmiProperty.MemoryDevice.DeviceLocator, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.DeviceLocator));
                properties.Add(DmiProperty.MemoryDevice.BankLocator, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.BankLocator));
                properties.Add(DmiProperty.MemoryDevice.MemoryType, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryType));
                properties.Add(DmiProperty.MemoryDevice.TypeDetail, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.TypeDetail));
            }

            if (ImplementedVersion >= DmiStructureVersion.v23)
            {
                ushort maximunSpeed = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.Speed);
                if (maximunSpeed != 0x0000)
                {
                    properties.Add(DmiProperty.MemoryDevice.Speed, maximunSpeed);
                }

                properties.Add(DmiProperty.MemoryDevice.Manufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.Manufacturer));
                properties.Add(DmiProperty.MemoryDevice.SerialNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.SerialNumber));
                properties.Add(DmiProperty.MemoryDevice.AssetTag, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.AssetTag));
                properties.Add(DmiProperty.MemoryDevice.PartNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.PartNumber));
            }

            if (ImplementedVersion >= DmiStructureVersion.v26)
            {
                byte rank = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.MemoryDevice.Rank);
                if (rank != 0x00)
                {
                    properties.Add(DmiProperty.MemoryDevice.Rank, rank);
                }
            }

            if (ImplementedVersion >= DmiStructureVersion.v27)
            {
                ushort currentSpeed = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.ConfiguredMemoryClockSpeed);
                if (currentSpeed != 0x0000)
                {
                    properties.Add(DmiProperty.MemoryDevice.ConfiguredMemoryClockSpeed, currentSpeed);
                }
            }

            if (ImplementedVersion >= DmiStructureVersion.v28)
            {
                ushort minimunVoltage = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.MinimumVoltage);
                if (minimunVoltage != 0x0000)
                {
                    properties.Add(DmiProperty.MemoryDevice.MinimumVoltage, minimunVoltage);
                }

                ushort maximumVoltage = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.MaximumVoltage);
                if (maximumVoltage != 0x0000)
                {
                    properties.Add(DmiProperty.MemoryDevice.MaximumVoltage, maximumVoltage);
                }

                ushort configuredVoltage = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.MemoryDevice.ConfiguredVoltage);
                if (configuredVoltage != 0x0000)
                {
                    properties.Add(DmiProperty.MemoryDevice.ConfiguredVoltage, configuredVoltage);
                }
            }

            if (ImplementedVersion >= DmiStructureVersion.v32)
            {
                properties.Add(DmiProperty.MemoryDevice.MemoryTechnology, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryTechnology));
                properties.Add(DmiProperty.MemoryDevice.MemoryOperatingModeCapability, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemoryOperatingModeCapability));
                properties.Add(DmiProperty.MemoryDevice.FirmwareVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.FirmwareVersion));
                properties.Add(DmiProperty.MemoryDevice.ModuleManufacturerId, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ModuleManufacturerId));
                properties.Add(DmiProperty.MemoryDevice.ModuleProductId, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ModuleProductId));
                properties.Add(DmiProperty.MemoryDevice.MemorySubsystemControllerManufacturerId, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemorySubsystemControllerManufacturerId));
                properties.Add(DmiProperty.MemoryDevice.MemorySubsystemControllerProductId, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.MemorySubsystemControllerProductId));
                properties.Add(DmiProperty.MemoryDevice.NonVolatileSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.NonVolatileSize));
                properties.Add(DmiProperty.MemoryDevice.VolatileSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.VolatileSize));
                properties.Add(DmiProperty.MemoryDevice.CacheSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.CacheSize));
                properties.Add(DmiProperty.MemoryDevice.LogicalSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.LogicalSize));
            }

            if (ImplementedVersion >= DmiStructureVersion.v33)
            {
                properties.Add(DmiProperty.MemoryDevice.ExtendedSpeed, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ExtendedSpeed));
                properties.Add(DmiProperty.MemoryDevice.ExtendedConfiguredMemorySpeed, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDevice.ExtendedConfiguredMemorySpeed));
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsMeasuredInKb(int): Gets a value that indicates whether the memory is measured in KB
        /// <summary>
        /// Gets a value that indicates whether the memory is measured in KB.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// <b>true</b> if memory is measured in KB;<b>false</b> otherwise.
        /// </returns>
        private static bool IsMeasuredInKb(int code) => code.CheckBit(Bits.Bit15);
        #endregion

        #endregion
    }
}
