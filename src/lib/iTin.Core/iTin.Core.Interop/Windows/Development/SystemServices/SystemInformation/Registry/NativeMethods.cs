
namespace iTin.Core.Interop.Windows.Development.SystemServices.SystemInformation.Registry
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// Functions to manipulate the system registry.
    /// </summary>
    /// <remarks>
    /// Database defined by the system in which applications and system components store and retrieve configuration data.
    /// </remarks>
    internal static class NativeMethods
    {
        #region public constants
        /// <summary>
        /// Type not defined, for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_NONE = 0x00;

        /// <summary>
        /// String terminated in null. This will be Unicode or ANSI, depending on whether the Unicode or ANSI functions are used.
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_SZ = 0x01;

        /// <summary>
        /// A null-terminated string containing non-expanding references of the environment variables (for example, "%PATH%").
        /// It will be a Unicode or ANSI string, depending on whether the Unicode or ANSI functions are used.
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_EXPAND_SZ = 0x02;

        /// <summary>
        /// Binary data, (contains any value).
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_BINARY = 0x03;//Binary data (any arbitrary data)

        /// <summary>
        /// Integer 32-bit.
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_DWORD = 0x04;

        /// <summary>
        /// Integer 32-bit without sign. Coding (little-endian).
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_DWORD_LITTLE_ENDIAN = REG_DWORD;

        /// <summary>
        /// Integer 32-bit without sign. Coding (big-endian).
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_DWORD_BIG_ENDIAN = 0x05;

        /// <summary>
        /// A null-terminated Unicode string that contains a link to another registry key.
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_LINK = 0x06;

        /// <summary>
        /// Sequence of null terminated strings, terminated with an empty string (\0).
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_MULTI_SZ = 0x07;

        /// <summary>
        /// List of resources (used by the PnP hardware).
        /// for more information see: http://en.wikipedia.org/wiki/Windows_registry.
        /// </summary>
        public const uint REG_RESOURCE_LIST = 0x08;

        /// <summary>
        /// Resource descriptor (used by the PnP hardware).
        /// for more information see: http://en.wikipedia.org/wiki/Windows_registry.
        /// </summary>
        public const uint REG_FULL_RESOURCE_DESCRIPTOR = 0x09;

        /// <summary>
        /// Resource requirement list (used by the PnP hardware).
        /// for more information see: http://en.wikipedia.org/wiki/Windows_registry.
        /// </summary>        
        public const uint REG_RESOURCE_REQUIREMENTS_LIST = 0x0a;

        /// <summary>
        /// Integer 64-bit. Without specifying if it is litte or big-endian. From Windows 2000.
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_QWORD = 0x0b;

        /// <summary>
        /// Integer 64-bit. Codification (little-endian).
        /// for more information see: http://msdn.microsoft.com/en-us/library/ms724884%28v=VS.85%29.aspx.
        /// </summary>
        public const uint REG_QWORD_LITTLE_ENDIAN = REG_QWORD;
        #endregion

        #region P/Invoke

        #region [public] {static} {extern} (int) RegQueryValue(IntPtr, UInt32, StringBuilder, ref UInt32): Retrieves the default value of the specified registry key
        /// <summary>
        /// Retrieves the default value of the specified registry key.
        /// The value to recover must be a null-terminated string. For more information, see http://msdn.microsoft.com/en-us/library/ms724909%28v=VS.85%29.aspx.
        /// </summary>
        /// <remarks>
        /// This function is available only for compatibility with 16-bit versions of Windows.
        /// Use the <see cref="RegQueryValueEx" /> function for <strong>ANSI</strong> or <see cref="RegQueryValueExW" /> for <strong>Unicode</strong>.
        /// </remarks>
        [Obsolete("Use the RegQueryValueEx (ANSI) or RegQueryValueExW (Unicode) function")]
        [DllImport(ExternDll.Advapi32, SetLastError = true)]
        public static extern int RegQueryValue(IntPtr hKey, UInt32 lpSubKey, StringBuilder lpValue, ref UInt32 lpcbValue);
        #endregion

        #region [public] {static} {extern} (int) RegQueryValueEx(IntPtr, String, IntPtr, out UInt32, StringBuilder, ref UInt32): Retrieve the type and data(s) for the name of the specified value associated with an open registry key
        /// <summary>
        /// Retrieve the type and data (s) for the name of the specified value associated with an open registry key.
        /// </summary>
        /// <remarks>
        /// <strong>ANSI</strong> version of the function.
        /// </remarks>
        [DllImport(ExternDll.Advapi32, CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", SetLastError = true)]
        internal static extern int RegQueryValueEx(IntPtr hKey, String lpValueName, IntPtr lpReserved, out UInt32 lpType, StringBuilder lpData, ref UInt32 lpcbData);
        #endregion

        #region [public] {static} {extern} (int) RegQueryValueExW(IntPtr, string, IntPtr, out UInt32, StringBuilder, ref UInt32): Retrieve the type and data(s) for the name of the specified value associated with an open registry key
        /// <summary>
        /// Retrieve the type and data(s) for the name of the specified value associated with an open registry key.
        /// </summary>
        /// <remarks>
        /// <strong>Unicode</strong> version of the function.
        /// </remarks>
        [DllImport(ExternDll.Advapi32, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW", SetLastError = true)]
        internal static extern int RegQueryValueExW(IntPtr hKey, string lpValueName, IntPtr lpReserved, out UInt32 lpType, StringBuilder lpData, ref UInt32 lpcbData);
        #endregion

        #endregion
    }
}
