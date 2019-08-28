
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;

    using iTin.Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint;

    /// <summary>
    /// Funciones que se pueden utilizar para controlar la configuración de parámetros del sistema y los diversos atributos del sistema, como el tiempo del doble clic,
    /// el tiempo de espera del protector de pantalla, el ancho del borde de las ventanas.
    /// </summary>
    static class NativeMethods
    {
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

        #region Enums

        #region [internal] (enum) ChangeDisplaySettingsFlags:
        /// <summary>
        /// 
        /// </summary>
        [Flags]
        internal enum ChangeDisplaySettingsFlags
        {
            /// <summary>
            /// Cambia el modo gráfico actual, este se actualizarán en el registro. La información del modo se almacena en el perfil de usuario.
            /// </summary>
            CDS_UPDATEREGISTRY = 0x01,
            /// <summary>
            /// El sistema comprueba si se puede establecer el modo gráfico solicitado.
            /// </summary>
            CDS_TEST = 0x02,
            /// <summary>
            /// El modo es de carácter temporal. Si cambia a y desde otro escritorio, este modo no se restablecerá.
            /// </summary>
            CDS_FULLSCREEN = 0x04,
            /// <summary>
            /// La configuración se guardará en el área configuración global para que afectará a todos los usuarios de la máquina.
            /// De lo contrario, se modifica sólo la configuración del usuario.
            /// Este indicador sólo es válido cuando se usa junto con el flag <see cref="CDS_UPDATEREGISTRY"/>.
            /// </summary>
            CDS_GLOBAL = 0x08,
            /// <summary>
            /// Este dispositivo se convertirá en el dispositivo primario.
            /// </summary>
            CDS_SET_PRIMARY = 0x10,
            /// <summary>
            /// Cuando se establece, el parámetro <strong>lParam</strong> es un puntero a una estructura VIDEOPARAMETERS.
            /// </summary>
            CDS_VIDEOPARAMETERS = 0x020,
            /// <summary>
            /// La configuración se guardan en el registro, pero no tendrá efecto.
            /// Este indicador sólo es válido cuando se usa junto con el flag <see cref="CDS_UPDATEREGISTRY"/>.
            /// </summary>
            CDS_NORESET = 0x10000000,
            /// <summary>
            ///	Debe cambiar la configuración, incluso si los ajustes solicitados son los mismos que la configuración actual.
            /// </summary>
            CDS_RESET = 0x40000000,
        }
        #endregion

        #region [internal] (enum) DISP_CHANGE: Valores de retorno para las funciones ChangeDisplaySettings y ChangeDisplaySettingsEx.
        /// <summary>
        /// Valores de retorno para las funciones <see cref="ChangeDisplaySettings"/> y <see cref="ChangeDisplaySettingsEx"/>.
        /// </summary>
        /// <remarks>
        /// Para más información, ver sección <strong>return value</strong> de http://msdn.microsoft.com/es-es/library/dd183411.aspx
        /// </remarks>
        internal enum DISP_CHANGE
        {
            /// <summary>
            /// El cambio de configuración se realizo con éxito.
            /// </summary>
            DISP_CHANGE_SUCCESSFUL = 0,
            /// <summary>
            /// Debe reiniciar el equipo para que el modo de gráfico funcione.
            /// </summary>
            DISP_CHANGE_RESTART = 1,
            /// <summary>
            /// El controlador de generó un error para el modo de vídeo especificado.
            /// </summary>
            DISP_CHANGE_FAILED = -1,
            /// <summary>
            /// Modo gráfico no soportado.
            /// </summary>
            DISP_CHANGE_BADMODE = -2,
            /// <summary>
            /// No se puede escribir la configuración en el registro.
            /// </summary>
            DISP_CHANGE_NOTUPDATED = -3,
            /// <summary>
            /// Flag ó conjunto de Flags no válidos.
            /// </summary>
            DISP_CHANGE_BADFLAGS = -4,
            /// <summary>
            /// Se pasó un parámetro no válido en el campo <strong>Flags</strong>. 
            /// Esto puede incluir un flag no válido o una combinación de flags no válidos.
            /// </summary>
            DISP_CHANGE_BADPARAM = -5,
            /// <summary>
            /// El cambio de configuración no tuvo éxito porque el sistema es capaz de DualView.
            /// </summary>
            DISP_CHANGE_BADDUALVIEW = -6
        }
        #endregion

        #region [internal] (enum) DeviceCap: Valores de retorno para las funciones ChangeDisplaySettings y ChangeDisplaySettingsEx.
        /// <summary>
        /// Rón GetDeviceCaps recupera información específica del dispositivo para el dispositivo especificado.
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
            /// Tamaño necesario para descriptor de dispositivo.
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

        #region P/Invoke

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettings(ref DEVMODE, int): Cambiar la configuración del dispositivo de visualización por defecto para el modo de gráficos especificado.
        /// <summary>
        /// Cambiar la configuración del dispositivo de visualización por defecto para el modo de gráficos especificado.
        /// Para cambiar la configuración de un dispositivo de visualización especificado, utilice la función <see cref="ChangeDisplaySettings"/>.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd183411.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern DISP_CHANGE ChangeDisplaySettings(ref DEVMODE devMode, int flags);
        #endregion

        #region [public] {static} {extern} (DISP_CHANGE) ChangeDisplaySettingsEx(string, ref DEVMODE, IntPtr, int, IntPtr): Cambiar la configuración de la pantalla especificado para el modo de gráficos especificado.
        /// <summary>
        /// Cambiar la configuración de la pantalla especificado para el modo de gráficos especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd183413.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, int dwflags, IntPtr lParam);
        #endregion

        #region [public] {static} {extern} (IntPtr) CreateDC(string, string, string, ref DEVMODE): Crea un contexto de dispositivo (DC) para un dispositivo usando el nombre especificado.
        /// <summary>
        /// Crea un contexto de dispositivo (DC) para un dispositivo usando el nombre especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd183490%28VS.85%29.aspx.
        /// </remarks>
        [DllImport(ExternDll.Win.Gdi32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, ref DEVMODE lpInitData);
        #endregion

        #region [public] {static} {extern} (bool) DeleteDC(IntPtr): Borrar el contexto de dispositivo (DC) especificado.
        /// <summary>
        /// Borrar el contexto de dispositivo (DC) especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd183533%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.Gdi32)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public static extern bool DeleteDC(IntPtr hdc);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplayDevices(string, UInt32, ref DISPLAY_DEVICE, UInt32): Obtener información acerca de los dispositivos de visualización en la sesión actual.
        /// <summary>
        /// Obtener información acerca de los dispositivos de visualización en la sesión actual.
        /// </summary>
        /// <param name="lpDevice">Puntero al nombre del dispositivo. Si es <strong>null</strong>, devuelve la información de todos los adaptadores de video del equipo. Para obtener la información de cada adaptador debemos ir incrementando el valor del parámetro <c>iDevNum</c>.</param>
        /// <param name="iDevNum">Índice que especifica el dispositivo de pantalla. El sistema operativo identifica cada dispositivo de visualización con un índice. Estos índices son enteros consecutivos, a partir de 0. Si la sesión actual tiene tres dispositivos de pantalla, por ejemplo, se especifican los valores de índice 0, 1 y 2 respectivamente.</param>
        /// <param name="lpDisplayDevice">Puntero a una estructura <see cref="DISPLAY_DEVICE"/> que recibe la información del dispositivo de pantalla especificado por iDevNum. Antes de llamar a la esta función, el miembro cb de la estructura se ha de inicializar con el tamaño de la estructura en bytes.</param>
        /// <param name="dwFlags">Establecer este indicador en EDD_GET_DEVICE_INTERFACE_NAME (0x00000001) para recuperar el nombre de la interfaz de dispositivo de GUID_DEVINTERFACE_MONITOR, que está registrado por el sistema operativo de base por monitor. El valor se coloca en el miembro DeviceID de la estructura <see cref="DISPLAY_DEVICE"/> en <c>lpDisplayDevice</c>.</param>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd162609.aspx.
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([In] String lpDevice
                                                    , [In] UInt32 iDevNum
                                                    , [In] [Out] ref DISPLAY_DEVICE lpDisplayDevice
                                                    , [In] UInt32 dwFlags);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettings(string, int, ref DEVMODE): Obtiene información acerca de uno de los modos gráficos para un dispositivo de visualización.
        /// <summary>
        /// Obtiene información acerca de uno de los modos gráficos para un dispositivo de visualización.
        /// Para recuperar información para todos los modos gráficos de un dispositivo de visualización, realizar una serie de llamadas a esta función.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/es-es/library/dd162611.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        #endregion

        #region [public] {static} {extern} (bool) EnumDisplaySettingsEx(string, int, ref DEVMODE, int): Obtiene información acerca de uno de los modos gráficos para un dispositivo de visualización.
        /// <summary>
        /// Recupera información acerca de uno de los modos gráficos para un dispositivo de visualización.
        /// Para recuperar información para todos los modos gráficos para un dispositivo de visualización, realizar una serie de llamadas a esta función.
        /// Esta función difiere de <see cref="EnumDisplaySettings"/>  en que hay un parámetro dwFlags.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd162612.aspx.
        /// </remarks>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool EnumDisplaySettingsEx(string deviceName, int modeNum, ref DEVMODE devMode, int dwFlags);
        #endregion

        #region [public] {static} {extern} (int) GetDeviceCaps(IntPtr, DeviceCap): Obtiene información específica del dispositivo especificado.
        /// <summary>
        /// Obtiene información específica del dispositivo especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/dd144877%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.Gdi32)]
        public static extern int GetDeviceCaps(IntPtr hdc, DeviceCap index);
        #endregion

        #endregion
    }
}
