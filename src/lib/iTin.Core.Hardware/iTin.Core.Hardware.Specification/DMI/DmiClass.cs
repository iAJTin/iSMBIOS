
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Diagnostics;

    using Smbios;

    /// <summary>
    /// Represents a <c>DMI</c> class.
    /// </summary>
    public sealed class DmiClass
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SmbiosBaseType smbiosTable;
        #endregion

        #region constructor/s

        #region [internal] DmiClass(SmbiosBaseType): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="DmiClass" /> class.
        /// </summary>
        /// <param name="smbiosTable">Table <see cref="SMBIOS" /> that contains the data of the structure.</param>
        internal DmiClass(SmbiosBaseType smbiosTable)
        {
            this.smbiosTable = smbiosTable;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DmiClassPropertiesTable) Properties: Gets a value that represents the available properties
        /// <summary>
        /// Gets a value that represents the available properties.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public DmiClassPropertiesTable Properties
        {
            get
            {
                var dmiProperties = new DmiClassPropertiesTable();
                foreach (KeyValuePair<PropertyKey, object> property in smbiosTable.Properties)
                {
                    dmiProperties.Add(property);                    
                }

                return dmiProperties;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (object) GetProperty(PropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetProperty(PropertyKey propertyKey) => smbiosTable.Properties[propertyKey];
        #endregion

        #region [public] (T) GetProperty<T>(PropertyKey): Returns the the strongly typed value of specified property
        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public T GetProperty<T>(PropertyKey propertyKey) => (T)GetProperty(propertyKey);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a String that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the available properties.
        /// </remarks> 
        public override string ToString() => $"Properties = {Properties.Count}";
        #endregion

        #endregion
    }
}
