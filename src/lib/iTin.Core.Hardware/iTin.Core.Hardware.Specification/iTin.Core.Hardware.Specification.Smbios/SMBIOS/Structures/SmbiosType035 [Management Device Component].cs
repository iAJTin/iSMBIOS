
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the  Management Device Component (Type 35) structure.
    /// </summary>
    internal sealed class SmbiosType035 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType035(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType035" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType035(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Description: Gets a value representing the 'Description' field
        /// <summary>
        /// Gets a value representing the <c>Description</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description => GetString(0x04);
        #endregion

        #region [private] (int) ManagementDeviceHandle: Gets a value representing the 'Management Device Handle' field
        /// <summary>
        /// Gets a value representing the <c>Management Device Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ManagementDeviceHandle => GetWord(0x05);
        #endregion

        #region [private] (int) ComponentHandle: Gets a value representing the 'Component Handle' field
        /// <summary>
        /// Gets a value representing the <c>Component Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ComponentHandle => GetWord(0x07);
        #endregion

        #region [private] (int) ThresholdHandle: Gets a value representing the 'Threshold Handle' field
        /// <summary>
        /// Gets a value representing the <c>Threshold Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ThresholdHandle => GetWord(0x09);
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
            properties.Add(SmbiosProperty.ManagementDeviceComponent.Description, Description);
            properties.Add(SmbiosProperty.ManagementDeviceComponent.ManagementDeviceHandle, ManagementDeviceHandle);
            properties.Add(SmbiosProperty.ManagementDeviceComponent.ComponentHandle, ComponentHandle);
            properties.Add(SmbiosProperty.ManagementDeviceComponent.ThresholdHandle, ThresholdHandle);
        }
        #endregion

        #endregion
    }
}
