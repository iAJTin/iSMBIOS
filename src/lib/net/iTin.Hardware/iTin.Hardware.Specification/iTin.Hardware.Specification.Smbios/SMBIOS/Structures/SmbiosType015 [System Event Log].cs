
namespace iTin.Hardware.Specification.Smbios
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using Property;

    // Type 015: System Event Log.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.0+        Type                BYTE        15          Event Log Type Indicator                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.0+        Length              BYTE        Varies      14h for version 2.0                       |
    // |                                                                  17h + (x * y) for version 2.1 and later   |
    // |                                                                  Where:                                    |
    // |                                                                         x = offset 15h                     |
    // |                                                                         y = offset 16h                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.0+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.0+        Log Area            WORD        Varies      The length, in bytes, of the overall event|
    // |                      Length                                      log area, from the first byte of header   |
    // |                                                                  to the last byte of data.                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.0+        Log Header          WORD        Varies      Defines the starting offset (or index)    |
    // |                                                                  within the nonvolatile storage of the     |
    // |                                                                  event-log’s header, from the Access Method|
    // |                                                                  Address.                                  |
    // |                                                                  For singlebyte indexed I/O  accesses, the |
    // |                                                                  mostsignificant byte of the start offset  |
    // |                                                                  is set to 00h.                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.0+        Log Data Start       WORD        Varies     Defines the starting offset (or index)    |
    // |                                                                  within the nonvolatile storage of the     |
    // |                                                                  event-log’s first data byte, from the     |
    // |                                                                  Access Method Address.                    |
    // |                                                                  For single-byte indexed I/O accesses, the |
    // |                                                                  most-significant byte of the start offset |
    // |                                                                  is set to 00h.                            |
    // |                                                                  NOTE: The data directly follows any header|
    // |                                                                        information. Therefore, the header  |
    // |                                                                        length can be determined by         |
    // |                                                                        subtracting the Header Start Offset |
    // |                                                                        from the Data Start Offset.         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah      2.0+        Access               BYTE        Varies     Defines the Location and Method used by   |
    // |                      Method                                      higher-level software to access the log   |
    // |                                                                  area, one of:                             |
    // |                                                                  00h Indexed I/O: 1 8-bit index port,      |
    // |                                                                      1 8-bit data port.                    |
    // |                                                                      The Access Method Address field       |
    // |                                                                      contains the 16-bit I/O addresses for |
    // |                                                                      the index and data ports.             |
    // |                                                                                                            |
    // |                                                                  01h Indexed I/O: 2 8-bit index ports,     |
    // |                                                                      1 8-bit data port.                    |
    // |                                                                      The Access Method Address field       |
    // |                                                                      contains the 16-bit I/O address for   |
    // |                                                                      the index and data ports.             |
    // |                                                                                                            |
    // |                                                                  02h Indexed I/O: 1 16-bit index ports,    |
    // |                                                                      1 8-bit data port.                    |
    // |                                                                      The Access Method Address field       |
    // |                                                                      contains the 16-bit I/O address for   |
    // |                                                                      the index and data ports.             |
    // |                                                                                                            |
    // |                                                                  03h Memory-mapped physical 32-bit         |
    // |                                                                      address. The Access Method Address    |
    // |                                                                      field contains the 4-byte (Intel DWORD|
    // |                                                                      format) starting physical address.    |
    // |                                                                                                            |
    // |                                                                  04h Available through General-Purpose     |
    // |                                                                      NonVolatile Data functions.           |
    // |                                                                      The Access Method Address field       |
    // |                                                                      contains the 2-byte (Intel WORD       |
    // |                                                                      format) GPNV handle.                  |
    // |                                                                                                            |
    // |                                                                  05h-7Fh Available for future assignment   |
    // |                                                                          by this specification             |
    // |                                                                                                            |
    // |                                                                  80h-FFh BIOS Vendor/OEM-specific          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.0+        Log Status          BYTE        Varies      This bit-field describes the current      |
    // |                                                                  status of the system event-log:           |
    // |                                                                  Bits 07:02 Reserved, set to 0s            |
    // |                                                                  Bit  01    Log area full, if 1            |
    // |                                                                  Bit  00    Log area valid, if 1           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.0+        Log Change          DWORD       Varies      Unique token that is reassigned every time|
    // |                      Token                                       the event log changes. Can be used to     |
    // |                                                                  determine if additional events have       |
    // |                                                                  occurred since the last time the log was  |
    // |                                                                  read.                                     | 
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.0+        Access              DWORD       Varies      The address associated with the access    |
    // |                      Method                                      method; the data present depends on the   |
    // |                      Address                                     Access Method field value.                |
    // |                                                                  The area’s format can be described by the |
    // |                                                                  following 1-bytepacked ‘C’ union:         |
    // |                                                                                                            |
    // |                                                                  union                                     |
    // |                                                                  {                                         |
    // |                                                                      struct                                |
    // |                                                                      {                                     |
    // |                                                                          short IndexAddr;                  |
    // |                                                                          short DataAddr;                   |
    // |                                                                      } IO;                                 |
    // |                                                                      long PhysicalAddr32;                  |
    // |                                                                      short GPNVHandle;                     |
    // |                                                                  }  AccessMethodAddress;                   |
    // |                                                                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 14h      2.1+        Log Header          BYTE        ENUM        Identifies the format of the log header   |
    // |                      Format                                      area.                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h      2.1+        Number of           BYTE        Varies      Number of supported event log type        |
    // |                      Supported                                   descriptors that follow. If the value     |
    // |                      Log Type                                    is 0, the list that starts at offset 17h  |
    // |                      Descriptors                                 is not present.                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 16h      2.1+        Length of           BYTE        2           Identifies the number of bytes associated |
    // |                      each Log                                    with each type entry in the list below.   |
    // |                      Type                                        The value is currently “hard-coded” as 2, |
    // |                      Descriptor (y)                              because each entry consists of two bytes. |
    // |                                                                  This field’s presence allows future       |
    // |                                                                  Software that interprets the following    |
    // |                                                                  list should not assume a list entry’s     |
    // |                                                                  length.                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h to   2.1+        List of             Varies      Varies      Contains a list of Event Log Type         |
    // | 17h +                Supported                                   Descriptors, as long as the value         |
    // | (x*y)-1              Event Log                                   specified in offset 15h is non-zero.      |
    // |                      Type                                                                                  |
    // |                      Descriptors                                                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the System Event Log (Type 15) structure.
    /// </summary>
    internal sealed class SmbiosType015 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType015(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType015"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType015(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (int) LogAreaLength: Gets a value representing the 'Log Area Length' field
        /// <summary>
        /// Gets a value representing the <b>Log Area Length</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LogAreaLength => Reader.GetWord(0x04);
        #endregion

        #region [private] (int) LogHeaderStartOffset: Gets a value representing the 'Log Header Start Offset' field
        /// <summary>
        /// Gets a value representing the <b>Log Header Start Offset</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LogHeaderStartOffset => Reader.GetWord(0x06);
        #endregion

        #region [private] (int) DataStartOffset: Gets a value representing the 'Data Start Offset' field
        /// <summary>
        /// Gets a value representing the <b>Data Start Offset</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int DataStartOffset => Reader.GetWord(0x08);
        #endregion

        #region [private] (byte) AccessMethod: Gets a value representing the 'Access Method' field
        /// <summary>
        /// Gets a value representing the <b>Access Method</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AccessMethod => Reader.GetByte(0x10);
        #endregion

        #region [private] (byte) LogStatus: Gets a value representing the 'Log Status' field
        /// <summary>
        /// Gets a value representing the <b>Log Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LogStatus => Reader.GetByte(0x0b);
        #endregion

        #region [private] (int) AccessMethodAddress: Gets a value representing the 'Access Method Address' field
        /// <summary>
        /// Gets a value representing the <b>Access Method Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int AccessMethodAddress => Reader.GetDoubleWord(0x10);
        #endregion

        #region [private] (int) LogChangeToken: Gets a value representing the 'Log Change Token' field
        /// <summary>
        /// Gets a value representing the <b>Log Change Token</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int LogChangeToken => Reader.GetDoubleWord(0x0c);
        #endregion

        #region [private] (byte) LogHeaderFormat: Gets a value representing the 'Log Header Format' field
        /// <summary>
        /// Gets a value representing the <b>Log Header Format</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LogHeaderFormat => Reader.GetByte(0x14);
        #endregion

        #region [private] (byte) SupportedLogTypeDescriptors: Gets a value representing the 'Supported Log Type Descriptors' field
        /// <summary>
        /// Gets a value representing the <b>Supported Log Type Descriptors</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedLogTypeDescriptors => Reader.GetByte(0x15);
        #endregion

        #region [private] (byte) LengthTypeDescriptor: Gets a value representing the 'Length Type Descriptor' field
        /// <summary>
        /// Gets a value representing the <b>Length Type Descriptor</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LengthTypeDescriptor => Reader.GetByte(0x16);
        #endregion

        #region [private] (byte) ListSupportedEventLogTypeDescriptors: Gets a value representing the 'List Supported Event Log Type Descriptors' field
        /// <summary>
        /// Gets a value representing the <b>List Supported Event Log Type Descriptors</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ListSupportedEventLogTypeDescriptors => Reader.GetByte(0x17);
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
                properties.Add(SmbiosProperty.SystemEventLog.LogAreaLength, LogAreaLength);
                properties.Add(SmbiosProperty.SystemEventLog.LogHeaderStartOffset, LogHeaderStartOffset);
                properties.Add(SmbiosProperty.SystemEventLog.DataStartOffset, DataStartOffset);
                properties.Add(SmbiosProperty.SystemEventLog.AccessMethod, GetAccessMethod(AccessMethod));
                properties.Add(SmbiosProperty.SystemEventLog.LogStatus, GetLogStatus(LogStatus));
                
                if (AccessMethod <= 0x04)
                {
                    properties.Add(SmbiosProperty.SystemEventLog.AccessMethodAddress, GetAccessMethodAddress(AccessMethod, AccessMethodAddress));
                }

                properties.Add(SmbiosProperty.SystemEventLog.LogChangeToken, $"{LogChangeToken:X}");
            }
            #endregion

            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.SystemEventLog.LogHeaderFormat, GetLogHeaderFormat(LogHeaderFormat));
                properties.Add(SmbiosProperty.SystemEventLog.SupportedLogTypeDescriptors, SupportedLogTypeDescriptors);

                var n = SupportedLogTypeDescriptors * LengthTypeDescriptor;
                if (StructureInfo.Length > 0x17 + n)
                {
                    properties.Add(SmbiosProperty.SystemEventLog.ListSupportedEventLogTypeDescriptors, GetListSupportedEventLogTypeDescriptors(Reader.Data.Extract(0x17, n - 1).ToArray()));
                }
            }
            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 2.7.1 (26/01/2011)

        private static string GetAccessMethod(byte code)
        {
            string[] methods =
            {
                "Indexed I/O, one 8-bit index port, one 8-bit data port",  // 0x00
                "Indexed I/O, two 8-bit index ports, one 8-bit data port",
                "Indexed I/O, one 16-bit index port, one 8-bit data port",
                "Memory-mapped physical 32-bit address",
                "General-purpose non-volatile data functions"              // 0x04
            };

            if (code <= 0x04)
            {
                return methods[code];
            }

            if (code >= 0x08)
            {
                return "OEM-specific";
            }

            return SmbiosHelper.OutOfSpec;
        }

        private static string GetLogStatus(byte code)
        {
            var valid = code.CheckBit(Bits.Bit00) ? "Valid" : "Invalid";
            var area = code.CheckBit(Bits.Bit01) ? "Full" : "Not Full";

            return $"{valid} {area}";
        }

        private static string GetAccessMethodAddress(byte method, int value)
        {
            switch (method)
            {
                case 0x00:
                case 0x01:
                case 0x02:
                {
                    var valueArray = value.ToArray();
                    var data = valueArray[0];
                    var index = valueArray[1];

                    return $"Index {index:X}, Data {data:X}";
                }

                case 0x03:
                    return $"{value:X}";

                case 0x04:
                {
                    var valueArray = value.ToArray();
                    var handle = valueArray[0];
                    return $"{handle:X}";
                }

                default:
                    return SmbiosHelper.Unknown;
            }
        }

        private static string GetLogHeaderFormat(byte code)
        {
            string[] types =
            {
                "No Header", // 0x00
                "Type 1" // 0x01
            };

            if (code <= 0x01)
            {
                return types[code];
            }

            if (code >= 0x80)
            {
                return "OEM-specific";
            }

            return SmbiosHelper.OutOfSpec;
        }

        private static SupportedEventLogTypeDescriptorsCollection GetListSupportedEventLogTypeDescriptors(byte[] data)
        {
            var items = new Collection<SupportedEventLogTypeDescriptorElement>();

            for (var i = 0; i < data.Length; i += 2)
            {
                items.Add(new SupportedEventLogTypeDescriptorElement(data.Extract(i, 2).ToArray()));
            }

            return new SupportedEventLogTypeDescriptorsCollection(items);
        }

        #endregion
    }
}
