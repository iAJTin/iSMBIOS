
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.ObjectModel;

    using Device.DeviceProperty;

    #region [private] (emun) SmbiosType000Property: Defines the properties available for the structure type 000 [BIOS Information].
    /// <summary>
    /// Defines the properties available for the structure type 000 [BIOS Information].
    /// </summary>
    enum SmbiosType000Property
    {
        #region version 2.0+
        [DevicePropertyDescription("Vendedor de esta bios")]
        [DevicePropertyType(typeof(String))]
        Vendor,

        [DevicePropertyDescription("Version de esta bios")]
        [DevicePropertyType(typeof(String))]
        BiosVersion,

        [DevicePropertyDescription("Ubicación del segmento de dirección inicial de esta bios")]
        [DevicePropertyType(typeof(String))]
        BiosStartingAddressSegment,

        [DevicePropertyDescription("Fecha de la versión esta bios")]
        [DevicePropertyType(typeof(String))]
        BiosReleaseDate,

        [DevicePropertyDescription("Tamaño de esta bios")]
        [DevicePropertyType(typeof(Int32))]
        BiosRomSize,

        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        Characteristics,
        #endregion

        #region version 2.4+
        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        ExtensionByte1,

        [DevicePropertyDescription("Colección de funciones compatibles con esta bios")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        ExtensionByte2,

        [DevicePropertyDescription("Número de versión de esta bios")]
        [DevicePropertyType(typeof(Byte?))]
        SystemBiosMajorRelease,

        [DevicePropertyDescription("Número de revisión de esta bios")]
        [DevicePropertyType(typeof(Byte?))]
        SystemBiosMinorRelease,

        [DevicePropertyDescription("Número de versión del firmware del controlador de esta bios")]
        [DevicePropertyType(typeof(Byte?))]
        FirmwareMajorRelease,

        [DevicePropertyDescription("Número de revisón del firmware del controlador de esta bios")]
        [DevicePropertyType(typeof(Byte?))]
        FirmwareMinorRelease,
        #endregion

        #region version 3.1.0+
        [DevicePropertyDescription("Tamaño extendido de la ROM")]
        [DevicePropertyType(typeof(Int32))]
        ExtendedBiosRomSize,

        [DevicePropertyDescription("Tamaño extendido de la ROM (undades)")]
        [DevicePropertyType(typeof(MemorySizeUnit))]
        ExtendedBiosRomSizeUnit,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType001Property: Defines the properties available for the structure type 001 [System Information].
    /// <summary>
    /// Defines the properties available for the structure type 001 [System Information].
    /// </summary>
    enum SmbiosType001Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProductName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        UUID,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        WakeUpType,
        #endregion

        #region version 2.4+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SkuNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Family,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType002Property: Defines the properties available for the structure type 002 [Baseboard (or Module) Information].
    /// <summary>
    /// Defines the properties available for the structure type 002 [Baseboard (or Module) Information].
    /// </summary>
    enum SmbiosType002Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Product,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        HotSwappable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        IsReplaceable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        IsRemovable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        RequiredDaughterBoard,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        IsHostingBoard,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        LocationInChassis,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ChassisHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BoardType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        NumberOfContainedObjectHandles,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(BaseBoardContainedElementCollection))]
        ContainedObjectHandles,
    }
    #endregion

    #region [private] (emun) SmbiosType003Property: Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// <summary>
    /// Defines the properties available for the structure type 003 [System Enclosure or Chassis].
    /// </summary>
    enum SmbiosType003Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ChassisType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Locked,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AssetTagNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BootUpState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        PowerSupplyState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ThermalState,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SecurityStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
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
        [DevicePropertyType(typeof(String))]
        SkuNumber,

        ContainedElementMinimum,
        ContainedElementMaximun,
        ContainedTypeSelect,
        ContainedType,
    }
    #endregion

    #region [private] (emun) SmbiosType004Property: Defines the properties available for the structure type 004 [Processor Information].
    /// <summary>
    /// Defines the properties available for the structure type 004 [Processor Information].
    /// </summary>
    enum SmbiosType004Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorFamily,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorManufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsLegacyMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        VoltageCapability,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ExternalClock,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximunSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        CurrentSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        SocketPopulated,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        CpuStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ProcessorUpgrade,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        L1CacheHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        L2CacheHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        L3CacheHandle,
        #endregion

        #region version 2.3+
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        PartNumber,
        #endregion

        #region version 2.6+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        CoreCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        CoreEnabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        ThreadCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        Capable64Bits,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        MultiCore,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        HardwareThreadPerCore,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        ExecuteProtectionSupport,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        EnhancedVirtualizationInstructions,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        PowerPerformanceControlSupport,
        #endregion

        #region version 3.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        CoreCount2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        CoreEnabled2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        ThreadCount2,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType005Property: Defines the properties available for the structure type 005, obsolete [Memory Controller Information].
    /// <summary>
    /// Defines the properties available for the structure type 005, obsolete [Memory Controller Information].
    /// </summary>
    enum SmbiosType005Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorDetectingMethod,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorCorrectingCapabilities,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SupportedInterleave,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        CurrentInterleave,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MaximumMemoryModuleSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        SupportedSpeeds,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        SupportedMemoryTypes,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        MemoryModuleVoltages,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        NumberMemorySlots,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryControllerContainedElementCollection))]
        ContainedMemoryModules,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        EnabledErrorCorrectingCapabilities,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType006Property: Defines the properties available for the structure type 006, obsolete [Memory Module Information].
    /// <summary>
    /// Defines the properties available for the structure type 006, obsolete [Memory Module Information].
    /// </summary>
    enum SmbiosType006Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        BankConnections,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        CurrentSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        CurrentMemoryType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        InstalledSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        EnabledSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorStatus,
    }
    #endregion

    #region [private] (emun) SmbiosType007Property: Defines the properties available for the structure type 007 [Cache Information].
    /// <summary>
    /// Defines the properties available for the structure type 007 [Cache Information].
    /// </summary>
    enum SmbiosType007Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SocketDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        OperationalMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        CacheEnabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        CacheLocation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        CacheSocketed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        CacheLevel,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MaximumCacheSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        InstalledCacheSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        SupportedSramTypes,
        #endregion

        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        CurrentSramType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        CacheSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorCorrectionType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SystemCacheType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Associativity,
        #endregion

        #region version 3.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32))]
        MaximumCacheSize2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        InstalledCacheSize2,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType008Property: Defines the properties available for the structure type 008 [Port Connector Information].
    /// <summary>
    /// Defines the properties available for the structure type 008 [Port Connector Information].
    /// </summary>
    enum SmbiosType008Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InternalReferenceDesignator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InternalConnectorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ExternalReferenceDesignator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ExternalConnectorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        PortType,
    }
    #endregion

    #region [private] (emun) SmbiosType009Property: Defines the properties available for the structure type 009 [System Slots].
    /// <summary>
    /// Defines the properties available for the structure type 009 [System Slots].
    /// </summary>
    enum SmbiosType009Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SlotDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SlotType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SlotDataBusWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        CurrentUsage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SlotLength,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SlotId,
        #endregion

        #region version 2.0+ - 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        SlotCharacteristics,
        #endregion

        #region version 2.6+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SegmentBusFunction,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BusDeviceFunction
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType010Property: Defines the properties available for the structure type 010, obsolete [On Board Devices Information].
    /// <summary>
    /// Defines the properties available for the structure type 010, obsolete [On Board Devices Information].
    /// </summary>
    enum SmbiosType010Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        Enabled,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,
    }
    #endregion

    #region [private] (emun) SmbiosType011Property: Defines the properties available for the structure type 011 [OEM Strings].
    /// <summary>
    /// Defines the properties available for the structure type 011 [OEM Strings].
    /// </summary>
    enum SmbiosType011Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        Values,
    }
    #endregion

    #region [private] (emun) SmbiosType012Property: Defines the properties available for the structure type 012 [System Configuration Options].
    /// <summary>
    /// Defines the properties available for the structure type 012 [System Configuration Options].
    /// </summary>
    enum SmbiosType012Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        Values,
    }
    #endregion

    #region [private] (emun) SmbiosType013Property: Defines the properties available for the structure type 013 [BIOS Language Information].
    /// <summary>
    /// Defines the properties available for the structure type 013 [BIOS Language Information].
    /// </summary>
    enum SmbiosType013Property
    {
        #region version 2.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        InstallableLanguages,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsCurrentAbbreviated,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Current,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType014Property: Defines the properties available for the structure type 014 [Group Associations].
    /// <summary>
    /// Defines the properties available for the structure type 014 [Group Associations].
    /// </summary>
    enum SmbiosType014Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        GroupName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(GroupAssociationElementCollection))]
        ContainedElements,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        Handle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(SmbiosStructure))]
        Structure,
    }
    #endregion

    #region [private] (emun) SmbiosType015Property: Defines the properties available for the structure type 015 [System Event Log].
    /// <summary>
    /// Defines the properties available for the structure type 015 [System Event Log].
    /// </summary>
    enum SmbiosType015Property
    {
        [DevicePropertyDescription("")]
        SystemEventLog,
    }
    #endregion

    #region [private] (emun) SmbiosType016Property: Defines the properties available for the structure type 016 [Physical Memory Array].
    /// <summary>
    /// Defines the properties available for the structure type 016 [Physical Memory Array].
    /// </summary>
    enum SmbiosType016Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Use,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        MemoryErrorCorrection,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64))]
        MaximumCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        MemoryErrorInformationHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        NumberOfMemoryDevices,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64))]
        ExtendedMaximunCapacity,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType017Property: Defines the properties available for the structure type 017 [Memory Device].
    /// <summary>
    /// Defines the properties available for the structure type 017 [Memory Device].
    /// </summary>
    enum SmbiosType017Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        PhysicalMemoryArrayHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MemoryErrorInformationHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        TotalWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        DataWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Size,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        FormFactor,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        DeviceSet,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceLocator,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        MemoryType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        TypeDetail,
        #endregion

        #region version 2.3+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximunSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AssetTag,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        PartNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Rank,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ConfiguredMemoryClockSpeed,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BankLocator,
        #endregion

        #region version 2.8+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MinimunVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximumVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ConfiguredVoltage,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType018Property: Defines the properties available for the structure type 018 [32-Bit Memory Error Information].
    /// <summary>
    /// Defines the properties available for the structure type 018 [32-Bit Memory Error Information].
    /// </summary>
    enum SmbiosType018Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorGranularity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorOperation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        VendorSyndrome,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        MemoryArrayErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        DeviceErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        ErrorResolution,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType019Property: Defines the properties available for the structure type 019 [Memory Array Mapped Address].
    /// <summary>
    /// Defines the properties available for the structure type 019 [Memory Array Mapped Address].
    /// </summary>
    enum SmbiosType019Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MemoryArrayHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        PartitionWidth,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        ExtendedStartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType020Property: Defines the properties available for the structure type 020 [Memory Device Mapped Address].
    /// <summary>
    /// Defines the properties available for the structure type 020 [Memory Device Mapped Address].
    /// </summary>
    enum SmbiosType020Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        StartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt32?))]
        EndingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MemoryDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        MemoryArrayMappedAddressHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        PartitionRowPosition,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryDeviceMappedAddressInterleavedPosition))]
        InterleavePosition,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        InterleavedDataDepth,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        ExtendedStartingAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        ExtendedEndingAddress,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType021Property: Defines the properties available for the structure type 021 [Built-in Pointing Device].
    /// <summary>
    /// Defines the properties available for the structure type 021 [Built-in Pointing Device].
    /// </summary>
    enum SmbiosType021Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Type,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Interface,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        NumberOfButtons,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType022Property: Defines the properties available for the structure type 022 [Portable Battery].
    /// <summary>
    /// Defines the properties available for the structure type 022 [Built-in Pointing Device].
    /// </summary>
    enum SmbiosType022Property
    {
        #region version 2.1+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ManufactureDate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceChemistry,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        DesignCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        DesignVoltage,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SBDSVersionNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        MaximunErrorInBatteryData,
        #endregion

        #region version 2.2+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SBDSSerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SBDSManufactureDate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SBDSDeviceChemistry,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DesignCapacityMultiplier,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        OemSpecific,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType023Property: Defines the properties available for the structure type 023 [System Reset].
    /// <summary>
    /// Defines the properties available for the structure type type 023 [System Reset].
    /// </summary>
    enum SmbiosType023Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BootOption,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BootOptionOnLimit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        WatchdogTimer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ResetCount,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ResetLimit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        TimerInterval,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Timeout,
    }
    #endregion

    #region [private] (emun) SmbiosType024Property: Defines the properties available for the structure type 024 [Hardware Security].
    /// <summary>
    /// Defines the properties available for the structure type type 024 [Hardware Security].
    /// </summary>
    enum SmbiosType024Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        FrontPanelResetStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AdministratorPasswordStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        KeyboardPasswordStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        PowerOnPasswordStatus
    }
    #endregion

    #region [private] (emun) SmbiosType025Property: Defines the properties available for the structure type 025 [System Power Controls].
    /// <summary>
    /// Defines the properties available for the structure type type 025 [System Power Controls].
    /// </summary>
    enum SmbiosType025Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Month,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Day,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Hour,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Minute,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        Second,
    }
    #endregion

    #region [private] (emun) SmbiosType026Property: Defines the properties available for the structure type 026 [Voltage Probe].
    /// <summary>
    /// Defines the properties available for the structure type type 026 [Voltage Probe].
    /// </summary>
    enum SmbiosType026Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType027Property: Defines the properties available for the structure type 027 [Cooling Device].
    /// <summary>
    /// Defines the properties available for the structure type type 027 [Cooling Device].
    /// </summary>
    enum SmbiosType027Property
    {
        #region version 2.2+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        TemperatureProbeHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        CoolingUnitGroup,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        NominalSpeed,
        #endregion

        #region version 2.7+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,
        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType028Property: Defines the properties available for the structure type 028 [Temperature Probe].
    /// <summary>
    /// Defines the properties available for the structure type type 028 [Cooling Device].
    /// </summary>
    enum SmbiosType028Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType029Property: Defines the properties available for the structure type 029 [Electrical Current Probe].
    /// <summary>
    /// Defines the properties available for the structure type type 029 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType029Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaximunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MinimunValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Resolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Tolerance,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        Accuracy,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64))]
        OemDefined,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        NominalValue,
    }
    #endregion

    #region [private] (emun) SmbiosType030Property: Defines the properties available for the structure type 030 [Out-of-Band Remote Access].
    /// <summary>
    /// Defines the properties available for the structure type type 030 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType030Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ManufacturerName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        OutBoundConnection,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InBoundConnection,
    }
    #endregion

    #region [private] (emun) SmbiosType031Property: Defines the properties available for the structure type 031 [Boot Integrity Services (BIS) Entry Point].
    /// <summary>
    /// Defines the properties available for the structure type type 031 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType031Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        Checksum,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BisEntryPointAddress16,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        BisEntryPointAddress32,
    }
    #endregion

    #region [private] (emun) SmbiosType032Property: Defines the properties available for the structure type 032 [System Boot Information].
    /// <summary>
    /// Defines the properties available for the structure type type 032 [Electrical Current Probe].
    /// </summary>
    enum SmbiosType032Property
    {
        [DevicePropertyDescription("Reserved for future assignment by this specification; all bytes are set to 00h")]
        [DevicePropertyType(typeof(Int32))]
        Reserved,

        [DevicePropertyDescription("Status and Additional Data fields that identify the boot status")]
        [DevicePropertyType(typeof(String))]
        BootStatus,
    }
    #endregion

    #region [private] (emun) SmbiosType033Property: Defines the properties available for the structure type 033 [64-Bit Memory Error Information].
    /// <summary>
    /// Defines the properties available for the structure type type 033 [64-Bit Memory Error Information].
    /// </summary>
    enum SmbiosType033Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorGranularity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ErrorOperation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        VendorSyndrome,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        MemoryArrayErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64?))]
        DeviceErrorAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int64?))]
        ErrorResolution,
    }
    #endregion

    #region [private] (emun) SmbiosType034Property: Defines the properties available for the structure type 034 [Management Device].
    /// <summary>
    /// Defines the properties available for the structure type type 034 [Management Device].
    /// </summary>
    enum SmbiosType034Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Type,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Address,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AddressType,
    }
    #endregion

    #region [private] (emun) SmbiosType035Property: Defines the properties available for the structure type 035 [Management Device Component].
    /// <summary>
    /// Defines the properties available for the structure type type 035 [Management Device Component].
    /// </summary>
    enum SmbiosType035Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        ManagementDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        ComponentHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        ThresholdHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType036Property: Defines the properties available for the structure type 036 [Management Device Threshold Data].
    /// <summary>
    /// Defines the properties available for the structure type type 036 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType036Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        LowerNonCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        UpperNonCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        LowerCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        UpperCritical,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        LowerNonRecoverable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        UpperNonRecoverable,
    }
    #endregion

    #region [private] (emun) SmbiosType037Property: Defines the properties available for the structure type 037 [Memory Channel].
    /// <summary>
    /// Defines the properties available for the structure type type 037 [Management Device Threshold Data].
    /// </summary>
    enum SmbiosType037Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ChannelType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        MaximunChannelLoad,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(MemoryChannelElementCollection))]
        Devices,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        Handle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        Load
    }
    #endregion

    #region [private] (emun) SmbiosType038Property: Defines the properties available for the structure type 038 [IPMI Device Information].
    /// <summary>
    /// Defines the properties available for the structure type type 038 [IPMI Device Information].
    /// </summary>
    enum SmbiosType038Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InterfaceType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SpecificationRevision,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        I2CSlaveAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        NVStorageDeviceAddress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(UInt64))]
        BaseAdress,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        RegisterSpacing,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        LSBit,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean?))]
        SpecifiedInfo,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Polarity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        TriggerMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte?))]
        InterruptNumber,
    }
    #endregion

    #region [private] (emun) SmbiosType039Property: Defines the properties available for the structure type 039 [System Power Supply].
    /// <summary>
    /// Defines the properties available for the structure type type 039 [System Power Supply].
    /// </summary>
    enum SmbiosType039Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsRedundant,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Location,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Manufacturer,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        AssetTagNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ModelPartNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        RevisionLevel,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        MaxPowerCapacity,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        SupplyType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Status,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InputVoltageRange,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsPlugged,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsPresent,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsHotReplaceable,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        InputVoltageProbeHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        CoolingDeviceHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32?))]
        InputCurrentProbeHandle,
    }
    #endregion

    #region [private] (emun) SmbiosType040Property: Defines the properties available for the structure type 040 [Additional Information].
    /// <summary>
    /// Defines the properties available for the structure type type 040 [Additional Information].
    /// </summary>
    enum SmbiosType040Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        EntryLength,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Int32))]
        ReferencedHandle,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        ReferencedOffset,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        StringValue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        Value,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(AdditionalInformationEntryCollection))]
        Entries,
    }
    #endregion

    #region [private] (emun) SmbiosType041Property: Defines the properties available for the structure type 041 [Onboard Devices Extended Information].
    /// <summary>
    /// Defines the properties available for the structure type type 041 [Onboard Devices Extended Information].
    /// </summary>
    enum SmbiosType041Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        ReferenceDesignation,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceStatus,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        DeviceType,
    }
    #endregion

    #region [private] (emun) SmbiosType042Property: Defines the properties available for the structure type 042 [Management Controller Host Interface].
    /// <summary>
    /// Defines the properties available for the structure type type 042 [Management Controller Host Interface].
    /// </summary>
    enum SmbiosType042Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        InterfaceType,
    }
    #endregion

    #region [private] (emun) SmbiosType043Property: Defines the properties available for the structure type 043 [TPM Device].
    /// <summary>
    /// Defines the properties available for the structure type type 043 [TPM Device].
    /// </summary>
    enum SmbiosType043Property
    {
        #region Version 3.1.0+
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        VendorId,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        MajorSpecVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        MinorSpecVersion,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        FirmwareVersion1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        FirmwareVersion2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<String>))]
        Characteristics,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        OemDefined,

        #endregion
    }
    #endregion

    #region [private] (emun) SmbiosType126Property: Defines the properties available for the structure type 126 [Inactive].
    /// <summary>
    /// Defines the properties available for the structure type type 126 [Inactive].
    /// </summary>
    enum SmbiosType126Property
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Description,
    }
    #endregion

    #region [private] (emun) SmbiosType127Property: Defines the properties available for the structure type 127 [End-of-Table].
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
