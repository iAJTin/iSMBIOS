
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Power Supply (Type 39) structure.
    /// For more information, please see <see cref="SmbiosType039"/>.
    /// </summary>
    internal sealed class DmiType039 : DmiBaseType<SmbiosType039>
    {
        #region constructor/s

        #region [public] DmiType039(SmbiosType039, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType039"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType039(SmbiosType039 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            properties.Add(DmiProperty.SystemPowerSupply.IsRedundant, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.IsRedundant));
            properties.Add(DmiProperty.SystemPowerSupply.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Location));
            properties.Add(DmiProperty.SystemPowerSupply.DeviceName, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.DeviceName));
            properties.Add(DmiProperty.SystemPowerSupply.Manufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Manufacturer));
            properties.Add(DmiProperty.SystemPowerSupply.SerialNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.SerialNumber));
            properties.Add(DmiProperty.SystemPowerSupply.AssetTagNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.AssetTagNumber));
            properties.Add(DmiProperty.SystemPowerSupply.ModelPartNumber, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.ModelPartNumber));
            properties.Add(DmiProperty.SystemPowerSupply.RevisionLevel, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.RevisionLevel));

            ushort maxPowerCapacity = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemPowerSupply.MaxPowerCapacity);
            if (maxPowerCapacity != 0x8000)
            {
                properties.Add(DmiProperty.SystemPowerSupply.MaxPowerCapacity, maxPowerCapacity);
            }

            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.SupplyType, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.SupplyType));
            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.Status));
            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.InputVoltageRange, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.InputVoltageRange));
            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsPlugged, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsPlugged));
            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsPresent, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsPresent));
            properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsHotReplaceable, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsHotReplaceable));

            if (SmbiosStructure.StructureInfo.Length >= 0x11)
            {
                ushort inputVoltageProbeHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemPowerSupply.InputVoltageProbeHandle);
                if (inputVoltageProbeHandle != 0xffff)
                {
                    properties.Add(DmiProperty.SystemPowerSupply.InputVoltageProbeHandle, inputVoltageProbeHandle);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x13)
            {
                ushort coolingDeviceHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemPowerSupply.CoolingDeviceHandle);
                if (coolingDeviceHandle != 0xffff)
                {
                    properties.Add(DmiProperty.SystemPowerSupply.CoolingDeviceHandle, coolingDeviceHandle);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x15)
            {
                ushort inputCurrentProbeHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.SystemPowerSupply.InputCurrentProbeHandle);
                if (inputCurrentProbeHandle != 0xffff)
                {
                    properties.Add(DmiProperty.SystemPowerSupply.InputCurrentProbeHandle, inputCurrentProbeHandle);
                }
            }
        }
        #endregion

        #endregion
    }
}
