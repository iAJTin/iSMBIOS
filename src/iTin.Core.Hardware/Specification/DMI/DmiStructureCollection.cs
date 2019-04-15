
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;

    using Device.DeviceProperty;
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
                Items.Add(new DmiStructure(smbiosStructure));                    
            }
        }
        #endregion

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

        #region [public] (IDeviceProperty) GetProperty(PropertyKey): Gets a reference to an object that implements the IDeviceProperty interface, represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// <summary>
        /// Gets a reference to an object that implements the IDeviceProperty interface, represents the strongly typed value of the property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public IDeviceProperty GetProperty(PropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;            
            DmiStructure structure = this[(SmbiosStructure)propertyId];

            return structure?.Elements[0].GetProperty(propertyKey);
        }
        #endregion

        #region [public] (IDictionary<int, IDeviceProperty>) GetProperties(PropertyKey): Gets a reference to an object that implements the IDeviceProperty interface, represents the strongly typed value of the property
        /// <summary>
        /// Gets a reference to an object list that implements the IDeviceProperty interface, represents the strongly typed value of the property. If it does not exist, returns an empty collection.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object list that represents the strongly typed value of the property
        /// </returns>
        public IDictionary<int, IDeviceProperty> GetProperties(PropertyKey propertyKey)
        {
            Enum propertyId = propertyKey.StructureId;
            Dictionary<int, IDeviceProperty> properties = new Dictionary<int, IDeviceProperty>();
            DmiStructure structure = this[(SmbiosStructure) propertyId];
            if (structure == null)
            {
                return properties;
            }

            int i = 0;
            DmiClassCollection elements = structure.Elements;
            foreach (var element in elements)
            {
                properties.Add(i, element.GetProperty(propertyKey));
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
