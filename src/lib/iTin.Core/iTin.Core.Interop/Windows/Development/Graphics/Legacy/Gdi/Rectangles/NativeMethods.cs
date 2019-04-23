
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions that can be used to control the configuration of system parameters and the various attributes of the system, such as double-click time, the wait time of the screen saver, the width of the edge of the windows.
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Determines whether the specified rectangle is empty.
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd145017%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.User32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([In] ref RECT lprc);
    }
}