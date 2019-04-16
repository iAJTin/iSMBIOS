
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    using Device.DeviceProperty;

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

        #region [public] (SmbiosPropertiesTable) Properties: Gets a value that represents the available properties
        /// <summary>
        /// Gets a value that represents the available properties.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public SmbiosPropertiesTable Properties => smbiosTable.Properties;
        #endregion

        #endregion

        #region public methods

        #region [public] (IDeviceProperty) GetProperty(PropertyKey): Gets a reference to an object that implements the interface IDeviceProperty represents the strongly typed value of the property
        /// <summary>
        /// Gets a reference to an object that implements the interface <see cref="IDeviceProperty" />, represents the strongly typed value of the property.
        /// </summary>
        /// <param name="propertyKey">Key to the property to be recovered.</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property.
        /// </returns>
        public IDeviceProperty GetProperty(PropertyKey propertyKey) => smbiosTable.GetProperty(propertyKey);
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
