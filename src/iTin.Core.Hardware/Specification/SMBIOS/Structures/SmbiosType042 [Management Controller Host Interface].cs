
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

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
    // | 05h          MC Host         n           Varies      Management Controller Host Interface Data as specified|
    // |              Interface       BYTEs                   by the Interface Type. Refer to DSP0239 to locate the |
    // |              Data                                    specification that corresponds to the Interface Type  |
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

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Management Controller Host Interface (Type 42) structure.
    /// </summary>
    sealed class SmbiosType042 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType042(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType042"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType042(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) InterfaceType: Gets a value representing the 'Interface Type' field.
        /// <summary>
        /// Gets a value representing the <c>Interface Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterfaceType => GetByte(0x04);
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

            switch (propertyId)
            {
                #region [0x04] - [Interface Type] - [String]
                case SmbiosType042Property.InterfaceType:
                    value = GetInterfaceType(InterfaceType);
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
            properties.Add(KnownDmiProperty.ManagementControllerHostInterface.InterfaceType, GetInterfaceType(InterfaceType));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetInterfaceType(byte): Gets a string representing the type of interface.
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
