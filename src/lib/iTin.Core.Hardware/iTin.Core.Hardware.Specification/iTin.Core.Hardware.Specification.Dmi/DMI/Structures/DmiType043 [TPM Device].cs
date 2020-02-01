
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the TPM Device (Type 43) structure.
    /// For more information, please see <see cref="SmbiosType043"/>.
    /// </summary>
    internal sealed class DmiType043: DmiBaseType<SmbiosType043>
    {
        #region constructor/s

        #region [public] DmiType043(SmbiosType043, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType043"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType043(SmbiosType043 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object vendorId = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.VendorId);
            if (vendorId != null)
            {
                properties.Add(DmiProperty.TpmDevice.VendorId, vendorId);
            }

            object vendorIdDescription = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.VendorIdDescription);
            if (vendorIdDescription != null)
            {
                properties.Add(DmiProperty.TpmDevice.VendorIdDescription, vendorIdDescription);
            }

            object majorSpecVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.MajorSpecVersion);
            if (majorSpecVersion != null)
            {
                properties.Add(DmiProperty.TpmDevice.MajorSpecVersion, majorSpecVersion);
            }

            object minorSpecVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.MinorSpecVersion);
            if (minorSpecVersion != null)
            {
                properties.Add(DmiProperty.TpmDevice.MinorSpecVersion, minorSpecVersion);
            }

            object firmwareVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.FirmwareVersion);
            if (firmwareVersion != null)
            {
                properties.Add(DmiProperty.TpmDevice.FirmwareVersion, firmwareVersion);
            }

            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.TpmDevice.Description, description);
            }

            object characteristics = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.Characteristics);
            if (characteristics != null)
            {
                properties.Add(DmiProperty.TpmDevice.Characteristics, characteristics);
            }

            object oemDefined = SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.OemDefined);
            if (oemDefined != null)
            {
                properties.Add(DmiProperty.TpmDevice.OemDefined, oemDefined);
            }
        }
        #endregion

        #endregion
    }
}
