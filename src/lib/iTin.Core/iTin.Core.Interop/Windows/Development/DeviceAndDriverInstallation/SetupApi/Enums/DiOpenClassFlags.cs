
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi
{
    using System;

    /// <summary>
    /// Defines the type of registry key that will be opened.
    /// </summary>
    [Flags]
    public enum DiOpenClassFlags : uint
    {
        /// <summary>
        /// Open a configuration class key. If ClassGuid is <c>null</c>, open the root key of the class installer's branch.
        /// </summary>
        DIOCR_INSTALLER = 0x00000001,

        /// <summary>
        /// Open an interface class key. If ClassGuid is <c>null</c>, open the root key of the interface class branch.
        /// </summary>
        DIOCR_INTERFACE = 0x00000002
    }
}
