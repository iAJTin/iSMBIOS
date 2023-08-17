
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of objects <see cref="SmbiosStructure"/> available on a motherboard.
/// </summary>
public sealed class BaseBoardContainedElementCollection : ReadOnlyCollection<SmbiosStructure>
{
    /// <summary>
    /// Initialize a new instance of the class <see cref="BaseBoardContainedElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal BaseBoardContainedElementCollection(IEnumerable<SmbiosStructure> elements) : base(elements.ToList())
    {
    }

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntryCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items.
    /// </remarks>                                    
    public override string ToString() => $"Elements = {Items.Count}";
}
