
namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Define a generic property
    /// </summary>
    public class PropertyItem
    {
        /// <summary>
        /// Gets or sets a value containing the property key identifier.
        /// </summary>
        /// <value>
        /// A <see cref="IPropertyKey"/> implementation that represents a property key identifier.
        /// </value>
        public IPropertyKey Key { get; set; }

        /// <summary>
        /// Gets or sets a value containing the property value.
        /// </summary>
        /// <value>
        /// An <see cref="object"/> containing the property value.
        /// </value>
        public object Value { get; set; }
    }
}
