
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 020: Memory Device Mapped Address.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        20          Memory Device Mapped Address indicator    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        13h         Length of the structure.                  |
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
    // | 0Ch      2.1+        Memory Device       WORD        Varies      The handle, or instance number, associated|
    // |                      Handle                                      with the Memory device structure to which |
    // |                                                                  this address range is mapped.             |
    // |                                                                  Multiple address ranges can be mapped to  |
    // |                                                                  a single Memory Device.                   |
    // |                                                                  Note: See DeviceHandle                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Eh      2.1+        Memory Array        WORD        Varies      The handle, or instance number, associated|
    // |                      Mapped                                      with the Memory Array Mapped Address      |
    // |                      Address Handle                              structure to which this device address    |
    // |                                                                  range is mapped.                          |
    // |                                                                  Multiple address ranges can be mapped to a|
    // |                                                                  single Memory Array Mapped Address.       |
    // |                                                                  Note: See MappedAddressHandle             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h      2.1+        Partition Row       BYTE        Varies      Identifies the position of the referenced |
    // |                      Position                                    Memory Device in a row of the address.    |
    // |                                                                  partition.                                |
    // |                                                                  For example, if two 8-bit devices form a  |
    // |                                                                  16-bit row, this field’s value is either  |
    // |                                                                  1 or 2.                                   |
    // |                                                                  The value 0 is reserved. If the position  |
    // |                                                                  is unknown, the field contains FFh.       |
    // |                                                                  Note: See PartitionRowPosition            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h      2.1+        Interleave          BYTE        Varies      The position of the referenced Memory     |
    // |                      Position                                    Device in an interleave.                  |
    // |                                                                  The value 0 indicates noninterleaved, 1   |
    // |                                                                  indicates first interleave position, 2    |
    // |                                                                  the second interleave position, and so on.|
    // |                                                                  If the position is unknown, the field     |
    // |                                                                  contains FFh.                             |
    // |                                                                  EXAMPLES: In a 2:1 interleave, the value 1|
    // |                                                                            indicates the device in the     |
    // |                                                                            ”even” position. In a 4:1       |
    // |                                                                            interleave, the value 1         |
    // |                                                                            indicates the first of four     |
    // |                                                                            possible positions.             |
    // |                                                                  Note: See InterleavePosition              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h      2.1+        Interleave          BYTE        Varies      The maximum number of consecutive rows    |
    // |                      Data Depth                                  from the referenced Memory Device that are|
    // |                                                                  accessed in a single interleaved transfer.|
    // |                                                                  If the device is not part of an           |
    // |                                                                  interleave, the field contains 0; if the  |
    // |                                                                  interleave configuration is unknown, the  |
    // |                                                                  value is FFh.                             |
    // |                                                                  EXAMPLES: If a device transfers two rows  |
    // |                                                                            each time it is read, its       |
    // |                                                                            Interleaved Data Depth is set to|
    // |                                                                            2. If that device is 2:1        |
    // |                                                                            interleaved and in Interleave   |
    // |                                                                            Position 1, the rows mapped to  |
    // |                                                                            that device are 1, 2, 5, 6, 9,  |
    // |                                                                            10, etc.                        |
    // |                                                                  Note: See InterleaveDataDepth             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      2.7+        Extended            QWORD       Varies      The physical address, in bytes, of a range|
    // |                      Starting                                    of memory mapped to the referenced Memory |
    // |                      Address                                     Device.                                   |
    // |                                                                  This field is valid when Starting Address |
    // |                                                                  contains the value FFFF FFFFh.            |
    // |                                                                  If Starting Address contains a value other|
    // |                                                                  than FFFF FFFFh, this field contains zeros|
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Extended Ending Address must also contain |
    // |                                                                  a valid address.                          |
    // |                                                                  Note: See ExtendedStartingAddress         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Bh      2.7+        Extended            QWORD       Varies      The physical ending address, in bytes, of |
    // |                      Ending                                      the last of a range of addresses mapped to|
    // |                      Address                                     the referenced Memory Device.             |
    // |                                                                  This field is valid when both Starting    |
    // |                                                                  Address and Ending Address contain the    |
    // |                                                                  value FFFF FFFFh.                         |
    // |                                                                  If Ending Address contains a value other  |
    // |                                                                  than FFFF FFFFh, this field contains zeros|
    // |                                                                  When this field contains a valid address, |
    // |                                                                  Extended Starting Address must also       |
    // |                                                                  contain a valid address.                  |
    // |                                                                  Note: See ExtendedEndingAddress           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the Memory Device Mapped Address (Type 20) structure.
    /// </summary>
    internal sealed class SmbiosType020 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType020(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType020"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType020(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
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

        #region [private] (ushort) MemoryDeviceHandle: Gets a value representing the 'Memory Device Handle' field
        /// <summary>
        /// Gets a value representing the <b>Memory Device Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MemoryDeviceHandle => (ushort)Reader.GetWord(0x0C);
        #endregion

        #region [private] (ushort) MappedAddressHandle: Gets a value representing the 'Mapped Address Handle' field
        /// <summary>
        /// Gets a value representing the <b>Mapped Address Handle</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort MappedAddressHandle => (ushort)Reader.GetWord(0x0e);
        #endregion

        #region [private] (byte) PartitionRowPosition: Gets a value representing the 'Partition Row Position' field
        /// <summary>
        /// Gets a value representing the <b>Partition Row Position</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PartitionRowPosition => Reader.GetByte(0x10);
        #endregion

        #region [private] (MemoryDeviceMappedAddressInterleavedPosition) InterleavePosition: Gets a value representing the 'Interleave Position' field
        /// <summary>
        /// Gets a value representing the <b>Interleave Position</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MemoryDeviceMappedAddressInterleavedPosition InterleavePosition => (MemoryDeviceMappedAddressInterleavedPosition)Reader.GetByte(0x11);
        #endregion

        #region [private] (byte) InterleavedDataDepth: Gets a value representing the 'Interleaved Data Depth' field
        /// <summary>
        /// Gets a value representing the <b>Interleaved Data Depth</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte InterleavedDataDepth => Reader.GetByte(0x12);
        #endregion

        #endregion

        #region Version 2.7+ fields

        #region [private] (ulong) ExtendedStartingAddress: Gets a value representing the 'Extended Starting Address' field
        /// <summary>
        /// Gets a value representing the <b>Extended Starting Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong ExtendedStartingAddress => (ulong)Reader.GetQuadrupleWord(0x13);
        #endregion

        #region [private] (ulong) ExtendedEndingAddress: Gets a value representing the 'Extended Ending Address' field
        /// <summary>
        /// Gets a value representing the <b>Extended Ending Address</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong ExtendedEndingAddress => (ulong)Reader.GetQuadrupleWord(0x1b);
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
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.StartingAddress, StartingAddress);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.EndingAddress, EndingAddress);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.MemoryDeviceHandle, MemoryDeviceHandle);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.MemoryArrayMappedAddressHandle, MappedAddressHandle);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.PartitionRowPosition, PartitionRowPosition);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.InterleavePosition, InterleavePosition);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.InterleavedDataDepth, InterleavedDataDepth);
            }
            #endregion

            #region 2.7+
            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v27)
            {
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedStartingAddress, ExtendedStartingAddress);
                properties.Add(SmbiosProperty.MemoryDeviceMappedAddress.ExtendedEndingAddress, ExtendedEndingAddress);
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
