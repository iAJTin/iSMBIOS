
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of objects <see cref="DmiAdditionalInformationEntry"/>.
/// </summary>
public sealed class DmiAdditionalInformationEntryCollection : ReadOnlyCollection<DmiAdditionalInformationEntry>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiAdditionalInformationEntryCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal DmiAdditionalInformationEntryCollection(AdditionalInformationEntryCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="DmiAdditionalInformationEntryCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available elements.
    /// </remarks>                                    
    public override string ToString() => $"Entries = {Items.Count}";

    #endregion

    #region private static methods

    private static IEnumerable<DmiAdditionalInformationEntry> AsDmiCollectionFrom(AdditionalInformationEntryCollection elements)
    {
        var items = new Collection<DmiAdditionalInformationEntry>();

        foreach (var element in elements)
        {
            items.Add(new DmiAdditionalInformationEntry(element.Properties));
        }

        return items;
    }

    #endregion
}
