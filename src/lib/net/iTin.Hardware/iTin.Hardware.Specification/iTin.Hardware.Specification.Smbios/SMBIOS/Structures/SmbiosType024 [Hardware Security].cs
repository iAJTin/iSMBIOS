
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

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

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Hardware Security (Type 24) structure.
    /// </summary>
    internal sealed class SmbiosType024 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType024(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType024"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType024(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) HardwareSecuritySettings: Gets a value representing the 'Hardware Security Settings' field
        /// <summary>
        /// Gets a value representing the <b>Hardware Security Setting</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HardwareSecuritySettings => Reader.GetByte(0x04);
        #endregion

        #region [private] (byte) FrontPanelResetStatus: Gets a value representing the 'Front Panel ResetS Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <b>Front Panel ResetS Status</b> hardware setting of the <b>Hardware Security Setting</b> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FrontPanelResetStatus => (byte) (HardwareSecuritySettings & 0x03);
        #endregion

        #region [private] (byte) AdministratorPasswordStatus: Gets a value representing the 'Administrator Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <b>Administrator Password Status</b> hardware setting of the <b>Hardware Security Setting</b> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AdministratorPasswordStatus => (byte) ((HardwareSecuritySettings >> 2) & 0x03);
        #endregion

        #region [private] (byte) KeyboardPasswordStatus: Gets a value representing the 'Keyboard Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <b>Keyboard Password Status</b> hardware setting of the <b>Hardware Security Setting</b> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte KeyboardPasswordStatus => (byte) ((HardwareSecuritySettings >> 4) & 0x03);
        #endregion

        #region [private] (byte) PowerOnPasswordStatus: Gets a value representing the 'Power-On Password Status' hardware setting of the 'Hardware Security Setting' field
        /// <summary>
        /// Gets a value representing the <b>Power-On Password Status</b> hardware setting of the <b>Hardware Security Setting</b> field
        /// </summary>
        /// <value>
        /// Hardware setting value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PowerOnPasswordStatus => (byte) ((HardwareSecuritySettings >> 6) & 0x03);
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

            properties.Add(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus, GetSettings(FrontPanelResetStatus));
            properties.Add(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus, GetSettings(AdministratorPasswordStatus));
            properties.Add(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus, GetSettings(KeyboardPasswordStatus));
            properties.Add(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus, GetSettings(PowerOnPasswordStatus));
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
