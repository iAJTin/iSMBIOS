
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 034: Management Device.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        34          Management Device indicator                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        0Bh         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Description     BYTE        STRING      The number of the string that contains additional     |
    // |                                                      descriptive information about the device or its       |
    // |                                                      location.                                             |
    // |                                                      Note: See Description                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Type            BYTE        Varies      Defines the device’s type.                            |
    // |                                                      Note: See GetDeviceType(byte)                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Address         DWORD       Varies      Defines the device’s address.                         |
    // |                                                      Note: See Address                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Address         BYTE        Varies      Defines the type of addressing used to access the     |
    // |              Type                                    device.                                               |
    // |                                                      Note: See GetDeviceAddressType(byte)                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the  Management Device (Type 34) structure.
    /// </summary>
    internal sealed class SmbiosType034 : SmbiosBaseType
    {
        #region Constructor/es

        #region [public] SmbiosType034(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType034"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType034(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Description: Gets a value representing the 'Description' field
        /// <summary>
        /// Gets a value representing the <b>Description</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description => GetString(0x04);
        #endregion

        #region [private] (byte) Type: Gets a value representing the 'Type' field
        /// <summary>
        /// Gets a value representing the <b>Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Type => Reader.GetByte(0x05);
        #endregion

        #region [private] (string) Address: Gets a value representing the 'Address' field
        /// <summary>
        /// Gets a value representing the <b>Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Address => $"{Reader.GetWord(0x06):X}:{Reader.GetWord(0x08):X}";
        #endregion

        #region [private] (byte) AddressType: Gets a value representing the 'Address Type' field
        /// <summary>
        /// Gets a value representing the <b>Address Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AddressType => Reader.GetByte(0x0a);
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

            properties.Add(SmbiosProperty.ManagementDevice.Description, Description);
            properties.Add(SmbiosProperty.ManagementDevice.Type, GetDeviceType(Type));
            properties.Add(SmbiosProperty.ManagementDevice.Address, Address);
            properties.Add(SmbiosProperty.ManagementDevice.AddressType, GetDeviceAddressType(AddressType));
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceAddressType(byte): Gets a string that represents the type of address
        /// <summary>
        /// Gets a string that represents the type of address.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The type of address.
        /// </returns>
        private static string GetDeviceAddressType(byte code)
        {
            string[] value =
            {
                "Other",       // 0x01
                "Unknown",
                "I/O Port",
                "Memory",
                "SM Bus"       // 0x05
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetDeviceType(byte): Gets a string representing the device type
        /// <summary>
        /// Gets a string representing the device type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The device type.
        /// </returns>
        private static string GetDeviceType(byte code)
        {
            string[] value =
            {
                "Other",                         // 0x01
                "Unknown",
                "National Semiconductor LM75",
                "National Semiconductor LM78",
                "National Semiconductor LM79",
                "National Semiconductor LM80",
                "National Semiconductor LM81",
                "Analog Devices ADM9240",
                "Dallas Semiconductor DS1780",
                "Maxim 1617",
                "Genesys GL518SM",
                "Winbond W83781D",
                "Holtek HT82H791"                // 0x0D                                       
            };

            if (code >= 0x01 && code <= 0x0D)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
