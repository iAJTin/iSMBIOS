
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Hardware Security (Type 24) structure.<br/>
/// For more information, please see <see cref="SmbiosType024"/>.
/// </summary>
internal sealed class DmiType024 : DmiBaseType<SmbiosType024>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType024"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType024(SmbiosType024 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.FrontPanelResetStatus));
        properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.AdministratorPasswordStatus));
        properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.KeyboardPasswordStatus));
        properties.Add(DmiProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus, SmbiosStructure.GetPropertyValue(SmbiosProperty.HardwareSecurity.HardwareSecuritySettings.PowerOnPasswordStatus));
    }
}
