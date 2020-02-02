
namespace iTin.Core.Hardware.Specification.Dmi
{
    using System.Collections.ObjectModel;

    using Smbios;
    using Tpm;

    #region [internal] (emun) DmiType000Property: Defines the properties available for the structure type 000 [BIOS Information]
    /// <summary>
    /// Defines the properties available for the structure type 000 [BIOS Information].
    /// </summary>
    internal enum DmiType000Property
    {
        #region version 2.0+
        [PropertyName("BIOS Vendor")]
        [PropertyDescription("String number of the BIOS Vendor’s Name")]
        [PropertyType(typeof(string))]
        Vendor,

        [PropertyName("BIOS Version")]
        [PropertyDescription("String number of the BIOS Version")]
        [PropertyType(typeof(string))]
        BiosVersion,

        [PropertyName("BIOS Start Segment")]
        [PropertyDescription("Segment location of BIOS starting address")]
        [PropertyType(typeof(string))]
        BiosStartSegment,

        [PropertyName("BIOS Release Date")]
        [PropertyDescription("String number of the BIOS release date")]
        [PropertyType(typeof(string))]
        BiosReleaseDate,

        [PropertyName("BIOS Characteristics")]
        [PropertyDescription("Defines which functions the BIOS supports: PCI, PCMCIA, Flash, etc...")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,
        #endregion

        #region version 2.4+
        [PropertyName("BIOS Characteristics Extension Byte 1")]
        [PropertyDescription("Collection of functions compatible with this bios")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        CharacteristicsExtensionByte1,

        [PropertyName("BIOS Characteristics Extension Byte 2")]
        [PropertyDescription("Collection of functions compatible with this bios")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        CharacteristicsExtensionByte2,

        [PropertyName("System BIOS Major Release")]
        [PropertyDescription("Major release of the System BIOS")]
        [PropertyType(typeof(byte?))]
        SystemBiosMajorRelease,

        [PropertyName("System BIOS Minor Release")]
        [PropertyDescription("Minor release of the System BIOS")]
        [PropertyType(typeof(byte?))]
        SystemBiosMinorRelease,

        [PropertyName("Embedded Controller Firmware Major Version")]
        [PropertyDescription("Identifies the major release of the embedded controller firmware")]
        [PropertyType(typeof(byte?))]
        FirmwareMajorRelease,

        [PropertyName("Embedded Controller Firmware Minor Version")]
        [PropertyDescription("Identifies the minor release of the embedded controller firmware")]
        [PropertyType(typeof(byte?))]
        FirmwareMinorRelease,
        #endregion

        #region version 2.0+, 3.1+
        [PropertyName("BIOS Size")]
        [PropertyDescription("Size of the physical device containing the BIOS")]
        [PropertyType(typeof(int))]
        BiosRomSize,

        [PropertyName("BIOS ROM Size Units")]
        [PropertyDescription("Size of the physical device(s) containing the BIOS")]
        [PropertyType(typeof(MemorySizeUnit))]
        BiosRomSizeUnit,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType001Property: Defines the properties available for the structure type 001 [System Information]
    /// <summary>
    /// Defines the properties available for the structure type 001 [System Information].
    /// </summary>
    internal enum DmiType001Property
    {
        #region version 2.0+
        [PropertyName("System Manufacturer")]
        [PropertyDescription("System Manufacturer")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Product Name")]
        [PropertyDescription("Product Name")]
        [PropertyType(typeof(string))]
        ProductName,

        [PropertyName("Product Version")]
        [PropertyDescription("Product Version")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyName("Product Serial Number")]
        [PropertyDescription("Product Serial Number")]
        [PropertyType(typeof(string))]
        SerialNumber,
        #endregion

        #region version 2.1+
        [PropertyName("UUID")]
        [PropertyDescription("Universal unique ID number (UUID)")]
        [PropertyType(typeof(string))]
        UUID,

        [PropertyName("Wake Up Type")]
        [PropertyDescription("Identifies the event that caused the system to power up")]
        [PropertyType(typeof(string))]
        WakeUpType,
        #endregion

        #region version 2.4+
        [PropertyName("SKU Number")]
        [PropertyDescription("This text string identifies a particular computer configuration for sale")]
        [PropertyType(typeof(string))]
        SkuNumber,

        [PropertyName("Family")]
        [PropertyDescription("This text string identifies the family to which a particular computer belongs")]
        [PropertyType(typeof(string))]
        Family,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType002Property: Defines the properties available for the structure type 002 [Baseboard (or Module) Information]
    /// <summary>
    /// Defines the properties available for the structure type 002 [Baseboard (or Module) Information].
    /// </summary>
    internal enum DmiType002Property
    {
        [PropertyName("Mainboard Manufacturer")]
        [PropertyDescription("Mainboard Manufacturer")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Mainboard Name")]
        [PropertyDescription("Mainboard Name")]
        [PropertyType(typeof(string))]
        Product,

        [PropertyName("Mainboard Version")]
        [PropertyDescription("Mainboard version")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyName("Mainboard Serial Number")]
        [PropertyDescription("Mainboard Serial Number")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Asset Tag")]
        [PropertyDescription("Asset Tag")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyName("Hot Swappable")]
        [PropertyDescription("The mainboard is hot swappable")]
        [PropertyType(typeof(bool?))]
        HotSwappable,

        [PropertyName("Replaceable")]
        [PropertyDescription("The mainboard is replaceable")]
        [PropertyType(typeof(bool?))]
        IsReplaceable,

        [PropertyName("Removable")]
        [PropertyDescription("The mainboard is removable")]
        [PropertyType(typeof(bool?))]
        IsRemovable,

        [PropertyName("Required Daughter Board")]
        [PropertyDescription("The mainboard required daughter board")]
        [PropertyType(typeof(bool?))]
        RequiredDaughterBoard,

        [PropertyName("Hosting Board")]
        [PropertyDescription("Determines if is hosting board")]
        [PropertyType(typeof(bool?))]
        IsHostingBoard,

        [PropertyName("Location In Chassis")]
        [PropertyDescription("String that describes this board's location")]
        [PropertyType(typeof(string))]
        LocationInChassis,

        [PropertyName("Chassis Handle")]
        [PropertyDescription("Handle, or instance number, associated with the chassis in which this board resides")]
        [PropertyType(typeof(int?))]
        ChassisHandle,

        [PropertyName("Mainboard Type")]
        [PropertyDescription("Type of board")]
        [PropertyType(typeof(string))]
        BoardType,

        [PropertyName("Mainboard Number Of Contained Object Handles")]
        [PropertyDescription("Number (0 to 255) of contained Object Handles that follow")]
        [PropertyType(typeof(byte?))]
        NumberOfContainedObjectHandles,

        [PropertyName("Mainboard Contained Object Handles")]
        [PropertyDescription("List of handles of other structures (for examples, Baseboard, Processor, Port, System Slots, Memory Device) that are contained by this baseboard")]
        [PropertyType(typeof(BaseBoardContainedElementCollection))]
        ContainedObjectHandles,
    }
    #endregion

    #region [internal] (emun) DmiType003Property: Defines the properties available for the structure type 003 [System Enclosure or Chassis]
    /// <summary>
    /// Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// </summary>
    internal enum DmiType003Property
    {
        [PropertyName("Manufacturer")]
        [PropertyDescription("Manufacturer")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Chassis Type")]
        [PropertyDescription("Chassis Type")]
        [PropertyType(typeof(string))]
        ChassisType,

        [PropertyName("Locked")]
        [PropertyDescription("Indicates if chassis lock is present")]
        [PropertyType(typeof(string))]
        Locked,

        [PropertyName("Version")]
        [PropertyDescription("Version")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyName("Serial Number")]
        [PropertyDescription("Serial Number")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Asset Tag Number")]
        [PropertyDescription("Asset Tag Number")]
        [PropertyType(typeof(string))]
        AssetTagNumber,

        [PropertyName("Boot Up State")]
        [PropertyDescription("State of the enclosure when it was last booted")]
        [PropertyType(typeof(string))]
        BootUpState,

        [PropertyName("Power Supply State")]
        [PropertyDescription("State of the enclosure’s power supply (or supplies) when last booted")]
        [PropertyType(typeof(string))]
        PowerSupplyState,

        [PropertyName("Thermal State")]
        [PropertyDescription("Thermal state of the enclosure when last booted")]
        [PropertyType(typeof(string))]
        ThermalState,

        [PropertyName("Security State")]
        [PropertyDescription("Physical security status of the enclosure when last booted")]
        [PropertyType(typeof(string))]
        SecurityStatus,

        [PropertyName("OEM Information")]
        [PropertyDescription("OEM or BIOS vendor-specific information")]
        [PropertyType(typeof(long?))]
        OemDefined,

        [PropertyName("Height")]
        [PropertyDescription("Height of the enclosure, in 'U's  A U is a standard unit of measure for the height of a rack or rack-mountable component")]
        [PropertyType(typeof(byte?))]
        Height,

        [PropertyName("Number Of Power Cords")]
        [PropertyDescription("Number of power cords associated with the enclosure or chassis")]
        [PropertyType(typeof(byte?))]
        NumberOfPowerCords,

        [PropertyName("Contained Elements")]
        [PropertyDescription("Number of contained Element records that follow, in the range 0 to 255")]
        [PropertyType(typeof(ChassisContainedElementCollection))]
        ContainedElements,

        [PropertyName("SKU Number")]
        [PropertyDescription("String describing the chassis or enclosure SKU number")]
        [PropertyType(typeof(string))]
        SkuNumber,

        [PropertyName("Contained Type")]
        [PropertyDescription("Type of element associated")]
        [PropertyType(typeof(string))]
        ContainedType,

        [PropertyName("Contained Type Select")]
        [PropertyDescription("Type of selected element associated")]
        [PropertyType(typeof(ChassisContainedElementType))]
        ContainedTypeSelect,

        [PropertyName("Contained Type Select")]
        [PropertyDescription("Specifies the maximum number of the element type that can be installed in the chassis, in the range 1 to 255")]
        [PropertyType(typeof(byte?))]
        ContainedElementMaximum,

        [PropertyName("Contained Element Minimum")]
        [PropertyDescription("Specifies the minimum number of the element type that can be installed in the chassis for the chassis to properly operate, in the range 0 to 254")]
        [PropertyType(typeof(byte?))]
        ContainedElementMinimum
    }
    #endregion

    #region [internal] (emun) DmiType004Property: Defines the properties available for the structure type 004 [Processor Information]
    /// <summary>
    /// Defines the properties available for the structure type 004 [Processor Information].
    /// </summary>
    internal enum DmiType004Property
    {
        #region version 2.0+
        [PropertyName("Socket Designation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyName("Processor Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorType,

        [PropertyName("Processor Family")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorFamily,

        [PropertyName("Processor Manufacturer")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorManufacturer,

        [PropertyName("Processor Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorId,

        [PropertyName("Processor Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorVersion,

        [PropertyName("Is Legacy Mode")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        IsLegacyMode,

        [PropertyName("Voltage Capability")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        VoltageCapability,

        [PropertyName("External Clock")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ExternalClock,

        [PropertyName("Maximum Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumSpeed,

        [PropertyName("Current Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CurrentSpeed,

        [PropertyName("Socket Populated")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        SocketPopulated,

        [PropertyName("Cpu Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CpuStatus,

        [PropertyName("Processor Upgrade")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorUpgrade,
        #endregion

        #region version 2.1+
        [PropertyName("L1 Cache Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        L1CacheHandle,

        [PropertyName("L2 Cache Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        L2CacheHandle,

        [PropertyName("L3 Cache Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        L3CacheHandle,
        #endregion

        #region version 2.3+
        [PropertyName("Serial Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Asset Tag")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyName("Part Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PartNumber,
        #endregion

        #region version 2.6+
        [PropertyName("Core Count")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CoreCount,

        [PropertyName("Core Enabled")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CoreEnabled,

        [PropertyName("Thread Count")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ThreadCount,

        [PropertyName("Capable 64 Bits")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        Capable64Bits,

        [PropertyName("Multi Core")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        MultiCore,

        [PropertyName("Hardware Thread Per Core")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        HardwareThreadPerCore,

        [PropertyName("Execute Protection Support")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        ExecuteProtectionSupport,

        [PropertyName("Enhanced Virtualization Instructions")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        EnhancedVirtualizationInstructions,

        [PropertyName("Power Performance Control Support")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        PowerPerformanceControlSupport,
        #endregion

        #region version 3.0+
        [PropertyName("Core Count 2")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        CoreCount2,

        [PropertyName("Core Enabled 2")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        CoreEnabled2,

        [PropertyName("Thread Count 2")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        ThreadCount2,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType005Property: Defines the properties available for the structure type 005, obsolete [Memory Controller Information]
    /// <summary>
    /// Defines the properties available for the structure type 005, obsolete [Memory Controller Information].
    /// </summary>
    internal enum DmiType005Property
    {
        #region version 2.0+
        [PropertyName("Error Detecting Method")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorDetectingMethod,

        [PropertyName("Error Correcting Capabilitiesn")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorCorrectingCapabilities,

        [PropertyName("Supported Interleave")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SupportedInterleave,

        [PropertyName("Current Interleave")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CurrentInterleave,

        [PropertyName("Maximum Memory Module Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumMemoryModuleSize,

        [PropertyName("Supported Speeds")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSpeeds,

        [PropertyName("Supported Memory Types")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedMemoryTypes,

        [PropertyName("Memory Module Voltages")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryModuleVoltages,

        [PropertyName("Number Memory Slots")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NumberMemorySlots,

        [PropertyName("Contained Memory Modules")]
        [PropertyDescription("")]
        [PropertyType(typeof(MemoryControllerContainedElementCollection))]
        ContainedMemoryModules,
        #endregion

        #region version 2.1+
        [PropertyName("Enabled Error Correcting Capabilities")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        EnabledErrorCorrectingCapabilities,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType006Property: Defines the properties available for the structure type 006, obsolete [Memory Module Information]
    /// <summary>
    /// Defines the properties available for the structure type 006, obsolete [Memory Module Information].
    /// </summary>
    internal enum DmiType006Property
    {
        [PropertyName("Socket Designation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyName("Bank Connections")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        BankConnections,

        [PropertyName("Current Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        CurrentSpeed,

        [PropertyName("Current Memory Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        CurrentMemoryType,

        [PropertyName("Installed Sizes")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        InstalledSize,

        [PropertyName("Enabled Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        EnabledSize,

        [PropertyName("Error Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorStatus,
    }
    #endregion

    #region [internal] (emun) DmiType007Property: Defines the properties available for the structure type 007 [Cache Information]
    /// <summary>
    /// Defines the properties available for the structure type 007 [Cache Information].
    /// </summary>
    internal enum DmiType007Property
    {
        #region version 2.0+
        [PropertyName("Socket Designation")]
        [PropertyDescription("String number for reference designation")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyName("Operational Mode")]
        [PropertyDescription("Cache operational mode (Write Through, Write Back, ...)")]
        [PropertyType(typeof(string))]
        OperationalMode,

        [PropertyName("Cache Enabled")]
        [PropertyDescription("Indicates if is enabled/disabled (at boot time)")]
        [PropertyType(typeof(bool?))]
        CacheEnabled,

        [PropertyName("Cache Location")]
        [PropertyDescription("Location, relative to the CPU module")]
        [PropertyType(typeof(string))]
        CacheLocation,

        [PropertyName("Cache Socketed")]
        [PropertyDescription("Indicates if cache is socketed")]
        [PropertyType(typeof(bool?))]
        CacheSocketed,

        [PropertyName("Cache Level")]
        [PropertyDescription("Returns cache level (1, 2, 3,...)")]
        [PropertyType(typeof(byte?))]
        CacheLevel,

        [PropertyName("Maximum Cache Size")]
        [PropertyDescription("Maximum size that can be installed, expressed in KB")]
        [PropertyType(typeof(int?))]
        MaximumCacheSize,

        [PropertyName("Installed Cache Size")]
        [PropertyDescription("Installed size, expressed in KB")]
        [PropertyType(typeof(int?))]
        InstalledCacheSize,

        [PropertyName("Supported SRAM Types")]
        [PropertyDescription("String collection with supported SRAM types")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSramTypes,

        [PropertyName("Current SRAM Type")]
        [PropertyDescription("Current SRAM type is installed")]
        [PropertyType(typeof(string))]
        CurrentSramType,
        #endregion

        #region version 2.1+
        [PropertyName("Cache Speed")]
        [PropertyDescription("Cache module speed, in nanoseconds")]
        [PropertyType(typeof(byte?))]
        CacheSpeed,

        [PropertyName("Error Correction Type")]
        [PropertyDescription("Error-correction scheme supported by this cache component")]
        [PropertyType(typeof(string))]
        ErrorCorrectionType,

        [PropertyName("System Cache Type")]
        [PropertyDescription("Logical type of cache")]
        [PropertyType(typeof(string))]
        SystemCacheType,

        [PropertyName("Associativity")]
        [PropertyDescription("Associativity of the cache")]
        [PropertyType(typeof(string))]
        Associativity,
        #endregion

        #region version 3.1+
        [PropertyName("Maximum Cache Size 2")]
        [PropertyDescription("If is present, for cache sizes of 2047MB or smaller the value is equals to MaximumCacheSize property")]
        [PropertyType(typeof(uint?))]
        MaximumCacheSize2,

        [PropertyName("Installed Cache Size 2")]
        [PropertyDescription("If is present, for cache sizes of 2047MB or smaller the value is equals to InstalledCacheSize property")]
        [PropertyType(typeof(uint?))]
        InstalledCacheSize2,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType008Property: Defines the properties available for the structure type 008 [Port Connector Information]
    /// <summary>
    /// Defines the properties available for the structure type 008 [Port Connector Information].
    /// </summary>
    internal enum DmiType008Property
    {
        [PropertyName("Internal Reference Designator")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InternalReferenceDesignator,

        [PropertyName("Internal Connector Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InternalConnectorType,

        [PropertyName("External Reference Designator")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ExternalReferenceDesignator,

        [PropertyName("External Connector Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ExternalConnectorType,

        [PropertyName("Port Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PortType,
    }
    #endregion

    #region [internal] (emun) DmiType009Property: Defines the properties available for the structure type 009 [System Slots]
    /// <summary>
    /// Defines the properties available for the structure type 009 [System Slots].
    /// </summary>
    internal enum DmiType009Property
    {
        #region version 2.0+
        [PropertyName("Slot Designation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotDesignation,

        [PropertyName("Slot Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotType,

        [PropertyName("Slot Data Bus Width")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotDataBusWidth,

        [PropertyName("Current Usage")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CurrentUsage,

        [PropertyName("Slot Length")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotLength,

        [PropertyName("Slot Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotId,
        #endregion

        #region version 2.0+ - 2.1+
        [PropertyName("Slot Characteristics")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SlotCharacteristics,
        #endregion

        #region version 2.6+
        [PropertyName("Segment Bus Function")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SegmentBusFunction,

        [PropertyName("Bus Device Function")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BusDeviceFunction
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType010Property: Defines the properties available for the structure type 010, obsolete [On Board Devices Information]
    /// <summary>
    /// Defines the properties available for the structure type 010, obsolete [On Board Devices Information].
    /// </summary>
    internal enum DmiType010Property
    {
        [PropertyName("Enabled")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        Enabled,

        [PropertyName("Device Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,

        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [internal] (emun) DmiType011Property: Defines the properties available for the structure type 011 [OEM strings]
    /// <summary>
    /// Defines the properties available for the structure type 011 [OEM strings].
    /// </summary>
    internal enum DmiType011Property
    {
        [PropertyName("Values")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [internal] (emun) DmiType012Property: Defines the properties available for the structure type 012 [System Configuration Options]
    /// <summary>
    /// Defines the properties available for the structure type 012 [System Configuration Options].
    /// </summary>
    internal enum DmiType012Property
    {
        [PropertyName("Values")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [internal] (emun) DmiType013Property: Defines the properties available for the structure type 013 [BIOS Language Information]
    /// <summary>
    /// Defines the properties available for the structure type 013 [BIOS Language Information].
    /// </summary>
    internal enum DmiType013Property
    {
        #region version 2.0+
        [PropertyName("Installable Languages")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        InstallableLanguages,

        [PropertyName("Is Current Abbreviated")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        IsCurrentAbbreviated,

        [PropertyName("Current")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Current,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType014Property: Defines the properties available for the structure type 014 [Group Associations]
    /// <summary>
    /// Defines the properties available for the structure type 014 [Group Associations].
    /// </summary>
    internal enum DmiType014Property
    {
        [PropertyName("Group Name")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        GroupName,

        [PropertyName("Contained Elements")]
        [PropertyDescription("")]
        [PropertyType(typeof(GroupAssociationElementCollection))]
        ContainedElements,

        [PropertyName("Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        Handle,

        [PropertyName("Structure")]
        [PropertyDescription("")]
        [PropertyType(typeof(SmbiosStructure))]
        Structure,
    }
    #endregion

    #region [internal] (emun) DmiType015Property: Defines the properties available for the structure type 015 [System Event Log]
    /// <summary>
    /// Defines the properties available for the structure type 015 [System Event Log].
    /// </summary>
    internal enum DmiType015Property
    {
        [PropertyName("System Event Log")]
        [PropertyDescription("")]
        SystemEventLog,
    }
    #endregion

    #region [internal] (emun) DmiType016Property: Defines the properties available for the structure type 016 [Physical Memory Array]
    /// <summary>
    /// Defines the properties available for the structure type 016 [Physical Memory Array].
    /// </summary>
    internal enum DmiType016Property
    {
        #region version 2.1+
        [PropertyName("Location")]
        [PropertyDescription("Physical location of the Memory Array, whether on the system board or an add-in board")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Use")]
        [PropertyDescription("Function for which the array is used")]
        [PropertyType(typeof(string))]
        Use,

        [PropertyName("Memory Error Correction")]
        [PropertyDescription("Primary hardware error correction or detection method supported by this memory array")]
        [PropertyType(typeof(string))]
        MemoryErrorCorrection,

        [PropertyName("Memory Error Information Handle")]
        [PropertyDescription("Handle, or instance number, associated with any error that was previously detected for the array")]
        [PropertyType(typeof(string))]
        MemoryErrorInformationHandle,

        [PropertyName("Number Of Memory Devices")]
        [PropertyDescription("Number of slots or sockets available for Memory devices in this array")]
        [PropertyType(typeof(int?))]
        NumberOfMemoryDevices,
        #endregion

        #region version 2.1+ - 2.7+
        [PropertyName("Maximum Capacity")]
        [PropertyDescription("Maximum memory capacity, in kilobytes, for this array")]
        [PropertyType(typeof(ulong?))]
        MaximumCapacity,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType017Property: Defines the properties available for the structure type 017 [Memory Device]
    /// <summary>
    /// Defines the properties available for the structure type 017 [Memory Device].
    /// </summary>
    internal enum DmiType017Property
    {
        #region version 2.1+
        [PropertyName("Physical Memory Array Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        PhysicalMemoryArrayHandle,

        [PropertyName("Memory Error Information Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MemoryErrorInformationHandle,

        [PropertyName("Total Width")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TotalWidth,

        [PropertyName("Data Width")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DataWidth,

        [PropertyName("Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Size,

        [PropertyName("Form Factor")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FormFactor,

        [PropertyName("Device Set")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        DeviceSet,

        [PropertyName("Device Locator")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceLocator,

        [PropertyName("Memory Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryType,

        [PropertyName("Type Detail")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        TypeDetail,
        #endregion

        #region version 2.3+
        [PropertyName("Maximun Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumSpeed,

        [PropertyName("Manufacturer")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Serial Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Asset Tag")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyName("Part Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PartNumber,

        [PropertyName("Rank")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Rank,
        #endregion

        #region version 2.7+
        [PropertyName("Configured Memory Clock Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ConfiguredMemoryClockSpeed,

        [PropertyName("Bank Locator")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BankLocator,
        #endregion

        #region version 2.8+
        [PropertyName("Minimun Voltage")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimumVoltage,

        [PropertyName("Maximum Voltage")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumVoltage,

        [PropertyName("Configured Voltage")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ConfiguredVoltage,
        #endregion

        #region version 3.2+
        [PropertyName("Memory Technology")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryTechnology,

        [PropertyName("Memory Operating Mode Capability")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryOperatingModeCapability,

        [PropertyName("Firmware Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareVersion,

        [PropertyName("Module Manufacturer Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModuleManufacturerId,

        [PropertyName("Module Product Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModuleProductId,

        [PropertyName("Memory Sub System Controller Manufacturer Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MemorySubSystemControllerManufacturerId,

        [PropertyName("Memory Sub System Controller Product Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MemorySubSystemControllerProductId,

        [PropertyName("Non-Volatile Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        NonVolatileSize,

        [PropertyName("Volatile Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        VolatileSize,

        [PropertyName("Cache Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        CacheSize,

        [PropertyName("Logical Size")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        LogicalSize,
        #endregion

        #region version 3.3+
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ExtendedSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ExtendedConfiguredMemorySpeed
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType018Property: Defines the properties available for the structure type 018 [32-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type 018 [32-Bit Memory Error Information].
    /// </summary>
    internal enum DmiType018Property
    {
        #region version 2.1+
        [PropertyName("Error Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorType,

        [PropertyName("Error Granularity")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorGranularity,

        [PropertyName("Error Operation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorOperation,

        [PropertyName("Vendor Syndrome")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        VendorSyndrome,

        [PropertyName("Memory Array Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        MemoryArrayErrorAddress,

        [PropertyName("Device Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        DeviceErrorAddress,

        [PropertyName("Error Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        ErrorResolution,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType019Property: Defines the properties available for the structure type 019 [Memory Array Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 019 [Memory Array Mapped Address].
    /// </summary>
    internal enum DmiType019Property
    {
        #region version 2.1+
        [PropertyName("Memory Array Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryArrayHandle,

        [PropertyName("Partition Width")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        PartitionWidth,
        #endregion

        #region version 2.7+
        [PropertyName("Start Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        StartAddress,

        [PropertyName("End Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        EndAddress,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType020Property: Defines the properties available for the structure type 020 [Memory Device Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 020 [Memory Device Mapped Address].
    /// </summary>
    internal enum DmiType020Property
    {
        #region version 2.1+
        [PropertyName("Start Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        StartAddress,

        [PropertyName("End Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        EndAddress,

        [PropertyName("Memory Device Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryDeviceHandle,

        [PropertyName("Memory Array Mapped Address Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryArrayMappedAddressHandle,

        [PropertyName("Partition Row Position")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        PartitionRowPosition,

        [PropertyName("Interleave Position")]
        [PropertyDescription("")]
        [PropertyType(typeof(MemoryDeviceMappedAddressInterleavedPosition))]
        InterleavePosition,

        [PropertyName("Interleaved Data Depth")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        InterleavedDataDepth,
        #endregion

        #region version 2.7+
        [PropertyName("Extended Starting Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedStartingAddress,

        [PropertyName("Extended Ending Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType021Property: Defines the properties available for the structure type 021 [Built-in Pointing Device]
    /// <summary>
    /// Defines the properties available for the structure type 021 [Built-in Pointing Device].
    /// </summary>
    internal enum DmiType021Property
    {
        #region version 2.1+
        [PropertyName("Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Type,

        [PropertyName("Interface")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Interface,

        [PropertyName("Number Of Buttons")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        NumberOfButtons,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType022Property: Defines the properties available for the structure type 022 [Portable Battery]
    /// <summary>
    /// Defines the properties available for the structure type 022 [Built-in Pointing Device].
    /// </summary>
    internal enum DmiType022Property
    {
        #region version 2.1+
        [PropertyName("Location")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Manufacturer")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Manufacture Date")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ManufactureDate,

        [PropertyName("Serial Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Device Name")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceName,

        [PropertyName("Device Chemistry")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceChemistry,

        [PropertyName("Design Capacity")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DesignCapacity,

        [PropertyName("Design Voltage")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DesignVoltage,

        [PropertyName("SBDS Version Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SbdsVersionNumber,

        [PropertyName("Maximun Error In Battery Data")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        MaximunErrorInBatteryData,
        #endregion

        #region version 2.2+
        [PropertyName("SBDS Serial Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SbdsSerialNumber,

        [PropertyName("SBDS Manufacture Date")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SbdsManufactureDate,

        [PropertyName("SBDS Device Chemistry")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SbdsDeviceChemistry,

        [PropertyName("Design Capacity Multiplier")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DesignCapacityMultiplier,

        [PropertyName("OEM Specific")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        OemSpecific,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType023Property: Defines the properties available for the structure type 023 [System Reset]
    /// <summary>
    /// Defines the properties available for the structure type type 023 [System Reset].
    /// </summary>
    internal enum DmiType023Property
    {
        [PropertyName("Boot Option")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BootOption,

        [PropertyName("Boot Option On Limit")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BootOptionOnLimit,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Watchdog Timer")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        WatchdogTimer,

        [PropertyName("Reset Count")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ResetCount,

        [PropertyName("Reset Limit")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ResetLimit,

        [PropertyName("Timer Interval")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TimerInterval,

        [PropertyName("Timeout")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Timeout,
    }
    #endregion

    #region [internal] (emun) DmiType024Property: Defines the properties available for the structure type 024 [Hardware Security]
    /// <summary>
    /// Defines the properties available for the structure type type 024 [Hardware Security].
    /// </summary>
    internal enum DmiType024Property
    {
        [PropertyName("Front Panel Reset Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FrontPanelResetStatus,

        [PropertyName("Administrator Password Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AdministratorPasswordStatus,

        [PropertyName("Keyboard Password Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        KeyboardPasswordStatus,

        [PropertyName("Power-On Password Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PowerOnPasswordStatus
    }
    #endregion

    #region [internal] (emun) DmiType025Property: Defines the properties available for the structure type 025 [System Power Controls]
    /// <summary>
    /// Defines the properties available for the structure type type 025 [System Power Controls].
    /// </summary>
    internal enum DmiType025Property
    {
        [PropertyName("Month")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Month,

        [PropertyName("Day")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Day,

        [PropertyName("Hour")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Hour,

        [PropertyName("Minute")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Minute,

        [PropertyName("Second")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Second,
    }
    #endregion

    #region [internal] (emun) DmiType026Property: Defines the properties available for the structure type 026 [Voltage Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 026 [Voltage Probe].
    /// </summary>
    internal enum DmiType026Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Location")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Maximun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyName("Minimun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [internal] (emun) DmiType027Property: Defines the properties available for the structure type 027 [Cooling Device]
    /// <summary>
    /// Defines the properties available for the structure type type 027 [Cooling Device].
    /// </summary>
    internal enum DmiType027Property
    {
        #region version 2.2+
        [PropertyName("Temperature Probe Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TemperatureProbeHandle,

        [PropertyName("Device Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Cooling Unit Group")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        CoolingUnitGroup,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyName("Nominal Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalSpeed,
        #endregion

        #region version 2.7+
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType028Property: Defines the properties available for the structure type 028 [Temperature Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 028 [Cooling Device].
    /// </summary>
    internal enum DmiType028Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Location")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Maximun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyName("Minimun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [internal] (emun) DmiType029Property: Defines the properties available for the structure type 029 [Electrical Current Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 029 [Electrical Current Probe].
    /// </summary>
    internal enum DmiType029Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Location")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Maximun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyName("Minimun Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [internal] (emun) DmiType030Property: Defines the properties available for the structure type 030 [Out-of-Band Remote Access]
    /// <summary>
    /// Defines the properties available for the structure type type 030 [Electrical Current Probe].
    /// </summary>
    internal enum DmiType030Property
    {
        [PropertyName("Manufacturer Name")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ManufacturerName,

        [PropertyName("OutBound Connection")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OutBoundConnection,

        [PropertyName("InBound Connection")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InBoundConnection,
    }
    #endregion

    #region [internal] (emun) DmiType031Property: Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point]
    /// <summary>
    /// Defines the properties available for the structure type type 031 [Electrical Current Probe].
    /// </summary>
    internal enum DmiType031Property
    {
        [PropertyName("Checksum")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Checksum,

        [PropertyName("16-Bis Entry Point Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BisEntryPointAddress16,

        [PropertyName("32-Bis Entry Point Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BisEntryPointAddress32,
    }
    #endregion

    #region [internal] (emun) DmiType032Property: Defines the properties available for the structure type 032 [System Boot Information]
    /// <summary>
    /// Defines the properties available for the structure type type 032 [Electrical Current Probe].
    /// </summary>
    internal enum DmiType032Property
    {
        [PropertyName("Reserved")]
        [PropertyDescription("Reserved for future assignment by this specification; all bytes are set to 00h")]
        [PropertyType(typeof(int))]
        Reserved,

        [PropertyName("Boot Status")]
        [PropertyDescription("Status and Additional Data fields that identify the boot status")]
        [PropertyType(typeof(string))]
        BootStatus,
    }
    #endregion

    #region [internal] (emun) DmiType033Property: Defines the properties available for the structure type 033 [64-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type type 033 [64-Bit Memory Error Information].
    /// </summary>
    internal enum DmiType033Property
    {
        [PropertyName("Error Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorType,

        [PropertyName("Error Granularity")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorGranularity,

        [PropertyName("Error Operation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorOperation,

        [PropertyName("Vendor Syndrome")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        VendorSyndrome,

        [PropertyName("Memory Array Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        MemoryArrayErrorAddress,

        [PropertyName("Device Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        DeviceErrorAddress,

        [PropertyName("Error Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        ErrorResolution,
    }
    #endregion

    #region [internal] (emun) DmiType034Property: Defines the properties available for the structure type 034 [Management Device]
    /// <summary>
    /// Defines the properties available for the structure type type 034 [Management Device].
    /// </summary>
    internal enum DmiType034Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Type,

        [PropertyName("Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Address,

        [PropertyName("Address Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AddressType,
    }
    #endregion

    #region [internal] (emun) DmiType035Property: Defines the properties available for the structure type 035 [Management Device Component]
    /// <summary>
    /// Defines the properties available for the structure type type 035 [Management Device Component].
    /// </summary>
    internal enum DmiType035Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Management Device Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ManagementDeviceHandle,

        [PropertyName("Component Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ComponentHandle,

        [PropertyName("Threshold Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ThresholdHandle,
    }
    #endregion

    #region [internal] (emun) DmiType036Property: Defines the properties available for the structure type 036 [Management Device Threshold Data]
    /// <summary>
    /// Defines the properties available for the structure type type 036 [Management Device Threshold Data].
    /// </summary>
    internal enum DmiType036Property
    {
        [PropertyName("Lower Non Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerNonCritical,

        [PropertyName("Upper Non Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperNonCritical,

        [PropertyName("Lower Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerCritical,

        [PropertyName("Upper Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperCritical,

        [PropertyName("Lower Non Recoverable")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerNonRecoverable,

        [PropertyName("Upper Non Recoverable")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperNonRecoverable,
    }
    #endregion

    #region [internal] (emun) DmiType037Property: Defines the properties available for the structure type 037 [Memory Channel]
    /// <summary>
    /// Defines the properties available for the structure type type 037 [Management Device Threshold Data].
    /// </summary>
    internal enum DmiType037Property
    {
        [PropertyName("Channel Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ChannelType,

        [PropertyName("Maximun Channel Load")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MaximunChannelLoad,

        [PropertyName("Devices")]
        [PropertyDescription("")]
        [PropertyType(typeof(MemoryChannelElementCollection))]
        Devices,

        [PropertyName("Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Handle,

        [PropertyName("Load")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Load
    }
    #endregion

    #region [internal] (emun) DmiType038Property: Defines the properties available for the structure type 038 [IPMI Device Information]
    /// <summary>
    /// Defines the properties available for the structure type type 038 [IPMI Device Information].
    /// </summary>
    internal enum DmiType038Property
    {
        [PropertyName("Interface Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InterfaceType,

        [PropertyName("Specification Revision")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SpecificationRevision,

        [PropertyName("I2C Slave Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        I2CSlaveAddress,

        [PropertyName("NV Storage Device Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        NvStorageDeviceAddress,

        [PropertyName("Base Adress")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        BaseAdress,

        [PropertyName("Register Spacing")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        RegisterSpacing,

        [PropertyName("LS-Bit")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        LsBit,

        [PropertyName("Interface Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        SpecifiedInfo,

        [PropertyName("Polarity")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Polarity,

        [PropertyName("Trigger Mode")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        TriggerMode,

        [PropertyName("Interrupt Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        InterruptNumber,
    }
    #endregion

    #region [internal] (emun) DmiType039Property: Defines the properties available for the structure type 039 [System Power Supply]
    /// <summary>
    /// Defines the properties available for the structure type type 039 [System Power Supply].
    /// </summary>
    internal enum DmiType039Property
    {
        [PropertyName("Is Redundant")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsRedundant,

        [PropertyName("Location")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyName("Device Name")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceName,

        [PropertyName("Manufacturer")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyName("Serial Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyName("Asset Tag Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTagNumber,

        [PropertyName("Model Part Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModelPartNumber,

        [PropertyName("Revision Level")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        RevisionLevel,

        [PropertyName("Max Power Capacity")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaxPowerCapacity,

        [PropertyName("Supply Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SupplyType,

        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Input Voltage Range")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InputVoltageRange,

        [PropertyName("Is Plugged")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsPlugged,

        [PropertyName("Entry Length")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsPresent,

        [PropertyName("Is Hot Replaceable")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsHotReplaceable,

        [PropertyName("Input Voltage Probe Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        InputVoltageProbeHandle,

        [PropertyName("Cooling Device Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CoolingDeviceHandle,

        [PropertyName("Input Current Probe Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        InputCurrentProbeHandle,
    }
    #endregion

    #region [internal] (emun) DmiType040Property: Defines the properties available for the structure type 040 [Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type type 040 [Additional Information].
    /// </summary>
    internal enum DmiType040Property
    {
        [PropertyName("Entry Length")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        EntryLength,

        [PropertyName("Referenced Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ReferencedHandle,

        [PropertyName("Referenced Offset")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        ReferencedOffset,

        [PropertyName("String Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        StringValue,

        [PropertyName("Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Value,

        [PropertyName("Entries")]
        [PropertyDescription("")]
        [PropertyType(typeof(AdditionalInformationEntryCollection))]
        Entries,
    }
    #endregion

    #region [internal] (emun) DmiType041Property: Defines the properties available for the structure type 041 [Onboard Devices Extended Information]
    /// <summary>
    /// Defines the properties available for the structure type type 041 [Onboard Devices Extended Information].
    /// </summary>
    internal enum DmiType041Property
    {
        [PropertyName("Reference Designation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ReferenceDesignation,

        [PropertyName("Device Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceStatus,

        [PropertyName("Device Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,
    }
    #endregion

    #region [internal] (emun) DmiType042Property: Defines the properties available for the structure type 042 [Management Controller Host Interface]
    /// <summary>
    /// Defines the properties available for the structure type type 042 [Management Controller Host Interface].
    /// </summary>
    internal enum DmiType042Property
    {
        [PropertyName("Interface Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InterfaceType,

        [PropertyName("Interface Type Specific Data")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        InterfaceTypeSpecificData,

        [PropertyName("Protocols")]
        [PropertyDescription("")]
        [PropertyType(typeof(ManagementControllerHostInterfaceProtocolRecordsCollection))]
        Protocols,

        [PropertyName("Protocol Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProtocolType,

        [PropertyName("Protocol Type Specific Data")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        ProtocolTypeSpecificData,
    }
    #endregion

    #region [internal] (emun) DmiType043Property: Defines the properties available for the structure type 043 [TPM Device]
    /// <summary>
    /// Defines the properties available for the structure type type 043 [TPM Device].
    /// </summary>
    internal enum DmiType043Property
    {
        #region Version 3.1.0+
        [PropertyName("Vendor Id")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        VendorId,

        [PropertyName("Vendor Id Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        VendorIdDescription,

        [PropertyName("Major Spec Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MajorSpecVersion,

        [PropertyName("Minor Spec Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MinorSpecVersion,

        [PropertyName("Firmware Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(TpmFirmwareVersion))]
        FirmwareVersion,

        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OemDefined,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType044Property: Defines the properties available for the structure type 043 [Processor Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type type 044 [Processor Additional Information].
    /// </summary>
    internal enum DmiType044Property
    {
        #region Version 3.3.0+
        [PropertyName("Referenced Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ReferencedHandle,

        [PropertyName("Processor Specific Block")]
        [PropertyDescription("")]
        [PropertyType(typeof(ProcessorSpecificInformationBlock))]
        ProcessorSpecificBlock,
        #endregion
    }
    #endregion

    #region [internal] (emun) DmiType126Property: Defines the properties available for the structure type 126 [Inactive]
    /// <summary>
    /// Defines the properties available for the structure type type 126 [Inactive].
    /// </summary>
    internal enum DmiType126Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [internal] (emun) DmiType127Property: Defines the properties available for the structure type 127 [End-of-Table]
    /// <summary>
    /// Defines the properties available for the structure type type 127 [End-of-Table].
    /// </summary>
    internal enum DmiType127Property
    {
        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,
    }
    #endregion
}
