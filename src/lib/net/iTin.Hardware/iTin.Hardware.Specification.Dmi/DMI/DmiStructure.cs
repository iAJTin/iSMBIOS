
using System.Diagnostics;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Dmi;

/// <summary>
/// Represents a structure <see cref="DMI"/>.
/// </summary>
public sealed class DmiStructure
{
    #region private members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DmiClassCollection _elementsCollection;
    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DmiStructure"/>.
    /// </summary>
    /// <param name="class">Structure.</param>
    /// <param name="context">a <see cref="SMBIOS"/> reference.</param>
    internal DmiStructure(DmiStructureClass @class, SMBIOS context)
    {
        Class = @class;
        Context = context;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that represents the class implemented.
    /// </summary>
    /// <value>
    /// One of the values of the enumeration <see cref="DmiStructureClass"/> that represents the implemented class.
    /// </value>
    public DmiStructureClass Class { get; }

    /// <summary>
    /// Gets the collection of available items.
    /// </summary>
    /// <value>
    /// Object <see cref="DmiClassCollection"/> that contains the collection of <see cref="DmiClass"/> objects available.
    /// If there is no object <see cref="DmiClass"/>, <b>null</b> is returned.
    /// </value>
    public DmiClassCollection Elements => _elementsCollection ??= new DmiClassCollection(this);

    /// <summary>
    /// Gets a value that represents the structure friendly name.
    /// </summary>
    /// <returns>
    /// The structure friendly name
    /// </returns>
    public string FriendlyClassName => Class.GetPropertyName();

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets a value that represents the <see cref="SMBIOS"/> reference context.
    /// </summary>
    /// <value>
    /// A <see cref="SMBIOS"/> reference context.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal SMBIOS Context { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the structure description.
    /// </summary>
    /// <returns>
    /// The structure description.
    /// </returns>
    public string GetStructureDescrition() => Class.GetPropertyDescription();

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents this instance.
    /// </returns>
    /// <remarks>
    /// This method returns a string that represents this instance.
    /// </remarks> 
    public override string ToString() => $"Class = {Class}";

    #endregion
}
