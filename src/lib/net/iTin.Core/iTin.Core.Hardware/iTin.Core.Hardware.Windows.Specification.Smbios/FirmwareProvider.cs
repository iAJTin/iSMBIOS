
namespace iTin.Core.Hardware.Windows.Specification.Smbios;

/// <summary>
/// Defines firmware tables
/// </summary>
public enum FirmwareProvider
{
    /// <summary>
    /// 'ACPI' table
    /// </summary>
    ACPI = 0x41435049,

    /// <summary>
    /// 'FIRM' table
    /// </summary>
    FIRM = 0x4649524D,

    /// <summary>
    /// 'RSMB' table
    /// </summary>
    RSMB = 0x52534D42
}
