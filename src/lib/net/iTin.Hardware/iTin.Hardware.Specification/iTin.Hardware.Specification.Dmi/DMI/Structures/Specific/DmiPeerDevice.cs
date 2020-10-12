
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <summary>
    /// This class represents an element of the structure <see cref="DmiType009"/>.
    /// </summary>
    public class DmiPeerDevice
    {
        #region private members
        private readonly SmbiosPropertiesTable _reference;
        #endregion

        #region constructor/s

        #region [internal] DmiPeerDevice(SmbiosPropertiesTable): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiPeerDevice"/>.
        /// </summary>
        /// <param name="reference"><b>SMBIOS</b> properties.</param>
        internal DmiPeerDevice(SmbiosPropertiesTable reference)
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
                {DmiProperty.SystemSlots.Peers.DataBusWidth, _reference[SmbiosProperty.SystemSlots.Peers.DataBusWidth]},
                {DmiProperty.SystemSlots.Peers.BusDeviceFunction, _reference[SmbiosProperty.SystemSlots.Peers.BusDeviceFunction]},
                {DmiProperty.SystemSlots.Peers.SegmentGroupNumber, _reference[SmbiosProperty.SystemSlots.Peers.SegmentGroupNumber]}
            };
        #endregion

        #endregion
    }
}
