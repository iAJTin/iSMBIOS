
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of objects <see cref="ChassisContainedElement"/>.
    /// </summary>
    public sealed class ChassisContainedElementCollection : ReadOnlyCollection<ChassisContainedElement>
    {
        #region constructor/s

        #region [internal] ChassisContainedElementCollection(IEnumerable<ChassisContainedElement>): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="ChassisContainedElementCollection"/>.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal ChassisContainedElementCollection(IEnumerable<ChassisContainedElement> elements) : base(elements.ToList())
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
        /// Object <see cref="string"/> that represents the current <see cref="ChassisContainedElementCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available elements.
        /// </remarks>                                    
        public override string ToString() => $"Elements = {Items.Count}";
        #endregion

        #endregion              
    }
}
