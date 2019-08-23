
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <summary>
    /// This class represents an element of the structure <see cref="DmiType042"/>.
    /// </summary>
    public class DmiManagementControllerHostInterfaceProtocolRecord 
    {
        #region private members
        private readonly SmbiosPropertiesTable _reference;
        #endregion

        #region constructor/s

        #region [internal] DmiManagementControllerHostInterfaceProtocolRecord(SmbiosPropertiesTable): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiManagementControllerHostInterfaceProtocolRecord"/>.
        /// </summary>
        /// <param name="reference"><c>SMBIOS</c> properties.</param>
        internal DmiManagementControllerHostInterfaceProtocolRecord(SmbiosPropertiesTable reference)
        {
            _reference = reference;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DmiClassPropertiesTable) Properties : 
        public DmiClassPropertiesTable Properties =>
            new DmiClassPropertiesTable
            {
                {DmiProperty.ManagementControllerHostInterface.Protocol.ProtocolType, _reference[SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolType]},
                {DmiProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData, _reference[SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData]}
            };
        #endregion

        #endregion
    }
}
