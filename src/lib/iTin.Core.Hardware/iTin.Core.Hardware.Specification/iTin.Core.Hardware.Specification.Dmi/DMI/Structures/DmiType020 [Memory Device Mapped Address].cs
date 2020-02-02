
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Device Mapped Address (Type 20) structure.
    /// For more information, please see <see cref="SmbiosType020"/>.
    /// </summary>
    internal sealed class DmiType020 : DmiBaseType<SmbiosType020>
    {
        #region constructor/s

        #region [public] DmiType020(SmbiosType020, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType020"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType020(SmbiosType020 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object memoryDeviceHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.MemoryDeviceHandle);
            if (memoryDeviceHandle != null)
            {
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.MemoryDeviceHandle, memoryDeviceHandle);
            }

            object memoryArrayMappedAddressHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.MemoryArrayMappedAddressHandle);
            if (memoryArrayMappedAddressHandle != null)
            {
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.MemoryArrayMappedAddressHandle, memoryArrayMappedAddressHandle);
            }

            object partitionRowPositionProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.PartitionRowPosition);
            if (partitionRowPositionProperty != null)
            {
                byte partitionRowPosition = (byte)partitionRowPositionProperty;
                if (partitionRowPosition != 0xff)
                {
                    properties.Add(DmiProperty.MemoryDeviceMappedAddress.PartitionRowPosition, partitionRowPosition);
                }
            }

            object interleavePosition = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.InterleavePosition);
            if (interleavePosition != null)
            {
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.InterleavePosition, interleavePosition);
            }

            object interleavedDataDepthProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.InterleavedDataDepth);
            if (interleavedDataDepthProperty != null)
            {
                byte interleavedDataDepth = (byte)interleavedDataDepthProperty;
                if (interleavedDataDepth != 0xff)
                {
                    properties.Add(DmiProperty.MemoryDeviceMappedAddress.InterleavedDataDepth, interleavedDataDepth);
                }
            }

            uint startingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryDeviceMappedAddress.StartingAddress);
            if (startingAddress == 0xffffffff)
            {
                object extendedStartingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedStartingAddress);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedStartingAddress, extendedStartingAddress);
            }
            else
            {
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedStartingAddress, startingAddress * 1024);
            }

            uint endingAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.MemoryDeviceMappedAddress.EndingAddress);
            if (endingAddress == 0xffffffff)
            {
                object extendedEndingAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedEndingAddress);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedEndingAddress, extendedEndingAddress);
            }
            else
            {
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedEndingAddress, endingAddress * 1024);
            }
        }
        #endregion

        #endregion
    }
}
