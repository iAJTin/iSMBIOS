
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Cache Information (Type 7) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007" />.
    /// </summary>
    internal sealed class DmiType007 : DmiBaseType<SmbiosType007>
    {
        #region constructor/s

        #region [public] DmiType007(SmbiosType007, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType007" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType007(SmbiosType007 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0+
            if (SmbiosStructure.StructureInfo.Length >= 0x0f)
            {
                object socketDesignation = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SocketDesignation);
                if (socketDesignation != null)
                {
                    properties.Add(DmiProperty.Cache.SocketDesignation, socketDesignation);
                }

                object operationalMode = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.OperationalMode);
                if (operationalMode != null)
                {
                    properties.Add(DmiProperty.Cache.CacheConfiguration.OperationalMode, operationalMode);
                }

                object cacheEnabled = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.CacheEnabled);
                if (cacheEnabled != null)
                {
                    properties.Add(DmiProperty.Cache.CacheConfiguration.CacheEnabled, cacheEnabled);
                }

                object location = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.Location);
                if (location != null)
                {
                    properties.Add(DmiProperty.Cache.CacheConfiguration.Location, location);
                }

                object cacheSocketed = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.CacheSocketed);
                if (cacheSocketed != null)
                {
                    properties.Add(DmiProperty.Cache.CacheConfiguration.CacheSocketed, cacheSocketed);
                }

                object level = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheConfiguration.Level);
                if (level != null)
                {
                    properties.Add(DmiProperty.Cache.CacheConfiguration.Level, level);
                }

                object maximumCacheSize = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.MaximumCacheSize);
                if (maximumCacheSize != null)
                {
                    properties.Add(DmiProperty.Cache.MaximumCacheSize, maximumCacheSize);
                }

                object installedCacheSizeProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.InstalledCacheSize);
                if (installedCacheSizeProperty != null)
                {
                    int installedCacheSize = (int)installedCacheSizeProperty;
                    if (installedCacheSize != 0x0000)
                    {
                        properties.Add(DmiProperty.Cache.InstalledCacheSize, installedCacheSize);
                    }
                }

                object supportedSramTypes = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SupportedSramTypes);
                if (supportedSramTypes != null)
                {
                    properties.Add(DmiProperty.Cache.SupportedSramTypes, supportedSramTypes);
                }

                object currentSramType = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CurrentSramType);
                if (currentSramType != null)
                {
                    properties.Add(DmiProperty.Cache.CurrentSramType, currentSramType);
                }
            }
            #endregion

            #region 2.1+
            if (SmbiosStructure.StructureInfo.Length >= 0x10)
            {
                object cacheSpeedProperty = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.CacheSpeed);
                if (cacheSpeedProperty != null)
                {
                    byte cacheSpeed = (byte)cacheSpeedProperty;
                    if (cacheSpeed != 0x00)
                    {
                        properties.Add(DmiProperty.Cache.CacheSpeed, cacheSpeed);
                    }
                }

                object errorCorrectionType = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.ErrorCorrectionType);
                if (errorCorrectionType != null)
                {
                    properties.Add(DmiProperty.Cache.ErrorCorrectionType, errorCorrectionType);
                }

                object systemCacheType = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.SystemCacheType);
                if (systemCacheType != null)
                {
                    properties.Add(DmiProperty.Cache.SystemCacheType, systemCacheType);
                }

                object associativity = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.Associativity);
                if (associativity != null)
                {
                    properties.Add(DmiProperty.Cache.Associativity, associativity);
                }
            }
            #endregion

            #region 3.1.0+
            if (SmbiosStructure.StructureInfo.Length >= 0x14)
            {
                object maximumCacheSize2 = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.MaximumCacheSize2);
                if (maximumCacheSize2 != null)
                {
                    properties.Add(DmiProperty.Cache.MaximumCacheSize2, maximumCacheSize2);
                }

                object installedCacheSize2Property = SmbiosStructure.GetPropertyValue(SmbiosProperty.Cache.InstalledCacheSize2);
                if (installedCacheSize2Property != null)
                {
                    uint installedCacheSize2 = (uint)installedCacheSize2Property;
                    if (installedCacheSize2 != 0x00)
                    {
                        properties.Add(DmiProperty.Cache.InstalledCacheSize2, installedCacheSize2);
                    }
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
