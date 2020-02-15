
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;

    /// <summary>
    /// The <b>DmiBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="DMI"/>.
    /// </summary>
    public interface IDmiType
    {
        /// <summary>
        /// Returns a list of implemented properties for a structure
        /// </summary>
        /// <returns>
        /// A list of implemented properties for a structure.
        /// </returns>
        IEnumerable<IPropertyKey> ImplementedProperties { get; }

        /// <summary>
        /// Returns a value that indicates the implemented version of a <see cref="DMI"/> structure.
        /// </summary>
        /// <returns>
        /// One of the values of the <see cref="DmiStructureVersion"/> enumeration.
        /// </returns>
        DmiStructureVersion ImplementedVersion { get; }

        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        DmiClassPropertiesTable Properties { get; }


        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        object GetPropertyValue(IPropertyKey propertyKey);

        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        T GetPropertyValue<T>(IPropertyKey propertyKey);
    }
}
