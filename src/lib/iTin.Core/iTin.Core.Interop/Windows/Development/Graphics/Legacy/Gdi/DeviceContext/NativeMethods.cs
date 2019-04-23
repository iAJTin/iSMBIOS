
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    using DocumentAndPrinting.Printing.GdiPrint;

    /// <summary>
    /// Funciones que se pueden utilizar para controlar la configuración de parámetros del sistema y los diversos atributos del sistema, como el tiempo del doble clic,
    /// el tiempo de espera del protector de pantalla, el ancho del borde de las ventanas.
    /// </summary>
    static class NativeMethods
    {
        #region internal enumerations

        #region [internal] (enum) ChangeDisplaySettingsFlags:
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        internal enum ChangeDisplaySettingsFlags
        {
            /// <summary>
            /// Changes the current graphic mode, this will be updated in the registry. The mode information is stored in the user profile.
            /// </summary>
            CDS_UPDATEREGISTRY = 0x01,

            /// <summary>
            /// The system checks if the requested graphic mode can be established.
            /// </summary>
            CDS_TEST = 0x02,

            /// <summary>
            /// The mode is temporary. If you switch to and from another desktop, this mode will not be reset.
            /// </summary>
            CDS_FULLSCREEN = 0x04,

            /// <summary>
            /// The configuration will be saved in the global configuration area so that it will affect all users of the machine.
            /// Otherwise, only the user's configuration is modified.
            /// This flag is only valid when used together with the flag <see cref="CDS_UPDATEREGISTRY" />.
            /// </summary>
            CDS_GLOBAL = 0x08,

            /// <summary>
            /// This device will become the primary device.
            /// </summary>
            CDS_SET_PRIMARY = 0x10,

            /// <summary>
            /// When set, the <strong>lParam</strong> parameter is a pointer to a VIDEOPARAMETERS structure.
            /// </summary>
            CDS_VIDEOPARAMETERS = 0x020,

            /// <summary>
            /// The settings are saved in the registry, but will have no effect.
            /// This flag is only valid when used together with the flag <see cref="CDS_UPDATEREGISTRY" />.
            /// </summary>
            CDS_NORESET = 0x10000000,

            /// <summary>
            ///	You must change the configuration, even if the requested settings are the same as the current configuration.
            /// </summary>
            CDS_RESET = 0x40000000,
        }
        #endregion

        #region [internal] (enum) DISP_CHANGE: Return values for the ChangeDisplaySettings and ChangeDisplaySettingsEx functions
        /// <summary>
        /// Return values for the <see cref="ChangeDisplaySettings"/> and <see cref="ChangeDisplaySettingsEx"/> functions.
        /// </summary>
        /// <remarks>
        /// For more information, please see the <strong>return value</strong> section of http://msdn.microsoft.com/en-us/library/dd183411.aspx
        /// </remarks>
        internal enum DISP_CHANGE
        {
            /// <summary>
            /// The configuration change was successful.
            /// </summary>
            DISP_CHANGE_SUCCESSFUL = 0,

            /// <summary>
            /// You must restart the computer so that the graph mode works.
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
            /// The configuration can not be written to the registry.
            /// </summary>
            DISP_CHANGE_NOTUPDATED = -3,

            /// <summary>
            /// Flag or set of invalid Flags.
            /// </summary>
            DISP_CHANGE_BADFLAGS = -4,

            /// <summary>
            /// An invalid parameter was passed in the <strong>Flags</strong> field.
            /// This may include an invalid flag or a combination of invalid flags.
            /// </summary>
            DISP_CHANGE_BADPARAM = -5,

            /// <summary>
            /// The configuration change was not successful because the system is capable of DualView.
            /// </summary>
            DISP_CHANGE_BADDUALVIEW = -6
        }
        #endregion

        #region [internal] (enum) DeviceCap: 
        /// <summary>
        /// GetDeviceCaps recupera información específica del dispositivo para el dispositivo especificado.
        /// </summary>
        internal enum DeviceCap
        {
            /// <summary>
            /// Versión del controlador del dispositivo.
            /// </summary>
            DRIVERVERSION = 0,

            /// <summary>
            /// Clasificación del dispositivo.
            /// </summary>
            TECHNOLOGY = 2,

            /// <summary>
            /// Tamaño horizontal en milimetros.
            /// </summary>
            HORZSIZE = 4,

            /// <summary>
            /// Tamaño vertical en milimetros.
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
            /// Número de bits por pixel.
            /// </summary>
            BITSPIXEL = 12,

            /// <summary>
            /// Numbero de planos de color.
            /// </summary>
            PLANES = 14,

            /// <summary>
            /// Número de pinceles que tiene el dispositivo.
            /// </summary>
            NUMBRUSHES = 16,

            /// <summary>
            /// Número de pens que tiene el dispositivo.
            /// </summary>
            NUMPENS = 18,

            /// <summary>
            /// Número de marcadores que tiene el dispositivo.
            /// </summary>
            NUMMARKERS = 20,

            /// <summary>
            /// Número de fuentes que tiene el dispositivo.
            /// </summary>
            NUMFONTS = 22,

            /// <summary>
            /// Número de colores soportados por el dispositivo.
            /// </summary>
            NUMCOLORS = 24,

            /// <summary>
            /// Tamaño necesari
            /// o para descriptor de dispositivo.
            /// </summary>
            PDEVICESIZE = 26,

            /// <summary>
            /// Capacidades de curva.
            /// </summary>
            CURVECAPS = 28,

            /// <summary>
            /// Capacidades de línea.
            /// </summary>
            LINECAPS = 30,

            /// <summary>
            /// Capacidades poligonales.
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
            /// Capacidades de BitBlt.
            /// </summary>
            RASTERCAPS = 38,

            /// <summary>
            /// Longitud X.
            /// </summary>
            ASPECTX = 40,

            /// <summary>
            /// Longitud Y.
            /// </summary>
            ASPECTY = 42,

            /// <summary>
            /// Longitud de la hipotenusa.
            /// </summary>
            ASPECTXY = 44,

            /// <summary>
            /// Shading and Blending caps
            /// </summary>
            SHADEBLENDCAPS = 45,

            /// <summary>
            /// Logical pixels inch in X
            /// </summary>
            LOGPIXELSX = 88,

            /// <summary>
            /// Logical pixels inch in Y
            /// </summary>
            LOGPIXELSY = 90,

            /// <summary>
            /// Número de entradas físicas en paleta.
            /// </summary>
            SIZEPALETTE = 104,

            /// <summary>
            /// Número de entradas reservadas en paleta.
            /// </summary>
            NUMRESERVED = 106,

            /// <summary>
            /// Resolución de color actual.
            /// </summary>
            COLORRES = 108,

            // Relacionadas con la impresión.
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
            /// Refresco vertical del monitor actual, se mide en Hercios(Hz).
            /// </summary>
            VREFRESH = 116,

            /// <summary>
            /// Ancho completo del escritorio, en pixeles.
            /// </summary>
            DESKTOPVERTRES = 117,

            /// <summary>
            /// Altura completa del escritorio, en pixeles.
            /// </summary>
            DESKTOPHORZRES = 118,

            /// <summary>
            /// Preferred blt alignment
            /// </summary>
            BLTALIGNMENT = 119
        }
        #endregion

        #endregion

        #region public methods (P/Invoke)

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettings(ref DEVMODE, int): Change the default display device settings for the specified graphics mode
        /// <summary>
        /// Change the default display device settings for the specified graphics mode.
        /// To change the settings of a specified display device, use the <see cref="ChangeDisplaySettings" /> function.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx
        /// </remarks>
        [DllImport(ExternDll.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern DISP_CHANGE ChangeDisplaySettings(ref DEVMODE devMode, int flags);
        #endregion

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettingsEx(string, ref DEVMODE, IntPtr, int, IntPtr): Change the settings of the specified screen for the specified graphics mode
        /// <summary>
        /// Change the settings of the specified screen for the specified graphics mode.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd183413.aspx
        /// </remarks>
        [DllImport(ExternDll.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, int dwflags, IntPtr lParam);
        #endregion

        #region [public] {static} {extern} (IntPtr) CreateDC(string, string, string, ref DEVMODE): Create a device context (DC) for a device using the specified name
        /// <summary>
        /// Create a device context (DC) for a device using the specified name.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd183490%28VS.85%29.aspx.
        /// </remarks>
        [DllImport(ExternDll.Gdi32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, ref DEVMODE lpInitData);
        #endregion

        #region [public] {static} {extern} (bool) DeleteDC(IntPtr): Delete the specified device context (DC)
        /// <summary>
        /// Delete the specified device context (DC).
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd183533%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Gdi32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern bool DeleteDC(IntPtr hdc);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplayDevices(string, UInt32, ref DISPLAY_DEVICE, UInt32): Get information about the display devices in the current session
        /// <summary>
        /// Get information about the display devices in the current session.
        /// </summary>
        /// <param name="lpDevice">Puntero al nombre del dispositivo. Si es <strong>null</strong>, devuelve la información de todos los adaptadores de video del equipo.
        /// Para obtener la información de cada adaptador debemos ir incrementando el valor del parámetro <c>iDevNum</c>.</param>
        /// <param name="iDevNum">Índice que especifica el dispositivo de pantalla. El sistema operativo identifica cada dispositivo 
        /// de visualización con un índice. Estos índices son enteros consecutivos, a partir de 0. 
        /// Si la sesión actual tiene tres dispositivos de pantalla, por ejemplo, se especifican los valores de índice 0, 1 y 2 respectivamente.</param>
        /// <param name="lpDisplayDevice">Puntero a una estructura <see cref="DISPLAY_DEVICE"/> que recibe la información del dispositivo de pantalla especificado por iDevNum.
        /// Antes de llamar a la esta función, el miembro cb de la estructura se ha de inicializar con el tamaño de la estructura en bytes.</param>
        /// <param name="dwFlags">Establecer este indicador en EDD_GET_DEVICE_INTERFACE_NAME (0 x 00000001) para recuperar el nombre de la interfaz de dispositivo de
        /// GUID_DEVINTERFACE_MONITOR, que está registrado por el sistema operativo de base por monitor. 
        /// El valor se coloca en el miembro DeviceID de la estructura <see cref="DISPLAY_DEVICE"/> en <c>lpDisplayDevice</c>.</param>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd162609.aspx.
        /// </remarks>
        [DllImport(ExternDll.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([In] String lpDevice, [In] UInt32 iDevNum, [In] [Out] ref DISPLAY_DEVICE lpDisplayDevice, [In] UInt32 dwFlags);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettings(string, int, ref DEVMODE): Obtains information about one of the graphic modes for a display device
        /// <summary>
        /// Obtains information about one of the graphic modes for a display device.
        /// To retrieve information for all graphic modes of a display device, make a series of calls to this function.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/es-es/library/dd162611.aspx
        /// </remarks>
        [DllImport(ExternDll.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettingsEx(string, int, ref DEVMODE, int): Retrieve information about one of the graphic modes for a display device
        /// <summary>
        /// Retrieve information about one of the graphic modes for a display device.
        /// To retrieve information for all graphic modes for a display device, make a series of calls to this function.
        /// This function differs from <see cref="EnumDisplaySettings" /> in that there is a dwFlags parameter.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd162612.aspx.
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(ExternDll.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool EnumDisplaySettingsEx(string deviceName, int modeNum, ref DEVMODE devMode, int dwFlags);
        #endregion

        #region [public] {static} {extern} (int) GetDeviceCaps(IntPtr, DeviceCap): Obtain information specific to the specified device
        /// <summary>
        /// Obtain information specific to the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/dd144877%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Gdi32)]
        public static extern int GetDeviceCaps(IntPtr hdc, DeviceCap index);
        #endregion

        #endregion


        #region nested classes

        #region [internal] {static} (class) EnumDisplayFlags:
        internal static class EnumDisplayFlags
        {
            public const int EDS_NORMAL = 0x00;
            public const int EDS_RAWMODE = 0x02;
            public const int EDS_ROTATEDMODE = 0x04;
        }
        #endregion

        #endregion
    }
}
