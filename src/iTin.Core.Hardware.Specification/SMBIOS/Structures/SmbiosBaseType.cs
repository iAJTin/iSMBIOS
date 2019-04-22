
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// The <b>SmbiosBaseType</b> class provides functions to analyze the properties associated with a structure <see cref="SMBIOS" />.
    /// </summary>
    public abstract class SmbiosBaseType
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string[] _strings;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _content;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SmbiosPropertiesTable _SmbiosPropertiesTable;
        #endregion

        #region constructor/s

        #region [protected] SmbiosBaseType(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the Header of the structure and current SMBIOS
        /// <summary>
        /// Initializes a new instance of the class <see cref="SmbiosBaseType"/> by specifying the Header of the structure and current SMBIOS.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Header of the current structure.</param>
        /// <param name="smbiosVersion">Current SMBIOS version.</param>
        protected SmbiosBaseType(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion)
        {
            SmbiosVersion = smbiosVersion;
            HeaderInfo = smbiosStructureHeaderInfo;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (Hashtable) Content: Gets the properties available for this device
        /// <summary>
        /// Gets the properties available for this device.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public Hashtable Content
        {
            get
            {
                if (_content == null)
                {
                    _content = new Hashtable();
                    _strings = SmbiosHelper.ParseStrings(HeaderInfo.RawData);
                }

                return _content;
            }
        }
        #endregion

        #region [public] (SmbiosStructureHeaderInfo) HeaderInfo: Gets the raw information from this structure
        /// <summary>
        /// Gets the raw information from this structure.
        /// </summary>
        /// <value>
        /// A <see cref="SmbiosStructureHeaderInfo"/> object that contains the information.
        /// </value>
        public SmbiosStructureHeaderInfo HeaderInfo { get; }
        #endregion

        #region [public] (SmbiosPropertiesTable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        public SmbiosPropertiesTable Properties
        {
            get
            {
                if (_SmbiosPropertiesTable != null)
                {
                    return _SmbiosPropertiesTable;
                }

                _SmbiosPropertiesTable = new SmbiosPropertiesTable();
                _strings = SmbiosHelper.ParseStrings(HeaderInfo.RawData);
                Parse(_SmbiosPropertiesTable);

                return _SmbiosPropertiesTable;
            }
        }
        #endregion

        #endregion

        #region protected readonly properties

        #region [protected] (int) SmbiosVersion: Gets the current version of SMBIOS
        /// <summary>
        /// Gets the current version of <see cref="SMBIOS" />.
        /// </summary>
        /// <value>
        /// Value representing the current version of <see cref="SMBIOS" />.
        /// </value>
        protected int SmbiosVersion { get; }
        #endregion

        #region [protected] (ReadOnlyCollection<string>) Strings: Gets the strings associated with this structure
        /// <summary>
        /// Gets the strings associated with this structure.
        /// </summary>
        /// <value>
        /// An read-only collection that contains the strings of this structure.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected ReadOnlyCollection<string> Strings => new ReadOnlyCollection<string>(_strings);
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
        public object GetProperty(PropertyKey propertyKey) => Properties[propertyKey];
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

        #region [protected] {override} (string) ToString(): Gets the property collection for this structure
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents this instance.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref="SmbiosStructureHeaderInfo.StructureType" />.
        /// </remarks> 
        public override string ToString() => $"Type = {HeaderInfo.StructureType}";
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
        protected byte GetByte(byte target) => HeaderInfo.RawData[target];
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
                bytes.Add(HeaderInfo.RawData[i]);
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
        protected int GetWord(byte start) => HeaderInfo.RawData.GetWord(start);
        #endregion

        #region [protected] (int) GetDoubleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected int GetDoubleWord(byte start) => HeaderInfo.RawData.GetDoubleWord(start);
        #endregion

        #region [protected] (long) GetQuadrupleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected long GetQuadrupleWord(byte start) => HeaderInfo.RawData.GetQuadrupleWord(start);
        #endregion

        #region [protected] (string) GetString(byte): Returns the stored string from the specified byte
        /// <summary>
        /// Returns the stored string from the specified byte.
        /// </summary>
        /// <param name="target">target byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected string GetString(byte target)
        {
            try
            {
                return Strings[GetByte(target)];
            }
            catch
            {
                return string.Empty;
            }
        }
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (object) GetValueTypedProperty(PropertyKey): Returns a value that represents the value of the specified property.
        /// <summary>
        /// Returns a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// An <see cref="T:System.Object"/> that contains property.
        /// </returns>
        protected virtual object GetValueTypedProperty(PropertyKey propertyKey) => null;
        #endregion

        #region [protected] {virtual} (void) Parse(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected virtual void Parse(SmbiosPropertiesTable properties)
        {
        }
        #endregion

        #endregion

        #region private members

        //#region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Returns a reference to an object that implements the interface IDeviceProperty, represents the value of the property specified by its key by the parameter propertyKey.
        ///// <summary>
        ///// Returns a reference to an object that implements the interface <see cref="IDeviceProperty" />, represents the value of the property specified by its key by the parameter <paramref name="propertyKey"/>.
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
