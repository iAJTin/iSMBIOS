
namespace iTin.Core.Hardware.Interop
{
    /// <summary>
    /// Defines firmware tables
    /// </summary>
    public enum FirmwareProvider
    {
        ACPI = (byte)'A' << 24 | (byte)'C' << 16 | (byte)'P' << 8 | (byte)'I',
        FIRM = (byte)'F' << 24 | (byte)'I' << 16 | (byte)'R' << 8 | (byte)'M',
        RSMB = (byte)'R' << 24 | (byte)'S' << 16 | (byte)'M' << 8 | (byte)'B'
    }
}
