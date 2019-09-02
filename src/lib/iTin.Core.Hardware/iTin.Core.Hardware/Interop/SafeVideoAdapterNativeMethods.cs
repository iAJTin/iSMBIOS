
namespace iTin.Core.Hardware.Interop
{
    using System.Collections.Generic;
    using System.Linq;

    using DeviceInfo;

    using DeviceContext = Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext;

    /// <summary>
    /// Defines a set of Safe monitor native methods.
    /// </summary>
    public static class SafeVideoAdapterNativeMethods
    {
        /// <summary>
        /// Array with the information of the system video adapters.
        /// </summary>
        /// <returns>
        /// Returns a <see cref = "T: System.Array" /> of structures <see cref = "VideoAdapterDeviceInfo" /> that contains the system's video adapters.
        /// </returns>
        public static VideoAdapterDeviceInfo[] EnumerateVideoAdapterDevices()
        {
            var adapters = new List<VideoAdapterDeviceInfo>();

            for (uint i = 0; ; i++)
            {
                var adapterDevice = DeviceContext.DISPLAY_DEVICE.Empty;
                bool deviceIsAvailable = DeviceContext.NativeMethods.EnumDisplayDevices(null, i, ref adapterDevice, 0);

                if (!deviceIsAvailable)
                {
                    break;
                }

                if (!string.IsNullOrEmpty(adapterDevice.DeviceID))
                {
                    adapters.Add(new VideoAdapterDeviceInfo(adapterDevice));
                }
            }

            return adapters.ToArray();
        }

        /// <summary>
        /// Get the video adapter information associated with the specified monitor.
        /// </summary>
        /// <param name="monitorDeviceInfo"> Monitor information. </param>
        /// <returns>
        /// Returns a <see cref="VideoAdapterDeviceInfo"/> structure that contains the adapter information associated with the specified monitor.
        /// </returns>
        public static VideoAdapterDeviceInfo GetVideoAdapterDeviceFromMonitor(MonitorDeviceInfo monitorDeviceInfo)
        {
            var adapters = EnumerateVideoAdapterDevices();

           return adapters.SingleOrDefault(adapter => adapter.DisplayName == monitorDeviceInfo.DisplayName);
        }
    }
}
