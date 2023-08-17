
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the BIOS Language Information (Type 13) structure.<br/>
/// For more information, please see <see cref="SmbiosType013"/>.
/// </summary>
internal sealed class DmiType013 : DmiBaseType<SmbiosType013>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType013"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType013(SmbiosType013 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.v20)
        {
            return;
        }

        properties.Add(DmiProperty.BiosLanguage.InstallableLanguages, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.InstallableLanguages));
        properties.Add(DmiProperty.BiosLanguage.IsCurrentAbbreviated, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.IsCurrentAbbreviated));
        properties.Add(DmiProperty.BiosLanguage.Current, SmbiosStructure.GetPropertyValue(SmbiosProperty.BiosLanguage.Current));
    }
}
