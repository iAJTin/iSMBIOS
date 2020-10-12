
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the  Management Device Component (Type 35) structure.
    /// For more information, please see <see cref="SmbiosType035"/>.
    /// </summary>
    internal sealed class DmiType035 : DmiBaseType<SmbiosType035>
    {
        #region constructor/s

        #region [public] DmiType035(SmbiosType035, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType035"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType035(SmbiosType035 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            if (ImplementedVersion < DmiStructureVersion.Latest)
            {
                return;
            }

            properties.Add(DmiProperty.ManagementDeviceComponent.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.Description));
            properties.Add(DmiProperty.ManagementDeviceComponent.ComponentHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ComponentHandle));
           
            ushort thresholdHandle = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceComponent.ThresholdHandle);
            if (thresholdHandle != 0xffff)
            {
                properties.Add(DmiProperty.ManagementDeviceComponent.ThresholdHandle, thresholdHandle);
            }

            properties.Add(DmiProperty.ManagementDeviceComponent.ManagementDeviceHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ManagementDeviceHandle));
        }
        #endregion

        #endregion
    }
}
