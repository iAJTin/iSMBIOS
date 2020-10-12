
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Built-in Pointing Device (Type 21) structure.
    /// For more information, please see <see cref="SmbiosType021"/>.
    /// </summary>
    internal sealed class DmiType021 : DmiBaseType<SmbiosType021>
    {
        #region constructor/s

        #region [public] DmiType021(SmbiosType021, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType021"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType021(SmbiosType021 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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

            properties.Add(DmiProperty.BuiltInPointingDevice.NumberOfButtons, SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.NumberOfButtons));
            properties.Add(DmiProperty.BuiltInPointingDevice.Type, SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.Type));
            properties.Add(DmiProperty.BuiltInPointingDevice.Interface, SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.Interface));
        }
        #endregion

        #endregion
    }
}
