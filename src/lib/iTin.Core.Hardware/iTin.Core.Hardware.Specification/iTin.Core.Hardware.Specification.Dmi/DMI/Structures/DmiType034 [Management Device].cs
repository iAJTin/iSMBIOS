
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the  Management Device (Type 34) structure.
    /// For more information, please see <see cref="SmbiosType034"/>.
    /// </summary>
    internal sealed class DmiType034 : DmiBaseType<SmbiosType034>
    {
        #region constructor/s

        #region [public] DmiType034(SmbiosType034, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType034"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType034(SmbiosType034 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.ManagementDevice.Description, description);
            }

            object type = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Type);
            if (type != null)
            {
                properties.Add(DmiProperty.ManagementDevice.Type, type);
            }

            object address = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.Address);
            if (address != null)
            {
                properties.Add(DmiProperty.ManagementDevice.Address, address);
            }

            object addressType = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementDevice.AddressType);
            if (addressType != null)
            {
                properties.Add(DmiProperty.ManagementDevice.AddressType, addressType);
            }
        }
        #endregion

        #endregion
    }
}
