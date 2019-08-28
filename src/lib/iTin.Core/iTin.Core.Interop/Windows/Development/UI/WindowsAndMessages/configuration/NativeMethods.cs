
namespace iTin.Core.Interop.Windows.Development.UI.WindowsAndMessages.Configuration
{
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Funciones que se pueden utilizar para controlar la configuración de parámetros del sistema y los diversos atributos del sistema, como el tiempo del doble clic,
    /// el tiempo de espera del protector de pantalla, el ancho del borde de las ventanas.
    /// </summary>
    internal static class NativeMethods
    {
        #region Enums

            #region [public] (enum) SystemMetricIndex: Representa una característica o valor de configuración del sistema a recuperar.
            /// <summary>
            /// Representa una característica o valor de configuración del sistema a recuperar.
            /// Tener en cuenta que todos los valores <strong>SM_CX*</strong> son anchos y <strong>SM_CY*</strong> los valores de altura.
            /// También tener en cuenta que los ajustes diseñados para devolver datos <see cref="T:System.Boolean"/>, el valor <strong>true</strong>
            /// se representa con un valor distinto de cero y <strong>false</strong> con valor cero.
            /// </summary>
            public enum SystemMetricIndex
            {
                /// <summary>
                /// Ancho de la pantalla del monitor de pantalla principal, en píxeles.
                /// Este valor es el mismo valor que se obtiene mediante una llamada a <strong>GetDeviceCaps</strong> como sigue: GetDeviceCaps (hdcPrimaryMonitor, HORZRES).
                /// </summary>
                SM_CXSCREEN = 0,
                /// <summary>
                /// Altura de la pantalla del monitor de pantalla principal, en píxeles.
                /// Este valor es el mismo valor que se obtiene mediante una llamada a <strong>GetDeviceCaps</strong> como sigue: GetDeviceCaps (hdcPrimaryMonitor, VERTRES).
                /// </summary>
                SM_CYSCREEN = 1,
                /// <summary>
                /// Ancho de la barra de desplazamiento vertical, en píxeles.
                /// </summary>
                SM_CXVSCROLL = 2,
                /// <summary>
                /// Altura de una barra de desplazamiento horizontal, en píxeles.
                /// </summary>
                SM_CYHSCROLL = 3,
                /// <summary>
                /// Altura del área de título, en píxeles.
                /// </summary>
                SM_CYCAPTION = 4,
                /// <summary>
                /// Ancho del borde de ventana, en píxeles. Esto es equivalente al valor <see cref="SM_CXEDGE"/> para windows con la apariencia 3D.
                /// </summary>
                SM_CXBORDER = 5,
                /// <summary>
                /// 
                /// </summary>
                SM_CYBORDER = 6,
                /// <summary>
                /// Ver <see cref="SM_CXFIXEDFRAME"/>.
                /// </summary>
                SM_CXDLGFRAME = 7,
                /// <summary>
                /// 
                /// </summary>
                SM_CYDLGFRAME = 8,
                /// <summary>
                /// 
                /// </summary>
                SM_CYVTHUMB = 9,
                /// <summary>
                /// 
                /// </summary>
                SM_CXHTHUMB = 10,
                /// <summary>
                /// 
                /// </summary>
                SM_CXICON = 11,
                /// <summary>
                /// 
                /// </summary>
                SM_CYICON = 12,
                /// <summary>
                /// 
                /// </summary>
                SM_CXCURSOR = 13,
                /// <summary>
                /// 
                /// </summary>
                SM_CYCURSOR = 14,
                /// <summary>
                /// Altura de una barra de menú de una línea, en píxeles.
                /// </summary>
                SM_CYMENU = 15,
                /// <summary>
                /// 
                /// </summary>
                SM_CXFULLSCREEN = 16,
                /// <summary>
                /// 
                /// </summary>
                SM_CYFULLSCREEN = 17,
                /// <summary>
                /// 
                /// </summary>
                SM_CYKANJIWINDOW = 18,
                /// <summary>
                /// 
                /// </summary>
                SM_MOUSEPRESENT = 19,
                /// <summary>
                /// 
                /// </summary>
                SM_CYVSCROLL = 20,
                /// <summary>
                /// 
                /// </summary>
                SM_CXHSCROLL = 21,
                /// <summary>
                /// 
                /// </summary>
                SM_DEBUG = 22,
                /// <summary>
                /// 
                /// </summary>
                SM_SWAPBUTTON = 23,
                /// <summary>
                /// 
                /// </summary>
                SM_RESERVED1 = 24,
                /// <summary>
                /// 
                /// </summary>
                SM_RESERVED2 = 25,
                /// <summary>
                /// 
                /// </summary>
                SM_RESERVED3 = 26,
                /// <summary>
                /// 
                /// </summary>
                SM_RESERVED4 = 27,
                /// <summary>
                /// Anchura mínima de una ventana, en píxeles.
                /// </summary>
                SM_CXMIN = 28,
                /// <summary>
                /// Altura mínima de una ventana, en píxeles.
                /// </summary>
                SM_CYMIN = 29,
                /// <summary>
                /// Anchura de un botón de una barra o título de ventana, en píxeles.
                /// </summary>
                SM_CXSIZE = 30,
                /// <summary>
                /// Altura de un botón de una barra o título de ventana, en píxeles.
                /// </summary>
                SM_CYSIZE = 31,
                /// <summary>
                /// 
                /// </summary>
                SM_CXFRAME = 32,
                /// <summary>
                /// 
                /// </summary>
                SM_CYFRAME = 33,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMINTRACK = 34,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMINTRACK = 35,
                /// <summary>
                /// 
                /// </summary>
                SM_CXDOUBLECLK = 36,
                /// <summary>
                /// 
                /// </summary>
                SM_CYDOUBLECLK = 37,
                /// <summary>
                /// 
                /// </summary>
                SM_CXICONSPACING = 38,
                /// <summary>
                /// 
                /// </summary>
                SM_CYICONSPACING = 39,
                /// <summary>
                /// 
                /// </summary>
                SM_MENUDROPALIGNMENT = 40,
                /// <summary>
                /// 
                /// </summary>
                SM_PENWINDOWS = 41,
                /// <summary>
                /// 
                /// </summary>
                SM_DBCSENABLED = 42,
                /// <summary>
                /// Número de botones del ratón , devuelve cero si el ratón no está instalado.
                /// </summary>
                SM_CMOUSEBUTTONS = 43,

                /*#if(WINVER >= 0x0400)*/
                /// <summary>
                /// 
                /// </summary>
                SM_CXFIXEDFRAME = SM_CXDLGFRAME,  /* ;win40 name change */
                /// <summary>
                /// 
                /// </summary>
                SM_CYFIXEDFRAME = SM_CYDLGFRAME, /* ;win40 name change */
                /// <summary>
                /// 
                /// </summary>
                SM_CXSIZEFRAME = SM_CXFRAME,    /* ;win40 name change */
                /// <summary>
                /// 
                /// </summary>
                SM_CYSIZEFRAME = SM_CYFRAME,     /* ;win40 name change */

                /// <summary>
                /// 
                /// </summary>
                SM_SECURE = 44,
                /// <summary>
                /// 
                /// </summary>
                SM_CXEDGE = 45,
                /// <summary>
                /// 
                /// </summary>
                SM_CYEDGE = 46,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMINSPACING = 47,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMINSPACING = 48,
                /// <summary>
                /// 
                /// </summary>
                SM_CXSMICON = 49,
                /// <summary>
                /// 
                /// </summary>
                SM_CYSMICON = 50,
                /// <summary>
                /// 
                /// </summary>
                SM_CYSMCAPTION = 51,
                /// <summary>
                /// 
                /// </summary>
                SM_CXSMSIZE = 52,
                /// <summary>
                /// 
                /// </summary>
                SM_CYSMSIZE = 53,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMENUSIZE = 54,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMENUSIZE = 55,
                /// <summary>
                /// 
                /// </summary>
                SM_ARRANGE = 56,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMINIMIZED = 57,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMINIMIZED = 58,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMAXTRACK = 59,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMAXTRACK = 60,
                /// <summary>
                /// 
                /// </summary>
                SM_CXMAXIMIZED = 61,
                /// <summary>
                /// 
                /// </summary>
                SM_CYMAXIMIZED = 62,
                /// <summary>
                /// 
                /// </summary>
                SM_NETWORK = 63,
                /// <summary>
                /// 
                /// </summary>
                SM_CLEANBOOT = 67,
                /// <summary>
                /// 
                /// </summary>
                SM_CXDRAG = 68,
                /// <summary>
                /// 
                /// </summary>
                SM_CYDRAG = 69,
                /*#endif /* WINVER >= 0x0400 */
                /// <summary>
                /// 
                /// </summary>
                SM_SHOWSOUNDS = 70,
                /*#if(WINVER >= 0x0400)*/
                /// <summary>
                /// 
                /// </summary>
                SM_CXMENUCHECK = 71,   /* Use instead of GetMenuCheckMarkDimensions()! */
                /// <summary>
                /// 
                /// </summary>
                SM_CYMENUCHECK = 72,
                /// <summary>
                /// 
                /// </summary>
                SM_SLOWMACHINE = 73,
                /// <summary>
                /// 
                /// </summary>
                SM_MIDEASTENABLED = 74,
                /*#endif /* WINVER >= 0x0400 */

                /*#if (WINVER >= 0x0500) || (_WIN32_WINNT >= 0x0400)*/
                /// <summary>
                /// 
                /// </summary>
                SM_MOUSEWHEELPRESENT = 75,
                /*#endif*/
                /*#if(WINVER >= 0x0500)*/
                /// <summary>
                /// 
                /// </summary>
                SM_XVIRTUALSCREEN = 76,
                /// <summary>
                /// 
                /// </summary>
                SM_YVIRTUALSCREEN = 77,
                /// <summary>
                /// 
                /// </summary>
                SM_CXVIRTUALSCREEN = 78,
                /// <summary>
                /// 
                /// </summary>
                SM_CYVIRTUALSCREEN = 79,
                /// <summary>
                /// Número de monitores de pantalla de un ordenador. Para obtener más información, vea la sección Comentarios de este tema.
                /// </summary>
                SM_CMONITORS = 80,
                /// <summary>
                /// 
                /// </summary>
                SM_SAMEDISPLAYFORMAT = 81,
                /*#endif /* WINVER >= 0x0500 */
                /*#if(_WIN32_WINNT >= 0x0500)*/
                /// <summary>
                /// 
                /// </summary>
                SM_IMMENABLED = 82,
                /*#endif /* _WIN32_WINNT >= 0x0500 */
                /*#if(_WIN32_WINNT >= 0x0501)*/
                /// <summary>
                /// 
                /// </summary>
                SM_CXFOCUSBORDER = 83,
                /// <summary>
                /// 
                /// </summary>
                SM_CYFOCUSBORDER = 84,
                /*#endif /* _WIN32_WINNT >= 0x0501 */

                /*#if(_WIN32_WINNT >= 0x0501)*/
                /// <summary>
                /// 
                /// </summary>
                SM_TABLETPC = 86,
                /// <summary>
                /// 
                /// </summary>
                SM_MEDIACENTER = 87,
                /*#endif /* _WIN32_WINNT >= 0x0501 */

                /*#if (WINVER < 0x0500) && (!defined(_WIN32_WINNT) || (_WIN32_WINNT < 0x0400))*/
                /// <summary>
                /// 
                /// </summary>
                SM_CMETRICS_OTHER = 76,
                /*#elif WINVER == 0x500*/
                /// <summary>
                /// 
                /// </summary>
                SM_CMETRICS_2000 = 83,
                /*#else*/
                /// <summary>
                /// Un valor distinto de cero indica que el sistema operativo actual es Windows 7 Starter Edition, Windows Vista Starter o Windows XP Starter Edition; caso contrario, 0.
                /// </summary>
                SM_CMETRICS_NT = 88,
                /*#endif*/

                /*#if(WINVER >= 0x0500)*/
                /// <summary>
                /// 
                /// </summary>
                SM_REMOTESESSION = 0x1000,

                /*#if(_WIN32_WINNT >= 0x0501)*/
                /// <summary>
                /// 
                /// </summary>
                SM_SHUTTINGDOWN = 0x2000,
                /*#endif /* _WIN32_WINNT >= 0x0501 */

                /*#if(WINVER >= 0x0501)*/
                /// <summary>
                /// 
                /// </summary>
                SM_REMOTECONTROL = 0x2001,
                /*#endif /* WINVER >= 0x0501 */


                /*#endif /* WINVER >= 0x0500 */
            }
            #endregion

            #region [internal] (enum) SPI: Representa una característica o valor de configuración del sistema a recuperar.
            /// <summary>
            /// Representa una característica o valor de configuración del sistema a recuperar.
            /// Tener en cuenta que todos los valores <strong>SM_CX*</strong> son anchos y <strong>SM_CY*</strong> los valores de altura.
            /// También tener en cuenta que los ajustes diseñados para devolver datos <see cref="T:System.Boolean"/>, el valor <strong>true</strong>
            /// se representa con un valor distinto de cero y <strong>false</strong> con valor cero.
            /// SPI_ System-wide parameter - Used in SystemParametersInfo function
            /// </summary>            
            [Description("SPI_(System-wide parameter - Used in SystemParametersInfo function )")]
            internal enum SPI : uint
            {
                /// <summary>
                /// Determines whether the warning beeper is on.
                /// The pvParam parameter must point to a BOOL variable that receives TRUE if the beeper is on, or FALSE if it is off.
                /// </summary>
                GetBeep = 0x0001,
                /// <summary>
                /// Turns the warning beeper on or off. The uiParam parameter specifies TRUE for on, or FALSE for off.
                /// </summary>
                SetBeep = 0x0002,
                /// <summary>
                /// Retrieves the two mouse threshold values and the mouse speed.
                /// </summary>
                GetMouse = 0x0003,
                /// <summary>
                /// Establece los valores de umbral y la velocidad del ratón.
                /// </summary>
                SetMouse = 0x0004,
                /// <summary>
                /// Retrieves the border multiplier factor that determines the width of a window's sizing border.
                /// The pvParam parameter must point to an integer variable that receives this value.
                /// </summary>
                GetBorder = 0x0005,
                /// <summary>
                /// Sets the border multiplier factor that determines the width of a window's sizing border.
                /// The uiParam parameter specifies the new value.
                /// </summary>
                SetBorder = 0x0006,
                /// <summary>
                /// Retrieves the keyboard repeat-speed setting, which is a value in the range from 0 (approximately 2.5 repetitions per second)
                /// through 31 (approximately 30 repetitions per second). The actual repeat rates are hardware-dependent and may vary from
                /// a linear scale by as much as 20%. The pvParam parameter must point to a DWORD variable that receives the setting
                /// </summary>
                GetKeyboardSpeed = 0x000A,
                /// <summary>
                /// Sets the keyboard repeat-speed setting. The uiParam parameter must specify a value in the range from 0
                /// (approximately 2.5 repetitions per second) through 31 (approximately 30 repetitions per second).
                /// The actual repeat rates are hardware-dependent and may vary from a linear scale by as much as 20%.
                /// If uiParam is greater than 31, the parameter is set to 31.
                /// </summary>
                SetKeyboardSpeed = 0x000B,
                /// <summary>
                /// Not implemented.
                /// </summary>
                LangDriver = 0x000C,
                /// <summary>
                /// Sets or retrieves the width, in pixels, of an icon cell. The system uses this rectangle to arrange icons in large icon view.
                /// To set this value, set uiParam to the new value and set pvParam to null. You cannot set this value to less than SM_CXICON.
                /// To retrieve this value, pvParam must point to an integer that receives the current value.
                /// </summary>
                IconhorizontalSpacing = 0x000D,
                /// <summary>
                /// Retrieves the screen saver time-out value, in seconds. The pvParam parameter must point to an integer variable that receives the value.
                /// </summary>
                GetScreenSaveTimeout = 0x000E,
                /// <summary>
                /// Sets the screen saver time-out value to the value of the uiParam parameter. This value is the amount of time, in seconds,
                /// that the system must be idle before the screen saver activates.
                /// </summary>
                SetScreenSaveTimeout = 0x000F,
                /// <summary>
                /// Determines whether screen saving is enabled. The pvParam parameter must point to a bool variable that receives TRUE
                /// if screen saving is enabled, or FALSE otherwise.
                /// </summary>
                GetScreenSaveActive = 0x0010,
                /// <summary>
                /// Sets the state of the screen saver. The uiParam parameter specifies TRUE to activate screen saving, or FALSE to deactivate it.
                /// </summary>
                SetScreenSaveActive = 0x0011,
                /// <summary>
                /// Retrieves the current granularity value of the desktop sizing grid. The pvParam parameter must point to an integer variable
                /// that receives the granularity.
                /// </summary>
                GetGridGranularity = 0x0012,
                /// <summary>
                /// Sets the granularity of the desktop sizing grid to the value of the uiParam parameter.
                /// </summary>
                SetGridGranularity = 0x0013,
                /// <summary>
                /// Sets the desktop wallpaper. The value of the pvParam parameter determines the new wallpaper. To specify a wallpaper bitmap,
                /// set pvParam to point to a null-terminated string containing the name of a bitmap file. Setting pvParam to "" removes the wallpaper.
                /// Setting pvParam to SETWALLPAPER_DEFAULT or null reverts to the default wallpaper.
                /// </summary>
                SetDeskWallpaper = 0x0014,
                /// <summary>
                /// Sets the current desktop pattern by causing Windows to read the Pattern= setting from the WIN.INI file.
                /// </summary>
                SetDeskPattern = 0x0015,
                /// <summary>
                /// Retrieves the keyboard repeat-delay setting, which is a value in the range from 0 (approximately 250 ms delay) through 3
                /// (approximately 1 second delay). The actual delay associated with each value may vary depending on the hardware. The pvParam parameter must point to an integer variable that receives the setting.
                /// </summary>
                GetKeyboardDelay = 0x0016,
                /// <summary>
                /// Sets the keyboard repeat-delay setting. The uiParam parameter must specify 0, 1, 2, or 3, where zero sets the shortest delay
                /// (approximately 250 ms) and 3 sets the longest delay (approximately 1 second). The actual delay associated with each value may
                /// vary depending on the hardware.
                /// </summary>
                SetKeyboardDelay = 0x0017,
                /// <summary>
                /// Sets or retrieves the height, in pixels, of an icon cell.
                /// To set this value, set uiParam to the new value and set pvParam to null. You cannot set this value to less than SM_CYICON.
                /// To retrieve this value, pvParam must point to an integer that receives the current value.
                /// </summary>
                IconVerticalSpacing = 0x0018,

                #region GetIconTitleWrap. Determina si se habilita el ajuste de icono-título.
                /// <summary>
                /// Determina si está habilitada el arrastre completo de las ventanas (ver contenido al arrastrar).
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                GetIconTitleWrap = 0x0019,
                #endregion

                #region SetIconTitleWrap. Activa o desactiva la característica. Ver GetIconTitleWrap.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetIconTitleWrap"/>.
                /// </summary>
                SetIconTitleWrap = 0x001A,
                #endregion

                /// <summary>
                /// Determines whether pop-up menus are left-aligned or right-aligned, relative to the corresponding menu-bar item.
                /// The pvParam parameter must point to a bool variable that receives TRUE if left-aligned, or FALSE otherwise.
                /// </summary>
                GetMenuDropAlignment = 0x001B,
                /// <summary>
                /// Sets the alignment value of pop-up menus. The uiParam parameter specifies TRUE for right alignment, or FALSE for left alignment.
                /// </summary>
                SetMenuDropAlignment = 0x001C,
                /// <summary>
                /// Sets the width of the double-click rectangle to the value of the uiParam parameter.
                /// The double-click rectangle is the rectangle within which the second click of a double-click must fall for it to be registered
                /// as a double-click.
                /// To retrieve the width of the double-click rectangle, call GetSystemMetrics with the SM_CXDOUBLECLK flag.
                /// </summary>
                SetDoubleClkWidth = 0x001D,
                /// <summary>
                /// Sets the height of the double-click rectangle to the value of the uiParam parameter.
                /// The double-click rectangle is the rectangle within which the second click of a double-click must fall for it to be registered
                /// as a double-click.
                /// To retrieve the height of the double-click rectangle, call GetSystemMetrics with the SM_CYDOUBLECLK flag.
                /// </summary>
                SetDoubleClkHeight = 0x001E,
                /// <summary>
                /// Retrieves the logical font information for the current icon-title font. The uiParam parameter specifies the size of a LOGFONT structure,
                /// and the pvParam parameter must point to the LOGFONT structure to fill in.
                /// </summary>
                GetIconTitleLogFont = 0x001F,
                /// <summary>
                /// Sets the double-click time for the mouse to the value of the uiParam parameter. The double-click time is the maximum number
                /// of milliseconds that can occur between the first and second clicks of a double-click. You can also call the SetDoubleClickTime
                /// function to set the double-click time. To get the current double-click time, call the GetDoubleClickTime function.
                /// </summary>
                SetDoubleClickTime = 0x0020,
                /// <summary>
                /// Swaps or restores the meaning of the left and right mouse buttons. The uiParam parameter specifies TRUE to swap the meanings
                /// of the buttons, or FALSE to restore their original meanings.
                /// </summary>
                SetMouseButtonSwap = 0x0021,
                /// <summary>
                /// Sets the font that is used for icon titles. The uiParam parameter specifies the size of a LOGFONT structure,
                /// and the pvParam parameter must point to a LOGFONT structure.
                /// </summary>
                SetIconTitleLogFont = 0x0022,
                /// <summary>
                /// This flag is obsolete. Previous versions of the system use this flag to determine whether ALT+TAB fast task switching is enabled.
                /// For Windows 95, Windows 98, and Windows NT version 4.0 and later, fast task switching is always enabled.
                /// </summary>
                GetFastTaskWitch = 0x0023,
                /// <summary>
                /// This flag is obsolete. Previous versions of the system use this flag to enable or disable ALT+TAB fast task switching.
                /// For Windows 95, Windows 98, and Windows NT version 4.0 and later, fast task switching is always enabled.
                /// </summary>
                SetFastTaskWitch = 0x0024,


                //#if(WINVER >= 0x0400)

                #region SetDragFullWindows. Activa o desactiva la característica. Ver GetDragFullWindows.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetDragFullWindows"/>.
                /// </summary>
                SetDragFullWindows = 0x0025,
                #endregion

                #region GetDragFullWindows. Determina si está habilitada el arrastre completo de las ventanas (ver contenido al arrastrar).
                /// <summary>
                /// Determina si está habilitada el arrastre completo de las ventanas (ver contenido al arrastrar).
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Para Windows 95, está característica sólo está soportada si tiene instalado Windows Plus!. Ver <see cref="GetWindowsExtension"/>.
                /// </remarks>
                GetDragFullWindows = 0x0026,
                #endregion

                /// <summary>
                /// Retrieves the metrics associated with the nonclient area of nonminimized windows. The pvParam parameter must point
                /// to a NONCLIENTMETRICS structure that receives the information. Set the cbSize member of this structure and the uiParam parameter
                /// to sizeof(NONCLIENTMETRICS).
                /// </summary>
                GetNonClientMetrics = 0x0029,
                /// <summary>
                /// Sets the metrics associated with the nonclient area of nonminimized windows. The pvParam parameter must point
                /// to a NONCLIENTMETRICS structure that contains the new parameters. Set the cbSize member of this structure
                /// and the uiParam parameter to sizeof(NONCLIENTMETRICS). Also, the lfHeight member of the LOGFONT structure must be a negative value.
                /// </summary>
                SetNonClientMetrics = 0x002A,
                /// <summary>
                /// Retrieves the metrics associated with minimized windows. The pvParam parameter must point to a MINIMIZEDMETRICS structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(MINIMIZEDMETRICS).
                /// </summary>
                GetMinimizedMetrics = 0x002B,
                /// <summary>
                /// Sets the metrics associated with minimized windows. The pvParam parameter must point to a MINIMIZEDMETRICS structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(MINIMIZEDMETRICS).
                /// </summary>
                SetMinimizedMetrics = 0x002C,
                /// <summary>
                /// Retrieves the metrics associated with icons. The pvParam parameter must point to an ICONMETRICS structure that receives
                /// the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(ICONMETRICS).
                /// </summary>
                GetIconMetrics = 0x002D,
                /// <summary>
                /// Sets the metrics associated with icons. The pvParam parameter must point to an ICONMETRICS structure that contains
                /// the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(ICONMETRICS).
                /// </summary>
                SetIconMetrics = 0x002E,
                /// <summary>
                /// Sets the size of the work area. The work area is the portion of the screen not obscured by the system taskbar
                /// or by application desktop toolbars. The pvParam parameter is a pointer to a RECT structure that specifies the new work area rectangle,
                /// expressed in virtual screen coordinates. In a system with multiple display monitors, the function sets the work area
                /// of the monitor that contains the specified rectangle.
                /// </summary>
                SetWorkArea = 0x002F,
                /// <summary>
                /// Retrieves the size of the work area on the primary display monitor. The work area is the portion of the screen not obscured
                /// by the system taskbar or by application desktop toolbars. The pvParam parameter must point to a RECT structure that receives
                /// the coordinates of the work area, expressed in virtual screen coordinates.
                /// To get the work area of a monitor other than the primary display monitor, call the GetMonitorInfo function.
                /// </summary>
                GetWorkArea = 0x0030,
                /// <summary>
                /// Windows Me/98/95:  Pen windows is being loaded or unloaded. The uiParam parameter is TRUE when loading and FALSE
                /// when unloading pen windows. The pvParam parameter is null.
                /// </summary>
                SetPenWindows = 0x0031,
                /// <summary>
                /// Retrieves information about the HighContrast accessibility feature. The pvParam parameter must point to a HIGHCONTRAST structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(HIGHCONTRAST).
                /// For a general discussion, see remarks.
                /// Windows NT:  This value is not supported.
                /// </summary>
                /// <remarks>
                /// There is a difference between the High Contrast color scheme and the High Contrast Mode. The High Contrast color scheme changes
                /// the system colors to colors that have obvious contrast; you switch to this color scheme by using the Display Options in the control panel.
                /// The High Contrast Mode, which uses SPI_GETHIGHCONTRAST and SPI_SETHIGHCONTRAST, advises applications to modify their appearance
                /// for visually-impaired users. It involves such things as audible warning to users and customized color scheme
                /// (using the Accessibility Options in the control panel). For more information, see HIGHCONTRAST on MSDN.
                /// For more information on general accessibility features, see Accessibility on MSDN.
                /// </remarks>
                GetHighContrast = 0x0042,
                /// <summary>
                /// Sets the parameters of the HighContrast accessibility feature. The pvParam parameter must point to a HIGHCONTRAST structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(HIGHCONTRAST).
                /// Windows NT:  This value is not supported.
                /// </summary>
                SetHighContrast = 0x0043,
                /// <summary>
                /// Determines whether the user relies on the keyboard instead of the mouse, and wants applications to display keyboard interfaces
                /// that would otherwise be hidden. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if the user relies on the keyboard; or FALSE otherwise.
                /// Windows NT:  This value is not supported.
                /// </summary>
                GetKeyboardPref = 0x0044,
                /// <summary>
                /// Sets the keyboard preference. The uiParam parameter specifies TRUE if the user relies on the keyboard instead of the mouse,
                /// and wants applications to display keyboard interfaces that would otherwise be hidden; uiParam is FALSE otherwise.
                /// Windows NT:  This value is not supported.
                /// </summary>
                SetKeyboardPref = 0x0045,
                /// <summary>
                /// Determines whether a screen reviewer utility is running. A screen reviewer utility directs textual information to an output device,
                /// such as a speech synthesizer or Braille display. When this flag is set, an application should provide textual information
                /// in situations where it would otherwise present the information graphically.
                /// The pvParam parameter is a pointer to a BOOL variable that receives TRUE if a screen reviewer utility is running, or FALSE otherwise.
                /// Windows NT:  This value is not supported.
                /// </summary>
                GetScreenReader = 0x0046,
                /// <summary>
                /// Determines whether a screen review utility is running. The uiParam parameter specifies TRUE for on, or FALSE for off.
                /// Windows NT:  This value is not supported.
                /// </summary>
                SetScreenReader = 0x0047,
                /// <summary>
                /// Retrieves the animation effects associated with user actions. The pvParam parameter must point to an ANIMATIONINFO structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(ANIMATIONINFO).
                /// </summary>
                GetAnimation = 0x0048,
                /// <summary>
                /// Sets the animation effects associated with user actions. The pvParam parameter must point to an ANIMATIONINFO structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(ANIMATIONINFO).
                /// </summary>
                SetAnimation = 0x0049,


                #region GetFontSmoothing. Determina si está habilitada la función de suavizado de fuentes.
                /// <summary>
                /// Determina si está habilitada la función de suavizado de fuentes.
                /// Esta función utiliza el suavizado de fuentes para las curvas de la fuente se dibujan más suaves en diferentes niveles de gris.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Para Windows 95, está característica sólo está soportada si tiene instalado Windows Plus!. Ver <see cref="GetWindowsExtension"/>.
                /// </remarks>
                GetFontSmoothing = 0x004A,
                #endregion

                #region SetFontSmoothing. Activa o desactiva la característica. Ver GetFontSmoothing.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetFontSmoothing"/>.
                /// </summary>
                SetFontSmoothing = 0x004B,
                #endregion

                /// <summary>
                /// Sets the width, in pixels, of the rectangle used to detect the start of a drag operation. Set uiParam to the new value.
                /// To retrieve the drag width, call GetSystemMetrics with the SM_CXDRAG flag.
                /// </summary>
                SetDragWidth = 0x004C,
                /// <summary>
                /// Sets the height, in pixels, of the rectangle used to detect the start of a drag operation. Set uiParam to the new value.
                /// To retrieve the drag height, call GetSystemMetrics with the SM_CYDRAG flag.
                /// </summary>
                SetDragHeight = 0x004D,
                /// <summary>
                /// Used internally; applications should not use this value.
                /// </summary>
                SetHandled = 0x004E,
                /// <summary>
                /// Retrieves the time-out value for the low-power phase of screen saving. The pvParam parameter must point to an integer variable
                /// that receives the value. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                GetLowPowerTimeout = 0x004F,
                /// <summary>
                /// Retrieves the time-out value for the power-off phase of screen saving. The pvParam parameter must point to an integer variable
                /// that receives the value. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                GetPowerOffTimeout = 0x0050,
                /// <summary>
                /// Sets the time-out value, in seconds, for the low-power phase of screen saving. The uiParam parameter specifies the new value.
                /// The pvParam parameter must be null. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                SetLowPowerTimeout = 0x0051,
                /// <summary>
                /// Sets the time-out value, in seconds, for the power-off phase of screen saving. The uiParam parameter specifies the new value.
                /// The pvParam parameter must be null. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                SetPowerOffTimeout = 0x0052,
                /// <summary>
                /// Determines whether the low-power phase of screen saving is enabled. The pvParam parameter must point to a BOOL variable
                /// that receives TRUE if enabled, or FALSE if disabled. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                GetLowPowerActive = 0x0053,
                /// <summary>
                /// Determines whether the power-off phase of screen saving is enabled. The pvParam parameter must point to a BOOL variable
                /// that receives TRUE if enabled, or FALSE if disabled. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                GetPowerOffActive = 0x0054,
                /// <summary>
                /// Activates or deactivates the low-power phase of screen saving. Set uiParam to 1 to activate, or zero to deactivate.
                /// The pvParam parameter must be null. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                SetLowPowerActive = 0x0055,
                /// <summary>
                /// Activates or deactivates the power-off phase of screen saving. Set uiParam to 1 to activate, or zero to deactivate.
                /// The pvParam parameter must be null. This flag is supported for 32-bit applications only.
                /// Windows NT, Windows Me/98:  This flag is supported for 16-bit and 32-bit applications.
                /// Windows 95:  This flag is supported for 16-bit applications only.
                /// </summary>
                SetPowerOfActive = 0x0056,
                /// <summary>
                /// Reloads the system cursors. Set the uiParam parameter to zero and the pvParam parameter to null.
                /// </summary>
                SetCursors = 0x0057,
                /// <summary>
                /// Reloads the system icons. Set the uiParam parameter to zero and the pvParam parameter to null.
                /// </summary>
                SetIcons = 0x0058,
                /// <summary>
                /// Retrieves the input locale identifier for the system default input language. The pvParam parameter must point
                /// to an HKL variable that receives this value. For more information, see Languages, Locales, and Keyboard Layouts on MSDN.
                /// </summary>
                GetDefaultInputLang = 0x0059,
                /// <summary>
                /// Sets the default input language for the system shell and applications. The specified language must be displayable
                /// using the current system character set. The pvParam parameter must point to an HKL variable that contains
                /// the input locale identifier for the default language. For more information, see Languages, Locales, and Keyboard Layouts on MSDN.
                /// </summary>
                SetDefaultInputLang = 0x005A,
                /// <summary>
                /// Sets the hot key set for switching between input languages. The uiParam and pvParam parameters are not used.
                /// The value sets the shortcut keys in the keyboard property sheets by reading the registry again. The registry must be set before this flag is used. the path in the registry is \HKEY_CURRENT_USER\keyboard layout\toggle. Valid values are "1" = ALT+SHIFT, "2" = CTRL+SHIFT, and "3" = none.
                /// </summary>
                SetLangToggle = 0x005B,
                /// <summary>
                /// Windows 95:  Determines whether the Windows extension, Windows Plus!, is installed. Set the uiParam parameter to 1.
                /// The pvParam parameter is not used. The function returns TRUE if the extension is installed, or FALSE if it is not.
                /// </summary>
                GetWindowsExtension = 0x005C,
                /// <summary>
                /// Enables or disables the Mouse Trails feature, which improves the visibility of mouse cursor movements by briefly showing
                /// a trail of cursors and quickly erasing them.
                /// To disable the feature, set the uiParam parameter to zero or 1. To enable the feature, set uiParam to a value greater than 1
                /// to indicate the number of cursors drawn in the trail.
                /// Windows 2000/NT:  This value is not supported.
                /// </summary>
                SetMouseTrails = 0x005D,
                /// <summary>
                /// Determines whether the Mouse Trails feature is enabled. This feature improves the visibility of mouse cursor movements
                /// by briefly showing a trail of cursors and quickly erasing them.
                /// The pvParam parameter must point to an integer variable that receives a value. If the value is zero or 1, the feature is disabled.
                /// If the value is greater than 1, the feature is enabled and the value indicates the number of cursors drawn in the trail.
                /// The uiParam parameter is not used.
                /// Windows 2000/NT:  This value is not supported.
                /// </summary>
                GetMouseTrails = 0x005E,
                /// <summary>
                /// Windows Me/98:  Used internally; applications should not use this flag.
                /// </summary>
                SetScreenSaverRunning = 0x0061,
                /// <summary>
                /// Same as SPI_SETSCREENSAVERRUNNING.
                /// </summary>
                ScreenSaverRunning = SetScreenSaverRunning,
                //#endif /* WINVER >= 0x0400 */

                /// <summary>
                /// Retrieves information about the FilterKeys accessibility feature. The pvParam parameter must point to a FILTERKEYS structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(FILTERKEYS).
                /// </summary>
                GetFilterKeys = 0x0032,
                /// <summary>
                /// Sets the parameters of the FilterKeys accessibility feature. The pvParam parameter must point to a FILTERKEYS structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(FILTERKEYS).
                /// </summary>
                SetFilterKeys = 0x0033,
                /// <summary>
                /// Retrieves information about the ToggleKeys accessibility feature. The pvParam parameter must point to a TOGGLEKEYS structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(TOGGLEKEYS).
                /// </summary>
                GetToggleKeys = 0x0034,
                /// <summary>
                /// Sets the parameters of the ToggleKeys accessibility feature. The pvParam parameter must point to a TOGGLEKEYS structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(TOGGLEKEYS).
                /// </summary>
                SetToggleKeys = 0x0035,
                /// <summary>
                /// Retrieves information about the MouseKeys accessibility feature. The pvParam parameter must point to a MOUSEKEYS structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(MOUSEKEYS).
                /// </summary>
                GetMouseKeys = 0x0036,
                /// <summary>
                /// Sets the parameters of the MouseKeys accessibility feature. The pvParam parameter must point to a MOUSEKEYS structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(MOUSEKEYS).
                /// </summary>
                SetMouseKeys = 0x0037,

                #region GetShowSounds. Determina si la opción sonido de la característica de accesibilidad esta activado los eventos se muestran de forma audible.
                /// <summary>
                /// Determina si la opción sonido de la característica de accesibilidad esta activado los eventos se muestran de forma audible.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                GetShowSounds = 0x0038,
                #endregion

                #region SetShowSounds. Activa o desactiva la característica. Ver GetShowSounds.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetShowSounds"/>.
                /// </summary>
                SetShowSounds = 0x0039,
                #endregion

                /// <summary>
                /// Retrieves information about the StickyKeys accessibility feature. The pvParam parameter must point to a STICKYKEYS structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(STICKYKEYS).
                /// </summary>
                GetStickyKeys = 0x003A,
                /// <summary>
                /// Sets the parameters of the StickyKeys accessibility feature. The pvParam parameter must point to a STICKYKEYS structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(STICKYKEYS).
                /// </summary>
                SetStickyKeys = 0x003B,
                /// <summary>
                /// Retrieves information about the time-out period associated with the accessibility features. The pvParam parameter must point
                /// to an ACCESSTIMEOUT structure that receives the information. Set the cbSize member of this structure and the uiParam parameter
                /// to sizeof(ACCESSTIMEOUT).
                /// </summary>
                GetAccessTimeout = 0x003C,
                /// <summary>
                /// Sets the time-out period associated with the accessibility features. The pvParam parameter must point to an ACCESSTIMEOUT
                /// structure that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(ACCESSTIMEOUT).
                /// </summary>
                SetAccessTimeout = 0x003D,

                //#if(WINVER >= 0x0400)
                /// <summary>
                /// Windows Me/98/95:  Retrieves information about the SerialKeys accessibility feature. The pvParam parameter must point
                /// to a SERIALKEYS structure that receives the information. Set the cbSize member of this structure and the uiParam parameter
                /// to sizeof(SERIALKEYS).
                /// Windows Server 2003, Windows XP/2000/NT:  Not supported. The user controls this feature through the control panel.
                /// </summary>
                GetSerialKeys = 0x003E,
                /// <summary>
                /// Windows Me/98/95:  Sets the parameters of the SerialKeys accessibility feature. The pvParam parameter must point
                /// to a SERIALKEYS structure that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter
                /// to sizeof(SERIALKEYS).
                /// Windows Server 2003, Windows XP/2000/NT:  Not supported. The user controls this feature through the control panel.
                /// </summary>
                SetSerialKeys = 0x003F,
                //#endif /* WINVER >= 0x0400 */

                /// <summary>
                /// Retrieves information about the SoundSentry accessibility feature. The pvParam parameter must point to a SOUNDSENTRY structure
                /// that receives the information. Set the cbSize member of this structure and the uiParam parameter to sizeof(SOUNDSENTRY).
                /// </summary>
                GetSoundEntry = 0x0040,
                /// <summary>
                /// Sets the parameters of the SoundSentry accessibility feature. The pvParam parameter must point to a SOUNDSENTRY structure
                /// that contains the new parameters. Set the cbSize member of this structure and the uiParam parameter to sizeof(SOUNDSENTRY).
                /// </summary>
                SetSoundEntry = 0x0041,

                //#if(_WIN32_WINNT >= 0x0400)
                /// <summary>
                /// Determines whether the snap-to-default-button feature is enabled. If enabled, the mouse cursor automatically moves
                /// to the default button, such as OK or Apply, of a dialog box. The pvParam parameter must point to a BOOL variable
                /// that receives TRUE if the feature is on, or FALSE if it is off.
                /// Windows 95:  Not supported.
                /// </summary>
                GetSnapToDefButton = 0x005F,
                /// <summary>
                /// Enables or disables the snap-to-default-button feature. If enabled, the mouse cursor automatically moves to the default button,
                /// such as OK or Apply, of a dialog box. Set the uiParam parameter to TRUE to enable the feature, or FALSE to disable it.
                /// Applications should use the ShowWindow function when displaying a dialog box so the dialog manager can position the mouse cursor.
                /// Windows 95:  Not supported.
                /// </summary>
                SetSnapToDefButton = 0x0060,
                //#endif /* _WIN32_WINNT >= 0x0400 */

                //#if (_WIN32_WINNT >= 0x0400) || (_WIN32_WINDOWS > 0x0400)
                /// <summary>
                /// Retrieves the width, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. The pvParam parameter must point to a UINT variable that receives the width.
                /// Windows 95:  Not supported.
                /// </summary>
                GetMouseHoverWidth = 0x0062,
                /// <summary>
                /// Retrieves the width, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. The pvParam parameter must point to a UINT variable that receives the width.
                /// Windows 95:  Not supported.
                /// </summary>
                SetMouseHoverWidth = 0x0063,
                /// <summary>
                /// Retrieves the height, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. The pvParam parameter must point to a UINT variable that receives the height.
                /// Windows 95:  Not supported.
                /// </summary>
                GetMouseHoverHeight = 0x0064,
                /// <summary>
                /// Sets the height, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. Set the uiParam parameter to the new height.
                /// Windows 95:  Not supported.
                /// </summary>
                SetMouseHoverHeight = 0x0065,
                /// <summary>
                /// Retrieves the time, in milliseconds, that the mouse pointer has to stay in the hover rectangle for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. The pvParam parameter must point to a UINT variable that receives the time.
                /// Windows 95:  Not supported.
                /// </summary>
                GetMouseHoverTime = 0x0066,
                /// <summary>
                /// Sets the time, in milliseconds, that the mouse pointer has to stay in the hover rectangle for TrackMouseEvent
                /// to generate a WM_MOUSEHOVER message. This is used only if you pass HOVER_DEFAULT in the dwHoverTime parameter in the call to TrackMouseEvent. Set the uiParam parameter to the new time.
                /// Windows 95:  Not supported.
                /// </summary>
                SetMouseHoverTime = 0x0067,
                /// <summary>
                /// Retrieves the number of lines to scroll when the mouse wheel is rotated. The pvParam parameter must point
                /// to a UINT variable that receives the number of lines. The default value is 3.
                /// Windows 95:  Not supported.
                /// </summary>
                GetWheelScrollLines = 0x0068,
                /// <summary>
                /// Sets the number of lines to scroll when the mouse wheel is rotated. The number of lines is set from the uiParam parameter.
                /// The number of lines is the suggested number of lines to scroll when the mouse wheel is rolled without using modifier keys.
                /// If the number is 0, then no scrolling should occur. If the number of lines to scroll is greater than the number of lines viewable,
                /// and in particular if it is WHEEL_PAGESCROLL (#defined as UINT_MAX), the scroll operation should be interpreted
                /// as clicking once in the page down or page up regions of the scroll bar.
                /// Windows 95:  Not supported.
                /// </summary>
                SetWheelScrollLines = 0x0069,
                /// <summary>
                /// Retrieves the time, in milliseconds, that the system waits before displaying a shortcut menu when the mouse cursor is
                /// over a submenu item. The pvParam parameter must point to a DWORD variable that receives the time of the delay.
                /// Windows 95:  Not supported.
                /// </summary>
                GetMenuShowDelay = 0x006A,
                /// <summary>
                /// Sets uiParam to the time, in milliseconds, that the system waits before displaying a shortcut menu when the mouse cursor is
                /// over a submenu item.
                /// Windows 95:  Not supported.
                /// </summary>
                SetMenuShowDelay = 0x006B,
                /// <summary>
                /// Determines whether the IME status window is visible (on a per-user basis). The pvParam parameter must point to a BOOL variable
                /// that receives TRUE if the status window is visible, or FALSE if it is not.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetShowImeUI = 0x006E,
                /// <summary>
                /// Sets whether the IME status window is visible or not on a per-user basis. The uiParam parameter specifies TRUE for on or FALSE for off.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetShowImeUI = 0x006F,
                //#endif

                //#if(WINVER >= 0x0500)
                /// <summary>
                /// Retrieves the current mouse speed. The mouse speed determines how far the pointer will move based on the distance the mouse moves.
                /// The pvParam parameter must point to an integer that receives a value which ranges between 1 (slowest) and 20 (fastest).
                /// A value of 10 is the default. The value can be set by an end user using the mouse control panel application or
                /// by an application using SPI_SETMOUSESPEED.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetMouseSpeed = 0x0070,
                /// <summary>
                /// Sets the current mouse speed. The pvParam parameter is an integer between 1 (slowest) and 20 (fastest). A value of 10 is the default.
                /// This value is typically set using the mouse control panel application.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetMouseSpeed = 0x0071,
                /// <summary>
                /// Determines whether a screen saver is currently running on the window station of the calling process.
                /// The pvParam parameter must point to a BOOL variable that receives TRUE if a screen saver is currently running, or FALSE otherwise.
                /// Note that only the interactive window station, "WinSta0", can have a screen saver running.
                /// </summary>
                /// <remarks>
                /// Está opción no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetScreenSaverRunning = 0x0072,
                /// <summary>
                /// Recupera la ruta de acceso completa del archivo de mapa de bits para el fondo de escritorio.
                /// El parámetro <strong>pvParam</strong> debe apuntar a un búfer para recibir la cadena de ruta terminada en null.
                /// Establezca el parámetro <strong>uiParam</strong> con el tamaño, en carácteres del buffer de <strong>pvParam</strong>.
                /// La cadena devuelta no podrá superar la longitud MAX_PATH. 
                /// Si no hay ningún tapiz, se devolverá una cadena vacía.
                /// </summary>
                /// <remarks>
                /// Está opción no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetDeskWallPaper = 0x0073,
                //#endif /* WINVER >= 0x0500 */

                //#if(WINVER >= 0x0500)
                /// <summary>
                /// Determines whether active window tracking (activating the window the mouse is on) is on or off. The pvParam parameter must point
                /// to a BOOL variable that receives TRUE for on, or FALSE for off.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetActiveWindowTracking = 0x1000,
                /// <summary>
                /// Sets active window tracking (activating the window the mouse is on) either on or off. Set pvParam to TRUE for on or FALSE for off.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetActiveWindowTracking = 0x1001,

                #region GetMenuAnimation. Determina si está habilitada la característica de animación de menú.
                /// <summary>
                /// Determina si está habilitada la característica de animación de menú.
                /// Sí la característica <see cref="GetMenuFade"/> está activada indica si los menús usan atenuación o animación.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                GetMenuAnimation = 0x1002,
                #endregion

                #region SetMenuAnimation. Activa o desactiva la característica. Ver GetMenuAnimation.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetMenuAnimation"/>.
                /// </summary>
                SetMenuAnimation = 0x1003,
                #endregion

                #region GetComboboxAnimation. Determina si está habilitado el efecto de apertura para los cuadros combinados.
                /// <summary>
                /// Determina si está habilitado el efecto de apertura para los cuadros combinados.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong>
                /// para indicar que está activado o <strong>false</strong> si está desactivado.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows 95.
                /// </remarks>                
                GetComboboxAnimation = 0x1004,
                #endregion

                #region SetComboboxAnimation. Activa o desactiva la característica. Ver GetComboboxAnimation.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetComboboxAnimation"/>.
                /// </summary>
                SetComboboxAnimation = 0x1005,
                #endregion

                #region GetListBoxSmoothScrolling. Determina si está habilitado el efecto de desplazamiento suave para cuadros de lista.
                /// <summary>
                /// Determina si está habilitado el efecto de desplazamiento suave para cuadros de lista.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows 95.
                /// </remarks>
                GetListBoxSmoothScrolling = 0x1006,
                #endregion

                #region SetListBoxSmoothScrolling. Activa o desactiva la característica. Ver GetListBoxSmoothScrolling.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetListBoxSmoothScrolling"/>.
                /// </summary>
                SetListBoxSmoothScrolling = 0x1007,
                #endregion

                /// <summary>
                /// Determines whether the gradient effect for window title bars is enabled. The pvParam parameter must point to a BOOL variable
                /// that receives TRUE for enabled, or FALSE for disabled. For more information about the gradient effect, see the GetSysColor function.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetGradientCaptions = 0x1008,
                /// <summary>
                /// Enables or disables the gradient effect for window title bars. Set the pvParam parameter to TRUE to enable it, or FALSE to disable it.
                /// The gradient effect is possible only if the system has a color depth of more than 256 colors. For more information about
                /// the gradient effect, see the GetSysColor function.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetGradientCaptions = 0x1009,
                /// <summary>
                /// Determines whether menu access keys are always underlined. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if menu access keys are always underlined, and FALSE if they are underlined only when the menu is activated by the keyboard.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetKeyboardCues = 0x100A,
                /// <summary>
                /// Sets the underlining of menu access key letters. The pvParam parameter is a BOOL variable. Set pvParam to TRUE to always underline menu
                /// access keys, or FALSE to underline menu access keys only when the menu is activated from the keyboard.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetKeyboardCues = 0x100B,
                /// <summary>
                /// Same as SPI_GETKEYBOARDCUES.
                /// </summary>
                GetMenuUnderlines = GetKeyboardCues,
                /// <summary>
                /// Same as SPI_SETKEYBOARDCUES.
                /// </summary>
                SetMenuUnderlines = SetKeyboardCues,
                /// <summary>
                /// Determines whether windows activated through active window tracking will be brought to the top. The pvParam parameter must point
                /// to a BOOL variable that receives TRUE for on, or FALSE for off.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetActiveWndTrkZorder = 0x100C,
                /// <summary>
                /// Determines whether or not windows activated through active window tracking should be brought to the top. Set pvParam to TRUE
                /// for on or FALSE for off.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetActiveWndTrkZorder = 0x100D,

                #region GetHotTracking. Determina si está habilitado el seguimiento activo de los elementos de la interfaz de usuario, como barras de menús, los nombres de menú.
                /// <summary>
                /// Determina si está habilitado el seguimiento activo de los elementos de la interfaz de usuario, como barras de menús, los nombres de menú.
                /// Seguimiento activo significa que cuando el cursor se mueve sobre un elemento, este se dibuja con relieve pero no está seleccionado.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows 95.
                /// </remarks>
                GetHotTracking = 0x100E,
                #endregion

                #region SetHotTracking. Activa o desactiva la característica. Ver GetHotTracking.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetHotTracking"/>.
                /// </summary>
                SetHotTracking = 0x100F,
                #endregion

                #region GetMenuFade. Determina si está habilitada la animación del cierre de menú.
                /// <summary>
                /// Determina si está habilitada la animación del cierre de menú.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetMenuFade = 0x1012,
                #endregion

                #region SetMenuFade. Activa o desactiva la característica. Ver GetMenuFade.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetMenuFade"/>.
                /// </summary>
                SetMenuFade = 0x1013,
                #endregion

                #region GetSelectionFade. Determina si está habilitado el efecto de desvanecimiento de la selección.
                /// <summary>
                /// Determina si está habilitado el efecto de desvanecimiento de la selección.
                /// El efecto de desvanecimiento de la selección hace que el elemento de menú seleccionado por el usuario permanezca en la pantalla brevemente mientras desaparece lentamente.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetSelectionFade = 0x1014,
                #endregion

                #region SetSelectionFade. Activa o desactiva la característica. Ver GetSelectionFade.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetSelectionFade"/>.
                /// </summary>
                SetSelectionFade = 0x1015,
                #endregion

                #region GetTooltipAnimation. Determina si está habilitada la animación de los globos de ayuda sobre herramientas.
                /// <summary>
                /// Determina si está habilitada la animación de los globos de ayuda sobre herramientas.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetTooltipAnimation = 0x1016,
                #endregion

                #region SetTooltipAnimation. Activa o desactiva la característica. Ver GetTooltipAnimation.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetTooltipAnimation"/>.
                /// </summary>
                SetTooltipAnimation = 0x1017,
                #endregion

                #region GetTooltipFade. Si está habilitada la SetTooltipAnimation, GetTooltipFade indica si los globos de ayuda utilizan un efecto de transición o no.
                /// <summary>
                /// Si está habilitada la <see cref="SetTooltipAnimation"/>, <strong>GetTooltipFade</strong> indica si los globos de ayuda utilizan un efecto de transición o no.
                /// El efecto de desvanecimiento de la selección hace que el elemento de menú seleccionado por el usuario permanezca en la pantalla brevemente mientras desaparece lentamente.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la caracteristíca está activada ó <strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetTooltipFade = 0x1018,
                #endregion

                #region SetTooltipFade. Activa o desactiva la característica. Ver GetTooltipFade.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetTooltipFade"/>.
                /// </summary>
                SetTooltipFade = 0x1019,
                #endregion

                #region GetCursorShadow. Determina si el cursor del ratón tiene una sombra alrededor.
                /// <summary>
                /// Determina si el cursor del ratón tiene una sombra alrededor.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si la sombra del cursor está activada ó <strong>false</strong> si está deshabilitado.
                /// </summary>
                /// <remarks>
                /// El efecto sólo es apreciable en sistemas que tengan como mínimo 256 colores de profundidad de color.
                /// Está característica no está soportada por Windows NT, Windows Me/98/95.
                /// </remarks>
                GetCursorShadow = 0x101A,
                #endregion

                #region SetCursorShadow. Activa o desactiva la característica. Ver GetCursorShadow.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetCursorShadow"/>.
                /// </summary>
                SetCursorShadow = 0x101B,
                #endregion

                /// <summary>
                /// Retrieves the state of the Mouse Sonar feature. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if enabled or FALSE otherwise. For more information, see About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                GetMouseSonar = 0x101C,
                /// <summary>
                /// Turns the Sonar accessibility feature on or off. This feature briefly shows several concentric circles around the mouse pointer
                /// when the user presses and releases the CTRL key. The pvParam parameter specifies TRUE for on and FALSE for off. The default is off.
                /// For more information, see About Mouse Input.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                SetMouseSonar = 0x101D,
                /// <summary>
                /// Retrieves the state of the Mouse ClickLock feature. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if enabled, or FALSE otherwise. For more information, see About Mouse Input.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                GetMouseClickLock = 0x101E,
                /// <summary>
                /// Turns the Mouse ClickLock accessibility feature on or off. This feature temporarily locks down the primary mouse button
                /// when that button is clicked and held down for the time specified by SPI_SETMOUSECLICKLOCKTIME. The uiParam parameter specifies
                /// TRUE for on,
                /// or FALSE for off. The default is off. For more information, see Remarks and About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                SetMouseClickLock = 0x101F,
                /// <summary>
                /// Retrieves the state of the Mouse Vanish feature. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if enabled or FALSE otherwise. For more information, see About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                GetMouseVanish = 0x1020,
                /// <summary>
                /// Turns the Vanish feature on or off. This feature hides the mouse pointer when the user types; the pointer reappears
                /// when the user moves the mouse. The pvParam parameter specifies TRUE for on and FALSE for off. The default is off.
                /// For more information, see About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                SetMouseVanish = 0x1021,

                #region GetFlatMenu. Determina si los menús de usuario nativos tienen apariencia de menú plano.
                /// <summary>
                /// Determina si los menús de usuario nativos tienen apariencia de menú plano.
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si se establece la apariencia;<strong>false</strong> en caso contrario.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows 2000.
                /// </remarks>
                GetFlatMenu = 0x1022,
                #endregion

                #region SetFlatMenu. Activa o desactiva la característica. Ver GetFlatMenu.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetFlatMenu"/>.
                /// </summary>
                SetFlatMenu = 0x1023,
                #endregion

                #region GetDropShadow. Determina si está habilitado el efecto de sombra paralela.
                /// <summary>
                /// Determina si está habilitado el efecto de sombra paralela. 
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si está habilitada;<strong>false</strong> si está deshabilitado.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows 2000/NT, Windows Me/98/95.
                /// </remarks>
                GetDropShadow = 0x1024,
                #endregion

                #region SetDropShadow. Activa o desactiva la característica. Ver GetDropShadow.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetDropShadow"/>.
                /// </summary>
                SetDropShadow = 0x1025,
                #endregion

                /// <summary>
                /// Retrieves a BOOL indicating whether an application can reset the screensaver's timer by calling the SendInput function
                /// to simulate keyboard or mouse input. The pvParam parameter must point to a BOOL variable that receives TRUE
                /// if the simulated input will be blocked, or FALSE otherwise.
                /// </summary>
                GetBlockSendInputResets = 0x1026,
                /// <summary>
                /// Determines whether an application can reset the screensaver's timer by calling the SendInput function to simulate keyboard
                /// or mouse input. The uiParam parameter specifies TRUE if the screensaver will not be deactivated by simulated input,
                /// or FALSE if the screensaver will be deactivated by simulated input.
                /// </summary>
                SetBlockSendInputResets = 0x1027,

                #region GetClearType. Determina si está habilitada la característica.
                /// <summary>
                /// Determina si está habilitada la característica.
                /// ClearType es una tecnología de software que mejora la legibilidad del texto en monitores con pantalla de cristal líquido (LCD).
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si está habilitada;<strong>false</strong> si está deshabilitado.
                /// </summary>
                /// <remarks>
                /// Está característica no está soportada por Windows Server 2003 y Windows XP/2000
                /// </remarks>
                GetClearType = 0x1048,
                #endregion

                #region SetClearType. Activa o desactiva la característica. Ver GetClearType.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="GetClearType"/>.
                /// </summary>
                SetClearType = 0x1049,
                #endregion

                #region GetUiEffects. Determina si todos los efectos de la interfaz de usuario están habilitados o desactivados.
                /// <summary>
                /// Determina si todos los efectos de la interfaz de usuario están habilitados o desactivados.               
                /// El parámetro <strong>pvParam</strong> debe apuntar a una variable de tipo <see cref="T:System.Boolean"/> que recibirá <strong>true</strong> 
                /// si está habilitada;<strong>false</strong> si está deshabilitado.
                /// </summary>
                GetUiEffects = 0x103E,
                #endregion

                #region SetUiEffects. Activa o desactiva la característica. Ver GetUiEffects.
                /// <summary>
                /// Activa o desactiva la característica. Ver <see cref="SetUiEffects"/>.
                /// </summary>
                SetUiEffects = 0x103F,
                #endregion


                /// <summary>
                /// Retrieves the amount of time following user input, in milliseconds, during which the system will not allow applications
                /// to force themselves into the foreground. The pvParam parameter must point to a DWORD variable that receives the time.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetForegroundLockTimeout = 0x2000,
                /// <summary>
                /// Sets the amount of time following user input, in milliseconds, during which the system does not allow applications
                /// to force themselves into the foreground. Set pvParam to the new timeout value.
                /// The calling thread must be able to change the foreground window, otherwise the call fails.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetForegroundLockTimeout = 0x2001,
                /// <summary>
                /// Retrieves the active window tracking delay, in milliseconds. The pvParam parameter must point to a DWORD variable
                /// that receives the time.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetActiveWndTrkTimeout = 0x2002,
                /// <summary>
                /// Sets the active window tracking delay. Set pvParam to the number of milliseconds to delay before activating the window
                /// under the mouse pointer.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetActiveWndTrkTimeout = 0x2003,
                /// <summary>
                /// Retrieves the number of times SetForegroundWindow will flash the taskbar button when rejecting a foreground switch request.
                /// The pvParam parameter must point to a DWORD variable that receives the value.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                GetForegroundFlashCount = 0x2004,
                /// <summary>
                /// Sets the number of times SetForegroundWindow will flash the taskbar button when rejecting a foreground switch request.
                /// Set pvParam to the number of times to flash.
                /// Windows NT, Windows 95:  This value is not supported.
                /// </summary>
                SetForegroundFlashCount = 0x2005,
                /// <summary>
                /// Retrieves the caret width in edit controls, in pixels. The pvParam parameter must point to a DWORD that receives this value.
                /// Windows NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                GetCaretWidth = 0x2006,
                /// <summary>
                /// Sets the caret width in edit controls. Set pvParam to the desired width, in pixels. The default and minimum value is 1.
                /// Windows NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                SetCaretWidth = 0x2007,

                //#if(_WIN32_WINNT >= 0x0501)
                /// <summary>
                /// Retrieves the time delay before the primary mouse button is locked. The pvParam parameter must point to DWORD that receives
                /// the time delay. This is only enabled if SPI_SETMOUSECLICKLOCK is set to TRUE. For more information, see About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                GetMouseClickLockTime = 0x2008,
                /// <summary>
                /// Turns the Mouse ClickLock accessibility feature on or off. This feature temporarily locks down the primary mouse button
                /// when that button is clicked and held down for the time specified by SPI_SETMOUSECLICKLOCKTIME. The uiParam parameter
                /// specifies TRUE for on, or FALSE for off. The default is off. For more information, see Remarks and About Mouse Input on MSDN.
                /// Windows 2000/NT, Windows 98/95:  This value is not supported.
                /// </summary>
                SetMouseClickLockTime = 0x2009,
                /// <summary>
                /// Retrieves the type of font smoothing. The pvParam parameter must point to a UINT that receives the information.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                GetFontSmoothingType = 0x200A,
                /// <summary>
                /// Sets the font smoothing type. The pvParam parameter points to a UINT that contains either FE_FONTSMOOTHINGSTANDARD,
                /// if standard anti-aliasing is used, or FE_FONTSMOOTHINGCLEARTYPE, if ClearType is used. The default is FE_FONTSMOOTHINGSTANDARD.
                /// When using this option, the fWinIni parameter must be set to SPIF_SENDWININICHANGE | SPIF_UPDATEINIFILE; otherwise,
                /// SystemParametersInfo fails.
                /// </summary>
                SetFontSmoothingType = 0x200B,
                /// <summary>
                /// Retrieves a contrast value that is used in ClearType™ smoothing. The pvParam parameter must point to a UINT
                /// that receives the information.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                GetFontSmoothingContrast = 0x200C,
                /// <summary>
                /// Sets the contrast value used in ClearType smoothing. The pvParam parameter points to a UINT that holds the contrast value.
                /// Valid contrast values are from 1000 to 2200. The default value is 1400.
                /// When using this option, the fWinIni parameter must be set to SPIF_SENDWININICHANGE | SPIF_UPDATEINIFILE; otherwise,
                /// SystemParametersInfo fails.
                /// SPI_SETFONTSMOOTHINGTYPE must also be set to FE_FONTSMOOTHINGCLEARTYPE.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                SetFontSmoothingContrast = 0x200D,
                /// <summary>
                /// Retrieves the width, in pixels, of the left and right edges of the focus rectangle drawn with DrawFocusRect.
                /// The pvParam parameter must point to a UINT.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                GetFocusBorderWidth = 0x200E,
                /// <summary>
                /// Sets the height of the left and right edges of the focus rectangle drawn with DrawFocusRect to the value of the pvParam parameter.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                SetFocusBorderWidth = 0x200F,
                /// <summary>
                /// Retrieves the height, in pixels, of the top and bottom edges of the focus rectangle drawn with DrawFocusRect.
                /// The pvParam parameter must point to a UINT.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                GetFocusBorderHeight = 0x2010,
                /// <summary>
                /// Sets the height of the top and bottom edges of the focus rectangle drawn with DrawFocusRect to the value of the pvParam parameter.
                /// Windows 2000/NT, Windows Me/98/95:  This value is not supported.
                /// </summary>
                SetFocusBorderHeight = 0x2011,
                /// <summary>
                /// Not implemented.
                /// </summary>
                GetFontSmoothingOrientation = 0x2012,
                /// <summary>
                /// Not implemented.
                /// </summary>
                SetFontSmoothingOrientation = 0x2013,
            }
            #endregion

            #region [internal] (enum) SPIF: Representa una característica o valor de configuración del sistema a recuperar.
            /// <summary>
            /// Especifica si es necesario actualizar el perfil de usuario, y si es así, indicar que se envie el mensaje <strong>WM_SETTINGCHANGE</strong> a todas las 
            /// ventanas de nivel superior para notificarles el cambio.
            /// Este parámetro puede ser cero si no desea actualizar el perfil de usuario o el mensaje de <strong>WM_SETTINGCHANGE</strong>, o puede ser uno o más de
            ///  los siguientes valores.
            /// </summary>
            [Flags]
            internal enum SPIF
            {
                /// <summary>
                /// No hay acción.
                /// </summary>      
                Zero = 0x00,
                /// <summary>
                ///	Escribe el nuevo valor de parámetro en el perfil de usuario.
                /// </summary>      
                UpdateIniFile = 0x01,
                /// <summary>
                /// Enviar mensaje <strong>WM_SETTINGCHANGE</strong> después de actualizar el perfil de usuario.
                /// </summary>      
                SendChange = 0x02,
                /// <summary>
                /// Igual que a la opción<see cref="SendChange"/>
                /// </summary>
                SendWinIniChange = 0x02
            }
            #endregion

        #endregion

        #region Estructuras
        /// <summary>
        /// ANIMATIONINFO specifies animation effects associated with user actions.
        /// Used with SystemParametersInfo when SPI_GETANIMATION or SPI_SETANIMATION action is specified.
        /// </summary>
        /// <remark>
        /// The uiParam value must be set to (System.UInt32)Marshal.SizeOf(typeof(ANIMATIONINFO)) when using this structure.
        /// </remark>
        [StructLayout(LayoutKind.Sequential)]
        internal struct ANIMATIONINFO
        {
            /// <summary>
            /// Creates an AMINMATIONINFO structure.
            /// </summary>
            /// <param name="iMinAnimate">If non-zero and SPI_SETANIMATION is specified, enables minimize/restore animation.</param>
            public ANIMATIONINFO(int iMinAnimate)
            {
                cbSize = (uint)Marshal.SizeOf(typeof(ANIMATIONINFO));
                this.iMinAnimate = iMinAnimate;
            }

            /// <summary>
            /// Always must be set to (System.UInt32)Marshal.SizeOf(typeof(ANIMATIONINFO)).
            /// </summary>
            public uint cbSize;

            /// <summary>
            /// If non-zero, minimize/restore animation is enabled, otherwise disabled.
            /// </summary>
            public int iMinAnimate;
        }
        #endregion

        #region P/Invoke

        #region [public] {static} (int) GetSystemMetrics(SystemMetricIndex): Recupera un valor de configuración ó una característica del sistema.
        /// <summary>
        /// Recupera un valor de configuración ó una característica del sistema.
        /// Todas las valores de medida obtenidos por <strong>GetSystemMetrics</strong> están en píxeles.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724385%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, ExactSpelling = true)]
        public static extern int GetSystemMetrics(SystemMetricIndex smIndex);
        #endregion

        #region [public] {static} (bool) SystemParametersInfo(SPI, UInt32, IntPtr, SPIF): Recupera o establece el valor de uno de los parámetros del sistema.
        /// <summary>
        /// Recupera o establece el valor de uno de los parámetros del sistema.
        /// Esta función también puede actualizar el perfil de usuario al establecer un parámetro.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724947%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(SPI uiAction, UInt32 uiParam, IntPtr pvParam, SPIF fWinIni);
        #endregion

        #region [public] {static} (bool) SystemParametersInfo(SPI, UInt32, ref Boolean, SPIF): Recupera o establece el valor de uno de los parámetros del sistema.
        /// <summary>
        /// Recupera o establece el valor de uno de los parámetros del sistema.
        /// Esta función también puede actualizar el perfil de usuario al establecer un parámetro.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724947%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(SPI uiAction, UInt32 uiParam, [MarshalAs(UnmanagedType.Bool)] ref Boolean pvParam, SPIF fWinIni);
        #endregion

        #region [public] {static} (bool) SystemParametersInfo(SPI, UInt32, Boolean, SPIF): Recupera o establece el valor de uno de los parámetros del sistema.
        /// <summary>
        /// Recupera o establece el valor de uno de los parámetros del sistema.
        /// Esta función también puede actualizar el perfil de usuario al establecer un parámetro.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724947%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(SPI uiAction, UInt32 uiParam, [MarshalAs(UnmanagedType.Bool)] Boolean pvParam, SPIF fWinIni);
        #endregion

        #region [public] {static} (bool) SystemParametersInfo(SPI, UInt32, String, SPIF): Recupera o establece el valor de uno de los parámetros del sistema.
        /// <summary>
        /// Recupera o establece el valor de uno de los parámetros del sistema.
        /// Esta función también puede actualizar el perfil de usuario al establecer un parámetro.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724947%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(SPI uiAction, UInt32 uiParam, String pvParam, SPIF fWinIni);
        #endregion

        #region [public] {static} (bool) SystemParametersInfo(SPI, UInt32, ref ANIMATIONINFO, SPIF): Recupera o establece el valor de uno de los parámetros del sistema.
        /// <summary>
        /// Recupera o establece el valor de uno de los parámetros del sistema.
        /// Esta función también puede actualizar el perfil de usuario al establecer un parámetro.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ms724947%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.User32, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfo(SPI uiAction, UInt32 uiParam, ref ANIMATIONINFO pvParam, SPIF fWinIni);
        #endregion

        #endregion
    }
}
