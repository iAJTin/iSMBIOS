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
    public enum FsctlFileControlCodes : uint
    {
        /// <summary>
        /// Código base para los códigos de control del sistema de archivos.
        /// </summary>
        FSCTL_FILE_BASE = DeviceType.FileSystem,

        /// <summary>
        /// Indica al conductor del sistema de archivos que no realiza ninguna comprobación de los límites de E/S en la partición de lectura o escritura.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364556%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_ALLOW_EXTENDED_DASD_IO = (FSCTL_FILE_BASE << 16) | (0x0020 << 2) | DeviceMethod.Neither |(DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera el identificador de objeto para el archivo o directorio especificado. Si no existe crea uno.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364557%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_CREATE_OR_GET_OBJECT_ID = (FSCTL_FILE_BASE << 16) | (0x0030 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Elimina el identificador de objeto de un archivo o directorio especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364559%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_DELETE_OBJECT_ID = (FSCTL_FILE_BASE << 16) | (0x0028 << 2) |  DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera la información de varios contadores de rendimiento del sistema de archivos.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364565%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_FILESYSTEM_GET_STATISTICS = (FSCTL_FILE_BASE << 16) | (0x0018 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Searches a directory for a file whose creator owner matches the specified SID.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364566%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_FIND_FILES_BY_SID = (FSCTL_FILE_BASE << 16) | (0x0023 << 2) | DeviceMethod.Neither | (DeviceAccess.Any << 14),

        /// <summary>
        /// Retrieves the current compression state of a file or directory on a volume whose file system supports per-stream compression.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364567%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_GET_COMPRESSION = (FSCTL_FILE_BASE << 16) | (0x000f << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera el registro del primer archivo que está en uso y es de un valor menor o igual al número ordinal de referencia a archivos solicitados.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364568%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_GET_NTFS_FILE_RECORD = (FSCTL_FILE_BASE << 16) | (0x001a << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera el identificador de objeto para el archivo o directorio especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364570%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_GET_OBJECT_ID = (FSCTL_FILE_BASE << 16) | (0x0027 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14) ,

        /// <summary>
        /// Recupera información sobre el mecanismo de auto-reparación del sistema de archivos NTFS.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964898%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_GET_REPAIR = (FSCTL_FILE_BASE << 16) | (0x0067 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Activa el sistema de archivos NTFS para iniciar un ciclo de auto-reparación en un solo archivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964899%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_INITIATE_REPAIR = (FSCTL_FILE_BASE << 16) | (0x006a << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Cierra una sesión abierta en UDF de una sola escritura para hacer la ROM multimedia compatible.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964900%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_MAKE_MEDIA_COMPATIBLE = (FSCTL_FILE_BASE << 16) | (0x004c << 2) | DeviceMethod.Buffered | (DeviceAccess.Write << 14),

        /// <summary>
        /// Notifica a un servidor que la aplicación cliente está dispuesto a cerrar un archivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364578%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_OPBATCH_ACK_CLOSE_PENDING = (FSCTL_FILE_BASE << 16) | (0x0004 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Responde a la notificación de que un bloqueo oportunista en un archivo está a punto de romperse.
        /// Utilice esta operación para desbloquear todos los bloqueos oportunistas en el archivo, pero mantener el archivo abierto
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364580%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_OPLOCK_BREAK_ACK_NO_2 = (FSCTL_FILE_BASE << 16) | (0x0014 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Responde a la notificación de que un bloqueo exclusivo oportunista en un archivo está a punto de romperse.
        /// Utilice esta operación para indicar que el archivo debe recibir un nivel 2 de bloqueo oportunista.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364579%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_OPLOCK_BREAK_ACKNOWLEDGE = (FSCTL_FILE_BASE << 16) | (0x0003 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Permite la aplicación que llama a esperar a la finalización de una interrupción del bloqueo oportunista.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364581%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_OPLOCK_BREAK_NOTIFY = (FSCTL_FILE_BASE << 16) | (0x0005 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Escanea un archivo o una secuencia alternativa en busca de los rangos que pueden contener datos distintos de cero.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364582%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_QUERY_ALLOCATED_RANGES = (FSCTL_FILE_BASE << 16) | (0x0033 << 2) | DeviceMethod.Neither | (DeviceAccess.Read << 14),

        /// <summary>
        /// Requests UDF-specific volume information.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964901%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_QUERY_ON_DISK_VOLUME_INFO = (FSCTL_FILE_BASE << 16) | (0x004f << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recupera las propiedades de gestión de defectos del volumen. Se utiliza para sistemas de archivos UDF.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964902%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_QUERY_SPARING_INFO = (FSCTL_FILE_BASE << 16) | (0x004e << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Recalls a file from storage media that Remote Storage manages, which is the hierarchical storage management software.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364587%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_RECALL_FILE = (FSCTL_FILE_BASE << 16) | (0x0045 << 2) | DeviceMethod.Neither | (DeviceAccess.Any << 14),

        /// <summary>
        /// Requests a batch opportunistic lock on a file.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364588%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_REQUEST_BATCH_OPLOCK = (FSCTL_FILE_BASE << 16) | (0x0002 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Solicita un bloqueo oportunista en un filtro de archivos.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364589%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_REQUEST_FILTER_OPLOCK = (FSCTL_FILE_BASE << 16) | (0x0017 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Requests an opportunistic lock (oplock) on a file and acknowledges that an oplock break has occurred
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/ee681828%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_REQUEST_OPLOCK = (FSCTL_FILE_BASE << 16) | (0x0090 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Solicita un nivel 1 de bloqueo oportunista en un archivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365155%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_REQUEST_OPLOCK_LEVEL_1 = (FSCTL_FILE_BASE << 16) | (0x0000 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Solicita un nivel 2 de bloqueo oportunista en un archivo.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364591%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_REQUEST_OPLOCK_LEVEL_2 = (FSCTL_FILE_BASE << 16) | (0x0001 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Sets the compression state of a file or directory on a volume whose file system supports per-file and per-directory compression.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364592%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_COMPRESSION = (FSCTL_FILE_BASE << 16) | (0x0010 << 2) | DeviceMethod.Buffered | ((DeviceAccess.Read | DeviceAccess.Write) << 14),

        /// <summary>
        /// Sets the software defect management state for the specified file. Used for UDF file systems.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964903%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_DEFECT_MANAGEMENT = (FSCTL_FILE_BASE << 16) | (0x004d << 2) | DeviceMethod.Buffered | (DeviceAccess.Write << 14),

        /// <summary>
        /// Establece el identificador de objeto para el archivo o directorio especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364593%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_OBJECT_ID = (FSCTL_FILE_BASE << 16) | (0x0026 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Modifica los datos de usuario asociado al identificador de objeto para el archivo o directorio especificado.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364594%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_OBJECT_ID_EXTENDED = (FSCTL_FILE_BASE << 16) | (0x002f << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Establece el modo de auto-reparación de un sistema de archivos NTFS.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964904%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_REPAIR = (FSCTL_FILE_BASE << 16) | (0x0066 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Marks the indicated file as sparse or not sparse. In a sparse file, large ranges of zeros may not require disk allocation.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364596%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_SPARSE = (FSCTL_FILE_BASE << 16) | (0x0031 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Rellena un rango específico de un archivo con ceros.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364597%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_ZERO_DATA = (FSCTL_FILE_BASE << 16) | (0x0032 << 2) | DeviceMethod.Buffered | (DeviceAccess.Write << 14),

        /// <summary>
        /// Indicates an NTFS file system file handle should have its clusters filled with zeros when it is deallocated.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964911%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_ZERO_ON_DEALLOCATION = 0,

        /// <summary>
        /// Indicates an NTFS file system file handle should have its clusters filled with zeros when it is deallocated.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964916%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_WAIT_FOR_REPAIR = 0,
    }
}

//FsctlLockVolume = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0006 << 2) | DeviceMethod.Buffered,
//FsctlUnlockVolume = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0007 << 2) | DeviceMethod.Buffered,
//FsctlDismountVolume = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0008 << 2) | DeviceMethod.Buffered,
//FsctlIsVolumeMounted = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x000a << 2) | DeviceMethod.Buffered,
//FsctlIsPathnameValid = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x000b << 2) | DeviceMethod.Buffered,
//FsctlMarkVolumeDirty = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x000c << 2) | DeviceMethod.Buffered,
//FsctlQueryRetrievalPointers = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x000e << 2) | DeviceMethod.Neither,
//FsctlMarkAsSystemHive = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0013 << 2) | DeviceMethod.Neither,
//FsctlInvalidateVolumes = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0015 << 2) | DeviceMethod.Buffered,
//FsctlQueryFatBpb = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0016 << 2) | DeviceMethod.Buffered,
//FsctlGetNtfsVolumeData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0019 << 2) | DeviceMethod.Buffered,
//FsctlGetVolumeBitmap = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x001b << 2) | DeviceMethod.Neither,
//FsctlGetRetrievalPointers = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x001c << 2) | DeviceMethod.Neither,
//FsctlMoveFile = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x001d << 2) | DeviceMethod.Buffered,
//FsctlIsVolumeDirty = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x001e << 2) | DeviceMethod.Buffered,
//FsctlGetHfsInformation = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x001f << 2) | DeviceMethod.Buffered,
//FsctlAllowExtendedDasdIo = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0020 << 2) | DeviceMethod.Neither,
//FsctlReadPropertyData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0021 << 2) | DeviceMethod.Neither,
//FsctlWritePropertyData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0022 << 2) | DeviceMethod.Neither,
//FsctlDumpPropertyData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0025 << 2) | DeviceMethod.Neither,
//FsctlDeleteReparsePoint = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x002b << 2) | DeviceMethod.Buffered,
//FsctlEnumUsnData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x002c << 2) | DeviceMethod.Neither,
//FsctlSecurityIdCheck = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Read << 14) | (0x002d << 2) | DeviceMethod.Neither,
//FsctlReadUsnJournal = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x002e << 2) | DeviceMethod.Neither,
//FsctlEnableUpgrade = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Write << 14) | (0x0034 << 2) | DeviceMethod.Buffered,
//FsctlSetEncryption = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0035 << 2) | DeviceMethod.Neither,
//FsctlEncryptionFsctlIo = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0036 << 2) | DeviceMethod.Neither,
//FsctlWriteRawEncrypted = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0037 << 2) | DeviceMethod.Neither,
//FsctlReadRawEncrypted = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0038 << 2) | DeviceMethod.Neither,
//FsctlCreateUsnJournal = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0039 << 2) | DeviceMethod.Neither,
//FsctlReadFileUsnData = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003a << 2) | DeviceMethod.Neither,
//FsctlWriteUsnCloseRecord = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003b << 2) | DeviceMethod.Neither,
//FsctlExtendVolume = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003c << 2) | DeviceMethod.Buffered,
//FsctlQueryUsnJournal = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003d << 2) | DeviceMethod.Buffered,
//FsctlDeleteUsnJournal = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003e << 2) | DeviceMethod.Buffered,
//FsctlMarkHandle = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x003f << 2) | DeviceMethod.Buffered,
//FsctlSisCopyFile = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Any << 14) | (0x0040 << 2) | DeviceMethod.Buffered,
//FsctlSisLinkFiles = (FSCTL_FILE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0041 << 2) | DeviceMethod.Buffered,
//FsctlHsmMsg = (FSCTL_FILE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0042 << 2) | DeviceMethod.Buffered,
//FsctlNssControl = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Write << 14) | (0x0043 << 2) | DeviceMethod.Buffered,
//FsctlHsmData = (FSCTL_FILE_BASE << 16) | ((DeviceAccess.Read | DeviceAccess.Write) << 14) | (0x0044 << 2) | DeviceMethod.Neither,
//FsctlNssRcontrol = (FSCTL_FILE_BASE << 16) | (DeviceAccess.Read << 14) | (0x0046 << 2) | DeviceMethod.Buffered,

