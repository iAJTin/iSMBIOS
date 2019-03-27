
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    /// <summary>
    /// Represents the description of a property.
    /// </summary>
    public class DevicePropertyDescription
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly PropertyKey _propertyKey;
        #endregion

        #region constructor/s

        #region [internal] DevicePropertyDescription(PropertyKey): Initialize a new instance of the class with the property key
        /// <summary>
        /// Initialize a new instance of the <see cref="DevicePropertyDescription" /> class with the property key.
        /// </summary>
        /// <param name="propertyKey">Unique property code</param>
        internal DevicePropertyDescription(PropertyKey propertyKey)
        {
            _propertyKey = propertyKey;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Name: Obtiene una cadena que identifica la descripción.
        /// <summary> 
        /// Obtiene una cadena que identifica la descripción.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Cadena que identifica la descripción.</para>
        /// </value>
        public string Name
        {
            get
            {
                Enum id = PropertyKey.PropertyId;
                Type idType = id.GetType();

                string idName = Enum.GetName(idType, id);
                MemberInfo[] mi = idType.GetMember(idName);

                Attribute generalAttribute = Attribute.GetCustomAttribute(mi[0], typeof(DevicePropertyDescriptionAttribute));
                var idDevicePropertyAttribute = (DevicePropertyDescriptionAttribute)generalAttribute;

                string valueType = idDevicePropertyAttribute.Description;
                return valueType;
            }
        }
        #endregion

        #region [public] (PropertyKey) PropertyKey: Gets a value that represents the unique key that identifies a property
        /// <summary> 
        /// Gets a value that represents the unique key that identifies a property.
        /// </summary>
        /// <value>
        /// Unique key that identifies a property.
        /// </value>
        public PropertyKey PropertyKey => _propertyKey;
        #endregion

        #region [public] (Type) ValueType: Gets a value that represents the type of the value assigned to the property
        /// <summary>
        /// Gets a value that represents the type of the value assigned to the property.
        /// </summary>
        /// <value>
        /// Type of value assigned to the property.
        /// </value>
        /// <remarks>
        /// The type of the property is obtained by reflection from the <see cref="PropertyKey" />.
        /// </remarks>
        public Type ValueType
        {
            get
            {
                Enum id = PropertyKey.PropertyId;
                Type idType = id.GetType();

                string idName = Enum.GetName(idType, id);
                MemberInfo[] mi = idType.GetMember(idName);

                Attribute generalAttribute = Attribute.GetCustomAttribute(mi[0], typeof(DevicePropertyTypeAttribute));
                var idDevicePropertyAttribute = (DevicePropertyTypeAttribute)generalAttribute;

                Type valueType = idDevicePropertyAttribute.PropertyType;
                return valueType;
            }
        }
        #endregion

        #endregion

        #region public overide methods

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
        public override string ToString() => $"Name = {Name}; Type = {ValueType.Name}";
        #endregion

        #endregion
    }
}
