
namespace iTin.Core.Hardware.Interop
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    using iTin.Core.Interop.Windows;

    using ComponentModel;
    using DeviceInfo;

    using Gdi = Core.Interop.Windows.Development.Graphics.Legacy.Gdi;
    using Registry = Core.Interop.Windows.Development.Registry;
    using SetupApi = Core.Interop.Windows.Development.DeviceAndDriverInstallation.SetupApi;

    /// <summary>
    /// Defines a set of Safe monitor native methods.
    /// </summary>
    public static class SafeMonitorNativeMethods
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly IList<Gdi.MultipleDisplayMonitors.MONITORINFOEX> Monitors = new List<Gdi.MultipleDisplayMonitors.MONITORINFOEX>();
        #endregion

        #region public static members

        #region [public] {static} (IEnumerable<MonitorDeviceInfo>) EnumerateMonitorDevices(): Returns an array with the information of the system monitors
        /// <summary>
        /// Returns an array with the information of the system monitors.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="T:System.Array"/> of structures <see cref="MonitorDeviceInfo"/> which contains the information of the system monitors.
        /// </returns>
        public static IEnumerable<MonitorDeviceInfo> EnumerateMonitorDevices()
        {
            var monitors = new Collection<MonitorDeviceInfo>();

            IEnumerable<MonitorDeviceInfoNative> devicesInfo = EnumerateMonitorDevicesImpl().ToList();
            IEnumerable<MonitorDeviceEdidInfoNative> edidDevicesInfo = EnumerateMonitorEdidDevicesImpl().ToList();

            foreach (var deviceInfo in devicesInfo)
            {
                var deviceIdNormalized = deviceInfo.DeviceId.Replace("#", "\\").ToLowerInvariant();
                foreach (var edidDeviceInfo in edidDevicesInfo)
                {
                    var edidDeviceInfoNormalized = edidDeviceInfo.DeviceId.ToLowerInvariant();

                    var canAdd = deviceIdNormalized.Contains(edidDeviceInfoNormalized);
                    if (!canAdd)
                    {
                        continue;
                    }

                    monitors.Add(new MonitorDeviceInfo(deviceInfo, edidDeviceInfo));
                }
            }

            return monitors;
        }
        #endregion

        #endregion

        #region private static members

        private static IEnumerable<MonitorDeviceInfoNative> EnumerateMonitorDevicesImpl()
        {
            Monitors.Clear();
            Gdi.MultipleDisplayMonitors.NativeMethods.EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, EnumMonitorsCallBack, IntPtr.Zero);

            var monitorDevices = new List<MonitorDeviceInfoNative>();
            foreach (var monitorInfo in Monitors)
            {
                for (uint i = 0; ; i++)
                {
                    var monitorDevice = Gdi.DeviceContext.DISPLAY_DEVICE.Empty;
                    bool deviceIsAvailable = Gdi.DeviceContext.NativeMethods.EnumDisplayDevices(monitorInfo.DeviceName, i, ref monitorDevice, Gdi.DeviceContext.DISPLAY_DEVICE.EDD_GET_DEVICE_INTERFACE_NAME);
                    if (!deviceIsAvailable)
                    {
                        break;
                    }

                    if ((monitorDevice.State & Gdi.DeviceContext.DISPLAY_DEVICE.KnownDisplayDeviceStates.MirroringDriver) != Gdi.DeviceContext.DISPLAY_DEVICE.KnownDisplayDeviceStates.MirroringDriver)
                    {
                        monitorDevices.Add(new MonitorDeviceInfoNative(monitorInfo, monitorDevice));
                    }
                }
            }

            return monitorDevices;
        }

        private static IEnumerable<MonitorDeviceEdidInfoNative> EnumerateMonitorEdidDevicesImpl()
        {
            var info = new Collection<MonitorDeviceEdidInfoNative>();
            var GUID_DEVCLASS_MONITOR = GuidDevClass.GUID_DEVCLASS_MONITOR;

            var canContinue = true;
            while (canContinue)
            {
                IntPtr devInfo =
                    SetupApi.NativeMethods.SetupDiGetClassDevsEx(
                        ref GUID_DEVCLASS_MONITOR,     // class GUID
                        null,                // enumerator
                        IntPtr.Zero,         // HWND
                        SetupApi.DiGetClassFlags.DIGCF_PRESENT, // Flags
                        IntPtr.Zero,       // device info, create a new one
                        null,               // machine name, local machine
                        IntPtr.Zero);
                if (devInfo == IntPtr.Zero)
                {
                    canContinue = false;
                }

                if (!canContinue)
                {
                    break;
                }

                for (uint i = 0; Marshal.GetLastWin32Error() != Win32ErrorCode.ERROR_NO_MORE_ITEMS; i++)
                {
                    SetupApi.SP_DEVINFO_DATA devInfoData = SetupApi.SP_DEVINFO_DATA.Empty;
                    bool deviceInfoSuccess = SetupApi.NativeMethods.SetupDiEnumDeviceInfo(devInfo, i, ref devInfoData);
                    if (!deviceInfoSuccess)
                    {
                        canContinue = false;
                    }

                    if (!canContinue)
                    {
                        continue;
                    }

                    MonitorDeviceEdidInfoNative candidate = GetMonitorDeviceEdidInfo(devInfo, devInfoData);
                    var canAdd = candidate.IsValid && candidate != MonitorDeviceEdidInfoNative.NoValid;
                    if (canAdd)
                    {
                        info.Add(candidate);
                    }
                }
            }

            return info;
        }

        private static bool EnumMonitorsCallBack(IntPtr hMonitor, IntPtr hdcMonitor, ref Gdi.Rectangles.RECT lprcMonitor, IntPtr dwData)
        {
            Gdi.MultipleDisplayMonitors.MONITORINFOEX mi = Gdi.MultipleDisplayMonitors.MONITORINFOEX.Empty;
            bool ok = Gdi.MultipleDisplayMonitors.NativeMethods.GetMonitorInfo(hMonitor, ref mi);
            if (ok)
            {
                Monitors.Add(mi);
            }

            return ok;
        }

        private static MonitorDeviceEdidInfoNative GetMonitorDeviceEdidInfo(IntPtr devInfo, SetupApi.SP_DEVINFO_DATA devInfoData)
        {
            uint instanceIdSize = 0;
            IntPtr instanceIdSizePointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(uint)));
            Marshal.StructureToPtr(instanceIdSize, instanceIdSizePointer, false);

            var instanceId = new char[256];
            bool deviceInstanceSuccess =
                SetupApi.NativeMethods.SetupDiGetDeviceInstanceId(
                    devInfo,
                    ref devInfoData,
                    instanceId,
                    256,
                    instanceIdSizePointer);

            if (!deviceInstanceSuccess)
            {
                return MonitorDeviceEdidInfoNative.NoValid;
            }

            byte[] instanceIdBytes = Encoding.Unicode.GetBytes(instanceId, 0, instanceId.Length);
            uint instanceIdSizeValue = ((uint)Marshal.PtrToStructure(instanceIdSizePointer, typeof(uint)) - 1) << 1;
            string instanceIdString = Encoding.Unicode.GetString(instanceIdBytes, 0, (int)instanceIdSizeValue);

            IntPtr edidRegKey =
                SetupApi.NativeMethods.SetupDiOpenDevRegKey(
                    devInfo,
                    ref devInfoData,
                    1, //NativeConstants.DICS_FLAG_GLOBAL,
                    0,
                    1, //NativeConstants.DIREG_DEV,
                    0x20019); //NativeConstants.KEY_READ);

            uint edidSize = 128;
            var edidData = new byte[edidSize];
            uint regQuerySuccess = Registry.NativeMethods.RegQueryValueEx(
                edidRegKey,
                "EDID",
                IntPtr.Zero,
                IntPtr.Zero,
                edidData,
                ref edidSize);

            if (regQuerySuccess != Win32ErrorCode.ERROR_SUCCESS)
            {
                return MonitorDeviceEdidInfoNative.NoValid;
            }

            return new MonitorDeviceEdidInfoNative
            {
                DeviceId = instanceIdString,
                IsValid = !Array.TrueForAll(edidData, y => y == 0),
                RawEdid = edidData
            };
        }

        #endregion
    }
}
