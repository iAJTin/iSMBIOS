
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the System Power Supply (Type 39) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039" />.
    /// </summary>
    internal sealed class DmiType039 : DmiBaseType<SmbiosType039>
    {
        #region constructor/s

        #region [public] DmiType039(SmbiosType039, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType039" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType039(SmbiosType039 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(DmiClassPropertiesTable properties)
        {
            object isRedundant = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.IsRedundant);
            if (isRedundant != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.IsRedundant, isRedundant);
            }

            object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Location);
            if (location != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Location, location);
            }

            object deviceName = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.DeviceName);
            if (deviceName != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.DeviceName, deviceName);
            }

            object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Manufacturer);
            if (manufacturer != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Manufacturer, manufacturer);
            }

            object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.SerialNumber);
            if (serialNumber != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.SerialNumber, serialNumber);
            }

            object assetTagNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.AssetTagNumber);
            if (assetTagNumber != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.AssetTagNumber, assetTagNumber);
            }

            object modelPartNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.ModelPartNumber);
            if (modelPartNumber != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.ModelPartNumber, modelPartNumber);
            }

            object revisionLevel = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.RevisionLevel);
            if (revisionLevel != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.RevisionLevel, revisionLevel);
            }

            object maxPowerCapacityProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.MaxPowerCapacity);
            if (maxPowerCapacityProperty != null)
            {
                int maxPowerCapacity = (int) maxPowerCapacityProperty;
                if (maxPowerCapacity != 0x8000)
                {
                    properties.Add(DmiProperty.SystemPowerSupply.MaxPowerCapacity, maxPowerCapacity);
                }
            }

            object supplyType = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.SupplyType);
            if (supplyType != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.SupplyType, supplyType);
            }

            object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.Status);
            if (status != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.Status, status);
            }

            object inputVoltageRange = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.InputVoltageRange);
            if (inputVoltageRange != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.InputVoltageRange, inputVoltageRange);
            }

            object isPlugged = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsPlugged);
            if (isPlugged != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsPlugged, isPlugged);
            }

            object isPresent = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsPresent);
            if (isPresent != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsPresent, isPresent);
            }

            object isHotReplaceable = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.Characteristics.IsHotReplaceable);
            if (isHotReplaceable != null)
            {
                properties.Add(DmiProperty.SystemPowerSupply.Characteristics.IsHotReplaceable, isHotReplaceable);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x11)
            {
                object inputVoltageProbeHandleProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.InputVoltageProbeHandle);
                if (inputVoltageProbeHandleProperty != null)
                {
                    int inputVoltageProbeHandle = (int) inputVoltageProbeHandleProperty;
                    if (inputVoltageProbeHandle != 0xffff)
                    {
                        properties.Add(DmiProperty.SystemPowerSupply.InputVoltageProbeHandle, inputVoltageProbeHandle);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x13)
            {
                object coolingDeviceHandleProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.CoolingDeviceHandle);
                if (coolingDeviceHandleProperty != null)
                {
                    int coolingDeviceHandle = (int) coolingDeviceHandleProperty;
                    if (coolingDeviceHandle != 0xffff)
                    {
                        properties.Add(DmiProperty.SystemPowerSupply.CoolingDeviceHandle, coolingDeviceHandle);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x15)
            {
                object inputCurrentProbeHandleProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerSupply.InputCurrentProbeHandle);
                if (inputCurrentProbeHandleProperty != null)
                {
                    int inputCurrentProbeHandle = (int) inputCurrentProbeHandleProperty;
                    if (inputCurrentProbeHandle != 0xffff)
                    {
                        properties.Add(DmiProperty.SystemPowerSupply.InputCurrentProbeHandle, inputCurrentProbeHandle);
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
