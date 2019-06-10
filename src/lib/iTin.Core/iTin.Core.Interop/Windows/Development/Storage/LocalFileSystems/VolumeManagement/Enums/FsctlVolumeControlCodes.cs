using System;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.VolumeManagement
{
    // -------------------------------------------------------------------------------
    // | Control Code Format = (type << 16) | function << 2 | method | access << 14) |
    // -------------------------------------------------------------------------------

    /// <summary>
    /// Códigos de control.
    /// </summary>
    [Flags]
    public enum FsctlVolumeControlCodes : uint
    {
        /// <summary>
        /// Código base para los códigos de control del sistema de archivos.
        /// </summary>
        FSCTL_FILE_BASE = DeviceType.FileSystem,

        /// <summary>
        /// Indicates an NTFS file system file handle should have its clusters filled with zeros when it is deallocated.
        /// </summary>
        /// <remarks>
        /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa964916%28v=VS.85%29.aspx
        /// </remarks>            
        FSCTL_WAIT_FOR_REPAIR = 0,
    }
}
