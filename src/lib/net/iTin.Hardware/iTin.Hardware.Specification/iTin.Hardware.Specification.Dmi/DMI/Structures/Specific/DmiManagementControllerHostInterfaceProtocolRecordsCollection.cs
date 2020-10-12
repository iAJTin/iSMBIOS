
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Smbios;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of objects <see cref="DmiManagementControllerHostInterfaceProtocolRecordsCollection"/>.
    /// </summary>
    public sealed class DmiManagementControllerHostInterfaceProtocolRecordsCollection : ReadOnlyCollection<DmiManagementControllerHostInterfaceProtocolRecord>
    {
        #region constructor/s

        #region [internal] DmiManagementControllerHostInterfaceProtocolRecordsCollection(ManagementControllerHostInterfaceProtocolRecordsCollection): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiManagementControllerHostInterfaceProtocolRecordsCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal DmiManagementControllerHostInterfaceProtocolRecordsCollection(ManagementControllerHostInterfaceProtocolRecordsCollection elements) : base(AsDmiCollectionFrom(elements).ToList())
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
        /// Object <see cref="string"/> that represents the current <see cref="ManagementControllerHostInterfaceProtocolRecordsCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available elements.
        /// </remarks>                                    
        public override string ToString() => $"Protocols = {Items.Count}";
        #endregion

        #endregion              

        #region private static methods

        private static IEnumerable<DmiManagementControllerHostInterfaceProtocolRecord> AsDmiCollectionFrom(ManagementControllerHostInterfaceProtocolRecordsCollection elements)
        {
            var items = new Collection<DmiManagementControllerHostInterfaceProtocolRecord>();

            foreach (var element in elements)
            {
                items.Add(new DmiManagementControllerHostInterfaceProtocolRecord(element.Properties));
            }

            return items;
        }

        #endregion
    }
}
