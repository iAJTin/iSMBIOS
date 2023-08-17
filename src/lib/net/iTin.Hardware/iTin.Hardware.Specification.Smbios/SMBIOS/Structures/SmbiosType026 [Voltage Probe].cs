
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 026: Voltage Probe.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        26          Voltage Probe indicator                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        Varies      Length of the structure, at least 14h                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Description     BYTE        STRING      The number of the string that contains additional     |
// |                                                      descriptive information about the probe or its        |
// |                                                      location.                                             |
// |                                                      Note: See Description                                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Location and    BYTE        Bit Field   Defines the probe’s physical location and status of   |
// |              Status                                  the voltage monitored by this voltage probe.          |
// |                                                      Note: See GetLocation(byte)                           |
// |                                                      Note: See GetStatus(byte)                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Maximum Value   WORD        Varies      The maximum voltage level readable by this probe, in  |
// |                                                      millivolts.                                           |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      Note: See MaximumValue                                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Minimum Value   WORD        Varies      The minimum voltage level readable by this probe, in  |
// |                                                      millivolts.                                           |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      Note: See MinimumValue                                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ah          Resolution      WORD        Varies      The resolution for the probe’s reading, in tenths of  |
// |                                                      millivolts.                                           |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      Note: See Resolution                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch          Tolerance       WORD        Varies      The tolerance for reading from this probe, in +/-     |
// |                                                      millivolts.                                           |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      Note: See Tolerance                                   |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Eh          Accuracy        WORD        Varies      The accuracy for reading from this probe, in +/-      |
// |                                                      1/100th of a percent.                                 |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      Note: See Accuracy                                    |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 10h          OEM-defined     DWORD       Varies      Contains OEM- or BIOS vendor-specific information.    |
// |                                                      Note: See OemDefined                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 14h          Nominal Value   WORD        Varies      The nominal value for the probe’s reading in          |
// |                                                      millivolts.                                           |
// |                                                      If the value is unknown, the field is set to 0x8000.  |
// |                                                      This field is present in the structure only if the    |
// |                                                      structure’s Length is larger than 14h.                |
// |                                                      Note: See NominalValue                                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Voltage Probe (Type 26) structure.
/// </summary>
internal sealed class SmbiosType026 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType026"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType026(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Description</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string Description => GetString(0x04);

    /// <summary>
    /// Gets a value representing the <b>Location And Status</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte LocationAndStatus => Reader.GetByte(0x05);

    /// <summary>
    /// Gets a value representing the <b>Location</b> feature of the <b>Location And Status</b> field
    /// </summary>
    /// <value>
    /// Feature value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Location => (byte)(LocationAndStatus & 0x1f);

    /// <summary>
    /// Gets a value representing the <b>Status</b> feature of the <b>Location And Status</b> field
    /// </summary>
    /// <value>
    /// Feature value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Status => (byte)((LocationAndStatus >> 5) & 0x07);

    /// <summary>
    /// Gets a value representing the <b>Maximun Value</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MaximunValue => (ushort)Reader.GetWord(0x06);

    /// <summary>
    /// Gets a value representing the <b>Minimun Value</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MinimunValue => (ushort)Reader.GetWord(0x08);

    /// <summary>
    /// Gets a value representing the <b>Resolution</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Resolution => (ushort)Reader.GetWord(0x0a);

    /// <summary>
    /// Gets a value representing the <b>Tolerance</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Tolerance => (ushort)Reader.GetWord(0x0c);

    /// <summary>
    /// Gets a value representing the <b>Accuracy</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Accuracy => (ushort)Reader.GetWord(0x0e);

    /// <summary>
    /// Gets a value representing the <b>Oem Defined</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint OemDefined => (uint)Reader.GetDoubleWord(0x10);

    /// <summary>
    /// Gets a value representing the <b>Nominal Value</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort NominalValue => (ushort)Reader.GetWord(0x14);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.Latest)
        {
            properties.Add(SmbiosProperty.VoltageProbe.Description, Description);
            properties.Add(SmbiosProperty.VoltageProbe.LocationAndStatus.Status, GetStatus(Status));
            properties.Add(SmbiosProperty.VoltageProbe.LocationAndStatus.Location, GetLocation(Location));
            properties.Add(SmbiosProperty.VoltageProbe.MaximumValue, MaximunValue);
            properties.Add(SmbiosProperty.VoltageProbe.MinimumValue, MinimunValue);
            properties.Add(SmbiosProperty.VoltageProbe.Resolution, Resolution);
            properties.Add(SmbiosProperty.VoltageProbe.Tolerance, Tolerance);
            properties.Add(SmbiosProperty.VoltageProbe.Accuracy, Accuracy);
            properties.Add(SmbiosProperty.VoltageProbe.OemDefined, OemDefined);
        }

        if (StructureInfo.Length >= 0x15)
        {
            properties.Add(SmbiosProperty.VoltageProbe.NominalValue, NominalValue);
        }
    }

    #endregion


    #region BIOS Specification 2.7.1 (26/01/2011)

    /// <summary>
    /// Gets a string representing the location.
    /// </summary>
    /// <param name="code">Value to analyze..</param>
    /// <returns>
    /// The location.
    /// </returns>
    private static string GetLocation(byte code)
    {
        string[] value =
        {
            "Other",                         // 0x01
            "Unknown",
            "Proccessor",
            "Disk",
            "Peripheral Bay",
            "System Management Module",
            "Motherboard",
            "Memory Module",
            "Processor Module",
            "Power Unit",
            "Add-in Card"                    // 0x0b
        };

        if (code >= 0x01 && code <= 0x0b)
        {
            return value[code - 0x01];
        }

        return SmbiosHelper.OutOfSpec;
    }

    /// <summary>
    /// Gets a string representing the state of the test.
    /// </summary>
    /// <param name="code">Value to analyze..</param>
    /// <returns>
    /// The state of the test.
    /// </returns>
    private static string GetStatus(byte code)
    {
        string[] value =
        {
            "Other",               // 0x01
            "Unknown",
            "Ok",
            "Non-critical",
            "Critical",
            "Non-recoverable"      // 0x06
        };

        if (code >= 0x01 && code <= 0x06)
        {
            return value[code - 0x01];
        }

        return SmbiosHelper.OutOfSpec;
    }

    #endregion
}
