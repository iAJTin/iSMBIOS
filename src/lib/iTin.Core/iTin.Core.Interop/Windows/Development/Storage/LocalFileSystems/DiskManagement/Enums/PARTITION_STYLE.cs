using System.Diagnostics.CodeAnalysis;

namespace iTin.Core.Interop.Windows.Development.Storage.LocalFileSystems.DiskManagement
{
    /// <summary>
    /// Representa el formato de una partición.
    /// </summary>
    /// <remarks>
    /// Para más información ver: http://msdn.microsoft.com/en-us/library/aa365452%28v=VS.85%29.aspx
    /// </remarks>
    public enum PARTITION_STYLE
    {
        /// <summary>
        /// Formato de Master Boot Record (MBR). Corresponde al estándar de particiones MBR.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MBR")]
        MBR = 0,

        /// <summary>
        /// Formato de tabla de particiones GUID (GPT).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "GPT")]
        GPT = 1,

        /// <summary>
        /// Partición sin formato, ó no tiene uno de los formatos reconocidos (<see cref="MBR"/> ó <see cref="GPT"/>).
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "RAW")]
        RAW = 2,
    }
}