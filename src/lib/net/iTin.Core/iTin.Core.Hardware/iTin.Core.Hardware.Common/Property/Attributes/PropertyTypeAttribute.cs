
using System;

namespace iTin.Core.Hardware.Common;

/// <summary>
/// Attribute that sets the type of the value of a property.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class PropertyTypeAttribute : Attribute
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.PropertyTypeAttribute" /> class by setting the type of property value.
    /// </summary>
    /// <param name="propertyType">Type of property value.</param>
    public PropertyTypeAttribute(Type propertyType)
    {
        PropertyType = propertyType;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets an object that represents the type of property value
    /// </summary>
    /// <value>
    /// Type of property value.
    /// </value>
    public Type PropertyType { get; }

    #endregion
}
