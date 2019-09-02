
namespace iTin.Core.Hardware.Interop
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    using DeviceInfo;

    using DeviceContext = Core.Interop.Windows.Development.Graphics.Legacy.Gdi.DeviceContext;
    using GdiPrint = Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint;

    /// <summary>
    /// Defines a set of Safe monitor native methods.
    /// </summary>
    public static class SafeVideoModeNativeMethods
    {
        #region public static methods

        #region [public] {static} (VideoModeDeviceInfo[]) EnumerateVideoModesFromAdapter(VideoAdapterDeviceInfo): Change the current video mode to the specified mode
        /// <summary>
        /// Array with the information of the video modes supported by a video adapter.
        /// </summary>
        /// <param name="videoAdapterInfo">Video adapter information.</param>
        /// <returns>
        /// Returns a <see cref="T:System.Array"/> of structures <see cref="VideoAdapterDeviceInfo"/> that contains the video modes supported by a video adapter.
        /// </returns>
        public static VideoModeDeviceInfo[] EnumerateVideoModesFromAdapter(VideoAdapterDeviceInfo videoAdapterInfo)
        {
            var videoModes = new Collection<VideoModeDeviceInfo>();
            var currentMode = GetCurrentVideoModeFromAdapter(videoAdapterInfo);

            for (int i = 0; ; i++)
            {
                var videoMode = GdiPrint.DEVMODE.Empty;
                var modeIsAvailable = DeviceContext.NativeMethods.EnumDisplaySettingsEx(videoAdapterInfo.DisplayName, i, ref videoMode, DeviceContext.NativeMethods.EnumDisplayFlags.EDS_NORMAL);

                if (!modeIsAvailable)
                {
                    break;
                }

                var apiModeInfo = new VideoModeDeviceInfo(videoMode);
                if (apiModeInfo == currentMode)
                {
                    apiModeInfo.SetCurrent(true);
                }

                videoModes.Add(apiModeInfo);
            }

            return (VideoModeDeviceInfo[])videoModes.ToArray().Clone();
        }
        #endregion

        #region [public] {static} (bool) ChangeVideoMode(VideoAdapterDeviceInfo, VideoModeDeviceInfo): Change the current video mode to the specified mode
        /// <summary>
        /// Change the current video mode to the specified mode.
        /// </summary>
        /// <param name="adapter">Video adapter information.</param>
        /// <param name="mode">New video mode.</param>
        /// <returns>
        /// <strong>true</strong> if the operation could be performed; <strong>false</strong> otherwise.
        /// </returns>
        public static bool ChangeVideoMode(VideoAdapterDeviceInfo adapter, VideoModeDeviceInfo mode)
        {
            const DeviceContext.NativeMethods.ChangeDisplaySettingsFlags flags = DeviceContext.NativeMethods.ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY | DeviceContext.NativeMethods.ChangeDisplaySettingsFlags.CDS_SET_PRIMARY;
            var result = ChangeVideoMode(adapter, mode, flags);
            return result == DeviceContext.NativeMethods.DISP_CHANGE.DISP_CHANGE_SUCCESSFUL;
        }
        #endregion

        #region [public] {static} (VideoModeDeviceInfo) GetCurrentVideoModeFromAdapter(VideoAdapterDeviceInfo): Returns a reference to the current video mode information for the specified device
        /// <summary>
        /// Returns a reference to the current video mode information for the specified device.
        /// </summary>
        /// <param name="videoAdapterData"> Video adapter information.</param>
        /// <returns>
        /// Returns a <see cref="VideoModeDeviceInfo"/> structure that contains the current video mode information.
        /// </returns>
        public static VideoModeDeviceInfo GetCurrentVideoModeFromAdapter(VideoAdapterDeviceInfo videoAdapterData)
        {
            var mode = GdiPrint.DEVMODE.Empty;
            DeviceContext.NativeMethods.EnumDisplaySettings(videoAdapterData.DisplayName, GdiPrint.DEVMODE.ENUM_CURRENT_SETTINGS, ref mode);

            return new VideoModeDeviceInfo(mode);
        }
        #endregion

        #region [public] {static} (bool) TestVideoMode(VideoAdapterDeviceInfo, VideoModeInfo): Check if this video mode is a valid video mode
        /// <summary>
        /// Check if this video mode is a valid video mode.
        /// </summary>
        /// <param name="adapter"> Video adapter information. </param>
        /// <param name="mode"> Video mode to check. </param>
        /// <returns>
        /// <strong>true</strong> if it is a valid video mode; <strong>false</strong> otherwise.
        /// </returns>
        public static bool TestVideoMode(VideoAdapterDeviceInfo adapter, VideoModeDeviceInfo mode)
        {
            var result = ChangeVideoMode(adapter, mode, DeviceContext.NativeMethods.ChangeDisplaySettingsFlags.CDS_TEST);

            return result == DeviceContext.NativeMethods.DISP_CHANGE.DISP_CHANGE_SUCCESSFUL;
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (DISP_CHANGE) ChangeVideoMode(VideoAdapterDeviceInfo, VideoModeInfo, DeviceContext.NativeMethods.ChangeDisplaySettingsFlags): Change the current video mode to the specified mode
        /// <summary>
        /// Change the current video mode to the specified mode.
        /// </summary>
        /// <param name="adapter">The adapter.</param>
        /// <param name="newVideoMode">New video mode.</param>
        /// <param name="flags">Status indicators for changing / testing a video mode.</param>
        /// <returns>
        /// One of the values in the <see cref="DeviceContext.NativeMethods.DISP_CHANGE"/> enumeration that indicates the status.
        /// </returns>
        private static DeviceContext.NativeMethods.DISP_CHANGE ChangeVideoMode(VideoAdapterDeviceInfo adapter, VideoModeDeviceInfo newVideoMode, DeviceContext.NativeMethods.ChangeDisplaySettingsFlags flags)
        {
            var devMode = GdiPrint.DEVMODE.Empty;

            devMode.dmFields = GdiPrint.DEVMODE.DM.Position | GdiPrint.DEVMODE.DM.PelsWidth | GdiPrint.DEVMODE.DM.PelsHeight | GdiPrint.DEVMODE.DM.DisplayFlags | GdiPrint.DEVMODE.DM.BitsPerPixel | GdiPrint.DEVMODE.DM.DisplayFrequency;
            devMode.dmPelsWidth = newVideoMode.Size.Width;
            devMode.dmPelsHeight = newVideoMode.Size.Height;
            devMode.dmPosition.X = newVideoMode.Location.X;
            devMode.dmPosition.Y = newVideoMode.Location.Y;
            devMode.dmBitsPerPel = newVideoMode.BitsPerPixel;
            devMode.dmDisplayFrequency = newVideoMode.Frequency;

            return DeviceContext.NativeMethods.ChangeDisplaySettingsEx(adapter.DisplayName, ref devMode, IntPtr.Zero, (int)flags, IntPtr.Zero);
        }
        #endregion

        #endregion
    }
}
