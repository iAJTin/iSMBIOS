
namespace iTin.Core.Hardware.Common
{
    /// <summary>
    /// Define a generic device information.
    /// </summary>
    public interface IDeviceInfo
    {
        /// <summary>
        /// Gets or sets a value containing the property key identifier.
        /// </summary>
        /// <value>
        /// A <see cref="IPropertyKey"/> implementation that represents a property key identifier.
        /// </value>
        QueryPropertyResult GetProperty(IPropertyKey key);
    }
}
