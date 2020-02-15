
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the contents of a structure type.
    /// </summary>
    internal struct SmbiosStructureInfo : IEquatable<SmbiosStructureInfo>
    {
        #region constructor/s

        #region [public] SmbiosStructureInfo(SmbiosStructure, int): Initializes a new instance of the struct
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosStructureInfo"/> struct.
        /// </summary>
        /// <param name="structureType">Type of the structure.</param>
        /// <param name="smbiosVersion">The <see cref="SMBIOS"/> version.</param>
        public SmbiosStructureInfo(SmbiosStructure structureType, int smbiosVersion)
        {
            StructureType = structureType;
            SmbiosVersion = smbiosVersion;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (string) FriendlyClassName: Gets a value that represents the structure friendly name
        /// <summary>
        /// Gets a value that represents the structure friendly name.
        /// </summary>
        /// <returns>
        /// The structure friendly name
        /// </returns>
        public string FriendlyStructureName => StructureType.GetPropertyName();
        #endregion

        #region [public] (int) SmbiosVersion: Gets a value representing the version of SMBIOS
        /// <summary>
        /// Gets a value representing the version of <see cref="SMBIOS"/>.
        /// </summary>
        /// <value>
        /// <see cref="SMBIOS"/> versión.
        /// </value>
        public int SmbiosVersion { get; }
        #endregion

        #region [public] (SmbiosStructure) StructureType: Gets the type of structure
        /// <summary>
        /// Gets the type of structure.
        /// </summary>
        /// <value>Type of structure.</value>
        public SmbiosStructure StructureType { get; }
        #endregion

        #region [public] (SmbiosStructureCollection) Structures: Gets collection of available structures
        /// <summary>
        /// Gets collection of available structures.
        /// </summary>
        /// <value>
        /// Collection of available structures.
        /// </value>
        public SmbiosStructureCollection Structures
        {
            get
            {
                IEnumerable<SmbiosBaseType> structures = SmbiosStructureFactory.Create(this);
                return new SmbiosStructureCollection(structures);
            }
        }
        #endregion

        #endregion

        #region public operators

        #region [public] {operator} (bool) operator ==(SmbiosStructureInfo, SmbiosStructureInfo): Implements the == operator
        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="structureInfo1">The structure info1.</param>
        /// <param name="structureInfo2">The structure info2.</param>
        /// <returns>
        /// Returns <b>true</b> if <b>structureInfo1</b> is equal to <b>structureInfo2</b>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(SmbiosStructureInfo structureInfo1, SmbiosStructureInfo structureInfo2) => structureInfo1.Equals(structureInfo2);
        #endregion

        #region [public] {operator} (bool) operator !=(SmbiosStructureInfo, SmbiosStructureInfo): Implements the != operator
        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="structureInfo1">The structure info1.</param>
        /// <param name="structureInfo2">The structure info2.</param>
        /// <returns>
        /// Returns <b>true</b> if <b>structureInfo1</b> is not equal to <b>structureInfo2</b>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(SmbiosStructureInfo structureInfo1, SmbiosStructureInfo structureInfo2) => !structureInfo1.Equals(structureInfo2);
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Equals(SmbiosStructureInfo): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc/>
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Object to be compared to this object.</param>
        /// <returns>
        /// <b>true</b> if the current object is equal to the parameter <paramref name="other"/>; Otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(SmbiosStructureInfo other) => other.Equals((object)this);
        #endregion

        #region [public] (string) GetStructureDescrition(): Returns the structure description
        /// <summary>
        /// Returns the structure description.
        /// </summary>
        /// <returns>
        /// The structure description.
        /// </returns>
        public string GetStructureDescrition() => StructureType.GetPropertyDescription();
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a hash code for this instance
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode() => StructureType.GetHashCode() ^ SmbiosVersion;
        #endregion

        #region [public] {override} (bool) Equals(object): Determines whether the specified object is equal to this instance
        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">Another object with which the comparison is to be made.</param>
        /// <returns>
        /// <b>true</b> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <b>false</b>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is SmbiosStructureInfo))
            {
                return false;
            }

            SmbiosStructureInfo other = (SmbiosStructureInfo)obj;
            return 
                other.StructureType == StructureType && 
                other.SmbiosVersion == SmbiosVersion;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="ToString()"/> method returns a string that includes the <see cref="StructureType"/>.
        /// </remarks>
        public override string ToString() => $"SMBIOS = {SmbiosVersion:X2}, Type = {StructureType}, Structures = {Structures.Count}";
        #endregion

        #endregion
    }
}
