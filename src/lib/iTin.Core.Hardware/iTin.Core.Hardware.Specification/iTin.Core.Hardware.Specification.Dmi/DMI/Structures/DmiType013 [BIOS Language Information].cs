
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the BIOS Language Information (Type 13) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType013" />.
    /// </summary>
    internal sealed class DmiType013 : DmiBaseType<SmbiosType013>
    {
        #region constructor/s

        #region [public] DmiType013(SmbiosType013, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType013" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType013(SmbiosType013 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
                object installableLanguages = SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.InstallableLanguages);
                if (installableLanguages != null)
                {
                    properties.Add(DmiProperty.BiosLanguage.InstallableLanguages, installableLanguages);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x06)
            {
                object isCurrentAbbreviated = SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.IsCurrentAbbreviated);
                if (isCurrentAbbreviated != null)
                {
                    properties.Add(DmiProperty.BiosLanguage.IsCurrentAbbreviated, isCurrentAbbreviated);
                }
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x16)
            {
                object current = SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.Current);
                if (current != null)
                {
                    properties.Add(DmiProperty.BiosLanguage.Current, current);
                }
            }
        }
        #endregion

        #endregion
    }
}
