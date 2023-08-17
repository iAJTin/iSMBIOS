﻿
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Processor Additional Information (Type 44) structure.<br/>
/// For more information, please see <see cref="SmbiosType044"/>.
/// </summary>
internal sealed class DmiType044: DmiBaseType<SmbiosType044>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType044"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType044(SmbiosType044 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        object referenceHandle = SmbiosStructure.GetPropertyValue(SmbiosProperty.ProcessorAdditionalInformation.ReferencedHandle);
        if (referenceHandle != null)
        {
            properties.Add(DmiProperty.ProcessorAdditionalInformation.ReferencedHandle, referenceHandle);
        }
            
        properties.Add(DmiProperty.ProcessorAdditionalInformation.ProcessorSpecificBlock, SmbiosStructure.GetPropertyValue(SmbiosProperty.ProcessorAdditionalInformation.ProcessorSpecificBlock));
    }
}
