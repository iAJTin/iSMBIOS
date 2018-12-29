
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Diagnostics;

    /// <summary>
    /// Clase de ayuda para <c>DMI</c>.
    /// </summary>
    static class DmiHelper
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly SMBIOS SMBIOS = SMBIOS.Instance;

        /// <summary>
        /// Obtiene una referencia al objeto SMBIOS.
        /// </summary>
        /// <value>
        /// Objeto <see cref="SMBIOS"/> que contiene las estructuras implementadas.
        /// </value>
        public static SMBIOS Smbios => SMBIOS;
    }
}
