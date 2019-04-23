﻿using System;

namespace iTin.Core.Interop.Windows.DriverKit.DeviceAndDriverTechnologies.StorageDevices.Reference.IdeBus
{
    [Flags]
    public enum AtaError : byte
    {
        None = 0,
        IllegalLengthOrTimeoutOrMediaErrorOrOther = 1 << 0,
        EndOfMedium = 1 << 1,
        Abort = 1 << 2,
        IdNotFound = 1 << 4,
        UncorrectableError = 1 << 6,
        InterfaceCrc = 1 << 7
    }
}