using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.Extern.Device.CPUID
{
    public static class SafeNativeMethods
    {
        #region P/Invoke

            #region [public] {static} {extern} (bool) CPUIDIsSupported(): Obtiene un valor que indica si existe soporte para la función CPUID del microprocesador.
            /// <summary>
            /// Obtiene un valor que indica si existe soporte para la función CPUID del microprocesador.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para>Devuelve <b>true</b> en el caso que la instrucción CPUID se soporte; <b>false</b> en caso contrario.</para>
            /// </returns>
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode"), DllImport(ExternDll.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool CPUIDIsSupported();
            #endregion

            #region [public] {unsafe} {static} (bool) Invoke(uint, out int, out int, out int, out int): Llamada a CPUID con la función especificada.
            /// <summary>
            /// Llamada a CPUID con la función especificada.
            /// </summary>
            /// <param name="level">Un <see cref="T:System.Int32"/>, que contine la función a ejecutar</param>
            /// <param name="eax">Un <see cref="T:System.Int32"/>, con el valor devuelto por el registro eax del microprocesador.</param>
            /// <param name="ebx">Un <see cref="T:System.Int32"/>, con el valor devuelto por el registro ebx del microprocesador.</param>
            /// <param name="ecx">Un <see cref="T:System.Int32"/>, con el valor devuelto por el registro ecx del microprocesador.</param>
            /// <param name="edx">Un <see cref="T:System.Int32"/>, con el valor devuelto por el registro edx del microprocesador.</param>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para>Devuelve <b>true</b> en el caso que la llamada sea valida; <b>false</b> en caso contrario.</para>
            /// </returns>
            public unsafe static bool Invoke(uint level, out int eax, out int ebx, out int ecx, out int edx)
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

        #region Miembros privados

            #region [private] {unsafe} {static} {extern} (bool) __cpuid(uint, int*, int*, int*, int*): Ejecutar una función determinada.
            /// <summary>
            /// Ejecutar una función determinada.
            /// </summary>
            /// <param name="level">Un <see cref="T:System.Int32"/>, que representa la función a emplear.</param>
            /// <param name="eax">Un <see cref="T:System.Int32"/>, que representa el valor del registro eax.</param>
            /// <param name="ebx">Un <see cref="T:System.Int32"/>, que representa el valor del registro ebx.</param>
            /// <param name="ecx">Un <see cref="T:System.Int32"/>, que representa el valor del registro ecx.</param>
            /// <param name="edx">Un <see cref="T:System.Int32"/>, que representa el valor del registro edx.</param>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Boolean"/></para>
            /// 	<para>Devuelve <b>true</b> en el caso que la llamada sea valida; <b>false</b> en caso contrario.</para>
            /// </returns>
            [DllImport(ExternDll.Cpuid, SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern unsafe bool __cpuid(uint level, int* eax, int* ebx, int* ecx, int* edx);
            #endregion

        #endregion
    }
}