
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Linq;

    using iTin.Core;

    using Property;

    // Type 001: System Information.
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                      |
    // | Offset   Version     Name                Length      Value       Description                                        |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        1           System Information Indicator                       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      08h for version 2.0                                |
    // |                                                                  19h for versions 2.1 – 2.3.4                       |
    // |                                                                  1Bh for version 2.4 and later                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Manufacturer        BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, Manufacturer                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        Product Name        BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  Note: Please see,ProductName                       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Version             BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, Version                          |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Serial Number       BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, SerialNumber                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.1+        UUID                16 BYTE's   Varies      Universal Unique ID number                         |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, GetUUID(byte[], uint)            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 18h      2.1+        Wake-up             BYTE        ENUM        Identifies the event that caused the system to     |
    // |                      Type                                        power up.                                          | 
    // |                                                                                                                     |
    // |                                                                  Note: Please see, GetWakeUpType(byte)              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 19h      2.4+        SKU Number          BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  This text string identifies a particular computer  |
    // |                                                                  configuration for sale. It is sometimes also       |
    // |                                                                  called a product ID or purchase order number.      |
    // |                                                                  This number is frequently found in existing        |
    // |                                                                  fields, but there is no standard format.           |
    // |                                                                  Typically for a given system board from a given    |
    // |                                                                  OEM, there are tens of unique processor, memory,   |
    // |                                                                  hard drive, and optical drive configurations.      |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, SkuNumber                        |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ah      2.4+        Family              BYTE        STRING      Number of null-terminated string                   |
    // |                                                                                                                     |
    // |                                                                  This text string identifies the family to which a  |
    // |                                                                  particular computer belongs. A family refers to    |
    // |                                                                  a set of computers that are similar but not        |
    // |                                                                  identical from a hardware or software point of     |
    // |                                                                  view. Typically, a family is composed of different |
    // |                                                                  computer models, which have different              |
    // |                                                                  configurations and pricing points.                 |
    // |                                                                  Computers in the same family often have similar    |
    // |                                                                  branding and cosmetic features.                    |
    // |                                                                                                                     |
    // |                                                                  Note: Please see, Family                           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Information (Type 1) structure.
    /// </summary>
    internal sealed class SmbiosType001 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType001(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType001"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType001(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Family: Gets a value representing the 'Family' field
        /// <summary>
        /// Gets a value representing the <b>Family</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Family
        {
            get
            {
                string ret;

                try
                {
                    ret = GetString(0x1A);
                }
                catch (ArgumentOutOfRangeException)
                {
                    ret = string.Empty;
                }

                return ret;
            }
        }
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Family</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x04);
        #endregion

        #region [private] (string) ProductName: Gets a value representing the 'Product name' field
        /// <summary>
        /// Gets a value representing the <b>Product name</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ProductName => GetString(0x05);
        #endregion

        #region [private] (string) Sku: Gets a value representing the 'Sku' field
        /// <summary>
        /// Gets a value representing the <b>Sku</b> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Sku => GetString(0x19);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial number' field
        /// <summary>
        /// Gets a value representing the <b>Serial number</b> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x07);
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <b>Version</b> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x06);
        #endregion

        #region [private] (byte) WakeUpType: Gets a value representing the 'Wake up type' field
        /// <summary>
        /// Gets a value representing the <b>Wake up type</b> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WakeUpType => Reader.GetByte(0x18);
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
                properties.Add(SmbiosProperty.System.Manufacturer, Manufacturer);
                properties.Add(SmbiosProperty.System.ProductName, ProductName);
                properties.Add(SmbiosProperty.System.Version, Version);
                properties.Add(SmbiosProperty.System.SerialNumber, SerialNumber);
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.System.WakeUpType, GetWakeUpType(WakeUpType));

                byte[] uuid = StructureInfo.RawData.Extract(0x08, 0x10).ToArray();
                properties.Add(SmbiosProperty.System.UUID, GetUuid(uuid, SmbiosVersion));
            }
            #endregion

            #region 2.4+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v24)
            {
                properties.Add(SmbiosProperty.System.SkuNumber, Sku);
                properties.Add(SmbiosProperty.System.Family, Family);
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetUUID(byte[], uint): Universal Unique ID number
        // UUID Byte Order and RFC4122 Field Names
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | Offset     RFC 4122 Name               Length     deviceProperty        Description                 |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 00h        time_low                    DWORD      Varies       The low field of the timestamp       |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 04h        time_mid                    WORD       Varies       The middle field of the timestamp    |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 06h        time_hi_and_version         WORD       Varies       The high field of the timestamp      |
        // |                                                                multiplexed with the version number  |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 08h        clock_seq_hi_and_reserved   BYTE       Varies       The high field of the clock sequence |
        // |                                                                multiplexed with the variant         |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 09h        clock_seq_low               BYTE       Varies       The low field of the clock sequence  |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        // | 0Ah        Node                        6 BYTEs    Varies       The spatially unique node identifier |
        // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
        /// <summary>
        /// Universal Unique ID number.
        /// </summary>
        /// <param name="uuid">UUID.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        /// A <see cref="string"/> containing Universal Unique ID number.
        private static string GetUuid(byte[] uuid, int smbiosVersion)
        {
            bool only0xFF = true;
            bool only0x00 = true;

            for (int i = 0; i < 16 && (only0x00 || only0xFF); i++)
            {
                if (uuid[i] != 0x00) only0x00 = false;
                if (uuid[i] != 0xFF) only0xFF = false;
            }

            if (only0xFF)
            {
                return "Not Present";
            }

            if (only0x00)
            {
                return "Not Settable";
            }

            // As off version 2.6 of the SMBIOS specification, the first 3 fields of the UUID are supposed to be encoded on little-endian.
            // The specification says that this is the defacto standard, however I've seen systems following RFC 4122 instead and use
            // network byte order, so I am reluctant to apply the byte-swapping for older versions.	        
            return 
                smbiosVersion >= 0x0206 
                    ? string.Format(
                        CultureInfo.InvariantCulture, 
                        "{{{0}{1}{2}{3}-{4}{5}-{6}{7}-{8}{9}-{10}{11}{12}{13}{14}{15}}}",                        
                        uuid[3].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[2].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[1].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[0].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[5].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[4].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[7].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[6].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[8].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[9].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[10].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[11].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[12].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[13].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[14].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[15].ToString("X2", CultureInfo.InvariantCulture))
                    : string.Format(
                        CultureInfo.InvariantCulture, 
                        "{{{0}{1}{2}{3}-{4}{5}-{6}{7}-{8}{9}-{10}{11}{12}{13}{14}{15}}}",
                        uuid[0].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[1].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[2].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[3].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[4].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[5].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[6].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[7].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[8].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[9].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[10].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[11].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[12].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[13].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[14].ToString("X2", CultureInfo.InvariantCulture),
                        uuid[15].ToString("X2", CultureInfo.InvariantCulture));
        }
        #endregion

        #region [private] {static} (string) GetWakeUpType(byte): Identifies the event that turns on the system
        /// <summary>
        /// Identifies the event that turns on the system.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A <see cref="string"/> containing the event that starts the system.
        /// </returns>
        private static string GetWakeUpType(byte code)
        {
            string[] deviceProperty =
            {
                "Reserved",         // 0x00
                "Other",
                "Unknown",
                "APM Timer",
                "Modem Ring",
                "LAN Remote",
                "Power Switch",
                "PCI PME#",
                "AC Power Restored" // 0x08
            };

            return 
                code <= 0x08 
                    ? deviceProperty[code] 
                    : SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
