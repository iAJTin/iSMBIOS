
namespace iTin.Core.Hardware.DeviceInfo
{
    using System.Diagnostics;

    using Configuration = Core.Interop.Windows.Development.UI.WindowsAndMessages.Configuration;

    /// <summary>
    /// The <see cref="DesktopDeviceEffects"/> data structure contains information about the desktop effects.
    /// </summary>
    public static class DesktopDeviceEffects
    {
        #region private static members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _comboboxAnimation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _dropShadowEffect;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _flatMenuEffect;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _fontSmoothing;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _clearType;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _dragFullWindows;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _hotTracking;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _iconTitleWrap;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _listBoxSmoothScrolling;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _menuAnimation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _menuFade;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _mouseCursorShadow;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _selectionFade;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _showSounds;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _tooltipAnimation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static bool _tooltipFade;
        #endregion

        #region public static properties

        #region [public] {static} (bool) ComboBoxAnimation: Gets or sets a value that indicates whether combo boxes have an effect when deployed
        /// <summary>
        /// Gets or sets a value that indicates whether combo boxes have an effect when deployed.
        /// This feature is not supported by Windows NT, Windows 95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool ComboBoxAnimation
        {
            get
            {
                _comboboxAnimation = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetComboboxAnimation, 0, ref _comboboxAnimation, Configuration.NativeMethods.SPIF.Zero);
                return _comboboxAnimation;
            }
            set
            {
                if (value != _comboboxAnimation)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetComboboxAnimation, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) DropShadowEffect: Gets or sets a value that indicates whether shadows are displayed under windows
        /// <summary>
        /// Gets or sets a value that indicates whether shadows are displayed under windows.
        /// This feature is not supported by Windows 2000 / NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool DropShadowEffect
        {
            get
            {
                _dropShadowEffect = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetDropShadow, 0, ref _dropShadowEffect, Configuration.NativeMethods.SPIF.Zero);
                return _dropShadowEffect;
            }
            set
            {
                if (value != _dropShadowEffect)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetDropShadow, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) FlatMenuEffect:  Gets or sets a value that indicates whether menus are dimmed.
        /// <summary>
        /// Gets or sets a value that indicates whether menus are dimmed.
        /// This feature is not supported by Windows 2000.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool FlatMenuEffect
        {
            get
            {
                _flatMenuEffect = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetFlatMenu, 0, ref _flatMenuEffect, Configuration.NativeMethods.SPIF.Zero);
                return _flatMenuEffect;
            }
            set
            {
                if (value != _flatMenuEffect)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetFlatMenu, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) FontSmoothing: Gets or sets a value that indicates whether the font smoothing function is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether the font smoothing function is enabled.
        /// This function uses the smoothing of fonts so that the curves of the font are drawn softer at different gray levels.
        /// For Windows 95, this feature is only supported if you have Windows Plus!
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool FontSmoothing
        {
            get
            {
                _fontSmoothing = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetFontSmoothing, 0, ref _fontSmoothing, Configuration.NativeMethods.SPIF.Zero);
                return _fontSmoothing;
            }
            set
            {
                if (value != _fontSmoothing)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetFontSmoothing, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) ClearType: Gets or sets a value that indicates whether the feature is activated
        /// <summary>
        /// Gets or sets a value that indicates whether the feature is activated.
        /// <strong>ClearType</strong> is a software technology that improves text readability on monitors with a liquid crystal display (LCD).
        /// This feature is not supported by Windows Server 2003 and Windows XP / 2000.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool ClearType
        {
            get
            {
                _clearType = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetClearType, 0, ref _clearType, Configuration.NativeMethods.SPIF.Zero);
                return _clearType;
            }
            set
            {
                if (value != _clearType)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetClearType, 0, _clearType, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) DragFullWindows: Get or set a value that indicates whether full window dragging is enabled (view content when dragging)
        /// <summary>
        /// Get or set a value that indicates whether full window dragging is enabled (view content when dragging).
        /// For Windows 95, this feature is only supported if you have Windows Plus!
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool DragFullWindows
        {
            get
            {
                _dragFullWindows = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetDragFullWindows, 0, ref _dragFullWindows, Configuration.NativeMethods.SPIF.Zero);
                return _dragFullWindows;
            }
            set
            {
                if (value != _dragFullWindows)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetDragFullWindows, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) HotTracking: Gets or sets a value that indicates whether active tracking of user interface elements such as menu bars, menu names is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether active tracking of user interface elements such as menu bars, menu names is enabled.
        /// Active tracking means that when the cursor moves over an item, it is drawn with relief but not selected.
        /// This feature is not supported by Windows NT, Windows 95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool HotTracking
        {
            get
            {
                _hotTracking = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetHotTracking, 0, ref _hotTracking, Configuration.NativeMethods.SPIF.Zero);
                return _hotTracking;
            }
            set
            {
                if (value != _hotTracking)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetHotTracking, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) IconTitleWrap: Gets or sets a value that indicates whether the title icon setting is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether the title icon setting is enabled.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool IconTitleWrap
        {
            get
            {
                _iconTitleWrap = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetIconTitleWrap, 0, ref _iconTitleWrap, Configuration.NativeMethods.SPIF.Zero);
                return _iconTitleWrap;
            }
            set
            {
                if (value != _iconTitleWrap)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetIconTitleWrap, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) ListBoxSmoothScrolling: Gets or sets a value that indicates whether the smooth scrolling effect is enabled for list boxes
        /// <summary>
        /// Gets or sets a value that indicates whether the smooth scrolling effect is enabled for list boxes.
        /// This feature is not supported by Windows 95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool ListBoxSmoothScrolling
        {
            get
            {
                _listBoxSmoothScrolling = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetListBoxSmoothScrolling, 0, ref _listBoxSmoothScrolling, Configuration.NativeMethods.SPIF.Zero);
                return _listBoxSmoothScrolling;
            }
            set
            {
                if (value != _listBoxSmoothScrolling)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetListBoxSmoothScrolling, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) MenuAnimation: Gets or sets a value that indicates whether the menu animation feature is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether the menu animation feature is enabled.
        /// If the <see cref="MenuFade"/> feature is activated, it indicates whether the menus use dimming or animation.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool MenuAnimation
        {
            get
            {
                _menuAnimation = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetMenuAnimation, 0, ref _menuAnimation, Configuration.NativeMethods.SPIF.Zero);
                return _menuAnimation;
            }
            set
            {
                if (value != _menuAnimation)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetMenuAnimation, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) MenuFade: Gets or sets a value that indicates whether menu closure animation is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether menu closure animation is enabled.
        /// This feature is not supported by Windows NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool MenuFade
        {
            get
            {
                _menuFade = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetMenuFade, 0, ref _menuFade, Configuration.NativeMethods.SPIF.Zero);
                return _menuFade;
            }
            set
            {
                if (value != _menuFade)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetMenuFade, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) MouseCursorShadow: Gets or sets a value that indicates whether shadow is displayed under the mouse cursor
        /// <summary>
        /// Gets or sets a value that indicates whether shadow is displayed under the mouse cursor.
        /// The effect is only noticeable on systems that have at least 256 colors of color depth.
        /// This feature is not supported by Windows NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool MouseCursorShadow
        {
            get
            {
                _mouseCursorShadow = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetCursorShadow, 0, ref _mouseCursorShadow, Configuration.NativeMethods.SPIF.Zero);
                return _mouseCursorShadow;
            }
            set
            {
                if (value != _mouseCursorShadow)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetCursorShadow, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) SelectionFade: Gets or sets a value that indicates whether the fading effect of the selection is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether the fading effect of the selection is enabled.
        /// The fade effect of the selection causes the menu item selected by the user to remain on the screen briefly while slowly disappearing.
        /// This feature is not supported by Windows NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool SelectionFade
        {
            get
            {
                _selectionFade = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetSelectionFade, 0, ref _selectionFade, Configuration.NativeMethods.SPIF.Zero);
                return _selectionFade;
            }
            set
            {
                if (value != _selectionFade)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetSelectionFade, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) ShowSounds: Gets or sets a value that indicates whether the sound option of the accessibility feature is enabled, events are audibly displayed
        /// <summary>
        /// Gets or sets a value that indicates whether the sound option of the accessibility feature is enabled, events are audibly displayed.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool ShowSounds
        {
            get
            {
                _showSounds = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetShowSounds, 0, ref _showSounds, Configuration.NativeMethods.SPIF.Zero);
                return _showSounds;
            }
            set
            {
                if (value != _showSounds)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetShowSounds, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) TooltipAnimation: Gets or sets a value that indicates whether the animation of tool help balloons is enabled
        /// <summary>
        /// Gets or sets a value that indicates whether the animation of tool help balloons is enabled.
        /// This feature is not supported by Windows NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool TooltipAnimation
        {
            get
            {
                _tooltipAnimation = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetTooltipAnimation, 0, ref _tooltipAnimation, Configuration.NativeMethods.SPIF.Zero);
                return _tooltipAnimation;
            }
            set
            {
                if (value != _tooltipAnimation)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetTooltipAnimation, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #region [public] {static} (bool) TooltipFade: Gets or sets a value that indicates whether the TooltipAnimation, TooltipFade feature is enabled if help balloons use a transition effect or not
        /// <summary>
        /// Gets or sets a value that indicates whether the <see cref="TooltipAnimation"/>, <strong>TooltipFade</strong> feature is enabled if help balloons use a transition effect or not.
        /// This feature is not supported by Windows NT, Windows Me / 98/95.
        /// </summary>
        /// <value>
        /// <strong>true</strong> to indicate that this feature is enabled; <strong>false</strong> otherwise.
        /// </value>
        public static bool TooltipFade
        {
            get
            {
                _tooltipFade = false;
                Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.GetTooltipFade, 0, ref _tooltipFade, Configuration.NativeMethods.SPIF.Zero);
                return _tooltipFade;
            }
            set
            {
                if (value != _tooltipAnimation)
                {
                    Configuration.NativeMethods.SystemParametersInfo(Configuration.NativeMethods.SPI.SetTooltipFade, 0, value, Configuration.NativeMethods.SPIF.Zero);
                }
            }
        }
        #endregion

        #endregion
    }
}
