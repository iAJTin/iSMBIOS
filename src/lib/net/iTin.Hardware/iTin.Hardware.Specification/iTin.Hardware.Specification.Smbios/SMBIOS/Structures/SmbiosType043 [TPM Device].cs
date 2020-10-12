
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    using iTin.Core;

    using Property;
    using Tpm;

    // Type 043: TPM Device.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        43          TPM Device                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        1Fh         Length of the structure                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      Handle, or instance number, associated with the       |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Vendor ID       4           Varies      Specified as four ASCII characters, as defined by TCG |
    // |                              BYTEs                   Vendor ID (see CAP_VID in TCG Vendor ID Registry).    |
    // |                                                                                                            |
    // |                                                      For example:                                          |
    // |                                                          Vendor ID string of "ABC" = (41 42 43 00)         |
    // |                                                          Vendor ID string of "ABCD" = (41 42 43 44)        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Major Spec      BYTE        Varies      Major TPM version supported by the TPM device.        |
    // |              Version                                 For rexample,                                         |
    // |                                                        · The value is 01h for TPM v1.2 and is 02h for      |
    // |                                                          TPM v2.0.                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Minor Spec      BYTE        Varies      Major TPM version supported by the TPM device.        |
    // |              Version                                 For rexample,                                         |
    // |                                                        · The value is 02h for TPM v1.2 and is 00h for      |
    // |                                                          TPM v2.0.                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Firmware        DWORD       Varies      For Major Spec Version 01h, this field contains the   |
    // |              Version 1                               TPM_VERSION structure defined in the TPM Main         |
    // |                                                      Specification, Part 2, Section 5.3.                   |
    // |                                                                                                            |
    // |                                                      For Major Spec Version 02h, this field contains the   |
    // |                                                      most significant 32 bits of a TPM vendor-specific     |
    // |                                                      value for firmware version (please see                |
    // |                                                      TPM_PT_FIRMWARE_VERSION_1 in TPM Structures spec.)    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Firmware        DWORD       Varies      For Major Spec Version 01h, this field contains 00h   |
    // |              Version 2                                                                                     |
    // |                                                      For Major Spec Version 02h, this field contains the   |
    // |                                                      least significant 32 bits of a TPM vendor-specific    |
    // |                                                      value for firmware version (please see                |
    // |                                                      TPM_PT_FIRMWARE_VERSION_2 in TPM Structures spec.)    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Description     BYTE        STRING      String number of descriptive information of the TPM   |
    // |              Version 2                               device                                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h          Characteristics QWORD       Varies      TPM device characteristics information (see 7.44.1)   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Bh          OEM-defined     DWORD       Varies      OEM- or BIOS vendor-specific information              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the TPM Device (Type 43) structure.
    /// </summary>
    internal sealed class SmbiosType043 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType043(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType043"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType043(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte[]) VendorId: Gets a value representing the 'Vendor ID' field
        /// <summary>
        ///  Gets a value representing the <b>Vendor ID</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawVendorId => Reader.GetBytes(0x04, 0x04);
        #endregion

        #region [private] (byte) MajorSpecVersion: Gets a value representing the 'Major Spec Version' field
        /// <summary>
        ///  Gets a value representing the <b>Major Spec Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MajorSpecVersion => Reader.GetByte(0x08);
        #endregion

        #region [private] (byte) MinorSpecVersion: Gets a value representing the 'Minor Spec Version' field
        /// <summary>
        ///  Gets a value representing the <b>Minor Spec Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MinorSpecVersion => Reader.GetByte(0x09);
        #endregion

        #region [private] (byte[]) RawFirmwareVersion1: Gets a value representing the 'Firmware Version 1' field
        /// <summary>
        ///  Gets a value representing the <b>Firmware Version 1</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawFirmwareVersion1 => Reader.GetBytes(0x0a, 0x04);
        #endregion

        #region [private] (byte[]) RawFirmwareVersion2: Gets a value representing the 'Firmware Version 2' field
        /// <summary>
        ///  Gets a value representing the <b>Firmware Version 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawFirmwareVersion2 => Reader.GetBytes(0x0e, 0x04);
        #endregion

        #region [private] (string) DescriptionVersion2: Gets a value representing the 'Description Version 2' field
        /// <summary>
        ///  Gets a value representing the <b>Description Version 2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DescriptionVersion2 => GetString(0x12);
        #endregion

        #region [private] (ulong) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private ulong Characteristics => (ulong)Reader.GetQuadrupleWord(0x13);
        #endregion

        #region [private] (uint) OemDefined: Gets a value representing the 'OEM Defined' field
        /// <summary>
        /// Gets a value representing the <b>OEM Defined</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private uint OemDefined => (uint)Reader.GetDoubleWord(0x1b);
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
            if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
            {
                return;
            }

            TpmCapabilityVendorId tpmCapabilityVendorIdEntry = GetTpmCapabilityVendorId(RawVendorId);
            properties.Add(SmbiosProperty.TpmDevice.VendorId, tpmCapabilityVendorIdEntry.ASCII);
            properties.Add(SmbiosProperty.TpmDevice.VendorIdDescription, tpmCapabilityVendorIdEntry.Description);
            properties.Add(SmbiosProperty.TpmDevice.MajorSpecVersion, MajorSpecVersion);
            properties.Add(SmbiosProperty.TpmDevice.MinorSpecVersion, MinorSpecVersion);

            var firmwareVersion = TpmFirmwareVersion.Unknown;
            if (MajorSpecVersion >= 0x01 && MajorSpecVersion <= 0x02)
            {
                firmwareVersion =
                    MajorSpecVersion == 0x01
                        ? TpmFirmwareVersion.Parse(RawFirmwareVersion1)
                        : new TpmFirmwareVersion
                        {
                            MajorVersion = (int) Reader.GetDoubleWord(0x0a),
                            MinorVersion = (int) Reader.GetDoubleWord(0x0e)
                        };
            }

            properties.Add(SmbiosProperty.TpmDevice.FirmwareVersion, firmwareVersion);
            properties.Add(SmbiosProperty.TpmDevice.Description, DescriptionVersion2);
            properties.Add(SmbiosProperty.TpmDevice.Characteristics, GetTpmCharacteristics(Characteristics));
            properties.Add(SmbiosProperty.TpmDevice.OemDefined, OemDefined);
        }
        #endregion

        #endregion


        #region BIOS Specification 3.1.0 (21/11/2016)

        #region [private] {static} (ReadOnlyCollection<string>) GetTpmCharacteristics(byte): Gets a collection of TPM characteristics
        /// <summary>
        /// Gets a collection of <b>TPM</b> characteristics.
        /// </summary>
        /// <param name="target">Value to analyze</param>
        /// <returns>
        /// Collection of <b>TPM</b> characteristics.
        /// </returns>            
        private static ReadOnlyCollection<string> GetTpmCharacteristics(ulong target)
        {
            string[] value =
            {
                "TPM Device Characteristics are not supported",                          // 0x02           
                "Family configurable via firmware update",
                "Family configurable via platform software support, such as BIOS Setup",
                "Family configurable via OEM proprietary mechanism"                      // 0x05                                    
            };

            List<string> items = new List<string>();
            for (byte i = 2; i < 6; i++)
            {
                bool addCharacteristic = target.CheckBit(i);
                if (addCharacteristic)
                {
                    items.Add(value[i - 0x02]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (string) PopulatesVendorId(IEnumerable<byte>): Returns a string that contains vendor id field
        /// <summary>
        /// Returns a string that contains vendor id field.
        /// </summary>
        /// <param name="data">Vendor Id raw data</param>
        /// <returns>
        /// A <see cref="string"/> containing vendor id field.
        /// </returns>
        private static string PopulatesVendorId(IEnumerable<byte> data)
        {
            var builder = new StringBuilder(); 

            foreach (var item in data)
            {
                if (item == 0x00)
                {
                    continue;
                }

                builder.Append((char) item);
            }

            return builder.ToString();
        }
        #endregion

        #endregion

        #region TPM Vendor ID Registry 1.01 (18/10/2017), for more info please see, TpmCapabilityVendorId class

        #region [private] {static} (TpmCapabilityVendorId) GetTpmCapabilityVendorId(byte[]): Returns TPM vendor information from hexadecimal vendor data
        /// <summary>
        /// Returns <b>TPM vendor information</b> from hexadecimal vendor data. For more info please see, <see cref="TpmCapabilityVendorId"/> class.
        /// </summary>
        /// <param name="data">target vendor id data</param>
        /// <returns>
        /// A <see cref="TpmCapabilityVendorId"/> thats contains vendor information.
        /// </returns>
        private static TpmCapabilityVendorId GetTpmCapabilityVendorId(byte[] data)
        {
            var knownTpmCapabilityVendors = new Collection<TpmCapabilityVendorId>
            {
                TpmCapabilityVendorId.AMD,
                TpmCapabilityVendorId.Atmel,
                TpmCapabilityVendorId.Broadcom,
                TpmCapabilityVendorId.HPE,
                TpmCapabilityVendorId.IBM,
                TpmCapabilityVendorId.Infineon,
                TpmCapabilityVendorId.Intel,
                TpmCapabilityVendorId.Lenovo,
                TpmCapabilityVendorId.Microsoft,
                TpmCapabilityVendorId.NationalSemiconductor,
                TpmCapabilityVendorId.Nationz,
                TpmCapabilityVendorId.NuvotonTechnology,
                TpmCapabilityVendorId.Qualcomm,
                TpmCapabilityVendorId.SMSC,
                TpmCapabilityVendorId.STMicroelectronics,
                TpmCapabilityVendorId.Samsung,
                TpmCapabilityVendorId.Sinosun,
                TpmCapabilityVendorId.TexasInstruments,
                TpmCapabilityVendorId.Winbond,
                TpmCapabilityVendorId.FuzhouRockchip,
                TpmCapabilityVendorId.Google
            };

            var cadidateEntry = knownTpmCapabilityVendors.FirstOrDefault(entry => entry.Hex.SequenceEqual(data));
            if (cadidateEntry != null)
            {
                return cadidateEntry;
            }

            var newEntry = PopulatesVendorId(data);
            return new TpmCapabilityVendorId
            {
                Hex = data,
                ASCII = newEntry,
                Description = newEntry
            };
        }
        #endregion

        #endregion
    }
}
