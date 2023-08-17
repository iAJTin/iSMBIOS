
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 035: Management Device Component.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        35          Management Device Component indicator                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        0Bh         Length of the structure.                              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Description     BYTE        STRING      The number of the string that contains additional     |
// |                                                      descriptive information about the component.          |
// |                                                      Note: Ver Description                                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Management      WORD        Varies      The handle, or instance number, of the Management     |
// |              Device Handle                           Device.                                               |
// |                                                      Note: Ver DeviceHandle                                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h          Component       WORD        Varies      The handle, or instance number, of the probe or       |
// |              Handle                                  cooling device that defines this component.           |
// |                                                      Note: Ver ProbeHandle                                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 09h          Threshold       WORD        Varies      The handle, or instance number, associated with the   |
// |              Handle                                  device thresholds.                                    |
// |                                                                                                            |
// |                                                      A value of 0FFFFh indicates that no Threshold Data    |
// |                                                      structure is associated with this component.          |
// |                                                      Note: Ver ThresholdHandle                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the  Management Device Component (Type 35) structure.
/// </summary>
internal sealed class SmbiosType035 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType035"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType035(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
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
    /// Gets a value representing the <b>Management Device Handle</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ManagementDeviceHandle => (ushort)Reader.GetWord(0x05);

    /// <summary>
    /// Gets a value representing the <b>Component Handle</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ComponentHandle => (ushort)Reader.GetWord(0x07);

    /// <summary>
    /// Gets a value representing the <b>Threshold Handle</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ThresholdHandle => (ushort)Reader.GetWord(0x09);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
        {
            return;
        }

        properties.Add(SmbiosProperty.ManagementDeviceComponent.Description, Description);
        properties.Add(SmbiosProperty.ManagementDeviceComponent.ComponentHandle, ComponentHandle);
        properties.Add(SmbiosProperty.ManagementDeviceComponent.ThresholdHandle, ThresholdHandle);
        properties.Add(SmbiosProperty.ManagementDeviceComponent.ManagementDeviceHandle, ManagementDeviceHandle);
    }

    #endregion
}
