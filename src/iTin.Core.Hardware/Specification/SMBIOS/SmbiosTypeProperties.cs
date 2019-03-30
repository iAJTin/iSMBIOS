
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.ObjectModel;

    using Device.DeviceProperty;

    #region [private] (emun) SmbiosType000Property: Defines the properties available for the structure type 000 [BIOS Information]
    /// <summary>
    /// Defines the properties available for the structure type 000 [BIOS Information].
    /// </summary>
    enum SmbiosType000Property
    {
        #region version 2.0+
        [DevicePropertyDescription("Vendedor de esta bios")]
        [DevicePropertyType(typeof(string))]
        Vendor,

        [DevicePropertyDescription("Version de esta bios")]
        [DevicePropertyType(typeof(string))]
        BiosVersion,

        [DevicePropertyDescription("Ubicación del segmento de dirección inicial de esta bios")]
        [DevicePropertyType(typeof(string))]
        BiosStartingAddressSegment,

        [DevicePropertyDescription("Fecha de la versión esta bios")]
        [DevicePropertyType(typeof(string))]
        BiosReleaseDate,

        [DevicePropertyDescription("Tamaño de esta bios")]
        [DevicePropertyType(typeof(int))]
        BiosRomSize,

        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,
        #endregion

        #region version 2.4+
        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        ExtensionByte1,

        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        ExtensionByte2,

        [DevicePropertyDescription("Número de versión de esta bios")]
        [DevicePropertyType(typeof(byte?))]
        SystemBiosMajorRelease,

        [DevicePropertyDescription("Número de revisión de esta bios")]
        [DevicePropertyType(typeof(byte?))]
        SystemBiosMinorRelease,

        [DevicePropertyDescription("Número de versión del firmware del controlador de esta bios")]
        [DevicePropertyType(typeof(byte?))]
        FirmwareMajorRelease,

        [DevicePropertyDescription("Número de revisón del firmware del controlador de esta bios")]
        [DevicePropertyType(typeof(byte?))]
        FirmwareMinorRelease,
        #endregion

        #region version 3.1.0+
        [DevicePropertyDescription("Tamaño extendido de la ROM")]
        [DevicePropertyType(typeof(int))]
        ExtendedBiosRomSize,

        [DevicePropertyDescription("Tamaño extendido de la ROM (undades)")]
        [DevicePropertyType(typeof(MemorySizeUnit))]
        ExtendedBiosRomSizeUnit,
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProductName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        UUID,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        WakeUpType,
        #endregion

        #region version 2.4+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SkuNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Product,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        HotSwappable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        IsReplaceable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        IsRemovable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        RequiredDaughterBoard,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        IsHostingBoard,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        LocationInChassis,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ChassisHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BoardType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        NumberOfContainedObjectHandles,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(BaseBoardContainedElementCollection))]
        ContainedObjectHandles,
    }
    #endregion

    #region [private] (emun) SmbiosType003Property: Defines the properties available for the structure type 003 [System Enclosure or Chassis]
    /// <summary>
    /// Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// </summary>
    enum SmbiosType003Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ChassisType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Locked,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AssetTagNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BootUpState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        PowerSupplyState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ThermalState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SecurityStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Height,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        NumberOfPowerCords,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ChassisContainedElementCollection))]
        ContainedElements,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorFamily,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorManufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsLegacyMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        VoltageCapability,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ExternalClock,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximunSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        CurrentSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        SocketPopulated,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        CpuStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProcessorUpgrade,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        L1CacheHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        L2CacheHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        L3CacheHandle,
        #endregion

        #region version 2.3+
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        PartNumber,
        #endregion

        #region version 2.6+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        CoreCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        CoreEnabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ThreadCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        Capable64Bits,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        MultiCore,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        HardwareThreadPerCore,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        ExecuteProtectionSupport,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        EnhancedVirtualizationInstructions,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        PowerPerformanceControlSupport,
        #endregion

        #region version 3.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
        CoreCount2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
        CoreEnabled2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorDetectingMethod,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorCorrectingCapabilities,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SupportedInterleave,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        CurrentInterleave,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MaximumMemoryModuleSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSpeeds,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedMemoryTypes,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryModuleVoltages,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        NumberMemorySlots,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryControllerContainedElementCollection))]
        ContainedMemoryModules,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        BankConnections,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        CurrentSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        CurrentMemoryType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        InstalledSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        EnabledSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        OperationalMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        CacheEnabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        CacheLocation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        CacheSocketed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        CacheLevel,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MaximumCacheSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        InstalledCacheSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedSramTypes,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        CurrentSramType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        CacheSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorCorrectionType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SystemCacheType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Associativity,
        #endregion

        #region version 3.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint))]
        MaximumCacheSize2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InternalReferenceDesignator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InternalConnectorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ExternalReferenceDesignator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ExternalConnectorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SlotDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SlotType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SlotDataBusWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        CurrentUsage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SlotLength,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SlotId,
        #endregion

        #region version 2.0+ - 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        SlotCharacteristics,
        #endregion

        #region version 2.6+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SegmentBusFunction,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        Enabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [private] (emun) SmbiosType011Property: Defines the properties available for the structure type 011 [OEM strings]
    /// <summary>
    /// Defines the properties available for the structure type 011 [OEM strings].
    /// </summary>
    enum SmbiosType011Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        Values,
    }
    #endregion

    #region [private] (emun) SmbiosType012Property: Defines the properties available for the structure type 012 [System Configuration Options]
    /// <summary>
    /// Defines the properties available for the structure type 012 [System Configuration Options].
    /// </summary>
    enum SmbiosType012Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        InstallableLanguages,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsCurrentAbbreviated,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        GroupName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(GroupAssociationElementCollection))]
        ContainedElements,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        Handle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(SmbiosStructure))]
        Structure,
    }
    #endregion

    #region [private] (emun) SmbiosType015Property: Defines the properties available for the structure type 015 [System Event Log]
    /// <summary>
    /// Defines the properties available for the structure type 015 [System Event Log].
    /// </summary>
    enum SmbiosType015Property
    {
        [DevicePropertyDescription("")]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Use,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MemoryErrorCorrection,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong))]
        MaximumCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MemoryErrorInformationHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        NumberOfMemoryDevices,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        PhysicalMemoryArrayHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MemoryErrorInformationHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        TotalWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        DataWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Size,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        FormFactor,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        DeviceSet,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceLocator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MemoryType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        TypeDetail,
        #endregion

        #region version 2.3+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximunSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        PartNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Rank,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ConfiguredMemoryClockSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BankLocator,
        #endregion

        #region version 2.8+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MinimunVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximumVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ConfiguredVoltage,
        #endregion

        #region version 3.2+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MemoryTechnology,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        MemoryOperatingModeCapability,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        FirmwareVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ModuleManufacturerId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ModuleProductId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MemorySubsystemControllerManufacturerId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MemorySubsystemControllerProductId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        NonVolatileSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        VolatileSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        CacheSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorGranularity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorOperation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        VendorSyndrome,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        MemoryArrayErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        DeviceErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MemoryArrayHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        PartitionWidth,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        ExtendedStartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
        StartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
        EndingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MemoryDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        MemoryArrayMappedAddressHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        PartitionRowPosition,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryDeviceMappedAddressInterleavedPosition))]
        InterleavePosition,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        InterleavedDataDepth,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        ExtendedStartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Type,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Interface,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ManufactureDate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceChemistry,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        DesignCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        DesignVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SBDSVersionNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        MaximunErrorInBatteryData,
        #endregion

        #region version 2.2+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SBDSSerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SBDSManufactureDate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SBDSDeviceChemistry,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DesignCapacityMultiplier,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BootOption,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BootOptionOnLimit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        WatchdogTimer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ResetCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ResetLimit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        TimerInterval,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Timeout,
    }
    #endregion

    #region [private] (emun) SmbiosType024Property: Defines the properties available for the structure type 024 [Hardware Security]
    /// <summary>
    /// Defines the properties available for the structure type type 024 [Hardware Security].
    /// </summary>
    enum SmbiosType024Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        FrontPanelResetStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AdministratorPasswordStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        KeyboardPasswordStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        PowerOnPasswordStatus
    }
    #endregion

    #region [private] (emun) SmbiosType025Property: Defines the properties available for the structure type 025 [System Power Controls]
    /// <summary>
    /// Defines the properties available for the structure type type 025 [System Power Controls].
    /// </summary>
    enum SmbiosType025Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Month,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Day,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Hour,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Minute,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        Second,
    }
    #endregion

    #region [private] (emun) SmbiosType026Property: Defines the properties available for the structure type 026 [Voltage Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 026 [Voltage Probe].
    /// </summary>
    enum SmbiosType026Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        TemperatureProbeHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        CoolingUnitGroup,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        NominalSpeed,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType029Property: Defines the properties available for the structure type 029 [Electrical Current Probe]
    /// <summary>
    /// Defines the properties available for the structure type type 029 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType029Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType030Property: Defines the properties available for the structure type 030 [Out-of-Band Remote Access]
    /// <summary>
    /// Defines the properties available for the structure type type 030 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType030Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ManufacturerName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        OutBoundConnection,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InBoundConnection,
    }
    #endregion

    #region [private] (emun) SmbiosType031Property: Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point]
    /// <summary>
    /// Defines the properties available for the structure type type 031 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType031Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Checksum,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BisEntryPointAddress16,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        BisEntryPointAddress32,
    }
    #endregion

    #region [private] (emun) SmbiosType032Property: Defines the properties available for the structure type 032 [System Boot Information]
    /// <summary>
    /// Defines the properties available for the structure type type 032 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType032Property
    {
        [DevicePropertyDescription("Reserved for future assignment by this specification; all bytes are set to 00h")]
        [DevicePropertyType(typeof(int))]
        Reserved,

        [DevicePropertyDescription("Status and Additional Data fields that identify the boot status")]
        [DevicePropertyType(typeof(string))]
        BootStatus,
    }
    #endregion

    #region [private] (emun) SmbiosType033Property: Defines the properties available for the structure type 033 [64-Bit Memory Error Information]
    /// <summary>
    /// Defines the properties available for the structure type type 033 [64-Bit Memory Error Information].
    /// </summary>
    enum SmbiosType033Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorGranularity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ErrorOperation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        VendorSyndrome,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        MemoryArrayErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong?))]
        DeviceErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(long?))]
        ErrorResolution,
    }
    #endregion

    #region [private] (emun) SmbiosType034Property: Defines the properties available for the structure type 034 [Management Device]
    /// <summary>
    /// Defines the properties available for the structure type type 034 [Management Device].
    /// </summary>
    enum SmbiosType034Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Type,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Address,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AddressType,
    }
    #endregion

    #region [private] (emun) SmbiosType035Property: Defines the properties available for the structure type 035 [Management Device Component]
    /// <summary>
    /// Defines the properties available for the structure type type 035 [Management Device Component].
    /// </summary>
    enum SmbiosType035Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        ManagementDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        ComponentHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        ThresholdHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType036Property: Defines the properties available for the structure type 036 [Management Device Threshold Data]
    /// <summary>
    /// Defines the properties available for the structure type type 036 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType036Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        LowerNonCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        UpperNonCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        LowerCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        UpperCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        LowerNonRecoverable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        UpperNonRecoverable,
    }
    #endregion

    #region [private] (emun) SmbiosType037Property: Defines the properties available for the structure type 037 [Memory Channel]
    /// <summary>
    /// Defines the properties available for the structure type type 037 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType037Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ChannelType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        MaximunChannelLoad,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryChannelElementCollection))]
        Devices,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Handle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Load
    }
    #endregion

    #region [private] (emun) SmbiosType038Property: Defines the properties available for the structure type 038 [IPMI Device Information]
    /// <summary>
    /// Defines the properties available for the structure type type 038 [IPMI Device Information].
    /// </summary>
    enum SmbiosType038Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InterfaceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SpecificationRevision,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        I2CSlaveAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        NVStorageDeviceAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ulong))]
        BaseAdress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        RegisterSpacing,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        LSBit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool?))]
        SpecifiedInfo,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Polarity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        TriggerMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        InterruptNumber,
    }
    #endregion

    #region [private] (emun) SmbiosType039Property: Defines the properties available for the structure type 039 [System Power Supply]
    /// <summary>
    /// Defines the properties available for the structure type type 039 [System Power Supply].
    /// </summary>
    enum SmbiosType039Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsRedundant,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AssetTagNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ModelPartNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        RevisionLevel,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        MaxPowerCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SupplyType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InputVoltageRange,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsPlugged,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsPresent,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsHotReplaceable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        InputVoltageProbeHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        CoolingDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int?))]
        InputCurrentProbeHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType040Property: Defines the properties available for the structure type 040 [Additional Information]
    /// <summary>
    /// Defines the properties available for the structure type type 040 [Additional Information].
    /// </summary>
    enum SmbiosType040Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        EntryLength,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        ReferencedHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        ReferencedOffset,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        StringValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Value,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(AdditionalInformationEntryCollection))]
        Entries,
    }
    #endregion

    #region [private] (emun) SmbiosType041Property: Defines the properties available for the structure type 041 [Onboard Devices Extended Information]
    /// <summary>
    /// Defines the properties available for the structure type type 041 [Onboard Devices Extended Information].
    /// </summary>
    enum SmbiosType041Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ReferenceDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DeviceType,
    }
    #endregion

    #region [private] (emun) SmbiosType042Property: Defines the properties available for the structure type 042 [Management Controller Host Interface]
    /// <summary>
    /// Defines the properties available for the structure type type 042 [Management Controller Host Interface].
    /// </summary>
    enum SmbiosType042Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        InterfaceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<byte>))]
        InterfaceTypeSpecificData,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ManagementControllerHostInterfaceProtocolRecordsCollection))]
        Protocols,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        ProtocolType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<byte>))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        VendorId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MajorSpecVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        MinorSpecVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        FirmwareVersion1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        FirmwareVersion2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<string>))]
        Characteristics,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
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
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Description,
    }
    #endregion

    #region [private] (emun) SmbiosType127Property: Defines the properties available for the structure type 127 [End-of-Table]
    /// <summary>
    /// Defines the properties available for the structure type type 127 [End-of-Table].
    /// </summary>
    enum SmbiosType127Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Status,
    }
    #endregion
}
