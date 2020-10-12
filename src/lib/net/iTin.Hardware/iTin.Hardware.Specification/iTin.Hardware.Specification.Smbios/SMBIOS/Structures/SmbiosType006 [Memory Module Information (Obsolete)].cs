
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 006: Memory Module Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      deviceProperty       Description                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        6           Memory Module Configuration Indicator                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        0Ch                                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Socket          BYTE        STRING      Number of null-terminated string                      |
    // |              Designation                             EXAMPLE: ‘J202’,0                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Bank            BYTE        Varies      Each nibble indicates a bank (RAS#) connection; 0xF   |
    // |              Connections                             means no connection.                                  |
    // |                                                      EXAMPLE: If banks 1 & 3 (RAS# 1 & 3) were connected   |
    // |                                                               to a SIMM socket the byte for that socket    |
    // |                                                               would be 13h.                                |
    // |                                                               If only bank 2 (RAS 2) were connected, the   |
    // |                                                               byte for that socket would be 2Fh.           |
    // |                                                      Note: Please see, GetBankConnections(byte)            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Current Speed   BYTE        Varies      The speed of the memory module, in ns (for example,   |
    // |                                                      70d for a 70ns module).                               |
    // |                                                      If the speed is unknown, the field is set to 0.       |
    // |                                                      Note: Please see, GetMemorySpeeds(byte)               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Current Memory  WORD        Bit Field   Note: Please see, GetCurrentMemoryTypes(int)          |
    // |              Type                                                                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Installed Size  BYTE        Varies      Note: Please see, GetSize(byte)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Enabled Size    BYTE        Varies      Note: Please see, GetSize(byte)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Error Status    BYTE        Varies      Bits 07:03 - Reserved, must be zero                   |
    // |                                                                                                            |
    // |                                                      Bit     02 - If set, the Error Status information     |
    // |                                                                   should be obtained from the event log;   |
    // |                                                                   bits 1 and 0 are reserved.               |
    // |                                                                                                            |
    // |                                                      Bit     01 - Correctable errors received for the      |
    // |                                                                   module, if set. This bit is reset only   |
    // |                                                                   during a system reset.                   |
    // |                                                                                                            |
    // |                                                      Bit     00 - Uncorrectable errors received for the    |
    // |                                                                   module, if set. All or a portion of the  |
    // |                                                                   module has been disabled. This bit is    |
    // |                                                                   only reset on  power-on.                 |
    // |                                                      Note: Please see, GetErrorStatus(byte)                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Memory Module Information (Type 6, Obsolete) structure.
    /// </summary>
    internal sealed class SmbiosType006 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType006(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType006"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType006(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) SocketDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <b>Socket Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SocketDesignation => Strings[StructureInfo.RawData[0x04]];
        #endregion

        #region [private] (byte) BankConnections: Gets a value representing the 'Bank Connections' field
        /// <summary>
        /// Gets a value representing the <b>Bank Connections</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BankConnections => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) CurrentSpeed: Gets a value representing the 'Current Speed' field
        /// <summary>
        /// Gets a value representing the <b>Current Speed</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CurrentSpeed => Reader.GetByte(0x06);
        #endregion

        #region [private] (int) CurrentMemoryType: Gets a value representing the 'Current Memory Type' field
        /// <summary>
        /// Gets a value representing the <b>Current Memory Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CurrentMemoryType => Reader.GetWord(0x07);
        #endregion

        #region [private] (byte) InstalledSize: Gets a value representing the 'Installed Size' field
        /// <summary>
        /// Gets a value representing the <b>Installed Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InstalledSize => Reader.GetByte(0x09);
        #endregion

        #region [private] (byte) EnabledSize: Gets a value representing the 'Enabled Size' field
        /// <summary>
        /// Gets a value representing the <b>Enabled Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EnabledSize => Reader.GetByte(0x0a);
        #endregion

        #region [private] (byte) ErrorStatus: Gets a value representing the 'Error Status' field
        /// <summary>
        /// Gets a value representing the <b>Error Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorStatus => Reader.GetByte(0x0b);
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
            if (StructureInfo.StructureVersion <= SmbiosStructureVersion.Latest)
            {
                return;
            }

            properties.Add(SmbiosProperty.MemoryModule.SocketDesignation, SocketDesignation);
            properties.Add(SmbiosProperty.MemoryModule.BankConnections, GetBankConnections(BankConnections));
            properties.Add(SmbiosProperty.MemoryModule.CurrentSpeed, GetMemorySpeeds(CurrentSpeed));
            properties.Add(SmbiosProperty.MemoryModule.CurrentMemoryType, GetCurrentMemoryTypes(CurrentMemoryType));
            properties.Add(SmbiosProperty.MemoryModule.InstalledSize, GetSize(InstalledSize));
            properties.Add(SmbiosProperty.MemoryModule.EnabledSize, GetSize(EnabledSize));
            properties.Add(SmbiosProperty.MemoryModule.ErrorStatus, GetErrorStatus(ErrorStatus));
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (ReadOnlyCollection<string>) GetBankConnections(byte): Gets a collection that represents the available memory banks
        /// <summary>
        /// Gets a collection that represents the available memory banks.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// An available memory bank collection
        /// </returns>            
        private static ReadOnlyCollection<string> GetBankConnections(byte code)
        {                
            List<string> items = new List<string>();

            byte[] nibbles = code.ToNibbles();
            foreach (byte nibble in nibbles)
            {
                if (nibble != 0x0f)
                {
                    items.Add($"RAS#{nibble}");
                }  
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetCurrentMemoryTypes(int): Gets a collection of supported memory types
        /// <summary>
        /// Gets a collection of supported memory types.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// An supported memory type collection
        /// </returns>            
        private static ReadOnlyCollection<string> GetCurrentMemoryTypes(int code)
        {
            string[] deviceProperty =
            {
                "Other",             // 0x00
                "Unknown",
                "Standard",
                "Fast Page Mode",
                "EDO",
                "Parity",
                "ECC",
                "SIMM",
                "DIMM",
                "Burst EDO",
                "SDRAM"              // 0x0a                                              
            };

            List<string> items = new List<string>();
            for (byte i = 0x00; i <= 0x0a; i++)
            {
                bool addType = code.CheckBit(i);
                if (addType)
                {
                    items.Add(deviceProperty[i]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (string) GetErrorStatus(byte): Gets a string representing the error state
        /// <summary>
        /// Gets a string representing the error state.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Error state.
        /// </returns>            
        private static string GetErrorStatus(byte code)
        {
            string[] deviceProperty =
            {
                "No erros",      // 0x00
                "Correctable",
                "View Event Log" // 0x02
            };

            if (code <= 0x02)
            {
                return deviceProperty[code];
            }

            return "Reserved";               
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetMemorySpeeds(int): Gets a collection of supported speeds
        /// <summary>
        /// Gets a collection of supported speeds.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// A collection of supported speeds.
        /// </returns>
        private static ReadOnlyCollection<string> GetMemorySpeeds(byte code)
        {
            string[] deviceProperty =
            {
                "Other",     // 0x00
                "Unknown",
                "70",
                "60",
                "50"         // 0x04                                              
            };

            List<string> items = new List<string>();       
            if (code == 0x00)
            {
                items.Add(deviceProperty[0x01]);
            }

            for (byte i = 0x00; i <= 0x04; i++)
            {
                bool addSpeed = code.CheckBit(i);
                if (addSpeed)
                {
                    items.Add(deviceProperty[i]);
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetSize(byte): Returns a collection of available sizes
        // •————————————————————————————————————————————————————————————————————————————————————————•
        // | BitsOffset     Description                                                             |
        // •————————————————————————————————————————————————————————————————————————————————————————•
        // | Bit     07     Defines whether the memory module has:                                  |
        // |                0b - A single-bank connection                                           |
        // |                1b - Double-bank connection                                             |
        // |                                                                                        |
        // | Bits 00:06     Size (n), where 2^n is the size in MB.                                  |
        // |                Special-case:                                                           |
        // |                              7Dh - Not determinable (Installed Size only)              |
        // |                              7Eh - Module is installed, but no memory has been enabled |
        // |                              7Fh - Not installed                                       |
        // •————————————————————————————————————————————————————————————————————————————————————————•
        /// <summary>
        /// Returns a collection of available sizes.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// An available size collection.
        /// </returns>            
        private static ReadOnlyCollection<string> GetSize(byte code)
        {
            List<string> items = new List<string>();

            switch(code)
            {
                case 0x7d:
                    items.Add("indeterminable");
                    break;

                case 0x7e:
                    items.Add("Installed but not enabled");
                    break;

                case 0x7f:
                    items.Add("Not installed");
                    break;

                default:
                    int pow = code & 0x7f;
                    double size = Math.Pow(2, pow);

                    bool isdoubleBank = code.CheckBit(Bits.Bit07);
                    items.Add(isdoubleBank ? "double-bank" : "single-bank");
                    items.Add($"{size}");
                    break;
            }

            return items.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
