
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <inheritdoc/>
/// <summary>
/// Represents a collection of objects <see cref="AdditionalInformationEntry"/>.
/// </summary>
public sealed class AdditionalInformationEntryCollection : ReadOnlyCollection<AdditionalInformationEntry>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="AdditionalInformationEntryCollection"/>.
    /// </summary>
    /// <param name="entries">Item list.</param>
    internal AdditionalInformationEntryCollection(IEnumerable<AdditionalInformationEntry> entries) : base(entries.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="T: System.String"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntryCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available elements.
    /// </remarks>                                    
    public override string ToString() => $"Entries = {Items.Count}";

    #endregion              
}
