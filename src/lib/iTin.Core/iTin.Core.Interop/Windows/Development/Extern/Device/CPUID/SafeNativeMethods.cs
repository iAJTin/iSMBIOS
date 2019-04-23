
namespace iTin.Core.Interop.Windows.Extern.Device.CPUID
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    public static class SafeNativeMethods
    {
        #region P/Invoke methods

        #region [public] {static} {extern} (bool) CPUIDIsSupported(): Gets a value that indicates whether there is support for the CPUID function of the microprocessor
        /// <summary>
        /// Gets a value that indicates whether there is support for the CPUID function of the microprocessor.
        /// </summary>
        /// <returns>
        /// Returns <b>true</b> in case the CPUID instruction is supported; <b>false</b> otherwise.
        /// </returns>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [DllImport(ExternDll.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CPUIDIsSupported();
        #endregion

        #region [public] {unsafe} {static} (bool) Invoke(uint, out int, out int, out int, out int): Call CPUID with the specified function
        /// <summary>
        /// Call CPUID with the specified function.
        /// </summary>
        /// <param name="level">A <see cref="T:System.Int32"/>, which contains the function to execute</param>
        /// <param name="eax">A <see cref="T:System.Int32"/>, with the value returned by the eax register of the microprocessor.</param>
        /// <param name="ebx">A <see cref="T:System.Int32"/>, with the value returned by the ebx register of the microprocessor.</param>
        /// <param name="ecx">A <see cref="T:System.Int32"/>, with the value returned by the ecx register of the microprocessor.</param>
        /// <param name="edx">A <see cref="T:System.Int32"/>, with the value returned by the edx register of the microprocessor.</param>
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
            if (__cpuid(level, &oeax, &oebx, &oecx, &oedx))
            {
                eax = oeax;
                ebx = oebx;
                ecx = oecx;
                edx = oedx;
                return true;
            }

            return false;
        }
        #endregion   

        #endregion

        #region private methods

        #region [private] {static} {extern} {unsafe} (bool) __cpuid(uint, int*, int*, int*, int*): Executes the determined function
        /// <summary>
        /// Executes the determined function.
        /// </summary>
        /// <param name="level">A <see cref="T:System.Int32"/>, which represents the function to be used.</param>
        /// <param name="eax">A <see cref="T:System.Int32"/>, which represents the value of the eax register.</param>
        /// <param name="ebx">A <see cref="T:System.Int32"/>, which represents the value of the ebx register.</param>
        /// <param name="ecx">A <see cref="T:System.Int32"/>, which represents the value of the ecx register.</param>
        /// <param name="edx">A <see cref="T:System.Int32"/>, which represents the value of the edx register.</param>
        /// <returns>
        /// Returns <b>true</b> in case the call is valid; <b>false</b> otherwise.
        /// </returns>
        [DllImport(ExternDll.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern unsafe bool __cpuid(uint level, int* eax, int* ebx, int* ecx, int* edx);
        #endregion

        #endregion
    }
}
