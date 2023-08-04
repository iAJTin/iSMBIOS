﻿
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Represents a collection of objects <see cref="MemoryChannelElement"/>.
/// </summary>
public sealed class MemoryChannelElementCollection : ReadOnlyCollection<MemoryChannelElement>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="MemoryChannelElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal MemoryChannelElementCollection(IEnumerable<MemoryChannelElement> elements) : base(elements.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="string"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref="MemoryChannelElementCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items
    /// </remarks>                                    
    public override string ToString() => $"Devices = {Items.Count}";

    #endregion              
}
