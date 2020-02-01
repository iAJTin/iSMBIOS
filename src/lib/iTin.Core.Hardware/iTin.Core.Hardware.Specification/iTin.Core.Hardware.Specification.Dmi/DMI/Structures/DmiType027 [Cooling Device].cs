
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Cooling Device (Type 27) structure.
    /// For more information, please see <see cref="SmbiosType027"/>.
    /// </summary>
    internal sealed class DmiType027: DmiBaseType<SmbiosType027>
    {
        #region constructor/s

        #region [public] DmiType027(SmbiosType027, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType027"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType027(SmbiosType027 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            if (SmbiosStructure.StructureInfo.Length >= 0x05)
            {
                object temperatureProbeHandleProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.TemperatureProbeHandle);
                if (temperatureProbeHandleProperty != null)
                {
                    int temperatureProbeHandle = (int)temperatureProbeHandleProperty;
                    if (temperatureProbeHandle != 0x8000)
                    {
                        properties.Add(DmiProperty.CoolingDevice.TemperatureProbeHandle, temperatureProbeHandle);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x07)
            {
                object status = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.Status);
                if (status != null)
                {
                    properties.Add(DmiProperty.CoolingDevice.DeviceTypeAndStatus.Status, status);
                }

                object deviceType = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.DeviceType);
                if (deviceType != null)
                {
                    properties.Add(DmiProperty.CoolingDevice.DeviceTypeAndStatus.DeviceType, deviceType);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x08)
            {
                object coolingUnitGroupProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.CoolingUnitGroup);
                if (coolingUnitGroupProperty != null)
                {
                    byte coolingUnitGroup = (byte)coolingUnitGroupProperty;
                    if (coolingUnitGroup != 0x00)
                    {
                        properties.Add(DmiProperty.CoolingDevice.CoolingUnitGroup, coolingUnitGroup);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x09)
            {
                object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.OemDefined);
                if (oemDefined != null)
                {
                    properties.Add(DmiProperty.CoolingDevice.OemDefined, oemDefined);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0d)
            {
                object nominalSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.NominalSpeed);
                if (nominalSpeedProperty != null)
                {
                    int nominalSpeed = (int)nominalSpeedProperty;
                    if (nominalSpeed != 0x8000)
                    {
                        properties.Add(DmiProperty.CoolingDevice.NominalSpeed, nominalSpeed);
                    }
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x0f)
            {
                object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.CoolingDevice.Description);
                if (description != null)
                {
                    properties.Add(DmiProperty.CoolingDevice.Description, description);
                }
            }
        }
        #endregion

        #endregion
    }
}
