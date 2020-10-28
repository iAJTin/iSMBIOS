
namespace iTin.Core.Interop.Shared.Windows
{
    /// <summary>
    /// Defines known constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Max path lenght.
        /// </summary>
        public const int MAX_PATH = 260;

        /// <summary>
        /// Base code for device control codes.
        /// </summary>
        public const uint IOCTL_DISK_BASE = (uint)DeviceType.Disk;

        /// <summary>
        /// Base code for storage device control codes.
        /// </summary>
        public const uint IOCTL_SCSI_BASE = (uint)DeviceType.Controller;
    }
}