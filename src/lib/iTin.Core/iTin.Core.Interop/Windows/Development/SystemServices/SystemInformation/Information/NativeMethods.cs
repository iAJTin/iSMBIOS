
namespace iTin.Core.Interop.Windows.Development.SystemServices.SystemInformation.Information
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// Functions to query, modify the system configuration.
    /// </summary>
    internal static class NativeMethods
    {
        #region public enumerations

        #region [public] (enum) COMPUTER_NAME_FORMAT: Specifies the type of computer name
        /// <summary>
        /// Specifies the type of computer name.
        /// </summary>
        public enum COMPUTER_NAME_FORMAT
        {
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNameNetBios,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNameDnsHostname,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNameDnsDomain,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNameDnsFullyQualified,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNamePhysicalNetBios,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNamePhysicalDnsHostname,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNamePhysicalDnsDomain,
            /// <summary>
            /// For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNamePhysicalDnsFullyQualified,
            /// <summary>
            ///For more inforation, see http://msdn.microsoft.com/en-us/library/ms724224%28v=VS.85%29.aspx.
            /// </summary>
            ComputerNameMax
        }
        #endregion

        #endregion

        #region P/Invoke

        #region [public] {static} {extern} (bool) GetComputerName(StringBuilder, ref UInt32): Retrieves the default value of the specified registry key
        /// <summary>
        /// Retrieves the default value of the specified registry key.
        /// This name is established at the start of the system, when the system is read from the registry. For more inforation, see http://msdn.microsoft.com/en-us/library/ms724295%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Kernel32, SetLastError = true)]
        public static extern bool GetComputerName(StringBuilder lpBuffer, ref UInt32 lpnSize);
        #endregion

        #region [public] {static} {extern} (Boolean) GetComputerNameEx(COMPUTER_NAME_FORMAT, [Out] StringBuilder, ref UInt32): Retrieves the default value of the specified registry key.
        /// <summary>
        /// Retrieves the default value of the specified registry key.
        /// The names have been established at the beginning of the system, when the system reads them from the registry. For more inforation, see http://msdn.microsoft.com/en-us/library/ms724301%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetComputerNameEx(COMPUTER_NAME_FORMAT nameType, [Out] StringBuilder lpBuffer, ref UInt32 lpnSize);
        #endregion

        #endregion
    }
}
