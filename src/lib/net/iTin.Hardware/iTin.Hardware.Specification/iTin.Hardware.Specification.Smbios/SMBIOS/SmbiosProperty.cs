
namespace iTin.Hardware.Specification.Smbios.Property
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines available keys for the available devices of a system.
    /// </summary>
    public static partial class SmbiosProperty
    {
        #region [public] {static} (class) Bios: Contains the key definitions available for a type 000 [Bios Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 000 [<see cref="SmbiosStructure.Bios"/> Information] structure.
        /// </summary>
        public static class Bios
        {
            #region Version 2.0+

            #region [public] {static} (IPropertyKey) Vendor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the BIOS Vendor’s Name.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.Vendor"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Vendor => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.Vendor);
            #endregion

            #region [public] {static} (IPropertyKey) BiosVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the BIOS Version.</para>
            /// <para>This value is a free-form string that may contain core and <b>OEM</b> version information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosVersion => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosVersion);
            #endregion

            #region [public] {static} (IPropertyKey) BiosStartSegment: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Segment location of BIOS starting address. This value is a free-form string that may contain core and <b>OEM</b> version information.
            /// The size of the runtime BIOS image can be computed by subtracting the Starting Address Segment from 10000h and multiplying the result by 16.
            /// When not applicable, such as on UEFI-based systems, this value is set to 0000h.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosStartSegment"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosStartSegment => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosStartSegment);
            #endregion

            #region [public] {static} (IPropertyKey) BiosReleaseDate: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// String number of the BIOS release date. The date string, if supplied, is in either mm/dd/yy or mm/dd/yyyy format. If the year portion of the string is two digits, the year is assumed to be 19yy.
            /// The mm/dd/yyyy format is required for SMBIOS version 2.3 and later.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosReleaseDate"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosReleaseDate => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosReleaseDate);
            #endregion

            #region [public] {static} (IPropertyKey) BiosRomSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the physical device containing the BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosRomSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosRomSize => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosRomSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports: <b>PCI</b>, <b>PCMCIA</b>, <b>Flash</b>, etc.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.Characteristics"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.Characteristics);
            #endregion

            #endregion

            #region Version 2.4+

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.CharacteristicsExtensionByte1"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CharacteristicsExtensionByte1 => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.CharacteristicsExtensionByte1);
            #endregion

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.CharacteristicsExtensionByte2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CharacteristicsExtensionByte2 => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.CharacteristicsExtensionByte2);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMajorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the major release of the System BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.SystemBiosMajorRelease"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SystemBiosMajorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.SystemBiosMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMinorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the minor release of the System BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.SystemBiosMinorRelease"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SystemBiosMinorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.SystemBiosMinorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMajorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the major release of the embedded controller firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.FirmwareMajorRelease"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareMajorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.FirmwareMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMinorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the minor release of the embedded controller firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.FirmwareMinorRelease"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareMinorRelease => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.FirmwareMinorRelease);
            #endregion

            #endregion

            #region version 3.1+

            #region [public] {static} (IPropertyKey) ExtendedBiosRomSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Extended size of the physical device(s) containing the BIOS. For check measured unit, please see <see cref="BiosRomSizeUnit"/>.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosRomSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+, 3.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedBiosRomSize => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.ExtendedBiosRomSize, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) BiosRomSizeUnit: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the physical device(s) containing the BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Bios"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType000Property.BiosRomSizeUnit"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="MemorySizeUnit"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosRomSizeUnit => new PropertyKey(SmbiosStructure.Bios, SmbiosType000Property.BiosRomSizeUnit);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) System: Contains the key definitions available for a type 001 [System Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 001 [<see cref="SmbiosStructure.System"/> Information] structure.
        /// </summary>
        public static class System
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Manufacturer name</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ProductName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Product name</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.ProductName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProductName => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.ProductName);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Product Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.Version"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.SerialNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) UUID: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Universal unique ID number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.UUID"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey UUID => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.UUID);
            #endregion

            #region [public] {static} (IPropertyKey) WakeUpType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the event that caused the system to power up.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.WakeUpType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey WakeUpType => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.WakeUpType);
            #endregion

            #endregion

            #region version 2.4+

            #region [public] {static} (IPropertyKey) SkuNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// This text string identifies a particular computer configuration for sale.
            /// It is sometimes also called a product ID or purchase order number.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.SkuNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SkuNumber => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.SkuNumber);
            #endregion

            #region [public] {static} (IPropertyKey) Family: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>This text string identifies the family to which a particular computer belongs.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.System"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType001Property.Family"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.4+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Family => new PropertyKey(SmbiosStructure.System, SmbiosType001Property.Family);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BaseBoard: Contains the key definitions available for a type 002 [Baseboard (or Module) Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 002 [<see cref="SmbiosStructure.BaseBoard"/> (or Module) Information] structure.
        /// </summary>
        public static class BaseBoard
        {
            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Manufacturer name</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Product: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Baseboard product.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.Product"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Product => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Product);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Version</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.Version"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard asset tag number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.AssetTag"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) LocationInChassis: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String that describes this board's location.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.LocationInChassis"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LocationInChassis => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.LocationInChassis);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the chassis in which this board resides.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.ChassisHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ChassisHandle => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.ChassisHandle);
            #endregion

            #region [public] {static} (IPropertyKey) BoardType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.BoardType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BoardType => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.BoardType);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfContainedObjectHandles: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number (0 to 255) of contained Object Handles that follow.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.NumberOfContainedObjectHandles"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfContainedObjectHandles => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.NumberOfContainedObjectHandles);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>List of handles of other structures (for examples, Baseboard, Processor, Port, System Slots, Memory Device) that are contained by this baseboard.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType002Property.ContainedObjectHandles"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="BaseBoardContainedElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.ContainedObjectHandles);
            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Features' section
            /// <summary>
            /// Contains the key definition for the <b>Features</b> section.
            /// </summary>
            public static class Features
            {
                #region [public] {static} (IPropertyKey) IsHostingBoard: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is hosting board.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType002Property.IsHostingBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHostingBoard => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsHostingBoard);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotSwappable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is hot swappable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType002Property.HotSwappable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHotSwappable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.HotSwappable);
                #endregion

                #region [public] {static} (IPropertyKey) IsRemovable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is removable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType002Property.IsRemovable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsRemovable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsRemovable);
                #endregion

                #region [public] {static} (IPropertyKey) IsReplaceable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is replaceable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType002Property.IsReplaceable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsReplaceable => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.IsReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) RequiredDaughterBoard: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard required a daughter board.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType002Property.RequiredDaughterBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey RequiredDaughterBoard => new PropertyKey(SmbiosStructure.BaseBoard, SmbiosType002Property.RequiredDaughterBoard);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Chassis: Contains the key definitions available for a type 003 [System Enclosure or Chassis] structure
        /// <summary>
        /// Contains the key definitions available for a type 003 [<see cref="SmbiosStructure.SystemEnclosure"/> Information] structure.
        /// </summary>
        public static class Chassis
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Manufacturer name</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Locked: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates if chassis lock is present.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.Locked"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Locked => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Locked);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.ChassisType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ChassisType => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ChassisType);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.Version"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset Tag Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.AssetTagNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTagNumber => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.AssetTagNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) BootUpState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>State of the enclosure when it was last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.BootUpState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BootUpState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.BootUpState);
            #endregion

            #region [public] {static} (IPropertyKey) PowerSupplyState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>State of the enclosure’s power supply (or supplies) when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.PowerSupplyState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PowerSupplyState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.PowerSupplyState);
            #endregion

            #region [public] {static} (IPropertyKey) ThermalState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Thermal state of the enclosure when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.ThermalState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThermalState => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ThermalState);
            #endregion

            #region [public] {static} (IPropertyKey) SecurityStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical security status of the enclosure when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.SecurityStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SecurityStatus => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SecurityStatus);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) Height: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Height of the enclosure, in 'U's  A U is a standard unit of measure for the height of a rack or rack-mountable component and is equal to 1.75 inches or 4.445 cm.</para>
            /// <para>A value of 00h indicates that the enclosure height is unspecified.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.Height"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.U"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Height => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.Height, PropertyUnit.U);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfPowerCords: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of power cords associated with the enclosure or chassis.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.NumberOfPowerCords"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfPowerCords => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.NumberOfPowerCords);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of contained Element records that follow, in the range 0 to 255.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.ContainedElements"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ChassisContainedElementCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElements);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) SkuNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String describing the chassis or enclosure SKU number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType003Property.SkuNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SkuNumber => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.SkuNumber);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Elements: Contains the key definition for the 'Elements' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Elements
            {
                #region [public] {static} (IPropertyKey) ItemType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Type of element associated.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType003Property.ContainedType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.3+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ItemType => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedType);
                #endregion

                #region [public] {static} (IPropertyKey) Min: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Specifies the minimum number of the element type that can be installed in the chassis for the chassis to properly operate, in the range 0 to 254.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType003Property.ContainedElementMinimum"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.3+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Min => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElementMinimum);
                #endregion

                #region [public] {static} (IPropertyKey) Max: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Specifies the maximum number of the element type that can be installed in the chassis, in the range 1 to 255.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType003Property.ContainedElementMaximum"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.3+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Max => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedElementMaximum);
                #endregion

                #region [public] {static} (IPropertyKey) TypeSelect: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Type of select element associated.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType003Property.ContainedTypeSelect"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ChassisContainedElementType"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.3+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey TypeSelect => new PropertyKey(SmbiosStructure.SystemEnclosure, SmbiosType003Property.ContainedTypeSelect);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Processor: Contains the key definitions available for a type 004 [Processor Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 004 [<see cref="SmbiosStructure.Processor"/> Information] structure.
        /// </summary>
        public static class Processor
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Reference designation.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.SocketDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String containing the type of processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorType => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorType);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorFamily: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String containing the family of processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorFamily"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Family => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorFamily);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorManufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor manufacturer.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorManufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorManufacturer => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorManufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Raw processor identification data.</para>
            /// <para>The Processor ID field contains processor-specific information that describes the processor’s features.</para>
            /// <para>
            ///  <list type="bullet">
            ///   <item>
            ///    <term>x86</term>
            ///    <description>
            ///     <para>The field’s format depends on the processor’s support of the CPUID instruction. If the instruction is supported, the Processor ID field contains two DWORD-formatted values.</para>
            ///     <para>The first (offsets 08h-0Bh) is the EAX value returned by a CPUID instruction with input EAX set to 1; the second(offsets 0Ch-0Fh) is the EDX value returned by that instruction.</para>
            ///    </description>
            ///   </item>
            ///   <item>
            ///    <term>ARM32</term>
            ///    <description>
            ///     <para>The processor ID field contains two DWORD-formatted values. The first (offsets 08h-0Bh) is the contents of the Main ID Register(MIDR); the second(offsets 0Ch-0Fh) is zero.</para>
            ///    </description>
            ///   </item>
            ///   <item>
            ///    <term>ARM64</term>
            ///    <description>
            ///     <para>The processor ID field contains two DWORD-formatted values. The first (offsets 08h-0Bh) is the contents of the MIDR_EL1 register; the second (offsets 0Ch-0Fh) is zero.</para>
            ///    </description>
            ///   </item>
            ///   <item>
            ///    <term>RISC-V</term>
            ///    <description>
            ///     <para>The processor ID contains a QWORD Machine Vendor ID CSR (mvendroid) of RISC-V processor hart 0. More information of RISC-V class CPU feature is described in RISC-V processor additional information.</para>
            ///    </description>
            ///   </item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorId => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorId);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String describing the processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorVersion => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalClock: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>External Clock Frequency, in MHz.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ExternalClock"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExternalClock => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ExternalClock, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum processor speed (in MHz) supported by the system for this processor socket 0E9h is for a 233 MHz processor. If the value is unknown, the field is set to 0.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.MaximumSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximunSpeed => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.MaximumSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current processor speed (in MHz).</para>
            /// <para>This field identifies the processor's speed at system boot; the processor may support more than one speed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.CurrentSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentSpeed => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CurrentSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorUpgrade: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor upgrade value.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ProcessorUpgrade"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpgradeMethod => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ProcessorUpgrade);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) L1CacheHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle of a cache information structure that defines the attributes of the primary (Level 1) cache for this processor.</para>
            /// <para>
            ///  <list type="bullet">
            ///   <item><description>For version 2.1 and version 2.2 implementations, the value is 0FFFFh if the processor has no L1 cache.</description></item>
            ///   <item><description>For version 2.3 and later implementations, the value is 0FFFFh if the Cache Information structure is not provided.</description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.L1CacheHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey L1CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L1CacheHandle);
            #endregion

            #region [public] {static} (IPropertyKey) L2CacheHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle of a cache information structure that defines the attributes of the secondary (Level 2) cache for this processor.</para>
            /// <para>
            ///  <list type="bullet">
            ///   <item><description>For version 2.1 and version 2.2 implementations, the value is 0FFFFh if the processor has no L2 cache.</description></item>
            ///   <item><description>For version 2.3 and later implementations, the value is 0FFFFh if the Cache Information structure is not provided.</description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.L2CacheHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey L2CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L2CacheHandle);
            #endregion

            #region [public] {static} (IPropertyKey) L3CacheHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle of a cache information structure that defines the attributes of the tertiary (Level 3) cache for this processor.</para>
            /// <para>
            ///  <list type="bullet">
            ///   <item><description>For version 2.1 and version 2.2 implementations, the value is 0FFFFh if the processor has no L3 cache.</description></item>
            ///   <item><description>For version 2.3 and later implementations, the value is 0FFFFh if the Cache Information structure is not provided.</description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.L3CacheHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey L3CacheHandle => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.L3CacheHandle);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Serial number of this processor. This value is set by the manufacturer and normally not changeable.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset tag of this processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.AssetTag"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset tag of this processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.PartNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PartNumber => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.PartNumber);
            #endregion

            #endregion

            #region version 2.5+

            #region [public] {static} (IPropertyKey) CoreCount: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of cores per processor socket. If the value is unknown, the field is set to 0.
            /// Core Count is the number of cores detected by the BIOS for this processor socket. It does not necessarily indicate the full capability of the processor.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.CoreCount"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.5+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreCount => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreCount);
            #endregion

            #region [public] {static} (IPropertyKey) CoreEnabled: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of enabled cores per processor socket. If the value is unknown, the field is set 0.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.CoreEnabled"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.5+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreEnabled => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreEnabled);
            #endregion

            #region [public] {static} (IPropertyKey) ThreadCount: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of threads per processor socket. If the value is unknown, the field is set to 0.
            /// For thread counts of 256 or greater, this property returns FFh and the <b>ThreadCount2</b> property is set to the number of threads.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ThreadCount"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.5+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThreadCount => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ThreadCount);
            #endregion

            #endregion

            #region version 3.0+

            #region [public] {static} (IPropertyKey) CoreCount2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of cores per processor socket. Supports core counts >255.
            /// If this field is present, it holds the core count for the processor socket.
            /// Core Count will also hold the core count, except for core counts that are 256 or greater.
            /// In that case, core Count shall be set to FFh and core Count 2 will hold the count.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.CoreCount2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreCount2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreCount2);
            #endregion

            #region [public] {static} (IPropertyKey) CoreEnabled2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of enabled cores per processor socket. Supports core enabled counts >255
            /// If this field is present, it holds the core enabled count for the processor socket.
            /// Core Enabled will also hold the core enabled count, except for core counts that are 256 or greater.
            /// In that case, core enabled shall be set to FFh and core enabled 2 will hold the count.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.CoreEnabled2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreEnabled2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CoreEnabled2);
            #endregion

            #region [public] {static} (IPropertyKey) ThreadCount2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of threads per processor socket. Supports thread counts >255
            /// If this field is present, it holds the thread count for the processor socket.
            /// Thread Count will also hold the thread count, except for thread counts that are 256 or greater.
            /// In that case, thread count shall be set to FFh and thread count 2 will hold the count.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType004Property.ThreadCount2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThreadCount2 => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ThreadCount2);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Characteristics' section
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (IPropertyKey) Capable64Bits: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>64-bit Capable indicates the maximum data width capability of the processor.</para>
                /// <para>For example, this bit is set for Intel Itanium, AMD Opteron, and Intel Xeon(with EM64T) processors; this bit is cleared for Intel Xeon processors that do not have EM64T.</para>
                /// <para>Indicates the maximum capability of the processor and does not indicate the current enabled state.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.Capable64Bits"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Capable64Bits => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.Capable64Bits);
                #endregion

                #region [public] {static} (IPropertyKey) Capable128Bits: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>128-bit Capable indicates the maximum data width capability of the processor.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.Capable128Bits"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Capable128Bits => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.Capable128Bits);
                #endregion

                #region [public] {static} (IPropertyKey) Arm64SocIdSupported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>indicates that the processor supports returning a SoC ID value using the
                /// SMCCC_ARCH_SOC_ID architectural call, as defined in the Arm SMC Calling Convention Specification v1.2 at
                /// https://developer.arm.com/architectures/system-architectures/software-standards/smccc.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.Arm64SocIdSupported"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>3.4+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Arm64SocIdSupported => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.Arm64SocIdSupported);
                #endregion

                #region [public] {static} (IPropertyKey) EnhancedVirtualizationInstructions: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor is capable of executing enhanced virtualization instructions. Does not indicate the present state of this feature.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.EnhancedVirtualizationInstructions"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey EnhancedVirtualizationInstructions => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.EnhancedVirtualizationInstructions);
                #endregion

                #region [public] {static} (IPropertyKey) ExecuteProtectionSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Indicates that the processor supports marking specific memory regions as non-executable.
                /// For example, this is the NX (No eXecute) feature of AMD processors and the XD (eXecute Disable) feature of Intel processors.
                /// Does not indicate the present state of this feature.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.ExecuteProtectionSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ExecuteProtectionSupport => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.ExecuteProtectionSupport);
                #endregion

                #region [public] {static} (IPropertyKey) MultiCore: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates the processor has more than one core. Does not indicate the number of cores (Core Count) enabled by hardware or the number of cores (Core Enabled) enabled by BIOS.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.MultiCore"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey MultiCore => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.MultiCore);
                #endregion

                #region [public] {static} (IPropertyKey) HardwareThreadPerCore: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor supports multiple hardware threads per core. Does not indicate the state or number of threads.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.HardwareThreadPerCore"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HardwareThreadPerCore => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.HardwareThreadPerCore);
                #endregion

                #region [public] {static} (IPropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor is capable of load-based power savings. Does not indicate the present state of this feature.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.PowerPerformanceControlSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.5+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PowerPerformanceControlSupport => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.PowerPerformanceControlSupport);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Status: Contains the key definition for the 'Status' section
            /// <summary>
            /// Contains the key definition for the <b>Status</b> section.
            /// </summary>
            public static class Status
            {
                #region [public] {static} (IPropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>String containing the current status of processor.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.CpuStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey CpuStatus => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.CpuStatus);
                #endregion

                #region [public] {static} (IPropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if CPU is populated.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.SocketPopulated"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SocketPopulated => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.SocketPopulated);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Voltage: Contains the key definition for the 'Voltage' section
            /// <summary>
            /// Contains the key definition for the <b>Voltage</b> section.
            /// </summary>
            public static class Voltage
            {
                #region [public] {static} (IPropertyKey) IsLegacyMode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicating 'legacy' mode for processor voltage</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.IsLegacyMode"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsLegacyMode => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.IsLegacyMode);
                #endregion

                #region [public] {static} (IPropertyKey) VoltageCapability: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Represent the specific voltages that the processor socket can accept.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Processor"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType004Property.VoltageCapability"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.V"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedVoltages => new PropertyKey(SmbiosStructure.Processor, SmbiosType004Property.VoltageCapability, PropertyUnit.V);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryController: Contains the key definitions available for a type 005, obsolete [Memory Controller Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 005, obsolete [<see cref="SmbiosStructure.MemoryController"/> Information] structure.
        /// </summary>
        public static class MemoryController
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Error detecting method.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.ErrorDetectingMethod"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorDetectingMethod => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ErrorDetectingMethod);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Error detecting capabilities.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.ErrorCorrectingCapabilities"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorCorrectingCapabilities => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ErrorCorrectingCapabilities);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedInterleave: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interleave supported.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.SupportedInterleave"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedInterleave => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedInterleave);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentInterleave: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current interleave.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.CurrentInterleave"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentInterleave => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.CurrentInterleave);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumMemoryModuleSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Size of the largest memory module supported (per slot), specified as n, where 2**n is the maximum size in MB.
            /// The maximum amount of memory supported by this controller is that value times the number of slots, as specified in <see cref="NumberMemorySlots"/> property.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.MaximumMemoryModuleSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumMemoryModuleSize => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.MaximumMemoryModuleSize);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSpeeds: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with supported speeds.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.SupportedSpeeds"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.ns"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedSpeeds => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedSpeeds, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedMemoryTypes: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with supported memory types.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.SupportedMemoryTypes"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedMemoryTypes => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.SupportedMemoryTypes);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryModuleVoltages: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with memory module voltages.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.MemoryModuleVoltages"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryModuleVoltages => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.MemoryModuleVoltages, PropertyUnit.V);
            #endregion

            #region [public] {static} (IPropertyKey) NumberMemorySlots: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of memory slots.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.NumberMemorySlots"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberMemorySlots => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.NumberMemorySlots);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedMemoryModules: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contained memory modules reference.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.ContainedMemoryModules"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="MemoryControllerContainedElementCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedMemoryModules => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.ContainedMemoryModules, PropertyUnit.None);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) EnabledErrorCorrectingCapabilities: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the error-correcting capabilities that were enabled.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType005Property.EnabledErrorCorrectingCapabilities"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey EnabledErrorCorrectingCapabilities => new PropertyKey(SmbiosStructure.MemoryController, SmbiosType005Property.EnabledErrorCorrectingCapabilities);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryModule: Contains the key definitions available for a type 006, obsolete [Memory Module Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 006, obsolete [<see cref="SmbiosStructure.MemoryModule"/> Information] structure.
        /// </summary>
        public static class MemoryModule
        {
            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for reference designation.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.SocketDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) BankConnections: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates a bank (RAS#) connection.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.BankConnections"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BankConnections => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.BankConnections);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Speed of the memory module, in ns.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.CurrentSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.ns"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentSpeed => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.CurrentSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentMemoryType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the physical characteristics of the memory modules that are supported by (and currently installed in) the system.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.CurrentMemoryType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentMemoryType => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.CurrentMemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identify the size of the memory module that is installed in the socket, as determined by reading and correlating the module’s presence-detect information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.InstalledSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InstalledSize => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.InstalledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) EnabledSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the amount of memory currently enabled for the system’s use from the module.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.EnabledSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey EnabledSize => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.EnabledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies error status.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType006Property.ErrorStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorStatus => new PropertyKey(SmbiosStructure.MemoryModule, SmbiosType006Property.ErrorStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cache: Contains the key definitions available for a type 007 [Cache Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 007 [<see cref="SmbiosStructure.Cache"/> Information] structure.
        /// </summary>
        public static class Cache
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for reference designation.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.SocketDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumCacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum size that can be installed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.MaximumCacheSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumCacheSize => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.MaximumCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Installed size.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.InstalledCacheSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey InstalledCacheSize => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.InstalledCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSramTypes: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String collection with supported SRAM types.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.SupportedSramTypes"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedSramTypes => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SupportedSramTypes);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSramType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current SRAM type is installed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.SupportedSramTypes"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentSramType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CurrentSramType);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) CacheSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Cache module speed, in nanoseconds.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.CacheSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.ns"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheSpeed => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorCorrectionType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Error-correction scheme supported by this cache component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.ErrorCorrectionType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorCorrectionType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.ErrorCorrectionType);
            #endregion

            #region [public] {static} (IPropertyKey) SystemCacheType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Logical type of cache.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.SystemCacheType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SystemCacheType => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.SystemCacheType);
            #endregion

            #region [public] {static} (IPropertyKey) Associativity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Associativity of the cache.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.Associativity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Associativity => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.Associativity);
            #endregion

            #endregion

            #region version 3.1+

            #region [public] {static} (IPropertyKey) MaximumCacheSize2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>If is present, for cache sizes of 2047MB or smaller the value is equals to <see cref="MaximumCacheSize"/> property.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.MaximumCacheSize2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumCacheSize2 => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.MaximumCacheSize2, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>If is present, for cache sizes of 2047MB or smaller the value is equals to <see cref="InstalledCacheSize"/> property.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType007Property.InstalledCacheSize2"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey InstalledCacheSize2 => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.InstalledCacheSize2, PropertyUnit.KB);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) CacheConfiguration: Contains the key definition for the 'CacheConfiguration' section
            /// <summary>
            /// Contains the key definition for the <b>CacheConfiguration</b> section.
            /// </summary>
            public static class CacheConfiguration
            {
                #region [public] {static} (IPropertyKey) CacheEnabled: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is enabled/disabled (at boot time).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType007Property.CacheEnabled"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey CacheEnabled => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheEnabled);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLevel: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns cache level (1, 2, 3,...).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType007Property.CacheLevel"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Level => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheLevel);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLocation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Location, relative to the CPU module.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType007Property.CacheLocation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheLocation);
                #endregion

                #region [public] {static} (IPropertyKey) OperationalMode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cache operational mode (Write Through, Write Back, ...).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType007Property.OperationalMode"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey OperationalMode => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.OperationalMode);
                #endregion

                #region [public] {static} (IPropertyKey) CacheSocketed: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if cache is socketed.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.Cache"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType007Property.CacheSocketed"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.0+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey CacheSocketed => new PropertyKey(SmbiosStructure.Cache, SmbiosType007Property.CacheSocketed);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortConnector: Contains the key definitions available for a type 008 [Port Connector Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 008 [<see cref="SmbiosStructure.PortConnector"/> Information] structure.
        /// </summary>
        public static class PortConnector
        {
            #region [public] {static} (IPropertyKey) InternalReferenceDesignator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for Internal Reference Designator, that is, internal to the system enclosure.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType008Property.InternalReferenceDesignator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InternalReferenceDesignator => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.InternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) InternalConnectorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Internal Connector type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType008Property.InternalConnectorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InternalConnectorType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.InternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalReferenceDesignator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for the External Reference Designation external to the system enclosure.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType008Property.ExternalReferenceDesignator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExternalReferenceDesignator => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.ExternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalConnectorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>External Connector type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType008Property.ExternalConnectorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExternalConnectorType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.ExternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) PortType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the function of the port.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType008Property.PortType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PortType => new PropertyKey(SmbiosStructure.PortConnector, SmbiosType008Property.PortType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemSlots: Contains the key definitions available for a type 009 [System Slots] structure
        /// <summary>
        /// Contains the key definitions available for a type 009 [<see cref="SmbiosStructure.SystemSlots"/>] structure.
        /// </summary>
        public static class SystemSlots
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SlotDesignation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for reference designation.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotDesignation => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) SlotType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotType => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotType);
            #endregion

            #region [public] {static} (IPropertyKey) SlotDataBusWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot Data Bus Width.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotDataBusWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotDataBusWidth => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotDataBusWidth, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentUsage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot current usage.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.CurrentUsage"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentUsage => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.CurrentUsage);
            #endregion

            #region [public] {static} (IPropertyKey) SlotLength: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot length.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotLength"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotLength => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotLength);
            #endregion

            #region [public] {static} (IPropertyKey) SlotId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot Identifier.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotId => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotId);
            #endregion

            #endregion

            #region version 2.0+ - 2.1+

            #region [public] {static} (IPropertyKey) SlotCharacteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot characteristics.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotCharacteristics"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+, 2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotCharacteristics);
            #endregion

            #endregion

            #region version 2.6+

            #region [public] {static} (IPropertyKey) SegmentBusFunction: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Segment bus function.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SegmentBusFunction"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+ - 2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SegmentBusFunction => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SegmentBusFunction);
            #endregion

            #region [public] {static} (IPropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Bus device function.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.BusDeviceFunction"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.6+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BusDeviceFunction => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.BusDeviceFunction);
            #endregion

            #endregion

            #region version 3.2

            #region [public] {static} (IPropertyKey) PeerDevices: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The PCI Express Generation (e.g., PCI Express Generation 6).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.PeerDevices"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="PeerDevicesCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PeerDevices => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.PeerDevices);
            #endregion

            #endregion

            #region version 3.4

            #region [public] {static} (IPropertyKey) SlotInformation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The PCI Express Generation (e.g., PCI Express Generation 6).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotInformation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.4</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotInformation => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotInformation);
            #endregion

            #region [public] {static} (IPropertyKey) SlotPhysicalWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates the physical width of the slot whereas <see cref="SystemSlots.SlotDataBusWidth"/> property indicates the electrical width of the slot.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotPhysicalWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.4</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotPhysicalWidth => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotPhysicalWidth);
            #endregion

            #region [public] {static} (IPropertyKey) SlotPitch: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates the pitch of the slot in units of 1/100 millimeter. The pitch is defined by each slot/card specification, but typically describes add-in card to add-in card pitch.</para>
            /// <para>A value of 0 implies that the slot pitch is not given or is unknown.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotPitch"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.d_mm"/> <b>(1/100 mm)</b></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.4</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotPitch => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotPitch, PropertyUnit.d_mm);
            #endregion

            #endregion

            #region version 3.5

            #region [public] {static} (IPropertyKey) SlotHeight: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates the maximum supported card height for the slot.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType009Property.SlotHeight"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SlotHeight => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SlotHeight);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Peers: Contains the key definition for the 'Peers' section
            /// <summary>
            /// Contains the key definition for the <b>Peers</b> section.
            /// </summary>
            public static class Peers
            {
                #region [public] {static} (IPropertyKey) SegmentGroupNumber: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Segment Group Number is defined in the PCI Firmware Specification. The value is 0 for a single-segment topology.</para>
                /// <para>For PCI Express slots, Bus Number and Device/Function Number refer to the endpoint in the slot, not the upstream switch.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType009Property.SegmentGroupNumber"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>3.2</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SegmentGroupNumber => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.SegmentGroupNumber);
                #endregion

                #region [public] {static} (IPropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Bus device function (Peer).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType009Property.BusDeviceFunctionPeer"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>3.2</para>
                /// </para>
                /// </summary>
                public static IPropertyKey BusDeviceFunction => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.BusDeviceFunctionPeer);
                #endregion

                #region [public] {static} (IPropertyKey) DataBusWidth: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates electrical bus width of peer Segment/Bus/Device/Function.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType009Property.DataBusWidth"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>3.2</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataBusWidth => new PropertyKey(SmbiosStructure.SystemSlots, SmbiosType009Property.DataBusWidth);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 010, obsolete [On Board Devices Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 010, obsolete [<see cref="SmbiosStructure.OnBoardDevices"/> Information] structure.
        /// </summary>
        public static class OnBoardDevices
        {
            #region [public] {static} (IPropertyKey) Enabled: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device status.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType010Property.Enabled"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Enabled => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.Enabled);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType010Property.DeviceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceType => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.DeviceType);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of device description.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType010Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.OnBoardDevices, SmbiosType010Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 011 [OEM Strings] structure
        /// <summary>
        /// Contains the key definitions available for a type 011 [<see cref="SmbiosStructure.OemStrings"/>] structure.
        /// </summary>
        public static class OemStrings
        {
            #region [public] {static} (IPropertyKey) Values: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains free-form strings defined by the OEM.</para>
            /// <para>Examples of this are part numbers for system reference documents, contact information for the manufacturer, etc.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OemStrings"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType011Property.Values"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(SmbiosStructure.OemStrings, SmbiosType011Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemConfigurationOptions: Contains the key definitions available for a type 012 [System Configuration Options] structure
        /// <summary>
        /// Contains the key definitions available for a type 012 [<see cref="SmbiosStructure.SystemConfigurationOptions"/>] structure.
        /// </summary>
        public static class SystemConfigurationOptions
        {
            #region [public] {static} (IPropertyKey) Values: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains information required to configure the baseboard’s Jumpers and Switches.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemConfigurationOptions"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType012Property.Values"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(SmbiosStructure.SystemConfigurationOptions, SmbiosType012Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BiosLanguage: Contains the key definitions available for a type 013 [BIOS Language Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 013 [<see cref="SmbiosStructure.BiosLanguage"/> Information] structure.
        /// </summary>
        public static class BiosLanguage
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) InstallableLanguages: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of languages available. Each available language has a description string</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType013Property.InstallableLanguages"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey InstallableLanguages => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.InstallableLanguages);
            #endregion

            #region [public] {static} (IPropertyKey) Current: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Currently installed language.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType013Property.Current"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Current => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.Current);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) IsCurrentAbbreviated: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates if the abbreviated format is used.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType013Property.IsCurrentAbbreviated"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsCurrentAbbreviated => new PropertyKey(SmbiosStructure.BiosLanguage, SmbiosType013Property.IsCurrentAbbreviated);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) GroupAssociations: Contains the key definitions available for a type 014 [Group Associations] structure
        /// <summary>
        /// Contains the key definitions available for a type 014 [<see cref="SmbiosStructure.GroupAssociations"/>] structure.
        /// </summary>
        public static class GroupAssociations
        {
            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A collection of group association items.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.GroupAssociations"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType014Property.ContainedElements"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="GroupAssociationElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.ContainedElements);
            #endregion

            #region [public] {static} (IPropertyKey) GroupName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of string describing the group.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.GroupAssociations"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType014Property.GroupName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey GroupName => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.GroupName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Items: Contains the key definition for the 'Items' section
            /// <summary>
            /// Contains the key definition for the <b>Items</b> section.
            /// </summary>
            public static class Items  
            {
                #region [public] {static} (IPropertyKey) Handle: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Handle corresponding to a item collection.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.GroupAssociations"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType014Property.Handle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Structure: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Item (Structure) Type of this member.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.GroupAssociations"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType014Property.Structure"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="SmbiosStructure"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Structure => new PropertyKey(SmbiosStructure.GroupAssociations, SmbiosType014Property.Structure);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemEventLog: Contains the key definitions available for a type 015 [System Event Log] structure
        /// <summary>
        /// Contains the key definitions available for a type 015 [<see cref="SmbiosStructure.SystemEventLog"/>] structure.
        /// </summary>
        public static class SystemEventLog
        {
            #region [public] {static} (IPropertyKey) LogAreaLength: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The length, in bytes, of the overall event log area</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.LogAreaLength"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogAreaLength => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.LogAreaLength, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) LogHeaderStartOffset: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the starting offset (or index) within the nonvolatile storage of the event-log’s header from the Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.LogHeaderStartOffset"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogHeaderStartOffset => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.LogHeaderStartOffset);
            #endregion

            #region [public] {static} (IPropertyKey) DataStartOffset: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the starting offset (or index) within the nonvolatile storage of the event-log’s first data byte, from the Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.DataStartOffset"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DataStartOffset => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.DataStartOffset);
            #endregion

            #region [public] {static} (IPropertyKey) AccessMethod: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the Location and Method used by higher-level software to access the log area</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.AccessMethod"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AccessMethod => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.AccessMethod);
            #endregion

            #region [public] {static} (IPropertyKey) LogStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current status of the system event-log</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.LogStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogStatus => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.LogStatus);
            #endregion

            #region [public] {static} (IPropertyKey) AccessMethodAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.AccessMethodAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AccessMethodAddress => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.AccessMethodAddress);
            #endregion

            #region [public] {static} (IPropertyKey) LogChangeToken: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Unique token that is reassigned every time the event log changes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.LogChangeToken"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogChangeToken => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.LogChangeToken);
            #endregion

            #region [public] {static} (IPropertyKey) LogHeaderFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Unique token that is reassigned every time the event log changes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.LogHeaderFormat"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogHeaderFormat => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.LogHeaderFormat);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedLogTypeDescriptors: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of supported event log type descriptors.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.SupportedLogTypeDescriptors"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedLogTypeDescriptors => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.SupportedLogTypeDescriptors);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedLogTypeDescriptors: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>List of Event Log Type Descriptors.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType015Property.ListSupportedEventLogTypeDescriptors"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="SupportedEventLogTypeDescriptorsCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ListSupportedEventLogTypeDescriptors => new PropertyKey(SmbiosStructure.SystemEventLog, SmbiosType015Property.ListSupportedEventLogTypeDescriptors);
            #endregion
        }
        #endregion

        #region [public] {static} (class) PhysicalMemoryArray: Contains the key definitions available for a type 016 [Physical Memory Array] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="SmbiosStructure.PhysicalMemoryArray"/>] structure.
        /// </summary>
        public static class PhysicalMemoryArray
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical location of the Memory Array, whether on the system board or an add-in board.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.Location"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Use: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Function for which the array is used.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.Use"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Use => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.Use);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorCorrection: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Primary hardware error correction or detection method supported by this memory array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.MemoryErrorCorrection"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryErrorCorrection => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MemoryErrorCorrection);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum memory capacity, in kilobytes, for this array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.MaximumCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumCapacity => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MaximumCapacity, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with any error that was previously detected for the array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.MemoryErrorInformationHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfMemoryDevices: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of slots or sockets available for Memory devices in this array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.NumberOfMemoryDevices"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfMemoryDevices => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.NumberOfMemoryDevices);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ExtendedMaximumCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Extended maximum memory capacity, in kilobytes, for this array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType016Property.ExtendedMaximumCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedMaximumCapacity => new PropertyKey(SmbiosStructure.PhysicalMemoryArray, SmbiosType016Property.ExtendedMaximumCapacity, PropertyUnit.KB);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDevice: Contains the key definitions available for a type 017 [Memory Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 017 [<see cref="SmbiosStructure.MemoryDevice"/>] structure.
        /// </summary>
        public static class MemoryDevice
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) PhysicalMemoryArrayHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the physical memory array to which this device belongs.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.PhysicalMemoryArrayHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PhysicalMemoryArrayHandle => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.PhysicalMemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Handle, or instance number, associated with any error that was previously detected for the device.
            /// If the system does not provide the error information structure, the field contains FFFEh; otherwise, the
            /// field contains either FFFFh(if no error was detected).
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemoryErrorInformationHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) TotalWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Total width, in bits, of this memory device, including any check or error-correction bits.
            /// If there are no error-correction bits, this value should be equal to Data Width.If the width is unknown, the field is set to FFFFh
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.TotalWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey TotalWidth => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.TotalWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) DataWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Data width, in bits, of this memory device A data width of 0 and a total width of 8 indicates that the device is being
            /// used solely to provide 8 error-correction bits.
            /// If there are no error-correction bits, this value should be equal to Data Width.If the width is unknown, the field is set to FFFFh.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.DataWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DataWidth => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DataWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) Size: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Size of the memory device.
            /// If the value is 0, no memory device is installed in the socket;
            /// if the size is unknown, the field value is FFFFh.
            /// If the size is 32 GB-1 MB or greater, the field value is 7FFFh and the actual size is stored in the Extended Size field.
            /// The granularity in which the value is specified depends on the setting of the most-significant bit (bit 15).
            /// If the bit is 0, the value is specified in megabyte units; if the bit is 1, the value is specified in kilobyte units.
            /// For example, the value 8100h identifies a 256 KB memory device and 0100h identifies a 256 MB memory device.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.Size"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Size => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Size, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) FormFactor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Implementation form factor for this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.FormFactor"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FormFactor => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.FormFactor);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceSet: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Identifies when the Memory Device is one of a set of Memory Devices that must be populated with all
            /// devices of the same type and size, and the set to which this device belongs.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.DeviceSet"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceSet => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DeviceSet);
            #endregion

            #region [public] {static} (IPropertyKey) BankLocator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number of the string that identifies the physically labeled bank where the memory device is located.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.BankLocator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BankLocator => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.BankLocator);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceLocator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number of the string that identifies the physically-labeled socket or board position where the memory device is located.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.DeviceLocator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceLocator => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.DeviceLocator);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Type of memory used in this device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemoryType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryType => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) TypeDetail: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Additional detail on the memory device type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.TypeDetail"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey TypeDetail => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.TypeDetail);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) Speed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Identifies the maximum capable speed of the device, in megatransfers per second(MT/s).
            /// 0000h = the speed is unknown.
            /// FFFFh = the speed is 65,535 MT/s or greater, and the actual speed is stored in the <see cref="ExtendedSpeed"/> property.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.Speed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MTs"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Speed => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Speed, PropertyUnit.MTs);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the manufacturer of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the serial number of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the asset tag of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.AssetTag"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the part number of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.PartNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PartNumber => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.PartNumber);
            #endregion

            #endregion

            #region version 2.6+

            #region [public] {static} (IPropertyKey) Rank: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Rank.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.Rank"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Rank => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Rank);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ExtendedSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Extended size of the memory device (complements the <see cref="Size"/> property).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ExtendedSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.Size, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) ConfiguredMemoryClockSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Memory speed is expressed in megatransfers per second (MT/s). Previous revisions (3.0.0 and earlier) of this
            /// specification used MHz to indicate clock speed.With double data rate memory, clock speed is distinct
            /// from transfer rate, since data is transferred on both the rising and the falling edges of the clock signal.
            /// This maintains backward compatibility with observed DDR implementations prior to this revision, which
            /// already reported transfer rate instead of clock speed, e.g., DDR4-2133 (PC4-17000) memory was
            /// reported as 2133 instead of 1066.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ConfiguredMemoryClockSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Variable"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ConfiguredMemoryClockSpeed => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ConfiguredMemoryClockSpeed, PropertyUnit.Variable);
            #endregion

            #endregion

            #region version 2.8+

            #region [public] {static} (IPropertyKey) MinimumVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Minimum operating voltage for this device, in millivolts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MinimumVoltage"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.8+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumVoltage => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MinimumVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum operating voltage for this device, in millivolts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MaximumVoltage"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.8+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumVoltage => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MaximumVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) ConfiguredVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Configured voltage for this device, in millivolts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ConfiguredVoltage"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.8+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ConfiguredVoltage => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ConfiguredVoltage, PropertyUnit.mV);
            #endregion

            #endregion

            #region version 3.2+

            #region [public] {static} (IPropertyKey) MemoryTechnology: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Memory technology type for this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemoryTechnology"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryTechnology => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryTechnology);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryOperatingModeCapability: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The operating modes supported by this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemoryOperatingModeCapability"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryOperatingModeCapability => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemoryOperatingModeCapability);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for the firmware version of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.FirmwareVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleManufacturerId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte module manufacturer ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ModuleManufacturerId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ModuleManufacturerId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ModuleManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleProductId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte module product ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ModuleProductId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ModuleProductId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ModuleProductId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerManufacturerId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte memory subsystem controller manufacturer ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemorySubSystemControllerManufacturerId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemorySubsystemControllerManufacturerId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemorySubSystemControllerManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerProductId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte memory subsystem controller product ID found in the SPD of this memory device; LSB first.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.MemorySubSystemControllerProductId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemorySubsystemControllerProductId => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.MemorySubSystemControllerProductId);
            #endregion

            #region [public] {static} (IPropertyKey) NonVolatileSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Non-volatile portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.NonVolatileSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NonVolatileSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.NonVolatileSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) VolatileSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the volatile portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.VolatileSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey VolatileSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.VolatileSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) CacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Cache portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.CacheSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CacheSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.CacheSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) LogicalSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Logical memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.LogicalSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogicalSize => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.LogicalSize, PropertyUnit.Bytes);
            #endregion

            #endregion

            #region version 3.3+

            #region [public] {static} (IPropertyKey) ExtendedSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Extended speed of the memory device. Identifies the maximum capable speed of the device, in megatransfers per second (MT/s).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ExtendedSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MTs"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedSpeed => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ExtendedSpeed, PropertyUnit.MTs);
            #endregion

            #region [public] {static} (IPropertyKey) ExtendedConfiguredMemorySpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Extended configured memory speed of the memory device. Identifies the configured speed of the memory device, in megatransfers per second (MT/s).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType017Property.ExtendedConfiguredMemorySpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MTs"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedConfiguredMemorySpeed => new PropertyKey(SmbiosStructure.MemoryDevice, SmbiosType017Property.ExtendedConfiguredMemorySpeed, PropertyUnit.MTs);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError32: Contains the key definitions available for a type 018 [32-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 018 [<see cref="SmbiosStructure.BitMemoryError32"/> Information] structure.
        /// </summary>
        public static class BitMemoryError32
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) ErrorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of error that is associated with the current status reported for the memory array or device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.ErrorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorType => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Granularity (for example, device versus Partition) to which the error can be resolved.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.ErrorGranularity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorGranularity => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Memory access operation that caused the error.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.ErrorOperation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorOperation => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Vendor-specific ECC syndrome or CRC data associated with the erroneous access.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.VendorSyndrome"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorSyndrome => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error based on the addressing of the bus to which the memory array is connected.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.MemoryArrayErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryArrayErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error relative to the start of the failing memory device, in bytes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.DeviceErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.DeviceErrorAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Range, in bytes, within which the error can be determined, when an error address is given</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType018Property.ErrorResolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorResolution => new PropertyKey(SmbiosStructure.BitMemoryError32, SmbiosType018Property.ErrorResolution, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 019 [Memory Array Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 019 [<see cref="SmbiosStructure.MemoryArrayMappedAddress"/>] structure.
        /// </summary>
        public static class MemoryArrayMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) StartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical address, of a range of memory mapped to the specified physical memory array When the field value is FFFF FFFFh,
            /// the actual address is stored in the <see cref="ExtendedStartingAddress"/> property.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.StartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey StartingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.StartingAddress, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) EndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para> Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical ending address of the last kilobyte of a range of addresses mapped to the specified physical memory array When the field value is FFFF FFFFh
            /// and the <see cref="StartingAddress"/> property also contains FFFF FFFFh, the actual address is stored in the <see cref="ExtendedEndingAddress"/> property.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.EndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey EndingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.EndingAddress, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para> Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Handle, or instance number, associated with the physical memory array to which this address range is mapped
            /// multiple address ranges can be mapped to a single physical memory array.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.MemoryArrayHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryArrayHandle => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.MemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) PartitionWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para> Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of memory devices that form a single row of memory for the address partition defined by this structure.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.PartitionWidth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PartitionWidth => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.PartitionWidth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ExtendedStartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical address, in bytes, of a range of memory mapped to the specified physical memory array this property is valid when
            /// <see cref="StartingAddress"/> contains the value FFFF FFFFh. If <see cref="StartingAddress"/> contains a value other than FFFF FFFFh,
            /// this field contains zeros.When this field contains a valid address, <see cref="ExtendedEndingAddress"/> must also contain a valid address.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.ExtendedStartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedStartingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.ExtendedStartingAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) ExtendedEndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical ending address, in bytes, of the last of a range of addresses mapped to the specified physical memory array this property
            /// is valid when both <see cref="StartingAddress"/> and <see cref="EndingAddress"/> contain the value FFFF FFFFh. If <see cref="EndingAddress"/>
            /// contains a value other than FFFF FFFFh, this property contains zeros. When this property contains a valid address, <see cref="ExtendedEndingAddress"/>
            /// must also contain a valid address.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType019Property.ExtendedEndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedEndingAddress => new PropertyKey(SmbiosStructure.MemoryArrayMappedAddress, SmbiosType019Property.ExtendedEndingAddress, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 020 [Memory Device Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 020 [<see cref="SmbiosStructure.MemoryDeviceMappedAddress"/>] structure.
        /// </summary>
        public static class MemoryDeviceMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) StartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical address, in kilobytes, of a range of memory mapped to the referenced memory device When the property value is FFFF FFFFh the actual
            /// address is stored in the <see cref="ExtendedStartingAddress"/> property. When this property contains a valid address, <see cref="EndingAddress"/> must also contain a
            /// valid address. When this property contains FFFF FFFFh, <see cref="EndingAddress"/> must also contain FFFF FFFFh.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.StartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey StartingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.StartingAddress);
            #endregion

            #region [public] {static} (IPropertyKey) EndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical ending address of the last kilobyte of a range of addresses mapped to the referenced memory device When the field value is FFFF FFFFh the actual
            /// address is stored in the <see cref="ExtendedEndingAddress"/> field. When this property contains a valid address,<see cref="StartingAddress"/> must also contain a valid address.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.EndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey EndingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.EndingAddress);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryDeviceHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Handle, or instance number, associated with the memory device structure to which this address range is mapped multiple address
            /// ranges can be mapped to a single memory device.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.MemoryDeviceHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryDeviceHandle => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.MemoryDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayMappedAddressHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Handle, or instance number, associated with the memory array mapped Address structure to which this device address range is mapped
            /// multiple address ranges can be mapped to a single Memory array mapped address.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.MemoryArrayMappedAddressHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryArrayMappedAddressHandle => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.MemoryArrayMappedAddressHandle);
            #endregion

            #region [public] {static} (IPropertyKey) PartitionRowPosition: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Position of the referenced Memory Device in a row of the address partition.
            /// The value 0 is reserved. If the position is unknown, the field contains FFh.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.PartitionRowPosition"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PartitionRowPosition => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.PartitionRowPosition);
            #endregion

            #region [public] {static} (IPropertyKey) InterleavePosition: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Position of the referenced Memory Device in an interleave.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.InterleavePosition"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="MemoryDeviceMappedAddressInterleavedPosition"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterleavePosition => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.InterleavePosition);
            #endregion

            #region [public] {static} (IPropertyKey) InterleavedDataDepth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum number of consecutive rows from the referenced Memory Device that are accessed in a single interleaved transfer.
            /// If the device is not part of an interleave, the field contains 0; if the interleave configuration is unknown, the value is FFh.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.InterleavedDataDepth"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterleavedDataDepth => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.InterleavedDataDepth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ExtendedStartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical address, in bytes, of a range of memory mapped to the referenced memory device this property is valid when <see cref="StartingAddress"/> contains
            /// the value FFFF FFFFh. If <see cref="StartingAddress"/> contains a value other than FFFF FFFFh, this property contains zeros. When this property contains a valid
            /// address, <see cref="ExtendedEndingAddress"/> must also contain a valid address.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.ExtendedStartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedStartingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.ExtendedStartingAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) ExtendedEndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Physical ending address, in bytes, of the last of a range of addresses mapped to the referenced memory device this property is valid when both
            /// <see cref="StartingAddress"/> and <see cref="EndingAddress"/> contain the value FFFF FFFFh. If <see cref="EndingAddress"/> contains a value other
            /// than FFFF FFFFh, this property contains zeros. When this property contains a valid address, <see cref="ExtendedStartingAddress"/> must also contain a valid address.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType020Property.ExtendedEndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExtendedEndingAddress => new PropertyKey(SmbiosStructure.MemoryDeviceMappedAddress, SmbiosType020Property.ExtendedEndingAddress, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BuiltInPointingDevice: Contains the key definitions available for a type 021 [Built-in Pointing Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 021 [<see cref="SmbiosStructure.BuiltInPointingDevice"/>] structure.
        /// </summary>
        public static class BuiltInPointingDevice
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) Type: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of pointing device.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType021Property.Type"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Type => new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Interface: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interface type for the pointing device.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType021Property.Interface"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Interface => new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.Interface);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfButtons: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of buttons on the pointing device.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType021Property.NumberOfButtons"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfButtons => new PropertyKey(SmbiosStructure.BuiltInPointingDevice, SmbiosType021Property.NumberOfButtons);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortableBattery: Contains the key definitions available for a type 022 [Portable Battery] structure
        /// <summary>
        /// Contains the key definitions available for a type 022 [<see cref="SmbiosStructure.PortableBattery"/>] structure.
        /// </summary>
        public static class PortableBattery
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of the string that identifies the location of the battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.Location"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of the string that names the company that manufactured the battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Battery name.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.DeviceName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceName => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) DesignVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Design voltage of the battery in mVolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.DesignVoltage"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DesignVoltage => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) SBDSVersionNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The Smart Battery Data Specification version number supported by this battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.SbdsVersionNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SBDSVersionNumber => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SbdsVersionNumber);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunErrorInBatteryData: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum error (as a percentage in the range 0 to 100) in the Watt-hour data reported by the battery, indicating an upper bound on how much
            /// additional energy the battery might have above the energy it reports having.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.MaximunErrorInBatteryData"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximunErrorInBatteryData => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.MaximunErrorInBatteryData);
            #endregion

            #region [public] {static} (IPropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The date on which the battery was manufactured. Version 2.2+ implementations that use a Smart Battery set this property to empty string to indicate
            /// that the <b>SBDS Manufacture Date</b>.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.ManufactureDate"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ManufactureDate => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.ManufactureDate);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// The serial number for the battery. Version 2.2+ implementations that use a Smart Battery set this property to empty string to indicate
            /// that the <b>SBDS Serial Number</b> (<see cref="SBDSVersionNumber"/>) property contains the information.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceChemistry: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Identifies the battery chemistry. Version 2.2+ implementations that use a Smart Battery set this property to empty string to indicate
            /// that the <b>SBDS Device Chemistry</b>.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.DeviceChemistry"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceChemistry => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DeviceChemistry);
            #endregion

            #region [public] {static} (IPropertyKey) DesignCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Design capacity of the battery in mWatt-hours. For version 2.2+ implementations, this value is multiplied by the
            /// <b>Design Capacity Multiplier</b> (<see cref="DesignCapacityMultiplier"/>) property to produce the actual value.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.DesignCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mWh"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DesignCapacity => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignCapacity, PropertyUnit.mWh);
            #endregion

            #endregion

            #region version 2.2+

            #region [public] {static} (IPropertyKey) DesignCapacityMultiplier: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Multiplication factor of the Design Capacity value, which assures that the mWatt hours value
            /// does not overflow for <b>SBDS</b> implementations. The multiplier default is 1.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.DesignCapacityMultiplier"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey DesignCapacityMultiplier => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.DesignCapacityMultiplier);
            #endregion

            #region [public] {static} (IPropertyKey) OemSpecific: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType022Property.OemSpecific"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemSpecific => new PropertyKey(SmbiosStructure.PortableBattery, SmbiosType022Property.OemSpecific);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemReset: Contains the key definitions available for a type 023 [System Reset] structure
        /// <summary>
        /// Contains the key definitions available for a type 023 [<see cref="SmbiosStructure.SystemReset"/>] structure.
        /// </summary>
        public static class SystemReset
        {
            #region [public] {static} (IPropertyKey) ResetCount: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of automatic system resets since the last intentional reset.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType023Property.ResetCount"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ResetCount => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.ResetCount);
            #endregion

            #region [public] {static} (IPropertyKey) ResetLimit: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of consecutive times the system reset is attempted.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType023Property.ResetLimit"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ResetLimit => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.ResetLimit);
            #endregion

            #region [public] {static} (IPropertyKey) TimerInterval: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of minutes to use for the watchdog timer If the timer is not reset within this interval, the system reset timeout begins.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType023Property.TimerInterval"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey TimerInterval => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.TimerInterval);
            #endregion

            #region [public] {static} (IPropertyKey) Timeout: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Number of minutes before the reboot is initiated. It is used after a system power cycle, system reset (local or remote),
            /// and automatic system reset
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType023Property.Timeout"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Timeout => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.Timeout);
            #endregion


            #region nested classes

            #region [public] {static} (class) Capabilities: Contains the key definition for the 'Capabilities' section.
            /// <summary>
            /// Contains the key definition for the <b>Capabilities</b> section.
            /// </summary>
            public static class Capabilities
            {
                #region [public] {static} (IPropertyKey) BootOption: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns the action to be taken after a watchdog restart.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType023Property.BootOption"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BootOption =>  new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.BootOption);
                #endregion

                #region [public] {static} (IPropertyKey) BootOptionOnLimit: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns to the action that will be taken when the restart limit is reached.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType023Property.BootOptionOnLimit"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BootOptionOnLimit => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.BootOptionOnLimit);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Identifies whether (enabled) or not (disabled) the system reset by the user.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType023Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) WatchdogTimer: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whether the system contains a watchdog timer.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType023Property.WatchdogTimer"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey WatchdogTimer => new PropertyKey(SmbiosStructure.SystemReset, SmbiosType023Property.WatchdogTimer);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 024 [Hardware Security] structure
        /// <summary>
        /// Contains the key definitions available for a type 024 [<see cref="SmbiosStructure.HardwareSecurity"/>] structure.
        /// </summary>
        public static class HardwareSecurity
        {
            #region nested classes

            #region [public] {static} (class) HardwareSecuritySettings: Contains the key definition for the 'HardwareSecuritySettings' section
            /// <summary>
            /// Contains the key definition for the <b>HardwareSecuritySettings</b> section.
            /// </summary>
            public static class HardwareSecuritySettings
            {
                #region [public] {static} (IPropertyKey) AdministratorPasswordStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current administrator password status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType024Property.AdministratorPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey AdministratorPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.AdministratorPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) FrontPanelResetStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current front panel reset status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType024Property.FrontPanelResetStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrontPanelResetStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.FrontPanelResetStatus);
                #endregion

                #region [public] {static} (IPropertyKey) KeyboardPasswordStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current keyboard password status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType024Property.KeyboardPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey KeyboardPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.KeyboardPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) PowerOnPasswordStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current power on password status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType024Property.PowerOnPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PowerOnPasswordStatus => new PropertyKey(SmbiosStructure.HardwareSecurity, SmbiosType024Property.PowerOnPasswordStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 025 [System Power Controls] structure
        /// <summary>
        /// Contains the key definitions available for a type 025 [<see cref="SmbiosStructure.SystemPowerControls"/>] structure.
        /// </summary>
        public static class SystemPowerControls
        {
            #region [public] {static} (IPropertyKey) Month: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the month on which the next scheduled power-on is to occur, in the range 01h to 12h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType025Property.Month"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Month => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Month);
            #endregion

            #region [public] {static} (IPropertyKey) Day: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the day-of-month on which the next scheduled power-on is to occur, in the range 01h to 31h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType025Property.Day"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Day => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Day);
            #endregion

            #region [public] {static} (IPropertyKey) Hour: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the hour on which the next scheduled poweron is to occur, in the range 00h to 23h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType025Property.Hour"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Hour => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Hour);
            #endregion

            #region [public] {static} (IPropertyKey) Minute: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the minute on which the next scheduled power-on is to occur, in the range 00h to 59h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType025Property.Minute"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Minute => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Minute);
            #endregion

            #region [public] {static} (IPropertyKey) Second: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the second on which the next scheduled power-on is to occur, in the range 00h to 59h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType025Property.Second"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Second => new PropertyKey(SmbiosStructure.SystemPowerControls, SmbiosType025Property.Second);
            #endregion
        }
        #endregion

        #region [public] {static} (class) VoltageProbe: Contains the key definitions available for a type 026 [Voltage Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 026 [<see cref="SmbiosStructure.VoltageProbe"/>] structure.
        /// </summary>
        public static class VoltageProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the probe or its location.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum voltage level readable by this probe, in millivolts.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.MaximumValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Minimum voltage level readable by this probe, in millivolts.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.MinimumValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Resolution for the probe’s reading, in tenths of millivolts.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.d_mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Resolution, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Tolerance for reading from this probe, in plus/minus millivolts.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Tolerance, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Accuracy for reading from this probe, in plus/minus 1/100th of a percent.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Nominal value for the probe’s reading in millivolts.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType026Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.NominalValue, PropertyUnit.mV);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical location of the voltage monitored by this voltage probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType026Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the voltage monitored by this voltage probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.VoltageProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType026Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.VoltageProbe, SmbiosType026Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) CoolingDevice: Contains the key definitions available for a type 027 [Cooling Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 027 [<see cref="SmbiosStructure.CoolingDevice"/>] structure.
        /// </summary>
        public static class CoolingDevice
        {
            #region version 2.2+

            #region [public] {static} (IPropertyKey) TemperatureProbeHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the temperature probe monitoring this cooling device</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType027Property.TemperatureProbeHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey TemperatureProbeHandle => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.TemperatureProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingUnitGroup: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Cooling unit group to which this cooling device is associated.
            /// Having multiple cooling devices in the same cooling unit implies a redundant configuration.
            /// The value is 00h if the cooling device is not a member of a redundant cooling unit.Non-zero values imply
            /// redundancy and that at least one other cooling device will be enumerated with the same value.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType027Property.CoolingUnitGroup"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoolingUnitGroup => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.CoolingUnitGroup);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information,</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType027Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Nominal value for the cooling device’s rotational speed, in revolutions-per-minute (rpm).
            /// If the value is unknown or the cooling device is non-rotating, the field is set to 0x8000.
            /// This field is present in the structure only if the structure’s length is larger than 0Ch.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType027Property.NominalSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.RPM"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalSpeed => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.NominalSpeed, PropertyUnit.RPM);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Contains additional descriptive information about the cooling device or its location.
            /// Is present in the structure only if the structure’s length is 0Fh or larger.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType027Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.Description);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) DeviceTypeAndStatus: Contains the key definition for the 'Device Type And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Device Type And Status</b> section.
            /// </summary>
            public static class DeviceTypeAndStatus
            {
                #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cooling device type.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType027Property.DeviceType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.7+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cooling device status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.CoolingDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType027Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.7+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.CoolingDevice, SmbiosType027Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TemperatureProbe: Contains the key definitions available for a type 028 [Temperature Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 028 [<see cref="SmbiosStructure.TemperatureProbe"/>] structure.
        /// </summary>
        public static class TemperatureProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the probe or its location.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum temperature readable by this probe, in 1/10th ºC.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.MaximumValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Minimum temperature readable by this probe, in 1/10th ºC.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.MinimumValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Resolution for the probe’s reading, in 1/1000th ºC.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Resolution, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Tolerance for reading from this probe, in plus/minus 1/10th ºC.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.Tolerance"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Tolerance, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Accuracy for reading from this probe, in plus/minus 1/100th of a percent.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Nominal value for the probe’s reading in 1/10th degrees ºC.
            /// If the value is unknown, the field is set to 0x8000.
            /// Is present only if the structure’s Length is larger than 14h.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType028Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.NominalValue, PropertyUnit.DegreeCentigrade);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical location of the temperature monitored by this temperature probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType028Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the temperature monitored by this temperature probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.TemperatureProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType028Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType028Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ElectricalCurrentProbe: Contains the key definitions available for a type 029 [Electrical Current Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 029 [<see cref="SmbiosStructure.ElectricalCurrentProbe"/>] structure.
        /// </summary>
        public static class ElectricalCurrentProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the probe or its location.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Maximum current readable by this probe, in milliamps.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.MaximumValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Minimun current readable by this probe, in milliamps.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.MinimumValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Resolution for the probe’s reading, in tenths of milliamps.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Resolution, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Tolerance for reading from this probe, in plus/minus milliamps.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.Tolerance"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(SmbiosStructure.TemperatureProbe, SmbiosType029Property.Tolerance, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Accuracy for reading from this probe, in plus/minus 1/100th of a percent.
            /// If the value is unknown, the field is set to 0x8000.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Nominal value for the probe’s reading in milliamps.
            /// If the value is unknown, the field is set to 0x8000.
            /// Is present only if the structure’s Length is larger than 14h.
            /// </para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType029Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.NominalValue, PropertyUnit.mA);
            #endregion


            #region nested classes

            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical location of the current monitored by this current probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType029Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the current monitored by this current probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.ElectricalCurrentProbe"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType029Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.ElectricalCurrentProbe, SmbiosType029Property.Status);
                #endregion
            }
            #endregion

            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OutOfBandRemote: Contains the key definitions available for a type 030 [Out-of-Band Remote Access] structure
        /// <summary>
        /// Contains the key definitions available for a type 030 [<see cref="SmbiosStructure.OutOfBandRemote"/>] structure.
        /// </summary>
        public static class OutOfBandRemote
        {
            #region [public] {static} (IPropertyKey) ManufacturerName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the manufacturer of the out-of-band access facility.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OutOfBandRemote"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType030Property.ManufacturerName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.ManufacturerName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Connections: Contains the key definition for the 'Connections And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Connections And Status</b> section.
            /// </summary>
            public static class Connections
            {
                #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whether is allowed to initiate outbound connections to contact an alert management facility when critical conditions occur.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.OutOfBandRemote"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType030Property.OutBoundConnection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey OutBoundConnection => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.OutBoundConnection);
                #endregion

                #region [public] {static} (IPropertyKey) InBoundConnection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whether is allowed to initiate outbound connections to receive incoming connections for the purpose of remote operations or problem management.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.OutOfBandRemote"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType030Property.InBoundConnection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey InBoundConnection => new PropertyKey(SmbiosStructure.OutOfBandRemote, SmbiosType030Property.InBoundConnection);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BootIntegrityServicesEntryPoint: Contains the key definitions available for a type 031 [Boot Integrity Services (BIS) Entry Point] structure
        /// <summary>
        /// Contains the key definitions available for a type 031 [<see cref="SmbiosStructure.BootIntegrityServicesEntryPoint"/>] structure.
        /// </summary>
        public static class BootIntegrityServicesEntryPoint
        {
            #region [public] {static} (IPropertyKey) Checksum: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Checksum.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType031Property.Checksum"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Checksum => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.Checksum);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress16: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Entry point address bis 16bits.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType031Property.BisEntryPointAddress16"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress16 => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.BisEntryPointAddress16);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress32: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Entry point address bis 32bits.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType031Property.BisEntryPointAddress32"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress32 => new PropertyKey(SmbiosStructure.BootIntegrityServicesEntryPoint, SmbiosType031Property.BisEntryPointAddress32);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemBoot: Contains the key definitions available for a type 032 [System Boot Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 032 [<see cref="SmbiosStructure.SystemBoot"/> Information] structure.
        /// </summary>
        public static class SystemBoot
        {
            #region [public] {static} (IPropertyKey) Reserved: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Reserved for future assignment by this specification; all bytes are set to 00h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemBoot"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType032Property.Reserved"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Reserved => new PropertyKey(SmbiosStructure.SystemBoot, SmbiosType032Property.Reserved);
            #endregion

            #region [public] {static} (IPropertyKey) BootStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Status and additional data fields that identify the boot status.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemBoot"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType032Property.BootStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BootStatus => new PropertyKey(SmbiosStructure.SystemBoot, SmbiosType032Property.BootStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError64: Contains the key definitions available for a type 033 [64-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 033 [<see cref="SmbiosStructure.BitMemoryError64"/>] structure.
        /// </summary>
        public static class BitMemoryError64
        {
            #region [public] {static} (IPropertyKey) ErrorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of error that is associated with the current status reported for the memory array or device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.ErrorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorType => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Granularity (for example, device versus Partition) to which the error can be resolved.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.ErrorGranularity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorGranularity => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Memory access operation that caused the error.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.ErrorOperation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorOperation => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Vendor-specific ECC syndrome or CRC data associated with the erroneous access.
            /// If the value is unknown, this field contains 0000 0000h.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.VendorSyndrome"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorSyndrome => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// 64-bit physical address of the error based on the addressing of the bus to which the memory array is connected.
            /// If the address is unknown, this field contains 8000 0000 0000 0000h.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.MemoryArrayErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryArrayErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// 64-bit physical address of the error relative to the start of the failing memory device, in bytes.
            /// If the address is unknown, this field contains 8000 0000 0000 0000h.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.DeviceErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Range, in bytes, within which the error can be determined, when an error address is given.
            /// If the range is unknown, this field contains 8000 0000h.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType033Property.ErrorResolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorResolution => new PropertyKey(SmbiosStructure.BitMemoryError64, SmbiosType033Property.ErrorResolution);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDevice: Contains the key definitions available for a type 034 [Management Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 034 [<see cref="SmbiosStructure.ManagementDevice"/>] structure.
        /// </summary>
        public static class ManagementDevice
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the device or its location.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType034Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Type: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device’s type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType034Property.Type"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Type => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Address: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device’s address.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType034Property.Address"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Address => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.Address);
            #endregion

            #region [public] {static} (IPropertyKey) AddressType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of addressing used to access the device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType034Property.AddressType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AddressType => new PropertyKey(SmbiosStructure.ManagementDevice, SmbiosType034Property.AddressType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceComponent: Contains the key definitions available for a type 035 [Management Device Component] structure
        /// <summary>
        /// Contains the key definitions available for a type 035 [<see cref="SmbiosStructure.ManagementDeviceComponent"/>] structure.
        /// </summary>
        public static class ManagementDeviceComponent
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType035Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) ManagementDeviceHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the Management Device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType035Property.ManagementDeviceHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ManagementDeviceHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ManagementDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ComponentHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the probe or cooling device that defines this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType035Property.ComponentHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ComponentHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ComponentHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ThresholdHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Contains additional descriptive information about the component.
            /// A value of 0FFFFh indicates that no Threshold Data structure is associated with this component.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType035Property.ThresholdHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThresholdHandle => new PropertyKey(SmbiosStructure.ManagementDeviceComponent, SmbiosType035Property.ThresholdHandle);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceThresholdData: Contains the key definitions available for a type 036 [Management Device Threshold Data] structure
        /// <summary>
        /// Contains the key definitions available for a type 036 [<see cref="SmbiosStructure.ManagementDeviceThresholdData"/>] structure.
        /// </summary>
        public static class ManagementDeviceThresholdData
        {
            #region [public] {static} (IPropertyKey) LowerNonCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Lower non-critical threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.LowerNonCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerNonCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Upper non-critical threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.UpperNonCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperNonCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Lower critical threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.LowerCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Upper critical threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.UpperCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperCritical => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerNonRecoverable: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Lower non-recoverable threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.LowerNonRecoverable"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerNonRecoverable => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.LowerNonRecoverable);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonRecoverable: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Upper non-recoverable threshold for this component.
            /// If the value is unavailable, the field is set to 0x8000
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType036Property.UpperNonRecoverable"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperNonRecoverable => new PropertyKey(SmbiosStructure.ManagementDeviceThresholdData, SmbiosType036Property.UpperNonRecoverable);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryChannel: Contains the key definitions available for a type 037 [Memory Channel] structure
        /// <summary>
        /// Contains the key definitions available for a type 037 [<see cref="SmbiosStructure.MemoryChannel"/>] structure.
        /// </summary>
        public static class MemoryChannel
        {
            #region [public] {static} (IPropertyKey) ChannelType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of memory associated with the channel.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType037Property.ChannelType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ChannelType => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.ChannelType);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumChannelLoad: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum load supported by the channel; the sum of all device loads cannot exceed this value.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType037Property.MaximumChannelLoad"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumChannelLoad => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.MaximumChannelLoad);
            #endregion

            #region [public] {static} (IPropertyKey) Devices: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Devices collection.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType037Property.Devices"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="MemoryChannelElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Devices => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Devices);
            #endregion


            #region nested classes

            #region [public] {static} (class) MemoryDevices: Contains the key definition for the 'Memory Devices' section
            /// <summary>
            /// Contains the key definition for the <b>Memory Devices</b> section.
            /// </summary>
            public static class MemoryDevices
            {
                #region [public] {static} (IPropertyKey) Handle: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Structure handle that identifies the memory device associated with this channel.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryChannel"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType037Property.Handle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Load: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Channel load provided by the memory device associated with this channel.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.MemoryChannel"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType037Property.Load"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Load => new PropertyKey(SmbiosStructure.MemoryChannel, SmbiosType037Property.Load);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) IpmiDevice: Contains the key definitions available for a type 038 [IPMI Device Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 038 [<see cref="SmbiosStructure.IpmiDevice"/> Information] structure.
        /// </summary>
        public static class IpmiDevice
        {
            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Baseboard Management Controller (BMC) interface type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.InterfaceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) SpecificationRevision: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>IPMI specification revision, in BCD format, to which the BMC was designed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.SpecificationRevision"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SpecificationRevision => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.SpecificationRevision);
            #endregion

            #region [public] {static} (IPropertyKey) I2CSlaveAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slave address on the I2C bus of this BMC.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.I2CSlaveAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey I2CSlaveAddress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.I2CSlaveAddress);
            #endregion

            #region [public] {static} (IPropertyKey) NVStorageDeviceAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Bus ID of the NV storage device. If no storage device exists for this BMC, the property is set to 0xFF.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.NvStorageDeviceAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NVStorageDeviceAddress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.NvStorageDeviceAddress);
            #endregion

            #region [public] {static} (IPropertyKey) BaseAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Base address (either memory-mapped or I/O) of the BMC. If the least-significant bit of the field is a 1,
            /// the address is in I/O space; otherwise, the address is memory-mapped.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.BaseAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BaseAddress => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.BaseAddress);
            #endregion

            #region [public] {static} (IPropertyKey) InterruptNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interrupt number for IPMI System Interface.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType038Property.InterruptNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterruptNumber => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.InterruptNumber);
            #endregion


            #region nested classes

            #region [public] {static} (class) BaseAdressModifier: Contains the key definition for the 'Base Adress Modifier' section
            /// <summary>
            /// Contains the key definition for the <b>Base Adress Modifier</b> section.
            /// </summary>
            public static class BaseAdressModifier
            {
                #region [public] {static} (IPropertyKey) RegisterSpacing: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Register spacing.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType038Property.RegisterSpacing"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey RegisterSpacing => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.RegisterSpacing);
                #endregion

                #region [public] {static} (IPropertyKey) LsBit: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>LS-bit for addresses.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType038Property.LsBit"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey LsBit => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.LsBit);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Interrupt: Definition of keys for the 'Interrupt' section
            /// <summary>
            /// Definition of keys for the '<b>Interrupt</b>' section.
            /// </summary>
            [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public static class Interrupt
            {
                #region [public] {static} (IPropertyKey) Polarity: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interrupt Polarity.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType038Property.Polarity"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Polarity => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.Polarity);
                #endregion

                #region [public] {static} (IPropertyKey) SpecifiedInfo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para> Interrupt information specified.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType038Property.SpecifiedInfo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SpecifiedInfo => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.SpecifiedInfo);
                #endregion

                #region [public] {static} (IPropertyKey) TriggerMode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interrupt trigger mode.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType038Property.TriggerMode"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TriggerMode => new PropertyKey(SmbiosStructure.IpmiDevice, SmbiosType038Property.TriggerMode);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerSupply: Contains the key definitions available for a type 039 [System Power Supply] structure
        /// <summary>
        /// Contains the key definitions available for a type 039 [<see cref="SmbiosStructure.SystemPowerSupply"/> Information] structure.
        /// </summary>
        public static class SystemPowerSupply
        {
            #region [public] {static} (IPropertyKey) IsRedundant: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates whether it is redundant.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.IsRedundant"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsRedundant => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsRedundant);
            #endregion

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the location of the power supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.Location"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Names the power supply device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.DeviceName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceName => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Names the company that manufactured the supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the serial number for the power supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the asset tag number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.AssetTagNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTagNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.AssetTagNumber);
            #endregion

            #region [public] {static} (IPropertyKey) ModelPartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the OEM part order number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.ModelPartNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ModelPartNumber => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.ModelPartNumber);
            #endregion

            #region [public] {static} (IPropertyKey) RevisionLevel: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Power supply revision string.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.RevisionLevel"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RevisionLevel => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.RevisionLevel);
            #endregion

            #region [public] {static} (IPropertyKey) MaxPowerCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum sustained power output in Watts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.MaxPowerCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.W"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaxPowerCapacity => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.MaxPowerCapacity, PropertyUnit.W);
            #endregion

            #region [public] {static} (IPropertyKey) InputVoltageProbeHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of a voltage probe monitoring this power supply’s input voltage.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.InputVoltageProbeHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InputVoltageProbeHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputVoltageProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingDeviceHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of a cooling device associated with this power supply</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.CoolingDeviceHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoolingDeviceHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.CoolingDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) InputCurrentProbeHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the electrical current probe monitoring this power supply’s input current.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType039Property.InputCurrentProbeHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InputCurrentProbeHandle => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputCurrentProbeHandle);
            #endregion


            #region nested classes

            #region [public] {static} (class) Characteristics: Contains the key definition for the 'Characteristics' section.
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (IPropertyKey) InputVoltageRange: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Input voltage range switching.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.InputVoltageRange"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey InputVoltageRange => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.InputVoltageRange);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotReplaceable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is hot-replaceable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.IsHotReplaceable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHotReplaceable => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsHotReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) IsPlugged: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is plugged.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.IsPlugged"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsPlugged => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsPlugged);
                #endregion

                #region [public] {static} (IPropertyKey) IsPresent: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is present.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.IsPresent"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsPresent => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.IsPresent);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Power supply status.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) SupplyType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Power supply type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType039Property.SupplyType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupplyType => new PropertyKey(SmbiosStructure.SystemPowerSupply, SmbiosType039Property.SupplyType);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) AdditionalInformation: Contains the key definitions available for a type 040 [Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 040 [<see cref="SmbiosStructure.AdditionalInformation"/>] structure.
        /// </summary>
        public static class AdditionalInformation
        {
            #region [public] {static} (IPropertyKey) Entries: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Collection of additional information entries.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType040Property.Entries"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="AdditionalInformationEntryCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Entries => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.Entries);
            #endregion


            #region nested classes

            #region [public] {static} (class) Entry: Contains the key definition for the 'Entry' section
            /// <summary>
            /// Contains the key definition for the <b>Entry</b> section.
            /// </summary>
            public static class Entry
            {
                #region [public] {static} (IPropertyKey) EntryLength: Obtiene un valor que representa la clave para recuperar la propiedad
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Length of this additional information entry instance; a minimum of 6.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType040Property.EntryLength"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey EntryLength => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.EntryLength);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedHandle: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Handle, or instance number, associated with the structure for which additional information is provided.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType040Property.ReferencedHandle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ReferencedHandle => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.ReferencedHandle);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedOffset: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Offset of the field within the structure referenced by the referenced handle for which additional information is provided.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType040Property.ReferencedOffset"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ReferencedOffset => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.ReferencedOffset);
                #endregion

                #region [public] {static} (IPropertyKey) StringValue: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Optional string to be associated with the field referenced by the referenced offset.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType040Property.StringValue"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey StringValue => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.StringValue);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Enumerated value or updated field content that has not yet been approved for publication in this specification and
                /// therefore could not be used in the field referenced by referenced offset.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType040Property.Value"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Value => new PropertyKey(SmbiosStructure.AdditionalInformation, SmbiosType040Property.Value);
                #endregion
            }
            #endregion

            #endregion            
        }
        #endregion

        #region [public] {static} (class) OnBoardDevicesExtended: Contains the key definitions available for a type 041 [OnBoard Devices Extended Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 041 [<see cref="SmbiosStructure.OnBoardDevicesExtended"/> Information] structure.
        /// </summary>
        public static class OnBoardDevicesExtended
        {
            #region [public] {static} (IPropertyKey) ReferenceDesignation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Onboard device reference designation.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType041Property.ReferenceDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ReferenceDesignation => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.ReferenceDesignation);
            #endregion


            #region nested classes

            #region [public] {static} (class) Element: Contains the key definition for the 'Element' section
            /// <summary>
            /// Contains the key definition for the <b>Element</b> section.
            /// </summary>
            public static class Element
            {
                #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Device type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType041Property.DeviceType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) DeviceStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Device status.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.OnBoardDevicesExtended"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType041Property.DeviceStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceStatus => new PropertyKey(SmbiosStructure.OnBoardDevicesExtended, SmbiosType041Property.DeviceStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementControllerHostInterface: Contains the key definitions available for a type 042 [Management Controller Host Interface] structure
        /// <summary>
        /// Contains the key definitions available for a type 042 [<see cref="SmbiosStructure.ManagementControllerHostInterface"/>] structure.
        /// </summary>
        public static class ManagementControllerHostInterface
        {
            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Management Controller Interface Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType042Property.InterfaceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceTypeSpecificData: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Management Controller Interface Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType042Property.InterfaceTypeSpecificData"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceTypeSpecificData => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.InterfaceTypeSpecificData);
            #endregion

            #region [public] {static} (IPropertyKey) Protocols: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Management Controller Interface Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType042Property.Protocols"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ManagementControllerHostInterfaceProtocolRecordsCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Protocols => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.Protocols);
            #endregion


            #region nested classes

            #region [public] {static} (class) Protocol: Contains the key definition for the 'Protocols' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Protocol
            {
                #region [public] {static} (IPropertyKey) ProtocolType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Management Controller Interface Type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType042Property.ProtocolType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ProtocolType => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.ProtocolType);
                #endregion

                #region [public] {static} (IPropertyKey) ProtocolTypeSpecificData: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Protocol type specific data.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="SmbiosStructure.ManagementControllerHostInterface"/></description></item>
                ///   <item><description>Property: <see cref="SmbiosType042Property.ProtocolTypeSpecificData"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ProtocolTypeSpecificData => new PropertyKey(SmbiosStructure.ManagementControllerHostInterface, SmbiosType042Property.ProtocolTypeSpecificData);
                #endregion

            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TpmDevice: Contains the key definitions available for a type 043 [TpmDevice] structure
        /// <summary>
        /// Contains the key definitions available for a type 043 [<see cref="SmbiosStructure.TpmDevice"/>] structure.
        /// </summary>
        public static class TpmDevice
        {
            #region [public] {static} (IPropertyKey) VendorId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Specified as four ASCII characters.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.VendorId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorId => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.VendorId);
            #endregion

            #region [public] {static} (IPropertyKey) VendorIdDescription: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Vendor Id description.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.VendorIdDescription"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorIdDescription => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.VendorIdDescription);
            #endregion

            #region [public] {static} (IPropertyKey) MajorSpecVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Major TPM version supported by the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.MajorSpecVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MajorSpecVersion => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.MajorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) MinorSpecVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Minor TPM version supported by the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.MinorSpecVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinorSpecVersion => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.MinorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>TPM firmware version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.FirmwareVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Tpm.TpmFirmwareVersion"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of descriptive information of the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>TPM device characteristics information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.Characteristics"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.Characteristics);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM- or BIOS vendor-specific information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType043Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(SmbiosStructure.TpmDevice, SmbiosType043Property.OemDefined);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorAdditionalInformation: Contains the key definitions available for a type 044 [Processor Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 044 [<see cref="SmbiosStructure.ProcessorAdditionalInformation"/>] structure.
        /// </summary>
        public static class ProcessorAdditionalInformation
        {
            #region [public] {static} (IPropertyKey) VendorId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ProcessorAdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType044Property.ReferencedHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ReferencedHandle => new PropertyKey(SmbiosStructure.ProcessorAdditionalInformation, SmbiosType044Property.ReferencedHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorSpecificBlock: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor-specific block.</para>
            /// <para>The format of processor-specific data varies between different processor architecture.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.ProcessorAdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType044Property.ProcessorSpecificBlock"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Smbios.ProcessorSpecificInformationBlock"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ProcessorSpecificBlock => new PropertyKey(SmbiosStructure.ProcessorAdditionalInformation, SmbiosType044Property.ProcessorSpecificBlock);
            #endregion
        }
        #endregion

        #region [public] {static} (class) FirmwareInventoryInformation: Contains the key definitions available for a type 045 [Firmware Inventory Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 045 [<see cref="SmbiosStructure.FirmwareInventoryInformation"/>] structure.
        /// </summary>
        public static class FirmwareInventoryInformation
        {
            #region [public] {static} (IPropertyKey) FirmwareComponentName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware Component Name.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareComponentName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareComponentName => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareComponentName);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware Version of this firmware. The format of this value is defined by the Version Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersionFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the format of the Firmware Version and the Lowest Supported Firmware Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareVersionFormat"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareVersionFormat => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareVersionFormat);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware ID of this firmware. The format of this value is defined by the Firmware ID Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareId => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareId);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareIdFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the format of the Firmware ID.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareIdFormat"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareIdFormat => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareIdFormat);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareReleaseDate: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the firmware release date. The date string, if supplied, follows the Date-Time values format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareReleaseDate"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareReleaseDate => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareReleaseDate);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareManufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the firmware release date. The date string, if supplied, follows the Date-Time values format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareManufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareManufacturer => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareManufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) LowestSupportedFirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the lowest version to which this firmware can be rolled back to. The format of this value is defined by the Version Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.LowestSupportedFirmwareVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowestSupportedFirmwareVersion => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.LowestSupportedFirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareImageSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the firmware image that is currently programmed in the device, in bytes. If the Firmware Image Size is unknown, the field is set to FFFFFFFFFFFFFFFFh</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareImageSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareImageSize => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareImageSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareCharacteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Firmware characteristics information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareCharacteristics"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareCharacteristics => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareCharacteristics);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Firmware state information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.FirmwareState"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareState => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.FirmwareState);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfAssociatedComponents: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines how many Associated Component Handles are associated with this firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.NumberOfAssociatedComponents"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfAssociatedComponents => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.NumberOfAssociatedComponents);
            #endregion

            #region [public] {static} (IPropertyKey) AssociatedComponentHandles: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Lists the <b>SMBIOS</b> structure handles that are associated with this firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType045Property.AssociatedComponentHandles"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="uint"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssociatedComponentHandles => new PropertyKey(SmbiosStructure.FirmwareInventoryInformation, SmbiosType045Property.AssociatedComponentHandles);
            #endregion
        }
        #endregion

        #region [public] {static} (class) StringProperty: Contains the key definitions available for a type 046 [String Property] structure
        /// <summary>
        /// Contains the key definitions available for a type 044 [<see cref="SmbiosStructure.StringProperty"/>] structure.
        /// </summary>
        public static class StringProperty
        {
            #region [public] {static} (IPropertyKey) PropertyId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType046Property.PropertyId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PropertyId => new PropertyKey(SmbiosStructure.StringProperty, SmbiosType046Property.PropertyId);
            #endregion

            #region [public] {static} (IPropertyKey) PropertyValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType046Property.PropertyValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PropertyValue => new PropertyKey(SmbiosStructure.StringProperty, SmbiosType046Property.PropertyValue);
            #endregion

            #region [public] {static} (IPropertyKey) ParentHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType046Property.ParentHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.5</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ParentHandle => new PropertyKey(SmbiosStructure.StringProperty, SmbiosType046Property.ParentHandle);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Inactive: Contains the key definitions available for a type 126 [Inactive] structure
        /// <summary>
        /// Contains the key definitions available for a type 126 [<see cref="SmbiosStructure.Inactive"/>] structure.
        /// </summary>
        public static class Inactive
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates end of structures. Always returns the '<b>Inactive</b>' string.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.Inactive"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType126Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>Any version</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(SmbiosStructure.Inactive, SmbiosType126Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) EndOfTable: Contains the key definitions available for a type 127 [End-Of-Table] structure
        /// <summary>
        /// Contains the key definitions available for a type 127 [<see cref="SmbiosStructure.EndOfTable"/>] structure.
        /// </summary>
        public static class EndOfTable
        {
            #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates end of structures. Always returns the '<b>End Of Table Structures</b>' string.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="SmbiosStructure.EndOfTable"/></description></item>
            ///   <item><description>Property: <see cref="SmbiosType127Property.Status"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>Any version</para>
            /// </para>
            /// </summary>
            public static IPropertyKey Status => new PropertyKey(SmbiosStructure.EndOfTable, SmbiosType127Property.Status);
            #endregion
        }
        #endregion
    }
}
