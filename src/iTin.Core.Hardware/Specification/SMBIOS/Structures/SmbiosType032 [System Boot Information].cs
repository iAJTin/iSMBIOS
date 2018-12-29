
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections;
    using System.Diagnostics;

    using Dmi.Property;
    using Helpers;

    // Type 032: System Boot Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        32          System Boot Information structure identifier          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        Varies      Length of the structure, at least 14h                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      The handle, or instance number, associated with the   |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Reserved        6 BYTEs     00h         Reserved for future assignment by this specification; |
    // |                                                      all bytes are set to 00h.                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Boot Status     10 BYTEs    Varies      The Status and Additional Data fields that identify   |
    // |                                                      boot status.                                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref = "T:iTin.Core.Hardware.Specification.Smbios.SmbiosBaseType" /> class that contains the logic to decode the System Boot Information (Type 32) structure.
    /// </summary>
    sealed class SmbiosType032 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType032(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version.
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType032"/> class by specifying the structure information and the <see cref="SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS" /> version.</param>
        public SmbiosType032(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) BootStatus: Gets a value representing the 'Boot Status' field.
        /// <summary>
        /// Gets a value representing the <c>Boot Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BootStatus
        {
            get { return GetByte(0x0a); }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Gets a value that represents the value of the specified property.
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
            SmbiosType032Property propertyId = (SmbiosType032Property)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x0a] - [BootStatus] - [String]
                case SmbiosType032Property.BootStatus:
                    value = GetBootStatus(BootStatus);
                    break;
                #endregion
            }
            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Gets the property collection for this structure.
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
            properties.Add(KnownDmiProperty.SystemBoot.BootStatus, GetBootStatus(BootStatus));
            #endregion
        }
        #endregion

        #endregion

        #region BIOS Specification 2.7.1 (26/01/2011)

        #region [private] {static} (string) SystemBootStatus(byte):
        private static string GetBootStatus(byte code)
        {
            string[] value =
            {
                "No errors detected",                          // 0
                "No bootable media",
                "Operating system failed to load",
                "Firmware-detected hardware failure",
                "Operating system-detected hardware failure",
                "User-requested boot",
                "System security violation",
                "Previously-requested image",
                "System watchdog timer expired"                // 8
            };

            if (code <= 8)
            {
                return value[code];
            }

            if (code >= 128 && code <= 191)
            {
                return "OEM-specific";
            }

            if (code >= 192)
            {
                return "Product-specific";
            }

            return SmbiosHelper.OutOfSpec;
        }
        #endregion

        #endregion
    }
}
