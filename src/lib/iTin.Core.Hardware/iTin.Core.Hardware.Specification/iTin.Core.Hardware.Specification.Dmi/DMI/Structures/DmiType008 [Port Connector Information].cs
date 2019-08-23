
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the  Port Connector Information (Type 8) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType008" />.
    /// </summary>
    internal sealed class DmiType008 : DmiBaseType<SmbiosType008>
    {
        #region constructor/s

        #region [public] DmiType008(SmbiosType008, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType008" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType008(SmbiosType008 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object internalReferenceDesignator = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.InternalReferenceDesignator);
            if (internalReferenceDesignator != null)
            {
                properties.Add(DmiProperty.PortConnector.InternalReferenceDesignator, internalReferenceDesignator);
            }

            object internalConnectorType = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.InternalConnectorType);
            if (internalConnectorType != null)
            {
                properties.Add(DmiProperty.PortConnector.InternalConnectorType, internalConnectorType);
            }

            object externalReferenceDesignator = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.ExternalReferenceDesignator);
            if (externalReferenceDesignator != null)
            {
                properties.Add(DmiProperty.PortConnector.ExternalReferenceDesignator, externalReferenceDesignator);
            }

            object externalConnectorType = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.ExternalConnectorType);
            if (externalConnectorType != null)
            {
                properties.Add(DmiProperty.PortConnector.ExternalConnectorType, externalConnectorType);
            }

            object portType = SmbiosStructure.GetPropertyValue(SmbiosProperty.PortConnector.PortType);
            if (portType != null)
            {
                properties.Add(DmiProperty.PortConnector.PortType, portType);
            }
        }
        #endregion

        #endregion
    }
}
