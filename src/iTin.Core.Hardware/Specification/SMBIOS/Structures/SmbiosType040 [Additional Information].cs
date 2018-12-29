
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

    // Type 040: Additional Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        40          Additional Information type                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure, a minimum of 0Bh             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Number of       BYTE        Varies      The number of Additional Information Entries that     |
    // |              Additional                              follow                                                |
    // |              Information                             NOTE: Ver Count                                       |
    // |              entries (n)                                                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Additional      Varies      Varies      Additional Information entries.                       |
    // |              Information                                                                                   |
    // |              entries                                                                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Additional Information (Type 40) structure.
    /// </summary>
    sealed class SmbiosType040 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType040(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType040"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType040(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Count: Gets a value representing the 'Count' field.
        /// <summary>
        /// Gets a value representing the <c>Count</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Count
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
            SmbiosType040Property propertyId = (SmbiosType040Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x05] - [Additional Information Entries] - [AdditionalInformationEntryCollection]
                case SmbiosType040Property.Entries:
                    byte n = Count;
                    if (n != 0x00)
                    {
                        byte[] containedElementsArray = new byte[n * 6];
                        Array.Copy(HeaderInfo.RawData, 0x05, containedElementsArray, 0, n * 6);

                        IEnumerable<AdditionalInformationEntry> containedElements = GetContainedElements(containedElementsArray, n);
                        value =  new AdditionalInformationEntryCollection(containedElements);
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
            byte n = Count;
            if (n != 0x00)
            {
                byte[] containedElementsArray = new byte[n * 6];
                Array.Copy(HeaderInfo.RawData, 0x05, containedElementsArray, 0, n * 6);

                IEnumerable<AdditionalInformationEntry> containedElements = GetContainedElements(containedElementsArray, n);
                properties.Add(KnownDmiProperty.AdditionalInformation.Entries, new AdditionalInformationEntryCollection(containedElements));
            }
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (IEnumerable<AdditionalInformationEntry>) GetContainedElements(byte[], byte): Gets the list of additional entries.
        /// <summary>
        /// Gets the list of additional entries.
        /// </summary>
        /// <param name="rawValueArray">Raw information.</param>
        /// <param name="n">Number of items to be treated.</param>
        /// <returns>
        /// Item collection.
        /// </returns>
        private static IEnumerable<AdditionalInformationEntry> GetContainedElements(byte[] rawValueArray, byte n)
        {
            int m = rawValueArray.Length / n;
            Collection<AdditionalInformationEntry> containedElements = new Collection<AdditionalInformationEntry>();

            for (int i = 0; i < rawValueArray.Length; i = i + m)
            {
                byte[] value = new byte[m];
                Array.Copy(rawValueArray, i, value, 0, m);

                containedElements.Add(new AdditionalInformationEntry(value));
            }

            return containedElements;
        }
        #endregion

        #endregion
    }
}
