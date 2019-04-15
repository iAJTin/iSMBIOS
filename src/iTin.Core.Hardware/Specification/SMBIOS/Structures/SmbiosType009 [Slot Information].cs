
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

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
    // |                      Number                                                                                                   | 
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.6+        Bus Number          BYTE        Varies                                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.6+        Device/Function     BYTE        Bit field   Bits 7:3 – device number                                     |
    // |                      Number                                      Bits 2:0 – function number                                   |
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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Slot Information (Type 9) structure.
    /// </summary>
    sealed class SmbiosType009 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType009(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType009(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.0+ fields

        #region [private] (string) SlotDesignation: Gets a value representing the 'Socket Designation' field
        /// <summary>
        /// Gets a value representing the <c>Slot Designation</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SlotDesignation => GetString(0x04);
        #endregion

        #region [private] (byte) SlotType: Gets a value representing the 'Slot Type' field
        /// <summary>
        /// Gets a value representing the <c>Slot Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SlotType => GetByte(0x05);
        #endregion

        #region [private] (byte) DataWidth: Gets a value representing the 'Data Width' field
        /// <summary>
        /// Gets a value representing the <c>Data Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DataWidth => GetByte(0x06);
        #endregion

        #region [private] (byte) CurrentUsage: Gets a value representing the 'Current Usage' field
        /// <summary>
        /// Gets a value representing the <c>Current Usage</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte CurrentUsage => GetByte(0x07);
        #endregion

        #region [private] (byte) Length: Gets a value representing the 'Length' field
        /// <summary>
        /// Gets a value representing the <c>Length</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Length => GetByte(0x08);
        #endregion

        #region [private] (byte) Adapter: Gets a value representing the 'Adapter' field
        /// <summary>
        /// Gets a value representing the <c>Adapter</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Adapter => GetByte(0x09);
        #endregion

        #region [private] (byte) Socket: Gets a value representing the 'Socket' field
        /// <summary>
        /// Gets a value representing the <c>Socket</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Socket => GetByte(0x0a);
        #endregion

        #region [private] (byte) Characteristics1: Gets a value representing the 'Characteristics1' field
        /// <summary>
        /// Gets a value representing the <c>Characteristics1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Characteristics1 => GetByte(0x0b);
        #endregion

        #endregion

        #region Version 2.1+ fields

        #region [private] (byte) Characteristics2: Gets a value representing the 'Characteristics2' field
        /// <summary>
        /// Gets a value representing the <c>Characteristics2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Characteristics2 => GetByte(0x0c);
        #endregion

        #endregion

        #region Version 2.6+ fields

        #region [private] (int) SegmentBusFunction: Gets a value representing the 'Segment Bus Function' field
        /// <summary>
        /// Gets a value representing the <c>Segment Bus Function</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int SegmentBusFunction => GetWord(0x0d);
        #endregion

        #region [private] (byte) Bus: Gets a value representing the 'Bus' field
        /// <summary>
        /// Gets a value representing the <c>Bus</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Bus => GetByte(0x0f);
        #endregion

        #region [private] (byte) DeviceFunctionNumber: Gets a value representing the 'Device Function Number' field
        /// <summary>
        /// Gets a value representing the <c>Device Function Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceFunctionNumber => GetByte(0x10);
        #endregion

        #region [private] (byte) Device: Gets a value representing the 'Device' feature of the 'Device/Function Number' field
        /// <summary>
        /// Gets a value representing the <c>Device</c> feature of the <c>Device/Function Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Device => (byte) ((DeviceFunctionNumber & 0xf8) >> 3);
        #endregion

        #region [private] (byte) Function: Gets a value representing the 'Function' feature of the 'Device/Function Number' field
        /// <summary>
        /// Gets a value representing the <c>Function</c> feature of the <c>Device/Function Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Function => (byte) (DeviceFunctionNumber & 0x07);
        #endregion

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
            SmbiosType009Property propertyId = (SmbiosType009Property)propertyKey.PropertyId;

            switch (propertyId)
            {                  
                #region [0x04] - [v2.0] - [Slot Designation] - [String]
                case SmbiosType009Property.SlotDesignation:
                    value = SlotDesignation;
                    break;
                #endregion

                #region [0x05] - [v2.0] - [Slot Type] - [String]
                case SmbiosType009Property.SlotType:
                    value = GetSlotType(SlotType);
                    break;
                #endregion

                #region [0x06] - [v2.0] - [Slot Data Bus Width] - [String]
                case SmbiosType009Property.SlotDataBusWidth:
                    value = GetDataBusWidth(DataWidth);
                    break;
                #endregion

                #region [0x07] - [v2.0] - [Current Usage] - [String]
                case SmbiosType009Property.CurrentUsage:
                    value = GetCurrentUsage(CurrentUsage);
                    break;
                #endregion

                #region [0x08] - [v2.0] - [Slot Length] - [String]
                case SmbiosType009Property.SlotLength:
                    value = GetLength(Length);
                    break;
                #endregion

                #region [0x09] - [v2.0] - [Slot ID] - [String]
                case SmbiosType009Property.SlotId:
                    value = GetId(SlotType, Adapter, Socket);
                    break;
                #endregion

                #region [0x0b] - [v2.0 - v2.1] - [Slot Characteristics] - [ReadOnlyCollection<string>]
                case SmbiosType009Property.SlotCharacteristics:
                    if (HeaderInfo.Length >= 0x0d)
                    {
                        value = GetCharacteristics(Characteristics1, Characteristics2);
                    }
                    else
                    {
                        value = GetCharacteristics(Characteristics1, 0xff);
                    }
                    break;
                #endregion

                #region [0x0d] - [v2.6] - [Segment Group Number] - [String]
                case SmbiosType009Property.SegmentBusFunction:
                    if (HeaderInfo.Length >= 0x0e)
                    {
                        value = GetSegmentBusFunction(SegmentBusFunction);
                    }
                    break;
                #endregion

                #region [0x10] - [v2.6] - [Device/Function Number] - [String]
                case SmbiosType009Property.BusDeviceFunction:
                    if (HeaderInfo.Length >= 0x11)
                    {
                        value = GetBusDeviceFunction(Bus, Device, Function);
                    }
                break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(PropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(PropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region versions

            #region 2.0+
            if (HeaderInfo.Length >= 0x0c)
            {
                properties.Add(KnownDmiProperty.SystemSlots.SlotDesignation, SlotDesignation);
                properties.Add(KnownDmiProperty.SystemSlots.SlotType, GetSlotType(SlotType));
                properties.Add(KnownDmiProperty.SystemSlots.SlotDataBusWidth, GetDataBusWidth(DataWidth));
                properties.Add(KnownDmiProperty.SystemSlots.CurrentUsage, GetCurrentUsage(CurrentUsage));
                properties.Add(KnownDmiProperty.SystemSlots.SlotLength, GetLength(Length));
                properties.Add(KnownDmiProperty.SystemSlots.SlotId, GetId(SlotType, Adapter, Socket));
                properties.Add(KnownDmiProperty.SystemSlots.Characteristics, GetCharacteristics(Characteristics1, 0xff));
            }
            #endregion

            #region 2.1+
            if (HeaderInfo.Length >= 0x0d)
            {
                properties[KnownDmiProperty.SystemSlots.Characteristics] = GetCharacteristics(Characteristics1, Characteristics2);
            }
            #endregion

            #region 2.6+
            if (HeaderInfo.Length >= 0x11)
            {
                properties.Add(KnownDmiProperty.SystemSlots.SegmentBusFunction, GetSegmentBusFunction(SegmentBusFunction));
                properties.Add(KnownDmiProperty.SystemSlots.BusDeviceFunction, GetBusDeviceFunction(Bus, Device, Function));
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.2.0 (26/04/2018)

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
        private static string GetBusDeviceFunction(byte bus, byte device, byte function)
        {
            return $"Bus = {bus}, Device = {device}, Function = {function}";
        }
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
                "PME signal is supported",         // 0x00
                "Hot-plug devices are supported",
                "SMBus signal is supported",        
                "PCIe slot supports bifurcation",  // 0x03
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
                for (byte i = 0; i <= 3; i++)
                {
                    bool addCharacteristic = code2.CheckBit(i);
                    if (addCharacteristic)
                    {
                        items.Add(value1[i]);
                    }
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

        #region [private] {static} (string) GetSegmentBusFunction(int): Gets a string representing SegmentBusFuction
        /// <summary>
        /// Gets a string representing SegmentBusFuction.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Segment  Bus function.
        /// </returns>
        private static string GetSegmentBusFunction(int code)
        {
            return $"{code:X}";
        }
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
                "PCI Express Mini 76-pin (CEM spec. 2.0) Corresponds to Display-Mini card." // 0x23
            };

            string[] value1 =
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
                "PCI Express Gen 3 x16" // 0xB6 
            };

            if (code >= 0x01 && code <= 0x23)
            {
                return value[code - 0x01];
            }

            if (code >= 0xA0 && code <= 0xB6)
            {
                return value1[code - 0xA0];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
