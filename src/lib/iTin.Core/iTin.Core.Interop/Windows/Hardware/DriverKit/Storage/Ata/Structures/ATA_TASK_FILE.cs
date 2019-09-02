
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ATA_TASK_FILE
    {
        #region public members

        [FieldOffset(0)]public readonly byte Features;
        [FieldOffset(0)]public readonly AtaError Error;
        [FieldOffset(1)]public readonly byte Count;
        [FieldOffset(2)]public readonly byte Sector;
        [FieldOffset(3)]public readonly ushort Cylinder;
        [FieldOffset(5)]public readonly byte DeviceOrHead;
        [FieldOffset(6)]public readonly AtaCommand Command;
        [FieldOffset(6)]public readonly AtaStatus Status;
        [FieldOffset(7)]public readonly byte Reserved;

        #endregion

        #region constructor/s

        #region [public] ATA_TASK_FILE(AtaCommand):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public ATA_TASK_FILE(AtaCommand command) : this(0, 0, 0, 0, 0, command, 0)
        {
        }
        #endregion

        #region [public] ATA_TASK_FILE(byte, byte, uint, byte, AtaCommand, byte):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="featuresOrError"></param>
        /// <param name="count"></param>
        /// <param name="logicalBlockAddress"></param>
        /// <param name="deviceOrHead"></param>
        /// <param name="command"></param>
        /// <param name="reserved"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public ATA_TASK_FILE(byte featuresOrError, byte count, uint logicalBlockAddress, byte deviceOrHead, AtaCommand command, byte reserved) : this(featuresOrError, count, (byte)(logicalBlockAddress & 0xFF), (ushort)((logicalBlockAddress >> 8) & 0xFFFF), deviceOrHead, command, reserved)
        {
            if ((logicalBlockAddress & unchecked(0xFF000000)) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(logicalBlockAddress), logicalBlockAddress, @"Logical block address must only use the lower 3 bytes.");
            }
        }
        #endregion

        #region [public] ATA_TASK_FILE(byte, byte, byte, ushort, byte, AtaCommand, byte):
        /// <summary>
        /// 
        /// </summary>
        /// <param name="featuresOrError"></param>
        /// <param name="count"></param>
        /// <param name="sector"></param>
        /// <param name="cylinder"></param>
        /// <param name="deviceOrHead"></param>
        /// <param name="command"></param>
        /// <param name="reserved"></param>
        public ATA_TASK_FILE(byte featuresOrError, byte count, byte sector, ushort cylinder, byte deviceOrHead, AtaCommand command, byte reserved)
        {
            Error = (AtaError)(Features = featuresOrError);
            Count = count;
            Sector = sector;
            Cylinder = cylinder;
            DeviceOrHead = deviceOrHead;
            Status = (AtaStatus)(Command = command);
            Reserved = reserved;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (uint) LogicalBlockAddress: 
        /// <summary>
        /// 
        /// </summary>
        public uint LogicalBlockAddress => Sector | ((uint)Cylinder << 8);
        #endregion

        #endregion
    }
}
