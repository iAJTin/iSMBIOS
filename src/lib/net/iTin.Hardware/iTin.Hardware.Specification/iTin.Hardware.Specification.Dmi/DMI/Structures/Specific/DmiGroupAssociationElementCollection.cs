
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Smbios;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of <see cref="DmiGroupAssociationElement"/>.
    /// </summary>
    public sealed class DmiGroupAssociationElementCollection : ReadOnlyCollection<DmiGroupAssociationElement>
    {
        #region constructor/s

        #region [internal] DmiGroupAssociationElementCollection(GroupAssociationElementCollection): Inicializa una nueva instancia de la clase
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiGroupAssociationElementCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        public DmiGroupAssociationElementCollection(GroupAssociationElementCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
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
        /// Object <see cref="string"/> that represents the current <see cref="DmiGroupAssociationElementCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available items
        /// </remarks>                                    
        public override string ToString() => $"Elements = { Items.Count}";
        #endregion

        #endregion

        #region private static methods

        private static IEnumerable<DmiGroupAssociationElement> AsDmiCollectionFrom(GroupAssociationElementCollection elements)
        {
            var items = new Collection<DmiGroupAssociationElement>();

            foreach (var element in elements)
            {
                items.Add(new DmiGroupAssociationElement(element.Properties));
            }

            return items;
        }

        #endregion
    }
}
