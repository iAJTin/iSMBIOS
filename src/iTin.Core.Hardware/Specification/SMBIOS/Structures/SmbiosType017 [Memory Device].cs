
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;
    using Helpers.Enumerations;

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
    // |                      Array Handle                                Note: Ver PhysicalArrayHandle                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.1+        Memory              WORD        Varies      The handle, or instance number, associated with any|
    // |                      Error                                       error that was previously detected for the device. |
    // |                      Information                                 if the system does not provide the error           |
    // |                      Handle                                      information structure, the field contains FFFEh;   |
    // |                                                                  otherwise, the field contains either FFFFh         |
    // |                                                                  (if no error was detected) or the handle of the    |
    // |                                                                  error-information structure.                       |
    // |                                                                  Note: Ver GetErrorHandle(int)                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.1+        Total Width         WORD        Varies      The total width, in bits, of this memory device,   |
    // |                                                                  including any check or error-correction bits.      |
    // |                                                                  If there are no error-correction bits, this device |
    // |                                                                  Property should be equal to Data Width.            |
    // |                                                                  If the width is unknown, the field is set to FFFFh |
    // |                                                                  Note: Ver TotalWidth                               |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.1+        Data Width          WORD        Varies      The data width, in bits, of this memory device.    |
    // |                                                                  A Data Width of 0 and a Total Width of 8 indicates |
    // |                                                                  that the device is being used solely to provide 8  |
    // |                                                                  error-correction bits.                             |
    // |                                                                  If the width is unknown, the field is set to FFFFh |
    // |                                                                  Note: Ver DataWidth                                |
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
    // |                                                                  Note: Ver GetFormFactor(byte)                      |
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
    // |                                                                  Note: Ver DeviceSet(byte)                          |
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
    // |                                                                  Note: Ver GetDeviceType(byte)                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      2.1+        Type Detail         WORD        Bit Field   Additional detail on the memory device type.       |
    // |                                                                  Note: Ver GetDeviceTypeDetail(int)                 |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.3+        Speed               WORD        Varies      Identifies the maximum capable speed of the device,|
    // |                                                                  in megahertz (MHz).                                |
    // |                                                                  If the deviceProperty is 0, the speed is unknown.  |
    // |                                                                  NOTE: n MHz = (1000 / n) nanoseconds (ns)          |
    // |                                                                  Note: Ver MaximunSpeed                             |
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
    // |                                                                  Note: Ver Rank                                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ch      2.7+        Extended            DWORD       Varies      The extended size of the memory device (complements|
    // |                      Size                                        the Size field at offset 0Ch)                      |
    // |                                                                  deviceProperty = 0 for unknown rank information.   |
    // |                                                                  Note: Ver ExtendedSize                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 20h      2.7+        Configured          WORD        Varies      Identifies the configured clock speed to the memory|
    // |                      Memory                                      device, in megahertz (MHz).                        |
    // |                      Clock Speed                                 If the deviceProperty is 0, the speed is unknown.  |
    // |                                                                  NOTE: n MHz = (1000 / n) nanoseconds (ns)          |
    // |                                                                  Note: Ver CurrentSpeed                             |
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
    // |                      Subsystem                                    manufacturer ID found in the SPD of this memory   |
    // |                      Controller                                   device. LSB first.                                |
    // |                      Manufacturer                                                                                   |
    // |                      ID                                                                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 32h      3.2+        Memory              WORD        Varies      The two-byte memory subsystem controller product   |
    // |                      Subsystem                                    ID found in the SPD of this memory device.        |
    // |                      Controller                                   LSB first                                         |
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

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Memory Device (Type 17) structure.
    /// </summary>
    sealed class SmbiosType017 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType017(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType017" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType017(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (int) PhysicalArrayMemoryHandle: Gets a value representing the 'Physical Array Memory Handle' field
        /// <summary>
        /// Gets a value representing the <c>Physical Array Memory Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int PhysicalArrayMemoryHandle => GetWord(0x04);
        #endregion

        #region [private] (int) MemoryErrorInformationHandle: Gets a value representing the 'Memory Error Information Handle' field
        /// <summary>
        /// Gets a value representing the <c>Memory Error Information Handle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MemoryErrorInformationHandle => GetWord(0x06);
        #endregion

        #region [private] (int) TotalWidth: Gets a value representing the 'Total Width' field
        /// <summary>
        /// Gets a value representing the <c>Total Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int TotalWidth => GetWord(0x08);
        #endregion

        #region [private] (int) DataWidth: Gets a value representing the 'Data Width' field
        /// <summary>
        /// Gets a value representing the <c>Data Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int DataWidth => GetWord(0x0a);
        #endregion

        #region [private] (int) Size: Gets a value representing the 'Size' field
        /// <summary>
        /// Gets a value representing the <c>Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Size => GetWord(0x0c);
        #endregion

        #region [private] (byte) FormFactor: Gets a value representing the 'Form Factor' field
        /// <summary>
        /// Gets a value representing the <c>Form Factor</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FormFactor => GetByte(0x0e);
        #endregion

        #region [private] (byte) DeviceSet: Gets a value representing the 'Device Set' field
        /// <summary>
        /// Gets a value representing the <c>Device Set</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DeviceSet => GetByte(0x0f);
        #endregion

        #region [private] (MemoryDeviceBelongsToSet) BelongsToSet: Gets a value indicating whether this device belongs to a set of the same capacity and type
        /// <summary>
        /// Gets a value indicating whether this device belongs to a set of the same capacity and type.
        /// </summary>
        /// <value>
        /// One of the values in the <see cref = "MemoryDeviceBelongsToSet" /> enumeration that indicates membership to a set.
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
        #endregion

        #region [private] (string) DeviceLocator: Gets a value representing the 'Device Locator' field
        /// <summary>
        /// Gets a value representing the <c>Device Locator</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DeviceLocator => GetString(0x10);
        #endregion

        #region [private] (string) BankLocator: Gets a value representing the 'Bank Locator' field
        /// <summary>
        /// Gets a value representing the <c>Bank Locator</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BankLocator => GetString(0x11);
        #endregion

        #region [private] (byte) MemoryType: Gets a value representing the 'Memory Type' field
        /// <summary>
        /// Gets a value representing the <c>Memory Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MemoryType => GetByte(0x12);
        #endregion

        #region [private] (int) TypeDetail: Gets a value representing the 'Type Detail' field
        /// <summary>
        /// Gets a value representing the <c>Type Detail</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int TypeDetail => GetWord(0x13);
        #endregion

        #endregion

        #region Version 2.3+ fields

        #region [private] (string) Manufacturer: Gets a value representing the 'Manufacturer' field
        /// <summary>
        /// Gets a value representing the <c>Manufacturer</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Manufacturer => GetString(0x17);
        #endregion

        #region [private] (string) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string SerialNumber => GetString(0x18);
        #endregion

        #region [private] (string) AssetTag: Gets a value representing the 'Asset Tag' field
        /// <summary>
        /// Gets a value representing the <c>Asset Tag</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string AssetTag => GetString(0x19);
        #endregion

        #region [private] (string) PartNumber: Gets a value representing the 'Part Number' field
        /// <summary>
        /// Gets a value representing the <c>Part Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string PartNumber => GetString(0x1a);
        #endregion

        #region [private] (int) MaximunSpeed: Gets a value representing the 'Maximun Speed' field
        /// <summary>
        /// Gets a value representing the <c>Maximun Speed</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximunSpeed => GetWord(0x15);
        #endregion

        #endregion

        #region Version 2.6+ fields

        #region [private] (byte) Rank: Gets a value representing the 'Rank' field
        /// <summary>
        /// Gets a value representing the <c>Rank</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Rank => (byte) (GetByte(0x1b) & 0x0f);
        #endregion

        #endregion

        #region Version 2.7+ fields

        #region [private] (uint) ExtendedSize: Gets a value representing the 'Extended Size' field
        /// <summary>
        /// Gets a value representing the <c>Extended Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint ExtendedSize => (uint) GetDoubleWord(0x1c) & 0x7FFFFFFF;
        #endregion

        #region [private] (int) CurrentSpeed: Gets a value representing the 'Current Speed' field
        /// <summary>
        /// Gets a value representing the <c>Current Speed</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CurrentSpeed => GetWord(0x20);
        #endregion

        #endregion

        #region Version 2.8+ fields

        #region [private] (int) MinimunVoltage: Gets a value representing the 'Minimun Voltage' field
        /// <summary>
        /// Gets a value representing the <c>Minimun Voltage</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimunVoltage => GetWord(0x22);
        #endregion

        #region [private] (int) MaximumVoltage: Gets a value representing the 'Maximum Voltage' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Voltage</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumVoltage => GetWord(0x24);
        #endregion

        #region [private] (int) ConfiguredVoltage: Gets a value representing the 'Configured Voltage' field
        /// <summary>
        /// Gets a value representing the <c>Configured Voltage</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ConfiguredVoltage => GetWord(0x26);
        #endregion

        #endregion

        #region Version 3.2+ fields

        #region [private] (byte) MemoryTechnology: Gets a value representing the 'Memory Technology' field
        /// <summary>
        /// Gets a value representing the '<c>Memory Technology</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MemoryTechnology => GetByte(0x28);
        #endregion

        #region [private] (byte) MemoryOperatingModeCapability: Gets a value representing the 'Memory Operating Mode Capability' field
        /// <summary>
        /// Gets a value representing the '<c>Memory Operating Mode Capability</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MemoryOperatingModeCapability => GetWord(0x29);
        #endregion

        #region [private] (string) FirmwareVersion: Gets a value representing the 'Firmware Version' field
        /// <summary>
        /// Gets a value representing the '<c>Firmware Version</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string FirmwareVersion => GetString(0x2b);
        #endregion

        #region [private] (int) ModuleManufacturerId: Gets a value representing the 'Module Manufacturer Id' field
        /// <summary>
        /// Gets a value representing the '<c>Module Manufacturer Id</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ModuleManufacturerId => GetWord(0x2c);
        #endregion

        #region [private] (int) ModuleProductId: Gets a value representing the 'Module Product Id' field
        /// <summary>
        /// Gets a value representing the '<c>Module Product Id</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ModuleProductId => GetWord(0x2e);
        #endregion

        #region [private] (int) MemorySubsystemControllerManufacturerId: Gets a value representing the 'Memory Subsystem Controller Manufacturer Id' field
        /// <summary>
        /// Gets a value representing the '<c>Memory Subsystem Controller Manufacturer Id</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MemorySubsystemControllerManufacturerId => GetWord(0x30);
        #endregion

        #region [private] (int) MemorySubsystemControllerManufacturerId: Gets a value representing the 'Memory Subsystem Controller Product Id' field
        /// <summary>
        /// Gets a value representing the '<c>Memory Subsystem Controller Product Id</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MemorySubsystemControllerProductId => GetWord(0x32);
        #endregion

        #region [private] (ulong) NonVolatileSize: Gets a value representing the 'Non Volatile Size' field
        /// <summary>
        /// Gets a value representing the '<c>Non Volatile Size</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong NonVolatileSize => (ulong) GetQuadrupleWord(0x34);
        #endregion

        #region [private] (ulong) VolatileSize: Gets a value representing the 'Volatile Size' field
        /// <summary>
        /// Gets a value representing the '<c>Volatile Size</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong VolatileSize => (ulong)GetQuadrupleWord(0x3c);
        #endregion

        #region [private] (ulong) CacheSize: Gets a value representing the 'Cache Size' field
        /// <summary>
        /// Gets a value representing the '<c>Cache Size</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong CacheSize  => (ulong)GetQuadrupleWord(0x44);
        #endregion

        #region [private] (ulong) LogicalSize: Gets a value representing the 'Logical Size' field
        /// <summary>
        /// Gets a value representing the '<c>Logical Size</c>' field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong LogicalSize => (ulong)GetQuadrupleWord(0x4c);
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
            var propertyId = (SmbiosType017Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.1] - [Physical Memory Array Handle] - [Int32]
                case SmbiosType017Property.PhysicalMemoryArrayHandle:
                    value = PhysicalArrayMemoryHandle;
                    break;
                #endregion

                #region [0x06] - [v2.1] - [Memory Error Information Handle] - [Int32]
                case SmbiosType017Property.MemoryErrorInformationHandle:
                    var memoryErrorInformationHandle = MemoryErrorInformationHandle;
                    switch (memoryErrorInformationHandle)
                    {
                        case 0xffff:
                            value = -1;
                            break;

                        case 0xfffe:
                            value = -2;
                            break;

                        default:
                            value = memoryErrorInformationHandle;
                            break;
                    }
                    break;
                #endregion

                #region [0x08] - [v2.1] - [Total Width] - [Int32?]
                case SmbiosType017Property.TotalWidth:
                    var totalWidth = TotalWidth;
                    if (totalWidth != 0xffff)
                    {
                        value = (int?)totalWidth;
                    }

                    break;
                #endregion

                #region [0x0a] - [v2.1] - [Data Width] - [Int32?]
                case SmbiosType017Property.DataWidth:
                    var dataWidth = DataWidth;
                    if (dataWidth != 0xffff)
                    {
                        value = (int?)dataWidth;
                    }
                    break;

                #endregion

                #region [0x0c] - [v2.1] - [Size] - [Int32?]
                case SmbiosType017Property.Size:
                    var size = Size;
                    if (size != 0xffff)
                    {
                        if (size != 0x7fff)
                        {
                            var sizeIsMeasuredInKb = IsMeasuredInKb(size);
                            if (!sizeIsMeasuredInKb)
                            {
                                size = size << 0x0a;
                            }

                            value = (int?)size;
                        }
                        else
                        {
                            if (HeaderInfo.Length >= 0x1d)
                            {
                                var extendedSize = ExtendedSize << 0x0a;
                                value = (int?)extendedSize;
                            }
                        }
                    }
                    break;
                #endregion

                #region [0x0e] - [v2.1] - [Form Factor] - [String]
                case SmbiosType017Property.FormFactor:
                    value = GetFormFactor(FormFactor);
                    break;
                #endregion

                #region [0x0f] - [v2.1] - [Device Set]

                #region [0x0f] - [v2.1] - [Device Set -> Device Set] - [Byte?]
                case SmbiosType017Property.DeviceSet:
                    var belongsToSetDevice = BelongsToSet;
                    if (belongsToSetDevice == MemoryDeviceBelongsToSet.Yes)
                    {
                        value = (byte?)DeviceSet;
                    }
                    break;
                #endregion

                #endregion

                #region [0x10] - [v2.1] - [Device Locator] - [String]
                case SmbiosType017Property.DeviceLocator:
                    value = DeviceLocator;
                    break;
                #endregion

                #region [0x11] - [v2.1] - [Bank Locator] - [String]
                case SmbiosType017Property.BankLocator:
                    value = BankLocator;
                    break;
                #endregion

                #region [0x12] - [v2.1] - [Memory Type] - [String]
                case SmbiosType017Property.MemoryType:
                    value = GetDeviceType(MemoryType);
                    break;
                #endregion

                #region [0x13] - [v2.1] - [Memory Type Detail] - [ReadOnlyCollection<String>]
                case SmbiosType017Property.TypeDetail:
                    value = GetDeviceTypeDetail(TypeDetail);
                    break;
                #endregion

                #region [0x15] - [v2.3] - [Maximun Speed] - [Int32?]
                case SmbiosType017Property.MaximunSpeed:
                    if (HeaderInfo.Length >= 0x16)
                    {
                        var maximunSpeed = MaximunSpeed;
                        if (maximunSpeed != 0)
                        {
                            value = (int?)maximunSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x17] - [v2.3] - [Manufacturer] - [String]
                case SmbiosType017Property.Manufacturer:
                    if (HeaderInfo.Length >= 0x18)
                    {
                        value = Manufacturer;
                    }
                    break;
                #endregion

                #region [0x18] - [v2.3] - [Serial Number] - [String]
                case SmbiosType017Property.SerialNumber:
                    if (HeaderInfo.Length >= 0x19)
                    {
                        value = SerialNumber;
                    }
                    break;
                #endregion

                #region [0x19] - [v2.3] - [Asset Tag] - [String]
                case SmbiosType017Property.AssetTag:
                    if (HeaderInfo.Length >= 0x1a)
                    {
                        value = AssetTag;
                    }
                    break;
                #endregion

                #region [0x1a] - [v2.3] - [Part Number] - [String]
                case SmbiosType017Property.PartNumber:
                    if (HeaderInfo.Length >= 0x1b)
                    {
                        value = PartNumber;
                    }
                    break;
                #endregion

                #region [0x1b] - [v2.6] - [Attributes]

                #region [0x1b] - [v2.6] - [Attributes -> Rank] - [Byte?]
                case SmbiosType017Property.Rank:
                    if (HeaderInfo.Length >= 0x1c)
                    {
                        if (Rank != 0)
                        {
                            value = (byte?)Rank;
                        }
                    }
                    break;
                #endregion

                #endregion

                #region [0x20] - [v2.7] - [Configured Memory Clock Speed] - [Int32?]
                case SmbiosType017Property.ConfiguredMemoryClockSpeed:
                    if (HeaderInfo.Length >= 0x21)
                    {
                        if (CurrentSpeed != 0)
                        {
                            value = (int?)CurrentSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x22] - [v2.8] - [Minimum Voltage] - [Int32?]
                case SmbiosType017Property.MinimunVoltage:
                    if (HeaderInfo.Length >= 0x23)
                    {
                        if (CurrentSpeed != 0)
                        {
                            value = (int?)CurrentSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x24] - [v2.8] - [Maximum Voltage] - [Int32?]
                case SmbiosType017Property.MaximumVoltage:
                    if (HeaderInfo.Length >= 0x25)
                    {
                        if (CurrentSpeed != 0)
                        {
                            value = (int?)CurrentSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x26] - [v2.8] - [Configured Voltage] - [Int32?]
                case SmbiosType017Property.ConfiguredVoltage:
                    if (HeaderInfo.Length >= 0x27)
                    {
                        if (CurrentSpeed != 0)
                        {
                            value = (int?)CurrentSpeed;
                        }
                    }
                    break;
                #endregion

                #region [0x28] - [v3.2] - [Memory Technologies] - [String]
                case SmbiosType017Property.MemoryTechnology:
                    if (HeaderInfo.Length >= 0x29)
                    {
                        value = GetMemoryTechnology(MemoryTechnology);
                    }
                    break;
                #endregion

                #region [0x29] - [v3.2] - [Memory Operating Mode Capability] - [ReadOnlyCollection<String>]
                case SmbiosType017Property.MemoryOperatingModeCapability:
                    if (HeaderInfo.Length >= 0x2A)
                    {
                        value = GetMemoryOperatingModeCapability(MemoryOperatingModeCapability);
                    }
                    break;
                #endregion

                #region [0x2B] - [v3.2] - [Firmware Version] - [String]
                case SmbiosType017Property.FirmwareVersion:
                    if (HeaderInfo.Length >= 0x2C)
                    {
                        value = FirmwareVersion;
                    }
                    break;
                #endregion

                #region [0x2C] - [v3.2] - [Module Manufacturer ID] - [Int32?]
                case SmbiosType017Property.ModuleManufacturerId:
                    if (HeaderInfo.Length >= 0x2D)
                    {
                        value = ModuleManufacturerId;
                    }
                    break;
                #endregion

                #region [0x2E] - [v3.2] - [Module Product ID] - [Int32?]
                case SmbiosType017Property.ModuleProductId:
                    if (HeaderInfo.Length >= 0x2F)
                    {
                        value = ModuleProductId;
                    }
                    break;
                #endregion

                #region [0x30] - [v3.2] - [Memory Subsystem Controller Manufacturer Id] - [Int32?]
                case SmbiosType017Property.MemorySubsystemControllerManufacturerId:
                    if (HeaderInfo.Length >= 0x31)
                    {
                        value = MemorySubsystemControllerManufacturerId;
                    }
                    break;
                #endregion

                #region [0x32] - [v3.2] - [Memory Subsystem Controller Product Id] - [Int32?]
                case SmbiosType017Property.MemorySubsystemControllerProductId:
                    if (HeaderInfo.Length >= 0x33)
                    {
                        value = MemorySubsystemControllerProductId;
                    }
                    break;
                #endregion

                #region [0x34] - [v3.2] - [Non Volatile Size] - [ulong?]
                case SmbiosType017Property.NonVolatileSize:
                    if (HeaderInfo.Length >= 0x35)
                    {
                        value = NonVolatileSize;
                    }
                    break;
                #endregion

                #region [0x3C] - [v3.2] - [Volatile Size] - [ulong?]
                case SmbiosType017Property.VolatileSize:
                    if (HeaderInfo.Length >= 0x3d)
                    {
                        value = VolatileSize;
                    }
                    break;
                #endregion

                #region [0x44] - [v3.2] - [Cache Size] - [ulong?]
                case SmbiosType017Property.CacheSize:
                    if (HeaderInfo.Length >= 0x45)
                    {
                        value = CacheSize;
                    }
                    break;
                #endregion

                #region [0x4C] - [v3.2] - [Logical Size] - [ulong?]
                case SmbiosType017Property.LogicalSize:
                    if (HeaderInfo.Length >= 0x4d)
                    {
                        value = LogicalSize;
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

            #region versions

            #region 2.1+
            properties.Add(KnownDmiProperty.MemoryDevice.PhysicalMemoryArrayHandle, PhysicalArrayMemoryHandle);

            var memoryErrorInformationHandle = MemoryErrorInformationHandle;
            switch (memoryErrorInformationHandle)
            {
                case 0xffff:
                    properties.Add(KnownDmiProperty.MemoryDevice.MemoryErrorInformationHandle, -1);
                    break;

                case 0xfffe:
                    properties.Add(KnownDmiProperty.MemoryDevice.MemoryErrorInformationHandle, -2);
                    break;

                default:
                    properties.Add(KnownDmiProperty.MemoryDevice.MemoryErrorInformationHandle, memoryErrorInformationHandle);
                    break;
            }

            var totalWidth = TotalWidth;
            if (totalWidth != 0xffff)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.TotalWidth, totalWidth);
            }

            var dataWidth = DataWidth;
            if (dataWidth != 0xffff)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.DataWidth, dataWidth);
            }

            var size = Size;
            if (size != 0xffff)
            {
                if (size != 0x7fff)
                {
                    var sizeIsMeasuredInKb = IsMeasuredInKb(size);
                    if (!sizeIsMeasuredInKb)
                    {
                        size = size << 0x0a;
                    }

                    properties.Add(KnownDmiProperty.MemoryDevice.Size, size);
                }
                else
                {
                    if (HeaderInfo.Length >= 0x1d)
                    {
                        var extendedSize = ExtendedSize << 0x0a;
                        properties.Add(KnownDmiProperty.MemoryDevice.Size, extendedSize);
                    }
                }
            }

            properties.Add(KnownDmiProperty.MemoryDevice.FormFactor, GetFormFactor(FormFactor));

            var belongsToSet = BelongsToSet;
            if (belongsToSet.Equals(MemoryDeviceBelongsToSet.Yes))
            {
                properties.Add(KnownDmiProperty.MemoryDevice.DeviceSet, DeviceSet);
            }

            properties.Add(KnownDmiProperty.MemoryDevice.DeviceLocator, DeviceLocator);
            properties.Add(KnownDmiProperty.MemoryDevice.BankLabel, BankLocator);
            properties.Add(KnownDmiProperty.MemoryDevice.MemoryType, GetDeviceType(MemoryType));
            properties.Add(KnownDmiProperty.MemoryDevice.TypeDetail, GetDeviceTypeDetail(TypeDetail));
            #endregion

            #region 2.3+
            if (HeaderInfo.Length >= 0x16)
            {
                var maximunSpeed = MaximunSpeed;
                if (maximunSpeed != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.MaximunSpeed, maximunSpeed);
                }
            }

            if (HeaderInfo.Length >= 0x18)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.Manufacturer, Manufacturer);
            }

            if (HeaderInfo.Length >= 0x19)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.SerialNumber, SerialNumber);
            }

            if (HeaderInfo.Length >= 0x1a)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.AssetTag, AssetTag);
            }

            if (HeaderInfo.Length >= 0x1b)
            {
                properties.Add(KnownDmiProperty.MemoryDevice.PartNumber, PartNumber);
            }
            #endregion

            #region 2.6+
            if (HeaderInfo.Length >= 0x1c)
            {
                var rank = Rank;
                if (rank != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.Rank, rank);
                }
            }
            #endregion

            #region 2.7+
            if (HeaderInfo.Length >= 0x21)
            {
                var currentSpeed = CurrentSpeed;
                if (currentSpeed != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.ConfiguredMemoryClockSpeed, currentSpeed);
                }
            }
            #endregion

            #region 2.8+
            if (HeaderInfo.Length >= 0x23)
            {
                var minimunVoltage = MinimunVoltage;
                if (minimunVoltage != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.MinimunVoltage, minimunVoltage);
                }

                var maximumVoltage = MaximumVoltage;
                if (maximumVoltage != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.MaximumVoltage, maximumVoltage);
                }

                var configuredVoltage = ConfiguredVoltage;
                if (configuredVoltage != 0)
                {
                    properties.Add(KnownDmiProperty.MemoryDevice.ConfiguredVoltage, configuredVoltage);
                }
            }
            #endregion

            #region 3.2+
            if (HeaderInfo.Length >= 0x29)
            {
                var memoryTechnology = GetMemoryTechnology(MemoryTechnology);
                properties.Add(KnownDmiProperty.MemoryDevice.MemoryTechnology, memoryTechnology);

                var memoryOperatingModeCapability = GetMemoryOperatingModeCapability(MemoryOperatingModeCapability);
                properties.Add(KnownDmiProperty.MemoryDevice.MemoryOperatingModeCapability, memoryOperatingModeCapability);

                properties.Add(KnownDmiProperty.MemoryDevice.FirmwareVersion, FirmwareVersion);
                properties.Add(KnownDmiProperty.MemoryDevice.ModuleManufacturerId, ModuleManufacturerId);
                properties.Add(KnownDmiProperty.MemoryDevice.ModuleProductId, ModuleProductId);
                properties.Add(KnownDmiProperty.MemoryDevice.MemorySubsystemControllerManufacturerId, MemorySubsystemControllerManufacturerId);
                properties.Add(KnownDmiProperty.MemoryDevice.MemorySubsystemControllerProductId, MemorySubsystemControllerProductId);
                properties.Add(KnownDmiProperty.MemoryDevice.NonVolatileSize, NonVolatileSize);
                properties.Add(KnownDmiProperty.MemoryDevice.VolatileSize, VolatileSize);
                properties.Add(KnownDmiProperty.MemoryDevice.CacheSize, CacheSize);
                properties.Add(KnownDmiProperty.MemoryDevice.LogicalSize, LogicalSize);

            }
            #endregion

            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 3.2.0 (26/04/2018)

        #region [private] {static} (string) GetDeviceType(byte): Gets a string representing the device type
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
                "Other",                      // 0x01
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
                "DDR2 FB-DIMM"                // 0x14
            };

            string[] deviceProperty2 =
            {
                "DDR3",                       // 0x18
                "FBD2",
                "DDR4",
                "LPDDR",
                "LPDDR2",
                "LPDDR3",
                "LPDDR4",
                "Logical non-volatile device" // 0x1F
            };

            if (code >= 0x01 && code <= 0x14)
            {
                return deviceProperty[code - 0x01];
            }

            if (code >= 0x18 && code <= 0x1F)
            {
                return deviceProperty2[code - 0x18];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) GetDeviceTypeDetail(int): Gets a collection of additional features from a memory device detail
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
        #endregion

        #region [private] {static} (string) GetFormFactor(byte): Gets a string that represents the shape of the device
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
                "FB-DIMM"              // 0x0F                                         
            };

            if (code >= 0x01 && code <= 0x0F)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetMemoryTechnology(byte): Gets a string that represents the memory type technology
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
                "Other",                  // 0x01
                "Unknown",
                "DRAM",
                "NVDIMM-N",
                "NVDIMM-F",
                "NVDIMM-P",
                "Intel persistent memory" // 0x07
            };

            if (code >= 0x01 && code <= 0x07)
            {
                return deviceProperty[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (bool) IsMeasuredInKb(int): Gets a value that indicates whether the memory is measured in KB
        /// <summary>
        /// Gets a value that indicates whether the memory is measured in KB.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// <b>true</b> if memory is measured in KB;<b>false</b> otherwise.
        /// </returns>
        private static bool IsMeasuredInKb(int code) => code.CheckBit(Bits.Bit15);
        #endregion

        #region [private] {static} (ReadOnlyCollection<String>) GetMemoryOperatingModeCapability(int): Gets a memory operating mode capability
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

        #endregion
    }
}
