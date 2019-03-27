
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    /// <summary>
    /// Class of help for <c>DMI </c>.
    /// </summary>
    static class DmiHelper
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly SMBIOS SMBIOS = SMBIOS.Instance;

        /// <summary>
        /// Gets a reference to the <c>SMBIOS</c> object.
        /// </summary>
        /// <value>
        /// Object <see cref="SMBIOS" /> that contains the implemented structures.
        /// </value>
        public static SMBIOS Smbios => SMBIOS;
    }
}
