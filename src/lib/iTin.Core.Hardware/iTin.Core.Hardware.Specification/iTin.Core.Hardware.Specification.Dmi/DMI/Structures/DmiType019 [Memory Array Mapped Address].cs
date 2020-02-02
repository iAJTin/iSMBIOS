
namespace iTin.Core.Hardware.Specification.Dmi
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
            object memoryArrayHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.MemoryArrayHandle);
            if (memoryArrayHandle != null)
            {
                properties.Add(DmiProperty.MemoryArrayMappedAddress.MemoryArrayHandle, memoryArrayHandle);
            }

            object partitionWidth = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.PartitionWidth);
            if (partitionWidth != null)
            {
                properties.Add(DmiProperty.MemoryArrayMappedAddress.PartitionWidth, partitionWidth);
            }

            uint startingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryArrayMappedAddress.StartingAddress);
            if (startingAddress == 0xffffffff)
            {
                object extendedStartingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.ExtendedStartingAddress);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedStartingAddress, extendedStartingAddress);
            }
            else
            {
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedStartingAddress, startingAddress * 1024);
            }

            uint endingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryArrayMappedAddress.EndingAddress);
            if (endingAddress == 0xffffffff)
            {
                object extendedEndingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryArrayMappedAddress.ExtendedEndingAddress);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedEndingAddress, extendedEndingAddress);
            }
            else
            {
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedEndingAddress, endingAddress * 1024);
            }
        }
        #endregion

        #endregion
    }
}
