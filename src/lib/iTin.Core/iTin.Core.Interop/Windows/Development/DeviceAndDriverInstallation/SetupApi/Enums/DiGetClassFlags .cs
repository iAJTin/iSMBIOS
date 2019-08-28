
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi
{
    using System;

    [Flags]
    public enum DiGetClassFlags : uint
    {
        DIGCF_DEFAULT = 0x00000001,         // only valid with DIGCF_DEVICEINTERFACE
        DIGCF_PRESENT = 0x00000002,
        DIGCF_ALLCLASSES = 0x00000004,
        DIGCF_PROFILE = 0x00000008,
        DIGCF_DEVICEINTERFACE = 0x00000010,
    }
}
