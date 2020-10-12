
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 019: Memory Array Mapped Address.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        19          Memory Array Mapped Address indicator     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        0Fh         Length of the structure.                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.1+        Starting            DWORD       Varies      The physical address, in kilobytes, of a  |
    // |                      Address                                     range of memory mapped to the specified   |
    // |                                                                  Physical Memory Array.                    |
    // |                                                                  When the field value is FFFF FFFFh, the   |
    // |                                                                  actual address is stored in the Extended  |
    // |                                                                  Starting Address field.                   |
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Ending Address must also contain a valid  |
    // |                                                                  address.                                  |
    // |                                                                  When this field contains FFFF FFFFh,      |
    // |                                                                  Ending Address must also contain          |
    // |                                                                  FFFF FFFFh.                               |
    // |                                                                  Note: See StartingAddress                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h      2.1+        Ending              DWORD       Varies      The physical ending address of the last   |
    // |                      Address                                     kilobyte of a range of addresses mapped   |
    // |                                                                  to the specified Physical Memory Array.   |
    // |                                                                  When the field value is FFFF FFFFh and    |
    // |                                                                  the Starting Address field also contains  |
    // |                                                                  FFFF FFFFh, the actual address is stored  |
    // |                                                                  in the Extended Ending Address field.     |
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Starting Address must also contain a      |
    // |                                                                  valid address.                            |
    // |                                                                  Note: See EndingAddress                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch      2.1+        Memory Array        WORD        Varies      The handle, or instance number, associated|
    // |                      Handle                                      with the Physical Memory Array to which   |
    // |                                                                  this address range is mapped.             |
    // |                                                                  Multiple address ranges can be mapped to  |
    // |                                                                  a single Physical Memory Array.           |
    // |                                                                  Note: See ArrayHandle                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh      2.1+        Partition           BYTE        Varies      Identifies the number of Memory Devices   |
    // |                      Width                                       that form a single row of memory for the  |
    // |                                                                  address partition defined by this         |
    // |                                                                  structure.                                |
    // |                                                                  Note: See DeviceNumber                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.7+        Extended            QWORD       Varies      The physical address, in bytes, of a range|
    // |                      Starting                                    of memory mapped to the specified Physical|
    // |                      Address                                     Memory Array.                             |
    // |                                                                  This field is valid when Starting Address |
    // |                                                                  contains the value FFFF FFFFh.            |
    // |                                                                  If Starting Address contains a value other| 
    // |                                                                  than FFFF FFFFh, this field contains      |
    // |                                                                  zeros.                                    |
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Extended Ending Address must also contain |
    // |                                                                  a valid address.                          |
    // |                                                                  Note: See ExtendedStartingAddress         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h      2.7+        Extended             QWORD      Varies      The physical address, in bytes, of a range|
    // |                      Ending                                      of addresses mapped to the specified      |
    // |                      Address                                     Physical Memory Array.                    |
    // |                                                                  This field is valid when Starting Address |
    // |                                                                  contains the value FFFF FFFFh.            |
    // |                                                                  If Starting Address contains a value other| 
    // |                                                                  than FFFF FFFFh, this field contains      |
    // |                                                                  zeros.                                    |
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Extended Ending Address must also contain |
    // |                                                                  a valid address.                          |
    // |                                                                  Note: See ExtendedEndingAddress           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Memory Array Mapped Address (Type 19) structure.
    /// </summary>
    internal sealed class SmbiosType019 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType019(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType019"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType019(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (uint) StartingAddress: Gets a value representing the 'Starting Address' field
        /// <summary>
        /// Gets a value representing the <b>Starting Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint StartingAddress => (uint)Reader.GetDoubleWord(0x04);
        #endregion

        #region [private] (uint) EndingAddress: Gets a value representing the 'Ending Address' field
        /// <summary>
        /// Gets a value representing the <b>Ending Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint EndingAddress => (uint)Reader.GetDoubleWord(0x08);
        #endregion

        #region [private] (ushort) MemoryArrayHandle: Gets a value representing the 'Memory Array Handle' field
        /// <summary>
        /// Gets a value representing the <b>Memory Array Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MemoryArrayHandle => (ushort)Reader.GetWord(0x0c);
        #endregion

        #region [private] (byte) PartitionWidth: Gets a value representing the 'Partition Width' field
        /// <summary>
        /// Gets a value representing the <b>Partition Width</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PartitionWidth => Reader.GetByte(0x0e);
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
            #region 2.1+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v21)
            {
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.StartingAddress, StartingAddress);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.EndingAddress, EndingAddress);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.MemoryArrayHandle, MemoryArrayHandle);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.PartitionWidth, PartitionWidth);
            }
            #endregion

            #region 2.7+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v27)
            {
                var extendedStartingAddress = Reader.GetQuadrupleWord(0x0f);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedStartingAddress, extendedStartingAddress);

                var extendedEndingAddress = Reader.GetQuadrupleWord(0x17);
                properties.Add(SmbiosProperty.MemoryArrayMappedAddress.ExtendedEndingAddress, extendedEndingAddress);
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
