
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Onboard Devices Extended Information (Type 41) structure.
    /// For more information, please see <see cref="DmiType041"/>.
    /// </summary>
    internal sealed class DmiType041: DmiBaseType<SmbiosType041>
    {
        #region constructor/s

        #region [public] DmiType041(SmbiosType041, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType041"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType041(SmbiosType041 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.OnBoardDevicesExtended.ReferenceDesignation, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.ReferenceDesignation));
            properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceStatus));
            properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceType));
        }
        #endregion

        #endregion
    }
}
