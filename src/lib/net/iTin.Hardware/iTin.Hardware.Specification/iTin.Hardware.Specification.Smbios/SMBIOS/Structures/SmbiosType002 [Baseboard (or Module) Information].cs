
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

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

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Baseboard (or Module) Information (Type 2) structure.
    /// </summary>
    internal sealed class SmbiosType002 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType002(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType002"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType002(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <b>Manufacturer</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x04);
        #endregion

        #region [private] (string) Product: Gets a value representing the 'Product' field
        /// <summary>
        /// Gets a value representing the <b>Product</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Product => GetString(0x05);
        #endregion

        #region [private] (string) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <b>Version</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Version => GetString(0x06);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x07);
        #endregion

        #region [private] (string) AssetTag: Gets a value representing the 'Asset Tag' field
        /// <summary>
        /// Gets a value representing the <b>Asset Tag</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTag => GetString(0x08);
        #endregion

        #region [private] (byte) FeatureFlags: Gets a value representing the 'Feature Flags' field
        /// <summary>
        /// Gets a value representing the <b>Feature Flags</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FeatureFlags => Reader.GetByte(0x09);
        #endregion

        #region [private] (bool) IsHostingBoard: Gets a value representing the 'Is Hosting Board' field
        /// <summary>
        /// Gets a value representing the <b>Is Hosting Board</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHostingBoard => FeatureFlags.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (bool) RequiredDaughterBoard: Gets a value representing the 'Required Daughter Board' field
        /// <summary>
        /// Gets a value representing the <b>Required Daughter Board</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool RequiredDaughterBoard => FeatureFlags.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsRemovable: Gets a value representing the 'Is Removable' field
        /// <summary>
        /// Gets a value representing the <b>Is Removable</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsRemovable => FeatureFlags.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsReplaceable: Gets a value representing the 'Is Replaceable' field
        /// <summary>
        /// Gets a value representing the <b>Is Replaceable</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsReplaceable => FeatureFlags.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) IsHotSwappable: Gets a value representing the 'Is Hot Swappable' field
        /// <summary>
        /// Gets a value representing the <b>Is Hot Swappable</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHotSwappable => FeatureFlags.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (string) LocationInChassis: Gets a value representing the 'Location In Chassis' field
        /// <summary>
        /// Gets a value representing the <b>Location In Chassis</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string LocationInChassis => GetString(0x0a);
        #endregion

        #region [private] (ushort) ChassisHandle: Gets a value representing the 'Chassis Handle' field
        /// <summary>
        /// Gets a value representing the <b>Chassis Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ChassisHandle => (ushort)Reader.GetWord(0x0b);
        #endregion

        #region [private] (byte) BoardType: Gets a value representing the 'Board Type' field
        /// <summary>
        /// Gets a value representing the <b>Board Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BoardType => Reader.GetByte(0x0d);
        #endregion

        #region [private] (byte) NumberOfContainedObjectHandles: Gets a value representing the 'Number Of Contained Object Handles' field
        /// <summary>
        /// Gets a value representing the <b>Number Of Contained Object Handles</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberOfContainedObjectHandles => Reader.GetByte(0x0e);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc/>
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            properties.Add(SmbiosProperty.BaseBoard.Manufacturer, Manufacturer);
            properties.Add(SmbiosProperty.BaseBoard.Product, Product);
            properties.Add(SmbiosProperty.BaseBoard.Version, Version);
            properties.Add(SmbiosProperty.BaseBoard.SerialNumber, SerialNumber);

            if (StructureInfo.Length >= 0x09)
            {
                properties.Add(SmbiosProperty.BaseBoard.AssetTag, AssetTag);
            }

            if (StructureInfo.Length >= 0x0a)
            {
                properties.Add(SmbiosProperty.BaseBoard.Features.IsHotSwappable, IsHotSwappable);
                properties.Add(SmbiosProperty.BaseBoard.Features.IsReplaceable, IsReplaceable);
                properties.Add(SmbiosProperty.BaseBoard.Features.IsRemovable, IsRemovable);
                properties.Add(SmbiosProperty.BaseBoard.Features.RequiredDaughterBoard, RequiredDaughterBoard);
                properties.Add(SmbiosProperty.BaseBoard.Features.IsHostingBoard, IsHostingBoard);
            }

            if (StructureInfo.Length >= 0x0b)
            {
                properties.Add(SmbiosProperty.BaseBoard.LocationInChassis, LocationInChassis);
            }

            if (StructureInfo.Length >= 0x0c)
            {
                properties.Add(SmbiosProperty.BaseBoard.ChassisHandle, ChassisHandle);
            }

            if (StructureInfo.Length >= 0x0d)
            {
                properties.Add(SmbiosProperty.BaseBoard.BoardType, GetBoardType(BoardType));
            }

            if (StructureInfo.Length >= 0x0e)
            {
                byte n = NumberOfContainedObjectHandles;
                properties.Add(SmbiosProperty.BaseBoard.NumberOfContainedObjectHandles, n);

                if (n != 0x00 && StructureInfo.Length >= 0x0f)
                {
                    byte[] containedElementsArray = StructureInfo.RawData.Extract((byte)0x0f, n).ToArray();
                    IEnumerable<SmbiosStructure> containedElements = GetContainedElements(containedElementsArray);
                    properties.Add(SmbiosProperty.BaseBoard.ContainedElements, new BaseBoardContainedElementCollection(containedElements));
                }
            }
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetBoardType(byte): Gets a string that identifies the type of motherboard
        /// <summary>
        /// Gets a <see cref="string"/> that identifies the type of motherboard.
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
