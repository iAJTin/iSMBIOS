
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    using Smbios;

    /// <summary>
    /// Representa a una estructura <see cref="DMI"/>.
    /// </summary>
    public sealed class DmiStructure
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiClassCollection elementsCollection;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SmbiosStructure smbiosStructure;
        #endregion

        #region constructor/s

        #region [internal] DmiStructure(SmbiosStructure): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DmiStructure"/>.
        /// </summary>
        /// <param name="smbiosStructure">Estructura.</param>
        internal DmiStructure(SmbiosStructure smbiosStructure)
        {
            this.smbiosStructure = smbiosStructure;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (SmbiosStructure) Class: Obtiene un valor que representa la clase implementada.
        /// <summary>
        /// Obtiene un valor que representa la clase implementada.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="SmbiosStructure"/></para>
        /// 	<para>Uno de los valores de la enumeración <see cref="SmbiosStructure"/> que representa la clase implementada.</para>
        /// </value>
        public SmbiosStructure Class
        {
            get { return smbiosStructure; }
        }
        #endregion

        #region [public] (DmiClassCollection) Elements: Obtiene la colección de elementos disponibles.
        /// <summary>
        /// Obtiene la colección de elementos disponibles.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="DmiClassCollection"/></para>
        /// 	<para>
        ///         Objeto <see cref="DmiClassCollection"/> que contiene la colección de objetos <see cref="DmiClass"/> disponibles.
        ///         Si no existe ningún objeto <see cref="DmiClass"/>, se devuelve <b>null</b>.
        ///     </para>
        /// </value>
        public DmiClassCollection Elements
        {
            get { return elementsCollection ?? (elementsCollection = new DmiClassCollection(this)); }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Devuelve una cadena que representa al objeto actual.
        /// <summary>
        /// Devuelve una cadena que representa al objeto <see cref="DmiStructure"/> actual.
        /// </summary>
        /// <returns>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Cadena que representa al objeto <see cref="DmiStructure"/> actual.</para>
        /// </returns>
        /// <remarks>
        /// El método <see cref="DmiStructure.ToString()"/> devuelve una cadena que incluye la clase.
        /// </remarks>   
        public override string ToString()
        {
            return string.Concat("Class = ", Class);
        }
        #endregion

        #endregion
    }
}
