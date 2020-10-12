
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Array Mapped Address (Type 19) structure.
    /// For more information, please see <see cref="SmbiosType019"/>.
    /// </summary>
    internal sealed class DmiType019 : DmiBaseType<SmbiosType019>
    {
        #region constructor/s

        #region [public] DmiType019(SmbiosType019, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType019"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType019(SmbiosType019 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            if (ImplementedVersion < DmiStructureVersion.v21)
            {
                return;
            }

            properties.Add(DmiProperty.MemoryArrayMappedAddress.MemoryArrayHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.MemoryArrayHandle));
            properties.Add(DmiProperty.MemoryArrayMappedAddress.PartitionWidth, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.PartitionWidth));

            uint startingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryArrayMappedAddress.StartingAddress);
            properties.Add(
                DmiProperty.MemoryArrayMappedAddress.StartingAddress,
                startingAddress == 0xffffffff
                    ? SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.ExtendedStartingAddress)
                    : (ulong)startingAddress * (ulong)1024);

            uint endingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryArrayMappedAddress.EndingAddress);
            properties.Add(
                DmiProperty.MemoryArrayMappedAddress.EndingAddress,
                endingAddress == 0xffffffff
                    ? SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.ExtendedEndingAddress)
                    : (ulong)endingAddress * (ulong)1024);
        }
        #endregion

        #endregion
    }
}
