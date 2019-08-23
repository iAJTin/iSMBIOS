
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Portable Battery (Type 22) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022" />.
    /// </summary>
    internal sealed class DmiType022 : DmiBaseType<SmbiosType022>
    {
        #region constructor/s

        #region [public] DmiType022(SmbiosType022, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType022" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType022(SmbiosType022 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            if (SmbiosStructure.StructureInfo.Length >= 0x05)
            {
                object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.Location);
                if (location != null)
                {
                    properties.Add(DmiProperty.PortableBattery.Location, location);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x06)
            {
                object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.Manufacturer);
                if (manufacturer != null)
                {
                    properties.Add(DmiProperty.PortableBattery.Manufacturer, manufacturer);
                }
            }

            object manufactureDate = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.ManufactureDate);
            if (manufactureDate != null)
            {
                properties.Add(DmiProperty.PortableBattery.ManufactureDate, manufactureDate);
            }

            object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.SerialNumber);
            if (serialNumber != null)
            {
                properties.Add(DmiProperty.PortableBattery.SerialNumber, serialNumber);
            }

            object deviceName = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DeviceName);
            if (serialNumber != null)
            {
                properties.Add(DmiProperty.PortableBattery.DeviceName, deviceName);
            }

            object deviceChemistry = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DeviceChemistry);
            if (deviceChemistry != null)
            {
                properties.Add(DmiProperty.PortableBattery.DeviceChemistry, deviceChemistry);
            }

            object designCapacity = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DesignCapacity);
            if (deviceChemistry != null)
            {
                properties.Add(DmiProperty.PortableBattery.DesignCapacity, designCapacity);
            }

            object designVoltageProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.DesignVoltage);
            if (designVoltageProperty != null)
            {
                int designVoltage = (int)designVoltageProperty;
                if (designVoltage != 0x0000)
                {
                    properties.Add(DmiProperty.PortableBattery.DesignVoltage, designVoltage);
                }
            }

            object sbdsVersionNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.SBDSVersionNumber);
            if (sbdsVersionNumber != null)
            {
                properties.Add(DmiProperty.PortableBattery.SBDSVersionNumber, sbdsVersionNumber);
            }

            object maximumErrorInBatteryDataProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.MaximunErrorInBatteryData);
            if (maximumErrorInBatteryDataProperty != null)
            {
                byte maximumErrorInBatteryData = (byte)maximumErrorInBatteryDataProperty;
                if (maximumErrorInBatteryData != 0xff)
                {
                    properties.Add(DmiProperty.PortableBattery.MaximunErrorInBatteryData, maximumErrorInBatteryData);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x17)
            {
                object oemSpecific = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortableBattery.OemSpecific);
                if (oemSpecific != null)
                {
                    properties.Add(DmiProperty.PortableBattery.OemSpecific, oemSpecific);
                }
            }
        }
        #endregion

        #endregion
    }
}
