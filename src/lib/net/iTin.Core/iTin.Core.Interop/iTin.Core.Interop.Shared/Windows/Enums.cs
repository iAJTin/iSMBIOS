
namespace iTin.Core.Interop.Shared.Windows
{
    using System;

    /// <summary>
    /// Device Method
    /// </summary>
    [Flags]
    public enum DeviceMethod : uint
    {
        /// <summary>
        /// Buffered
        /// </summary>
        Buffered = 0,

        /// <summary>
        /// InDirect
        /// </summary>
        InDirect = 1,

        /// <summary>
        /// OutDirect
        /// </summary>
        OutDirect = 2,

        /// <summary>
        /// Neither
        /// </summary>
        Neither = 3
    }

    /// <summary>
    /// Device Access
    /// </summary>
    [Flags]
    public enum DeviceAccess
    {
        /// <summary>
        /// Any
        /// </summary>
        Any = 0,

        /// <summary>
        /// Special
        /// </summary>
        Special = Any,

        /// <summary>
        /// Read
        /// </summary>
        Read = 1,

        /// <summary>
        /// Write
        /// </summary>
        Write = 2
    }

    /// <summary>
    /// Device Type
    /// </summary>
    [Flags]
    public enum DeviceType : uint
    {
        /// <summary>
        /// 
        /// </summary>
        Beep = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        CDRom = 0x00000002,

        /// <summary>
        /// 
        /// </summary>
        CDRomFileSytem = 0x00000003,

        /// <summary>
        /// 
        /// </summary>
        Controller = 0x00000004,

        /// <summary>
        /// 
        /// </summary>
        Datalink = 0x00000005,

        /// <summary>
        /// 
        /// </summary>
        Dfs = 0x00000006,

        /// <summary>
        /// 
        /// </summary>
        Disk = 0x00000007,

        /// <summary>
        /// 
        /// </summary>
        DiskFileSystem = 0x00000008,

        /// <summary>
        /// 
        /// </summary>
        FileSystem = 0x00000009,

        /// <summary>
        /// 
        /// </summary>
        InPortPort = 0x0000000a,

        /// <summary>
        /// 
        /// </summary>
        Keyboard = 0x0000000b,

        /// <summary>
        /// 
        /// </summary>
        Mailslot = 0x0000000c,

        /// <summary>
        /// 
        /// </summary>
        MidiIn = 0x0000000d,

        /// <summary>
        /// 
        /// </summary>
        MidiOut = 0x0000000e,

        /// <summary>
        /// 
        /// </summary>
        Mouse = 0x0000000f,

        /// <summary>
        /// 
        /// </summary>
        MultiUncProvider = 0x00000010,

        /// <summary>
        /// 
        /// </summary>
        NamedPipe = 0x00000011,

        /// <summary>
        /// 
        /// </summary>
        Network = 0x00000012,

        /// <summary>
        /// 
        /// </summary>
        NetworkBrowser = 0x00000013,

        /// <summary>
        /// 
        /// </summary>
        NetworkFileSystem = 0x00000014,

        /// <summary>
        /// 
        /// </summary>
        Null = 0x00000015,

        /// <summary>
        /// 
        /// </summary>
        ParallelPort = 0x00000016,

        /// <summary>
        /// 
        /// </summary>
        PhysicalNetcard = 0x00000017,

        /// <summary>
        /// 
        /// </summary>
        Printer = 0x00000018,

        /// <summary>
        /// 
        /// </summary>
        Scanner = 0x00000019,

        /// <summary>
        /// 
        /// </summary>
        SerialMousePort = 0x0000001a,

        /// <summary>
        /// 
        /// </summary>
        SerialPort = 0x0000001b,

        /// <summary>
        /// 
        /// </summary>
        Screen = 0x0000001c,

        /// <summary>
        /// 
        /// </summary>
        Sound = 0x0000001d,

        /// <summary>
        /// 
        /// </summary>
        Streams = 0x0000001e,

        /// <summary>
        /// 
        /// </summary>
        Tape = 0x0000001f,

        /// <summary>
        /// 
        /// </summary>
        TapeFileSystem = 0x00000020,

        /// <summary>
        /// 
        /// </summary>
        Transport = 0x00000021,

        /// <summary>
        /// 
        /// </summary>
        Unknown = 0x00000022,

        /// <summary>
        /// 
        /// </summary>
        Video = 0x00000023,

        /// <summary>
        /// 
        /// </summary>
        VirtualDisk = 0x00000024,

        /// <summary>
        /// 
        /// </summary>
        WaveIn = 0x00000025,

        /// <summary>
        /// 
        /// </summary>
        WaveOut = 0x00000026,

        /// <summary>
        /// 
        /// </summary>
        Port8042 = 0x00000027,

        /// <summary>
        /// 
        /// </summary>
        NetworkRedirector = 0x00000028,

        /// <summary>
        /// 
        /// </summary>
        Battery = 0x00000029,

        /// <summary>
        /// 
        /// </summary>
        BusExtender = 0x0000002a,

        /// <summary>
        /// 
        /// </summary>
        Modem = 0x0000002b,

        /// <summary>
        /// 
        /// </summary>
        Vdm = 0x0000002c,

        /// <summary>
        /// 
        /// </summary>
        MassStorage = 0x0000002d,

        /// <summary>
        /// 
        /// </summary>
        Smb = 0x0000002e,

        /// <summary>
        /// 
        /// </summary>
        Ks = 0x0000002f,

        /// <summary>
        /// 
        /// </summary>
        Changer = 0x00000030,

        /// <summary>
        /// 
        /// </summary>
        Smartcard = 0x00000031,

        /// <summary>
        /// 
        /// </summary>
        Acpi = 0x00000032,

        /// <summary>
        /// 
        /// </summary>
        Dvd = 0x00000033,

        /// <summary>
        /// 
        /// </summary>
        FullscreenVideo = 0x00000034,

        /// <summary>
        /// 
        /// </summary>
        DfsFileSystem = 0x00000035,

        /// <summary>
        /// 
        /// </summary>
        DfsVolume = 0x00000036,

        /// <summary>
        /// 
        /// </summary>
        Serenum = 0x00000037,

        /// <summary>
        /// 
        /// </summary>
        Termsrv = 0x00000038,

        /// <summary>
        /// 
        /// </summary>
        Ksec = 0x00000039,

        /// <summary>
        /// 
        /// </summary>


        /// <summary>
        /// 
        /// </summary>
        // From Windows Driver Kit 7
        Fips = 0x0000003A,

        /// <summary>
        /// 
        /// </summary>
        Infiniband = 0x0000003B,

        /// <summary>
        /// 
        /// </summary>
        Vmbus = 0x0000003E,

        /// <summary>
        /// 
        /// </summary>
        CryptProvider = 0x0000003F,

        /// <summary>
        /// 
        /// </summary>
        Wpd = 0x00000040,

        /// <summary>
        /// 
        /// </summary>
        Bluetooth = 0x00000041,

        /// <summary>
        /// 
        /// </summary>
        MtComposite = 0x00000042,

        /// <summary>
        /// 
        /// </summary>
        MtTransport = 0x00000043,

        /// <summary>
        /// 
        /// </summary>
        Biometric = 0x00000044,

        /// <summary>
        /// 
        /// </summary>
        Pmi = 0x00000045
    }
}