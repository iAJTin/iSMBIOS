
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Hardware.Common;
    using iTin.Core.Helpers;

    /// <summary>
    /// The <b>SmbiosBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="DMI"/>.
    /// </summary>
    public abstract class SpecificDmiBaseType
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiClassPropertiesTable _dmiPropertiesTable;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _data;
        #endregion

        #region constructor/s

        #region [protected] SpecificDmiBaseType(): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the class <see cref="SpecificDmiBaseType"/>.
        /// </summary>
        protected SpecificDmiBaseType()
        {
        }
        #endregion

        #region [protected] SpecificDmiBaseType(byte[]): Initializes a new instance of the class by specifying the raw data of a specific SMBIOS structure
        /// <summary>
        /// Initializes a new instance of the class <see cref="SpecificDmiBaseType"/> by specifying the raw data of a specific <b>SMBIOS</b> structure
        /// </summary>
        /// <param name="data">Raw data.</param>
        protected SpecificDmiBaseType(byte[] data)
        {
            _data = data;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (IEnumerable<IPropertyKey>) ImplementedProperties: Returns a list of implemented properties for this smbios structure
        /// <summary>
        /// Returns a list of implemented properties for this smbios structure.
        /// </summary>
        /// <returns>
        /// A list of implemented properties for this structure.
        /// </returns>
        public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;
        #endregion

        #region [public] (SmbiosPropertiesTable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        public DmiClassPropertiesTable Properties
        {
            get
            {
                if (_dmiPropertiesTable != null)
                {
                    return _dmiPropertiesTable;
                }

                _dmiPropertiesTable = new DmiClassPropertiesTable();
                Parse(_dmiPropertiesTable);

                return _dmiPropertiesTable;
            }
        }
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
        public object GetPropertyValue(IPropertyKey propertyKey) => Properties.ContainsKey(propertyKey) ? Properties[propertyKey] : null;
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

        #region protected methods

        #region [protected] (byte) GetByte(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="target">target byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected byte GetByte(byte target) => _data[target];
        #endregion

        #region [protected] (byte) GetBytes(byte, byte): Returns the stored array from start with specified lenght
        /// <summary>
        /// Returns the stored array from start with specified lenght.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <param name="lenght">lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        protected byte[] GetBytes(byte start, byte lenght)
        {
            var bytes = new Collection<byte>();
            for (byte i = start; i <= lenght; i++)
            {
                bytes.Add(_data[i]);
            }

            return bytes.ToArray();

        }
        #endregion

        #region [protected] (int) GetWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected int GetWord(byte start) => _data.GetWord(start);
        #endregion

        #region [protected] (int) GetDoubleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected int GetDoubleWord(byte start) => _data.GetDoubleWord(start);
        #endregion

        #region [protected] (long) GetQuadrupleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected long GetQuadrupleWord(byte start) => _data.GetQuadrupleWord(start);
        #endregion

        #region [protected] (void) Parse(DmiClassPropertiesTable): Parse and populates the property collection for this structure
        /// <summary>
        /// Parse and populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected void Parse(DmiClassPropertiesTable properties)
        {
            SentinelHelper.ArgumentNull(properties, nameof(properties));

            PopulateProperties(properties);
        }
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected virtual void PopulateProperties(DmiClassPropertiesTable properties)
        {
        }
        #endregion

        #endregion
    }
}
