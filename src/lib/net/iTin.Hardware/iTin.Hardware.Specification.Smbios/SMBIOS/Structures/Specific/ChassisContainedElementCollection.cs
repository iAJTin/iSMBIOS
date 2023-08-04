
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Represents a collection of objects <see cref="ChassisContainedElement"/>.
/// </summary>
public sealed class ChassisContainedElementCollection : ReadOnlyCollection<ChassisContainedElement>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="ChassisContainedElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal ChassisContainedElementCollection(IEnumerable<ChassisContainedElement> elements) : base(elements.ToList())
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
}
