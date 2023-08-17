﻿
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;

using iTin.Hardware.Specification.Smbios.Property;

namespace iTin.Hardware.Specification.Smbios;

// Type 017: Memory Device.
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// |          Spec.                                                                                                      |
// | Offset   Version     Name                Length      deviceProperty       Description                               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h      2.1+        Type                BYTE        17          Memory Device type                                 |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h      2.1+        Length              BYTE        Varies      Length of the structure, a minimum of 15h          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated with the|
// |                                                                  structure                                          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h      2.1+        Physical            WORD        Varies      The handle, or instance number, associated with the|
// |                      Memory                                      Physical Memory Array to which this device belongs.|
// |                      Array Handle                                Note: See PhysicalArrayHandle                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h      2.1+        Memory              WORD        Varies      The handle, or instance number, associated with any|
// |                      Error                                       error that was previously detected for the device. |
// |                      Information                                 if the system does not provide the error           |
// |                      Handle                                      information structure, the field contains FFFEh;   |
// |                                                                  otherwise, the field contains either FFFFh         |
// |                                                                  (if no error was detected) or the handle of the    |
// |                                                                  error-information structure.                       |
// |                                                                  Note: See GetErrorHandle(int)                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h      2.1+        Total Width         WORD        Varies      The total width, in bits, of this memory device,   |
// |                                                                  including any check or error-correction bits.      |
// |                                                                  If there are no error-correction bits, this device |
// |                                                                  Property should be equal to Data Width.            |
// |                                                                  If the width is unknown, the field is set to FFFFh |
// |                                                                  Note: See TotalWidth                               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ah      2.1+        Data Width          WORD        Varies      The data width, in bits, of this memory device.    |
// |                                                                  A Data Width of 0 and a Total Width of 8 indicates |
// |                                                                  that the device is being used solely to provide 8  |
// |                                                                  error-correction bits.                             |
// |                                                                  If the width is unknown, the field is set to FFFFh |
// |                                                                  Note: See DataWidth                                |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch      2.1+        Size                WORD        Varies      The size of the memory device. If the device       |
// |                                                                  Property is 0, nomemory device is installed in the |
// |                                                                  socket; if the size is unknown, the field device   |
// |                                                                  Property is FFFFh. If the size is 32 GB-1 MB or    |
// |                                                                  greater, the field deviceProperty is 7FFFh and the |
// |                                                                  actual size is stored in the Extended Size field.  |
// |                                                                  The granularity in which the deviceProperty is     |
// |                                                                  specified depends on the setting of the            |
// |                                                                  most-significant bit (bit 15). If the bit          |
// |                                                                  is 0, the deviceProperty is specified in megabyte  |
// |                                                                  units; if the bit is 1, the deviceProperty is      |
// |                                                                  specified in kilobyte units.                       |
// |                                                                  For example, the deviceProperty 8100h identifies a |
// |                                                                  256 KB memory device and 0100h identifies a 256 MB |
// |                                                                  memory device.                                     |
// |                                                                  Note: see MemoryDeviceSize(ushort)                 |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Eh      2.1+        Form Factor         BYTE        ENUM        The implementation form factor for this memory     |
// |                                                                  device.                                            |
// |                                                                  Note: See GetFormFactor(byte)                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Fh      2.1+        Device Set          BYTE        Varies      Identifies when the Memory Device is one of a set  |
// |                                                                  of Memory Devices that must be populated with all  |
// |                                                                  devices of the same type and size, and the set to  |
// |                                                                  which this device belongs.                         |
// |                                                                  A deviceProperty of 0 indicates that the device is |
// |                                                                  not part of a set; a deviceProperty of FFh         |
// |                                                                  indicates that the attribute is unknown.           |
// |                                                                  NOTE: A Device Set number must be unique within the|
// |                                                                        context of the Memory Array containing this  |
// |                                                                        Memory Device.                               |
// |                                                                  Note: See DeviceSet(byte)                          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 10h      2.1+        Device              BYTE        STRING      The string number of the string that identifies the|
// |                      Locator                                     physically-labeled socket or board position where  |
// |                                                                  the memory device is located.                      |
// |                                                                  EXAMPLE: “SIMM 3”                                  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 11h      2.1+        Bank                BYTE        STRING      The string number of the string that identifies the|
// |                      Locator                                     physically labeled bank where the memory device is |
// |                                                                  located.                                           |
// |                                                                  EXAMPLE: “Bank 0” or “A”                           |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 12h      2.1+        Memory Type         BYTE        ENUM        The type of memory used in this device.            |
// |                                                                  Note: See GetDeviceType(byte)                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 13h      2.1+        Type Detail         WORD        Bit Field   Additional detail on the memory device type.       |
// |                                                                  Note: See GetDeviceTypeDetail(int)                 |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 15h      2.3+        Speed               WORD        Varies      Identifies the maximum capable speed of the device,|
// |                                                                  in megahertz (MHz).                                |
// |                                                                  If the deviceProperty is 0, the speed is unknown.  |
// |                                                                  NOTE: n MHz = (1000 / n) nanoseconds (ns)          |
// |                                                                  Note: See MaximunSpeed                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 17h      2.3+        Manufacturer        BYTE        STRING      String number for the manufacturer of this memory  |
// |                                                                  device.                                            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 18h      2.3+        Serial              BYTE        STRING      String number for the serial number of this memory |
// |                      Number                                      device.                                            |
// |                                                                  This deviceProperty is set by the manufacturer and |
// |                                                                  normally is not changeable.                        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 19h      2.3+        Asset Tag           BYTE        STRING      String number for the asset tag of this memory     |
// |                                                                  device.                                            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Ah      2.3+        Part Number         BYTE        STRING      String number for the part number of this memory   |
// |                                                                  device.                                            |
// |                                                                  This deviceProperty is set by the manufacturer and |
// |                                                                  normally is not changeable.                        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Bh      2.6+        Attributes          BYTE        Varies      Bits 07-04: reserved                               |
// |                                                                  Bits 03-00: rank                                   |
// |                                                                  deviceProperty=0 for unknown rank information.     |
// |                                                                  Note: See Rank                                     |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Ch      2.7+        Extended            DWORD       Varies      The extended size of the memory device (complements|
// |                      Size                                        the Size field at offset 0Ch)                      |
// |                                                                  deviceProperty = 0 for unknown rank information.   |
// |                                                                  Note: See ExtendedSize                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 20h      2.7+        Configured          WORD        Varies      Identifies the configured clock speed to the memory|
// |                      Memory                                      device, in megahertz (MHz).                        |
// |                      Clock Speed                                 If the deviceProperty is 0, the speed is unknown.  |
// |                                                                  NOTE: n MHz = (1000 / n) nanoseconds (ns)          |
// |                                                                  Note: See CurrentSpeed                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 22h      2.8+        Minimum             WORD        Varies      Minimum operating voltage for this device, in      |
// |                      voltage                                     millivolts.                                        |
// |                                                                  If the value is 0, the voltage is unknown.         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 24h      2.8+        Maximum             WORD        Varies      Maximum operating voltage for this device, in      |
// |                      voltage                                     millivolts.                                        |
// |                                                                  If the value is 0, the voltage is unknown.         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 26h      2.8+        Configured          WORD        Varies      Configured voltage for this device, in millivolts  |
// |                      voltage                                     If the value is 0, the voltage is unknown.         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 28h      3.2+        Memory              BYTE        Varies      Memory technology type for this memory device.     |
// |                      Technology                                  Note: See GetMemoryTechnology                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 29h      3.2+        Memory              WORD        Bit Field   The operating modes supported by this memory       |
// |                      Operating                                   device.                                            |
// |                      Mode                                                                                           |
// |                      Capability                                                                                     |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 2Bh      3.2+        Firmware            BYTE        String      String number for the firmware version of this     |
// |                      Version                                     memory device.                                     |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 2Ch      3.2+        Module              WORD        Varies      The two-byte module manufacturer ID found in the   |
// |                      Manufacturer                                SPD of this memory device; LSB first               |
// |                      ID                                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 2Eh      3.2+        Module              WORD        Varies      The two-byte module product ID found in the        |
// |                      Product                                     SPD of this memory device; LSB first               |
// |                      ID                                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 30h      3.2+        Memory              WORD        Varies      The two-byte memory subsystem controller           |
// |                      Subsystem                                   manufacturer ID found in the SPD of this memory    |
// |                      Controller                                  device. LSB first.                                 |
// |                      Manufacturer                                                                                   |
// |                      ID                                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 32h      3.2+        Memory              WORD        Varies      The two-byte memory subsystem controller product   |
// |                      Subsystem                                   ID found in the SPD of this memory device.         |
// |                      Controller                                  LSB first                                          |
// |                      Product                                                                                        |
// |                      ID                                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 34h      3.2+        Non-volatile        QWORD       Varies      Size of the Non-volatile portion of the memory     |
// |                      Size                                        device in Bytes, if any.                           |
// |                                                                  If is 0, there is no non-volatile portion.         |
// |                                                                  If is FFFFFFFFFFFFFFFFh, is unknown.               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 3Ch      3.2+        Volatile Size       QWORD       Varies      Size of the Volatile portion of the memory device  |
// |                                                                  in Bytes, if any.                                  |
// |                                                                  If is 0, there is no volatile portion.             |
// |                                                                  If is FFFFFFFFFFFFFFFFh, is unknown.               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 44h      3.2+        Cache Size          QWORD       Varies      Size of the cache portion of the memory device in  |
// |                                                                  Bytes, if any.                                     |
// |                                                                  If is 0, there is no volatile portion.             |
// |                                                                  If is FFFFFFFFFFFFFFFFh, is unknown.               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 4Ch      3.2+        Lofical Size        QWORD       Varies      Size of the logical memory device in Bytes.        |
// |                                                                  If is FFFFFFFFFFFFFFFFh, is unknown.               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 54h      3.3+        Extended            DWORD       Varies      Extended speed of the memory device                |
// |                      Speed                                       (complements the Speed field at offset 15h).       |
// |                                                                  Identifies the maximum capable speed of the        |
// |                                                                  device, in megatransfers per second (MT/s).        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 58h      3.3+        Extended            DWORD       Varies      Extended configured memory speed of the memory     |
// |                      Configured                                  device (complements the Configured Memory          |
// |                      Memory                                      Speed field at offset 20h). Identifies the .       |
// |                      Speed                                       configured speed of the memory device, in          |
// |                                                                  megatransfers per second (MT/s).                   |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 5Ch      3.7+        PMIC0               WORD        Varies      The two-byte PMIC0 manufacturer ID found in the    |
// |                      Manufacturer ID                             SPD of this memory device; LSB first.              |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 5Eh      3.7+        PMIC0 Revision      WORD        Varies      The PMIC 0 Revision Number found in the SPD of     |
// |                      Number                                      this memory device.                                |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 60h      3.7+        RCD                 WORD        Varies      The two-byte RCD manufacturer ID found in the      |
// |                      Manufacturer ID                             SPD of this memory device; LSB first.              |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 62h      3.7+        RCD Revision        WORD        Varies      The RCD 0 Revision Number found in the SPD of      |
// |                      Number                                      this memory device.                                |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Memory Device (Type 17) structure.
/// </summary>
internal sealed class SmbiosType017 : SmbiosBaseType
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SmbiosType017"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
    /// </summary>
    /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
    /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
    public SmbiosType017(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
    {
    }

    #endregion

    #region private properties

    #region Version 2.1+ fields

    /// <summary>
    /// Gets a value representing the <b>Physical Array Memory Handle</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort PhysicalArrayMemoryHandle => (ushort)Reader.GetWord(0x04);

    /// <summary>
    /// Gets a value representing the <b>Memory Error Information Handle</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MemoryErrorInformationHandle => (ushort)Reader.GetWord(0x06);

    /// <summary>
    /// Gets a value representing the <b>Total Width</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort TotalWidth => (ushort)Reader.GetWord(0x08);

    /// <summary>
    /// Gets a value representing the <b>Data Width</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort DataWidth => (ushort)Reader.GetWord(0x0a);

    /// <summary>
    /// Gets a value representing the <b>Size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Size => (ushort)Reader.GetWord(0x0c);

    /// <summary>
    /// Gets a value representing the <b>Form Factor</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte FormFactor => Reader.GetByte(0x0e);

    /// <summary>
    /// Gets a value representing the <b>Device Set</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DeviceSet => Reader.GetByte(0x0f);

    /// <summary>
    /// Gets a value indicating whether this device belongs to a set of the same capacity and type.
    /// </summary>
    /// <value>
    /// One of the values in the <see cref = "MemoryDeviceBelongsToSet"/> enumeration that indicates membership to a set.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private MemoryDeviceBelongsToSet BelongsToSet
    {
        get
        {
            if (DeviceSet == 0)
            {
                return MemoryDeviceBelongsToSet.No;
            }

            if (DeviceSet == 0xff)
            {
                return MemoryDeviceBelongsToSet.Unknown;
            }

            return MemoryDeviceBelongsToSet.Yes;
        }
    }

    /// <summary>
    /// Gets a value representing the <b>Device Locator</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DeviceLocator => GetString(0x10);

    /// <summary>
    /// Gets a value representing the <b>Bank Locator</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string BankLocator => GetString(0x11);

    /// <summary>
    /// Gets a value representing the <b>Memory Type</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte MemoryType => Reader.GetByte(0x12);

    /// <summary>
    /// Gets a value representing the <b>Type Detail</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort TypeDetail => (ushort)Reader.GetWord(0x13);

    #endregion

    #region Version 2.3+ fields

    /// <summary>
    /// Gets a value representing the <b>Manufacturer</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string Manufacturer => GetString(0x17);

    /// <summary>
    /// Gets a value representing the <b>Serial Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string SerialNumber => GetString(0x18);

    /// <summary>
    /// Gets a value representing the <b>Asset Tag</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string AssetTag => GetString(0x19);

    /// <summary>
    /// Gets a value representing the <b>Part Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string PartNumber => GetString(0x1a);

    /// <summary>
    /// Gets a value representing the <b>Speed</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort Speed => (ushort)Reader.GetWord(0x15);

    #endregion

    #region Version 2.6+ fields

    /// <summary>
    /// Gets a value representing the <b>Rank</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Rank => (byte) (Reader.GetByte(0x1b) & 0x0f);

    #endregion

    #region Version 2.7+ fields

    /// <summary>
    /// Gets a value representing the <b>Extended Size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint ExtendedSize => (uint)Reader.GetDoubleWord(0x1c) & 0x7FFFFFFF;

    /// <summary>
    /// Gets a value representing the <b>Current Speed</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort CurrentSpeed => (ushort)Reader.GetWord(0x20);

    #endregion

    #region Version 2.8+ fields

    /// <summary>
    /// Gets a value representing the <b>Minimum Voltage</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MinimumVoltage => (ushort)Reader.GetWord(0x22);

    /// <summary>
    /// Gets a value representing the <b>Maximum Voltage</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MaximumVoltage => (ushort)Reader.GetWord(0x24);

    /// <summary>
    /// Gets a value representing the <b>Configured Voltage</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ConfiguredVoltage => (ushort)Reader.GetWord(0x26);

    #endregion

    #region Version 3.2+ fields

    /// <summary>
    /// Gets a value representing the '<b>Memory Technology</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte MemoryTechnology => Reader.GetByte(0x28);

    /// <summary>
    /// Gets a value representing the '<b>Memory Operating Mode Capability</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int MemoryOperatingModeCapability => Reader.GetWord(0x29);

    /// <summary>
    /// Gets a value representing the '<b>Firmware Version</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string FirmwareVersion => GetString(0x2b);

    /// <summary>
    /// Gets a value representing the '<b>Module Manufacturer Id</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ModuleManufacturerId => (ushort)Reader.GetWord(0x2c);

    /// <summary>
    /// Gets a value representing the '<b>Module Product Id</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ModuleProductId => (ushort)Reader.GetWord(0x2e);

    /// <summary>
    /// Gets a value representing the '<b>Memory Subsystem Controller Manufacturer Id</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MemorySubsystemControllerManufacturerId => (ushort)Reader.GetWord(0x30);

    /// <summary>
    /// Gets a value representing the '<b>Memory Subsystem Controller Product Id</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort MemorySubsystemControllerProductId => (ushort)Reader.GetWord(0x32);

    /// <summary>
    /// Gets a value representing the '<b>Non Volatile Size</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ulong NonVolatileSize => (ulong)Reader.GetQuadrupleWord(0x34);

    /// <summary>
    /// Gets a value representing the '<b>Volatile Size</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ulong VolatileSize => (ulong)Reader.GetQuadrupleWord(0x3c);

    /// <summary>
    /// Gets a value representing the '<b>Cache Size</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ulong CacheSize  => (ulong)Reader.GetQuadrupleWord(0x44);

    /// <summary>
    /// Gets a value representing the '<b>Logical Size</b>' field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ulong LogicalSize => (ulong)Reader.GetQuadrupleWord(0x4c);

    #endregion

    #region Version 3.3+ fields

    /// <summary>
    /// Gets a value representing the <b>Extended Speed</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort ExtendedSpeed => (ushort)Reader.GetWord(0x54);

    /// <summary>
    /// Gets a value representing the <b>Extended Configured Speed</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint ExtendedConfiguredSpeed => (uint)Reader.GetDoubleWord(0x58);

    #endregion

    #region Version 3.7+ fields

    /// <summary>
    /// Gets a value representing the <b>PMIC0 Manufacturer ID</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort PMIC0ManufacturerId => (ushort)Reader.GetWord(0x5c);

    /// <summary>
    /// Gets a value representing the <b>PMIC0 Revision Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort PMIC0RevisionNumber => (ushort)Reader.GetWord(0x5e);

    /// <summary>
    /// Gets a value representing the <b>RCD Manufacturer ID</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort RCDManufacturerId => (ushort)Reader.GetWord(0x60);

    /// <summary>
    /// Gets a value representing the <b>RCD Revision Number</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ushort RCDRevisionNumber => (ushort)Reader.GetWord(0x62);

    #endregion

    #endregion

    #region protected override methods

    /// <inheritdoc/>
    protected override void PopulateProperties(SmbiosPropertiesTable properties)
    {
        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
        {
            properties.Add(SmbiosProperty.MemoryDevice.PhysicalMemoryArrayHandle, PhysicalArrayMemoryHandle);
            properties.Add(SmbiosProperty.MemoryDevice.MemoryErrorInformationHandle, MemoryErrorInformationHandle);
            properties.Add(SmbiosProperty.MemoryDevice.TotalWidth, TotalWidth);
            properties.Add(SmbiosProperty.MemoryDevice.DataWidth, DataWidth);
            properties.Add(SmbiosProperty.MemoryDevice.Size, Size);
            properties.Add(SmbiosProperty.MemoryDevice.FormFactor, GetFormFactor(FormFactor));
                
            MemoryDeviceBelongsToSet belongsToSet = BelongsToSet;
            if (belongsToSet.Equals(MemoryDeviceBelongsToSet.Yes))
            {
                properties.Add(SmbiosProperty.MemoryDevice.DeviceSet, DeviceSet);
            }
                
            properties.Add(SmbiosProperty.MemoryDevice.DeviceLocator, DeviceLocator);
            properties.Add(SmbiosProperty.MemoryDevice.BankLocator, BankLocator);
            properties.Add(SmbiosProperty.MemoryDevice.MemoryType, GetDeviceType(MemoryType));
            properties.Add(SmbiosProperty.MemoryDevice.TypeDetail, GetDeviceTypeDetail(TypeDetail));
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v23)
        {
            properties.Add(SmbiosProperty.MemoryDevice.Speed, Speed);
            properties.Add(SmbiosProperty.MemoryDevice.Manufacturer, Manufacturer);
            properties.Add(SmbiosProperty.MemoryDevice.SerialNumber, SerialNumber);
            properties.Add(SmbiosProperty.MemoryDevice.AssetTag, AssetTag);
            properties.Add(SmbiosProperty.MemoryDevice.PartNumber, PartNumber);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v26)
        {
            properties.Add(SmbiosProperty.MemoryDevice.Rank, Rank);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v27)
        {
            properties.Add(SmbiosProperty.MemoryDevice.ExtendedSize, ExtendedSize);
            properties.Add(SmbiosProperty.MemoryDevice.ConfiguredMemoryClockSpeed, CurrentSpeed);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v28)
        {
            properties.Add(SmbiosProperty.MemoryDevice.MinimumVoltage, MinimumVoltage);
            properties.Add(SmbiosProperty.MemoryDevice.MaximumVoltage, MaximumVoltage);
            properties.Add(SmbiosProperty.MemoryDevice.ConfiguredVoltage, ConfiguredVoltage);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v32)
        {
            string memoryTechnology = GetMemoryTechnology(MemoryTechnology);
            properties.Add(SmbiosProperty.MemoryDevice.MemoryTechnology, memoryTechnology);

            ReadOnlyCollection<string> memoryOperatingModeCapability = GetMemoryOperatingModeCapability(MemoryOperatingModeCapability);
            properties.Add(SmbiosProperty.MemoryDevice.MemoryOperatingModeCapability, memoryOperatingModeCapability);

            properties.Add(SmbiosProperty.MemoryDevice.FirmwareVersion, FirmwareVersion);
            properties.Add(SmbiosProperty.MemoryDevice.ModuleManufacturerId, ModuleManufacturerId);
            properties.Add(SmbiosProperty.MemoryDevice.ModuleProductId, ModuleProductId);
            properties.Add(SmbiosProperty.MemoryDevice.MemorySubsystemControllerManufacturerId, MemorySubsystemControllerManufacturerId);
            properties.Add(SmbiosProperty.MemoryDevice.MemorySubsystemControllerProductId, MemorySubsystemControllerProductId);
            properties.Add(SmbiosProperty.MemoryDevice.NonVolatileSize, NonVolatileSize);
            properties.Add(SmbiosProperty.MemoryDevice.VolatileSize, VolatileSize);
            properties.Add(SmbiosProperty.MemoryDevice.CacheSize, CacheSize);
            properties.Add(SmbiosProperty.MemoryDevice.LogicalSize, LogicalSize);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v33)
        {
            properties.Add(SmbiosProperty.MemoryDevice.ExtendedSpeed, ExtendedSpeed);
            properties.Add(SmbiosProperty.MemoryDevice.ExtendedConfiguredMemorySpeed, ExtendedConfiguredSpeed);
        }

        if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v37)
        {
            properties.Add(SmbiosProperty.MemoryDevice.PMIC0ManufacturerId, PMIC0ManufacturerId);
            properties.Add(SmbiosProperty.MemoryDevice.PMIC0RevisionNumber, PMIC0RevisionNumber);
            properties.Add(SmbiosProperty.MemoryDevice.RCDManufacturerId, RCDManufacturerId);
            properties.Add(SmbiosProperty.MemoryDevice.RCDRevisionNumber, RCDRevisionNumber);
        }
    }

    #endregion


    #region BIOS Specification 3.7.0 (23/07/2023)

    /// <summary>
    /// Gets a string representing the device type.
    /// </summary>
    /// <param name="code">Value to analyze.</param>
    /// <returns>
    /// Device type.
    /// </returns> 
    private static string GetDeviceType(byte code)
    {
        string[] deviceProperty =
        {
            "Other",                                    // 0x01
            "Unknown",
            "DRAM",
            "EDRAM",
            "VRAM",
            "SRAM",
            "RAM",
            "ROM",
            "FLASH",
            "EEPROM",
            "FEPROM",
            "EPROM",
            "CDRAM",
            "3DRAM",
            "SDRAM",
            "SGRAM",
            "RDRAM",
            "DDR",
            "DDR2",
            "DDR2 FB-DIMM"                              // 0x14
        };

        string[] deviceProperty2 =
        {
            "DDR3",                                     // 0x18
            "FBD2",
            "DDR4",
            "LPDDR",
            "LPDDR2",
            "LPDDR3",
            "LPDDR4",
            "Logical non-volatile device", 
            "HBM",
            "HBM2",
            "DDR5",
            "LPDDR5",
            "HBM3"                                      // 0x24
        };

        if (code >= 0x01 && code <= 0x14)
        {
            return deviceProperty[code - 0x01];
        }

        if (code >= 0x18 && code <= 0x24)
        {
            return deviceProperty2[code - 0x18];
        }

        return SmbiosHelper.OutOfSpec;
    }

    /// <summary>
    /// Gets a string representing the device type detail.
    /// </summary>
    /// <param name="code">Value to analyze.</param>
    /// <returns>
    /// Device type detail.
    /// </returns>  
    private static ReadOnlyCollection<string> GetDeviceTypeDetail(int code)
    {
        string[] deviceProperty =
        {
            "Other",                         // 0x01
            "Unknown",
            "Fast-paged",
            "Static column",
            "Pseudo-static",
            "RAMBUS",
            "Synchronous",
            "CMOS",
            "EDO",
            "Window DRAM",
            "Cache DRAM",
            "Non-volatile",
            "Registered (Buffered)",
            "Unbuffered (Unregistered)",
            "LRDIMM "                        // 0x15
        };

        var items = new List<string>();
        for (var i = 1; i <= 15; i++)
        {
            var bit = (byte)(i + 1);
            var addDetail = code.CheckBit(bit);
            if (addDetail)
            {
                items.Add(deviceProperty[i]);
            }
        }

        return items.AsReadOnly();
    }

    /// <summary>
    /// Gets a string that represents the shape of the device.
    /// </summary>
    /// <param name="code">Value to analyze.</param>
    /// <returns>
    /// A string that represents the shape of the device.
    /// </returns> 
    private static string GetFormFactor(byte code)
    {
        string[] deviceProperty =
        {
            "Other",               // 0x01
            "Unknown",
            "SIMM",
            "SIP",
            "Chip",
            "DIP",
            "ZIP",
            "Propietary Card",
            "DIMM",
            "TSOP",
            "Row of chips",
            "RIMM",
            "SODIMM",
            "SRIMM",
            "FB-DIMM", 
            "Die"                  // 0x10
        };

        if (code >= 0x01 && code <= 0x10)
        {
            return deviceProperty[code - 0x01];
        }

        return SmbiosHelper.OutOfSpec;
    }

    /// <summary>
    /// Gets a string that represents the memory type technology.
    /// </summary>
    /// <param name="code">Value to analyze.</param>
    /// <returns>
    /// A string that represents the memory type technology.
    /// </returns> 
    private static string GetMemoryTechnology(byte code)
    {
        string[] deviceProperty =
        {
            "Other",                               // 0x01
            "Unknown",
            "DRAM",
            "NVDIMM-N",
            "NVDIMM-F",
            "NVDIMM-P",
            "Intel® Optane™ persistent memory"     // 0x07
        };

        if (code >= 0x01 && code <= 0x07)
        {
            return deviceProperty[code - 0x01];
        }

        return SmbiosHelper.OutOfSpec;
    }

    /// <summary>
    /// Gets a memory operating mode capability.
    /// </summary>
    /// <param name="code">Value to analyze</param>
    /// <returns>
    /// A read-only collection of supported memory operating mode capabilities.
    /// </returns>            
    private static ReadOnlyCollection<string> GetMemoryOperatingModeCapability(int code)
    {
        string[] capability =
        {
            "Reserved", // 0x00
            "Other",
            "Unknown",
            "Volatile memory",
            "Byte-accessible persistent memory",
            "Block-accessible persistent memory", // 0x05

            // Bit 0x06 - 0x0f Reserved (0)
        };

        var items = new List<string>();
        for (byte i = 1; i <= 5; i++)
        {
            var addType = code.CheckBit(i);
            if (addType)
            {
                items.Add(capability[i]);
            }
        }

        return items.AsReadOnly();
    }

    #endregion
}
