
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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
    // |                                                      Note: See ReferenceDesignation                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Device Type     BYTE        ENUM        Bit  07    – Device Status:                           |
    // |                                                                   01b – Device Enabled                     |
    // |                                                                   00b – Device Disabled                    |
    // |                                                      Note: Ver DeviceStatus                                |
    // |                                                                                                            |
    // |                                                      Bits 06:00 – Type of Device                           |
    // |                                                      Note: Ver DeviceType                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Device Type     BYTE        Varies      Note: See DeviceTypeInstance                          |
    // |              Instance                                                                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Segment Group   WORD        Varies      Note: See SegmentGroupNumber                          |
    // |              Number                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Bus Number      BYTE        Varies      Note: See BusNumber                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Device/         BYTE        Bit Field   Bits 07:03 – Device number                            |
    // |              Function                                Note: Ver DeviceNumber                                |
    // |              Number                                                                                        |
    // |                                                      Bits 02:00 – Function number                          |
    // |                                                      Note: See FunctionNumber                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Onboard Devices Extended Information (Type 41) structure.
    /// </summary>
    internal sealed class SmbiosType041 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType041(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType041"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType041(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ReferenceDesignation: Gets a value representing the 'Reference Designation' field
        /// <summary>
        /// Gets a value representing the <b>Reference Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ReferenceDesignation => GetString(0x04);
        #endregion

        #region [private] (string) DeviceStatus: Gets a value representing the 'Device Status' field
        /// <summary>
        /// Gets a value representing the <b>Device Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceStatus => Reader.GetByte(0x05).CheckBit(Bits.Bit07) ? "Enabled" : "Disabled";
        #endregion

        #region [private] (byte) DeviceType: Gets a value representing the 'Device Type' field
        /// <summary>
        /// Gets a value representing the <b>Device Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceType => (byte) (Reader.GetByte(0x05) & 0x7f);
        #endregion

        #region [private] (byte) DeviceTypeInstance: Gets a value representing the 'Device Type Instance' field
        /// <summary>
        /// Gets a value representing the <b>Device Type Instance</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceTypeInstance => Reader.GetByte(0x06);
        #endregion

        #region [private] (ushort) SegmentGroupNumber: Gets a value representing the 'Segment Group Number' field
        /// <summary>
        /// Gets a value representing the <b>Segment Group Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort SegmentGroupNumber => (ushort)Reader.GetWord(0x07);
        #endregion

        #region [private] (byte) BusNumber: Gets a value representing the 'Bus Number' field
        /// <summary>
        /// Gets a value representing the <b>Bus Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BusNumber => Reader.GetByte(0x09);
        #endregion

        #region [private] (byte) DeviceFunction: Gets a value representing the 'Device Function' field
        /// <summary>
        /// Gets a value representing the <b>Device Function</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceFunction => (byte)(Reader.GetByte(0x0a) & 0x07);
        #endregion

        #region [private] (byte) DeviceNumber: Gets a value representing the 'Device Number' field
        /// <summary>
        /// Gets a value representing the <b>Device Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceNumber => (byte)((Reader.GetByte(0x0a) >> 3) & 0x1f);
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

            properties.Add(SmbiosProperty.OnBoardDevicesExtended.ReferenceDesignation, ReferenceDesignation);
            properties.Add(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceStatus, DeviceStatus);
            properties.Add(SmbiosProperty.OnBoardDevicesExtended.Element.DeviceType, GetDeviceType(DeviceType));
        }
        #endregion

        #endregion


        #region BIOS Specification 3.5.0 (15/09/2021)

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
                "SAS Controller",
                "Wireless LAN",
                "Bluetooth",
                "WWAN",
                "eMMC (embedded Multi-Media Controller)",
                "NVMe Controller",
                "UFS Controller"      // 0x10     
            };

            if (code >= 0x01 && code <= 0x10)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
