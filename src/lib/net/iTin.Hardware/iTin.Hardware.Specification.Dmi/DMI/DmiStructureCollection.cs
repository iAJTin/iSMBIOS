﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a collection of <see cref="DmiStructure"/> objects implemented in <see cref="DMI"/>.
/// </summary>
public sealed class DmiStructureCollection : ReadOnlyCollection<DmiStructure>
{
    #region constructor/s

    /// <inheritdoc/>
    /// <summary>
    /// Initialize a new instance of the <see cref="DmiStructureCollection"/> class.
    /// </summary>
    /// <param name="context">a <see cref="SMBIOS"/> reference.</param>
    internal DmiStructureCollection(SMBIOS context) : base(new List<DmiStructure>())
    {
        if (context.Version == 0 && context.ImplementedStructures.Count == 0 && context.Lenght == 0)
        {
            return;
        }

        foreach (var smbiosStructure in context.ImplementedStructures)
        {
            Items.Add(new DmiStructure((DmiStructureClass)(int)smbiosStructure, context));
        }
    }

    #endregion

    #region public indexers

    /// <summary>
    /// Gets the element with the specified key.
    /// </summary>
    /// <Result>
    /// Object <see cref="DmiStructure"/> specified by its key.
    /// </Result>
    /// <remarks>
    /// If the element does not exist, <b>null</b> is returned.
    /// </remarks>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public DmiStructure this[DmiStructureClass resultKey]
    {
        get
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(resultKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(resultKey), (int)resultKey, typeof(SmbiosStructure));
            }

            int blockIndex = IndexOf(resultKey);
            if (blockIndex != -1)
            {
                return this[blockIndex];
            }

            return null;
        }
    }

    #endregion

    #region public methods

    /// <summary>
    /// Determines whether the element with the specified key is in the collection.
    /// </summary>
    /// <param name="resultKey">One of the Results of <see cref="SmbiosStructure"/> that represents the key of the object <see cref="DmiStructure"/> to search.</param>
    /// <returns>
    /// <b>true</b> if the object <see cref="DmiStructure"/> with the <paramref name="resultKey"/> is in the collection; otherwise, it is <b>false</b>.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public bool Contains(DmiStructureClass resultKey)
    {
        bool knownBlockValid = SentinelHelper.IsEnumValid(resultKey, true);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(resultKey), (int)resultKey, typeof(DmiStructureClass));
        }
                           
        DmiStructure block = Items.FirstOrDefault(item => item.Class == resultKey);

        return Items.Contains(block);
    }

    /// <summary>
    /// Returns a Result that contains the result of the operation. Always returns the first appearance of the property
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Result</b> property will contain the Result; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <b>Result</b> property is <see cref="PropertyItem"/>.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
    {
        Enum propertyId = propertyKey.StructureId;
        DmiStructure structure = this[(DmiStructureClass)propertyId];

        object result = structure?.Elements[0].Properties[propertyKey];
        if (!(result is List<PropertyItem> itemList))
        {
            return QueryPropertyResult.CreateErroResult("Can not found specified property key");
        }

        bool hasItems = itemList.Any();
        if (!hasItems)
        {
            return QueryPropertyResult.CreateErroResult("Can not found specified property key");
        }

        bool onlyOneItem = itemList.Count == 1;
        if (onlyOneItem)
        {
            return structure.Elements.FirstOrDefault()?.GetProperty(propertyKey);
        }

        return QueryPropertyResult.CreateErroResult("Can not found specified property key");

    }

    /// <summary>
    /// Returns a Result that contains the result of the operation.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyCollectionResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Result</b> property will contain the Result; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <b>Result</b> property is <see cref="IEnumerable{T}"/> where <b>T</b> is <see cref="PropertyItem"/>.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyCollectionResult GetProperties(IPropertyKey propertyKey)
    {
        Enum propertyId = propertyKey.StructureId;
        Collection<PropertyItem> properties = new Collection<PropertyItem>();
        DmiStructure structure = this[(DmiStructureClass)propertyId];
        if (structure == null)
        {
            return QueryPropertyCollectionResult.CreateErroResult("Can not found specified property key");
        }

        DmiClassCollection elements = structure.Elements;
        foreach (var element in elements)
        {
            properties.Add(element.GetProperty(propertyKey).Result);
        }

        return QueryPropertyCollectionResult.CreateSuccessResult(properties);
    }

    /// <summary>
    /// Returns the index of the object with the key specified in the collection
    /// </summary>
    /// <param name="ResultKey">One of the Results of <see cref="SmbiosStructure"/> that represents the key of the object to be searched in the collection.</param>
    /// <returns>
    /// Zero-base index of the first appearance of the item in the collection, if found; otherwise, -1.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException"></exception>
    public int IndexOf(DmiStructureClass ResultKey)
    {
        bool knownBlockValid = SentinelHelper.IsEnumValid(ResultKey, true);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(ResultKey), (int)ResultKey, typeof(DmiStructureClass));
        }

        DmiStructure block = null;
        foreach (var item in Items)
        {
            if (item.Class != ResultKey)
            {
                continue;
            }

            block = item;
            break;
        }

        return IndexOf(block);
    }

    #endregion
}
