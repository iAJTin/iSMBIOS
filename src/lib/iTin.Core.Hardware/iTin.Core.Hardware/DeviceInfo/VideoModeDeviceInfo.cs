
namespace iTin.Core.Hardware.DeviceInfo
{
    using System;
    using System.Diagnostics;
    using System.Drawing;

    using Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint;

    /// <summary>
    /// La estructura de datos <strong>VideoModeInfo</strong> contiene información abaout a video mode.
    /// </summary>
    public struct VideoModeDeviceInfo : IEquatable<VideoModeDeviceInfo>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DEVMODE _modeInfo;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _current;
        #endregion

        #region constructor/s

        #region [public] VideoModeDeviceInfo(DEVMODE): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModeDeviceInfo"/> structure.
        /// </summary>
        /// <param name="modeInfo">Native video mode information.</param>
        public VideoModeDeviceInfo(DEVMODE modeInfo)
        {
            _current = false;
            _modeInfo = modeInfo;
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(VideoModeDeviceInfo): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other">Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong> true </strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(VideoModeDeviceInfo other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(VideoModeDeviceInfo, VideoModeDeviceInfo): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator ==(VideoModeDeviceInfo left, VideoModeDeviceInfo right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(VideoModeDeviceInfo, VideoModeDeviceInfo): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator !=(VideoModeDeviceInfo left, VideoModeDeviceInfo right) => !left.Equals(right);
        #endregion

        #endregion

        #region public properties

        #region [public] (int) BitsPerPixel: Gets the number of bits used to display each pixel
        /// <summary>
        /// Gets the number of bits used to display each pixel.
        /// </summary>
        /// <value>
        /// Number of bits used to display each pixel.
        /// </value>
        public int BitsPerPixel => _modeInfo.dmBitsPerPel;
        #endregion

        #region [public] (int) Frequency: Gets a value that represents how often the video driver updates the monitor image
        /// <summary>
        /// Gets a value that represents how often the video driver updates the monitor image.
        /// </summary>
        /// <value>
        /// Frequency with which the video controller updates the monitor image.
        /// </value>
        public int Frequency => _modeInfo.dmDisplayFrequency;
        #endregion

        #region [public] (bool) IsCurrent: Gets a value that indicates whether this video mode is the current one
        /// <summary>
        /// Gets a value that indicates whether this video mode is the current one.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if it's the current video mode; <strong>false</strong> otherwise.
        /// </value>
        public bool IsCurrent => _current;
        #endregion

        #region [public] (Point) Location: Gets a value that represents the coordinate of the first pixel of this video mode
        /// <summary>
        /// Gets a value that represents the coordinate of the first pixel of this video mode.
        /// </summary>
        /// <value>
        /// Coordinate of the first pixel of this video mode.
        /// </value>
        public Point Location => new Point(_modeInfo.dmPosition.X, _modeInfo.dmPosition.Y);
        #endregion

        #region [public] (Size) Size: Gets a value that represents the size in pixels of the video mode
        /// <summary>
        /// Gets a value that represents the size in pixels of the video mode.
        /// </summary>
        /// <value>
        /// Value representing the size in pixels of the video mode.
        /// </value>
        public Size Size => new Size(_modeInfo.dmPelsWidth, _modeInfo.dmPelsHeight);
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
        public override int GetHashCode() => _modeInfo.GetHashCode();
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

            if (!(obj is VideoModeDeviceInfo))
            {
                return false;
            }

            var other = (VideoModeDeviceInfo)obj;

            return
                other.Size == Size &&
                other.BitsPerPixel == BitsPerPixel &&
                other.Frequency == Frequency;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current <see cref="VideoModeDeviceInfo"/> structure.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="VideoModeDeviceInfo"/> structure.
        /// </returns>
        public override string ToString() => _modeInfo.ToString();
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetCurrent(bool): Sets this instance as the current one
        /// <summary>
        /// Sets this instance as the current one
        /// </summary>
        /// <param name="current">Indicates if is current.</param>
        internal void SetCurrent(bool current)
        {
            _current = current;
        }
        #endregion

        #endregion
    }
}
