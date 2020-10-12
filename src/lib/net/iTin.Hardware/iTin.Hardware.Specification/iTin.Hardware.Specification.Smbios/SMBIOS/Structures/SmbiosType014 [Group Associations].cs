
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;

    using Property;

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
    // |                                                      Note: See GroupName                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Item Type       BYTE        Varies      Item (Structure) Type of this member                  |
    // |                                                      Note: See GetContainedElements(byte[], int)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Item Handle     WORD        Varies      Handle corresponding to this structure                |
    // |                                                      Note: See GetContainedElements(byte[], int)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Group Associations (Type 14) structure.
    /// </summary>
    internal sealed class SmbiosType014 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType014(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType014"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType014(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) GroupName: Gets a value representing the 'Group Name' field
        /// <summary>
        /// Gets a value representing the <b>Group Name</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string GroupName => GetString(0x04);
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
            properties.Add(SmbiosProperty.GroupAssociations.GroupName, GroupName);

            int n = (StructureInfo.Length - 5) / 3;
            byte[] containedElementsArray = StructureInfo.RawData.Extract(0x05, n * 3).ToArray();
            IEnumerable<GroupAssociationElement> containedElements = GetContainedElements(containedElementsArray, n);
            properties.Add(SmbiosProperty.GroupAssociations.ContainedElements, new GroupAssociationElementCollection(containedElements));
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

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
                byte[] value = rawValueArray.Extract(i, m).ToArray();
                containedElements.Add(new GroupAssociationElement(value));
            }

            return containedElements;
        }
        #endregion

        #endregion
    }
}
