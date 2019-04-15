
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

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
    // |                                                                   Note: Ver WatchdogTimer                  |
    // |                                                                                                            |
    // |                                                      Bits 04:03 - Boot Option on Limit.                    |
    // |                                                                   Identifies one of the following system   |
    // |                                                                   actions to be taken when the Reset Limit |
    // |                                                                   is reached:                              |
    // |                                                                   00b - Reserved, do not use               |
    // |                                                                   01b - Operating system                   |
    // |                                                                   10b - System utilities                   |
    // |                                                                   11b - Do not reboot                      |
    // |                                                                   Note: Ver GetBootOption(byte)            |
    // |                                                                                                            |
    // |                                                      Bits 02:01 - Boot Option.                             |
    // |                                                                   Indicates one of the following actions   |
    // |                                                                   to be taken after a watchdog reset:      |
    // |                                                                   00b - Reserved, do not use               |
    // |                                                                   01b - Operating system                   |
    // |                                                                   10b - System utilities                   |
    // |                                                                   11b - Do not reboot                      |
    // |                                                                   Note: Ver GetBootOption(byte)            |
    // |                                                                                                            |
    // |                                                      Bit     00 - Status.                                  |
    // |                                                                   Identifies whether (1) or not (0) the    |
    // |                                                                   system reset is enabled by the user.     |
    // |                                                                   Note: Ver Status                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Reset Count         WORD        Varies  The number of automatic system resets since the last  |
    // |                                                      intentional reset.                                    |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: Ver ResetCount                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Reset Limit         WORD        Varies  The number of consecutive times the system reset is   |
    // |                                                      attempted.                                            |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: Ver ResetLimit                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Timer Interval      WORD        Varies  The number of minutes to use for the watchdog timer.  |
    // |                                                      If the timer is not reset within this interval, the   |
    // |                                                      system  reset timeout begins.                         |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: Ver TimerInterval                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Timeout             WORD        Varies  Identifies the number of minutes before the reboot is |
    // |                                                      initiated.                                            |
    // |                                                      It is used after a system power cycle, system reset   |
    // |                                                      (local or remote), and automatic system reset.        |
    // |                                                      A value of 0FFFFh indicates unknown.                  |
    // |                                                      Note: Ver TimeOut                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Reset (Type 23) structure.
    /// </summary>
    sealed class SmbiosType023 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType023(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType023" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType023(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Capabilities: Gets a value representing the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <c>Capabilities</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Capabilities => GetByte(0x04);
        #endregion

        #region [private] (string) Status: Gets a value representing the 'Status' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <c>Status</c> capability of the <c>Capabilities</c> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Status => Capabilities.CheckBit(Bits.Bit00) ? "Enabled" : "Disabled";
        #endregion

        #region [private] (byte) BootOption: Gets a value representing the 'Boot Option' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <c>Boot Option</c> capability of the <c>Capabilities</c> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootOption => (byte) ((Capabilities >> 1) & 0x03);
        #endregion

        #region [private] (byte) BootOptionOnLimit: Gets a value representing the 'Boot Option On Limit' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <c>Boot Option On Limit</c> capability of the <c>Capabilities</c> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootOptionOnLimit => (byte) ((Capabilities >> 3) & 0x03);
        #endregion

        #region [private] (bool) WatchdogTimer: Gets a value representing the 'Watchdog Timer' capability of the 'Capabilities' field
        /// <summary>
        /// Gets a value representing the <c>Watchdog Timer</c> capability of the <c>Capabilities</c> field
        /// </summary>
        /// <value>
        /// Capability value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool WatchdogTimer => Capabilities.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (int) ResetCount: Gets a value representing the 'Reset Count' field
        /// <summary>
        /// Gets a value representing the <c>Reset Count</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ResetCount => GetWord(0x05);
        #endregion

        #region [private] (int) ResetLimit: Gets a value representing the 'Reset Limit' field
        /// <summary>
        /// Gets a value representing the <c>Reset Limit</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ResetLimit => GetWord(0x07);
        #endregion

        #region [private] (int) TimerInterval: Gets a value representing the 'Timer Interval' field
        /// <summary>
        /// Gets a value representing the <c>Timer Interval</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int TimerInterval => GetWord(0x09);
        #endregion

        #region [private] (int) TimeOut: Gets a value representing the 'Time Out' field
        /// <summary>
        /// Gets a value representing the <c>Time Out</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int TimeOut => GetWord(0x09);
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
            SmbiosType023Property propertyId = (SmbiosType023Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Capabilities]

                    #region [0x04] - [Capabilities -> Status] - [String]
                    case SmbiosType023Property.Status:
                        value = Status;
                        break;
                    #endregion

                    #region [0x04] - [Capabilities -> Boot Option] - [String]
                    case SmbiosType023Property.BootOption:
                        value = GetBootOption(BootOption);
                        break;
                    #endregion

                    #region [0x04] - [Capabilities -> Boot Option On Limit] - [String]
                    case SmbiosType023Property.BootOptionOnLimit:
                        value = GetBootOption(BootOptionOnLimit);
                        break;
                    #endregion

                    #region [0x04] - [Capabilities -> Watchdog Timer] - [Boolean]
                    case SmbiosType023Property.WatchdogTimer:
                        value = WatchdogTimer;
                        break;
                    #endregion

                #endregion

                #region [0x05] - [Reset Count] - [Int32?]
                case SmbiosType023Property.ResetCount:
                    if (ResetCount != 0xffff)
                    {
                        value = (int?)ResetCount;                            
                    }
                    break;
                #endregion

                #region [0x07] - [Reset Limit] - [Int32?]
                case SmbiosType023Property.ResetLimit:
                    if (ResetLimit != 0xffff)
                    {
                        value = (int?) ResetLimit;
                    }
                    break;
                #endregion

                #region [0x09] - [Timer Interval] - [Int32?]
                case SmbiosType023Property.TimerInterval:
                    if (TimerInterval != 0xffff)
                    {
                        value = (int?) TimerInterval;
                    }
                    break;
                #endregion

                #region [0x0B] - [Time Out] - [Int32?]
                case SmbiosType023Property.Timeout:
                    if (TimeOut != 0xffff)
                    {
                        value = (int?) TimeOut;
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(PropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(PropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.SystemReset.Capabilities.Status, Status);
            properties.Add(KnownDmiProperty.SystemReset.Capabilities.BootOption, GetBootOption(BootOption));
            properties.Add(KnownDmiProperty.SystemReset.Capabilities.BootOptionOnLimit, GetBootOption(BootOptionOnLimit));
            properties.Add(KnownDmiProperty.SystemReset.Capabilities.WatchdogTimer, WatchdogTimer);

            if (ResetCount != 0xffff)
            {
                properties.Add(KnownDmiProperty.SystemReset.ResetCount, ResetCount);
            }

            if (ResetLimit != 0xffff)
            {
                properties.Add(KnownDmiProperty.SystemReset.ResetLimit, ResetLimit);
            }

            if (TimerInterval != 0xffff)
            {
                properties.Add(KnownDmiProperty.SystemReset.TimerInterval, TimerInterval);
            }

            if (TimeOut != 0xffff)
            {
                properties.Add(KnownDmiProperty.SystemReset.Timeout, TimeOut);
            }
            #endregion
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
