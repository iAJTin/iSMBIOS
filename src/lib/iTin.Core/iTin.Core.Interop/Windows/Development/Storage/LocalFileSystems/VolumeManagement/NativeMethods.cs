
namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.VolumeManagement
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>  
    /// The highest level of organization in the file system is the volume.
    /// A file system resides on a volume.
    /// A volume contains at least one partition, which is a logical division of a physical disk (for more information, see Disk devices and partitions at http://msdn.microsoft.com/en-us/library/aa363966%28v=VS.85%29.aspx).
    /// A volume that contains the data that exists in a partition called a simple volume, and a volume
    /// which contains the data that exists in more than one partition called a volume of several partitions.
    /// </summary>
    public static class NativeMethods
    {
        #region Enums

        #region [public] {enum} FileSystemFlags: 
        [Flags]
        public enum FileSystemFlags : uint
        {
            /// <summary>
            /// The specified volume supports case-sensitive file names.
            /// </summary>
            FILE_CASE_SENSITIVE_SEARCH = 0x00000001,

            /// <summary>
            /// The specified volume supports preserved case of file names when it places a name on disk.
            /// </summary>
            FILE_CASE_PRESERVED_NAMES = 0x00000002,

            /// <summary>
            /// The specified volume preserves and enforces access control lists (ACL).
            /// For example, the NTFS file system preserves and enforces ACLs, and the FAT file system does not.
            /// </summary>
            FILE_PERSISTENT_ACLS = 0x00000008,

            /// <summary>
            /// The specified volume supports file-based compression.
            /// </summary>
            FILE_FILE_COMPRESSION = 0x00000010,

            /// <summary>
            /// The specified volume supports named streams.
            /// </summary>
            FILE_NAMED_STREAMS = 0x00040000,

            /// <summary>
            /// The specified volume is read-only.
            /// </summary>
            FILE_READ_ONLY_VOLUME = 0x00080000,

            /// <summary>
            /// The specified volume supports a single sequential write.
            /// </summary>
            FILE_SEQUENTIAL_WRITE_ONCE = 0x00100000,

            /// <summary>
            /// The specified volume supports the Encrypted File System (EFS).
            /// For more information, see File Encryption.
            /// </summary>
            FILE_SUPPORTS_ENCRYPTION = 0x00020000,

            /// <summary>
            /// The specified volume supports extended attributes.
            /// An extended attribute is a piece of application-specific metadata that an application can associate with a file and is not part of the file's data.
            /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  This value is not supported until Windows Server 2008 R2 and Windows 7.
            /// </summary>
            FILE_SUPPORTS_EXTENDED_ATTRIBUTES = 0x00800000,

            /// <summary>
            /// The specified volume supports hard links. 
            /// For more information, see Hard Links and Junctions.
            /// An extended attribute is a piece of application-specific metadata that an application can associate with a file and is not part of the file's data.
            /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  This value is not supported until Windows Server 2008 R2 and Windows 7.
            /// </summary>
            FILE_SUPPORTS_HARD_LINKS = 0x00400000,

            /// <summary>
            /// The specified volume supports object identifiers.
            /// For more information, see Hard Links and Junctions.
            /// </summary>
            FILE_SUPPORTS_OBJECT_IDS = 0x00010000,

            /// <summary>
            /// The file system supports open by FileID.
            /// For more information, see FILE_ID_BOTH_DIR_INFO.
            /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  This value is not supported until Windows Server 2008 R2 and Windows 7.
            /// </summary>
            FILE_SUPPORTS_OPEN_BY_FILE_ID = 0x01000000,

            /// <summary>
            /// The specified volume supports re-parse points.
            /// </summary>
            FILE_SUPPORTS_REPARSE_POINTS = 0x00000080,

            /// <summary>
            /// The specified volume supports sparse files.
            /// </summary>
            FILE_SUPPORTS_SPARSE_FILES = 0x00000040,

            /// <summary>
            /// The specified volume supports transactions.
            /// For more information, see About KTM.
            /// </summary>
            FILE_SUPPORTS_TRANSACTIONS = 0x00200000,

            /// <summary>
            /// The specified volume supports update sequence number (USN) journals.
            /// For more information, see Change Journal Records.
            /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  This value is not supported until Windows Server 2008 R2 and Windows 7.
            /// </summary>
            FILE_SUPPORTS_USN_JOURNAL = 0x02000000,

            /// <summary>
            /// The specified volume supports Unicode in file names as they appear on disk.
            /// For more information, see Change Journal Records.
            /// Windows Server 2008, Windows Vista, Windows Server 2003, and Windows XP:  This value is not supported until Windows Server 2008 R2 and Windows 7.
            /// </summary>
            FILE_UNICODE_ON_DISK = 0x00000004,

            /// <summary>
            /// The specified volume supports Unicode in file names as they appear on disk.
            /// The specified volume is a compressed volume, for example, a DoubleSpace volume.
            /// </summary>
            FILE_VOLUME_IS_COMPRESSED = 0x00008000,

            /// <summary>
            /// The specified volume supports disk quotas.
            /// </summary>
            FILE_VOLUME_QUOTAS = 0x00000020,
        }
        #endregion

        #endregion

        #region P/Invoke

        #region [public] {static} (extern} (long) GetDriveType(string): Determina si una unidad de disco es extraíble, fijo, CD-ROM, disco RAM, o unidad de red.
        /// <summary>
        /// Determina si una unidad de disco es extraíble, fijo, CD-ROM, disco RAM, o unidad de red.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa364939%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.Kernel32, SetLastError = true)]
        public static extern long GetDriveType(string driveLetter);
        #endregion

        #region [public] {static} (extern} (bool) GetVolumeInformation(string, StringBuilder, uint, [Out] uint, [Out] uint, [Out] FileSystemFlags, StringBuilder, uint): Recupera información sobre el sistema de archivos y el volumen asociado con el directorio raíz especificado.
        /// <summary>
        /// Recupera información sobre el sistema de archivos y el volumen asociado con el directorio raíz especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa364993%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.Kernel32, SetLastError = true)]
        public static extern bool GetVolumeInformation(string rootPathName, StringBuilder volumeNameBuffer, uint volumeNameSize, out uint volumeSerialNumber, out uint maximumComponentLength, out FileSystemFlags fileSystemFlags, StringBuilder fileSystemNameBuffer, uint fileSystemNameSize);
        #endregion

        #region [public] {static} (extern} (bool) GetVolumeInformation(string, IntPtr, uint, [Out] uint, [Out] uint, [Out] uint, IntPtr, uint): Recupera información sobre el sistema de archivos y el volumen asociado con el directorio raíz especificado.
        /// <summary>
        /// Recupera información sobre el sistema de archivos y el volumen asociado con el directorio raíz especificado.
        /// </summary>
        /// <remarks>
        /// Para más información, ver http://msdn.microsoft.com/en-us/library/aa364993%28v=VS.85%29.aspx
        /// </remarks>
        [DllImport(ExternDll.Win.Kernel32, SetLastError = true)]
        public static extern bool GetVolumeInformation(string rootPathName, IntPtr volumeNameBuffer, uint volumeNameSize, [Out] uint volumeSerialNumber, [Out] uint maximumComponentLength, [Out] uint fileSystemFlags, IntPtr fileSystemNameBuffer, uint fileSystemNameSize);
        #endregion

        #endregion
    }
}
