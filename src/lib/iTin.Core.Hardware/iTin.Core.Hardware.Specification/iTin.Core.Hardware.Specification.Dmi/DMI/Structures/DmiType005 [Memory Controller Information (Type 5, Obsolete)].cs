
namespace iTin.Core.Hardware.Specification.Dmi
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
            object errorDetectingMethod = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ErrorDetectingMethod);
            if (errorDetectingMethod != null)
            {
                properties.Add(DmiProperty.MemoryController.ErrorDetectingMethod, errorDetectingMethod);
            }

            object errorCorrectingCapabilities = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ErrorCorrectingCapabilities);
            if (errorCorrectingCapabilities != null)
            {
                properties.Add(DmiProperty.MemoryController.ErrorCorrectingCapabilities, errorCorrectingCapabilities);
            }

            object supportedInterleave = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedInterleave);
            if (supportedInterleave != null)
            {
                properties.Add(DmiProperty.MemoryController.SupportedInterleave, supportedInterleave);
            }

            object currentInterleave = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.CurrentInterleave);
            if (supportedInterleave != null)
            {
                properties.Add(DmiProperty.MemoryController.CurrentInterleave, currentInterleave);
            }

            object maximumMemoryModuleSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.MaximumMemoryModuleSize);
            if (maximumMemoryModuleSize != null)
            {
                properties.Add(DmiProperty.MemoryController.MaximumMemoryModuleSize, maximumMemoryModuleSize);
            }

            object supportedSpeeds = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedSpeeds);
            if (supportedSpeeds != null)
            {
                properties.Add(DmiProperty.MemoryController.SupportedSpeeds, supportedSpeeds);
            }

            object supportedMemoryTypes = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.SupportedMemoryTypes);
            if (supportedMemoryTypes != null)
            {
                properties.Add(DmiProperty.MemoryController.SupportedMemoryTypes, supportedMemoryTypes);
            }

            object memoryModuleVoltages = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.MemoryModuleVoltages);
            if (memoryModuleVoltages != null)
            {
                properties.Add(DmiProperty.MemoryController.MemoryModuleVoltages, memoryModuleVoltages);
            }

            object numberMemorySlots = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.NumberMemorySlots);
            if (numberMemorySlots != null)
            {
                properties.Add(DmiProperty.MemoryController.NumberMemorySlots, numberMemorySlots);
            }

            object containedMemoryModules = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.ContainedMemoryModules);
            if (containedMemoryModules == null)
            {
                return;
            }

            properties.Add(DmiProperty.MemoryController.ContainedMemoryModules, new DmiMemoryControllerContainedElementCollection((MemoryControllerContainedElementCollection)containedMemoryModules));

            object enabledErrorCorrectingCapabilities = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryController.EnabledErrorCorrectingCapabilities);
            if (enabledErrorCorrectingCapabilities != null)
            {
                properties.Add(DmiProperty.MemoryController.EnabledErrorCorrectingCapabilities, enabledErrorCorrectingCapabilities);
            }
        }
        #endregion

        #endregion
    }
}
