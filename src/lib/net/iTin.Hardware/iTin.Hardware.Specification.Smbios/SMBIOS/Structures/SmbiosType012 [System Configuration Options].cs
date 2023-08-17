
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 012: System Configuration Options.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        12          Configuration Information Indicator                   |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        05h                                                               |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies                                                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Count           BYTE        Varies      Strings number                                        |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Configuration Options (Type 12) structure.
/// </summary>
internal sealed class SmbiosType012 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType012"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType012(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Count</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int Count => Reader.GetByte(0x04);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        int count = Count;
        if (count != 0)
        {
            properties.Add(SmbiosProperty.SystemConfigurationOptions.Values, GetValues(count));
        }
    }

    #endregion


    #region BIOS Specification 2.7.1 (26/01/2011)

    /// <summary>
    /// Gets a collection with system information.
    /// </summary>
    /// <param name="count">Counter.</param>
    /// <returns>
    /// A collection with system information.
    /// </returns>
    private ReadOnlyCollection<string> GetValues(int count)
    {
        List<string> items = new List<string>();

        for (int i = 1; i <= count; i++)
        {
            items.Add(Strings[i]);
        }

        return items.AsReadOnly();
    }

    #endregion
}
