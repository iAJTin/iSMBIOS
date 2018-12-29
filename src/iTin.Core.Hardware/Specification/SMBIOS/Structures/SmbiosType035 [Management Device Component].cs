
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

    // Type 035: Management Device Component.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        35          Management Device Component indicator                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        0Bh         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Description     BYTE        STRING      The number of the string that contains additional     |
    // |                                                      descriptive information about the component.          |
    // |                                                      Note: Ver Description                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Management      WORD        Varies      The handle, or instance number, of the Management     |
    // |              Device Handle                           Device.                                               |
    // |                                                      Note: Ver DeviceHandle                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Component       WORD        Varies      The handle, or instance number, of the probe or       |
    // |              Handle                                  cooling device that defines this component.           |
    // |                                                      Note: Ver ProbeHandle                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Threshold       WORD        Varies      The handle, or instance number, associated with the   |
    // |              Handle                                  device thresholds.                                    |
    // |                                                                                                            |
    // |                                                      A value of 0FFFFh indicates that no Threshold Data    |
    // |                                                      structure is associated with this component.          |
    // |                                                      Note: Ver ThresholdHandle                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the  Management Device Component (Type 35) structure.
    /// </summary>
    sealed class SmbiosType035 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType035(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType035"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType035(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Description: Gets a value representing the 'Description' field.
        /// <summary>
        /// Gets a value representing the <c>Description</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description
        {
            get { return GetString(0x04); }
        }
        #endregion

        #region [private] (int) ManagementDeviceHandle: Gets a value representing the 'Management Device Handle' field.
        /// <summary>
        /// Gets a value representing the <c>Management Device Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ManagementDeviceHandle
        {
            get { return GetWord(0x05); }
        }
        #endregion

        #region [private] (int) ComponentHandle: Gets a value representing the 'Component Handle' field.
        /// <summary>
        /// Gets a value representing the <c>Component Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ComponentHandle
        {
            get { return GetWord(0x07); }
        }
        #endregion

        #region [private] (int) ThresholdHandle: Gets a value representing the 'Threshold Handle' field.
        /// <summary>
        /// Gets a value representing the <c>Threshold Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ThresholdHandle
        {
            get { return GetWord(0x09); }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property.
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
            SmbiosType035Property propertyId = (SmbiosType035Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Description] - [String]
                case SmbiosType035Property.Description:
                    value = Description;
                    break;
                #endregion

                #region [0x05] - [Management Device Handle] - [Innt32]
                case SmbiosType035Property.ManagementDeviceHandle:
                    value = ManagementDeviceHandle;
                    break;
                #endregion

                #region [0x07] - [Component Handle] - [Int32]
                case SmbiosType035Property.ComponentHandle:
                    value = ComponentHandle;
                    break;
                #endregion

                #region [0x09] - [Threshold Handle] - [Int32?]
                case SmbiosType035Property.ThresholdHandle:
                    if (ThresholdHandle != 0xffff)
                    {
                        value = (int?) ThresholdHandle;
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure.
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.ManagementDeviceComponent.Description, Description);
            properties.Add(KnownDmiProperty.ManagementDeviceComponent.ManagementDeviceHandle, ManagementDeviceHandle);
            properties.Add(KnownDmiProperty.ManagementDeviceComponent.ComponentHandle, ComponentHandle);

            if (ThresholdHandle != 0xffff)
            {
                properties.Add(KnownDmiProperty.ManagementDeviceComponent.ThresholdHandle, ThresholdHandle);
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
