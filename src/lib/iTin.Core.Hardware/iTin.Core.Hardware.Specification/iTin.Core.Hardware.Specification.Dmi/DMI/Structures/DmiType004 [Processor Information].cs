
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Processor Information (Type 4) structure.
    /// For more information, please see <see cref="SmbiosType004"/>.
    /// </summary>
    internal sealed class DmiType004 : DmiBaseType<SmbiosType004>
    {
        #region constructor/s

        #region [public] DmiType004(SmbiosType004, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType004"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType004(SmbiosType004 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0+
            if (SmbiosVersion >= 0x0200)
            {
                object socketDesignation = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.SocketDesignation);
                if (socketDesignation != null)
                {
                    properties.Add(DmiProperty.Processor.SocketDesignation, socketDesignation);
                }

                object processorType = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorType);
                if (processorType != null)
                {
                    properties.Add(DmiProperty.Processor.ProcessorType, processorType);
                }

                object processorVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorVersion);
                if (processorVersion != null)
                {
                    properties.Add(DmiProperty.Processor.ProcessorVersion, processorVersion);
                }

                object family = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Family);
                if (family != null)
                {
                    properties.Add(DmiProperty.Processor.Family, family);
                }

                object processorManufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorManufacturer);
                if (processorManufacturer != null)
                {
                    properties.Add(DmiProperty.Processor.ProcessorManufacturer, processorManufacturer);
                }

                object processorId = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorId);
                if (processorId != null)
                {
                    properties.Add(DmiProperty.Processor.ProcessorId, processorId);
                }

                object isLegacyMode = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Voltage.IsLegacyMode);
                if (isLegacyMode != null)
                {
                    properties.Add(DmiProperty.Processor.Voltage.IsLegacyMode, isLegacyMode);
                }

                object supportedVoltages = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Voltage.SupportedVoltages);
                if (supportedVoltages != null)
                {
                    properties.Add(DmiProperty.Processor.Voltage.SupportedVoltages, supportedVoltages);
                }

                object externakClockProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ExternalClock);
                if (externakClockProperty != null)
                {
                    int externakClock = (int)externakClockProperty;
                    if (externakClock != 0x00)
                    {
                        properties.Add(DmiProperty.Processor.ExternalClock, externakClock);
                    }
                }

                object maxSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.MaximunSpeed);
                if (maxSpeedProperty != null)
                {
                    int maxSpeed = (int)maxSpeedProperty;
                    if (maxSpeed != 0x00)
                    {
                        properties.Add(DmiProperty.Processor.MaximumSpeed, maxSpeed);
                    }
                }

                object currentSpeed = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CurrentSpeed);
                if (currentSpeed != null)
                {
                    properties.Add(DmiProperty.Processor.CurrentSpeed, currentSpeed);
                }

                object cpuStatus = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Status.CpuStatus);
                if (cpuStatus != null)
                {
                    properties.Add(DmiProperty.Processor.Status.CpuStatus, cpuStatus);
                }

                object socketPopulated = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Status.SocketPopulated);
                if (socketPopulated != null)
                {
                    properties.Add(DmiProperty.Processor.Status.SocketPopulated, socketPopulated);
                }

                object upgradeMethod = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.UpgradeMethod);
                if (upgradeMethod != null)
                {
                    properties.Add(DmiProperty.Processor.UpgradeMethod, upgradeMethod);
                }
            }
            #endregion

            #region 2.1+
            if (SmbiosVersion >= 0x0201)
            {
                object l1CacheHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L1CacheHandle);
                if (l1CacheHandle != null)
                {
                    properties.Add(DmiProperty.Processor.L1CacheHandle, l1CacheHandle);
                }

                object l2CacheHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L2CacheHandle);
                if (l2CacheHandle != null)
                {
                    properties.Add(DmiProperty.Processor.L2CacheHandle, l2CacheHandle);
                }

                object l3CacheHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L3CacheHandle);
                if (l3CacheHandle != null)
                {
                    properties.Add(DmiProperty.Processor.L3CacheHandle, l3CacheHandle);
                }
            }
            #endregion

            #region 2.3+
            if (SmbiosStructure.StructureInfo.Length >= 0x21)
            {
                object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.SerialNumber);
                if (serialNumber != null)
                {
                    properties.Add(DmiProperty.Processor.SerialNumber, serialNumber);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x22)
            {
                object assetTag = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.AssetTag);
                if (assetTag != null)
                {
                    properties.Add(DmiProperty.Processor.AssetTag, assetTag);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x23)
            {
                object partNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.PartNumber);
                if (partNumber != null)
                {
                    properties.Add(DmiProperty.Processor.PartNumber, partNumber);
                }
            }
            #endregion

            #region 2.5+
            if (SmbiosStructure.StructureInfo.Length >= 0x24)
            {
                object coreCount = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CoreCount);
                if (coreCount != null)
                {
                    properties.Add(DmiProperty.Processor.CoreCount, coreCount);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x25)
            {
                object coreEnabled = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CoreEnabled);
                if (coreEnabled != null)
                {
                    properties.Add(DmiProperty.Processor.CoreEnabled, coreEnabled);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x26)
            {
                object threadCount = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ThreadCount);
                if (threadCount != null)
                {
                    properties.Add(DmiProperty.Processor.ThreadCount, threadCount);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x27)
            {
                object capable64Bits = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.Capable64Bits);
                if (capable64Bits != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.Capable64Bits, capable64Bits);
                }

                object multiCore = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.MultiCore);
                if (multiCore != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.MultiCore, multiCore);
                }

                object hardwareThreadPerCore = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.HardwareThreadPerCore);
                if (hardwareThreadPerCore != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.HardwareThreadPerCore, hardwareThreadPerCore);
                }

                object executeProtectionSupport = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.ExecuteProtectionSupport);
                if (executeProtectionSupport != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.ExecuteProtectionSupport, executeProtectionSupport);
                }

                object enhancedVirtualizationInstructions = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.EnhancedVirtualizationInstructions);
                if (enhancedVirtualizationInstructions != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.EnhancedVirtualizationInstructions, enhancedVirtualizationInstructions);
                }

                object powerPerformanceControlSupport = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.PowerPerformanceControlSupport);
                if (powerPerformanceControlSupport != null)
                {
                    properties.Add(DmiProperty.Processor.Characteristics.PowerPerformanceControlSupport, powerPerformanceControlSupport);
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
