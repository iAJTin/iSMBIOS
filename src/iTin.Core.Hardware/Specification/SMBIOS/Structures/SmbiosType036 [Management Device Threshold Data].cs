
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

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
    sealed class SmbiosType036 : SmbiosBaseType
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
        private int LowerNonCritical => GetWord(0x04);
        #endregion

        #region [private] (int) UpperNonCritical: Gets a value representing the 'Upper Non Critical' field
        /// <summary>
        /// Gets a value representing the <c>Upper Non Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperNonCritical => GetWord(0x06);
        #endregion

        #region [private] (int) LowerCritical: Gets a value representing the 'Lower Critical' field
        /// <summary>
        /// Gets a value representing the <c>Lower Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LowerCritical => GetWord(0x08);
        #endregion

        #region [private] (int) UpperCritical: Gets a value representing the 'Upper Critical' field
        /// <summary>
        /// Gets a value representing the <c>Upper Critical</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperCritical => GetWord(0x0a);
        #endregion

        #region [private] (int) LowerNonRecoverable: Gets a value representing the 'Lower Non Recoverable' field
        /// <summary>
        /// Gets a value representing the <c>Lower Non Recoverable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LowerNonRecoverable => GetWord(0x0c);
        #endregion

        #region [private] (int) UpperNonRecoverable: Gets a value representing the 'Upper Non Recoverable' field
        /// <summary>
        /// Gets a value representing the <c>Upper Non Recoverable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int UpperNonRecoverable => GetWord(0x0e);
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
            SmbiosType036Property propertyId = (SmbiosType036Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Lower Threshold Non-critical] - [Int32?]
                case SmbiosType036Property.LowerNonCritical:
                    if (LowerNonCritical != 0x8000)
                    {
                        value = (int?) LowerNonCritical;
                    }
                    break;
                #endregion

                #region [0x06] - [Upper Threshold Non-critical] - [Int32?]
                case SmbiosType036Property.UpperNonCritical:
                    if (UpperNonCritical != 0x8000)
                    {
                        value = (int?) UpperNonCritical;
                    }
                    break;
                #endregion

                #region [0x08] - [Lower Threshold Critical] - [Int32?]
                case SmbiosType036Property.LowerCritical:
                    if (LowerCritical != 0x8000)
                    {
                        value = (int?) LowerCritical;
                    }
                    break;
                #endregion

                #region [0x0a] - [Upper Threshold Critical] - [Int32?]
                case SmbiosType036Property.UpperCritical:
                    if (UpperCritical != 0x8000)
                    {
                        value = (int?) UpperCritical;
                    }
                    break;
                #endregion

                #region [0x0c] - [Lower Threshold Non-recoverable] - [Int32?]
                case SmbiosType036Property.LowerNonRecoverable:
                    if (LowerNonRecoverable != 0x8000)
                    {
                        value = (int?) LowerNonRecoverable;
                    }
                    break;
                #endregion

                #region [0x0e] - [Upper Threshold Non-recoverable] - [Int32?]
                case SmbiosType036Property.UpperNonRecoverable:
                    if (UpperNonRecoverable != 0x8000)
                    {
                        value = (int?) UpperNonRecoverable;
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(SmbiosPropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(SmbiosPropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region versions
            if (LowerNonCritical != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.LowerNonCritical, LowerNonCritical);
            }

            if (UpperNonCritical != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.UpperNonCritical, UpperNonCritical);
            }

            if (LowerCritical != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.LowerCritical, LowerCritical);
            }

            if (UpperCritical != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.UpperCritical, UpperCritical);
            }

            if (LowerNonRecoverable != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.LowerNonRecoverable, LowerNonRecoverable);
            }

            if (UpperNonRecoverable != 0x8000)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceThresholdData.UpperNonRecoverable, UpperNonRecoverable);
            }
            #endregion
        }
        #endregion

        #endregion                
    }
}
