using System;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Códigos de control.
    /// </summary>
    [Flags]
    public enum IoctlDiskControlCode : uint
    {
        /// <summary>
        /// Código base para los códigos de control de disco.
        /// </summary>
        IOCTL_DISK_BASE = DeviceType.Disk,

        /// <summary>
        /// Inicializa el disco especificado, y la tabla de particiones de disco con la información de la estructura CREATE_DISK.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365155%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_CREATE_DISK = (IOCTL_DISK_BASE << 16) | (0x0016 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Elimina la firma de arranque del registro de inicio maestro, por lo que el disco será formateado desde el sector cero hasta el final del disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365158%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_DELETE_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0040 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Da formato al conjunto de pistas (contiguo) especificadas, en un disco flexible.
        /// Para proporcionar parámetros adicionales, utilice <see cref="IOCTL_DISK_FORMAT_TRACKS_EX"/>.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365161%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_FORMAT_TRACKS = (IOCTL_DISK_BASE << 16) | (0x0006 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Da formato al conjunto de pistas (contiguo) especificadas, en un disco flexible.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365164%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_FORMAT_TRACKS_EX = (IOCTL_DISK_BASE << 16) | (0x000b << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Recupera los datos de configuración de caché de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365165%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_CACHE_INFORMATION = (IOCTL_DISK_BASE << 16) | (0x0035 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Recupera la información acerca de la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista y bytes por sector.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365169%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_GEOMETRY = (IOCTL_DISK_BASE << 16) | (0x0000 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera la información ampliada sobre la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista, y bytes por sector.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365171%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_GEOMETRY_EX = (IOCTL_DISK_BASE << 16) | (0x0028 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera información de todas las entradas de las tablas de partición de un disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365173%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0003 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Recupera la información ampliada para cada entrada en la tabla de particiones de un disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365174%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_LAYOUT_EX = (IOCTL_DISK_BASE << 16) | (0x0014 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera la longitud del disco especificado, el volumen o partición.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365178%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_LENGTH_INFO = (IOCTL_DISK_BASE << 16) | (0x0017 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Recupera información sobre el tipo, el tamaño y la naturaleza de una partición del disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365179%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_PARTITION_INFO = (IOCTL_DISK_BASE << 16) | (0x0001 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Recupera información adicional sobre el tipo, tamaño y naturaleza de una partición del disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365180%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GET_PARTITION_INFO_EX = (IOCTL_DISK_BASE << 16) | (0x0012 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Aumenta el tamaño de la partición especificada.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365181%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_GROW_PARTITION = (IOCTL_DISK_BASE << 16) | (0x0034 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Indica si el disco especificado es modificable.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365182%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_IS_WRITABLE = (IOCTL_DISK_BASE << 16) | (0x0009 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Habilita los contadores de rendimiento que proporcionan información de rendimiento de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365183%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_PERFORMANCE = (IOCTL_DISK_BASE << 16) | (0x0008 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Deshabilita los contadores de rendimiento que proporcionan información de rendimiento de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365184%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_PERFORMANCE_OFF = (IOCTL_DISK_BASE << 16) | (0x0018 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Dirige el dispositivo de disco para asignar uno o más bloques de recambio.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365185%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_REASSIGN_BLOCKS = (IOCTL_DISK_BASE << 16) | (0x0007 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Directs the disk device to map one or more blocks to its spare-block pool.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365186%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_REASSIGN_BLOCKS_EX = (IOCTL_DISK_BASE << 16) | (0x0029 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Clears all Volume Shadow Copy Service (VSS) hardware-based shadow copy (also called "snapshot") information from the disk.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ee450091%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_RESET_SNAPSHOT_INFO = (IOCTL_DISK_BASE << 16) | (0x0084 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Establece los datos de configuración del disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365187%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_SET_CACHE_INFORMATION = (IOCTL_DISK_BASE << 16) | (0x0036 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Particiones de un disco y datos de la partición.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365188%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_SET_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0004 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Particiones de un disco de acuerdo a la disposición de unidad especificada y la partición de datos de información.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365189%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_SET_DRIVE_LAYOUT_EX = (IOCTL_DISK_BASE << 16) | (0x0015 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Asigna información de partición para la partición de disco especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365190%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_SET_PARTITION_INFO = (IOCTL_DISK_BASE << 16) | (0x0002 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Establece la información de partición para la partición del disco especificado, incluyendo información de diseño de AT y EFI (Extensible Firmware Interface).
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365191%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_SET_PARTITION_INFO_EX = (IOCTL_DISK_BASE << 16) | (0x0013 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Invalida la tabla de particiones en caché y vuelve a enumerar el dispositivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365192%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_UPDATE_PROPERTIES = (IOCTL_DISK_BASE << 16) | (0x0050 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Verifica un disco duro.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365193%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_DISK_VERIFY = (IOCTL_DISK_BASE << 16) | (0x0005 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Devuelve las propiedades de un dispositivo de almacenamiento o el adaptador
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ff800830%28v=VS.85%29.aspx
        /// </remarks>            
        IOCTL_STORAGE_QUERY_PROPERTY = (IOCTL_DISK_BASE << 16) | (0x0500 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
    }
}