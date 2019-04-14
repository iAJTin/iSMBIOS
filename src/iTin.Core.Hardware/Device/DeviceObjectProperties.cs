
namespace iTin.Core.Hardware.Device
{
    using Helpers;

    public abstract class DeviceObjectProperties : DeviceObjectPropertiesBase
    {
        #region constructor/s

        #region [protected] DeviceObjectProperties(DeviceObject): Inicializa una nueva instancia de la clase
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Device.DeviceObjectProperties" />.
        /// </summary>
        /// <param name="owner"><see cref="T:iTin.Core.Hardware.Device.DeviceObject" /> que contiene estas propiedades.</param>
        protected DeviceObjectProperties(DeviceObject owner) : base(SentinelHelper.PassThroughNonNull(owner).GetTypedDeviceData())
        {
            Device = owner;
        }
        #endregion

        #endregion

        #region protected methods

        #region [protected] (DeviceObject) Device: Obtiene una referencia al dispositivo que contiene estas propiedades
        /// <summary>
        /// Obtiene una referencia al dispositivo que contiene estas propiedades.
        /// </summary>
        /// <value>
        /// Referencia al dispositivo que contiene estas propiedades.
        /// </value>
        protected DeviceObject Device { get; }
        #endregion

        #endregion
    }
}
