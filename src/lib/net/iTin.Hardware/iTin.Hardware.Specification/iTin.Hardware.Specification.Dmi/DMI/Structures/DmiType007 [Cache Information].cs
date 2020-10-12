
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Cache Information (Type 7) structure.
    /// For more information, please see <see cref="SmbiosType007"/>.
    /// </summary>
    internal sealed class DmiType007 : DmiBaseType<SmbiosType007>
    {
        #region constructor/s

        #region [public] DmiType007(SmbiosType007, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="DmiType007"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public DmiType007(SmbiosType007 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0+
            if (ImplementedVersion >= DmiStructureVersion.v20)
            {
                properties.Add(DmiProperty.Cache.SocketDesignation, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SocketDesignation));
                properties.Add(DmiProperty.Cache.CacheConfiguration.OperationalMode, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.OperationalMode));
                properties.Add(DmiProperty.Cache.CacheConfiguration.CacheEnabled, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.CacheEnabled));
                properties.Add(DmiProperty.Cache.CacheConfiguration.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.Location));
                properties.Add(DmiProperty.Cache.CacheConfiguration.CacheSocketed, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.CacheSocketed));
                properties.Add(DmiProperty.Cache.CacheConfiguration.Level, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.Level));
                properties.Add(DmiProperty.Cache.MaximumCacheSize, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.MaximumCacheSize));

                int installedCacheSize = SmbiosStructure.GetPropertyValue<int>(SmbiosProperty.Cache.InstalledCacheSize);
                if (installedCacheSize != 0x0000)
                {
                    properties.Add(DmiProperty.Cache.InstalledCacheSize, installedCacheSize);
                }

                properties.Add(DmiProperty.Cache.SupportedSramTypes, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SupportedSramTypes));
                properties.Add(DmiProperty.Cache.CurrentSramType, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CurrentSramType));
            }
            #endregion

            #region 2.1+
            if (ImplementedVersion >= DmiStructureVersion.v21)
            {
                byte cacheSpeed = SmbiosStructure.GetPropertyValue<byte>(SmbiosProperty.Cache.CacheSpeed);
                if (cacheSpeed != 0x00)
                {
                    properties.Add(DmiProperty.Cache.CacheSpeed, cacheSpeed);
                }

                properties.Add(DmiProperty.Cache.ErrorCorrectionType, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.ErrorCorrectionType));
                properties.Add(DmiProperty.Cache.SystemCacheType, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SystemCacheType));
                properties.Add(DmiProperty.Cache.Associativity, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.Associativity));
            }
            #endregion

            #region 3.1+
            if (ImplementedVersion >= DmiStructureVersion.v31)
            {
                properties.Add(DmiProperty.Cache.MaximumCacheSize2, SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.MaximumCacheSize2));

                uint installedCacheSize2 = SmbiosStructure.GetPropertyValue<uint>(SmbiosProperty.Cache.InstalledCacheSize2);
                if (installedCacheSize2 != 0x00)
                {
                    properties.Add(DmiProperty.Cache.InstalledCacheSize2, installedCacheSize2);
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
