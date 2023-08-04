
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Represents a collection of <see cref="GroupAssociationElement"/>.
/// </summary>
public sealed class GroupAssociationElementCollection : ReadOnlyCollection<GroupAssociationElement>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="GroupAssociationElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    public GroupAssociationElementCollection(IEnumerable<GroupAssociationElement> elements) : base(elements.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="GroupAssociationElementCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items
    /// </remarks>                                    
    public override string ToString() => $"Elements = { Items.Count}";

    #endregion              
}
