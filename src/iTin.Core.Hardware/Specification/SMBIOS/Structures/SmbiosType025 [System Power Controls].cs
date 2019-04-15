
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 025: System Power Controls.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        25          System Power Controls indicator                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        09h         Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Next Scheduled  BYTE        Varies      Contains the BCD value of the month on which the next |
    // |              Power-on Month                          scheduled power-on is to occur, in the range 01h to   |
    // |                                                      12h.                                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Next Scheduled  BYTE        Varies      Contains the BCD value of the day-of-month on which   |
    // |              Power-on Day-of                         the next scheduled power-on is to occur, in the range |
    // |              -month                                  01h to 31h.                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Next Scheduled  BYTE        Varies      Contains the BCD value of the hour on which the next  |
    // |              Power-on Hour                           scheduled power-on is to occur, in the range 00h to   |
    // |                                                      23h.                                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Next Scheduled  BYTE        Varies      Contains the BCD value of the minute on which the next|
    // |              Power-on Minute                         scheduled power-on is to occur, in the range 00h to   |
    // |                                                      59h.                                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Next Scheduled  BYTE        Varies      Contains the BCD value of the second on which the next|
    // |              Power-on Second                         scheduled power-on is to occur, in the range 00h to   |
    // |                                                      59h.                                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Power Controls (Type 25) structure.
    /// </summary>
    sealed class SmbiosType025 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType025(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType025" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType025(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Month: Gets a value representing the 'Month' field
        /// <summary>
        /// Gets a value representing the <c>Month</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Month => GetByte(0x04);
        #endregion

        #region [private] (byte) Day: Gets a value representing the 'Day' field
        /// <summary>
        /// Gets a value representing the <c>Day</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Day => GetByte(0x05);
        #endregion

        #region [private] (byte) Hour: Gets a value representing the 'Hour' field
        /// <summary>
        /// Gets a value representing the <c>Hour</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Hour => GetByte(0x06);
        #endregion

        #region [private] (byte) Minute: Gets a value representing the 'Minute' field
        /// <summary>
        /// Gets a value representing the <c>Minute</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Minute => GetByte(0x07);
        #endregion

        #region [private] (byte) Second: Gets a value representing the 'Second' field
        /// <summary>
        /// Gets a value representing the <c>Second</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Second => GetByte(0x08);
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
            SmbiosType025Property propertyId = (SmbiosType025Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Next Scheduled Power-On Month] - [Byte]
                case SmbiosType025Property.Month:
                    value = Month;
                    break;
                #endregion

                #region [0x05] - [Next Scheduled Power-On Day Of Month] - [Byte]
                case SmbiosType025Property.Day:
                    value = Day;
                    break;
                #endregion

                #region [0x06] - [Next Scheduled Power-On Hour] - [Byte]
                case SmbiosType025Property.Hour:
                    value = Hour;
                    break;
                #endregion

                #region [0x07] - [Next Scheduled Power-On Minute] - [Byte]
                case SmbiosType025Property.Minute:
                    value = Minute;
                    break;
                #endregion

                #region [0x08] - [Next Scheduled Power-On Second] - [Byte]
                case SmbiosType025Property.Second:
                    value = Second;
                    break;
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
            properties.Add(KnownDmiProperty.SystemPowerControls.Month, Month);
            properties.Add(KnownDmiProperty.SystemPowerControls.Day, Day);
            properties.Add(KnownDmiProperty.SystemPowerControls.Hour, Hour);
            properties.Add(KnownDmiProperty.SystemPowerControls.Minute, Minute);
            properties.Add(KnownDmiProperty.SystemPowerControls.Second, Second);
            #endregion
        }
        #endregion

        #endregion
    }
}
