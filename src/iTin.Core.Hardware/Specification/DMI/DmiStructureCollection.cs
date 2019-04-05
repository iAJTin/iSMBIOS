
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;

    using Helpers;
    using Smbios;

    /// <summary>
    /// Represents a collection of <see cref="DmiStructure" /> objects implemented in <see cref="DMI" />.
    /// </summary>
    public sealed class DmiStructureCollection : ReadOnlyCollection<DmiStructure>
    {
        #region constructor/s

        #region [internal] DmiStructureCollection(bool): Initialize a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureCollection" /> class.
        /// </summary>
        internal DmiStructureCollection() : base(new List<DmiStructure>())
        {
            foreach (var smbiosStructure in DmiHelper.Smbios.ImplementedStructures)
            {
                Items.Add(new DmiStructure(smbiosStructure));                    
            }
        }
        #endregion

        internal DmiStructureCollection(DMI dmi) : base(new List<DmiStructure>())
        {
            //DmiHelper.Smbios.Parse(dmi.)
        }
        #endregion

        #region public indexers

        #region [public] (DmiStructure) this[SmbiosStructure]: Gets the element with the specified key
        /// <summary>
        /// Gets the element with the specified key.
        /// </summary>
        /// <value>
        /// Object <see cref="DmiStructure" /> specified by its key.
        /// </value>
        /// <remarks>
        /// If the element does not exist, <b>null</b> is returned.
        /// </remarks>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public DmiStructure this[SmbiosStructure valueKey]
        {
            get
            {
                bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
                }

                int blockIndex = IndexOf(valueKey);
                if (blockIndex != -1)
                {
                    return this[blockIndex];
                }

                return null;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Contains(SmbiosStructure): Determines whether the element with the specified key is in the collection
        /// <summary>
        /// Determines whether the element with the specified key is in the collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="SmbiosStructure" /> that represents the key of the object <see cref="DmiStructure" /> to search.</param>
        /// <returns>
        /// <b>true</b> if the object <see cref="DmiStructure" /> with the <paramref name="valueKey"/> is in the collection; otherwise, it is <b>false</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(SmbiosStructure valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
            }
                           
            DmiStructure block = Items.FirstOrDefault(item => item.Class == valueKey);

            return Items.Contains(block);
        }
        #endregion

        #region [public] (int) IndexOf(SmbiosStructure): Returns the index of the object with the key specified in the collection
        /// <summary>
        /// Returns the index of the object with the key specified in the collection
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="SmbiosStructure" /> that represents the key of the object to be searched in the collection.</param>
        /// <returns>
        /// Zero-base index of the first appearance of the item in the collection, if found; otherwise, -1.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(SmbiosStructure valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(SmbiosStructure));
            }

            DmiStructure block = null;
            foreach (var item in Items)
            {
                if (item.Class != valueKey)
                {
                    continue;
                }

                block = item;
                break;
            }

            return IndexOf(block);
        }
        #endregion

        #endregion
    }
}
