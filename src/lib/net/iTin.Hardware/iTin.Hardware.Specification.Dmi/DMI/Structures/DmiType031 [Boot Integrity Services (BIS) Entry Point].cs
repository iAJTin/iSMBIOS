
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Boot Integrity Services (BIS) Entry Point (Type 31) structure.<br/>
/// For more information, please see <see cref="SmbiosType031"/>.
/// </summary>
internal sealed class DmiType031 : DmiBaseType<SmbiosType031>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType031"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType031(SmbiosType031 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion <= DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.Checksum, SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.Checksum));
        properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress16, SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress16));
        properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress32, SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress32));
    }
}
