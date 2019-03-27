
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// The class <see cref="DevicePropertyDescriptionsCache" /> represents the cache of descriptions available by keys.
    /// </summary>
    internal class DevicePropertyDescriptionsCache
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IDictionary<PropertyKey, DevicePropertyDescription> _propsDictionary;
        #endregion

        #region public static readonly members
        /// <summary>
        /// Gets a reference to the cache of available descriptions.
        /// </summary>
        public static readonly DevicePropertyDescriptionsCache Cache = new DevicePropertyDescriptionsCache();
        #endregion

        #region constructor/s

        #region [private] DevicePropertyDescriptionsCache(): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="DevicePropertyDescriptionsCache"/> class.
        /// </summary>
        private DevicePropertyDescriptionsCache()
        {
            _propsDictionary = new Dictionary<PropertyKey, DevicePropertyDescription>();
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (DevicePropertyDescription) GetPropertyDescription(PropertyKey): Returns the description for the specified key
        /// <summary>
        /// Returns the description for the specified key.
        /// </summary>
        /// <param name="key">The structure info.</param>
        /// <returns>
        /// Description for the specified key.
        /// </returns>
        public DevicePropertyDescription GetPropertyDescription(PropertyKey key)
        {
            if (!_propsDictionary.ContainsKey(key))
            {
                _propsDictionary.Add(key, new DevicePropertyDescription(key));
            }

            return _propsDictionary[key];
        }
        #endregion

        #endregion
    }
}
