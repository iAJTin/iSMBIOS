
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Bios Information (Type 0) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000" />.
    /// </summary>
    internal sealed class DmiType000 : DmiBaseType<SmbiosType000>
    {
        #region constructor/s

        #region [public] DmiType000(SmbiosType000, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType000" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType000(SmbiosType000 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0
            if (SmbiosVersion >= 0x0200)
            {
                object vendor = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.Vendor);
                if (vendor != null)
                {
                    properties.Add(DmiProperty.Bios.Vendor, vendor);
                }

                object biosVersion = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.BiosVersion);
                if (biosVersion != null)
                {
                    properties.Add(DmiProperty.Bios.BiosVersion, biosVersion);
                }

                object biosStartSegment = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.BiosStartSegment);
                if (biosStartSegment != null)
                {
                    properties.Add(DmiProperty.Bios.BiosStartSegment, biosStartSegment);
                }

                object biosReleaseDate = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.BiosReleaseDate);
                if (biosReleaseDate != null)
                {
                    properties.Add(DmiProperty.Bios.BiosReleaseDate, biosReleaseDate);
                }

                object characteristics = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.Characteristics);
                if (characteristics != null)
                {
                    properties.Add(DmiProperty.Bios.Characteristics, characteristics);
                }
            }
            #endregion

            #region 2.4+
            if (SmbiosVersion >= 0x0204)
            {
                object characteristicsExtensionByte1 = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.CharacteristicsExtensionByte1);
                if (characteristicsExtensionByte1 != null)
                {
                    properties.Add(DmiProperty.Bios.CharacteristicsExtensionByte1, characteristicsExtensionByte1);
                }

                object characteristicsExtensionByte2 = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.CharacteristicsExtensionByte2);
                if (characteristicsExtensionByte2 != null)
                {
                    properties.Add(DmiProperty.Bios.CharacteristicsExtensionByte2, characteristicsExtensionByte2);
                }

                object systemBiosMajorRelease = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.SystemBiosMajorRelease);
                if (systemBiosMajorRelease != null)
                {
                    properties.Add(DmiProperty.Bios.SystemBiosMajorRelease, systemBiosMajorRelease);
                }

                object systemBiosMinorRelease = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.SystemBiosMinorRelease);
                if (systemBiosMinorRelease != null)
                {
                    properties.Add(DmiProperty.Bios.SystemBiosMinorRelease, systemBiosMinorRelease);
                }

                object firmwareMajorRelease = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.FirmwareMajorRelease);
                if (firmwareMajorRelease != null)
                {
                    properties.Add(DmiProperty.Bios.FirmwareMajorRelease, firmwareMajorRelease);
                }

                object firmwareMinorRelease = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.FirmwareMinorRelease);
                if (firmwareMinorRelease != null)
                {
                    properties.Add(DmiProperty.Bios.FirmwareMinorRelease, firmwareMinorRelease);
                }
            }
            #endregion

            #region 3.1+
            object romSizeProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.BiosRomSize);
            if (romSizeProperty != null)
            {
                int romSize = (int)romSizeProperty;
                if (romSize != 0xff)
                {
                    if (SmbiosVersion >= 0x0301)
                    {
                        object extendedBiosRomSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.ExtendedBiosRomSize);
                        if (extendedBiosRomSize != null)
                        {
                            properties.Add(DmiProperty.Bios.BiosRomSize, extendedBiosRomSize);
                        }

                        object biosRomSizeUnit = SmbiosStructure.GetPropertyValue(SmbiosProperty.Bios.BiosRomSizeUnit);
                        if (biosRomSizeUnit != null)
                        {
                            properties.Add(DmiProperty.Bios.BiosRomSizeUnit, biosRomSizeUnit);
                        }
                    }
                }
                else
                {
                    properties.Add(DmiProperty.Bios.BiosRomSize, romSize);
                    properties.Add(DmiProperty.Bios.BiosRomSizeUnit, MemorySizeUnit.KB);
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
