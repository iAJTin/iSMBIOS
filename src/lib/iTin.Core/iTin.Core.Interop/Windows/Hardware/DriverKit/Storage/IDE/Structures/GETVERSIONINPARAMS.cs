
namespace iTin.Core.Interop.Windows.Hardware.DriverKit.Storage.Ide
{
    using System;
    using System.Runtime.InteropServices;

    using Helpers;
    using Helpers.Enumerations;

    using UCHAR = System.Byte;
    using ULONG = System.UInt32;

    /// <summary>
    /// The <strong>GETVERSIONINPARAMS</strong> structure is used in conjunction with the SMART_GET_VERSION request to retrieve version information, a capabilities mask, and a bitmask for the indicated device.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/content/ntdddisk/ns-ntdddisk-_getversioninparams.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct GETVERSIONINPARAMS : IEquatable<GETVERSIONINPARAMS>
    {
        #region public enumerations

        #region [public] (enum) Capabilities: Contains the bitmask of driver capabilities.
        /// <summary>
        /// Contains the bitmask of driver capabilities.
        /// </summary>
        [Flags]
        public enum Capabilities : uint
        {
            /// <summary>
            /// ATA ID command supported
            /// </summary>
            CAP_ATA_ID_CMD = 1,
            
            /// <summary>
            /// ATAPI ID command supported
            /// </summary>
            CAP_ATAPI_ID_CMD = 2,
            
            /// <summary>
            /// SMART commannds supported
            /// </summary>
            CAP_SMART_CMD = 4,
        }
        #endregion

        #region [public] (enum) IdeDeviceLocation: Contains the bitmask of driver capabilities.
        /// <summary>
        /// Contains the bitmask of driver capabilities.
        /// </summary>
        [Flags]
        public enum IdeDeviceLocation
        {
            Unknown = -1,

            IdeMasterPrimaryChannel,

            IdeSlavePrimaryChannel,

            IdeMasterSecondaryChannel,

            IdeSlaveSecondaryChannel,

            AtapiMasterPrimaryChannel,

            AtapiSlavePrimaryChannel,

            AtapiMasterSecondaryChannel,

            AtapiSlaveSecondaryChannel,
        }
        #endregion

        #endregion

        #region public members
        /// <summary>
        /// Version number of the binary driver.
        /// </summary>
        public UCHAR Version;

        /// <summary>
        /// Binary controller revision number.
        /// </summary>
        public UCHAR Revision;

        /// <summary>
        /// Reservad.
        /// </summary>
        public UCHAR Reserved;

        /// <summary>
        /// Mapeado de dispositivos.
        /// </summary>
        public UCHAR IdeDeviceMap;

        /// <summary>
        /// Máscara de bits con las capacidades del driver.
        /// </summary>
        [CLSCompliant(false)]
        public Capabilities fCapabilities;

        /// <summary>
        /// Reservado.
        /// </summary>
        [CLSCompliant(false)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ULONG[] wReserved;
        #endregion

        #region interfaces

        #region [public] (bool) Equals(GETVERSIONINPARAMS): Indicates whether the current structure is the same as another structure of the same type
        /// <summary>
        /// Indicates whether the current structure is the same as another structure of the same type.
        /// </summary>
        /// <param name="other"> Structure to be compared with this structure.</param>
        /// <returns>
        /// Returns <strong>true</strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
        /// </returns>
        public bool Equals(GETVERSIONINPARAMS other) => other.Equals((object)this);
        #endregion

        #endregion

        #region public operatos

        #region [public] {static} (bool) operator ==(GETVERSIONINPARAMS, GETVERSIONINPARAMS): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Operating 1.</param>
        /// <param name="right">Operating 2.</param>
        /// <returns>
        /// Returns <strong> true </strong> if <c> operator1 </c> is equal to <c> operator2 </c>; <strong> false </strong> otherwise.
        /// </returns>
        public static bool operator ==(GETVERSIONINPARAMS left, GETVERSIONINPARAMS right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(GETVERSIONINPARAMS, GETVERSIONINPARAMS): Implements the inequality operator (!=)
        /// <summary>
        /// Implements the inequality operator (!=).
        /// </summary>
        /// <param name="left">Operand 1.</param>
        /// <param name="right">Operand 2.</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(GETVERSIONINPARAMS left, GETVERSIONINPARAMS right) => !left.Equals(right);
        #endregion

        #endregion

        #region public static properties
        public static GETVERSIONINPARAMS Empty => new GETVERSIONINPARAMS();
        #endregion

        #region public properties

        #region [public] (IdeDeviceLocation) DeviceLocation: 

        public IdeDeviceLocation DeviceLocation
        {
            get
            {
                var location = IdeDeviceLocation.Unknown;
                for (int i = 0; i <= 7; i++)
                {
                    var found = LogicHelper.CheckBit(IdeDeviceMap, (Bits)i);
                    if (!found)
                    {
                        continue;
                    }

                    location = (IdeDeviceLocation) i;
                    break;
                }

                return location;
            }
        }
        #endregion

        #endregion        

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns a value that represents the hash code of this structure
        /// <summary>
        /// Returns a value that represents the hash code of this structure.
        /// </summary>
        /// <returns>
        /// Hash code of this structure.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object): Returns a value that indicates whether this structure is the same as another
        /// <summary>
        /// Returns a value that indicates whether this structure is the same as another.
        /// </summary>
        /// <param name="obj">Structure to compare.</param>
        /// <returns>
        /// Result of the equality comparison.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is GETVERSIONINPARAMS))
            {
                return false;
            }

            var other = (GETVERSIONINPARAMS)obj;

            return 
                other.Version == Version &&
                other.Revision == Revision &&
                other.fCapabilities == fCapabilities &&
                other.IdeDeviceMap == IdeDeviceMap;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current structure
        /// <summary>
        /// Returns a string that represents the current structure.
        /// </summary>
        /// <returns>
        /// String representing the current structure.
        /// </returns>
        public override string ToString() => $"Version = {Version}; Revision = {Revision}; Location = {DeviceLocation}";
        #endregion

        #endregion
    }
}
