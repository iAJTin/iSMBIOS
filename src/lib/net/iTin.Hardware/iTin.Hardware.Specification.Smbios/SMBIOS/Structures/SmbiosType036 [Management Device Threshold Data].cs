
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 036: Management Device Threshold Data.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        36          Management Device Threshold Data structure indicator. |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        10h         Length of the structure.                              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Lower           WORD        Varies      The lower non-critical threshold for this component.  |
// |              Threshold                                                                                     |
// |              Non-critical                            Note: Ver LowerNonCritical                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Upper           WORD        Varies      The upper non-critical threshold for this component.  |
// |              Threshold                                                                                     |
// |              Non-critical                            Note: Ver UpperNonCritical                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Lower           WORD        Varies      The lower critical threshold for this component.      |
// |              Threshold                                                                                     |
// |              Critical                                Note: Ver LowerCritical                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ah          Upper           WORD        Varies      The upper critical threshold for this component.      |
// |              Threshold                                                                                     |
// |              Critical                                Note: Ver UpperCritical                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch          Lower           WORD        Varies      The lower non-recoverable threshold for this          |
// |              Threshold                               component.                                            |
// |              Non-recoverable                         Note: Ver LowerNonRecoverable                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Eh          Upper           WORD        Varies      The upper non-recoverable threshold for this          |
// |              Threshold                               component.                                            |
// |              Non-recoverable                         Note: Ver UpperNonRecoverable                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Management Device Threshold Data (Type 36) structure.
/// </summary>
internal sealed class SmbiosType036 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType036"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType036(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Lower Non Critical</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort LowerNonCritical => (ushort)Reader.GetWord(0x04);

    /// <summary>
    /// Gets a value representing the <b>Upper Non Critical</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort UpperNonCritical => (ushort)Reader.GetWord(0x06);

    /// <summary>
    /// Gets a value representing the <b>Lower Critical</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort LowerCritical => (ushort)Reader.GetWord(0x08);

    /// <summary>
    /// Gets a value representing the <b>Upper Critical</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort UpperCritical => (ushort)Reader.GetWord(0x0a);

    /// <summary>
    /// Gets a value representing the <b>Lower Non Recoverable</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort LowerNonRecoverable => (ushort)Reader.GetWord(0x0c);

    /// <summary>
    /// Gets a value representing the <b>Upper Non Recoverable</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort UpperNonRecoverable => (ushort)Reader.GetWord(0x0e);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
        {
            return;
        }

        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerNonCritical, LowerNonCritical);
        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperNonCritical, UpperNonCritical);
        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerCritical, LowerCritical);
        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperCritical, UpperCritical);
        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerNonRecoverable, LowerNonRecoverable);
        properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperNonRecoverable, UpperNonRecoverable);
    }

    #endregion                
}
