
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

    // Type 0002: Baseboard (or Module) Information
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      deviceProperty       Description                                           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        2           Baseboard Information Indicator                                |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure. At least 08h.                         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies                                                                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Manufacturer    BYTE        STRING      Number of null-terminated string                               |
    // |                                                                                                                     |
    // |                                                      Note: Please see, Manufacturer                                 | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Product         BYTE        STRING      Number of null-terminated string                               |
    // |                                                                                                                     |
    // |                                                      Note: Please see, Product                                      | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Version         BYTE        STRING      Number of null-terminated string                               |
    // |                                                                                                                     |
    // |                                                      Note: Please see, Version                                      | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Serial Number   BYTE        STRING      Number of null-terminated string                               |
    // |                                                                                                                     |
    // |                                                      Note: Please see, SerialNumber                                 | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Asset Tag       BYTE        STRING      Number of null-terminated string                               |
    // |                                                                                                                     |
    // |                                                      Note: Please see, AssetTag                                     | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Feature         BYTE        Bit Field   A collection of 'flags' that identify the characteristics of   |
    // |              Flags                                   this baseboard.                                                |
    // |                                                                                                                     |
    // |                                                      Bit(s)   Description                                           |
    // |                                                       07:05 - Reserved for future definition by this                |
    // |                                                               specification; set to 000b.                           |    
    // |                                                                                                                     |
    // |                                                          04 - Set to 1 if the board is hot swappable; it is         | 
    // |                                                               possible to replace the board with a physically       |
    // |                                                               different but equivalent board while power is applied |
    // |                                                               to the board. The board is inherently replaceable and |
    // |                                                               removable.                                            |
    // |                                                               Note: Please see, IsHotSwappable                      | 
    // |                                                                                                                     |
    // |                                                          03 - Set to 1 if the board is replaceable; it is possible  |
    // |                                                               to replace (either as a field repair or upgrade) the  |
    // |                                                               board with a physically different board. The board is |
    // |                                                               inherently removable.                                 |
    // |                                                               Note: Please see, IsReplaceable                       | 
    // |                                                                                                                     |
    // |                                                          02 - Set to 1 if the board is removable; it is designed to |
    // |                                                               be taken in and out of the chassis without impairing  |
    // |                                                               the function of the chassis.                          |
    // |                                                               Note: Please see, IsRemovable                         | 
    // |                                                                                                                     |
    // |                                                          01 - Set to 1 if the board requires at least one daughter  |
    // |                                                               board or auxiliary card to function properly.         |
    // |                                                               Note: Please see, RequiredDaughterBoard               | 
    // |                                                                                                                     |
    // |                                                          00 - Set to 1 if the board is a hosting board              |
    // |                                                               (for example, a motherboard).                         |
    // |                                                               Note: Please see, IsHostingBoard                      | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Location in     BYTE        STRING      Number of null-terminated string which describes the location  |
    // |              Chassis                                 of this motherboard within the chassis (described below).      |
    // |                                                      This field supports a CIM_Container class mapping              |
    // |                                                      where:                                                         |
    // |                                                        · LocationWithinContainer is this field.                     |
    // |                                                        · GroupComponent is the chassis referenced by Chassis Handle |
    // |                                                        · PartComponent is this baseboard.                           |
    // |                                                      Note: Please see, LocationInChassis                            | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Chassis         WORD        Varies      Identifier or instance number associated with the chassis that | 
    // |              Handle                                  contains this baseboard.                                       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh          Board           BYTE        ENUM        Identifies the type of baseboard.                              |
    // |              Type                                    Note: Please see, GetBoardType(byte)                           | 
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh          Number of       BYTE        Varies      Identifies the number (0 - 255) of contained objects in this   |
    // |              Contained                               baseboard.                                                     |
    // |              Object                                                                                                 |
    // |              Handles (n)                                                                                            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh          Contained       n           Varies      List of identifiers of other SMBIOS structures (For example,   |
    // |              Object          WORDs                   Baseboard, Proccessor, Port, System, Slots, Memory Device)     |
    // |              Handles                                 present on this motherboard.                                   |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Baseboard (or Module) Information (Type 2) structure.
    /// </summary>
    sealed class SmbiosType002 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType002(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType002" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType002(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x04);
        #endregion

        #region [private] (string) Product: Gets a value representing the 'Product' field
        /// <summary>
        /// Gets a value representing the <c>Product</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Product => GetString(0x05);
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <c>Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x06);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x07);
        #endregion

        #region [private] (string) AssetTag: Gets a value representing the 'Asset Tag' field
        /// <summary>
        /// Gets a value representing the <c>Asset Tag</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTag => GetString(0x08);
        #endregion

        #region [private] (byte) FeatureFlags: Gets a value representing the 'Feature Flags' field
        /// <summary>
        /// Gets a value representing the <c>Feature Flags</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FeatureFlags => GetByte(0x09);
        #endregion

        #region [private] (bool) IsHostingBoard: Gets a value representing the 'Is Hosting Board' field
        /// <summary>
        /// Gets a value representing the <c>Is Hosting Board</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHostingBoard => FeatureFlags.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (bool) RequiredDaughterBoard: Gets a value representing the 'Required Daughter Board' field
        /// <summary>
        /// Gets a value representing the <c>Required Daughter Board</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool RequiredDaughterBoard => FeatureFlags.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsRemovable: Gets a value representing the 'Is Removable' field
        /// <summary>
        /// Gets a value representing the <c>Is Removable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsRemovable => FeatureFlags.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsReplaceable: Gets a value representing the 'Is Replaceable' field
        /// <summary>
        /// Gets a value representing the <c>Is Replaceable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsReplaceable => FeatureFlags.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) IsHotSwappable: Gets a value representing the 'Is Hot Swappable' field
        /// <summary>
        /// Gets a value representing the <c>Is Hot Swappable</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHotSwappable => FeatureFlags.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (string) LocationInChassis: Gets a value representing the 'Location In Chassis' field
        /// <summary>
        /// Gets a value representing the <c>Location In Chassis</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string LocationInChassis => GetString(0x0a);
        #endregion

        #region [private] (int) ChassisHandle: Gets a value representing the 'Chassis Handle' field
        /// <summary>
        /// Gets a value representing the <c>Chassis Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ChassisHandle => GetWord(0x0b);
        #endregion

        #region [private] (byte) BoardType: Gets a value representing the 'Board Type' field
        /// <summary>
        /// Gets a value representing the <c>Board Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BoardType => GetByte(0x0d);
        #endregion

        #region [private] (byte) NumberOfContainedObjectHandles: Gets a value representing the 'Number Of Contained Object Handles' field
        /// <summary>
        /// Gets a value representing the <c>Number Of Contained Object Handles</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfContainedObjectHandles => GetByte(0x0e);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Gets a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            SmbiosType002Property propertyId = (SmbiosType002Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [Manufacturer] - [String]
                case SmbiosType002Property.Manufacturer:
                    value = Manufacturer;
                    break;
                #endregion

                #region [0x05] - [Product] - [String]
                case SmbiosType002Property.Product:
                    value = Product;
                    break;
                #endregion

                #region [0x06] - [Version] - [String]
                case SmbiosType002Property.Version:
                    value = Version;
                    break;
                #endregion

                #region [0x07] - [Serial Number] - [String]
                case SmbiosType002Property.SerialNumber:
                    value = SerialNumber;
                    break;
                #endregion

                #region [0x08] - [Asset Tag] - [String]
                case SmbiosType002Property.AssetTag:
                    if (HeaderInfo.Length >= 0x09)
                    {
                        value = AssetTag;
                    }
                    break;
                #endregion

                #region [0x09] - [Feature Flag]

                #region [0x09] - [Feature Flags -> Hot Swappable] - [Boolean?]
                case SmbiosType002Property.HotSwappable:
                    if (HeaderInfo.Length >= 0x0a)
                    {
                        value = (bool?)IsHotSwappable;
                    }
                    break;
                #endregion

                #region [0x09] - [Feature Flags -> Is Replaceable] - [Boolean?]
                case SmbiosType002Property.IsReplaceable:
                    if (HeaderInfo.Length >= 0x0a)
                    {
                        value = (bool?)IsReplaceable;
                    }
                    break;
                #endregion

                #region [0x09] - [Feature Flags -> Is Removable] - [Boolean?]
                case SmbiosType002Property.IsRemovable:
                    if (HeaderInfo.Length >= 0x0a)
                    {
                        value = (bool?) IsRemovable;
                    }
                    break;
                #endregion

                #region [0x09] - [Feature Flags -> Required Daughter Board] - [Boolean?]
                case SmbiosType002Property.RequiredDaughterBoard:
                    if (HeaderInfo.Length >= 0x0a)
                    {
                        value = (bool?)RequiredDaughterBoard;
                    }
                    break;
                #endregion

                #region [0x09] - [Feature Flags -> Is Hosting Board] - [Boolean?]
                case SmbiosType002Property.IsHostingBoard:
                    if (HeaderInfo.Length >= 0x0a)
                    {
                        value = (bool?)IsHostingBoard;
                    }
                    break;
                #endregion

                #endregion

                #region [0x0a] - [Location In Chassis] - [String]
                case SmbiosType002Property.LocationInChassis:
                    if (HeaderInfo.Length >= 0x0b)
                    {
                        value = LocationInChassis;
                    }
                    break;
                #endregion

                #region [0x0b] - [Chassis Handle] - [Int32?]
                case SmbiosType002Property.ChassisHandle:
                    if (HeaderInfo.Length >= 0x0c)
                    {
                        value = ChassisHandle;
                    }
                    break;
                #endregion

                #region [0x0d] - [Board Type] - [String]
                case SmbiosType002Property.BoardType:
                    if (HeaderInfo.Length >= 0x0e)
                    {
                        value = GetBoardType(BoardType);
                    }
                    break;
                #endregion

                #region [0x0e] - [Number Of Contained Object Handles] - [Byte?]
                case SmbiosType002Property.NumberOfContainedObjectHandles:
                    if (HeaderInfo.Length >= 0x0f)
                    {
                        value = NumberOfContainedObjectHandles;
                    }
                    break;
                #endregion

                #region [0x0f] - [Number Of Contained Object Handles] - [BaseBoardContainedElementCollection]
                case SmbiosType002Property.ContainedObjectHandles:
                    if (HeaderInfo.Length >= 0x0f)
                    {
                        byte n = NumberOfContainedObjectHandles;
                        if (n != 0x00 && HeaderInfo.Length >= 0x10)
                        {
                            var containedElementsArray = new byte[n];
                            Array.Copy(HeaderInfo.RawData, 0x0f, containedElementsArray, 0, n);

                            IEnumerable<SmbiosStructure> containedElements = GetContainedElements(containedElementsArray);
                            value = new BaseBoardContainedElementCollection(containedElements);
                        }
                    }
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(Hashtable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(KnownDmiProperty.BaseBoard.Manufacturer, Manufacturer);
            properties.Add(KnownDmiProperty.BaseBoard.Product, Product);
            properties.Add(KnownDmiProperty.BaseBoard.Version, Version);
            properties.Add(KnownDmiProperty.BaseBoard.SerialNumber, SerialNumber);

            if (HeaderInfo.Length >= 0x09)
            {
                properties.Add(KnownDmiProperty.BaseBoard.AssetTag, AssetTag);
            }

            if (HeaderInfo.Length >= 0x0a)
            {
                properties.Add(KnownDmiProperty.BaseBoard.Features.IsHotSwappable, IsHotSwappable);
                properties.Add(KnownDmiProperty.BaseBoard.Features.IsReplaceable, IsReplaceable);
                properties.Add(KnownDmiProperty.BaseBoard.Features.IsRemovable, IsRemovable);
                properties.Add(KnownDmiProperty.BaseBoard.Features.RequiredDaughterBoard, RequiredDaughterBoard);
                properties.Add(KnownDmiProperty.BaseBoard.Features.IsHostingBoard, IsHostingBoard);
            }

            if (HeaderInfo.Length >= 0x0b)
            {
                properties.Add(KnownDmiProperty.BaseBoard.LocationInChassis, LocationInChassis);
            }

            if (HeaderInfo.Length >= 0x0c)
            {
                properties.Add(KnownDmiProperty.BaseBoard.ChassisHandle, ChassisHandle);
            }

            if (HeaderInfo.Length >= 0x0d)
            {
                properties.Add(KnownDmiProperty.BaseBoard.BoardType, GetBoardType(BoardType));
            }

            if (HeaderInfo.Length >= 0x0e)
            {
                byte n = NumberOfContainedObjectHandles;
                properties.Add(KnownDmiProperty.BaseBoard.NumberOfContainedObjectHandles, n);

                if (n != 0x00 && HeaderInfo.Length >= 0x0f)
                {
                    var containedElementsArray = new byte[n];
                    Array.Copy(HeaderInfo.RawData, 0x0f, containedElementsArray, 0, n);

                    IEnumerable<SmbiosStructure> containedElements = GetContainedElements(containedElementsArray);
                    properties.Add(KnownDmiProperty.BaseBoard.ContainedElements, new BaseBoardContainedElementCollection(containedElements));
                }
            }
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetBoardType(byte): Gets a string that identifies the type of motherboard
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that identifies the type of motherboard.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Type of motherboard.
        /// </returns>
        private static string GetBoardType(byte code)
        {
            string[] deviceProperty =
            {
                "Unknown", // 0x01
                "Other",
                "Server Blade",
                "Connectivity Switch",
                "System Management Module",
                "Processor Module",
                "I/O Module",
                "Memory Module",
                "Daughter Board",
                "Motherboard",
                "Processor+Memory Module",
                "Processor+I/O Module",
                "Interconnect Board" // 0x0D                                      
            };

            if (code >= 0x01 && code <= 0x0D)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (IEnumerable<SmbiosStructure>) GetContainedElements(IEnumerable<byte>): Gets the list of items contained in this motherboard
        /// <summary>
        /// Gets the list of items contained in this motherboard
        /// </summary>
        /// <param name="rawdevicePropertyArray">Raw information.</param>
        /// <returns>
        /// Collection of items contained in this motherboard..
        /// </returns>
        private static IEnumerable<SmbiosStructure> GetContainedElements(IEnumerable<byte> rawdevicePropertyArray)
        {
            Collection<SmbiosStructure> containedElements = new Collection<SmbiosStructure>();

            foreach (var deviceProperty in rawdevicePropertyArray)
            {
                containedElements.Add((SmbiosStructure)deviceProperty);
            }              
 
            return containedElements;
        }
        #endregion

        #endregion
    }
}
