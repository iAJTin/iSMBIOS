
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 000: BIOS Information
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                        |
    // | Offset   Version     Name              Length      Value       Description                                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type              BYTE        0           BIOS Information Indicator                             |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length            BYTE        Varies      12h + number of BIOS Characteristics Extension         |
    // |                                                                Bytes. If no Extension Bytes are used the Length is    |
    // |                                                                12h. For version 2.1 and 2.2 implementations, the      |
    // |                                                                length is 13h because one extension byte is defined.   |
    // |                                                                For version 2.3 and later implementations, the length  |
    // |                                                                is at least 14h because two extension bytes are        |
    // |                                                                defined. For version 2.4 and later implementations,    |
    // |                                                                the length is at least 18h because bytes 14-17h are    |
    // |                                                                defined.                                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle            WORD        Varies                                                             |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Vendor            BYTE        STRING      Número o cadena terminada en nulo.                     |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        BIOS Version      BYTE        STRING      Número o cadena terminada en nulo.                     |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        BIOS Starting     WORD        Varies      Segment location of BIOS starting address (for         |
    // |                      Address Segment                           example, 0E800h).                                      |
    // |                                                                                                                       |
    // |                                                                NOTE: The size of the runtime BIOS image can be        |
    // |                                                                computed by subtracting the Starting Address Segment   |
    // |                                                                from 10000h and multiplying the result by 16.          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        BIOS Release      BYTE        STRING      String number of the BIOS release date. The date       |
    // |                      Date                                      string, if supplied, is in either mm/dd/yy or          |
    // |                                                                mm/dd/yyyy format. If the year portion of the string   |
    // |                                                                is two digits, the year is assumed to be 19yy.         |
    // |                                                                                                                       |
    // |                                                                NOTE: The mm/dd/yyyy format is required for SMBIOS     |
    // |                                                                version 2.3 and later.                                 |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.0+        BIOS ROM Size     BYTE        Varies(n)   Size(n) where 64K * (n+1) is the size of the physical  |
    // |                                                                device containing the BIOS, in bytes                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.0+        BIOS              QWORD       Bit Field   Defines which functions the BIOS supports: PCI,        |
    // |                      Characteristics                           PCMCIA, Flash, etc. (see 7.1.1).                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.4+        BIOS              Zero or     Bit Field   Optional space reserved for future supported           |
    // |                      Characteristics   more BYTEs              functions. The number of Extension Bytes that are      |
    // |                      Extension Bytes                           present is indicated by the Length in offset 1 minus   |
    // |                                                                12h. See 7.1.2 for extensions defined for version 2.1  |
    // |                                                                and later implementations. For version 2.4 and later   |
    // |                                                                implementations, two BIOS Characteristics              |
    // |                                                                Extension Bytes are defined (12-13h) and bytes 14-     |
    // |                                                                17h are also defined.                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.4+        System BIOS       BYTE        Varies      Identifies the major release of the System BIOS; for   |
    // |                      Major Release                             example, the deviceProperty is 0Ah for revision 10.22  |
    // |                                                                and 02h for revision 2.1.                              |
    // |                                                                This field and/or the System BIOS Minor Release        |
    // |                                                                field is updated each time a System BIOS update for    |
    // |                                                                a given system is released.                            |  
    // |                                                                If the system does not support the use of this field,  |
    // |                                                                the deviceProperty is 0FFh for both this field and     |
    // |                                                                the System BIOS Minor Release field.                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.4+        System BIOS       BYTE        Varies      Identifies the minor release of the System BIOS; for   |
    // |                      Minor Release                             example, the deviceProperty is 16h for revision 10.22  |
    // |                                                                and 01h for revision 2.1.                              |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 16h      2.4+        Embedded          BYTE        Varies      Identifies the major release of the embedded           |
    // |                      Controller                                controller firmware; for example, the deviceProperty   |
    // |                      Firmware Major                            would be 0Ah for revision 10.22 and 02h for revision   |
    // |                      Release                                   2.1. This field and/or the Embedded Controller         |
    // |                                                                Firmware Minor Release field is updated each time an   |
    // |                                                                embedded controller firmware update for a given        |
    // |                                                                system is released.                                    |
    // |                                                                                                                       | 
    // |                                                                If the system does not have field upgradeable embedded |
    // |                                                                controller firmware, the device Property is 0FFh.      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h      2.4+        Embedded          BYTE        Varies      Identifies the minor release of the embedded           |
    // |                      Controller                                controller firmware; for example, the device Property  |
    // |                      Firmware Minor                            is 16h for revision 10.22 and 01h for revision 2.1.    |
    // |                      Release                                                                                          |
    // |                                                                If the system does not have field upgradeable embedded |
    // |                                                                controller firmware, the deviceProperty is 0FFh.       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 18h      3.1+        Extended BIOS     WORD        Bit Field   Extended size of the physical device(s)                |
    // |                      ROM Size                                  containing the BIOS, rounded up if needed.             |
    // |                                                                                                                       |
    // |                                                                Bits 15:14     Unit                                    |
    // |                                                                               00b - megabytes                         |
    // |                                                                               01b - gigabytes                         |
    // |                                                                               10b - reserved                          |
    // |                                                                               11b - reserved                          |
    // |                                                                                                                       |
    // |                                                                Bits 13:0      Size                                    |
    // |                                                                                                                       |
    // |                                                                Examples: a 16 MB device would be represented as       |
    // |                                                                0010h. A 48 GB device set would be represented as      |
    // |                                                                0100 0000 0011 0000b or 4030h.                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Bios Information (Type 0) structure.
    /// </summary>
    sealed class SmbiosType000 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType000(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType000" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType000(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (ulong) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Characteristics</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong Characteristics => (ulong)GetQuadrupleWord(0x0a);
        #endregion

        #region [private] (byte) ExtensionByte1: Gets a value representing the 'Extension byte 1' field
        /// <summary>
        /// Gets a value representing the <c>Extension byte 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ExtensionByte1 => GetByte(0x12);
        #endregion

        #region [private] (byte) ExtensionByte2: Gets a value representing the 'Extension byte 2' field
        /// <summary>
        /// Gets a value representing the <c>Extension byte 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ExtensionByte2 => GetByte(0x13);
        #endregion

        #region [private] (byte) FirmwareMajorRelease: Gets a value representing the 'Firmware major release' field
        /// <summary>
        /// Gets a value representing the <c>Firmware major release</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareMajorRelease => GetByte(0x16);
        #endregion

        #region [private] (byte) FirmwareMinorRelease: Gets a value representing the 'Firmware minor release' field
        /// <summary>
        /// Gets a value representing the <c>Firmware minor release</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareMinorRelease => GetByte(0x17);
        #endregion

        #region [private] (string) BiosReleaseDate: Gets a value representing the 'Bios release date' field
        /// <summary>
        /// Gets a value representing the <c>Bios release date</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosReleaseDate => GetString(0x08);
        #endregion

        #region [private] (int) RomSize: Gets a value representing the 'Rom size' field
        /// <summary>
        /// Gets a value representing the <c>Rom size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int RomSize => (GetByte(0x09) + 1) << 6;
        #endregion

        #region [private] (string) BiosStartingAddressSegment: Gets a value representing the 'Bios starting address segment' field
        /// <summary>
        /// Gets a value representing the <c>Bios starting address segment</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosStartingAddressSegment => $"{GetWord(0x06):X}";
        #endregion

        #region [private] (byte) SystemBiosMajorRelease: Gets a value representing the 'System bios major release' field
        /// <summary>
        /// Gets a value representing the <c>System bios major release</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemBiosMajorRelease => GetByte(0x14);
        #endregion

        #region [private] (byte) SystemBiosMinorRelease: Gets a value representing the 'System bios minor release' field
        /// <summary>
        /// Gets a value representing the <c>System bios minor release</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemBiosMinorRelease => GetByte(0x15);
        #endregion

        #region [private] (string) Vendor: Gets a value representing the 'Vendor' field
        /// <summary>
        /// Gets a value representing the <c>Vendor</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Vendor => GetString(0x04);
        #endregion

        #region [private] (string) BiosVersion: Gets a value representing the 'Bios version' field
        /// <summary>
        /// Gets a value representing the <c>Bios version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosVersion => GetString(0x05);
        #endregion

        #region [private] (int) ExtendedBiosRomSizeRawInfo: Gets a value representing the 'Extended bios rom size raw info' field
        /// <summary>
        /// Gets a value representing the <c>Extended bios rom size raw info</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ExtendedBiosRomSizeRawInfo => GetWord(0x18);
        #endregion

        #region [private] (int) ExtendedBiosRomSize: Gets a value representing the 'Extended bios rom size' field
        /// <summary>
        /// Gets a value representing the <c>Extended bios rom size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ExtendedBiosRomSize => ExtendedBiosRomSizeRawInfo & 0x3fff;
        #endregion

        #region [private] (int) ExtendedBiosRomSizeUnits: Gets a value representing the 'Extended bios rom size units' field
        /// <summary>
        /// Gets a value representing the <c>Extended bios rom size units</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MemorySizeUnit ExtendedBiosRomSizeUnits
        {
            get
            {
                int value = ExtendedBiosRomSizeRawInfo & 0xc000;
                byte unit = value.GetByte(Bytes.Byte03);

                return
                    unit >= 2 
                        ? MemorySizeUnit.Reserved 
                        : (MemorySizeUnit) unit;
            }
        }
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
            SmbiosType000Property propertyId = (SmbiosType000Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.0] - [Vendor] - [String]
                case SmbiosType000Property.Vendor:
                    value = Vendor;
                    break;
                #endregion

                #region [0x05] - [v2.0] - [BiosVersion] - [String]
                case SmbiosType000Property.BiosVersion:
                    value = BiosVersion;
                    break;
                #endregion

                #region [0x06] - [v2.0] - [BIOS Starting Address Segment] - [String]
                case SmbiosType000Property.BiosStartingAddressSegment:
                    value = BiosStartingAddressSegment;
                    break;
                #endregion

                #region [0x08] - [v2.0] - [BIOS Release Date] - [String]
                case SmbiosType000Property.BiosReleaseDate:
                    value = BiosReleaseDate;
                    break;
                #endregion

                #region [0x09] - [v2.0] - [Bios Rom Size] - [Int32]
                case SmbiosType000Property.BiosRomSize:
                    value = RomSize;
                    break;
                #endregion

                #region [0x0a] - [v2.0] - [BIOS Characteristics] - [ReadOnlyCollection<String>]
                case SmbiosType000Property.Characteristics:
                    value = GetCharacteristics(Characteristics);
                    break;
                #endregion

                #region [0x12] - [v2.1] - [BIOS Characteristics Extension Bytes]

                #region [0x12] - [v2.1] - [BIOS Characteristics Extension Bytes -> ExtensionByte1] - [ReadOnlyCollection<String>]
                case SmbiosType000Property.ExtensionByte1:
                    if (HeaderInfo.Length >= 0x13)
                    {
                        value = GetExtensionByte1(ExtensionByte1);
                    }
                    break;
                #endregion

                #region [0x13] - [v2.1] - [BIOS Characteristics Extension Bytes -> ExtensionByte2] - [ReadOnlyCollection<String>]
                case SmbiosType000Property.ExtensionByte2:
                    if (HeaderInfo.Length >= 0x14)
                    {
                        value = GetExtensionByte1(ExtensionByte2);
                    }
                    break;
                #endregion

                #endregion

                #region [0x14] - [v2.4] - [System Bios Major Release] - [Byte?]
                case SmbiosType000Property.SystemBiosMajorRelease:
                    if (HeaderInfo.Length >= 0x15)
                    {
                        value = (byte?)SystemBiosMajorRelease;
                    }
                    break;
                #endregion

                #region [0x15] - [v2.4] - [System Bios Minor Release] - [Byte?]
                case SmbiosType000Property.SystemBiosMinorRelease:
                    if (HeaderInfo.Length >= 0x16)
                    {
                        value = (byte?)SystemBiosMinorRelease;
                    }
                    break;
                #endregion

                #region [0x16] - [v2.4] - [Embedded Controller Firmware Major Release] - [Byte?]
                case SmbiosType000Property.FirmwareMajorRelease:
                    if (HeaderInfo.Length >= 0x17)
                    {
                        value = (byte?)FirmwareMajorRelease;
                    }
                    break;
                #endregion

                #region [0x17] - [v2.4] - [Embedded Controller Firmware Minor Release] - [Byte?]
                case SmbiosType000Property.FirmwareMinorRelease:
                    if (HeaderInfo.Length >= 0x18)
                    {
                        value = (byte?)FirmwareMinorRelease;
                    }
                    break;
                #endregion

                #region [0x18] - [v3.1] - [Extended BIOS ROM Size]

                #region [0x18] - [v3.1] - [Extended BIOS ROM -> Size] - [Int32]
                case SmbiosType000Property.ExtendedBiosRomSize:
                    if (HeaderInfo.Length >= 0x19)
                    {
                        value = ExtendedBiosRomSize;
                    }
                    break;
                #endregion

                #region [0x18] - [v3.1] - [Extended BIOS ROM -> Unit] - [MemorySizeUnit]
                case SmbiosType000Property.ExtendedBiosRomSizeUnit:
                    if (HeaderInfo.Length >= 0x19)
                    {
                        value = ExtendedBiosRomSizeUnits;
                    }
                    break;
                #endregion

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

            #region 2.0
            if (HeaderInfo.Length >= 0x12)
            {
                properties.Add(KnownDmiProperty.Bios.Vendor, Vendor);
                properties.Add(KnownDmiProperty.Bios.BiosVersion, BiosVersion);
                properties.Add(KnownDmiProperty.Bios.BiosStartingAddressSegment, BiosStartingAddressSegment);
                properties.Add(KnownDmiProperty.Bios.BiosReleaseDate, BiosReleaseDate);
                properties.Add(KnownDmiProperty.Bios.BiosRomSize, RomSize);
                properties.Add(KnownDmiProperty.Bios.Characteristics, GetCharacteristics(Characteristics));
            }
            #endregion

            #region 2.1 - 2.2
            if (HeaderInfo.Length >= 0x13)
            {
                properties.Add(KnownDmiProperty.Bios.ExtensionByte1, GetExtensionByte1(ExtensionByte1));
            }
            #endregion

            #region 2.3
            if (HeaderInfo.Length >= 0x14)
            {
                properties.Add(KnownDmiProperty.Bios.ExtensionByte2, GetExtensionByte2(ExtensionByte2));
            }
            #endregion

            #region 2.4+
            if (HeaderInfo.Length >= 0x14)
            {
                properties.Add(KnownDmiProperty.Bios.SystemBiosMajorRelease, SystemBiosMajorRelease);
                properties.Add(KnownDmiProperty.Bios.SystemBiosMinorRelease, SystemBiosMinorRelease);
                properties.Add(KnownDmiProperty.Bios.FirmwareMajorRelease, FirmwareMajorRelease);
                properties.Add(KnownDmiProperty.Bios.FirmwareMinorRelease, FirmwareMinorRelease);
            }
            #endregion

            #region 3.1+
            if (HeaderInfo.Length >= 0x19)
            {
                properties.Add(KnownDmiProperty.Bios.ExtendedBiosRomSize, ExtendedBiosRomSize);
                properties.Add(KnownDmiProperty.Bios.ExtendedBiosRomSizeUnit, ExtendedBiosRomSizeUnits);
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (ReadOnlyCollection<string>) GetCharacteristics(ulong): Define which functions supports the BIOS: PCI, PCMCIA, Flash, etc.
        /// <summary>
        /// Define which functions supports the BIOS: PCI, PCMCIA, Flash, etc.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A read-only collection containing the characteristics.
        /// </returns>
        private static ReadOnlyCollection<string> GetCharacteristics(ulong code)
        {
            string[] deviceProperty =
            {
                "BIOS characteristics not supported", // 3
                "ISA is supported",
                "MCA is supported",
                "EISA is supported",
                "PCI is supported",
                "PC Card (PCMCIA) is supported",
                "PNP is supported",
                "APM is supported",
                "BIOS is upgradeable",
                "BIOS shadowing is allowed",
                "VLB is supported",
                "ESCD support is available",
                "Boot from CD is supported",
                "Selectable boot is supported",
                "BIOS ROM is socketed",
                "Boot from PC Card (PCMCIA) is supported",
                "EDD is supported",
                "Japanese floppy for NEC 9800 1.2 MB is supported (int 13h)",
                "Japanese floppy for Toshiba 1.2 MB is supported (int 13h)",
                "5.25\"/360 kB floppy services are supported (int 13h)",
                "5.25\"/1.2 MB floppy services are supported (int 13h)",
                "3.5\"/720 kB floppy services are supported (int 13h)",
                "3.5\"/2.88 MB floppy services are supported (int 13h)",
                "Print screen service is supported (int 5h)",
                "8042 keyboard services are supported (int 9h)",
                "Serial services are supported (int 14h)",
                "Printer services are supported (int 17h)",
                "CGA/mono video services are supported (int 10h)",
                "NEC PC-98" // 31
            };

            List<string> items = new List<string>();
            if ((code & (1 << 3)) == 1 << 3)
            {
                items.Add(deviceProperty[0]);
            }

            for (int i = 4; i <= 31; i++)
            {
                if ((code & (ulong) (1 << i)) == (ulong) (1 << i))
                {
                    items.Add(deviceProperty[i - 3]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetExtensionByte1(byte): Space reserved for future BIOS functions (byte 01)
        /// <summary>
        /// space reserved for future BIOS functions (byte 01).
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A read-only collection containing the future BIOS functions (byte 01)
        /// </returns>
        private static ReadOnlyCollection<string> GetExtensionByte1(byte code)
        {
            string[] deviceProperty =
            {
                "ACPI is supported",
                "USB legacy is supported",
                "AGP is supported",
                "I2O boot is supported",
                "LS-120 boot is supported",
                "ATAPI Zip drive boot is supported",
                "IEEE 1394 boot is supported",
                "Smart battery is supported"
            };

            List<string> items = new List<string>();
            for (byte i = 0; i <= 7; i++)
            {
                bool addItem = code.CheckBit(i);
                if (addItem)
                {
                    items.Add(deviceProperty[i]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetExtensionByte2(byte): Space reserved for future BIOS functions (byte 02)
        /// <summary>
        /// space reserved for future BIOS functions (byte 01).
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A read-only collection containing the future BIOS functions (byte 02)
        /// </returns>
        private static ReadOnlyCollection<string> GetExtensionByte2(byte code)
        {
            string[] deviceProperty =
            {
                "BIOS boot specification is supported",
                "Function key-initiated network boot is supported",
                "Targeted content distribution is supported",
                "UEFI Specification is supported",
                "Virtual machine"
            };

            List<string> items = new List<string>();
            for (byte i = 0; i <= 4; i++)
            {
                bool addItem = code.CheckBit(i);
                if (addItem)
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
