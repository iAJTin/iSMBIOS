
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType037"/>.
/// </summary>
public class DmiMemoryChannelElement
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiMemoryChannelElement"/>.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiMemoryChannelElement(SmbiosPropertiesTable reference)
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
            {DmiProperty.MemoryChannel.MemoryDevices.Load, _reference[SmbiosProperty.MemoryChannel.MemoryDevices.Load]},
            {DmiProperty.MemoryChannel.MemoryDevices.Handle, _reference[SmbiosProperty.MemoryChannel.MemoryDevices.Handle]}
        };

    #endregion
}
