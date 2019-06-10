
namespace iTin.Core.Interop.Windows
{
    internal static class Constants
    {
        public const int MAX_PATH = 260;

        /// <summary>
        /// Código base para los códigos de control de dispositivos.
        /// </summary>
        public const uint IOCTL_DISK_BASE = (uint)DeviceType.Disk;

        /// <summary>
        /// Código base para los códigos de control de dispositivos de almacenamiento.
        /// </summary>
        public const uint IOCTL_SCSI_BASE = (uint)DeviceType.Controller;
    }
}