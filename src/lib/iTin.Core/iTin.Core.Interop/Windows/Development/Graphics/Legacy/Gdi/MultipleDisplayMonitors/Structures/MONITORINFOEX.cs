
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    using System;
    using System.Runtime.InteropServices;

    using Rectangles;

    /// <summary>
    /// The <strongs>MONITORINFOEX</strongs> structure contains information about a monitor.
    /// The <strongs>MONITORINFOEX</strongs> structure is a superset of the <see cref="MONITORINFO"/> structure.
    /// For more information, see http://msdn.microsoft.com/es-es/library/dd145066.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct MONITORINFOEX : IEquatable<MONITORINFOEX>
    {
        #region public constants
        public const uint MONITORINFOF_PRIMARY = 0x00000001;
        #endregion

        #region private constants
        private const int CCHDEVICENAME = 0x20;
        #endregion

        #region public members
        /// <summary>
        /// Specifies the size, in bytes, of the <strong>MONITORINFOEX</strong> structure.
        /// Must be initialized before calling a <strong>Api</strong> function.
        /// </summary>
        public int Size;

        /// <summary>
        /// A structure <see cref="RECT"/> that specifies the rectangle of the total area of the monitor.
        /// </summary>
        public RECT Monitor;

        /// <summary>
        /// A structure <see cref="RECT"/> that specifies the rectangle of the working area of the useful monitor that can be used by applications, expressed in virtual screen coordinates.
        /// Windows uses this rectangle to maximize an application on the monitor.
        /// Toolbars, status bars, etc. are excluded.
        /// </summary>
        public RECT WorkArea;

        /// <summary>
        /// Attributes of the monitor.
        /// </summary>
        public uint Flags;

        /// <summary>
        /// A string that specifies the name of the monitor.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        public string DeviceName;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(MONITORINFOEX): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other"> Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong>true</strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(MONITORINFOEX other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(MONITORINFOEX, MONITORINFOEX): Implement the equality operator (==)
        /// <summary>
        /// Implement the equality operator (==).
        /// </summary>
        /// <param name="operator1">Operating 1.</param>
        /// <param name="operator2">Operating 2.</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>operator1</c> is equal to <c>operator2</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator ==(MONITORINFOEX operator1, MONITORINFOEX operator2) => operator1.Equals(operator2);
        #endregion

        #region [public] {static} (bool) operator !=(MONITORINFOEX, MONITORINFOEX): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name = "operator1">Operating 1.</param>
        /// <param name = "operator2">Operating 2.</param>
        /// <returns>
        /// Returns <strong>true</strong> if <c>operator1</c> is not equal to <c>operator2</c>; <strong>false</strong> otherwise.
        /// </returns>
        public static bool operator !=(MONITORINFOEX operator1, MONITORINFOEX operator2) => !operator1.Equals(operator2);
        #endregion

        #endregion

        #region public static properties
        public static readonly MONITORINFOEX Empty = new MONITORINFOEX { Size = Marshal.SizeOf(typeof(MONITORINFOEX)) };
        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code of this structure
        /// <summary>
        /// Returns a value that represents the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object): Returns a value that indicates whether this structure is the same as another
        /// <summary>
        /// Returns a value that indicates whether this structure is the same as another.
        /// </summary>
        /// <param name="obj"> Structure to compare.</param>
        /// <returns>
        /// Result of the equality comparison.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is MONITORINFOEX))
            {
                return false;
            }

            var other = (MONITORINFOEX)obj;

            return
                other.Monitor == Monitor &&
                other.WorkArea == WorkArea &&
               other.Flags == Flags &&
               other.DeviceName == DeviceName;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current <see cref="MONITORINFOEX"/> structure.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="MONITORINFOEX"/> structure.
        /// </returns>
        public override string ToString() => $"DeviceName = {DeviceName}";
        #endregion

        #endregion
    }
}
