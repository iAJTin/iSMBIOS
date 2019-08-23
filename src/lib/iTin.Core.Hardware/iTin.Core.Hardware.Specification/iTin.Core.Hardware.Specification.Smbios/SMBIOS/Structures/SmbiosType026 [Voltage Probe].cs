
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 026: Voltage Probe.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        26          Voltage Probe indicator                               |
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
    // |              Status                                  the voltage monitored by this voltage probe.          |
    // |                                                      Note: See GetLocation(byte)                           |
    // |                                                      Note: See GetStatus(byte)                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Maximum Value   WORD        Varies      The maximum voltage level readable by this probe, in  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See MaximumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Minimum Value   WORD        Varies      The minimum voltage level readable by this probe, in  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See MinimumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Resolution      WORD        Varies      The resolution for the probe’s reading, in tenths of  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: See Resolution                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Tolerance       WORD        Varies      The tolerance for reading from this probe, in +/-     |
    // |                                                      millivolts.                                           |
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
    // | 14h          Nominal Value   WORD        Varies      The nominal value for the probe’s reading in          |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      This field is present in the structure only if the    |
    // |                                                      structure’s Length is larger than 14h.                |
    // |                                                      Note: See NominalValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Voltage Probe (Type 26) structure.
    /// </summary>
    internal sealed class SmbiosType026 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType026(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType026" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType026(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
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

        #region [private] (byte) LocationAndStatus: Gets a value representing the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <c>Location And Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LocationAndStatus => GetByte(0x05);
        #endregion

        #region [private] (byte) Location: Gets a value representing the 'Location' feature of the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <c>Location</c> feature of the <c>Location And Status</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location => (byte)(LocationAndStatus & 0x1f);
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Location And Status' field
        /// <summary>
        /// Gets a value representing the <c>Status</c> feature of the <c>Location And Status</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte)((LocationAndStatus >> 5) & 0x07);
        #endregion

        #region [private] (int) MaximunValue: Gets a value representing the 'Maximun Value' field
        /// <summary>
        /// Gets a value representing the <c>Maximun Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximunValue => GetWord(0x06);
        #endregion

        #region [private] (int) MinimunValue: Gets a value representing the 'Minimun Value' field
        /// <summary>
        /// Gets a value representing the <c>Minimun Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimunValue => GetWord(0x08);
        #endregion

        #region [private] (int) Resolution: Gets a value representing the 'Resolution' field
        /// <summary>
        /// Gets a value representing the <c>Resolution</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Resolution => GetWord(0x0a);
        #endregion

        #region [private] (int) Tolerance: Gets a value representing the 'Tolerance' field
        /// <summary>
        /// Gets a value representing the <c>Tolerance</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Tolerance => GetWord(0x0c);
        #endregion

        #region [private] (int) Accuracy: Gets a value representing the 'Accuracy' field
        /// <summary>
        /// Gets a value representing the <c>Accuracy</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Accuracy => GetWord(0x0e);
        #endregion.

        #region [private] (long) OemDefined: Gets a value representing the 'Oem Defined' field
        /// <summary>
        /// Gets a value representing the <c>Oem Defined</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long OemDefined => GetDoubleWord(0x10);
        #endregion

        #region [private] (int) NominalValue: Gets a value representing the 'Nominal Value' field
        /// <summary>
        /// Gets a value representing the <c>Nominal Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int NominalValue => GetWord(0x14);
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
            properties.Add(SmbiosProperty.VoltageProbe.Description, Description);
            properties.Add(SmbiosProperty.VoltageProbe.LocationAndStatus.Status, GetStatus(Status));
            properties.Add(SmbiosProperty.VoltageProbe.LocationAndStatus.Location, GetLocation(Location));
            properties.Add(SmbiosProperty.VoltageProbe.MaximunValue, MaximunValue);
            properties.Add(SmbiosProperty.VoltageProbe.MinimunValue, MinimunValue);
            properties.Add(SmbiosProperty.VoltageProbe.Resolution, Resolution);
            properties.Add(SmbiosProperty.VoltageProbe.Tolerance, Tolerance);
            properties.Add(SmbiosProperty.VoltageProbe.Accuracy, Accuracy);
            properties.Add(SmbiosProperty.VoltageProbe.OemDefined, OemDefined);

            if (StructureInfo.Length >= 0x15)
            {
                properties.Add(SmbiosProperty.VoltageProbe.NominalValue, NominalValue);
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetLocation(byte): Gets a string representing the location
        /// <summary>
        /// Gets a string representing the location.
        /// </summary>
        /// <param name="code">Value to analyze..</param>
        /// <returns>
        /// The location.
        /// </returns>
        private static string GetLocation(byte code)
        {
            string[] value =
            {
                "Other",                         // 0x01
                "Unknown",
                "Proccessor",
                "Disk",
                "Peripheral Bay",
                "System Management Module",
                "Motherboard",
                "Memory Module",
                "Processor Module",
                "Power Unit",
                "Add-in Card"                    // 0x0b
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
        /// <param name="code">Value to analyze..</param>
        /// <returns>
        /// The state of the test.
        /// </returns>
        private static string GetStatus(byte code)
        {
            string[] value =
            {
                "Other",               // 0x01
                "Unknown",
                "Ok",
                "Non-critical",
                "Critical",
                "Non-recoverable"      // 0x06
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
