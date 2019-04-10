
namespace iTin.Core.Hardware.Interop.Windows.Development.SystemServices.SystemInformation.Firmware
{
    /// <summary>
    /// Defines firmware tables
    /// </summary>
    public enum KnownProvider
    {
        /// <summary>
        /// ACPI table provider.
        /// </summary>
        ACPI = (byte)'A' << 24 | (byte)'C' << 16 | (byte)'P' << 8 | (byte)'I',

        /// <summary>
        /// FIRM table provider.
        /// </summary>
        FIRM = (byte)'F' << 24 | (byte)'I' << 16 | (byte)'R' << 8 | (byte)'M',

        /// <summary>
        /// RSMB table provider.
        /// </summary>
        RSMB = (byte)'R' << 24 | (byte)'S' << 16 | (byte)'M' << 8 | (byte)'B'
    }
}
