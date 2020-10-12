
namespace iTin.Hardware.Specification.Dmi
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
            if (ImplementedVersion >= DmiStructureVersion.v20)
            {
                properties.Add(DmiProperty.Processor.SocketDesignation, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.SocketDesignation));
                properties.Add(DmiProperty.Processor.ProcessorType, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorType));
                properties.Add(DmiProperty.Processor.ProcessorVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorVersion));
                properties.Add(DmiProperty.Processor.Family, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Family));
                properties.Add(DmiProperty.Processor.ProcessorManufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorManufacturer));
                properties.Add(DmiProperty.Processor.ProcessorId, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ProcessorId));
                properties.Add(DmiProperty.Processor.Voltage.IsLegacyMode, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Voltage.IsLegacyMode));
                properties.Add(DmiProperty.Processor.Voltage.SupportedVoltages, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Voltage.SupportedVoltages));

                object externakClockProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ExternalClock);
                ushort externakClock = (ushort)externakClockProperty;
                if (externakClock != 0x00)
                {
                    properties.Add(DmiProperty.Processor.ExternalClock, externakClock);
                }

                object maxSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.MaximunSpeed);
                ushort maxSpeed = (ushort)maxSpeedProperty;
                if (maxSpeed != 0x00)
                {
                    properties.Add(DmiProperty.Processor.MaximumSpeed, maxSpeed);
                }

                properties.Add(DmiProperty.Processor.CurrentSpeed, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CurrentSpeed));
                properties.Add(DmiProperty.Processor.Status.CpuStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Status.CpuStatus));
                properties.Add(DmiProperty.Processor.Status.SocketPopulated, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Status.SocketPopulated));
                properties.Add(DmiProperty.Processor.UpgradeMethod, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.UpgradeMethod));
            }
            #endregion

            #region 2.1+
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                properties.Add(DmiProperty.Processor.L1CacheHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L1CacheHandle));
                properties.Add(DmiProperty.Processor.L2CacheHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L2CacheHandle));
                properties.Add(DmiProperty.Processor.L3CacheHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.L3CacheHandle));
            }
            #endregion

            #region 2.3+
            if (ImplementedVersion >= DmiStructureVersion.v23)
            {
                properties.Add(DmiProperty.Processor.SerialNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.SerialNumber));
                properties.Add(DmiProperty.Processor.AssetTag, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.AssetTag));
                properties.Add(DmiProperty.Processor.PartNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.PartNumber));
            }
            #endregion

            #region 2.5+
            if (ImplementedVersion >= DmiStructureVersion.v25)
            {
                properties.Add(DmiProperty.Processor.CoreCount, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CoreCount));
                properties.Add(DmiProperty.Processor.CoreEnabled, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.CoreEnabled));
                properties.Add(DmiProperty.Processor.ThreadCount, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.ThreadCount));
                properties.Add(DmiProperty.Processor.Characteristics.Arm64SocIdSupported, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.Arm64SocIdSupported));
                properties.Add(DmiProperty.Processor.Characteristics.Capable64Bits, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.Capable64Bits));
                properties.Add(DmiProperty.Processor.Characteristics.Capable128Bits, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.Capable128Bits));
                properties.Add(DmiProperty.Processor.Characteristics.MultiCore, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.MultiCore));
                properties.Add(DmiProperty.Processor.Characteristics.HardwareThreadPerCore, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.HardwareThreadPerCore));
                properties.Add(DmiProperty.Processor.Characteristics.ExecuteProtectionSupport, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.ExecuteProtectionSupport));
                properties.Add(DmiProperty.Processor.Characteristics.EnhancedVirtualizationInstructions, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.EnhancedVirtualizationInstructions));
                properties.Add(DmiProperty.Processor.Characteristics.PowerPerformanceControlSupport, SmbiosStructure.GetPropertyValue(SmbiosProperty.Processor.Characteristics.PowerPerformanceControlSupport));
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
