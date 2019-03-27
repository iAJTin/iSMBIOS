
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

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
    class GroupAssociationElement
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _groupAssociationElement;
        #endregion

        #region constructor/s

        #region [internal] GroupAssociationElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the class <see cref="GroupAssociationElement" /> specifying the information of the structure.
        /// </summary>
        /// <param name="groupAssociationElement">Untreated information of the current structure.</param>
        internal GroupAssociationElement(byte[] groupAssociationElement)
        {
            _groupAssociationElement = groupAssociationElement;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (Hashtable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Available properties.
        /// </value>
        public Hashtable Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new Hashtable();
                    Parse(_properties);
                }

                return _properties;
            }
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) Handle: Gets a value that represents the 'Handle' field
        /// <summary>
        ///  Gets a value that represents the '<c>Handle</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Handle => LogicHelper.Word(_groupAssociationElement[0x01], _groupAssociationElement[0x02]);
        #endregion

        #region [private] (SmbiosStructure) ItemType: Gets a value that represents the 'ItemType' field
        /// <summary>
        ///  Gets a value that represents the '<c>ItemType</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SmbiosStructure ItemType => (SmbiosStructure)_groupAssociationElement[0x00];
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="T: System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.String" /> that represents the current <see cref = "T:iTin.Core.Hardware.Specification.Smbios.AdditionalInformationEntry"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the properties <see cref = "P:iTin.Core.Hardware.Specification.Smbios.GroupAssociationElement.ItemType" />
        /// and <see cref = "P:iTin.Core.Hardware.Specification.Smbios.GroupAssociationElement.Handle" />.
        /// </remarks>                                    
        public override string ToString() => $"Structure = {ItemType}, Handle = {Handle}";
        #endregion

        #endregion

        #region private methods

        #region [private] (void) Parse(Hashtable): Gets the property collection for this structure
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        private void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.GroupAssociations.Items.Structure, ItemType);
            properties.Add(KnownDmiProperty.GroupAssociations.Items.Handle, Handle);
            #endregion
        }
        #endregion
            
        #endregion
    }
}
