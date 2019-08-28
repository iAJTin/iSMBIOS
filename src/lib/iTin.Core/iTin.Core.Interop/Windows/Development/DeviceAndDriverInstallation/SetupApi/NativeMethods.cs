
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions to develop Device and Driver Installation Reference.
    /// </summary>
    public static class NativeMethods
    {
        #region enumerations

        #region [public] (enum) KnownSetupDiGetDeviceRegistryProperty: Flags for SetupDiGetDeviceRegistry property parameter
        /// <summary>
        /// Flags for SetupDiGetDeviceRegistry property parameter
        /// </summary>
        public enum KnownSetupDiGetDeviceRegistryProperty : uint
        {
            SPDRP_DEVICEDESC = 0x00000000,                  // DeviceDesc (R/W)
            SPDRP_HARDWAREID = 0x00000001,                  // HardwareID (R/W)
            SPDRP_COMPATIBLEIDS = 0x00000002,               // CompatibleIDs (R/W)
            SPDRP_UNUSED0 = 0x00000003,                     // unused
            SPDRP_SERVICE = 0x00000004,                     // Service (R/W)
            SPDRP_UNUSED1 = 0x00000005,                     // unused
            SPDRP_UNUSED2 = 0x00000006,                     // unused
            SPDRP_CLASS = 0x00000007,                       // Class (R--tied to ClassGUID)
            SPDRP_CLASSGUID = 0x00000008,                   // ClassGUID (R/W)
            SPDRP_DRIVER = 0x00000009,                      // Driver (R/W)
            SPDRP_CONFIGFLAGS = 0x0000000A,                 // ConfigFlags (R/W)
            SPDRP_MFG = 0x0000000B,                         // Mfg (R/W)
            SPDRP_FRIENDLYNAME = 0x0000000C,                // FriendlyName (R/W)
            SPDRP_LOCATION_INFORMATION = 0x0000000D,        // LocationInformation (R/W)
            SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = 0x0000000E, // PhysicalDeviceObjectName (R)
            SPDRP_CAPABILITIES = 0x0000000F,                // Capabilities (R)
            SPDRP_UI_NUMBER = 0x00000010,                   // UiNumber (R)
            SPDRP_UPPERFILTERS = 0x00000011,                // UpperFilters (R/W)
            SPDRP_LOWERFILTERS = 0x00000012,                // LowerFilters (R/W)
            SPDRP_BUSTYPEGUID = 0x00000013,                 // BusTypeGUID (R)
            SPDRP_LEGACYBUSTYPE = 0x00000014,               // LegacyBusType (R)
            SPDRP_BUSNUMBER = 0x00000015,                   // BusNumber (R)
            SPDRP_ENUMERATOR_NAME = 0x00000016,             // Enumerator Name (R)
            SPDRP_SECURITY = 0x00000017,                    // Security (R/W, binary form)
            SPDRP_SECURITY_SDS = 0x00000018,                // Security (W, SDS form)
            SPDRP_DEVTYPE = 0x00000019,                     // Device Type (R/W)
            SPDRP_EXCLUSIVE = 0x0000001A,                   // Device is exclusive-access (R/W)
            SPDRP_CHARACTERISTICS = 0x0000001B,             // Device Characteristics (R/W)
            SPDRP_ADDRESS = 0x0000001C,                     // Device Address (R)
            SPDRP_UI_NUMBER_DESC_FORMAT = 0X0000001D,       // UiNumberDescFormat (R/W)
            SPDRP_DEVICE_POWER_DATA = 0x0000001E,           // Device Power Data (R)
            SPDRP_REMOVAL_POLICY = 0x0000001F,              // Removal Policy (R)
            SPDRP_REMOVAL_POLICY_HW_DEFAULT = 0x00000020,   // Hardware Removal Policy (R)
            SPDRP_REMOVAL_POLICY_OVERRIDE = 0x00000021,     // Removal Policy Override (RW)
            SPDRP_INSTALL_STATE = 0x00000022,               // Device Install State (R)
            SPDRP_LOCATION_PATHS = 0x00000023,              // Device Location Paths (R)
            SPDRP_BASE_CONTAINERID = 0x00000024             // Base ContainerID (R)
        }
        #endregion

        #endregion

        #region P/Invoke

        #region [public] {static} {extern} (bool) SetupDiEnumDeviceInfo (IntPtr, UInt32, ref SP_DEVINFO_DATA): Returns a SP_DEVINFO_DATA structure that specifies a device information element in a device information set
        /// <summary>
        /// Returns a <see cref="SP_DEVINFO_DATA"/> structure that specifies a device information element in a device information set.
        /// </summary>
        /// <remarks>
        /// For more information, please see https://docs.microsoft.com/es-es/windows/win32/api/setupapi/nf-setupapi-setupdienumdeviceinfo
        /// </remarks>
        [DllImport(ExternDll.Win.SetupApi, SetLastError = true)]
        public static extern bool SetupDiEnumDeviceInfo(IntPtr hdevinfo, UInt32 memberIndex, ref SP_DEVINFO_DATA deviceInfoData);
        #endregion

        #region [public] {static} {extern} (IntPtr) SetupDiGetClassDevsEx(ref Guid, UInt32, IntPtr, DiGetClassFlags, IntPtr, string, IntPtr): Returns a handle to a device information set that contains requested device information elements for a local or a remote computer
        /// <summary>
        /// Returns a handle to a device information set that contains requested device information elements for a local or a remote computer.
        /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetclassdevsexa
        /// </summary>
        [DllImport(ExternDll.Win.SetupApi, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr SetupDiGetClassDevsEx(
            ref Guid guidClass, 
            UInt32 enumerator, 
            IntPtr hwndParent, 
            DiGetClassFlags flags, 
            IntPtr deviceInfoSet, 
            [MarshalAs(UnmanagedType.LPWStr)] string machineName, 
            IntPtr reserved);
        #endregion

        #region [public] {static} {extern} (IntPtr) SetupDiGetClassDevsEx(ref Guid, string, IntPtr, DiGetClassFlags, IntPtr, string, IntPtr): Returns a handle to a device information set that contains requested device information elements for a local or a remote computer
        /// <summary>
        /// Returns a handle to a device information set that contains requested device information elements for a local or a remote computer.
        /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetclassdevsexa
        /// </summary>
        [DllImport(ExternDll.Win.SetupApi, SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr SetupDiGetClassDevsEx(
            ref Guid guidClass,
            [MarshalAs(UnmanagedType.LPWStr)] string enumerator,
            IntPtr hwndParent,
            DiGetClassFlags flags,
            IntPtr deviceInfoSet,
            [MarshalAs(UnmanagedType.LPWStr)] string machineName,
            IntPtr reserved);
        #endregion

        #region [public] {static} {extern} (bool) SetupDiGetDeviceRegistryProperty (IntPtr, ref SP_DEVINFO_DATA, KnownSetupDiGetDeviceRegistryProperty, out UInt32, byte[], uint, out UInt32): Retrieves a specified Plug and Play device property
        /// <summary>
        /// Retrieves a specified Plug and Play device property.
        /// </summary>
        /// <remarks>
        /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetdeviceregistrypropertya
        /// </remarks>
        [DllImport(ExternDll.Win.SetupApi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, KnownSetupDiGetDeviceRegistryProperty property, out UInt32 propertyRegDataType, byte[] propertyBuffer, uint propertyBufferSize, out UInt32 requiredSize);
        #endregion

        #region [public] {static} {extern} (bool) SetupDiOpenDevRegKey (IntPtr, ref SP_DEVINFO_DATA, KnownSetupDiGetDeviceRegistryProperty, UInt32, UInt32, ulong): Opens a registry key for device-specific configuration information
        /// <summary>
        /// Opens a registry key for device-specific configuration information. For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetdeviceregistrypropertya
        /// </summary>
        [DllImport(ExternDll.Win.SetupApi, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, UInt32 scope, UInt32 hwProfile, UInt32 keyType, ulong samDesired);
        #endregion

        #endregion
    }
}
