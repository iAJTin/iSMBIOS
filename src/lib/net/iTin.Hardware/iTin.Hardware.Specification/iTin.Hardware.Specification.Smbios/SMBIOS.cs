
namespace iTin.Hardware.Specification
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Hardware.Common.Specification.Smbios;
    using iTin.Core.Helpers;

    using iTin.Hardware.Abstractions.Specification.Smbios;

    using Smbios;

    /// <summary>
    /// System Management BIOS (SMBIOS).<br/>
    /// Standard format of the data collected by the BIOS. SMBIOS defines this information in a series of data tables,<br/>
    /// where information about system components such as memory, peripheral devices, expansion cards, inventory label<br/>
    /// and operating system is collected.
    /// </summary>
    public sealed class SMBIOS
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte _majorVersion;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte _minorVersion;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ISmbiosConnectOptions _options;
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IEnumerable<byte[]> _rawTables;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<SmbiosStructure> _implementedStructures;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<SmbiosStructure, ICollection<byte[]>> _rawStructures;
        #endregion

        #region constructor/s

        #region [private] SMBIOS(): Initializes a new instance of this class.
        /// <summary>
        /// Initializes a new instance of the <see cref="SMBIOS"/> class.
        /// </summary>
        /// <remarks>
        /// Retrieves the <b>SMBIOS</b> information by <b>WMI</b> or native call.
        /// </remarks>
        private SMBIOS() : this(null)
        {
        }
        #endregion

        #region [private] SMBIOS(ISmbiosConnectOptions): Prevents a default instance of this class from being created with specified remote options
        /// <summary>
        /// Prevents a default instance of the <see cref="SMBIOS"/> class from being created. Retrieves the <see cref="SMBIOS"/> information by WMI.
        /// </summary>
        private SMBIOS(ISmbiosConnectOptions options)
        {
            _options = options;

            var rawSmbiosTable = SmbiosOperations.Instance.GetSmbiosDataArray(options);
            if (rawSmbiosTable.Length > 0)
            {
                _majorVersion = rawSmbiosTable[0x01];
                _minorVersion = rawSmbiosTable[0x02];
                Lenght = rawSmbiosTable.Length - 0x08;

                byte[] smbiosData = rawSmbiosTable.Extract(0x08, Lenght).ToArray();
                ToRawTables(smbiosData);
            }
        }
        #endregion

        #endregion

        #region public static readonly properties

        #region [public] {static} {readonly} (SMBIOS) Instance: Gets a instance of this class
        /// <summary>
        /// Gets a instance of this class.
        /// </summary>
        /// <value>
        /// A <see cref="SMBIOS"/> reference instance.
        /// </value>
        [Obsolete("please use the SMBIOS.CreateInstance() method instead of SMBIOS.Instance for local SMBIOS instance. For remote instance use SMBIOS.CreateInstance(SmbiosConnectOptions)")]
        public static readonly SMBIOS Instance = new SMBIOS();
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (IEnumerable<SmbiosBaseType>) ImplementedStructures: Gets the list of implemented structures
        /// <summary>
        /// Gets the list of implemented structures.
        /// </summary>
        public ReadOnlyCollection<SmbiosStructure> ImplementedStructures
        {
            get
            {
                _implementedStructures = GetImplementedStructureKeys();
                return _implementedStructures;
            }
            internal set => _implementedStructures = value;
        }
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
        public int Version => LogicHelper.Word(_minorVersion, _majorVersion);
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (Dictionary<SmbiosStructure, ICollection<byte[]>>) RawStructures: Gets the structures grouped by raw type
        /// <summary>
        /// Gets the structures grouped by raw type.
        /// </summary>
        /// <value>>
        /// Dictionary with unprocessed structures grouped by type.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<SmbiosStructure, ICollection<byte[]>> RawStructures => _rawStructures ?? (_rawStructures = new Dictionary<SmbiosStructure, ICollection<byte[]>>());
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
            SmbiosStructureInfo structureInfo = new SmbiosStructureInfo(this, structure);

            return cache.Get(structureInfo);
        }
        #endregion

        #endregion

        #region internal methods

        #region [internal] (ReadOnlyCollection<SmbiosStructure>) GetAllRawTablesFrom(SmbiosStructure): Returns the list of structure(s) of the specified type
        /// <summary>
        /// Returns the list of structure(s) of the specified type.
        /// </summary>
        /// <param name="structure">Reference structure.</param>
        /// <returns>
        /// An enumerator, which supports a simple iteration in the collection.
        /// </returns>
        internal IEnumerable<byte[]> GetAllRawTablesFrom(SmbiosStructure structure)
        {
            ReadOnlyCollection<SmbiosStructure> implementedStructures = GetImplementedStructureKeys();
            bool ok = implementedStructures.Contains(structure);

            if (!ok)
            {
                return null;
            }

            return RawStructures[structure];
        }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (SMBIOS) CreateInstance(ISmbiosConnectOptions = null): Gets a unique instance of this class for remote machine
        /// <summary>
        /// Gets a unique instance of this class for remote machine.<br/>
        /// If <paramref name="options"/> is <b>null</b> (<b>Nothing</b> in Visual Basic) always returns an instance for this machine.
        /// </summary>
        /// <value>
        /// A unique <see cref="SMBIOS"/> reference that contains <b>DMI</b> information.
        /// </value>
        public static SMBIOS CreateInstance(ISmbiosConnectOptions options = null) => options == null ? new SMBIOS() : new SMBIOS(options);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents this instance
        /// <summary>
        /// Returns a <see cref="string"/> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents this instance.</returns>
        /// <remarks>
        /// The <see cref="ToString()"/> method returns a string that includes the version expresed in hexadecimal format,
        /// the number of available structures, and the total length occupied by all structures.
        /// </remarks>
        public override string ToString()
        {
            if (_options == null)
            {
                return $"Version={Version:X}, Structures={ImplementedStructures.Count}, Lenght={Lenght}";
            }

            if (Version == 0 && ImplementedStructures.Count == 0 && Lenght == 0)
            {
                return $"Unable connect to remote machine '{_options.MachineNameOrIpAddress}'";
            }

            return $"Version={Version:X}, Structures={ImplementedStructures.Count}, Lenght={Lenght}";
        }

        #endregion

        #endregion

        #region private methods

        #region [private] (ReadOnlyCollection<SmbiosStructure>) GetImplementedStructureKeys: Returns the list with the keys of implemented structures
        /// <summary>
        /// Returns the list with the keys of implemented structures.
        /// </summary>
        /// <value>
        /// List of structures implemented.
        /// </value>
        private ReadOnlyCollection<SmbiosStructure> GetImplementedStructureKeys()
        {
            return
                RawStructures
                    .OrderBy(structure => structure.Key)
                    .Select(rawStructure => rawStructure.Key)
                    .ToList()
                    .AsReadOnly();
        }
        #endregion

        #region [private] (void) ToRawStructures(IEnumerable<byte[]): Returns the structures grouped by unprocessed type
        /// <summary>
        /// Returns the structures grouped by unprocessed type.
        /// </summary>
        /// <param name="data">Structures not processed without grouping.</param>
        private void ToRawStructures(IEnumerable<byte[]> data)
        {
            if (RawStructures.Count != 0)
            {
                RawStructures.Clear();
            }

            foreach (byte[] rawTable in data)
            {
                if(rawTable.Length<3)
                {
                    continue;
                }

                SmbiosStructure structureType = (SmbiosStructure)rawTable[0];
                if (RawStructures.ContainsKey(structureType))
                {
                    RawStructures[structureType].Add(rawTable);
                }
                else
                {
                    RawStructures.Add(structureType, new List<byte[]> { rawTable });
                }
            }
        }
        #endregion

        #region [private] (void) ToRawTables(byte[]): Returns all the SMBIOS tables unprocessed
        /// <summary>
        /// Returns all the SMBIOS tables unprocessed.
        /// </summary>
        /// <param name="rawSmbiosTable">Array with raw <b>SMBIOS</b> data.</param>
        private void ToRawTables(byte[] rawSmbiosTable)
        {
            int i = 0;
            bool exit = false;
            Collection<byte[]> smbiosTables = new Collection<byte[]>();

            while (!exit)
            {
                int firstByte = i;
                for (i = firstByte + rawSmbiosTable[i + 1]; i < rawSmbiosTable.Length; i++)
                {
                    if (rawSmbiosTable[i] == 0x00 && rawSmbiosTable[i + 1] == 0x00)
                    {
                        i += 2;
                        int lastByte = i;

                        if (rawSmbiosTable[firstByte] <= 0x7F)
                        {
                            var aTable = new byte[lastByte - firstByte];
                            Array.Copy(rawSmbiosTable, firstByte, aTable, 0, lastByte - firstByte);
                            smbiosTables.Add(aTable);
                        }
                        break;
                    }
                }

                if (i == rawSmbiosTable.Length)
                {
                    exit = true;
                }
            }

            //RawData = rawSmbiosTable;
            _rawTables = smbiosTables;
            ToRawStructures(_rawTables);
        }
        #endregion

        #endregion
    }
}
