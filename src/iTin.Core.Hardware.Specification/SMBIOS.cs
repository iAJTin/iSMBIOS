
namespace iTin.Core.Hardware.Specification
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Management;

    using Helpers;
    using Interop.Windows.Development.SystemServices.SystemInformation.Firmware;
    using Smbios;

    /// <summary>
    /// System Management BIOS (SMBIOS).
    /// Standard format of the data collected by the BIOS. SMBIOS defines this information in a series of data tables, 
    /// where information about system components such as memory, peripheral devices, expansion cards, inventory label
    /// and operating system is collected.
    /// </summary>
    internal sealed class SMBIOS
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte majorVersion;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte minorVersion;
        #endregion

        #region constructor/s

        #region [private] SMBIOS(): Initializes a new instance of the SMBIOS class. Retrieves the SMBIOS information by WMI
        /// <summary>
        /// Initializes a new instance of the <see cref="SMBIOS"/> class. Retrieves the SMBIOS information by WMI.
        /// </summary>
        /// <remarks>
        /// Retrieves the <b>SMBIOS</b> information by <b>WMI</b>
        /// </remarks>
        private SMBIOS()
        {
            string[] tableNames = FirmwareTable.EnumerateTables(KnownProvider.RSMB);
            if (tableNames.Any())
            {
                byte[] rawSmbiosTable = FirmwareTable.GetTable(KnownProvider.RSMB, tableNames[0]);
                majorVersion = rawSmbiosTable[0x01];
                minorVersion = rawSmbiosTable[0x02];
                Lenght = rawSmbiosTable.Length - 0x08;

                var smBiosData = rawSmbiosTable.Extract(0x08, Lenght); 
                SmbiosHelper.ToRawTables(smBiosData);
            }
            else
            {
                using (var wmi = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSSmBios_RawSMBiosTables"))
                {
                    foreach (var o in wmi.Get())
                    {
                        var queryObj = (ManagementObject)o;
                        Lenght = (int) (uint) queryObj["Size"];
                        majorVersion = (byte)queryObj["SmbiosMajorVersion"];
                        minorVersion = (byte)queryObj["SmbiosMinorVersion"];

                        SmbiosHelper.ToRawTables((byte[])queryObj["SMBiosData"]);
                    }
                }
            }
        }
        #endregion

        #endregion

        #region public static readonly properties
        /// <summary>
        /// Gets a unique instance of this class.
        /// </summary>
        public static readonly SMBIOS Instance = new SMBIOS();
        #endregion

        #region public readonly properties

        #region [public] (IEnumerable<SmbiosBaseType>) ImplementedStructures: Gets the list of implemented structures
        /// <summary>
        /// Gets the list of implemented structures.
        /// </summary>
        public ReadOnlyCollection<SmbiosStructure> ImplementedStructures => SmbiosHelper.GetImplementedStructureKeys();
        #endregion

        #region [public] (int) Lenght: Gets a value that contains the length of all SMBIOS tables
        /// <summary>
        /// Gets a value that contains the length of all <b>SMBIOS</b> tables.
        /// </summary>
        /// <value>
        /// Length of all <b>SMBIOS</b> tables
        /// </value>
        public int Lenght { get; }

        #endregion

        #region [public] (int) Version: Gets a value that contains the version of SMBIOS
        /// <summary>
        /// Gets a value that contains the version of <b>SMBIOS</b>.
        /// </summary>
        /// <value>
        /// Version of <b>SMBIOS</b> in decimal notation.
        /// </value>
        public int Version => LogicHelper.Word(minorVersion, majorVersion);
        #endregion

        #endregion

        #region public methods

        #region [public] (SmbiosStructureCollection) Get(SmbiosStructure): Gets the data of the specified structure
        /// <summary>
        /// Gets the data of the specified structure.
        /// </summary>
        /// <param name="structure">Structure to be recovered.</param>
        /// <returns>
        /// Collection of structures.
        /// </returns>
        public SmbiosStructureCollection Get(SmbiosStructure structure)
        {
            bool implementedStructure = ImplementedStructures.Contains(structure);
            if (!implementedStructure)
            {
                return null;
            }

            SmbiosStructuresCache cache = SmbiosStructuresCache.Cache;
            SmbiosStructureInfo structureInfo = new SmbiosStructureInfo(structure, Version);

            return cache.Get(structureInfo);
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="T:System.String" /> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="T:SMBIOS.ToString ()" /> method returns a string that includes the version expresed in hexadecimal format,
        /// the number of available structures, and the total length occupied by all structures.
        /// </remarks>
        public override string ToString() => $"Version = {Version:X}, Structures = {ImplementedStructures.Count}, Lenght = {Lenght}";
        #endregion

        #endregion
    }
}
