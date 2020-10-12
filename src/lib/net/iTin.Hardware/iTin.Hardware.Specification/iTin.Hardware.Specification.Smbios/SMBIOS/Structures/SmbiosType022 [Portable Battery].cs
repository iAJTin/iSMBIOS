
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    using iTin.Core;

    using Property;

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

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Portable Battery (Type 22) structure.
    /// </summary>
    internal sealed class SmbiosType022 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType022(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType022"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType022(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (string) Location: Gets a value representing the 'Location' field
        /// <summary>
        /// Gets a value representing the <b>Location</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Location => GetString(0x04);
        #endregion

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x05);
        #endregion

        #region [private] (string) ManufacturerDate: Gets a value representing the 'Manufacturer Date' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer Date</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ManufactureDate
        {
            get
            {
                byte rawManufactureDate = Reader.GetByte(0x06);
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
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber
        {
            get
            {
                byte rawSerialNumber = Reader.GetByte(0x07);
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
        /// Gets a value representing the <b>Device Name</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceName => GetString(0x08);
        #endregion

        #region [private] (byte) DeviceChemistryValue: Gets a value representing the 'Device Chemistry Value' field
        /// <summary>
        /// Gets a value representing the <b>Device Chemistry Value</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceChemistryValue => Reader.GetByte(0x09);
        #endregion

        #region [private] (ushort) DesignCapacity: Gets a value representing the 'Design Capacity' field
        /// <summary>
        /// Gets a value representing the <b>Design Capacity</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort DesignCapacity => (ushort) Reader.GetWord(0x0a);
        #endregion

        #region [private] (ushort) DesignVoltage: Gets a value representing the 'Design Voltage' field
        /// <summary>
        /// Gets a value representing the <b>Design Voltage</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort DesignVoltage => (ushort)Reader.GetWord(0x0c);
        #endregion

        #region [private] (string) SbdsVersionNumber: Gets a value representing the 'Sbds Version Number' field
        /// <summary>
        /// Gets a value representing the <b>Sbds Version Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsVersionNumber => GetString(0x0e);
        #endregion

        #region [private] (byte) MaximumErrorInBatteryData: Gets a value representing the 'Maximum Error In Battery Data' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Error In Battery Data</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MaximumErrorInBatteryData => Reader.GetByte(0x0f);
        #endregion

        #endregion

        #region Version 2.2+ fields

        #region [private] (string) SbdsSerialNumber: Gets a value representing the 'Sbds Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Sbds Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsSerialNumber => Reader.GetWord(0x10).ToString(CultureInfo.InvariantCulture);
        #endregion

        #region [private] (string) SbdsManufactureDate: Gets a value representing the 'Sbds Manufacture Date' field
        /// <summary>
        /// Gets a value representing the <b>Sbds Manufacture Date</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsManufactureDate => UnpacketBatteryDate((ushort)Reader.GetWord(0x12));
        #endregion

        #region [private] (string) SbdsDeviceChemistry: Gets a value representing the 'Sbds Device Chemistry' field
        /// <summary>
        /// Gets a value representing the <b>Sbds Device Chemistry</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SbdsDeviceChemistry => GetString(0x14);
        #endregion

        #region [private] (byte) DesignCapacityMultiplier: Gets a value representing the 'Design Capacity Multiplier' field
        /// <summary>
        /// Gets a value representing the <b>Design Capacity Multiplier</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DesignCapacityMultiplier => Reader.GetByte(0x15);
        #endregion

        #region [private] (uint) OemSpecific: Gets a value representing the 'Oem Specific' field
        /// <summary>
        /// Gets a value representing the <b>Oem Specific</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint OemSpecific => (uint)Reader.GetDoubleWord(0x16);
        #endregion

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
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.PortableBattery.Location, Location);
                properties.Add(SmbiosProperty.PortableBattery.Manufacturer, Manufacturer);
                properties.Add(SmbiosProperty.PortableBattery.DeviceName, DeviceName);
                properties.Add(SmbiosProperty.PortableBattery.DesignVoltage, DesignVoltage);
                properties.Add(SmbiosProperty.PortableBattery.SBDSVersionNumber, SbdsVersionNumber);
                properties.Add(SmbiosProperty.PortableBattery.MaximunErrorInBatteryData, MaximumErrorInBatteryData);

                if (string.IsNullOrEmpty(ManufactureDate))
                {
                    if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
                    {
                        properties.Add(SmbiosProperty.PortableBattery.ManufactureDate, SbdsManufactureDate);
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.PortableBattery.ManufactureDate, ManufactureDate);
                }

                if (string.IsNullOrEmpty(SerialNumber))
                {
                    if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
                    {
                        properties.Add(SmbiosProperty.PortableBattery.SerialNumber, SbdsSerialNumber);
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.PortableBattery.SerialNumber, SerialNumber);
                }


                if (DeviceChemistryValue == 0x02)
                {
                    if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
                    {
                        properties.Add(SmbiosProperty.PortableBattery.DeviceChemistry, SbdsDeviceChemistry);
                    }
                }
                else
                {
                    properties.Add(SmbiosProperty.PortableBattery.DeviceChemistry, GetDeviceChemistry(DeviceChemistryValue));
                }

                if (DesignCapacity != 00)
                {
                    if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
                    {
                        int designCapacityCalculated = DesignCapacity * DesignCapacityMultiplier;
                        properties.Add(SmbiosProperty.PortableBattery.DesignCapacity, designCapacityCalculated);
                        properties.Add(SmbiosProperty.PortableBattery.DesignCapacityMultiplier, DesignCapacityMultiplier);
                    }
                    else
                    {
                        properties.Add(SmbiosProperty.PortableBattery.DesignCapacity, DesignCapacity);
                    }
                }
            }

            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
            {
                properties.Add(SmbiosProperty.PortableBattery.OemSpecific, OemSpecific);
            }
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
