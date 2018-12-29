
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    /// <summary>
    /// Define las propiedades usadas por una <b>DeviceProperty</b>.
    /// </summary>
    public interface IDeviceProperty
    {
        /// <summary>
        /// Obtiene la clave que identifica la propiedad.
        /// </summary>
        PropertyKey PropertyKey { get; }

        /// <summary>
        /// Obtiene un valor que representa la descripción de la propiedad.
        /// </summary>
        DevicePropertyDescription Description { get; }

        /// <summary>
        /// Obtiene un valor que indica si la propiedad tiene valor disponible.
        /// </summary>             
        bool HasValue { get; }
    }
}