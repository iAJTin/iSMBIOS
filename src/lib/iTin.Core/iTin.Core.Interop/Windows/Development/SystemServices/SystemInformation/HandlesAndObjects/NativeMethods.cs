
namespace iTin.Core.Interop.Windows.Development.SystemServices.SystemInformation.HandlesAndObjects
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions to manipulate the identifiers (Handles) of objects.
    /// </summary>
    /// <remarks>
    /// An object is a data structure that represents a system resource, such as a file, thread, or image. Applications can not directly access data from an object or from system resources.
    /// Instead, the application must obtain an object identifier, which can be used to examine or modify system resources.
    /// Each identifier (Handle) is stored in an internal table maintained by the system, these entries contain the addresses of the resources and means necessary to identify the type of resource.
    /// </remarks>
    internal static class NativeMethods
    {
        #region [public] {static} {extern} (bool) CloseHandle(IntPtr): Close an open object handle
        /// <summary>
        /// Close an open object handle. For more inforation, see http://msdn.microsoft.com/en-us/library/ms724211%28v=vs.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Kernel32)]
        public static extern bool CloseHandle(IntPtr hFile);
        #endregion
    }
}
