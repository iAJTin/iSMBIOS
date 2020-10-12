
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Smbios;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of objects <see cref="MemoryChannelElement"/>.
    /// </summary>
    public sealed class DmiMemoryChannelElementCollection : ReadOnlyCollection<DmiMemoryChannelElement>
    {
        #region constructor/s

        #region [internal] DmiMemoryChannelElementCollection(MemoryChannelElementCollection): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiMemoryChannelElementCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal DmiMemoryChannelElementCollection(MemoryChannelElementCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
        {
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="DmiMemoryChannelElementCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available items
        /// </remarks>                                    
        public override string ToString() => $"Devices = {Items.Count}";
        #endregion

        #endregion              

        #region private static methods

        private static IEnumerable<DmiMemoryChannelElement> AsDmiCollectionFrom(MemoryChannelElementCollection elements)
        {
            var items = new Collection<DmiMemoryChannelElement>();

            foreach (var element in elements)
            {
                items.Add(new DmiMemoryChannelElement(element.Properties));
            }

            return items;
        }

        #endregion
    }
}
