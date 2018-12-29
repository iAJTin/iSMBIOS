
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
    static class SmbiosHelper
    {
        #region public constants
        public const string OutOfSpec = "<OUT OF SPEC>";
        #endregion

        #region private static members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IEnumerable<byte[]> _rawTables;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static Dictionary<SmbiosStructure, ICollection<byte[]>> _rawStructures;
        #endregion

        #region public static properties

        /// <summary>
        /// Obtiene las estructuras agrupadas por tipo sin procesar.
        /// </summary>
        /// <value>>Diccionario con las estructuras no procesadas agrupadas por tipo.</value>
        public static Dictionary<SmbiosStructure, ICollection<byte[]>> RawStructures => _rawStructures ?? (_rawStructures = new Dictionary<SmbiosStructure, ICollection<byte[]>>());

        /// <summary>
        /// Obtiene las tablas SMBIOS sin procesar.
        /// </summary>
        /// <value>Un enumerador, que admite una iteración simple en la colección.</value>
        public static IEnumerable<byte[]> RawTables => _rawTables;

        public static byte[] RawData
        {
            get; private set;
        }
  
        #endregion

        #region public static methods
        /// <summary>
        /// Obtener la lista con las claves de estructuras implementadas.
        /// </summary>
        /// <value>Lista de estructuras implementadas.</value>
        public static ReadOnlyCollection<SmbiosStructure> GetImplementedStructureKeys()
        {
            return 
                RawStructures
                    .OrderBy(structure => structure.Key)
                    .Select(rawStructure => rawStructure.Key)
                    .ToList()
                    .AsReadOnly();
        }

        /// <summary>
        /// Obtener la lista de estructura(s) del tipo especificado.
        /// </summary>
        /// <param name="structure">Estructura de referencia.</param>
        /// <returns>Un enumerador, que admite una iteración simple en la colección.</returns>
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

        /// <summary>
        /// Obtener todas las tablas SMBIOS sin procesar.
        /// </summary>
        /// <param name="rawSMBIOSTable">Array con los datos SMBIOS sin procesar.</param>
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
                    if ((rawSMBIOSTable[i] == 0x00) && (rawSMBIOSTable[i + 1] == 0x00))
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

        #region private static methods

        /// <summary>
        /// Obtener las estructuras agrupadas por tipo sin procesar.
        /// </summary>
        /// <param name="data">Estructuras no procesadas sin agrupar.</param>
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
    }
}
