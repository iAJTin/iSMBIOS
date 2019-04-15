
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Helper class for <see cref="SMBIOS" />.
    /// </summary>
    internal static class SmbiosHelper
    {
        #region public constants
        public const string Reserved = "Reserved";
        public const string OutOfSpec = "<OUT OF SPEC>";
        #endregion

        #region private static members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IEnumerable<byte[]> _rawTables;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<SmbiosStructure, ICollection<byte[]>> _rawStructures;
        #endregion

        #region public static properties

        #region [public] {static} (Dictionary<SmbiosStructure, ICollection<byte[]>>) RawStructures: Gets the structures grouped by raw type
        /// <summary>
        /// Gets the structures grouped by raw type.
        /// </summary>
        /// <value>>
        /// Dictionary with unprocessed structures grouped by type.
        /// </value>
        public static Dictionary<SmbiosStructure, ICollection<byte[]>> RawStructures => _rawStructures ?? (_rawStructures = new Dictionary<SmbiosStructure, ICollection<byte[]>>());
        #endregion

        #region [public] {static} (IEnumerable<byte[]>) RawTables: Gets the raw SMBIOS tables
        /// <summary>
        /// Gets the raw <c>SMBIOS</c> tables.
        /// </summary>
        /// <value>
        /// An enumerator, which supports a simple iteration in the collection.
        /// </value>
        public static IEnumerable<byte[]> RawTables => _rawTables;
        #endregion

        #region [public] {static} (byte[]) RawData: Gets smbios raw data
        /// <summary>
        /// Gets smbios raw data
        /// </summary>
        /// <returns>
        /// Raw data.
        /// </returns>
        public static byte[] RawData
        {
            get; private set;
        }
        #endregion

        #endregion

        #region public static methods        

        #region [public] {static} (ReadOnlyCollection<SmbiosStructure>) GetImplementedStructureKeys: Returns the list with the keys of implemented structures
        /// <summary>
        /// Returns the list with the keys of implemented structures.
        /// </summary>
        /// <value>
        /// List of structures implemented.
        /// </value>
        public static ReadOnlyCollection<SmbiosStructure> GetImplementedStructureKeys()
        {
            return
                RawStructures
                    .OrderBy(structure => structure.Key)
                    .Select(rawStructure => rawStructure.Key)
                    .ToList()
                    .AsReadOnly();
        }
        #endregion

        #region [public] {static} (ReadOnlyCollection<SmbiosStructure>) GetAllRawTablesFrom(SmbiosStructure): Returns the list of structure(s) of the specified type
        /// <summary>
        /// Returns the list of structure(s) of the specified type.
        /// </summary>
        /// <param name="structure">Reference structure.</param>
        /// <returns>
        /// An enumerator, which supports a simple iteration in the collection.
        /// </returns>
        public static IEnumerable<byte[]> GetAllRawTablesFrom(SmbiosStructure structure)
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

        #region [public] {static} (void) ToRawTables(byte[]): Returns all the SMBIOS tables unprocessed
        /// <summary>
        /// Returns all the SMBIOS tables unprocessed.
        /// </summary>
        /// <param name="rawSMBIOSTable">Array with raw <c>SMBIOS</c> data.</param>
        public static void ToRawTables(byte[] rawSMBIOSTable)
        {
            int i = 0;
            bool exit = false;
            Collection<byte[]> smbiosTables = new Collection<byte[]>();

            while (!exit)
            {
                int firstByte = i;
                for (i = firstByte + rawSMBIOSTable[i + 1]; i < rawSMBIOSTable.Length; i++)
                {
                    if (rawSMBIOSTable[i] == 0x00 && rawSMBIOSTable[i + 1] == 0x00)
                    {
                        i += 2;
                        int lastByte = i;

                        if (rawSMBIOSTable[firstByte] <= 0x7F)
                        {
                            var aTable = new byte[lastByte - firstByte];
                            Array.Copy(rawSMBIOSTable, firstByte, aTable, 0, lastByte - firstByte);
                            smbiosTables.Add(aTable);
                        }
                        break;
                    }
                }

                if (i == rawSMBIOSTable.Length)
                {
                    exit = true;
                }
            }

            RawData = rawSMBIOSTable;
            _rawTables = smbiosTables;
            ToRawStructures(_rawTables);
        }
        #endregion

        #region [public] {static} (string[]) ParseStrings(byte[]): Returns all stored strings in raw table
        /// <summary>
        /// Returns all stored strings in raw table.
        /// </summary>
        /// <param name="rawDataArray">Raw table</param>
        /// <returns>
        /// Strings stored in raw data.
        /// </returns>
        public static string[] ParseStrings(byte[] rawDataArray)
        {
            bool exit = false;
            int index = rawDataArray[1];
            Collection<string> items = new Collection<string> { string.Empty };

            while (!exit)
            {
                int end = Array.IndexOf(rawDataArray, (byte)0x00, index);
                int count = end - index;
                items.Add(Encoding.ASCII.GetString(rawDataArray, index, count));

                if (rawDataArray[end + 1] == 0x00)
                {
                    exit = true;
                }
                else
                {
                    index = end + 1;
                }
            }

            return items.ToArray();
        }
        #endregion

        #endregion

        #region private static methods

        #region [public] {static} (void) ToRawStructures(IEnumerable<byte[]): Returns the structures grouped by unprocessed type
        /// <summary>
        /// Returns the structures grouped by unprocessed type.
        /// </summary>
        /// <param name="data">Structures not processed without grouping.</param>
        private static void ToRawStructures(IEnumerable<byte[]> data)
        {
            if (RawStructures.Count != 0)
            {
                RawStructures.Clear();
            }

            foreach (byte[] rawTable in data)
            {
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

        #endregion
    }
}
