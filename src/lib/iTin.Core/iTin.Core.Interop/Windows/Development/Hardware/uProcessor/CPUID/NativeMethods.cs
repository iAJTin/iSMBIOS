
namespace iTin.Core.Interop.Windows.Development.Hardware.uProcessor.CPUID
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions for handle <c>CPUID</c> microprocessor features.
    /// </summary>
    public static class NativeMethods
    {
        /// <summary>
        /// Gets a value that indicates whether there is support for the <c>CPUID</c> function of the microprocessor.
        /// </summary>
        /// <returns>
        /// Returns <b>true</b> in case the <c>CPUID</c> instruction is supported; <b>false</b> otherwise.
        /// </returns>
        [DllImport(ExternDll.ThirdParty.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CpuidIsSupported();

        /// <summary>
        /// Execute a certain function.
        /// </summary>
        /// <param name="level">A <see cref="T:System.Int32" />, which represents the function to be used.</param>
        /// <param name="eax">A <see cref="T:System.Int32" />, which represents the value of the eax record.</param>
        /// <param name="ebx">A <see cref="T:System.Int32" />, which represents the value of the ebx record.</param>
        /// <param name="ecx">A <see cref="T:System.Int32" />, which represents the value of the ecx record.</param>
        /// <param name="edx">A <see cref="T:System.Int32" />, which represents the value of the edx record.</param>
        /// <returns>
        /// Returns <b>true</b> in case the call is valid; <b>false</b> otherwise.
        /// </returns>
        [DllImport(ExternDll.ThirdParty.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern unsafe bool __cpuid(uint level, int* eax, int* ebx, int* ecx, int* edx);
    }
}
