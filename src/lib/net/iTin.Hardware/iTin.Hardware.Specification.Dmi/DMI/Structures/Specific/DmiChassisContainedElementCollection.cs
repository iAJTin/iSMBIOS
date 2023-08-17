
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of objects <see cref="ChassisContainedElement"/>.
/// </summary>
public sealed class DmiChassisContainedElementCollection : ReadOnlyCollection<DmiChassisContainedElement>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiChassisContainedElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal DmiChassisContainedElementCollection(ChassisContainedElementCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="ChassisContainedElementCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available elements.
    /// </remarks>                                    
    public override string ToString() => $"Elements = {Items.Count}";

    #endregion              

    #region private static methods

    private static IEnumerable<DmiChassisContainedElement> AsDmiCollectionFrom(ChassisContainedElementCollection elements)
    {
        var items = new Collection<DmiChassisContainedElement>();

        foreach (var element in elements)
        {
            items.Add(new DmiChassisContainedElement(element.Properties));
        }

        return items;
    }

    #endregion
}
