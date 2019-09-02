
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    using System;
    using System.Runtime.InteropServices;

    using Rectangles;

    /// <summary>
    /// Functions that can be used to control the configuration of system parameters and various system attributes, such as double click time, the screen saver timeout, the width of the window border.
    /// </summary>
    public static class NativeMethods
    {
        #region public enumerations

        #region [internal] (enum) MonitorOptions: Determine the value returned by the function if the point is not within any system monitor
        /// <summary>
        /// Determine the value returned by the function if the point is not within any system monitor.
        /// For more information, please see section <strong>dwFlags</strong> of http://msdn.microsoft.com/es-es/library/dd145062.
        /// </summary>
        public enum MonitorOptions : uint
        {
            MONITOR_DEFAULTTONULL = 0x00000000,

            MONITOR_DEFAULTTOPRIMARY = 0x00000001,

            MONITOR_DEFAULTTONEAREST = 0x00000002
        }
        #endregion

        #endregion

        #region public delegates
        /// <summary>
        /// Callback of the <see cref="EnumDisplayMonitors"/> function.
        /// </summary>
        public delegate bool MonitorEnumCallBack(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);
        #endregion

        #region P/Invoke

        #region [public] {static} (extern bool) EnumDisplayMonitors(IntPtr, IntPtr, MonitorEnumCallBack, IntPtr): List the monitors (including invisible pseudo-monitors). Call a callback function (MonitorEnumCallBack)
        /// <summary>
        /// List the monitors (including invisible pseudo-monitors). Call a callback function (MonitorEnumCallBack).
        /// For more information, see http://msdn.microsoft.com/en-us/library/dd162610%28v=VS.85%29.aspx
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumCallBack lpfnEnum, IntPtr dwData);
        #endregion

        #region [public] {static} (extern bool) GetMonitorInfo(IntPtr, ref MONITORINFO): Get information from a monitor
        /// <summary>
        /// Get information from a monitor. For more information, please see http://msdn.microsoft.com/es-es/library/dd144901.
        /// </summary>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);
        #endregion

        #region [public] {static} (extern bool) GetMonitorInfo(IntPtr, ref MONITORINFOEX): Get information from a monitor
        /// <summary>
        /// Get information from a monitor. For more information, please see http://msdn.microsoft.com/es-es/library/dd144901.
        /// </summary>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);
        #endregion

        #region [public] {static} (extern IntPtr) MonitorFromPoint(POINT, MonitorOptions): Get the monitor ID that contains the specified point.
        /// <summary>
        /// Get the monitor ID that contains the specified point. For more information, please see http://msdn.microsoft.com/es-es/library/dd145062.
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        public static extern IntPtr MonitorFromPoint(POINT pt, MonitorOptions dwFlags);
        #endregion

        #region [public] {static} (extern IntPtr) MonitorFromRect(ref RECT, MonitorOptions): Get the identifier of the monitor that has the largest area of intersection with the specified rectangle
        /// <summary>
        /// Get the identifier of the monitor that has the largest area of intersection with the specified rectangle. For more information, please see http://msdn.microsoft.com/es-es/library/dd145062.
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        public static extern IntPtr MonitorFromRect([In]ref RECT lprc, [In]MonitorOptions dwFlags);
        #endregion

        #region [public] {static} (extern IntPtr) MonitorFromWindow(IntPtr, MonitorOptions): Get the identifier of the monitor that has the largest area of intersection with the rectangle of the specified window
        /// <summary>
        /// Get the identifier of the monitor that has the largest area of intersection with the rectangle of the specified window.
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd145064.
        /// </summary>
        [DllImport(ExternDll.Win.User32, SetLastError = true)]
        public static extern IntPtr MonitorFromWindow([In]IntPtr hwnd, [In]MonitorOptions dwFlags);
        #endregion

        #endregion
    }
}
