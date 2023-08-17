
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 025: System Power Controls.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        25          System Power Controls indicator                       |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        09h         Length of the structure.                              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Next Scheduled  BYTE        Varies      Contains the BCD value of the month on which the next |
// |              Power-on Month                          scheduled power-on is to occur, in the range 01h to   |
// |                                                      12h.                                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Next Scheduled  BYTE        Varies      Contains the BCD value of the day-of-month on which   |
// |              Power-on Day-of                         the next scheduled power-on is to occur, in the range |
// |              -month                                  01h to 31h.                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Next Scheduled  BYTE        Varies      Contains the BCD value of the hour on which the next  |
// |              Power-on Hour                           scheduled power-on is to occur, in the range 00h to   |
// |                                                      23h.                                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h          Next Scheduled  BYTE        Varies      Contains the BCD value of the minute on which the next|
// |              Power-on Minute                         scheduled power-on is to occur, in the range 00h to   |
// |                                                      59h.                                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Next Scheduled  BYTE        Varies      Contains the BCD value of the second on which the next|
// |              Power-on Second                         scheduled power-on is to occur, in the range 00h to   |
// |                                                      59h.                                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Power Controls (Type 25) structure.
/// </summary>
internal sealed class SmbiosType025 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType025"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType025(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Month</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Month => Reader.GetByte(0x04);

    /// <summary>
    /// Gets a value representing the <b>Day</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Day => Reader.GetByte(0x05);

    /// <summary>
    /// Gets a value representing the <b>Hour</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Hour => Reader.GetByte(0x06);

    /// <summary>
    /// Gets a value representing the <b>Minute</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Minute => Reader.GetByte(0x07);

    /// <summary>
    /// Gets a value representing the <b>Second</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Second => Reader.GetByte(0x08);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
        {
            return;
        }

        properties.Add(SmbiosProperty.SystemPowerControls.Month, Month);
        properties.Add(SmbiosProperty.SystemPowerControls.Day, Day);
        properties.Add(SmbiosProperty.SystemPowerControls.Hour, Hour);
        properties.Add(SmbiosProperty.SystemPowerControls.Minute, Minute);
        properties.Add(SmbiosProperty.SystemPowerControls.Second, Second);
    }

    #endregion
}
