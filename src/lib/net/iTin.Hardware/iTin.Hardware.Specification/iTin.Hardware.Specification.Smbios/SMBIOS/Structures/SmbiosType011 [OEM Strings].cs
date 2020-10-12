
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Property;

    // Type 011: OEM Strings.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        11          OEM Strings Indicator                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        05h                                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Count           BYTE        Varies      String's number                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode OEM Strings (Type 11) structure
    /// </summary>
    internal sealed class SmbiosType011 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType011(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType011"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType011(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) Count: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <b>Socket Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Count => Reader.GetByte(0x04);
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
            int count = Count;
            if (count != 0)
            {
                properties.Add(SmbiosProperty.OemStrings.Values, GetValues(count));
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] (ReadOnlyCollection<string>) GetValues(int): Gets a collection with OEM information
        /// <summary>
        /// Gets a collection with OEM information.
        /// </summary>
        /// <param name="count">Counter.</param>
        /// <returns>
        /// A collection with OEM information.
        /// </returns>
        private ReadOnlyCollection<string> GetValues(int count)
        {
            var items = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                items.Add(Strings[i]);
            }

            return items.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
