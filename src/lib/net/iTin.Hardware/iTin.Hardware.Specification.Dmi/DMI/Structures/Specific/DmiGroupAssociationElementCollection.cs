
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of <see cref="DmiGroupAssociationElement"/>.
/// </summary>
public sealed class DmiGroupAssociationElementCollection : ReadOnlyCollection<DmiGroupAssociationElement>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiGroupAssociationElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    public DmiGroupAssociationElementCollection(GroupAssociationElementCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="DmiGroupAssociationElementCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items
    /// </remarks>                                    
    public override string ToString() => $"Elements = { Items.Count}";

    #endregion

    #region private static methods

    private static IEnumerable<DmiGroupAssociationElement> AsDmiCollectionFrom(GroupAssociationElementCollection elements)
    {
        var items = new Collection<DmiGroupAssociationElement>();

        foreach (var element in elements)
        {
            items.Add(new DmiGroupAssociationElement(element.Properties));
        }

        return items;
    }

    #endregion
}
