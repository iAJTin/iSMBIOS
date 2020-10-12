
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Hardware Security (Type 24) structure.
    /// For more information, please see <see cref="SmbiosType024"/>.
    /// </summary>
    internal sealed class DmiType024 : DmiBaseType<SmbiosType024>
    {
        #region constructor/s

        #region [public] DmiType024(SmbiosType024, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType024"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType024(SmbiosType024 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus));
        }
        #endregion

        #endregion
    }
}
