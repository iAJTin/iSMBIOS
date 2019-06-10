using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    /// <summary>
    /// Funciones que se pueden utilizar para controlar la configuración de parámetros del sistema y los diversos atributos del sistema, como el tiempo del doble clic,
    /// el tiempo de espera del protector de pantalla, el ancho del borde de las ventanas.
    /// </summary>
    internal static class NativeMethods
    {
        #region Enums

            #region [internal] (enum) MonitorOptions: Determina el valor devuelto por la función si el punto no se encuentra dentro de ningún monitor del sistema.
            /// <summary>
            /// Determina el valor devuelto por la función si el punto no se encuentra dentro de ningún monitor del sistema.
            /// Para más información, ver sección <strong>dwFlags</strong> de http://msdn.microsoft.com/es-es/library/dd145062.
            /// </summary>
            internal enum MonitorOptions : uint
            {
                MONITOR_DEFAULTTONULL = 0x00000000,
                MONITOR_DEFAULTTOPRIMARY = 0x00000001,
                MONITOR_DEFAULTTONEAREST = 0x00000002
            }
            #endregion

        #endregion

        #region Delegados
        /// <summary>
        /// Callback de la función <see cref="EnumDisplayMonitors"/>.
        /// </summary>
        public delegate bool MonitorEnumCallBack(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);
        #endregion

        #region P/Invoke

            #region [public] {static} (extern bool) EnumDisplayMonitors(IntPtr, IntPtr, MonitorEnumCallBack, IntPtr): Enumera los monitores (incluyendo los pseudo-monitores invisibles). Llama a una función de callback (MonitorEnumCallBack).
            /// <summary>
            /// Enumera los monitores (incluyendo los pseudo-monitores invisibles). Llama a una función de callback (MonitorEnumCallBack).
            /// </summary>
            /// <remarks>
            /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd162610%28v=VS.85%29.aspx
            /// </remarks>
            [DllImport(ExternDll.User32, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumCallBack lpfnEnum, IntPtr dwData);
            #endregion

            #region [public] {static} (extern bool) GetMonitorInfo(IntPtr, ref MONITORINFO): Obtiene información de un monitor.
            /// <summary>
            /// Obtiene información de un monitor. Para más información, ver http://msdn.microsoft.com/es-es/library/dd144901.
            /// </summary>
            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport(ExternDll.User32, CharSet = CharSet.Auto, SetLastError = true)]
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);
            #endregion

            #region [public] {static} (extern bool) GetMonitorInfo(IntPtr, ref MONITORINFOEX): Obtiene información de un monitor.
            /// <summary>
            /// Obtiene información de un monitor. Para más información, ver http://msdn.microsoft.com/es-es/library/dd144901.
            /// </summary>
            [DllImport(ExternDll.User32, CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);
            #endregion

            #region [public] {static} (extern IntPtr) MonitorFromPoint(POINT, MonitorOptions): Obtiene el identificador del monitor que contiene el punto especificado.
            /// <summary>
            /// Obtiene el identificador del monitor que contiene el punto especificado. Para más información, ver http://msdn.microsoft.com/es-es/library/dd145062.
            /// </summary>
            [DllImport(ExternDll.User32, SetLastError = true)]
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            public static extern IntPtr MonitorFromPoint(POINT pt, MonitorOptions dwFlags);
            #endregion

            #region [public] {static} (extern IntPtr) MonitorFromRect(ref RECT, MonitorOptions): Obtiene el identificador del monitor que tiene la mayor área de intersección con el rectángulo especificado.
            /// <summary>
            /// Obtiene el identificador del monitor que tiene la mayor área de intersección con el rectángulo especificado, ver http://msdn.microsoft.com/es-es/library/dd145062.
            /// </summary>
            [DllImport(ExternDll.User32, SetLastError = true)]
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            public static extern IntPtr MonitorFromRect([In]ref RECT lprc, [In]MonitorOptions dwFlags);
            #endregion

            #region [public] {static} (extern IntPtr) MonitorFromWindow(IntPtr, MonitorOptions): Obtiene el identificador del monitor que tiene la mayor área de intersección con el rectángulo de la ventana especificada.
            /// <summary>
            /// Obtiene el identificador del monitor que tiene la mayor área de intersección con el rectángulo de la ventana especificada.
            /// Para más información ver http://msdn.microsoft.com/es-es/library/dd145064.
            /// </summary>
            [DllImport(ExternDll.User32, SetLastError = true)]
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            public static extern IntPtr MonitorFromWindow([In]IntPtr hwnd, [In]MonitorOptions dwFlags);
            #endregion

        #endregion
    }
}