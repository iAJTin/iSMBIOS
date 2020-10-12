
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 044: Processor Additional Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        44          Processor Additional Information                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        6 + Y       Length of the structure. Y is the length of Processor |
    // |                                                      specific Block specified at offset 06h.               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      Handle, or instance number, associated with the       |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Referenced      WORD        Varies      Handle, or instance number, associated with the       |
    // |              Handle                                  Processor structure (SMBIOS type 4) which the         |
    // |                                                      Processor Additional Information structure describes. |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Processor       Varies      Varies      Processor-specific block.                             |
    // |              Specific        (Y)                                                                           |
    // |              Block                                                                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Processor Additional Information (Type 44) structure.
    /// </summary>
    internal sealed class SmbiosType044 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType044(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType044"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType044(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Length: Gets a value representing the 'Length' field
        /// <summary>
        ///  Gets a value representing the <b>Length</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Length => Reader.GetByte(0x01);
        #endregion

        #region [private] (ushort) ReferencedHandle: Gets a value representing the 'Referenced Handle' field
        /// <summary>
        ///  Gets a value representing the <b>Referenced Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ReferencedHandle => (ushort)Reader.GetWord(0x04);
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
            properties.Add(SmbiosProperty.ProcessorAdditionalInformation.ReferencedHandle, ReferencedHandle);
            properties.Add(SmbiosProperty.ProcessorAdditionalInformation.ProcessorSpecificBlock, new ProcessorSpecificInformationBlock(Reader.GetBytes(0x06, (byte)(Length - 6))));
        }
        #endregion

        #endregion
    }
}
