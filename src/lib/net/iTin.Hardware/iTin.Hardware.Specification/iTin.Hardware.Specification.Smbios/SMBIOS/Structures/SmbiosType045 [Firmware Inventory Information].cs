
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 045: Firmware Inventory Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        45          Firmware Inventory Information                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure, computed by the BIOS as 24 + |
    // |                                                      (2 *n), where n is the Number of Associated           |
    // |                                                      Components                                            |
    // |                                                      NOTE: To allow future structure growth by appending   |
    // |                                                            information after the Associated Components     |
    // |                                                            Handles list, this field must not be used to    |
    // |                                                            determine the number of Associated Components   |
    // |                                                            Handles specified within the structure.         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      Handle, or instance number, associated with the       |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Firmware        BYTE        STRING      String number of the Firmware Component Name.         |
    // |              Component Name                          EXAMPLE: ‘BMC Firmware’,0                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Firmware        BYTE        STRING      String number of the Firmware Version of this         |
    // |              Version                                 firmware.                                             |
    // |                                                      The format of this value is defined by the Version    |
    // |                                                      Format.                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Version Format  BYTE        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Firmware ID     BYTE        STRING      String number of the Firmware ID of this firmware.    |
    // |                                                      The format of this value is defined by the Firmware   |
    // |                                                      ID Format.                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Firmware ID     BYTE        Varies                                                            |
    // |              Format                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Release         BYTE        STRING      String number of the firmware release date            |
    // |              Date                                    The date string, if supplied, follows the Date-Tim    |
    // |                                                      values format, as defined in DSP0266.                 |
    // |                                                                                                            |
    // |                                                      EXAMPLE: '2021-05-15T04:14:33+06:00',0                |
    // |                                                                                                            |
    // |                                                      EXAMPLE: When the time is unknown or not specified.   |
    // |                                                               '2021-05-15T00:00:00Z',0                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Manufacturer    BYTE        STRING      String number of the manufacturer or producer of this |
    // |                                                      firmware                                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Lowest          BYTE        STRING      String number of the lowest version to which this     |
    // |              Supported                               firmware can be rolled back to. The format of this    |
    // |              Firmware                                value is defined by the Version Format.               |
    // |              Version                                                                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Image Size      QWORD       Varies      Size of the firmware image that is currently          |
    // |                                                      programmed in the device, in bytes. If the Firmware   |
    // |                                                      Image Size is unknown, the field is set to            |
    // |                                                      FFFFFFFFFFFFFFFFh                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h          Characteristics WORD        Bit Field   Firmware characteristics information                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 16h          State           BYTE        Varies      Firmware state information                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h          Number of       BYTE        Varies      Defines how many Associated Component Handles are     |
    // |              Associated                              associated with this firmware.                        |
    // |              Components (n)                                                                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 18h          Associated       n WORDS     Varies     Lists the SMBIOS structure handles that are           |
    // |              Components                              associated with this firmware, if any. Value of       |
    // |              Handles                                 Number of Associated Components field (n) defines the |
    // |                                                      count.                                                |
    // |                                                                                                            |
    // |                                                      NOTE: This list may contain zero or more handles to   |
    // |                                                            any SMBIOS structure that represents a device   |
    // |                                                            with a firmware component. For example, this    |
    // |                                                                                                            |
    // |                                                            · Type 9 handle (for describing the firmware of |
    // |                                                              a device in a slot)                           |
    // |                                                                                                            |
    // |                                                            · Type 17 handle (for describing the firmware   |
    // |                                                              of a memory device)                           |
    // |                                                                                                            |
    // |                                                            · Type 41 handle (for describing the firmware   |
    // |                                                              of an onboard device)                         |
    // |                                                                                                            |
    // |                                                            · Type 43 handle (for describing the firmware   |
    // |                                                              of a TPM device)                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Firmware Inventory Information (Type 45) structure.
    /// </summary>
    internal sealed class SmbiosType045 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType045(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType045"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType045(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 3.5 fields

        #region [private] (string) FirmwareComponentName: Gets a value representing the 'Firmware Component Name' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Component Name</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareComponentName => GetString(0x04);
        #endregion

        #region [private] (string) FirmwareVersion: Gets a value representing the 'Firmware Version' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareVersion => GetString(0x05);
        #endregion

        #region [private] (byte) FirmwareVersionFormat: Gets a value representing the 'Firmware Version format' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Version Format</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareVersionFormat => Reader.GetByte(0x06);
        #endregion

        #region [private] (string) FirmwareId: Gets a value representing the 'Firmware Id' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Id</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareId => GetString(0x07);
        #endregion

        #region [private] (byte) FirmwareIdFormat: Gets a value representing the 'Firmware Id Format' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Id Format</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareIdFormat => Reader.GetByte(0x08);
        #endregion

        #region [private] (string) FirmwareReleaseDate: Gets a value representing the 'Firmware Release Date' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Release Date</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareReleaseDate => GetString(0x09);
        #endregion

        #region [private] (string) FirmwareManufacturer: Gets a value representing the 'Firmware Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareManufacturer => GetString(0x0a);
        #endregion

        #region [private] (string) LowestSupportedFirmwareVersion: Gets a value representing the 'Lowest Supported Firmware Version' field
        /// <summary>
        /// Gets a value representing the <b>Lowest Supported Firmware Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string LowestSupportedFirmwareVersion => GetString(0x0b);
        #endregion

        #region [private] (ulong) FirmwareImageSize: Gets a value representing the 'Firmware Image Size' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Image Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong FirmwareImageSize => (ulong) Reader.GetQuadrupleWord(0x17);
        #endregion

        #region [private] (int) FirmwareCharacteristics: Gets a value representing the 'Firmware Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Firmware Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int FirmwareCharacteristics => Reader.GetWord(0x14);
        #endregion

        #region [private] (byte) FirmwareState: Gets a value representing the 'Firmware State' field
        /// <summary>
        /// Gets a value representing the <b>Firmware State</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FirmwareState => Reader.GetByte(0x16);
        #endregion

        #region [private] (byte) NumberOfAssociatedComponentsCount: Gets a value representing the 'Number Of Associated Components (n)' field
        /// <summary>
        /// Gets a value representing the <b>Number Of Associated Components (n)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfAssociatedComponentsCount => Reader.GetByte(0x17);
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
            #region 3.5
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v35)
            {
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareComponentName, FirmwareComponentName);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareVersion, FirmwareVersion);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareVersionFormat, GetFirmwareVersionFormat(FirmwareVersionFormat));
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareId, FirmwareId);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareIdFormat, GetFirmwareIdFormat(FirmwareIdFormat));
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareReleaseDate, FirmwareReleaseDate);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareManufacturer, FirmwareManufacturer);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.LowestSupportedFirmwareVersion, LowestSupportedFirmwareVersion);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareImageSize, FirmwareImageSize);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareCharacteristics, GetFirmwareCharacteristics(FirmwareCharacteristics));
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.FirmwareState, GetFirmwareState(FirmwareState));
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.NumberOfAssociatedComponents, NumberOfAssociatedComponentsCount);
                properties.Add(SmbiosProperty.FirmwareInventoryInformation.AssociatedComponentHandles, GetAssociatedComponentHandles(NumberOfAssociatedComponentsCount));
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 3.5.0 (15/09/2021)

        #region [private] {static} (string) GetFirmwareVersionFormat(byte): Gets a string representing the current firmware version format
        /// <summary>
        /// Gets a string representing the current firmware version format.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The current firmware version format.
        /// </returns>
        private static string GetFirmwareVersionFormat(byte code)
        {
            string[] value =
            {
                "Other",              // 0x01
                "Unknown",
                "Disabled",
                "Enabled",
                "Absent",
                "StandbyOffline",
                "StandbySpare",
                "UnavailableOffline", // 0x08
            };

            if (code >= 0x01 && code <= 0x08)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetFirmwareIdFormat(byte): Gets a string representing the current firmware id format
        /// <summary>
        /// Gets a string representing the current firmware id format.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The current firmware id format.
        /// </returns>
        private static string GetFirmwareIdFormat(byte code)
        {
            if (code >= 0x00 && code <= 0x01)
            {
                string[] value =
                {
                    "Free-form string",
                    "UEFI GUID or UEFI Firmware Management Protocol Image TypeId"
                };

                if (code >= 0x00 && code <= 0x01)
                {
                    return value[code];
                }
            }
            else if (code >= 0x02 && code <= 0x7f)
            {
                return "Future assignment by this specification";
            }
          
            return "BIOS Vendor/OEM-specific";
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) FirmwareCharacteristics(int): Gets a string representing the current firmware Characteristics
        /// <summary>
        /// Gets a string representing the current firmware Characteristics.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The current firmware Characteristics.
        /// </returns>
        private static ReadOnlyCollection<string> GetFirmwareCharacteristics(int code)
        {
            var values = new Collection<string>();

            var isUpdatable = code.CheckBit(Bits.Bit00);
            if (isUpdatable)
            {
                values.Add("Updatable: This firmware can be updated by software.");
            }

            var writeProtect = code.CheckBit(Bits.Bit01);
            if (writeProtect)
            {
                values.Add("Write-Protect: This firmware is in a write-protected state.");
            }

            return new ReadOnlyCollection<string>(values);
        }
        #endregion

        #region [private] {static} (string) GetFirmwareState(byte): Gets a string representing the current firmware state
        /// <summary>
        /// Gets a string representing the current firmware state.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The current firmware state.
        /// </returns>
        private static string GetFirmwareState(byte code)
        {
            string[] value =
            {
                "Other",              // 0x01
                "Unknown",
                "Disabled",
                "Enabled",
                "Absent",
                "StandbyOffline",
                "StandbySpare",
                "UnavailableOffline", // 0x08
            };

            if (code >= 0x01 && code <= 0x08)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (IEnumerable<uint>) GetAssociatedComponentHandles(byte): Gets collecion with Associated Component Handles
        private IEnumerable<uint> GetAssociatedComponentHandles(byte count)
        {
            var values = new Collection<uint>();
            for (byte i = 0, offset=0; i < count; i++, offset+=2)
            {
                values.Add((uint) Reader.GetWord((byte)(0x18 + offset)));
            }

            return values;
        }
        #endregion

        #endregion
    }
}
