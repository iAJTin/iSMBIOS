
namespace iTin.Core.Interop.Windows.Development.DeviceAndDriverInstallation.ConfigurationManager
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Functions to develop Device and Driver Installation Reference.
    /// </summary>
    public static class NativeMethods
    {
        #region public constants

        public const int CR_SUCCESS = 0x00000000;
        public const int CR_DEFAULT = 0x00000001;
        public const int CR_OUT_OF_MEMORY = 0x00000002;
        public const int CR_INVALID_POINTER = 0x00000003;
        public const int CR_INVALID_FLAG = 0x00000004;
        public const int CR_INVALID_DEVNODE = 0x00000005;
        public const int CR_INVALID_DEVINST = CR_INVALID_DEVNODE;
        public const int CR_INVALID_RES_DES = 0x00000006;
        public const int CR_INVALID_LOG_CONF = 0x00000007;
        public const int CR_INVALID_ARBITRATOR = 0x00000008;
        public const int CR_INVALID_NODELIST = 0x00000009;
        public const int CR_DEVNODE_HAS_REQS = 0x0000000A;
        public const int CR_DEVINST_HAS_REQS = CR_DEVNODE_HAS_REQS;
        public const int CR_INVALID_RESOURCEID = 0x0000000B;
        public const int CR_DLVXD_NOT_FOUND = 0x0000000C;
        public const int CR_NO_SUCH_DEVNODE = 0x0000000D;
        public const int CR_NO_SUCH_DEVINST = CR_NO_SUCH_DEVNODE;
        public const int CR_NO_MORE_LOG_CONF = 0x0000000E;
        public const int CR_NO_MORE_RES_DES = 0x0000000F;
        public const int CR_ALREADY_SUCH_DEVNODE = 0x00000010;
        public const int CR_ALREADY_SUCH_DEVINST = CR_ALREADY_SUCH_DEVNODE;
        public const int CR_INVALID_RANGE_LIST = 0x00000011;
        public const int CR_INVALID_RANGE = 0x00000012;
        public const int CR_FAILURE = 0x00000013;
        public const int CR_NO_SUCH_LOGICAL_DEV = 0x00000014;
        public const int CR_CREATE_BLOCKED = 0x00000015;
        public const int CR_NOT_SYSTEM_VM = 0x00000016;
        public const int CR_REMOVE_VETOED = 0x00000017;
        public const int CR_APM_VETOED = 0x00000018;
        public const int CR_INVALID_LOAD_TYPE = 0x00000019;
        public const int CR_BUFFER_SMALL = 0x0000001A;
        public const int CR_NO_ARBITRATOR = 0x0000001B;
        public const int CR_NO_REGISTRY_HANDLE = 0x0000001C;
        public const int CR_REGISTRY_ERROR = 0x0000001D;
        public const int CR_INVALID_DEVICE_ID = 0x0000001E;
        public const int CR_INVALID_DATA = 0x0000001F;
        public const int CR_INVALID_API = 0x00000020;
        public const int CR_DEVLOADER_NOT_READY = 0x00000021;
        public const int CR_NEED_RESTART = 0x00000022;
        public const int CR_NO_MORE_HW_PROFILES = 0x00000023;
        public const int CR_DEVICE_NOT_THERE = 0x00000024;
        public const int CR_NO_SUCH_VALUE = 0x00000025;
        public const int CR_WRONG_TYPE = 0x00000026;
        public const int CR_INVALID_PRIORITY = 0x00000027;
        public const int CR_NOT_DISABLEABLE = 0x00000028;
        public const int CR_FREE_RESOURCES = 0x00000029;
        public const int CR_QUERY_VETOED = 0x0000002A;
        public const int CR_CANT_SHARE_IRQ = 0x0000002B;
        public const int CR_NO_DEPENDENT = 0x0000002C;
        public const int CR_SAME_RESOURCES = 0x0000002D;
        public const int CR_NO_SUCH_REGISTRY_KEY = 0x0000002E;
        public const int CR_INVALID_MACHINENAME = 0x0000002F;
        public const int CR_REMOTE_COMM_FAILURE = 0x00000030;
        public const int CR_MACHINE_UNAVAILABLE = 0x00000031;
        public const int CR_NO_CM_SERVICES = 0x00000032;
        public const int CR_ACCESS_DENIED = 0x00000033;
        public const int CR_CALL_NOT_IMPLEMENTED = 0x00000034;
        public const int CR_INVALID_PROPERTY = 0x00000035;
        public const int CR_DEVICE_INTERFACE_ACTIVE = 0x00000036;
        public const int CR_NO_SUCH_DEVICE_INTERFACE = 0x00000037;
        public const int CR_INVALID_REFERENCE_STRING = 0x00000038;
        public const int CR_INVALID_CONFLICT_LIST = 0x00000039;
        public const int CR_INVALID_INDEX = 0x0000003A;
        public const int CR_INVALID_STRUCTURE_SIZE = 0x0000003B;

        #endregion

        #region P/Invoke

        #region [public] {static} {extern} (uint) CM_Enumerate_Classes(uint, ref Guid, uint): Retrieves the GUID identifier of each class installed on this system. The function must be called repeatedly until the CR_NO_SUCH_VALUE value is returned
        /// <summary>
        /// When called repeatedly, enumerates the local machine's installed device classes by supplying each class's GUID.
        /// Retrieves the GUID identifier of each class installed on this system. The function must be called repeatedly until the CR_NO_SUCH_VALUE value is returned.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/ff538021%28v=VS.85%29.aspx.
        /// </remarks>
        [DllImport(ExternDll.Win.Cfgmgr32, SetLastError = true)]
        public static extern uint CM_Enumerate_Classes(uint classIndex, ref Guid classGuid, uint flags);
        #endregion

        #endregion
    }
}
