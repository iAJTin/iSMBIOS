
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// Attribute that sets the type of the value of a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DevicePropertyTypeAttribute : Attribute
    {
        #region constructor/s

        #region [public] DevicePropertyTypeAttribute(Type): Initialize a new instance of the class by setting the type of property value
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Device.DeviceProperty.DevicePropertyTypeAttribute" /> class by setting the type of property value.
        /// </summary>
        /// <param name="propertyType">Type of property value.</param>
        public DevicePropertyTypeAttribute(Type propertyType)
        {
            PropertyType = propertyType;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (Type) PropertyType: Gets an object that represents the type of property value
        /// <summary>
        /// Gets an object that represents the type of property value
        /// </summary>
        /// <value>
        /// Type of property value.
        /// </value>
        public Type PropertyType { get; }
        #endregion

        #endregion
    }
}
