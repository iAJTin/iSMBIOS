using System.Runtime.InteropServices;
using BYTE = System.Byte;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff554977%28v=VS.85%29.aspx
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct IDEREGS
    {
        #region Atributos
        /// <summary>
        /// Used for specifying SMART "commands".
        /// </summary>
        public BYTE bFeaturesReg;

        /// <summary>
        /// IDE sector count register
        /// </summary>
        public BYTE bSectorCountReg;

        /// <summary>
        /// IDE sector number register
        /// </summary>
        public BYTE bSectorNumberReg;

        /// <summary>
        /// IDE low order cylinder value
        /// </summary>
        public BYTE bCylLowReg;

        /// <summary>
        /// IDE high order cylinder value
        /// </summary>
        public BYTE bCylHighReg;

        /// <summary>
        ///  IDE drive/head register
        /// </summary>
        public BYTE bDriveHeadReg;

        /// <summary>
        /// Actual IDE command.
        /// </summary>
        public BYTE bCommandReg;

        /// <summary>
        /// Reserved for future use.  Must be zero.
        /// </summary>
        public BYTE bReserved;
        #endregion
    }
}