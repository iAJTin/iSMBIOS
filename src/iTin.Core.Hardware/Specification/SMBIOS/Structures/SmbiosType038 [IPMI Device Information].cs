
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 038: IPMI Device Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        38          IPMI Device Information                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure, a minimum of 10h             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Interface Type  BYTE        ENUM        Baseboard Management Controller (BMC) interface type. |
    // |                                                      NOTE: Ver GetInterfaceType(byte)                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          IPMI            BYTE        Varies      Identifies the IPMI Specification Revision, in BCD    |
    // |              Specification                           format, to which the BMC was designed.                |
    // |              Revision                                Bits 07:04 - Hold the most significant digit of the   |
    // |                                                                   revision                                 |
    // |                                                      Bits 03:00 - Hold the least significant bits.         |
    // |                                                                                                            |
    // |                                                      EXAMPLE: A value of 10h indicates revision 1.0.       |
    // |                                                      NOTE: Ver SpecificationRevision                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          I2C Slave       BYTE        Varies      The slave address on the I2C bus of this BMC.         |
    // |              Address                                                                                       |
    // |                                                      NOTE: Ver I2CSlaveAddress                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          NV Storage      BYTE        Varies      Bus ID of the NV storage device. If no storage device |
    // |              Device Address                          exists for this BMC, the field is set to 0FFh.        |
    // |                                                      NOTE: Ver BusId                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Base Address    QWORD       Varies      Identifies the base address (either memory-mapped or  |
    // |                                                      I/O) of the BMC. If the least-significant bit of the  |
    // |                                                      field is a 1, the address is in I/O space; otherwise, |
    // |                                                      the address is memorymapped.                          |
    // |                                                      Refer to the IPMI Interface Specification for usage   |
    // |                                                      details                                               |
    // |                                                      NOTE: Ver BaseAddress                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          Base Address    BYTE        Varies      Base Address Modifier (This field is unused and set   |
    // |              Modifier /                              to 00h for SSIF.)                                     |
    // |              Interrupt Info                                                                                |
    // |                                                      Bits 07:06 – Register spacing                         |
    // |                                                                   00b - Interface registers are on         |
    // |                                                                         successive byte boundaries.        |
    // |                                                                   01b - Interface registers are on 32-bit  |
    // |                                                                         boundaries.                        |
    // |                                                                   10b - Interface registers are on 16-byte |
    // |                                                                         boundaries.                        |
    // |                                                                   11b - Reserved.                          |
    // |                                                      Note: Ver GetRegisterSpacing(byte)                    |
    // |                                                                                                            |
    // |                                                      Bit  05 – Reserved. Return as 0b.                     |
    // |                                                                                                            |
    // |                                                      Bit  04 – LS-bit for addresses:                       |
    // |                                                                0b = Address bit 0 = 0b                     |
    // |                                                                1b = Address bit 0 = 1b                     |
    // |                                                      Note: Ver LsBit                                       |
    // |                                                                                                            |
    // |                                                      Interrupt Info                                        |
    // |                                                      Identifies the type and polarity of the interrupt     |
    // |                                                      associated with the IPMI system interface, if any:    |
    // |                                                      Bit 03 – Interrupt Info                               |
    // |                                                               1b - Interrupt information specified         |
    // |                                                               0b - Interrupt information not specified     |
    // |                                                      Note: Ver SpecifiedInfo                               |
    // |                                                                                                            |
    // |                                                      Bit 02 – Reserved. Return as 0b                       |
    // |                                                                                                            |
    // |                                                      Bit 01 – Interrupt Polarity                           |
    // |                                                               1b - active high                             |
    // |                                                               0b - active low                              |
    // |                                                      Note: Ver Polarity                                    |
    // |                                                                                                            |
    // |                                                      Bit 00 – Interrupt Trigger Mode                       |
    // |                                                               1b - level                                   |
    // |                                                               0b - edge                                    |
    // |                                                      Note: Ver TriggerMode                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h          Interrupt       BYTE        Varies      Interrupt number for IPMI System Interface.           |
    // |              Number                                  00h = unspecified/unsupported                         |
    // |                                                      Note: Ver InterruptNumber                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the IPMI Device Information (Type 38) structure.
    /// </summary>
    sealed class SmbiosType038 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType038(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType038" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType038(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) InterfaceType: Gets a value representing the 'Interface Type' field
        /// <summary>
        /// Gets a value representing the <c>Interface Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterfaceType => GetByte(0x04);
        #endregion

        #region [private] (string) SpecificationRevision: Gets a value representing the 'Specification Revision' field
        /// <summary>
        /// Gets a value representing the <c>Specification Revision</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SpecificationRevision
        {
            get
            {
                byte hi = (byte)((GetByte(0x05) >> 4) & 0x0f);
                byte lo = (byte)(GetByte(0x05) & 0x0f);

                string hiString = hi.ToString(CultureInfo.InvariantCulture);
                string loString = lo.ToString(CultureInfo.InvariantCulture);

                return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", hiString, loString);
            }
        }
        #endregion

        #region [private] (string) I2CSlaveAddress: Gets a value representing the 'I2C Slave Address' field
        /// <summary>
        /// Gets a value representing the <c>I2C Slave Address</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string I2CSlaveAddress => GetByte(0x06).ToString("X", CultureInfo.InvariantCulture);
        #endregion

        #region [private] (byte) NVStorageDeviceAddress: Gets a value representing the 'NV Storage Device Address' field
        /// <summary>
        /// Gets a value representing the <c>NV Storage Device Address</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NVStorageDeviceAddress => GetByte(0x07);
        #endregion

        #region [private] (ulong) BaseAddress: Gets a value representing the 'Base Address' field
        /// <summary>
        /// Gets a value representing the <c>Base Address</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong BaseAddress => (ulong)GetQuadrupleWord(0x08);
        #endregion

        #region [private] (string) BaseAddressModifier: Gets a value representing the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <c>Base Address Modifier</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BaseAddressModifier => GetByte(0x10);
        #endregion

        #region [private] (string) TriggerMode: Gets a value representing the 'Trigger Mode' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <c>Trigger Mode</c> feature of the <c>Base Address Modifier</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string TriggerMode => BaseAddressModifier.CheckBit(Bits.Bit00) ? "Level" : "Edge";
        #endregion

        #region [private] (string) Polarity: Gets a value representing the 'Polarity' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <c>Polarity</c> feature of the <c>Base Address Modifier</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Polarity => BaseAddressModifier.CheckBit(Bits.Bit01) ? "Active High" : "Active Low";
        #endregion

        #region [private] (bool) SpecifiedInfo: Gets a value representing the 'Specified Info' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <c>Specified Info</c> feature of the <c>Base Address Modifier</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SpecifiedInfo => BaseAddressModifier.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) LsBit: Gets a value representing the 'Specified Info' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <c>LsBit</c> feature of the <c>Base Address Modifier</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LsBit => (byte) (BaseAddressModifier & 0x01);
        #endregion

        #region [private] (byte) RegisterSpacing: Gets a value representing the 'Register Spacing' field
        /// <summary>
        /// Gets a value representing the <c>Register Spacing</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte RegisterSpacing => (byte)((BaseAddressModifier >> 6) & 0x03);
        #endregion

        #region [private] (byte) InterruptNumber: Gets a value representing the 'Interrupt Number' field
        /// <summary>
        /// Gets a value representing the <c>Interrup tNumber</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterruptNumber => GetByte(0x11);
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
            SmbiosType038Property propertyId = (SmbiosType038Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Interface Type] - [String]
                case SmbiosType038Property.InterfaceType:
                    value = GetInterfaceType(InterfaceType);
                    break;
                #endregion

                #region [0x05] - [IPMI Specification Revision] - [String]
                case SmbiosType038Property.SpecificationRevision:
                    value = SpecificationRevision;
                    break;
                #endregion

                #region [0x06] - [I2C Slave Address] - [String]
                case SmbiosType038Property.I2CSlaveAddress:
                    value = I2CSlaveAddress;
                    break;
                #endregion

                #region [0x07] - [NV Storage Device Address] - [Byte?]
                case SmbiosType038Property.NVStorageDeviceAddress:
                    if (NVStorageDeviceAddress != 0x00)
                    {
                        value = (byte?)NVStorageDeviceAddress;
                    }
                    break;
                #endregion

                #region [0x08] - [Base Address] - [UInt64]
                case SmbiosType038Property.BaseAdress:
                    value = BaseAddress;
                    break;
                #endregion

                #region [0x10] - [Base Address Modifier / Interrupt Info]

                #region [0x10] - [Base Address Modifier]

                #region [0x10] - [Base Address Modifier -> Base Address -> Register Spacing] - [String]
                case SmbiosType038Property.RegisterSpacing:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        if (BaseAddressModifier != 0x00)
                        {
                            value = GetRegisterSpacing(RegisterSpacing);
                        }
                    }
                    break;
                #endregion

                #region [0x10] - [Base Address Modifier -> Base Address -> LsBit] - [Byte?]
                case SmbiosType038Property.LSBit:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        if (BaseAddressModifier != 0x00)
                        {
                            value = (Byte?) LsBit;
                        }
                    }
                    break;
                #endregion

                #endregion

                #region [0x10] - [Interrupt Info]

                #region [0x10] - [Base Address Modifier -> Interrupt Info -> Specified Info] - [Boolean?]
                case SmbiosType038Property.SpecifiedInfo:
                if (HeaderInfo.Length >= 0x11)
                {
                    if (BaseAddressModifier != 0x00)
                    {
                        value = (bool?) SpecifiedInfo;
                    }
                }
                break;
                #endregion

                #region [0x10] - [Base Address Modifier -> Interrupt Info -> Polarity] - [String]
                case SmbiosType038Property.Polarity:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        if (BaseAddressModifier != 0x00)
                        {
                            value = Polarity;
                        }
                    }
                    break;
                #endregion

                #region [0x10] - [Base Address Modifier -> Interrupt Info -> Trigger Mode] - [String]
                case SmbiosType038Property.TriggerMode:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        if (BaseAddressModifier != 0x00)
                        {
                            value = TriggerMode;
                        }
                    }
                    break;
                #endregion

                #endregion

                #endregion

                #region [0x11] - [Interrupt Number] - [Byte?]
                case SmbiosType038Property.InterruptNumber:
                    if (HeaderInfo.Length >= 0x12)
                    {
                        if (InterruptNumber != 0x00)
                        {
                            value = (byte?) InterruptNumber;
                        }
                    }
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

            #region values
            properties.Add(KnownDmiProperty.IpmiDevice.InterfaceType, GetInterfaceType(InterfaceType));
            properties.Add(KnownDmiProperty.IpmiDevice.SpecificationRevision, SpecificationRevision);
            properties.Add(KnownDmiProperty.IpmiDevice.I2CSlaveAddress, I2CSlaveAddress);

            if (NVStorageDeviceAddress != 0x00)
            {
                properties.Add(KnownDmiProperty.IpmiDevice.NVStorageDeviceAddress, NVStorageDeviceAddress);
            }

            properties.Add(KnownDmiProperty.IpmiDevice.BaseAdress, BaseAddress);

            if (HeaderInfo.Length >= 0x11)
            {
                if (BaseAddressModifier != 0x00)
                {
                    properties.Add(KnownDmiProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing, GetRegisterSpacing(RegisterSpacing));
                    properties.Add(KnownDmiProperty.IpmiDevice.BaseAdressModifier.LsBit, LsBit);

                    properties.Add(KnownDmiProperty.IpmiDevice.Interrupt.SpecifiedInfo, SpecifiedInfo);
                    properties.Add(KnownDmiProperty.IpmiDevice.Interrupt.Polarity, Polarity);
                    properties.Add(KnownDmiProperty.IpmiDevice.Interrupt.TriggerMode, TriggerMode);
                }
            }

            if (HeaderInfo.Length >= 0x12)
            {
                if (InterruptNumber != 0x00)
                {
                    properties.Add(KnownDmiProperty.IpmiDevice.InterruptNumber, InterruptNumber);
                }
            }
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.2.0 (26/04/2018)

        #region [private] {static} (string) GetInterfaceType(byte): Gets a string representing interface type
        /// <summary>
        /// Gets a string representing interface type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The interface type.
        /// </returns>
        private static string GetInterfaceType(byte code)
        {
            string[] value =
            {
                "Unknown",                                 // 0x00
                "KCS: Keyboard Controller Style",
                "SMIC: Server Management Interface Chip",
                "BT: Block Transfer",
                "SSIF: SMBus System Interface"             // 0x04
            };

            if (code <= 0x04)
            {
                return value[code];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetRegisterSpacing(byte): Gets a string representing record type
        /// <summary>
        /// Gets a string representing record type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The record type.
        /// </returns>
        private static string GetRegisterSpacing(byte code)
        {
            string[] value =
            {
                "Interface registers are on successive byte boundaries", // 0x00
                "Interface registers are on 32-bit boundaries",
                "Interface registers are on 16-byte boundaries",
                "Reserved"                                               // 0x03
            };

            return value[code];
        }
        #endregion

        #endregion
    }
}
