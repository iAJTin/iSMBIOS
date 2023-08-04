
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using iTin.Core;
using iTin.Core.ComponentModel;
using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// The <b>SmbiosBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="SMBIOS"/>.
/// </summary>
public abstract class SmbiosBaseType
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string[] _strings;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SmbiosPropertiesTable _smbiosPropertiesTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="SmbiosBaseType"/> by specifying the Header of the structure and current SMBIOS.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Header of the current structure.</param>
    /// <param name="smbiosVersion">Current SMBIOS version.</param>
    protected SmbiosBaseType(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion)
    {
        SmbiosVersion = smbiosVersion;
        StructureInfo = smbiosStructureHeaderInfo;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Returns a list of implemented properties for this smbios structure.
    /// </summary>
    /// <returns>
    /// A list of implemented properties for this structure.
    /// </returns>
    public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;

    /// <summary>
    /// Gets the raw information from this structure.
    /// </summary>
    /// <value>
    /// A <see cref="SmbiosStructureHeaderInfo"/> object that contains the information.
    /// </value>
    public SmbiosStructureHeaderInfo StructureInfo { get; }

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    internal SmbiosPropertiesTable Properties
    {
        get
        {
            if (_smbiosPropertiesTable != null)
            {
                return _smbiosPropertiesTable;
            }

            _smbiosPropertiesTable = new SmbiosPropertiesTable();
            Parse(_smbiosPropertiesTable);

            return _smbiosPropertiesTable;
        }
    }

    #endregion

    #region protected readonly properties

    /// <summary>
    /// Gets a reference to byte raw data reader
    /// </summary>
    /// <value>
    /// Byte raw data reader.
    /// </value>
    protected ByteReader Reader => ByteReader.FromByteArray(StructureInfo.RawData);

    /// <summary>
    /// Gets the current version of <see cref="SMBIOS"/>.
    /// </summary>
    /// <value>
    /// Value representing the current version of <see cref="SMBIOS"/>.
    /// </value>
    protected int SmbiosVersion { get; }

    /// <summary>
    /// Gets the strings associated with this structure.
    /// </summary>
    /// <value>
    /// An array that contains the strings of this structure.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected string[] Strings => _strings ??= SmbiosHelper.ParseStrings(StructureInfo.RawData);

    #endregion

    #region public methods

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
    /// </returns>
    public object GetPropertyValue(IPropertyKey propertyKey)
    {
        var propertyType = propertyKey.GetPropertyType();

        object result = Properties[propertyKey];
        if (!(result is List<PropertyItem> itemList))
        {
            return result;
        }

        bool hasItems = itemList.Any();
        if (!hasItems)
        {
            return propertyType.GetDefaultValue();
        }

        bool onlyOneItem = itemList.Count == 1;
        if (onlyOneItem)
        {
            return itemList.FirstOrDefault().Value;
        }

        return propertyType.GetDefaultValue();
    }

    /// <summary>
    /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
    /// </returns>
    public T GetPropertyValue<T>(IPropertyKey propertyKey) => (T)GetPropertyValue(propertyKey);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents this instance.
    /// </returns>
    /// <remarks>
    /// This method returns a string that includes the property <see cref="SmbiosStructureInfo.StructureType"/>.
    /// </remarks> 
    public override string ToString() => $"Type = {StructureInfo.StructureType}";

    #endregion

    #region protected methods

    /// <summary>
    /// Returns the stored string from the specified byte.
    /// </summary>
    /// <param name="target">target byte</param>
    /// <returns>
    /// The value stored in the indicated byte.
    /// </returns>
    protected string GetString(byte target)
    {
        try
        {
            return Strings[Reader.GetByte(target)];
        }
        catch
        {
            return string.Empty;
        }
    }

    /// <summary>
    /// Parse and populates the property collection for this structure.
    /// </summary>
    /// <param name="properties">Collection of properties of this structure.</param>
    protected void Parse(SmbiosPropertiesTable properties)
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
    protected virtual void PopulateProperties(SmbiosPropertiesTable properties)
    {
    }

    #endregion

    #region private members

    //#region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Returns a reference to an object that implements the interface IDeviceProperty, represents the value of the property specified by its key by the parameter propertyKey.
    ///// <summary>
    ///// Returns a reference to an object that implements the interface <see cref="IDeviceProperty"/>, represents the value of the property specified by its key by the parameter <paramref name="propertyKey"/>.
    ///// </summary>
    ///// <param name="propertyKey">Key to the property to obtain</param>
    ///// <returns>
    ///// Interface that represents the value of the property.
    ///// </returns>
    //private IDeviceProperty GetTypedProperty(PropertyKey propertyKey)
    //{
    //    object propertyValue = GetValueTypedProperty(propertyKey);
    //    IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

    //    return newTypedProperty;
    //}
    //#endregion

    #endregion
}
