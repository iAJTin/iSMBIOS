
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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
    // |                                                                For version 3.1 and later implementations, the length  |
    // |                                                                is at least 1Ah because bytes 14-19h are defined.      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle            WORD        Varies                                                             |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Vendor            BYTE        STRING      String number of the BIOS Vendor’s Name                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        BIOS Version      BYTE        STRING      String number of the BIOS Version. This value is a     |
    // |                                                                free-form string that may contain Core and OEM version |
    // |                                                                information.                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        BIOS Starting     WORD        Varies      Segment location of BIOS starting address (for         |
    // |                      Address Segment                           example, 0E800h). When not applicable, such as on      |
    // |                                                                UEFI-based systems, this value is set to 0000h.        |
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

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Bios Information (Type 0) structure.
    /// </summary>
    internal sealed class SmbiosType000 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType000(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType000"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType000(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (ulong) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong Characteristics => (ulong)Reader.GetQuadrupleWord(0x0a);
        #endregion

        #region [private] (byte) ExtensionByte1: Gets a value representing the 'Extension byte 1' field
        /// <summary>
        /// Gets a value representing the <b>Extension byte 1</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ExtensionByte1 => Reader.GetByte(0x12);
        #endregion

        #region [private] (byte) ExtensionByte2: Gets a value representing the 'Extension byte 2' field
        /// <summary>
        /// Gets a value representing the <b>Extension byte 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ExtensionByte2 => Reader.GetByte(0x13);
        #endregion

        #region [private] (byte) FirmwareMajorRelease: Gets a value representing the 'Firmware major release' field
        /// <summary>
        /// Gets a value representing the <b>Firmware major release</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareMajorRelease => Reader.GetByte(0x16);
        #endregion

        #region [private] (byte) FirmwareMinorRelease: Gets a value representing the 'Firmware minor release' field
        /// <summary>
        /// Gets a value representing the <b>Firmware minor release</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareMinorRelease => Reader.GetByte(0x17);
        #endregion

        #region [private] (string) BiosReleaseDate: Gets a value representing the 'Bios release date' field
        /// <summary>
        /// Gets a value representing the <b>Bios release date</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosReleaseDate => GetString(0x08);
        #endregion

        #region [private] (byte) RomSize: Gets a value representing the 'Rom size' field
        /// <summary>
        /// Gets a value representing the <b>Rom size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte RomSize => (byte)((Reader.GetByte(0x09) + 1) << 6);
        #endregion

        #region [private] (string) BiosStartSegment: Gets a value representing the 'Bios starting address segment' field
        /// <summary>
        /// Gets a value representing the <b>Bios starting address segment</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosStartSegment => $"{Reader.GetWord(0x06):X}";
        #endregion

        #region [private] (byte) SystemBiosMajorRelease: Gets a value representing the 'System bios major release' field
        /// <summary>
        /// Gets a value representing the <b>System bios major release</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemBiosMajorRelease => Reader.GetByte(0x14);
        #endregion

        #region [private] (byte) SystemBiosMinorRelease: Gets a value representing the 'System bios minor release' field
        /// <summary>
        /// Gets a value representing the <b>System bios minor release</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SystemBiosMinorRelease => Reader.GetByte(0x15);
        #endregion

        #region [private] (string) Vendor: Gets a value representing the 'Vendor' field
        /// <summary>
        /// Gets a value representing the <b>Vendor</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Vendor => GetString(0x04);
        #endregion

        #region [private] (string) BiosVersion: Gets a value representing the 'Bios version' field
        /// <summary>
        /// Gets a value representing the <b>Bios version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BiosVersion => GetString(0x05);
        #endregion

        #region [private] (ushort) ExtendedBiosRomSizeRawInfo: Gets a value representing the 'Extended bios rom size raw info' field
        /// <summary>
        /// Gets a value representing the <b>Extended bios rom size raw info</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ExtendedBiosRomSizeRawInfo => (ushort)Reader.GetWord(0x18);
        #endregion

        #region [private] (ushort) ExtendedBiosRomSize: Gets a value representing the 'Extended bios rom size' field
        /// <summary>
        /// Gets a value representing the <b>Extended bios rom size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ExtendedBiosRomSize => (ushort)(ExtendedBiosRomSizeRawInfo & 0x3fff);
        #endregion

        #region [private] (MemorySizeUnit) ExtendedBiosRomSizeUnits: Gets a value representing the 'Extended bios rom size units' field
        /// <summary>
        /// Gets a value representing the <b>Extended bios rom size units</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MemorySizeUnit ExtendedBiosRomSizeUnits
        {
            get
            {
                int value = (ushort)(ExtendedBiosRomSizeRawInfo & 0xc000);
                byte unit = (byte)(value.GetByte(Bytes.Byte03) >> 2);

                return
                    unit >= 2
                        ? MemorySizeUnit.Reserved
                        : (MemorySizeUnit)unit;
            }
        }
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
                properties.Add(SmbiosProperty.Bios.Vendor, Vendor);
                properties.Add(SmbiosProperty.Bios.BiosVersion, BiosVersion);
                properties.Add(SmbiosProperty.Bios.BiosStartSegment, BiosStartSegment);
                properties.Add(SmbiosProperty.Bios.BiosReleaseDate, BiosReleaseDate);
                properties.Add(SmbiosProperty.Bios.BiosRomSize, RomSize);
                properties.Add(SmbiosProperty.Bios.Characteristics, GetCharacteristics(Characteristics));
            }
            #endregion

            #region 2.4+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v24)
            {
                properties.Add(SmbiosProperty.Bios.CharacteristicsExtensionByte1, GetExtensionByte1(ExtensionByte1));
                properties.Add(SmbiosProperty.Bios.CharacteristicsExtensionByte2, GetExtensionByte2(ExtensionByte2));
                properties.Add(SmbiosProperty.Bios.SystemBiosMajorRelease, SystemBiosMajorRelease);
                properties.Add(SmbiosProperty.Bios.SystemBiosMinorRelease, SystemBiosMinorRelease);
                properties.Add(SmbiosProperty.Bios.FirmwareMajorRelease, FirmwareMajorRelease);
                properties.Add(SmbiosProperty.Bios.FirmwareMinorRelease, FirmwareMinorRelease);
            }
            #endregion

            #region 3.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v31)
            {
                properties.Add(SmbiosProperty.Bios.ExtendedBiosRomSize, ExtendedBiosRomSize);
                properties.Add(SmbiosProperty.Bios.BiosRomSizeUnit, ExtendedBiosRomSizeUnits);
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 3.5.0 (15/09/2021)

        #region [private] {static} (ReadOnlyCollection<string>) GetCharacteristics(ulong): Define which functions supports the BIOS: PCI, PCMCIA, Flash, etc
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
                "Virtual machine",
                "Manufacturing mode is supported",
                "Manufacturing mode is enabled",
                "Reserved"
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

        #endregion
    }
}
