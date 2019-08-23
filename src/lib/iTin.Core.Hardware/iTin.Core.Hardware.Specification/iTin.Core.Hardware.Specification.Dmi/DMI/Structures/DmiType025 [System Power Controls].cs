
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the System Power Controls (Type 25) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025" />.
    /// </summary>
    internal sealed class DmiType025 : DmiBaseType<SmbiosType025>
    {
        #region constructor/s

        #region [public] DmiType025(SmbiosType025, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType025" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType025(SmbiosType025 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object month = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Month);
            if (month != null)
            {
                properties.Add(DmiProperty.SystemPowerControls.Month, month);
            }

            object day = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Day);
            if (day != null)
            {
                properties.Add(DmiProperty.SystemPowerControls.Day, day);
            }

            object hour = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Hour);
            if (hour != null)
            {
                properties.Add(DmiProperty.SystemPowerControls.Hour, hour);
            }

            object minute = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Minute);
            if (minute != null)
            {
                properties.Add(DmiProperty.SystemPowerControls.Minute, minute);
            }

            object second = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemPowerControls.Second);
            if (second != null)
            {
                properties.Add(DmiProperty.SystemPowerControls.Second, second);
            }
        }
        #endregion

        #endregion
    }
}
