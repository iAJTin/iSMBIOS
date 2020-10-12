
namespace iTin.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <summary>
    /// This class represents an element of the structure <see cref="DmiType040"/>.
    /// </summary>
    public class DmiAdditionalInformationEntry
    {
        #region private members
        private readonly SmbiosPropertiesTable _reference;
        #endregion

        #region constructor/s

        #region [internal] DmiAdditionalInformationEntry(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initialize a new instance of the <see cref="DmiAdditionalInformationEntry"/> class specifying the structure information.
        /// </summary>
        /// <param name="reference"><b>SMBIOS</b> properties.</param>
        internal DmiAdditionalInformationEntry(SmbiosPropertiesTable reference)
        {
            _reference = reference;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DmiClassPropertiesTable) Properties: Gets the properties available for this structure
        /// <summary>
        /// Gets the properties available for this structure.
        /// </summary>
        /// <value>
        /// Availables properties.
        /// </value>
        public DmiClassPropertiesTable Properties =>
            new DmiClassPropertiesTable
            {
                {DmiProperty.AdditionalInformation.Entry.EntryLength, _reference[SmbiosProperty.AdditionalInformation.Entry.EntryLength]},
                {DmiProperty.AdditionalInformation.Entry.ReferencedHandle, _reference[SmbiosProperty.AdditionalInformation.Entry.ReferencedHandle]},
                {DmiProperty.AdditionalInformation.Entry.ReferencedOffset, _reference[SmbiosProperty.AdditionalInformation.Entry.ReferencedOffset]},
                {DmiProperty.AdditionalInformation.Entry.StringValue, _reference[SmbiosProperty.AdditionalInformation.Entry.StringValue]},
                {DmiProperty.AdditionalInformation.Entry.Value, _reference[SmbiosProperty.AdditionalInformation.Entry.Value]}
            };
        #endregion

        #endregion
    }
}
