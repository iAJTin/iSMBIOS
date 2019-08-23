
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Built-in Pointing Device (Type 21) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType021" />.
    /// </summary>
    internal sealed class DmiType021 : DmiBaseType<SmbiosType021>
    {
        #region constructor/s

        #region [public] DmiType021(SmbiosType021, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType021" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType021(SmbiosType021 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object numberOfButtons = SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.NumberOfButtons);
            if (numberOfButtons != null)
            {
                properties.Add(DmiProperty.BuiltInPointingDevice.NumberOfButtons, numberOfButtons);
            }

            object type = SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.Type);
            if (type != null)
            {
                properties.Add(DmiProperty.BuiltInPointingDevice.Type, type);
            }

            object @interface = SmbiosStructure.GetPropertyValue(SmbiosProperty.BuiltInPointingDevice.Interface);
            if (@interface != null)
            {
                properties.Add(DmiProperty.BuiltInPointingDevice.Interface, @interface);
            }
        }
        #endregion

        #endregion
    }
}
