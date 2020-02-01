
namespace iTin.Core.Hardware.Specification.Dmi
{
    /// <summary>
    /// Class of help for <b>DMI</b>.
    /// </summary>
    static class DmiHelper
    {
        /// <summary>
        /// Gets a reference to the <b>SMBIOS</b> object.
        /// </summary>
        /// <value>
        /// Object <see cref="SMBIOS"/> that contains the implemented structures.
        /// </value>
        public static SMBIOS Smbios => SMBIOS.Instance;
    }
}
