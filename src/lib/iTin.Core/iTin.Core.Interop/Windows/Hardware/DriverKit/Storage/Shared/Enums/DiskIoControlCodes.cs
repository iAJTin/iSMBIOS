
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage
{
    using System;

    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Códigos de control.
    /// </summary>
    [Flags]
    public enum DiskIoControlCode : uint
    {
        /// <summary>
        /// Returns version information, capabilities, and a bit mask for the device.
        /// This IOCTL must be managed by drivers who support supervision, analysis and Information Technology (SMART).
        /// </summary>
        /// <remarks>
        /// For more information, see https://docs.microsoft.com/en-us/previous-versions/windows/hardware/drivers/ff566202(v=vs.85).
        /// </remarks>
        SMART_GET_VERSION = (Constants.IOCTL_DISK_BASE << 16) | (0x0020 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Returns the ATA-2 identify data, the Self-Monitoring Analysis and Reporting Technology (SMART) thresholds, or the SMART attributes for the device.
        /// This IOCTL must be handled by drivers that support SMART.
        /// </summary>
        /// <remarks>
        /// For more information, see https://docs.microsoft.com/en-us/previous-versions/windows/hardware/drivers/ff566204(v=vs.85).
        /// </remarks> 
        SMART_RCV_DRIVE_DATA = (Constants.IOCTL_DISK_BASE << 16) | (0x0022 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Sends one of the following Self-Monitoring Analysis and Reporting Technology (SMART) commands to the device:
        /// Enable or disable reporting on the device
        /// Enable or disable autosaving of attributes
        /// Save current attributes now
        /// Execute offline diagnostics
        /// Get current SMART status
        /// Write to SMART log
        /// This IOCTL must be handled by drivers that support SMART.
        /// </summary>
        /// <remarks>
        /// For more information, see https://docs.microsoft.com/en-us/previous-versions/windows/hardware/drivers/ff566206(v=vs.85).
        /// </remarks> 
        SMART_SEND_DRIVE_COMMAND = (Constants.IOCTL_DISK_BASE << 16) | (0x0021 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),
    }
}
