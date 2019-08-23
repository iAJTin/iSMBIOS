
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Onboard Devices Extended Information (Type 41) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.DmiType041" />.
    /// </summary>
    internal sealed class DmiType041: DmiBaseType<SmbiosType041>
    {
        #region constructor/s

        #region [public] DmiType041(SmbiosType041, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType041" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType041(SmbiosType041 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object referenceDesignation = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.ReferenceDesignation);
            if (referenceDesignation != null)
            {
                properties.Add(DmiProperty.OnBoardDevicesExtended.ReferenceDesignation, referenceDesignation);
            }

            object deviceStatus = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceStatus);
            if (deviceStatus != null)
            {
                properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceStatus, deviceStatus);
            }

            object deviceType = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceType);
            if (deviceType != null)
            {
                properties.Add(DmiProperty.OnBoardDevicesExtended.Element.DeviceType, deviceType);
            }
        }
        #endregion

        #endregion
    }
}
