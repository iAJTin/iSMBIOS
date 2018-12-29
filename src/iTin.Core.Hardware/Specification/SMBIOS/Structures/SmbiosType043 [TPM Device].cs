
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

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

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the TPM Device (Type 43) structure.
    /// </summary>
    sealed class SmbiosType043 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType043(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType043"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType043(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 3.1.0+ fields

        #region [private] (string) VendorId: Gets a value representing the 'Vendor ID' field.
        /// <summary>
        ///  Gets a value representing the <c>Vendor ID</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string VendorId => GetBytes(HeaderInfo.RawData, 4, 4).ToString();
        #endregion

        #region [private] (string) DescriptionVersion2: Gets a value representing the 'Description Version 2' field.
        /// <summary>
        ///  Gets a value representing the <c>Description Version 2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DescriptionVersion2 => GetString(0x12);
        #endregion

        #region [private] (ulong) Characteristics: Gets a value representing the 'Characteristics' field.
        /// <summary>
        /// Gets a value representing the <c>Characteristics</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private ulong Characteristics => (ulong)GetQuadrupleWord(0x13);
        #endregion

        #region [private] (int) OemDefined: Gets a value representing the 'OEM Defined' field.
        /// <summary>
        /// Gets a value representing the <c>OEM Defined</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int OemDefined => GetDoubleWord(0x18);
        #endregion

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
            SmbiosType042Property propertyId = (SmbiosType042Property)propertyKey.PropertyId;

            //switch (propertyId)
            //{
            //    #region [0x04] - [Interface Type] - [String]
            //    case SmbiosType042Property.InterfaceType:
            //        value = GetInterfaceType(InterfaceType);
            //        break;
            //    #endregion
            //}

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
            //properties.Add(KnownDmiProperty.ManagementControllerHostInterface.InterfaceType, GetInterfaceType(InterfaceType));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.1.0 (21/11/2016)


        #endregion

        private byte[] GetBytes(byte[] sequence, byte start, byte len)
        {            
            IEnumerable<byte> query = sequence.TakeWhile((item, index) => index >= start && index <= len);

           return query.ToArray();
        }
    }
}
