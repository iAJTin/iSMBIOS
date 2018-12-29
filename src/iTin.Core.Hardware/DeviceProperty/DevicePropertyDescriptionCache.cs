
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// La clase <see cref="DevicePropertyDescriptionsCache"/> representa la caché de descripciones disponibles por claves.
    /// </summary>
    internal class DevicePropertyDescriptionsCache
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IDictionary<PropertyKey, DevicePropertyDescription> _propsDictionary;
        #endregion

        #region public static readonly members
        /// <summary>
        /// Obtiene una referencia a la caché de descripciones disponibles.
        /// </summary>
        public static readonly DevicePropertyDescriptionsCache Cache = new DevicePropertyDescriptionsCache();
        #endregion

        #region constructor/s

        #region [private] DevicePropertyDescriptionsCache(): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DevicePropertyDescriptionsCache"/>.
        /// </summary>
        private DevicePropertyDescriptionsCache()
        {
            _propsDictionary = new Dictionary<PropertyKey, DevicePropertyDescription>();
        }
        #endregion

        #endregion

        #region public methods

            #region [public] (DevicePropertyDescription) GetPropertyDescription(PropertyKey): Obtener la descripción para la clave especificada.
            /// <summary>
            /// Obtener la descripción para la clave especificada.
            /// </summary>
            /// <param name="key">The structure info.</param>
            /// <returns>Descripción para la clave especificada.</returns>
            public DevicePropertyDescription GetPropertyDescription(PropertyKey key)
            {
                if (!_propsDictionary.ContainsKey(key))
                {
                    _propsDictionary.Add(key, new DevicePropertyDescription(key));
                }

                return _propsDictionary[key];
            }
            #endregion

        #endregion
    }
}
