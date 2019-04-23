
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Represents the description of a property.
    /// </summary>
    public class DevicePropertyDescription
    {
        #region constructor/s

        #region [internal] DevicePropertyDescription(PropertyKey): Initialize a new instance of the class with the property key
        /// <summary>
        /// Initialize a new instance of the <see cref="DevicePropertyDescription" /> class with the property key.
        /// </summary>
        /// <param name="propertyKey">Unique property code</param>
        internal DevicePropertyDescription(PropertyKey propertyKey)
        {
            PropertyKey = propertyKey;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) PropertyName: Gets a string that contains the description of the property
        /// <summary> 
        /// Gets a string that contains the description of the property.
        /// </summary>
        /// <value>
        /// Description of the property.
        /// </value>
        public string PropertyName
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
        public PropertyKey PropertyKey { get; }

        #endregion

        #region [public] (Type) PropertyType: Gets a value that represents the type of the value assigned to the property
        /// <summary>
        /// Gets a value that represents the type of the value assigned to the property.
        /// </summary>
        /// <value>
        /// Type of value assigned to the property.
        /// </value>
        /// <remarks>
        /// The type of the property is obtained by reflection from the <see cref="PropertyKey" />.
        /// </remarks>
        public Type PropertyType
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
        public override string ToString() => $"Name=\"{PropertyName}\"; Type=\"{PropertyType.Name}\"";
        #endregion

        #endregion
    }
}
