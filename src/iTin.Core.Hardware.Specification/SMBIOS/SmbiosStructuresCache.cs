
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// The <see cref="SmbiosStructuresCache" /> class represents the cache of available structures for a particular type.
    /// </summary>
    internal class SmbiosStructuresCache
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Dictionary<SmbiosStructure, SmbiosStructureCollection> structureDictionary;
        #endregion

        #region public static readonly memebrs
        /// <summary>
        /// Gets a reference to the available structures cache.
        /// </summary>
        public static readonly SmbiosStructuresCache Cache = new SmbiosStructuresCache();
        #endregion

        #region constructor/s

        #region private SmbiosStructuresCache(): Prevents a default instance of the class from being created
        /// <summary>
        /// Prevents a default instance of the class from being created.
        /// </summary>
        private SmbiosStructuresCache()
        {
            structureDictionary = new Dictionary<SmbiosStructure, SmbiosStructureCollection>();   
        }
        #endregion

        #endregion

        #region public methods

        #region public (SmbiosStructureCollection) Get(SmbiosStructureInfo): Gets the collection of available structures
        /// <summary>
        /// Gets the collection of available structures.
        /// </summary>
        /// <param name="structureInfo">The structure info.</param>
        /// <returns>
        /// The collection of available structures.
        /// </returns>
        public SmbiosStructureCollection Get(SmbiosStructureInfo structureInfo)
        {
            if (!structureDictionary.ContainsKey(structureInfo.StructureType))
            {
                structureDictionary.Add(structureInfo.StructureType, structureInfo.Structures);
            }

            return structureDictionary[structureInfo.StructureType];
        }
        #endregion

        #endregion
    }
}
