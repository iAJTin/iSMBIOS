
namespace iTin.Core.Hardware.Device
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    using DeviceProperty;
    using Helpers;
    using Specification.Dmi;
    using Specification.Smbios;

    using Microsoft.Win32;

    #region [private] {abstract} (class) TypedDeviceInfoBase: La clase abstract TypedDeviceInfoBase proporciona funciones para recuperar las propiedades asociadas con dispositivo via API
    /// <summary>
    /// Define el contenido de un tipo de estructura.
    /// </summary>
    abstract class TypedDeviceInfoBase : IDeviceInfo
    {                
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable content;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<string> registryEntryKeysCollection;
        #endregion

        #region public properties

            #region [public] (bool) IsDmiDevice: Obtiene un valor que indica si el dispositivo es de tipo DMI.
            /// <summary>
            /// Obtiene un valor que indica si es un dispositivo de tipo <see cref="iTin.Core.Hardware.Specification.DMI"/>.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para><strong>true</strong> si es un dispositivo <see cref="iTin.Core.Hardware.Specification.DMI"/> ; <strong>false</strong> en caso contrario.</para>
            /// </value>
            public bool IsDmiDevice
            {
                get { return IsDmiDeviceType; }
            }
            #endregion

        #endregion

        #region protected virtual properties

            #region [protected] {virtual} (bool) CanUseRegistry: Obtiene un valor que indica si se va a usar el registro para recuperar las propiedades.
            /// <summary>
            /// Obtiene un valor que indica si se va a usar el registro para recuperar las propiedades.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para><strong>true</strong> si se va utilizar el registro para recuperar las propiedades; <strong>false</strong> en caso contrario.</para>
            /// </value>
            protected virtual bool CanUseRegistry
            {
                get { return true; }
            }
            #endregion

            #region [protected] {virtual} (DmiClass) DmiDataProvider: Obtiene un valor que representa la clase DMI que suministra las propiedades.
            /// <summary>
            /// Obtiene un valor que representa la clase DMI que suministra las propiedades.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="DmiClass"/></para>
            /// 	<para>Objeto <see cref="DmiClass"/> que hace de proveedor de propiedades para el dispositivo.</para>
            /// </value>
            protected virtual DmiClass DmiDataProvider
            {
                get { return null; }
            }
            #endregion

            #region [protected] {virtual} (bool) IsDmiDeviceType: Obtiene un valor que indica si el dispositivo es de tipo DMI.
            /// <summary>
            /// Obtiene un valor que indica si es un dispositivo de tipo <see cref="iTin.Core.Hardware.Specification.DMI"/>.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para><strong>true</strong> si es un dispositivo de tipo <see cref="iTin.Core.Hardware.Specification.DMI"/>; <strong>false</strong> en caso contrario.</para>
            /// </value>
            protected virtual bool IsDmiDeviceType
            {
                get { return false; }
            }
            #endregion

        #endregion

        #region private properties

            #region [private] (Hashtable) Content: Obtiene las propiedades disponibles para este dispositivo.
            /// <summary>
            /// Obtiene las propiedades disponibles para este dispositivo.
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="T:System.Collections.Hashtable"/></para>
            /// 	<para>Propiedades disponibles.</para>
            /// </value>
            private Hashtable Content
            {
                get { return content ?? (content = new Hashtable()); }
            }
        #endregion

        #endregion

        #region public methods

            #region [public] (IDeviceProperty) GetProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
            /// <returns>Referencia al objeto que representa el valor fuertemente tipado de la propiedad</returns>
            public IDeviceProperty GetProperty<T>(PropertyKey propertyKey)
            {
                if (CanUseRegistry)
                {
                    var registryKey = GetRegistryKeyDeviceBranch();
                    if (registryKey != null)
                    {
                        if (!Content.Contains(propertyKey))
                        {
                            Content.Add(
                                propertyKey,
                                !IsDmiDevice
                                    ? GetTypedProperty(propertyKey, registryKey)
                                    : DmiDataProvider.GetProperty(propertyKey));
                        }
                    }
                }
                else
                {
                    if (!Content.Contains(propertyKey))
                    {
                        Content.Add(
                                propertyKey,
                                !IsDmiDevice 
                                    ? GetTypedProperty(propertyKey) 
                                    : DmiDataProvider.GetProperty(propertyKey));
                    }
                }

                return (IDeviceProperty)Content[propertyKey];
            }
            #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (RegistryKey) GetRegistryKeyDeviceBranch(): Obtiene la clave del registro que corresponde a este dispositivo.
        /// <summary>
        /// Obtiene la clave del registro que corresponde a este dispositivo.
        /// </summary>
        /// <returns>Clave del registro que corresponde a este dispositivo.</returns>
        protected virtual RegistryKey GetRegistryKeyDeviceBranch()
            {
                return null;
            }
            #endregion

            #region [protected] {virtual} (object) GetValueTypedProperty(PropertyKey, RegistryKey): Obtiene un valor que representa el valor de la propiedad especificada.
            /// <summary>
            /// Obtiene un valor que representa el valor de la propiedad especificada.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            /// <param name="registryKey">Clave del registro desde donde recuperar la información.</param>
            /// <returns>
            /// Objeto que representa el valor de la propiedad.
            /// </returns>
            protected virtual object GetValueTypedProperty(PropertyKey propertyKey, RegistryKey registryKey)
            {
                return null;
            }
            #endregion

            #region [protected] {virtual} (IDeviceProperty) GetValueTypedDmiProperty(PropertyKey, RegistryKey): Obtiene un valor que representa el valor de la propiedad especificada.
            /// <summary>
            /// Obtiene un valor que representa el valor de la propiedad especificada para un dispositivo DMI.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            /// <param name="registryKey">Clave del registro desde donde recuperar la información.</param>
            /// <returns>
            /// Objeto que representa el valor de la propiedad.
            /// </returns>
            protected virtual IDeviceProperty GetValueTypedDmiProperty(PropertyKey propertyKey, RegistryKey registryKey)
            {
                return null;
            }
            #endregion

        #endregion

        #region internal static methods

        #region [internal] (T) GetTypedRegistryValue<T>(string, RegistryKey): Obtiene un valor fuertemenente tipado que representa al valor de la clave del registro especificada.
        /// <summary>
        /// Obtiene un valor fuertemenente tipado que representa al valor de la clave del registro especificada.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entryKey">Entrada que contiene el valor a recuperar.</param>
        /// <param name="registryKey">Clave del registro que contiene la entrada a recuperar.</param>
        /// <returns>
        /// Valor fuertemente tipado que corresponde al valor de la entrada especificada.
        /// </returns>
        internal T GetTypedRegistryValue<T>(string entryKey, RegistryKey registryKey)
        {
            var existKey = registryEntryKeysCollection.Contains(entryKey);
            if (!existKey)
            {
                return default(T);
            }

            object typedResult;
            var keyValue = registryKey.GetValue(entryKey);

            RegistryValueKind valueKind = registryKey.GetValueKind(entryKey);
            switch (valueKind)
            {
                case RegistryValueKind.Binary:
                    var keyValueArray = (byte[])keyValue;

                    if (typeof(T) == typeof(int?))
                    {
                        typedResult = LogicHelper.ADWord(keyValueArray, 0);
                    }
                    else
                    {
                        typedResult = Encoding.Unicode.GetString(keyValueArray, 0, (keyValueArray).Length - 2);
                    }                    
                    break;

                default:
                    typedResult = keyValue;
                    break;
            }

            return (T)typedResult;
        }
        #endregion

        #endregion

        #region private methods

            #region [private] (IDeviceProperty) GetTypedProperty(PropertyKey, RegistryKey = null): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor de la propiedad especificada mediante su clave por el parámetro propertyKey.
            /// <summary>
            /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/>, representa el valor de la propiedad especificada mediante su clave por el parámetro <c>propertyKey</c>.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            /// <param name="registryKey">Clave del registro desde donde recuperar la información.</param>
            /// <returns>
            /// Interfaz que representa el valor de la propiedad.
            /// </returns>
            private IDeviceProperty GetTypedProperty(PropertyKey propertyKey, RegistryKey registryKey = null)
            {
                if (registryKey != null)
                {
                    if (registryEntryKeysCollection == null)
                    {
                        string[] keyNamesArray = registryKey.GetValueNames();
                        registryEntryKeysCollection = new List<string>(keyNamesArray);
                    }
                }

                object propertyValue = GetValueTypedProperty(propertyKey, registryKey);
                IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

                return newTypedProperty;
            }
            #endregion

        #endregion
    }
    #endregion


    #region [private] {sealed} (class) TypedDeviceDmiInfo: Especialización de la clase TypedDeviceInfo que proporciona el conjunto de propiedades disponibles para un escritorio de este sistema
    /// <summary>
    /// Especialización de la clase <see cref="TypedDeviceDmiInfo"/> que proporciona el conjunto de propiedades disponibles para un escritorio de este sistema.
    /// </summary>
    sealed class TypedDeviceDmiInfo : TypedDeviceInfoBase
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DmiDeviceInfo _nativeDeviceData;
        #endregion

        #region constructor/s

        #region [public] TypedDeviceDmiInfo(DmiDeviceInfo): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="TypedDeviceDmiInfo"/>.
        /// </summary>
        /// <param name="nativeDeviceData">Estructura <see cref="DmiDeviceInfo"/> con la información nativa del dispositivo.</param>
        public TypedDeviceDmiInfo(DmiDeviceInfo nativeDeviceData) => _nativeDeviceData = nativeDeviceData;
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (SmbiosStructure) Structure: Obtiene un valor que representa la clase DMI
        /// <summary>
        /// Obtiene un valor que representa la clase <see cref="iTin.Core.Hardware.Specification.DMI"/>.
        /// </summary>
        /// <value>
        /// Uno de los valores de la enumeración <see cref="SmbiosStructure"/> que representa la clase <see cref="iTin.Core.Hardware.Specification.DMI"/>.
        /// </value>
        public SmbiosStructure Structure => _nativeDeviceData.Structure;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual
        /// <summary>
        /// Devuelve una cadena que representa la clase actual.
        /// </summary>
        /// <returns>
        /// Una cadena que representa la clase <see cref="TypedDeviceDmiInfo"/> actual.
        /// </returns>
        /// <remarks>
        /// El método <see cref="TypedDeviceDmiInfo.ToString()"/> devuelve una cadena que identifica a este dispositivo.
        /// </remarks>
        public override string ToString() => _nativeDeviceData.ToString();
        #endregion

        #endregion

        #region protected override readonly properties

        #region [protected] {override} (bool) CanUseRegistry: Obtiene la clave del registro que corresponde a este dispositivo.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene un valor que indica si se va a usar el registro para recuperar las propiedades.
        /// </summary>
        /// <value>
        /// <strong>true</strong> si se va utilizar el registro para recuperar las propiedades; <strong>false</strong> en caso contrario.
        /// </value>
        protected override bool CanUseRegistry => false;
        #endregion

        #region [protected] {override} (bool) DmiDataProvider: Obtiene la clave del registro que corresponde a este dispositivo.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene un valor que representa la clase DMI que suministra las propiedades.
        /// </summary>
        /// <value>
        /// Objeto <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiClass" /> que hace de proveedor de propiedades para el dispositivo.
        /// </value>
        protected override DmiClass DmiDataProvider => _nativeDeviceData.Class;
        #endregion

        #region [protected] {override} (bool) IsDmiDeviceType: Obtiene un valor que indica si es un dispositivo de tipo DMI.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene un valor que indica si es un dispositivo de tipo DMI.
        /// </summary>
        /// <value>
        /// <strong>true</strong> si es un dispositivo DMI; <strong>false</strong> en caso contrario.
        /// </value>
        protected override bool IsDmiDeviceType => true;
        #endregion

        #endregion

        #region internal methods

        #region [internal] (DmiDeviceInfo) GetNativeDeviceData: Recupera la información DMI para este dispositivo.
        /// <summary>
        /// Recupera la información <see cref="iTin.Core.Hardware.Specification.DMI"/> para este dispositivo.
        /// </summary>
        /// <returns>
        /// Estructura <see cref="DmiDeviceInfo"/> que contiene la información <see cref="iTin.Core.Hardware.Specification.DMI"/> para este dispositivo de memoria.
        /// </returns> 
        internal DmiDeviceInfo GetNativeDeviceData() => _nativeDeviceData;
        #endregion

        #endregion
    }
    #endregion
}
