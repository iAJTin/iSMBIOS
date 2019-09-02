
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Describes the geometry of disk devices and media.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/winioctl/ns-winioctl-disk_geometry.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct DISK_GEOMETRY : IEquatable<DISK_GEOMETRY>
    {
        #region public members
        /// <summary>
        /// Number of cylinders
        /// </summary>
        public long Cylinders;

        /// <summary>
        /// Media Type. For more information, please see <see cref="MEDIA_TYPE"/>.
        /// </summary>
        public MEDIA_TYPE MediaType;

        /// <summary>
        /// Number of tracks per cylinder.
        /// </summary>
        public int TracksPerCylinder;

        /// <summary>
        /// Number of sectors per track.
        /// </summary>
        public int SectorsPerTrack;

        /// <summary>
        /// Number of bytes per sector.
        /// </summary>
        public int BytesPerSector;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(DISK_GEOMETRY): Indicates whether the current object is the same as another object of the same type
        /// <summary>
        /// Indicates whether the current object is the same as another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared with this object.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(DISK_GEOMETRY other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public static members
        /// <summary>
        /// Empty structure
        /// </summary>
        public static readonly DISK_GEOMETRY Empty;
        #endregion

        #region public properties

        #region [public] (long) DiskSize:  Gets a value that represents the size of the disk, it is measured in bytes
        /// <summary>
        /// Gets a value that represents the size of the disk, it is measured in bytes.
        /// </summary>
        /// <value>
        /// Disk size in bytes.
        /// </value>
        public long DiskSize => Cylinders * TracksPerCylinder * SectorsPerTrack * BytesPerSector;
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns the hash code of the structure
        /// <summary>
        /// Returns the hash code of the structure.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
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

            if (!(obj is DISK_GEOMETRY))
            {
                return false;
            }

            var other = (DISK_GEOMETRY)obj;

            return 
                other.Cylinders == Cylinders &&
                other.MediaType == MediaType &&
                other.TracksPerCylinder == TracksPerCylinder &&
                other.SectorsPerTrack == SectorsPerTrack &&
                other.BytesPerSector == BytesPerSector;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// Returns a string that represents the current object.
        /// </returns>
        public override string ToString() => $"{DiskSize}";
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
        public static bool operator ==(DISK_GEOMETRY left, DISK_GEOMETRY right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(DISK_GEOMETRY, DISK_GEOMETRY): Implementa el operador de desigualdad (!=).
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(DISK_GEOMETRY left, DISK_GEOMETRY right) => !left.Equals(right);
        #endregion

        #endregion
    }
}
