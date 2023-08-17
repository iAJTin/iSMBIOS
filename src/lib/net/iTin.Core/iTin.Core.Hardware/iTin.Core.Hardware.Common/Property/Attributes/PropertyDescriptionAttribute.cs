
using System;
using System.ComponentModel;

namespace iTin.Core.Hardware.Common;

/// <summary>
/// Attribute that allows you to add a description to a property.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class PropertyDescriptionAttribute : DescriptionAttribute
{
    /// <summary>
    /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.PropertyDescriptionAttribute" /> class by setting a string that defines the property.
    /// </summary>
    /// <param name="description">String that defines the property</param>
    public PropertyDescriptionAttribute(string description) : base(description)
    {
    }
}
