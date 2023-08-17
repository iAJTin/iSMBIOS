
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 037: Memory Channel. Contained Devices.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Memory          BYTE        Varies      The channel load provided by the first Memory Device  |
// |              Device                                  associated with this channel.                         |
// |              Load                                    Note: Ver Load                                        |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Memory          WORD        Varies      The structure handle that identifies the first Memory |
// |              Device                                  Device associated with this channel.                  |
// |              Handle                                  Note: Ver Handle                                      |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// This class represents an element of the structure <see cref="SmbiosType037"/>.
/// </summary>
public class MemoryChannelElement : SpecificSmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="MemoryChannelElement"/> class specifying the structure information.
    /// </summary>
    /// <param name="memoryContainedElementsArray">Untreated information of the current structure.</param>
    internal MemoryChannelElement(byte[] memoryContainedElementsArray) : base(memoryContainedElementsArray)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    ///  Gets a value that represents the '<b>Load</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Load => GetByte(0x00);

    /// <summary>
    ///  Gets a value that represents the '<b>Handle</b>' field.
    /// </summary>
    /// <value>
    /// Value of the property.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Handle => (ushort)GetWord(0x01);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="MemoryChannelElement"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the property <see cref="Load"/> and <see cref="Handle"/>.
    /// </remarks>                                    
    public override string ToString() => $"Load = {Load}, Handle = {Handle}";

    #endregion

    #region protected methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        properties.Add(SmbiosProperty.MemoryChannel.MemoryDevices.Load, Load);
        properties.Add(SmbiosProperty.MemoryChannel.MemoryDevices.Handle, Handle);
    }
            
    #endregion
}
