
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System.Diagnostics;
    using System.Globalization;

    /// <summary>
    /// Define un objeto que representa una propiedad fuertemente tipada.
    /// </summary>
    /// <typeparam name="T">
    /// El tipo de valor de esta propiedad. Debido a que el valor de propiedad puede estar vacío, sólo se admiten tipos que 
    /// aceptan valores <c>null</c>.
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

            #region [internal] DeviceProperty(PropertyKey, DevicePropertyDescription, object): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase.
            /// </summary>
            /// <param name="propertykey">Clave de la propiedad a recuperar.</param>
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

            #region [public] (DevicePropertyDescription) Description: Obtiene un objeto que representa la descripción de la propiedad.
            /// <summary>
            /// Obtiene un objeto que representa la descripción de una propiedad.
            /// </summary>
            /// <value>
            /// Descripción de una propiedad.
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public DevicePropertyDescription Description
            {
                get { return description; }
            }
            #endregion

            #region [public] (bool) HasValue: Obtiene un valor que indica si existe un valor disponible para la propiedad.
            /// <summary>
            /// Obtiene un valor que indica si existe un valor disponible para la propiedad.
            /// </summary>
            /// <value>
            /// <strong>true</strong> si esta propiedad tiene valor;<strong>false</strong> en caso contrario.
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public bool HasValue
            {                
                get
                {
                    if (Value != null)
                    {
                        return true;
                    }

                    return false;
                }
            }
            #endregion

            #region [public] (PropertyKey) PropertyKey: Obtiene un valor que representa la clave única que identifica a esta propiedad.
            /// <summary>
            /// Obtiene un valor que representa la clave única que identifica a esta propiedad.
            /// </summary>
            /// <value>
            /// Clave única que identifica a esta propiedad.
            /// </value>
            public PropertyKey PropertyKey
            {
                get { return propertykey; }
            }
            #endregion

            #region [public] (T) Value: Obtiene el valor fuertemente tipado de esta propiedad.
            /// <summary>
            /// Obtiene el valor fuertemente tipado de esta propiedad.
            /// </summary>
            /// <value>Valor de la esta propiedad.</value>
            public T Value
            {
                get { return (T)value; }
            }
            #endregion

        #endregion

        #region public override methods

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
            /// <summary>
            /// Devuelve una cadena que representa la clase actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la clase actual.</para>
            /// </returns>
            /// <remarks>
            /// Este método devuelve una cadena que identifica a esta propiedad.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "HasValue = {0}", HasValue);
            }
            #endregion

        #endregion
    }
}
