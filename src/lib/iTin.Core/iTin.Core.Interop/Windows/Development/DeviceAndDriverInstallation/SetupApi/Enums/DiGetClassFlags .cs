
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi
{
    using System;

    /// <summary>
    /// Defines control options that filter the device information elements.
    /// </summary>
    [Flags]
    public enum DiGetClassFlags : uint
    {
        /// <summary>
        /// Return only the device that is associated with the system default device interface, if one is set, for the specified device interface classes.
        /// </summary>
        DIGCF_DEFAULT = 0x00000001,         // only valid with DIGCF_DEVICEINTERFACE

        /// <summary>
        /// Return only devices that are currently present in a system.
        /// </summary>
        DIGCF_PRESENT = 0x00000002,

        /// <summary>
        /// Return a list of installed devices for all device setup classes or all device interface classes.
        /// </summary>
        DIGCF_ALLCLASSES = 0x00000004,

        /// <summary>
        /// Return only devices that are a part of the current hardware profile.
        /// </summary>
        DIGCF_PROFILE = 0x00000008,

        /// <summary>
        /// Return devices that support device interfaces for the specified device interface classes. This flag must be set in the Flags parameter if the Enumerator parameter specifies a device instance ID.
        /// </summary>
        DIGCF_DEVICEINTERFACE = 0x00000010,
    }
}
