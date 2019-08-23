
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the 32-Bit Memory Error Information (Type 18) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018" />.
    /// </summary>
    internal sealed class DmiType018 : DmiBaseType<SmbiosType018>
    {
        #region constructor/s

        #region [public] DmiType018(SmbiosType018, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType018" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType018(SmbiosType018 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object errorType = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorType);
            if (errorType != null)
            {
                properties.Add(DmiProperty.BitMemoryError32.ErrorType, errorType);
            }

            object errorGranularity = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorGranularity);
            if (errorGranularity != null)
            {
                properties.Add(DmiProperty.BitMemoryError32.ErrorGranularity, errorGranularity);
            }

            object errorOperation = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorOperation);
            if (errorOperation != null)
            {
                properties.Add(DmiProperty.BitMemoryError32.ErrorOperation, errorOperation);
            }

            object vendorSyndromeProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.VendorSyndrome);
            if (vendorSyndromeProperty != null)
            {
                long vendorSyndrome = (long)vendorSyndromeProperty;
                if (vendorSyndrome != 0x00000000)
                {
                    properties.Add(DmiProperty.BitMemoryError32.VendorSyndrome, vendorSyndrome);
                }
            }

            object busErrorAddressProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.MemoryArrayErrorAddress);
            if (busErrorAddressProperty != null)
            {
                long busErrorAddress = (long)busErrorAddressProperty;
                if (busErrorAddress != 0x80000000)
                {
                    properties.Add(DmiProperty.BitMemoryError32.MemoryArrayErrorAddress, busErrorAddress);
                }
            }

            object deviceErrorAddressProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.DeviceErrorAddress);
            if (deviceErrorAddressProperty != null)
            {
                long deviceErrorAddress = (long)deviceErrorAddressProperty;
                if (deviceErrorAddress != 0x80000000)
                {
                    properties.Add(DmiProperty.BitMemoryError32.DeviceErrorAddress, deviceErrorAddress);
                }
            }

            object errorResolutionProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.BitMemoryError32.ErrorResolution);
            if (errorResolutionProperty != null)
            {
                long errorResolution = (long)errorResolutionProperty;
                if (errorResolution != 0x80000000)
                {
                    properties.Add(DmiProperty.BitMemoryError32.ErrorResolution, errorResolution);
                }
            }
        }
        #endregion

        #endregion
    }
}
