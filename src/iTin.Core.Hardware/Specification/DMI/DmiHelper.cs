
namespace iTin.Core.Hardware.Specification.Dmi
{
    /// <summary>
    /// Class of help for <c>DMI </c>.
    /// </summary>
    static class DmiHelper
    {
        /// <summary>
        /// Gets a reference to the <c>SMBIOS</c> object.
        /// </summary>
        /// <value>
        /// Object <see cref="Smbios" /> that contains the implemented structures.
        /// </value>
        public static SMBIOS Smbios { get; } = SMBIOS.Instance;
    }
}
