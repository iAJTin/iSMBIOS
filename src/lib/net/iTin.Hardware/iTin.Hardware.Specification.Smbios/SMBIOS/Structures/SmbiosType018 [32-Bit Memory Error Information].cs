
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 018: 32-Bit Memory Error Information.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |          Spec.                                                                                             |
// | Offset   Version     Name                Length      Value       Description                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h      2.1+        Type                BYTE        18          32-bit Memory Error Information type      |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h      2.1+        Length              BYTE        17h         Length of the structure.                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
// |                                                                  with the structure                        |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h      2.1+        Error Type          BYTE        ENUM        The type of error that is associated with |
// |                                                                  the current status reported for the memory|
// |                                                                  array or device.                          |
// |                                                                  Note: See GetErrorType(byte)              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h      2.1+        Error               BYTE        ENUM        Identifies the granularity (for example,  |
// |                      Granularity                                 device versus Partition) to which the     |
// |                                                                  error can be resolved.                    |
// |                                                                  Note: See GetErrorGranularity(byte)       |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h      2.1+        Error Operation     BYTE        ENUM        The memory access operation that caused   |
// |                                                                  the error.                                |
// |                                                                  Note: See GetErrorOperation(byte)         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h      2.1+        Vendor              DWORD       Varies      The vendor-specific ECC syndrome or CRC   |
// |                      Syndrome                                    data associated with the erroneous access.|
// |                                                                  If the value is unknown, this field       |
// |                                                                  contains 0000 0000h.                      |
// |                                                                  Note: See CrcData                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Bh      2.1+        Memory Array        DWORD       Varies      The 32-bit physical address of the error  |
// |                      Error Address                               based on the addressing of the bus to     |
// |                                                                  which the memory array is connected.      |
// |                                                                  If the address is unknown, this field     |
// |                                                                  contains 8000 0000h.                      |
// |                                                                  Note: See BusErrorAddress                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Fh      2.1+        Device Error        DWORD       Varies      The 32-bit physical address of the error  |
// |                      Address                                     relative to the start of the failing      |
// |                                                                  memory device, in bytes.                  |
// |                                                                  If the address is unknown, this field     |
// |                                                                  contains 8000 0000h.                      |
// |                                                                  Note: See DeviceErrorAddress              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 13h      2.1+        Error               DWORD       Varies      The range, in bytes, within which the     |
// |                      Resolution                                  error can be determined, when an error    |
// |                                                                  address is given.                         |
// |                                                                  If the range is unknown, this field       |
// |                                                                  contains 8000 0000h.                      |
// |                                                                  Note: See ErrorResolution                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the 32-Bit Memory Error Information (Type 18) structure.
/// </summary>
internal class SmbiosType018 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType018"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType018(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    #region Version 2.1+ fields

    /// <summary>
    /// Gets a value representing the <b>Error Type</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ErrorType => Reader.GetByte(0x04);

    /// <summary>
    /// Gets a value representing the <b>Error Granularity</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ErrorGranularity => Reader.GetByte(0x05);

    /// <summary>
    /// Gets a value representing the <b>Error Operation</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ErrorOperation => Reader.GetByte(0x06);

    /// <summary>
    /// Gets a value representing the <b>Crc Data</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint CrcData => (uint)Reader.GetDoubleWord(0x07);

    /// <summary>
    /// Gets a value representing the <b>Bus Error Address</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint BusErrorAddress => (uint)Reader.GetDoubleWord(0x0b);

    /// <summary>
    /// Gets a value representing the <b>Device Error Address</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint DeviceErrorAddress => (uint)Reader.GetDoubleWord(0x0f);

    /// <summary>
    /// Gets a value representing the <b>Error Resolution</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint ErrorResolution => (uint)Reader.GetDoubleWord(0x13);

    #endregion

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.v21)
        {
            return;
        }

        properties.Add(SmbiosProperty.BitMemoryError32.ErrorType, GetErrorType(ErrorType));
        properties.Add(SmbiosProperty.BitMemoryError32.ErrorGranularity, GetErrorGranularity(ErrorGranularity));
        properties.Add(SmbiosProperty.BitMemoryError32.ErrorOperation, GetErrorOperation(ErrorOperation));
        properties.Add(SmbiosProperty.BitMemoryError32.VendorSyndrome, CrcData);
        properties.Add(SmbiosProperty.BitMemoryError32.MemoryArrayErrorAddress, BusErrorAddress);
        properties.Add(SmbiosProperty.BitMemoryError32.DeviceErrorAddress, DeviceErrorAddress);
        properties.Add(SmbiosProperty.BitMemoryError32.ErrorResolution, ErrorResolution);
    }

    #endregion


    #region BIOS Specification 2.7.1 (26/01/2011)

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
}
