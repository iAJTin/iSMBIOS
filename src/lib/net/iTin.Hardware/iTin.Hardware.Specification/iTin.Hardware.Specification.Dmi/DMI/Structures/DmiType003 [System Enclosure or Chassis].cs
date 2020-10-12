
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Enclosure or Chassis (Type 3) structure.
    /// For more information, please see <see cref="SmbiosType003"/>.
    /// </summary>
    internal sealed class DmiType003 : DmiBaseType<SmbiosType003>
    {
        #region constructor/s

        #region [public] DmiType003(SmbiosType003, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType003"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType003(SmbiosType003 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
                object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.Manufacturer);
                if (manufacturer != null)
                {
                    properties.Add(DmiProperty.Chassis.Manufacturer, manufacturer);
                }

                object chassisType = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.ChassisType);
                if (chassisType != null)
                {
                    properties.Add(DmiProperty.Chassis.ChassisType, chassisType);
                }

                object locked = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.Locked);
                if (locked != null)
                {
                    properties.Add(DmiProperty.Chassis.Locked, locked);
                }

                object version = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.Version);
                if (version != null)
                {
                    properties.Add(DmiProperty.Chassis.Version, version);
                }

                object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.SerialNumber);
                if (serialNumber != null)
                {
                    properties.Add(DmiProperty.Chassis.SerialNumber, serialNumber);
                }

                object assetTagNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.AssetTagNumber);
                if (assetTagNumber != null)
                {
                    properties.Add(DmiProperty.Chassis.AssetTagNumber, assetTagNumber);
                }
            }
            #endregion

            #region 2.1+
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                object bootUpState = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.BootUpState);
                if (bootUpState != null)
                {
                    properties.Add(DmiProperty.Chassis.BootUpState, bootUpState);
                }

                object powerSupplyState = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.PowerSupplyState);
                if (powerSupplyState != null)
                {
                    properties.Add(DmiProperty.Chassis.PowerSupplyState, powerSupplyState);
                }

                object thermalState = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.ThermalState);
                if (thermalState != null)
                {
                    properties.Add(DmiProperty.Chassis.ThermalState, thermalState);
                }

                object securityStatus = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.SecurityStatus);
                if (securityStatus != null)
                {
                    properties.Add(DmiProperty.Chassis.SecurityStatus, securityStatus);
                }
            }
            #endregion

            #region 2.3+
            if (ImplementedVersion >= DmiStructureVersion.v23)
            {
                object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.OemDefined);
                if ((uint) oemDefined != 0)
                {
                    properties.Add(DmiProperty.Chassis.OemDefined, oemDefined);
                }

                object height = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.Height);
                if ((byte) height != 0)
                {
                    properties.Add(DmiProperty.Chassis.Height, height);
                }

                object numberOfPowerCords = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.NumberOfPowerCords);
                if ((byte) numberOfPowerCords != 0)
                {
                    properties.Add(DmiProperty.Chassis.NumberOfPowerCords, numberOfPowerCords);
                }

                object containedElements = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.ContainedElements);
                if (containedElements == null)
                {
                    return;
                }

                properties.Add(DmiProperty.Chassis.ContainedElements, new DmiChassisContainedElementCollection((ChassisContainedElementCollection)containedElements));
            }
            #endregion

            #region 2.7+
            if (ImplementedVersion >= DmiStructureVersion.v27)
            {
                object skuNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.Chassis.SkuNumber);
                properties.Add(DmiProperty.Chassis.SkuNumber, skuNumber);
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
