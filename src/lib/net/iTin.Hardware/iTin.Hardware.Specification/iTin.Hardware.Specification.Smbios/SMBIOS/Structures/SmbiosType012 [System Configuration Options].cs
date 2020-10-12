
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Property;

    // Type 012: System Configuration Options.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        12          Configuration Information Indicator                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        05h                                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Count           BYTE        Varies      Strings number                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Configuration Options (Type 12) structure.
    /// </summary>
    internal sealed class SmbiosType012 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType012(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType012"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType012(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) Count: Gets a value representing the 'Count' field
        /// <summary>
        /// Gets a value representing the <b>Count</b> field.
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
                properties.Add(SmbiosProperty.SystemConfigurationOptions.Values, GetValues(count));
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] (ReadOnlyCollection<string>) GetValues(int): Gets a collection with system information
        /// <summary>
        /// Gets a collection with system information.
        /// </summary>
        /// <param name="count">Counter.</param>
        /// <returns>
        /// A collection with system information.
        /// </returns>
        private ReadOnlyCollection<string> GetValues(int count)
        {
            List<string> items = new List<string>();

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
