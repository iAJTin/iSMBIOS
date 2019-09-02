
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Metafiles
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The <b>POINTL</b> structure contains the coordinates of a point.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct POINTL : IEquatable<POINTL>
    {
        #region public members
        /// <summary>
        /// X coordinate of the point.
        /// </summary>
        public int X;

        /// <summary>
        /// Y coordinate of the point.
        /// </summary>
        public int Y;
        #endregion

        #region constructor/s

        #region [public] POINTL(int, int): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="POINTL"/> structure.
        /// </summary>
        /// <param name="x">X coordinate of the point.</param>
        /// <param name="y">Y coordinate of the point.</param>
        public POINTL(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(POINTL): Indicates whether the current object is the same as another object of the same type
        /// <summary>
        /// Indicates whether the current object is the same as another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared with this object.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(POINTL other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region Implicit

        #region [public] {static} (implicit operator) Point(POINTL): Make an implicit conversion from type POINTL to type Point
        /// <summary>
        /// Make an implicit conversion from type <see cref="POINTL"/> to type <see cref="T:System.Drawing.Point"/>.
        /// </summary>
        /// <param name="point">Structure to convert.</param>
        /// <returns>
        /// Converted structure.
        /// </returns>
        public static implicit operator Point(POINTL point) => new Point(point.X, point.Y);
        #endregion

        #region [public] {static} (implicit operator) POINTL(Point): Perform an implicit conversion of type Point to type POINTL
        /// <summary>
        /// Perform an implicit conversion of type <see cref="T:System.Drawing.Point"/> to type <see cref="POINTL"/>.
        /// </summary>
        /// <param name="point">Structure to convert.</param>
        /// <returns>
        /// Converted structure.
        /// </returns>
        public static implicit operator POINTL(Point point) => new POINTL(point.X, point.Y);
        #endregion

        #endregion

        #region comparison

        #region [public] {static} (bool) operator ==(POINTL, POINTL): Implement the equality operator (==)
        /// <summary>
        /// Implement the equality operator (==).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(POINTL deviceInfo1, POINTL deviceInfo2) => deviceInfo1.Equals(deviceInfo2);
        #endregion

        #region [public] {static} (bool) operator !=(POINTL, POINTL): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        public static bool operator !=(POINTL deviceInfo1, POINTL deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);
        #endregion

        #endregion

        #endregion

        #region public overrides methods

        #region [public] {override} (int) GetHashCode(): Returns the hash code of this structure
        /// <summary>
        /// Returns the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => X ^ Y;
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

            if (!(obj is POINTL))
            {
                return false;
            }

            POINTL other = (POINTL)obj;
            return other.X == X && other.Y == Y;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current <see cref="POINTL"/> object.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="POINTL"/> structure.
        /// </returns>
        public override string ToString() => $"X = {X}, Y = {Y}";
        #endregion

        #endregion
    }
}
