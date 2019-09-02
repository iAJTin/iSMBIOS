
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.Rectangles
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    /// <summary>
    /// The <Strong>RECT</Strong> structure defines the coordinates of the upper left and lower right corners of a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT : IEquatable<RECT>
    {
        #region public members
        /// <summary>
        /// X coordinate of the upper left corner of the rectangle.
        /// </summary>
        public int Left;

        /// <summary>
        /// Y coordinate of the upper left corner of the rectangle.
        /// </summary>
        public int Top;

        /// <summary>
        /// X coordinate of the lower right corner of the rectangle.
        /// </summary>
        public int Right;

        /// <summary>
        /// Y coordinate of the lower right corner of the rectangle.
        /// </summary>
        public int Bottom;
        #endregion

        #region constructor/s

        #region [public] REC(int, int, int, int): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="RECT"/> structure.
        /// </summary>
        /// <param name="left">X coordinate of the upper left corner of the rectangle.</param>
        /// <param name="top">Y coordinate of the upper left corner of the rectangle.</param>
        /// <param name="right">X coordinate of the lower right corner of the rectangle.</param>
        /// <param name="bottom">Y coordinate of the lower right corner of the rectangle.</param>
        public RECT(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }
        #endregion

        #endregion

        #region interfaces

        #region [public] (bool) Equals(RECT): Indicates whether the current object is equal to another object of the same type
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared with this object.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(RECT other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region implicit

        #region [public] {static} (implicit operator) Rectangle(RECT): Perform an implicit conversion of type RECT to type Rectangle
        /// <summary>
        /// Perform an implicit conversion of type <see cref="RECT"/> to type <see cref="T:System.Drawing.Rectangle" />.
        /// </summary>
        /// <param name="rect">Structure to convert.</param>
        /// <returns>
        /// Converted structure.
        /// </returns>
        public static implicit operator Rectangle(RECT rect) => new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
        #endregion

        #region [public] {static} (implicit operator) RECT(Rectangle): Perform an implicit conversion from type Rectangle to type RECT
        /// <summary>
        /// Perform an implicit conversion from type <see cref="T:System.Drawing.Rectangle"/> to type <see cref="RECT"/>.
        /// </summary>
        /// <param name="rect">Structure to convert.</param>
        /// <returns>
        /// Converted structure.
        /// </returns>
        public static implicit operator RECT(Rectangle rect) => new RECT(rect.X, rect.Y, rect.Right - rect.Left, rect.Bottom - rect.Top);
        #endregion

        #endregion

        #region comparison

        #region [public] {static} (bool) operator ==(RECT, RECT): Implement the equality operator (==)
        /// <summary>
        /// Implement the equality operator (==).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(RECT deviceInfo1, RECT deviceInfo2) => deviceInfo1.Equals(deviceInfo2);
        #endregion

        #region [public] {static} (bool) operator !=(RECT, RECT): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(RECT deviceInfo1, RECT deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);
        #endregion

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns the hash code of the object
        /// <summary>
        /// Returns the hash code of the object.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => Left ^ Top ^ Right ^ Bottom;
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

            if (!(obj is RECT))
            {
                return false;
            }

            var other = (RECT)obj;

            return 
                other.Left == Left && 
                other.Top == Top &&
                other.Right == Right && 
                other.Bottom == Bottom;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current <see cref="RECT"/> object.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="RECT" /> object.
        /// </returns>
        public override string ToString() => $"Left = {Left}, Top = {Top}, Right = {Right}, Bottom = {Bottom}";
        #endregion

        #endregion
    }
}
