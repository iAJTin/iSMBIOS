
namespace iTin.Core.Hardware.Interop.ComponentModel
{
    using System;
    using System.Diagnostics;
    using System.Drawing;

    using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext;
    using iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors;

    /// <summary>
    /// The data structure <see cref="MonitorDeviceInfoNative"/> contains the basic information of a system monitor.
    /// </summary>
    internal struct MonitorDeviceInfoNative : IEquatable<MonitorDeviceInfoNative>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly MONITORINFOEX _monitorInfo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DISPLAY_DEVICE _displayInfo;
        #endregion

        #region constructor/s

        #region [public] MonitorDeviceInfoNative(MONITORINFOEX, DISPLAY_DEVICE): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorDeviceInfoNative"/> structure.
        /// </summary>
        /// <param name="displayInfo">Monitor information.</param>
        /// <param name="monitorInfo">Screen information.</param>
        public MonitorDeviceInfoNative(MONITORINFOEX monitorInfo, DISPLAY_DEVICE displayInfo)
        {
            _monitorInfo = monitorInfo;
            _displayInfo = displayInfo;
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(MonitorDeviceInfoNative): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other">Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong> true </strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(MonitorDeviceInfoNative other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(MonitorDeviceInfoNative, MonitorDeviceInfoNative): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator ==(MonitorDeviceInfoNative left, MonitorDeviceInfoNative right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(MonitorDeviceInfoNative, MonitorDeviceInfoNative): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator !=(MonitorDeviceInfoNative left, MonitorDeviceInfoNative right) => !left.Equals(right);
        #endregion

        #endregion

        #region public properties

        #region [public] (string) DeviceId: Gets a value that represents the device identifier
        /// <summary>
        /// Gets a value that represents the device identifier.
        /// </summary>
        /// <value>
        /// String representing the device identifier.
        /// </value>
        public string DeviceId => _displayInfo.DeviceID;
        #endregion

        #region [public] (string) DisplayName: Get a value that represents the name of the screen that contains this monitor
        /// <summary>
        /// Get a value that represents the name of the screen that contains this monitor.
        /// </summary>
        /// <value>
        /// String representing the name of the screen that contains this monitor.
        /// </value>
        public string DisplayName => _monitorInfo.DeviceName;
        #endregion

        #region [public] (bool) IsAttached: Gets a value that indicates whether the monitor is part of the desktop
        /// <summary>
        /// Gets a value that indicates whether the monitor is part of the desktop.
        /// </summary>
        /// <value>
        /// Returns <strong>true</strong> if it is part of the desktop; <strong>false</strong> otherwise.
        /// </value>
        public bool IsAttached
        {
            get
            {
                var flags = _displayInfo.State;
                return (flags & DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop) == DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop;
            }
        }
        #endregion

        #region [public] (bool) IsPrimaryMonitor: Gets a value that indicates whether the monitor is the main monitor
        /// <summary>
        /// Gets a value that indicates whether the monitor is the main monitor.
        /// </summary>
        /// <value>
        /// Returns <strong>true</strong> if it is the main monitor; <strong>false</strong> otherwise.
        /// </value>
        public bool IsPrimaryMonitor
        {
            get
            {
                var flags = _monitorInfo.Flags;
                return (flags & MONITORINFOEX.MONITORINFOF_PRIMARY) == MONITORINFOEX.MONITORINFOF_PRIMARY;
            }
        }
        #endregion

        #region [public] (Rectangle) MonitorArea: Gets a value that represents the total area of the monitor
        /// <summary>
        /// Gets a value that represents the total area of the monitor.
        /// </summary>
        /// <value>
        /// Rectangle of the monitor screen, expressed in virtual screen coordinates.
        /// </value>
        /// <remarks>
        /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
        /// </remarks>
        public Rectangle MonitorArea => _monitorInfo.Monitor;
        #endregion

        #region [public] (string) MonitorDriverRegistryPath: Gets a value that represents the registry key that contains the information on this monitor
        /// <summary>
        /// Gets a value that represents the registry key that contains the information on this monitor.
        /// </summary>
        /// <value>
        /// String representing the registry key that contains the information on this monitor.
        /// </value>
        public string MonitorDriverRegistryPath
        {
            get
            {
                var i = _displayInfo.DeviceKey.IndexOf("\\System", StringComparison.OrdinalIgnoreCase);
                var deviceRegistryKeyBranch = _displayInfo.DeviceKey.Substring((i + 1), _displayInfo.DeviceKey.Length - (i + 1));

                return deviceRegistryKeyBranch;
            }
        }
        #endregion

        #region [public] (string) MonitorName: Gets a value that represents the name of the monitor
        /// <summary>
        /// Gets a value that represents the name of the monitor.
        /// </summary>
        /// <value>
        /// String representing the name of the monitor.
        /// </value>
        public string MonitorName => _displayInfo.DeviceString;
        #endregion

        #region [public] (Rectangle) MonitorWorkingArea: Gets a value that represents the usable surface of the monitor
        /// <summary>
        /// Gets a value that represents the usable surface of the monitor.
        /// </summary>
        /// <value>
        /// Usable monitor rectangle, taskbar and sidebars are excluded.
        /// </value>
        /// <remarks>
        /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
        /// </remarks>
        public Rectangle MonitorWorkingArea => _monitorInfo.WorkArea;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code of this structure
        /// <summary>
        /// Returns a value that represents the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code of this structure.
        /// </returns>
        public override int GetHashCode() => _displayInfo.GetHashCode() ^ _monitorInfo.GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object obj): Returns a value that indicates whether this structure is the same as another
        /// <summary>
        /// Returns a value that indicates whether this structure is the same as another.
        /// </summary>
        /// <param name="obj">Structure to compare.</param>
        /// <returns>
        /// Result of the equality comparison.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is MonitorDeviceInfoNative))
            {
                return false;
            }

            var other = (MonitorDeviceInfoNative)obj;

            return 
                other.DisplayName.Equals(DisplayName) &&
                other.MonitorName.Equals(MonitorName) &&
                other.IsAttached.Equals(IsAttached) &&
                other.IsPrimaryMonitor.Equals(IsPrimaryMonitor);
        }
        #endregion

        #region [public] {override} (string) ToString(): Devuelve una cadena que representa a la estructura actual.
        /// <summary>
        /// Returns a string that represents the current <see cref="MonitorDeviceInfoNative"/> structure.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="MonitorDeviceInfoNative"/> structure.
        /// </returns>
        public override string ToString() => $"{MonitorName}";
        #endregion

        #endregion
    }
}
