
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    using Smbios;

    /// <summary>
    /// Represents a structure <see cref="DMI" />.
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

        #region [internal] DmiStructure(SmbiosStructure): Initialize a new instance of the class DmiStructure
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiStructure" />.
        /// </summary>
        /// <param name="smbiosStructure">Estructura.</param>
        internal DmiStructure(SmbiosStructure smbiosStructure)
        {
            this.smbiosStructure = smbiosStructure;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (SmbiosStructure) Class: Gets a value that represents the class implemented
        /// <summary>
        /// Gets a value that represents the class implemented.
        /// </summary>
        /// <value>
        /// One of the values of the enumeration <see cref="SmbiosStructure" /> that represents the implemented class.
        /// </value>
        public SmbiosStructure Class => smbiosStructure;
        #endregion

        #region [public] (DmiClassCollection) Elements: Gets the collection of available items
        /// <summary>
        /// Gets the collection of available items.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiClassCollection" /> that contains the collection of <see cref="DmiClass" /> objects available.
        /// If there is no object <see cref="DmiClass" />, <b>null</b> is returned.
        /// </value>
        public DmiClassCollection Elements => elementsCollection ?? (elementsCollection = new DmiClassCollection(this));
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Returns a String that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that represents this instance.
        /// </remarks> 
        public override string ToString() => $"Class = {Class}";
        #endregion

        #endregion
    }
}
