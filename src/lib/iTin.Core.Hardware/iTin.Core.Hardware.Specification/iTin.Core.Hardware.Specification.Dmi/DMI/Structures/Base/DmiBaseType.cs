
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Diagnostics;

    using Helpers;

    using Smbios;

    /// <inheritdoc/>
    /// <summary>
    /// The <b>DmiBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="DMI"/>.
    /// </summary>
    /// <typeparam name="TSmbios">Smbios strucutre type</typeparam>
    public abstract class DmiBaseType<TSmbios> : IDmiType
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiClassPropertiesTable _smbiosPropertiesTable;
        #endregion

        #region constructor/s

        #region [protected] DmiBaseType(TSmbios, int): Initializes a new instance of the class by specifying the Header of the structure and current SMBIOS
        /// <summary>
        /// Initializes a new instance of the class <see cref="SmbiosBaseType"/> by specifying the Header of the structure and current 
        /// </summary>
        /// <param name="smbiosStructure">Header of the current structure.</param>
        /// <param name="smbiosVersion">Current SMBIOS version.</param>
        protected DmiBaseType(TSmbios smbiosStructure, int smbiosVersion)
        {
            SmbiosVersion = smbiosVersion;
            SmbiosStructure = smbiosStructure;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (IEnumerable<IPropertyKey>) ImplementedProperties: Returns a list of implemented properties for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Returns a list of implemented properties for this structure.
        /// </summary>
        /// <returns>
        /// A list of implemented properties for this structure.
        /// </returns>
        public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;
        #endregion

        #region [public] (DmiClassPropertiesTable) Properties: Gets the properties available for this structure
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
                if (_smbiosPropertiesTable != null)
                {
                    return _smbiosPropertiesTable;
                }

                _smbiosPropertiesTable = new DmiClassPropertiesTable();
                Parse(_smbiosPropertiesTable);

                return _smbiosPropertiesTable;
            }
        }
        #endregion

        #endregion

        #region protected readonly properties

        #region [protected] (int) SmbiosVersion: Gets the current version of SMBIOS
        /// <summary>
        /// Gets the current version of <see cref="SMBIOS"/>.
        /// </summary>
        /// <value>
        /// Value representing the current version of <see cref="SMBIOS"/>.
        /// </value>
        protected int SmbiosVersion { get; }
        #endregion

        #region [protected] (TSmbios) SmbiosStructure: Gets a reference to smbios structure
        /// <summary>
        /// Gets a reference to smbios structure.
        /// </summary>
        /// <value>
        /// A reference to smbios structure.
        /// </value>
        protected TSmbios SmbiosStructure { get; }
        #endregion

        #endregion

        #region public methods

        #region [public] (object) GetPropertyValue(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <inheritdoc/>
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetPropertyValue(IPropertyKey propertyKey) => Properties[propertyKey];
        #endregion

        #region [public] (TProperty) GetPropertyValue<TProperty>(IPropertyKey): Returns the the strongly typed value of specified property
        /// <inheritdoc/>
        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <b>null</b> (<b>Nothing</b> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public TProperty GetPropertyValue<TProperty>(IPropertyKey propertyKey) => (TProperty)GetPropertyValue(propertyKey);
        #endregion

        #region [public] (TSmbios) GetUnderlyingSmbiosStructure: Returns a reference to the underlying smbios structure for this dmi type
        /// <summary>
        /// Returns a reference to the underlying smbios structure for this dmi type.
        /// </summary>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public TSmbios GetUnderlyingSmbiosStructure() => SmbiosStructure;
        #endregion

        #endregion

        #region public override methods

        #region [protected] {override} (string) ToString(): Gets the property collection for this structure
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents this instance.
        /// </returns>
        public override string ToString() => $"Type = {GetType().Name}";
        #endregion

        #endregion

        #region protected methods

        #region [protected] (void) Parse(DmiClassPropertiesTable): Parse and populates the property collection for this structure
        /// <summary>
        /// Parse and populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected void Parse(DmiClassPropertiesTable properties)
        {
            SentinelHelper.ArgumentNull(properties);

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

        #region private members

        //#region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Returns a reference to an object that implements the interface IDeviceProperty, represents the value of the property specified by its key by the parameter propertyKey.
        ///// <summary>
        ///// Returns a reference to an object that implements the interface <see cref="IDeviceProperty"/>, represents the value of the property specified by its key by the parameter <paramref name="propertyKey"/>.
        ///// </summary>
        ///// <param name="propertyKey">Key to the property to obtain</param>
        ///// <returns>
        ///// Interface that represents the value of the property.
        ///// </returns>
        //private IDeviceProperty GetTypedProperty(PropertyKey propertyKey)
        //{
        //    object propertyValue = GetValueTypedProperty(propertyKey);
        //    IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

        //    return newTypedProperty;
        //}
        //#endregion

        #endregion
    }
}
