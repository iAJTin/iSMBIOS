
using System;

namespace iTin.Core.Hardware.Common;

/// <summary>
/// Defines a value that contains the detailed information of a writer.
/// </summary>
public readonly struct PropertyKey : IPropertyKey, IEquatable<PropertyKey>
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the structure <see cref="T:iTin.Core.Hardware.PropertyKey" /> specifying the structure and property.
    /// </summary>
    /// <param name="structureId">Structure identifier.</param>
    /// <param name="propertyId">Property identifier.</param>
    public PropertyKey(Enum structureId, Enum propertyId) : this(structureId, propertyId, PropertyUnit.None)
    {
    }

    /// <summary>
    /// Initialize a new instance of the structure <see cref="T:iTin.Core.Hardware.PropertyKey" /> specifying the structure, property and measured unit.
    /// </summary>
    /// <param name="structureId">Structure identifier.</param>
    /// <param name="propertyId">Property identifier.</param>
    /// <param name="propertyUnit">Unit identifier.</param>
    public PropertyKey(Enum structureId, Enum propertyId, PropertyUnit propertyUnit)
    {
        PropertyId = propertyId;
        StructureId = structureId;
        PropertyUnit = propertyUnit;
    }

    #endregion

    #region interfaces

    #region IEquatable

    #region public properties

    /// <summary>
    /// Indicates whether the current structure is equal to another structure of the same type.
    /// </summary>
    /// <param name="other">Structure that is going to be compared with this structure.</param>
    /// <returns>
    /// Returns <strong>true</strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
    /// </returns>
    public bool Equals(PropertyKey other) => other.Equals((object)this);

    #endregion

    #endregion

    #region IPropertyKey

    #region public properties

    /// <summary>
    /// Gets a value that represents a <see cref="P:iTin.Core.Hardware.PropertyKey.StructureId" /> field from which the value is to be retrieved.
    /// </summary>
    /// <value>
    /// Field of <see cref="P:iTin.Core.Hardware.PropertyKey.StructureId" /> from which the value will be retrieved.
    /// </value>
    /// <remarks>
    /// The value of the attribute represents the type of the value linked to this property.
    /// </remarks>
    public Enum PropertyId { get; }

    /// <summary>
    /// Gets a value that represents the unit in which the property is measured.
    /// </summary>
    /// <value>
    /// Unidad en que se mide la propiedad.
    /// </value>
    public PropertyUnit PropertyUnit { get; }

    /// <summary>
    /// Gets a value that represents the structure from which the value is to be retrieved.
    /// </summary>
    /// <value>
    /// Structure from which the value will be recovered.
    /// </value>
    public Enum StructureId { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the property description.
    /// </summary>
    /// <returns>
    /// Property description.
    /// </returns>
    public string GetPropertyDescription() => PropertyId.GetPropertyDescription();

    /// <summary>
    /// Returns the property name. If is null or empty then returns this property name.
    /// </summary>
    /// <returns>
    /// Property name.
    /// </returns>
    public string GetPropertyName()
    {
        string name = PropertyId.GetPropertyName();

        return string.IsNullOrEmpty(name)
            ? PropertyId.ToString()
            : name;
    }

    /// <summary>
    /// Returns the property type.
    /// </summary>
    /// <returns>
    /// Property type.
    /// </returns>
    public Type GetPropertyType() => PropertyId.GetPropertyType();

    #endregion

    #endregion

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="propertyKey1">Operand 1.</param>
    /// <param name="propertyKey2">Operand 2.</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>propertyKey1</c> is equal to <c>propertyKey2</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator ==(PropertyKey propertyKey1, PropertyKey propertyKey2) => propertyKey1.Equals(propertyKey2);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="propertyKey1">Operando 1.</param>
    /// <param name="propertyKey2">Operando 2.</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>propertyKey1</c> it is not equal to <c>propertyKey2</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator !=(PropertyKey propertyKey1, PropertyKey propertyKey2) => !propertyKey1.Equals(propertyKey2);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a value that represents the hash code of this structure.
    /// </summary>
    /// <returns>
    /// Hash code of this structure
    /// </returns>
    public override int GetHashCode() => ToString().GetHashCode();

    /// <summary>
    /// Returns a value that indicates if this structure is equal to another.
    /// </summary>
    /// <param name="obj">Structure with which to compare.</param>
    /// <returns>
    /// Result of the comparison of equality.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not PropertyKey other)
        {
            return false;
        }

        return
            PropertyId.Equals(other.PropertyId) &&
            StructureId.Equals(other.StructureId) &&
            PropertyUnit.Equals(other.PropertyUnit);
    }

    /// <summary>
    /// Returns a <see cref="T:System.String" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.String" /> that represents this instance.
    /// </returns>
    public override string ToString() => $"Structure = {StructureId}, Property = {PropertyId}, Unit = {PropertyUnit}";

    #endregion
}
