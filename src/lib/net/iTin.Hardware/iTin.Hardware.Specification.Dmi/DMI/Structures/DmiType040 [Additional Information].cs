
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Additional Information (Type 40) structure.<br/>
/// For more information, please see <see cref="SmbiosType040"/>.
/// </summary>
internal sealed class DmiType040: DmiBaseType<SmbiosType040>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType040"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType040(SmbiosType040 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.AdditionalInformation.Entries, new DmiAdditionalInformationEntryCollection((AdditionalInformationEntryCollection)SmbiosStructure.GetPropertyValue(SmbiosProperty.AdditionalInformation.Entries)));
    }
}
