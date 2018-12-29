
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

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
    // |                                                      Note: Ver Description                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Location and    BYTE        Bit Field   Defines the probe’s physical location and status of   |
    // |              Status                                  the voltage monitored by this voltage probe.          |
    // |                                                      Note: Ver GetLocation(byte)                           |
    // |                                                      Note: Ver GetStatus(byte)                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Maximum Value   WORD        Varies      The maximum voltage level readable by this probe, in  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: Ver MaximumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Minimum Value   WORD        Varies      The minimum voltage level readable by this probe, in  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: Ver MinimumValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Resolution      WORD        Varies      The resolution for the probe’s reading, in tenths of  |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: Ver Resolution                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Tolerance       WORD        Varies      The tolerance for reading from this probe, in +/-     |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: Ver Tolerance                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Accuracy        WORD        Varies      The accuracy for reading from this probe, in +/-      |
    // |                                                      1/100th of a percent.                                 |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      Note: Ver Accuracy                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          OEM-defined     DWORD       Varies      Contains OEM- or BIOS vendor-specific information.    |
    // |                                                      Note: Ver OemDefined                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h          Nominal Value   WORD        Varies      The nominal value for the probe’s reading in          |
    // |                                                      millivolts.                                           |
    // |                                                      If the value is unknown, the field is set to 0x8000.  |
    // |                                                      This field is present in the structure only if the    |
    // |                                                      structure’s Length is larger than 14h.                |
    // |                                                      Note: Ver NominalValue                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Voltage Probe (Type 26) structure.
    /// </summary>
    sealed class SmbiosType026 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType026(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType026"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType026(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
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

        #region [private] (byte) LocationAndStatus: Gets a value representing the 'Location And Status' field.
        /// <summary>
        /// Gets a value representing the <c>Location And Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LocationAndStatus
        {
            get { return GetByte(0x05); }
        }
        #endregion

        #region [private] (byte) Location: Gets a value representing the 'Location' feature of the 'Location And Status' field.
        /// <summary>
        /// Gets a value representing the <c>Location</c> feature of the <c>Location And Status</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location
        {
            get { return (byte)(LocationAndStatus & 0x1f); }
        }
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Status' feature of the 'Location And Status' field.
        /// <summary>
        /// Gets a value representing the <c>Status</c> feature of the <c>Location And Status</c> field
        /// </summary>
        /// <value>
        /// Feature value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status
        {
            get { return (byte)((LocationAndStatus >> 5) & 0x07); }
        }
        #endregion

        #region [private] (int) MaximunValue: Gets a value representing the 'Maximun Value' field.
        /// <summary>
        /// Gets a value representing the <c>Maximun Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximunValue
        {
            get { return GetWord(0x06); }
        }
        #endregion

        #region [private] (int) MinimunValue: Gets a value representing the 'Minimun Value' field.
        /// <summary>
        /// Gets a value representing the <c>Minimun Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimunValue
        {
            get { return GetWord(0x08); }
        }
        #endregion

        #region [private] (int) Resolution: Gets a value representing the 'Resolution' field.
        /// <summary>
        /// Gets a value representing the <c>Resolution</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Resolution
        {
            get { return GetWord(0x0a); }
        }
        #endregion

        #region [private] (int) Tolerance: Gets a value representing the 'Tolerance' field.
        /// <summary>
        /// Gets a value representing the <c>Tolerance</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Tolerance
        {
            get { return GetWord(0x0c); }
        }
        #endregion

        #region [private] (int) Accuracy: Gets a value representing the 'Accuracy' field.
        /// <summary>
        /// Gets a value representing the <c>Accuracy</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Accuracy
        {
            get { return GetWord(0x0e); }
        }
        #endregion.

        #region [private] (long) OemDefined: Gets a value representing the 'Oem Defined' field.
        /// <summary>
        /// Gets a value representing the <c>Oem Defined</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long OemDefined
        {
            get { return GetDoubleWord(0x10); }
        }
        #endregion

        #region [private] (int) NominalValue: Gets a value representing the 'Nominal Value' field.
        /// <summary>
        /// Gets a value representing the <c>Nominal Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int NominalValue
        {
            get { return GetWord(0x14); }
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
            SmbiosType026Property propertyId = (SmbiosType026Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Description] - [String]
                case SmbiosType026Property.Description:
                    value = Description;
                    break;
                #endregion

                #region [0x05] - [Location And Status]

                    #region [0x05] - [Location And Status -> Status] - [String]
                    case SmbiosType026Property.Status:
                        value = GetStatus(Status);
                        break;
                    #endregion

                    #region [0x05] - [Location And Status -> Location] - [String]
                    case SmbiosType026Property.Location:
                        value = GetLocation(Location);
                        break;
                    #endregion

                #endregion

                #region [0x06] - [Maximum Value] - [Int32?]
                case SmbiosType026Property.MaximunValue:
                    if (MaximunValue != 0x8000)
                    {
                        value = MaximunValue;
                    }
                    break;
                #endregion

                #region [0x08] - [Minimum Value] - [Int32?]
                case SmbiosType026Property.MinimunValue:
                    if (MinimunValue != 0x8000)
                    {
                        value = MinimunValue;
                    }
                    break;
                #endregion

                #region [0x0a] - [Resolution] - [Int32?]
                case SmbiosType026Property.Resolution:
                    if (Resolution != 0x8000)
                    {
                        value = Resolution;
                    }
                    break;
                #endregion

                #region [0x0c] - [Tolerance] - [Int32?]
                case SmbiosType026Property.Tolerance:
                    if (Tolerance != 0x8000)
                    {
                        value = Tolerance;
                    }
                    break;
                #endregion

                #region [0x0e] - [Accuracy] - [Int32?]
                case SmbiosType026Property.Accuracy:
                    if (Accuracy != 0x8000)
                    {
                        value = Accuracy;
                    }
                    break;
                #endregion

                #region [0x10] - [OEM-defined] - [Int64]
                case SmbiosType026Property.OemDefined:
                    value = OemDefined;
                    break;
                #endregion

                #region [0x14] - [Nominal Value] - [Int32?]
                case SmbiosType026Property.NominalValue:
                    if (HeaderInfo.Lenght >= 0x15)
                    {                                   
                        if (NominalValue != 0x8000)
                        {
                            value = NominalValue;
                        }
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
            properties.Add(KnownDmiProperty.VoltageProbe.Description, Description);
            properties.Add(KnownDmiProperty.VoltageProbe.LocationAndStatus.Status, GetStatus(Status));
            properties.Add(KnownDmiProperty.VoltageProbe.LocationAndStatus.Location, GetLocation(Location));

            if (MaximunValue != 0x8000)
            {
                properties.Add(KnownDmiProperty.VoltageProbe.MaximunValue, MaximunValue);
            }

            if (MinimunValue != 0x8000)
            {
                properties.Add(KnownDmiProperty.VoltageProbe.MinimunValue, MinimunValue);
            }

            if (Resolution != 0x8000)
            {
                properties.Add(KnownDmiProperty.VoltageProbe.Resolution, Resolution);
            }

            if (Tolerance != 0x8000)
            {
                properties.Add(KnownDmiProperty.VoltageProbe.Tolerance, Tolerance);
            }

            if (Accuracy != 0x8000)
            {
                properties.Add(KnownDmiProperty.VoltageProbe.Accuracy, Accuracy);
            }

            properties.Add(KnownDmiProperty.VoltageProbe.OemDefined, OemDefined);

            if (HeaderInfo.Lenght >= 0x15)
            {
                if (NominalValue != 0x8000)
                {
                    properties.Add(KnownDmiProperty.VoltageProbe.NominalValue, NominalValue);
                }
            }
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetLocation(byte): Gets a string representing the location.
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

        #region [private] {static} (string) GetStatus(byte): Gets a string representing the state of the test.
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
