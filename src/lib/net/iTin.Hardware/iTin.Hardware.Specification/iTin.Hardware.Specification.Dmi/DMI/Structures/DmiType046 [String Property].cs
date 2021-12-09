
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the String Property (Type 46) structure.
    /// For more information, please see <see cref="SmbiosType046"/>.
    /// </summary>
    internal sealed class DmiType046: DmiBaseType<SmbiosType046>
    {
        #region constructor/s

        #region [public] DmiType046(SmbiosType046, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType046"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType046(SmbiosType046 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region version 3.5
            properties.Add(DmiProperty.StringProperty.PropertyId, SmbiosStructure.GetPropertyValue(SmbiosProperty.StringProperty.PropertyId));
            properties.Add(DmiProperty.StringProperty.PropertyValue, SmbiosStructure.GetPropertyValue(SmbiosProperty.StringProperty.PropertyValue));
            properties.Add(DmiProperty.StringProperty.ParentHandle, SmbiosStructure.GetPropertyValue(SmbiosProperty.StringProperty.ParentHandle));
            #endregion
        }
        #endregion

        #endregion
    }
}
