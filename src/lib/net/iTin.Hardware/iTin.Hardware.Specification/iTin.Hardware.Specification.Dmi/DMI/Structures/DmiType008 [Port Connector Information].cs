
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the  Port Connector Information (Type 8) structure.
    /// For more information, please see <see cref="SmbiosType008"/>.
    /// </summary>
    internal sealed class DmiType008 : DmiBaseType<SmbiosType008>
    {
        #region constructor/s

        #region [public] DmiType008(SmbiosType008, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType008"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType008(SmbiosType008 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            properties.Add(DmiProperty.PortConnector.InternalReferenceDesignator, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.InternalReferenceDesignator));
            properties.Add(DmiProperty.PortConnector.InternalConnectorType, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.InternalConnectorType));
            properties.Add(DmiProperty.PortConnector.ExternalReferenceDesignator, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.ExternalReferenceDesignator));
            properties.Add(DmiProperty.PortConnector.ExternalConnectorType, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.ExternalConnectorType));
            properties.Add(DmiProperty.PortConnector.PortType, SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.PortType));
        }
        #endregion

        #endregion
    }
}
