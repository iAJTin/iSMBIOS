
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Represents a collection of objects <see cref="PeerDevice"/>.
/// </summary>
public sealed class PeerDevicesCollection : ReadOnlyCollection<PeerDevice>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="PeerDevicesCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal PeerDevicesCollection(IEnumerable<PeerDevice> elements) : base(elements.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="PeerDevicesCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items.
    /// </remarks>                                    
    public override string ToString() => $"Peers={Items.Count}";

    #endregion              
}
