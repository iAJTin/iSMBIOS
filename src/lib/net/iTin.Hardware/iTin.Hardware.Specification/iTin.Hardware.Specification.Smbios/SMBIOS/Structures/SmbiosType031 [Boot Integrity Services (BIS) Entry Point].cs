
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 031: Boot Integrity Services (BIS) Entry Point.
    //
    // Structure type 31 (decimal) is reserved for use by the Boot Integrity Services (BIS). Refer to the Boot
    // Integrity Services API Specification for details.
    // NOTE: This structure type was added in version 2.3 of this specification.

    // •——————————————————————————————————————————————————————————————————————————————————————•
    // | Especificacion extraida de: Boot Integrity Services API Specifications - página 21   |
    // |                                                                                      |
    // | typedef struct _BIS_ENTRY_POINT                                                      |
    // | {                                                                                    |
    // |     UINT8 smBiosType;                                                                |
    // |     UINT8 length;                                                                    |
    // |     UINT16 structHandle;                                                             |
    // |     UINT8 structChecksum;                                                            |
    // |     UINT8 reserved1;                                                                 |
    // |     UINT16 reserved2;                                                                |
    // |     pBisEntry16 bisEntry16; /* pBisEntry16 definido como: typedef UINT32 pBisEntry16 |
    // |     pBisEntry32 bisEntry32; /* pBisEntry16 definido como: typedef UINT32 pBisEntry16 |
    // |     UINT64 reserved3;                                                                |
    // |     UINT32 reserved4;                                                                |
    // |     UINT16 doubleNull;                                                               |
    // | }                                                                                    |
    // |                                                                                      |
    // | Quedaria:                                                                            |
    // |                      C/C++       C#          Tamaño      Posicion                    |
    // |  ------------------------------------------------------------------------            |
    // |      smBiosType      UINT8       byte        1               00h                     |
    // |      length          UINT8       byte        1               01h                     |
    // |      structHandle    UINT16      ushort      2               02h                     |
    // |      structChecksum  UINT8       byte        1               04h                     |
    // |      reserved1       UINT8       byte        1               05h                     |
    // |      reserved2       UINT16      ushort      2               06h                     |
    // |      bisEntry16      UINT32      uint        4               08h                     |
    // |      bisEntry32      UINT32      uint        4               0Ch                     |
    // |      reserved3       UINT64      ulong       8               14h                     |
    // |      reserved4       UINT32      uint        4               1Ch                     |
    // |      doubleNull      UINT16      ushort      2               20h                     |
    // •——————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Boot Integrity Services (BIS) Entry Point (Type 31) structure.
    /// </summary>
    internal sealed class SmbiosType031 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType031(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType031"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType031(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Checksum: Gets a value representing the 'Checksum' field
        /// <summary>
        /// Gets a value representing the <b>Checksum</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Checksum => Reader.GetByte(0x04);
        #endregion

        #region [private] (string) BisEntryPointAddress16: Gets a value representing the 'Bis Entry Point Address 16' field
        /// <summary>
        /// Gets a value representing the <b>Bis Entry Point Address 16</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BisEntryPointAddress16 => $"{Reader.GetWord(0x08)}:{Reader.GetWord(0x0a)}";
        #endregion

        #region [private] (string) BisEntryPointAddress32: Gets a value representing the 'Bis Entry Point Address 32' field
        /// <summary>
        /// Gets a value representing the <b>Bis Entry Point Address 32</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string BisEntryPointAddress32 => $"{Reader.GetQuadrupleWord(0x0c)}";
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
            if (StructureInfo.StructureVersion < SmbiosStructureVersion.Latest)
            {
                return;
            }

            properties.Add(SmbiosProperty.BootIntegrityServicesEntryPoint.Checksum, Checksum);
            properties.Add(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress16, BisEntryPointAddress16);
            properties.Add(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress32, BisEntryPointAddress32);
        }
        #endregion

        #endregion
    }
}
