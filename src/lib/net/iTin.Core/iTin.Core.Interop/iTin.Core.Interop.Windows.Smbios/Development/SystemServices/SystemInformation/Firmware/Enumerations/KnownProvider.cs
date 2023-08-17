
namespace iTin.Core.Interop.Windows.Development.SystemServices.SystemInformation.Firmware;

/// <summary>
/// Defines firmware tables
/// </summary>
public enum KnownProvider
{
    /// <summary>
    /// ACPI
    /// </summary>
    ACPI = (byte)'A' << 24 | (byte)'C' << 16 | (byte)'P' << 8 | (byte)'I',

    /// <summary>
    /// FIRM
    /// </summary>
    FIRM = (byte)'F' << 24 | (byte)'I' << 16 | (byte)'R' << 8 | (byte)'M',

    /// <summary>
    /// RSMB
    /// </summary>
    RSMB = (byte)'R' << 24 | (byte)'S' << 16 | (byte)'M' << 8 | (byte)'B'
}
