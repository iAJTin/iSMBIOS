
using System;
using System.Collections.Generic;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Smbios;

/// <summary>
/// Defines the contents of a structure type.
/// </summary>
internal readonly struct SmbiosStructureInfo : IEquatable<SmbiosStructureInfo>
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosStructureInfo"/> struct.
    /// </summary>
    /// <param name="context">The <see cref="SMBIOS"/> context.</param>
    /// <param name="structureType">Type of the structure.</param>
    public SmbiosStructureInfo(SMBIOS context, SmbiosStructure structureType)
    {
        Context = context;
        StructureType = structureType;
        SmbiosVersion = context.Version;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that represents the structure friendly name.
    /// </summary>
    /// <value>
    /// The structure friendly name
    /// </value>
    public string FriendlyStructureName => StructureType.GetPropertyName();

    /// <summary>
    /// Gets a value representing the version of <see cref="SMBIOS"/>.
    /// </summary>
    /// <value>
    /// <see cref="SMBIOS"/> versión.
    /// </value>
    public int SmbiosVersion { get; }

    /// <summary>
    /// Gets the type of structure.
    /// </summary>
    /// <value>Type of structure.</value>
    public SmbiosStructure StructureType { get; }

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

    #region internal readonly properties

    /// <summary>
    /// Gets a value that represents the underliying <see cref="SMBIOS"/>.
    /// </summary>
    /// <value>
    /// The current <see cref="SMBIOS"/> context.
    /// </value>
    internal SMBIOS Context { get; }

    #endregion

    #region public operators

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="structureInfo1">The structure info1.</param>
    /// <param name="structureInfo2">The structure info2.</param>
    /// <returns>
    /// Returns <b>true</b> if <b>structureInfo1</b> is equal to <b>structureInfo2</b>; <b>false</b> otherwise.
    /// </returns>
    public static bool operator ==(SmbiosStructureInfo structureInfo1, SmbiosStructureInfo structureInfo2) => structureInfo1.Equals(structureInfo2);

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

    #region public methods

    /// <inheritdoc/>
    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared to this object.</param>
    /// <returns>
    /// <b>true</b> if the current object is equal to the parameter <paramref name="other"/>; Otherwise, <b>false</b>.
    /// </returns>
    public bool Equals(SmbiosStructureInfo other) => other.Equals((object)this);

    /// <summary>
    /// Returns the structure description.
    /// </summary>
    /// <returns>
    /// The structure description.
    /// </returns>
    public string GetStructureDescrition() => StructureType.GetPropertyDescription();

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    public override int GetHashCode() => StructureType.GetHashCode() ^ SmbiosVersion;

    /// <summary>
    /// Determines whether the specified <see cref="T:System.Object"/> is equal to this instance.
    /// </summary>
    /// <param name="obj">Another object with which the comparison is to be made.</param>
    /// <returns>
    /// <b>true</b> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <b>false</b>.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not SmbiosStructureInfo other)
        {
            return false;
        }

        return 
            other.StructureType == StructureType && 
            other.SmbiosVersion == SmbiosVersion;
    }

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="string"/> that represents this instance.</returns>
    /// <remarks>
    /// The <see cref="ToString()"/> method returns a string that includes the <see cref="StructureType"/>.
    /// </remarks>
    public override string ToString() => $"SMBIOS = {SmbiosVersion:X2}, Type = {StructureType}, Structures = {Structures.Count}";

    #endregion
}
