
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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
    // | 13h      3.1+        Maximum Cache       DWORD       Bit Field   If this field is present, for cache sizes of |
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
    // | 17h      3.1+        Installed Cache     DWORD       Bit Field   Same format as Maximum Cache Size 2 field;   |
    // |                      Size 2                                      Absent or set to 0 if no cache is installed. |
    // |                                                                  See 7.8.1.                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Cache Information (Type 7) structure.
    /// </summary>
    internal sealed class SmbiosType007 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType007(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType007"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType007(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.0+ fields

        #region [private] (string) SocketDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <b>Socket Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SocketDesignation => GetString(0x04);
        #endregion

        #region [private] (ushort) CacheConfiguration: Gets a value representing the 'Cache Configuration' field
        /// <summary>
        /// Gets a value representing the <b>Cache Configuration</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CacheConfiguration => (ushort)Reader.GetWord(0x05);
        #endregion

        #region [private] (byte) OperationalMode:  Gets a value that represents the 'Operational Mode' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <b>bcOperational Mode</b> feature of the <b>Cache Configuration</b> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte OperationalMode => (byte) ((CacheConfiguration >> 0x08) & 0x0003);
        #endregion

        #region [private] (bool) Enabled: Gets a value that represents the 'Enabled' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <b>Enabled</b> feature of the <b>Cache Configuration</b> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Enabled => CacheConfiguration.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (byte) Location: Gets a value that represents the 'Location' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <b>Location</b> feature of the <b>Cache Configuration</b> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location => (byte) ((CacheConfiguration >> 0x05) & 0x0003);
        #endregion

        #region [private] (bool) CacheSocketed: Gets a value that represents the 'Cache Socketed' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <b>Cache Socketed</b> feature of the <b>Cache Configuration</b> field.
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool CacheSocketed => CacheConfiguration.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (byte) CacheLevel: Gets a value that represents the 'Cache Level' feature of the 'Cache Configuration' field
        /// <summary>
        /// Gets a value that represents the <b>Cache Level</b> feature of the <b>Cache Configuration</b> field.
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

        #region [private] (ushort) MaximumCacheSize: Gets a value representing the 'Maximum Cache Size' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Cache Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MaximumCacheSize => (ushort)Reader.GetWord(0x07);
        #endregion

        #region [private] (ushort) InstalledSize: Gets a value representing the 'Installed Size' field
        /// <summary>
        /// Gets a value representing the <b>Installed Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort InstalledSize => (ushort)Reader.GetWord(0x09);
        #endregion

        #region [private] (ushort) SupportedSramType: Gets a value representing the 'Supported SRAM Type' field
        /// <summary>
        /// Gets a value representing the <b>Supported SRAM Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort SupportedSramType => (ushort)Reader.GetWord(0x0b);
        #endregion

        #region [private] (ushort) CurrentSramType: Gets a value representing the 'Current SRAM Type' field
        /// <summary>
        /// Gets a value representing the <b>Current SRAM Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CurrentSramType => (ushort)Reader.GetWord(0x0d);
        #endregion

        #endregion

        #region Version 2.1+ fields

        #region [private] (byte) CacheSpeed: Gets a value representing the 'Cache Speed' field
        /// <summary>
        /// Gets a value representing the <b>Cache Speed</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CacheSpeed => Reader.GetByte(0x0f);
        #endregion

        #region [private] (byte) ErrorCorrectionType: Gets a value representing the 'Error Connection Type' field
        /// <summary>
        /// Gets a value representing the <b>Error Connection Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorCorrectionType => Reader.GetByte(0x10);
        #endregion

        #region [private] (byte) SystemCacheType: Gets a value representing the 'System Cache Type' field
        /// <summary>
        /// Gets a value representing the <b>System Cache Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemCacheType => Reader.GetByte(0x11);
        #endregion

        #region [private] (byte) Associativity: Gets a value representing the 'Associativity' field
        /// <summary>
        /// Gets a value representing the <b>Associativity</b>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Associativity => Reader.GetByte(0x12);
        #endregion

        #endregion

        #region Version 3.1.0+ fields

        #region [private] (uint) MaximumCacheSize2: Gets a value representing the 'Maximum Cache Size 2' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Cache Size 2</b> field.
        /// </summary>
        /// <value>
        /// Valor de la propiedad.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint MaximumCacheSize2 => (uint)Reader.GetDoubleWord(0x13);
        #endregion

        #region [private] (uint) InstalledCacheSize2: Gets a value representing the 'Installed Cache Size 2' field
        /// <summary>
        /// Gets a value representing the <b>Installed Cache Size 2</b> field.
        /// </summary>
        /// <value>
        /// Valor de la propiedad.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint InstalledCacheSize2 => (uint)Reader.GetDoubleWord(0x13);
        #endregion

        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            #region 2.0+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v20)
            {
                properties.Add(SmbiosProperty.Cache.SocketDesignation, SocketDesignation);
                properties.Add(SmbiosProperty.Cache.CacheConfiguration.OperationalMode, GetOperationalMode(OperationalMode));
                properties.Add(SmbiosProperty.Cache.CacheConfiguration.CacheEnabled, Enabled);
                properties.Add(SmbiosProperty.Cache.CacheConfiguration.Location, GetLocation(Location));
                properties.Add(SmbiosProperty.Cache.CacheConfiguration.CacheSocketed, CacheSocketed);
                properties.Add(SmbiosProperty.Cache.CacheConfiguration.Level, CacheLevel);
                properties.Add(SmbiosProperty.Cache.MaximumCacheSize, GetSize(MaximumCacheSize));
                properties.Add(SmbiosProperty.Cache.InstalledCacheSize, GetSize(InstalledSize));
                properties.Add(SmbiosProperty.Cache.SupportedSramTypes, GetTypes(SupportedSramType));

                ReadOnlyCollection<string> types = GetTypes(CurrentSramType);
                string currentType = types[0];
                properties.Add(SmbiosProperty.Cache.CurrentSramType, currentType);
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.Cache.CacheSpeed, CacheSpeed);
                properties.Add(SmbiosProperty.Cache.ErrorCorrectionType, GetErrorCorrection(ErrorCorrectionType));
                properties.Add(SmbiosProperty.Cache.SystemCacheType, GetSystemCacheType(SystemCacheType));
                properties.Add(SmbiosProperty.Cache.Associativity, GetAssociativity(Associativity));
            }
            #endregion

            #region 3.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v31)
            {
                properties.Add(SmbiosProperty.Cache.MaximumCacheSize2, GetSize(MaximumCacheSize2));
                properties.Add(SmbiosProperty.Cache.InstalledCacheSize2, GetSize(InstalledCacheSize2));
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetAssociativity(byte): Gets a string indicating the association mode of this cache
        /// <summary>
        /// Gets a <see cref="string"/> indicating the association mode of this cache.
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
        /// Gets a <see cref="string"/> indicating the method of error correction.
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
        /// Gets a <see cref="string"/> indicating the location of this cache against the processor.
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
        /// Gets a <see cref="string"/> representing the operational mode.
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
        /// Gets a <see cref="string"/> that represents the cache size in Kb.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The cache size in Kb.
        /// </returns>
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
        /// Gets a <see cref="string"/> that represents the cache size in Kb.
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
        /// Gets a <see cref="string"/> representing the logical type of this cache.
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
