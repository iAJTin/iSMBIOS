
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core.Hardware.Common;

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

        #region [public] (DmiStructureVersion) ImplementedVersion: Returns a value that indicates the implemented version of this DMI structure
        /// <summary>
        /// Returns a value that indicates the implemented version of this <see cref="DMI"/> structure.
        /// </summary>
        /// <returns>
        /// One of the values of the <see cref="DmiStructureVersion"/> enumeration.
        /// </returns>
        public DmiStructureVersion ImplementedVersion => _dmiType.ImplementedVersion;
        #endregion

        #endregion

        #region internal properties

        #region [internal] (DmiClassPropertiesTable) Properties: Gets a value that represents the available properties
        /// <summary>
        /// Gets a value that represents the available properties.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        internal DmiClassPropertiesTable Properties => _dmiType.Properties;
        #endregion

        #endregion

        #region public methods

        #region [public] (QueryPropertyResult) GetProperty(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// <para>
        /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
        /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
        /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
        /// </para>
        /// <para>
        /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>. Contains the result of the operation.
        /// </para>
        /// <para>
        /// </para>
        /// </returns>
        public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
        {
            object result = Properties[propertyKey];
            if (!(result is List<PropertyItem> itemList))
            {
                return QueryPropertyResult.CreateErroResult("Can not found specified property key");
            }

            bool hasItems = itemList.Any();
            if (!hasItems)
            {
                return QueryPropertyResult.CreateErroResult("Can not found specified property key");
            }

            bool onlyOneItem = itemList.Count == 1;
            if (onlyOneItem)
            {
                return QueryPropertyResult.CreateSuccessResult(itemList.FirstOrDefault());
            }

            return QueryPropertyResult.CreateErroResult("Can not found specified property key");
        }
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
