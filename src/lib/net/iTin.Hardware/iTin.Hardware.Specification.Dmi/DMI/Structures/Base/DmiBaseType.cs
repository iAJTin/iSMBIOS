﻿
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

using iTin.Hardware.Specification.Smbios;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// The <b>DmiBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="DMI"/>.
/// </summary>
/// <typeparam name="TSmbios">Smbios strucutre type</typeparam>
public abstract class DmiBaseType<TSmbios> : IDmiType
{
    #region private members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DmiClassPropertiesTable _smbiosPropertiesTable;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="SmbiosBaseType"/> by specifying the Header of the structure and current 
    /// </summary>
    /// <param name="smbiosStructure">Header of the current structure.</param>
    /// <param name="smbiosVersion">Current SMBIOS version.</param>
    protected DmiBaseType(TSmbios smbiosStructure, int smbiosVersion)
    {
        SmbiosVersion = smbiosVersion;
        SmbiosStructure = smbiosStructure;
    }

    #endregion

    #region interfaces

    #region IDmiType

    #region explicit

    /// <inheritdoc />
    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <returns>
    /// Availables properties.
    /// </returns>
    DmiClassPropertiesTable IDmiType.Properties => Properties;

    #endregion

    #region public readonly properties

    /// <inheritdoc/>
    public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;

    /// <summary>
    /// Returns a value that indicates the implemented version of this <see cref="DMI"/> structure.
    /// </summary>
    /// <returns>
    /// One of the values of the <see cref="DmiStructureVersion"/> enumeration.
    /// </returns>
    public DmiStructureVersion ImplementedVersion => (DmiStructureVersion)(SmbiosStructure as SmbiosBaseType).StructureInfo.StructureVersion;

    #endregion

    #region public methods

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>. Contains the result of the operation.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
    {
        PropertyItem candidate = Properties.FirstOrDefault(property => property.Key.Equals(propertyKey));
            
        return candidate == null 
            ? QueryPropertyResult.CreateErroResult("Can not found specified property key") 
            : QueryPropertyResult.CreateSuccessResult(candidate);
    }

    #endregion

    #endregion

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    internal DmiClassPropertiesTable Properties
    {
        get
        {
            if (_smbiosPropertiesTable != null)
            {
                return _smbiosPropertiesTable;
            }

            _smbiosPropertiesTable = new DmiClassPropertiesTable();
            Parse(_smbiosPropertiesTable);

            return _smbiosPropertiesTable;
        }
    }

    #endregion

    #region protected readonly properties

    /// <summary>
    /// Gets the current version of <see cref="SMBIOS"/>.
    /// </summary>
    /// <value>
    /// Value representing the current version of <see cref="SMBIOS"/>.
    /// </value>
    protected int SmbiosVersion { get; }

    /// <summary>
    /// Gets a reference to smbios structure.
    /// </summary>
    /// <value>
    /// A reference to smbios structure.
    /// </value>
    protected TSmbios SmbiosStructure { get; }

    #endregion

    #region public methods
        
    /// <summary>
    /// Returns a reference to the underlying smbios structure for this dmi type.
    /// </summary>
    /// <returns>
    /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
    /// </returns>
    public TSmbios GetUnderlyingSmbiosStructure() => SmbiosStructure;

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents this instance.
    /// </returns>
    public override string ToString() => $"Type = {GetType().Name}";

    #endregion

    #region protected methods

    /// <summary>
    /// Parse and populates the property collection for this structure.
    /// </summary>
    /// <param name="properties">Collection of properties of this structure.</param>
    protected void Parse(DmiClassPropertiesTable properties)
    {
        SentinelHelper.ArgumentNull(properties, nameof(properties));

        PopulateProperties(properties);
    }

    #endregion

    #region protected virtual methods

    /// <summary>
    /// Populates the property collection for this structure.
    /// </summary>
    /// <param name="properties">Collection of properties of this structure.</param>
    protected virtual void PopulateProperties(DmiClassPropertiesTable properties)
    {
    }

    #endregion
}
