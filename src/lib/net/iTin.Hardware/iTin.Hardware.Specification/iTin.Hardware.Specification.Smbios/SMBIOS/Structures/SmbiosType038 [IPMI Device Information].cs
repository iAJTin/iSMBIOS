
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;
    using System.Globalization;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the IPMI Device Information (Type 38) structure.
    /// </summary>
    internal sealed class SmbiosType038 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType038(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType038"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType038(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) InterfaceType: Gets a value representing the 'Interface Type' field
        /// <summary>
        /// Gets a value representing the <b>Interface Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterfaceType => Reader.GetByte(0x04);
        #endregion

        #region [private] (string) SpecificationRevision: Gets a value representing the 'Specification Revision' field
        /// <summary>
        /// Gets a value representing the <b>Specification Revision</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SpecificationRevision
        {
            get
            {
                byte hi = (byte)((Reader.GetByte(0x05) >> 4) & 0x0f);
                byte lo = (byte)(Reader.GetByte(0x05) & 0x0f);

                string hiString = hi.ToString(CultureInfo.InvariantCulture);
                string loString = lo.ToString(CultureInfo.InvariantCulture);

                return $"{hiString}.{loString}";
            }
        }
        #endregion

        #region [private] (string) I2CSlaveAddress: Gets a value representing the 'I2C Slave Address' field
        /// <summary>
        /// Gets a value representing the <b>I2C Slave Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string I2CSlaveAddress => Reader.GetByte(0x06).ToString("X", CultureInfo.InvariantCulture);
        #endregion

        #region [private] (byte) NVStorageDeviceAddress: Gets a value representing the 'NV Storage Device Address' field
        /// <summary>
        /// Gets a value representing the <b>NV Storage Device Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NVStorageDeviceAddress => Reader.GetByte(0x07);
        #endregion

        #region [private] (ulong) BaseAddress: Gets a value representing the 'Base Address' field
        /// <summary>
        /// Gets a value representing the <b>Base Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong BaseAddress => (ulong)Reader.GetQuadrupleWord(0x08);
        #endregion

        #region [private] (string) BaseAddressModifier: Gets a value representing the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <b>Base Address Modifier</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BaseAddressModifier => Reader.GetByte(0x10);
        #endregion

        #region [private] (string) TriggerMode: Gets a value representing the 'Trigger Mode' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <b>Trigger Mode</b> feature of the <b>Base Address Modifier</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string TriggerMode => BaseAddressModifier.CheckBit(Bits.Bit00) ? "Level" : "Edge";
        #endregion

        #region [private] (string) Polarity: Gets a value representing the 'Polarity' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <b>Polarity</b> feature of the <b>Base Address Modifier</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Polarity => BaseAddressModifier.CheckBit(Bits.Bit01) ? "Active High" : "Active Low";
        #endregion

        #region [private] (bool) SpecifiedInfo: Gets a value representing the 'Specified Info' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <b>Specified Info</b> feature of the <b>Base Address Modifier</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SpecifiedInfo => BaseAddressModifier.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) LsBit: Gets a value representing the 'Specified Info' feature of the 'Base Address Modifier' field
        /// <summary>
        /// Gets a value representing the <b>LsBit</b> feature of the <b>Base Address Modifier</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LsBit => (byte) (BaseAddressModifier & 0x01);
        #endregion

        #region [private] (byte) RegisterSpacing: Gets a value representing the 'Register Spacing' field
        /// <summary>
        /// Gets a value representing the <b>Register Spacing</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte RegisterSpacing => (byte)((BaseAddressModifier >> 6) & 0x03);
        #endregion

        #region [private] (byte) InterruptNumber: Gets a value representing the 'Interrupt Number' field
        /// <summary>
        /// Gets a value representing the <b>Interrup tNumber</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterruptNumber => Reader.GetByte(0x11);
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

            properties.Add(SmbiosProperty.IpmiDevice.InterfaceType, GetInterfaceType(InterfaceType));
            properties.Add(SmbiosProperty.IpmiDevice.SpecificationRevision, SpecificationRevision);
            properties.Add(SmbiosProperty.IpmiDevice.I2CSlaveAddress, I2CSlaveAddress);
            properties.Add(SmbiosProperty.IpmiDevice.NVStorageDeviceAddress, NVStorageDeviceAddress);
            properties.Add(SmbiosProperty.IpmiDevice.BaseAddress, BaseAddress);

            if (StructureInfo.Length >= 0x11)
            {
                if (BaseAddressModifier != 0x00)
                {
                    properties.Add(SmbiosProperty.IpmiDevice.BaseAdressModifier.RegisterSpacing, GetRegisterSpacing(RegisterSpacing));
                    properties.Add(SmbiosProperty.IpmiDevice.BaseAdressModifier.LsBit, LsBit);

                    properties.Add(SmbiosProperty.IpmiDevice.Interrupt.SpecifiedInfo, SpecifiedInfo);
                    properties.Add(SmbiosProperty.IpmiDevice.Interrupt.Polarity, Polarity);
                    properties.Add(SmbiosProperty.IpmiDevice.Interrupt.TriggerMode, TriggerMode);
                }
            }

            if (StructureInfo.Length >= 0x12)
            {
                properties.Add(SmbiosProperty.IpmiDevice.InterruptNumber, InterruptNumber);
            }
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
