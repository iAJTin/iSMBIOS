﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios
{
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
    // |              Information                             NOTE: See Count                                       |
    // |              entries (n)                                                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Additional      Varies      Varies      Additional Information entries.                       |
    // |              Information                                                                                   |
    // |              entries                                                                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Additional Information (Type 40) structure.
    /// </summary>
    internal sealed class SmbiosType040 : SmbiosBaseType
    {
        #region constructor/s

        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType040"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType040(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }

        #endregion

        #region private properties

        /// <summary>
        /// Gets a value representing the <b>Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Count => Reader.GetByte(0x04);

        #endregion

        #region protected override methods

        /// <inheritdoc/>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
            {
                return;
            }

            byte n = Count;

            if (n == 0x00)
            {
                return;
            }

            byte[] containedElementsArray = StructureInfo.RawData.Extract(0x05, n * 6).ToArray();
            IEnumerable<AdditionalInformationEntry> containedElements = GetContainedElements(containedElementsArray, n);
            properties.Add(SmbiosProperty.AdditionalInformation.Entries, new AdditionalInformationEntryCollection(containedElements));
        }

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

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
            var containedElements = new Collection<AdditionalInformationEntry>();

            for (int i = 0; i < rawValueArray.Length; i += m)
            {
                byte[] value = new byte[m];
                Array.Copy(rawValueArray, i, value, 0, m);

                containedElements.Add(new AdditionalInformationEntry(value));
            }

            return containedElements;
        }

        #endregion
    }
}
