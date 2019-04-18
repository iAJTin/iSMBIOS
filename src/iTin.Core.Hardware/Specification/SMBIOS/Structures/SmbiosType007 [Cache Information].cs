
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 007: Cache Information.
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                |
    // | Offset   Version     Name                Length      deviceProperty       Description                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        7           Cache Information Indicator                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      0Fh for version 2.0                          |
    // |                                                                  13h for version 2.1                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Socket              BYTE        STRING      String number for reference designation.     |
    // |                      Designation                                 EXAMPLE: “CACHE1”, 0                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        Cache               WORD        Varies      Bits 15:10 - Reserved, must be zero          |
    // |                      Configuration                                                                            |
    // |                                                                  Bits 09:08 - Operational Mode                |
    // |                                                                               00b - Write Through             |
    // |                                                                               01b - Write Back                |
    // |                                                                               10b - Varies with Memory        |
    // |                                                                                     Address                   |
    // |                                                                               11b - Unknown                   |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetOperationalMode(byte) function.     |
    // |                                                                                                               |
    // |                                                                  Bit     07 - Enabled/Disabled                |
    // |                                                                               (at boot time)                  |
    // |                                                                               1b - Enabled                    |
    // |                                                                               0b - Disabled                   |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        State(byte) function.                  |
    // |                                                                                                               |
    // |                                                                  Bits 06:05 - Location, en relación con la    |
    // |                                                                               CPU:                            |
    // |                                                                               00b - Internal                  |
    // |                                                                               01b - External                  |
    // |                                                                               10b - Reserved                  |
    // |                                                                               11b - Unknown                   |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetLocation(byte) function.            |
    // |                                                                                                               |
    // |                                                                  Bit     04 - Reserved, must be zero          |
    // |                                                                                                               |
    // |                                                                  Bit     03 - Cache Socketed                  |
    // |                                                                               1b - Socketed                   |
    // |                                                                               0b - Disabled                   |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        Socketed(byte) function.               |
    // |                                                                                                               |
    // |                                                                  Bits 02:00 - Cache Level (1 - 8)             |
    // |                                                                               Example:                        |
    // |                                                                               - L1 cache would use value 000b |
    // |                                                                               - L3 cache would use value 010b |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        Level(byte) function.                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Maximum Cache       WORD        Varies      Maximum size that can be installed.          |
    // |                      Size                                        Bit     15 - Granularity                     |
    // |                                                                               0b - 1K granularity             |
    // |                                                                               1b - 64K granularity            |
    // |                                                                                                               |
    // |                                                                  Bits 14:00 - Max size in given granularity   |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetSize(int) function.                 |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.0+        Installed Size      WORD        Varies      Same format as Max Cache Size field.         |
    // |                      Type                                        The value 0x00 indicates no cache is         |
    // |                                                                  installed.                                   |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetSize(int) function.                 |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.0+        Supported SRAM      WORD        Bit Field   Note: For more information, please see       |
    // |                      Type                                              GetTypes(int) function.                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh      2.0+        Current SRAM Type   WORD        Bit Field   Note: For more information, please see       |
    // |                                                                        GetTypes(int) function.                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.1+        Cache Speed         BYTE        Varies      Cache module speed, in nanoseconds.          |
    // |                      Type                                        The value is 0 if the speed is unknown.      |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        Speed(byte) function.                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.1+        Error Correction    BYTE        ENUM        Error-correction scheme supported by this    |
    // |                      Type                                        cache component                              |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetErrorCorrection(byte) function      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      2.1+        System Cache Type   BYTE        ENUM        Logical type of cache                        |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetSystemCacheType(byte) function.     |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.1+        Associativity       BYTE        ENUM        Associativity of the cache.                  |
    // |                                                                                                               |
    // |                                                                  Note: For more information, please see       |
    // |                                                                        GetAssociativity(byte) function.       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      3.1.0+      Maximum Cache       DWORD       Bit Field   If this field is present, for cache sizes of |
    // |                      Size 2                                      2047 MB or smaller the value in the Max size |
    // |                                                                  in given granularity portion of the field    |
    // |                                                                  equals the size given in the corresponding   |
    // |                                                                  portion of the Maximum Cache Size field,     |
    // |                                                                  and the Granularity bit matches the value of |
    // |                                                                  the Granularity bit in the Maximum Cache     |
    // |                                                                  Size field.                                  |
    // |                                                                  For Cache sizes greater than 2047 MB, the    |
    // |                                                                  Maximum Cache Size field is set to 0xFFFF    |
    // |                                                                  and the Maximum Cache Size 2 field is        |
    // |                                                                  present, the Granularity bit is set to 1b,   |
    // |                                                                  and the size set as required; see 7.8.1.     |
    // |                                                                                                               |
    // |                                                                  Bit 31        Granularity                    |
    // |                                                                                0 – 1K granularity             |
    // |                                                                                1 – 64K granularity(always 1b  |
    // |                                                                                    for cache sizes >2047 MB)  |
    // |                                                                                                               |
    // |                                                                  Bits 30:0     Max size in given granularity  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h      3.1.0+      Installed Cache     DWORD       Bit Field   Same format as Maximum Cache Size 2 field;   |
    // |                      Size 2                                      Absent or set to 0 if no cache is installed. |
    // |                                                                  See 7.8.1.                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Cache Information (Type 7) structure.
    /// </summary>
    sealed class SmbiosType007 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType007(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType007" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType007(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.0+ fields

        #region [private] (string) SocketDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <c>Socket Designation</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SocketDesignation => GetString(0x04);
        #endregion

        #region [private] (int) CacheConfiguration: Gets a value representing the 'Cache Configuration' field
        /// <summary>
        /// Gets a value representing the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CacheConfiguration => GetWord(0x05);
        #endregion

        #region [private] (byte) OperationalMode:  Gets a value that represents the 'Operational Mode' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <c>bcOperational Mode</c> feature of the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte OperationalMode => (byte) ((CacheConfiguration >> 0x08) & 0x0003);
        #endregion

        #region [private] (bool) Enabled: Gets a value that represents the 'Enabled' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <c>Enabled</c> feature of the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Enabled => CacheConfiguration.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (byte) Location: Gets a value that represents the 'Location' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <c>Location</c> feature of the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location => (byte) ((CacheConfiguration >> 0x05) & 0x0003);
        #endregion

        #region [private] (bool) CacheSocketed: Gets a value that represents the 'Cache Socketed' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <c>Cache Socketed</c> feature of the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool CacheSocketed => CacheConfiguration.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (byte) CacheLevel: Gets a value that represents the 'Cache Level' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <c>Cache Level</c> feature of the <c>Cache Configuration</c> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CacheLevel
        {
            get
            {
                byte level = (byte)(CacheConfiguration & 0x0007);
                level++;

                return level;
            }
        }
        #endregion

        #region [private] (int) MaximumCacheSize: Gets a value representing the 'Maximum Cache Size' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Cache Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumCacheSize => GetWord(0x07);
        #endregion

        #region [private] (int) InstalledSize: Gets a value representing the 'Installed Size' field
        /// <summary>
        /// Gets a value representing the <c>Installed Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int InstalledSize => GetWord(0x09);
        #endregion

        #region [private] (int) SupportedSramType: Gets a value representing the 'Supported SRAM Type' field
        /// <summary>
        /// Gets a value representing the <c>Supported SRAM Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int SupportedSramType => GetWord(0x0b);
        #endregion

        #region [private] (int) CurrentSramType: Gets a value representing the 'Current SRAM Type' field
        /// <summary>
        /// Gets a value representing the <c>Current SRAM Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CurrentSramType => GetWord(0x0d);
        #endregion

        #endregion

        #region Version 2.1+ fields

        #region [private] (byte) CacheSpeed: Gets a value representing the 'Cache Speed' field
        /// <summary>
        /// Gets a value representing the <c>Cache Speed</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CacheSpeed => GetByte(0x0F);
        #endregion

        #region [private] (byte) ErrorCorrectionType: Gets a value representing the 'Error Connection Type' field
        /// <summary>
        /// Gets a value representing the <c>Error Connection Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorCorrectionType => GetByte(0x10);
        #endregion

        #region [private] (byte) SystemCacheType: Gets a value representing the 'System Cache Type' field
        /// <summary>
        /// Gets a value representing the <c>System Cache Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemCacheType => GetByte(0x11);
        #endregion

        #region [private] (byte) Associativity: Gets a value representing the 'Associativity' field
        /// <summary>
        /// Gets a value representing the <c>Associativity</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Associativity => GetByte(0x12);
        #endregion

        #endregion

        #region Version 3.1.0+ fields

        #region [private] (uint) MaximumCacheSize2: Gets a value representing the 'Maximum Cache Size 2' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Cache Size 2</c> field.
        /// </summary>
        /// <value>
        /// Valor de la propiedad.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumCacheSize2 => (uint)GetDoubleWord(0x13);
        #endregion

        #region [private] (uint) InstalledCacheSize2: Gets a value representing the 'Installed Cache Size 2' field
        /// <summary>
        /// Gets a value representing the <c>Installed Cache Size 2</c> field.
        /// </summary>
        /// <value>
        /// Valor de la propiedad.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint InstalledCacheSize2 => (uint)GetDoubleWord(0x13);
        #endregion

        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            SmbiosType007Property propertyId = (SmbiosType007Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.0] - [Socket Designation] - [String]
                case SmbiosType007Property.SocketDesignation:
                    value = SocketDesignation;
                    break;
                #endregion

                #region [0x05] - [v2.0] - [Cache Configuration]

                    #region [0x05] - [v2.0] - [Cache Configuration -> Operational Mode] - [String]
                    case SmbiosType007Property.OperationalMode:
                        value = GetOperationalMode(OperationalMode);
                        break;
                    #endregion

                    #region [0x05] - [v2.0] - [Cache Configuration -> Enabled/Disabled] - [Boolean]
                    case SmbiosType007Property.CacheEnabled:
                        value = Enabled;                        
                        break;
                    #endregion

                    #region [0x05] - [v2.0] - [Cache Configuration -> Location] - [String]
                    case SmbiosType007Property.CacheLocation:
                        value = GetLocation(Location);                        
                        break;
                    #endregion

                    #region [0x05] - [v2.0] - [Cache Configuration -> Cache Socketed] - [Boolean]
                    case SmbiosType007Property.CacheSocketed:
                        value = CacheSocketed;                        
                        break;
                    #endregion

                    #region [0x05] - [v2.0] - [Cache Configuration -> Cache Level] - [Byte]
                    case SmbiosType007Property.CacheLevel:
                        value = CacheLevel;
                        break;
                    #endregion

                #endregion

                #region [0x07] - [v2.0] - [Maximum Cache Size] - [Int32]
                case SmbiosType007Property.MaximumCacheSize:
                    value = GetSize(MaximumCacheSize);
                    break;
                #endregion

                #region [0x09] - [v2.0] - [Installed Size] - [Int32?]
                case SmbiosType007Property.InstalledCacheSize:
                    if (InstalledSize != 0x00)
                    {
                        value = (int?)GetSize(InstalledSize);
                    }
                    break;
                #endregion

                #region [0x0b] - [v2.0] - [Supported SRAM Type] - [ReadOnlyCollection<String>]
                case SmbiosType007Property.SupportedSramTypes:
                    value = GetTypes(SupportedSramType);
                    break;
                #endregion

                #region [0x0d] - [v2.0] - [Current SRAM Type] - [String]
                case SmbiosType007Property.CurrentSramType:
                    ReadOnlyCollection<String> types = GetTypes(CurrentSramType);
                    string currentType = types[0];
                    value = currentType;
                    break;
                #endregion

                #region [0x0f] - [v2.1] - [Cache Speed] - [Byte?]
                case SmbiosType007Property.CacheSpeed:
                    if (HeaderInfo.Length >= 0x10)
                    {
                        if (CacheSpeed != 0x00)
                        {
                            value = (byte?)CacheSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x10] - [v2.1] - [Error Correction Type] - [String]
                case SmbiosType007Property.ErrorCorrectionType:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        value = GetErrorCorrection(ErrorCorrectionType);
                    }
                    break;
                #endregion

                #region [0x11] - [v2.1] - [System Cache Type] - [String]
                case SmbiosType007Property.SystemCacheType:
                    if (HeaderInfo.Length >= 0x12)
                    {
                        value = GetSystemCacheType(SystemCacheType);
                    }
                    break;
                #endregion

                #region [0x12] - [v2.1] - [Associativity] - [String]
                case SmbiosType007Property.Associativity:
                    if (HeaderInfo.Length >= 0x13)
                    {
                        value = GetAssociativity(Associativity);
                    }
                    break;
                #endregion

                #region [0x13] - [v3.1.0] - [Maximum Cache Size 2] - [UInt32]
                case SmbiosType007Property.MaximumCacheSize2:
                    if (HeaderInfo.Length >= 0x14)
                    {
                        value = GetSize(MaximumCacheSize2);
                    }
                    break;
                #endregion

                #region [0x17] - [v3.1.0] - [Installed Size 2] - [UInt32?]
                case SmbiosType007Property.InstalledCacheSize2:
                    if (HeaderInfo.Length >= 0x18)
                    {
                        if (InstalledCacheSize2 != 0x0000)
                        {
                            value = (uint?) GetSize(InstalledCacheSize2);
                        }
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(SmbiosPropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(SmbiosPropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region versions

            #region 2.0+
            if (HeaderInfo.Length >= 0x0f)
            {
                properties.Add(DmiProperty.Cache.SocketDesignation, SocketDesignation);
                properties.Add(DmiProperty.Cache.CacheConfiguration.OperationalMode, GetOperationalMode(OperationalMode));
                properties.Add(DmiProperty.Cache.CacheConfiguration.CacheEnabled, Enabled);
                properties.Add(DmiProperty.Cache.CacheConfiguration.Location, GetLocation(Location));
                properties.Add(DmiProperty.Cache.CacheConfiguration.CacheSocketed, CacheSocketed);
                properties.Add(DmiProperty.Cache.CacheConfiguration.Level, CacheLevel);
                properties.Add(DmiProperty.Cache.MaximumCacheSize, GetSize(MaximumCacheSize));

                if (InstalledSize != 0x00)
                {
                    properties.Add(DmiProperty.Cache.InstalledCacheSize, (int?)GetSize(InstalledSize));
                }

                properties.Add(DmiProperty.Cache.SupportedSramTypes, GetTypes(SupportedSramType));

                ReadOnlyCollection<string> types = GetTypes(CurrentSramType);
                string currentType = types[0];
                properties.Add(DmiProperty.Cache.CurrentSramType, currentType);
            }
            #endregion

            #region 2.1+
            if (HeaderInfo.Length >= 0x10)
            {
                if (CacheSpeed != 0x00)
                {
                    properties.Add(DmiProperty.Cache.CacheSpeed, CacheSpeed);
                }

                properties.Add(DmiProperty.Cache.ErrorCorrectionType, GetErrorCorrection(ErrorCorrectionType));
                properties.Add(DmiProperty.Cache.SystemCacheType, GetSystemCacheType(SystemCacheType));
                properties.Add(DmiProperty.Cache.Associativity, GetAssociativity(Associativity));
            }
            #endregion

            #region 3.1.0+
            if (HeaderInfo.Length >= 0x14)
            {
                properties.Add(DmiProperty.Cache.MaximumCacheSize2, GetSize(MaximumCacheSize2));

                if (InstalledCacheSize2 != 0x00)
                {
                    properties.Add(DmiProperty.Cache.InstalledCacheSize2, (int?)GetSize(InstalledCacheSize2));
                }
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetAssociativity(byte): Gets a string indicating the association mode of this cache
        /// <summary>
        /// Gets a <see cref="T:system.String"/> indicating the association mode of this cache.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>The association mode of this cache.</returns>
        private static string GetAssociativity(byte code)
        {
            string[] deviceProperty =
            {
                "Other",                  // 0x01
                "Unknown",
                "Direct Mapped",
                "2-way Set-Associative",
                "4-way Set-Associative",
                "Fully Associative",
                "8-way Set-Associative",
                "16-way Set-Associative",
                "12-way Set-Associative",
                "24-way Set-Associative",
                "32-way Set-Associative",
                "48-way Set-Associative",
                "64-way Set-Associative",
                "20-way Set-Associative"  // 0x0E
            };

            if (code >= 0x01 && code <= 0x0E)
            {
                return deviceProperty[code - 1];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetErrorCorrection(byte): Gets a string indicating the method of error correction
        /// <summary>
        /// Gets a <see cref="T:system.String"/> indicating the method of error correction.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>Method used for error correction.</returns>            
        private static string GetErrorCorrection(byte code)
        {
            string[] deviceProperty =
            {
                "Other",          // 0x01
                "Unknown",
                "None",
                "Parity",
                "Single-bit ECC",
                "Multi-bit ECC"   // 0x06
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return deviceProperty[code - 1];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetLocation(byte): Gets a string indicating the location of this cache against the processor
        /// <summary>
        /// Gets a <see cref="T:system.String"/> indicating the location of this cache against the processor.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>The location of this cache against the processor.</returns>            
        private static string GetLocation(byte code)
        {
            string[] deviceProperty =
            {
                "Internal", // 0x00
                "External",
                "Reserved",
                "Unknown"   // 0x03
            };

            return deviceProperty[code];
        }
        #endregion

        #region [private] {static} (string) GetOperationalMode(byte): Gets a string representing the operational mode
        /// <summary>
        /// Gets a <see cref="T:system.String"/> representing the operational mode.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>The operational mode.</returns>            
        private static string GetOperationalMode(byte code)
        {
            string[] deviceProperty =
            {
                "Write Through",              // 0x00
                "Write Back",
                "Varies With Memory Address",
                "Unknown"                     // 0x03
            };
                    
            return deviceProperty[code];
        }
        #endregion

        #region [private] {static} (int) GetSize(int): Gets a string that represents the cache size in Kb
        /// <summary>
        /// Gets a <see cref="T:System.String"/> that represents the cache size in Kb.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>The cache size in Kb.</returns>
        private static int GetSize(int code)
        {
            int size = code & 0x7fff;
            bool granularity64Kb = code.CheckBit(Bits.Bit15);
            if (granularity64Kb)
            {
                return size << 6;
            }

            return size;
        }
        #endregion

        #region [private] {static} (uint) GetSize(int): Gets a string that represents the cache size in Kb
        /// <summary>
        /// Gets a <see cref="T:System.String"/> that represents the cache size in Kb.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>The cache size in Kb.</returns>
        private static uint GetSize(uint code)
        {
            uint size = code & 0x7ffff;

            bool granularity64Kb = LogicHelper.CheckBit(code, Bits.Bit31);
            if (granularity64Kb)
            {
                return size << 6;
            }

            return size;
        }
        #endregion

        #region [private] {static} (string) GetSystemCacheType(byte): Gets a string representing the logical type of this cache
        /// <summary>
        /// Gets a <see cref="T:System.String"/> representing the logical type of this cache.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>The logical type of this cache.</returns>
        private static string GetSystemCacheType(byte code)
        {
            string[] deviceProperty =
            {
                "Other",       // 0x01
                "Unknown",
                "Instruction",
                "Data",
                "Unified"      // 0x05
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return deviceProperty[code - 1];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<String>) GetTypes(int): Gets a read-only collection of supported memory types
        /// <summary>
        /// Gets a read-only collection of supported memory types.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>A read-only collection of supported memory types.</returns>            
        private static ReadOnlyCollection<string> GetTypes(int code)
        {
            string[] deviceProperty =
            {
                "Other",          // 0x00
                "Unknown",
                "Non-burst",
                "Burst",
                "Pipeline Burst",
                "Synchronous",
                "Asynchronous"    // 0x06                                             
            };

            List<string> items = new List<string>();
            for (byte i = 0; i <= 6; i++)
            {
                bool addType = code.CheckBit(i);
                if (addType)
                {
                    items.Add(deviceProperty[i]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
