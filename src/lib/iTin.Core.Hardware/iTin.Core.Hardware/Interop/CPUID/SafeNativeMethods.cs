
namespace iTin.Core.Hardware.Interop.Cpuid
{
    using iTin.Core.Interop.Windows.Development.Hardware.uProcessor.CPUID;

    /// <summary>
    /// Methods for handle CPUID microprocessor features.
    /// </summary>
    public static class SafeNativeMethods
    {
        /// <summary>
        /// Call <c>CPUID</c> with the specified function.
        /// </summary>
        /// <param name="level">A <see cref="T:System.Int32" />, which represents the function to be used.</param>
        /// <param name="eax">A <see cref="T:System.Int32" />, which represents the value of the eax record.</param>
        /// <param name="ebx">A <see cref="T:System.Int32" />, which represents the value of the ebx record.</param>
        /// <param name="ecx">A <see cref="T:System.Int32" />, which represents the value of the ecx record.</param>
        /// <param name="edx">A <see cref="T:System.Int32" />, which represents the value of the edx record.</param>
        /// <returns>
        /// Returns <b>true</b> in case the call is valid; <b>false</b> otherwise.
        /// </returns>
        public static unsafe bool Invoke(uint level, out int eax, out int ebx, out int ecx, out int edx)
        {
            var oeax = 0;
            var oebx = 0;
            var oecx = 0;
            var oedx = 0;

            eax = 0;
            ebx = 0;
            ecx = 0;
            edx = 0;
            if (NativeMethods.__cpuid(level, &oeax, &oebx, &oecx, &oedx))
            {
                eax = oeax;
                ebx = oebx;
                ecx = oecx;
                edx = oedx;

                return true;
            }

            return false;
        }
    }
}
