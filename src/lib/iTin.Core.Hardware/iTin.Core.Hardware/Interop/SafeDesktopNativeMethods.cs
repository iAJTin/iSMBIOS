
namespace iTin.Core.Hardware.Interop
{
    using System;
    using System.Drawing;

    using iTin.Core.Interop.Windows;

    using DeviceInfo;

    using Gdi = Core.Interop.Windows.Development.Graphics.Legacy.Gdi;
    using GdiPrint = Core.Interop.Windows.Development.DocumentAndPrinting.Printing.GdiPrint;
    using UserInterfaceConfiguration = Core.Interop.Windows.Development.UI.WindowsAndMessages.Configuration;

    /// <summary>
    /// Defines a set of safe desktop native methods.
    /// </summary>
    public static class SafeDesktopNativeMethods
    {
        #region public static members

        #region [public] {static} (DesktopDeviceInfo) GetDesktopInfoFromMonitor(MonitorDeviceInfo): Gets the desktop information associated with the specified monitor
        /// <summary>
        /// Gets the desktop information associated with the specified monitor.
        /// </summary>
        /// <param name="monitorDevice">Monitor information.</param>
        /// <returns>
        /// Returns a <see cref="DesktopDeviceInfo"/> structure that contains the desktop information associated with the specified monitor.
        /// </returns>
        public static DesktopDeviceInfo GetDesktopInfoFromMonitor(MonitorDeviceInfo monitorDevice) => GetDesktopInfoFromDisplay(monitorDevice.DisplayName);
        #endregion

        #region [public] {static} (DesktopDeviceInfo) GetDesktopInfoFromDisplay(string): Get the desktop information associated with the specified screen.
        /// <summary>
        /// Get the desktop information associated with the specified screen.
        /// </summary>
        /// <param name="displayName">Device identifier.</param>
        /// <returns>
        /// Returns a <see cref="DesktopDeviceInfo"/> structure that contains the desktop information associated with the specified screen.
        /// </returns>
        public static DesktopDeviceInfo GetDesktopInfoFromDisplay(string displayName)
        {
            var emptyDevMode = GdiPrint.DEVMODE.Empty;

            return PopulatesDesktopInfo(
                displayName,
                Gdi.DeviceContext.NativeMethods.CreateDC(
                    displayName,
                    null,
                    null, ref emptyDevMode));
        }
        #endregion

        #endregion

        #region private static members

        private static string GetDesktopWallPaper()
        {
            var result = string.Empty;

            var currentWallpaper = new string('\0', Constants.MAX_PATH);
            bool success =
                UserInterfaceConfiguration.NativeMethods.SystemParametersInfo(
                    UserInterfaceConfiguration.NativeMethods.SPI.GetDeskWallPaper,
                    (uint) currentWallpaper.Length, currentWallpaper,
                    UserInterfaceConfiguration.NativeMethods.SPIF.Zero);
            if (success)
            {
                result = currentWallpaper.Substring(0, currentWallpaper.IndexOf('\0'));
            }

            return result;
        }

        private static DesktopDeviceInfo PopulatesDesktopInfo(string displayName, IntPtr dc)
        {
            var desktopInfo = new DesktopDeviceInfo
            {
                DeviceName = displayName,
                ColorDepth = Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.BITSPIXEL),
                ColorPlanes = Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.PLANES),
                FontResolution = new Size(Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.LOGPIXELSX), Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.LOGPIXELSY)),
                PixelDiagonal = Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.ASPECTXY),
                PixelSize = new Size(Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.ASPECTX), Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.ASPECTY)),
                Resolution = new Size(Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.DESKTOPHORZRES), Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.DESKTOPVERTRES)),
                Technology = (DesktopDeviceInfo.Technologies)Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.TECHNOLOGY),
                VerticalRefreshRate = Gdi.DeviceContext.NativeMethods.GetDeviceCaps(dc, Gdi.DeviceContext.NativeMethods.DeviceCap.VREFRESH),
                DesktopWallpaper = GetDesktopWallPaper()
            };

            Gdi.DeviceContext.NativeMethods.DeleteDC(dc);

            return desktopInfo;
        }

        #endregion
    }
}
