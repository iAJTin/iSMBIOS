
using System;

namespace iTin.Core.Hardware.Specification
{
    using System.Diagnostics;

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

        #region [private] DMI(): Prevents a default instance of this class from being created
        /// <summary>
        /// Prevents a default instance of the <see cref="DMI"/> class from being created.
        /// </summary>
        private DMI()
        {
        }
        #endregion

        private DMI(byte[] data)
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DmiStructureCollection Parse(byte[] data)
        {
            //var dmi = new DMI(data);
            //new DmiStructureCollection(dmi);
            return new DmiStructureCollection();
        }

        #region public properties
        /// <summary>
        /// Gets the collection of available structures.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiStructureCollection" /> that contains the collection of available <see cref="DmiStructure" /> objects.
        /// If there is no object <see cref="DmiStructure" />, <b>null</b> is returned.
        /// </value>
        public DmiStructureCollection Structures => dmiStructureCollection ?? (dmiStructureCollection = new DmiStructureCollection());
        #endregion

        #region public static methods
        /// <summary>
        /// Gets a string that represents the type of access.
        /// </summary>
        /// <value>
        /// A string that represents the type of access.
        /// </value>
        /// <remarks>
        /// This method always returns the <b>System BIOS</b> string.
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
        public override string ToString() => $"SMBIOS={DmiHelper.Smbios.Version:X}, Classes={DmiHelper.Smbios.ImplementedStructures.Count}, Size={DmiHelper.Smbios.Lenght}";
        #endregion

        #endregion
    }
}
