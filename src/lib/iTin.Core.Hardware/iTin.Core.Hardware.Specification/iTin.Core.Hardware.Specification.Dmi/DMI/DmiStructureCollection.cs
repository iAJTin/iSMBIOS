
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;

    using Helpers;
    using Smbios;

    /// <inheritdoc />
    /// <summary>
    /// Represents a collection of <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructure" /> objects implemented in <see cref="T:iTin.Core.Hardware.Specification.DMI" />.
    /// </summary>
    public sealed class DmiStructureCollection : ReadOnlyCollection<DmiStructure>
    {
        #region constructor/s

        #region [internal] DmiStructureCollection(): Initialize a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureCollection" /> class.
        /// </summary>
        internal DmiStructureCollection() : base(new List<DmiStructure>())
        {
            foreach (var smbiosStructure in DmiHelper.Smbios.ImplementedStructures)
            {                
                Items.Add(new DmiStructure((DmiStructureClass)(int)smbiosStructure));                    
            }
        }
        #endregion

        #endregion

        #region public indexers

        #region [public] (DmiStructure) this[DmiStructureClass]: Gets the element with the specified key
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
        public DmiStructure this[DmiStructureClass valueKey]
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

        #region [public] (bool) Contains(DmiStructureClass): Determines whether the element with the specified key is in the collection
        /// <summary>
        /// Determines whether the element with the specified key is in the collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="SmbiosStructure" /> that represents the key of the object <see cref="DmiStructure" /> to search.</param>
        /// <returns>
        /// <b>true</b> if the object <see cref="DmiStructure" /> with the <paramref name="valueKey"/> is in the collection; otherwise, it is <b>false</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(DmiStructureClass valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DmiStructureClass));
            }
                           
            DmiStructure block = Items.FirstOrDefault(item => item.Class == valueKey);

            return Items.Contains(block);
        }
        #endregion

        #region [public] (object) GetProperty(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetProperty(IPropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            DmiStructure structure = this[(DmiStructureClass)propertyId];

            return structure?.Elements[0].Properties[propertyKey];
        }
        #endregion

        #region [public] (T) GetProperty<T>(IPropertyKey): Returns the the strongly typed value of specified property
        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public T GetProperty<T>(IPropertyKey propertyKey)
        {
            T result = (T)GetProperty(propertyKey);
            if (result == null)
            {
                return default;
            }

            return result;
        }
        #endregion

        #region [public] (IDictionary<int, object>) GetProperties(IPropertyKey): Returns a table that contains the position and value of the property
        /// <summary>
        /// Returns a table that contains the position and value of the property. If it does not exist, returns an empty collection.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object list that contains the position and value of the property
        /// </returns>
        public IDictionary<int, object> GetProperties(IPropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            Dictionary<int, object> properties = new Dictionary<int, object>();
            DmiStructure structure = this[(DmiStructureClass)propertyId];
            if (structure == null)
            {
                return properties;
            }

            int i = 0;
            DmiClassCollection elements = structure.Elements;
            foreach (var element in elements)
            {
                properties.Add(i, element.GetPropertyValue(propertyKey));
                i++;
            }

            return properties;
        }
        #endregion

        #region [public] (IDictionary<int, T>) GetProperties<T>(IPropertyKey): Returns a table that contains the position and strongly typed value of the property
        /// <summary>
        /// Returns a table that contains the position and strongly typed value of the property. If it does not exist, returns an empty collection.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object list that contains the position and strongly typed value of the property.
        /// </returns>
        public IDictionary<int, T> GetProperties<T>(IPropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            Dictionary<int, T> properties = new Dictionary<int, T>();
            DmiStructure structure = this[(DmiStructureClass)propertyId];
            if (structure == null)
            {
                return properties;
            }

            int i = 0;
            DmiClassCollection elements = structure.Elements;
            foreach (var element in elements)
            {
                properties.Add(i, element.GetPropertyValue<T>(propertyKey));
                i++;
            }

            return properties;
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
        public int IndexOf(DmiStructureClass valueKey)
        {
            bool knownBlockValid = SentinelHelper.IsEnumValid(valueKey, true);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DmiStructureClass));
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
