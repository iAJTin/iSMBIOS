
using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 126: Inactive.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        126         Inactive structure indicator                          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        Varies      Length of the structure, a minimum of 0Bh             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure.                                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <inheritdoc/>
/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Inactive (Type 126) structure.
/// </summary>
internal class SmbiosType126 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType126"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType126(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this structure.
    /// </summary>
    /// <param name="properties">Collection of properties of this structure.</param>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        properties.Add(SmbiosProperty.Inactive.Description, "Inactive");
    }

    #endregion
}
