
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    /// <summary>
    /// Defines the properties used by a <b>DeviceProperty</b>.
    /// </summary>
    public interface IDeviceProperty
    {
        /// <summary>
        /// Gets the key that identifies the property.
        /// </summary>
        PropertyKey PropertyKey { get; }

        /// <summary>
        /// Gets a value that represents the description of the property.
        /// </summary>
        DevicePropertyDescription Description { get; }

        /// <summary>
        /// Gets a value that indicates whether the property has available value.
        /// </summary>             
        bool HasValue { get; }
    }
}
