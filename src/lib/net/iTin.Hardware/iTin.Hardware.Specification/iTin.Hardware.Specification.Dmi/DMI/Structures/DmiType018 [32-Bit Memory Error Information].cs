
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the 32-Bit Memory Error Information (Type 18) structure.
    /// For more information, please see <see cref="SmbiosType018"/>.
    /// </summary>
    internal sealed class DmiType018 : DmiBaseType<SmbiosType018>
    {
        #region constructor/s

        #region [public] DmiType018(SmbiosType018, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType018"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType018(SmbiosType018 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.BitMemoryError32.ErrorType, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorType));
            properties.Add(DmiProperty.BitMemoryError32.ErrorGranularity, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorGranularity));
            properties.Add(DmiProperty.BitMemoryError32.ErrorOperation, SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorOperation));

            uint vendorSyndrome = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError32.VendorSyndrome);
            if (vendorSyndrome != 0x00000000)
            {
                properties.Add(DmiProperty.BitMemoryError32.VendorSyndrome, vendorSyndrome);
            }

            uint busErrorAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError32.MemoryArrayErrorAddress);
            if (busErrorAddress != 0x80000000)
            {
                properties.Add(DmiProperty.BitMemoryError32.MemoryArrayErrorAddress, busErrorAddress);
            }

            uint deviceErrorAddress = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError32.DeviceErrorAddress);
            if (deviceErrorAddress != 0x80000000)
            {
                properties.Add(DmiProperty.BitMemoryError32.DeviceErrorAddress, deviceErrorAddress);
            }

            uint errorResolution = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.BitMemoryError32.ErrorResolution);
            if (errorResolution != 0x80000000)
            {
                properties.Add(DmiProperty.BitMemoryError32.ErrorResolution, errorResolution);
            }
        }
        #endregion

        #endregion
    }
}
