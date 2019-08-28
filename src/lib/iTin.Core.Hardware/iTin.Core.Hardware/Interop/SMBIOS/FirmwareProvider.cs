
namespace iTin.Core.Hardware.Interop.Smbios
{
    /// <summary>
    /// Defines firmware tables
    /// </summary>
    public enum FirmwareProvider
    {
        ACPI = 0x41435049, // 'ACPI' table
        FIRM = 0x4649524D, // 'FIRM' table
        RSMB = 0x52534D42  // 'RSMB' table
    }
}
