
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 030: Out-of-Band Remote Access.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        30          Out-of-Band Remote Access indicator                   |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        06h         Length of the structure                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Manufacturer    BYTE        STRING      The number of the string that contains the            |
// |              Name                                    manufacturer of the out-of-band access facility.      |
// |                                                      Note: See Manufacturer                                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Connections     BYTE        Bit Field   Identifies the current remote-access connections:     |
// |                                                                                                            |
// |                                                      Bits 07:02 - Reserved for future definition by this   |
// |                                                                   specification; set to all zeros.         |
// |                                                                                                            |
// |                                                      Bit     01 - Outbound Connection Enabled. Identifies  |
// |                                                                   whether (1) or not (0) the facility is   |
// |                                                                   allowed to initiate outbound connections |
// |                                                                   to contact an alert management facility  |
// |                                                                   when critical conditions occur.          |
// |                                                                   Note: See OutboundConnection             |
// |                                                                                                            |
// |                                                      Bit     00 - Inbound Connection Enabled. Identifies   |
// |                                                                   whether (1) or not (0) the facility is   |
// |                                                                   allowed to initiate outbound connections |
// |                                                                   to receive incoming facility connections |
// |                                                                   for the purpose of remote operations or  |
// |                                                                   problem management.                      |
// |                                                                   Note: See InboundConnection              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Out-of-Band Remote Access (Type 30) structure.
/// </summary>
internal sealed class SmbiosType030 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType030"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType030(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Manufacturer Name</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string ManufacturerName => GetString(0x04);

    /// <summary>
    /// Gets a value representing the <b>Connections</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Connections => Reader.GetByte(0x05);

    /// <summary>
    /// Gets a value representing the <b>InBound Connection</b> feature of the <b>Connections</b> field
    /// </summary>
    /// <value>
    /// Feature value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string InBoundConnection => Connections.CheckBit(Bits.Bit00) ? "Enabled" : "Disabled";

    /// <summary>
    /// Gets a value representing the <b>OutBound Connection</b> feature of the <b>Connections</b> field
    /// </summary>
    /// <value>
    /// Feature value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string OutBoundConnection => Connections.CheckBit(Bits.Bit01) ? "Enabled" : "Disabled";

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
        {
            return;
        }

        properties.Add(SmbiosProperty.OutOfBandRemote.Manufacturer, ManufacturerName);
        properties.Add(SmbiosProperty.OutOfBandRemote.Connections.OutBoundConnection, OutBoundConnection);
        properties.Add(SmbiosProperty.OutOfBandRemote.Connections.InBoundConnection, InBoundConnection);
    }

    #endregion
}
