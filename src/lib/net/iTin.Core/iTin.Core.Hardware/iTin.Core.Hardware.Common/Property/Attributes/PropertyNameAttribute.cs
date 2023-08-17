
using System;

namespace iTin.Core.Hardware.Common;

/// <summary>
/// Attribute that allows you to add a name to a property.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class PropertyNameAttribute : Attribute
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.PropertyDescriptionAttribute" /> class by setting a string that defines the property's name.
    /// </summary>
    /// <param name="name">String that defines the property</param>
    public PropertyNameAttribute(string name)
    {
        Name = name;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a string that defines the property.
    /// </summary>
    /// <value>
    /// <see cref="T:System.String"/> that defines the property.
    /// </value>
    public string Name { get; }

    #endregion
}
