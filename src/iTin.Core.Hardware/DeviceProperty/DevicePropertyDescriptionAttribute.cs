
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Atributo que permite añadir una descripción a una propiedad.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DevicePropertyDescriptionAttribute : Attribute
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly string _description;
        #endregion

        #region constructor/s

            #region [public] DevicePropertyDescriptionAttribute(string): Inicializa una nueva instancia de la clase estableciendo una cadena que define la propiedad.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DevicePropertyDescriptionAttribute"/> estableciendo una cadena que define la propiedad.
            /// </summary>
            /// <param name="description">Cadena que define la propiedad.</param>
            public DevicePropertyDescriptionAttribute(string description)
            {
                _description = description;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (string) Description: Obtiene una cadena que define la propiedad.
            /// <summary>
            /// Obtiene una cadena que define la propiedad.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que define la propiedad.</para>
            /// </value>
            public string Description
            {
                get { return _description; }
            }
            #endregion

        #endregion
    }
}
