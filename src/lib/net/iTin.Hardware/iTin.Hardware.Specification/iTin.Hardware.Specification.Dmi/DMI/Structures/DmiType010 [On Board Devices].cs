
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the On Board Devices (Type 10, Obsolete) structure.
    /// For more information, please see <see cref="SmbiosType010"/>.
    /// </summary>
    internal sealed class DmiType010 : DmiBaseType<SmbiosType010>
    {
        #region constructor/s

        #region [public] DmiType010(SmbiosType010, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType010"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType010(SmbiosType010 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            properties.Add(DmiProperty.OnBoardDevices.Enabled, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Enabled));
            properties.Add(DmiProperty.OnBoardDevices.DeviceType, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.DeviceType));
            properties.Add(DmiProperty.OnBoardDevices.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Description));
        }
        #endregion

        #endregion
    }
}
