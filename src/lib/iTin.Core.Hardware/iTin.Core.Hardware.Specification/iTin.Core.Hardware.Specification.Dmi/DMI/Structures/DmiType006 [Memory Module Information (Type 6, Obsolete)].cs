
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Memory Module Information (Type 6, Obsolete) structure.
    /// For more information, please see <see cref="SmbiosType006"/>.
    /// </summary>
    internal sealed class DmiType006 : DmiBaseType<SmbiosType006>
    {
        #region constructor/s

        #region [public] DmiType006(SmbiosType006, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType006"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType006(SmbiosType006 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object socketDesignation = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.SocketDesignation);
            if (socketDesignation != null)
            {
                properties.Add(DmiProperty.MemoryModule.SocketDesignation, socketDesignation);
            }

            object bankConnections = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.BankConnections);
            if (bankConnections != null)
            {
                properties.Add(DmiProperty.MemoryModule.BankConnections, bankConnections);
            }

            object currentSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.CurrentSpeed);
            if (currentSpeedProperty != null)
            {
                byte currentSpeed = (byte)currentSpeedProperty;
                if (currentSpeed != 0x00)
                {
                    properties.Add(DmiProperty.MemoryModule.CurrentSpeed, currentSpeed);
                }
            }

            object currentMemoryType = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.CurrentMemoryType);
            if (currentMemoryType != null)
            {
                properties.Add(DmiProperty.MemoryModule.CurrentMemoryType, currentMemoryType);
            }

            object installedSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.InstalledSize);
            if (installedSize != null)
            {
                properties.Add(DmiProperty.MemoryModule.InstalledSize, installedSize);
            }

            object enabledSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.EnabledSize);
            if (enabledSize != null)
            {
                properties.Add(DmiProperty.MemoryModule.EnabledSize, enabledSize);
            }

            object errorStatus = SmbiosStructure.GetPropertyValue(SmbiosProperty.MemoryModule.ErrorStatus);
            if (errorStatus != null)
            {
                properties.Add(DmiProperty.MemoryModule.ErrorStatus, errorStatus);
            }
        }
        #endregion

        #endregion
    }
}
