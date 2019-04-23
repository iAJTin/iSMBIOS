using System;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Windows.DriverKit.PnP.ConfigurationManager
{
    /// <summary>
    /// Funciones para consultar, modificar la configuración del sistema.
    /// </summary>
    internal static class NativeMethods
    {
        #region Constantes
        /// <summary>
        /// 
        /// </summary>
        public const int CR_SUCCESS = (0x00000000);

        /// <summary>
        /// 
        /// </summary>
        public const int CR_NO_SUCH_VALUE = (0x00000025);

        /// <summary>
        /// 
        /// </summary>
        public const int CR_INVALID_DATA = (0x0000001F);
        #endregion

        #region P/Invoke

            #region [public] {static extern} (UInt32) CM_Enumerate_Classes(UInt32, ref Guid, UInt32): Recupera el identificador GUID de cada clase instalada en este sistema. Se ha de llamar repetidamente a la función hasta que se devuelva el valor CR_NO_SUCH_VALUE.
            /// <summary>
            /// Recupera el identificador GUID de cada clase instalada en este sistema. Se ha de llamar repetidamente a la función hasta que se devuelva el valor CR_NO_SUCH_VALUE.
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff538021%28v=VS.85%29.aspx.
            /// </summary>
            [DllImport(ExternDll.Cfgmgr32, SetLastError = true)]
            public static extern UInt32 CM_Enumerate_Classes(UInt32 classIndex, ref Guid classGuid, UInt32 flags);
            #endregion

        #endregion
    }
}