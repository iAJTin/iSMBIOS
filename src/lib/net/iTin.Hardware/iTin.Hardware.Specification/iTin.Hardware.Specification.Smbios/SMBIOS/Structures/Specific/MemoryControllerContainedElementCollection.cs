
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of memory device identifiers.
    /// </summary>
    public sealed class MemoryControllerContainedElementCollection : ReadOnlyCollection<int>
    {
        #region constructor/s

        #region [internal] MemoryControllerContainedElementCollection(IEnumerable<int>): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="MemoryControllerContainedElementCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal MemoryControllerContainedElementCollection(IEnumerable<int> elements) : base(elements.ToList())
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
        /// Object <see cref="string"/> that represents the current <see cref="MemoryControllerContainedElementCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available items
        /// </remarks>                                    
        public override string ToString() => $"Memory Devices = { Items.Count}";
        #endregion

        #endregion              
    }
}
