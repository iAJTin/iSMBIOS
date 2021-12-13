
namespace iTin.Hardware.Specification
{
    using System;
    using System.Diagnostics;

    using Dmi;
    using iTin.Hardware.Abstractions.Specification.Smbios.ComponentModel;

    /// <summary>
    /// The Desktop Management Interface (DMI) or the desktop management interface, standard framework for management and<br/>
    /// component tracking on a desktop, laptop or server.
    /// </summary>
    public sealed class DMI
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DmiConnectOptions _options;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SMBIOS _smbios;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DmiStructureCollection _dmiStructureCollection;
        #endregion

        #region constructor/s

        #region [private] DMI(): Prevents a default instance of this class from being created
        /// <summary>
        /// Prevents a default instance of the <see cref="DMI"/> class from being created.
        /// </summary>
        private DMI() : this(null)
        {
        }
        #endregion

        #region [private] DMI(DmiConnectOptions): Prevents a default instance of this class from being created with specified remote options
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

        #endregion

        #region public static readonly properties

        #region [public] {static} (string) AccessType: Gets a string that represents the type of access
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
        #endregion

        #region [public] {static} (string) Identificationmethod: Gets a string that represents access mode
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
        #endregion

        #region [public] {static} (DMI) Instance: Gets a instance of this class
        /// <summary>
        /// Gets a instance of this class.
        /// </summary>
        /// <value>
        /// A <see cref="DMI"/> reference that contains <b>DMI</b> information.
        /// </value>
        [Obsolete("please use the DMI.CreateInstance() method instead of DMI.Instance for local DMI instance. For remote instance use DMI.CreateInstance(DmiConnectOptions)")]
        public static DMI Instance => new DMI();
        #endregion

        #endregion

        #region public readonly properties

        #region [public] {static} (int) SmbiosVersion: Gets the SMBIOS version
        /// <summary>
        /// Gets the <b>SMBIOS</b> version.
        /// </summary>
        /// <value>
        /// The <b>SMBIOS</b> version.
        /// </value>
        public string SmbiosVersion => _smbios.Version.ToString("X");
        #endregion

        #region [public] (DmiStructureCollection) Structures: Gets the collection of available structure
        /// <summary>
        /// Gets the collection of available structures.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiStructureCollection"/> that contains the collection of available <see cref="DmiStructure"/> objects.
        /// If there is no object <see cref="DmiStructure"/>, <b>null</b> is returned.
        /// </value>
        public DmiStructureCollection Structures => _dmiStructureCollection ?? (_dmiStructureCollection = new DmiStructureCollection(_smbios));
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (DMI) CreateInstance(DmiConnectOptions = null): Gets an instance of this class for remote machine
        /// <summary>
        /// Gets an instance of this class for remote machine.<br/>
        /// If <paramref name="options"/> is <b>null</b> (<b>Nothing</b> in Visual Basic) always returns an instance for this machine.
        /// </summary>
        /// <value>
        /// A <see cref="DMI"/> reference that contains <b>DMI</b> information.
        /// </value>
        public static DMI CreateInstance(DmiConnectOptions options = null) => options == null ? new DMI() : new DMI(options);
        #endregion

        #endregion

        #region public overrides methods

        #region [public] {override} (string) ToString(): Returns aString that represents this instance.
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
        public override string ToString()
        {
            return _options == null 
                ? $"SMBIOS={SmbiosVersion}, Classes={_smbios.ImplementedStructures.Count}, Size={_smbios.Lenght}"
                : _smbios.ToString();
        }
        #endregion

        #endregion
    }
}
