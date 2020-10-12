
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the BIOS Language Information (Type 13) structure.
    /// For more information, please see <see cref="SmbiosType013"/>.
    /// </summary>
    internal sealed class DmiType013 : DmiBaseType<SmbiosType013>
    {
        #region constructor/s

        #region [public] DmiType013(SmbiosType013, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType013"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType013(SmbiosType013 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            if (ImplementedVersion < DmiStructureVersion.v20)
            {
                return;
            }

            properties.Add(DmiProperty.BiosLanguage.InstallableLanguages, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.InstallableLanguages));
            properties.Add(DmiProperty.BiosLanguage.IsCurrentAbbreviated, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.IsCurrentAbbreviated));
            properties.Add(DmiProperty.BiosLanguage.Current, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.Current));
        }
        #endregion

        #endregion
    }
}
