
namespace iTin.Hardware.Specification.Dmi
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of memory device identifiers.
    /// </summary>
    public sealed class DmiMemoryControllerContainedElementCollection : ReadOnlyCollection<int>
    {
        #region constructor/s

        #region [internal] DmiMemoryControllerContainedElementCollection(IEnumerable<int>): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="DmiMemoryControllerContainedElementCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal DmiMemoryControllerContainedElementCollection(IEnumerable<int> elements) : base(elements.ToList())
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
        /// Object <see cref="string"/> that represents the current <see cref="DmiMemoryControllerContainedElementCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available items
        /// </remarks>                                    
        public override string ToString() => $"Memory Devices = { Items.Count}";
        #endregion

        #endregion              
    }
}
