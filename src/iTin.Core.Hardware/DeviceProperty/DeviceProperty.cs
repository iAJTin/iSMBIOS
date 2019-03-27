
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
        private readonly PropertyKey propertykey;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DevicePropertyDescription description;

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
            this.description = description;
            this.propertykey = propertykey;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DevicePropertyDescription) Description: Gets an object that represents the description of the property
        /// <summary>
        /// Gets an object that represents the description of the property.
        /// </summary>
        /// <value>
        /// Description of a property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public DevicePropertyDescription Description => description;
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
        #endregion

        #region [public] (PropertyKey) PropertyKey: Gets a value that represents the unique key that identifies this property
        /// <summary>
        /// Gets a value that represents the unique key that identifies this property.
        /// </summary>
        /// <value>
        /// Unique key that identifies this property.
        /// </value>
        public PropertyKey PropertyKey => propertykey;
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
