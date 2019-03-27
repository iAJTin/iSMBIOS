
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;

    using Helpers;

    // Type 016: Physical Memory Array.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // |          Spec.                                                                                             |
    // | Offset   Version     Name                Length      Value       Description                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h      2.1+        Type                BYTE        16          Physical Memory Array type                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h      2.1+        Length              BYTE        0Fh         Length of the structure                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h      2.1+        Handle              WORD        Varies      The handle, or instance number, associated|
    // |                                                                  with the structure                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h      2.1+        Location            BYTE        ENUM        The physical location of the Memory Array,|
    // |                                                                  whether on the system board or an add-in  |
    // |                                                                  board.                                    |
    // |                                                                  Note: Ver GetLocation(byte)               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h      2.1+        Use                 BYTE        ENUM        The function for which the array is used. |
    // |                                                                  whether on the system board or an add-in  |
    // |                                                                  Note: Ver GetUse(byte)                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h      2.1+        Memory Error        BYTE        ENUM        The primary hardware error correction or  |
    // |                      Correction                                  detection method supported by this memory |
    // |                                                                  array.                                    |
    // |                                                                  Note: Ver GetErrorCorrectionTypes(byte)   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h      2.1+        Maximum             DWORD       Varies      The maximum memory capacity, in kilobytes,|
    // |                      Capacity                                    for this array.                           |
    // |                                                                  If the capacity is not represented in this|
    // |                                                                  field, then this field contains 8000 0000h|
    // |                                                                  and the Extended Maximum Capacity field   |
    // |                                                                  should be used. Values 2 TB (8000 0000h)  |
    // |                                                                  or greater must be represented in the     |
    // |                                                                  Extended Maximum Capacity field.          |
    // |                                                                  Note: Ver MaximumCapacity(uint)           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh      2.1+        Memory Error        WORD        Varies      The handle, or instance number, associated|
    // |                      Information                                 with any error that was previously        |
    // |                      Handle                                      detected for the array.                   |
    // |                                                                  If the system does not provide the error  |
    // |                                                                  information structure, the field contains |
    // |                                                                  FFFEh; otherwise, the field contains      |
    // |                                                                  either FFFFh (if no error was detected) or|
    // |                                                                  the handle of the errorinformation        |
    // |                                                                  structure                                 |
    // |                                                                  Note: Ver GetErrorHandle(int)             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh      2.1+        Number of           WORD        Varies      The number of slots or sockets available  |
    // |                      Memory                                      for Memory Devices in this array.         |
    // |                      Devices                                     This value represents the number of Memory|
    // |                                                                  Device structures that comprise this      |
    // |                                                                  Memory Array.                             |
    // |                                                                  Each Memory Device has a reference to the |
    // |                                                                  “owning” Memory Array.                    |
    // |                                                                  Note: Ver NumberOfMemoryDevices           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh      2.7+        Extended            QWORD       Varies      The maximum memory capacity, in bytes,    |
    // |                      Maximum                                     for this array.                           |
    // |                      Capacity                                    This field is only valid when the Maximum |
    // |                                                                  Capacity field contains 8000 0000h.       |
    // |                                                                  When Maximum Capacity contains a value    |
    // |                                                                  that is not 8000 0000h, Extended Maximum  |
    // |                                                                  Capacity must contain zeros.              |
    // |                                                                  Note: Ver ExtendedMaximumCapacity         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the Physical Memory Array (Type 16) structure.
    /// </summary>
    sealed class SmbiosType016 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType016(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType016" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public SmbiosType016(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region Version 2.1+ fields

        #region [private] (byte) Location: Gets a value representing the 'Location' field
        /// <summary>
        /// Gets a value representing the <c>Location</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Location => GetByte(0x04);
        #endregion

        #region [private] (byte) Use: Gets a value representing the 'Use' field
        /// <summary>
        /// Gets a value representing the <c>Use</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Use => GetByte(0x05);
        #endregion

        #region [private] (byte) ErrorCorrection: Gets a value representing the 'Error Correction' field
        /// <summary>
        /// Gets a value representing the <c>Error Correction</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ErrorCorrection => HeaderInfo.RawData[0x06];
        #endregion

        #region [private] (ulong) MaximumCapacity: Gets a value representing the 'Maximum Capacity' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Capacity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong MaximumCapacity => (ulong)GetDoubleWord(0x07);
        #endregion

        #region [private] (ulong) ErrorInformationHandle: Gets a value representing the 'Error Information Handle' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Capacity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ErrorInformationHandle => GetWord(0x0b);
        #endregion

        #region [private] (int) NumberOfMemoryDevices: Gets a value representing the 'Number Of Memory Devices' field
        /// <summary>
        /// Gets a value representing the <c>Number Of Memory Devices</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int NumberOfMemoryDevices => GetWord(0x0d);
        #endregion

        #endregion

        #region Version 2.7+ fields

        #region [private] (ulong) ExtendedMaximumCapacity: Gets a value representing the 'Extended Maximum Capacity' field
        /// <summary>
        /// Gets a value representing the <c>Extended Maximum Capacity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ulong ExtendedMaximumCapacity => (ulong) GetQuadrupleWord(0x0f);
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
            SmbiosType016Property propertyId = (SmbiosType016Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x04] - [v2.1] - [Location] - [string]
                case SmbiosType016Property.Location:
                    value = GetLocation(Location);
                    break;
                #endregion

                #region [0x05] - [v2.1] - [Use] - [string]
                case SmbiosType016Property.Use:
                    value = GetUse(Use);
                    break;
                #endregion

                #region [0x06] - [v2.1] - [Memory Error Correction] - [string]
                case SmbiosType016Property.MemoryErrorCorrection:
                    value = GetErrorCorrectionTypes(ErrorCorrection);
                    break;
                #endregion

                #region [0x07] - [v2.1 - v2.7] - [Maximum Capacity] - [ulong]
                case SmbiosType016Property.MaximumCapacity:                
                    value = MaximumCapacity == 0x08000000 ? ExtendedMaximumCapacity : MaximumCapacity;
                    break;
                #endregion

                #region [0x0b] - [v2.1] - [Memory Error Information Handle] - [string]
                case SmbiosType016Property.MemoryErrorInformationHandle:
                    value = GetErrorHandle(ErrorInformationHandle);
                    break;
                #endregion

                #region [0x0d] - [v2.1] - [Number Of Memory Devices] - [int]
                case SmbiosType016Property.NumberOfMemoryDevices:
                    value = NumberOfMemoryDevices;
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
            properties.Add(KnownDmiProperty.PhysicalMemoryArray.Location, GetLocation(Location));
            properties.Add(KnownDmiProperty.PhysicalMemoryArray.Use, GetUse(Use));
            properties.Add(KnownDmiProperty.PhysicalMemoryArray.MemoryErrorCorrection, GetErrorCorrectionTypes(ErrorCorrection));
            properties.Add(KnownDmiProperty.PhysicalMemoryArray.MemoryErrorInformationHandle, GetErrorHandle(ErrorInformationHandle));
            properties.Add(KnownDmiProperty.PhysicalMemoryArray.NumberOfMemoryDevices, NumberOfMemoryDevices);

            ulong maximumCapacity = MaximumCapacity;
            properties.Add(
                KnownDmiProperty.PhysicalMemoryArray.MaximumCapacity, 
                maximumCapacity == 0x08000000 
                    ? ExtendedMaximumCapacity 
                    : maximumCapacity);
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) GetLocation(byte): Gets a string indicating the location of the array
        /// <summary>
        /// Gets a string indicating the location of the array.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Matrix location
        /// </returns>
        private static string GetLocation(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "System board or motherboard",
                "ISA add-on-cardS",
                "EISA Add-on Card",
                "PCI Add-on Card",
                "MCA Add-on Card",
                "PCMCIA Add-on Card",
                "Proprietary Add-on Card",
                "NuBus" // 0x0A
            };

            string[] value2 =
            {
                "PC-98/C20 Add-on Card", // 0xA0
                "PC-98/C24 Add-on Card",
                "PC-98/E Add-on Card",
                "PC-98/Local Bus Add-on Card" // 0xA3
            };

            if (code >= 0x01 && code <= 0x0A)
            {
                return value[code - 0x01];
            }

            if (code >= 0xA0 && code <= 0xA3)
            {
                return value2[code - 0xA0];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetUse(byte): Gets a string indicating the use of the array
        /// <summary>
        /// Gets a string indicating the use of the array.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Using the Matrix.
        /// </returns> 
        private static string GetUse(byte code)
        {
            string[] value =
            {
                "Other",               // 0x01
                "Unknown",
                "System memory",
                "Video memory",
                "Flash memory",
                "Non-volatile RAM",
                "Cache memory",
                "PCMCIA Add-on Card"   // 0x08
            };

            if (code >= 0x01 && code <= 0x08)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetErrorCorrectionTypes(byte): Gets a string indicating the type of error correction
        /// <summary>
        /// Gets a string indicating the type of error correction.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The type of error correction.
        /// </returns> 
        private static string GetErrorCorrectionTypes(byte code)
        {
            string[] value =
            {
                "Other", // 0x01
                "Unknown",
                "None",
                "Parity",
                "Single-bit ECC",
                "Multi-bit ECC",
                "CRC" // 0x07
            };

            if (code >= 0x01 && code <= 0x07)
            {
                return value[code - 0x01];
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #region [private] {static} (string) GetErrorHandle(int): Gets a string representing the error handler
        /// <summary>
        /// Gets a string representing the error handler.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// The error handler.
        /// </returns> 
        private static string GetErrorHandle(int code)
        {
            if (code == 0xFFFE)
            {
                return "Not Provided";
            }

            if (code == 0xFFFF)
            {
                return "No Error";
            }

            return $"{code:X}";
        }
        #endregion

        #endregion
    }
}
