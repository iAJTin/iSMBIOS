
namespace iTin.Core.Hardware.Device
{
    using System;
    using System.Diagnostics;

    using Specification.Dmi;
    using Specification.Smbios;

    /// <summary>
    /// Defines content of a <c>DMI</c> structure.
    /// </summary>
    struct DmiDeviceInfo : IEquatable<DmiDeviceInfo>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int _index;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DmiClass _dmiClass;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SmbiosStructure _structure;
        #endregion

        #region constructor/s

        #region [public] DmiDeviceInfo(SmbiosStructure, DmiClass, int): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="DmiDeviceInfo"/>.
        /// </summary>
        /// <param name="structure">Estructura <see cref="iTin.Core.Hardware.Specification.SMBIOS"/>.</param>
        /// <param name="dmiClass">Clase.</param>
        /// <param name="index">Índice de la clase.</param>
        public DmiDeviceInfo(SmbiosStructure structure, DmiClass dmiClass, int index)
        {
            _index = index;
            _dmiClass = dmiClass;
            _structure = structure;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (int) Index:
        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <value>The index.</value>
        public int Index
        {
            get { return _index; }
        }
        #endregion

        #region [public] (SmbiosStructure) Structure:
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public SmbiosStructure Structure
        {
            get { return _structure; }
        }
        #endregion

        #region [public] (DmiClass) Class:
        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public DmiClass Class
        {
            get { return _dmiClass; }
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(DmiDeviceInfo): Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// <summary>
        /// Indica si la estructura actual es igual a otra estructura del mismo tipo.
        /// </summary>
        /// <param name="other">Estructura que se va a comparar con esta.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si las estructuras son iguales; en caso contrario, <strong>false</strong>.
        /// </returns>
            public bool Equals(DmiDeviceInfo other)
        {
            return other.Equals((object)this);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Devuelve un valor que repesenta al código hash de esta estructura.
        /// <summary>
        /// Devuelve un valor que repesenta al código hash de esta estructura.
        /// </summary>
        /// <returns>
        /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
        /// 	<para>Código Hash de esta estructura.</para>
        /// </returns>
        public override int GetHashCode()
        {
            return Structure.GetHashCode() ^ Index;
        }
        #endregion

        #region [public] {override} (bool) Equals(object obj): Devuelve un valor que indica si esta estructutra es igual a otra.
        /// <summary>
        /// Devuelve un valor que indica si esta estructutra es igual a otra.
        /// </summary>
        /// <param name="obj">Estructura con la que comparar.</param>
        /// <returns>Resultado de la comparación de igualdad.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is DmiDeviceInfo))
                return false;

            DmiDeviceInfo other = (DmiDeviceInfo)obj;
            return (other.Structure == Structure);// &&
            //(other.Properties.Count == Properties.Count);
        }
        #endregion

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
        /// <summary>
        /// Devuelve una cadena que representa la estructura <see cref="DmiDeviceInfo"/> actual.
        /// </summary>
        /// <returns>
        /// 	<para>Tipo: <see cref="T:System.String"/></para>
        /// 	<para>Cadena que representa la estructura <see cref="DmiDeviceInfo"/> actual.</para>
        /// </returns>
        /// <remarks>
        /// El método <see cref="DmiDeviceInfo.ToString()"/> devuelve una cadena que incluye el tipo de estructura.
        /// </remarks>      
        public override string ToString() => $"Structure = {Structure}, Properties = {1000}, Index = {Index}";
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(DmiDeviceInfo, DmiDeviceInfo): Implementa el operador de igualdad (==).
        /// <summary>
        /// Implementa el operador de igualdad (==).
        /// </summary>
        /// <param name="deviceInfo1">Operando 1.</param>
        /// <param name="deviceInfo2">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
            public static bool operator ==(DmiDeviceInfo deviceInfo1, DmiDeviceInfo deviceInfo2)
        {
            return deviceInfo1.Equals(deviceInfo2);
        }
        #endregion

        #region [public] {static} (bool) operator !=(DmiDeviceInfo, DmiDeviceInfo): Implementa el operador de desigualdad (!=).
        /// <summary>
        /// Implementa el operador de desigualdad (!=).
        /// </summary>
        /// <param name="deviceInfo1">Operando 1.</param>
        /// <param name="deviceInfo2">Operando 2.</param>
        /// <returns>
        /// Devuelve <strong>true</strong> si <c>deviceInfo1</c> no es igual a <c>deviceInfo2</c>; <strong>false</strong> en caso contrario.
        /// </returns>
        public static bool operator !=(DmiDeviceInfo deviceInfo1, DmiDeviceInfo deviceInfo2)
        {
            return !deviceInfo1.Equals(deviceInfo2);
        }
        #endregion

        #endregion
    }
}
