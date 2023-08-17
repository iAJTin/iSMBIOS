
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Management Device Threshold Data (Type 36) structure.<br/>
/// For more information, please see <see cref="SmbiosType036"/>.
/// </summary>
internal sealed class DmiType036 : DmiBaseType<SmbiosType036>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType036"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType036(SmbiosType036 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion < DmiStructureVersion.Latest)
        {
            return;
        }

        ushort lowerNonCritical = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.LowerNonCritical);
        if (lowerNonCritical != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.LowerNonCritical, lowerNonCritical);
        }

        ushort upperNonCritical = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.UpperNonCritical);
        if (upperNonCritical != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.UpperNonCritical, upperNonCritical);
        }

        ushort lowerCritical = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.LowerCritical);
        if (lowerCritical != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.LowerCritical, lowerCritical);
        }

        ushort upperCritical = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.UpperCritical);
        if (upperCritical != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.UpperCritical, upperCritical);
        }

        ushort lowerNonRecoverable = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.LowerNonRecoverable);
        if (lowerNonRecoverable != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.LowerNonRecoverable, lowerNonRecoverable);
        }

        ushort upperNonRecoverable = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.ManagementDeviceThresholdData.UpperNonRecoverable);
        if (upperNonRecoverable != 0x8000)
        {
            properties.Add(DmiProperty.ManagementDeviceThresholdData.UpperNonRecoverable, upperNonRecoverable);
        }
    }
}
