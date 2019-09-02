
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ata
{
    public enum AtaCommand : byte
    {
        CfaEraseSectors = 0xC0,

        CfaRequestExtendedError = 0x03,

        CfaTranslateSector = 0x87,

        CfaWriteMultipleWithoutErase = 0xCD,

        CfaWriteSectorsWithoutErase = 0xCD,

        CheckMediaCardType = 0xD1,

        CheckPowerMode = 0xE5,

        ConfigureStream = 0x51,

        DataSetManagement = 0x06,

        DeviceConfigurationOverlay = 0xB1,

        DeviceReset = 0x08,

        DownloadMicrocode = 0x92,

        DownloadMicrocodeDma = 0x93,

        ExecuteDeviceDiagnostic = 0x90,

        FlushCache = 0xE7,

        FlushCacheExt = 0xEA,

        IdentifyDevice = 0xEC,

        IdentifyPacketDevice = 0xA1,

        Idle = 0xE3,

        IdleImmediate = 0xE1,

        Nop = 0x00,

        NonvolatileCache = 0xB6,

        Packet = 0xA0,

        ReadBuffer = 0xE4,

        ReadBufferDma = 0xE9,

        ReadDma = 0xC8,

        ReadDmaExt = 0x25,

        ReadFpDmaQueued = 0x60,

        ReadLogDmaExt = 0x47,

        ReadLogExt = 0x2F,

        ReadMultiple = 0xC4,

        ReadMultipleExt = 0x29,

        ReadNativeMaxAddress = 0xF8,

        ReadNativeMaxAddressExt = 0x27,

        ReadSectors = 0x20,

        ReadSectorsExt = 0x24,

        ReadStreamDmaExt = 0x2A,

        ReadStreamExt = 0x2A,

        ReadVerifySectors = 0x40,

        ReadVerifySectorsExt = 0x42,

        RequestSenseDataExt = 0x0B,

        SanitizeDevice = 0xB4,

        SecurityDisablePassword = 0xF6,

        SecurityErasePrepare = 0xF3,

        SecurityEraseUnit = 0xF4,

        SecurityFreezeLock = 0xF5,

        SecuritySetPassword = 0xF1,

        SecurityUnlock = 0xF2,

        SetFeatures = 0xEF,

        SetMaxAddress = 0xF9,

        SetMaxAddressExt = 0x37,

        SetMultipleMode = 0xC6,

        Sleep = 0xE6,

        Smart = 0xB0,

        Standby = 0xE2,

        StandbyImmediate = 0xE0,

        TrustedNonData = 0x5B,

        TrustedReceive = 0x5C,

        TrustedReceiveDma = 0x5D,

        TrustedSend = 0x5E,

        TrustedSendDma = 0x5F,

        WriteBuffer = 0xE8,

        WriteBufferDma = 0xEB,

        WriteDma = 0xCA,

        WriteDmaExt = 0x35,

        WriteDmaForceUnitAccessExt = 0x3D,

        WriteFpDmaQueued = 0x61,

        WriteLogDmaExt = 0x57,

        WriteLogExt = 0x3F,

        WriteMultiple = 0xC5,

        WriteMultipleExt = 0x39,

        WriteMultipleForceUnitAccessExt = 0xCE,

        WriteSectors = 0x30,

        WriteSectorsExt = 0x34,

        WriteStreamDmaExt = 0x3A,

        WriteStreamExt = 0x3B,

        WriteUncorrectableExt = 0x45,
    }
}
