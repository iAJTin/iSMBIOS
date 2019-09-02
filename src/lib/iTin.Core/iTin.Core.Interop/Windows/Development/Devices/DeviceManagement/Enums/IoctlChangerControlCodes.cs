
namespace iTin.Core.Interop.Windows.Development.Devices.DeviceManagement
{
    using System;
    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Códigos de control.
    /// </summary>
    [Flags]
    public enum IoctlChangerControlCodes : uint
    {
        /// <summary>
        /// Código base para los códigos de control de dispositivos.
        /// </summary>
        IOCTL_CHANGER_BASE = DeviceType.Changer,

        /// <summary>
        /// Moves a piece of media from a source element to one destination, and the piece of media originally in the first destination to a second destination.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363392%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_EXCHANGE_MEDIUM = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0008 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera el estado de todos los elementos o un número determinado de elementos de un tipo particular.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363393%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_ELEMENT_STATUS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0005 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera los parámetros del dispositivo especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363394%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_PARAMETERS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0000 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera los datos del producto para el dispositivo especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363395%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_PRODUCT_DATA = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0002 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera el estado actual del dispositivo especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363396%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_GET_STATUS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0001 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Inicializa el estado de todos los elementos o los elementos especificados de un tipo particular.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363397%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0006 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Moves a piece of media to a destination.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363398%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_MOVE_MEDIUM = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0009 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Recupera la información de etiqueta de volumen para los elementos especificados.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363399%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_QUERY_VOLUME_TAGS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x000b << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Physically recalibrates a transport element.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363400%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_REINITIALIZE_TRANSPORT = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x000a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Establece el estado del puerto de inserción/expulsión del dispositivo, puerta o teclado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363401%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_SET_ACCESS = (IOCTL_CHANGER_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0004 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// Sets the changer's robotic transport mechanism to the specified element address.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa363402%28v=VS.85%29.aspx
        /// </remarks> 
        IOCTL_CHANGER_SET_POSITION = (IOCTL_CHANGER_BASE << 16) | (DeviceAccess.Read << 14) | (0x0007 << 2) | DeviceMethod.Buffered,
    }
}