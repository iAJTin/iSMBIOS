using System.Diagnostics.CodeAnalysis;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Representa los tipos de partición válidos utilizados por los controladores de disco.
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa363990%28v=VS.85%29.aspx
    /// </remarks>
    public enum PARTITION_TYPE : byte
    {
        /// <summary>
        /// Partición no utilizada.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UNUSED")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ENTRY")]
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        ENTRY_UNUSED = 0x00,

        /// <summary>
        ///	Partición de tipo FAT12.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FAT")]
        FAT_12 = 0x01,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XENIX")]
        XENIX_1 = 0x02,


        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XENIX")]
        XENIX_2 = 0x03,

        /// <summary>
        /// Partición de tipo FAT16.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FAT")]
        FAT_16 = 0x04,

        /// <summary>
        /// Partición extendida.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EXTENDED")]
        EXTENDED = 0x05,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "HUGE")]
        HUGE = 0x06,

        /// <summary>
        /// Partición de tipo IFS (Installable File System).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "IFS")]
        IFS = 0x07,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "BOOTMGR")]
        OS2BOOTMGR = 0x0a,

        /// <summary>
        /// Partición de tipo FAT32.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FAT")]
        FAT32 = 0x0b,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "FAT")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XINT")]
        FAT32_XINT13 = 0x0c,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XINT")]
        XINT13 = 0x0e,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EXTENDED")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "XINT")]
        XINT13_EXTENDED = 0x0f,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "PREP")]
        PREP = 0x41,

        /// <summary>
        /// Partición de disco lógico manager (LDM).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "LDM")]
        LDM = 0x42,

        /// <summary>
        /// 
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UNIX")]
        UNIX = 0x63,

        /// <summary>
        /// Partición de tipo NTFT.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "NTFT")]
        NTFT = 0x80,
    }
}
