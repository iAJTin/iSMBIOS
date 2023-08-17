
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of objects <see cref="DmiPeerDevice"/>.
/// </summary>
public class DmiPeerDevicesCollection : ReadOnlyCollection<DmiPeerDevice>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiPeerDevicesCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal DmiPeerDevicesCollection(PeerDevicesCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="DmiPeerDevicesCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available elements.
    /// </remarks>                                    
    public override string ToString() => $"Elements={Items.Count}";

    #endregion              

    #region private static methods

    private static IEnumerable<DmiPeerDevice> AsDmiCollectionFrom(PeerDevicesCollection elements)
    {
        var items = new Collection<DmiPeerDevice>();

        foreach (var element in elements)
        {
            items.Add(new DmiPeerDevice(element.Properties));
        }

        return items;
    }

    #endregion
}
