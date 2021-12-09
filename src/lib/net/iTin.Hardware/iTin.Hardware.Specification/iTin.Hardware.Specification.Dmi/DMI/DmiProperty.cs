
namespace iTin.Hardware.Specification.Dmi.Property
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines available keys for the available devices of a system.
    /// </summary>
    public static partial class DmiProperty
    {
        #region [public] {static} (class) Bios: Contains the key definitions available for a type 000 [Bios Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 000 [<see cref="DmiStructureClass.Bios"/> Information] structure.
        /// </summary>
        public static class Bios
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) Vendor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the BIOS Vendor’s Name.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.Vendor"/></description></item>
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
            public static IPropertyKey Vendor => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.Vendor);
            #endregion

            #region [public] {static} (IPropertyKey) BiosVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the BIOS Version.</para>
            /// <para>This value is a free-form string that may contain core and <b>OEM</b> version information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.BiosVersion"/></description></item>
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
            public static IPropertyKey BiosVersion => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosVersion);
            #endregion

            #region [public] {static} (IPropertyKey) BiosStartSegment: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Segment location of BIOS starting address. This value is a free-form string that may contain core and <b>OEM</b> version information.
            /// The size of the runtime BIOS image can be computed by subtracting the Starting Address Segment from 10000h and multiplying the result by 16.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.BiosStartSegment"/></description></item>
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
            public static IPropertyKey BiosStartSegment => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosStartSegment);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.BiosReleaseDate"/></description></item>
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
            public static IPropertyKey BiosReleaseDate => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosReleaseDate);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports: <b>PCI</b>, <b>PCMCIA</b>, <b>Flash</b>, etc.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.Characteristics"/></description></item>
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
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.Characteristics);
            #endregion

            #endregion

            #region version 2.4+

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte1: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.CharacteristicsExtensionByte1"/></description></item>
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
            public static IPropertyKey CharacteristicsExtensionByte1 => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.CharacteristicsExtensionByte1);
            #endregion

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines which functions the BIOS supports.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.CharacteristicsExtensionByte2"/></description></item>
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
            public static IPropertyKey CharacteristicsExtensionByte2 => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.CharacteristicsExtensionByte2);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMajorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the major release of the System BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.SystemBiosMajorRelease"/></description></item>
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
            public static IPropertyKey SystemBiosMajorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.SystemBiosMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMinorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the minor release of the System BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.SystemBiosMinorRelease"/></description></item>
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
            public static IPropertyKey SystemBiosMinorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.SystemBiosMinorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMajorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the major release of the embedded controller firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.FirmwareMajorRelease"/></description></item>
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
            public static IPropertyKey FirmwareMajorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.FirmwareMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMinorRelease: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the minor release of the embedded controller firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.FirmwareMinorRelease"/></description></item>
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
            public static IPropertyKey FirmwareMinorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.FirmwareMinorRelease);
            #endregion

            #endregion

            #region version 2.0 - 3.1+

            #region [public] {static} (IPropertyKey) BiosRomSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the physical device containing the BIOS. For check measured unit, please see <see cref="BiosRomSizeUnit"/> property.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.BiosRomSize"/></description></item>
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
            public static IPropertyKey BiosRomSize => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosRomSize, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) BiosRomSizeUnit: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the physical device(s) containing the BIOS.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Bios"/></description></item>
            ///   <item><description>Property: <see cref="DmiType000Property.BiosRomSizeUnit"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="MemorySizeUnit"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+, 3.1+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey BiosRomSizeUnit => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosRomSizeUnit);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) System: Contains the key definitions available for a type 001 [System Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 001 [<see cref="DmiStructureClass.System"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.Manufacturer"/></description></item>
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
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.System, DmiType001Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ProductName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Product name</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.ProductName"/></description></item>
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
            public static IPropertyKey ProductName => new PropertyKey(DmiStructureClass.System, DmiType001Property.ProductName);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Product Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.Version"/></description></item>
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
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.System, DmiType001Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.SerialNumber"/></description></item>
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
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.System, DmiType001Property.SerialNumber);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.UUID"/></description></item>
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
            public static IPropertyKey UUID => new PropertyKey(DmiStructureClass.System, DmiType001Property.UUID);
            #endregion

            #region [public] {static} (IPropertyKey) WakeUpType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the event that caused the system to power up.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.WakeUpType"/></description></item>
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
            public static IPropertyKey WakeUpType => new PropertyKey(DmiStructureClass.System, DmiType001Property.WakeUpType);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.SkuNumber"/></description></item>
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
            public static IPropertyKey SkuNumber => new PropertyKey(DmiStructureClass.System, DmiType001Property.SkuNumber);
            #endregion

            #region [public] {static} (IPropertyKey) Family: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>This text string identifies the family to which a particular computer belongs.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.System"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.Family"/></description></item>
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
            public static IPropertyKey Family => new PropertyKey(DmiStructureClass.System, DmiType001Property.Family);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BaseBoard: Contains the key definitions available for a type 002 [Baseboard (or Module) Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 002 [<see cref="DmiStructureClass.BaseBoard"/> (or Module) Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Product: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Baseboard product.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.Product"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Product => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Product);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Version</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.Version"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard asset tag number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.AssetTag"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) LocationInChassis: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String that describes this board's location.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.LocationInChassis"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LocationInChassis => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.LocationInChassis);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the chassis in which this board resides.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.ChassisHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ChassisHandle => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.ChassisHandle);
            #endregion

            #region [public] {static} (IPropertyKey) BoardType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Mainboard Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.BoardType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BoardType => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.BoardType);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfContainedObjectHandles: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number (0 to 255) of contained Object Handles that follow.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.NumberOfContainedObjectHandles"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NumberOfContainedObjectHandles => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.NumberOfContainedObjectHandles);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>List of handles of other structures (for examples, Baseboard, Processor, Port, System Slots, Memory Device) that are contained by this baseboard.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
            ///   <item><description>Property: <see cref="DmiType002Property.ContainedObjectHandles"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="BaseBoardContainedElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.ContainedObjectHandles);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="DmiType002Property.IsHostingBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHostingBoard => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsHostingBoard);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotSwappable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is hot swappable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="DmiType002Property.HotSwappable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHotSwappable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.HotSwappable);
                #endregion

                #region [public] {static} (IPropertyKey) IsRemovable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is removable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="DmiType002Property.IsRemovable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsRemovable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsRemovable);
                #endregion

                #region [public] {static} (IPropertyKey) IsReplaceable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard is replaceable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="DmiType002Property.IsReplaceable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsReplaceable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) RequiredDaughterBoard: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if mainboard required a daughter board.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.BaseBoard"/></description></item>
                ///   <item><description>Property: <see cref="DmiType002Property.RequiredDaughterBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey RequiredDaughterBoard => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.RequiredDaughterBoard);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Chassis: Contains the key definitions available for a type 003 [System Enclosure or Chassis] structure
        /// <summary>
        /// Contains the key definitions available for a type 003 [<see cref="DmiStructureClass.SystemEnclosure"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType001Property.Manufacturer"/></description></item>
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
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Locked: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates if chassis lock is present.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.Locked"/></description></item>
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
            public static IPropertyKey Locked => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Locked);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.ChassisType"/></description></item>
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
            public static IPropertyKey ChassisType => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ChassisType);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.Version"/></description></item>
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
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Chassis Serial Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.SerialNumber"/></description></item>
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
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset Tag Number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.AssetTagNumber"/></description></item>
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
            public static IPropertyKey AssetTagNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.AssetTagNumber);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.BootUpState"/></description></item>
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
            public static IPropertyKey BootUpState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.BootUpState);
            #endregion

            #region [public] {static} (IPropertyKey) PowerSupplyState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>State of the enclosure’s power supply (or supplies) when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.PowerSupplyState"/></description></item>
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
            public static IPropertyKey PowerSupplyState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.PowerSupplyState);
            #endregion

            #region [public] {static} (IPropertyKey) ThermalState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Thermal state of the enclosure when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.ThermalState"/></description></item>
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
            public static IPropertyKey ThermalState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ThermalState);
            #endregion

            #region [public] {static} (IPropertyKey) SecurityStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical security status of the enclosure when last booted.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.SecurityStatus"/></description></item>
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
            public static IPropertyKey SecurityStatus => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SecurityStatus);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.OemDefined"/></description></item>
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
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) Height: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Height of the enclosure, in 'U's  A U is a standard unit of measure for the height of a rack or rack-mountable component and is equal to 1.75 inches or 4.445 cm.</para>
            /// <para>A value of 00h indicates that the enclosure height is unspecified.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.Height"/></description></item>
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
            public static IPropertyKey Height => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Height, PropertyUnit.U);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfPowerCords: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of power cords associated with the enclosure or chassis.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.NumberOfPowerCords"/></description></item>
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
            public static IPropertyKey NumberOfPowerCords => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.NumberOfPowerCords);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of contained Element records that follow, in the range 0 to 255.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.ContainedElements"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiChassisContainedElementCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.3+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElements);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
            ///   <item><description>Property: <see cref="DmiType003Property.SkuNumber"/></description></item>
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
            public static IPropertyKey SkuNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SkuNumber);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="DmiType003Property.ContainedType"/></description></item>
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
                public static IPropertyKey ItemType => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedType);
                #endregion

                #region [public] {static} (IPropertyKey) Min: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Specifies the minimum number of the element type that can be installed in the chassis for the chassis to properly operate, in the range 0 to 254.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="DmiType003Property.ContainedElementMinimum"/></description></item>
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
                public static IPropertyKey Min => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElementMinimum);
                #endregion

                #region [public] {static} (IPropertyKey) Max: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Specifies the maximum number of the element type that can be installed in the chassis, in the range 1 to 255.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="DmiType003Property.ContainedElementMaximum"/></description></item>
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
                public static IPropertyKey Max => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElementMaximum);
                #endregion

                #region [public] {static} (IPropertyKey) TypeSelect: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Type of select element associated.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEnclosure"/></description></item>
                ///   <item><description>Property: <see cref="DmiType003Property.ContainedTypeSelect"/></description></item>
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
                public static IPropertyKey TypeSelect => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedTypeSelect);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Processor: Contains the key definitions available for a type 004 [Processor Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 004 [<see cref="DmiStructureClass.Processor"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.SocketDesignation"/></description></item>
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
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String containing the type of processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorType"/></description></item>
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
            public static IPropertyKey ProcessorType => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorType);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorFamily: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String containing the family of processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorFamily"/></description></item>
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
            public static IPropertyKey Family => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorFamily);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorManufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor manufacturer.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorManufacturer"/></description></item>
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
            public static IPropertyKey ProcessorManufacturer => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorManufacturer);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorId"/></description></item>
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
            public static IPropertyKey ProcessorId => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorId);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String describing the processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorVersion"/></description></item>
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
            public static IPropertyKey ProcessorVersion => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalClock: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>External Clock Frequency, in MHz.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ExternalClock"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
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
            public static IPropertyKey ExternalClock => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ExternalClock, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum processor speed (in MHz) supported by the system for this processor socket 0E9h is for a 233 MHz processor. If the value is unknown, the field is set to 0.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.MaximumSpeed"/></description></item>
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
            public static IPropertyKey MaximumSpeed => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.MaximumSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current processor speed (in MHz).</para>
            /// <para>This field identifies the processor's speed at system boot; the processor may support more than one speed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.CurrentSpeed"/></description></item>
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
            public static IPropertyKey CurrentSpeed => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CurrentSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorUpgrade: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor upgrade value.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ProcessorUpgrade"/></description></item>
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
            public static IPropertyKey UpgradeMethod => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorUpgrade);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.L1CacheHandle"/></description></item>
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
            public static IPropertyKey L1CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L1CacheHandle);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.L2CacheHandle"/></description></item>
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
            public static IPropertyKey L2CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L2CacheHandle);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.L3CacheHandle"/></description></item>
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
            public static IPropertyKey L3CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L3CacheHandle);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.SerialNumber"/></description></item>
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
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset tag of this processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.AssetTag"/></description></item>
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
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Asset tag of this processor.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.PartNumber"/></description></item>
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
            public static IPropertyKey PartNumber => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.PartNumber);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.CoreCount"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.5+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreCount => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreCount);
            #endregion

            #region [public] {static} (IPropertyKey) CoreEnabled: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of enabled cores per processor socket. If the value is unknown, the field is set 0.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.CoreEnabled"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.5+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoreEnabled => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreEnabled);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ThreadCount"/></description></item>
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
            public static IPropertyKey ThreadCount => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ThreadCount);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.CoreCount2"/></description></item>
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
            public static IPropertyKey CoreCount2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreCount2);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.CoreEnabled2"/></description></item>
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
            public static IPropertyKey CoreEnabled2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreEnabled2);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
            ///   <item><description>Property: <see cref="DmiType004Property.ThreadCount2"/></description></item>
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
            public static IPropertyKey ThreadCount2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ThreadCount2);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Characteristics' section
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.Arm64SocIdSupported"/></description></item>
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
                public static IPropertyKey Arm64SocIdSupported => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.Arm64SocIdSupported);
                #endregion

                #region [public] {static} (IPropertyKey) Capable64Bits: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// 64-bit Capable indicates the maximum data width capability of the processor.
                /// For example, this bit is set for Intel Itanium, AMD Opteron, and Intel Xeon(with EM64T) processors; this bit is cleared for Intel Xeon processors that do not have EM64T.
                /// Indicates the maximum capability of the processor and does not indicate the current enabled state.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.Capable64Bits"/></description></item>
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
                public static IPropertyKey Capable64Bits => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.Capable64Bits);
                #endregion

                #region [public] {static} (IPropertyKey) Capable128Bits: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// 128-bit Capable indicates the maximum data width capability of the processor.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.Capable64Bits"/></description></item>
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
                public static IPropertyKey Capable128Bits => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.Capable128Bits);
                #endregion

                #region [public] {static} (IPropertyKey) EnhancedVirtualizationInstructions: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor is capable of executing enhanced virtualization instructions. Does not indicate the present state of this feature.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.EnhancedVirtualizationInstructions"/></description></item>
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
                public static IPropertyKey EnhancedVirtualizationInstructions => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.EnhancedVirtualizationInstructions);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.ExecuteProtectionSupport"/></description></item>
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
                public static IPropertyKey ExecuteProtectionSupport => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ExecuteProtectionSupport);
                #endregion

                #region [public] {static} (IPropertyKey) MultiCore: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates the processor has more than one core. Does not indicate the number of cores (Core Count) enabled by hardware or the number of cores (Core Enabled) enabled by BIOS.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.MultiCore"/></description></item>
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
                public static IPropertyKey MultiCore => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.MultiCore);
                #endregion

                #region [public] {static} (IPropertyKey) HardwareThreadPerCore: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor supports multiple hardware threads per core. Does not indicate the state or number of threads.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.HardwareThreadPerCore"/></description></item>
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
                public static IPropertyKey HardwareThreadPerCore => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.HardwareThreadPerCore);
                #endregion

                #region [public] {static} (IPropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates that the processor is capable of load-based power savings. Does not indicate the present state of this feature.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.PowerPerformanceControlSupport"/></description></item>
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
                public static IPropertyKey PowerPerformanceControlSupport => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.PowerPerformanceControlSupport);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Status: Contains the key definition for the 'Status' section
            /// <summary>
            /// Contains the key definition for the <b>Status</b> section.
            /// </summary>
            public static class Status
            {
                #region [public] {static} (IPropertyKey) CpuStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>String containing the current status of processor.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.CpuStatus"/></description></item>
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
                public static IPropertyKey CpuStatus => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CpuStatus);
                #endregion

                #region [public] {static} (IPropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if CPU is populated.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.SocketPopulated"/></description></item>
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
                public static IPropertyKey SocketPopulated => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SocketPopulated);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.IsLegacyMode"/></description></item>
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
                public static IPropertyKey IsLegacyMode => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.IsLegacyMode);
                #endregion

                #region [public] {static} (IPropertyKey) VoltageCapability: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Represent the specific voltages that the processor socket can accept.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Processor"/></description></item>
                ///   <item><description>Property: <see cref="DmiType004Property.VoltageCapability"/></description></item>
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
                public static IPropertyKey SupportedVoltages => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.VoltageCapability, PropertyUnit.V);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryController: Contains the key definitions available for a type 005, obsolete [Memory Controller Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 005, obsolete [<see cref="DmiStructureClass.MemoryController"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.ErrorDetectingMethod"/></description></item>
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
            public static IPropertyKey ErrorDetectingMethod => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ErrorDetectingMethod);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorCorrectingCapabilities: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Error detecting capabilities.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.ErrorCorrectingCapabilities"/></description></item>
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
            public static IPropertyKey ErrorCorrectingCapabilities => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ErrorCorrectingCapabilities);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedInterleave: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interleave supported.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.SupportedInterleave"/></description></item>
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
            public static IPropertyKey SupportedInterleave => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedInterleave);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentInterleave: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current interleave.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.CurrentInterleave"/></description></item>
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
            public static IPropertyKey CurrentInterleave => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.CurrentInterleave);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.MaximumMemoryModuleSize"/></description></item>
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
            public static IPropertyKey MaximumMemoryModuleSize => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.MaximumMemoryModuleSize);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSpeeds: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with supported speeds.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.SupportedSpeeds"/></description></item>
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
            public static IPropertyKey SupportedSpeeds => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedSpeeds, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedMemoryTypes: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with supported memory types.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.SupportedMemoryTypes"/></description></item>
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
            public static IPropertyKey SupportedMemoryTypes => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedMemoryTypes);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryModuleVoltages: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A string collection with memory module voltages.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.MemoryModuleVoltages"/></description></item>
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
            public static IPropertyKey MemoryModuleVoltages => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.MemoryModuleVoltages, PropertyUnit.V);
            #endregion

            #region [public] {static} (IPropertyKey) NumberMemorySlots: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of memory slots.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.NumberMemorySlots"/></description></item>
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
            public static IPropertyKey NumberMemorySlots => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.NumberMemorySlots);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedMemoryModules: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contained memory modules reference.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.ContainedMemoryModules"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiMemoryControllerContainedElementCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.0+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedMemoryModules => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ContainedMemoryModules, PropertyUnit.None);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryController"/></description></item>
            ///   <item><description>Property: <see cref="DmiType005Property.EnabledErrorCorrectingCapabilities"/></description></item>
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
            public static IPropertyKey EnabledErrorCorrectingCapabilities => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.EnabledErrorCorrectingCapabilities);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryModule: Contains the key definitions available for a type 006, obsolete [Memory Module Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 006, obsolete [<see cref="DmiStructureClass.MemoryModule"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.SocketDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) BankConnections: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates a bank (RAS#) connection.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.BankConnections"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BankConnections => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.BankConnections);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Speed of the memory module, in ns.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.CurrentSpeed"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.ns"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentSpeed => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.CurrentSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentMemoryType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the physical characteristics of the memory modules that are supported by (and currently installed in) the system.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.CurrentMemoryType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CurrentMemoryType => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.CurrentMemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identify the size of the memory module that is installed in the socket, as determined by reading and correlating the module’s presence-detect information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.InstalledSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InstalledSize => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.InstalledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) EnabledSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the amount of memory currently enabled for the system’s use from the module.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.EnabledSize"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.MB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey EnabledSize => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.EnabledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies error status.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryModule"/></description></item>
            ///   <item><description>Property: <see cref="DmiType006Property.ErrorStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorStatus => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.ErrorStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cache: Contains the key definitions available for a type 007 [Cache Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 007 [<see cref="DmiStructureClass.Cache"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.SocketDesignation"/></description></item>
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
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumCacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum size that can be installed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.MaximumCacheSize"/></description></item>
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
            public static IPropertyKey MaximumCacheSize => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.MaximumCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Installed size.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.InstalledCacheSize"/></description></item>
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
            public static IPropertyKey InstalledCacheSize => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.InstalledCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSramTypes: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String collection with supported SRAM types.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.SupportedSramTypes"/></description></item>
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
            public static IPropertyKey SupportedSramTypes => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SupportedSramTypes);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSramType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current SRAM type is installed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.SupportedSramTypes"/></description></item>
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
            public static IPropertyKey CurrentSramType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CurrentSramType);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.CacheSpeed"/></description></item>
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
            public static IPropertyKey CacheSpeed => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorCorrectionType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Error-correction scheme supported by this cache component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.ErrorCorrectionType"/></description></item>
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
            public static IPropertyKey ErrorCorrectionType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.ErrorCorrectionType);
            #endregion

            #region [public] {static} (IPropertyKey) SystemCacheType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Logical type of cache.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.SystemCacheType"/></description></item>
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
            public static IPropertyKey SystemCacheType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SystemCacheType);
            #endregion

            #region [public] {static} (IPropertyKey) Associativity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Associativity of the cache.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.Associativity"/></description></item>
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
            public static IPropertyKey Associativity => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.Associativity);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.MaximumCacheSize2"/></description></item>
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
            public static IPropertyKey MaximumCacheSize2 => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.MaximumCacheSize2, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize2: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>If is present, for cache sizes of 2047MB or smaller the value is equals to <see cref="InstalledCacheSize"/> property.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
            ///   <item><description>Property: <see cref="DmiType007Property.InstalledCacheSize2"/></description></item>
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
            public static IPropertyKey InstalledCacheSize2 => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.InstalledCacheSize2, PropertyUnit.KB);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
                ///   <item><description>Property: <see cref="DmiType007Property.CacheEnabled"/></description></item>
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
                public static IPropertyKey CacheEnabled => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheEnabled);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLevel: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns cache level (1, 2, 3,...).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
                ///   <item><description>Property: <see cref="DmiType007Property.CacheLevel"/></description></item>
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
                public static IPropertyKey Level => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheLevel);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLocation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Location, relative to the CPU module.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
                ///   <item><description>Property: <see cref="DmiType007Property.CacheLocation"/></description></item>
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
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheLocation);
                #endregion

                #region [public] {static} (IPropertyKey) OperationalMode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cache operational mode (Write Through, Write Back, ...).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
                ///   <item><description>Property: <see cref="DmiType007Property.OperationalMode"/></description></item>
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
                public static IPropertyKey OperationalMode => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.OperationalMode);
                #endregion

                #region [public] {static} (IPropertyKey) CacheSocketed: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if cache is socketed.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.Cache"/></description></item>
                ///   <item><description>Property: <see cref="DmiType007Property.CacheSocketed"/></description></item>
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
                public static IPropertyKey CacheSocketed => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheSocketed);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortConnector: Contains the key definitions available for a type 008 [Port Connector Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 008 [<see cref="DmiStructureClass.PortConnector"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="DmiType008Property.InternalReferenceDesignator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InternalReferenceDesignator => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.InternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) InternalConnectorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Internal Connector type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="DmiType008Property.InternalConnectorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InternalConnectorType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.InternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalReferenceDesignator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for the External Reference Designation external to the system enclosure.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="DmiType008Property.ExternalReferenceDesignator"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExternalReferenceDesignator => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.ExternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalConnectorType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>External Connector type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="DmiType008Property.ExternalConnectorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ExternalConnectorType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.ExternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) PortType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the function of the port.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortConnector"/></description></item>
            ///   <item><description>Property: <see cref="DmiType008Property.PortType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey PortType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.PortType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemSlots: Contains the key definitions available for a type 009 [System Slots] structure
        /// <summary>
        /// Contains the key definitions available for a type 009 [<see cref="DmiStructureClass.SystemSlots"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotDesignation"/></description></item>
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
            public static IPropertyKey SlotDesignation => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) SlotType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotType"/></description></item>
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
            public static IPropertyKey SlotType => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotType);
            #endregion

            #region [public] {static} (IPropertyKey) SlotDataBusWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot Data Bus Width.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotDataBusWidth"/></description></item>
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
            public static IPropertyKey SlotDataBusWidth => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotDataBusWidth, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentUsage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot current usage.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.CurrentUsage"/></description></item>
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
            public static IPropertyKey CurrentUsage => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.CurrentUsage);
            #endregion

            #region [public] {static} (IPropertyKey) SlotLength: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot length.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotLength"/></description></item>
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
            public static IPropertyKey SlotLength => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotLength);
            #endregion

            #region [public] {static} (IPropertyKey) SlotId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot Identifier.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotId"/></description></item>
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
            public static IPropertyKey SlotId => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotId);
            #endregion

            #endregion

            #region version 2.0+ - 2.1+

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slot characteristics.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotCharacteristics"/></description></item>
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
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotCharacteristics);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SegmentBusFunction"/></description></item>
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
            public static IPropertyKey SegmentBusFunction => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SegmentBusFunction);
            #endregion

            #region [public] {static} (IPropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Bus device function.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.BusDeviceFunction"/></description></item>
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
            public static IPropertyKey BusDeviceFunction => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.BusDeviceFunction);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.PeerDevices"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiPeerDevicesCollection"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>3.2</para>
            /// </para>
            /// </summary>
            public static IPropertyKey PeerDevices => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.PeerDevices);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotInformation"/></description></item>
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
            public static IPropertyKey SlotInformation => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotInformation);
            #endregion

            #region [public] {static} (IPropertyKey) SlotPhysicalWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates the physical width of the slot whereas <see cref="SystemSlots.SlotDataBusWidth"/> property indicates the electrical width of the slot.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotPhysicalWidth"/></description></item>
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
            public static IPropertyKey SlotPhysicalWidth => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotPhysicalWidth);
            #endregion

            #region [public] {static} (IPropertyKey) SlotPitch: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Indicates the pitch of the slot in millimeters. The pitch is defined by each slot/card specification, but typically describes add-in card to add-in card pitch.</para>
            /// <para>A value of 0 implies that the slot pitch is not given or is unknown.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
            ///   <item><description>Property: <see cref="DmiType009Property.SlotPitch"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
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
            public static IPropertyKey SlotPitch => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotPitch, PropertyUnit.mm);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="DmiType009Property.SegmentGroupNumber"/></description></item>
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
                public static IPropertyKey SegmentGroupNumber => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SegmentGroupNumber);
                #endregion

                #region [public] {static} (IPropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Bus device function (Peer).</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="DmiType009Property.BusDeviceFunctionPeer"/></description></item>
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
                public static IPropertyKey BusDeviceFunction => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.BusDeviceFunctionPeer);
                #endregion

                #region [public] {static} (IPropertyKey) DataBusWidth: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates electrical bus width of peer Segment/Bus/Device/Function.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemSlots"/></description></item>
                ///   <item><description>Property: <see cref="DmiType009Property.DataBusWidth"/></description></item>
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
                public static IPropertyKey DataBusWidth => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.DataBusWidth);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 010, obsolete [On Board Devices Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 010, obsolete [<see cref="DmiStructureClass.OnBoardDevices"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="DmiType010Property.Enabled"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Enabled => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.Enabled);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="DmiType010Property.DeviceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.DeviceType);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of device description.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevices"/></description></item>
            ///   <item><description>Property: <see cref="DmiType010Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) OemStrings: Contains the key definitions available for a type 011 [OEM Strings] structure
        /// <summary>
        /// Contains the key definitions available for a type 011 [<see cref="DmiStructureClass.OemStrings"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.OemStrings"/></description></item>
            ///   <item><description>Property: <see cref="DmiType011Property.Values"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(DmiStructureClass.OemStrings, DmiType011Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemConfigurationOptions: Contains the key definitions available for a type 012 [System Configuration Options] structure
        /// <summary>
        /// Contains the key definitions available for a type 012 [<see cref="DmiStructureClass.SystemConfigurationOptions"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemConfigurationOptions"/></description></item>
            ///   <item><description>Property: <see cref="DmiType012Property.Values"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(DmiStructureClass.SystemConfigurationOptions, DmiType012Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BiosLanguage: Contains the key definitions available for a type 013 [BIOS Language Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 013 [<see cref="DmiStructureClass.BiosLanguage"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="DmiType013Property.InstallableLanguages"/></description></item>
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
            public static IPropertyKey InstallableLanguages => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.InstallableLanguages);
            #endregion

            #region [public] {static} (IPropertyKey) Current: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Currently installed language.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="DmiType013Property.Current"/></description></item>
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
            public static IPropertyKey Current => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.Current);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BiosLanguage"/></description></item>
            ///   <item><description>Property: <see cref="DmiType013Property.IsCurrentAbbreviated"/></description></item>
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
            public static IPropertyKey IsCurrentAbbreviated => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.IsCurrentAbbreviated);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) GroupAssociations: Contains the key definitions available for a type 014 [Group Associations] structure
        /// <summary>
        /// Contains the key definitions available for a type 014 [<see cref="DmiStructureClass.GroupAssociations"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.GroupAssociations"/></description></item>
            ///   <item><description>Property: <see cref="DmiType014Property.ContainedElements"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiGroupAssociationElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.ContainedElements);
            #endregion

            #region [public] {static} (IPropertyKey) GroupName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of string describing the group.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.GroupAssociations"/></description></item>
            ///   <item><description>Property: <see cref="DmiType014Property.GroupName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey GroupName => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.GroupName);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.GroupAssociations"/></description></item>
                ///   <item><description>Property: <see cref="DmiType014Property.Handle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Structure: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Item (Structure) Type of this member.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.GroupAssociations"/></description></item>
                ///   <item><description>Property: <see cref="DmiType014Property.Structure"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="Smbios.SmbiosStructure"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Structure => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.Structure);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemEventLog: Contains the key definitions available for a type 015 [System Event Log] structure
        /// <summary>
        /// Contains the key definitions available for a type 015 [<see cref="DmiStructureClass.SystemEventLog"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.LogAreaLength"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogAreaLength => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.LogAreaLength);
            #endregion

            #region [public] {static} (IPropertyKey) LogHeaderStartOffset: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the starting offset (or index) within the nonvolatile storage of the event-log’s header from the Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.LogHeaderStartOffset"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogHeaderStartOffset => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.LogHeaderStartOffset);
            #endregion

            #region [public] {static} (IPropertyKey) DataStartOffset: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the starting offset (or index) within the nonvolatile storage of the event-log’s first data byte, from the Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.DataStartOffset"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="int"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DataStartOffset => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.DataStartOffset);
            #endregion

            #region [public] {static} (IPropertyKey) AccessMethod: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines the Location and Method used by higher-level software to access the log area</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.AccessMethod"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AccessMethod => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.AccessMethod);
            #endregion

            #region [public] {static} (IPropertyKey) LogStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Current status of the system event-log</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.LogStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogStatus => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.LogStatus);
            #endregion

            #region [public] {static} (IPropertyKey) AccessMethodAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Access Method Address</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.AccessMethodAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AccessMethodAddress => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.AccessMethodAddress);
            #endregion

            #region [public] {static} (IPropertyKey) LogChangeToken: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Unique token that is reassigned every time the event log changes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.LogChangeToken"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogChangeToken => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.LogChangeToken);
            #endregion

            #region [public] {static} (IPropertyKey) LogHeaderFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Unique token that is reassigned every time the event log changes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.LogHeaderFormat"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LogHeaderFormat => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.LogHeaderFormat);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedLogTypeDescriptors: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of supported event log type descriptors.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.SupportedLogTypeDescriptors"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SupportedLogTypeDescriptors => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.SupportedLogTypeDescriptors);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedLogTypeDescriptors: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>List of Event Log Type Descriptors.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemEventLog"/></description></item>
            ///   <item><description>Property: <see cref="DmiType015Property.ListSupportedEventLogTypeDescriptors"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiSupportedEventLogTypeDescriptorsCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ListSupportedEventLogTypeDescriptors => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.ListSupportedEventLogTypeDescriptors);
            #endregion
        }
        #endregion

        #region [public] {static} (class) PhysicalMemoryArray: Contains the key definitions available for a type 016 [Physical Memory Array] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="DmiStructureClass.PhysicalMemoryArray"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.Location"/></description></item>
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
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Use: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Function for which the array is used.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.Use"/></description></item>
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
            public static IPropertyKey Use => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.Use);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorCorrection: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Primary hardware error correction or detection method supported by this memory array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.MemoryErrorCorrection"/></description></item>
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
            public static IPropertyKey MemoryErrorCorrection => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MemoryErrorCorrection);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with any error that was previously detected for the array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.MemoryErrorInformationHandle"/></description></item>
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
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfMemoryDevices: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of slots or sockets available for Memory devices in this array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.NumberOfMemoryDevices"/></description></item>
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
            public static IPropertyKey NumberOfMemoryDevices => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.NumberOfMemoryDevices);
            #endregion

            #endregion

            #region version 2.1+, 2.7+

            #region [public] {static} (IPropertyKey) MaximumCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum memory capacity, in kilobytes, for this array.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray"/></description></item>
            ///   <item><description>Property: <see cref="DmiType016Property.MaximumCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.KB"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumCapacity => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MaximumCapacity, PropertyUnit.KB);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDevice: Contains the key definitions available for a type 017 [Memory Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 017 [<see cref="DmiStructureClass.MemoryDevice"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.PhysicalMemoryArrayHandle"/></description></item>
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
            public static IPropertyKey PhysicalMemoryArrayHandle => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.PhysicalMemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>
            /// Handle, or instance number, associated with any error that was previously detected for the device.
            /// If no error was detected returns <b>-1</b>.
            /// If the system does not provide the error information returns <b>-2</b>.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemoryErrorInformationHandle"/></description></item>
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
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) TotalWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Total width, in bits, of this memory device, including any check or error-correction bits.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.TotalWidth"/></description></item>
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
            public static IPropertyKey TotalWidth => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.TotalWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) DataWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Data width, in bits, of this memory device A data width of 0 and a total width of 8 indicates that the device is being used solely to provide 8 error-correction bits</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.DataWidth"/></description></item>
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
            public static IPropertyKey DataWidth => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DataWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) Size: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.Size"/></description></item>
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
            public static IPropertyKey Size => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Size, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) FormFactor: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Implementation form factor for this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.FormFactor"/></description></item>
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
            public static IPropertyKey FormFactor => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.FormFactor);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.DeviceSet"/></description></item>
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
            public static IPropertyKey DeviceSet => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DeviceSet);
            #endregion

            #region [public] {static} (IPropertyKey) BankLocator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number of the string that identifies the physically labeled bank where the memory device is located.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.BankLocator"/></description></item>
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
            public static IPropertyKey BankLocator => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.BankLocator);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceLocator: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number of the string that identifies the physically-labeled socket or board position where the memory device is located.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.DeviceLocator"/></description></item>
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
            public static IPropertyKey DeviceLocator => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DeviceLocator);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Type of memory used in this device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemoryType"/></description></item>
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
            public static IPropertyKey MemoryType => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) TypeDetail: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Additional detail on the memory device type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.TypeDetail"/></description></item>
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
            public static IPropertyKey TypeDetail => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.TypeDetail);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.Speed"/></description></item>
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
            public static IPropertyKey Speed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Speed, PropertyUnit.MTs);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the manufacturer of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.Manufacturer"/></description></item>
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
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the serial number of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.SerialNumber"/></description></item>
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
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the asset tag of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.AssetTag"/></description></item>
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
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String number for the part number of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.PartNumber"/></description></item>
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
            public static IPropertyKey PartNumber => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.PartNumber);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.Rank"/></description></item>
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
            public static IPropertyKey Rank => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Rank);
            #endregion

            #endregion

            #region version 2.7+

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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ConfiguredMemoryClockSpeed"/></description></item>
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
            public static IPropertyKey ConfiguredMemoryClockSpeed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ConfiguredMemoryClockSpeed, PropertyUnit.Variable);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MinimumVoltage"/></description></item>
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
            public static IPropertyKey MinimumVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MinimumVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Maximum operating voltage for this device, in millivolts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MaximumVoltage"/></description></item>
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
            public static IPropertyKey MaximumVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MaximumVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) ConfiguredVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Configured voltage for this device, in millivolts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ConfiguredVoltage"/></description></item>
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
            public static IPropertyKey ConfiguredVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ConfiguredVoltage, PropertyUnit.mV);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemoryTechnology"/></description></item>
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
            public static IPropertyKey MemoryTechnology => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryTechnology);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryOperatingModeCapability: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The operating modes supported by this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemoryOperatingModeCapability"/></description></item>
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
            public static IPropertyKey MemoryOperatingModeCapability => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryOperatingModeCapability);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number for the firmware version of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.FirmwareVersion"/></description></item>
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
            public static IPropertyKey FirmwareVersion => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleManufacturerId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte module manufacturer ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ModuleManufacturerId"/></description></item>
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
            public static IPropertyKey ModuleManufacturerId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ModuleManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleProductId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte module product ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ModuleProductId"/></description></item>
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
            public static IPropertyKey ModuleProductId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ModuleProductId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerManufacturerId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte memory subsystem controller manufacturer ID found in the SPD of this memory device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemorySubSystemControllerManufacturerId"/></description></item>
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
            public static IPropertyKey MemorySubsystemControllerManufacturerId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemorySubSystemControllerManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerProductId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>The two-byte memory subsystem controller product ID found in the SPD of this memory device; LSB first.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.MemorySubSystemControllerProductId"/></description></item>
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
            public static IPropertyKey MemorySubsystemControllerProductId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemorySubSystemControllerProductId);
            #endregion

            #region [public] {static} (IPropertyKey) NonVolatileSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Non-volatile portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.NonVolatileSize"/></description></item>
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
            public static IPropertyKey NonVolatileSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.NonVolatileSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) VolatileSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the volatile portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.VolatileSize"/></description></item>
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
            public static IPropertyKey VolatileSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.VolatileSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) CacheSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Cache portion of the memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.CacheSize"/></description></item>
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
            public static IPropertyKey CacheSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.CacheSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) LogicalSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the Logical memory device in bytes.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.LogicalSize"/></description></item>
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
            public static IPropertyKey LogicalSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.LogicalSize, PropertyUnit.Bytes);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ExtendedSpeed"/></description></item>
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
            public static IPropertyKey ExtendedSpeed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ExtendedSpeed, PropertyUnit.MTs);
            #endregion

            #region [public] {static} (IPropertyKey) ExtendedConfiguredMemorySpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Extended configured memory speed of the memory device. Identifies the configured speed of the memory device, in megatransfers per second (MT/s).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType017Property.ExtendedConfiguredMemorySpeed"/></description></item>
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
            public static IPropertyKey ExtendedConfiguredMemorySpeed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ExtendedConfiguredMemorySpeed, PropertyUnit.MTs);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError32: Contains the key definitions available for a type 018 [32-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 018 [<see cref="DmiStructureClass.BitMemoryError32"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.ErrorType"/></description></item>
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
            public static IPropertyKey ErrorType => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Granularity (for example, device versus Partition) to which the error can be resolved.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.ErrorGranularity"/></description></item>
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
            public static IPropertyKey ErrorGranularity => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Memory access operation that caused the error.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.ErrorOperation"/></description></item>
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
            public static IPropertyKey ErrorOperation => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Vendor-specific ECC syndrome or CRC data associated with the erroneous access.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.VendorSyndrome"/></description></item>
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
            public static IPropertyKey VendorSyndrome => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error based on the addressing of the bus to which the memory array is connected.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.MemoryArrayErrorAddress"/></description></item>
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
            public static IPropertyKey MemoryArrayErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error relative to the start of the failing memory device, in bytes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.DeviceErrorAddress"/></description></item>
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
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.DeviceErrorAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Range, in bytes, within which the error can be determined, when an error address is given</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError32"/></description></item>
            ///   <item><description>Property: <see cref="DmiType018Property.ErrorResolution"/></description></item>
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
            public static IPropertyKey ErrorResolution => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorResolution, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 019 [Memory Array Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 019 [<see cref="DmiStructureClass.MemoryArrayMappedAddress"/>] structure.
        /// </summary>
        public static class MemoryArrayMappedAddress
        {
            #region version 2.1+

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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType019Property.MemoryArrayHandle"/></description></item>
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
            public static IPropertyKey MemoryArrayHandle => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.MemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) PartitionWidth: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para> Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of memory devices that form a single row of memory for the address partition defined by this structure.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType019Property.PartitionWidth"/></description></item>
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
            public static IPropertyKey PartitionWidth => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.PartitionWidth);
            #endregion

            #endregion

            #region version 2.1+ - 2.7+

            #region [public] {static} (IPropertyKey) StartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical address, of a range of memory mapped to the specified physical memory array.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType019Property.StartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey StartingAddress => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.StartingAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) EndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical ending address.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType019Property.EndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey EndingAddress => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.EndingAddress, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDeviceMappedAddress: Contains the key definitions available for a type 020 [Memory Device Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 020 [<see cref="DmiStructureClass.MemoryDeviceMappedAddress"/>] structure.
        /// </summary>
        public static class MemoryDeviceMappedAddress
        {
            #region version 2.1+

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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.MemoryDeviceHandle"/></description></item>
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
            public static IPropertyKey MemoryDeviceHandle => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.MemoryDeviceHandle);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.MemoryArrayMappedAddressHandle"/></description></item>
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
            public static IPropertyKey MemoryArrayMappedAddressHandle => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.MemoryArrayMappedAddressHandle);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.PartitionRowPosition"/></description></item>
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
            public static IPropertyKey PartitionRowPosition => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.PartitionRowPosition);
            #endregion

            #region [public] {static} (IPropertyKey) InterleavePosition: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Position of the referenced Memory Device in an interleave.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.InterleavePosition"/></description></item>
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
            public static IPropertyKey InterleavePosition => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.InterleavePosition);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.InterleavedDataDepth"/></description></item>
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
            public static IPropertyKey InterleavedDataDepth => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.InterleavedDataDepth);
            #endregion

            #endregion

            #region version 2.1+, 2.7+

            #region [public] {static} (IPropertyKey) StartingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical starting address.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.StartingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey StartingAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.StartingAddress, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) EndingAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Physical ending address.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress"/></description></item>
            ///   <item><description>Property: <see cref="DmiType020Property.EndingAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.7+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey EndingAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.EndingAddress, PropertyUnit.Bytes);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BuiltInPointingDevice: Contains the key definitions available for a type 021 [Built-in Pointing Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 021 [<see cref="DmiStructureClass.BuiltInPointingDevice"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType021Property.Type"/></description></item>
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
            public static IPropertyKey Type => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Interface: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interface type for the pointing device.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType021Property.Interface"/></description></item>
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
            public static IPropertyKey Interface => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.Interface);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfButtons: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of buttons on the pointing device.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType021Property.NumberOfButtons"/></description></item>
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
            public static IPropertyKey NumberOfButtons => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.NumberOfButtons);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortableBattery: Contains the key definitions available for a type 022 [Portable Battery] structure
        /// <summary>
        /// Contains the key definitions available for a type 022 [<see cref="DmiStructureClass.PortableBattery"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.Location"/></description></item>
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
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of the string that names the company that manufactured the battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.Manufacturer"/></description></item>
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
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Battery name.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.DeviceName"/></description></item>
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
            public static IPropertyKey DeviceName => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceChemistry: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the battery chemistry.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.DeviceChemistry"/></description></item>
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
            public static IPropertyKey DeviceChemistry => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DeviceChemistry);
            #endregion

            #region [public] {static} (IPropertyKey) DesignCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Design capacity of the battery in mWatt-hours.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.DesignCapacity"/></description></item>
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
            public static IPropertyKey DesignCapacity => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignCapacity, PropertyUnit.mWh);
            #endregion

            #region [public] {static} (IPropertyKey) DesignVoltage: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Design voltage of the battery in mVolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.DesignVoltage"/></description></item>
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
            public static IPropertyKey DesignVoltage => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) SBDSVersionNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The Smart Battery Data Specification version number supported by this battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.SbdsVersionNumber"/></description></item>
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
            public static IPropertyKey SBDSVersionNumber => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SbdsVersionNumber);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.MaximunErrorInBatteryData"/></description></item>
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
            public static IPropertyKey MaximunErrorInBatteryData => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.MaximunErrorInBatteryData);
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
            /// <para><b>Key Composition</b></para>l
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.DesignCapacityMultiplier"/></description></item>
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
            public static IPropertyKey DesignCapacityMultiplier => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignCapacityMultiplier);
            #endregion

            #region [public] {static} (IPropertyKey) OemSpecific: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.OemSpecific"/></description></item>
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
            public static IPropertyKey OemSpecific => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.OemSpecific);
            #endregion

            #endregion

            #region version 2.1+, 2.2+

            #region [public] {static} (IPropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para> The date on which the battery was manufactured.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.ManufactureDate"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// <para>
            ///  <para><b>Remarks</b></para>
            ///  <para>2.1+, 2.2+</para>
            /// </para>
            /// </summary>
            public static IPropertyKey ManufactureDate => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.ManufactureDate);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>The serial number for the battery.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.PortableBattery"/></description></item>
            ///   <item><description>Property: <see cref="DmiType022Property.SerialNumber"/></description></item>
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
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SerialNumber);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemReset: Contains the key definitions available for a type 023 [System Reset] structure
        /// <summary>
        /// Contains the key definitions available for a type 023 [<see cref="DmiStructureClass.SystemReset"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="DmiType023Property.ResetCount"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ResetCount => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.ResetCount);
            #endregion

            #region [public] {static} (IPropertyKey) ResetLimit: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of consecutive times the system reset is attempted.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="DmiType023Property.ResetLimit"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ResetLimit => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.ResetLimit);
            #endregion

            #region [public] {static} (IPropertyKey) TimerInterval: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Number of minutes to use for the watchdog timer If the timer is not reset within this interval, the system reset timeout begins.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="DmiType023Property.TimerInterval"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey TimerInterval => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.TimerInterval);
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
            ///   <item><description>Property: <see cref="DmiType023Property.Timeout"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Timeout => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.Timeout);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="DmiType023Property.BootOption"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BootOption =>  new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.BootOption);
                #endregion

                #region [public] {static} (IPropertyKey) BootOptionOnLimit: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns to the action that will be taken when the restart limit is reached.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="DmiType023Property.BootOptionOnLimit"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey BootOptionOnLimit => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.BootOptionOnLimit);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Identifies whether (enabled) or not (disabled) the system reset by the user.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="DmiType023Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) WatchdogTimer: Gets a value representing the key to retrieve the property value.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whether the system contains a watchdog timer.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemReset"/></description></item>
                ///   <item><description>Property: <see cref="DmiType023Property.WatchdogTimer"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey WatchdogTimer => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.WatchdogTimer);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 024 [Hardware Security] structure
        /// <summary>
        /// Contains the key definitions available for a type 024 [<see cref="DmiStructureClass.HardwareSecurity"/>] structure.
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="DmiType024Property.AdministratorPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey AdministratorPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.AdministratorPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) FrontPanelResetStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current front panel reset status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="DmiType024Property.FrontPanelResetStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrontPanelResetStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.FrontPanelResetStatus);
                #endregion

                #region [public] {static} (IPropertyKey) KeyboardPasswordStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current keyboard password status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="DmiType024Property.KeyboardPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey KeyboardPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.KeyboardPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) PowerOnPasswordStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Returns current power on password status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.HardwareSecurity"/></description></item>
                ///   <item><description>Property: <see cref="DmiType024Property.PowerOnPasswordStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey PowerOnPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.PowerOnPasswordStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerControls: Contains the key definitions available for a type 025 [System Power Controls] structure
        /// <summary>
        /// Contains the key definitions available for a type 025 [<see cref="DmiStructureClass.SystemPowerControls"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="DmiType025Property.Month"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Month => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Month);
            #endregion

            #region [public] {static} (IPropertyKey) Day: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the day-of-month on which the next scheduled power-on is to occur, in the range 01h to 31h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="DmiType025Property.Day"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Day => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Day);
            #endregion

            #region [public] {static} (IPropertyKey) Hour: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the hour on which the next scheduled poweron is to occur, in the range 00h to 23h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="DmiType025Property.Hour"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Hour => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Hour);
            #endregion

            #region [public] {static} (IPropertyKey) Minute: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the minute on which the next scheduled power-on is to occur, in the range 00h to 59h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="DmiType025Property.Minute"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Minute => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Minute);
            #endregion

            #region [public] {static} (IPropertyKey) Second: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>BCD value of the second on which the next scheduled power-on is to occur, in the range 00h to 59h.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerControls"/></description></item>
            ///   <item><description>Property: <see cref="DmiType025Property.Second"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Second => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Second);
            #endregion
        }
        #endregion

        #region [public] {static} (class) VoltageProbe: Contains the key definitions available for a type 026 [Voltage Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 026 [<see cref="DmiStructureClass.VoltageProbe"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum voltage level readable by this probe, in millivolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.MaximumValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Minimum voltage level readable by this probe, in millivolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.MinimumValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Resolution for the probe’s reading, in tenths of millivolts</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.d_mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Resolution, PropertyUnit.d_mV);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Tolerance for reading from this probe, in plus/minus millivolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.Tolerance"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mV"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Tolerance, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Accuracy for reading from this probe, in plus/minus 1/100th of a percent.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Nominal value for the probe’s reading in millivolts.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType026Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.NominalValue, PropertyUnit.mV);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType026Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the voltage monitored by this voltage probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.VoltageProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType026Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) CoolingDevice: Contains the key definitions available for a type 027 [Cooling Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 027 [<see cref="DmiStructureClass.CoolingDevice"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType027Property.TemperatureProbeHandle"/></description></item>
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
            public static IPropertyKey TemperatureProbeHandle => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.TemperatureProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingUnitGroup: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Cooling unit group to which this cooling device is associated. Having multiple cooling devices in the same cooling unit implies a redundant configuration.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType027Property.CoolingUnitGroup"/></description></item>
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
            public static IPropertyKey CoolingUnitGroup => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.CoolingUnitGroup);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information,</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType027Property.CoolingUnitGroup"/></description></item>
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
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalSpeed: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Nominal value for the cooling device’s rotational speed, in revolutions-per-minute (rpm)</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType027Property.NominalSpeed"/></description></item>
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
            public static IPropertyKey NominalSpeed => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.NominalSpeed, PropertyUnit.RPM);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains additional descriptive information about the cooling device or its location.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType027Property.Description"/></description></item>
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
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.Description);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType027Property.DeviceType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.2+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Cooling device status.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.CoolingDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType027Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>2.2+</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TemperatureProbe: Contains the key definitions available for a type 028 [Temperature Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 028 [<see cref="DmiStructureClass.TemperatureProbe"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum temperature readable by this probe, in 1/10th ºC</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.MaximumValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Minimun temperature readable by this probe, in 1/10th ºC</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.MinimumValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Resolution for the probe’s reading, in 1/1000th ºC.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Resolution, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Tolerance for reading from this probe, in plus/minus 1/10th ºC.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.Tolerance"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Tolerance, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Accuracy for reading from this probe, in plus/minus 1/100th of a percent.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Nominal value for the probe’s reading in 1/10th degrees ºC.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType028Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.DegreeCentigrade"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.NominalValue, PropertyUnit.DegreeCentigrade);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType028Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the temperature monitored by this temperature probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.TemperatureProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType028Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ElectricalCurrentProbe: Contains the key definitions available for a type 029 [Electrical Current Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 029 [<see cref="DmiStructureClass.ElectricalCurrentProbe"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum temperature readable by this probe, in milliamps.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.MaximumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximumValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.MaximumValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) MinimumValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Minimun temperature readable by this probe, in milliamps.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.MinimumValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinimumValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.MinimumValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property value.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Resolution for the probe’s reading, in tenths of milliamps.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.Resolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Resolution, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Tolerance for reading from this probe, in plus/minus milliamps.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.Tolerance"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType029Property.Tolerance, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Accuracy for reading from this probe, in plus/minus 1/100th of a percent.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.Accuracy"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Percent_1_100th"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Accuracy, PropertyUnit.Percent_1_100th);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Nominal value for the probe’s reading in milliamps.</para>
            /// <para>
            /// <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
            ///   <item><description>Property: <see cref="DmiType029Property.NominalValue"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.mA"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.NominalValue, PropertyUnit.mA);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType029Property.Location"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Probe’s physical status of the temperature monitored by this temperature probe.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe"/></description></item>
                ///   <item><description>Property: <see cref="DmiType029Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OutOfBandRemote: Contains the key definitions available for a type 030 [Out-of-Band Remote Access] structure
        /// <summary>
        /// Contains the key definitions available for a type 030 [<see cref="DmiStructureClass.OutOfBandRemote"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.OutOfBandRemote"/></description></item>
            ///   <item><description>Property: <see cref="DmiType030Property.ManufacturerName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.ManufacturerName);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.OutOfBandRemote"/></description></item>
                ///   <item><description>Property: <see cref="DmiType030Property.OutBoundConnection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey OutBoundConnection => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.OutBoundConnection);
                #endregion

                #region [public] {static} (IPropertyKey) InBoundConnection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whether is allowed to initiate outbound connections to receive incoming connections for the purpose of remote operations or problem management.</para>
                /// <para>
                /// <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.OutOfBandRemote"/></description></item>
                ///   <item><description>Property: <see cref="DmiType030Property.InBoundConnection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey InBoundConnection => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.InBoundConnection);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BootIntegrityServicesEntryPoint: Contains the key definitions available for a type 031 [Boot Integrity Services (BIS) Entry Point] structure
        /// <summary>
        /// Contains the key definitions available for a type 031 [<see cref="DmiStructureClass.BootIntegrityServicesEntryPoint"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="DmiType031Property.Checksum"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Checksum => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.Checksum);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress16: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Entry point address bis 16bits.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="DmiType031Property.BisEntryPointAddress16"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress16 => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.BisEntryPointAddress16);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress32: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Entry point address bis 32bits.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint"/></description></item>
            ///   <item><description>Property: <see cref="DmiType031Property.BisEntryPointAddress32"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress32 => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.BisEntryPointAddress32);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemBoot: Contains the key definitions available for a type 032 [System Boot Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 032 [<see cref="DmiStructureClass.SystemBoot"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemBoot"/></description></item>
            ///   <item><description>Property: <see cref="DmiType032Property.Reserved"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Reserved => new PropertyKey(DmiStructureClass.SystemBoot, DmiType032Property.Reserved);
            #endregion

            #region [public] {static} (IPropertyKey) BootStatus: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Status and additional data fields that identify the boot status.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemBoot"/></description></item>
            ///   <item><description>Property: <see cref="DmiType032Property.BootStatus"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BootStatus => new PropertyKey(DmiStructureClass.SystemBoot, DmiType032Property.BootStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError64: Contains the key definitions available for a type 033 [64-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 033 [<see cref="DmiStructureClass.BitMemoryError64"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.ErrorType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorType => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Granularity (for example, device versus Partition) to which the error can be resolved.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.ErrorGranularity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorGranularity => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Memory access operation that caused the error.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.ErrorOperation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorOperation => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Vendor-specific ECC syndrome or CRC data associated with the erroneous access.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.VendorSyndrome"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorSyndrome => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error based on the addressing of the bus to which the memory array is connected.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.MemoryArrayErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MemoryArrayErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>32-bit physical address of the error relative to the start of the failing memory device, in bytes</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.DeviceErrorAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Range, in bytes, within which the error can be determined, when an error address is given</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.BitMemoryError64"/></description></item>
            ///   <item><description>Property: <see cref="DmiType033Property.ErrorResolution"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.Bytes"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ErrorResolution => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorResolution);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDevice: Contains the key definitions available for a type 034 [Management Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 034 [<see cref="DmiStructureClass.ManagementDevice"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType034Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Type: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device’s type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType034Property.Type"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Type => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Address: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Device’s address.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType034Property.Address"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Address => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Address);
            #endregion

            #region [public] {static} (IPropertyKey) AddressType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Type of addressing used to access the device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType034Property.AddressType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AddressType => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.AddressType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceComponent: Contains the key definitions available for a type 035 [Management Device Component] structure
        /// <summary>
        /// Contains the key definitions available for a type 035 [<see cref="DmiStructureClass.ManagementDeviceComponent"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType035Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) ManagementDeviceHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the Management Device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType035Property.ManagementDeviceHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ManagementDeviceHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ManagementDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ComponentHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the probe or cooling device that defines this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType035Property.ComponentHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ComponentHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ComponentHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ThresholdHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the device thresholds.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType035Property.ThresholdHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ThresholdHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ThresholdHandle);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceThresholdData: Contains the key definitions available for a type 036 [Management Device Threshold Data] structure
        /// <summary>
        /// Contains the key definitions available for a type 036 [<see cref="DmiStructureClass.ManagementDeviceThresholdData"/>] structure.
        /// </summary>
        public static class ManagementDeviceThresholdData
        {
            #region [public] {static} (IPropertyKey) LowerNonCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Lower non-critical threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.LowerNonCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerNonCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Upper non-critical threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.UpperNonCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperNonCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Lower critical threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.LowerCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperCritical: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Upper critical threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.LowerCritical"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerNonRecoverable: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Lower non-recoverable threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.LowerNonRecoverable"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey LowerNonRecoverable => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerNonRecoverable);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonRecoverable: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Upper non-recoverable threshold for this component.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData"/></description></item>
            ///   <item><description>Property: <see cref="DmiType036Property.UpperNonRecoverable"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey UpperNonRecoverable => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperNonRecoverable);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryChannel: Contains the key definitions available for a type 037 [Memory Channel] structure
        /// <summary>
        /// Contains the key definitions available for a type 037 [<see cref="DmiStructureClass.MemoryChannel"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="DmiType037Property.ChannelType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ChannelType => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.ChannelType);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumChannelLoad: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum load supported by the channel; the sum of all device loads cannot exceed this value.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="DmiType037Property.MaximumChannelLoad"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaximunChannelLoad => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.MaximumChannelLoad);
            #endregion

            #region [public] {static} (IPropertyKey) Devices: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Devices collection.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryChannel"/></description></item>
            ///   <item><description>Property: <see cref="DmiType037Property.Devices"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiMemoryChannelElementCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Devices => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Devices);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryChannel"/></description></item>
                ///   <item><description>Property: <see cref="DmiType037Property.Handle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Load: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Channel load provided by the memory device associated with this channel.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.MemoryChannel"/></description></item>
                ///   <item><description>Property: <see cref="DmiType037Property.Load"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Load => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Load);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) IpmiDevice: Contains the key definitions available for a type 038 [IPMI Device Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 038 [<see cref="DmiStructureClass.IpmiDevice"/> Information] structure.
        /// </summary>
        public static class IpmiDevice
        {
            #region [public] {static} (IPropertyKey) BaseAdress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>
            /// Base address (either memory-mapped or I/O) of the BMC. If the least-significant bit of the field is a 1,
            /// the address is in I/O space; otherwise, the address is memory-mapped.
            /// </para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.BaseAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ulong"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey BaseAddress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.BaseAddress);
            #endregion

            #region [public] {static} (IPropertyKey) NVStorageDeviceAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Bus ID of the NV storage device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.NvStorageDeviceAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey NVStorageDeviceAddress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.NvStorageDeviceAddress);
            #endregion

            #region [public] {static} (IPropertyKey) I2CSlaveAddress: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Slave address on the I2C bus of this BMC.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.I2CSlaveAddress"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey I2CSlaveAddress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.I2CSlaveAddress);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Baseboard Management Controller (BMC) interface type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.InterfaceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) InterruptNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Interrupt number for IPMI System Interface.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.InterfaceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterruptNumber => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.InterruptNumber);
            #endregion

            #region [public] {static} (IPropertyKey) SpecificationRevision: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>IPMI specification revision, in BCD format, to which the BMC was designed.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType038Property.SpecificationRevision"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SpecificationRevision => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.SpecificationRevision);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType038Property.RegisterSpacing"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey RegisterSpacing => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.RegisterSpacing);
                #endregion

                #region [public] {static} (IPropertyKey) LsBit: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>LS-bit for addresses.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType038Property.LsBit"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey LsBit => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.LsBit);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType038Property.Polarity"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Polarity => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.Polarity);
                #endregion

                #region [public] {static} (IPropertyKey) SpecifiedInfo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interrupt information specified.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType038Property.SpecifiedInfo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SpecifiedInfo => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.SpecifiedInfo);
                #endregion

                #region [public] {static} (IPropertyKey) TriggerMode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interrupt trigger mode.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.IpmiDevice"/></description></item>
                ///   <item><description>Property: <see cref="DmiType038Property.TriggerMode"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey TriggerMode => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.TriggerMode);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerSupply: Contains the key definitions available for a type 039 [System Power Supply] structure
        /// <summary>
        /// Contains the key definitions available for a type 039 [<see cref="DmiStructureClass.SystemPowerSupply"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.IsRedundant"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="bool"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey IsRedundant => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsRedundant);
            #endregion

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Identifies the location of the power supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.Location"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Names the power supply device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.DeviceName"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey DeviceName => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Names the company that manufactured the supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.Manufacturer"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the serial number for the power supply.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.SerialNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the asset tag number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.AssetTagNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey AssetTagNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.AssetTagNumber);
            #endregion

            #region [public] {static} (IPropertyKey) ModelPartNumber: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Contains the OEM part order number.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.ModelPartNumber"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ModelPartNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.ModelPartNumber);
            #endregion

            #region [public] {static} (IPropertyKey) RevisionLevel: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Power supply revision string.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.RevisionLevel"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey RevisionLevel => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.RevisionLevel);
            #endregion

            #region [public] {static} (IPropertyKey) MaxPowerCapacity: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Maximum sustained power output in Watts.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.MaxPowerCapacity"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.W"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MaxPowerCapacity => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.MaxPowerCapacity, PropertyUnit.W);
            #endregion

            #region [public] {static} (IPropertyKey) InputVoltageProbeHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of a voltage probe monitoring this power supply’s input voltage.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.InputVoltageProbeHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InputVoltageProbeHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputVoltageProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingDeviceHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of a cooling device associated with this power supply</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.CoolingDeviceHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey CoolingDeviceHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.CoolingDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) InputCurrentProbeHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, of the electrical current probe monitoring this power supply’s input current.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
            ///   <item><description>Property: <see cref="DmiType039Property.InputCurrentProbeHandle"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ushort"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InputCurrentProbeHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputCurrentProbeHandle);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.InputVoltageRange"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey InputVoltageRange => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputVoltageRange);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotReplaceable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is hot-replaceable.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.IsHotReplaceable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsHotReplaceable => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsHotReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) IsPlugged: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is plugged.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.IsPlugged"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsPlugged => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsPlugged);
                #endregion

                #region [public] {static} (IPropertyKey) IsPresent: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates whethe power supply is present.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.IsPresent"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsPresent => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsPresent);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Power supply status.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) SupplyType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Power supply type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.SystemPowerSupply"/></description></item>
                ///   <item><description>Property: <see cref="DmiType039Property.SupplyType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupplyType => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.SupplyType);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) AdditionalInformation: Contains the key definitions available for a type 040 [Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 040 [<see cref="DmiStructureClass.AdditionalInformation"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType040Property.Entries"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiAdditionalInformationEntryCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Entries => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.Entries);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="DmiType040Property.EntryLength"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey EntryLength => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.EntryLength);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedHandle: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Handle, or instance number, associated with the structure for which additional information is provided.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="DmiType040Property.ReferencedHandle"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ushort"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ReferencedHandle => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.ReferencedHandle);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedOffset: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Offset of the field within the structure referenced by the referenced handle for which additional information is provided.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="DmiType040Property.ReferencedOffset"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ReferencedOffset => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.ReferencedOffset);
                #endregion

                #region [public] {static} (IPropertyKey) StringValue: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Optional string to be associated with the field referenced by the referenced offset.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="DmiType040Property.StringValue"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey StringValue => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.StringValue);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.AdditionalInformation"/></description></item>
                ///   <item><description>Property: <see cref="DmiType040Property.Value"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey Value => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.Value);
                #endregion
            }
            #endregion

            #endregion            
        }
        #endregion

        #region [public] {static} (class) OnBoardDevicesExtended: Contains the key definitions available for a type 041 [OnBoard Devices Extended Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 041 [<see cref="DmiStructureClass.OnBoardDevicesExtended"/> Information] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended"/></description></item>
            ///   <item><description>Property: <see cref="DmiType041Property.ReferenceDesignation"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey ReferenceDesignation => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.ReferenceDesignation);
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
                ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended"/></description></item>
                ///   <item><description>Property: <see cref="DmiType041Property.DeviceType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) DeviceStatus: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Device status.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended"/></description></item>
                ///   <item><description>Property: <see cref="DmiType041Property.DeviceStatus"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey DeviceStatus => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.DeviceStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementControllerHostInterface: Contains the key definitions available for a type 042 [Management Controller Host Interface] structure
        /// <summary>
        /// Contains the key definitions available for a type 042 [<see cref="DmiStructureClass.ManagementControllerHostInterface"/>] structure.
        /// </summary>
        public static class ManagementControllerHostInterface
        {
            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property value value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Management Controller Interface Type.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="DmiType042Property.InterfaceType"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceTypeSpecificData: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Management Controller Host Interface Data as specified by the Interface Type.</para>
            /// <para>The format uses the '<b>Enterprise Number</b>' that is assigned and maintained by <b>IANA</b> (www.iana.org) as the means of identifying a particular vendor, company, or organization.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="DmiType042Property.InterfaceTypeSpecificData"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey InterfaceTypeSpecificData => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.InterfaceTypeSpecificData);
            #endregion

            #region [public] {static} (IPropertyKey) Protocols: Gets a value representing the key to retrieve the property value value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>A collection of possible values for the Protocol.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface"/></description></item>
            ///   <item><description>Property: <see cref="DmiType042Property.Protocols"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="DmiManagementControllerHostInterfaceProtocolRecordsCollection"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Protocols => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.Protocols);
            #endregion


            #region nested classes

            #region [public] {static} (class) Protocol: Contains the key definition for the 'Protocols' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Protocol
            {
                #region [public] {static} (IPropertyKey) ProtocolType: Gets a value representing the key to retrieve the property value value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Protocol type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface"/></description></item>
                ///   <item><description>Property: <see cref="DmiType042Property.ProtocolType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ProtocolType => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.ProtocolType);
                #endregion

                #region [public] {static} (IPropertyKey) ProtocolTypeSpecificData: Gets a value representing the key to retrieve the property value value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Protocol type specific data.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface"/></description></item>
                ///   <item><description>Property: <see cref="DmiType042Property.ProtocolTypeSpecificData"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/></para>
                /// </para>
                /// </summary>
                public static IPropertyKey ProtocolTypeSpecificData => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.ProtocolTypeSpecificData);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TpmDevice: Contains the key definitions available for a type 043 [Tpm Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 043 [<see cref="DmiStructureClass.TpmDevice"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.VendorId"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorId => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.VendorId);
            #endregion

            #region [public] {static} (IPropertyKey) VendorIdDescription: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Vendor Id description.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.VendorIdDescription"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey VendorIdDescription => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.VendorIdDescription);
            #endregion

            #region [public] {static} (IPropertyKey) MajorSpecVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Major TPM version supported by the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.MajorSpecVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MajorSpecVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.MajorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) MinorSpecVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Minor TPM version supported by the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.MinorSpecVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="byte"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey MinorSpecVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.MinorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>TPM firmware version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.FirmwareVersion"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="Tpm.TpmFirmwareVersion"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of descriptive information of the TPM device.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.Description"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>TPM device characteristics information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.Characteristics"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.Characteristics);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>OEM- or BIOS vendor-specific information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.TpmDevice"/></description></item>
            ///   <item><description>Property: <see cref="DmiType043Property.OemDefined"/></description></item>
            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
            ///  </list>
            /// </para>
            /// <para>
            ///  <para><b>Return Value</b></para>
            ///  <para>Type: <see cref="uint"/></para>
            /// </para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.OemDefined);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ProcessorAdditionalInformation: Contains the key definitions available for a type 044 [Processor Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 044 [<see cref="DmiStructureClass.ProcessorAdditionalInformation"/>] structure.
        /// </summary>
        public static class ProcessorAdditionalInformation
        {
            #region [public] {static} (IPropertyKey) ReferencedHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ProcessorAdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType044Property.ReferencedHandle"/></description></item>
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
            public static IPropertyKey ReferencedHandle => new PropertyKey(DmiStructureClass.ProcessorAdditionalInformation, DmiType044Property.ReferencedHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorSpecificBlock: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Processor-specific block.</para>
            /// <para>The format of processor-specific data varies between different processor architecture.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.ProcessorAdditionalInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType044Property.ProcessorSpecificBlock"/></description></item>
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
            public static IPropertyKey ProcessorSpecificBlock => new PropertyKey(DmiStructureClass.ProcessorAdditionalInformation, DmiType044Property.ProcessorSpecificBlock);
            #endregion
        }
        #endregion

        #region [public] {static} (class) FirmwareInventoryInformation: Contains the key definitions available for a type 045 [Firmware Inventory Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 045 [<see cref="DmiStructureClass.FirmwareInventoryInformation"/>] structure.
        /// </summary>
        public static class FirmwareInventoryInformation
        {
            #region version 3.5

            #region [public] {static} (IPropertyKey) FirmwareComponentName: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware Component Name.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareComponentName"/></description></item>
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
            public static IPropertyKey FirmwareComponentName => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareComponentName);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware Version of this firmware. The format of this value is defined by the Version Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareVersion"/></description></item>
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
            public static IPropertyKey FirmwareVersion => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersionFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the format of the Firmware Version and the Lowest Supported Firmware Version.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareVersionFormat"/></description></item>
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
            public static IPropertyKey FirmwareVersionFormat => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareVersionFormat);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the Firmware ID of this firmware. The format of this value is defined by the Firmware ID Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareId"/></description></item>
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
            public static IPropertyKey FirmwareId => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareId);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareIdFormat: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Describes the format of the Firmware ID.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareIdFormat"/></description></item>
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
            public static IPropertyKey FirmwareIdFormat => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareIdFormat);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareReleaseDate: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the firmware release date. The date string, if supplied, follows the Date-Time values format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareReleaseDate"/></description></item>
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
            public static IPropertyKey FirmwareReleaseDate => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareReleaseDate);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareManufacturer: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the firmware release date. The date string, if supplied, follows the Date-Time values format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareManufacturer"/></description></item>
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
            public static IPropertyKey FirmwareManufacturer => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareManufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) LowestSupportedFirmwareVersion: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>String number of the lowest version to which this firmware can be rolled back to. The format of this value is defined by the Version Format.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.LowestSupportedFirmwareVersion"/></description></item>
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
            public static IPropertyKey LowestSupportedFirmwareVersion => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.LowestSupportedFirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareImageSize: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Size of the firmware image that is currently programmed in the device, in bytes. If the Firmware Image Size is unknown, the field is set to FFFFFFFFFFFFFFFFh</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareImageSize"/></description></item>
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
            public static IPropertyKey FirmwareImageSize => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareImageSize, PropertyUnit.Bytes);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareCharacteristics: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Firmware characteristics information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareCharacteristics"/></description></item>
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
            public static IPropertyKey FirmwareCharacteristics => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareCharacteristics);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareState: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Firmware state information.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.FirmwareState"/></description></item>
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
            public static IPropertyKey FirmwareState => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.FirmwareState);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfAssociatedComponents: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Defines how many Associated Component Handles are associated with this firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.NumberOfAssociatedComponents"/></description></item>
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
            public static IPropertyKey NumberOfAssociatedComponents => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.NumberOfAssociatedComponents);
            #endregion

            #region [public] {static} (IPropertyKey) AssociatedComponentHandles: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Lists the <b>SMBIOS</b> structure handles that are associated with this firmware.</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.FirmwareInventoryInformation"/></description></item>
            ///   <item><description>Property: <see cref="DmiType045Property.AssociatedComponentHandles"/></description></item>
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
            public static IPropertyKey AssociatedComponentHandles => new PropertyKey(DmiStructureClass.FirmwareInventoryInformation, DmiType045Property.AssociatedComponentHandles);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) StringProperty: Contains the key definitions available for a type 046 [String Property] structure
        /// <summary>
        /// Contains the key definitions available for a type 046 [<see cref="DmiStructureClass.StringProperty"/>] structure.
        /// </summary>
        public static class StringProperty
        {
            #region version 3.5

            #region [public] {static} (IPropertyKey) PropertyId: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="DmiType046Property.PropertyId"/></description></item>
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
            public static IPropertyKey PropertyId => new PropertyKey(DmiStructureClass.StringProperty, DmiType046Property.PropertyId);
            #endregion

            #region [public] {static} (IPropertyKey) PropertyValue: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="DmiType046Property.PropertyValue"/></description></item>
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
            public static IPropertyKey PropertyValue => new PropertyKey(DmiStructureClass.StringProperty, DmiType046Property.PropertyValue);
            #endregion

            #region [public] {static} (IPropertyKey) ParentHandle: Gets a value representing the key to retrieve the property value
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property value.</para>
            /// <para>Handle, or instance number, associated with the processor structure (Type 004).</para>
            /// <para>
            ///  <para><b>Key Composition</b></para>
            ///  <list type="bullet">
            ///   <item><description>Structure: <see cref="DmiStructureClass.StringProperty"/></description></item>
            ///   <item><description>Property: <see cref="DmiType046Property.ParentHandle"/></description></item>
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
            public static IPropertyKey ParentHandle => new PropertyKey(DmiStructureClass.StringProperty, DmiType046Property.ParentHandle);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Inactive: Contains the key definitions available for a type 126 [Inactive] structure
        /// <summary>
        /// Contains the key definitions available for a type 126 [<see cref="DmiStructureClass.Inactive"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.Inactive"/></description></item>
            ///   <item><description>Property: <see cref="DmiType126Property.Description"/></description></item>
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
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.Inactive, DmiType126Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) EndOfTable: Contains the key definitions available for a type 127 [End-Of-Table] structure
        /// <summary>
        /// Contains the key definitions available for a type 127 [<see cref="DmiStructureClass.EndOfTable"/>] structure.
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
            ///   <item><description>Structure: <see cref="DmiStructureClass.EndOfTable"/></description></item>
            ///   <item><description>Property: <see cref="DmiType127Property.Status"/></description></item>
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
            public static IPropertyKey Status => new PropertyKey(DmiStructureClass.EndOfTable, DmiType127Property.Status);
            #endregion
        }
        #endregion
    }
}
