
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Channel (Type 37) structure.
    /// For more information, please see <see cref="SmbiosType037"/>.
    /// </summary>
    sealed class DmiType037 : DmiBaseType<SmbiosType037>
    {
        #region constructor/s

        #region [public] DmiType037(SmbiosType037, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType037"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType037(SmbiosType037 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.MemoryChannel.ChannelType, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.ChannelType));
            properties.Add(DmiProperty.MemoryChannel.MaximunChannelLoad, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.MaximumChannelLoad));

            object devices = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryChannel.Devices);
            if (devices != null)
            {
                properties.Add(DmiProperty.MemoryChannel.Devices, new DmiMemoryChannelElementCollection((MemoryChannelElementCollection) devices));
            }
        }
        #endregion

        #endregion
    }
}
