
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

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
    // | 04h          Count           BYTE        Varies      Número de cadenas                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode OEM Strings (Type 11) structure.
    /// </summary>
    sealed class SmbiosType011 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType011(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType011"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType011(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) Count: Gets a value representing the 'Socket Designation' field.
        /// <summary>
        /// Gets a value representing the <c>Socket Designation</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Count
        {
            get { return GetByte(0x04); }
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
            SmbiosType011Property propertyId = (SmbiosType011Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Values] - [ReadOnlyCollection<string>]
                case SmbiosType011Property.Values:
                    int count = Count;
                    if (count != 0)
                    {
                        value = GetValues(count);
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
            int count = Count;
            if (count != 0)
            {
                properties.Add(KnownDmiProperty.OemStrings.Values, GetValues(count));
            }
            #endregion
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (ReadOnlyCollection<string>) GetValues(int): Gets a collection with OEM information.
        /// <summary>
        /// Gets a collection with OEM information.
        /// </summary>
        /// <param name="count">Counter.</param>
        /// <returns>
        /// A collection with OEM information.
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
