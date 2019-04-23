using System;
using System.Runtime.InteropServices;
using UCHAR = System.Byte;
using ULONG = System.UInt32;
using PVOID = System.IntPtr;
using USHORT = System.UInt16;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    struct AtaTaskFile
    {
        public AtaTaskFile(AtaCommand command) : this(0, 0, 0, 0, 0, command, 0)
        { }

        public AtaTaskFile(byte featuresOrError, byte count, uint logicalBlockAddress, byte deviceOrHead, AtaCommand command, byte reserved) : this(featuresOrError, count, (byte)(logicalBlockAddress & 0xFF), (ushort)((logicalBlockAddress >> 8) & 0xFFFF), deviceOrHead, command, reserved)
        {
            if ((logicalBlockAddress & unchecked(0xFF000000)) != 0)
            {
                throw new ArgumentOutOfRangeException("logicalBlockAddress", logicalBlockAddress, "Logical block address must only use the lower 3 bytes.");
            }
        }

        public AtaTaskFile(byte featuresOrError, byte count, byte sector, ushort cylinder, byte deviceOrHead, AtaCommand command, byte reserved)
        {
            Error = (AtaError)(Features = featuresOrError);
            Count = count;
            Sector = sector;
            Cylinder = cylinder;
            DeviceOrHead = deviceOrHead;
            Status = (AtaStatus)(Command = command);
            Reserved = reserved;
        }

        [FieldOffset(0)]
        public readonly byte Features;
        [FieldOffset(0)]
        public readonly AtaError Error;
        [FieldOffset(1)]
        public readonly byte Count;
        [FieldOffset(2)]
        public readonly byte Sector;
        [FieldOffset(3)]
        public readonly ushort Cylinder;
        [FieldOffset(5)]
        public readonly byte DeviceOrHead;
        [FieldOffset(6)]
        public readonly AtaCommand Command;
        [FieldOffset(6)]
        public readonly AtaStatus Status;
        [FieldOffset(7)]
        public readonly byte Reserved;

        public uint LogicalBlockAddress
        {
            get { return Sector | ((uint)Cylinder << 8); }
        }
    }
}