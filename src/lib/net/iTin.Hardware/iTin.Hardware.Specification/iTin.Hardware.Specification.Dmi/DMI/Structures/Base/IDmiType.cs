
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;

    using iTin.Core.Hardware.Common;

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
        QueryPropertyResult GetProperty(IPropertyKey propertyKey);
    }
}
