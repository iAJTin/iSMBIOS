
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <summary>
    /// This class represents an element of the structure <see cref="DmiType037"/>.
    /// </summary>
    public class DmiMemoryChannelElement
    {
        #region private members
        private readonly SmbiosPropertiesTable _reference;
        #endregion

        #region constructor/s

        #region [internal] DmiMemoryChannelElement(SmbiosPropertiesTable): Initialize a new instance of the class.
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiMemoryChannelElement"/>.
        /// </summary>
        /// <param name="reference"><b>SMBIOS</b> properties.</param>
        internal DmiMemoryChannelElement(SmbiosPropertiesTable reference)
        {
            _reference = reference;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DmiClassPropertiesTable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        public DmiClassPropertiesTable Properties =>
            new DmiClassPropertiesTable
            {
                {DmiProperty.MemoryChannel.MemoryDevices.Load, _reference[SmbiosProperty.MemoryChannel.MemoryDevices.Load]},
                {DmiProperty.MemoryChannel.MemoryDevices.Handle, _reference[SmbiosProperty.MemoryChannel.MemoryDevices.Handle]}
            };
        #endregion

        #endregion
    }
}
