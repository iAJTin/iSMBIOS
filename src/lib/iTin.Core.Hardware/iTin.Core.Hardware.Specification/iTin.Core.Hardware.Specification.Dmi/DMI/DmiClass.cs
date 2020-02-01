
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Represents a <b>DMI</b> class.
    /// </summary>
    public sealed class DmiClass
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IDmiType _dmiType;
        #endregion

        #region constructor/s

        #region [internal] DmiClass(IDmiType): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="DmiClass"/> class.
        /// </summary>
        /// <param name="dmiType">Table <see cref="DMI"/> that contains the data of the structure.</param>
        internal DmiClass(IDmiType dmiType)
        {
            _dmiType = dmiType;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (IEnumerable<IPropertyKey>) ImplementedProperties: Returns a list of implemented properties for this structure
        /// <summary>
        /// Returns a list of implemented properties for this structure
        /// </summary>
        /// <returns>
        /// A list of implemented properties for this structure.
        /// </returns>
        public IEnumerable<IPropertyKey> ImplementedProperties => _dmiType.ImplementedProperties;
        #endregion

        #region [public] (DmiClassPropertiesTable) Properties: Gets a value that represents the available properties
        /// <summary>
        /// Gets a value that represents the available properties.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public DmiClassPropertiesTable Properties => _dmiType.Properties;
        #endregion

        #endregion

        #region public methods

        #region [public] (object) GetPropertyValue(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetPropertyValue(IPropertyKey propertyKey) => Properties[propertyKey];
        #endregion

        #region [public] (T) GetPropertyValue<T>(IPropertyKey): Returns the the strongly typed value of specified property
        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public T GetPropertyValue<T>(IPropertyKey propertyKey) => (T)GetPropertyValue(propertyKey);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a String that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the available properties.
        /// </remarks> 
        public override string ToString() => $"Properties = {Properties.Count}";
        #endregion

        #endregion
    }
}
