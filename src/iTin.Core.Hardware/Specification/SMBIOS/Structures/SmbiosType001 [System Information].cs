
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;
    using Helpers;

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
    // —•————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
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
    // |                                                                 Note: Please see, Family                            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Information (Type 1) structure.
    /// </summary>
    sealed class SmbiosType001 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType001(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType001"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType001(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Family: Gets a value representing the 'Family' field.
        /// <summary>
        /// Gets a value representing the <c>Family</c> field.
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

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field.
        /// <summary>
        /// Gets a value representing the <c>Family</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer
        {
            get { return GetString(0x04); }
        }
        #endregion

        #region [private] (string) ProductName: Gets a value representing the 'Product name' field.
        /// <summary>
        /// Gets a value representing the <c>Product name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ProductName
        {
            get { return GetString(0x05); }
        }
        #endregion

        #region [private] (string) Sku: Gets a value representing the 'Sku' field.
        /// <summary>
        /// Gets a value representing the <c>Sku</c> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Sku
        {
            get { return GetString(0x19); }
        }
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial number' field.
        /// <summary>
        /// Gets a value representing the <c>Serial number</c> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber
        {
            get { return GetString(0x07); }
        }
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field.
        /// <summary>
        /// Gets a value representing the <c>Version</c> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version
        {
            get { return GetString(0x06); }
        }
        #endregion

        #region [private] (byte) WakeUpType: Gets a value representing the 'Wake up type' field.
        /// <summary>
        /// Gets a value representing the <c>Wake up type</c> field.
        /// </summary>
        /// <value>Property value.</value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WakeUpType
        {
            get { return GetByte(0x18); }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property.
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
            SmbiosType001Property propertyId = (SmbiosType001Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.0] - [Manufacturer] - [String]
                case SmbiosType001Property.Manufacturer:
                    value = Manufacturer;
                    break;
                #endregion

                #region [0x05] - [v2.0] - [Product Name] - [String]
                case SmbiosType001Property.ProductName:
                    value = ProductName;
                    break;
                #endregion

                #region [0x06] - [v2.0] - [Version] - [String]
                case SmbiosType001Property.Version:
                    value = Version;
                    break;
                #endregion

                #region [0x07] - [v2.0] - [Serial Number] - [String]
                case SmbiosType001Property.SerialNumber:
                    value = SerialNumber;
                    break;
                #endregion

                #region [0x08] - [v2.1] - [UUID] - [String]
                case SmbiosType001Property.UUID:
                    if (HeaderInfo.Lenght >= 0x09)
                    {
                        var uuid = new byte[16];
                        Array.Copy(HeaderInfo.RawData, 0x08, uuid, 0, 16);

                        value = GetUuid(uuid, SmbiosVersion);
                    }
                    break;
                #endregion

                #region [0x18] - [v2.1] - [Wake-up Type] - [String]
                case SmbiosType001Property.WakeUpType:
                    if (HeaderInfo.Lenght >= 0x19)
                    {
                        value = GetWakeUpType(WakeUpType);
                    }
                    break;
                #endregion           

                #region [0x19] - [v2.4] - [SKU Number] - [String]
                case SmbiosType001Property.SkuNumber:
                    if (HeaderInfo.Lenght >= 0x1a)
                    {
                        value = Sku;
                    }
                    break;
                #endregion

                #region [0x1a] - [v2.4] - [Family] - [String]
                case SmbiosType001Property.Family:
                    if (HeaderInfo.Lenght >= 0x1b)
                    {
                        value = Family;
                    }
                    break;                             
                #endregion        
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure.
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region versions

            #region 2.0+
            if (HeaderInfo.Lenght >= 0x08)
            {
                properties.Add(KnownDmiProperty.System.Manufacturer, Manufacturer);
                properties.Add(KnownDmiProperty.System.ProductName, ProductName);
                properties.Add(KnownDmiProperty.System.Version, Version);
                properties.Add(KnownDmiProperty.System.SerialNumber, SerialNumber);
            }
            #endregion

            #region 2.1+
            if (HeaderInfo.Lenght >= 0x19)
            {
                var uuid = new byte[16];
                Array.Copy(HeaderInfo.RawData, 0x08, uuid, 0, 16);
                properties.Add(KnownDmiProperty.System.WakeUpType, GetWakeUpType(WakeUpType));
                properties.Add(KnownDmiProperty.System.UUID, GetUuid(uuid, SmbiosVersion));
            }
            #endregion

            #region 2.4+
            if (HeaderInfo.Lenght >= 0x1b)
            {
                properties.Add(KnownDmiProperty.System.SkuNumber, Sku);
                properties.Add(KnownDmiProperty.System.Family, Family);
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetUUID(byte[], uint): Universal Unique ID number.
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
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        /// <returns></returns>
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
                        "{0}{1}{2}{3}-{4}{5}-{6}{7}-{8}{9}-{10}{11}{12}{13}{14}{15}",
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
                        "{0}{1}{2}{3}-{4}{5}-{6}{7}-{8}{9}-{10}{11}{12}{13}{14}{15}",
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
                        uuid[14].ToString("X", CultureInfo.InvariantCulture),
                        uuid[15].ToString("X2", CultureInfo.InvariantCulture));
        }
        #endregion

        #region [private] {static} (string) GetWakeUpType(byte): Identifies the event that turns on the system.
        /// <summary>
        /// Identifies the event that turns on the system.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>A <see cref="T:System.String" /> containing the event that starts the system.</returns>
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
