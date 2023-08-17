
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Voltage Probe (Type 26) structure.<br/>
/// For more information, please see <see cref="SmbiosType026"/>.
/// </summary>
internal sealed class DmiType026 : DmiBaseType<SmbiosType026>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType026"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType026(SmbiosType026 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        if (ImplementedVersion >= DmiStructureVersion.Latest)
        {
            properties.Add(DmiProperty.VoltageProbe.Description, SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.Description));
            properties.Add(DmiProperty.VoltageProbe.LocationAndStatus.Status, SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.LocationAndStatus.Status));
            properties.Add(DmiProperty.VoltageProbe.LocationAndStatus.Location, SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.LocationAndStatus.Location));

            ushort maximumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.MaximumValue);
            if (maximumValue != 0x8000)
            {
                properties.Add(DmiProperty.VoltageProbe.MaximumValue, maximumValue);
            }

            ushort minimumValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.MinimumValue);
            if (minimumValue != 0x8000)
            {
                properties.Add(DmiProperty.VoltageProbe.MinimumValue, minimumValue);
            }

            ushort resolution = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.Resolution);
            if (resolution != 0x8000)
            {
                properties.Add(DmiProperty.VoltageProbe.Resolution, resolution);
            }

            ushort tolerance = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.Tolerance);
            if (tolerance != 0x8000)
            {
                properties.Add(DmiProperty.VoltageProbe.Tolerance, tolerance);
            }

            ushort accuracy = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.Accuracy);
            if (accuracy != 0x8000)
            {
                properties.Add(DmiProperty.VoltageProbe.Accuracy, accuracy);
            }

            properties.Add(DmiProperty.VoltageProbe.OemDefined, SmbiosStructure.GetPropertyValue(SmbiosProperty.VoltageProbe.OemDefined));
        }

        if (SmbiosStructure.StructureInfo.Length < 0x15)
        {
            return;
        }

        ushort nominalValue = SmbiosStructure.GetPropertyValue<ushort>(SmbiosProperty.VoltageProbe.NominalValue);
        if (nominalValue != 0x8000)
        {
            properties.Add(DmiProperty.VoltageProbe.NominalValue, nominalValue);
        }
    }
}
