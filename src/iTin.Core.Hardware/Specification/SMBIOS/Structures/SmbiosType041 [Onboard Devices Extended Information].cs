
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 041: Onboard Devices Extended Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        41          Onboard Devices Extended Information                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      0Bh for version 2.6 and later                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Reference       BYTE        STRING      String number of the onboard device reference         |
    // |              Designation                             designation.                                          |
    // |                                                      Note: Ver ReferenceDesignation                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Device Type     BYTE        ENUM        Bit  07    – Device Status:                           |
    // |                                                                   01b – Device Enabled                     |
    // |                                                                   00b – Device Disabled                    |
    // |                                                      Note: Ver DeviceStatus                                |
    // |                                                                                                            |
    // |                                                      Bits 06:00 – Type of Device                           |
    // |                                                      Note: Ver DeviceType                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Device Type     BYTE        Varies      Note: Ver DeviceTypeInstance                          |
    // |              Instance                                                                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Segment Group   WORD        Varies      Note: Ver SegmentGroupNumber                          |
    // |              Number                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Bus Number      BYTE        Varies      Note: Ver BusNumber                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Device/         BYTE        Bit Field   Bits 07:03 – Device number                            |
    // |              Function                                Note: Ver DeviceNumber                                |
    // |              Number                                                                                        |
    // |                                                      Bits 02:00 – Function number                          |
    // |                                                      Note: Ver FunctionNumber                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Onboard Devices Extended Information (Type 41) structure.
    /// </summary>
    sealed class SmbiosType041 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType041(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType041" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType041(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ReferenceDesignation: Gets a value representing the 'Reference Designation' field
        /// <summary>
        /// Gets a value representing the <c>Reference Designation</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ReferenceDesignation => GetString(0x04);
        #endregion

        #region [private] (string) DeviceStatus: Gets a value representing the 'Device Status' field
        /// <summary>
        /// Gets a value representing the <c>Device Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceStatus => GetByte(0x05).CheckBit(Bits.Bit07) ? "Enabled" : "Disabled";
        #endregion

        #region [private] (byte) DeviceType: Gets a value representing the 'Device Type' field
        /// <summary>
        /// Gets a value representing the <c>Device Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceType => (byte) (GetByte(0x05) & 0x7f);
        #endregion

        #region [private] (byte) DeviceTypeInstance: Gets a value representing the 'Device Type Instance' field
        /// <summary>
        /// Gets a value representing the <c>Device Type Instance</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceTypeInstance => GetByte(0x06);
        #endregion

        #region [private] (int) SegmentGroupNumber: Gets a value representing the 'Segment Group Number' field
        /// <summary>
        /// Gets a value representing the <c>Segment Group Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int SegmentGroupNumber => GetWord(0x07);
        #endregion

        #region [private] (byte) BusNumber: Gets a value representing the 'Bus Number' field
        /// <summary>
        /// Gets a value representing the <c>Bus Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BusNumber => GetByte(0x09);
        #endregion

        #region [private] (byte) DeviceFunction: Gets a value representing the 'Device Function' field
        /// <summary>
        /// Gets a value representing the <c>Device Function</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceFunction => (byte)(GetByte(0x0a) & 0x07);
        #endregion

        #region [private] (byte) DeviceNumber: Gets a value representing the 'Device Number' field
        /// <summary>
        /// Gets a value representing the <c>Device Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceNumber => (byte)((GetByte(0x0a) >> 3) & 0x1f);
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
            SmbiosType041Property propertyId = (SmbiosType041Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Reference Designation] - [String]
                case SmbiosType041Property.ReferenceDesignation:
                    value = ReferenceDesignation;
                    break;
                #endregion

                #region [0x05] - [Element]

                    #region [0x05] - [Element -> Device Type] - [String]
                    case SmbiosType041Property.DeviceType:
                        value = GetDeviceType(DeviceType);
                        break;
                    #endregion

                    #region [0x05] - [Element -> Device Status] - [String]
                    case SmbiosType041Property.DeviceStatus:
                        value = DeviceStatus;
                        break;
                    #endregion

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
            properties.Add(KnownDmiProperty.OnBoardDevicesExtended.ReferenceDesignation, ReferenceDesignation);
            properties.Add(KnownDmiProperty.OnBoardDevicesExtended.Element.DeviceStatus, DeviceStatus);
            properties.Add(KnownDmiProperty.OnBoardDevicesExtended.Element.DeviceType, GetDeviceType(DeviceType));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceType(byte): Gets a string representing the device type
        /// <summary>
        /// Gets a string representing the device type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The device type..
        /// </returns> 
        private static string GetDeviceType(byte code)
        {
            string[] value =
            {
                "Other",               // 0x01
                "Unknown",
                "Video",
                "SCSI Controller",
                "Ethernet",
                "Token Ring",
                "Sound",
                "PATA Controller",
                "SATA Controller",
                "SAS Controller"       // 0x0A                                        
            };

            if (code >= 0x01 && code <= 0x0A)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
