
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;

    using Property;

    // Type 037: Memory Channel.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        37          Management Device Threshold Data structure indicator. |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE                    7 + 3 * (Memory Device Count)                         |
    // |                                                                                                            |
    // |                                                      NOTE: To allow future structure growth by appending   |
    // |                                                            information after the Load/Handle list, this    |
    // |                                                            field must not be used to determine the number  |
    // |                                                            of memory devices specified within the          |
    // |                                                            structure.                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Channel         BYTE        Varies      Identifies the type of memory associated with the     |
    // |              Type                                    channel.                                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Maximum         BYTE        Varies      The maximum load supported by the channel; the sum of |
    // |              Channel                                 all device loads cannot exceed this value.            |
    // |              Load                                                                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Memory          BYTE        Varies      The channel load provided by the first Memory Device  |
    // |              Device                                  associated with this channel.                         |
    // |              Count (n)                               This value also defines the number of Load/Handle     |
    // |                                                      pairs that follow.                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Memory          BYTE        Varies      The channel load provided by the first Memory Device  |
    // |              Device 1                                associated with this channel.                         |
    // |              Load                                                                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Memory          WORD        Varies      The structure handle that identifies the first Memory |
    // |              Device 1                                Device associated with this channel.                  |
    // |              Handle                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 7 +          Memory          BYTE        Varies      The channel load provided by the nth Memory Device    |
    // | 3*(n-1)      Device (n)                              associated with this channel.                         |
    // |              Load                                                                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 8 +          Memory          WORD        Varies      The structure handle that identifies the nth Memory   |
    // | 3*(n-1)      Device (n)                              Device associated with this channel.                  |
    // |              Handle                                                                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Memory Channel (Type 37) structure.
    /// </summary>
    internal sealed class SmbiosType037 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType037(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType037"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType037(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) ChannelType: Gets a value representing the 'Channel Type' field
        /// <summary>
        /// Gets a value representing the <b>Channel Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ChannelType => Reader.GetByte(0x04);
        #endregion

        #region [private] (byte) MaximunChannelLoad: Gets a value representing the 'Maximun Channel Load' field
        /// <summary>
        /// Gets a value representing the <b>Maximun Channel Load</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MaximunChannelLoad => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) Count: Gets a value representing the 'Count' field
        /// <summary>
        /// Gets a value representing the <b>Count</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Count => Reader.GetByte(0x06);
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
            if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
            {
                return;
            }

            properties.Add(SmbiosProperty.MemoryChannel.ChannelType, GetChannelType(ChannelType));
            properties.Add(SmbiosProperty.MemoryChannel.MaximumChannelLoad, MaximunChannelLoad);

            byte n = Count;
            if (n == 0x00)
            {
                return;
            }

            if (StructureInfo.Length >= 0x08)
            {
                byte[] containedElementsArray = StructureInfo.RawData.Extract(0x07, n * 3).ToArray();
                IEnumerable<MemoryChannelElement> containedElements = GetContainedElements(containedElementsArray, n);
                properties.Add(SmbiosProperty.MemoryChannel.Devices, new MemoryChannelElementCollection(containedElements));
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetChannelType(byte): Gets a string representing the channel type
        /// <summary>
        /// Gets a string representing the channel type
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Channel type.
        /// </returns>
        private static string GetChannelType(byte code)
        {
            string[] value =
            {
                "Other",     // 0x01
                "Unknown",
                "RamBus",
                "SyncLink"   // 0x04
            };

            if (code >= 0x01 && code <= 0x04)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (IEnumerable<MemoryChannelElement>) GetContainedElements(byte[], byte): Gets the list of devices
        /// <summary>
        /// Gets the list of devices.
        /// </summary>
        /// <param name="rawValueArray">Raw information.</param>
        /// <param name="n">Number of items to be treated.</param>
        /// <returns>
        /// Item collection.
        /// </returns>
        private static IEnumerable<MemoryChannelElement> GetContainedElements(byte[] rawValueArray, byte n)
        {
            int m = rawValueArray.Length / n;
            Collection<MemoryChannelElement> containedElements = new Collection<MemoryChannelElement>();

            for (int i = 0; i < rawValueArray.Length; i += m)
            {
                byte[] value = new byte[m];
                Array.Copy(rawValueArray, i, value, 0, m);

                containedElements.Add(new MemoryChannelElement(value));
            }

            return containedElements;
        }
        #endregion

        #endregion
    }
}
