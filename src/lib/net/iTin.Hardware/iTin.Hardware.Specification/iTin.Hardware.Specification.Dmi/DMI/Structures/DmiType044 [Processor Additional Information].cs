
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Processor Additional Information (Type 44) structure.
    /// For more information, please see <see cref="SmbiosType044"/>.
    /// </summary>
    internal sealed class DmiType044: DmiBaseType<SmbiosType044>
    {
        #region constructor/s

        #region [public] DmiType044(SmbiosType044, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType044"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType044(SmbiosType044 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object referenceHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.ProcessorAdditionalInformation.ReferencedHandle);
            if (referenceHandle != null)
            {
                properties.Add(DmiProperty.ProcessorAdditionalInformation.ReferencedHandle, referenceHandle);
            }
            
            properties.Add(DmiProperty.ProcessorAdditionalInformation.ProcessorSpecificBlock, SmbiosStructure.GetPropertyValue(SmbiosProperty.ProcessorAdditionalInformation.ProcessorSpecificBlock));
        }
        #endregion

        #endregion
    }
}
