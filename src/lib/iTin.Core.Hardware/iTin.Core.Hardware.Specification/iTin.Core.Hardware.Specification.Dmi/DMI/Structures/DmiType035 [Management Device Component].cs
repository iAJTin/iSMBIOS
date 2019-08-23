
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the  Management Device Component (Type 35) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035" />.
    /// </summary>
    internal sealed class DmiType035 : DmiBaseType<SmbiosType035>
    {
        #region constructor/s

        #region [public] DmiType035(SmbiosType035, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType035" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType035(SmbiosType035 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.ManagementDeviceComponent.Description, description);
            }

            object managementDeviceHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ManagementDeviceHandle);
            if (managementDeviceHandle != null)
            {
                properties.Add(DmiProperty.ManagementDeviceComponent.ManagementDeviceHandle, managementDeviceHandle);
            }

            object componentHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ComponentHandle);
            if (componentHandle != null)
            {
                properties.Add(DmiProperty.ManagementDeviceComponent.ComponentHandle, componentHandle);
            }

            object thresholdHandleProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDeviceComponent.ThresholdHandle);
            if (thresholdHandleProperty != null)
            {
                int thresholdHandle = (int) thresholdHandleProperty;
                if (thresholdHandle != 0xffff)
                {
                    properties.Add(DmiProperty.ManagementDeviceComponent.ThresholdHandle, thresholdHandle);
                }
            }
        }
        #endregion

        #endregion
    }
}
