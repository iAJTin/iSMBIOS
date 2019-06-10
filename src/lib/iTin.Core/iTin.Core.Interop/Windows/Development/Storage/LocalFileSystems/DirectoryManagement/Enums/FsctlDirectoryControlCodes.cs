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
    public enum FsctlDirectoryControlCodes : uint
    {
        /// <summary>
        /// Código base para los códigos de control del sistema de archivos.
        /// </summary>
        FSCTL_FILE_BASE = DeviceType.FileSystem,

        /// <summary>
        /// Deletes a reparse point from the specified file or directory.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364560%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_DELETE_REPARSE_POINT = (FSCTL_FILE_BASE << 16) | (0x002b << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Retrieves the reparse point data associated with the file or directory identified by the specified handle.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364571%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_GET_REPARSE_POINT = (FSCTL_FILE_BASE << 16) | (0x002a << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),

        /// <summary>
        /// Sets a reparse point on a file or directory.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa364595%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_SET_REPARSE_POINT = (FSCTL_FILE_BASE << 16) | (0x0029 << 2) | DeviceMethod.Buffered | (DeviceAccess.Any << 14),
    }
}