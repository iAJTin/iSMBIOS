
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 018: 32-Bit Memory Error Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        18          32-bit Memory Error Information type      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        17h         Length of the structure.                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.1+        Error Type          BYTE        ENUM        The type of error that is associated with |
    // |                                                                  the current status reported for the memory|
    // |                                                                  array or device.                          |
    // |                                                                  Note: Ver GetErrorType(byte)              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.1+        Error               BYTE        ENUM        Identifies the granularity (for example,  |
    // |                      Granularity                                 device versus Partition) to which the     |
    // |                                                                  error can be resolved.                    |
    // |                                                                  Note: Ver GetErrorGranularity(byte)       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.1+        Error Operation     BYTE        ENUM        The memory access operation that caused   |
    // |                                                                  the error.                                |
    // |                                                                  Note: Ver GetErrorOperation(byte)         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.1+        Vendor              DWORD       Varies      The vendor-specific ECC syndrome or CRC   |
    // |                      Syndrome                                    data associated with the erroneous access.|
    // |                                                                  If the value is unknown, this field       |
    // |                                                                  contains 0000 0000h.                      |
    // |                                                                  Note: Ver CrcData                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.1+        Memory Array        DWORD       Varies      The 32-bit physical address of the error  |
    // |                      Error Address                               based on the addressing of the bus to     |
    // |                                                                  which the memory array is connected.      |
    // |                                                                  If the address is unknown, this field     |
    // |                                                                  contains 8000 0000h.                      |
    // |                                                                  Note: Ver BusErrorAddress                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.1+        Device Error        DWORD       Varies      The 32-bit physical address of the error  |
    // |                      Address                                     relative to the start of the failing      |
    // |                                                                  memory device, in bytes.                  |
    // |                                                                  If the address is unknown, this field     |
    // |                                                                  contains 8000 0000h.                      |
    // |                                                                  Note: Ver DeviceErrorAddress              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 13h      2.1+        Error               DWORD       Varies      The range, in bytes, within which the     |
    // |                      Resolution                                  error can be determined, when an error    |
    // |                                                                  address is given.                         |
    // |                                                                  If the range is unknown, this field       |
    // |                                                                  contains 8000 0000h.                      |
    // |                                                                  Note: Ver ErrorResolution                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the 32-Bit Memory Error Information (Type 18) structure.
    /// </summary>
    class SmbiosType018 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType018(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType018" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType018(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region internal properties

        #region [internal] (byte) ErrorType: Gets a value representing the 'Error Type' field
        /// <summary>
        /// Gets a value representing the <c>Error Type</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal byte ErrorType => GetByte(0x04);
        #endregion

        #region [internal] (byte) ErrorGranularity: Gets a value representing the 'Error Granularity' field
        /// <summary>
        /// Gets a value representing the <c>Error Granularity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal byte ErrorGranularity => GetByte(0x05);
        #endregion

        #region [internal] (byte) ErrorOperation: Gets a value representing the 'Error Operation' field
        /// <summary>
        /// Gets a value representing the <c>Error Operation</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal byte ErrorOperation => GetByte(0x06);
        #endregion

        #region [internal] (long) CrcData: Gets a value representing the 'Crc Data' field
        /// <summary>
        /// Gets a value representing the <c>Crc Data</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal long CrcData => GetDoubleWord(0x07);
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (long) BusErrorAddress: Gets a value representing the 'Bus Error Address' field
        /// <summary>
        /// Gets a value representing the <c>Bus Error Address</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long BusErrorAddress => GetDoubleWord(0x0b);
        #endregion

        #region [private] (long) DeviceErrorAddress: Gets a value representing the 'Device Error Address' field
        /// <summary>
        /// Gets a value representing the <c>Device Error Address</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long DeviceErrorAddress => GetDoubleWord(0x0f);
        #endregion

        #region [private] (long) ErrorResolution: Gets a value representing the 'Error Resolution' field
        /// <summary>
        /// Gets a value representing the <c>Error Resolution</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private long ErrorResolution => GetDoubleWord(0x13);
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
            SmbiosType018Property propertyId = (SmbiosType018Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.1] - [Error Type] - [string]
                case SmbiosType018Property.ErrorType:
                    value = GetErrorType(ErrorType);
                    break;
                #endregion

                #region [0x05] - [v2.1] - [Error Granularity] - [string]
                case SmbiosType018Property.ErrorGranularity:
                    value = GetErrorGranularity(ErrorGranularity);
                    break;
                #endregion

                #region [0x06] - [v2.1] - [Error Operation] - [string]
                case SmbiosType018Property.ErrorOperation:
                    value = GetErrorOperation(ErrorOperation);
                    break;
                #endregion

                #region [0x07] - [v2.1] - [Vendor Syndrome] - [long?]
                case SmbiosType018Property.VendorSyndrome:
                    if (CrcData != 0x00000000)
                    {
                        value = (long?)CrcData;
                    }
                    break;
                #endregion

                #region [0x0b] - [v2.1] - [Memory Array Error Address] - [long?]
                case SmbiosType018Property.MemoryArrayErrorAddress:
                    if (BusErrorAddress != 0x80000000)
                    {
                        value = (long?)BusErrorAddress;
                    }
                    break;
                #endregion

                #region [0x0f] - [v2.1] - [Device Error Address] - [long?]
                case SmbiosType018Property.DeviceErrorAddress:
                    if (DeviceErrorAddress != 0x80000000)
                    {
                        value = (long?)DeviceErrorAddress;
                    }
                    break;
                #endregion

                #region [0x13] - [v2.1] - [Error Resolution] - [long?]
                case SmbiosType018Property.ErrorResolution:
                    if (ErrorResolution != 0x80000000)
                        value = (long?)ErrorResolution;
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

            #region values
            properties.Add(KnownDmiProperty.BitMemoryError32.ErrorType, GetErrorType(ErrorType));
            properties.Add(KnownDmiProperty.BitMemoryError32.ErrorGranularity, GetErrorGranularity(ErrorGranularity));
            properties.Add(KnownDmiProperty.BitMemoryError32.ErrorOperation, GetErrorOperation(ErrorOperation));

            long crcData = CrcData;
            if (crcData != 0x00000000)
            {
                properties.Add(KnownDmiProperty.BitMemoryError32.VendorSyndrome, crcData);
            }

            long busErrorAddress = BusErrorAddress;
            if (busErrorAddress != 0x80000000)
            {
                properties.Add(KnownDmiProperty.BitMemoryError32.MemoryArrayErrorAddress, busErrorAddress);
            }

            long deviceErrorAddress = DeviceErrorAddress;
            if (deviceErrorAddress != 0x80000000)
            {
                properties.Add(KnownDmiProperty.BitMemoryError32.DeviceErrorAddress, deviceErrorAddress);
            }

            long errorResolution = ErrorResolution;
            if (errorResolution != 0x80000000)
            {
                properties.Add(KnownDmiProperty.BitMemoryError32.ErrorResolution, errorResolution);
            }
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [internal] {static} (string) GetErrorType(byte): Gets a string representing the type of error
        /// <summary>
        /// Gets a string representing the type of error.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Error type.
        /// </returns> 
        internal static string GetErrorType(byte code)
        {
            string[] value =
            {
                "Other",                         // 0x01
                "Unknown",
                "OK",
                "Bad Read",
                "Parity Error",
                "Single-bit Error",
                "Double-bit Error",
                "Multi-bit Error",
                "Nibble Error",
                "Checksum Error",
                "CRC Error",
                "Corrected Single-bit Error",
                "Corrected Error",
                "Uncorrectable Error"            // 0x0E
            };

            if (code >= 0x01 && code <= 0x0E)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [internal] {static} (string) GetErrorGranularity(byte): Gets a string indicating 'Granularity'
        /// <summary>
        /// Gets a string indicating 'Granularity'.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Indicates the 'Granularity'.
        /// </returns> 
        internal static string GetErrorGranularity(byte code)
        {
            string[] value =
            {
                "Other",                 // 0x01
                "Unknown",
                "Device level",
                "Memory partition level" // 0x04
            };

            if (code >= 0x01 && code <= 0x04)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [internal] {static} (string) GetErrorOperation(byte): Gets a string indicating which memory operation generated the error
        /// <summary>
        /// Gets a string indicating which memory operation generated the error.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The operation generated the error.
        /// </returns> 
        internal static string GetErrorOperation(byte code)
        {
            string[] value =
            {
                "Other",        // 0x01
                "Unknown",
                "Read",
                "Write",
                "Partial write" // 0x05
            };

            if (code >= 0x01 && code <= 0x05)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
