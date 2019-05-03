
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.ObjectModel;

    #region [private] (emun) SmbiosType000Property: Defines the properties available for the structure type 000 [BIOS Information]
    /// <summary>
    /// Defines the properties available for the structure type 000 [BIOS Information].
    /// </summary>
    enum SmbiosType000Property
    {
        #region version 2.0+
        [PropertyName("BIOS Vendor")]
        [PropertyDescription("BIOS Vendor")]
        [PropertyType(typeof(string))]
        Vendor,

        [PropertyName("BIOS Version")]
        [PropertyDescription("BIOS Version")]
        [PropertyType(typeof(string))]
        BiosVersion,

        [PropertyDescription("Ubicación del segmento de dirección inicial de esta bios")]
        [PropertyType(typeof(string))]
        BiosStartingAddressSegment,

        [PropertyDescription("Date of the version is bios")]
        [PropertyType(typeof(string))]
        BiosReleaseDate,

        [PropertyDescription("Bios size")]
        [PropertyType(typeof(int))]
        BiosRomSize,

        [PropertyDescription("Collection of functions compatible with this bios")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,
        #endregion

        #region version 2.4+
        [PropertyDescription("Collection of functions compatible with this bios")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        ExtensionByte1,

        [PropertyDescription("Collection of functions compatible with this bios")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        ExtensionByte2,

        [PropertyDescription("Version number of this bios")]
        [PropertyType(typeof(byte?))]
        SystemBiosMajorRelease,

        [PropertyDescription("Revision number of this bios")]
        [PropertyType(typeof(byte?))]
        SystemBiosMinorRelease,

        [PropertyDescription("Controller firmware version number for this bios")]
        [PropertyType(typeof(byte?))]
        FirmwareMajorRelease,

        [PropertyDescription("Controller firmware revision number for this bios")]
        [PropertyType(typeof(byte?))]
        FirmwareMinorRelease,
        #endregion

        #region version 3.1.0+
        [PropertyDescription("Extended ROM size")]
        [PropertyType(typeof(int))]
        ExtendedBiosRomSize,

        [PropertyDescription("BIOS ROM size (units)")]
        [PropertyType(typeof(MemorySizeUnit))]
        BiosRomSizeUnit,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType001Property: Defines the properties available for the structure type 001 [System Information]
    /// <summary>
    /// Defines the properties available for the structure type 001 [System Information].
    /// </summary>
    enum SmbiosType001Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProductName,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,
        #endregion

        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        UUID,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        WakeUpType,
        #endregion

        #region version 2.4+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SkuNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Family,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType002Property: Defines the properties available for the structure type 002 [Baseboard (or Module) Information]
    /// <summary>
    /// Defines the properties available for the structure type 002 [Baseboard (or Module) Information].
    /// </summary>
    enum SmbiosType002Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Product,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTag,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        HotSwappable,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        IsReplaceable,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        IsRemovable,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        RequiredDaughterBoard,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        IsHostingBoard,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        LocationInChassis,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ChassisHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BoardType,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        NumberOfContainedObjectHandles,

        [PropertyDescription("")]
        [PropertyType(typeof(BaseBoardContainedElementCollection))]
        ContainedObjectHandles,
    }
    #endregion

    #region [private] (emun) SmbiosType003Property: Defines the properties available for the structure type 003 [System Enclosure or Chassis]
    /// <summary>
    /// Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// </summary>
    enum SmbiosType003Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ChassisType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Locked,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Version,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTagNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BootUpState,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PowerSupplyState,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ThermalState,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SecurityStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        OemDefined,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Height,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        NumberOfPowerCords,

        [PropertyDescription("")]
        [PropertyType(typeof(ChassisContainedElementCollection))]
        ContainedElements,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SkuNumber,

        ContainedElementMinimum,
        ContainedElementMaximun,
        ContainedTypeSelect,
        ContainedType,
    }
    #endregion

    #region [private] (emun) SmbiosType004Property: Defines the properties available for the structure type 004 [Processor Information]
    /// <summary>
    /// Defines the properties available for the structure type 004 [Processor Information].
    /// </summary>
    enum SmbiosType004Property
    {
        #region version 2.0+
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
        [PropertyType(typeof(int?))]
        ExternalClock,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
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
        [PropertyType(typeof(int?))]
        L1CacheHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        L2CacheHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
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
        [PropertyType(typeof(int?))]
        CoreCount,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CoreEnabled,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ThreadCount,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        Capable64Bits,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        MultiCore,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        HardwareThreadPerCore,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        ExecuteProtectionSupport,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        EnhancedVirtualizationInstructions,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        PowerPerformanceControlSupport,
        #endregion

        #region version 3.0+
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        CoreCount2,

        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        CoreEnabled2,

        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        ThreadCount2,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType005Property: Defines the properties available for the structure type 005, obsolete [Memory Controller Information]
    /// <summary>
    /// Defines the properties available for the structure type 005, obsolete [Memory Controller Information].
    /// </summary>
    enum SmbiosType005Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorDetectingMethod,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ErrorCorrectingCapabilities,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SupportedInterleave,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CurrentInterleave,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MaximumMemoryModuleSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSpeeds,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedMemoryTypes,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryModuleVoltages,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        NumberMemorySlots,

        [PropertyDescription("")]
        [PropertyType(typeof(MemoryControllerContainedElementCollection))]
        ContainedMemoryModules,
        #endregion

        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        EnabledErrorCorrectingCapabilities,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType006Property: Defines the properties available for the structure type 006, obsolete [Memory Module Information]
    /// <summary>
    /// Defines the properties available for the structure type 006, obsolete [Memory Module Information].
    /// </summary>
    enum SmbiosType006Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        BankConnections,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
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

    #region [private] (emun) SmbiosType007Property: Defines the properties available for the structure type 007 [Cache Information]
    /// <summary>
    /// Defines the properties available for the structure type 007 [Cache Information].
    /// </summary>
    enum SmbiosType007Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SocketDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OperationalMode,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        CacheEnabled,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CacheLocation,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        CacheSocketed,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        CacheLevel,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
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
        [PropertyType(typeof(uint))]
        MaximumCacheSize2,

        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        InstalledCacheSize2,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType008Property: Defines the properties available for the structure type 008 [Port Connector Information]
    /// <summary>
    /// Defines the properties available for the structure type 008 [Port Connector Information].
    /// </summary>
    enum SmbiosType008Property
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

    #region [private] (emun) SmbiosType009Property: Defines the properties available for the structure type 009 [System Slots]
    /// <summary>
    /// Defines the properties available for the structure type 009 [System Slots].
    /// </summary>
    enum SmbiosType009Property
    {
        #region version 2.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotDataBusWidth,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        CurrentUsage,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotLength,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SlotId,
        #endregion

        #region version 2.0+ - 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SlotCharacteristics,
        #endregion

        #region version 2.6+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SegmentBusFunction,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BusDeviceFunction
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType010Property: Defines the properties available for the structure type 010, obsolete [On Board Devices Information]
    /// <summary>
    /// Defines the properties available for the structure type 010, obsolete [On Board Devices Information].
    /// </summary>
    enum SmbiosType010Property
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

    #region [private] (emun) SmbiosType011Property: Defines the properties available for the structure type 011 [OEM strings]
    /// <summary>
    /// Defines the properties available for the structure type 011 [OEM strings].
    /// </summary>
    enum SmbiosType011Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [private] (emun) SmbiosType012Property: Defines the properties available for the structure type 012 [System Configuration Options]
    /// <summary>
    /// Defines the properties available for the structure type 012 [System Configuration Options].
    /// </summary>
    enum SmbiosType012Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [private] (emun) SmbiosType013Property: Defines the properties available for the structure type 013 [BIOS Language Information]
    /// <summary>
    /// Defines the properties available for the structure type 013 [BIOS Language Information].
    /// </summary>
    enum SmbiosType013Property
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

    #region [private] (emun) SmbiosType014Property: Defines the properties available for the structure type 014 [Group Associations]
    /// <summary>
    /// Defines the properties available for the structure type 014 [Group Associations].
    /// </summary>
    enum SmbiosType014Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        GroupName,

        [PropertyDescription("")]
        [PropertyType(typeof(GroupAssociationElementCollection))]
        ContainedElements,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        Handle,

        [PropertyDescription("")]
        [PropertyType(typeof(SmbiosStructure))]
        Structure,
    }
    #endregion

    #region [private] (emun) SmbiosType015Property: Defines the properties available for the structure type 015 [System Event Log]
    /// <summary>
    /// Defines the properties available for the structure type 015 [System Event Log].
    /// </summary>
    enum SmbiosType015Property
    {
        [PropertyDescription("")]
        SystemEventLog,
    }
    #endregion

    #region [private] (emun) SmbiosType016Property: Defines the properties available for the structure type 016 [Physical Memory Array]
    /// <summary>
    /// Defines the properties available for the structure type 016 [Physical Memory Array].
    /// </summary>
    enum SmbiosType016Property
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
        [PropertyType(typeof(ulong))]
        MaximumCapacity,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        MemoryErrorInformationHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        NumberOfMemoryDevices,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        ExtendedMaximunCapacity,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType017Property: Defines the properties available for the structure type 017 [Memory Device]
    /// <summary>
    /// Defines the properties available for the structure type 017 [Memory Device].
    /// </summary>
    enum SmbiosType017Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        PhysicalMemoryArrayHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryErrorInformationHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TotalWidth,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DataWidth,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Size,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FormFactor,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
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
        [PropertyType(typeof(int?))]
        MaximunSpeed,

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
        [PropertyType(typeof(byte?))]
        Rank,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ConfiguredMemoryClockSpeed,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BankLocator,
        #endregion

        #region version 2.8+
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunVoltage,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximumVoltage,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
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
        [PropertyType(typeof(int?))]
        MemorySubsystemControllerManufacturerId,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MemorySubsystemControllerProductId,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        NonVolatileSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        VolatileSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        CacheSize,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        LogicalSize,

        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType018Property: Defines the properties available for the structure type 018 [32-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type 018 [32-Bit Memory Error Information].
    /// </summary>
    enum SmbiosType018Property
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
        [PropertyType(typeof(long?))]
        VendorSyndrome,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        MemoryArrayErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        DeviceErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        ErrorResolution,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType019Property: Defines the properties available for the structure type 019 [Memory Array Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 019 [Memory Array Mapped Address].
    /// </summary>
    enum SmbiosType019Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryArrayHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        PartitionWidth,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedStartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType020Property: Defines the properties available for the structure type 020 [Memory Device Mapped Address]
    /// <summary>
    /// Defines the properties available for the structure type 020 [Memory Device Mapped Address].
    /// </summary>
    enum SmbiosType020Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        StartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(uint?))]
        EndingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryDeviceHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        MemoryArrayMappedAddressHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        PartitionRowPosition,

        [PropertyDescription("")]
        [PropertyType(typeof(MemoryDeviceMappedAddressInterleavedPosition))]
        InterleavePosition,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        InterleavedDataDepth,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedStartingAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType021Property: Defines the properties available for the structure type 021 [Built-in Pointing Device]
    /// <summary>
    /// Defines the properties available for the structure type 021 [Built-in Pointing Device].
    /// </summary>
    enum SmbiosType021Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Type,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Interface,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        NumberOfButtons,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType022Property: Defines the properties available for the structure type 022 [Portable Battery]
    /// <summary>
    /// Defines the properties available for the structure type 022 [Built-in Pointing Device].
    /// </summary>
    enum SmbiosType022Property
    {
        #region version 2.1+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ManufactureDate,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceName,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceChemistry,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DesignCapacity,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        DesignVoltage,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SBDSVersionNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        MaximunErrorInBatteryData,
        #endregion

        #region version 2.2+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SBDSSerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SBDSManufactureDate,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SBDSDeviceChemistry,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DesignCapacityMultiplier,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        OemSpecific,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType023Property: Defines the properties available for the structure type 023 [System Reset]
    /// <summary>
    /// Defines the properties available for the structure type type 023 [System Reset].
    /// </summary>
    enum SmbiosType023Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BootOption,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BootOptionOnLimit,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        WatchdogTimer,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ResetCount,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ResetLimit,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TimerInterval,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Timeout,
    }
    #endregion

    #region [private] (emun) SmbiosType024Property: Defines the properties available for the structure type 024 [Hardware Security]
    /// <summary>
    /// Defines the properties available for the structure type type 024 [Hardware Security].
    /// </summary>
    enum SmbiosType024Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        FrontPanelResetStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AdministratorPasswordStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        KeyboardPasswordStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        PowerOnPasswordStatus
    }
    #endregion

    #region [private] (emun) SmbiosType025Property: Defines the properties available for the structure type 025 [System Power Controls]
    /// <summary>
    /// Defines the properties available for the structure type type 025 [System Power Controls].
    /// </summary>
    enum SmbiosType025Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Month,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Day,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Hour,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Minute,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        Second,
    }
    #endregion

    #region [private] (emun) SmbiosType026Property: Defines the properties available for the structure type 026 [Voltage Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 026 [Voltage Probe].
    /// </summary>
    enum SmbiosType026Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType027Property: Defines the properties available for the structure type 027 [Cooling Device]
    /// <summary>
    /// Defines the properties available for the structure type type 027 [Cooling Device].
    /// </summary>
    enum SmbiosType027Property
    {
        #region version 2.2+
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        TemperatureProbeHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        CoolingUnitGroup,

        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalSpeed,
        #endregion

        #region version 2.7+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType028Property: Defines the properties available for the structure type 028 [Temperature Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 028 [Cooling Device].
    /// </summary>
    enum SmbiosType028Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType029Property: Defines the properties available for the structure type 029 [Electrical Current Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 029 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType029Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaximunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MinimunValue,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Resolution,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Tolerance,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        Accuracy,

        [PropertyDescription("")]
        [PropertyType(typeof(long))]
        OemDefined,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType030Property: Defines the properties available for the structure type 030 [Out-of-Band Remote Access]
    /// <summary>
    /// Defines the properties available for the structure type type 030 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType030Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ManufacturerName,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OutBoundConnection,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InBoundConnection,
    }
    #endregion

    #region [private] (emun) SmbiosType031Property: Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point]
    /// <summary>
    /// Defines the properties available for the structure type type 031 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType031Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Checksum,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BisEntryPointAddress16,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        BisEntryPointAddress32,
    }
    #endregion

    #region [private] (emun) SmbiosType032Property: Defines the properties available for the structure type 032 [System Boot Information]
    /// <summary>
    /// Defines the properties available for the structure type type 032 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType032Property
    {
        [PropertyDescription("Reserved for future assignment by this specification; all bytes are set to 00h")]
        [PropertyType(typeof(int))]
        Reserved,

        [PropertyDescription("Status and Additional Data fields that identify the boot status")]
        [PropertyType(typeof(string))]
        BootStatus,
    }
    #endregion

    #region [private] (emun) SmbiosType033Property: Defines the properties available for the structure type 033 [64-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type type 033 [64-Bit Memory Error Information].
    /// </summary>
    enum SmbiosType033Property
    {
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
        [PropertyType(typeof(long?))]
        VendorSyndrome,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        MemoryArrayErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong?))]
        DeviceErrorAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(long?))]
        ErrorResolution,
    }
    #endregion

    #region [private] (emun) SmbiosType034Property: Defines the properties available for the structure type 034 [Management Device]
    /// <summary>
    /// Defines the properties available for the structure type type 034 [Management Device].
    /// </summary>
    enum SmbiosType034Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Type,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Address,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AddressType,
    }
    #endregion

    #region [private] (emun) SmbiosType035Property: Defines the properties available for the structure type 035 [Management Device Component]
    /// <summary>
    /// Defines the properties available for the structure type type 035 [Management Device Component].
    /// </summary>
    enum SmbiosType035Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ManagementDeviceHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ComponentHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        ThresholdHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType036Property: Defines the properties available for the structure type 036 [Management Device Threshold Data]
    /// <summary>
    /// Defines the properties available for the structure type type 036 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType036Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerNonCritical,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperNonCritical,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerCritical,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperCritical,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        LowerNonRecoverable,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        UpperNonRecoverable,
    }
    #endregion

    #region [private] (emun) SmbiosType037Property: Defines the properties available for the structure type 037 [Memory Channel]
    /// <summary>
    /// Defines the properties available for the structure type type 037 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType037Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ChannelType,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MaximunChannelLoad,

        [PropertyDescription("")]
        [PropertyType(typeof(MemoryChannelElementCollection))]
        Devices,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Handle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Load
    }
    #endregion

    #region [private] (emun) SmbiosType038Property: Defines the properties available for the structure type 038 [IPMI Device Information]
    /// <summary>
    /// Defines the properties available for the structure type type 038 [IPMI Device Information].
    /// </summary>
    enum SmbiosType038Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InterfaceType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SpecificationRevision,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        I2CSlaveAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        NVStorageDeviceAddress,

        [PropertyDescription("")]
        [PropertyType(typeof(ulong))]
        BaseAdress,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        RegisterSpacing,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        LSBit,

        [PropertyDescription("")]
        [PropertyType(typeof(bool?))]
        SpecifiedInfo,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Polarity,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        TriggerMode,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        InterruptNumber,
    }
    #endregion

    #region [private] (emun) SmbiosType039Property: Defines the properties available for the structure type 039 [System Power Supply]
    /// <summary>
    /// Defines the properties available for the structure type type 039 [System Power Supply].
    /// </summary>
    enum SmbiosType039Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsRedundant,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Location,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceName,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Manufacturer,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        AssetTagNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ModelPartNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        RevisionLevel,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        MaxPowerCapacity,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        SupplyType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InputVoltageRange,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsPlugged,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsPresent,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsHotReplaceable,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        InputVoltageProbeHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        CoolingDeviceHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        InputCurrentProbeHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType040Property: Defines the properties available for the structure type 040 [Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type type 040 [Additional Information].
    /// </summary>
    enum SmbiosType040Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        EntryLength,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        ReferencedHandle,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        ReferencedOffset,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        StringValue,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Value,

        [PropertyDescription("")]
        [PropertyType(typeof(AdditionalInformationEntryCollection))]
        Entries,
    }
    #endregion

    #region [private] (emun) SmbiosType041Property: Defines the properties available for the structure type 041 [Onboard Devices Extended Information]
    /// <summary>
    /// Defines the properties available for the structure type type 041 [Onboard Devices Extended Information].
    /// </summary>
    enum SmbiosType041Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ReferenceDesignation,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceStatus,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        DeviceType,
    }
    #endregion

    #region [private] (emun) SmbiosType042Property: Defines the properties available for the structure type 042 [Management Controller Host Interface]
    /// <summary>
    /// Defines the properties available for the structure type type 042 [Management Controller Host Interface].
    /// </summary>
    enum SmbiosType042Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        InterfaceType,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        InterfaceTypeSpecificData,

        [PropertyDescription("")]
        [PropertyType(typeof(ManagementControllerHostInterfaceProtocolRecordsCollection))]
        Protocols,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        ProtocolType,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        ProtocolTypeSpecificData,
    }
    #endregion

    #region [private] (emun) SmbiosType043Property: Defines the properties available for the structure type 043 [TPM Device]
    /// <summary>
    /// Defines the properties available for the structure type type 043 [TPM Device].
    /// </summary>
    enum SmbiosType043Property
    {
        #region Version 3.1.0+
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        VendorId,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        VendorIdDescription,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MajorSpecVersion,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        MinorSpecVersion,

        [PropertyDescription("")]
        [PropertyType(typeof(TpmFirmwareVersion))]
        FirmwareVersion,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        OemDefined,

        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType126Property: Defines the properties available for the structure type 126 [Inactive]
    /// <summary>
    /// Defines the properties available for the structure type type 126 [Inactive].
    /// </summary>
    enum SmbiosType126Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [private] (emun) SmbiosType127Property: Defines the properties available for the structure type 127 [End-of-Table]
    /// <summary>
    /// Defines the properties available for the structure type type 127 [End-of-Table].
    /// </summary>
    enum SmbiosType127Property
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Status,
    }
    #endregion
}
