
namespace iTin.Core.Hardware.Device
{
    using DeviceProperty;

    /// <summary>
    /// Defines a common device information.
    /// </summary>
    public interface IDeviceInfo
    {
        /// <summary>
        /// Obtiene un valor que indica si es un dispositivo de tipo <see cref="Specification.DMI"/>.
        /// </summary>
        /// <value>
        /// <strong>true</strong> si es un dispositivo <see cref="Specification.DMI"/>; <strong>false</strong> en caso contrario.
        /// </value>
        bool IsDmiDevice { get; }

        /// <summary>
        /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/> que representa el valor fuertemente tipado de la propiedad.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
        /// <returns>
        /// Referencia al objeto que representa el valor fuertemente tipado de la propiedad
        /// </returns>
        IDeviceProperty GetProperty(PropertyKey propertyKey);
    }
}
