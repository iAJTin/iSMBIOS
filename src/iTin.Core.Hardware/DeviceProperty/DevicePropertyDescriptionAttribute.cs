
namespace iTin.Core.Hardware.Device.DeviceProperty
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Attribute that allows you to add a description to a property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DevicePropertyDescriptionAttribute : Attribute
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly string _description;
        #endregion

        #region constructor/s

        #region [public] DevicePropertyDescriptionAttribute(string): Initialize a new instance of the class by setting a string that defines the property
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Device.DeviceProperty.DevicePropertyDescriptionAttribute" /> class by setting a string that defines the property.
        /// </summary>
        /// <param name="description">String that defines the property</param>
        public DevicePropertyDescriptionAttribute(string description)
        {
            _description = description;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Description: Gets a string that defines the property
        /// <summary>
        /// Gets a string that defines the property.
        /// </summary>
        /// <value>
        /// <see cref="T:System.String"/> that defines the property.
        /// </value>
        public string Description => _description;
        #endregion

        #endregion
    }
}
