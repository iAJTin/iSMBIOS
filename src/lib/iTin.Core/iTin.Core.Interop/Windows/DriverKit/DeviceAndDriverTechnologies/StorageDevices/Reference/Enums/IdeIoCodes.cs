
namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference
{
    using System;

    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Esta sección contiene información sobre las solicitudes de E / S para dispositivos IDE.
    /// </summary>
    [Flags]
    public enum IdeIoControlCode : uint
    {
        /// <summary>
        /// Allows an application to send almost any ATA command to a target device.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff559309%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_ATA_PASS_THROUGH = (Constants.IOCTL_SCSI_BASE << 16) | (0x040b << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Allows an application to send almost any ATA command to a target device.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff559315%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_ATA_PASS_THROUGH_DIRECT = (Constants.IOCTL_SCSI_BASE << 16) | (0x040c << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),        
    }
}