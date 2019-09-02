
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    using DocumentAndPrinting.Printing.GdiPrint;

    /// <summary>
    /// Functions that can be used to control the configuration of system parameters and various system attributes, such as double click time, the screen saver timeout, the width of the window border.
    /// </summary>
    public static class NativeMethods
    {
        #region public enumerations

        #region [public] (enum) ChangeDisplaySettingsFlags:
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        public enum ChangeDisplaySettingsFlags
        {
            /// <summary>
            /// Change the current graphic mode, this will be updated in the registry. The mode information is stored in the user profile.
            /// </summary>
            CDS_UPDATEREGISTRY = 0x01,

            /// <summary>
            /// The system checks if the requested graphic mode can be set.
            /// </summary>
            CDS_TEST = 0x02,

            /// <summary>
            /// The mode is temporary. If you switch to and from another desktop, this mode will not be reset.
            /// </summary>
            CDS_FULLSCREEN = 0x04,

            /// <summary>
            /// The configuration will be saved in the global configuration area so that it will affect all users of the machine.
            /// Otherwise, only the user settings are modified.
            /// This indicator is only valid when used together with the flag <see cref="CDS_UPDATEREGISTRY"/>.
            /// </summary>
            CDS_GLOBAL = 0x08,

            /// <summary>
            /// This device will become the primary device.
            /// </summary>
            CDS_SET_PRIMARY = 0x10,

            /// <summary>
            /// When set, the <strong> lParam </strong> parameter is a pointer to a VIDEOPARAMETERS structure.
            /// </summary>
            CDS_VIDEOPARAMETERS = 0x020,

            /// <summary>
            /// The settings are saved in the registry, but will not take effect.
            /// This indicator is only valid when used together with the flag <see cref="CDS_UPDATEREGISTRY"/>.
            /// </summary>
            CDS_NORESET = 0x10000000,

            /// <summary>
            ///	You must change the settings, even if the requested settings are the same as the current settings.
            /// </summary>
            CDS_RESET = 0x40000000,
        }
        #endregion

        #region [public] (enum) DISP_CHANGE: Return values for the ChangeDisplaySettings and ChangeDisplaySettingsEx functions
        /// <summary>
        /// Return values for the <see cref="ChangeDisplaySettings"/> and <see cref="ChangeDisplaySettingsEx"/> functions. For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx.
        /// </summary>
        public enum DISP_CHANGE
        {
            /// <summary>
            /// The configuration change was successful.
            /// </summary>
            DISP_CHANGE_SUCCESSFUL = 0,

            /// <summary>
            /// You must restart the computer for the chart mode to work.
            /// </summary>
            DISP_CHANGE_RESTART = 1,

            /// <summary>
            /// The driver generated an error for the specified video mode.
            /// </summary>
            DISP_CHANGE_FAILED = -1,

            /// <summary>
            /// Graphic mode not supported.
            /// </summary>
            DISP_CHANGE_BADMODE = -2,

            /// <summary>
            /// The configuration cannot be written to the registry.
            /// </summary>
            DISP_CHANGE_NOTUPDATED = -3,

            /// <summary>
            /// Flag or set of invalid Flags.
            /// </summary>
            DISP_CHANGE_BADFLAGS = -4,

            /// <summary>
            /// An invalid parameter was passed in the <b>Flags</b> field.
            /// This may include an invalid flag or a combination of invalid flags.
            /// </summary>
            DISP_CHANGE_BADPARAM = -5,

            /// <summary>
            /// The configuration change was unsuccessful because the system is capable of DualView.
            /// </summary>
            DISP_CHANGE_BADDUALVIEW = -6
        }
        #endregion

        #region [public] (enum) DeviceCap: GetDeviceCaps retrieves device specific information for the specified device
        /// <summary>
        /// GetDeviceCaps retrieves device specific information for the specified device.
        /// </summary>
        public enum DeviceCap
        {
            /// <summary>
            /// Device driver version.
            /// </summary>
            DRIVERVERSION = 0,

            /// <summary>
            /// Clasificación del dispositivo.
            /// </summary>
            TECHNOLOGY = 2,

            /// <summary>
            /// Horizontal size in millimeters.
            /// </summary>
            HORZSIZE = 4,

            /// <summary>
            /// Vertical size in millimeters.
            /// </summary>
            VERTSIZE = 6,

            /// <summary>
            /// Tamaño horizontal en pixeles.
            /// </summary>
            HORZRES = 8,

            /// <summary>
            /// Tamaño vertical en pixeles.
            /// </summary>
            VERTRES = 10,

            /// <summary>
            /// Number of bits per pixel.
            /// </summary>
            BITSPIXEL = 12,

            /// <summary>
            /// Number of color planes.
            /// </summary>
            PLANES = 14,

            /// <summary>
            /// Number of brushes the device has.
            /// </summary>
            NUMBRUSHES = 16,

            /// <summary>
            /// Number of pens the device has
            /// </summary>
            NUMPENS = 18,

            /// <summary>
            /// Number of bookmarks the device has.
            /// </summary>
            NUMMARKERS = 20,

            /// <summary>
            /// Number of sources the device has.
            /// </summary>
            NUMFONTS = 22,

            /// <summary>
            /// Number of colors supported by the device.
            /// </summary>
            NUMCOLORS = 24,

            /// <summary>
            /// Required size for device descriptor.
            /// </summary>
            PDEVICESIZE = 26,

            /// <summary>
            /// Curve Capabilities.
            /// </summary>
            CURVECAPS = 28,

            /// <summary>
            /// Line Capabilities.
            /// </summary>
            LINECAPS = 30,

            /// <summary>
            /// Polygonal capabilities.
            /// </summary>
            POLYGONALCAPS = 32,

            /// <summary>
            /// Capacidades de texto.
            /// </summary>
            TEXTCAPS = 34,

            /// <summary>
            /// Capacidades de recorte.
            /// </summary>
            CLIPCAPS = 36,

            /// <summary>
            /// BitBlt Capabilities.
            /// </summary>
            RASTERCAPS = 38,

            /// <summary>
            /// X length.
            /// </summary>
            ASPECTX = 40,

            /// <summary>
            /// Y length.
            /// </summary>
            ASPECTY = 42,

            /// <summary>
            /// Length of the hypotenuse.
            /// </summary>
            ASPECTXY = 44,

            /// <summary>
            /// Shading and Blending caps.
            /// </summary>
            SHADEBLENDCAPS = 45,

            /// <summary>
            /// Logical pixels inch in X.
            /// </summary>
            LOGPIXELSX = 88,

            /// <summary>
            /// Logical pixels inch in Y.
            /// </summary>
            LOGPIXELSY = 90,

            /// <summary>
            /// Number of physical entries in palette.
            /// </summary>
            SIZEPALETTE = 104,

            /// <summary>
            /// Number of reserved entries in palette.
            /// </summary>
            NUMRESERVED = 106,

            /// <summary>
            /// Current color resolution.
            /// </summary>
            COLORRES = 108,

            // Related to printing.
            // -------------------
            /// <summary>
            /// Physical Width in device units
            /// </summary>
            PHYSICALWIDTH = 110,

            /// <summary>
            /// Physical Height in device units
            /// </summary>
            PHYSICALHEIGHT = 111,

            /// <summary>
            /// Physical Printable Area x margin
            /// </summary>
            PHYSICALOFFSETX = 112,

            /// <summary>
            /// Physical Printable Area y margin
            /// </summary>
            PHYSICALOFFSETY = 113,

            /// <summary>
            /// Scaling factor x
            /// </summary>
            SCALINGFACTORX = 114,

            /// <summary>
            /// Scaling factor y
            /// </summary>
            SCALINGFACTORY = 115,

            /// <summary>
            /// Vertical refreshment of the current monitor is measured in Hertz (Hz).
            /// </summary>
            VREFRESH = 116,

            /// <summary>
            /// Full width of the desktop, in pixels.
            /// </summary>
            DESKTOPVERTRES = 117,

            /// <summary>
            /// Full height of the desk, in pixels.
            /// </summary>
            DESKTOPHORZRES = 118,

            /// <summary>
            /// Preferred blt alignment
            /// </summary>
            BLTALIGNMENT = 119
        }
        #endregion

        #endregion

        #region P/Invoke

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettings(ref DEVMODE, int): Change the default display device settings for the specified graphics mode
        /// <summary>
        /// Change the default display device settings for the specified graphics mode.
        /// To change the settings of a specified display device, use the <see cref="ChangeDisplaySettings" /> function.
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern DISP_CHANGE ChangeDisplaySettings(ref DEVMODE devMode, int flags);
        #endregion

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettingsEx(string, ref DEVMODE, IntPtr, int, IntPtr): Change the specified screen settings for the specified graphics mode
        /// <summary>
        /// Change the specified screen settings for the specified graphics mode. For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, int dwflags, IntPtr lParam);
        #endregion

        #region [public] {static} {extern} (IntPtr) CreateDC(string, string, string, ref DEVMODE): Create a device context (DC) for a device using the specified name
        /// <summary>
        /// Create a device context (DC) for a device using the specified name. For more information, please see http://msdn.microsoft.com/en-us/library/dd183490%28VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.Gdi32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, ref DEVMODE lpInitData);
        #endregion

        #region [public] {static} {extern} (bool) DeleteDC(IntPtr): Delete the specified device context (DC)
        /// <summary>
        /// Delete the specified device context (DC). For more information, please see http://msdn.microsoft.com/en-us/library/dd183533%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.Gdi32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteDC(IntPtr hdc);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplayDevices(string, uint, ref DISPLAY_DEVICE, uint): Get information about the display devices in the current session
        /// <summary>
        /// Get information about the display devices in the current session. For more information, please see http://msdn.microsoft.com/es-es/library/dd162609.aspx.
        /// </summary>
        /// <param name="lpDevice">Pointer to the device name. If it is <strong>null</strong>, it returns the information of all the video adapters on the device. To obtain the information of each adapter we must increase the value of the <c>iDevNum</c> parameter.</param>
        /// <param name="iDevNum">Index that specifies the display device. The operating system identifies each display device with an index. These indexes are consecutive integers, from 0. If the current session has three display devices, for example, the index values 0, 1 and 2 are specified respectively.</param>
        /// <param name="lpDisplayDevice">Pointer to a structure <see cref="DISPLAY_DEVICE"/> that receives the information from the display device specified by iDevNum. Before calling this function, the cb member of the structure must be initialized with the size of the structure in bytes.</param>
        /// <param name="dwFlags">Set this indicator to EDD_GET_DEVICE_INTERFACE_NAME (0x00000001) to retrieve the device interface name of GUID_DEVINTERFACE_MONITOR, which is registered by the base operating system by monitor. The value is placed in the DeviceID member of the <see cref="DISPLAY_DEVICE"/> structure in <c>lpDisplayDevice</c>.</param>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([In] string lpDevice, [In] uint iDevNum, [In] [Out] ref DISPLAY_DEVICE lpDisplayDevice, [In] uint dwFlags);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettings(string, int, ref DEVMODE): Get information about one of the graphic modes for a display device
        /// <summary>
        /// Get information about one of the graphic modes for a display device.
        /// To retrieve information for all graphic modes of a display device, make a series of calls to this function.
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd162611.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettingsEx(string, int, ref DEVMODE, int): Retrieves information about one of the graphic modes for a display device
        /// <summary>
        /// Retrieves information about one of the graphic modes for a display device.
        /// To retrieve information for all graphic modes for a display device, make a series of calls to this function.
        /// This function differs from <see cref = "EnumDisplaySettings" /> in that there is a dwFlags parameter.
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd162612.aspx.
        /// </summary>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool EnumDisplaySettingsEx(string deviceName, int modeNum, ref DEVMODE devMode, int dwFlags);
        #endregion

        #region [public] {static} {extern} (int) GetDeviceCaps(IntPtr, DeviceCap): Get specific information of the specified device
        /// <summary>
        /// Get specific information of the specified device. For more information, please see http://msdn.microsoft.com/en-us/library/dd144877%28v=VS.85%29.aspx.
        /// </summary>
        [DllImport(ExternDll.Win.Gdi32)]
        public static extern int GetDeviceCaps(IntPtr hdc, DeviceCap index);
        #endregion

        #endregion


        #region nested classes

        #region [internal] {static} (class) EnumDisplayFlags:
        public static class EnumDisplayFlags
        {
            public const int EDS_NORMAL = 0x00;
            public const int EDS_RAWMODE = 0x02;
            public const int EDS_ROTATEDMODE = 0x04;
        }
        #endregion

        #endregion
    }
}
