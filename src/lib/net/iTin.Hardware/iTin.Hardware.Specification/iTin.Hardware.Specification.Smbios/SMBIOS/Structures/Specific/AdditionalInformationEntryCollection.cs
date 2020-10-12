
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc/>
    /// <summary>
    /// Represents a collection of objects <see cref="AdditionalInformationEntry"/>.
    /// </summary>
    public sealed class AdditionalInformationEntryCollection : ReadOnlyCollection<AdditionalInformationEntry>
    {
        #region constructor/s

        #region [internal] AdditionalInformationEntryCollection(IEnumerable<ChassisContainedElement>): Initialize a new instance of the class
        /// <inheritdoc/>
        /// <summary>
        /// Initialize a new instance of the class <see cref="AdditionalInformationEntryCollection"/>.
        /// </summary>
        /// <param name="entries">Item list.</param>
        internal AdditionalInformationEntryCollection(IEnumerable<AdditionalInformationEntry> entries) : base(entries.ToList())
        {
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="T: System.String"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="AdditionalInformationEntryCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available elements.
        /// </remarks>                                    
        public override string ToString() => $"Entries = {Items.Count}";
        #endregion

        #endregion              
    }
}
