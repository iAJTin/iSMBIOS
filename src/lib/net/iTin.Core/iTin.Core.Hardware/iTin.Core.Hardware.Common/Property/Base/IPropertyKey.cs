
using System;

namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Defines a value that contains the detailed information of a writer.
    /// </summary>
    public interface IPropertyKey
    {
        /// <summary>
        /// Gets a value that represents a <see cref="StructureId"/> field from which the value is to be retrieved.
        /// </summary>
        /// <value>
        /// Field of <see cref="StructureId" /> from which the value will be retrieved.
        /// </value>
        /// <remarks>
        /// The value of the attribute represents the type of the value linked to this property.
        /// </remarks>
        Enum PropertyId { get; }

        /// <summary>
        /// Gets a value that represents the unit in which the property is measured.
        /// </summary>
        /// <value>
        /// Unidad en que se mide la propiedad.
        /// </value>
        PropertyUnit PropertyUnit { get; }

        /// <summary>
        /// Gets a value that represents the structure from which the value is to be retrieved.
        /// </summary>
        /// <value>
        /// Structure from which the value will be recovered.
        /// </value>
        Enum StructureId { get; }


        /// <summary>
        /// Returns the property description.
        /// </summary>
        /// <returns>
        /// Property description.
        /// </returns>
        string GetPropertyDescription();

        /// <summary>
        /// Returns the property name.
        /// </summary>
        /// <returns>
        /// Property name.
        /// </returns>
        string GetPropertyName();

        /// <summary>
        /// Returns the property type.
        /// </summary>
        /// <returns>
        /// Property type.
        /// </returns>
        Type GetPropertyType();
    }
}
