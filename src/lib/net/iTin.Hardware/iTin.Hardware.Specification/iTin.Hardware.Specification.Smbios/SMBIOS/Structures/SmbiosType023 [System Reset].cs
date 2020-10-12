
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 023: System Reset.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        23          System Reset                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        0Dh         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Capabilities    BYTE        Bit Field   Identifies the system-reset capabilities for the      |
    // |                                                      system.                                               |
    // |                                                                                                            |
    // |                                                      Bits 07:06 - Reserved for future assignment by this   |
    // |                                                                   specification; set to 00b.               |
    // |                                                                                                            |
    // |                                                      Bit     05 - System contains a watchdog timer.        |
    // |                                                                   0b - False                               |
    // |                                                                   1b - True                                |
    // |                                                                   Note: See WatchdogTimer                  |
    // |                                                                                                            |
    // |                                                      Bits 04:03 - Boot Option on Limit.                    |
    // |                                                                   Identifies one of the following system   |
    // |                                                                   actions to be taken when the Reset Limit |
    // |                                                                   is reached:                              |
    // |                                                                   00b - Reserved, do not use               |
    // |                                                                   01b - Operating system                   |
    // |                                                                   10b - System utilities                   |
    // |                                                                   11b - Do not reboot                      |
    // |                                                                   Note: See GetBootOption(byte)            |
    // |                                                                                                            |
    // |                                                      Bits 02:01 - Boot Option.                             |
    // |                                                                   Indicates one of the following actions   |
    // |                                                                   to be taken after a watchdog reset:      |
    // |                                                                   00b - Reserved, do not use               |
    // |                                                                   01b - Operating system                   |
    // |                                                                   10b - System utilities                   |
    // |                                                                   11b - Do not reboot                      |
    // |                                                                   Note: See GetBootOption(byte)            |
    // |                                                                                                            |
    // |                                                      Bit     00 - Status.                                  |
    // |                                                                   Identifies whether (1) or not (0) the    |
    // |                                                                   system reset is enabled by the user.     |
    // |                                                                   Note: See Status                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Reset Count         WORD        Varies  The number of automatic system resets since the last  |
    // |                                                      intentional reset.                                    |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: See ResetCount                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Reset Limit         WORD        Varies  The number of consecutive times the system reset is   |
    // |                                                      attempted.                                            |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: See ResetLimit                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Timer Interval      WORD        Varies  The number of minutes to use for the watchdog timer.  |
    // |                                                      If the timer is not reset within this interval, the   |
    // |                                                      system  reset timeout begins.                         |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: See TimerInterval                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Timeout             WORD        Varies  Identifies the number of minutes before the reboot is |
    // |                                                      initiated.                                            |
    // |                                                      It is used after a system power cycle, system reset   |
    // |                                                      (local or remote), and automatic system reset.        |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: See TimeOut                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Reset (Type 23) structure.
    /// </summary>
    internal sealed class SmbiosType023 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType023(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType023"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType023(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Capabilities: Gets a value representing the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Capabilities</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Capabilities => Reader.GetByte(0x04);
        #endregion

        #region [private] (string) Status: Gets a value representing the 'Status' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Status</b> capability of the <b>Capabilities</b> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Status => Capabilities.CheckBit(Bits.Bit00) ? "Enabled" : "Disabled";
        #endregion

        #region [private] (byte) BootOption: Gets a value representing the 'Boot Option' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Boot Option</b> capability of the <b>Capabilities</b> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootOption => (byte) ((Capabilities >> 1) & 0x03);
        #endregion

        #region [private] (byte) BootOptionOnLimit: Gets a value representing the 'Boot Option On Limit' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Boot Option On Limit</b> capability of the <b>Capabilities</b> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootOptionOnLimit => (byte) ((Capabilities >> 3) & 0x03);
        #endregion

        #region [private] (bool) WatchdogTimer: Gets a value representing the 'Watchdog Timer' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Watchdog Timer</b> capability of the <b>Capabilities</b> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool WatchdogTimer => Capabilities.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (ushort) ResetCount: Gets a value representing the 'Reset Count' field
        /// <summary>
        /// Gets a value representing the <b>Reset Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ResetCount => (ushort) Reader.GetWord(0x05);
        #endregion

        #region [private] (ushort) ResetLimit: Gets a value representing the 'Reset Limit' field
        /// <summary>
        /// Gets a value representing the <b>Reset Limit</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ResetLimit => (ushort)Reader.GetWord(0x07);
        #endregion

        #region [private] (ushort) TimerInterval: Gets a value representing the 'Timer Interval' field
        /// <summary>
        /// Gets a value representing the <b>Timer Interval</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort TimerInterval => (ushort)Reader.GetWord(0x09);
        #endregion

        #region [private] (ushort) TimeOut: Gets a value representing the 'Time Out' field
        /// <summary>
        /// Gets a value representing the <b>Time Out</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort TimeOut => (ushort)Reader.GetWord(0x09);
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

            properties.Add(SmbiosProperty.SystemReset.ResetCount, ResetCount);
            properties.Add(SmbiosProperty.SystemReset.ResetLimit, ResetLimit);
            properties.Add(SmbiosProperty.SystemReset.TimerInterval, TimerInterval);
            properties.Add(SmbiosProperty.SystemReset.Timeout, TimeOut);
            properties.Add(SmbiosProperty.SystemReset.Capabilities.Status, Status);
            properties.Add(SmbiosProperty.SystemReset.Capabilities.BootOption, GetBootOption(BootOption));
            properties.Add(SmbiosProperty.SystemReset.Capabilities.BootOptionOnLimit, GetBootOption(BootOptionOnLimit));
            properties.Add(SmbiosProperty.SystemReset.Capabilities.WatchdogTimer, WatchdogTimer);
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetBootOption(byte): Gets a string representing the boot option
        /// <summary>
        /// Gets a string representing the boot option.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Boot option.
        /// </returns>
        private static string GetBootOption(byte code)
        {
            string[] value =
            {
                "Reserved",            // 0x00
                "Operating System",
                "System Utilities",
                "Do Not Reboot"        // 0x03
            };
                    
            return value[code];
        }
        #endregion

        #endregion
    }
}
