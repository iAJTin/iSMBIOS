
namespace iTin.Core.Hardware.Device
{
    using System.Diagnostics;

    public abstract class DeviceObject
    {
        #region private readonly properties
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly TypedDeviceInfoBase typedDeviceData;
        #endregion

        #region constructor/s

            #region [internal] DeviceObject(TypedDeviceInfoBase): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DeviceObject"/>.
            /// </summary>
            /// <param name="typedDeviceData">Información fuertemente tipada del dispositivo.</param>
            internal DeviceObject(TypedDeviceInfoBase typedDeviceData)
            {
                this.typedDeviceData = typedDeviceData;
            }
            #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
        /// <summary>
        /// Devuelve una cadena que representa la clase actual.
        /// </summary>
        /// <returns>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Cadena que representa la clase actual.</para>
        /// </returns>
        /// <remarks>
        /// Este método devuelve una cadena que contiene el nombre de este monitor.
        /// </remarks> 
        public override string ToString()
        {
            return $"Name = "; //Properties.Description.Value);
        }
        #endregion

        #endregion

        #region internal methods

            #region [internal] (TypedDeviceInfoBase) GetTypedDeviceData(): Referencia a la información fuertemente tipada de este dispositivo.
            /// <summary>
            /// Referencia a la información fuertemente tipada de este dispositivo.
            /// </summary>
            /// <returns>
            /// Información fuertemente tipada de este dispositivo.
            /// </returns>
            /// <remarks>
            /// Implementa la interfaz <see cref="IDeviceInfo"/>.
            /// </remarks>
            internal TypedDeviceInfoBase GetTypedDeviceData()
            {
                return typedDeviceData;
            }
            #endregion

        #endregion
    }
}
