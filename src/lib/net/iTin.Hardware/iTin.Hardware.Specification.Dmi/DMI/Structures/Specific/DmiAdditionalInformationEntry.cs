
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// This class represents an element of the structure <see cref="DmiType040"/>.
/// </summary>
public class DmiAdditionalInformationEntry
{
    #region private members
    private readonly SmbiosPropertiesTable _reference;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DmiAdditionalInformationEntry"/> class specifying the structure information.
    /// </summary>
    /// <param name="reference"><b>SMBIOS</b> properties.</param>
    internal DmiAdditionalInformationEntry(SmbiosPropertiesTable reference)
    {
        _reference = reference;
    }

    #endregion

    #region public properties

    /// <summary>
    /// Gets the properties available for this structure.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    public DmiClassPropertiesTable Properties =>
        new()
        {
            {DmiProperty.AdditionalInformation.Entry.EntryLength, _reference[SmbiosProperty.AdditionalInformation.Entry.EntryLength]},
            {DmiProperty.AdditionalInformation.Entry.ReferencedHandle, _reference[SmbiosProperty.AdditionalInformation.Entry.ReferencedHandle]},
            {DmiProperty.AdditionalInformation.Entry.ReferencedOffset, _reference[SmbiosProperty.AdditionalInformation.Entry.ReferencedOffset]},
            {DmiProperty.AdditionalInformation.Entry.StringValue, _reference[SmbiosProperty.AdditionalInformation.Entry.StringValue]},
            {DmiProperty.AdditionalInformation.Entry.Value, _reference[SmbiosProperty.AdditionalInformation.Entry.Value]}
        };

    #endregion
}
