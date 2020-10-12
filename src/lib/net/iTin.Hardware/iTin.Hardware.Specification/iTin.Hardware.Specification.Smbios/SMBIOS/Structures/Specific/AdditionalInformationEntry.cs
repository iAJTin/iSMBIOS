
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

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
    /// This class represents an element of the structure <see cref="SmbiosType040"/>.
    /// </summary>
    public class AdditionalInformationEntry : SpecificSmbiosBaseType
    {
        #region constructor/s

        #region [internal] AdditionalInformationEntry(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the <see cref="AdditionalInformationEntry"/> class specifying the structure information.
        /// </summary>
        /// <param name="additionalInformationEntryArray">Untreated information of the current structure.</param>
        internal AdditionalInformationEntry(byte[] additionalInformationEntryArray) : base(additionalInformationEntryArray)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) EntryLength: Gets a value that represents the 'Entry Length' field
        /// <summary>
        /// Gets a value that represents the <b>Entry Length</b> field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EntryLength => GetByte(0x00);
        #endregion

        #region [private] (ushort) ReferencedHandle: Gets a value that represents the 'Referenced Handle' field
        /// <summary>
        /// Gets a value that represents the '<b>Referenced Handle</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ReferencedHandle => (ushort)GetWord(0x01);
        #endregion

        #region [private] (byte) ReferencedOffset: Gets a value that represents the 'Referenced Offset' field
        /// <summary>
        /// Gets a value that represents the '<b>Referenced Offset</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ReferencedOffset => GetByte(0x03);
        #endregion

        #region [private] (string) StringValue: Gets a value that represents the 'String' field
        /// <summary>
        /// Gets a value that represents the '<b>String</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string StringValue => string.Empty;
        #endregion

        #region [private] (byte) Value: Gets a value that represents the 'Value' field
        /// <summary>
        /// Gets a value that represents the '<b>Value</b>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Value => GetByte(0x05);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntry"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref="P:iTin.Hardware.Specification.Smbios.AdditionalInformationEntry.Value"/>.
        /// </remarks>                                    
        public override string ToString() => $"Value = {Value}";
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
            properties.Add(SmbiosProperty.AdditionalInformation.Entry.EntryLength, EntryLength);
            properties.Add(SmbiosProperty.AdditionalInformation.Entry.ReferencedHandle, ReferencedHandle);
            properties.Add(SmbiosProperty.AdditionalInformation.Entry.ReferencedOffset, ReferencedOffset);
            properties.Add(SmbiosProperty.AdditionalInformation.Entry.StringValue, StringValue);
            properties.Add(SmbiosProperty.AdditionalInformation.Entry.Value, Value);
        }
        #endregion
            
        #endregion
    }
}
