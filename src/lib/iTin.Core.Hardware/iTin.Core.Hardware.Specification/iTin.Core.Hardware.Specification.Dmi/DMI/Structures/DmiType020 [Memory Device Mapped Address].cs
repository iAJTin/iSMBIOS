
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Memory Device Mapped Address (Type 20) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType020" />.
    /// </summary>
    internal sealed class DmiType020 : DmiBaseType<SmbiosType020>
    {
        #region constructor/s

        #region [public] DmiType020(SmbiosType020, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType020" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType020(SmbiosType020 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object startAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.StartingAddress);
            if (startAddress != null)
            {
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.StartAddress, startAddress);
            }

            object endAddress = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryDeviceMappedAddress.EndingAddress);
            if (endAddress != null)
            {
                properties.Add(DmiProperty.MemoryDeviceMappedAddress.EndAddress, endAddress);
            }

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
        }
        #endregion

        #endregion
    }
}
