
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions that can be used to control the configuration of system parameters and various system attributes, such as double click time, the screen saver timeout, the width of the window border.
    /// </summary>
    internal static class NativeMethods
    {
        /// <summary>
        /// Determine if the specified rectangle is empty.
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd145017%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsRectEmpty([In] ref RECT lprc);
    }
}
