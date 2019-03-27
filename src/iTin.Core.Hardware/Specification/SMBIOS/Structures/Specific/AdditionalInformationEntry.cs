
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 040: Additional Information. Additional Information Entry
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset     Name            Length      Value       Description                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h        Entry Length    BYTE        Varies      Length of this Additional Information Entry instance;   |
    // |                                                    a minimum of 6                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h        Referenced      WORD        Varies      The handle, or instance number, associated with the     |
    // |            Handle                                  structure for which additional information is provided  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h        Referenced      BYTE        Varies      The offset of the field within the structure referenced |
    // |            Offset                                  by the Referenced Handle for which additional           |
    // |                                                    information is provided                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h        String          BYTE        STRING      The number of the optional string to be associated with |
    // |                                                    the field referenced by the Referenced Offset           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h        Value           Varies      Varies      The enumerated value or updated field content that has  |
    // |                                                    not yet been approved for publication in this           |
    // |                                                    specification and therefore could not be used in the    |
    // |                                                    field referenced by Referenced Offset.                  |
    // |                                                    NOTE: This field is the same type and size as the field |
    // |                                                          being referenced by this Additional Information   |
    // |                                                          Entry.                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents an element of the structure <see cref="SmbiosType040" />.
    /// </summary>
    class AdditionalInformationEntry
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _properties;
        #endregion

        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _additionalInformationEntryArray;
        #endregion

        #region constructor/s

        #region [internal] AdditionalInformationEntry(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the <see cref="AdditionalInformationEntry"/> class specifying the structure information.
        /// </summary>
        /// <param name="additionalInformationEntryArray">Untreated information of the current structure.</param>
        internal AdditionalInformationEntry(byte[] additionalInformationEntryArray)
        {
            _additionalInformationEntryArray = additionalInformationEntryArray;
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

        #region [private] (byte) EntryLength: Gets a value that represents the 'Entry Length' field
        /// <summary>
        /// Gets a value that represents the <c>Entry Length</c> field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EntryLength => _additionalInformationEntryArray[0x00];
        #endregion

        #region [private] (int) ReferencedHandle: Gets a value that represents the 'Referenced Handle' field
        /// <summary>
        /// Gets a value that represents the '<c>Referenced Handle</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ReferencedHandle => LogicHelper.AWord(_additionalInformationEntryArray, 0x01);
        #endregion

        #region [private] (byte) ReferencedOffset: Gets a value that represents the 'Referenced Offset' field
        /// <summary>
        /// Gets a value that represents the '<c>Referenced Offset</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ReferencedOffset => _additionalInformationEntryArray[0x03];
        #endregion

        #region [private] (string) StringValue: Gets a value that represents the 'String' field
        /// <summary>
        /// Gets a value that represents the '<c>String</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string StringValue => string.Empty;
        #endregion

        #region [private] (byte) Value: Gets a value that represents the 'Value' field
        /// <summary>
        /// Gets a value that represents the '<c>Value</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Value => _additionalInformationEntryArray[0x05];
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
        /// This method returns a string that includes the property <see cref = "P:iTin.Core.Hardware.Specification.Smbios.AdditionalInformationEntry.Value" />.
        /// </remarks>                                    
        public override string ToString() => $"Value = {Value}";
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
            properties.Add(KnownDmiProperty.AdditionalInformation.Entry.EntryLength, EntryLength);
            properties.Add(KnownDmiProperty.AdditionalInformation.Entry.ReferencedHandle, ReferencedHandle);
            properties.Add(KnownDmiProperty.AdditionalInformation.Entry.ReferencedOffset, ReferencedOffset);
            properties.Add(KnownDmiProperty.AdditionalInformation.Entry.StringValue, StringValue);
            properties.Add(KnownDmiProperty.AdditionalInformation.Entry.Value, Value);
            #endregion
        }
        #endregion
            
        #endregion
    }
}
