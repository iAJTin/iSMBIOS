
namespace iTin.Core.Interop.Shared.Windows
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum DeviceControlCode : uint
    {
        //#region Storage.
        //StorageBase = DeviceType.MassStorage,
        //StorageCheckVerify =         (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0200 << 2) | DeviceMethod.Buffered,
        //StorageCheckVerify2 =        (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0200 << 2) | DeviceMethod.Buffered, 
        //StorageMediaRemoval =        (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0201 << 2) | DeviceMethod.Buffered,
        //StorageEjectMedia =          (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0202 << 2) | DeviceMethod.Buffered,
        //StorageLoadMedia =           (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0203 << 2) | DeviceMethod.Buffered,
        //StorageLoadMedia2 =          (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0203 << 2) | DeviceMethod.Buffered,
        //StorageReserve =             (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0204 << 2) | DeviceMethod.Buffered,
        //StorageRelease =             (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0205 << 2) | DeviceMethod.Buffered,
        //StorageFindNewDevices =      (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0206 << 2) | DeviceMethod.Buffered,
        //StorageEjectionControl =     (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0250 << 2) | DeviceMethod.Buffered,
        //StorageMcnControl =          (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0251 << 2) | DeviceMethod.Buffered,
        //StorageGetMediaTypes =       (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0300 << 2) | DeviceMethod.Buffered,
        //StorageGetMediaTypesEx =     (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0301 << 2) | DeviceMethod.Buffered,
        //StorageResetBus =            (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0400 << 2) | DeviceMethod.Buffered,
        //StorageResetDevice =         (StorageBase << 16) | (DeviceAccess.Read << 14)                        | (0x0401 << 2) | DeviceMethod.Buffered,
        //StorageGetDeviceNumber =     (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0420 << 2) | DeviceMethod.Buffered,
        //StoragePredictFailure =      (StorageBase << 16) | (DeviceAccess.Any << 14)                         | (0x0440 << 2) | DeviceMethod.Buffered,
        //StorageObsoleteResetBus =    (StorageBase << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0400 << 2) | DeviceMethod.Buffered,
        //StorageObsoleteResetDevice = (StorageBase << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0401 << 2) | DeviceMethod.Buffered,
        //#endregion

        #region  IoControlCode values for disk devices.

        #region All _WIN32
        /// <summary>
        /// Código base para los códigos de control de disco.
        /// </summary>
        IOCTL_DISK_BASE = DeviceType.Disk,

        /// <summary>
        /// Recupera la información acerca de la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista y bytes por sector.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365171
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_GEOMETRY = (IOCTL_DISK_BASE << 16) | (0x0000 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera información sobre el tipo, el tamaño y la naturaleza de una partición del disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365179
        /// </remarks>            
        IOCTL_DISK_GET_PARTITION_INFO = (IOCTL_DISK_BASE << 16) | (0x0001 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Asigna información de partición para la partición de disco especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365190
        /// </remarks>            
        IOCTL_DISK_SET_PARTITION_INFO = (IOCTL_DISK_BASE << 16) | (0x0002 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Recupera información de todas las entradas de las tablas de partición de un disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa363979
        /// </remarks>            
        IOCTL_DISK_GET_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0003 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Particiones de un disco y datos de la partición.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365188
        /// </remarks>            
        IOCTL_DISK_SET_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0004 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Verifica un disco duro.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365193
        /// </remarks>            
        IOCTL_DISK_VERIFY = (IOCTL_DISK_BASE << 16) | (0x0005 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Da formato al conjunto de pistas (contiguo) especificadas, en un disco flexible.
        /// Para proporcionar parámetros adicionales, utilice <see cref="IOCTL_DISK_FORMAT_TRACKS_EX"/>.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365161
        /// </remarks>            
        IOCTL_DISK_FORMAT_TRACKS = (IOCTL_DISK_BASE << 16) | (0x0006 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),


        /// <summary>
        /// Dirige el dispositivo de disco para asignar uno o más bloques de recambio.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365185
        /// </remarks>            
        IOCTL_DISK_REASSIGN_BLOCKS = (IOCTL_DISK_BASE << 16) | (0x0007 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Habilita los contadores de rendimiento que proporcionan información de rendimiento de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365183
        /// </remarks>            
        IOCTL_DISK_PERFORMANCE = (IOCTL_DISK_BASE << 16) | (0x0008 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Indica si el disco especificado es modificable.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365182
        /// </remarks>            
        IOCTL_DISK_IS_WRITABLE = (IOCTL_DISK_BASE << 16) | (0x0009 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_LOGGING = (IOCTL_DISK_BASE << 16) | (0x000a << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Da formato al conjunto de pistas (contiguo) especificadas, en un disco flexible.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365164
        /// </remarks>            
        IOCTL_DISK_FORMAT_TRACKS_EX = (IOCTL_DISK_BASE << 16) | (0x000b << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_HISTOGRAM_STRUCTURE = (IOCTL_DISK_BASE << 16) | (0x000c << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_HISTOGRAM_DATA = (IOCTL_DISK_BASE << 16) | (0x000d << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_HISTOGRAM_RESET = (IOCTL_DISK_BASE << 16) | (0x000e << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_REQUEST_STRUCTURE = (IOCTL_DISK_BASE << 16) | (0x000f << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_REQUEST_DATA = (IOCTL_DISK_BASE << 16) | (0x0010 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Deshabilita los contadores de rendimiento que proporcionan información de rendimiento de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365184
        /// </remarks>            
        IOCTL_DISK_PERFORMANCE_OFF = (IOCTL_DISK_BASE << 16) | (0x0018 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
        #endregion

        #region _WIN32_WINNT >= 0x0400.

        /// <summary>
        /// Código obsoleto.
        /// </summary>
        IOCTL_DISK_CONTROLLER_NUMBER = (IOCTL_DISK_BASE << 16) | (0x0011 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        #region  IOCTL support for SMART drive fault prediction.
        /// <summary>
        /// Devuelve información sobre la versión, capacidades y una máscara de bits para el dispositivo.
        /// Este IOCTL debe ser manejada por controladores compatibles con análisis de autocontrol y tecnología de generación de informes (SMART).
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ff566202%28v=VS.85%29.aspx
        /// </remarks>            
        SMART_GET_VERSION = (IOCTL_DISK_BASE << 16) | (0x0020 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Envía al dispositivo uno de los siguientes comandos SMART
        /// · Enable or disable reporting on the device
        /// · Enable or disable autosaving of attributes
        /// · Save current attributes now
        /// · Execute offline diagnostics
        /// · Get current SMART status
        /// · Write to SMART log
        /// This IOCTL must be handled by drivers that support SMART.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ff566206%28v=VS.85%29.aspx
        /// </remarks>            
        SMART_SEND_DRIVE_COMMAND = (IOCTL_DISK_BASE << 16) | (0x0021 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Devuelve el identifica datos ATA-2, atributos SMART para el dispositivo.
        /// Este IOCTL debe ser manejada por controladores compatibles con SMART.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ff566204%28v=VS.85%29.aspx
        /// </remarks>            
        SMART_RCV_DRIVE_DATA = (IOCTL_DISK_BASE << 16) | (0x0022 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),
        #endregion

        #endregion

        #region _WIN32_WINNT >= 0x0500.

        #region  New IOCTLs for GUID Partition tabled disks. 
        /// <summary>
        /// Recupera información extendida sobre el tipo, el tamaño y la naturaleza de una partición de disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365180
        /// </remarks>
        IOCTL_DISK_GET_PARTITION_INFO_EX = (IOCTL_DISK_BASE << 16) | (0x0012 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Establece la información de partición para la partición del disco especificado, incluyendo información de diseño de particiones AT y EFI (Extensible Firmware Interface).
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365174%28v=VS.85%29.aspx
        /// </remarks>
        IOCTL_DISK_SET_PARTITION_INFO_EX = (IOCTL_DISK_BASE << 16) | (0x0013 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Recupera la información extendida para cada entrada en las tablas de particiones de un disco.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365191
        /// </remarks>
        IOCTL_DISK_GET_DRIVE_LAYOUT_EX = (IOCTL_DISK_BASE << 16) | (0x0014 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Establece las particiones de un disco de acuerdo a los datos de información de diseño y partición de unidad especificada.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365189
        /// </remarks>
        IOCTL_DISK_SET_DRIVE_LAYOUT_EX = (IOCTL_DISK_BASE << 16) | (0x0015 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Inicializa el disco especificado y la tabla de particiones de disco con la información de la estructura CREATE_DISK.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365155
        /// </remarks>
        IOCTL_DISK_CREATE_DISK = (IOCTL_DISK_BASE << 16) | (0x0016 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Recupera la longitud del disco, volumen o partición especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365178
        /// </remarks>
        IOCTL_DISK_GET_LENGTH_INFO = (IOCTL_DISK_BASE << 16) | (0x0017 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// Recupera información extendida de la geometría del disco físico: tipo, número de cilindros, pistas por cilindro, sectores por pista y bytes por sector.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365171
        /// </remarks>
        IOCTL_DISK_GET_DRIVE_GEOMETRY_EX = (IOCTL_DISK_BASE << 16) | (0x0028 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
        #endregion


        /// <summary>
        /// IOCTL_DISK_UPDATE_DRIVE_SIZE
        /// </summary>
        IOCTL_DISK_UPDATE_DRIVE_SIZE = (IOCTL_DISK_BASE << 16) | (0x0032 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Amplía la partición especificada.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365181
        /// </remarks>
        IOCTL_DISK_GROW_PARTITION = (IOCTL_DISK_BASE << 16) | (0x0034 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_GET_CACHE_INFORMATION = (IOCTL_DISK_BASE << 16) | (0x0035 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_SET_CACHE_INFORMATION = (IOCTL_DISK_BASE << 16) | (0x0036 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_GET_WRITE_CACHE_STATE = (IOCTL_DISK_BASE << 16) | (0x0037 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_DELETE_DRIVE_LAYOUT = (IOCTL_DISK_BASE << 16) | (0x0040 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        // Called to flush cached information that the driver may have about this
        // device's characteristics.  Not all drivers cache characteristics, and not
        // cached properties can be flushed.  This simply serves as an update to the
        // driver that it may want to do an expensive reexamination of the device's
        // characteristics now (fixed media size, partition table, etc...)        
        /// <summary>
        /// Invalida la tabla de particiones en caché y re-enumera el dispositivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/es-es/library/aa365192
        /// </remarks>
        IOCTL_DISK_UPDATE_PROPERTIES = (IOCTL_DISK_BASE << 16) | (0x0050 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        #region Special IOCTLs needed to support PC-98 machines in Japan

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_FORMAT_DRIVE = (IOCTL_DISK_BASE << 16) | (0x00f3 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_SENSE_DEVICE = (IOCTL_DISK_BASE << 16) | (0x00f8 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
        #endregion

        #endregion

        #region Internal disk driver device controls to maintain the verify status bit for the device object.

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_INTERNAL_SET_VERIFY = (IOCTL_DISK_BASE << 16) | (0x0100 << 2) | DeviceMethod.Neither | (DeviceAccess.Any << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_INTERNAL_CLEAR_VERIFY = (IOCTL_DISK_BASE << 16) | (0x0101 << 2) | DeviceMethod.Neither | (DeviceAccess.Any << 14),

        /// <summary>
        /// Internal disk driver device control to set notification routine for the device object. Used in DiskPerf.
        /// </summary>
        IOCTL_DISK_INTERNAL_SET_NOTIFY = (IOCTL_DISK_BASE << 16) | (0x0102 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        #endregion

        #region The following device control codes are common for all class drivers. The functions codes defined here must match all of the other class drivers.
        // Warning: these codes will be replaced in the future by equivalent IOCTL_STORAGE codes.
        
        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_CHECK_VERIFY = (IOCTL_DISK_BASE << 16) | (0x0200 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),
        
        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_MEDIA_REMOVAL = (IOCTL_DISK_BASE << 16) | (0x0201 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_EJECT_MEDIA = (IOCTL_DISK_BASE << 16) | (0x0202 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),
        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_LOAD_MEDIA = (IOCTL_DISK_BASE << 16) | (0x0203 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_RESERVE = (IOCTL_DISK_BASE << 16) | (0x0204 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_RELEASE = (IOCTL_DISK_BASE << 16) | (0x0205 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_FIND_NEW_DEVICES = (IOCTL_DISK_BASE << 16) | (0x0206 << 2) | DeviceMethod.Buffered | (DeviceAccess.Read << 14),

        /// <summary>
        /// 
        /// </summary>
        IOCTL_DISK_GET_MEDIA_TYPES = (IOCTL_DISK_BASE << 16) | (0x0300 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
        #endregion

        #endregion

        #region Changer
        /// <summary>
        /// 
        /// </summary>
        ChangerBase = DeviceType.Changer,

        /// <summary>
        /// 
        /// </summary>
        ChangerGetParameters = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0000 << 2) | DeviceMethod.Buffered,
        
        /// <summary>
        /// 
        /// </summary>
        ChangerGetStatus = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0001 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerGetProductData = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0002 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerSetAccess = (ChangerBase << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0004 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerGetElementStatus = (ChangerBase << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0005 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerInitializeElementStatus = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0006 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerSetPosition = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0007 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerExchangeMedium = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0008 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerMoveMedium = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x0009 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerReinitializeTarget = (ChangerBase << 16) | (DeviceAccess.Read << 14) | (0x000a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        ChangerQueryVolumeTags = (ChangerBase << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x000b << 2) | DeviceMethod.Buffered,
        #endregion

        #region FileSystem.

        /// <summary>
        /// 
        /// </summary>
        FSCTL_REQUEST_OPLOCK_LEVEL_1 = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0000 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlRequestOplockLevel2 = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0001 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlRequestBatchOplock = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0002 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlOplockBreakAcknowledge = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0003 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlOpBatchAckClosePending = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0004 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlOplockBreakNotify = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0005 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlLockVolume = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0006 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlUnlockVolume = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0007 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlDismountVolume = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0008 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlIsVolumeMounted = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x000a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlIsPathnameValid = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x000b << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlMarkVolumeDirty = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x000c << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlQueryRetrievalPointers = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x000e << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetCompression = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x000f << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetCompression = (DeviceType.FileSystem << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0010 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlMarkAsSystemHive = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0013 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlOplockBreakAckNo2 = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0014 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlInvalidateVolumes = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0015 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlQueryFatBpb = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0016 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlRequestFilterOplock = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0017 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlFileSystemGetStatistics = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0018 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetNtfsVolumeData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0019 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetNtfsFileRecord = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetVolumeBitmap = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001b << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetRetrievalPointers = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001c << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlMoveFile = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001d << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlIsVolumeDirty = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001e << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetHfsInformation = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x001f << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlAllowExtendedDasdIo = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0020 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlReadPropertyData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0021 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlWritePropertyData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0022 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlFindFilesBySid = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0023 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlDumpPropertyData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0025 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetObjectId = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0026 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetObjectId = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0027 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlDeleteObjectId = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0028 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetReparsePoint = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0029 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlGetReparsePoint = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x002a << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlDeleteReparsePoint = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x002b << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlEnumUsnData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x002c << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlSecurityIdCheck = (DeviceType.FileSystem << 16) | (DeviceAccess.Read << 14) | (0x002d << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlReadUsnJournal = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x002e << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetObjectIdExtended = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x002f << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlCreateOrGetObjectId = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0030 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetSparse = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0031 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetZeroData = (DeviceType.FileSystem << 16) | (DeviceAccess.Write << 14) | (0x0032 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlQueryAllocatedRanges = (DeviceType.FileSystem << 16) | (DeviceAccess.Read << 14) | (0x0033 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlEnableUpgrade = (DeviceType.FileSystem << 16) | (DeviceAccess.Write << 14) | (0x0034 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSetEncryption = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0035 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlEncryptionFsctlIo = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0036 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlWriteRawEncrypted = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0037 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlReadRawEncrypted = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0038 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlCreateUsnJournal = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0039 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlReadFileUsnData = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003a << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlWriteUsnCloseRecord = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003b << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlExtendVolume = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003c << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlQueryUsnJournal = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003d << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlDeleteUsnJournal = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003e << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlMarkHandle = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x003f << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSisCopyFile = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0040 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlSisLinkFiles = (DeviceType.FileSystem << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0041 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlHsmMsg = (DeviceType.FileSystem << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0042 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlNssControl = (DeviceType.FileSystem << 16) | (DeviceAccess.Write << 14) | (0x0043 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        FsctlHsmData = (DeviceType.FileSystem << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0044 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlRecallFile = (DeviceType.FileSystem << 16) | (DeviceAccess.Any << 14) | (0x0045 << 2) | DeviceMethod.Neither,

        /// <summary>
        /// 
        /// </summary>
        FsctlNssRcontrol = (DeviceType.FileSystem << 16) | (DeviceAccess.Read << 14) | (0x0046 << 2) | DeviceMethod.Buffered,

        #endregion

        #region Video

        /// <summary>
        /// 
        /// </summary>
        VideoQuerySupportedBrightness = (DeviceType.Video << 16) | (DeviceAccess.Any << 14) | (0x0125 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        VideoQueryDisplayBrightness = (DeviceType.Video << 16) | (DeviceAccess.Any << 14) | (0x0126 << 2) | DeviceMethod.Buffered,

        /// <summary>
        /// 
        /// </summary>
        VideoSetDisplayBrightness = (DeviceType.Video << 16) | (DeviceAccess.Any << 14) | (0x0127 << 2) | DeviceMethod.Buffered,

        #endregion
    }
}