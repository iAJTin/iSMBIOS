
namespace iTin.Hardware.Specification.Smbios
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;

    using Property;

    // Type 009: System Slots
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                                                |
    // | Offset   Version     Name                Length      Value       Description                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        9           System Slot Structure Indicator                              |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      0Ch for version 2.0                                          |
    // |                                                                  0Dh for versiones 2.1 a 2.5                                  |
    // |                                                                  11h for version 2.6 and later.                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies                                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Slot Designation    BYTE        STRING      String number for reference designation                      |
    // |                                                                  EXAMPLE: ‘PCI-1’,0                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.0+        Slot Type           BYTE        ENUM        Note: For more information, GetSlotType(byte)                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Slot Data           BYTE        ENUM        Note: For more information, GetDataBusWidth(byte)            |
    // |                      Bus Width                                                                                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.0+        Current Usage       BYTE        ENUM        Note: For more information, GetCurrentUsage(byte)            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        Slot Length         BYTE        ENUM        Note: For more information, GetLength(byte)                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h      2.0+        Slot ID             WORD        Varies      Note: For more information, GetId(byte, byte, byte)          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.0+        Slot                BYTE        Bit Field   Note: For more information, GetCharacteristics(byte, byte)   |
    // |                      Characteristics 1                                                                                        |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.1+        Slot                BYTE        Bit Field   Note: For more information, GetCharacteristics(byte, byte)   |
    // |                      Characteristics 2                                                                                        |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh      2.6+        Segment Group       WORD        Varies      Note: For more information, GetSegmentBusFuction(int)        |
    // |                      Number (Base)                                                                                            | 
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.6+        Bus Number (Base)   BYTE        Varies                                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.6+        Device/Function     BYTE        Bit field   Bits 7:3 – device number                                     |
    // |                      Number (Base)                               Bits 2:0 – function number                                   |
    // |                                                                  Note: For more information, GetBusDeviceFunction(byte, byte) | 
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      3.2         Data Bus Width      BYTE        Varies      Indicate electrical bus width of base                        |
    // |                      (Base)                                      Segment/Bus/Device/Function/Width                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      3.2         Peer(S/B/D/F/Width) BYTE        Varies      Number of peer Segment/Bus/Device/Function/Width             |
    // |                      grouping count (n)                          groups that follow                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      3.2         Peer(S/B/D/F/Width) 5*n         Varies      Peer Segment/Bus/Device/Function                             |
    // |                      groups              BYTE                    present in the slot; see 7.10.9                              |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h +    3.4         Slot Information    BYTE        Varies      Please see SlotInformation                                   |
    // | 5*n                                                                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14 +     3.4         Slot Physical Width BYTE        Varies      Please see GetDataBusWidth()                                 |
    // | 5*n                                                                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h +    3.4         Slot Pitch          WORD         Varies     Please see SlotPitch                                         |
    // | 5*n                                                                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h +    3.5         Slot Height         BYTE         Varies     Please see SlotHeight                                        |
    // | 5*n                                                                                                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Slot Information (Type 9) structure.
    /// </summary>
    internal sealed class SmbiosType009 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType009(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType009"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType009(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.0+ fields

        #region [private] (string) SlotDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <b>Slot Designation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SlotDesignation => GetString(0x04);
        #endregion

        #region [private] (byte) SlotType: Gets a value representing the 'Slot Type' field
        /// <summary>
        /// Gets a value representing the <b>Slot Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SlotType => Reader.GetByte(0x05);
        #endregion

        #region [private] (byte) DataWidth: Gets a value representing the 'Data Width' field
        /// <summary>
        /// Gets a value representing the <b>Data Width</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DataWidth => Reader.GetByte(0x06);
        #endregion

        #region [private] (byte) CurrentUsage: Gets a value representing the 'Current Usage' field
        /// <summary>
        /// Gets a value representing the <b>Current Usage</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CurrentUsage => Reader.GetByte(0x07);
        #endregion

        #region [private] (byte) Length: Gets a value representing the 'Length' field
        /// <summary>
        /// Gets a value representing the <b>Length</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Length => Reader.GetByte(0x08);
        #endregion

        #region [private] (byte) Adapter: Gets a value representing the 'Adapter' field
        /// <summary>
        /// Gets a value representing the <b>Adapter</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Adapter => Reader.GetByte(0x09);
        #endregion

        #region [private] (byte) Socket: Gets a value representing the 'Socket' field
        /// <summary>
        /// Gets a value representing the <b>Socket</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Socket => Reader.GetByte(0x0a);
        #endregion

        #region [private] (byte) Characteristics1: Gets a value representing the 'Characteristics1' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics1</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Characteristics1 => Reader.GetByte(0x0b);
        #endregion

        #endregion

        #region Version 2.1+ fields

        #region [private] (byte) Characteristics2: Gets a value representing the 'Characteristics2' field
        /// <summary>
        /// Gets a value representing the <b>Characteristics2</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Characteristics2 => Reader.GetByte(0x0c);
        #endregion

        #endregion

        #region Version 2.6+ fields

        #region [private] (ushort) SegmentBusFunction: Gets a value representing the 'Segment Bus Function' field
        /// <summary>
        /// Gets a value representing the <b>Segment Bus Function</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort SegmentBusFunction => (ushort)Reader.GetWord(0x0d);
        #endregion

        #region [private] (byte) Bus: Gets a value representing the 'Bus' field
        /// <summary>
        /// Gets a value representing the <b>Bus</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Bus => Reader.GetByte(0x0f);
        #endregion

        #region [private] (byte) DeviceFunctionNumber: Gets a value representing the 'Device Function Number' field
        /// <summary>
        /// Gets a value representing the <b>Device Function Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceFunctionNumber => Reader.GetByte(0x10);
        #endregion

        #region [private] (byte) Device: Gets a value representing the 'Device' feature of the 'Device/Function Number' field
        /// <summary>
        /// Gets a value representing the <b>Device</b> feature of the <b>Device/Function Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Device => (byte) ((DeviceFunctionNumber & 0xf8) >> 3);
        #endregion

        #region [private] (byte) Function: Gets a value representing the 'Function' feature of the 'Device/Function Number' field
        /// <summary>
        /// Gets a value representing the <b>Function</b> feature of the <b>Device/Function Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Function => (byte) (DeviceFunctionNumber & 0x07);
        #endregion

        #endregion

        #region Version 3.2 fields

        #region [private] (byte) BaseDataBusWidth: Gets a value representing the 'Base Data Bus Width' field
        /// <summary>
        /// Gets a value representing the <b>Base Data Bus Width</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BaseDataBusWidth => Reader.GetByte(0x11);
        #endregion

        #region [private] (byte) GroupingCount: Gets a value representing the 'Peer Grouping Count (n)' field
        /// <summary>
        /// Gets a value representing the <b>Peer Grouping Count (n)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte GroupingCount => Reader.GetByte(0x12);
        #endregion

        #region [private] (byte[]) RawGroups: Gets a value representing the 'Peer (S/B/D/F/Width) groups' field
        /// <summary>
        /// Gets a value representing the <b>Peer (S/B/D/F/Width) groups</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawGroups => Reader.GetBytes(0x13, (byte)(5 * GroupingCount));
        #endregion

        #endregion

        #region Version 3.4 fields

        #region [private] (byte) SlotInformation: Gets a value representing the 'Slot Information' field
        /// <summary>
        /// Gets a value representing the <b>Slot Information</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SlotInformation => Reader.GetByte((byte)(0x14 + (5 * GroupingCount)));
        #endregion

        #region [private] (byte) SlotPhysicalWidth: Gets a value representing the 'Slot Physical Width' field
        /// <summary>
        /// Gets a value representing the <b>Slot Physical Width</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SlotPhysicalWidth => Reader.GetByte((byte)(0x15 + (5 * GroupingCount)));
        #endregion

        #region [private] (ushort) SlotPitch: Gets a value representing the 'Slot Pitch' field
        /// <summary>
        /// Gets a value representing the <b>Slot Pitch</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort SlotPitch => (ushort)Reader.GetWord((byte)(0x16 + (5 * GroupingCount)));
        #endregion

        #endregion

        #region Version 3.5 fields

        #region [private] (byte) SlotHeight: Gets a value representing the 'Slot Height' field
        /// <summary>
        /// Gets a value representing the <b>Slot Height</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SlotHeight => Reader.GetByte((byte)(0x18 + (5 * GroupingCount)));
        #endregion

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
            #region 2.0+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v20)
            {
                properties.Add(SmbiosProperty.SystemSlots.SlotDesignation, SlotDesignation);
                properties.Add(SmbiosProperty.SystemSlots.SlotType, GetSlotType(SlotType));
                properties.Add(SmbiosProperty.SystemSlots.SlotDataBusWidth, GetDataBusWidth(DataWidth));
                properties.Add(SmbiosProperty.SystemSlots.CurrentUsage, GetCurrentUsage(CurrentUsage));
                properties.Add(SmbiosProperty.SystemSlots.SlotLength, GetLength(Length));
                properties.Add(SmbiosProperty.SystemSlots.SlotId, GetId(SlotType, Adapter, Socket));
                properties.Add(SmbiosProperty.SystemSlots.Characteristics, GetCharacteristics(Characteristics1, 0xff));
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties[SmbiosProperty.SystemSlots.Characteristics] = GetCharacteristics(Characteristics1, Characteristics2);
            }
            #endregion

            #region 2.6+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v26)
            {
                properties.Add(SmbiosProperty.SystemSlots.SegmentBusFunction, GetSegmentBusFunction(SegmentBusFunction));
                properties.Add(SmbiosProperty.SystemSlots.BusDeviceFunction, GetBusDeviceFunction(Bus, Device, Function));
            }
            #endregion

            #region 3.2
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v32)
            {
                var slotType = GetSlotType(SlotType).ToLowerInvariant();
                var canEvaluate = slotType.Contains("agp") || slotType.Contains("pci");
                if (canEvaluate)
                {
                    IEnumerable<PeerDevice> peersDevices = GetPeerElements(RawGroups);
                    properties.Add(SmbiosProperty.SystemSlots.PeerDevices, new PeerDevicesCollection(peersDevices));
                }
            }
            #endregion

            #region 3.4
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v34)
            {
                if (SlotType == 0xC4)
                {
                    properties.Add(SmbiosProperty.SystemSlots.SlotInformation, $"PCI Express Generation {SlotInformation}");
                }

                properties.Add(SmbiosProperty.SystemSlots.SlotPhysicalWidth, GetDataBusWidth(DataWidth));
                properties.Add(SmbiosProperty.SystemSlots.SlotPitch, SlotPitch);
            }
            #endregion

            #region 3.5
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v35)
            {
                properties.Add(SmbiosProperty.SystemSlots.SlotHeight, GetSlotHeight(SlotHeight));
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 3.5.0 (15/09/2021)

        #region [private] {static} (string) GetBusDeviceFunction(byte, byte, byte): Gets a string representing Bus / Device / Function of the slot
        /// <summary>
        /// Gets a string representing Bus / Device / Function of the slot.
        /// </summary>
        /// <param name="bus">Bus.</param>
        /// <param name="device">Device.</param>
        /// <param name="function">Función.</param>
        /// <returns>
        /// Bus/Device/Function slot information
        /// </returns>
        private static string GetBusDeviceFunction(byte bus, byte device, byte function) => $"Bus = {bus}, Device = {device}, Function = {function}";
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetCharacteristics(byte, byte): Gets a collection with the characteristics of the slot
        /// <summary>
        /// Gets a collection with the characteristics of the slot.
        /// </summary>
        /// <param name="code1">General characteristics.</param>
        /// <param name="code2">Specific characteristics.</param>
        /// <returns>
        /// A collection with the characteristics of the slot.
        /// </returns>
        private static ReadOnlyCollection<string> GetCharacteristics(byte code1, byte code2)
        {
            string[] value =
            {
                "Characteristics Unknown",         // 0x00
                "Provides 5.0 Volts",
                "Provides 3.3 Volts",
                "Opening is shared",
                "PC Card-16 is supported",
                "Cardbus is supported",
                "Zoom Video is supported",
                "Modem ring resume is supported"   // 0x07                   
            };

            string[] value1 =
            {
                "PME signal is supported",             // 0x00
                "Hot-plug devices are supported",
                "SMBus signal is supported",        
                "PCIe slot supports bifurcation", 
                "Slot supports async/surprise removal" // 0x04
            };

            List<string> items = new List<string>();
            for (byte i = 0; i <= 7; i++)
            {
                bool addCharacteristic = code1.CheckBit(i);
                if (addCharacteristic)
                {
                    items.Add(value[i]);
                }
            }

            if (code2 != 0xff)
            {
                for (byte i = 0; i <= 4; i++)
                {
                    bool addCharacteristic = code2.CheckBit(i);
                    if (addCharacteristic)
                    {
                        items.Add(value1[i]);
                    }
                }

                var bit5 = code2.CheckBit(5);
                var bit6 = code2.CheckBit(6);
                if (bit5 == false && bit6 == false)
                {
                    items.Add("Non CXL-capable slot");
                }
                else if(bit5 && bit6 == false)
                {
                    items.Add("Flexbus slot, CXL 2.0 capable (backward compatible to 1.0)");
                }
                else
                {
                    items.Add("Flexbus slot, CXL 1.0 capable");
                }
            }

            return items.AsReadOnly();
        }
        #endregion

        #region [private] {static} (string) GetCurrentUsage(byte): Gets a string representing the current slot usage
        /// <summary>
        /// Gets a string representing the current slot usage.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The current slot usage.
        /// </returns>
        private static string GetCurrentUsage(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "Available",
                "In use", 
                "Unavailable", // 0x05 - e.g., connected to a processor that is not installed
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetDataBusWidth(byte): Gets a string representing the width of the data bus in the slot
        /// <summary>
        /// Gets a string representing the width of the data bus in the slot.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The width of the data bus in the slot.
        /// </returns>    
        private static string GetDataBusWidth(byte code)
        {
            string[] value =
            {
                "Other",     // 0x01
                "Unknown",
                "8-bit",
                "16-bit",
                "32-bit",
                "64-bit",
                "128-bit",
                "x1",
                "x2",
                "x4",
                "x8",
                "x12",
                "x16",
                "x32"        // 0x0E
            };

            if (code >= 0x01 && code <= 0x0E)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetId(byte, byte, byte): Gets a string that identifies the slot
        /// <summary>
        /// Gets a string that identifies the slot.
        /// </summary>
        /// <param name="type">Slot typet.</param>
        /// <param name="adpater">First value to analyze.</param>
        /// <param name="socket">Second value to analyze.</param>
        /// <returns>
        /// Slot identifier.
        /// </returns>
        private static string GetId(byte type, byte adpater, byte socket)
        {
            switch (type)
            {
                case 0x04: // MCA
                    return $"{adpater:X}";

                case 0x05: // EISA
                    return $"{adpater:X}";

                case 0x06: // PCI
                case 0x0E: // PCI
                case 0x0F: // AGP
                case 0x10: // AGP
                case 0x11: // AGP
                case 0x12: // PCI-X
                case 0x13: // AGP
                case 0xA5: // PCI Express
                    return $"{adpater:X}";

                case 0x07: // PCMCIA
                    return $"ID: Adapter {adpater:X}, Socket {socket:X}";

                default:
                    return SmbiosHelper.OutOfSpec;
            }
        }
        #endregion

        #region [private] {static} (string) GetLength(byte): Gets a string that identifies the physical width of the slot
        /// <summary>
        /// Gets a string that identifies the physical width of the slot.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Ancho físico del slot.
        /// </returns>
        private static string GetLength(byte code)
        {
            string[] value =
            {
                "Other",                    // 0x01
                "Unknown",
                "Short Length",
                "Long Length",
                "2.5\" drive form factor",
                "3.5\" drive form factor"   // 0x06
            };

            if (code >= 0x01 && code <= 0x06)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (IEnumerable<PeerDevice>) GetPeerElements(byte[], byte): Gets the list of peer information
        /// <summary>
        /// Gets the list of peer information.
        /// </summary>
        /// <param name="rawData">Raw information.</param>
        /// <returns>
        /// Peers
        /// </returns>
        private static IEnumerable<PeerDevice> GetPeerElements(byte[] rawData)
        {
            Collection<PeerDevice> peerElements = new Collection<PeerDevice>();

            for (int i = 0; i < rawData.Length; i += 0x05)
            {
                var peer = new byte[0x05];
                Array.Copy(rawData, i, peer, 0, 0x05);
                peerElements.Add(new PeerDevice(peer));
            }

            return peerElements;
        }
        #endregion

        #region [private] {static} (string) GetSegmentBusFunction(ushort): Gets a string representing SegmentBusFuction
        /// <summary>
        /// Gets a string representing SegmentBusFuction.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Segment  Bus function.
        /// </returns>
        private static string GetSegmentBusFunction(ushort code) => $"{code:X}";
        #endregion

        #region [private] {static} (string) GetSlotType(byte): Gets a string indicating the slot type
        /// <summary>
        /// Gets a string indicating the slot type.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Slot type.
        /// </returns>    
        private static string GetSlotType(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "ISA",
                "MCA",
                "EISA",
                "PCI",
                "PC Card (PCMCIA)",
                "VLB",
                "Proprietary",
                "Processor Card",
                "Proprietary Memory Card",
                "I/O Riser Card",
                "NuBus",
                "PCI-66",
                "AGP",
                "AGP 2x",
                "AGP 4x",
                "PCI-X",
                "AGP 8x",
                "M.2 Socket 1-DP (Mechanical Key A)",
                "M.2 Socket 1-SD (Mechanical Key E)",
                "M.2 Socket 2 (Mechanical Key B)",
                "M.2 Socket 3 (Mechanical Key M)",
                "MXM Type I",
                "MXM Type II",
                "MXM Type III (standard connector)",
                "MXM Type III (HE connector)",
                "MXM Type IV",
                "MXM 3.0 Type A",
                "MXM 3.0 Type B",
                "PCI Express Gen 2 SFF-8639",
                "PCI Express Gen 3 SFF-8639",
                "PCI Express Mini 52-pin (CEM spec. 2.0) with bottom-side keep-outs",
                "PCI Express Mini 52-pin (CEM spec. 2.0) without bottom-side keep-outs",
                "PCI Express Gen 4 SFF-8639 (U.2)",
                "PCI Express Gen 5 SFF-8639 (U.2)",
                "OCP NIC 3.0 Small Form Factor (SFF)",
                "OCP NIC 3.0 Large Form Factor (LFF)",
                "OCP NIC Prior to 3.0"  // 0x28h
            };

            string[] value1 =
            {
                "CXL Flexbus 1.0"  // 0x30
            };

            string[] value2 =
            {
                "PC-98/C20", // 0xA0
                "PC-98/C24",
                "PC-98/E",
                "PC-98/Local Bus",
                "PC-98/Card",
                "PCI Express",
                "PCI Express x1",
                "PCI Express x2",
                "PCI Express x4",
                "PCI Express x8",
                "PCI Express x16",
                "PCI Express Gen 2",
                "PCI Express Gen 2 x1",
                "PCI Express Gen 2 x2",
                "PCI Express Gen 2 x4",
                "PCI Express Gen 2 x8",
                "PCI Express Gen 2 x16",
                "PCI Express Gen 3",
                "PCI Express Gen 3 x1",
                "PCI Express Gen 3 x2",
                "PCI Express Gen 3 x4",
                "PCI Express Gen 3 x8",
                "PCI Express Gen 3 x16",
                "PCI Express Gen 4",
                "PCI Express Gen 4 x1",
                "PCI Express Gen 4 x2",
                "PCI Express Gen 4 x4",
                "PCI Express Gen 4 x8",
                "PCI Express Gen 4 x16",
                "PCI Express Gen 5",
                "PCI Express Gen 5 x1",
                "PCI Express Gen 5 x2",
                "PCI Express Gen 5 x4",
                "PCI Express Gen 5 x8",
                "PCI Express Gen 5 x16",
                "PCI Express Gen 6 and Beyond",
                "Enterprise and Datacenter 1U E1 Form Factor Slot",
                "Enterprise and Datacenter 3\" E3 Form Factor Slot" // 0xC6
            };

            if (code >= 0x01 && code <= 0x28)
            {
                return value[code - 0x01];
            }

            if (code >= 0x30 && code < 0xA0)
            {
                return value1[code - 0x01];
            }

            if (code >= 0xA0 && code <= 0xC3)
            {
                return value2[code - 0xA0];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetSlotHeight(byte): Gets a string that identifies the maximum supported card height for the slot
        /// <summary>
        /// Gets a string that identifies the maximum supported card height for the slot.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Maximum supported card height for the slot.
        /// </returns>
        private static string GetSlotHeight(byte code)
        {
            string[] value =
            {
                "Not applicable", // 0x00
                "Other",
                "Unknown",
                "Full height",
                "Low-profile"     // 0x04
            };

            if (code >= 0x00 && code <= 0x04)
            {
                return value[code];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
