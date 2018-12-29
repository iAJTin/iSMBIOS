
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Device.DeviceProperty;

    /// <summary>
    /// La clase <b>SmbiosBaseType</b> proporciona funciones para analizar las propiedades asociadas a una estructura <see cref="SMBIOS" />.
    /// </summary>
    public abstract class SmbiosBaseType
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string[] _strings;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _content;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int _smbiosVersion;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SmbiosStructureHeaderInfo _smbiosStructureHeaderInfo;
        #endregion

        #region constructor/s

        #region [protected] SmbiosBaseType(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the Header of the structure and current SMBIOS.
        /// <summary>
        /// Initializes a new instance of the class <see cref="SmbiosBaseType"/> by specifying the Header of the structure and current SMBIOS.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Header of the current structure.</param>
        /// <param name="smbiosVersion">Current SMBIOS version.</param>
        protected SmbiosBaseType(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion)
        {
            _smbiosVersion = smbiosVersion;
            _smbiosStructureHeaderInfo = smbiosStructureHeaderInfo;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (SmbiosStructureHeaderInfo) HeaderInfo: Gets the raw information from this structure.
        /// <summary>
        /// Gets the raw information from this structure.
        /// </summary>
        /// <value>
        /// A <see cref="SmbiosStructureHeaderInfo"/> object that contains the information.
        /// </value>
        public SmbiosStructureHeaderInfo HeaderInfo
        {
            get { return _smbiosStructureHeaderInfo; }
        }
        #endregion

        #region [public] (Hashtable) Properties: Gets the properties available for this structure.
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        public Hashtable Properties
        {
            get
            {
                if (_properties != null)
                {
                    return _properties;
                }

                _properties = new Hashtable();
                _strings = SmbiosHelper.ParseStrings(_smbiosStructureHeaderInfo.RawData);
                Parse(_properties);

                return _properties;
            }
        }
        #endregion

        #endregion

        #region protecetd properties

        #region [protected] (int) SmbiosVersion: Gets the current version of SMBIOS.
        /// <summary>
        /// Gets the current version of <see cref="SMBIOS" />.
        /// </summary>
        /// <value>
        /// Value representing the current version of <see cref="SMBIOS" />.
        /// </value>
        protected int SmbiosVersion
        {
            get { return _smbiosVersion; }
        }
        #endregion

        #region [protected] (ReadOnlyCollection<string>) Strings: Gets the strings associated with this structure.
        /// <summary>
        /// Gets the strings associated with this structure.
        /// </summary>
        /// <value>
        /// An read-only collection that contains the strings of this structure.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected ReadOnlyCollection<string> Strings
        {
            get { return new ReadOnlyCollection<string>(_strings); } 
        }
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (void) Parse(Hashtable): Gets the property collection for this structure.
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected virtual void Parse(Hashtable properties)
        {
        }
        #endregion

        #endregion

        #region public override methods

        #region [protected] {override} (string) ToString(): Gets the property collection for this structure.
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref="SmbiosStructureHeaderInfo.StructureType" />.
        /// </remarks> 
        public override string ToString()
        {
            return string.Concat("Type = ", HeaderInfo.StructureType); 
        }
        #endregion

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        protected byte GetByte(byte target)
        {
            return HeaderInfo.RawData[target];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        protected int GetWord(byte start)
        {
            return HeaderInfo.RawData.GetWord(start);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        protected int GetDoubleWord(byte start)
        {
            return HeaderInfo.RawData.GetDoubleWord(start);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        protected long GetQuadrupleWord(byte start)
        {
            return HeaderInfo.RawData.GetQuadrupleWord(start);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        protected string GetString(byte target)
        {
            return Strings[GetByte(target)];
        }

        #region Propiedades

        #region [public] (Hashtable) Content: Obtiene las propiedades disponibles para este dispositivo.
        /// <summary>
        /// Obtiene las propiedades disponibles para este dispositivo.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="T:System.Collections.Hashtable"/></para>
        /// 	<para>Propiedades disponibles.</para>
        /// </value>
        public Hashtable Content
            {
                get
                {
                    if (_content == null)
                    {
                        _content = new Hashtable();
                        _strings = SmbiosHelper.ParseStrings(_smbiosStructureHeaderInfo.RawData);
                    }
                    return _content;
                }
            }
            #endregion

        #endregion

        #region Métodos

            #region [public] (IDeviceProperty) GetProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
            /// <returns>Referencia al objeto que representa el valor fuertemente tipado de la propiedad</returns>
            public IDeviceProperty GetProperty(PropertyKey propertyKey)
            {
                if (!Content.Contains(propertyKey))
                    Content.Add(propertyKey, GetTypedProperty(propertyKey));

                return (IDeviceProperty)Content[propertyKey];
            }
            #endregion

        #endregion

        #region Miembros privados

            #region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor de la propiedad especificada mediante su clave por el parámetro propertyKey.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/>, representa el valor de la propiedad especificada mediante su clave por el parámetro <c>propertyKey</c>.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            /// <returns>Interfaz que representa el valor de la propiedad.</returns>
            private IDeviceProperty GetTypedProperty(PropertyKey propertyKey)
            {
                object propertyValue = GetValueTypedProperty(propertyKey);
                IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

                return newTypedProperty;
            }
            #endregion

        #endregion

        #region Miembros protected

            #region [protected] {virtual} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
            /// <summary>
            /// Obtiene un valor que representa el valor de la propiedad especificada.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            protected virtual object GetValueTypedProperty(PropertyKey propertyKey)
            {
                return null;
            }
            #endregion

        #endregion
    }
}