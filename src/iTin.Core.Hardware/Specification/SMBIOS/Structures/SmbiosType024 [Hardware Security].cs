
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 024: Hardware Security.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        24          Hardware Security indicator                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        05h         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Hardware        BYTE        Bit Field   Identifies the password and reset status for the      |
    // |              Security                                system:                                               |
    // |              Settings                                                                                      |
    // |                                                      Bits 07:06 - Power-on Password Status value:          |
    // |                                                                   00b - Disabled                           |
    // |                                                                   01b - Enabled                            |
    // |                                                                   10b - Not Implemented                    |
    // |                                                                   11b - Unknown                            |
    // |                                                                                                            |
    // |                                                      Bits 05:04 - Keyboard Password Status value:          |
    // |                                                                   00b - Disabled                           |
    // |                                                                   01b - Enabled                            |
    // |                                                                   10b - Not Implemented                    |
    // |                                                                   11b - Unknown                            |
    // |                                                                                                            |
    // |                                                      Bits 03:02 - Administrator Password Status value:     |
    // |                                                                   00b - Disabled                           |
    // |                                                                   01b - Enabled                            |
    // |                                                                   10b - Not Implemented                    |
    // |                                                                   11b - Unknown                            |
    // |                                                                                                            |
    // |                                                      Bits 01:00 - Front Panel Reset Status value:          |
    // |                                                                   00b - Disabled                           |
    // |                                                                   01b - Enabled                            |
    // |                                                                   10b - Not Implemented                    |
    // |                                                                   11b - Unknown                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Hardware Security (Type 24) structure.
    /// </summary>
    sealed class SmbiosType024 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType024(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType024"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType024(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) HardwareSecuritySettings: Gets a value representing the 'Hardware Security Settings' field
        /// <summary>
        /// Gets a value representing the <c>Hardware Security Setting</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HardwareSecuritySettings => GetByte(0x04);
        #endregion

        #region [private] (byte) FrontPanelResetStatus: Gets a value representing the 'Front Panel ResetS Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <c>Front Panel ResetS Status</c> hardware setting of the <c>Hardware Security Setting</c> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FrontPanelResetStatus => (byte) (HardwareSecuritySettings & 0x03);
        #endregion

        #region [private] (byte) AdministratorPasswordStatus: Gets a value representing the 'Administrator Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <c>Administrator Password Status</c> hardware setting of the <c>Hardware Security Setting</c> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AdministratorPasswordStatus => (byte) ((HardwareSecuritySettings >> 2) & 0x03);
        #endregion

        #region [private] (byte) KeyboardPasswordStatus: Gets a value representing the 'Keyboard Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <c>Keyboard Password Status</c> hardware setting of the <c>Hardware Security Setting</c> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte KeyboardPasswordStatus => (byte) ((HardwareSecuritySettings >> 4) & 0x03);
        #endregion

        #region [private] (byte) PowerOnPasswordStatus: Gets a value representing the 'Power-On Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <c>Power-On Password Status</c> hardware setting of the <c>Hardware Security Setting</c> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PowerOnPasswordStatus => (byte) ((HardwareSecuritySettings >> 6) & 0x03);
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
            SmbiosType024Property propertyId = (SmbiosType024Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Hardware Security Settings]

                    #region [0x04] - [Hardware Security Settings -> Front Panel Reset Status] - [String]
                    case SmbiosType024Property.FrontPanelResetStatus:
                        value = GetSettings(FrontPanelResetStatus);
                        break;
                    #endregion

                    #region [0x04] - [Hardware Security Settings -> Administrator Password Status] - [String]
                    case SmbiosType024Property.AdministratorPasswordStatus:
                        value = GetSettings(AdministratorPasswordStatus);
                        break;
                    #endregion

                    #region [0x04] - [Hardware Security Settings -> Keyboard Password Status] - [String]
                    case SmbiosType024Property.KeyboardPasswordStatus:
                        value = GetSettings(KeyboardPasswordStatus);
                        break;
                    #endregion

                    #region [0x04] - [Hardware Security Settings -> Power On Password Status] - [String]
                    case SmbiosType024Property.PowerOnPasswordStatus:
                        value = GetSettings(PowerOnPasswordStatus);
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
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus, GetSettings(FrontPanelResetStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus, GetSettings(AdministratorPasswordStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus, GetSettings(KeyboardPasswordStatus));
            properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus, GetSettings(PowerOnPasswordStatus));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetSettings(byte): Gets a string representing the set configuration
        /// <summary>
        /// Gets a string representing the set configuration.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The set configuration.
        /// </returns>
        private static string GetSettings(byte code)
        {
            string[] value =
            {
                "Disabled",            // 0x00
                "Enabled",
                "Not Implemented",
                "Unknown"              // 0x03
            };

            return value[code];
        }
        #endregion

        #endregion
    }
}
