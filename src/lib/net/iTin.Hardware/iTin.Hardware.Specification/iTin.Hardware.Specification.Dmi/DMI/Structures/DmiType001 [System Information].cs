
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Information (Type 1) structure.
    /// For more information, please see <see cref="SmbiosType001"/>.
    /// </summary>
    internal sealed class DmiType001 : DmiBaseType<SmbiosType001>
    {
        #region constructor/s

        #region [public] DmiType001(SmbiosType001, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType001"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType001(SmbiosType001 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
                object manufacturer = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.Manufacturer);
                if (manufacturer != null)
                {
                    properties.Add(DmiProperty.System.Manufacturer, manufacturer);
                }

                object productName = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.ProductName);
                if (productName != null)
                {
                    properties.Add(DmiProperty.System.ProductName, productName);
                }

                object version = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.Version);
                if (version != null)
                {
                    properties.Add(DmiProperty.System.Version, version);
                }

                object serialNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.SerialNumber);
                if (serialNumber != null)
                {
                    properties.Add(DmiProperty.System.SerialNumber, serialNumber);
                }
            }
            #endregion

            #region 2.1+
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                object wakeUpType = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.WakeUpType);
                if (wakeUpType != null)
                {
                    properties.Add(DmiProperty.System.WakeUpType, wakeUpType);
                }

                object uuid = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.UUID);
                if (uuid != null)
                {
                    properties.Add(DmiProperty.System.UUID, uuid);
                }
            }
            #endregion

            #region 2.4+
            if (ImplementedVersion >= DmiStructureVersion.v24)
            {
                object skuNumber = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.SkuNumber);
                if (skuNumber != null)
                {
                    properties.Add(DmiProperty.System.SkuNumber, skuNumber);
                }

                object family = SmbiosStructure.GetPropertyValue(SmbiosProperty.System.Family);
                if (family != null)
                {
                    properties.Add(DmiProperty.System.Family, family);
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
