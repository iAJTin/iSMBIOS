
namespace iTin.Core.Hardware.Specification.Smbios
{
    /// <summary>
    /// Known <see cref="SMBIOS"/> structures.
    /// </summary>
    public enum SmbiosStructure
    {
        /// <summary>
        /// <b>Bios</b> structure, for more information please see <see cref="SmbiosType000" />.
        /// </summary>
        Bios = 0x00,

        /// <summary>
        /// <b>System</b> structure, for more information please see <see cref="SmbiosType001" />.
        /// </summary>
        System = 0x01,

        /// <summary>
        /// <b>BaseBoard</b> structure, for more information please see <see cref="SmbiosType002" />.
        /// </summary>
        BaseBoard = 0x02,

        /// <summary>
        /// <b>System Enclosure</b> structure, for more information please see <see cref="SmbiosType003" />.
        /// </summary>
        SystemEnclosure = 0x03,

        /// <summary>
        /// <b>Processor</b> structure, for more information please see <see cref="SmbiosType004" />.
        /// </summary>
        Processor = 0x04,

        /// <summary>
        /// <b>Memory Controller</b> (obsolete) structure, for more information please see <see cref="SmbiosType005" />.
        /// </summary>
        MemoryController = 0x05,

        /// <summary>
        /// <b>Memory Module</b> (obsolete) structure, for more information please see <see cref="SmbiosType006" />.
        /// </summary>
        MemoryModule = 0x06,

        /// <summary>
        /// <b>Cache Memory</b> structure, for more information please see <see cref="SmbiosType007" />.
        /// </summary>
        Cache = 0x07,

        /// <summary>
        /// <b>Port Connector</b> structure, for more information please see <see cref="SmbiosType008" />.
        /// </summary>
        PortConnector = 0x08,

        /// <summary>
        /// <b>System Slots</b> structure, for more information please see <see cref="SmbiosType009" />.
        /// </summary>
        SystemSlots = 0x09,

        /// <summary>
        /// <b>On Board Devices</b> structure, for more information please see <see cref="SmbiosType010" />.
        /// </summary>
        OnBoardDevices = 0x0a,

        /// <summary>
        /// <b>OEM Strings</b> structure, for more information please see <see cref="SmbiosType011" />.
        /// </summary>
        OemStrings = 0x0b,

        /// <summary>
        /// <b>System Configuration Options</b> structure, for more information please see <see cref="SmbiosType012" />.
        /// </summary>
        SystemConfigurationOptions = 0x0c,

        /// <summary>
        /// <b>Bios Language</b> structure, for more information please see <see cref="SmbiosType013" />.
        /// </summary>
        BiosLanguage = 0x0d,

        /// <summary>
        /// <b>Group Associations</b> structure, for more information please see <see cref="SmbiosType014" />.
        /// </summary>
        GroupAssociations = 0x0e,

        /// <summary>
        /// <b>System Event Log</b> structure, for more information please see <see cref="SmbiosType015" />.
        /// </summary>
        SystemEventLog = 0x0f,

        /// <summary>
        /// <b>Physical Memory Array</b> structure, for more information please see <see cref="SmbiosType016" />.
        /// </summary>
        PhysicalMemoryArray = 0x10,

        /// <summary>
        /// <b>Memory Device</b> structure, for more information please see <see cref="SmbiosType017" />.
        /// </summary>
        MemoryDevice = 0x11,

        /// <summary>
        /// <b>32-Bit Memory Error Information</b> structure, for more information please see <see cref="SmbiosType018" />.
        /// </summary>
        BitMemoryError32 = 0x12,

        /// <summary>
        /// <b>Memory Array Mapped Address</b> structure, for more information please see <see cref="SmbiosType019" />.
        /// </summary>
        MemoryArrayMappedAddress = 0x13,

        /// <summary>
        /// <b>Memory Device Mapped Address</b> structure, for more information please see <see cref="SmbiosType020" />.
        /// </summary>
        MemoryDeviceMappedAddress = 0x14,

        /// <summary>
        /// <b>Built-in Pointing Device</b> structure, for more information please see <see cref="SmbiosType021" />.
        /// </summary>
        BuiltInPointingDevice = 0x15,

        /// <summary>
        /// <b>Portable Battery</b> structure, for more information please see <see cref="SmbiosType022" />.
        /// </summary>
        PortableBattery = 0x16,

        /// <summary>
        /// <b>System Reset</b> structure, for more information please see <see cref="SmbiosType023" />.
        /// </summary>
        SystemReset = 0x17,

        /// <summary>
        /// <b>Hardware Security</b> structure, for more information please see <see cref="SmbiosType024" />.
        /// </summary>
        HardwareSecurity = 0x18,

        /// <summary>
        /// <b>System Power Controls</b> structure, for more information please see <see cref="SmbiosType025" />.
        /// </summary>
        SystemPowerControls = 0x19,

        /// <summary>
        /// <b>Voltage Probe</b> structure, for more information please see <see cref="SmbiosType026" />.
        /// </summary>
        VoltageProbe = 0x1a,

        /// <summary>
        /// <b>Cooling Device</b> structure, for more information please see <see cref="SmbiosType027" />.
        /// </summary>
        CoolingDevice = 0x1b,

        /// <summary>
        /// <b>Temperature Probe</b> structure, for more information please see <see cref="SmbiosType028" />.
        /// </summary>
        TemperatureProbe = 0x1c,

        /// <summary>
        /// <b>Electrical Current Probe</b> structure, for more information please see <see cref="SmbiosType029" />.
        /// </summary>
        ElectricalCurrentProbe = 0x1d,

        /// <summary>
        /// <b>Out-Of-Band Remote</b> structure, for more information please see <see cref="SmbiosType030" />.
        /// </summary>
        OutOfBandRemote = 0x1e,

        /// <summary>
        /// <b>Boot Integrity Services (BIS) Entry Point</b> structure, for more information please see <see cref="SmbiosType031" />.
        /// </summary>
        BootIntegrityServicesEntryPoint = 0x1f,

        /// <summary>
        /// <b>System Boot Information</b> structure, for more information please see <see cref="SmbiosType032" />.
        /// </summary>
        SystemBoot = 0x20,

        /// <summary>
        /// <b>64-Bit Memory Error Information</b> structure, for more information please see <see cref="SmbiosType033" />.
        /// </summary>
        BitMemoryError64 = 0x21,

        /// <summary>
        /// <b>Management Device</b> structure, for more information please see <see cref="SmbiosType034" />.
        /// </summary>
        ManagementDevice = 0x22,

        /// <summary>
        /// <b>Management Device Component</b> structure, for more information please see <see cref="SmbiosType035" />.
        /// </summary>
        ManagementDeviceComponent = 0x23,

        /// <summary>
        /// <b>Management Device Threshold Data</b> structure, for more information please see <see cref="SmbiosType036" />.
        /// </summary>
        ManagementDeviceThresholdData = 0x24,

        /// <summary>
        /// <b>Memory Channel</b> structure, for more information please see <see cref="SmbiosType037" />.
        /// </summary>
        MemoryChannel = 0x25,

        /// <summary>
        /// <b>IPMI Device Information</b> structure, for more information please see <see cref="SmbiosType038" />.
        /// </summary>
        IpmiDevice = 0x26,

        /// <summary>
        /// <b>System Power Supply</b> structure, for more information please see <see cref="SmbiosType039" />.
        /// </summary>
        SystemPowerSupply = 0x27,

        /// <summary>
        /// <b>Additional Information</b> structure, for more information please see <see cref="SmbiosType040" />.
        /// </summary>
        AdditionalInformation = 0x28,

        /// <summary>
        /// <b>OnBoard Devices Extended Information</b> structure, for more information please see <see cref="SmbiosType041" />.
        /// </summary>
        OnBoardDevicesExtended = 0x29,

        /// <summary>
        /// <b>Management Controller Host Interface</b> structure, for more information please see <see cref="SmbiosType042" />.
        /// </summary>
        ManagementControllerHostInterface = 0x2A,

        /// <summary>
        /// <b>TPM Device</b> structure, for more information please see <see cref="SmbiosType043" />.
        /// </summary>
        TpmDevice = 0x2B,

        /// <summary>
        /// <b>Inactive</b> structure, for more information please see <see cref="SmbiosType126" />.
        /// </summary>
        Inactive = 0x7e,

        /// <summary>
        /// <b>End-Of-Table</b> structure, for more information please see <see cref="SmbiosType127" />.
        /// </summary>
        EndOfTable = 0x7f,
    }
}
