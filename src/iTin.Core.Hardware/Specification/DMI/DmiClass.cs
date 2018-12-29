
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections;
    using System.Diagnostics;
    using System.Globalization;

    using Device.DeviceProperty;
    using Smbios;

    /// <summary>
    /// Representa una clase.
    /// </summary>
    public sealed class DmiClass
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SmbiosBaseType smbiosTable;
        #endregion

        #region constructor/s

            #region [internal] DmiClass(SmbiosBaseType): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DmiClass" />.
            /// </summary>
            /// <param name="smbiosTable">Tabla <see cref="SMBIOS" /> que contiene los datos de la estructura.</param>
            internal DmiClass(SmbiosBaseType smbiosTable)
            {
                this.smbiosTable = smbiosTable;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (Hashtable) Properties: Obtiene un valor que representa las propiedades disponibles.
            /// <summary>
            /// Obtiene un valor que representa las propiedades disponibles.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="Hashtable" /></para>
            ///   <para>Propiedades disponibles.</para>
            /// </value>
            public Hashtable Properties
            {
                get { return smbiosTable.Properties; }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (Hashtable) GetTypedProperties(): Obtiene un valor que representa las propiedades disponibles.
            /// <summary>
            /// Obtiene un valor que representa las propiedades disponibles.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="Hashtable"/></para>
            ///   <para>Propiedades disponibles.</para>
            /// </returns>
            public Hashtable GetAllProperties()
            {
                return smbiosTable.Properties;
            }
            #endregion

            #region [public] (IDeviceProperty) GetProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty" />, representa el valor fuertemente tipado de la propiedad.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
            /// <returns>Referencia al objeto que representa el valor fuertemente tipado de la propiedad</returns>
            public IDeviceProperty GetProperty(PropertyKey propertyKey)
            {
                return smbiosTable.GetProperty(propertyKey);
            }
            #endregion

        #endregion

        #region public override methods

            #region [public] {override} (String) ToString: Devuelve una cadena que representa al objeto actual.
            /// <summary>
            /// Devuelve una cadena que representa al objeto <see cref="DmiClass" /> actual.
            /// </summary>
            /// <returns>
            ///   <para>Tipo: <see cref="T:System.String" /></para>
            ///   <para>Cadena que representa al objeto <see cref="DmiClass"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// El método <see cref="DmiClass.ToString()" /> devuelve una cadena que incluye el número de propiedades disponibles.
            /// </remarks>   
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Properties = {0}", Properties.Count);
            }
            #endregion

        #endregion
    }
}
