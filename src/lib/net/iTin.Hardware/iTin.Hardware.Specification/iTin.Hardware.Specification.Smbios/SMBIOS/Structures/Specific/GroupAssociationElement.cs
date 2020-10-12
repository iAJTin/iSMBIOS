
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 014: Group Associations. Contained Elements
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Item Type       BYTE        Varies      Item (Structure) Type of this member                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Item Handle     WORD        Varies      Handle corresponding to this structure                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents an element of the structure <see cref="SmbiosType014"/>.
    /// </summary>
    public class GroupAssociationElement : SpecificSmbiosBaseType
    {
        #region constructor/s

        #region [internal] GroupAssociationElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="GroupAssociationElement"/> specifying the information of the structure.
        /// </summary>
        /// <param name="groupAssociationElement">Untreated information of the current structure.</param>
        internal GroupAssociationElement(byte[] groupAssociationElement) : base(groupAssociationElement)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (ushort) Handle: Gets a value that represents the 'Handle' field
        /// <summary>
        ///  Gets a value that represents the '<b>Handle</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort Handle => (ushort)GetWord(0x01);
        #endregion

        #region [private] (SmbiosStructure) ItemType: Gets a value that represents the 'ItemType' field
        /// <summary>
        ///  Gets a value that represents the '<b>ItemType</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SmbiosStructure ItemType => (SmbiosStructure)GetByte(0x00);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="T: System.String"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref = "AdditionalInformationEntry"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the properties <see cref="ItemType"/>
        /// and <see cref="Handle"/>.
        /// </remarks>                                    
        public override string ToString() => $"Structure = {ItemType}, Handle = {Handle}";
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
            properties.Add(SmbiosProperty.GroupAssociations.Items.Structure, ItemType);
            properties.Add(SmbiosProperty.GroupAssociations.Items.Handle, Handle);
        }
        #endregion
            
        #endregion
    }
}
