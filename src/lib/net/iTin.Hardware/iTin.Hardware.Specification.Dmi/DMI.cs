﻿
using System;
using System.Diagnostics;

using iTin.Hardware.Abstractions.Specification.Smbios.ComponentModel;
using iTin.Hardware.Specification.Dmi;

namespace iTin.Hardware.Specification;

/// <summary>
/// The Desktop Management Interface (DMI) or the desktop management interface, standard framework for management and<br/>
/// component tracking on a desktop, laptop or server.
/// </summary>
public sealed class DMI
{
    #region private readonly members
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly DmiConnectOptions _options;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly SMBIOS _smbios;
    #endregion

    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DmiStructureCollection _dmiStructureCollection;
    #endregion

    #region constructor/s

    /// <summary>
    /// Prevents a default instance of the <see cref="DMI"/> class from being created.
    /// </summary>
    private DMI() : this(null)
    {
    }

    /// <summary>
    /// Prevents a default instance of the <see cref="DMI"/> class from being created.
    /// </summary>
    private DMI(DmiConnectOptions options)
    {
        _options = options;
        _smbios = _options == null
            ? SMBIOS.CreateInstance()
            : SMBIOS.CreateInstance(new SmbiosConnectOptions
            {
                UserName = options.UserName,
                Password = options.Password,
                MachineNameOrIpAddress = options.MachineNameOrIpAddress
            });
    }

    #endregion

    #region public static readonly properties

    /// <summary>
    /// Gets a <see cref="string"/> that represents the type of access.
    /// </summary>
    /// <value>
    /// A string that represents the type of access.
    /// </value>
    /// <remarks>
    /// This method always returns the <b>System BIOS</b> string.
    /// </remarks>       
    public static string AccessType => "System BIOS";

    /// <summary>
    /// Gets a <see cref="string"/> that represents access mode.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> that represents the mode of access.
    /// </value>
    /// <remarks>
    /// This method always returns the <b>&lt;DMI&gt;</b> string.
    /// </remarks>       
    public static string Identificationmethod => "<DMI>";

    /// <summary>
    /// Gets a instance of this class.
    /// </summary>
    /// <value>
    /// A <see cref="DMI"/> reference that contains <b>DMI</b> information.
    /// </value>
    [Obsolete("please use the DMI.CreateInstance() method instead of DMI.Instance for local DMI instance. For remote instance use DMI.CreateInstance(DmiConnectOptions)")]
    public static DMI Instance => new();

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the <b>SMBIOS</b> version.
    /// </summary>
    /// <value>
    /// The <b>SMBIOS</b> version.
    /// </value>
    public string SmbiosVersion => _smbios.Version.ToString("X");

    /// <summary>
    /// Gets the collection of available structures.
    /// </summary>
    /// <value>
    /// Object <see cref="DmiStructureCollection"/> that contains the collection of available <see cref="DmiStructure"/> objects.
    /// If there is no object <see cref="DmiStructure"/>, <b>null</b> is returned.
    /// </value>
    public DmiStructureCollection Structures => _dmiStructureCollection ??= new DmiStructureCollection(_smbios);

    #endregion

    #region public static methods

    /// <summary>
    /// Gets an instance of this class for remote machine.<br/>
    /// If <paramref name="options"/> is <b>null</b> (<b>Nothing</b> in Visual Basic) always returns an instance for this machine.
    /// </summary>
    /// <value>
    /// A <see cref="DMI"/> reference that contains <b>DMI</b> information.
    /// </value>
    public static DMI CreateInstance(DmiConnectOptions options = null) => options == null ? new DMI() : new DMI(options);

    #endregion

    #region public overrides methods

    /// <summary>
    /// Returns a <see cref="string"/> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents this instance.
    /// </returns>
    /// <remarks>
    /// The <see cref="ToString()"/> method returns a string that includes the version expresed in hexadecimal format,
    /// the number of available structures, and <see cref="SMBIOS"/> total size occupied by all structures.
    /// </remarks>
    public override string ToString() =>
        _options == null 
            ? $"SMBIOS={SmbiosVersion}, Classes={_smbios.ImplementedStructures.Count}, Size={_smbios.Lenght}"
            : _smbios.ToString();

    #endregion
}
