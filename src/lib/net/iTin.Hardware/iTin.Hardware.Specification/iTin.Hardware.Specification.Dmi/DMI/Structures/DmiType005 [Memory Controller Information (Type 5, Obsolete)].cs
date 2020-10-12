
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Controller Information (Type 5, Obsolete) structure.
    /// For more information, please see <see cref="SmbiosType005"/>.
    /// </summary>
    internal sealed class DmiType005 : DmiBaseType<SmbiosType005>
    {
        #region constructor/s

        #region [public] DmiType005(SmbiosType005, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType005"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType005(SmbiosType005 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            properties.Add(DmiProperty.MemoryController.ErrorDetectingMethod, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ErrorDetectingMethod));
            properties.Add(DmiProperty.MemoryController.ErrorCorrectingCapabilities, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ErrorCorrectingCapabilities));
            properties.Add(DmiProperty.MemoryController.SupportedInterleave, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedInterleave));
            properties.Add(DmiProperty.MemoryController.CurrentInterleave, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.CurrentInterleave));
            properties.Add(DmiProperty.MemoryController.MaximumMemoryModuleSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.MaximumMemoryModuleSize));
            properties.Add(DmiProperty.MemoryController.SupportedSpeeds, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedSpeeds));
            properties.Add(DmiProperty.MemoryController.SupportedMemoryTypes, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedMemoryTypes));
            properties.Add(DmiProperty.MemoryController.MemoryModuleVoltages, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.MemoryModuleVoltages));
            properties.Add(DmiProperty.MemoryController.NumberMemorySlots, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.NumberMemorySlots));

            object containedMemoryModules = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ContainedMemoryModules);
            if (containedMemoryModules == null)
            {
                return;
            }

            properties.Add(DmiProperty.MemoryController.ContainedMemoryModules, new DmiMemoryControllerContainedElementCollection((MemoryControllerContainedElementCollection)containedMemoryModules));
            properties.Add(DmiProperty.MemoryController.EnabledErrorCorrectingCapabilities, SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.EnabledErrorCorrectingCapabilities));
        }
        #endregion

        #endregion
    }
}
