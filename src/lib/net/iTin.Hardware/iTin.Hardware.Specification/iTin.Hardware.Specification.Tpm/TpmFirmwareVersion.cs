
namespace iTin.Hardware.Specification.Tpm
{
    using iTin.Core;

    // TPM_VERSION definition
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Type               Name        Description                                                                                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | TPM_VERSION_BYTE   Major       This SHALL indicate the major version of the TPM, mostSigVer MUST be 0x01, leastSigVer MUST be 0x00         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | TPM_VERSION_BYTE   Minor       This SHALL indicate the minor version of the TPM, mostSigVer MUST be 0x01 or 0x02, leastSigVer MUST be 0x00 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | TPM_VERSION_BYTE   revMajor    This SHALL be the value of the TPM_PERMANENT_DATA -> revMajor                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | TPM_VERSION_BYTE   revMinor    This SHALL be the value of the TPM_PERMANENT_DATA -> revMinor                                               |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    //
    // Notes
    // 1. The major and minor fields indicate the specification version the TPM was designed for
    // 2. The revMajor and revMinor fields indicate the manufacturer’s revision of the TPM
    //    a. Most challengers of the TPM MAY ignore the revMajor and revMinor fields
    //
    // TPM_VERSION_BYTE definition
    // Allocating a byte for the version information is wasteful of space.The current allocation does not provide sufficient resolution to indicate completely the version of the TPM.
    // To allow for backwards compatibility the size of the structure does not change from 1.1.
    // To enable minor version numbers with 2-digit resolution, the byte representing a version splits into two BCD encoded nibbles.The ordering of the low and high order provides
    // backwards compatibility with existing numbering.
    // An example of an implementation of this is; a version of 1.23 would have the value 2 in bit positions 3-0 and the value 3 in bit positions 7-4.
    // TPM_VERSION_BYTE is a byte.
    //
    // The byte is broken up according to the following rule
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Bit position       Name            Description                                                                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 7-4                leastSigVer     Least significant nibble of the minor version. MUST be values within the range of 0000-1001   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 3-0                mostSigVer      Most significant nibble of the minor version. MUST be values within the range of 0000-1001    |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Represents <b>TPM</b> firmware version.
    /// </summary>
    public class TpmFirmwareVersion
    {
        #region public static readonly properties

        #region [public] {static} (TpmFirmwareVersion) Unknown: Gets a TpmFirmwareVersion reference with all field set to minus one (-1)
        /// <summary>
        /// Gets a <see cref="TpmFirmwareVersion"/> reference with all field set to minus one (-1).
        /// </summary>
        /// <value>
        /// An empty <see cref="TpmFirmwareVersion"/> reference. All values sets to zero (0)
        /// </value>
        public static TpmFirmwareVersion Unknown => new TpmFirmwareVersion {MajorVersion = -1, MinorVersion = -1, MajorRevision = -1, MinorRevision = -1};
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (bool) IsUnknownVersion: Gets a value indicating whether this instance is unknown version
        /// <summary>
        /// Gets a value indicating whether this instance is unknown version.
        /// </summary>
        /// <value>
        /// <b>true</b> if this <b>TpmFirmwareVersion</b> instance has a unknown version  contains the default; otherwise, <b>false</b>.
        /// </value>
        public bool IsUnknownVersion =>MajorVersion == -1 && MinorVersion == -1  && MajorRevision == -1 && MinorRevision == -1;
        #endregion

        #endregion

        #region public properties

        #region [public] (int) MajorVersion: Gets or sets a value representing firmware major version
        /// <summary>
        /// Gets or sets a value representing firmware major version.
        /// </summary>
        /// <value>
        /// Firmware major version.
        /// </value>
        public int MajorVersion { get; set; }
        #endregion

        #region [public] (int) MinorVersion: Gets or sets a value representing firmware minor version
        /// <summary>
        /// Gets or sets a value representing firmware minor version.
        /// </summary>
        /// <value>
        /// Firmware minor version.
        /// </value>
        public int MinorVersion { get; set; }
        #endregion

        #region [public] (int) MajorRevision: Gets or sets a value representing firmware major revision, this value is usually the manufacturer's major revision
        /// <summary>
        /// Gets or sets a value representing firmware major revision, this value is usually the manufacturer's major revision.
        /// </summary>
        /// <value>
        /// Firmware major revision.
        /// </value>
        public int MajorRevision { get; set; }
        #endregion

        #region [public] (int) MinorRevision: Gets or sets a value representing firmware minor revision, this value is usually the manufacturer's minor revision
        /// <summary>
        /// Gets or sets a value representing firmware minor revision, this value is usually the manufacturer's minor revision.
        /// </summary>
        /// <value>
        /// Firmware minor revision.
        /// </value>
        public int MinorRevision { get; set; }
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (TpmFirmwareVersion) Parse(byte[]): Parses firmware version raw data, valid only for Firmware Spec Version 1
        /// <summary>
        /// Parses firmware version raw data, valid only for <b>Firmware Spec Version 1</b>.
        /// </summary>
        /// <param name="rawBytes">Target data to analyze</param>
        /// <returns>
        /// A <see cref="TpmFirmwareVersion"/> reference that contains the firmware version.
        /// </returns>
        public static TpmFirmwareVersion Parse(byte[] rawBytes)
        {
            var majorVersion = rawBytes[0x00];
            var majorVersionNibbles = majorVersion.ToNibbles();
            var mostSigVerMajorVersion = majorVersionNibbles[1];
            var leastSigVerMajorVersion = majorVersionNibbles[0];

            var minorVersion = rawBytes[0x01];
            var minorVersionNibbles = minorVersion.ToNibbles();
            var mostSigVerMinorVersion = minorVersionNibbles[1];
            var leastSigVerMinorVersion = minorVersionNibbles[0];

            var majorRevision = rawBytes[0x02];
            var minorRevision = rawBytes[0x03];

            return new TpmFirmwareVersion
            {
                MajorVersion = mostSigVerMajorVersion,
                MinorVersion = mostSigVerMinorVersion,
                MajorRevision = majorRevision,
                MinorRevision = minorRevision
            };
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="string"/> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="string"/> that represents the current <see cref="TpmFirmwareVersion"/> class.
        /// </returns>
        public override string ToString() => MajorRevision != 0 ? $"{MajorVersion}.{MinorVersion}.{MajorRevision}.{MinorRevision}" : $"{MajorVersion}.{MinorVersion}";
        #endregion

        #endregion
    }
}
