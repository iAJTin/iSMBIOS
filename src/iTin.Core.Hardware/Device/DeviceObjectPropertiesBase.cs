
namespace iTin.Core.Hardware.Device
{
    using System.Diagnostics;

    using DeviceProperty;
    using Helpers;

    public abstract class DeviceObjectPropertiesBase
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly IDeviceInfo owner;
        #endregion

        #region constructor/s

            #region [protected] DeviceObjectPropertiesBase(IDeviceInfo): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DeviceObjectPropertiesBase"/>.
            /// </summary>
            /// <param name="owner">Interfaz <see cref="IDeviceInfo"/> que tiene acceso a las propiedades.</param>
            protected DeviceObjectPropertiesBase(IDeviceInfo owner)
            {
                SentinelHelper.ArgumentNull(owner);

                this.owner = owner;
            }
            #endregion

        #endregion

        #region protecetd methods

            #region [protected] (IDeviceProperty) GetProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty que representa el valor fuertemente tipado de la propiedad.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/> que representa el valor fuertemente tipado de la propiedad.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
            /// <returns>
            /// Referencia al objeto que representa el valor fuertemente tipado de la propiedad
            /// </returns>
            protected IDeviceProperty GetProperty(PropertyKey propertyKey)
            {
                return owner.GetProperty(propertyKey);
            }
            #endregion

        #endregion
    }
}
