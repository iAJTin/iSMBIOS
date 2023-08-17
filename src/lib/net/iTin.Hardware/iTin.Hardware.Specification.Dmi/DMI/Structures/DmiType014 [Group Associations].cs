
using iTin.Hardware.Specification.Dmi.Property;

using iTin.Hardware.Specification.Smbios;
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Specialization of the <see cref="DmiBaseType{T}"/> class that contains the logic to decode the Group Associations (Type 14) structure.<br/>
/// For more information, please see <see cref="SmbiosType014"/>.
/// </summary>
internal sealed class DmiType014 : DmiBaseType<SmbiosType014>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DmiType014"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructure">Formatted structure information.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public DmiType014(SmbiosType014 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
    {
    }

    /// <inheritdoc/>
    protected override void PopulateProperties(DmiClassPropertiesTable properties)
    {
        properties.Add(DmiProperty.GroupAssociations.GroupName, SmbiosStructure.GetPropertyValue(SmbiosProperty.GroupAssociations.GroupName));

        object containedElements = SmbiosStructure.GetPropertyValue(SmbiosProperty.GroupAssociations.ContainedElements);
        properties.Add(DmiProperty.GroupAssociations.ContainedElements, new DmiGroupAssociationElementCollection((GroupAssociationElementCollection)containedElements));
    }
}
