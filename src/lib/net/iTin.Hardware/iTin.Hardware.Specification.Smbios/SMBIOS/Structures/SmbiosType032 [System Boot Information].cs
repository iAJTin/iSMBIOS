﻿
using System.Diagnostics;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 032: System Boot Information.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name            Length      Value       Description                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Type            BYTE        32          System Boot Information structure identifier          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Length          BYTE        Varies      Length of the structure, at least 14h                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
// |                                                      structure                                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Reserved        6 BYTEs     00h         Reserved for future assignment by this specification; |
// |                                                      all bytes are set to 00h.                             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ah          Boot Status     10 BYTEs    Varies      The Status and Additional Data fields that identify   |
// |                                                      boot status.                                          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Boot Information (Type 32) structure.
/// </summary>
internal sealed class SmbiosType032 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType032"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType032(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    /// <summary>
    /// Gets a value representing the <b>Boot Status</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte BootStatus => Reader.GetByte(0x0a);

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
        {
            return;
        }

        properties.Add(SmbiosProperty.SystemBoot.BootStatus, GetBootStatus(BootStatus));
    }

    #endregion


    #region BIOS Specification 2.7.1 (26/01/2011)

    private static string GetBootStatus(byte code)
    {
        string[] value =
        {
            "No errors detected",                          // 0
            "No bootable media",
            "Operating system failed to load",
            "Firmware-detected hardware failure",
            "Operating system-detected hardware failure",
            "User-requested boot",
            "System security violation",
            "Previously-requested image",
            "System watchdog timer expired"                // 8
        };

        if (code <= 8)
        {
            return value[code];
        }

        if (code >= 128 && code <= 191)
        {
            return "OEM-specific";
        }

        if (code >= 192)
        {
            return "Product-specific";
        }

        return SmbiosHelper.OutOfSpec;
    }

    #endregion
}
