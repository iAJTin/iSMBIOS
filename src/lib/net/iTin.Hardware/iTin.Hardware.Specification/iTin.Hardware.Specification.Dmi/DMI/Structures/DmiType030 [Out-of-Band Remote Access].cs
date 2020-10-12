
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Out-of-Band Remote Access (Type 30) structure.
    /// For more information, please see <see cref="SmbiosType030"/>.
    /// </summary>
    internal sealed class DmiType030 : DmiBaseType<SmbiosType030>
    {
        #region constructor/s

        #region [public] DmiType030(SmbiosType030, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType030"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType030(SmbiosType030 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.OutOfBandRemote.Manufacturer, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Manufacturer));
            properties.Add(DmiProperty.OutOfBandRemote.Connections.OutBoundConnection, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Connections.OutBoundConnection));
            properties.Add(DmiProperty.OutOfBandRemote.Connections.InBoundConnection, SmbiosStructure.GetPropertyValue(SmbiosProperty.OutOfBandRemote.Connections.InBoundConnection));
        }
        #endregion

        #endregion
    }
}
