
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Property;

    // Type 042: Management Controller Host Interface.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        42          Management Controller Host Interface structure        |
    // |                                                      indicator.                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE                    Length of the structure, a minimum of 09h.            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Interface       BYTE        ENUM        Management Controller Interface Type.                 |
    // |              Type                                                                                          |
    // |                                                      Refer to Management Component Transport Protocol      |
    // |                                                      (MCTP) IDs and Codes (DSP0239) for the definition of  |
    // |                                                      the Interface Type values.                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Interface Type  BYTE        Varies                                                            |
    // |              Specific Data                                                                                 |
    // |              Data Length                                                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Interface Type  N           Varies      Management Controller Host Interface Data as specified|
    // |              Specific Data   BYTEs                   by the Interface Type. Refer to DSP0239 to locate the |
    // |                                                      value.                                                |
    // |                                                      This field has a minimum of four bytes. If interface  |
    // |                                                      type = OEM then the first four bytes are the vendor   |
    // |                                                      ID (MSB first), as assigned by the Internet Assigned  |
    // |                                                      Numbers Authority (IANA).                             |
    // |                                                      This format uses the "Enterprise Number" that is      |
    // |                                                      assigned and maintained by IANA (www.iana.org) as the |
    // |                                                      means of identifying a particular vendor, company, or |
    // |                                                      organization.                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h + N      Number of       N           X           X number of Protocol Records for this Host Interface  |
    // |              Protocol                                Type                                                  |
    // |              Records                                                                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h + N      Protocol        M           Varies      Protocol Records                                      |
    // |              Records         BYTEs                                                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Management Controller Host Interface (Type 42) structure.
    /// </summary>
    internal sealed class SmbiosType042 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType042(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType042"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType042(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) InterfaceType: Gets a value representing the 'Interface Type' field
        /// <summary>
        /// Gets a value representing the '<b>Interface Type</b>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterfaceType => Reader.GetByte(0x04);
        #endregion

        #region [private] (byte) InterfaceTypeSpecificDataLenght: Gets a value representing the 'Interface Type Specific Data Lenght' field
        /// <summary>
        /// Gets a value representing the '<b>Interface Type Specific Data Lenght</b>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterfaceTypeSpecificDataLenght => Reader.GetByte(0x05);
        #endregion

        #region [private] (ReadOnlyCollection<byte>) InterfaceTypeSpecificData: Gets a value representing the 'Interface Type Specific Data' field
        /// <summary>
        /// Gets a value representing the '<b>Interface Type Specific Data</b>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<byte> InterfaceTypeSpecificData => new ReadOnlyCollection<byte>(Reader.GetBytes(0x06, InterfaceTypeSpecificDataLenght));
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
            properties.Add(SmbiosProperty.ManagementControllerHostInterface.InterfaceType, GetInterfaceType(InterfaceType));

            if (StructureInfo.Length >= 0x07)
            {
                properties.Add(SmbiosProperty.ManagementControllerHostInterface.InterfaceTypeSpecificData, InterfaceTypeSpecificData);
            }

            if (StructureInfo.Length >= 0x08 + InterfaceTypeSpecificDataLenght)
            {
                properties.Add(SmbiosProperty.ManagementControllerHostInterface.Protocols, new ManagementControllerHostInterfaceProtocolRecordsCollection(GetProtocolRecords()));
            }
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (IEnumerable<ManagementControllerHostInterfaceProtocolRecord>) GetProtocolRecords(): Returns a protocol records collection
        /// <summary>
        /// Returns a protocol records collection.
        /// </summary>
        /// <returns>
        /// Protocol records collection
        /// </returns>
        private IEnumerable<ManagementControllerHostInterfaceProtocolRecord> GetProtocolRecords()
        {
            var protocolRecords = new Collection<ManagementControllerHostInterfaceProtocolRecord>();

            var n = InterfaceTypeSpecificDataLenght;
            var numberOfProtocolsRecords = Reader.GetByte((byte)(0x06 + n));

            var offset = (byte)0;
            for (var x = 0; x < numberOfProtocolsRecords ; x++)
            {
                var init = (byte)(0x07 + n + offset);
                if (StructureInfo.Length <= init + 1)
                {
                    break;
                }

                var m = Reader.GetByte((byte) (init + 0x01));
                offset = (byte) (0x02 + m);

                var protocolRecordsBytes = Reader.GetBytes(init, m);
                protocolRecords.Add(new ManagementControllerHostInterfaceProtocolRecord(protocolRecordsBytes));
            }

            return protocolRecords;
        }
        #endregion

        #endregion


        #region BIOS Specification 3.2.0 (26/04/2018)

        #region [private] {static} (string) GetInterfaceType(byte): Gets a string representing the type of interface
        /// <summary>
        /// Gets a string representing the type of interface.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The type of interface.
        /// </returns> 
        private static string GetInterfaceType(byte code)
        {
            string[] value =
            {
                "Unspecified",                                                         // 0x00 
                "SMBus 2.0 100 kHz compatible",
                "SMBus 2.0 + I2C 100 kHz compatible",
                "I2C 100 kHz compatible",
                "I2C 400 kHz compatible"                                               // 0x04
            };

            string[] value1 =
            {
                "PCIe 1.1 compatible",                                                 // 0x08 
                "PCIe 2.0 compatible",
                "PCIe 2.1 compatible",
                "PCIe 3.0 compatible"                                                  // 0x0b
            };

            string[] value2 =
            {
                "PCI compatible (PCI 1.0,2.0,2.1,2.2,2.3,3.0,PCI-X 1.0, PCI-X 2.0)",   // 0x0f 
                "USB 1.1 compatible",
                "USB 2.0 compatible",
                "USB 3.0 compatible"                                                   // 0x12
            };

            string[] value3 =
            {
                "RMII / NC-SI",                                                        // 0x18 
            };

            string[] value4 =
            {
                "KCS / Legacy",                                                        // 0x20
                "KCS / PCI",
                "Serial Host / Legacy (Fixed Address Decoding)",
                "Serial Host / PCI (Base Class 7 Subclass 0)",
                "Asynchronous Serial (Between MCs and IMDs)"                           // 0x24  
            };

            if (code <= 0x04)
            {
                return value[code];
            }

            if (code >= 0x08 && code <= 0x0b)
            {
                return value1[code - 0x08];
            }

            if (code >= 0x0f && code <= 0x12)
            {
                return value2[code - 0x12];
            }

            if (code == 0x18)
            {
                return value3[0];
            }

            if (code >= 0x20 && code <= 0x24)
            {
                return value4[code - 0x20];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
