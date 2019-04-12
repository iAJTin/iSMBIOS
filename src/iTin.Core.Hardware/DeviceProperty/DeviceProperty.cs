
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System.Diagnostics;

    /// <summary>
    /// Defines an object that represents a strongly typed property.
    /// </summary>
    /// <typeparam name="T">
    /// The type of value of this property. Because the property value can be empty, only types that are
    /// accept values<c>null</c>.
    /// </typeparam>
    public sealed class DeviceProperty<T> : IDeviceProperty
    {
        #region private readonly properties
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly object value;
        #endregion

        #region constructor/es

        #region [internal] DeviceProperty(PropertyKey, DevicePropertyDescription, object): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="DeviceProperty"/> class.
        /// </summary>
        /// <param name="propertykey">Key to the property to be recovered.</param>
        /// <param name="description">Descripción de la propiedad.</param>
        /// <param name="value">Valor de la propiedad.</param>
        internal DeviceProperty(PropertyKey propertykey, DevicePropertyDescription description, object value)
        {
            this.value = value;
            Description = description;
            PropertyKey = propertykey;
        }
        #endregion

        #endregion

        #region public properties

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
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public bool HasValue => Value != null;

        /// <inheritdoc />
        /// <summary>
        /// Returns property value.
        /// </summary>
        /// <returns>
        /// Property value.
        /// </returns>
        public object GetValue()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns property value.
        /// </summary>
        /// <typeparam name="T">Property type</typeparam>
        /// <returns>
        /// Property value.
        /// </returns>
        public T1 GetValue<T1>()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region [public] (PropertyKey) PropertyKey: Gets a value that represents the unique key that identifies this property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that represents the unique key that identifies this property.
        /// </summary>
        /// <value>
        /// Unique key that identifies this property.
        /// </value>
        [field: DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public PropertyKey PropertyKey { get; }

        #endregion

        #region [public] (T) Value: Gets the strongly typed value of this property
        /// <summary>
        /// Gets the strongly typed value of this property
        /// </summary>
        /// <value>
        /// Value of this property
        /// </value>
        public T Value => (T)value;
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
        public override string ToString() => $"HasValue = {HasValue}";
        #endregion

        #endregion
    }
}
