
namespace iTin.Core.Hardware.Specification
{
    using System.Diagnostics;

    using Dmi;

    /// <summary>
    /// The Desktop Management Interface (DMI) or the desktop management interface, standard framework for management and
    /// component tracking on a desktop, laptop or server.
    /// </summary>
    public sealed class DMI
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiStructureCollection dmiStructureCollection;
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

        #endregion

        #region public static readonly properties

        #region [public] {static} (string) AccessType: Gets a string that represents the type of access
        /// <summary>
        /// Gets a <see cref="T:System.String"/> that represents the type of access.
        /// </summary>
        /// <value>
        /// A string that represents the type of access.
        /// </value>
        /// <remarks>
        /// This method always returns the <b>System BIOS</b> string.
        /// </remarks>       
        public static string AccessType => "System BIOS";
        #endregion

        #region [public] {static} (string) Identificationmethod: Gets a string that represents access mode
        /// <summary>
        /// Gets a <see cref="T:System.String"/> that represents access mode.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.String"/> that represents the mode of access.
        /// </value>
        /// <remarks>
        /// This method always returns the <b>&lt;DMI&gt;</b> string.
        /// </remarks>       
        public static string Identificationmethod => "<DMI>";
        #endregion

        #region [public] {static} (DMI) Instance: Gets a unique instance of this class
        /// <summary>
        /// Gets a unique instance of this class.
        /// </summary>
        /// <value>
        /// A unique <see cref="DMI"/> reference that contains <b>DMI</b> information.
        /// </value>
        public static readonly DMI Instance = new DMI();
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DmiStructureCollection) Structures: Gets the collection of available structure
        /// <summary>
        /// Gets the collection of available structures.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiStructureCollection" /> that contains the collection of available <see cref="DmiStructure" /> objects.
        /// If there is no object <see cref="DmiStructure" />, <b>null</b> is returned.
        /// </value>
        public DmiStructureCollection Structures => dmiStructureCollection ?? (dmiStructureCollection = new DmiStructureCollection());
        #endregion

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
