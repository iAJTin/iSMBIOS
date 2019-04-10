
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Text;

    using Dmi.Property;
    using Helpers;

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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the TPM Device (Type 43) structure.
    /// </summary>
    sealed class SmbiosType043 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType043(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType043" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType043(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 3.1.0+ fields

        #region [private] (byte[]) VendorId: Gets a value representing the 'Vendor ID' field
        /// <summary>
        ///  Gets a value representing the <c>Vendor ID</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawVendorId => GetBytes(0x04, 0x04);
        #endregion

        #region [private] (byte) MajorSpecVersion: Gets a value representing the 'Major Spec Version' field
        /// <summary>
        ///  Gets a value representing the <c>Major Spec Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MajorSpecVersion => GetByte(0x08);
        #endregion

        #region [private] (byte) MinorSpecVersion: Gets a value representing the 'Minor Spec Version' field
        /// <summary>
        ///  Gets a value representing the <c>Minor Spec Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MinorSpecVersion => GetByte(0x09);
        #endregion

        #region [private] (int) FirmwareVersion1: Gets a value representing the 'Firmware Version 1' field
        /// <summary>
        ///  Gets a value representing the <c>Firmware Version 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int FirmwareVersion1 => GetDoubleWord(0x0a);
        #endregion

        #region [private] (int) FirmwareVersion2: Gets a value representing the 'Firmware Version 2' field
        /// <summary>
        ///  Gets a value representing the <c>Firmware Version 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int FirmwareVersion2 => GetDoubleWord(0x0a);
        #endregion

        #region [private] (string) DescriptionVersion2: Gets a value representing the 'Description Version 2' field
        /// <summary>
        ///  Gets a value representing the <c>Description Version 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DescriptionVersion2 => GetString(0x12);
        #endregion

        #region [private] (ulong) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Characteristics</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private ulong Characteristics => (ulong)GetQuadrupleWord(0x13);
        #endregion

        #region [private] (int) OemDefined: Gets a value representing the 'OEM Defined' field
        /// <summary>
        /// Gets a value representing the <c>OEM Defined</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int OemDefined => GetDoubleWord(0x1b);
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
            SmbiosType043Property propertyId = (SmbiosType043Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Vendor Id] - [string]
                case SmbiosType043Property.VendorId:
                    value = PopulatesVendorId(RawVendorId);
                    break;
                #endregion

                #region [0x08] - [Major Spec Version] - [byte]
                case SmbiosType043Property.MajorSpecVersion:
                    value = MajorSpecVersion;
                    break;
                #endregion

                #region [0x09] - [Minor Spec Version] - [byte]
                case SmbiosType043Property.MinorSpecVersion:
                    value = MinorSpecVersion;
                    break;
                #endregion

                #region [0x12] - [Description Version 2] - [string]
                case SmbiosType043Property.Description:
                    value = DescriptionVersion2;
                    break;
                #endregion

                #region [0x13] - [Characteristics] - [ReadOnlyCollection<string>]
                case SmbiosType043Property.Characteristics:
                    value = GetTpmCharacteristics(Characteristics);
                    break;
                #endregion

                #region [0x1b] - [OEM Defined] - [int]
                case SmbiosType043Property.OemDefined:
                    value = OemDefined;
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure
        /// <inheritdoc />
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
            properties.Add(KnownDmiProperty.TpmDevice.VendorId, PopulatesVendorId(RawVendorId));
            properties.Add(KnownDmiProperty.TpmDevice.MajorSpecVersion, MajorSpecVersion);
            properties.Add(KnownDmiProperty.TpmDevice.MinorSpecVersion, MinorSpecVersion);
            properties.Add(KnownDmiProperty.TpmDevice.Description, DescriptionVersion2);
            properties.Add(KnownDmiProperty.TpmDevice.Characteristics, GetTpmCharacteristics(Characteristics));
            properties.Add(KnownDmiProperty.TpmDevice.OemDefined, OemDefined);
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.1.0 (21/11/2016)

        #region [private] {static} (string) PopulatesVendorId(IEnumerable<byte>): Returns a string that contains vendor id field
        /// <summary>
        /// Returns a string that contains vendor id field.
        /// </summary>
        /// <param name="data">Vendor Id raw data</param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing vendor id field.
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

        #region [private] {static} (ReadOnlyCollection<string>) GetTpmCharacteristics(byte): Gets a collection of TPM characteristics
        /// <summary>
        /// Gets a collection of <c>TPM</c> characteristics.
        /// </summary>
        /// <param name="target">Value to analyze</param>
        /// <returns>
        /// Collection of <c>TPM</c> characteristics.
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

        #endregion
    }
}
