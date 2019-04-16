
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Diagnostics;
    using System.Text;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 010: On Board Devices Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        10          On Board Devices Information Indicator                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      4 + 2 * (Number of Devices).                          |
    // |                                                      The user of this structure determines the number of   |
    // |                                                      devices as (Length - 4) / 2.                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 4+2*(n-1)    Devicen Type,   BYTE        Varies      Bit  07    Device(n) Status                           |
    // |              n ranges from                                      1b - Device Enabled                        |
    // |              1 to Number of                                     0b - Device Disabled                       |
    // |              Devices                                 Bits 06:00 Type of Device                             |
    // |                                                                 NOTE: See GetDeviceType(byte)              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 5+2*(n-1)    Description     BYTE        STRING      String number of device description                   |
    // |              String                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the On Board Devices (Type 10, Obsolete) structure.
    /// </summary>
    sealed class SmbiosType010 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType010(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType010" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType010(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) DeviceType: Gets a value representing the 'Device Type' field
        /// <summary>
        /// Gets a value representing the <c>Device Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceType => (byte) (GetByte(0x04) & 0x7f);
        #endregion

        #region [private] (bool) IsEnabled: Gets a value representing the 'Is Enabled' field
        /// <summary>
        /// Gets a value representing the <c>Is Enabled</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsEnabled => LogicHelper.CheckBit(GetByte(0x04), Bits.Bit07);
        #endregion

        #region [private] (string) Description: Gets a value representing the 'Description' field
        /// <summary>
        /// Gets a value representing the <c>Description</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description
        {
            get
            {
                const byte begin = 0x06;
                byte end = (byte)(HeaderInfo.RawData.Length - 0x02);
                byte lenght = (byte)(end - begin);
                byte[] descriptionArray = new byte[lenght];

                Array.Copy(HeaderInfo.RawData, begin, descriptionArray, 0x00, lenght);
                string description = Encoding.ASCII.GetString(descriptionArray, 0x00, lenght);

                return description;
            }
        }
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
            SmbiosType010Property propertyId = (SmbiosType010Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04 + 2*(n-1)] - [Devicen Type Info]

                    #region [0x04 + 2*(n-1)] - [Devicen Type Info -> Enabled] - [Boolean]
                    case SmbiosType010Property.Enabled:
                        value = IsEnabled;
                        break;
                    #endregion

                    #region [0x04 + 2*(n-1)] - [Devicen Type Info -> Device Type] - [String]
                    case SmbiosType010Property.DeviceType:
                        value = GetDeviceType(DeviceType);
                        break;
                    #endregion

                #endregion

                #region [0x05 + 2*(n-1)] - [Description] - [String]
                case SmbiosType010Property.Description:
                    value = Description;
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
            properties.Add(KnownDmiProperty.OnBoardDevices.Enabled, IsEnabled);
            properties.Add(KnownDmiProperty.OnBoardDevices.DeviceType, GetDeviceType(DeviceType));
            properties.Add(KnownDmiProperty.OnBoardDevices.Description, Description);
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceType(byte): Gets a value representing the built-in device type
        /// <summary>
        /// Gets a value representing the built-in device type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The built-in device type.
        /// </returns>
        private static string GetDeviceType(byte code)
        {
            var value = new[]
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
