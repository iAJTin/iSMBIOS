
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 027: Cooling Device.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.2+        Type                BYTE        27          Cooling Device indicator                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.2+        Length              BYTE        Varies      Length of the structure, at least 0Ch     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.2+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.2+        Temperature         WORD        Varies      The handle, or instance number, of the    |
    // |                      Probe Handle                                temperature probe monitoring this cooling |
    // |                                                                  device.                                   |
    // |                                                                  A value of 0xFFFF indicates that no probe |
    // |                                                                  is provided.                              |
    // |                                                                  Note: See ProbeHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.2+        Device Type         BYTE        Bit Field   Identifies the cooling device type and    |
    // |                      and Status                                  the status of this cooling device.        |
    // |                                                                  Note: ver GetDeviceType(byte)             |
    // |                                                                  Note: See GetStatus(byte)                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.2+        Cooling Unit        BYTE        Varies      Identifies the cooling unit group to which|
    // |                      Group                                       this cooling device is associated.        |
    // |                                                                  Having multiple cooling devices in the    |
    // |                                                                  same cooling unit implies a redundant     |
    // |                                                                  configuration.                            |
    // |                                                                  The value is 00h if the cooling device is |
    // |                                                                  not a member of a redundant cooling unit. |
    // |                                                                  Non-zero values imply redundancy and that |
    // |                                                                  at least one other cooling device will be |
    // |                                                                  enumerated with the same value.           |
    // |                                                                  Note: See UnitGroup                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.2+        OEM-defined         DWORD       Varies      Contains OEM- or BIOS vendor-specific     |
    // |                                                                  information.                              |
    // |                                                                  Note: See OemDefined                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.2+        Nominal             WORD        Varies      The nominal value for the cooling device’s|
    // |                      Speed                                       rotational speed, in revolutions-per-     |
    // |                                                                  minute (rpm).                             |
    // |                                                                  partition.                                |
    // |                                                                  If the value is unknown or the cooling    |
    // |                                                                  device is nonrotating, the field is set   |
    // |                                                                  to 0x8000.                                |
    // |                                                                  1 or 2.                                   |
    // |                                                                  This field is present in the structure    |
    // |                                                                  only if the structure’s Length is larger  |
    // |                                                                  than 0Ch.                                 |
    // |                                                                  Note: See NominalSpeed                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh      2.7+        Description         BYTE        STRING      The number of the string that contains    |
    // |                                                                  additional descriptive information about  |
    // |                                                                  the cooling device or its location.       |
    // |                                                                                                            |
    // |                                                                  This field is present in the structure    |
    // |                                                                  only if the structure’s Length is 0Fh or  |
    // |                                                                  larger.                                   |
    // |                                                                  Note: See Description                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Cooling Device (Type 27) structure.
    /// </summary>
    internal sealed class SmbiosType027 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType027(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType027"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType027(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
            
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.2+ fields

        #region [private] (ushort) TemperatureProbeHandle: Gets a value representing the 'Temperature Probe Handle' field
        /// <summary>
        /// Gets a value representing the <b>Temperature Probe Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort TemperatureProbeHandle => (ushort)Reader.GetWord(0x04);
        #endregion

        #region [private] (byte) DeviceTypeAndStatus: Gets a value representing the 'Device Type And Status' field
        /// <summary>
        /// Gets a value representing the <b>Device Type And Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceTypeAndStatus => Reader.GetByte(0x06);
        #endregion

        #region [private] (byte) DeviceType: Gets a value representing the 'Device Type' feature of the 'Device Type And Status' field
        /// <summary>
        /// Gets a value representing the <b>Device Type</b> feature of the <b>Device Type And Status</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceType => (byte) (DeviceTypeAndStatus & 0x1f);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Device Type And Status' field
        /// <summary>
        /// Gets a value representing the <b>Status</b> feature of the <b>Device Type And Status</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte) ((DeviceTypeAndStatus >> 5) & 0x07);
        #endregion

        #region [private] (byte) CoolingUnitGroup: Gets a value representing the 'Cooling Unit Group' field
        /// <summary>
        /// Gets a value representing the <b>Cooling Unit Group</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CoolingUnitGroup => Reader.GetByte(0x07);
        #endregion

        #region [private] (uint) OemDefined: Gets a value representing the 'Oem Defined' field
        /// <summary>
        /// Gets a value representing the <b>Oem Defined</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint OemDefined => (uint)Reader.GetDoubleWord(0x08);
        #endregion

        #region [private] (ushort) NominalSpeed: Gets a value representing the 'Nominal Speed' field
        /// <summary>
        /// Gets a value representing the <b>Nominal Speed</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort NominalSpeed => (ushort)Reader.GetWord(0x0c);
        #endregion

        #endregion

        #region Version 2.7+ fields

        #region [private] (string) Description: Gets a value representing the 'Description' field
        /// <summary>
        /// Gets a value representing the <b>Description</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description => GetString(0x0e);
        #endregion

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
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v22)
            {
                properties.Add(SmbiosProperty.CoolingDevice.TemperatureProbeHandle, TemperatureProbeHandle);
                properties.Add(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.Status, GetStatus(Status));
                properties.Add(SmbiosProperty.CoolingDevice.DeviceTypeAndStatus.DeviceType, GetDeviceType(DeviceType));
                properties.Add(SmbiosProperty.CoolingDevice.CoolingUnitGroup, CoolingUnitGroup);
                properties.Add(SmbiosProperty.CoolingDevice.OemDefined, OemDefined);

                if (StructureInfo.Length >= 0x0d)
                {
                    properties.Add(SmbiosProperty.CoolingDevice.NominalSpeed, NominalSpeed);
                }
            }

            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v27)
            {
                properties.Add(SmbiosProperty.CoolingDevice.Description, Description);
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetDeviceType(byte): Gets a string representing the device type
        /// <summary>
        /// Gets a string representing the device type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The device type.
        /// </returns>
        private static string GetDeviceType(byte code)
        {
            var value = new[]
            {
                "Other",                       // 0x01
                "Unknown",
                "Fan",
                "Centrifugal Blower",
                "Chip Fan",
                "Cabinet Fan",
                "Power Supply Fan",
                "Heat Pipe",
                "Integrated Refrigeration",
                "Active Cooling",
                "Passive Cooling"              // 0x0b
            };

            if (code >= 0x01 && code <= 0x0b)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetStatus(byte): Gets a string representing the state of the test
        /// <summary>
        /// Gets a string representing the state of the test.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The state of the test.
        /// </returns>
        private static string GetStatus(byte code)
        {
            var value = new[]
            {
                "Other",             // 0x01
                "Unknown",
                "Ok",
                "Non-critical",
                "Critical",
                "Non-recoverable"    // 0x06
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
