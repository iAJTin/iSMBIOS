
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 039: System Power Supply.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        39          Power Supply Structure indicator.                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE                    Length of the structure, a minimum of 10h.            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Power           BYTE        Varies      Identifies the power unit group to which this power   |
    // |              Unit Group                              supply is associated.                                 |
    // |                                                      Specifying the same Power Unit Group value for more   |
    // |                                                      than one System Power Supply structure indicates a    |
    // |                                                      redundant power supply configuration.                 |
    // |                                                      The field’s value is 00h if the power supply is not a |
    // |                                                      member of a redundant power unit.                     |
    // |                                                      Non-zero values imply redundancy and that at least one|
    // |                                                      other power supply will be enumerated with the same   |
    // |                                                      value.                                                |
    // |                                                      Note: See IsRedundant                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Location        BYTE        STRING      The number of the string that identifies the location |
    // |              Channel                                 of the power supply.                                  |
    // |              Load                                                                                          |
    // |                                                      EXAMPLES: “in the back, on the left-hand side” or     |
    // |                                                                “Left Supply Bay”                           |
    // |                                                      Note: See Location                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Device Name     BYTE        STRING      The number of the string that names the power supply  |
    // |                                                                                                            |
    // |                                                      EXAMPLES: “DR-36”                                     |
    // |                                                      Note: See DeviceName                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Manufacturer    BYTE        STRING      The number of the string that names the company that  |
    // |                                                      manufactured the supply.                              |
    // |                                                      Note: See Manufacturer                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Serial Number   BYTE        STRING      The number of the string that contains the serial     |
    // |                                                      number for the power supply.                          |
    // |                                                      Note: See SerialNumber                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Asset Tag       BYTE        STRING      The number of the string that contains the Asset Tag  |
    // |              Number                                  Number.                                               |
    // |                                                      Note: See AssetTagNumber                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Model Part      BYTE        STRING      The number of the string that contains the OEM Part   |
    // |              Number                                  Order Number.                                         |
    // |                                                      Note: See ModelPartNumber                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Revision        BYTE        STRING      Power supply Revision String.                         |
    // |              Level                                   EXAMPLE: “2.30”                                       |
    // |                                                      Note: See RevisionLevel                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Max Power       WORD        Varies      Maximum sustained power output in Watts.              |
    // |              Capacity                                Set to 0x8000 if unknown.                             |
    // |                                                      Note that the units specified by the DMTF for this    |
    // |                                                      field are milliWatts.                                 |
    // |                                                      Note: See MaxPowerCapacity                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Power Supply    WORD        Varies      Bits 15:14 - Reserved, set to 00b.                    |
    // |              Characteristics                                                                               |
    // |                                                      Bits 13:10 - DMTF Power Supply Type.                  |
    // |                                                                   0001b - Other                            |
    // |                                                                   0010b - Unknown                          |
    // |                                                                   0011b - Linear                           |
    // |                                                                   0100b - Switching                        |
    // |                                                                   0101b - Battery                          |
    // |                                                                   0110b - UPS                              |
    // |                                                                   0111b - Converter                        |
    // |                                                                   1000b - Regulator                        |
    // |                                                                   1001b to 1111b — Reserved for future     |
    // |                                                                                    assignment.             |
    // |                                                      Note: See GetSupplyType(byte)                         |
    // |                                                                                                            |
    // |                                                      Bits 09:07 - Status.                                  |
    // |                                                                   001b - Other                             |
    // |                                                                   010b - Unknown                           |
    // |                                                                   011b - OK                                |
    // |                                                                   100b - Non-critical                      |
    // |                                                                   101b - Critical; power supply has failed |
    // |                                                                          and has been taken off-line.      |
    // |                                                      Note: See GetStatus(byte)                             |
    // |                                                                                                            |
    // |                                                      Bits 06:03 - DMTF Input Voltage Range Switching.      |
    // |                                                                   0001b - Other                            |
    // |                                                                   0010b - Unknown                          |
    // |                                                                   0011b - Manual                           |
    // |                                                                   0100b - Auto-switch                      |
    // |                                                                   0101b - Wide range                       |
    // |                                                                   0110b - Not applicable                   |
    // |                                                                   0111b to 1111b — Reserved for future     |
    // |                                                                                    assignment.             |
    // |                                                      Note: See InputVoltageRange(byte)                     |
    // |                                                                                                            |
    // |                                                      Bit     02 - Power supply is unplugged from the wall, |
    // |                                                                   if 1.                                    |
    // |                                                      Note: See IsPlugged                                   |
    // |                                                                                                            |
    // |                                                      Bit     01 - Power supply is present, if 1.           |
    // |                                                      Note: See Ispresent                                   |
    // |                                                                                                            |
    // |                                                      Bit     00 - Power supply is hot replaceable, if 1.   |
    // |                                                      Note: See IsReplaceable                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          Input Voltage   WORD        Varies      The handle, or instance number, of a Voltage Probe    |
    // |              Probe Handle                            (Type 26) monitoring this power supply’s input        |
    // |                                                      voltage.                                              |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: See InputVoltageProbeHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Cooling Device  WORD        Varies      The handle, or instance number, of a Cooling Device   |
    // |              Handle                                  (Type 27) associated with this power supply.          |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: See CoolingDeviceHandle                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h          Input Current   WORD        Varies      The handle, or instance number, of the Electrical     |
    // |              Probe Handle                            Current Probe (Type 29) monitoring this power supply’s|
    // |                                                      input current.                                        |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: See InputCurrentProbeHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Power Supply (Type 39) structure.
    /// </summary>
    internal sealed class SmbiosType039 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType039(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType039"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType039(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (bool) IsRedundant: Gets a value representing the 'Is Redundant' field
        /// <summary>
        /// Gets a value representing the <b>Is Redundant</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsRedundant => Reader.GetByte(0x04) != 0x00;
        #endregion

        #region [private] (string) Location: Gets a value representing the 'Location' field
        /// <summary>
        /// Gets a value representing the <b>Location</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Location => GetString(0x05);
        #endregion

        #region [private] (string) DeviceName: Gets a value representing the 'Device Name' field
        /// <summary>
        /// Gets a value representing the <b>Device Name</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceName => GetString(0x06);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x07);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x08);
        #endregion

        #region [private] (string) AssetTagNumber: Gets a value representing the 'Asset Tag Number' field
        /// <summary>
        /// Gets a value representing the <b>Asset Tag Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTagNumber => GetString(0x09);
        #endregion

        #region [private] (string) ModelPartNumber: Gets a value representing the 'Model Part Number' field
        /// <summary>
        /// Gets a value representing the <b>Model Part Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ModelPartNumber => GetString(0x0a);
        #endregion

        #region [private] (string) RevisionLevel: Gets a value representing the 'Revision Level' field
        /// <summary>
        /// Gets a value representing the <b>Revision Level</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string RevisionLevel => GetString(0x0b);
        #endregion

        #region [private] (ushort) MaxPowerCapacity: Gets a value representing the 'Max Power Capacity' field
        /// <summary>
        /// Gets a value representing the <b>Max Power Capacity</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MaxPowerCapacity => (ushort)Reader.GetWord(0x0c);
        #endregion

        #region [private] (ushort) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Characteristics => (ushort)Reader.GetWord(0x0e);
        #endregion

        #region [private] (bool) IsHotReplaceable: Gets a value representing the 'Is Hot Replaceable' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Is Hot Replaceable</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHotReplaceable => Characteristics.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (bool) IsPresent: Gets a value representing the 'Is Present' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Is Present</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsPresent => Characteristics.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsPlugged: Gets a value representing the 'Is Plugged' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Is Plugged</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsPlugged => !Characteristics.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (byte) InputVoltageRange: Gets a value representing the 'Input Voltage Range' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Input Voltage Range</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InputVoltageRange => (byte) ((Characteristics >> 0x03) & 0x0007);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Status</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte) ((Characteristics >> 0x07) & 0x0007);
        #endregion

        #region [private] (byte) SupplyType: Gets a value representing the 'Supply Type' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Supply Type</b> feature of the <b>Characteristics</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupplyType => (byte) ((Characteristics >> 0x0a) & 0x000f);
        #endregion

        #region [private] (ushort) InputVoltageProbeHandle: Gets a value representing the 'Input Voltage Probe Handle' field
        /// <summary>
        /// Gets a value representing the <b>Input Voltage Probe Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort InputVoltageProbeHandle => (ushort)Reader.GetWord(0x10);
        #endregion

        #region [private] (ushort) CoolingDeviceHandle: Gets a value representing the 'Cooling Device Handle' field
        /// <summary>
        /// Gets a value representing the <b>Cooling Device Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort CoolingDeviceHandle => (ushort)Reader.GetWord(0x12);
        #endregion

        #region [private] (ushort) InputCurrentProbeHandle: Gets a value representing the 'Input Current Probe Handle' field
        /// <summary>
        /// Gets a value representing the <b>Input Current Probe Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort InputCurrentProbeHandle => (ushort)Reader.GetWord(0x14);
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
            properties.Add(SmbiosProperty.SystemPowerSupply.IsRedundant, IsRedundant);
                               
            properties.Add(SmbiosProperty.SystemPowerSupply.Location, Location);
            properties.Add(SmbiosProperty.SystemPowerSupply.DeviceName, DeviceName);
            properties.Add(SmbiosProperty.SystemPowerSupply.Manufacturer, Manufacturer);
            properties.Add(SmbiosProperty.SystemPowerSupply.SerialNumber, SerialNumber);
            properties.Add(SmbiosProperty.SystemPowerSupply.AssetTagNumber, AssetTagNumber);
            properties.Add(SmbiosProperty.SystemPowerSupply.ModelPartNumber, ModelPartNumber);
            properties.Add(SmbiosProperty.SystemPowerSupply.RevisionLevel, RevisionLevel);
            properties.Add(SmbiosProperty.SystemPowerSupply.MaxPowerCapacity, MaxPowerCapacity);

            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.SupplyType, GetSupplyType(SupplyType));
            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.Status, GetStatus(Status));
            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.InputVoltageRange, GetInputVoltageRange(InputVoltageRange));
            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.IsPlugged, IsPlugged);
            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.IsPresent, IsPresent);
            properties.Add(SmbiosProperty.SystemPowerSupply.Characteristics.IsHotReplaceable, IsHotReplaceable);
                               
            if (StructureInfo.Length >= 0x11)
            {
                properties.Add(SmbiosProperty.SystemPowerSupply.InputVoltageProbeHandle, InputVoltageProbeHandle);
            }

            if (StructureInfo.Length >= 0x13)
            {
                properties.Add(SmbiosProperty.SystemPowerSupply.CoolingDeviceHandle, CoolingDeviceHandle);
            }

            if (StructureInfo.Length >= 0x15)
            {
                properties.Add(SmbiosProperty.SystemPowerSupply.InputCurrentProbeHandle, InputCurrentProbeHandle);
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetInputVoltageRange(byte): Gets a string representing the mode of use of the power supply
        /// <summary>
        /// Gets a string representing the mode of use of the power supply.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The mode of use of the power supply.
        /// </returns>
        private static string GetInputVoltageRange(byte code)
        {
            string[] value =
            {
                "Other",         // 0x01
                "Unknown",
                "Manual",
                "Auto-switch",
                "Wide range",
                "Not applicable" // 0x06
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetStatus(byte): Gets a string representing the state of the power supply
        /// <summary>
        /// Gets a string representing the state of the power supply.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The state of the power supply.
        /// </returns>
        private static string GetStatus(byte code)
        {
            string[] value =
            {
                "Other",                                                         // 0x01
                "Unknown",
                "OK",
                "Non-critical",
                "Critical, power supply has failed and has been taken off-line"  // 0x05
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetSupplyType(byte): Gets a string representing the type of power supply
        /// <summary>
        /// Gets a string representing the type of power supply.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The type of power supply.
        /// </returns>
        private static string GetSupplyType(byte code)
        {
            string[] value =
            {
                "Other",         // 0x01
                "Unknown",
                "Linear",
                "Switching",
                "Battery",
                "UPS",
                "Converter",
                "Regulator"      // 0x08
            };

            if (code >= 0x01 && code <= 0x08)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
