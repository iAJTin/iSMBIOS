
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.ObjectModel;

    using iTin.Core.Hardware.Common;

    using Tpm;

    #region [internal] (emun) SmbiosType000Property: Defines the properties available for the structure type 000 [BIOS Information]
    /// <summary>
    /// Defines the properties available for the structure type 000 [BIOS Information].
    /// </summary>
    internal enum SmbiosType000Property
    {
        #region version 2.0+
        [PropertyName("BIOS Vendor")]
        [PropertyDescription("BIOS Vendor's name")]
        [PropertyType(typeof(string))]
        Vendor,

        [PropertyName("BIOS Version")]
        [PropertyDescription("BIOS Version")]
        [PropertyType(typeof(string))]
        BiosVersion,

        [PropertyName("BIOS Start Segment")]
        [PropertyDescription("Segment location of BIOS starting address")]
        [PropertyType(typeof(string))]
        BiosStartSegment,

        [PropertyName("BIOS Release Date")]
        [PropertyDescription("BIOS Release Date")]
        [PropertyType(typeof(string))]
        BiosReleaseDate,

        [PropertyName("BIOS Size")]
        [PropertyDescription("Size of the physical device containing the BIOS")]
        [PropertyType(typeof(byte))]
        BiosRomSize,

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
        [PropertyType(typeof(byte))]
        SystemBiosMajorRelease,

        [PropertyName("System BIOS Minor Release")]
        [PropertyDescription("Minor release of the System BIOS")]
        [PropertyType(typeof(byte))]
        SystemBiosMinorRelease,

        [PropertyName("Embedded Controller Firmware Major Version")]
        [PropertyDescription("Identifies the major release of the embedded controller firmware")]
        [PropertyType(typeof(byte))]
        FirmwareMajorRelease,

        [PropertyName("Embedded Controller Firmware Minor Version")]
        [PropertyDescription("Identifies the minor release of the embedded controller firmware")]
        [PropertyType(typeof(byte))]
        FirmwareMinorRelease,
        #endregion

        #region version 3.1+
        [PropertyName("BIOS Size")]
        [PropertyDescription("Extended size of the physical device(s) containing the BIOS")]
        [PropertyType(typeof(uint))]
        ExtendedBiosRomSize,

        [PropertyName("BIOS ROM Size Units")]
        [PropertyDescription("Size of the physical device(s) containing the BIOS")]
        [PropertyType(typeof(MemorySizeUnit))]
        BiosRomSizeUnit,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType001Property: Defines the properties available for the structure type 001 [System Information]
    /// <summary>
    /// Defines the properties available for the structure type 001 [System Information].
    /// </summary>
    internal enum SmbiosType001Property
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

    #region [internal] (emun) SmbiosType002Property: Defines the properties available for the structure type 002 [Baseboard (or Module) Information]
    /// <summary>
    /// Defines the properties available for the structure type 002 [Baseboard (or Module) Information].
    /// </summary>
    internal enum SmbiosType002Property
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
        [PropertyType(typeof(bool))]
        HotSwappable,

        [PropertyName("Replaceable")]
        [PropertyDescription("The mainboard is replaceable")]
        [PropertyType(typeof(bool))]
        IsReplaceable,

        [PropertyName("Removable")]
        [PropertyDescription("The mainboard is removable")]
        [PropertyType(typeof(bool))]
        IsRemovable,

        [PropertyName("Required Daughter Board")]
        [PropertyDescription("The mainboard required daughter board")]
        [PropertyType(typeof(bool))]
        RequiredDaughterBoard,

        [PropertyName("Hosting Board")]
        [PropertyDescription("Determines if is hosting board")]
        [PropertyType(typeof(bool))]
        IsHostingBoard,

        [PropertyName("Location In Chassis")]
        [PropertyDescription("String that describes this board's location")]
        [PropertyType(typeof(string))]
        LocationInChassis,

        [PropertyName("Chassis Handle")]
        [PropertyDescription("Handle, or instance number, associated with the chassis in which this board resides")]
        [PropertyType(typeof(ushort))]
        ChassisHandle,

        [PropertyName("Mainboard Type")]
        [PropertyDescription("Type of board")]
        [PropertyType(typeof(string))]
        BoardType,

        [PropertyName("Mainboard Number Of Contained Object Handles")]
        [PropertyDescription("Number (0 to 255) of contained Object Handles that follow")]
        [PropertyType(typeof(byte))]
        NumberOfContainedObjectHandles,

        [PropertyName("Mainboard Contained Object Handles")]
        [PropertyDescription("List of handles of other structures (for examples, Baseboard, Processor, Port, System Slots, Memory Device) that are contained by this baseboard")]
        [PropertyType(typeof(BaseBoardContainedElementCollection))]
        ContainedObjectHandles,
    }
    #endregion

    #region [internal] (emun) SmbiosType003Property: Defines the properties available for the structure type 003 [System Enclosure or Chassis]
    /// <summary>
    /// Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// </summary>
    internal enum SmbiosType003Property
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
        [PropertyType(typeof(uint))]
        OemDefined,

        [PropertyName("Height")]
        [PropertyDescription("Height of the enclosure, in 'U's  A U is a standard unit of measure for the height of a rack or rack-mountable component")]
        [PropertyType(typeof(byte))]
        Height,

        [PropertyName("Number Of Power Cords")]
        [PropertyDescription("Number of power cords associated with the enclosure or chassis")]
        [PropertyType(typeof(byte))]
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

        [PropertyName("Contained Element Maximum")]
        [PropertyDescription("Specifies the maximum number of the element type that can be installed in the chassis, in the range 1 to 255")]
        [PropertyType(typeof(byte))]
        ContainedElementMaximum,

        [PropertyName("Contained Type Select")]
        [PropertyDescription("Specifies the minimum number of the element type that can be installed in the chassis for the chassis to properly operate, in the range 0 to 254")]
        [PropertyType(typeof(byte))]
        ContainedElementMinimum
    }
    #endregion

    #region [internal] (emun) SmbiosType004Property: Defines the properties available for the structure type 004 [Processor Information]
    /// <summary>
    /// Defines the properties available for the structure type 004 [Processor Information].
    /// </summary>
    internal enum SmbiosType004Property
    {
        #region version 2.0+
        [PropertyName("Socket Designation")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorFamily,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorManufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorId,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorVersion,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsLegacyMode,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        VoltageCapability,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ExternalClock,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MaximumSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        CurrentSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        SocketPopulated,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CpuStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProcessorUpgrade,
        #endregion

        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        L1CacheHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        L2CacheHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        L3CacheHandle,
        #endregion

        #region version 2.3+
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PartNumber,
        #endregion

        #region version 2.6+
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        CoreCount,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        CoreEnabled,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        ThreadCount,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        Capable64Bits,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        Capable128Bits,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        Arm64SocIdSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        MultiCore,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        HardwareThreadPerCore,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        ExecuteProtectionSupport,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        EnhancedVirtualizationInstructions,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        PowerPerformanceControlSupport,
        #endregion

        #region version 3.0+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        CoreCount2,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        CoreEnabled2,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ThreadCount2,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType005Property: Defines the properties available for the structure type 005, obsolete [Memory Controller Information]
    /// <summary>
    /// Defines the properties available for the structure type 005, obsolete [Memory Controller Information].
    /// </summary>
    internal enum SmbiosType005Property
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
        [PropertyType(typeof(int))]
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
        [PropertyType(typeof(ushort))]
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

    #region [internal] (emun) SmbiosType006Property: Defines the properties available for the structure type 006, obsolete [Memory Module Information]
    /// <summary>
    /// Defines the properties available for the structure type 006, obsolete [Memory Module Information].
    /// </summary>
    internal enum SmbiosType006Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        BankConnections,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        CurrentSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        CurrentMemoryType,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        InstalledSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        EnabledSize,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorStatus,
    }
    #endregion

    #region [internal] (emun) SmbiosType007Property: Defines the properties available for the structure type 007 [Cache Information]
    /// <summary>
    /// Defines the properties available for the structure type 007 [Cache Information].
    /// </summary>
    internal enum SmbiosType007Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OperationalMode,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        CacheEnabled,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CacheLocation,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        CacheSocketed,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        CacheLevel,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumCacheSize,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        InstalledCacheSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSramTypes,
        #endregion

        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CurrentSramType,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        CacheSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorCorrectionType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SystemCacheType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Associativity,
        #endregion

        #region version 3.1+
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        MaximumCacheSize2,

        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        InstalledCacheSize2,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType008Property: Defines the properties available for the structure type 008 [Port Connector Information]
    /// <summary>
    /// Defines the properties available for the structure type 008 [Port Connector Information].
    /// </summary>
    internal enum SmbiosType008Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InternalReferenceDesignator,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InternalConnectorType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ExternalReferenceDesignator,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ExternalConnectorType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PortType,
    }
    #endregion

    #region [internal] (emun) SmbiosType009Property: Defines the properties available for the structure type 009 [System Slots]
    /// <summary>
    /// Defines the properties available for the structure type 009 [System Slots].
    /// </summary>
    internal enum SmbiosType009Property
    {
        #region version 2.0+
        [PropertyName("Slot Designation")]
        [PropertyDescription("String number for reference designation")]
        [PropertyType(typeof(string))]
        SlotDesignation,

        [PropertyName("Slot Type")]
        [PropertyDescription("Slot Type")]
        [PropertyType(typeof(string))]
        SlotType,

        [PropertyName("Slot Data Bus Width")]
        [PropertyDescription("Slot Data Bus Width")]
        [PropertyType(typeof(string))]
        SlotDataBusWidth,

        [PropertyName("Current Usage")]
        [PropertyDescription("Slot Current Usage")]
        [PropertyType(typeof(string))]
        CurrentUsage,

        [PropertyName("Slot Length")]
        [PropertyDescription("Slot Length")]
        [PropertyType(typeof(string))]
        SlotLength,

        [PropertyName("Slot Id")]
        [PropertyDescription("Slot Identifier")]
        [PropertyType(typeof(string))]
        SlotId,
        #endregion

        #region version 2.0+ - 2.1+
        [PropertyName("Slot Characteristics")]
        [PropertyDescription("Slot Characteristics")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SlotCharacteristics,
        #endregion

        #region version 2.6+
        [PropertyName("Segment Bus Function")]
        [PropertyDescription("Segment Bus Function")]
        [PropertyType(typeof(string))]
        SegmentBusFunction,

        [PropertyName("Bus Device Function")]
        [PropertyDescription("Bus Device Function")]
        [PropertyType(typeof(string))]
        BusDeviceFunction,
        #endregion

        #region version 3.2
        [PropertyName("Peers Devices")]
        [PropertyDescription("Peers Devices")]
        [PropertyType(typeof(PeerDevicesCollection))]
        PeerDevices,

        [PropertyName("Segment Group Number")]
        [PropertyDescription("Defined in the PCI Firmware Specification")]
        [PropertyType(typeof(ushort))]
        SegmentGroupNumber,

        [PropertyName("Bus Device Function")]
        [PropertyDescription("Bus Device Function (Peer)")]
        [PropertyType(typeof(string))]
        BusDeviceFunctionPeer,

        [PropertyName("Data Bus Width")]
        [PropertyDescription("Data Bus Width (Peer)")]
        [PropertyType(typeof(byte))]
        DataBusWidth,
        #endregion

        #region version 3.4
        [PropertyName("Slot Information")]
        [PropertyDescription("The PCI Express Generation")]
        [PropertyType(typeof(string))]
        SlotInformation,

        [PropertyName("Slot Physical Width")]
        [PropertyDescription("Indicates the physical width of the slot")]
        [PropertyType(typeof(string))]
        SlotPhysicalWidth,

        [PropertyName("Slot Pitch")]
        [PropertyDescription("Indicates the pitch of the slot in units of 1/100 millimeter")]
        [PropertyType(typeof(int))]
        SlotPitch,
        #endregion

        #region version 3.5
        [PropertyName("Slot Height")]
        [PropertyDescription("Indicates the maximum supported card height for the slot")]
        [PropertyType(typeof(byte))]
        SlotHeight
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType010Property: Defines the properties available for the structure type 010, obsolete [On Board Devices Information]
    /// <summary>
    /// Defines the properties available for the structure type 010, obsolete [On Board Devices Information].
    /// </summary>
    internal enum SmbiosType010Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        Enabled,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [internal] (emun) SmbiosType011Property: Defines the properties available for the structure type 011 [OEM strings]
    /// <summary>
    /// Defines the properties available for the structure type 011 [OEM strings].
    /// </summary>
    internal enum SmbiosType011Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [internal] (emun) SmbiosType012Property: Defines the properties available for the structure type 012 [System Configuration Options]
    /// <summary>
    /// Defines the properties available for the structure type 012 [System Configuration Options].
    /// </summary>
    internal enum SmbiosType012Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [internal] (emun) SmbiosType013Property: Defines the properties available for the structure type 013 [BIOS Language Information]
    /// <summary>
    /// Defines the properties available for the structure type 013 [BIOS Language Information].
    /// </summary>
    internal enum SmbiosType013Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        InstallableLanguages,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsCurrentAbbreviated,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Current,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType014Property: Defines the properties available for the structure type 014 [Group Associations]
    /// <summary>
    /// Defines the properties available for the structure type 014 [Group Associations].
    /// </summary>
    internal enum SmbiosType014Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        GroupName,

        [PropertyDescription("")]
        [PropertyType(typeof(GroupAssociationElementCollection))]
        ContainedElements,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Handle,

        [PropertyDescription("")]
        [PropertyType(typeof(SmbiosStructure))]
        Structure,
    }
    #endregion

    #region [internal] (emun) SmbiosType015Property: Defines the properties available for the structure type 015 [System Event Log]
    /// <summary>
    /// Defines the properties available for the structure type 015 [System Event Log].
    /// </summary>
    internal enum SmbiosType015Property
    {
        [PropertyName("Log Area Length")]
        [PropertyDescription("The length, in bytes, of the overall event log area")]
        [PropertyType(typeof(int))]
        LogAreaLength,

        [PropertyName("Log Header")]
        [PropertyDescription("Defines the starting offset (or index) within the nonvolatile storage of the event-log’s header from the Access Method Address")]
        [PropertyType(typeof(string))]
        LogHeaderStartOffset,

        [PropertyName("Data Start Offset")]
        [PropertyDescription("Defines the starting offset (or index) within the nonvolatile storage of the event-log’s first data byte, from the Access Method Address")]
        [PropertyType(typeof(int))]
        DataStartOffset,

        [PropertyName("Access Method")]
        [PropertyDescription("Defines the Location and Method used by higher-level software to access the log area")]
        [PropertyType(typeof(string))]
        AccessMethod,

        [PropertyName("Log Status")]
        [PropertyDescription("Current status of the system event-log")]
        [PropertyType(typeof(string))]
        LogStatus,

        [PropertyName("Access Method Address")]
        [PropertyDescription("Access Method Address")]
        [PropertyType(typeof(string))]
        AccessMethodAddress,

        [PropertyName("Log Change Token")]
        [PropertyDescription("Unique token that is reassigned every time the event log changes")]
        [PropertyType(typeof(string))]
        LogChangeToken,

        [PropertyName("Log Header Format")]
        [PropertyDescription("Format of the log header area")]
        [PropertyType(typeof(string))]
        LogHeaderFormat,

        [PropertyName("Supported Log Type Descriptors")]
        [PropertyDescription("Number of supported event log type descriptors")]
        [PropertyType(typeof(byte))]
        SupportedLogTypeDescriptors,

        [PropertyName("List Supported Event Log Type Descriptors")]
        [PropertyDescription("List of Event Log Type Descriptors")]
        [PropertyType(typeof(SupportedEventLogTypeDescriptorsCollection))]
        ListSupportedEventLogTypeDescriptors,
    }
    #endregion

    #region [internal] (emun) SmbiosType016Property: Defines the properties available for the structure type 016 [Physical Memory Array]
    /// <summary>
    /// Defines the properties available for the structure type 016 [Physical Memory Array].
    /// </summary>
    internal enum SmbiosType016Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Use,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryErrorCorrection,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        MaximumCapacity,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryErrorInformationHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        NumberOfMemoryDevices,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedMaximumCapacity,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType017Property: Defines the properties available for the structure type 017 [Memory Device]
    /// <summary>
    /// Defines the properties available for the structure type 017 [Memory Device].
    /// </summary>
    internal enum SmbiosType017Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        PhysicalMemoryArrayHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemoryErrorInformationHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        TotalWidth,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        DataWidth,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Size,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FormFactor,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        DeviceSet,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceLocator,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryType,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        TypeDetail,
        #endregion

        #region version 2.3+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Speed,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PartNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Rank,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        ExtendedSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ConfiguredMemoryClockSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BankLocator,
        #endregion

        #region version 2.8+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MinimumVoltage,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MaximumVoltage,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ConfiguredVoltage,
        #endregion

        #region version 3.2+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryTechnology,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryOperatingModeCapability,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareVersion,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModuleManufacturerId,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModuleProductId,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemorySubSystemControllerManufacturerId,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemorySubSystemControllerProductId,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        NonVolatileSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        VolatileSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        CacheSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        LogicalSize,

        #endregion

        #region version 3.3+
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ExtendedSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ExtendedConfiguredMemorySpeed
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType018Property: Defines the properties available for the structure type 018 [32-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type 018 [32-Bit Memory Error Information].
    /// </summary>
    internal enum SmbiosType018Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorGranularity,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorOperation,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        VendorSyndrome,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        MemoryArrayErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        DeviceErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        ErrorResolution
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType019Property: Defines the properties available for the structure type 019 [Memory Array Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 019 [Memory Array Mapped Address].
    /// </summary>
    internal enum SmbiosType019Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        StartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        EndingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemoryArrayHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        PartitionWidth,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedStartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType020Property: Defines the properties available for the structure type 020 [Memory Device Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 020 [Memory Device Mapped Address].
    /// </summary>
    internal enum SmbiosType020Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        StartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        EndingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemoryDeviceHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MemoryArrayMappedAddressHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        PartitionRowPosition,

        [PropertyDescription("")]
        [PropertyType(typeof(MemoryDeviceMappedAddressInterleavedPosition))]
        InterleavePosition,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        InterleavedDataDepth,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedStartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedEndingAddress
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType021Property: Defines the properties available for the structure type 021 [Built-in Pointing Device]
    /// <summary>
    /// Defines the properties available for the structure type 021 [Built-in Pointing Device].
    /// </summary>
    internal enum SmbiosType021Property
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

    #region [internal] (emun) SmbiosType022Property: Defines the properties available for the structure type 022 [Portable Battery]
    /// <summary>
    /// Defines the properties available for the structure type 022 [Built-in Pointing Device].
    /// </summary>
    internal enum SmbiosType022Property
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
        [PropertyType(typeof(ushort))]
        DesignCapacity,

        [PropertyName("Design Voltage")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        DesignVoltage,

        [PropertyName("SBDS Version Number")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SbdsVersionNumber,

        [PropertyName("Maximun Error In Battery Data")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
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
        [PropertyType(typeof(byte))]
        DesignCapacityMultiplier,

        [PropertyName("OEM Specific")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        OemSpecific,
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType023Property: Defines the properties available for the structure type 023 [System Reset]
    /// <summary>
    /// Defines the properties available for the structure type 023 [System Reset].
    /// </summary>
    internal enum SmbiosType023Property
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
        [PropertyType(typeof(ushort))]
        ResetCount,

        [PropertyName("Reset Limit")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ResetLimit,

        [PropertyName("Timer Interval")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        TimerInterval,

        [PropertyName("Timeout")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Timeout,
    }
    #endregion

    #region [internal] (emun) SmbiosType024Property: Defines the properties available for the structure type 024 [Hardware Security]
    /// <summary>
    /// Defines the properties available for the structure type 024 [Hardware Security].
    /// </summary>
    internal enum SmbiosType024Property
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

    #region [internal] (emun) SmbiosType025Property: Defines the properties available for the structure type 025 [System Power Controls]
    /// <summary>
    /// Defines the properties available for the structure type 025 [System Power Controls].
    /// </summary>
    internal enum SmbiosType025Property
    {
        [PropertyName("Month")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Month,

        [PropertyName("Day")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Day,

        [PropertyName("Hour")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Hour,

        [PropertyName("Minute")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Minute,

        [PropertyName("Second")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Second,
    }
    #endregion

    #region [internal] (emun) SmbiosType026Property: Defines the properties available for the structure type 026 [Voltage Probe]
    /// <summary>
    /// Defines the properties available for the structure type 026 [Voltage Probe].
    /// </summary>
    internal enum SmbiosType026Property
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

        [PropertyName("Maximum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MaximumValue,

        [PropertyName("Minimum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MinimumValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        NominalValue,
    }
    #endregion

    #region [internal] (emun) SmbiosType027Property: Defines the properties available for the structure type 027 [Cooling Device]
    /// <summary>
    /// Defines the properties available for the structure type 027 [Cooling Device].
    /// </summary>
    internal enum SmbiosType027Property
    {
        #region version 2.2+
        [PropertyName("Temperature Probe Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
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
        [PropertyType(typeof(byte))]
        CoolingUnitGroup,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        OemDefined,

        [PropertyName("Nominal Speed")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
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

    #region [internal] (emun) SmbiosType028Property: Defines the properties available for the structure type 028 [Temperature Probe]
    /// <summary>
    /// Defines the properties available for the structure type 028 [Temperature Probe].
    /// </summary>
    internal enum SmbiosType028Property
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

        [PropertyName("Maximum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MaximumValue,

        [PropertyName("Minimum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MinimumValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        NominalValue
    }
    #endregion

    #region [internal] (emun) SmbiosType029Property: Defines the properties available for the structure type 029 [Electrical Current Probe]
    /// <summary>
    /// Defines the properties available for the structure type 029 [Electrical Current Probe].
    /// </summary>
    internal enum SmbiosType029Property
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

        [PropertyName("Maximum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MaximumValue,

        [PropertyName("Minimum Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        MinimumValue,

        [PropertyName("Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Resolution,

        [PropertyName("Tolerance")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Tolerance,

        [PropertyName("Accuracy")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Accuracy,

        [PropertyName("OEM Defined")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        OemDefined,

        [PropertyName("Nominal Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        NominalValue
    }
    #endregion

    #region [internal] (emun) SmbiosType030Property: Defines the properties available for the structure type 030 [Out-of-Band Remote Access]
    /// <summary>
    /// Defines the properties available for the structure type 030 [Out-of-Band Remote Access].
    /// </summary>
    internal enum SmbiosType030Property
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
        InBoundConnection
    }
    #endregion

    #region [internal] (emun) SmbiosType031Property: Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point]
    /// <summary>
    /// Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point].
    /// </summary>
    internal enum SmbiosType031Property
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
        BisEntryPointAddress32
    }
    #endregion

    #region [internal] (emun) SmbiosType032Property: Defines the properties available for the structure type 032 [System Boot Information]
    /// <summary>
    /// Defines the properties available for the structure type 032 [System Boot Information].
    /// </summary>
    internal enum SmbiosType032Property
    {
        [PropertyName("Reserved")]
        [PropertyDescription("Reserved for future assignment by this specification; all bytes are set to 00h")]
        [PropertyType(typeof(int))]
        Reserved,

        [PropertyName("Boot Status")]
        [PropertyDescription("Status and Additional Data fields that identify the boot status")]
        [PropertyType(typeof(string))]
        BootStatus
    }
    #endregion

    #region [internal] (emun) SmbiosType033Property: Defines the properties available for the structure type 033 [64-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type 033 [64-Bit Memory Error Information].
    /// </summary>
    internal enum SmbiosType033Property
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
        [PropertyType(typeof(uint))]
        VendorSyndrome,

        [PropertyName("Memory Array Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        MemoryArrayErrorAddress,

        [PropertyName("Device Error Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        DeviceErrorAddress,

        [PropertyName("Error Resolution")]
        [PropertyDescription("")]
        [PropertyType(typeof(uint))]
        ErrorResolution
    }
    #endregion

    #region [internal] (emun) SmbiosType034Property: Defines the properties available for the structure type 034 [Management Device]
    /// <summary>
    /// Defines the properties available for the structure type 034 [Management Device].
    /// </summary>
    internal enum SmbiosType034Property
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
        AddressType
    }
    #endregion

    #region [internal] (emun) SmbiosType035Property: Defines the properties available for the structure type 035 [Management Device Component]
    /// <summary>
    /// Defines the properties available for the structure type 035 [Management Device Component].
    /// </summary>
    internal enum SmbiosType035Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyName("Management Device Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ManagementDeviceHandle,

        [PropertyName("Component Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ComponentHandle,

        [PropertyName("Threshold Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ThresholdHandle
    }
    #endregion

    #region [internal] (emun) SmbiosType036Property: Defines the properties available for the structure type 036 [Management Device Threshold Data]
    /// <summary>
    /// Defines the properties available for the structure type 036 [Management Device Threshold Data].
    /// </summary>
    internal enum SmbiosType036Property
    {
        [PropertyName("Lower Non Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        LowerNonCritical,

        [PropertyName("Upper Non Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        UpperNonCritical,

        [PropertyName("Lower Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        LowerCritical,

        [PropertyName("Upper Critical")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        UpperCritical,

        [PropertyName("Lower Non Recoverable")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        LowerNonRecoverable,

        [PropertyName("Upper Non Recoverable")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        UpperNonRecoverable
    }
    #endregion

    #region [internal] (emun) SmbiosType037Property: Defines the properties available for the structure type 037 [Memory Channel]
    /// <summary>
    /// Defines the properties available for the structure type 037 [Memory Channel].
    /// </summary>
    internal enum SmbiosType037Property
    {
        [PropertyName("Channel Type")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ChannelType,

        [PropertyName("Maximum Channel Load")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MaximumChannelLoad,

        [PropertyName("Devices")]
        [PropertyDescription("")]
        [PropertyType(typeof(MemoryChannelElementCollection))]
        Devices,

        [PropertyName("Load")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Load,

        [PropertyName("Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        Handle
    }
    #endregion

    #region [internal] (emun) SmbiosType038Property: Defines the properties available for the structure type 038 [IPMI Device Information]
    /// <summary>
    /// Defines the properties available for the structure type 038 [IPMI Device Information].
    /// </summary>
    internal enum SmbiosType038Property
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
        [PropertyType(typeof(byte))]
        NvStorageDeviceAddress,

        [PropertyName("Base Address")]
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        BaseAddress,

        [PropertyName("Register Spacing")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        RegisterSpacing,

        [PropertyName("LS-Bit")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        LsBit,

        [PropertyName("Specified Info")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
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
        [PropertyType(typeof(byte))]
        InterruptNumber
    }
    #endregion

    #region [internal] (emun) SmbiosType039Property: Defines the properties available for the structure type 039 [System Power Supply]
    /// <summary>
    /// Defines the properties available for the structure type 039 [System Power Supply].
    /// </summary>
    internal enum SmbiosType039Property
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
        [PropertyType(typeof(ushort))]
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
        [PropertyType(typeof(ushort))]
        InputVoltageProbeHandle,

        [PropertyName("Cooling Device Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        CoolingDeviceHandle,

        [PropertyName("Input Current Probe Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        InputCurrentProbeHandle
    }
    #endregion

    #region [internal] (emun) SmbiosType040Property: Defines the properties available for the structure type 040 [Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type 040 [Additional Information].
    /// </summary>
    internal enum SmbiosType040Property
    {
        [PropertyName("Entry Length")]
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        EntryLength,

        [PropertyName("Referenced Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
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
        Entries
    }
    #endregion

    #region [internal] (emun) SmbiosType041Property: Defines the properties available for the structure type 041 [Onboard Devices Extended Information]
    /// <summary>
    /// Defines the properties available for the structure type 041 [Onboard Devices Extended Information].
    /// </summary>
    internal enum SmbiosType041Property
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
        DeviceType
    }
    #endregion

    #region [internal] (emun) SmbiosType042Property: Defines the properties available for the structure type 042 [Management Controller Host Interface]
    /// <summary>
    /// Defines the properties available for the structure type 042 [Management Controller Host Interface].
    /// </summary>
    internal enum SmbiosType042Property
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
        ProtocolTypeSpecificData
    }
    #endregion

    #region [internal] (emun) SmbiosType043Property: Defines the properties available for the structure type 043 [TPM Device]
    /// <summary>
    /// Defines the properties available for the structure type 043 [TPM Device].
    /// </summary>
    internal enum SmbiosType043Property
    {
        #region Version 3.1+
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

    #region [internal] (emun) SmbiosType044Property: Defines the properties available for the structure type 044 [Processor Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type 044 [Processor Additional Information].
    /// </summary>
    internal enum SmbiosType044Property
    {
        #region Version 3.3+
        [PropertyName("Referenced Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(ushort))]
        ReferencedHandle,

        [PropertyName("Processor Specific Block")]
        [PropertyDescription("")]
        [PropertyType(typeof(ProcessorSpecificInformationBlock))]
        ProcessorSpecificBlock
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType045Property: Defines the properties available for the structure type 045 [Firmware Inventory Information]
    /// <summary>
    /// Defines the properties available for the structure type 045 [Firmware Inventory Information].
    /// </summary>
    internal enum SmbiosType045Property
    {
        #region Version 3.5+
        [PropertyName("Firmware Component Name")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareComponentName,

        [PropertyName("Firmware Version")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareVersion,

        [PropertyName("Firmware Version Format")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareVersionFormat,

        [PropertyName("Firmware ID")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FirmwareId,

        [PropertyName("Firmware ID Format")]
        [PropertyDescription("Describes the format of the Firmware ID")]
        [PropertyType(typeof(string))]
        FirmwareIdFormat,

        [PropertyName("Firmware Release Date")]
        [PropertyDescription("String number of the firmware release date")]
        [PropertyType(typeof(string))]
        FirmwareReleaseDate,

        [PropertyName("Firmware Manufacturer")]
        [PropertyDescription("String number of the manufacturer or producer of this firmware")]
        [PropertyType(typeof(string))]
        FirmwareManufacturer,

        [PropertyName("Lowest Supported Firmware Version")]
        [PropertyDescription("String number of the manufacturer or producer of this firmware")]
        [PropertyType(typeof(string))]
        LowestSupportedFirmwareVersion,

        [PropertyName("Firmware Image Size")]
        [PropertyDescription("Size of the firmware image that is currently programmed in the device, in bytes")]
        [PropertyType(typeof(ulong))]
        FirmwareImageSize,

        [PropertyName("Firmware Characteristics")]
        [PropertyDescription("Firmware characteristics information")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        FirmwareCharacteristics,

        [PropertyName("Firmware State")]
        [PropertyDescription("Firmware state information")]
        [PropertyType(typeof(string))]
        FirmwareState,

        [PropertyName("Number Of Associated Components")]
        [PropertyDescription("Defines how many Associated Component Handles are associated with this firmware")]
        [PropertyType(typeof(byte))]
        NumberOfAssociatedComponents,

        [PropertyName("Associated Component Handles")]
        [PropertyDescription("Lists the SMBIOS structure handles that are associated with this firmware")]
        [PropertyType(typeof(ReadOnlyCollection<uint>))]
        AssociatedComponentHandles

        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType046Property: Defines the properties available for the structure type 044 [Processor Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type 044 [Processor Additional Information].
    /// </summary>
    internal enum SmbiosType046Property
    {
        #region Version 3.5+
        [PropertyName("String Property ID")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PropertyId,

        [PropertyName("String Property Value")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PropertyValue,

        [PropertyName("Parent Handle")]
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ParentHandle
        #endregion
    }
    #endregion

    #region [internal] (emun) SmbiosType126Property: Defines the properties available for the structure type 126 [Inactive]
    /// <summary>
    /// Defines the properties available for the structure type 126 [Inactive].
    /// </summary>
    internal enum SmbiosType126Property
    {
        [PropertyName("Description")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [internal] (emun) SmbiosType127Property: Defines the properties available for the structure type 127 [End-of-Table]
    /// <summary>
    /// Defines the properties available for the structure type 127 [End-of-Table].
    /// </summary>
    internal enum SmbiosType127Property
    {
        [PropertyName("Status")]
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,
    }
    #endregion
}
