
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType009"/>.
/// </summary>
public class DmiPeerDevice
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiPeerDevice"/>.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiPeerDevice(SmbiosPropertiesTable reference)
    {
        _reference = reference;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    public DmiClassPropertiesTable Properties =>
        new()
        {
            {DmiProperty.SystemSlots.Peers.DataBusWidth, _reference[SmbiosProperty.SystemSlots.Peers.DataBusWidth]},
            {DmiProperty.SystemSlots.Peers.BusDeviceFunction, _reference[SmbiosProperty.SystemSlots.Peers.BusDeviceFunction]},
            {DmiProperty.SystemSlots.Peers.SegmentGroupNumber, _reference[SmbiosProperty.SystemSlots.Peers.SegmentGroupNumber]}
        };

    #endregion
}
