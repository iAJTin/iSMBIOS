
namespace iTin.Core.Hardware.DeviceInfo
{
    using System.Diagnostics;
    using System.Linq;
    using System.Drawing;
    using System;

    using Interop.ComponentModel;

    /// <summary>
    /// The <see cref="MonitorDeviceInfo"/> data structure contains information about a system monitor.
    /// </summary>
    public struct MonitorDeviceInfo : IEquatable<MonitorDeviceInfo>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly MonitorDeviceInfoNative _deviceInfo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly MonitorDeviceEdidInfoNative _edidDeviceInfo;
        #endregion

        #region constructor/s

        #region [public] MonitorDeviceInfo(MonitorDeviceInfoNative, MonitorDeviceEdidInfoNative): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorDeviceInfo"/> structure.
        /// </summary>
        /// <param name="deviceInfo">Monitor information.</param>
        /// <param name="edidDeviceInfo">Screen information.</param>
        internal MonitorDeviceInfo(MonitorDeviceInfoNative deviceInfo, MonitorDeviceEdidInfoNative edidDeviceInfo)
        {
            _deviceInfo = deviceInfo;
            _edidDeviceInfo = edidDeviceInfo;
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(MonitorDeviceInfo): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other">Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong> true </strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(MonitorDeviceInfo other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(MonitorDeviceInfo, MonitorDeviceInfo): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator ==(MonitorDeviceInfo left, MonitorDeviceInfo right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(MonitorDeviceInfo, MonitorDeviceInfo): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator !=(MonitorDeviceInfo left, MonitorDeviceInfo right) => !left.Equals(right);
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
        public string DeviceId => _deviceInfo.DeviceId;
        #endregion

        #region [public] (string) DisplayName: Get a value that represents the name of the screen that contains this monitor
        /// <summary>
        /// Get a value that represents the name of the screen that contains this monitor.
        /// </summary>
        /// <value>
        /// String representing the name of the screen that contains this monitor.
        /// </value>
        public string DisplayName => _deviceInfo.DisplayName;
        #endregion

        #region [public] (byte[]) Edid: Gets a value that contains the raw EDID information of this monitor
        /// <summary>
        /// Gets a value that contains the raw <c>EDID</c> information of this monitor.
        /// </summary>
        /// <value>
        /// Raw <c>EDID</c> information.
        /// </value>
        public byte[] Edid => _edidDeviceInfo.RawEdid;
        #endregion

        #region [public] (bool) IsAttached: Gets a value that indicates whether the monitor is part of the desktop
        /// <summary>
        /// Gets a value that indicates whether the monitor is part of the desktop.
        /// </summary>
        /// <value>
        /// Returns <strong>true</strong> if it is part of the desktop; <strong>false</strong> otherwise.
        /// </value>
        public bool IsAttached => _deviceInfo.IsAttached;
        #endregion

        #region [public] (bool) IsPrimaryMonitor: Gets a value that indicates whether the monitor is the main monitor
        /// <summary>
        /// Gets a value that indicates whether the monitor is the main monitor.
        /// </summary>
        /// <value>
        /// Returns <strong>true</strong> if it is the main monitor; <strong>false</strong> otherwise.
        /// </value>
        public bool IsPrimaryMonitor => _deviceInfo.IsPrimaryMonitor;
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
        public Rectangle MonitorArea => _deviceInfo.MonitorArea;
        #endregion

        #region [public] (string) MonitorDriverRegistryPath: Gets a value that represents the registry key that contains the information on this monitor
        /// <summary>
        /// Gets a value that represents the registry key that contains the information on this monitor.
        /// </summary>
        /// <value>
        /// String representing the registry key that contains the information on this monitor.
        /// </value>
        public string MonitorDriverRegistryPath => _deviceInfo.MonitorDriverRegistryPath;
        #endregion

        #region [public] (string) MonitorName: Gets a value that represents the name of the monitor
        /// <summary>
        /// Gets a value that represents the name of the monitor.
        /// </summary>
        /// <value>
        /// String representing the name of the monitor.
        /// </value>
        public string MonitorName => _deviceInfo.MonitorName;
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
        public Rectangle MonitorWorkingArea => _deviceInfo.MonitorWorkingArea;
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
        public override int GetHashCode() => _deviceInfo.GetHashCode() ^ _edidDeviceInfo.GetHashCode() ^ Edid.GetHashCode();
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

            if (!(obj is MonitorDeviceInfo))
            {
                return false;
            }

            var other = (MonitorDeviceInfo)obj;

            return 
                other.DisplayName.Equals(DisplayName) &&
                other.MonitorName.Equals(MonitorName) &&
                other.IsAttached.Equals(IsAttached) &&
                other.IsPrimaryMonitor.Equals(IsPrimaryMonitor) &&
                other.Edid.SequenceEqual(Edid);
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current <see cref="MonitorDeviceInfo"/> structure.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="MonitorDeviceInfo"/> structure.
        /// </returns>
        public override string ToString() => $"{MonitorName}";
        #endregion

        #endregion
    }
}
