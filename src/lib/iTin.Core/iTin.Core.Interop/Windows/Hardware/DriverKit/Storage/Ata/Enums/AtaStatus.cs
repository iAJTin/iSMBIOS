
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    using System;

    [Flags]
    public enum AtaStatus : byte
    {
        None = 0,

        CheckCondition = 1 << 0,

        SenseDataAvailable = 1 << 1,

        AlignmentError = 1 << 2,

        DataRequest = 1 << 3,

        DeferredWriteError = 1 << 4,

        StreamError = 1 << 5,

        DeviceFault = 1 << 5,

        DeviceReady = 1 << 6,

        Busy = 1 << 7
    }
}
