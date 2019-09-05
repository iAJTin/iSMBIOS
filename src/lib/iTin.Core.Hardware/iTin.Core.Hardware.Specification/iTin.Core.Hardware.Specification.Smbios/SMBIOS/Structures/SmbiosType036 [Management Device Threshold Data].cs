
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 036: Management Device Threshold Data.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        36          Management Device Threshold Data structure indicator. |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        10h         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Lower           WORD        Varies      The lower non-critical threshold for this component.  |
    // |              Threshold                                                                                     |
    // |              Non-critical                            Note: Ver LowerNonCritical                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Upper           WORD        Varies      The upper non-critical threshold for this component.  |
    // |              Threshold                                                                                     |
    // |              Non-critical                            Note: Ver UpperNonCritical                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Lower           WORD        Varies      The lower critical threshold for this component.      |
    // |              Threshold                                                                                     |
    // |              Critical                                Note: Ver LowerCritical                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Upper           WORD        Varies      The upper critical threshold for this component.      |
    // |              Threshold                                                                                     |
    // |              Critical                                Note: Ver UpperCritical                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Lower           WORD        Varies      The lower non-recoverable threshold for this          |
    // |              Threshold                               component.                                            |
    // |              Non-recoverable                         Note: Ver LowerNonRecoverable                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Upper           WORD        Varies      The upper non-recoverable threshold for this          |
    // |              Threshold                               component.                                            |
    // |              Non-recoverable                         Note: Ver UpperNonRecoverable                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Management Device Threshold Data (Type 36) structure.
    /// </summary>
    internal sealed class SmbiosType036 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType036(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType036" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType036(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) LowerNonCritical: Gets a value representing the 'Lower Non Critical' field
        /// <summary>
        /// Gets a value representing the <c>Lower Non Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LowerNonCritical => Reader.GetWord(0x04);
        #endregion

        #region [private] (int) UpperNonCritical: Gets a value representing the 'Upper Non Critical' field
        /// <summary>
        /// Gets a value representing the <c>Upper Non Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperNonCritical => Reader.GetWord(0x06);
        #endregion

        #region [private] (int) LowerCritical: Gets a value representing the 'Lower Critical' field
        /// <summary>
        /// Gets a value representing the <c>Lower Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LowerCritical => Reader.GetWord(0x08);
        #endregion

        #region [private] (int) UpperCritical: Gets a value representing the 'Upper Critical' field
        /// <summary>
        /// Gets a value representing the <c>Upper Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperCritical => Reader.GetWord(0x0a);
        #endregion

        #region [private] (int) LowerNonRecoverable: Gets a value representing the 'Lower Non Recoverable' field
        /// <summary>
        /// Gets a value representing the <c>Lower Non Recoverable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LowerNonRecoverable => Reader.GetWord(0x0c);
        #endregion

        #region [private] (int) UpperNonRecoverable: Gets a value representing the 'Upper Non Recoverable' field
        /// <summary>
        /// Gets a value representing the <c>Upper Non Recoverable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperNonRecoverable => Reader.GetWord(0x0e);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerNonCritical, LowerNonCritical);
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperNonCritical, UpperNonCritical);
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerCritical, LowerCritical);
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperCritical, UpperCritical);
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.LowerNonRecoverable, LowerNonRecoverable);
            properties.Add(SmbiosProperty.ManagementDeviceThresholdData.UpperNonRecoverable, UpperNonRecoverable);
        }
        #endregion

        #endregion                
    }
}
