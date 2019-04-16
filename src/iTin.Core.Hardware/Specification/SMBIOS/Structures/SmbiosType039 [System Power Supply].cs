
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

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
    // |                                                      Note: Ver IsRedundant                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Location        BYTE        STRING      The number of the string that identifies the location |
    // |              Channel                                 of the power supply.                                  |
    // |              Load                                                                                          |
    // |                                                      EXAMPLES: “in the back, on the left-hand side” or     |
    // |                                                                “Left Supply Bay”                           |
    // |                                                      Note: Ver Location                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Device Name     BYTE        STRING      The number of the string that names the power supply  |
    // |                                                                                                            |
    // |                                                      EXAMPLES: “DR-36”                                     |
    // |                                                      Note: Ver DeviceName                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Manufacturer    BYTE        STRING      The number of the string that names the company that  |
    // |                                                      manufactured the supply.                              |
    // |                                                      Note: Ver Manufacturer                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Serial Number   BYTE        STRING      The number of the string that contains the serial     |
    // |                                                      number for the power supply.                          |
    // |                                                      Note: Ver SerialNumber                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Asset Tag       BYTE        STRING      The number of the string that contains the Asset Tag  |
    // |              Number                                  Number.                                               |
    // |                                                      Note: Ver AssetTagNumber                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Model Part      BYTE        STRING      The number of the string that contains the OEM Part   |
    // |              Number                                  Order Number.                                         |
    // |                                                      Note: Ver ModelPartNumber                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Revision        BYTE        STRING      Power supply Revision String.                         |
    // |              Level                                   EXAMPLE: “2.30”                                       |
    // |                                                      Note: Ver RevisionLevel                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Max Power       WORD        Varies      Maximum sustained power output in Watts.              |
    // |              Capacity                                Set to 0x8000 if unknown.                             |
    // |                                                      Note that the units specified by the DMTF for this    |
    // |                                                      field are milliWatts.                                 |
    // |                                                      Note: Ver MaxPowerCapacity                            |
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
    // |                                                      Note: Ver GetSupplyType(byte)                         |
    // |                                                                                                            |
    // |                                                      Bits 09:07 - Status.                                  |
    // |                                                                   001b - Other                             |
    // |                                                                   010b - Unknown                           |
    // |                                                                   011b - OK                                |
    // |                                                                   100b - Non-critical                      |
    // |                                                                   101b - Critical; power supply has failed |
    // |                                                                          and has been taken off-line.      |
    // |                                                      Note: Ver GetStatus(byte)                             |
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
    // |                                                      Note: Ver InputVoltageRange(byte)                     |
    // |                                                                                                            |
    // |                                                      Bit     02 - Power supply is unplugged from the wall, |
    // |                                                                   if 1.                                    |
    // |                                                      Note: Ver IsPlugged                                   |
    // |                                                                                                            |
    // |                                                      Bit     01 - Power supply is present, if 1.           |
    // |                                                      Note: Ver Ispresent                                   |
    // |                                                                                                            |
    // |                                                      Bit     00 - Power supply is hot replaceable, if 1.   |
    // |                                                      Note: Ver IsReplaceable                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          Input Voltage   WORD        Varies      The handle, or instance number, of a Voltage Probe    |
    // |              Probe Handle                            (Type 26) monitoring this power supply’s input        |
    // |                                                      voltage.                                              |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: Ver InputVoltageProbeHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Cooling Device  WORD        Varies      The handle, or instance number, of a Cooling Device   |
    // |              Handle                                  (Type 27) associated with this power supply.          |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: Ver CoolingDeviceHandle                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h          Input Current   WORD        Varies      The handle, or instance number, of the Electrical     |
    // |              Probe Handle                            Current Probe (Type 29) monitoring this power supply’s|
    // |                                                      input current.                                        |
    // |                                                      A value of 0xFFFF indicates that no probe is provided.|
    // |                                                      Note: Ver InputCurrentProbeHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Power Supply (Type 39) structure.
    /// </summary>
    sealed class SmbiosType039 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType039(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType039" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType039(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (bool) IsRedundant: Gets a value representing the 'Is Redundant' field
        /// <summary>
        /// Gets a value representing the <c>Is Redundant</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsRedundant => GetByte(0x04) != 0x00;
        #endregion

        #region [private] (string) Location: Gets a value representing the 'Location' field
        /// <summary>
        /// Gets a value representing the <c>Location</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Location => GetString(0x05);
        #endregion

        #region [private] (string) DeviceName: Gets a value representing the 'Device Name' field
        /// <summary>
        /// Gets a value representing the <c>Device Name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceName => GetString(0x06);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x07);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x08);
        #endregion

        #region [private] (string) AssetTagNumber: Gets a value representing the 'Asset Tag Number' field
        /// <summary>
        /// Gets a value representing the <c>Asset Tag Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTagNumber => GetString(0x09);
        #endregion

        #region [private] (string) ModelPartNumber: Gets a value representing the 'Model Part Number' field
        /// <summary>
        /// Gets a value representing the <c>Model Part Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ModelPartNumber => GetString(0x0a);
        #endregion

        #region [private] (string) RevisionLevel: Gets a value representing the 'Revision Level' field
        /// <summary>
        /// Gets a value representing the <c>Revision Level</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string RevisionLevel => GetString(0x0b);
        #endregion

        #region [private] (int) MaxPowerCapacity: Gets a value representing the 'Max Power Capacity' field
        /// <summary>
        /// Gets a value representing the <c>Max Power Capacity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaxPowerCapacity => GetWord(0x0c);
        #endregion

        #region [private] (int) Characteristics: Gets a value representing the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Characteristics</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Characteristics => GetWord(0x0e);
        #endregion

        #region [private] (bool) IsHotReplaceable: Gets a value representing the 'Is Hot Replaceable' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Is Hot Replaceable</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHotReplaceable => Characteristics.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (bool) IsPresent: Gets a value representing the 'Is Present' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Is Present</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsPresent => Characteristics.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsPlugged: Gets a value representing the 'Is Plugged' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Is Plugged</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsPlugged => !Characteristics.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (byte) InputVoltageRange: Gets a value representing the 'Input Voltage Range' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Input Voltage Range</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InputVoltageRange => (byte) ((Characteristics >> 0x03) & 0x0007);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Status</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte) ((Characteristics >> 0x07) & 0x0007);
        #endregion

        #region [private] (byte) SupplyType: Gets a value representing the 'Supply Type' feature of the 'Characteristics' field
        /// <summary>
        /// Gets a value representing the <c>Supply Type</c> feature of the <c>Characteristics</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupplyType => (byte) ((Characteristics >> 0x0a) & 0x000f);
        #endregion

        #region [private] (int) InputVoltageProbeHandle: Gets a value representing the 'Input Voltage Probe Handle' field
        /// <summary>
        /// Gets a value representing the <c>Input Voltage Probe Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int InputVoltageProbeHandle => GetWord(0x10);
        #endregion

        #region [private] (int) CoolingDeviceHandle: Gets a value representing the 'Cooling Device Handle' field
        /// <summary>
        /// Gets a value representing the <c>Cooling Device Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CoolingDeviceHandle => GetWord(0x12);
        #endregion

        #region [private] (int) InputCurrentProbeHandle: Gets a value representing the 'Input Current Probe Handle' field
        /// <summary>
        /// Gets a value representing the <c>Input Current Probe Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int InputCurrentProbeHandle => GetWord(0x14);
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
            SmbiosType039Property propertyId = (SmbiosType039Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Power Unit Group] - [Boolean]
                case SmbiosType039Property.IsRedundant:
                    value = IsRedundant;
                    break;
                #endregion

                #region [0x05] - [Location Channel Load] - [String]
                case SmbiosType039Property.Location:
                    value = Location;
                    break;
                #endregion

                #region [0x06] - [Device Name] - [String]
                case SmbiosType039Property.DeviceName:
                    value = DeviceName;
                    break;
                #endregion

                #region [0x07] - [Manufacturer] - [String]
                case SmbiosType039Property.Manufacturer:
                    value = Manufacturer;
                    break;
                #endregion

                #region [0x08] - [Serial Number] - [String]
                case SmbiosType039Property.SerialNumber:
                    value = SerialNumber;
                    break;
                #endregion

                #region [0x09] - [Asset Tag Number] - [String]
                case SmbiosType039Property.AssetTagNumber:
                    value = AssetTagNumber;
                    break;
                #endregion

                #region [0x0a] - [Model Part Number] - [String]
                case SmbiosType039Property.ModelPartNumber:
                    value = ModelPartNumber;
                    break;
                #endregion

                #region [0x0b] - [Revision Level] - [String]
                case SmbiosType039Property.RevisionLevel:
                    value = RevisionLevel;
                    break;
                #endregion

                #region [0x0c] - [Max Power Capacity] - [Int32?]
                case SmbiosType039Property.MaxPowerCapacity:
                    if (MaxPowerCapacity != 0x8000)
                    {
                        value = (int?) MaxPowerCapacity;
                    }                     
                    break;
                #endregion

                #region [0x0e] - [Power Supply Characteristics]

                    #region [0x0e] - [Power Supply Characteristics -> Is Hot Replaceable] - [Boolean]
                    case SmbiosType039Property.IsHotReplaceable:
                        value = IsHotReplaceable;
                        break;
                    #endregion

                    #region [0x0e] - [Power Supply Characteristics -> Is Present] - [Boolean]
                    case SmbiosType039Property.IsPresent:
                        value = IsPresent;
                        break;
                    #endregion

                    #region [0x0e] - [Power Supply Characteristics -> Is Plugged] - [Boolean]
                    case SmbiosType039Property.IsPlugged:
                        value = IsPlugged;
                        break;
                    #endregion

                    #region [0x0e] - [Power Supply Characteristics -> Input Voltage Range] - [String]
                    case SmbiosType039Property.InputVoltageRange:
                        value = GetInputVoltageRange(InputVoltageRange);
                        break;
                    #endregion

                    #region [0x0e] - [Power Supply Characteristics -> Status] - [String]
                    case SmbiosType039Property.Status:
                        value = GetStatus(Status);
                        break;
                    #endregion

                    #region [0x0e] - [Power Supply Characteristics -> Supply Type] - [String]
                    case SmbiosType039Property.SupplyType:                    
                        value = GetSupplyType(SupplyType);
                        break;
                    #endregion

                #endregion

                #region [0x10] - [Input Voltage Probe Handle] - [Int32?]
                case SmbiosType039Property.InputVoltageProbeHandle:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        if (InputVoltageProbeHandle != 0xffff)
                        {
                            value = (int?) InputVoltageProbeHandle;
                        }
                    }
                    break;
                #endregion

                #region [0x12] - [Cooling Device Probe Handle] - [Int32?]
                case SmbiosType039Property.CoolingDeviceHandle:
                    if (HeaderInfo.Length >= 0x13)
                    {
                        if (CoolingDeviceHandle != 0xffff)
                        {
                            value = (int?) CoolingDeviceHandle;
                        }
                    }
                    break;
                #endregion

                #region [0x14] - [Input Current Probe Handle] - [Int32?]
                case SmbiosType039Property.InputCurrentProbeHandle:
                    if (HeaderInfo.Length >= 0x15)
                    {
                        if (InputCurrentProbeHandle != 0xffff)
                        {
                            value = (int?) InputCurrentProbeHandle;
                        }
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(SmbiosPropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(SmbiosPropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.SystemPowerSupply.IsRedundant, IsRedundant);
                               
            properties.Add(KnownDmiProperty.SystemPowerSupply.Location, Location);
            properties.Add(KnownDmiProperty.SystemPowerSupply.DeviceName, DeviceName);
            properties.Add(KnownDmiProperty.SystemPowerSupply.Manufacturer, Manufacturer);
            properties.Add(KnownDmiProperty.SystemPowerSupply.SerialNumber, SerialNumber);
            properties.Add(KnownDmiProperty.SystemPowerSupply.AssetTagNumber, AssetTagNumber);
            properties.Add(KnownDmiProperty.SystemPowerSupply.ModelPartNumber, ModelPartNumber);
            properties.Add(KnownDmiProperty.SystemPowerSupply.RevisionLevel, RevisionLevel);

            if (MaxPowerCapacity != 0x8000)
            {
                properties.Add(KnownDmiProperty.SystemPowerSupply.MaxPowerCapacity, MaxPowerCapacity);
            }

            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.SupplyType, GetSupplyType(SupplyType));
            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.Status, GetStatus(Status));
            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.InputVoltageRange, GetInputVoltageRange(InputVoltageRange));
            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.IsPlugged, IsPlugged);
            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.IsPresent, IsPresent);
            properties.Add(KnownDmiProperty.SystemPowerSupply.Characteristics.IsHotReplaceable, IsHotReplaceable);
                               
            if (HeaderInfo.Length >= 0x11)
            {
                if (InputVoltageProbeHandle != 0xffff)
                {
                    properties.Add(KnownDmiProperty.SystemPowerSupply.InputVoltageProbeHandle, InputVoltageProbeHandle);
                }
            }

            if (HeaderInfo.Length >= 0x13)
            {
                if (CoolingDeviceHandle != 0xffff)
                {
                    properties.Add(KnownDmiProperty.SystemPowerSupply.CoolingDeviceHandle, CoolingDeviceHandle);
                }
            }

            if (HeaderInfo.Length >= 0x15)
            {
                if (InputCurrentProbeHandle != 0xffff)
                {
                    properties.Add(KnownDmiProperty.SystemPowerSupply.InputCurrentProbeHandle, InputCurrentProbeHandle);
                }
            }
            #endregion
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
