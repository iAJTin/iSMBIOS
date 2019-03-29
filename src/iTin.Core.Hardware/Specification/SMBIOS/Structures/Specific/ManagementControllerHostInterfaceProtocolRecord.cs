
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using Dmi.Property;

    using Helpers;

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
    public class ManagementControllerHostInterfaceProtocolRecord
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _protocolRecordDataArray;
        #endregion

        #region constructor/s

        #region [internal] ManagementControllerHostInterfaceProtocolRecord(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="ChassisContainedElement"/> specifying the structure information.
        /// </summary>
        /// <param name="protocolRecordDataArray">Untreated information of the current structure.</param>
        internal ManagementControllerHostInterfaceProtocolRecord(byte[] protocolRecordDataArray)
        {
            _protocolRecordDataArray = protocolRecordDataArray;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (Hashtable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public Hashtable Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new Hashtable();
                    Parse(_properties);
                }

                return _properties;
            }
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ProtocolType: Gets a value that represents the 'Protocol Type' field
        /// <summary>
        ///  Gets a value that represents the '<c>Protocol Type</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ProtocolType => GetProtocolType(_protocolRecordDataArray[0x00]);
        #endregion

        #region [private] (byte) ProtocolTypeSpecificDataLenght: Gets a value representing the 'Protocol Type Specific Data Lenght' field
        /// <summary>
        /// Gets a value representing the <c>Protocol Type Specific Data Lenght</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ProtocolTypeSpecificDataLenght => _protocolRecordDataArray[0x01];
        #endregion

        #region [private] (ReadOnlyCollection<byte>) ProtocolTypeSpecificData: Gets a value representing the 'Protocol Type Specific Data' field
        /// <summary>
        /// Gets a value representing the <c>Protocol Type Specific Data</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<byte> ProtocolTypeSpecificData => new ReadOnlyCollection<byte>(GetBytes(0x02, ProtocolTypeSpecificDataLenght));
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString():  Returns a string that represents the current object
        /// <summary>
        /// Returns a class <see cref="T: System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.String" /> that represents the current <see cref = "T:iTin.Core.Hardware.Specification.Smbios.ManagementControllerHostInterfaceProtocolRecord"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref = "P:iTin.Core.Hardware.Specification.Smbios.ManagementControllerHostInterfaceProtocolRecord.ProtocolType" />.
        /// </remarks>                                    
        public override string ToString() => $"Type = {ProtocolType}";
        #endregion

        #endregion

        #region private methods

        #region [private] (void) Parse(Hashtable): Gets the property collection for this structure
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        private void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.ManagementControllerHostInterface.Protocol.ProtocolType, ProtocolType);
            properties.Add(KnownDmiProperty.ManagementControllerHostInterface.Protocol.ProtocolTypeSpecificData, ProtocolTypeSpecificData);
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.2.0 (26/04/2018)

        #region [private] (byte) GetBytes(byte, byte): Returns the stored array from start with specified lenght
        /// <summary>
        /// Returns the stored array from start with specified lenght.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <param name="lenght">lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        private byte[] GetBytes(byte start, byte lenght)
        {
            var bytes = new Collection<byte>();

            for (byte i = start; i <= lenght; i++)
            {
                bytes.Add(_protocolRecordDataArray[i]);
            }

            return bytes.ToArray();

        }
        #endregion

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
