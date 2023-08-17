
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the System Boot Information (Type 32) structure.<br/>
/// For more information, please see <see cref="SmbiosType032"/>.
/// </summary>
internal sealed class DmiType032 : DmiBaseType<SmbiosType032>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType032"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType032(SmbiosType032 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.SystemBoot.BootStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemBoot.BootStatus));
    }
}
