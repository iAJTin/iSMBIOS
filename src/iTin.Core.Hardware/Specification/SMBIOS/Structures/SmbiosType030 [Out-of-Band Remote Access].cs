
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 030: Out-of-Band Remote Access.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        30          Out-of-Band Remote Access indicator                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        06h         Length of the structure                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Manufacturer    BYTE        STRING      The number of the string that contains the            |
    // |              Name                                    manufacturer of the out-of-band access facility.      |
    // |                                                      Note: Ver Manufacturer                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Connections     BYTE        Bit Field   Identifies the current remote-access connections:     |
    // |                                                                                                            |
    // |                                                      Bits 07:02 - Reserved for future definition by this   |
    // |                                                                   specification; set to all zeros.         |
    // |                                                                                                            |
    // |                                                      Bit     01 - Outbound Connection Enabled. Identifies  |
    // |                                                                   whether (1) or not (0) the facility is   |
    // |                                                                   allowed to initiate outbound connections |
    // |                                                                   to contact an alert management facility  |
    // |                                                                   when critical conditions occur.          |
    // |                                                                   Note: Ver OutboundConnection             |
    // |                                                                                                            |
    // |                                                      Bit     00 - Inbound Connection Enabled. Identifies   |
    // |                                                                   whether (1) or not (0) the facility is   |
    // |                                                                   allowed to initiate outbound connections |
    // |                                                                   to receive incoming facility connections |
    // |                                                                   for the purpose of remote operations or  |
    // |                                                                   problem management.                      |
    // |                                                                   Note: Ver InboundConnection              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Out-of-Band Remote Access (Type 30) structure.
    /// </summary>
    sealed class SmbiosType030 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType030(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType030" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType030(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) ManufacturerName: Gets a value representing the 'Manufacturer Name' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer Name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string ManufacturerName => GetString(0x04);
        #endregion

        #region [private] (byte) Connections: Gets a value representing the 'Connections' field
        /// <summary>
        /// Gets a value representing the <c>Connections</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Connections => GetByte(0x05);
        #endregion

        #region [private] (byte) InBoundConnection: Gets a value representing the 'InBound Connection' feature of the 'Connections' field
        /// <summary>
        /// Gets a value representing the <c>InBound Connection</c> feature of the <c>Connections</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string InBoundConnection => Connections.CheckBit(Bits.Bit00) ? "Enabled" : "Disabled";
        #endregion

        #region [private] (byte) OutBoundConnection: Gets a value representing the 'OutBound Connection' feature of the 'LConnections' field
        /// <summary>
        /// Gets a value representing the <c>OutBound Connection</c> feature of the <c>Connections</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string OutBoundConnection => Connections.CheckBit(Bits.Bit01) ? "Enabled" : "Disabled";
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            SmbiosType030Property propertyId = (SmbiosType030Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Manufacturer Name] - [String]
                case SmbiosType030Property.ManufacturerName:
                    value = ManufacturerName;
                    break;
                #endregion

                #region [0x05] - [Connections]

                    #region [0x05] - [Connections -> In Bound Connection] - [String]
                    case SmbiosType030Property.InBoundConnection:
                        value = InBoundConnection;
                        break;
                    #endregion

                    #region [0x05] - [Connections -> Out Bound Connection] - [String]
                    case SmbiosType030Property.OutBoundConnection:
                        value = OutBoundConnection;
                        break;
                    #endregion

                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(PropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(PropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.OutOfBandRemote.Manufacturer, ManufacturerName);
            properties.Add(KnownDmiProperty.OutOfBandRemote.Connections.OutBoundConnection, OutBoundConnection);
            properties.Add(KnownDmiProperty.OutOfBandRemote.Connections.InBoundConnection, InBoundConnection);
            #endregion
        }
        #endregion

        #endregion
    }
}
