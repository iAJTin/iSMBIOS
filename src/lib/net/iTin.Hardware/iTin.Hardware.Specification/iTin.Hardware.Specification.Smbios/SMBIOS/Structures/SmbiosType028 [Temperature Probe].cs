
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 028: Voltage Probe.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        28          Temperature Probe indicator                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure, at least 14h                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Description     BYTE        STRING      The number of the string that contains additional     |
    // |                                                      descriptive information about the probe or its        |
    // |                                                      location.                                             |
    // |                                                      Note: See Description                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Location and    BYTE        Bit Field   Defines the probe’s physical location and status of   |
    // |              Status                                  the temperature monitored by this temperature probe.  |
    // |                                                      Note: See GetLocation(byte)                           |
    // |                                                      Note: See GetStatus(byte)                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Maximum Value   WORD        Varies      The maximum temperature readable by this probe, in    |
    // |                                                      1/10th degrees C.                                     |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See MaximumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Minimum Value   WORD        Varies      The Minimum temperature readable by this probe, in    |
    // |                                                      1/10th degrees C.                                     |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See MinimumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Resolution      WORD        Varies      The resolution for the probe’s reading, 1/1000th      |
    // |                                                      degrees C.                                            |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See Resolution                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Tolerance       WORD        Varies      The tolerance for reading from this probe, in +/-     |
    // |                                                      1/10th degrees C.                                     |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See Tolerance                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Accuracy        WORD        Varies      The accuracy for reading from this probe, in +/-      |
    // |                                                      1/100th of a percent.                                 |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See Accuracy                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          OEM-defined     DWORD       Varies      Contains OEM- or BIOS vendor-specific information.    |
    // |                                                      Note: See OemDefined                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h          Nominal Value   WORD        Varies      The nominal value for the probe’s reading in 1/10th   |
    // |                                                      degrees C.                                            |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      This field is present in the structure only if the    |
    // |                                                      structure’s Length is larger than 14h.                |
    // |                                                      Note: See NominalValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Temperature Probe (Type 28) structure.
    /// </summary>
    internal sealed class SmbiosType028 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType028(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType028"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType028(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Description: Gets a value representing the 'Description' field
        /// <summary>
        /// Gets a value representing the <b>Description</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Description => GetString(0x04);
        #endregion

        #region [private] (byte) LocationAndStatus: Gets a value representing the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <b>Location And Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LocationAndStatus => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) Location: Gets a value representing the 'Location' feature of the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <b>Location</b> feature of the <b>Location And Status</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location => (byte)(LocationAndStatus & 0x1f);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <b>Status</b> feature of the <b>Location And Status</b> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte)((LocationAndStatus >> 5) & 0x07);
        #endregion

        #region [private] (ushort) MaximunValue: Gets a value representing the 'Maximun Value' field
        /// <summary>
        /// Gets a value representing the <b>Maximun Value</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MaximunValue => (ushort)Reader.GetWord(0x06);
        #endregion

        #region [private] (ushort) MinimunValue: Gets a value representing the 'Minimun Value' field
        /// <summary>
        /// Gets a value representing the <b>Minimun Value</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MinimunValue => (ushort)Reader.GetWord(0x08);
        #endregion

        #region [private] (ushort) Resolution: Gets a value representing the 'Resolution' field
        /// <summary>
        /// Gets a value representing the <b>Resolution</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Resolution => (ushort)Reader.GetWord(0x0a);
        #endregion

        #region [private] (ushort) Tolerance: Gets a value representing the 'Tolerance' field
        /// <summary>
        /// Gets a value representing the <b>Tolerance</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Tolerance => (ushort)Reader.GetWord(0x0c);
        #endregion

        #region [private] (ushort) Accuracy: Gets a value representing the 'Accuracy' field
        /// <summary>
        /// Gets a value representing the <b>Accuracy</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Accuracy => (ushort)Reader.GetWord(0x0e);
        #endregion.

        #region [private] (uint) OemDefined: Gets a value representing the 'Oem Defined' field
        /// <summary>
        /// Gets a value representing the <b>Oem Defined</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint OemDefined => (uint)Reader.GetDoubleWord(0x10);
        #endregion

        #region [private] (ushort) NominalValue: Gets a value representing the 'Nominal Value field
        /// <summary>
        /// Gets a value representing the <b>Nominal Value</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort NominalValue => (ushort)Reader.GetWord(0x14);
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
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.Latest)
            {
                properties.Add(SmbiosProperty.TemperatureProbe.Description, Description);
                properties.Add(SmbiosProperty.TemperatureProbe.LocationAndStatus.Status, GetStatus(Status));
                properties.Add(SmbiosProperty.TemperatureProbe.LocationAndStatus.Location, GetLocation(Location));
                properties.Add(SmbiosProperty.TemperatureProbe.MaximumValue, MaximunValue);
                properties.Add(SmbiosProperty.TemperatureProbe.MinimumValue, MinimunValue);
                properties.Add(SmbiosProperty.TemperatureProbe.Resolution, Resolution);
                properties.Add(SmbiosProperty.TemperatureProbe.Tolerance, Tolerance);
                properties.Add(SmbiosProperty.TemperatureProbe.Accuracy, Accuracy);
                properties.Add(SmbiosProperty.TemperatureProbe.OemDefined, OemDefined);
            }

            if (StructureInfo.Length >= 0x15)
            {
                properties.Add(SmbiosProperty.TemperatureProbe.NominalValue, NominalValue);
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetLocation(byte): Gets a string representing the location
        /// <summary>
        /// Gets a string representing the location.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The location.
        /// </returns>
        private static string GetLocation(byte code)
        {
            string[] value =
            {
                "Other",                       // 0x01
                "Unknown",
                "Proccessor",
                "Disk",
                "Peripheral Bay",
                "System Management Module",
                "Motherboard",
                "Memory Module",
                "Processor Module",
                "Power Unit",
                "Add-in Card",
                "Front Panel Board",
                "Back Panel Board",
                "Power System Board",
                "Drive Back Plane"             // 0x0f
            };

            if (code >= 0x01 && code <= 0x0f)
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
