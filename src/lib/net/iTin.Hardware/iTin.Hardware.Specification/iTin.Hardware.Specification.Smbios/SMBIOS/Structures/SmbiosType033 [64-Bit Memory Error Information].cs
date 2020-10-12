
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 033: 64-Bit Memory Error Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        33          64-bit Memory Error Information type                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        1Fh         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Error Type      BYTE        ENUM        The type of error that is associated with the current |
    // |                                                      status reported for the memory array or device.       |
    // |                                                      Note: Ver GetErrorType(byte)                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Error           BYTE        ENUM        Identifies the granularity (for example, device versus|
    // |              Granularity                             Partition) to which the  error can be resolved.       |
    // |                                                      Note: Ver GetErrorGranularity(byte)                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Error           BYTE        ENUM        The memory access operation that caused the error.    |
    // |              Operation                               Note: Ver GetErrorOperation(byte)                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Vendor          DWORD       Varies      The vendor-specific ECC syndrome or CRC data          |
    // |              Syndrome                                associated with the erroneous access.                 |
    // |                                                      If the value is unknown, this field                   |
    // |                                                      contains 0000 0000h.                                  |
    // |                                                      Note: Ver CrcData                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Memory Array    QWORD       Varies      The 64-bit physical address of the error based on the |
    // |              Error Address                           addressing of the bus to which the memory array is.   |
    // |                                                      connected.                                            |
    // |                                                      If the address is unknown, this field contains        |
    // |                                                      8000 0000 0000 0000h.                                 |
    // |                                                      Note: Ver BusErrorAddress                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h          Device Error    QWORD       Varies      The 64-bit physical address of the error relative to  |
    // |              Address                                 the start of the failing memory device, in bytes.     |
    // |                                                      If the address is unknown, this field contains        |
    // |                                                      8000 0000 0000 0000h.                                 |
    // |                                                      Note: Ver DeviceErrorAddress                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Bh          Error           DWORD       Varies      The range, in bytes, within which the error can be    |
    // |              Resolution                              determined, when an error address is given.           |
    // |                                                      If the address is unknown, this field contains        |
    // |                                                      8000 0000h.                                           |
    // |                                                      Note: Ver ErrorResolution                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the 64-Bit Memory Error Information (Type 33) structure.
    /// </summary>
    internal sealed class SmbiosType033 : SmbiosBaseType
    {
        #region Constructor/es

        #region [public] SmbiosType033(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType033"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType033(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) ErrorType: Gets a value representing the 'Error Type' field
        /// <summary>
        /// Gets a value representing the <b>Error Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorType => Reader.GetByte(0x04);
        #endregion

        #region [private] (byte) ErrorGranularity: Gets a value representing the 'Error Granularity' field
        /// <summary>
        /// Gets a value representing the <b>Error Granularity</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorGranularity => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) ErrorOperation: Gets a value representing the 'Error Operation' field
        /// <summary>
        /// Gets a value representing the <b>Error Operation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorOperation => Reader.GetByte(0x06);
        #endregion

        #region [private] (uint) CrcData: Gets a value representing the 'Crc Data' field
        /// <summary>
        /// Gets a value representing the <b>Crc Data</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint CrcData => (uint)Reader.GetDoubleWord(0x07);
        #endregion

        #region [private] (ulong) MemoryArrayErrorAddress: Gets a value representing the 'Memory Array Error Address' field
        /// <summary>
        /// Gets a value representing the <b>Memory Array Error Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong MemoryArrayErrorAddress => (ulong)Reader.GetQuadrupleWord(0x0b);
        #endregion

        #region [private] (ulong) DeviceErrorAddress: Gets a value representing the 'Device Error Address' field
        /// <summary>
        /// Gets a value representing the <b>Device Error Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong DeviceErrorAddress => (ulong)Reader.GetQuadrupleWord(0x13);
        #endregion

        #region [private] (uint) ErrorResolution: Gets a value representing the 'Error Resolution' field
        /// <summary>
        /// Gets a value representing the <b>Error Resolution</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint ErrorResolution => (uint)Reader.GetDoubleWord(0x1b);
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

            properties.Add(SmbiosProperty.BitMemoryError64.ErrorType, GetErrorType(ErrorType));
            properties.Add(SmbiosProperty.BitMemoryError64.ErrorGranularity, GetErrorGranularity(ErrorGranularity));
            properties.Add(SmbiosProperty.BitMemoryError64.ErrorOperation, GetErrorOperation(ErrorOperation));
            properties.Add(SmbiosProperty.BitMemoryError64.VendorSyndrome, CrcData);
            properties.Add(SmbiosProperty.BitMemoryError64.MemoryArrayErrorAddress, MemoryArrayErrorAddress);
            properties.Add(SmbiosProperty.BitMemoryError64.DeviceErrorAddress, DeviceErrorAddress);
            properties.Add(SmbiosProperty.BitMemoryError64.ErrorResolution, ErrorResolution);
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [internal] {static} (string) GetErrorType(byte): Gets a string representing the type of error
        /// <summary>
        /// Gets a string representing the type of error.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Error type.
        /// </returns> 
        internal static string GetErrorType(byte code)
        {
            string[] value =
            {
                "Other",                         // 0x01
                "Unknown",
                "OK",
                "Bad Read",
                "Parity Error",
                "Single-bit Error",
                "Double-bit Error",
                "Multi-bit Error",
                "Nibble Error",
                "Checksum Error",
                "CRC Error",
                "Corrected Single-bit Error",
                "Corrected Error",
                "Uncorrectable Error"            // 0x0E
            };

            if (code >= 0x01 && code <= 0x0E)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [internal] {static} (string) GetErrorGranularity(byte): Gets a string indicating 'Granularity'
        /// <summary>
        /// Gets a string indicating 'Granularity'.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Indicates the 'Granularity'.
        /// </returns> 
        internal static string GetErrorGranularity(byte code)
        {
            string[] value =
            {
                "Other",                 // 0x01
                "Unknown",
                "Device level",
                "Memory partition level" // 0x04
            };

            if (code >= 0x01 && code <= 0x04)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [internal] {static} (string) GetErrorOperation(byte): Gets a string indicating which memory operation generated the error
        /// <summary>
        /// Gets a string indicating which memory operation generated the error.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The operation generated the error.
        /// </returns> 
        internal static string GetErrorOperation(byte code)
        {
            string[] value =
            {
                "Other",        // 0x01
                "Unknown",
                "Read",
                "Write",
                "Partial write" // 0x05
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
