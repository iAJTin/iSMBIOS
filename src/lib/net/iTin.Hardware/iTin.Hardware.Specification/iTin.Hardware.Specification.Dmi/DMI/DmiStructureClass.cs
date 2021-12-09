
namespace iTin.Hardware.Specification.Dmi
{
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Known <see cref="DMI"/> structures.
    /// </summary>
    public enum DmiStructureClass
    {
        /// <summary>
        /// <b>Bios</b> structure, for more information please see <see cref="DmiType000"/>.
        /// </summary>
        [PropertyName("BIOS")]
        [PropertyDescription("")]
        Bios = 0x00,

        /// <summary>
        /// <b>System</b> structure, for more information please see <see cref="DmiType001"/>.
        /// </summary>
        [PropertyName("System")]
        [PropertyDescription("")]
        System = 0x01,

        /// <summary>
        /// <b>BaseBoard</b> structure, for more information please see <see cref="DmiType002"/>.
        /// </summary>
        [PropertyName("Base Board")]
        [PropertyDescription("")]
        BaseBoard = 0x02,

        /// <summary>
        /// <b>System Enclosure</b> structure, for more information please see <see cref="DmiType003"/>.
        /// </summary>
        [PropertyName("System Enclosure")]
        [PropertyDescription("")]
        SystemEnclosure = 0x03,

        /// <summary>
        /// <b>Processor</b> structure, for more information please see <see cref="DmiType004"/>.
        /// </summary>
        [PropertyName("Processor")]
        [PropertyDescription("")]
        Processor = 0x04,

        /// <summary>
        /// <b>Memory Controller</b> (obsolete) structure, for more information please see <see cref="DmiType005"/>.
        /// </summary>
        [PropertyName("Memory Controller")]
        [PropertyDescription("")]
        MemoryController = 0x05,

        /// <summary>
        /// <b>Memory Module</b> (obsolete) structure, for more information please see <see cref="DmiType006"/>.
        /// </summary>
        [PropertyName("Memory Module")]
        [PropertyDescription("")]
        MemoryModule = 0x06,

        /// <summary>
        /// <b>Cache Memory</b> structure, for more information please see <see cref="DmiType007"/>.
        /// </summary>
        [PropertyName("Cache")]
        [PropertyDescription("")]
        Cache = 0x07,

        /// <summary>
        /// <b>Port Connector</b> structure, for more information please see <see cref="DmiType008"/>.
        /// </summary>
        [PropertyName("Port Connector")]
        [PropertyDescription("")]
        PortConnector = 0x08,

        /// <summary>
        /// <b>System Slots</b> structure, for more information please see <see cref="DmiType009"/>.
        /// </summary>
        [PropertyName("System Slots")]
        [PropertyDescription("")]
        SystemSlots = 0x09,

        /// <summary>
        /// <b>On Board Devices</b> structure, for more information please see <see cref="DmiType010"/>.
        /// </summary>
        [PropertyName("On Board Devices")]
        [PropertyDescription("")]
        OnBoardDevices = 0x0a,

        /// <summary>
        /// <b>OEM Strings</b> structure, for more information please see <see cref="DmiType011"/>.
        /// </summary>
        [PropertyName("OEM Strings")]
        [PropertyDescription("")]
        OemStrings = 0x0b,

        /// <summary>
        /// <b>System Configuration Options</b> structure, for more information please see <see cref="DmiType012"/>.
        /// </summary>
        [PropertyName("System Configuration Options")]
        [PropertyDescription("")]
        SystemConfigurationOptions = 0x0c,

        /// <summary>
        /// <b>Bios Language</b> structure, for more information please see <see cref="DmiType013"/>.
        /// </summary>
        [PropertyName("Bios Language")]
        [PropertyDescription("")]
        BiosLanguage = 0x0d,

        /// <summary>
        /// <b>Group Associations</b> structure, for more information please see <see cref="DmiType014"/>.
        /// </summary>
        [PropertyName("Group Associations")]
        [PropertyDescription("")]
        GroupAssociations = 0x0e,

        /// <summary>
        /// <b>System Event Log</b> structure, for more information please see <see cref="DmiType015"/>.
        /// </summary>
        [PropertyName("System Event Log")]
        [PropertyDescription("")]
        SystemEventLog = 0x0f,

        /// <summary>
        /// <b>Physical Memory Array</b> structure, for more information please see <see cref="DmiType016"/>.
        /// </summary>
        [PropertyName("Physical Memory Array")]
        [PropertyDescription("")]
        PhysicalMemoryArray = 0x10,

        /// <summary>
        /// <b>Memory Device</b> structure, for more information please see <see cref="DmiType017"/>.
        /// </summary>
        [PropertyName("Memory Device")]
        [PropertyDescription("")]
        MemoryDevice = 0x11,

        /// <summary>
        /// <b>32-Bit Memory Error Information</b> structure, for more information please see <see cref="DmiType018"/>.
        /// </summary>
        [PropertyName("32-Bit Memory Error")]
        [PropertyDescription("")]
        BitMemoryError32 = 0x12,

        /// <summary>
        /// <b>Memory Array Mapped Address</b> structure, for more information please see <see cref="DmiType019"/>.
        /// </summary>
        [PropertyName("Memory Array Mapped Address")]
        [PropertyDescription("")]
        MemoryArrayMappedAddress = 0x13,

        /// <summary>
        /// <b>Memory Device Mapped Address</b> structure, for more information please see <see cref="DmiType020"/>.
        /// </summary>
        [PropertyName("Memory Device Mapped Address")]
        [PropertyDescription("")]
        MemoryDeviceMappedAddress = 0x14,

        /// <summary>
        /// <b>Built-in Pointing Device</b> structure, for more information please see <see cref="DmiType021"/>.
        /// </summary>
        [PropertyName("Built-In Pointing Device")]
        [PropertyDescription("")]
        BuiltInPointingDevice = 0x15,

        /// <summary>
        /// <b>Portable Battery</b> structure, for more information please see <see cref="DmiType022"/>.
        /// </summary>
        [PropertyName("Portable Battery")]
        [PropertyDescription("")]
        PortableBattery = 0x16,

        /// <summary>
        /// <b>System Reset</b> structure, for more information please see <see cref="DmiType023"/>.
        /// </summary>
        [PropertyName("System Reset")]
        [PropertyDescription("")]
        SystemReset = 0x17,

        /// <summary>
        /// <b>Hardware Security</b> structure, for more information please see <see cref="DmiType024"/>.
        /// </summary>
        [PropertyName("Hardware Security")]
        [PropertyDescription("")]
        HardwareSecurity = 0x18,

        /// <summary>
        /// <b>System Power Controls</b> structure, for more information please see <see cref="DmiType025"/>.
        /// </summary>
        [PropertyName("System Power Controls")]
        [PropertyDescription("")]
        SystemPowerControls = 0x19,

        /// <summary>
        /// <b>Voltage Probe</b> structure, for more information please see <see cref="DmiType026"/>.
        /// </summary>
        [PropertyName("Voltage Probe")]
        [PropertyDescription("")]
        VoltageProbe = 0x1a,

        /// <summary>
        /// <b>Cooling Device</b> structure, for more information please see <see cref="DmiType027"/>.
        /// </summary>
        [PropertyName("Cooling Device")]
        [PropertyDescription("")]
        CoolingDevice = 0x1b,

        /// <summary>
        /// <b>Temperature Probe</b> structure, for more information please see <see cref="DmiType028"/>.
        /// </summary>
        [PropertyName("Temperature Probe")]
        [PropertyDescription("")]
        TemperatureProbe = 0x1c,

        /// <summary>
        /// <b>Electrical Current Probe</b> structure, for more information please see <see cref="DmiType029"/>.
        /// </summary>
        [PropertyName("Electrical Current Probe")]
        [PropertyDescription("")]
        ElectricalCurrentProbe = 0x1d,

        /// <summary>
        /// <b>Out-Of-Band Remote</b> structure, for more information please see <see cref="DmiType030"/>.
        /// </summary>
        [PropertyName("Out Of Band Remote")]
        [PropertyDescription("")]
        OutOfBandRemote = 0x1e,

        /// <summary>
        /// <b>Boot Integrity Services (BIS) Entry Point</b> structure, for more information please see <see cref="DmiType031"/>.
        /// </summary>
        [PropertyName("Boot Integrity Services Entry Point")]
        [PropertyDescription("")]
        BootIntegrityServicesEntryPoint = 0x1f,

        /// <summary>
        /// <b>System Boot Information</b> structure, for more information please see <see cref="DmiType032"/>.
        /// </summary>
        [PropertyName("System Boot")]
        [PropertyDescription("")]
        SystemBoot = 0x20,

        /// <summary>
        /// <b>64-Bit Memory Error Information</b> structure, for more information please see <see cref="DmiType033"/>.
        /// </summary>
        [PropertyName("64-Bit Memory Error")]
        [PropertyDescription("")]
        BitMemoryError64 = 0x21,

        /// <summary>
        /// <b>Management Device</b> structure, for more information please see <see cref="DmiType034"/>.
        /// </summary>
        [PropertyName("Management Device")]
        [PropertyDescription("")]
        ManagementDevice = 0x22,

        /// <summary>
        /// <b>Management Device Component</b> structure, for more information please see <see cref="DmiType035"/>.
        /// </summary>
        [PropertyName("Management Device Component")]
        [PropertyDescription("")]
        ManagementDeviceComponent = 0x23,

        /// <summary>
        /// <b>Management Device Threshold Data</b> structure, for more information please see <see cref="DmiType036"/>.
        /// </summary>
        [PropertyName("Management Device Threshold Data")]
        [PropertyDescription("")]
        ManagementDeviceThresholdData = 0x24,

        /// <summary>
        /// <b>Memory Channel</b> structure, for more information please see <see cref="DmiType037"/>.
        /// </summary>
        [PropertyName("Memory Channel")]
        [PropertyDescription("")]
        MemoryChannel = 0x25,

        /// <summary>
        /// <b>IPMI Device Information</b> structure, for more information please see <see cref="DmiType038"/>.
        /// </summary>
        [PropertyName("IPMI Device")]
        [PropertyDescription("")]
        IpmiDevice = 0x26,

        /// <summary>
        /// <b>System Power Supply</b> structure, for more information please see <see cref="DmiType039"/>.
        /// </summary>
        [PropertyName("System Power Supply")]
        [PropertyDescription("")]
        SystemPowerSupply = 0x27,

        /// <summary>
        /// <b>Additional Information</b> structure, for more information please see <see cref="DmiType040"/>.
        /// </summary>
        [PropertyName("Additional Information")]
        [PropertyDescription("")]
        AdditionalInformation = 0x28,

        /// <summary>
        /// <b>OnBoard Devices Extended Information</b> structure, for more information please see <see cref="DmiType041"/>.
        /// </summary>
        [PropertyName("On Board Devices Extended")]
        [PropertyDescription("")]
        OnBoardDevicesExtended = 0x29,

        /// <summary>
        /// <b>Management Controller Host Interface</b> structure, for more information please see <see cref="DmiType042"/>.
        /// </summary>
        [PropertyName("Management Controller Host Interface")]
        [PropertyDescription("")]
        ManagementControllerHostInterface = 0x2A,

        /// <summary>
        /// <b>TPM Device</b> structure, for more information please see <see cref="DmiType043"/>.
        /// </summary>
        [PropertyName("TPM Device")]
        [PropertyDescription("")]
        TpmDevice = 0x2b,

        /// <summary>
        /// <b>TPM Device</b> structure, for more information please see <see cref="DmiType044"/>.
        /// </summary>
        [PropertyName("Processor Additional Information")]
        [PropertyDescription("")]
        ProcessorAdditionalInformation = 0x2c,

        /// <summary>
        /// <b>Firmware Inventory Information</b> structure, for more information please see <see cref="DmiType045"/>.
        /// </summary>
        [PropertyName("Firmware Inventory Information")]
        [PropertyDescription("")]
        FirmwareInventoryInformation = 0x2d,

        /// <summary>
        /// <b>String Property</b> structure, for more information please see <see cref="DmiType046"/>.
        /// </summary>
        [PropertyName("String Property")]
        [PropertyDescription("")]
        StringProperty = 0x2e,

        /// <summary>
        /// <b>Inactive</b> structure, for more information please see <see cref="DmiType126"/>.
        /// </summary>
        [PropertyName("Inactive")]
        [PropertyDescription("")]
        Inactive = 0x7e,

        /// <summary>
        /// <b>End-Of-Table</b> structure, for more information please see <see cref="DmiType127"/>.
        /// </summary>
        [PropertyName("End Of Table")]
        [PropertyDescription("")]
        EndOfTable = 0x7f,
    }
}
