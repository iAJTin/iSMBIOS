
namespace iTin.Core.Interop.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors
{
    using System;
    using System.Runtime.InteropServices;

    using Rectangles;

    /// <summary>
    /// The <strongs>MONITORINFO</strongs> structure contains information about a monitor.
    /// The <strongs>MONITORINFO</strongs> structure is a subset of the <see cref="MONITORINFOEX"/> structure. The <see cref="MONITORINFOEX"/> structure adds a member that contains the name for the monitor.
    /// For more information, please see http://msdn.microsoft.com/es-es/library/dd145065.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MONITORINFO : IEquatable<MONITORINFO>
    {
        #region public memebrs
        /// <summary>
        /// Specifies the size, in bytes, of the <strong>MONITORINFO</strong> structure.
        /// Must be initialized before calling a <strong>Api</strong> function.
        /// </summary>
        public int Size;

        /// <summary>
        /// A structure <see cref="RECT"/> that specifies the rectangle of the total area of the monitor.
        /// </summary>
        public RECT Monitor;

        /// <summary>
        /// A structure <see cref="RECT"/> that specifies the rectangle of the working area of the useful monitor
        /// that can be used by applications, expressed in virtual screen coordinates.
        /// Windows uses this rectangle to maximize an application on the monitor.
        /// Toolbars, status bars, etc. are excluded.
        /// </summary>
        public RECT WorkArea;

        /// <summary>
        /// Attributes of the monitor.
        /// </summary>
        public uint Flags;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(MONITORINFO): Indicates whether the current object is the same as another object of the same type
        /// <summary>
        /// Indicates whether the current object is the same as another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared with this object.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(MONITORINFO other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(MONITORINFO, MONITORINFO): Implement the equality operator (==)
        /// <summary>
        /// Implement the equality operator (==).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2) => deviceInfo1.Equals(deviceInfo2);
        #endregion

        #region [public] {static} (bool) operator !=(MONITORINFO, MONITORINFO): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1.</param>
        /// <param name="deviceInfo2">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);
        #endregion

        #endregion

        #region public static properties

        #region [public] {static} (MONITORINFO) Create: Create a new instance of this structure
        /// <summary>
        /// Create a new instance of this structure.
        /// </summary>
        /// <value>
        /// New instance of the structure.
        /// </value>
        public static MONITORINFO Create
        {
            get
            {
                MONITORINFO instance = new MONITORINFO();
                instance.Init();

                return instance;
            }
        }
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
        public override int GetHashCode() => WorkArea.GetHashCode() ^ (int)Flags;
        #endregion

        #region [public] {override} (bool) Equals(object obj):Returns a value that indicates whether this object is equal to another
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

            if (!(obj is MONITORINFO))
            {
                return false;
            }

            var other = (MONITORINFO)obj;

            return 
                other.WorkArea == WorkArea && 
                other.Monitor == Monitor && 
                other.Flags == Flags;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current <see cref="MONITORINFO"/> object.
        /// </summary>
        /// <returns>
        /// String representing the current object.
        /// </returns>
        public override string ToString() => WorkArea.ToString();
        #endregion

        #endregion

        #region private members

        #region [private] (void) Init(): Initialize the structure internally, call always before using in an API call
        /// <summary>
        /// Initialize the structure internally, call <strong>always</strong> before using in an API call.
        /// </summary>
        private void Init()
        {
            Size = Marshal.SizeOf(this);
        }
        #endregion

        #endregion    
    }
}
