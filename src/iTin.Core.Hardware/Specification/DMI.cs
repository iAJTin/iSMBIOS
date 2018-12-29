
namespace iTin.Core.Hardware.Specification
{
    using System.Diagnostics;
    using System.Globalization;

    using Dmi;

    /// <summary>
    /// The Desktop Management Interface (DMI) ó La interfaz de administración de escritorio, marco estándar para la gestión y
    /// seguimiento de componentes en un ordenador de sobremesa, portátil o servidor.
    /// </summary>
    public sealed class DMI 
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiStructureCollection dmiStructureCollection;
        #endregion

        #region public static members
        /// <summary>
        /// Gets a unique instance of this class.
        /// </summary>
        public static readonly DMI Instance = new DMI();
        #endregion

        #region constructor/s

        #region [private] DMI(): Prevents a default instance of this class from being created.
        /// <summary>
        /// Prevents a default instance of the <see cref="DMI"/> class from being created.
        /// </summary>
        private DMI()
        {
        }
        #endregion

        #endregion

        #region public properties
        /// <summary>
        /// Obtiene la colección de estructuras disponibles.
        /// </summary>
        /// <value>
        /// Objeto <see cref="DmiStructureCollection"/> que contiene la colección de objetos <see cref="DmiStructure"/> disponibles.
        /// Si no existe ningún objeto <see cref="DmiStructure"/>, se devuelve <b>null</b>.
        /// </value>
        public DmiStructureCollection Structures => dmiStructureCollection ?? (dmiStructureCollection = new DmiStructureCollection());
        #endregion

        #region public static methods
        /// <summary>
        /// Obtiene una cadena que representa el tipo de acceso.
        /// </summary>
        /// <value>
        /// Una cadena que representa el tipo de acceso.
        /// </value>
        /// <remarks>
        ///Este método devuelve siempre la cadena <b>System BIOS</b>.
        /// </remarks>       
        public static string AccessType => "System BIOS";

        /// <summary>
        /// Obtiene una cadena que representa modo del acceso.
        /// </summary>
        /// <value>
        /// Una cadena que representa el modo del acceso.
        /// </value>
        /// <remarks>
        ///Este método devuelve siempre la cadena <b>DMI</b>.
        /// </remarks>       
        public static string Identificationmethod => "<DMI>";
        #endregion

        #region public overrides methods

        #region [public] {override} (string) ToString(): Returns aString that represents this instance.
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="T:SMBIOS.ToString ()" /> method returns a string that includes the version expresed in hexadecimal format,
        /// the number of available structures, and <see cref="SMBIOS"/> total size occupied by all structures.
        /// </remarks>
        public override string ToString()
        {
            return
                string.Format(
                    CultureInfo.InvariantCulture,
                    "SMBIOS={0}, Classes={1}, Size={2}",
                    DmiHelper.Smbios.Version.ToString("x", CultureInfo.InvariantCulture),
                    DmiHelper.Smbios.ImplementedStructures.Count,
                    DmiHelper.Smbios.Lenght);
        }
        #endregion

        #endregion
    }
}
