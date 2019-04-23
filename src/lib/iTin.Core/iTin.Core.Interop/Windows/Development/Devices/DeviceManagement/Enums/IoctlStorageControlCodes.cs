
namespace iTin.Core.Interop.Windows.Development.Devices.DeviceManagement
{
    using System;

    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Control codes
    /// </summary>
    [Flags]
    public enum IoctlStorageControlCodes : uint
    {
        /// <summary>
        /// Base code for device control codes.
        /// </summary>
        IOCTL_STORAGE_BASE = DeviceType.MassStorage,

        /// <summary>
        /// Change control of a removable device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363404%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_CHECK_VERIFY = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0200 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// It ejects media from a SCSI device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363406%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_EJECT_MEDIA = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0202 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Activates or deactivates the mechanism that ejects the media.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363405%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_EJECTION_CONTROL = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0250 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves the device type, device number and if it has partitions, the number of partitions.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/bb968800%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_GET_DEVICE_NUMBER = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0420 << 2) | DeviceMethod.Buffered,

        /// <summary>
        ///	Retrieve the 'hotplug' configuration of the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363408%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_GET_HOTPLUG_INFO = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0305 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieve the serial number of a USB device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363411%28v=VS.85%29.aspx.
        /// </remarks>
        IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0304 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera la información de la geometría del dispositivo.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363412%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_GET_MEDIA_TYPES = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0300 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves information about the types of media supported by a device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363413%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_GET_MEDIA_TYPES_EX = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0301 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Load the media into the specified device.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363413%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_LOAD_MEDIA = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0203 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Communicates trimming attribute information to the device if it is compatible with the device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/ee907417%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Write << 14) | (0x0501 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Enables or disables media change notification.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363415%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_MCN_CONTROL = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0251 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Activates or deactivates the disc ejection mechanism.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363416%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_MEDIA_REMOVAL = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0201 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves the geometry information for the device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363417%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_READ_CAPACITY = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0450 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Sets the hot-plug configuration of the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363418%28v=VS.85%29.aspx.
        /// </remarks> 
        IOCTL_STORAGE_SET_HOTPLUG_INFO = (IOCTL_STORAGE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0306 << 2) | DeviceMethod.Buffered,
    }
}
 
//StorageCheckVerify2 = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0200 << 2) | DeviceMethod.Buffered,
//StorageLoadMedia2 = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0203 << 2) | DeviceMethod.Buffered,
//StorageReserve = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0204 << 2) | DeviceMethod.Buffered,
//StorageRelease = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0205 << 2) | DeviceMethod.Buffered,
//StorageFindNewDevices = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0206 << 2) | DeviceMethod.Buffered,
//StorageResetBus = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0400 << 2) | DeviceMethod.Buffered,
//StorageResetDevice = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0401 << 2) | DeviceMethod.Buffered,
//StoragePredictFailure = (IOCTL_STORAGE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0440 << 2) | DeviceMethod.Buffered,
//StorageObsoleteResetBus = (IOCTL_STORAGE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0400 << 2) | DeviceMethod.Buffered,
//StorageObsoleteResetDevice = (IOCTL_STORAGE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0401 << 2) | DeviceMethod.Buffered,
