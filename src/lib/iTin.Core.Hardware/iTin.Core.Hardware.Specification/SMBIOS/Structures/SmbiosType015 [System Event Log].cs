
using iTin.Core.Hardware.Specification.Dmi.Property;

namespace iTin.Core.Hardware.Specification.Smbios
{
    using Helpers;

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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Event Log (Type 15) structure.
    /// </summary>
    sealed class SmbiosType015 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType015(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType015" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType015(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods.

        #region [protected] {override} (void) Parse(SmbiosPropertiesTable): Gets the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Gets the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void Parse(SmbiosPropertiesTable properties)
        {
            #region validate parameter/s
            SentinelHelper.ArgumentNull(properties);
            #endregion

            #region values
            properties.Add(DmiProperty.SystemEventLog.SystemEventLogs, string.Empty);
            #endregion
        }
        #endregion

        #endregion
    }
}
