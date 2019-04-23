
namespace iTin.Core.Interop.Windows.Development.Devices.DeviceManagement
{
    using System;

    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Control codes.
    /// </summary>
    [Flags]
    public enum IoctlChangerControlCodes : uint
    {
        /// <summary>
        /// Base code for device control codes.
        /// </summary>
        IOCTL_CHANGER_BASE = DeviceType.Changer,

        /// <summary>
        /// Moves a piece of media from a source element to one destination, and the piece of media originally in the first destination to a second destination.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363392%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_EXCHANGE_MEDIUM = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0008 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieve the status of all elements or a certain number of elements of a particular type.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363393%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_ELEMENT_STATUS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0005 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieve the parameters of the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363394%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_PARAMETERS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0000 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves the product data for the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363395%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_PRODUCT_DATA = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0002 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves the current state of the specified device.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363396%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_STATUS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0001 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Initializes the status of all the elements or the specified elements of a particular type.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363397%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0006 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Moves a piece of media to a destination.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363398%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_MOVE_MEDIUM = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0009 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Retrieves the volume label information for the specified elements.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363399%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_QUERY_VOLUME_TAGS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x000b << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Physically recalibrates a transport element.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363400%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_REINITIALIZE_TRANSPORT = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x000a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Establece el estado del puerto de inserción/expulsión del dispositivo, puerta o teclado.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363401%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_SET_ACCESS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0004 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Sets the changer's robotic transport mechanism to the specified element address.
        /// </summary>
        /// <remarks>
        /// For more information, please see http://msdn.microsoft.com/en-us/library/aa363402%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_SET_POSITION = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0007 << 2) | DeviceMethod.Buffered,
    }
}
