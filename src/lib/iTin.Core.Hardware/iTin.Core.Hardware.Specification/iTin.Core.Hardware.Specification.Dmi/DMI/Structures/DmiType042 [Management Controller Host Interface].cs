
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Management Controller Host Interface (Type 42) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.DmiType042" />.
    /// </summary>
    internal sealed class DmiType042: DmiBaseType<SmbiosType042>
    {
        #region constructor/s

        #region [public] DmiType042(SmbiosType042, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType042" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType042(SmbiosType042 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object interfaceType = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.InterfaceType);
            if (interfaceType != null)
            {
                properties.Add(DmiProperty.ManagementControllerHostInterface.InterfaceType, interfaceType);
            }

            if (SmbiosStructure.StructureInfo.Length >= 0x07)
            {
                object interfaceTypeSpecificData = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.InterfaceTypeSpecificData);
                if (interfaceTypeSpecificData != null)
                {
                    properties.Add(DmiProperty.ManagementControllerHostInterface.InterfaceTypeSpecificData, interfaceTypeSpecificData);
                }
            }

            object protocols = SmbiosStructure.GetPropertyValue(SmbiosProperty.ManagementControllerHostInterface.Protocols);
            if (protocols != null)
            {
                properties.Add(DmiProperty.ManagementControllerHostInterface.Protocols, new DmiManagementControllerHostInterfaceProtocolRecordsCollection((ManagementControllerHostInterfaceProtocolRecordsCollection)protocols));
            }
        }
        #endregion

        #endregion
    }
}
