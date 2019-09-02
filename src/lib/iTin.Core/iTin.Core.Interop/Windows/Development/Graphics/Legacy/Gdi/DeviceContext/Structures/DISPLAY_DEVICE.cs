
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The <strong>DISPLAY_DEVICE</strong> structure receives the information from the display device specified by the parameter <c> iDevNum </c> of function <see cref="NativeMethods.EnumDisplayDevices"/>.
    /// For more information, please see http://msdn.microsoft.com/es-es/library/dd183569.aspx.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICE : IEquatable<DISPLAY_DEVICE>
    {
        #region public constants
        /// <summary>
        /// Indicates that the DeviceId field will contain the registry key of this monitor.
        /// </summary>
        public const uint EDD_GET_DEVICE_INTERFACE_NAME = 0x01;
        #endregion

        #region public enumerations

        #region [public] (enum) KnownDisplayDeviceStates: Enumeration of status attributes of a DISPLAY_DEVICE structure
        /// <summary>
        /// Enumeration of status attributes of a <see cref="DISPLAY_DEVICE"/> structure. For more information, please see http://msdn.microsoft.com/es-es/library/dd183569.aspx.
        /// </summary>
        [Flags]
        public enum KnownDisplayDeviceStates
        {
            /// <summary>
            /// Indicates that the device shows the desktop.
            /// </summary>
            AttachedToDesktop = 0x00000001,

            /// <summary>
            /// 
            /// </summary>
            MultiDriver = 0x00000002,

            /// <summary>
            /// Indicates that it is the main desktop.
            /// For a system with a video adapter, it is always set.
            /// For a system with several video cards, only one can have this flag active.
            /// </summary>
            PrimaryDevice = 0x00000004,

            /// <summary>
            /// It represents a pseudo device to reflect the drawing application for remote interaction or for other purposes.
            /// A pseudo invisible monitor is associated with this device. For example, NetMeeting uses it.
            /// </summary>
            MirroringDriver = 0x00000008,

            /// <summary>
            /// The device is compatible with VGA.
            /// </summary>
            VgaCompatible = 0x00000010,

            /// <summary>
            /// The device is removable; It cannot be the main screen.
            /// </summary>
            Removable = 0x00000020,

            /// <summary>
            /// 
            /// </summary>
            UnSafeModesOn = 0x00080000,

            /// <summary>
            /// 
            /// </summary>
            TsCompatible = 0x00200000,

            /// <summary>
            /// 
            /// </summary>
            Disconnect = 0x02000000,

            /// <summary>
            /// 
            /// </summary>
            Remote = 0x04000000,

            /// <summary>
            /// The device has more video modes.
            /// </summary>
            ModesPruned = 0x08000000,
        }
        #endregion

        #endregion

        #region public members
        ///<summary>
        /// Specify the size, in bytes, of the <strong>DISPLAY_DEVICE</strong> structure.
        /// Must be initialized before calling a <strong>Api</strong> function.
        ///</summary>
        [MarshalAs(UnmanagedType.U4)]
        public int cb;

        ///<summary>
        /// A string that identifies the device name.
        /// This is the adapter device or the monitor device.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        ///<summary>
        /// A string that contains the device context.
        /// This is both a description of the video adapter or the screen monitor.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        ///<summary>
        /// Status indicators.
        ///</summary>
        [MarshalAs(UnmanagedType.U4)]
        public KnownDisplayDeviceStates State;

        ///<summary>
        /// Device identifier.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        ///<summary>
        /// A string containing the windows registry path to the device information.
        ///</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(DISPLAY_DEVICE): Indicates whether the current object is the same as another object of the same type
        /// <summary>
        /// Indicates whether the current object is the same as another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared with this object.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(DISPLAY_DEVICE other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(DISPLAY_DEVICE, DISPLAY_DEVICE): Implement the equality operator (==)
        /// <summary>
        /// Implement the equality operator (==).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(DISPLAY_DEVICE left, DISPLAY_DEVICE right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(DISPLAY_DEVICE, DISPLAY_DEVICE): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(DISPLAY_DEVICE left, DISPLAY_DEVICE right) => !left.Equals(right);
        #endregion

        #endregion

        #region public static methods
        /// <summary>
        /// New empty structure.
        /// </summary>
        public static readonly DISPLAY_DEVICE Empty = new DISPLAY_DEVICE { cb = Marshal.SizeOf(typeof(DISPLAY_DEVICE)) };
        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns the hash code of the structure
        /// <summary>
        /// Returns the hash code of the structure.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => DeviceName.GetHashCode() ^ (int)State;
        #endregion

        #region [public] {override} (bool) Equals(object obj): Returns a value that indicates whether this object is equal to another
        /// <summary>
        /// Returns a value that indicates whether this object is equal to another.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>
        /// Equality result.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is DISPLAY_DEVICE))
            {
                return false;
            }

            var other = (DISPLAY_DEVICE)obj;

            return 
                other.DeviceName == DeviceName && 
                other.State == State;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// Returns a string that represents the current object.
        /// </returns>
        public override string ToString() => $"DeviceName = {DeviceName}";
        #endregion

        #endregion
    }
}
