
namespace iTin.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 046: String Property.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Type            BYTE        46          String Property                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Length          BYTE        9           Length of the structure.                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Handle          WORD        Varies      Handle, or instance number, associated with the       |
    // |                                                      structure                                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          String          WORD        Varies      Please see GetPropertyId() function                   |
    // |              Property ID                                                                                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          String          BYTE        STRING      String number.                                        |
    // |              Property                                                                                      |
    // |              Value                                                                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Parent handle   WORD        Varies      Handle corresponding to the structure this string     |
    // |                                                      property applies to.                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc/>
    /// <summary>
    /// Specialization of the <see cref="SmbiosBaseType"/> class that contains the logic to decode the String Property (Type 46) structure.
    /// </summary>
    internal sealed class SmbiosType046 : SmbiosBaseType
    {
        #region constructor/s

        #region [public] SmbiosType046(SmbiosStructureHeaderInfo, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the <see cref="SmbiosType046"/> class by specifying the structure information and the <see cref="SMBIOS"/> version.
        /// </summary>
        /// <param name="smbiosStructureHeaderInfo">Raw information of the current structure.</param>
        /// <param name="smbiosVersion">Current <see cref="SMBIOS"/> version.</param>
        public SmbiosType046(SmbiosStructureHeaderInfo smbiosStructureHeaderInfo, int smbiosVersion) : base(smbiosStructureHeaderInfo, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region 3.5

        #region [private] (string) PropertyValue: Gets a value representing the 'Property Value' field
        /// <summary>
        /// Gets a value representing the <b>Property Value</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string PropertyValue => GetString(0x06);
        #endregion

        #region [private] (ushort) PropertyId: Gets a value representing the 'Property Id' field
        /// <summary>
        /// Gets a value representing the <b>Property Id</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort PropertyId => (ushort)Reader.GetWord(0x04);
        #endregion

        #region [private] (ushort) ParentHandle: Gets a value representing the 'Parent Handle' field
        /// <summary>
        /// Gets a value representing the <b>Parent Handle</b> field.
        /// </summary>
        /// <value>
        /// Parent Handle.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ushort ParentHandle => (ushort)Reader.GetWord(0x07);
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
            #region version 3.5

            if (StructureInfo.StructureVersion >= SmbiosStructureVersion.v35)
            {
                properties.Add(SmbiosProperty.StringProperty.PropertyId, GetPropertyId(PropertyId));
                properties.Add(SmbiosProperty.StringProperty.PropertyValue, PropertyValue);
                properties.Add(SmbiosProperty.StringProperty.ParentHandle, ParentHandle);
            }

            #endregion
        }
        #endregion

        #endregion


        #region BIOS Specification 3.5.0 (15/09/2021)

        #region [private] {static} (string) GetPropertyId(ushort): Gets a string representing the Property Id
        /// <summary>
        /// Gets a string representing the Property Id.
        /// </summary>
        /// <param name="code">Value to analyze.</param>
        /// <returns>
        /// Property Id.
        /// </returns>
        private static string GetPropertyId(ushort code)
        {
            switch (code)
            {
                case 0:
                    return "Reserved";

                case 1:
                    return "UEFI device path";

                default:
                    if (code >= 2 && code <= 32767)
                    {
                        return "Reserved for future DMTF use";
                    }
                    else if (code >= 32768 && code <= 49151)
                    {
                        return "Reserved for BIOS vendor use";
                    }
                    else
                    {
                        return "Reserved for OEM";
                    }
            }
        }
        #endregion

        #endregion
    }
}
