
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Dmi.Property;

    using Helpers;

    // Type 022: Portable Battery.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        22          Portable Battery                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        1Ah         Length of the structure.                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.1+        Location            BYTE        STRING      The number of the string that identifies  |
    // |                                                                  the location of the battery.              |
    // |                                                                  EXAMPLE: “in the back, on the left-hand   |
    // |                                                                            side”                           |
    // |                                                                  Note: Ver Location                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.1+        Manufacturer        BYTE        STRING      The number of the string that names the   |
    // |                                                                  company that manufactured the battery.    |
    // |                                                                  Note: Ver Manufacturer                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.1+        Manufacture         BYTE        STRING      The number of the string that identifies  |
    // |                      Date                                        the date on which the battery was         |
    // |                                                                  manufactured.                             |
    // |                                                                  Version 2.2+ implementations that use a   |
    // |                                                                  Smart Battery set this field to 0         |
    // |                                                                  (no string) to indicate that the SBDS     |
    // |                                                                  Manufacture Date field contains the       |
    // |                                                                  information.                              |
    // |                                                                  Note: Ver ManufactureDate                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.1+        Serial Number       BYTE        STRING      The number of the string that contains the|
    // |                                                                  serial number for the battery.            |
    // |                                                                  Version 2.2+ implementations that use a   |
    // |                                                                  Smart Battery set this field to 0         |
    // |                                                                  (no string) to indicate that the          |
    // |                                                                  SBDS Serial Number field contains the     |
    // |                                                                  information                               |
    // |                                                                  Note: Ver SerialNumber                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.1+        Device Name         BYTE        STRING      The number of the string that names the   |
    // |                                                                  battery device.                           |
    // |                                                                  EXAMPLE: “DR-36”                          |
    // |                                                                  Note: Ver DeviceName                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.1+        Device              BYTE        ENUM        Identifies the battery chemistry.         |
    // |                      Chemistry                                   Version 2.2+ implementations that use a   |
    // |                                                                  Smart Battery set this field to 02h       |
    // |                                                                  (Unknown) to indicate that the SBDS Device|
    // |                                                                  Chemistry field contains the information. |
    // |                                                                  Note: Ver GetDeviceChemistry(byte)        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.1+        Design              WORD        Varies      The design capacity of the battery in     |
    // |                      Capacity                                    mWatt-hours.                              |
    // |                                                                  If the value is unknown, the field        |
    // |                                                                  contains 0.                               |
    // |                                                                  For version 2.2+ implementations, this    |
    // |                                                                  value is multiplied by the Design         |
    // |                                                                  Capacity Multiplier to produce the actual |
    // |                                                                  value.                                    |
    // |                                                                  Note: Ver DesignCapacity                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.1+        Design Voltage      WORD        Varies      The design voltage of the battery in      |
    // |                                                                  mVolts.                                   |
    // |                                                                  If the value is unknown, the field        |
    // |                                                                  contains 0.                               |
    // |                                                                  Note: Ver DesignVoltage                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh      2.1+        SBDS Version        BYTE        STRING      The number of the string that contains the|
    // |                      Number                                      Smart Battery Data Specification version  |
    // |                                                                  number supported by this battery.         |
    // |                                                                  If the battery does not support the       |
    // |                                                                  function, no string is supplied.          |
    // |                                                                  Note: Ver SBDSVersionNumber               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.1+        Maximum Error       BYTE        Varies      The maximum error (as a percentage in the |
    // |                      in Battery Data                             range 0 to 100) in the Watt-hour data     |
    // |                                                                  reported by the battery, indicating an    |
    // |                                                                  upper bound on how much additional energy |
    // |                                                                  the battery might have above the energy it|
    // |                                                                  reports having.                           |
    // |                                                                  If the value is unknown, the field        |
    // |                                                                  contains FFh.                             |
    // |                                                                  Note: Ver MaximumErrorInBatteryData       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.2+        SBDS Serial         WORD        Varies      The 16-bit value that identifies the      |
    // |                      Number                                      battery’s serial number.                  |
    // |                                                                  This value, when combined with the        |
    // |                                                                  Manufacturer, Device Name, and Manufacture|
    // |                                                                  Date uniquely identifies the battery.     |
    // |                                                                  The Serial Number field must be set to 0  |
    // |                                                                  (no string) for this field to be valid.   |
    // |                                                                  Note: Ver SBDSSerialNumber                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.2+        SBDS                WORD        Varies      The date the cell pack was manufactured,  |
    // |                      Manufacture                                 in packed format:                         |
    // |                      Date                                                                                  |
    // |                                                                  Bits 15:09 - Year, biased by 1980, in the |
    // |                                                                               range 0 to 127               |
    // |                                                                  Bits 08:05 - Month, in the range 1 to 12. |
    // |                                                                  Bits 04:00 - Date, in the range 1 to 31.  |
    // |                                                                                                            |
    // |                                                                  EXAMPLE: 01 February 2000 would be        |
    // |                                                                           identified as:                   |
    // |                                                                               0010 1000 0100 0001b (0x2841)|
    // |                                                                                                            |
    // |                                                                  The Manufacture Date field must be set to |
    // |                                                                  0 (no string) for this field to be valid. |
    // |                                                                  Note: Ver SBDSManufactureDate             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.2+        SBDS Device         BYTE        STRING      The number of the string that identifies  |
    // |                      Chemistry                                   the battery chemistry (for example,       |
    // |                                                                  “PbAc”).                                  |
    // |                                                                  The Device Chemistry field must be set to |
    // |                                                                  02h (Unknown) for this field to be valid. |
    // |                                                                  Note: Ver SBDSDeviceChemistry             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.2+        Design              BYTE        Varies      The multiplication factor of the Design   |
    // |                      Capacity                                    Capacity value, which assures that the    |
    // |                      Multiplier                                  mWatt hours value does not overflow for   |
    // |                                                                  SBDS implementations.                     |
    // |                                                                  The multiplier default is 1, SBDS         |
    // |                                                                  implementations use the value 10 to       |
    // |                                                                  correspond to the data as returned from   |
    // |                                                                  the SBDS Function 18h.                    |
    // |                                                                  Note: Ver DesignCapacityMultiplier        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.2+        OEM-specific        DWORD       Varies      Contains OEM- or BIOS vendor-specific     |
    // |                                                                  information.                              |
    // |                                                                  Note: Ver OemSpecific                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Portable Battery (Type 22) structure.
    /// </summary>
    sealed class SmbiosType022 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType022(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType022" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType022(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (string) Location: Gets a value representing the 'Location' field
        /// <summary>
        /// Gets a value representing the <c>Location</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Location => GetString(0x04);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x05);
        #endregion

        #region [private] (string) ManufacturerDate: Gets a value representing the 'Manufacturer Date' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer Date</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ManufactureDate
        {
            get
            {
                byte rawManufactureDate = GetByte(0x06);
                if (rawManufactureDate == 0x00)
                {
                    return string.Empty;
                }

                return GetString(rawManufactureDate);
            }
        }
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber
        {
            get
            {
                byte rawSerialNumber = GetByte(0x07);
                if (rawSerialNumber == 0x00)
                {
                    return string.Empty;
                }

                return GetString(rawSerialNumber);
            }
        }
        #endregion

        #region [private] (string) DeviceName: Gets a value representing the 'Device Name' field
        /// <summary>
        /// Gets a value representing the <c>Device Name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceName => GetString(0x08);
        #endregion

        #region [private] (byte) DeviceChemistryValue: Gets a value representing the 'Device Chemistry Value' field
        /// <summary>
        /// Gets a value representing the <c>Device Chemistry Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceChemistryValue => GetByte(0x09);
        #endregion

        #region [private] (int) DesignCapacity: Gets a value representing the 'Design Capacity' field
        /// <summary>
        /// Gets a value representing the <c>Design Capacity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int DesignCapacity => GetWord(0x0a);
        #endregion

        #region [private] (int) DesignVoltage: Gets a value representing the 'Design Voltage' field
        /// <summary>
        /// Gets a value representing the <c>Design Voltage</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int DesignVoltage => GetWord(0x0c);
        #endregion

        #region [private] (string) SbdsVersionNumber: Gets a value representing the 'Sbds Version Number' field
        /// <summary>
        /// Gets a value representing the <c>Sbds Version Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsVersionNumber => GetString(0x0e);
        #endregion

        #region [private] (byte) MaximumErrorInBatteryData: Gets a value representing the 'Maximum Error In Battery Data' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Error In Battery Data</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MaximumErrorInBatteryData => GetByte(0x0f);
        #endregion

        #endregion

        #region Version 2.2+ fields

        #region [private] (string) SbdsSerialNumber: Gets a value representing the 'Sbds Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Sbds Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsSerialNumber => GetWord(0x10).ToString(CultureInfo.InvariantCulture);
        #endregion

        #region [private] (string) SbdsManufactureDate: Gets a value representing the 'Sbds Manufacture Date' field
        /// <summary>
        /// Gets a value representing the <c>Sbds Manufacture Date</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsManufactureDate => UnpacketBatteryDate((ushort)GetWord(0x12));
        #endregion

        #region [private] (string) SbdsDeviceChemistry: Gets a value representing the 'Sbds Device Chemistry' field
        /// <summary>
        /// Gets a value representing the <c>Sbds Device Chemistry</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsDeviceChemistry => GetString(0x14);
        #endregion

        #region [private] (byte) DesignCapacityMultiplier: Gets a value representing the 'Design Capacity Multiplier' field
        /// <summary>
        /// Gets a value representing the <c>Design Capacity Multiplier</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DesignCapacityMultiplier => GetByte(0x15);
        #endregion

        #region [private] (long) OemSpecific: Gets a value representing the 'Oem Specific' field
        /// <summary>
        /// Gets a value representing the <c>Oem Specific</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long OemSpecific => GetDoubleWord(0x16);
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
            SmbiosType022Property propertyId = (SmbiosType022Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.1] - [Location] - [String]
                case SmbiosType022Property.Location:
                    value = Location;
                    break;
                #endregion

                #region [0x05] - [v2.1] - [Manufacturer] - [String]
                case SmbiosType022Property.Manufacturer:
                    value = Manufacturer;
                    break;
                #endregion

                #region [0x06] - [v2.1] - [Manufacture Date] - [String]
                case SmbiosType022Property.ManufactureDate:
                    if (string.IsNullOrEmpty(ManufactureDate))
                    {
                        if (HeaderInfo.Lenght >= 0x13)
                        {
                            value = SbdsManufactureDate;
                        }
                    }
                    else
                    {
                        value = ManufactureDate;
                    }
                    break;
                #endregion

                #region [0x07] - [v2.1] - [Serial Number] - [string]
                case SmbiosType022Property.SerialNumber:
                    if (string.IsNullOrEmpty(SerialNumber))
                    {
                        if (HeaderInfo.Lenght >= 0x11)
                        {
                            value = SbdsSerialNumber;
                        }
                    }
                    else
                    {
                        value = SerialNumber;
                    }
                    break;
                #endregion

                #region [0x08] - [v2.1] - [Device Name] - [String]
                case SmbiosType022Property.DeviceName:
                    value = DeviceName;
                    break;
                #endregion

                #region [0x09] - [v2.1] - [Device Chemistry] - [String]
                case SmbiosType022Property.DeviceChemistry:
                    if (DeviceChemistryValue == 0x02)
                    {
                        if (HeaderInfo.Lenght >= 0x15)
                        {
                            value = SbdsDeviceChemistry;
                        }
                    }
                    else
                    {
                        value = GetDeviceChemistry(DeviceChemistryValue);
                    }                    
                    break;
                #endregion

                #region [0x0a] - [v2.1] - [Device Capacity] - [Int32?]
                case SmbiosType022Property.DesignCapacity:
                    if (DesignCapacity != 00)
                    {
                        if (HeaderInfo.Lenght >= 0x16)
                        {
                            int designCapacityCalculated = DesignCapacity * DesignCapacityMultiplier;
                            value = (int?) designCapacityCalculated;
                        }
                        else
                        {
                            value = (int?) DesignCapacity;
                        }
                    }
                    break;
                #endregion

                #region [0x0c] - [v2.1] - [Design Voltage] - [Int32?]
                case SmbiosType022Property.DesignVoltage:
                    if (DesignVoltage != 00)
                    {
                        value = (int?)DesignVoltage;
                    }
                    break;
                #endregion

                #region [0x0e] - [v2.1] - [SBDS Version Number] - [String]
                case SmbiosType022Property.SBDSVersionNumber:                
                    value = SbdsVersionNumber;
                    break;
                #endregion

                #region [0x0f] - [v2.1] - [Maximum Error In Battery Data] - [Byte?]
                case SmbiosType022Property.MaximunErrorInBatteryData:
                    if (MaximumErrorInBatteryData != 0xff)
                    {
                        value = (byte?) MaximumErrorInBatteryData;
                    }
                    break;
                #endregion

                #region [0x15] - [v2.2] - [OEM-specific] - [Int64?]
                case SmbiosType022Property.OemSpecific:
                    if (HeaderInfo.Lenght >= 0x17)
                    {
                        value = (long?)OemSpecific;
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
            properties.Add(KnownDmiProperty.PortableBattery.Location, Location);
            properties.Add(KnownDmiProperty.PortableBattery.Manufacturer, Manufacturer);
                   
            if (string.IsNullOrEmpty(ManufactureDate))
            {
                if (HeaderInfo.Lenght >= 0x13)
                {
                    properties.Add(KnownDmiProperty.PortableBattery.ManufactureDate, SbdsManufactureDate);
                }
            }
            else
            {
                properties.Add(KnownDmiProperty.PortableBattery.ManufactureDate, ManufactureDate);
            }

            if (string.IsNullOrEmpty(SerialNumber))
            {
                if (HeaderInfo.Lenght >= 0x11)
                {
                    properties.Add(KnownDmiProperty.PortableBattery.SerialNumber, SbdsSerialNumber);
                }
            }
            else
            {
                properties.Add(KnownDmiProperty.PortableBattery.SerialNumber, SerialNumber);
            }

            properties.Add(KnownDmiProperty.PortableBattery.DeviceName, DeviceName);

            if (DeviceChemistryValue == 0x02)
            {
                if (HeaderInfo.Lenght >= 0x15)
                {
                    properties.Add(KnownDmiProperty.PortableBattery.DeviceChemistry, SbdsDeviceChemistry);
                }
            }
            else
            {
                properties.Add(KnownDmiProperty.PortableBattery.DeviceChemistry, GetDeviceChemistry(DeviceChemistryValue));
            }

            if (DesignCapacity != 00)
            {
                if (HeaderInfo.Lenght >= 0x16)
                {
                    int designCapacityCalculated = DesignCapacity * DesignCapacityMultiplier;
                    properties.Add(KnownDmiProperty.PortableBattery.DesignCapacity, designCapacityCalculated);
                }
                else
                {
                    properties.Add(KnownDmiProperty.PortableBattery.DesignCapacity, DesignCapacity);
                }
            }

            if (DesignVoltage != 00)
            {
                properties.Add(KnownDmiProperty.PortableBattery.DesignVoltage, DesignVoltage);
            }

            properties.Add(KnownDmiProperty.PortableBattery.SBDSVersionNumber, SbdsVersionNumber);

            if (MaximumErrorInBatteryData != 0xff)
            {
                properties.Add(KnownDmiProperty.PortableBattery.MaximunErrorInBatteryData, MaximumErrorInBatteryData);
            }

            if (HeaderInfo.Lenght >= 0x17)
            {
                properties.Add(KnownDmiProperty.PortableBattery.OemSpecific, OemSpecific);
            }
            #endregion
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (Func<ushort, string>) UnpacketBatteryDate: Unpacket battery date
        /// <summary>
        /// The unpacket battery date
        /// </summary>
        private static readonly Func<ushort, string> UnpacketBatteryDate = a => string.Concat(("00" + (a & 0x1F)).Right(2), "/", ("00" + (a >> 5 & 0x0F)).Right(2), "/", 0x07BC + (a >> 9));
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceChemistry(byte): Gets a string representing the battery type
        /// <summary>
        /// Gets a string representing the battery type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The battery type.
        /// </returns>
        private static string GetDeviceChemistry(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "Lead Acid",
                "Nickel Cadmium",
                "Nickel metal hydride",
                "Lithium-ion",
                "Zinc air",
                "Lithium Polymer" // 0x08
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
