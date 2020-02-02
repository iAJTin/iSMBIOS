
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Physical Memory Array (Type 16) structure.
    /// For more information, please see <see cref="SmbiosType016"/>.
    /// </summary>
    internal sealed class DmiType016 : DmiBaseType<SmbiosType016>
    {
        #region constructor/s

        #region [public] DmiType016(SmbiosType016, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType016"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType016(SmbiosType016 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.Location);
            if (location != null)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.Location, location);
            }

            object use = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.Use);
            if (use != null)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.Use, use);
            }

            object memoryErrorCorrection = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.MemoryErrorCorrection);
            if (memoryErrorCorrection != null)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.MemoryErrorCorrection, memoryErrorCorrection);
            }

            object memoryErrorInformationHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.MemoryErrorInformationHandle);
            if (memoryErrorInformationHandle != null)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.MemoryErrorInformationHandle, memoryErrorInformationHandle);
            }

            object numberOfMemoryDevices = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.NumberOfMemoryDevices);
            if (numberOfMemoryDevices != null)
            {
                properties.Add(DmiProperty.PhysicalMemoryArray.NumberOfMemoryDevices, numberOfMemoryDevices);
            }

            object maximumCapacityProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.MaximumCapacity);
            if (maximumCapacityProperty != null)
            {
                ulong maximumCapacity = (ulong)maximumCapacityProperty;
                if (maximumCapacity != 0x08000000)
                {
                    properties.Add(DmiProperty.PhysicalMemoryArray.MaximumCapacity, maximumCapacity);
                }
                else
                {
                    if (SmbiosStructure.StructureInfo.Length >= 0x10)
                    {
                        object extendedMaximumCapacity = SmbiosStructure.GetPropertyValue(SmbiosProperty.PhysicalMemoryArray.ExtendedMaximumCapacity);
                        if (extendedMaximumCapacity != null)
                        {
                            properties.Add(DmiProperty.PhysicalMemoryArray.MaximumCapacity, extendedMaximumCapacity);
                        }
                    }
                }
            }
        }
        #endregion

        #endregion
    }
}
