
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;

    /// <inheritdoc />
    /// <summary>
    /// Defines an object that represents a strongly typed property.
    /// </summary>
    /// <typeparam name="T">
    /// The type of value of this property. Because the property value can be empty, only types that are accept values<c>null</c>.
    /// </typeparam>
    public sealed class DeviceProperty<T> : IDeviceProperty
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object _value;
        #endregion

        #region constructor/es

        #region [internal] DeviceProperty(PropertyKey, DevicePropertyDescription, object): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="DeviceProperty"/> class.
        /// </summary>
        /// <param name="propertykey">Key to the property to be recovered.</param>
        /// <param name="value">Valor de la propiedad.</param>
        internal DeviceProperty(PropertyKey propertykey, object value)
        {
            _value = value;
            PropertyKey = propertykey;
            Description = DevicePropertyDescriptionsCache.Cache.GetPropertyDescription(propertykey);
        }
        #endregion

        #endregion

        #region interfaces

        #region IDeviceProperty

        #region public readonly properties

        #region [public] (DevicePropertyDescription) Description: Gets an object that represents the description of the property
        /// <inheritdoc />
        /// <summary>
        /// Gets an object that represents the description of the property.
        /// </summary>
        /// <value>
        /// Description of a property.
        /// </value>
        public DevicePropertyDescription Description { get; }
        #endregion

        #region [public] (bool) HasValue: Gets a value that indicates if there is a value available for the property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that indicates if there is a value available for the property.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this property has value; otherwise, <strong>false</strong>.
        /// </value>
        public bool HasValue => _value != null;
        #endregion

        #region [public] (PropertyKey) PropertyKey: Gets a value that represents the unique key that identifies this property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that represents the unique key that identifies this property.
        /// </summary>
        /// <value>
        /// Unique key that identifies this property.
        /// </value>
        public PropertyKey PropertyKey { get; }
        #endregion

        #endregion

        #region public methods

        #region [public] (object) GetValue(): Returns property value
        /// <inheritdoc />
        /// <summary>
        /// Returns property value.
        /// </summary>
        /// <returns>
        /// Property value.
        /// </returns>
        public object GetValue() => _value;
        #endregion

        #region [public] (T) GetValue<T>(): Returns the value of the strongly typed property
        /// <inheritdoc />
        /// <summary>
        /// Returns the value of the strongly typed property.
        /// </summary>
        /// <typeparam name="T">The type of value of this property</typeparam>
        /// <returns>
        /// Strongly typed property value.
        /// </returns>
        public T GetValue<T>() => (T) GetValue();
        #endregion

        #endregion

        #endregion

        #endregion

        #region public readonly properties

        #region [public] (T) Value: Gets the strongly typed value of this property
        /// <summary>
        /// Gets the strongly typed value of this property.
        /// </summary>
        /// <value>
        /// Value of this property
        /// </value>
        [Obsolete("Please use IDeviceProperty.GetValue() or IDeviceProperty.GetValue<T>() generic call instead")]
        public T Value => (T)_value;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a string that represents this instance
        /// </summary>
        /// <returns>
        /// <see cref="T:System.String"/> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that identifies the device.
        /// </remarks> 
        public override string ToString() => $"HasValue={HasValue}";
        #endregion

        #endregion
    }
}
