
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;

    /// <summary>
    /// Representa la descripción de una propiedad.
    /// </summary>
    public class DevicePropertyDescription
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly PropertyKey _propertyKey;
        #endregion

        #region constructor/s

            #region [internal] DevicePropertyDescription(PropertyKey): Inicializa una nueva instancia de la clase con la clave de la propiedad.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DevicePropertyDescription"/> con la clave de la propiedad.
            /// </summary>
            /// <param name="propertyKey">Clave única de la propiedad.</param>
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

            #region [public] (PropertyKey) PropertyKey: Obtiene un valor que representa la clave única que identifica una propiedad.
            /// <summary> 
            /// Obtiene un valor que representa la clave única que identifica una propiedad.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="PropertyKey"/></para>
            ///   <para>Clave única que identifica una propiedad.</para>
            /// </value>
            public PropertyKey PropertyKey
            {
                get { return _propertyKey; }
            }
            #endregion

            #region [public] (Type) ValueType: Obtiene un valor que representa el tipo del valor asignado a la propiedad.
            /// <summary>
            /// Obtiene un valor que representa el tipo del valor asignado a la propiedad.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Type"/></para>
            ///   <para>Tipo del valor asignado a la propiedad.</para>
            /// </value>
            /// <remarks>
            /// El tipo de la propiedad se obtiene mediante reflexión a partir de la <see cref="PropertyKey"/>.
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

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
            /// <summary>
            /// Devuelve una cadena que representa la clase <see cref="DevicePropertyDescription"/> actual.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String"/></para>
            ///   <para>Cadena que representa la clase <see cref="DevicePropertyDescription"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// Este método devuelve una cadena que identifica el dispositivo.
            /// </remarks> 
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Name = {0}; Type = {1}", Name, ValueType.Name);
            }
            #endregion

        #endregion
    }
}
