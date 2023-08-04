
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 037: Memory Channel. Contained Devices.
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name              Length      Value       Description                              |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Segment Group     WORD        Varies      The channel load provided by the         |
// |              Number (Peer)                             associated with this channel.            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Bus Number        BYTE        Varies      The channel load provided by th          |
// |              (Peer)                                    associated with this channel.            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          Device/Function   BYTE        Bit Field   Bits 7:3 – Device Number                 |
// |              Number (Peer)                             Bits 2:0 – Function Number               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Data bus width    BYTE        Varies      Indicates electrical bus width of peer   |
// |              (Peer)                                    Segment/Bus/Device/Function.             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// This class represents an element of the structure <see cref="PeerDevice"/>.
/// </summary>
public class PeerDevice : SpecificSmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="PeerDevice"/> class specifying the structure information.
    /// </summary>
    /// <param name="peerDeviceArray">Untreated information of the current structure.</param>
    internal PeerDevice(byte[] peerDeviceArray) : base(peerDeviceArray)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    ///  Gets a value that represents the '<b>Segment Group Number</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort SegmentGroupNumber => (ushort)GetWord(0x00);

    /// <summary>
    ///  Gets a value that represents the '<b>Bus Number</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte BusNumber => GetByte(0x02);

    /// <summary>
    /// Gets a value that represents the '<b>Device / Function Number</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DeviceFunctionNumber => GetByte(0x03);

    /// <summary>
    /// Gets a value representing the <b>Device</b> feature of the <b>Device/Function Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Device => (byte)((DeviceFunctionNumber & 0xf8) >> 3);

    /// <summary>
    /// Gets a value representing the <b>Function</b> feature of the <b>Device/Function Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Function => (byte)(DeviceFunctionNumber & 0x07);

    /// <summary>
    /// Gets a value that represents the '<b>Data Bus Width</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DataBusWidth => GetByte(0x04);

    #endregion

    #region private methods

    /// <summary>
    /// Populates the property collection for this structure.
    /// </summary>
    /// <param name="properties">Collection of properties of this structure.</param>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        properties.Add(SmbiosProperty.SystemSlots.Peers.SegmentGroupNumber, SegmentGroupNumber);
        properties.Add(SmbiosProperty.SystemSlots.Peers.BusDeviceFunction, GetBusDeviceFunction(BusNumber, Device, Function));
        properties.Add(SmbiosProperty.SystemSlots.Peers.DataBusWidth, DataBusWidth);
    }

    #endregion


    #region BIOS Specification 3.4.0 (20/08/2020)

    /// <summary>
    /// Gets a string representing Bus / Device / Function of the slot.
    /// </summary>
    /// <param name="bus">Bus.</param>
    /// <param name="device">Device.</param>
    /// <param name="function">Función.</param>
    /// <returns>
    /// Bus/Device/Function slot information
    /// </returns>
    private static string GetBusDeviceFunction(byte bus, byte device, byte function) => $"Bus = {bus}, Device = {device}, Function = {function}";

    #endregion
}
