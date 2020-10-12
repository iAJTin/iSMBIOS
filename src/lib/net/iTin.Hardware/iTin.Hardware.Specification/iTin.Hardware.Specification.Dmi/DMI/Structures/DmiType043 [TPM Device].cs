
namespace iTin.Hardware.Specification.Dmi
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
            if (ImplementedVersion < DmiStructureVersion.Latest)
            {
                return;
            }

            properties.Add(DmiProperty.TpmDevice.VendorId, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.VendorId));
            properties.Add(DmiProperty.TpmDevice.VendorIdDescription, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.VendorIdDescription));
            properties.Add(DmiProperty.TpmDevice.MajorSpecVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.MajorSpecVersion));
            properties.Add(DmiProperty.TpmDevice.MinorSpecVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.MinorSpecVersion));
            properties.Add(DmiProperty.TpmDevice.FirmwareVersion, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.FirmwareVersion));
            properties.Add(DmiProperty.TpmDevice.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.Description));
            properties.Add(DmiProperty.TpmDevice.Characteristics, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.Characteristics));
            properties.Add(DmiProperty.TpmDevice.OemDefined, SmbiosStructure.GetPropertyValue(SmbiosProperty.TpmDevice.OemDefined));
        }
        #endregion

        #endregion
    }
}
