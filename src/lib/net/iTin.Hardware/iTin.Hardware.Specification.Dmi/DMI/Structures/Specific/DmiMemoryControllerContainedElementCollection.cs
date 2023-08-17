
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of memory device identifiers.
/// </summary>
public sealed class DmiMemoryControllerContainedElementCollection : ReadOnlyCollection<int>
{
    #region constructor/s

    /// <inheritdoc/>
    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiMemoryControllerContainedElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal DmiMemoryControllerContainedElementCollection(IEnumerable<int> elements) : base(elements.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="DmiMemoryControllerContainedElementCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items
    /// </remarks>                                    
    public override string ToString() => $"Memory Devices = { Items.Count}";

    #endregion              
}
