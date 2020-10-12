
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Property;

    // Type 042: Management Controller Host Interface. Protocol Record Data Format 
    // •———————————————————————————————————————————————————————————————————————————————————•
    // | Offset   Name                      Length      Value       Description            |
    // •———————————————————————————————————————————————————————————————————————————————————•
    // | 00h      Protocol Type             BYTE        ENUM        Protocol types.        |
    // •———————————————————————————————————————————————————————————————————————————————————•
    // | 01h      Protocol Type             BYTE        N                                  |
    // |          Specific Data Lenght                                                     |
    // •———————————————————————————————————————————————————————————————————————————————————•
    // | 02h      Protocol Type             N           Varies                             |
    // |          Specific Data             BYTEs                                          |
    // •———————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents an element of the structure <see cref="SmbiosType042"/>.
    /// </summary>
    public class ManagementControllerHostInterfaceProtocolRecord : SpecificSmbiosBaseType
    {
        #region constructor/s

        #region [internal] ManagementControllerHostInterfaceProtocolRecord(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="ManagementControllerHostInterfaceProtocolRecord"/> specifying the structure information.
        /// </summary>
        /// <param name="protocolRecordDataArray">Untreated information of the current structure.</param>
        internal ManagementControllerHostInterfaceProtocolRecord(byte[] protocolRecordDataArray) : base(protocolRecordDataArray)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ProtocolType: Gets a value that represents the 'Protocol Type' field
        /// <summary>
        ///  Gets a value that represents the '<b>Protocol Type</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ProtocolType => GetProtocolType(GetByte(0x00));
        #endregion

        #region [private] (byte) ProtocolTypeSpecificDataLenght: Gets a value representing the 'Protocol Type Specific Data Lenght' field
        /// <summary>
        /// Gets a value representing the <b>Protocol Type Specific Data Lenght</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ProtocolTypeSpecificDataLenght => GetByte(0x01);
        #endregion

        #region [private] (ReadOnlyCollection<byte>) ProtocolTypeSpecificData: Gets a value representing the 'Protocol Type Specific Data' field
        /// <summary>
        /// Gets a value representing the <b>Protocol Type Specific Data</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<byte> ProtocolTypeSpecificData => new ReadOnlyCollection<byte>(GetBytes(0x02, ProtocolTypeSpecificDataLenght));
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="ManagementControllerHostInterfaceProtocolRecord"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref="ProtocolType"/>.
        /// </remarks>                                    
        public override string ToString() => $"Type = {ProtocolType}";
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            properties.Add(SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolType, ProtocolType);
            properties.Add(SmbiosProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData, ProtocolTypeSpecificData);
        }
        #endregion

        #endregion


        #region BIOS Specification 3.2.0 (26/04/2018)

        #region [private] {static} (string) GetProtocolType(byte): Gets a string that allows you to identify the type of protocol
        /// <summary>
        /// Gets a string that allows you to identify the type of protocol.
        /// </summary>
        /// <param name="code">Target byte</param>
        /// <returns>
        /// Tipo de placa base.
        /// </returns>
        private static string GetProtocolType(byte code)
        {
            string[] value =
            {
                "IPMI",            // 0x02
                "MCTP",
                "Redfish over IP", // 0x04 
            };

            if (code == 0xf0)
            {
                return "OEM-defined";
            }

            if (code >= 0x02 && code <= 0x04)
            {
                return value[code - 0x02];
            }

            return SmbiosHelper.Reserved;
        }
        #endregion

        #endregion
    }
}
