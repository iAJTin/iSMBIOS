
namespace iTin.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Represents a structure <see cref="DMI"/>.
    /// </summary>
    public sealed class DmiStructure
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiClassCollection _elementsCollection;
        #endregion

        #region constructor/s

        #region [internal] DmiStructure(DmiStructureClass, SMBIOS): Initialize a new instance of the class DmiStructure
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiStructure"/>.
        /// </summary>
        /// <param name="class">Structure.</param>
        /// <param name="context">a <see cref="SMBIOS"/> reference.</param>
        internal DmiStructure(DmiStructureClass @class, SMBIOS context)
        {
            Class = @class;
            Context = context;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DmiStructureClass) Class: Gets a value that represents the class implemented
        /// <summary>
        /// Gets a value that represents the class implemented.
        /// </summary>
        /// <value>
        /// One of the values of the enumeration <see cref="DmiStructureClass"/> that represents the implemented class.
        /// </value>
        public DmiStructureClass Class { get; }
        #endregion

        #region [public] (DmiClassCollection) Elements: Gets the collection of available items
        /// <summary>
        /// Gets the collection of available items.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiClassCollection"/> that contains the collection of <see cref="DmiClass"/> objects available.
        /// If there is no object <see cref="DmiClass"/>, <b>null</b> is returned.
        /// </value>
        public DmiClassCollection Elements => _elementsCollection ?? (_elementsCollection = new DmiClassCollection(this));
        #endregion

        #region [public] (string) FriendlyClassName: Gets a value that represents the structure friendly name
        /// <summary>
        /// Gets a value that represents the structure friendly name.
        /// </summary>
        /// <returns>
        /// The structure friendly name
        /// </returns>
        public string FriendlyClassName => Class.GetPropertyName();
        #endregion

        #endregion

        #region internal readonly properties

        #region [internal] (SMBIOS) Context: Gets a value that represents the reference context
        /// <summary>
        /// Gets a value that represents the <see cref="SMBIOS"/> reference context.
        /// </summary>
        /// <value>
        /// A <see cref="SMBIOS"/> reference context.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal SMBIOS Context { get; }
        #endregion

        #endregion

        #region public methods

        #region [public] (string) GetStructureDescrition(): Returns the structure description
        /// <summary>
        /// Returns the structure description.
        /// </summary>
        /// <returns>
        /// The structure description.
        /// </returns>
        public string GetStructureDescrition() => Class.GetPropertyDescription();
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Returns a String that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that represents this instance.
        /// </remarks> 
        public override string ToString() => $"Class = {Class}";
        #endregion

        #endregion
    }
}
