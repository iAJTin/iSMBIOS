﻿
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Represents a collection of objects <see cref="SmbiosStructure"/> available on a motherboard.
/// </summary>
public sealed class BaseBoardContainedElementCollection : ReadOnlyCollection<SmbiosStructure>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="BaseBoardContainedElementCollection"/>.
    /// </summary>
    /// <param name="elements">Item list.</param>
    internal BaseBoardContainedElementCollection(IEnumerable<SmbiosStructure> elements) : base(elements.ToList())
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="T: System.String"/> that represents the current object.
    /// </summary>
    /// <returns>
    /// Object <see cref="string"/> that represents the current <see cref = "AdditionalInformationEntryCollection"/> class.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the number of available items.
    /// </remarks>                                    
    public override string ToString() => $"Elements = {Items.Count}";

    #endregion              
}
