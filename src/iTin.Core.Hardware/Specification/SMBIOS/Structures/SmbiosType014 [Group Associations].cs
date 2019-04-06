
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 014: Group Associations.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        14          Group Associations Indicator                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      5 + (3 bytes for each item in the group).             |
    // |                                                      The user of this structure determines the number of   |
    // |                                                      items as (Length - 5) / 3.                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Group Name      BYTE        STRING      String number of string describing the group          |
    // |                                                      Note: Ver GroupName                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Item Type       BYTE        Varies      Item (Structure) Type of this member                  |
    // |                                                      Note: Ver GetContainedElements(byte[], int)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Item Handle     WORD        Varies      Handle corresponding to this structure                |
    // |                                                      Note: Ver GetContainedElements(byte[], int)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Group Associations (Type 14) structure.
    /// </summary>
    sealed class SmbiosType014 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType014(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType014" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType014(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) GroupName: Gets a value representing the 'Group Name' field
        /// <summary>
        /// Gets a value representing the <c>Group Name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string GroupName => GetString(0x04);
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
            SmbiosType014Property propertyId = (SmbiosType014Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Group Name] - [string]
                case SmbiosType014Property.GroupName:
                    value = GroupName;
                    break;
                #endregion

                #region [0x05] - [Contained Elements] - [GroupAssociationElementCollection]
                case SmbiosType014Property.ContainedElements:
                    int n = (HeaderInfo.Length - 5) / 3;
                    byte[] containedElementsArray = new byte[n * 3];
                    Array.Copy(HeaderInfo.RawData, 0x05, containedElementsArray, 0, n * 3);

                    IEnumerable<GroupAssociationElement> containedElements = GetContainedElements(containedElementsArray, n);
                    value = new GroupAssociationElementCollection(containedElements);
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure
        /// <inheritdoc />
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
            properties.Add(KnownDmiProperty.GroupAssociations.GroupName, GroupName);

            int n = (HeaderInfo.Length - 5) / 3;
            byte[] containedElementsArray = new byte[n * 3];
            Array.Copy(HeaderInfo.RawData, 0x05, containedElementsArray, 0, n * 3);

            IEnumerable<GroupAssociationElement> containedElements = GetContainedElements(containedElementsArray, n);
            properties.Add(KnownDmiProperty.GroupAssociations.ContainedElements, new GroupAssociationElementCollection(containedElements));
            #endregion
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<ChassisContainedElement>) GetContainedElements(byte[], int): Gets the list of items that this group contains
        /// <summary>
        /// Gets the list of items that this group contains.
        /// </summary>
        /// <param name="rawValueArray">Raw information.</param>
        /// <param name="n">Number of items to be treated.</param>
        /// <returns>
        /// Collection of elements contained in this group.
        /// </returns>
        private static IEnumerable<GroupAssociationElement> GetContainedElements(byte[] rawValueArray, int n)
        {
            int m = rawValueArray.Length / n;
            Collection<GroupAssociationElement> containedElements = new Collection<GroupAssociationElement>();

            for (int i = 0; i < rawValueArray.Length; i += m)
            {
                byte[] value = new byte[m];
                Array.Copy(rawValueArray, i, value, 0, m);

                containedElements.Add(new GroupAssociationElement(value));
            }

            return containedElements;
        }
        #endregion

        #endregion
    }
}
