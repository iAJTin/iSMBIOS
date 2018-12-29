
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Atributo que establece el tipo del valor de una propiedad.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DevicePropertyTypeAttribute : Attribute
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Type _propertyType;
        #endregion

        #region constructor/s

            #region [public] DevicePropertyTypeAttribute(Type): Inicializa una nueva instancia de la clase estableciendo el tipo del valor de la propiedad.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DevicePropertyTypeAttribute"/> estableciendo el tipo del valor de la propiedad.
            /// </summary>
            /// <param name="propertyType">Tipo del valor de la propiedad.</param>
            public DevicePropertyTypeAttribute(Type propertyType)
            {
                _propertyType = propertyType;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (Type) PropertyType: Obtiene un objeto que representa el tipo del valor de la propiedad.
            /// <summary>
            /// Obtiene un objeto que representa el tipo del valor de la propiedad.
            /// </summary>
            /// <value>
            /// Tipo del valor de la propiedad.
            /// </value>
            public Type PropertyType
            {
                get { return _propertyType; }
            }
            #endregion

        #endregion
    }
}
